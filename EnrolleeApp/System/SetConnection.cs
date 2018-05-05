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
    public partial class SetConnection : Form
    {
        public SetConnection()
        {
            InitializeComponent();
        }

        private DialogResult result = DialogResult.Cancel;
        private DataTable data_table;
        private string current_preset;

        private void SetConnection_Load(object sender, EventArgs e)
        {
            MainForm.LocalDB.Get_curr_preset_id(out current_preset);
            MainForm.LocalDB.RunQuery("SELECT p_id, p_name, p_serv, p_user, p_db, p_port, p_pass, p_auto FROM connections; ", out data_table);

            cbPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbPresets_Fill();
            SelectCurrConn();
        }

        private void SelectCurrConn()
        {
            if (cbPresets.Items.Count != 0)
            {
                foreach (DataRow i in data_table.Rows)
                {
                    if (current_preset == i[0].ToString())
                    {
                        cbPresets.SelectedItem = i[1].ToString();
                    }
                }
            }
        }

        private void cbShowSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowSymbols.Checked) { tbPass.UseSystemPasswordChar = false; }
            else { tbPass.UseSystemPasswordChar = true; }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (MainForm.DB.ConnectToDatabase(tbServer.Text, tbUser.Text, tbDB.Text, tbPort.Text, tbPass.Text))
            {
                MessageBox.Show("Подключение успешно установлено!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm.LocalDB.Add_log("Подключение к базе данных", tbServer.Text + "; " + tbUser.Text + "; " + tbDB.Text + "; " + tbPort.Text + "; ");
                result = DialogResult.OK;

                this.Close();
            }
        }

        private void cbPresets_Fill()
        {
            cbPresets.Items.Clear();
            foreach (DataRow i in data_table.Rows)
            {
                cbPresets.Items.Add(i[1].ToString());
            }
        }

        private void cbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow i in data_table.Rows)
            {
                if (cbPresets.SelectedItem.ToString() == i[1].ToString())
                {
                    tbServer.Text = i[2].ToString();
                    tbUser.Text = i[3].ToString();
                    tbDB.Text = i[4].ToString();
                    tbPort.Text = i[5].ToString();
                    tbPass.Text = i[6].ToString();
                }
            }
        }

        private void btnSetPresets_Click(object sender, EventArgs e)
        {
            Presets pr = new Presets();
            pr.ShowDialog();

            cbPresets_Fill();
            SelectCurrConn();
        }
        private void SetConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
