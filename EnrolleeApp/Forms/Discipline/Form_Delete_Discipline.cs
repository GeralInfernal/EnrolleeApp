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
    public partial class Form_Delete_Discipline : Form
    {
        public Form_Delete_Discipline()
        {
            InitializeComponent();
        }

        private DataTable dtDiscipline;

        private void Form_Update_Discipline_Load(object sender, EventArgs e)
        {
            cbDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDiscipline_Fill();
        }
        private void cbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbId.Text = dtDiscipline.Rows[cbDiscipline.SelectedIndex][1].ToString();
            tbDisciplineName.Text = dtDiscipline.Rows[cbDiscipline.SelectedIndex][0].ToString();
        }

        private void cbDiscipline_Fill()
        {
            MainForm.DB.RunQuery("Select D_title, D_id from Discipline order by D_title asc; ", out dtDiscipline);

            foreach (DataRow i in dtDiscipline.Rows)
            {
                cbDiscipline.Items.Add(i[0].ToString());
            }
            if (cbDiscipline.Items.Count != 0) cbDiscipline.SelectedIndex = 0;
        }

        private int Find_Discipline_id()
        {
            foreach (DataRow i in dtDiscipline.Rows)
            {
                if (cbDiscipline.Text == i[0].ToString())
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
                if (tbDisciplineName.Text.Length > 40) { errorProvider.SetError(tbDisciplineName, "Название дисциплины должно быть не более 40 символов!"); ret_val = false; }

                if (tbDisciplineName.Text.Length == 0) { errorProvider.SetError(tbDisciplineName, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;
            string msg = "При удалении дисциплины значения связанных таблиц будут установлены в null. " +
                "\n\n" +
                "Продолжить удаление?";
            if (!(MessageBox.Show(msg, "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) return;

            string sql = "delete from discipline where D_title = '" + tbDisciplineName.Text + "' AND D_id = " + tbId.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Удалена дисциплина", cbDiscipline.Text);
                MessageBox.Show("Дисциплина успешно удалена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Нельзя удалить используемые записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
