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
    public partial class Form_Delete_Spec : Form
    {
        public Form_Delete_Spec()
        {
            InitializeComponent();
        }

        private DataTable dtSpecName;
        private DataTable dtCurr;

        private void Form_Delete_Spec_Load(object sender, EventArgs e)
        {
            cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbTitle.Items.Clear();
            cbTitle_Fill();
        }

        #region dtSpecName

        private void cbTitle_Fill()
        {
            MainForm.DB.RunQuery("SELECT S_title, S_id from spec order by S_title asc;", out dtSpecName);

            foreach (DataRow i in dtSpecName.Rows)
            {
                cbTitle.Items.Add(i[0]);
            }
            if (cbTitle.Items.Count != 0) cbTitle.SelectedIndex = 0;
        }

        private void cbSpecName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spec_name = Find_Title();
            if (spec_name == "-1")
            {
                errorProvider.SetError(cbTitle, "Выберите дисциплину!");
                return;
            }

            MainForm.DB.RunQuery("SELECT spec.S_id, spec.S_shifr, spec.S_spec, spec.S_title, spec.S_short, " +
                "IF(spec.S_ochn >= 1, 'Очная', 'Заочная'), " +
                "IF(spec.S_budjet >= 1, 'Бюджетная', 'Платная'), " +
                "disc1.D_title, disc2.D_title, " +
                "disc3.D_title " +
                "from spec " +
                "LEFT JOIN discipline AS disc1 ON(disc1.D_id = spec.S_discipline1) " +
                "LEFT JOIN discipline AS disc2 ON(disc2.D_id = spec.S_discipline2) " +
                "LEFT JOIN discipline AS disc3 ON(disc3.D_id = spec.S_discipline3) " +
                "WHERE spec.S_id = " + spec_name + "; ", out dtCurr);

            tbID.Text = dtCurr.Rows[0][0].ToString();
            tbShifr.Text = dtCurr.Rows[0][1].ToString();
            tbSpecName.Text = dtCurr.Rows[0][2].ToString();
            tbTitle.Text = dtCurr.Rows[0][3].ToString();
            tbShort.Text = dtCurr.Rows[0][4].ToString();
            tbOchn.Text = dtCurr.Rows[0][5].ToString();
            tbBudjet.Text = dtCurr.Rows[0][6].ToString();
            tbDiscipline1.Text = dtCurr.Rows[0][7].ToString();
            tbDiscipline2.Text = dtCurr.Rows[0][8].ToString();
            tbDiscipline3.Text = dtCurr.Rows[0][9].ToString();
        }

        private string Find_Title()
        {
            foreach (DataRow i in dtSpecName.Rows)
            {
                if (cbTitle.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msg = "При удалении специальности значения связанных таблиц будут установлены в null. " +
                "\n\n" +
                "Продолжить удаление?";
            if (!(MessageBox.Show(msg, "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) return;
            string sql = "delete from spec " +
                "where S_id = " + tbID.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Удалена специальность", cbTitle.Text + "; " + tbShifr.Text + "; " + tbSpecName.Text + "; ");
                MessageBox.Show("Специальность успешно удалена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось удалить специальность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
