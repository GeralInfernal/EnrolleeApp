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
    public partial class Form_Delete_Status : Form
    {
        public Form_Delete_Status()
        {
            InitializeComponent();
        }

        private DataTable dtChangingAbit;
        private DataTable dtChangingStatus;
        private DataTable currDT;

        private void Form_Add_Status_Load(object sender, EventArgs e)
        {
            cbChangingAbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbChangingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            cbChangingAbit.Items.Clear();
            cbChangingStatus.Items.Clear();

            cbhChangingAbit_Fill();
        }

        #region dtChangingAbit

        private void cbChangingAbit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChangingStatus.Items.Clear();
            cbChangingStatus_Fill();
            //if (cbChangingStatus.Items.Count != 0) cbChangingStatus.SelectedIndex = 0;
        }

        private void cbhChangingAbit_Fill()
        {
            MainForm.DB.RunQuery("Select abit.FIO, status.St_abit " +
                "from status " +
                "LEFT JOIN abit ON(abit.id = status.St_abit) " +
                "order by St_type asc; ", out dtChangingAbit);

            foreach (DataRow i in dtChangingAbit.Rows)
            {
                cbChangingAbit.Items.Add(i[0].ToString());
            }
            if (cbChangingAbit.Items.Count != 0) cbChangingAbit.SelectedIndex = 0;
        }

        private string Find_ChangingAbit_id()
        {
            foreach (DataRow i in dtChangingAbit.Rows)
            {
                if (cbChangingAbit.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion

        #region dtChangingStatus

        private void cbChangingStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status_id = Find_ChangingStatus_id();
            if (status_id == "-1")
            {
                return;
            }

            MainForm.DB.RunQuery("Select status.St_id, abit.FIO, status.St_type, status.St_docinform " +
                "from status " +
                "LEFT JOIN abit ON(abit.id = status.St_abit) " +
                "where status.St_id = " + status_id + ";", out currDT);

            tbID.Text = currDT.Rows[0][0].ToString();
            tbAbit.Text = currDT.Rows[0][1].ToString();
            tbStatusType.Text = currDT.Rows[0][2].ToString();
            tbDocinform.Text = currDT.Rows[0][3].ToString();
        }

        private void cbChangingStatus_Fill()
        {
            string abit_id = Find_ChangingAbit_id();
            if (abit_id == "-1")
            {
                return;
            }

            MainForm.DB.RunQuery("Select St_type, St_id from status " +
                "where St_abit = " + abit_id + " order by St_type asc; ", out dtChangingStatus);

            foreach (DataRow i in dtChangingStatus.Rows)
            {
                cbChangingStatus.Items.Add(i[0].ToString());
            }
            if (cbChangingStatus.Items.Count != 0) cbChangingStatus.SelectedIndex = 0;
        }

        private string Find_ChangingStatus_id()
        {
            foreach (DataRow i in dtChangingStatus.Rows)
            {
                if (cbChangingStatus.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbStatusType.Text.Length > 20) { errorProvider.SetError(tbStatusType, "Статус должен быть не более 20 символов!"); ret_val = false; }
                if (tbDocinform.Text.Length > 100) { errorProvider.SetError(tbDocinform, "Информация из документа должена быть не более 100 символов!"); ret_val = false; }

                if (tbStatusType.Text.Length == 0) { errorProvider.SetError(tbStatusType, "Заполните это поле!"); ret_val = false; }
                if (tbDocinform.Text.Length == 0) { errorProvider.SetError(tbDocinform, "Заполните это поле!"); ret_val = false; }
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

            string abit_id = Find_ChangingAbit_id();
            if (abit_id == "-1")
            {
                errorProvider.SetError(cbChangingAbit, "Выберите абитуринта!");
                return;
            }

            string sql = "update status set " +
                "St_abit = " + abit_id + ", St_type = '" + tbStatusType.Text + "', St_docinform = '" + tbDocinform.Text + "' " +
                "where St_id = " + tbID.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Удален статус", cbChangingAbit.Text + " " + tbStatusType.Text);
                MessageBox.Show("Cтатус успешно удален", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось удалить статус!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
