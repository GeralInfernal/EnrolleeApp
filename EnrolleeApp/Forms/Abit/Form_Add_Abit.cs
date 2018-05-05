using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EnrolleeApp
{
    public partial class Form_Add_Abit : Form
    {
        public Form_Add_Abit()
        {
            InitializeComponent();
        }

        private DataTable dtPolity;
        private DataTable dtLang;
        private DataTable dtPrior;
        private DataTable dtBase;

        private void Form_Add_Abit_Load(object sender, EventArgs e)
        {
            cbSex.SelectedIndex = 0;
            cbDocType.SelectedIndex = 0;
            dtpBirthDate.Value = DateTime.Now;
            dtpDate.Value = DateTime.Now;
            dtpDocDate.Value = DateTime.Now;

            cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbPolity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbPrior1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbPrior2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbPrior3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            cbPolity.Items.Clear();
            cbLang.Items.Clear();
            cbPrior1.Items.Clear();
            cbPrior2.Items.Clear();
            cbPrior3.Items.Clear();
            cbBase.Items.Clear();

            cbPolity_Fill();
            cbLang_Fill();
            cbPrior_Fill();
            cbBase_Fill();
        }

        #region cbPolity

        private void cbPolity_Fill()
        {
            MainForm.DB.RunQuery("select Pol_title, Pol_id from polity order by Pol_title asc; ", out dtPolity);

            foreach (DataRow i in dtPolity.Rows)
            {
                cbPolity.Items.Add(i[0].ToString());
            }
            if (cbPolity.Items.Count != 0) cbPolity.SelectedIndex = 0;
        }

        private string Find_Polity_id()
        {
            foreach (DataRow i in dtPolity.Rows)
            {
                if (cbPolity.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion

        #region cbLang

        private void cbLang_Fill()
        {
            MainForm.DB.RunQuery("select L_title, L_id from lang order by L_title asc; ", out dtLang);

            foreach (DataRow i in dtLang.Rows)
            {
                cbLang.Items.Add(i[0].ToString());
            }
            if (cbLang.Items.Count != 0) cbLang.SelectedIndex = 0;
        }

        private string Find_Lang_id()
        {
            foreach (DataRow i in dtLang.Rows)
            {
                if (cbLang.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion

        #region cbPrior

        private void cbPrior_Fill()
        {
            MainForm.DB.RunQuery("select S_title, S_id from spec order by S_title asc; ", out dtPrior);

            foreach (DataRow i in dtPrior.Rows)
            {
                cbPrior1.Items.Add(i[0].ToString());
                cbPrior2.Items.Add(i[0].ToString());
                cbPrior3.Items.Add(i[0].ToString());
            }
            if (cbPrior1.Items.Count != 0) cbPrior1.SelectedIndex = 0;
            if (cbPrior2.Items.Count != 0) cbPrior2.SelectedIndex = 0;
            if (cbPrior3.Items.Count != 0) cbPrior3.SelectedIndex = 0;
        }

        private string Find_Prior1_id()
        {
            foreach (DataRow i in dtPrior.Rows)
            {
                if (cbPrior1.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }
        private string Find_Prior2_id()
        {
            foreach (DataRow i in dtPrior.Rows)
            {
                if (cbPrior2.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }
        private string Find_Prior3_id()
        {
            foreach (DataRow i in dtPrior.Rows)
            {
                if (cbPrior3.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion

        #region cbBase

        private void cbBase_Fill()
        {
            MainForm.DB.RunQuery("select B_title, B_id from base order by B_title asc; ", out dtBase);

            foreach (DataRow i in dtBase.Rows)
            {
                cbBase.Items.Add(i[0].ToString());
            }
            if (cbBase.Items.Count != 0) cbBase.SelectedIndex = 0;
        }

        private string Find_Base_id()
        {
            foreach (DataRow i in dtBase.Rows)
            {
                if (cbBase.Text == i[0].ToString())
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
                if (tbReg.Text.Length > 10) { errorProvider.SetError(tbReg, "Регистрационный номер должен быть не более 10 символов!"); ret_val = false; }
                if (tbFIO.Text.Length > 50) { errorProvider.SetError(tbFIO, "ФИО абитуриента должен быть не более 50 символов!"); ret_val = false; }
                if (cbSex.Text.Length > 10) { errorProvider.SetError(cbSex, "Пол должен быть не более 10 символов!"); ret_val = false; }
                if (tbBirthPlace.Text.Length > 50) { errorProvider.SetError(tbBirthPlace, "Место рождения должно быть не более 50 символов!"); ret_val = false; }
                if (tbPassport.Text.Length > 100) { errorProvider.SetError(tbPassport, "Данные о паспорте должены быть не более 100 символов!"); ret_val = false; }
                if (tbAdrReg.Text.Length > 80) { errorProvider.SetError(tbAdrReg, "Адрес регистрации должен быть не более 80 символов!"); ret_val = false; }
                if (tbAdrFact.Text.Length > 80) { errorProvider.SetError(tbAdrFact, "Адрес проживания должен быть не более 80 символов!"); ret_val = false; }
                if (tbPhone.Text.Length > 20) { errorProvider.SetError(tbPhone, "Телефон должен быть не более 20 символов!"); ret_val = false; }
                if (tbMedpolis.Text.Length > 16) { errorProvider.SetError(tbMedpolis, "Данные о медицинском полисе должены быть не более 16 символов!"); ret_val = false; }
                if (tbUnivTitle.Text.Length > 100) { errorProvider.SetError(tbUnivTitle, "Название оконченного учреждения должено быть не более 100 символов!"); ret_val = false; }
                if (tbEndYear.Text.Length > 4) { errorProvider.SetError(tbEndYear, "Год должен быть не более 4 символов!"); ret_val = false; }
                if (cbDocType.Text.Length > 20) { errorProvider.SetError(cbDocType, "Тип документа об образовании должен быть не более 20 символов!"); ret_val = false; }
                if (tbDocSerNum.Text.Length > 20) { errorProvider.SetError(tbDocSerNum, "Серия и номер документа об образовании должен быть не более 20 символов!"); ret_val = false; }

                if (tbReg.Text.Length == 0) { errorProvider.SetError(tbReg, "Заполните это поле!"); ret_val = false; }
                if (tbFIO.Text.Length == 0) { errorProvider.SetError(tbFIO, "Заполните это поле!"); ret_val = false; }
                if (cbSex.Text.Length == 0) { errorProvider.SetError(cbSex, "Заполните это поле!"); ret_val = false; }
                if (tbBirthPlace.Text.Length == 0) { errorProvider.SetError(tbBirthPlace, "Заполните это поле!"); ret_val = false; }
                if (cbPolity.Text.Length == 0) { errorProvider.SetError(cbPolity, "Заполните это поле!"); ret_val = false; }
                if (tbPassport.Text.Length == 0) { errorProvider.SetError(tbPassport, "Заполните это поле!"); ret_val = false; }
                if (tbAdrReg.Text.Length == 0) { errorProvider.SetError(tbAdrReg, "Заполните это поле!"); ret_val = false; }
                if (tbAdrFact.Text.Length == 0) { errorProvider.SetError(tbAdrFact, "Заполните это поле!"); ret_val = false; }
                if (tbPhone.Text.Length == 0) { errorProvider.SetError(tbPhone, "Заполните это поле!"); ret_val = false; }
                if (tbMedpolis.Text.Length == 0) { errorProvider.SetError(tbMedpolis, "Заполните это поле!"); ret_val = false; }
                if (cbLang.Text.Length == 0) { errorProvider.SetError(cbLang, "Заполните это поле!"); ret_val = false; }
                if (cbPrior1.Text.Length == 0) { errorProvider.SetError(cbPrior1, "Заполните это поле!"); ret_val = false; }
                if (cbPrior2.Text.Length == 0) { errorProvider.SetError(cbPrior2, "Заполните это поле!"); ret_val = false; }
                if (cbPrior3.Text.Length == 0) { errorProvider.SetError(cbPrior3, "Заполните это поле!"); ret_val = false; }
                if (cbBase.Text.Length == 0) { errorProvider.SetError(cbBase, "Заполните это поле!"); ret_val = false; }
                if (tbUnivTitle.Text.Length == 0) { errorProvider.SetError(tbUnivTitle, "Заполните это поле!"); ret_val = false; }
                if (tbEndYear.Text.Length == 0) { errorProvider.SetError(tbEndYear, "Заполните это поле!"); ret_val = false; }
                if (cbDocType.Text.Length == 0) { errorProvider.SetError(cbDocType, "Заполните это поле!"); ret_val = false; }
                if (tbMidball.Text.Length == 0) { errorProvider.SetError(tbMidball, "Заполните это поле!"); ret_val = false; }
                if (tbMark1.Text.Length == 0) { errorProvider.SetError(tbMark1, "Заполните это поле!"); ret_val = false; }
                if (tbMark2.Text.Length == 0) { errorProvider.SetError(tbMark2, "Заполните это поле!"); ret_val = false; }
                if (tbMark3.Text.Length == 0) { errorProvider.SetError(tbMark3, "Заполните это поле!"); ret_val = false; }

                try { if (Convert.ToInt32(tbMark1.Text) > 5 || Convert.ToInt32(tbMark1.Text) < 2) { errorProvider.SetError(tbMark1, "Некорректный ввод!"); ret_val = false; } }
                catch { errorProvider.SetError(tbMark1, "Некорректный ввод!"); return false; }
                try { if (Convert.ToInt32(tbMark2.Text) > 5 || Convert.ToInt32(tbMark2.Text) < 2) { errorProvider.SetError(tbMark2, "Некорректный ввод!"); ret_val = false; } }
                catch { errorProvider.SetError(tbMark2, "Некорректный ввод!"); return false; }
                try { if (Convert.ToInt32(tbMark3.Text) > 5 || Convert.ToInt32(tbMark3.Text) < 2) { errorProvider.SetError(tbMark3, "Некорректный ввод!"); ret_val = false; } }
                catch { errorProvider.SetError(tbMark3, "Некорректный ввод!"); return false; }
                try { if (Convert.ToDouble(tbMidball.Text) > 5 || Convert.ToDouble(tbMidball.Text) < 2) { errorProvider.SetError(tbMidball, "Некорректный ввод!"); ret_val = false; } }
                catch { errorProvider.SetError(tbMidball, "Некорректный ввод!"); return false; }
                try { if (Convert.ToInt32(tbEndYear.Text) > 2100 || Convert.ToInt32(tbEndYear.Text) < 1900) { errorProvider.SetError(tbEndYear, "Некорректный ввод!"); ret_val = false; } }
                catch { errorProvider.SetError(tbEndYear, "Некорректный ввод!"); return false; }

                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool Get_bool_and_date_values(out string polity_id, out string lang_id, out string prior1, out string prior2, out string prior3, out string base_id)
        {
            try
            {
                polity_id = Find_Polity_id();
                if (polity_id == "-1")
                {
                    errorProvider.SetError(cbPolity, "Выберите гражданство!");
                    throw new ApplicationException();
                }

                lang_id = Find_Lang_id();
                if (lang_id == "-1")
                {
                    errorProvider.SetError(cbLang, "Выберите иностранный язык!");
                    throw new ApplicationException();
                }

                prior1 = Find_Prior1_id();
                if (prior1 == "-1")
                {
                    errorProvider.SetError(cbPrior1, "Выберите приоритет специальности!");
                    throw new ApplicationException();
                }

                prior2 = Find_Prior2_id();
                if (prior2 == "-1")
                {
                    errorProvider.SetError(cbPrior2, "Выберите приоритет специальности!");
                    throw new ApplicationException();
                }

                prior3 = Find_Prior3_id();
                if (prior3 == "-1")
                {
                    errorProvider.SetError(cbPrior3, "Выберите приоритет специальности!");
                    throw new ApplicationException();
                }

                base_id = Find_Base_id();
                if (base_id == "-1")
                {
                    errorProvider.SetError(cbBase, "Выберите базу образования!");
                    throw new ApplicationException();
                }
                return true;
            }
            catch
            {
                polity_id = null;
                lang_id = null;
                prior1 = null;
                prior2 = null;
                prior3 = null;
                base_id = null;
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;

            string polity_id, lang_id, prior1, prior2, prior3, base_id;
            if (!Get_bool_and_date_values(out polity_id, out lang_id, out prior1, out prior2, out prior3, out base_id)) return;

            string date = dtpDate.Value.Year.ToString() + "-" + dtpDate.Value.Month.ToString() + "-" + dtpDate.Value.Day.ToString();
            string birth_date = dtpBirthDate.Value.Year.ToString() + "-" + dtpBirthDate.Value.Month.ToString() + "-" + dtpBirthDate.Value.Day.ToString();
            string doc_date = dtpDocDate.Value.Year.ToString() + "-" + dtpDocDate.Value.Month.ToString() + "-" + dtpDocDate.Value.Day.ToString();

            string hostel, orphan, invalid, objective, contract;
            if (cbHostel.Checked) hostel = "1";
            else hostel = "0";
            if (cbOrphan.Checked) orphan = "1";
            else orphan = "0";
            if (cbInvalid.Checked) invalid = "1";
            else invalid = "0";
            if (cbObjective.Checked) objective = "1";
            else objective = "0";
            if (cbContract.Checked) contract = "1";
            else contract = "0";

            string sql = "INSERT INTO abit " +
                "values " +
                "(NULL, '" + tbReg.Text +"', '" + tbFIO.Text +"', '" + cbSex.Text +"', " +
                "'" + birth_date + "', '" + tbBirthPlace.Text + "', " + polity_id + ", " +
                "'" + tbPassport.Text + "', '" + tbAdrReg.Text + "', '" + tbAdrFact.Text + "', '" + tbPhone.Text + "', " +
                "" + tbMidball.Text + ", " + lang_id + ", " + hostel + ", " + prior1 + ", " + prior2 + ", " + prior3 + ", " + "NULL" + ", " +
                "" + "NULL" + ", '" + date + "', " + base_id + ", '" + tbUnivTitle.Text + "', '" + tbEndYear.Text + "', '" + cbDocType.Text + "', " +
                "'" + tbDocSerNum.Text + "', '" + doc_date + "', " + tbMark1.Text + ", " + tbMark2.Text + ", " + tbMark3.Text + ", " +
                "'" + tbMedpolis.Text + "', " + orphan + ", " + invalid + ", " + objective + ", " + contract + "); ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Добавлен абитуриент", tbFIO.Text + "; Рег. номер: " + tbReg.Text);
                MessageBox.Show("Абитуриент успешно добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось добавить абитуриента!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValues()) return;

                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\Report templates\\report_abit.docx");
                    ReplaseWords("{abit}", tbFIO.Text, wordDocument);
                    ReplaseWords("{reg}", tbReg.Text, wordDocument);
                    ReplaseWords("{sex}", cbSex.Text, wordDocument);
                    ReplaseWords("{birthdate}", dtpBirthDate.Value.ToShortDateString(), wordDocument);
                    ReplaseWords("{birthplace}", tbBirthPlace.Text, wordDocument);
                    ReplaseWords("{polity}", cbPolity.Text, wordDocument);
                    ReplaseWords("{passport}", tbPassport.Text, wordDocument);
                    ReplaseWords("{adrreg}", tbAdrReg.Text, wordDocument);
                    ReplaseWords("{adrfact}", tbAdrFact.Text, wordDocument);
                    ReplaseWords("{phone}", tbPhone.Text, wordDocument);
                    ReplaseWords("{medpolis}", tbMedpolis.Text, wordDocument);
                    ReplaseWords("{lang}", cbLang.Text, wordDocument);
                    ReplaseWords("{date}", dtpDate.Value.ToShortDateString(), wordDocument);
                    ReplaseWords("{spec1}", cbPrior1.Text, wordDocument);
                    ReplaseWords("{spec2}", cbPrior2.Text, wordDocument);
                    ReplaseWords("{spec3}", cbPrior3.Text, wordDocument);
                    ReplaseWords("{base}", cbBase.Text, wordDocument);
                    ReplaseWords("{univ}", tbUnivTitle.Text, wordDocument);
                    ReplaseWords("{endyear}", tbEndYear.Text, wordDocument);
                    ReplaseWords("{doctype}", cbDocType.Text, wordDocument);
                    ReplaseWords("{midball}", tbMidball.Text, wordDocument);
                    ReplaseWords("{mark1}", tbMark1.Text, wordDocument);
                    ReplaseWords("{mark2}", tbMark2.Text, wordDocument);
                    ReplaseWords("{mark3}", tbMark3.Text, wordDocument);
                    ReplaseWords("{sernum}", tbDocSerNum.Text, wordDocument);
                    ReplaseWords("{docdate}", dtpDocDate.Value.ToShortDateString(), wordDocument);

                    string hostel, orphan, invalid, objective, contract;
                    if (cbHostel.Checked) hostel = "Нуждается в общежитии; ";
                    else hostel = null;
                    if (cbOrphan.Checked) orphan = "Является сиротой; ";
                    else orphan = null;
                    if (cbInvalid.Checked) invalid = "Является сиротой; ";
                    else invalid = null;
                    if (cbObjective.Checked) objective = "Является сиротой; ";
                    else objective = null;
                    if (cbContract.Checked) contract = "Обучение на платной основе; ";
                    else contract = null;
                    ReplaseWords("{hostel}", hostel, wordDocument);
                    ReplaseWords("{orphan}", orphan, wordDocument);
                    ReplaseWords("{invalid}", invalid, wordDocument);
                    ReplaseWords("{objective}", objective, wordDocument);
                    ReplaseWords("{contract}", contract, wordDocument);

                    wordDocument.SaveAs(@sfdExport.FileName);
                    wordDocument.Close();
                    MessageBox.Show("Файл успешно сохранен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStatement_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValues()) return;

                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_statement.docx");
                    ReplaseWords("{FIO}", tbFIO.Text, wordDocument);
                    ReplaseWords("{address}", tbAdrFact.Text, wordDocument);
                    ReplaseWords("{phone}", tbPhone.Text, wordDocument);
                    string contract;
                    if (cbContract.Checked) contract = "очную ";
                    else contract = "заочную ";
                    ReplaseWords("{contract}", contract, wordDocument);
                    ReplaseWords("{spec1}", cbPrior1.Text, wordDocument);
                    ReplaseWords("{spec2}", cbPrior2.Text, wordDocument);
                    ReplaseWords("{spec3}", cbPrior3.Text, wordDocument);
                    ReplaseWords("{birthdate}", dtpBirthDate.Value.ToShortDateString(), wordDocument);
                    ReplaseWords("{birthplace}", tbBirthPlace.Text, wordDocument);
                    ReplaseWords("{passport}", tbPassport.Text, wordDocument);
                    ReplaseWords("{polity}", cbPolity.Text, wordDocument);
                    ReplaseWords("{doc_date}", dtpDocDate.Value.ToShortDateString(), wordDocument);
                    string hostel;
                    if (cbHostel.Checked) hostel = "Да";
                    else hostel = "Нет";
                    ReplaseWords("{hostel}", hostel, wordDocument);
                    ReplaseWords("{lang}", cbLang.Text, wordDocument);
                    string orphan;
                    if (cbOrphan.Checked) orphan = "Да";
                    else orphan = "Нет";
                    ReplaseWords("{orphan}", orphan, wordDocument);
                    string invalid;
                    if (cbInvalid.Checked) invalid = "Да";
                    else invalid = "Нет";
                    ReplaseWords("{invalid}", invalid, wordDocument);
                    ReplaseWords("{date}", dtpDate.Value.ToShortDateString(), wordDocument);

                    wordDocument.SaveAs(@sfdExport.FileName);
                    wordDocument.Close();
                    MessageBox.Show("Файл успешно сохранен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaseWords(string to_replace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: to_replace, ReplaceWith: text);
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
