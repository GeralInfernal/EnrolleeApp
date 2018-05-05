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
    public partial class AddPreset : Form
    {
        public AddPreset()
        {
            InitializeComponent();
        }

        private DialogResult result = DialogResult.Cancel;

        private void cbShowSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowSymbols.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string autoconn;
            if (cbAutoConn.Checked) { autoconn = "1"; }
            else { autoconn = "0"; }
            if(!MainForm.LocalDB.Add_preset(tbPreset.Text, tbServer.Text, tbUser.Text, tbDB.Text, tbPort.Text, tbPass.Text, autoconn)) return;
            MainForm.LocalDB.Add_log("Создание набора настроек", tbPreset.Text + "; " + tbServer.Text + "; " + tbUser.Text + "; " + tbDB.Text + "; " + tbPort.Text + "; ");
            result = DialogResult.OK;

            this.Close();
        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbPreset.Text.Length > 100) { errorProvider.SetError(tbPreset, "Название набора быть меньше 100 символов!"); ret_val = false; }
                if (tbPreset.Text.Length == 0) { errorProvider.SetError(tbPreset, "Заполните это поле!"); ret_val = false; }
                if (tbServer.Text.Length > 200) { errorProvider.SetError(tbServer, "Адрес должен быть меньше 200 символов!"); ret_val = false; }
                if (tbServer.Text.Length == 0) { errorProvider.SetError(tbServer, "Заполните это поле!"); }
                if (tbUser.Text.Length > 50) { errorProvider.SetError(tbUser, "Имя пользователя должно быть меньше 50 символов!"); ret_val = false; }
                if (tbUser.Text.Length == 0) { errorProvider.SetError(tbUser, "Заполните это поле!"); ret_val = false; }
                if (tbDB.Text.Length > 30) { errorProvider.SetError(tbDB, "Имя базы данных должно быть меньше 30 символов!"); ret_val = false; }
                if (tbDB.Text.Length == 0) { errorProvider.SetError(tbDB, "Заполните это поле!"); ret_val = false; }
                if (tbPort.Text.Length == 0) { errorProvider.SetError(tbPort, "Заполните это поле!"); ret_val = false; }
                if (tbPass.Text.Length > 100) { errorProvider.SetError(tbPass, "Пароль должен быть меньше 100 символов"); ret_val = false; }
                if (tbPass.Text.Length == 0) { errorProvider.SetError(tbPass, "Заполните это поле!"); ret_val = false; }
                if (Convert.ToInt32(tbPort.Text) < 0 || Convert.ToInt32(tbPort.Text) > 65536) { errorProvider.SetError(tbPort, "Порт указан неверно!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                errorProvider.SetError(tbPort, "Порт указан неверно!");
                MessageBox.Show("Порт указан неверно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPreset_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
