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
    public partial class Form_Delete_Groups : Form
    {
        public Form_Delete_Groups()
        {
            InitializeComponent();
        }

        DataTable dtGroup;
        DataTable buff;

        private void Form_AddParent_Load(object sender, EventArgs e)
        {
            cbGroup_Fill();
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
            tbSpec.Text = buff.Rows[0][2].ToString();
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

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (cbGroup.Text.Length == 0) { errorProvider.SetError(cbGroup, "Заполните это поле!"); ret_val = false; }
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

            string sql = "delete from groups where gr_id = " + tbID.Text + "; ";

            string msg = "Вы действительно хотите удалить эту запись?";
            if (!(MessageBox.Show(msg, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) return;

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Удалена группа", tbName.Text + " " + tbYear.Text + " " + tbStudents.Text);
                MessageBox.Show("Группа успешно удалена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось удалить группу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
