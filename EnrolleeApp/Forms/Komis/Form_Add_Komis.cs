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
    public partial class Form_Add_Komis : Form
    {
        public Form_Add_Komis()
        {
            InitializeComponent();
        }


        private void Form_Add_Komis_Load(object sender, EventArgs e)
        {

        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbKomisFIO.Text.Length > 50) { errorProvider.SetError(tbKomisFIO, "ФИО должно быть не более 50 символов!"); ret_val = false; }

                if (tbKomisFIO.Text.Length == 0) { errorProvider.SetError(tbKomisFIO, "Заполните это поле!"); ret_val = false; }
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

            string sql = "INSERT INTO komis(K_FIO) VALUES ('" + tbKomisFIO.Text + "');";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлен член комиссии", tbKomisFIO.Text);
                MessageBox.Show("Член комиссии успешно добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить члена комиссии!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
