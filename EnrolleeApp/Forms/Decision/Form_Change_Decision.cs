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
    public partial class Form_Update_Decision : Form
    {
        public Form_Update_Decision()
        {
            InitializeComponent();
        }

        private DataTable dtAbit;
        private DataTable dtKomis;
        private DataTable dtGroup;

        private void Form_Change_Decision_Load(object sender, EventArgs e)
        {
            cbKomis_Fill();
            cbAbit_Fill();
            cbGroup_Fill();
            dtpDate.Value = DateTime.Now;
        }
        private void cbAbit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string abit_id = Find_abit_id();
            if (abit_id == "-1")
            {
                return;
            }

            DataTable dt;
            MainForm.DB.RunQuery("select decision.Des_id, groups.gr_name, decision.Des_resolution, " +
                "decision.Comment, decision.Des_date, komis.K_FIO " +
                "from decision " +
                "LEFT JOIN komis ON(komis.K_id = decision.Des_komis) " +
                "LEFT JOIN groups ON(groups.gr_id = decision.Des_komis) " +
                "where Des_abit = " + abit_id + "; ", out dt);

            tbID.Text = dt.Rows[0][0].ToString();
            cbGroup.SelectedItem = dt.Rows[0][1].ToString();
            tbResolution.Text = dt.Rows[0][2].ToString();
            tbComment.Text = dt.Rows[0][3].ToString();
            dtpDate.Value = DateTime.Parse(dt.Rows[0][4].ToString());
            cbKomis.SelectedItem = dt.Rows[0][5].ToString();
        }

        private void cbAbit_Fill()
        {
            MainForm.DB.RunQuery("select abit.FIO, abit.id from decision " +
                "LEFT JOIN abit ON (abit.id = decision.Des_abit) " +
                "order by abit.FIO asc; ", out dtAbit);

            foreach (DataRow i in dtAbit.Rows)
            {
                cbAbit.Items.Add(i[0].ToString());
            }
            if (cbAbit.Items.Count != 0) cbAbit.SelectedIndex = 0;
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
            string sql = "UPDATE decision " +
                "SET Des_abit = " + abit_id + ", Des_group = " + group_id + ", Des_resolution = '" + tbResolution.Text + "', " +
                "Comment = '" + tbResolution.Text + "', Des_date = '" + date + "', Des_komis = '" + komis_id + "' " +
                "where decision.Des_id = " + tbID.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменено решение комиссии", abit_id + "" + tbResolution.Text);
                MessageBox.Show("Решение комиссии успешно изменено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось изменить решение комиссии!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
