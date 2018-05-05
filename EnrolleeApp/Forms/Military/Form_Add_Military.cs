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
    public partial class Form_Add_Military : Form
    {
        public Form_Add_Military()
        {
            InitializeComponent();
        }

        DataTable data_table;

        private void Form_AddParent_Load(object sender, EventArgs e)
        {
            cbAbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAbit_Fill();
        }

        private void cbAbit_Fill()
        {
            MainForm.DB.RunQuery("Select FIO, id from abit order by FIO asc; ", out data_table);

            foreach (DataRow i in data_table.Rows)
            {
                cbAbit.Items.Add(i[0].ToString());
            }
            if (cbAbit.Items.Count != 0) cbAbit.SelectedIndex = 0;
        }

        private int Find_id()
        {
            foreach (DataRow i in data_table.Rows)
            {
                if (cbAbit.Text == i[0].ToString())
                {
                    return Convert.ToInt32(i[1]);
                }
            }
            return -1;
        }

        private bool CheckValues()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbDocument.Text.Length > 40) { errorProvider.SetError(tbDocument, "Название документа должно быть не более 40 символов!"); ret_val = false; }
                if (tbDocumentInfo.Text.Length > 80) { errorProvider.SetError(tbDocumentInfo, "Информация из документа должена быть не более 80 символов!"); ret_val = false; }

                if (tbDocument.Text.Length == 0) { errorProvider.SetError(tbDocument, "Заполните это поле!"); ret_val = false; }
                if (tbDocumentInfo.Text.Length == 0) { errorProvider.SetError(tbDocumentInfo, "Заполните это поле!"); ret_val = false; }
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

            int abit_id = Find_id();
            if (abit_id == -1)
            {
                errorProvider.SetError(cbAbit, "Выберите абитуринта!");
                return;
            }
            string sql = "INSERT INTO military(M_abit, M_type, M_docinform) " +
                "VALUES (" + abit_id + ", '" + tbDocument.Text + "', '" + tbDocumentInfo.Text + "'); ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлена воинская обязанность", cbAbit.Text + " " + tbDocument.Text + " " + tbDocumentInfo.Text);
                MessageBox.Show("Воинская обязанность успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить воинскую обязанность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
