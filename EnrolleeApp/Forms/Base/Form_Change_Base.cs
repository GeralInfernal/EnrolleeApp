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
    public partial class Form_Change_Base : Form
    {
        public Form_Change_Base()
        {
            InitializeComponent();
        }

        private DataTable dtBase;

        private void Form_Update_Base_Load(object sender, EventArgs e)
        {
            cbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDiscipline_Fill();
        }
        private void cbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbId.Text = dtBase.Rows[cbBase.SelectedIndex][1].ToString();
            tbBaseName.Text = dtBase.Rows[cbBase.SelectedIndex][0].ToString();
        }

        private void cbDiscipline_Fill()
        {
            MainForm.DB.RunQuery("Select B_title, B_id from base order by B_title asc; ", out dtBase);

            foreach (DataRow i in dtBase.Rows)
            {
                cbBase.Items.Add(i[0].ToString());
            }
            if (cbBase.Items.Count != 0) cbBase.SelectedIndex = 0;
        }

        private int Find_Discipline_id()
        {
            foreach (DataRow i in dtBase.Rows)
            {
                if (cbBase.Text == i[0].ToString())
                {
                    return Convert.ToInt32(i[1]);
                }
            }
            return -1;
        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbBaseName.Text.Length > 40) { errorProvider.SetError(tbBaseName, "Название государства должно быть не более 40 символов!"); ret_val = false; }

                if (tbBaseName.Text.Length == 0) { errorProvider.SetError(tbBaseName, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string sql = "UPDATE base SET B_title = '" + tbBaseName.Text + "' WHERE B_id = " + tbId.Text + ";";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена база образования", cbBase.Text + " на " + tbBaseName.Text);
                MessageBox.Show("База образования успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось изменить указанную базу образования!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
