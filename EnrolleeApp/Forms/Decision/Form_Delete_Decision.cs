using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EnrolleeApp
{
    public partial class Form_Delete_Decision : Form
    {
        public Form_Delete_Decision()
        {
            InitializeComponent();
        }

        private DataTable dtAbit;

        private void Form_Change_Decision_Load(object sender, EventArgs e)
        {
            cbAbit_Fill();
        }
        private void cbAbit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string abit_id = Find_abit_id();
            if (abit_id == "-1")
            {
                return;
            }

            DataTable dt;
            MainForm.DB.RunQuery("select decision.Des_id, groups.gr_name, decision.Des_resolution, " +
                "decision.Comment, decision.Des_date, komis.K_FIO " +
                "from decision " +
                "LEFT JOIN komis ON(komis.K_id = decision.Des_komis) " +
                "LEFT JOIN groups ON(groups.gr_id = decision.Des_komis) " +
                "where Des_abit = " + abit_id + "; ", out dt);

            tbID.Text = dt.Rows[0][0].ToString();
            tbGroup.Text = dt.Rows[0][1].ToString();
            tbResolution.Text = dt.Rows[0][2].ToString();
            tbComment.Text = dt.Rows[0][3].ToString();
            tbDate.Text = DateTime.Parse(dt.Rows[0][4].ToString()).ToShortDateString();
            tbKomis.Text = dt.Rows[0][5].ToString();
        }

        private void cbAbit_Fill()
        {
            MainForm.DB.RunQuery("select abit.FIO, abit.id from decision " +
                "LEFT JOIN abit ON (abit.id = decision.Des_abit) " +
                "order by abit.FIO asc; ", out dtAbit);

            foreach (DataRow i in dtAbit.Rows)
            {
                cbAbit.Items.Add(i[0].ToString());
            }
            if (cbAbit.Items.Count != 0) cbAbit.SelectedIndex = 0;
        }

        private string Find_abit_id()
        {
            foreach (DataRow i in dtAbit.Rows)
            {
                if (cbAbit.Text == i[0].ToString())
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
                if (cbAbit.Text.Length == 0) { errorProvider.SetError(cbAbit, "Заполните это поле!"); ret_val = false; }
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
            string msg = "Вы действительно хотите удалить эту запись?";
            if (!(MessageBox.Show(msg, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) return;

            string abit_id = Find_abit_id();
            if (abit_id == "-1")
            {
                errorProvider.SetError(cbAbit, "Выберите абитуринта!");
                return;
            }

            string sql = "DELETE FROM decision " +
                "where decision.Des_id = " + tbID.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Удалено решение комиссии", abit_id + "" + tbResolution.Text + " " + tbComment.Text);
                MessageBox.Show("Решение комиссии успешно удалено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось удалить решение комиссии!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
