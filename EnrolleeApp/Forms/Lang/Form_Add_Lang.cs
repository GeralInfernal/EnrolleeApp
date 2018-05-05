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
    public partial class Form_Add_Lang : Form
    {
        public Form_Add_Lang()
        {
            InitializeComponent();
        }

        private void Form_Add_Lang_Load(object sender, EventArgs e)
        {

        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbLangName.Text.Length > 40) { errorProvider.SetError(tbLangName, "Название иностранного языка должно быть не более 40 символов!"); ret_val = false; }

                if (tbLangName.Text.Length == 0) { errorProvider.SetError(tbLangName, "Заполните это поле!"); ret_val = false; }
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

            string sql = "INSERT INTO lang(L_title) VALUES ('" + tbLangName.Text + "');";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлен иностранный язык", tbLangName.Text);
                MessageBox.Show("Иностранный язык успешно добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить иностранный язык!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
