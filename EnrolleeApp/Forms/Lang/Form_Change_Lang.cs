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
    public partial class Form_Change_Lang : Form
    {
        public Form_Change_Lang()
        {
            InitializeComponent();
        }

        private DataTable dtLang;

        private void Form_Update_Lang_Load(object sender, EventArgs e)
        {
            cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbLang_Fill();
        }
        private void cbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbId.Text = dtLang.Rows[cbLang.SelectedIndex][1].ToString();
            tbLangName.Text = dtLang.Rows[cbLang.SelectedIndex][0].ToString();
        }

        private void cbLang_Fill()
        {
            MainForm.DB.RunQuery("Select L_title, L_id from lang order by L_title asc; ", out dtLang);

            foreach (DataRow i in dtLang.Rows)
            {
                cbLang.Items.Add(i[0].ToString());
            }
            if (cbLang.Items.Count != 0) cbLang.SelectedIndex = 0;
        }

        private int Find_Discipline_id()
        {
            foreach (DataRow i in dtLang.Rows)
            {
                if (cbLang.Text == i[0].ToString())
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
                if (tbLangName.Text.Length > 40) { errorProvider.SetError(tbLangName, "Название иностранного языка должно быть не более 40 символов!"); ret_val = false; }

                if (tbLangName.Text.Length == 0) { errorProvider.SetError(tbLangName, "Заполните это поле!"); ret_val = false; }
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

            string sql = "UPDATE lang SET L_title = '" + tbLangName.Text + "' WHERE L_id = " + tbId.Text + ";";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменен иностранный язык", cbLang.Text + " на " + tbLangName.Text);
                MessageBox.Show("Иностранный язык успешно изменен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось изменить указанный иностранный язык!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
