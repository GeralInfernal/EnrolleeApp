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
    public partial class Form_Add_Polity : Form
    {
        public Form_Add_Polity()
        {
            InitializeComponent();
        }

        private void Form_Add_Polity_Load(object sender, EventArgs e)
        {

        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbPolityName.Text.Length > 40) { errorProvider.SetError(tbPolityName, "Название государства должно быть не более 40 символов!"); ret_val = false; }

                if (tbPolityName.Text.Length == 0) { errorProvider.SetError(tbPolityName, "Заполните это поле!"); ret_val = false; }
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

            string sql = "INSERT INTO polity(Pol_title) VALUES ('" + tbPolityName.Text + "');";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлено государство", tbPolityName.Text);
                MessageBox.Show("Государство успешно добавлено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить государство!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
