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
    public partial class Form_AddStatus : Form
    {
        public Form_AddStatus()
        {
            InitializeComponent();
        }

        DataTable data_table;

        private void Form_AddParent_Load(object sender, EventArgs e)
        {
            cbAbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAbit_Fill();
        }

        private void cbAbit_Fill()
        {
            MainForm.DB.RunQuery("Select FIO, id from abit order by FIO asc; ", out data_table);
            
            foreach(DataRow i in data_table.Rows)
            {
                cbAbit.Items.Add(i[0].ToString());
            }
            if(cbAbit.Items.Count != 0) cbAbit.SelectedIndex = 0;
        }

        private int Find_id()
        {
            foreach (DataRow i in data_table.Rows)
            {
                if (cbAbit.Text == i[0].ToString())
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
                if (tbParentFIO.Text.Length > 50) { errorProvider.SetError(tbParentFIO, "ФИО должно быть не более 50 символов!"); ret_val = false; }
                if (tbAdrReg.Text.Length > 80) { errorProvider.SetError(tbAdrReg, "Адрес регистрации должен быть не более 80 символов!"); ret_val = false; }
                if (tbAdrFact.Text.Length > 80) { errorProvider.SetError(tbAdrFact, "Адрес проживания должен быть не более 80 символов"); ret_val = false; }
                if (tbWorkpost.Text.Length > 80) { errorProvider.SetError(tbWorkpost, "Место работы должно быть не более 80 символов"); }
                if (tbPhone.Text.Length > 20) { errorProvider.SetError(tbPhone, "Телефон должен быть не более 80 символов!"); ret_val = false; }

                if (tbParentFIO.Text.Length == 0) { errorProvider.SetError(tbParentFIO, "Заполните это поле!"); ret_val = false; }
                if (tbAdrReg.Text.Length == 0) { errorProvider.SetError(tbAdrReg, "Заполните это поле!"); ret_val = false; }
                if (tbAdrFact.Text.Length == 0) { errorProvider.SetError(tbAdrFact, "Заполните это поле!"); ret_val = false; }
                if (tbWorkpost.Text.Length == 0) { errorProvider.SetError(tbWorkpost, "Заполните это поле!"); }
                if (tbPhone.Text.Length == 0) { errorProvider.SetError(tbPhone, "Заполните это поле!"); ret_val = false; }
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

            int abit_id = Find_id();
            if(abit_id == -1)
            {
                errorProvider.SetError(cbAbit, "Выберите абитуринта!");
                return;
            }

            string sql = "INSERT INTO Parent(P_abit, P_FIO, P_adrreg, P_adrfact, P_workpost, P_phone) " +
                "VALUES (" + abit_id.ToString() + ", '" + tbParentFIO.Text + "', '" + tbAdrReg.Text + "', '" +
                tbAdrFact.Text + "', '" + tbWorkpost.Text + "', '" + tbPhone.Text + "');";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлен родитель", tbParentFIO.Text + " " + tbAdrReg.Text + " " + tbAdrFact.Text + " " + tbWorkpost.Text + " " + tbPhone.Text);
                MessageBox.Show("Родитель успешно добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить родителя", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
