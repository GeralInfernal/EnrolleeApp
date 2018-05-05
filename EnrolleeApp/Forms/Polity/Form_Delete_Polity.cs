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
    public partial class Form_Delete_Polity : Form
    {
        public Form_Delete_Polity()
        {
            InitializeComponent();
        }

        private DataTable dtPolity;

        private void Form_Update_Polity_Load(object sender, EventArgs e)
        {
            cbPolity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDiscipline_Fill();
        }
        private void cbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbId.Text = dtPolity.Rows[cbPolity.SelectedIndex][1].ToString();
            tbPolityName.Text = dtPolity.Rows[cbPolity.SelectedIndex][0].ToString();
        }

        private void cbDiscipline_Fill()
        {
            MainForm.DB.RunQuery("Select Pol_title, Pol_id from polity order by Pol_title asc; ", out dtPolity);

            foreach (DataRow i in dtPolity.Rows)
            {
                cbPolity.Items.Add(i[0].ToString());
            }
            if (cbPolity.Items.Count != 0) cbPolity.SelectedIndex = 0;
        }

        private int Find_Discipline_id()
        {
            foreach (DataRow i in dtPolity.Rows)
            {
                if (cbPolity.Text == i[0].ToString())
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
                if (tbPolityName.Text.Length > 40) { errorProvider.SetError(tbPolityName, "Название государства должно быть не более 40 символов!"); ret_val = false; }

                if (tbPolityName.Text.Length == 0) { errorProvider.SetError(tbPolityName, "Заполните это поле!"); ret_val = false; }
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
            string msg = "При удалении государства значения связанных таблиц будут установлены в null. " +
                "\n\n" +
                "Продолжить удаление?";
            if (!(MessageBox.Show(msg, "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) return;

            string sql = "delete from polity where Pol_title = '" + tbPolityName.Text + "' AND Pol_id = " + tbId.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Удалено государство", cbPolity.Text);
                MessageBox.Show("Государство успешно удалено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Нельзя удалить используемые записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
