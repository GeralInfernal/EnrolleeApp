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
    public partial class Presets : Form
    {
        public Presets()
        {
            InitializeComponent();
        }

        private int active_conn;

        private void Presets_Load(object sender, EventArgs e)
        {
            Fill_dgvPresets();
        }

        private void Fill_dgvPresets()
        {
            dgvPresets.Rows.Clear();
            DataTable dt;
            MainForm.LocalDB.Get_connections(out dt);
            foreach (DataRow i in dt.Rows)
            {
                string str;
                if (Convert.ToInt32(i[7]) == 0) { str = "Нет"; }
                else { str = "Да"; }
                dgvPresets.Rows.Add(i[0].ToString(), i[1].ToString(), i[2].ToString(), i[3].ToString(), i[4].ToString(), i[5].ToString(), i[6].ToString(), str);
            }
            string curr;
            MainForm.LocalDB.Get_curr_preset_id(out curr);
            foreach (DataGridViewRow i in dgvPresets.Rows)
            {
                if(i.Cells[0].Value.ToString() == curr)
                {
                    active_conn = i.Index;
                    foreach (DataGridViewCell j in i.Cells)
                    {
                        j.Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPreset ap = new AddPreset();
            if(ap.ShowDialog() == DialogResult.Cancel) return;

            Fill_dgvPresets();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPresets.Rows.Count == 0) return;
            UpdatePreset up = new UpdatePreset(Convert.ToString(dgvPresets.SelectedRows[0].Cells[0].Value));
            if (up.ShowDialog() == DialogResult.Cancel) return;

            Fill_dgvPresets();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPresets.Rows.Count == 0) return;
            if(dgvPresets.SelectedRows[0].Index == active_conn)
            {
                MessageBox.Show("Нельзя удалить текущее соединение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Вы точно хотите удалить этот набор настроек?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                if (MainForm.LocalDB.Delete_preset(Convert.ToString(dgvPresets.SelectedRows[0].Cells[0].Value)))
                {
                    MainForm.LocalDB.Add_log("Удаление набора настроек", Convert.ToString(dgvPresets.SelectedRows[0].Cells[0].Value) +
                        Convert.ToString(dgvPresets.SelectedRows[0].Cells[1].Value) + Convert.ToString(dgvPresets.SelectedRows[0].Cells[3].Value) +
                        Convert.ToString(dgvPresets.SelectedRows[0].Cells[4].Value) + Convert.ToString(dgvPresets.SelectedRows[0].Cells[5].Value));
                    dgvPresets.Rows.Remove(dgvPresets.SelectedRows[0]);
                }
            }
        }

        #region правка
        private void tsmiShowID_Click(object sender, EventArgs e)
        {
            if (tsmiShowID.Checked)
            {
                tsmiShowID.Checked = false;
                dgvPresets.Columns["p_id"].Visible = false;
            }
            else
            {
                tsmiShowID.Checked = true;
                dgvPresets.Columns["p_id"].Visible = true;
            }
        }

        private void tsmiShowPass_Click(object sender, EventArgs e)
        {
            if (tsmiShowPass.Checked)
            {
                tsmiShowPass.Checked = false;
                dgvPresets.Columns["p_pass"].Visible = false;
            }
            else
            {
                tsmiShowPass.Checked = true;
                dgvPresets.Columns["p_pass"].Visible = true;
            }
        }

        private void tsmiActivatePreset_Click(object sender, EventArgs e)
        {
            btnActivate_Click(this, new EventArgs());
        }

        #endregion

        private void btnActivate_Click(object sender, EventArgs e)
        {
            //обесцвечиваю текущее подключение
            foreach (DataGridViewCell i in dgvPresets.Rows[active_conn].Cells)
            {
                i.Style.BackColor = Color.White;
            }

            //фиксирую изменение в БД
            if (!MainForm.LocalDB.Set_curr_preset(dgvPresets.SelectedRows[0].Cells[0].Value.ToString())) return;

            //крашу новое подключение
            foreach (DataGridViewCell j in dgvPresets.SelectedRows[0].Cells)
            {
                active_conn = dgvPresets.SelectedRows[0].Index;
                j.Style.BackColor = Color.Red;
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            sfdSavePresets.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            if (sfdSavePresets.ShowDialog() == DialogResult.OK)
            {
                string[] str = new string[dgvPresets.Rows.Count];
                int ind = 0;
                foreach (DataGridViewRow i in dgvPresets.Rows)
                {
                    foreach (DataGridViewCell j in i.Cells)
                    {
                        str[ind] = str[ind] + Convert.ToString(j.Value) + " ";
                    }
                    ind++;
                }
                System.IO.File.WriteAllLines(@sfdSavePresets.FileName, str);
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
