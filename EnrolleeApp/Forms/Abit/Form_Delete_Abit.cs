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
    public partial class Form_Delete_Abit : Form
    {
        public Form_Delete_Abit()
        {
            InitializeComponent();
        }

        private DataTable dtChangingAbit;
        private DataTable dtCurr;

        private void Form_Change_Abit_Load(object sender, EventArgs e)
        {

            cbChangingAbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            cbChangingAbit.Items.Clear();

            cbChangingAbit_Fill();
        }

        #region cbChangingAbit

        private void cbChangingAbit_Fill()
        {
            MainForm.DB.RunQuery("select FIO, id from abit order by FIO asc; ", out dtChangingAbit);

            foreach (DataRow i in dtChangingAbit.Rows)
            {
                cbChangingAbit.Items.Add(i[0].ToString());
            }
            if (cbChangingAbit.Items.Count != 0) cbChangingAbit.SelectedIndex = 0;
        }

        private void cbChangingAbit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ch_abit = Find_ChangingAbit_id();
            if (ch_abit == "-1")
            {
                errorProvider.SetError(cbChangingAbit, "Выберите абитуриента!");
                throw new ApplicationException();
            }

            string sql = "SELECT " +
                "abit.Reg, " +
                "abit.FIO, abit.Gender, abit.BirthDate, abit.BirthPlace, polity.Pol_title, abit.Pasp, abit.AdrReg, abit.AdrFact, abit.Phone, abit.Midball, lang.L_title, " +
                "prior1.S_title, prior2.S_title, prior3.S_title, abit.Date, base.B_title, abit.E_title, abit.E_yend, abit.E_doctype, " +
                "abit.E_docsernum, abit.E_docdate, abit.Discipline1, abit.Discipline2, abit.Discipline3, abit.Medpolis, abit.NeedHostel, " +
                "abit.S_orphan, abit.S_invalid, abit.S_objective, abit.S_contract " +
                "FROM abit " +
                "Left JOIN polity ON(polity.Pol_id = abit.Polity) " +
                "Left JOIN lang ON(lang.L_id = abit.Lang) " +
                "Left JOIN spec AS prior1 ON(prior1.S_id = abit.Prior1) " +
                "Left JOIN spec AS prior2 ON(prior2.S_id = abit.Prior2) " +
                "Left JOIN spec AS prior3 ON(prior3.S_id = abit.Prior3) " +
                "Left JOIN base ON(base.B_id = abit.E_base) " +
                "where abit.id = " + ch_abit + "; ";
            MainForm.DB.RunQuery(sql, out dtCurr);

            tbReg.Text = dtCurr.Rows[0][0].ToString();
            tbFIO.Text = dtCurr.Rows[0][1].ToString();
            tbSex.Text = dtCurr.Rows[0][2].ToString();
            tbBirthDate.Text = dtCurr.Rows[0][3].ToString();
            tbBirthPlace.Text = dtCurr.Rows[0][4].ToString();
            tbPolity.Text = dtCurr.Rows[0][5].ToString();
            tbPassport.Text = dtCurr.Rows[0][6].ToString();
            tbAdrReg.Text = dtCurr.Rows[0][7].ToString();
            tbAdrFact.Text = dtCurr.Rows[0][8].ToString();
            tbPhone.Text = dtCurr.Rows[0][9].ToString();
            tbMidball.Text = dtCurr.Rows[0][10].ToString();
            tbLang.Text = dtCurr.Rows[0][11].ToString();
            tbPrior1.Text = dtCurr.Rows[0][12].ToString();
            tbPrior2.Text = dtCurr.Rows[0][13].ToString();
            tbPrior3.Text = dtCurr.Rows[0][14].ToString();
            tbDate.Text = dtCurr.Rows[0][15].ToString();
            tbBase.Text = dtCurr.Rows[0][16].ToString();
            tbUnivTitle.Text = dtCurr.Rows[0][17].ToString();
            tbEndYear.Text = dtCurr.Rows[0][18].ToString();
            tbDocType.Text = dtCurr.Rows[0][19].ToString();
            tbDocSerNum.Text = dtCurr.Rows[0][20].ToString();
            tbDocDate.Text = dtCurr.Rows[0][21].ToString();
            tbMark1.Text = dtCurr.Rows[0][22].ToString();
            tbMark2.Text = dtCurr.Rows[0][23].ToString();
            tbMark3.Text = dtCurr.Rows[0][24].ToString();
            tbMedpolis.Text = dtCurr.Rows[0][25].ToString();
            if (dtCurr.Rows[0][26].ToString() == "1") cbHostel.Checked = true;
            else cbHostel.Checked = false;
            if (dtCurr.Rows[0][27].ToString() == "1") cbOrphan.Checked = true;
            else cbOrphan.Checked = false;
            if (dtCurr.Rows[0][28].ToString() == "1") cbInvalid.Checked = true;
            else cbInvalid.Checked = false;
            if (dtCurr.Rows[0][29].ToString() == "1") cbObjective.Checked = true;
            else cbObjective.Checked = false;
            if (dtCurr.Rows[0][30].ToString() == "1") cbContract.Checked = true;
            else cbContract.Checked = false;
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

            string msg = "При удалении абитуриента будут также потеряны связанные с ним записи в таблицах: " +
                "\nВоенная обязанность \nРодители \nСтатус \nРешения комиссии \n\n" +
                "Продолжить удаление?";
            if (!(MessageBox.Show(msg, "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)) return;

            string ch_abit = Find_ChangingAbit_id();
            if (ch_abit == "-1")
            {
                errorProvider.SetError(cbChangingAbit, "Выберите абитуриента!");
                throw new ApplicationException();
            }

            string sql = "DELETE FROM abit " +                
                "where abit.id = " + ch_abit + "; ";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Удален абитуриент", tbFIO.Text + "; Рег. номер: " + tbReg.Text);
                MessageBox.Show("Абитуриент успешно удален!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось удалить абитуриента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbMidball_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char i in tbMidball.Text)
            {
                if (i == ',')
                {
                    str += '.';
                }
                else
                {
                    str += i;
                }
            }
            tbMidball.Text = str;
        }
    }
}
