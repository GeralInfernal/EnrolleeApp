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
    public partial class Form_Change_Komis : Form
    {
        public Form_Change_Komis()
        {
            InitializeComponent();
        }

        private DataTable dtKomis;

        private void Form_Update_Komis_Load(object sender, EventArgs e)
        {
            cbKomis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbKomis_Fill();
        }
        private void cbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbId.Text = dtKomis.Rows[cbKomis.SelectedIndex][1].ToString();
            tbKomisName.Text = dtKomis.Rows[cbKomis.SelectedIndex][0].ToString();
        }

        private void cbKomis_Fill()
        {
            MainForm.DB.RunQuery("Select K_FIO, K_id from komis order by K_FIO asc; ", out dtKomis);

            foreach (DataRow i in dtKomis.Rows)
            {
                cbKomis.Items.Add(i[0].ToString());
            }
            if (cbKomis.Items.Count != 0) cbKomis.SelectedIndex = 0;
        }

        private int Find_Discipline_id()
        {
            foreach (DataRow i in dtKomis.Rows)
            {
                if (cbKomis.Text == i[0].ToString())
                {
                    return Convert.ToInt32(i[1]);
                }
            }
            return -1;
        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbKomisName.Text.Length > 50) { errorProvider.SetError(tbKomisName, "ФИО должно быть не более 50 символов!"); ret_val = false; }

                if (tbKomisName.Text.Length == 0) { errorProvider.SetError(tbKomisName, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string sql = "UPDATE komis SET K_FIO = '" + tbKomisName.Text + "' WHERE K_id = " + tbId.Text + ";";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменен член комиссии", cbKomis.Text + " на " + tbKomisName.Text);
                MessageBox.Show("Член комиссии успешно изменен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось изменить указанного члена комиссии!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
