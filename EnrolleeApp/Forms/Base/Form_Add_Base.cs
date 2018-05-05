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
    public partial class Form_Add_Base : Form
    {
        public Form_Add_Base()
        {
            InitializeComponent();
        }

        private void Form_Add_Base_Load(object sender, EventArgs e)
        {

        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbBaseName.Text.Length > 80) { errorProvider.SetError(tbBaseName, "Название дисцилины должно быть не более 80 символов!"); ret_val = false; }

                if (tbBaseName.Text.Length == 0) { errorProvider.SetError(tbBaseName, "Заполните это поле!"); ret_val = false; }
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

            string sql = "INSERT INTO base(B_title) VALUES ('" + tbBaseName.Text + "');";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлена база образования", tbBaseName.Text);
                MessageBox.Show("База образования успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить базу образования!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
