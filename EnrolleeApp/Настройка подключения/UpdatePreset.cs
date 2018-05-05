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
    public partial class UpdatePreset : Form
    {
        public UpdatePreset(string p_id)
        {
            InitializeComponent();
            id = p_id;
        }
   
        private string id;
        private DialogResult result = DialogResult.Cancel;

        private void UpdatePreset_Load(object sender, EventArgs e)
        {

            DataTable dt;
            MainForm.LocalDB.RunQuery("select p_name, p_serv, p_user, p_db, p_port, p_pass, p_auto from connections where p_id = '" + id + "'; ", out dt);
            foreach (DataRow i in dt.Rows)
            {
                tbPreset.Text = i[0].ToString();
                tbServer.Text = i[1].ToString();
                tbUser.Text = i[2].ToString();
                tbDB.Text = i[3].ToString();
                tbPort.Text = i[4].ToString();
                tbPass.Text = i[5].ToString();
                if(Convert.ToInt32(i[6].ToString()) == 1) { cbAutoConn.Checked = true; }
                else { cbAutoConn.Checked = false; }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string autoconn;
            if (cbAutoConn.Checked) { autoconn = "1"; }
            else { autoconn = "0"; }
            if(!MainForm.LocalDB.Update_preset(id,tbPreset.Text, tbServer.Text, tbUser.Text, tbDB.Text, tbPort.Text, tbPass.Text, autoconn)) return;
            MainForm.LocalDB.Add_log("Обновление набора настроек", id + "; " + tbPreset.Text + "; " + tbServer.Text + "; " + tbUser.Text + "; " + tbDB.Text + "; " + tbPort.Text + "; ");
            result = DialogResult.OK;

            this.Close();
        }

        private void cbShowSymbols_Click(object sender, EventArgs e)
        {
            if (cbShowSymbols.Checked) { tbPass.UseSystemPasswordChar = false; }
            else { tbPass.UseSystemPasswordChar = true; }
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

        private void UpdatePreset_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
