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
    public partial class Form_Change_Spec : Form
    {
        public Form_Change_Spec()
        {
            InitializeComponent();
        }

        private DataTable dtDiscipline;
        private DataTable dtSpecName;
        private DataTable dtCurr;

        private void Form_Change_Spec_Load(object sender, EventArgs e)
        {
            cbTitle.Items.Clear();

            cbBudjet.SelectedIndex = 0;
            cbOchn.SelectedIndex = 0;
            cbDiscipline_Fill();
            cbSpecName_Fill();
        }

        #region dtSpecName

        private void cbSpecName_Fill()
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
            string spec_name = Find_SpecName();
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
            cbOchn.SelectedItem = dtCurr.Rows[0][5].ToString();
            cbBudjet.SelectedItem = dtCurr.Rows[0][6].ToString();
            cbDiscipline1.SelectedItem = dtCurr.Rows[0][7].ToString();
            cbDiscipline2.SelectedItem = dtCurr.Rows[0][8].ToString();
            cbDiscipline3.SelectedItem = dtCurr.Rows[0][9].ToString();
        }

        private string Find_SpecName()
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


        private void cbDiscipline_Fill()
        {
            MainForm.DB.RunQuery("SELECT D_title, D_id from discipline;", out dtDiscipline);

            foreach (DataRow i in dtDiscipline.Rows)
            {
                cbDiscipline1.Items.Add(i[0].ToString());
                cbDiscipline2.Items.Add(i[0].ToString());
                cbDiscipline3.Items.Add(i[0].ToString());
            }
            if (cbDiscipline1.Items.Count != 0) cbDiscipline1.SelectedIndex = 0;
            if (cbDiscipline2.Items.Count != 0) cbDiscipline2.SelectedIndex = 0;
            if (cbDiscipline3.Items.Count != 0) cbDiscipline3.SelectedIndex = 0;
        }

        private string Find_Discipline1()
        {
            foreach (DataRow i in dtDiscipline.Rows)
            {
                if (cbDiscipline1.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private string Find_Discipline2()
        {
            foreach (DataRow i in dtDiscipline.Rows)
            {
                if (cbDiscipline1.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private string Find_Discipline3()
        {
            foreach (DataRow i in dtDiscipline.Rows)
            {
                if (cbDiscipline1.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbShifr.Text.Length > 10) { errorProvider.SetError(tbShifr, "Шифр должен быть не более 10 символов!"); ret_val = false; }
                if (tbSpecName.Text.Length > 45) { errorProvider.SetError(tbSpecName, "Квалификация по специальности должна быть не более 45 символов!"); ret_val = false; }
                if (tbTitle.Text.Length > 100) { errorProvider.SetError(tbTitle, "Название специальности должено быть не более 100 символов!"); ret_val = false; }
                if (tbShort.Text.Length > 6) { errorProvider.SetError(tbShort, "Аббревиатура специальности должена быть не более 6 символов"); ret_val = false; }

                if (tbShifr.Text.Length == 0) { errorProvider.SetError(tbShifr, "Заполните это поле!"); ret_val = false; }
                if (tbSpecName.Text.Length == 0) { errorProvider.SetError(tbSpecName, "Заполните это поле!"); ret_val = false; }
                if (tbTitle.Text.Length == 0) { errorProvider.SetError(tbSpecName, "Заполните это поле!"); ret_val = false; }
                if (tbShort.Text.Length == 0) { errorProvider.SetError(tbShort, "Заполните это поле!"); ret_val = false; }
                if (cbBudjet.Text.Length == 0) { errorProvider.SetError(tbShort, "Заполните это поле!"); ret_val = false; }
                if (cbOchn.Text.Length == 0) { errorProvider.SetError(tbShort, "Заполните это поле!"); ret_val = false; }
                if (cbDiscipline1.Text.Length == 0) { errorProvider.SetError(tbShort, "Заполните это поле!"); ret_val = false; }
                if (cbDiscipline2.Text.Length == 0) { errorProvider.SetError(tbShort, "Заполните это поле!"); ret_val = false; }

                if (cbOchn.Text == null)
                {
                    errorProvider.SetError(cbOchn, "Выберите форму обучения на специальности!");
                    ret_val = false;
                }

                if (cbBudjet.Text == null)
                {
                    errorProvider.SetError(cbBudjet, "Выберите оплату!");
                    ret_val = false;
                }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string ochn;
            if (cbBudjet.Text == "Очная") { ochn = "1"; }
            else { ochn = "0"; }

            string budjet;
            if (cbBudjet.Text == "Бюджетная") { budjet = "1"; }
            else { budjet = "0"; }

            string discipline1_id = Find_Discipline1();
            if (discipline1_id == "-1")
            {
                errorProvider.SetError(cbDiscipline1, "Выберите дисциплину!");
                return;
            }

            string discipline2_id = Find_Discipline2();
            if (discipline2_id == "-1")
            {
                errorProvider.SetError(cbDiscipline2, "Выберите дисциплину!");
                return;
            }

            string discipline3_id = Find_Discipline3();
            if (discipline3_id == "-1")
            {
                errorProvider.SetError(cbDiscipline3, "Выберите дисциплину!");
                return;
            }

            string sql = "UPDATE spec " +
                "SET S_shifr = '" + tbShifr.Text + "', S_spec = '" + tbSpecName.Text + "', S_title = '" + tbTitle.Text + "', S_short = '" + tbShort.Text + "'," +
                "S_ochn = " + ochn + ", S_budjet = " + budjet + ", S_discipline1 = " + discipline1_id + ", S_discipline2 = " + discipline2_id + ", " +
                "S_discipline3 = " + discipline3_id + " " +
                "where S_id = " + tbID.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена специальность", cbTitle.Text + "; " + tbShifr.Text + "; " + tbSpecName.Text + "; ");
                MessageBox.Show("Специальность успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось изменить специальность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
