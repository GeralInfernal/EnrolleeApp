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
    public partial class Form_Add_Discipline : Form
    {
        public Form_Add_Discipline()
        {
            InitializeComponent();
        }

        private void Form_Add_Discipline_Load(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string sql = "INSERT INTO discipline(D_title) VALUES ('" + tbDisciplineName.Text + "');"; 
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлена дисциплина", tbDisciplineName.Text);
                MessageBox.Show("Дисциплина успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить указанную дисциплину!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
