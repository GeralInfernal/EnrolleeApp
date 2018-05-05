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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void cbShowSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowSymbols.Checked)
            {
                tbOldPass.UseSystemPasswordChar = false;
                tbNewPass.UseSystemPasswordChar = false;
                tbNewPassConf.UseSystemPasswordChar = false;
            }
            else
            {
                tbOldPass.UseSystemPasswordChar = true;
                tbNewPass.UseSystemPasswordChar = true;
                tbNewPassConf.UseSystemPasswordChar = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckFields()) return;

            if (MainForm.LocalDB.SetPassword_Admin(tbNewPass.Text))
            {
                MessageBox.Show("Пароль успешно изменен!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MainForm.LocalDB.Add_log("Смена пароля", "Пароль успешно изменен!");
            }
            else
            {
                MessageBox.Show("Произошла непредвиденная ошибка!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainForm.LocalDB.Add_log("Смена пароля", "Произошла непредвиденная ошибка!");
            }
        }

        private bool CheckFields()
        {
            try
            {
                errorProvider.Dispose();

                if (tbOldPass.Text.Length < 4 || tbOldPass.Text.Length > 32)
                {
                    errorProvider.SetError(tbOldPass, "Пароль должен содержать не менее 4 символов и не более 32!");
                    throw new ApplicationException("Неверный диапазон ввода!");
                }
                if (tbNewPass.Text.Length < 4 || tbNewPass.Text.Length > 32)
                {
                    errorProvider.SetError(tbNewPass, "Пароль должен содержате не менее 4 символов и не более 32!");
                    throw new ApplicationException("Неверный диапазон ввода!");
                }
                if (tbNewPassConf.Text.Length < 4 || tbNewPassConf.Text.Length > 32)
                {
                    errorProvider.SetError(tbNewPassConf, "Пароль должен содержать не менее 4 символов и не более 32!");
                    throw new ApplicationException("Неверный диапазон ввода!");
                }

                if(tbNewPass.Text != tbNewPassConf.Text)
                {
                    errorProvider.SetError(tbNewPassConf, "Пароли не совпадают!");
                    throw new ApplicationException("Пароли не совпадают!");
                }
                if (!MainForm.LocalDB.CheckPassword_Admin(tbOldPass.Text))
                {
                    errorProvider.SetError(tbOldPass, "Указан неверный пароль!");
                    throw new ApplicationException("Указан неверный пароль!");
                }
                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainForm.LocalDB.Add_log("Смена пароля", ex.Message);
                return false;
            }
        }
    }
}
