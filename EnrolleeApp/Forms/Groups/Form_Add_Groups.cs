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
    public partial class Form_Add_Groups : Form
    {
        public Form_Add_Groups()
        {
            InitializeComponent();
        }

        DataTable dtSpec;

        private void Form_AddParent_Load(object sender, EventArgs e)
        {
            cbAbit_Fill();
        }

        private void cbAbit_Fill()
        {
            MainForm.DB.RunQuery("Select S_title, S_id from spec order by S_title asc; ", out dtSpec);

            foreach (DataRow i in dtSpec.Rows)
            {
                cbSpec.Items.Add(i[0].ToString());
            }
            if (cbSpec.Items.Count != 0) cbSpec.SelectedIndex = 0;
        }

        private string Find_id()
        {
            foreach (DataRow i in dtSpec.Rows)
            {
                if (cbSpec.Text == i[0].ToString())
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
                if (tbName.Text.Length > 20) { errorProvider.SetError(tbName, "Название группы должно быть не более 20 символов!"); ret_val = false; }
                if (tbYear.Text.Length > 4) { errorProvider.SetError(tbYear, "Год создания группы должен быть не более 4 символов!"); ret_val = false; }
                if (tbStudents.Text.Length > 2) { errorProvider.SetError(tbStudents, "Количество студентов должено быть не более 2 символов!"); ret_val = false; }

                if (tbName.Text.Length == 0) { errorProvider.SetError(tbName, "Заполните это поле!"); ret_val = false; }
                if (cbSpec.Text.Length == 0) { errorProvider.SetError(cbSpec, "Заполните это поле!"); ret_val = false; }
                if (tbYear.Text.Length == 0) { errorProvider.SetError(tbYear, "Заполните это поле!"); ret_val = false; }
                if (tbStudents.Text.Length == 0) { errorProvider.SetError(tbStudents, "Заполните это поле!"); ret_val = false; }
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

            string spec_id = Find_id();
            if (spec_id == "-1")
            {
                errorProvider.SetError(cbSpec, "Выберите специальность!");
                return;
            }

            string sql = "INSERT INTO groups (gr_name, gr_spec, gr_year, gr_students) " +
                "VALUES ('" + tbName.Text + "', " + spec_id + ", '" + tbYear.Text + "', '" + tbStudents.Text + "'); ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлена группа", tbName.Text + " " + tbYear.Text + " " + tbStudents.Text );
                MessageBox.Show("Группа успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить группу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
