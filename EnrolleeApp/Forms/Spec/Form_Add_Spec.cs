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
    public partial class Form_Add_Spec : Form
    {
        public Form_Add_Spec()
        {
            InitializeComponent();
        }

        DataTable dtDiscipline;

        private void Form_AddParent_Load(object sender, EventArgs e)
        {

            cbBudjet.SelectedIndex = 0;
            cbOchn.SelectedIndex = 0;
            cbDiscipline_Fill();
        }

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
                if (tbTitle.Text.Length > 100) { errorProvider.SetError(tbSpecName, "Название специальности должено быть не более 100 символов!"); ret_val = false; }
                if (tbSpecAbbr.Text.Length > 6) { errorProvider.SetError(tbSpecAbbr, "Аббревиатура специальности должена быть не более 6 символов"); ret_val = false; }

                if (tbShifr.Text.Length == 0) { errorProvider.SetError(tbShifr, "Заполните это поле!"); ret_val = false; }
                if (tbSpecName.Text.Length == 0) { errorProvider.SetError(tbSpecName, "Заполните это поле!"); ret_val = false; }
                if (tbTitle.Text.Length == 0) { errorProvider.SetError(tbSpecName, "Заполните это поле!"); ret_val = false; }
                if (tbSpecAbbr.Text.Length == 0) { errorProvider.SetError(tbSpecAbbr, "Заполните это поле!"); ret_val = false; }
                if (cbBudjet.Text.Length == 0) { errorProvider.SetError(tbSpecAbbr, "Заполните это поле!"); ret_val = false; }
                if (cbOchn.Text.Length == 0) { errorProvider.SetError(tbSpecAbbr, "Заполните это поле!"); ret_val = false; }
                if (cbDiscipline1.Text.Length == 0) { errorProvider.SetError(tbSpecAbbr, "Заполните это поле!"); ret_val = false; }
                if (cbDiscipline2.Text.Length == 0) { errorProvider.SetError(tbSpecAbbr, "Заполните это поле!"); ret_val = false; }
                if (cbDiscipline3.Text.Length == 0) { errorProvider.SetError(tbSpecAbbr, "Заполните это поле!"); ret_val = false; }

                if(cbOchn.Text == null)
                {
                    errorProvider.SetError(cbDiscipline3, "Выберите форму обучения на специальности!");
                    ret_val = false;
                }

                if (cbBudjet.Text == null)
                {
                    errorProvider.SetError(cbDiscipline3, "Выберите оплату!");
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

            string sql = "INSERT INTO Spec(S_shifr, S_spec, S_title, S_short, S_ochn, S_budjet, S_discipline1, S_discipline2, S_discipline3) " +
                " values ('"+ tbShifr.Text + "', '" + tbSpecName.Text + "', '" + tbTitle.Text + "', '" + tbSpecAbbr.Text + "', " +
                ochn + ", " + budjet + ", " + discipline1_id + ", " + discipline2_id + ", " + discipline3_id  + "');";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлена специальность", tbShifr.Text + "; " + tbSpecName.Text + "; " + tbTitle.Text + "; ");
                MessageBox.Show("Специальность успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить специальность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
