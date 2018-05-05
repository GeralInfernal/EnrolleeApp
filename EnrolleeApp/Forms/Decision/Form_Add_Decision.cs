using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeApp
{
    public partial class Form_Add_Decision : Form
    {
        public Form_Add_Decision()
        {
            InitializeComponent();
        }

        private DataTable dtAbit;
        private DataTable dtKomis;
        private DataTable dtGroup;

        private bool initialized = false;
        private string abit;
        private string group;

        public void FieldsIni(string abit, string group)
        {
            this.abit = abit;
            this.group = group;
            initialized = true;
        }

        private void Form_Add_Decision_Load(object sender, EventArgs e)
        {
            if (initialized == false)
            {
                cbAbit_Fill();
                cbKomis_Fill();
                cbGroup_Fill();
                if (cbAbit.Items.Count != 0) cbAbit.SelectedIndex = 0;
                if (cbKomis.Items.Count != 0) cbKomis.SelectedIndex = 0;
                if (cbGroup.Items.Count != 0) cbGroup.SelectedIndex = 0;
                dtpDate.Value = DateTime.Now;
            }
            else
            {
                cbAbit_Fill();
                cbKomis_Fill();
                cbGroup_Fill();
                if (cbAbit.Items.Count != 0) cbAbit.SelectedItem = abit;
                if (cbKomis.Items.Count != 0) cbKomis.SelectedIndex = 0;
                if (cbGroup.Items.Count != 0) cbGroup.SelectedItem = group;
                dtpDate.Value = DateTime.Now;
            }

        }

        private void cbAbit_Fill()
        {
            MainForm.DB.RunQuery("select FIO, id from abit order by FIO asc; ", out dtAbit);

            foreach (DataRow i in dtAbit.Rows)
            {
                cbAbit.Items.Add(i[0].ToString());
            }
        }

        private void cbKomis_Fill()
        {
            MainForm.DB.RunQuery("select K_FIO, K_id from komis order by K_FIO asc; ", out dtKomis);

            foreach (DataRow i in dtKomis.Rows)
            {
                cbKomis.Items.Add(i[0].ToString());
            }
        }

        private void cbGroup_Fill()
        {
            MainForm.DB.RunQuery("select gr_name, gr_id from groups order by gr_name asc; ", out dtGroup);

            cbGroup.Items.Add("Нет");

            foreach (DataRow i in dtGroup.Rows)
            {
                cbGroup.Items.Add(i[0].ToString());
            }
        }

        private string Find_abit_id()
        {
            foreach (DataRow i in dtAbit.Rows)
            {
                if (cbAbit.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private string Find_komis_id()
        {
            foreach (DataRow i in dtKomis.Rows)
            {
                if (cbKomis.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private string Find_group_id()
        {
            foreach (DataRow i in dtGroup.Rows)
            {
                if (cbGroup.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbResolution.Text.Length > 20) { errorProvider.SetError(tbResolution, "Решение должено быть не более 20 символов!"); ret_val = false; }
                if (tbComment.Text.Length > 100) { errorProvider.SetError(tbComment, "Комментарий должен быть не более 100 символов!"); ret_val = false; }

                if (tbResolution.Text.Length == 0) { errorProvider.SetError(tbResolution, "Заполните это поле!"); ret_val = false; }
                if (tbComment.Text.Length == 0) { errorProvider.SetError(tbComment, "Заполните это поле!"); ret_val = false; }
                if (cbAbit.Text.Length == 0) { errorProvider.SetError(cbAbit, "Заполните это поле!"); ret_val = false; }
                if (cbKomis.Text.Length == 0) { errorProvider.SetError(cbKomis, "Заполните это поле!"); ret_val = false; }
                if (cbGroup.Text.Length == 0) { errorProvider.SetError(cbGroup, "Заполните это поле!"); ret_val = false; }

                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string abit_id = Find_abit_id();
            if (abit_id == "-1")
            {
                errorProvider.SetError(cbAbit, "Выберите абитуринта!");
                return;
            }

            string komis_id = Find_komis_id();
            if (komis_id == "-1")
            {
                errorProvider.SetError(cbKomis, "Выберите члена комиссии!");
                return;
            }

            string group_id = Find_group_id();
            if (komis_id == "-1")
            {
                if (cbGroup.Text == "Нет")
                {
                    group_id = "NULL";
                }
                else
                {
                    errorProvider.SetError(cbGroup, "Выберите группу!");
                    return;
                }
            }

            string date = dtpDate.Value.Year.ToString() + "-" + dtpDate.Value.Month.ToString() + "-" + dtpDate.Value.Day.ToString();

            string sql = "INSERT INTO Decision(Des_abit, Des_group, Des_resolution, Comment, Des_date, Des_komis) " +
                " values( " + abit_id.ToString() + ", " + group_id + ", '" + tbResolution.Text + "', '" + tbComment.Text + "', '" + 
                date + "', " + komis_id.ToString() + "); ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлено решение комиссии", abit_id.ToString() + "" + tbResolution.Text + " " + tbComment.Text);
                MessageBox.Show("Решение комиссии успешно добавлено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить решение комиссии!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
