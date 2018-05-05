using System;
using System.Windows.Forms;

namespace EnrolleeApp
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        
        delegate bool PassCheck(string str);
        private int counter = 0;
        private DialogResult result = DialogResult.Cancel;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PassCheck pc_admin = new PassCheck((MainForm.LocalDB.CheckPassword_Admin));
            PassCheck pc_user = new PassCheck((MainForm.LocalDB.CheckPassword_User));
            counter++;
            if (pc_admin(tbPassword.Text)) 
            {
                result = DialogResult.Yes;
                MainForm.LocalDB.Add_log("Авторизация администратора", "Попытки авторизации: " + Convert.ToString(counter));
                this.Close();
            }
            else
            {
                if (pc_user(tbPassword.Text))
                {
                    result = DialogResult.No;
                    MainForm.LocalDB.Add_log("Авторизация пользователя", "Попытки авторизации: " + Convert.ToString(counter));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPassword.Focus();
                }
            };
        }

        private void cbShowSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowSymbols.Checked) { tbPassword.UseSystemPasswordChar = false; }
            else { tbPassword.UseSystemPasswordChar = true; }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.LocalDB.Add_log("Отмена авторизации", "Попытки авторизации: " + Convert.ToString(counter));
            this.DialogResult = result;
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}
