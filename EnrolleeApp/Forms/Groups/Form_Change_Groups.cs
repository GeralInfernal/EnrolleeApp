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
    public partial class Form_Change_Groups : Form
    {
        public Form_Change_Groups()
        {
            InitializeComponent();
        }

        DataTable dtSpec;
        DataTable dtGroup;
        DataTable buff;

        private void Form_AddParent_Load(object sender, EventArgs e)
        {
            cbGroup_Fill();
            cbSpec_Fill();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string group_id = FindID_cbGroup();
            if (group_id == "-1")
            {
                errorProvider.SetError(cbGroup, "Выберите группу!");
                return;
            }
            string sql = "select groups.gr_id, groups.gr_name, spec.S_title, groups.gr_year, groups.gr_students " +
                "FROM groups " +
                "LEFT JOIN spec ON(groups.gr_spec = spec.S_id) " +
                "where gr_id = " + group_id + "; ";

            MainForm.DB.RunQuery(sql, out buff);

            tbID.Text = buff.Rows[0][0].ToString();
            tbName.Text = buff.Rows[0][1].ToString();
            cbGroup.SelectedItem = buff.Rows[0][2].ToString();
            tbYear.Text = buff.Rows[0][3].ToString();
            tbStudents.Text = buff.Rows[0][4].ToString();
        }

        private void cbGroup_Fill()
        {
            MainForm.DB.RunQuery("Select gr_name, gr_id from groups order by gr_name asc; ", out dtGroup);

            foreach (DataRow i in dtGroup.Rows)
            {
                cbGroup.Items.Add(i[0].ToString());
            }
            if (cbGroup.Items.Count != 0) cbGroup.SelectedIndex = 0;
        }

        private string FindID_cbGroup()
        {
            foreach (DataRow i in dtGroup.Rows)
            {
                if (cbGroup.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private void cbSpec_Fill()
        {
            MainForm.DB.RunQuery("Select S_title, S_id from spec order by S_title asc; ", out dtSpec);

            foreach (DataRow i in dtSpec.Rows)
            {
                cbSpec.Items.Add(i[0].ToString());
            }
            if (cbSpec.Items.Count != 0) cbSpec.SelectedIndex = 0;
        }

        private string FindID_cbSpec()
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
                if (tbStudents.Text.Length > 2) { errorProvider.SetError(tbStudents, "Количество студентов должно быть не более 2 символов!"); ret_val = false; }

                if (cbGroup.Text.Length == 0) { errorProvider.SetError(cbGroup, "Заполните это поле!"); ret_val = false; }
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

            string spec_id = FindID_cbSpec();
            if (spec_id == "-1")
            {
                errorProvider.SetError(cbSpec, "Выберите специальность!");
                return;
            }

            string sql = "UPDATE groups SET " +
                "gr_name = '" + tbName.Text + "', gr_spec = " + spec_id + ", gr_year = '" + tbYear.Text + "', gr_students = '" + tbStudents.Text + "' " +
                "where groups.gr_id = " + tbID.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена группа", tbName.Text + " " + tbYear.Text + " " + tbStudents.Text);
                MessageBox.Show("Группа успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось изменить группу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
