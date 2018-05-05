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
    public partial class Form_Delete_Parent : Form
    {
        public Form_Delete_Parent()
        {
            InitializeComponent();
        }

        private DataTable dtParent;
        private DataTable currDT;
        private void cbParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string parent_id = Find_parent_id();
            if (parent_id == "-1")
            {
                errorProvider.SetError(cbParent, "Выберите имя родителя!");
                return;
            }

            MainForm.DB.RunQuery("select parent.P_id, abit.FIO, parent.P_FIO, " +
                "parent.P_adrreg, parent.P_adrfact, parent.P_workpost, parent.P_phone " +
                "from parent " +
                "LEFT JOIN abit ON(abit.id = parent.P_abit) " +
                "where parent.P_id = " + parent_id + " ; ", out currDT);

            tbID.Text = currDT.Rows[0][0].ToString();
            tbAbit.Text = currDT.Rows[0][1].ToString();
            tbParentFIO.Text = currDT.Rows[0][2].ToString();
            tbAdrReg.Text = currDT.Rows[0][3].ToString();
            tbAdrFact.Text = currDT.Rows[0][4].ToString();
            tbWorkpost.Text = currDT.Rows[0][5].ToString();
            tbPhone.Text = currDT.Rows[0][6].ToString();
        }

        private void Form_Change_Parent_Load(object sender, EventArgs e)
        {
            cbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbParent.Items.Clear();
            cbParent_Fill();
        }

        private void cbParent_Fill()
        {
            MainForm.DB.RunQuery("Select P_FIO, P_id from parent order by P_FIO asc; ", out dtParent);

            foreach (DataRow i in dtParent.Rows)
            {
                cbParent.Items.Add(i[0].ToString());
            }
            if (cbParent.Items.Count != 0) cbParent.SelectedIndex = 0;
        }

        private string Find_parent_id()
        {
            foreach (DataRow i in dtParent.Rows)
            {
                if (cbParent.Text == i[0].ToString())
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
                if (tbParentFIO.Text.Length > 50) { errorProvider.SetError(tbParentFIO, "ФИО должно быть не более 50 символов!"); ret_val = false; }
                if (tbAdrReg.Text.Length > 80) { errorProvider.SetError(tbAdrReg, "Адрес регистрации должен быть не более 80 символов!"); ret_val = false; }
                if (tbAdrFact.Text.Length > 80) { errorProvider.SetError(tbAdrFact, "Адрес проживания должен быть не более 80 символов"); ret_val = false; }
                if (tbWorkpost.Text.Length > 80) { errorProvider.SetError(tbWorkpost, "Место работы должно быть не более 80 символов"); }
                if (tbPhone.Text.Length > 20) { errorProvider.SetError(tbPhone, "Телефон должен быть не более 80 символов!"); ret_val = false; }

                if (tbParentFIO.Text.Length == 0) { errorProvider.SetError(tbParentFIO, "Заполните это поле!"); ret_val = false; }
                if (tbAdrReg.Text.Length == 0) { errorProvider.SetError(tbAdrReg, "Заполните это поле!"); ret_val = false; }
                if (tbAdrFact.Text.Length == 0) { errorProvider.SetError(tbAdrFact, "Заполните это поле!"); ret_val = false; }
                if (tbWorkpost.Text.Length == 0) { errorProvider.SetError(tbWorkpost, "Заполните это поле!"); }
                if (tbPhone.Text.Length == 0) { errorProvider.SetError(tbPhone, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string msg = "Вы действительно хотите удалить эту запись?";
            if (!(MessageBox.Show(msg, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) return;

            string sql = "delete from parent where P_id = " + tbID.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Удален родитель", "Идентификатор: " + tbID.Text + "; ФИО: " + tbParentFIO.Text + ";");
                MessageBox.Show("Данные о родителе успешно удалены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Нельзя удалить используемые записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
