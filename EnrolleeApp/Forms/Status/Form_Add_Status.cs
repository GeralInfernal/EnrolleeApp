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
    public partial class Form_Add_Status : Form
    {
        public Form_Add_Status()
        {
            InitializeComponent();
        }

        private DataTable data_table;

        private void Form_Add_Status_Load(object sender, EventArgs e)
        {
            cbAbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAbit_Fill();
        }

        private void cbAbit_Fill()
        {
            MainForm.DB.RunQuery("Select FIO, id from abit order by FIO asc; ", out data_table);

            foreach (DataRow i in data_table.Rows)
            {
                cbAbit.Items.Add(i[0].ToString());
            }
            if (cbAbit.Items.Count != 0) cbAbit.SelectedIndex = 0;
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
                if (tbStatusType.Text.Length > 20) { errorProvider.SetError(tbStatusType, "Статус должен быть не более 20 символов!"); ret_val = false; }
                if (tbDocinform.Text.Length > 100) { errorProvider.SetError(tbDocinform, "Информация из документа должена быть не более 100 символов!"); ret_val = false; }

                if (tbStatusType.Text.Length == 0) { errorProvider.SetError(tbStatusType, "Заполните это поле!"); ret_val = false; }
                if (tbDocinform.Text.Length == 0) { errorProvider.SetError(tbDocinform, "Заполните это поле!"); ret_val = false; }
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
            if (abit_id == -1)
            {
                errorProvider.SetError(cbAbit, "Выберите абитуринта!");
                return;
            }
            string sql = "INSERT INTO status(St_abit, St_type, St_docinform) " +
                "VALUES (" + abit_id + ", '" + tbStatusType.Text + "', '" + tbDocinform.Text + "');";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлен статус", cbAbit.Text + " " + tbStatusType.Text);
                MessageBox.Show("Cтатус успешно добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить статус!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
