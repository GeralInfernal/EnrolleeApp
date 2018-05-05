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
    public partial class Form_Change_Military : Form
    {
        public Form_Change_Military()
        {
            InitializeComponent();
        }


        private DataTable dtAbit;
        private DataTable dtChangingAbit;
        private DataTable currDT;

        private void Form_Add_Status_Load(object sender, EventArgs e)
        {
            cbAbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbChangingAbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            cbAbit.Items.Clear();
            cbChangingAbit.Items.Clear();

            cbAbit_Fill();
            cbhChangingAbit_Fill();
        }

        #region dtAbit

        private void cbAbit_Fill()
        {
            MainForm.DB.RunQuery("Select FIO, id from abit order by FIO asc; ", out dtAbit);

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

        #endregion

        #region dtChangingAbit

        private void cbChangingAbit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string military_id = Find_ChangingAbit_id();
            if (military_id == "-1")
            {
                errorProvider.SetError(cbAbit, "Выберите абитуринта!");
                return;
            }

            MainForm.DB.RunQuery("Select military.M_id, abit.FIO, military.M_type, military.M_docinform " +
                "from military " +
                "LEFT JOIN abit ON(abit.id = military.M_abit) " +
                "where military.M_id = " + military_id + ";", out currDT);

            tbID.Text = currDT.Rows[0][0].ToString();
            cbAbit.SelectedItem = currDT.Rows[0][1].ToString();
            tbDocument.Text = currDT.Rows[0][2].ToString();
            tbDocinform.Text = currDT.Rows[0][3].ToString();
        }

        private void cbhChangingAbit_Fill()
        {
            MainForm.DB.RunQuery("Select abit.FIO, military.M_id " +
                "from military " +
                "LEFT JOIN abit ON(abit.id = military.M_abit) " +
                "order by FIO asc; ", out dtChangingAbit);

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

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbDocument.Text.Length > 40) { errorProvider.SetError(tbDocument, "Документ должен быть не более 40 символов!"); ret_val = false; }
                if (tbDocinform.Text.Length > 80) { errorProvider.SetError(tbDocinform, "Информация из документа должна быть не более 80 символов!"); ret_val = false; }

                if (tbDocument.Text.Length == 0) { errorProvider.SetError(tbDocument, "Заполните это поле!"); ret_val = false; }
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

            string abit_id = Find_abit_id();
            if (abit_id == "-1")
            {
                errorProvider.SetError(cbAbit, "Выберите абитуринта!");
                return;
            }

            string sql = "update military set " +
                "M_abit = " + abit_id + ", M_type = '" + tbDocument.Text + "', M_docinform = '" + tbDocinform.Text + "' " +
                "where M_id = " + tbID.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена воинская обязанность", cbAbit.Text + " " + tbDocument.Text);
                MessageBox.Show("Воинская обязанность успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось изменить воинскую обязанность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
