using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EnrolleeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Users curr_user = new Users();

        private static Sqlce_db sqlce_db = new Sqlce_db();
        private static Mysql_db mysql_db = new Mysql_db();

        private EventLog event_log;
        private About about;

        #region Буфер для таблиц

        private DataTable dtAbit;
        private DataTable dtParents;
        private DataTable dtStatus;
        private DataTable dtMilitary;
        private DataTable dtBase;
        private DataTable dtDiscipline;
        private DataTable dtSpec;
        private DataTable dtLang;
        private DataTable dtKomis;
        private DataTable dtPolity;
        private DataTable dtDecision;
        private DataTable dtGroups;

        #endregion

        #region Буфер для выпадающих списков

        private DataTable dtAbit_cb;
        private DataTable dtDiscipline_cb;
        private DataTable dtKomis_cb;
        private DataTable dtGroups_cb;
        private DataTable dtSpec_cb;

        #endregion

        #region Буфер для списков

        private DataTable dtGroups_Candidates;
        private DataTable dtGroups_Formed;
        private DataTable dtAbit_Candidates;
        private DataTable dtAbit_Preliminary;
        private DataTable dtAbit_Formed;

        #endregion

        public static Sqlce_db LocalDB { get => sqlce_db; set => sqlce_db = value; }
        public static Mysql_db DB { get => mysql_db; set => mysql_db = value; }

        public enum Users
        {
            Admin = 0,
            User = 1            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Visible == true)
            {
                if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверидите действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
            LocalDB.CloseConnection();
            DB.CloseConnection();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //обновляю БД
            LocalDB.Sqlce_Upgrade();

            //выполняю стандартную процедуру загрузки
            if (!Load_Procedure())
            {
                this.Close();
                return;
            }

            //выполняю загрузку данных в выпадающие списки
            dtAbit_cb_Fill();
            dtDiscipline_cb_Fill();
            dtKomis_cb_Fill();
            dtGroups_cb_Fill();
            dtSpec_cb_Fill();

            //выполняю загрузку данных в списки
            lvGroups_Candidates_Fill();
            lvGroups_Formed_Fill();

            //Загружаю данные в таблицы
            dgvAbit_Fill();
            dgvParents_Fill();
            dgvStatus_Fill();
            dgvMilitary_Fill();
            dgvSpec_Fill();
            dgvDiscipline_Fill();
            dgvBase_Fill();
            dgvLang_Fill();
            dgvKomis_Fill();
            dgvPolity_Fill();
            dgvDecision_Fill();
            dgvGroups_Fill();

            //Загружаю сортировку и фильтрацию
            SortAndFilterIni_Abit();
            SortAndFilterIni_Parent();
            SortAndFilterIni_Status();
            SortAndFilterIni_Military();
            SortAndFilterIni_Spec();
            SortAndFilterIni_Discipline();
            SortAndFilterIni_Base();
            SortAndFilterIni_Lang();
            SortAndFilterIni_Komis();
            SortAndFilterIni_Polity();
            SortAndFilterIni_Decision();
            SortAndFilterIni_Groups();

            //собираю статистику
            Update_Abit_Stats();
            Update_Parent_Stats();
            Update_Status_Stats();
            Update_Military_Stats();
            Update_Base_Stats();
            Update_Lang_Stats();
            Update_Komis_Stats();
            Update_Polity_Stats();
            Update_Spec_Stats();
            Update_Discipline_Stats();
            Update_Decision_Stats();
            Update_Groups_Stats();
        }


        /// <summary>
        /// Процедура загрузки формы
        /// </summary>
        /// <returns></returns>
        private bool Load_Procedure()
        {
            try
            {
                this.Hide();
                //открываю соединение
                if (!LocalDB.OpenConnection())
                {
                    this.Close();
                    return false;
                }
                //узнаю, имеется ли блокировка

                //запрашиваю пароль
                Authorization login = new Authorization();
                switch (login.ShowDialog())
                {
                    case DialogResult.Cancel:
                        this.Close();
                        return false;
                    case DialogResult.Yes:
                        curr_user = Users.Admin;
                        break;
                    case DialogResult.No:
                        curr_user = Users.User;
                        break;
                }

                //получаю идентификатор текущей таблицы
                string conn_id;
                if (!LocalDB.Get_curr_preset_id(out conn_id))
                {
                    this.Close();
                    return false;
                }

                if (conn_id != null)
                {
                    DataTable dtPreset = new DataTable();
                    if (!LocalDB.Get_curr_preset(conn_id, out dtPreset))
                    {
                        return false;
                    }
                    
                    if(curr_user == Users.User)
                    {
                        if (DB.ConnectToDatabase(dtPreset.Rows[0][1].ToString(), dtPreset.Rows[0][2].ToString(), dtPreset.Rows[0][3].ToString(),
                            dtPreset.Rows[0][4].ToString(), dtPreset.Rows[0][5].ToString()))
                        {
                            DB.Add_log("Авторизация", "Автоматическое подключение");
                        }
                        else
                        {
                            string msg = "Не удалось выполнить автоматическое подключение! \nОбратитесь к администратору за помощью в настройке подключения к базе данных.";
                            MessageBox.Show(msg, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        OnUserLogon();
                    }


                    if (curr_user == Users.Admin)
                    {
                        //если используется автоподключение
                        if (Convert.ToInt32(dtPreset.Rows[0][6]) == 1)
                        {
                            if (DB.ConnectToDatabase(dtPreset.Rows[0][1].ToString(), dtPreset.Rows[0][2].ToString(), dtPreset.Rows[0][3].ToString(),
                                dtPreset.Rows[0][4].ToString(), dtPreset.Rows[0][5].ToString()))
                            {
                                DB.Add_log("Авторизация", "Автоматическое подключение");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось выполнить автоматическое подключение!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SetConnection set = new SetConnection();
                                if (set.ShowDialog() == DialogResult.Cancel) { return false; }
                                else { DB.Add_log("Авторизация", "Подключение вручную"); }
                            }
                        }
                        else
                        {
                            SetConnection set = new SetConnection();
                            if (set.ShowDialog() == DialogResult.Cancel) { return false; }
                            else { DB.Add_log("Авторизация", "Подключение вручную"); }
                        }
                        OnAdminLogon();
                    }
                }

                this.Show();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region Инициализация пользователя

        private void OnAdminLogon()
        {
            tsmiUser.Text = "Администратор";
            tsmiMenu_Connection.Visible = true;
            tsmiMenu_EventLog.Visible = true;
        }

        private void OnUserLogon()
        {
            tsmiUser.Text = "Пользователь";
            tsmiMenu_Connection.Visible = false;
            tsmiMenu_EventLog.Visible = false;
        }

        #endregion



        #region Статистические данные

        public void Update_Abit_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(id) from abit; ", out result);
            l_stats_abitCount.Text = "Всего абитуриентов: " + result;

            DB.RunAggregateQuery("SELECT count(id) from abit where YEAR(abit.Date) = YEAR(NOW()); ", out result);
            l_stats_AbitCountCurr.Text = "В текущем текущем году: " + result;

            DB.RunAggregateQuery("SELECT count(id) from abit where Gender like 'Мужской'; ", out result);
            l_stats_Male.Text = "Мужчин: " + result;

            DB.RunAggregateQuery("SELECT count(id) from abit where Gender like 'Женский'; ", out result);
            l_stats_Female.Text = "Женщин: " + result;

            DB.RunAggregateQuery("SELECT TRUNCATE(avg(midball),2) from abit; ", out result);
            l_stats_Midball.Text = "Средний проходной балл: " + result;

            DB.RunAggregateQuery("SELECT TRUNCATE(avg(midball),2) from abit where YEAR(abit.Date) = YEAR(NOW()); ", out result);
            l_stats_MidballCurr.Text = "В текущем году: " + result;

            DB.RunAggregateQuery("SELECT count(id) from abit where NeedHostel = 1; ", out result);
            l_stats_NeedHostel.Text = "Нуждаются в общежитии: " + result;

            DB.RunAggregateQuery("SELECT count(id) from abit where NeedHostel = 1 and YEAR(abit.Date) = YEAR(NOW()); ", out result);
            l_stats_NeedHostelCurr.Text = "В текущем году: " + result;

            DB.RunAggregateQuery("SELECT count(id) from abit where S_contract = 1; ", out result);
            l_stats_Contract.Text = "На платной основе: " + result;

            DB.RunAggregateQuery("SELECT count(id) from abit where S_contract = 1 and YEAR(abit.Date) = YEAR(NOW()); ", out result);
            l_stats_Invalid.Text = "Инвалиды: " + result;

            DB.RunAggregateQuery("SELECT count(S_orphan) from abit WHERE S_orphan = 1; ", out result);
            l_stats_Orphan.Text = "Сироты: " + result; 

            DB.RunAggregateQuery("SELECT count(S_objective) from abit WHERE S_objective = 1; ", out result);
            l_stats_Objective.Text = "По целевому контракту: " + result;
        }
        public void Update_Parent_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(P_id) from parent; ", out result);
            l_stats_ParentCount.Text = "Всего родителей: " + result;
        }

        public void Update_Status_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(St_id) from status; ", out result);
            l_stats_StatusCount.Text = "Всего записей: " + result;
        }

        public void Update_Military_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(M_id) from military; ", out result);
            l_stats_Military.Text = "Всего записей: " + result;
        }
  
        public void Update_Base_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(B_id) from base; ", out result);
            l_stats_BaseCount.Text = "Всего записей: " + result;
        }

        public void Update_Lang_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(L_id) from lang; ", out result);
            l_stats_LangCount.Text = "Всего языков: " + result;
        }

        public void Update_Komis_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(K_id) from komis; ", out result);
            l_stats_KomisCount.Text = "Всего записей: " + result;
        }

        public void Update_Polity_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(Pol_id) from polity; ", out result);
            l_stats_PolityCount.Text = "Всего государств: " + result;
        }

        public void Update_Spec_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(S_id) from spec; ", out result);
            l_stats_SpecCount.Text = "Всего специальностей: " + result;

            DB.RunAggregateQuery("SELECT count(S_id) from spec where S_ochn = 1; ", out result);
            l_stats_SpecOchn.Text = "Очные: " + result;

            DB.RunAggregateQuery("SELECT count(S_id) from spec where S_ochn = 0; ", out result);
            l_stats_SpecZaochn.Text = "Заочные: " + result;

            DB.RunAggregateQuery("SELECT count(S_id) from spec where S_budjet = 1; ", out result);
            l_stats_SpecBudjet.Text = "На бюджет: " + result;

            DB.RunAggregateQuery("SELECT count(S_id) from spec where S_budjet = 0; ", out result);
            l_stats_SpecChargeable.Text = "На платной основе: " + result;
        }

        public void Update_Discipline_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(D_id) from discipline; ", out result);
            l_stats_DisciplineCount.Text = "Всего государств: " + result;
        }

        public void Update_Decision_Stats()
        {
            string result;
            DB.RunAggregateQuery("SELECT count(Des_id) from decision; ", out result);
            l_DecisionCount.Text = "Всего решений: " + result;

            DB.RunAggregateQuery("SELECT TRUNCATE(count(Des_id)/(SELECT count(id) from abit) * 100, 2) from decision; ", out result);
            l_DecisionPercent.Text = "Процент: " + result;

            DB.RunAggregateQuery("SELECT count(Des_id) from decision where YEAR(Des_date) = YEAR(NOW()); ", out result);
            l_DecisionCountYear.Text = "В текущем текущем году: " + result;

            DB.RunAggregateQuery("SELECT TRUNCATE(count(Des_id)/(SELECT count(id) from abit) * 100, 2) from decision where YEAR(Des_date) = YEAR(NOW()); ", out result);
            l_DecisionPercentYear.Text = "Процент: " + result;
        }

        public void Update_Groups_Stats()
        {

        }

        #endregion

        #region Для выпадающих списков

        private void dtAbit_cb_Fill()
        {
            cbAbit_Military.Items.Clear();
            cbAbit_Parent.Items.Clear();
            cbAbit_Status.Items.Clear();

            DB.RunQuery("Select FIO, id from abit order by FIO asc; ", out dtAbit_cb);

            foreach (DataRow i in dtAbit_cb.Rows)
            {
                cbAbit_Military.Items.Add(i[0].ToString());
                cbAbit_Parent.Items.Add(i[0].ToString());
                cbAbit_Status.Items.Add(i[0].ToString());
            }
            if (cbAbit_Military.Items.Count != 0) cbAbit_Military.SelectedIndex = 0;
            if (cbAbit_Parent.Items.Count != 0) cbAbit_Parent.SelectedIndex = 0;
            if (cbAbit_Status.Items.Count != 0) cbAbit_Status.SelectedIndex = 0;
        }

        private void dtDiscipline_cb_Fill()
        {
            cbDiscipline1_Spec.Items.Clear();
            cbDiscipline2_Spec.Items.Clear();
            cbDiscipline3_Spec.Items.Clear();

            DB.RunQuery("SELECT D_title, D_id from discipline;", out dtDiscipline_cb);

            foreach (DataRow i in dtDiscipline_cb.Rows)
            {
                cbDiscipline1_Spec.Items.Add(i[0].ToString());
                cbDiscipline2_Spec.Items.Add(i[0].ToString());
                cbDiscipline3_Spec.Items.Add(i[0].ToString());
            }
            if (cbDiscipline1_Spec.Items.Count != 0) cbDiscipline1_Spec.SelectedIndex = 0;
            if (cbDiscipline2_Spec.Items.Count != 0) cbDiscipline2_Spec.SelectedIndex = 0;
            if (cbDiscipline3_Spec.Items.Count != 0) cbDiscipline3_Spec.SelectedIndex = 0;
        }

        private void dtKomis_cb_Fill()
        {
            cbKomis_Decision.Items.Clear();

            DB.RunQuery("select K_FIO, K_id from komis order by K_FIO asc; ", out dtKomis_cb);

            foreach (DataRow i in dtKomis_cb.Rows)
            {
                cbKomis_Decision.Items.Add(i[0].ToString());
            }
            if (cbKomis_Decision.Items.Count != 0) cbKomis_Decision.SelectedIndex = 0;
        }

        private void dtGroups_cb_Fill()
        {
            cbGroup_Decision.Items.Clear();

            DB.RunQuery("Select gr_name, gr_id from groups order by gr_name asc; ", out dtGroups_cb);

            cbGroup_Decision.Items.Add("Нет");

            foreach (DataRow i in dtGroups_cb.Rows)
            {
                cbGroup_Decision.Items.Add(i[0].ToString());
            }
            if (cbGroup_Decision.Items.Count != 0) cbGroup_Decision.SelectedIndex = 0;
        }

        private void dtSpec_cb_Fill()
        {
            cbSpec_Groups.Items.Clear();

            DB.RunQuery("Select S_title, S_id from spec order by S_title asc; ", out dtSpec_cb);

            foreach (DataRow i in dtSpec_cb.Rows)
            {
                cbSpec_Groups.Items.Add(i[0].ToString());
            }
            if (cbSpec_Groups.Items.Count != 0) cbSpec_Groups.SelectedIndex = 0;
        }

        private void lvGroups_Candidates_Fill()
        {
            lvGroups_Candidates.Items.Clear();
            lvGroups_Preliminary.Items.Clear();

            DB.RunQuery("Select gr_name, gr_id from groups where groups.gr_year = year(now()) order by gr_name asc; ", out dtGroups_Candidates);

            foreach (DataRow i in dtGroups_Candidates.Rows)
            {
                lvGroups_Candidates.Items.Add(i[0].ToString());
                lvGroups_Preliminary.Items.Add(i[0].ToString());
            }
            if (lvGroups_Candidates.Items.Count != 0) lvGroups_Candidates.Items[0].Selected = true;
            if (lvGroups_Preliminary.Items.Count != 0) lvGroups_Preliminary.Items[0].Selected = true;
        }

        private void lvGroups_Formed_Fill()
        {
            lvGroups_Formed.Items.Clear();

            DB.RunQuery("Select gr_name, gr_id from groups order by gr_name asc; ", out dtGroups_Formed);

            foreach (DataRow i in dtGroups_Formed.Rows)
            {
                lvGroups_Formed.Items.Add(i[0].ToString());
            }
            if (lvGroups_Formed.Items.Count != 0) lvGroups_Formed.Items[0].Selected = true;
        }

        #endregion

        #region Экспорт в Word

        private void ExportTable(string title, DataGridView dgv)
        {
            try
            {
                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_table.docx");
                    ReplaseWords("{title}", title, wordDocument);
                    ReplaseWordsToTable("{table}", dgv, wordDocument);
                    ReplaseWords("{curr_date}", DateTime.Now.ToLongDateString(), wordDocument);

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

        private void ReplaseWordsToTable(string to_replace, DataGridView dgv, Word.Document wordDocument)
        {
            try
            {
                var range = wordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "{table}");

                Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
                Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;
                int rows = dgv.DisplayedRowCount(false) + 1;
                int columns = dgv.DisplayedColumnCount(false);
                wordDocument.Tables.Add(range, rows - 1, columns, ref behiavor, ref autoFitBehiavor);

                int b = 1;
                foreach (DataGridViewColumn i in dgv.Columns)
                {
                    wordDocument.Tables[1].Cell(1, b).Range.Text = i.Name;
                    wordDocument.Tables[1].Cell(1, b).Range.Bold = 1;
                    wordDocument.Tables[1].Cell(1, b).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    wordDocument.Tables[1].Cell(1, b).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    b++;
                }

                for (int i = 0; i < rows - 2; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        wordDocument.Tables[1].Cell(i + 2, j + 1).Range.Text = dgv.Rows[i].Cells[j].Value.ToString();
                        wordDocument.Tables[1].Cell(i + 2, j + 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        wordDocument.Tables[1].Cell(i + 2, j + 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    }
                }
            }
            catch
            {

            }
        }

        private void ReplaseWordsToTable(string to_replace, DataTable dt, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: "{table}");

            Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;

            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;
            wordDocument.Tables.Add(range, rows + 1, columns, ref behiavor, ref autoFitBehiavor);

            int b = 1;
            foreach (DataColumn i in dt.Columns)
            {
                wordDocument.Tables[1].Cell(1, b).Range.Text = i.ColumnName;
                wordDocument.Tables[1].Cell(1, b).Range.Bold = 1;
                wordDocument.Tables[1].Cell(1, b).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                wordDocument.Tables[1].Cell(1, b).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                b++;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    wordDocument.Tables[1].Cell(i + 2, j + 1).Range.Text = dt.Rows[i][j].ToString();
                    wordDocument.Tables[1].Cell(i + 2, j + 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    wordDocument.Tables[1].Cell(i + 2, j + 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                }
            }
        }

        #endregion

        #region Меню



        #region Подключение

        private void tsmiChangeConnections_Click(object sender, EventArgs e)
        {
            Presets pr = new Presets();
            pr.ShowDialog();
        }

        private void tsmiDisconnect_Click(object sender, EventArgs e)
        {
            LocalDB.CloseConnection();
            DB.CloseConnection();
            if (!Load_Procedure()) return;
        }

        #endregion

        #region Журнал событий

        private void tsmiEventLog_Click(object sender, EventArgs e)
        {
            if (event_log != null && !event_log.IsDisposed && event_log.Visible)
            {
                event_log.Focus();
                return;
            }
            event_log = new EventLog();
            event_log.Show();
        }

        private void tsmi_LocalEventLog_Click(object sender, EventArgs e)
        {
            LocalEventLog local_event_log = new LocalEventLog();
            local_event_log.Show();
        }

        #endregion

        #region Справка
        private void tsmiContent_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(System.IO.Directory.GetCurrentDirectory() + "\\EnrolleeAppHelp.chm");
            }
            catch
            {
                MessageBox.Show("Не удается найти файл справки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsciAbout_Click(object sender, EventArgs e)
        {
            if (about != null && !about.IsDisposed && about.Visible)
            {
                about.Focus();
                return;
            }
            about = new About();
            about.Show();
            
        }

        #endregion

        #region Пользователь

        private void tsmiChangePass_Click_1(object sender, EventArgs e)
        {
            new ChangePass().ShowDialog();
        }

        #endregion



        #endregion



        #region Абитуриент



        #region Инициализация данных

        private void dgvAbit_Fill()
        {
            string sql = "SELECT " +
                           "abit.id AS 'Идентификатор', " +
                           "abit.Reg AS 'Регистрационный номер', " +
                           "abit.FIO AS 'ФИО', " +
                           "abit.Gender AS 'Пол', " +
                           "DATE_FORMAT(abit.BirthDate, '%d.%m.%Y') AS 'Дата рождения', " +
                           "abit.BirthPlace AS 'Место рождения', " +
                           "polity.Pol_title AS 'Гражданство', " +
                           "abit.Pasp AS 'О паспорте', " +
                           "abit.AdrReg AS 'Адрес регистрации', " +
                           "abit.AdrFact AS 'Адрес проживания', " +
                           "abit.Phone AS 'Номер телефона', " +
                           "abit.Midball AS 'Средний балл', " +
                           "lang.L_title AS 'Изученный иностр. язык', " +
                           "IF(abit.NeedHostel >= 1, 'Да', 'Нет') AS 'Общежитие', " +
                           "prior1.S_title AS 'Приоритет 1', " +
                           "prior2.S_title AS 'Приоритет 2', " +
                           "prior3.S_title AS 'Приоритет 3', " +
                           "DATE_FORMAT(abit.DocBack, '%d.%m.%Y') AS 'Выдача документов', " +
                           "DATE_FORMAT(abit.Date, '%d.%m.%Y') AS 'Заявление подано', " +
                           "base.B_title AS 'База образования', " +
                           "abit.E_title AS 'Наименование учреждения', " +
                           "abit.E_yend AS 'Год окончания', " +
                           "abit.E_doctype AS 'Тип документа', " +
                           "abit.E_docsernum AS 'Серия и номер документа', " +
                           "abit.E_docdate AS 'Дата выдачи документа', " +
                           "abit.Discipline1 AS 'Оценка 1', " +
                           "abit.Discipline2 AS 'Оценка 2', " +
                           "abit.Discipline3 AS 'Оценка 3', " +
                           "abit.Medpolis AS 'Медицинский полис', " +
                           "IF(abit.S_orphan >= 1, 'Да', 'Нет') AS 'Сирота', " +
                           "IF(abit.S_invalid >= 1, 'Да', 'Нет') AS 'Инвалид', " +
                           "IF(abit.S_objective >= 1, 'Да', 'Нет') AS 'Контракт', " +
                           "IF(abit.S_contract >= 1, 'Да', 'Нет') AS 'Платное' " +
                           "FROM abit " +
                           "Left JOIN polity ON(polity.Pol_id = abit.Polity) " +
                           "Left JOIN lang ON(lang.L_id = abit.Lang) " +
                           "Left JOIN spec AS prior1 ON(prior1.S_id = abit.Prior1) " +
                           "Left JOIN spec AS prior2 ON(prior2.S_id = abit.Prior2) " +
                           "Left JOIN spec AS prior3 ON(prior3.S_id = abit.Prior3) " +
                           "Left JOIN base ON(base.B_id = abit.E_base); ";
            DB.RunQuery(sql, out dtAbit);
            dgvAbit.DataSource = dtAbit;
        }

        private void SortAndFilterIni_Abit()
        {
            tscbSortField_Abit.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Abit.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Abit.SelectedIndex = 0;

            tscbFilterField_Abit.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Abit.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Abit.SelectedIndex = 0;

            foreach (DataColumn i in dtAbit.Columns)
            {
                tscbSortField_Abit.Items.Add(i.ColumnName);
                tscbFilterField_Abit.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Abit.Items.Count != 0) tscbSortField_Abit.SelectedIndex = 0;
            if (tscbFilterField_Abit.Items.Count != 0) tscbFilterField_Abit.SelectedIndex = 0;
            tssbSort_Abit.DropDown.BackColor = Color.LightGray;
            tssbFilter_Abit.DropDown.BackColor = Color.LightGray;
        }

        private void ShowColumnsSet()
        {
            foreach (DataColumn i in dtAbit.Columns)
            {
                tssbShowColumns.DropDownItems.Add(i.ColumnName);
            }
        }

        private void SetColumnVisibility(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Abit_Click(object sender, EventArgs e)
        {
            Form_Add_Abit form = new Form_Add_Abit();
            form.ShowDialog();
            dtAbit_cb_Fill();
        }

        private void tsbChange_Abit_Click(object sender, EventArgs e)
        {
            Form_Change_Abit form = new Form_Change_Abit();
            form.ShowDialog();
            dtAbit_cb_Fill();
        }

        private void tsbDelete_Abit_Click(object sender, EventArgs e)
        {
            Form_Delete_Abit form = new Form_Delete_Abit();
            form.ShowDialog();
            dtAbit_cb_Fill();
        }

        private void tsbRefresh_Abit_Click(object sender, EventArgs e)
        {
            dgvAbit_Fill();
            Update_Abit_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Abit_Click(object sender, EventArgs e)
        {
            tssbSort_Abit.ShowDropDown();
        }

        private void tsmiSortApply_Abit_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Abit.SelectedIndex == 0)
            {
                dtAbit.DefaultView.Sort = "[" + tscbSortField_Abit.Text + "] ASC";
            }
            else
            {
                dtAbit.DefaultView.Sort = "[" + tscbSortField_Abit.Text + "] DESC";
            }
        }

        private bool GetFieldType_Abit()
        {
            foreach (DataColumn i in dtAbit.Columns)
            {
                if (tscbFilterField_Abit.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tssbFilter_Abit_Click(object sender, EventArgs e)
        {
            tssbFilter_Abit.ShowDropDown();
        }

        private void tsmiFilterApply_Abit_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Abit())
                {
                    if (tscbFilterOper_Abit.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Abit.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Abit.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Abit.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtAbit.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Abit.Text, operation, tstbFilterValue_Abit.Text);
                }
                else
                {
                    if (tscbFilterOper_Abit.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Abit.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Abit.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Abit.SelectedIndex == 3) operation = "<";

                    dtAbit.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Abit.Text, operation, tstbFilterValue_Abit.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbResetFilterAbit_Click(object sender, EventArgs e)
        {
            dtAbit.DefaultView.RowFilter = "";
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Abit_Click(object sender, EventArgs e)
        {

        }

        private void tsbExportAll_Abit_Click(object sender, EventArgs e)
        {

        }

        #endregion



        #endregion

        #region Родители



        #region Инициализация данных

        private void dgvParents_Fill()
        {
            string sql = "SELECT parent.P_id AS Идентификатор, " +
                "abit.FIO AS Абитурьент," +
                "parent.P_FIO AS 'ФИО родителя', " +
                "parent.P_adrreg AS 'Адрес регистрации'," +
                "parent.P_adrfact AS 'Адрес проживания'," +
                "parent.P_workpost AS 'Место работы'," +
                "parent.P_phone AS 'Телефон'" +
                "FROM parent " +
                "INNER JOIN abit ON(parent.P_abit = abit.id); ";
            DB.RunQuery(sql, out dtParents);
            dgvParent.DataSource = dtParents;
        }

        private void SortAndFilterIni_Parent()
        {
            tscbSortField_Parent.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Parent.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Parent.SelectedIndex = 0;

            tscbFilterField_Parent.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Parent.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Parent.SelectedIndex = 0;

            foreach (DataColumn i in dtParents.Columns)
            {
                tscbSortField_Parent.Items.Add(i.ColumnName);
                tscbFilterField_Parent.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Parent.Items.Count != 0) tscbSortField_Parent.SelectedIndex = 0;
            if (tscbFilterField_Parent.Items.Count != 0) tscbFilterField_Parent.SelectedIndex = 0;
            tssbSort_Parent.DropDown.BackColor = Color.LightGray;
            tssbFilter_Parent.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Parent_Click(object sender, EventArgs e)
        {
            Form_AddStatus form = new Form_AddStatus();
            form.ShowDialog();
            tsbRefresh_Parent_Click(this, new EventArgs());
        }

        private void tsbChange_Parent_Click(object sender, EventArgs e)
        {
            Form_Change_Parent form = new Form_Change_Parent();
            form.ShowDialog();
            tsbRefresh_Parent_Click(this, new EventArgs());
        }

        private void tsbDelete_Parent_Click(object sender, EventArgs e)
        {
            Form_Delete_Parent form = new Form_Delete_Parent();
            form.ShowDialog();
            tsbRefresh_Parent_Click(this, new EventArgs());
        }

        private void tsbRefresh_Parent_Click(object sender, EventArgs e)
        {
            dgvParents_Fill();

            Update_Parent_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Parent_Click(object sender, EventArgs e)
        {
            tssbSort_Parent.ShowDropDown();
        }

        private void tsmiSortApply_Parent_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Parent.SelectedIndex == 0)
            {
                dtParents.DefaultView.Sort = "[" + tscbSortField_Parent.Text + "] ASC";
            }
            else
            {
                dtParents.DefaultView.Sort = "[" + tscbSortField_Parent.Text + "] DESC";
            }
        }
        private void tssbFilter_Parent_Click(object sender, EventArgs e)
        {
            tssbFilter_Parent.ShowDropDown();
        }

        private bool GetFieldType_Parent()
        {
            foreach (DataColumn i in dtParents.Columns)
            {
                if (tscbFilterField_Parent.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsmiFilterApply_Parent_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Parent())
                {
                    if (tscbFilterOper_Parent.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Parent.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Parent.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Parent.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtParents.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Parent.Text, operation, tstbFilterValue_Parent.Text);
                }
                else
                {
                    if (tscbFilterOper_Parent.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Parent.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Parent.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Parent.SelectedIndex == 3) operation = "<";

                    dtParents.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Parent.Text, operation, tstbFilterValue_Parent.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbResetFilter_Parent_Click(object sender, EventArgs e)
        {
            dtParents.DefaultView.RowFilter = "";
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Parent_Click(object sender, EventArgs e)
        {
            try
            {
                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_parent.docx");
                    ReplaseWords("{abit}", dgvParent.SelectedRows[0].Cells[1].Value.ToString(), wordDocument);
                    ReplaseWords("{fio}", dgvParent.SelectedRows[0].Cells[2].Value.ToString(), wordDocument);
                    ReplaseWords("{adrreg}", dgvParent.SelectedRows[0].Cells[3].Value.ToString(), wordDocument);
                    ReplaseWords("{adrfact}", dgvParent.SelectedRows[0].Cells[4].Value.ToString(), wordDocument);
                    ReplaseWords("{workpost}", dgvParent.SelectedRows[0].Cells[5].Value.ToString(), wordDocument);
                    ReplaseWords("{phone}", dgvParent.SelectedRows[0].Cells[6].Value.ToString(), wordDocument);
                    ReplaseWords("{curr_date}", DateTime.Now.ToLongDateString(), wordDocument);

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

        private void tsbExportAll_Parent_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о родителях абитуриентов", dgvParent);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvParents_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Parent.Text = dgvParent.SelectedRows[0].Cells[0].Value.ToString();
                cbAbit_Parent.SelectedItem = dgvParent.SelectedRows[0].Cells[1].Value.ToString();
                tbFIO_Parent.Text = dgvParent.SelectedRows[0].Cells[2].Value.ToString();
                tbAdrReg_Parent.Text = dgvParent.SelectedRows[0].Cells[3].Value.ToString();
                tbAdrFact_Parent.Text = dgvParent.SelectedRows[0].Cells[4].Value.ToString();
                tbWorkpost_Parent.Text = dgvParent.SelectedRows[0].Cells[5].Value.ToString();
                tbPhone_Parent.Text = dgvParent.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnUpdate_Parent_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Parent()) return;

            string abit_id = FindID_cbAbit_Parent();
            if (abit_id == "-1")
            {
                errorProvider.SetError(cbAbit_Parent, "Выберите имя абитуринта!");
                return;
            }

            string sql = "UPDATE parent " +
                            "SET  P_abit = " + abit_id + ", P_FIO = '" + tbFIO_Parent.Text + "', P_adrreg = '" + tbAdrReg_Parent.Text + "', P_adrfact = '" +
                            tbAdrFact_Parent.Text + "', P_workpost = '" + tbWorkpost_Parent.Text + "', P_phone = '" + tbPhone_Parent.Text + "' " +
                            "where P_id = " + tbID_Parent.Text + ";";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменены данные о родителе", "Идентификатор: " + tbID_Parent.Text + "; ФИО: " + tbFIO_Parent.Text + ";");
                MessageBox.Show("Данные успешно изменены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Parent();
            }
            else
            {
                MessageBox.Show("Не удалось изменить данные о родителе!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRow_Parent()
        {
            dgvParent.SelectedRows[0].Cells[0].Value = tbID_Parent.Text;
            dgvParent.SelectedRows[0].Cells[1].Value = cbAbit_Parent.SelectedItem;
            dgvParent.SelectedRows[0].Cells[2].Value = tbFIO_Parent.Text;
            dgvParent.SelectedRows[0].Cells[3].Value = tbAdrReg_Parent.Text;
            dgvParent.SelectedRows[0].Cells[4].Value = tbAdrFact_Parent.Text;
            dgvParent.SelectedRows[0].Cells[5].Value = tbWorkpost_Parent.Text;
            dgvParent.SelectedRows[0].Cells[6].Value = tbPhone_Parent.Text;
        }

        private bool CheckFields_Parent()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbFIO_Parent.Text.Length > 50) { errorProvider.SetError(tbFIO_Parent, "ФИО должно быть не более 50 символов!"); ret_val = false; }
                if (tbAdrReg_Parent.Text.Length > 80) { errorProvider.SetError(tbAdrReg_Parent, "Адрес регистрации должен быть не более 80 символов!"); ret_val = false; }
                if (tbAdrFact_Parent.Text.Length > 80) { errorProvider.SetError(tbAdrFact_Parent, "Адрес проживания должен быть не более 80 символов"); ret_val = false; }
                if (tbWorkpost_Parent.Text.Length > 80) { errorProvider.SetError(tbWorkpost_Parent, "Место работы должно быть не более 80 символов"); }
                if (tbPhone_Parent.Text.Length > 20) { errorProvider.SetError(tbPhone_Parent, "Телефон должен быть не более 80 символов!"); ret_val = false; }

                if (tbFIO_Parent.Text.Length == 0) { errorProvider.SetError(tbFIO_Parent, "Заполните это поле!"); ret_val = false; }
                if (tbAdrReg_Parent.Text.Length == 0) { errorProvider.SetError(tbAdrReg_Parent, "Заполните это поле!"); ret_val = false; }
                if (tbAdrFact_Parent.Text.Length == 0) { errorProvider.SetError(tbAdrFact_Parent, "Заполните это поле!"); ret_val = false; }
                if (tbWorkpost_Parent.Text.Length == 0) { errorProvider.SetError(tbWorkpost_Parent, "Заполните это поле!"); }
                if (tbPhone_Parent.Text.Length == 0) { errorProvider.SetError(tbPhone_Parent, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private string FindID_cbAbit_Parent()
        {
            foreach (DataRow i in dtAbit_cb.Rows)
            {
                if (cbAbit_Parent.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion



        #endregion

        #region Статус абитуриента



        #region Инициализация данных

        private void dgvStatus_Fill()
        {
            string sql = "SELECT status.St_id AS Идентификатор, " +
                "abit.FIO AS Абитурьент, " +
                "status.St_type AS 'Тип статуса', " +
                "status.St_docinform AS 'Информация, подтверждающая статус' " +
                "FROM status " +
                "INNER JOIN abit ON(status.St_abit = abit.id); ";
            DB.RunQuery(sql, out dtStatus);
            dgvStatus.DataSource = dtStatus;
        }

        private void SortAndFilterIni_Status()
        {
            tscbSortField_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Status.SelectedIndex = 0;

            tscbFilterField_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Status.SelectedIndex = 0;

            foreach (DataColumn i in dtStatus.Columns)
            {
                tscbSortField_Status.Items.Add(i.ColumnName);
                tscbFilterField_Status.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Status.Items.Count != 0) tscbSortField_Status.SelectedIndex = 0;
            if (tscbFilterField_Status.Items.Count != 0) tscbFilterField_Status.SelectedIndex = 0;
            tssbSort_Status.DropDown.BackColor = Color.LightGray;
            tssbFilter_Status.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Status_Click(object sender, EventArgs e)
        {
            new Form_Add_Status().ShowDialog();
            tsbRefresh_Status_Click(this, new EventArgs());
        }

        private void tsbChange_Status_Click(object sender, EventArgs e)
        {
            new Form_Change_Status().ShowDialog();
            tsbRefresh_Status_Click(this, new EventArgs());
        }

        private void tsbDelete_Status_Click(object sender, EventArgs e)
        {
            new Form_Delete_Status().ShowDialog();
            tsbRefresh_Status_Click(this, new EventArgs());
        }

        private void tsbRefresh_Status_Click(object sender, EventArgs e)
        {
            dgvStatus_Fill();
            Update_Status_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Status_Click(object sender, EventArgs e)
        {
            tssbSort_Status.ShowDropDown();
        }
        private void tsmiSortApply_Status_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Status.SelectedIndex == 0)
            {
                dtStatus.DefaultView.Sort = "[" + tscbSortField_Status.Text + "] ASC";
            }
            else
            {
                dtStatus.DefaultView.Sort = "[" + tscbSortField_Status.Text + "] DESC";
            }
        }

        private void tsbResetFilter_Status_Click(object sender, EventArgs e)
        {
            dtStatus.DefaultView.RowFilter = "";
        }

        private void tssbFilter_Status_Click(object sender, EventArgs e)
        {
            tssbFilter_Status.ShowDropDown();
        }

        private bool GetFieldType_Status()
        {
            foreach (DataColumn i in dtStatus.Columns)
            {
                if (tscbFilterField_Status.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsmiFilterApply_Status_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Status())
                {
                    if (tscbFilterOper_Status.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Status.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Status.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Status.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtStatus.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Status.Text, operation, tstbFilterValue_Status.Text);
                }
                else
                {
                    if (tscbFilterOper_Status.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Status.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Status.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Status.SelectedIndex == 3) operation = "<";

                    dtStatus.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Status.Text, operation, tstbFilterValue_Status.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Status_Click(object sender, EventArgs e)
        {
            try
            {
                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_status.docx");
                    ReplaseWords("{abit}", dgvStatus.SelectedRows[0].Cells[1].Value.ToString(), wordDocument);
                    ReplaseWords("{status}", dgvStatus.SelectedRows[0].Cells[2].Value.ToString(), wordDocument);
                    ReplaseWords("{docinform}", dgvStatus.SelectedRows[0].Cells[3].Value.ToString(), wordDocument);
                    ReplaseWords("{curr_date}", DateTime.Now.ToLongDateString(), wordDocument);

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

        private void tsbExportAll_Status_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о статусах абитуриентов", dgvStatus);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvStatus_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Status.Text = dgvStatus.SelectedRows[0].Cells[0].Value.ToString();
                cbAbit_Status.SelectedItem = dgvStatus.SelectedRows[0].Cells[1].Value.ToString();
                tbStatusType_Status.Text = dgvStatus.SelectedRows[0].Cells[2].Value.ToString();
                tbDocinform_Status.Text = dgvStatus.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Status()
        {
            dgvStatus.SelectedRows[0].Cells[0].Value = tbID_Status.Text;
            dgvStatus.SelectedRows[0].Cells[1].Value = cbAbit_Status.SelectedItem;
            dgvStatus.SelectedRows[0].Cells[2].Value = tbStatusType_Status.Text;
            dgvStatus.SelectedRows[0].Cells[3].Value = tbDocinform_Status.Text;
        }

        private void btnUpdate_Status_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Status()) return;

            string abit_id = FindID_cbAbit_Status();
            if (abit_id == "-1")
            {
                errorProvider.SetError(cbAbit_Status, "Выберите имя абитуринта!");
                return;
            }

            string sql = "update status set " +
                "St_abit = " + abit_id + ", St_type = '" + tbStatusType_Status.Text + "', St_docinform = '" + tbDocinform_Status.Text + "' " +
                "where St_id = " + tbID_Status.Text + "; ";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменен статус", cbAbit_Status.Text + " " + tbStatusType_Status.Text);
                MessageBox.Show("Cтатус успешно изменен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Status();
            }
            else
            {
                MessageBox.Show("Не удалось изменить статус!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Status()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbStatusType_Status.Text.Length > 20) { errorProvider.SetError(tbStatusType_Status, "Статус должен быть не более 20 символов!"); ret_val = false; }
                if (tbDocinform_Status.Text.Length > 100) { errorProvider.SetError(tbDocinform_Status, "Информация из документа должена быть не более 100 символов!"); ret_val = false; }

                if (tbStatusType_Status.Text.Length == 0) { errorProvider.SetError(tbStatusType_Status, "Заполните это поле!"); ret_val = false; }
                if (tbDocinform_Status.Text.Length == 0) { errorProvider.SetError(tbDocinform_Status, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private string FindID_cbAbit_Status()
        {
            foreach (DataRow i in dtAbit_cb.Rows)
            {
                if (cbAbit_Status.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion



        #endregion

        #region Воинская обязанность



        #region Инициализация данных

        private void dgvMilitary_Fill()
        {
            string sql = "SELECT military.M_id AS Идентификатор, " +
                "abit.FIO AS Абитурьент, " +
                "military.M_type AS 'Тип документа', " +
                "military.M_docinform AS 'Информация из документа' " +
                "FROM military " +
                "INNER JOIN abit ON(military.M_abit = abit.id); ";
            DB.RunQuery(sql, out dtMilitary);
            dgvMilitary.DataSource = dtMilitary;
        }

        private void SortAndFilterIni_Military()
        {
            tscbSortField_Military.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Military.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Military.SelectedIndex = 0;

            tscbFilterField_Military.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Military.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Military.SelectedIndex = 0;

            foreach (DataColumn i in dtMilitary.Columns)
            {
                tscbSortField_Military.Items.Add(i.ColumnName);
                tscbFilterField_Military.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Military.Items.Count != 0) tscbSortField_Military.SelectedIndex = 0;
            if (tscbFilterField_Military.Items.Count != 0) tscbFilterField_Military.SelectedIndex = 0;
            tssbSort_Military.DropDown.BackColor = Color.LightGray;
            tssbFilter_Military.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Military_Click(object sender, EventArgs e)
        {
            new Form_Add_Military().ShowDialog();
            tsbRefresh_Military_Click(this, new EventArgs());
        }

        private void tsbChange_Military_Click(object sender, EventArgs e)
        {
            new Form_Change_Military().ShowDialog();
            tsbRefresh_Military_Click(this, new EventArgs());
        }

        private void tsbDelete_Military_Click(object sender, EventArgs e)
        {
            new Form_Delete_Military().ShowDialog();
            tsbRefresh_Military_Click(this, new EventArgs());
        }

        private void tsbRefresh_Military_Click(object sender, EventArgs e)
        {
            dgvMilitary_Fill();
            Update_Military_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Military_Click(object sender, EventArgs e)
        {
            tssbSort_Military.ShowDropDown();
        }

        private void tsmiSortApply_Military_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Military.SelectedIndex == 0)
            {
                dtMilitary.DefaultView.Sort = "[" + tscbSortField_Military.Text + "] ASC";
            }
            else
            {
                dtMilitary.DefaultView.Sort = "[" + tscbSortField_Military.Text + "] DESC";
            }
        }

        private void tssbFilter_Military_Click(object sender, EventArgs e)
        {
            tssbFilter_Military.ShowDropDown();
        }

        private void tsmiFilterApply_Military_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Military())
                {
                    if (tscbFilterOper_Military.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Military.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Military.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Military.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtMilitary.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Military.Text, operation, tstbFilterValue_Military.Text);
                }
                else
                {
                    if (tscbFilterOper_Military.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Military.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Military.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Military.SelectedIndex == 3) operation = "<";

                    dtMilitary.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Military.Text, operation, tstbFilterValue_Military.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetFieldType_Military()
        {
            foreach (DataColumn i in dtMilitary.Columns)
            {
                if (tscbFilterField_Military.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsbResetFilter_Military_Click(object sender, EventArgs e)
        {
            dtMilitary.DefaultView.RowFilter = "";
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Military_Click(object sender, EventArgs e)
        {
            try
            {
                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_military.docx");
                    ReplaseWords("{abit}", dgvMilitary.SelectedRows[0].Cells[1].Value.ToString(), wordDocument);
                    ReplaseWords("{document}", dgvMilitary.SelectedRows[0].Cells[2].Value.ToString(), wordDocument);
                    ReplaseWords("{docinfo}", dgvMilitary.SelectedRows[0].Cells[3].Value.ToString(), wordDocument);
                    ReplaseWords("{curr_date}", DateTime.Now.ToLongDateString(), wordDocument);

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

        private void tsbExportAll_Military_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о воинской обязанности абитуриентов", dgvMilitary);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvMilitary_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Military.Text = dgvMilitary.SelectedRows[0].Cells[0].Value.ToString();
                cbAbit_Military.SelectedItem = dgvMilitary.SelectedRows[0].Cells[1].Value.ToString();
                tbDocument_Military.Text = dgvMilitary.SelectedRows[0].Cells[2].Value.ToString();
                tbDocinform_Military.Text = dgvMilitary.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Military()
        {
            dgvMilitary.SelectedRows[0].Cells[0].Value = tbID_Military.Text;
            dgvMilitary.SelectedRows[0].Cells[1].Value = cbAbit_Military.SelectedItem;
            dgvMilitary.SelectedRows[0].Cells[2].Value = tbDocument_Military.Text;
            dgvMilitary.SelectedRows[0].Cells[3].Value = tbDocinform_Military.Text;
        }

        private void btnUpdate_Military_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Military()) return;

            string abit_id = FindID_cbAbit_Military();
            if (abit_id == "-1")
            {
                errorProvider.SetError(cbAbit_Status, "Выберите имя абитуринта!");
                return;
            }

            string sql = "update military set " +
                "M_abit = " + abit_id + ", M_type = '" + tbDocument_Military.Text + "', M_docinform = '" + tbDocinform_Military.Text + "' " +
                "where M_id = " + tbID_Military.Text + "; ";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена воинская обязанность", cbAbit_Military.Text + " " + tbDocument_Military.Text);
                MessageBox.Show("Воинская обязанность успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Military();
            }
            else
            {
                MessageBox.Show("Не удалось изменить воинскую обязанность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Military()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbDocument_Military.Text.Length > 40) { errorProvider.SetError(tbDocument_Military, "Документ должен быть не более 40 символов!"); ret_val = false; }
                if (tbDocinform_Military.Text.Length > 80) { errorProvider.SetError(tbDocinform_Military, "Информация из документа должна быть не более 80 символов!"); ret_val = false; }

                if (tbDocument_Military.Text.Length == 0) { errorProvider.SetError(tbDocument_Military, "Заполните это поле!"); ret_val = false; }
                if (tbDocinform_Military.Text.Length == 0) { errorProvider.SetError(tbDocinform_Military, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private string FindID_cbAbit_Military()
        {
            foreach (DataRow i in dtAbit_cb.Rows)
            {
                if (cbAbit_Military.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion



        #endregion



        #region Базы образования




        #region Инициализация данных

        private void dgvBase_Fill()
        {
            DB.RunQuery("SELECT B_id AS 'Идентификатор', B_title AS 'Название базы образования' FROM base;", out dtBase);
            dgvBase.DataSource = dtBase;
        }

        private void SortAndFilterIni_Base()
        {
            tscbSortField_Base.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Base.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Base.SelectedIndex = 0;

            tscbFilterField_Base.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Base.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Base.SelectedIndex = 0;

            foreach (DataColumn i in dtBase.Columns)
            {
                tscbSortField_Base.Items.Add(i.ColumnName);
                tscbFilterField_Base.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Base.Items.Count != 0) tscbSortField_Base.SelectedIndex = 0;
            if (tscbFilterField_Base.Items.Count != 0) tscbFilterField_Base.SelectedIndex = 0;
            tssbSort_Base.DropDown.BackColor = Color.LightGray;
            tssbFilter_Base.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Base_Click(object sender, EventArgs e)
        {
            new Form_Add_Base().ShowDialog();
            tsbRefresh_Base_Click(this, new EventArgs());
        }

        private void tsbChange_Base_Click(object sender, EventArgs e)
        {
            new Form_Change_Base().ShowDialog();
            tsbRefresh_Base_Click(this, new EventArgs());
        }

        private void tsbDelete_Base_Click(object sender, EventArgs e)
        {
            new Form_Delete_Base().ShowDialog();
            tsbRefresh_Base_Click(this, new EventArgs());
        }

        private void tsbRefresh_Base_Click(object sender, EventArgs e)
        {
            dgvBase_Fill();
            Update_Base_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Base_Click(object sender, EventArgs e)
        {
            tssbSort_Base.ShowDropDown();
        }

        private void tsmiSortApply_Base_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Base.SelectedIndex == 0)
            {
                dtBase.DefaultView.Sort = "[" + tscbSortField_Base.Text + "] ASC";
            }
            else
            {
                dtBase.DefaultView.Sort = "[" + tscbSortField_Base.Text + "] DESC";
            }
        }

        private void tssbFilter_Base_Click(object sender, EventArgs e)
        {
            tssbFilter_Base.ShowDropDown();
        }

        private void tsmiFilterApply_Base_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Base())
                {
                    if (tscbFilterOper_Base.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Base.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Base.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Base.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtBase.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Base.Text, operation, tstbFilterValue_Base.Text);
                }
                else
                {
                    if (tscbFilterOper_Base.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Base.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Base.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Base.SelectedIndex == 3) operation = "<";

                    dtBase.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Base.Text, operation, tstbFilterValue_Base.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetFieldType_Base()
        {
            foreach (DataColumn i in dtBase.Columns)
            {
                if (tscbFilterField_Base.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsbResetFilter_Base_Click(object sender, EventArgs e)
        {
            dtBase.DefaultView.RowFilter = "";
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Base_Click(object sender, EventArgs e)
        {

        }

        private void tsbExportAll_Base_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о базах образования", dgvBase);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvBase_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Base.Text = dgvBase.SelectedRows[0].Cells[0].Value.ToString();
                tbName_Base.Text = dgvBase.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Base()
        {
            dgvBase.SelectedRows[0].Cells[0].Value = tbID_Base.Text;
            dgvBase.SelectedRows[0].Cells[1].Value = tbName_Base.Text;
        }

        private void btnUpdate_Base_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Base()) return;

            string sql = "UPDATE base SET B_title = '" + tbName_Base.Text + "' WHERE B_id = " + tbID_Base.Text + ";";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена база образования", dgvBase.SelectedRows[0].Cells[1].Value.ToString() + " на " + tbName_Base.Text);
                MessageBox.Show("База образования успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Base();
            }
            else
            {
                MessageBox.Show("Не удалось изменить указанную базу образования!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Base()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbName_Base.Text.Length > 40) { errorProvider.SetError(tbName_Base, "Название государства должно быть не более 40 символов!"); ret_val = false; }

                if (tbName_Base.Text.Length == 0) { errorProvider.SetError(tbName_Base, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion




        #endregion

        #region Профильные дисциплины




        #region Инициализация данных

        private void dgvDiscipline_Fill()
        {
            DB.RunQuery("SELECT D_id AS 'Идентификатор', D_title AS 'Название дисциплины' FROM discipline;", out dtDiscipline);
            dgvDiscipline.DataSource = dtDiscipline;
        }

        private void SortAndFilterIni_Discipline()
        {
            tscbSortField_Discipline.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Discipline.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Discipline.SelectedIndex = 0;

            tscbFilterField_Discipline.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Discipline.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Discipline.SelectedIndex = 0;

            foreach (DataColumn i in dtDiscipline.Columns)
            {
                tscbSortField_Discipline.Items.Add(i.ColumnName);
                tscbFilterField_Discipline.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Discipline.Items.Count != 0) tscbSortField_Discipline.SelectedIndex = 0;
            if (tscbFilterField_Discipline.Items.Count != 0) tscbFilterField_Discipline.SelectedIndex = 0;
            tssbSort_Discipline.DropDown.BackColor = Color.LightGray;
            tssbFilter_Discipline.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Discipline_Click(object sender, EventArgs e)
        {
            new Form_Add_Discipline().ShowDialog();
            tsbRefresh_Discipline_Click(this, new EventArgs());
            dtDiscipline_cb_Fill();
        }

        private void tsbChange_Discipline_Click(object sender, EventArgs e)
        {
            new Form_Change_Discipline().ShowDialog();
            tsbRefresh_Discipline_Click(this, new EventArgs());
            dtDiscipline_cb_Fill();
        }

        private void tsbDelete_Discipline_Click(object sender, EventArgs e)
        {
            new Form_Delete_Discipline().ShowDialog();
            tsbRefresh_Discipline_Click(this, new EventArgs());
            dtDiscipline_cb_Fill();
        }

        private void tsbRefresh_Discipline_Click(object sender, EventArgs e)
        {
            dgvDiscipline_Fill();
            Update_Discipline_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Discipline_Click(object sender, EventArgs e)
        {
            tssbSort_Discipline.ShowDropDown();
        }

        private void tsmiSortApply_Discipline_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Discipline.SelectedIndex == 0)
            {
                dtDiscipline.DefaultView.Sort = "[" + tscbSortField_Discipline.Text + "] ASC";
            }
            else
            {
                dtDiscipline.DefaultView.Sort = "[" + tscbSortField_Discipline.Text + "] DESC";
            }
        }

        private void tssbFilter_Discipline_Click(object sender, EventArgs e)
        {
            tssbFilter_Discipline.ShowDropDown();
        }

        private void tsmiFilterApply_Discipline_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Discipline())
                {
                    if (tscbFilterOper_Discipline.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Discipline.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Discipline.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Discipline.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtDiscipline.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Discipline.Text, operation, tstbFilterValue_Discipline.Text);
                }
                else
                {
                    if (tscbFilterOper_Discipline.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Discipline.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Discipline.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Discipline.SelectedIndex == 3) operation = "<";

                    dtDiscipline.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Discipline.Text, operation, tstbFilterValue_Discipline.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetFieldType_Discipline()
        {
            foreach (DataColumn i in dtDiscipline.Columns)
            {
                if (tscbFilterField_Discipline.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsbResetFilter_Discipline_Click(object sender, EventArgs e)
        {
            dtDiscipline.DefaultView.RowFilter = "";
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Discipline_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_military.docx");
                    ReplaseWords("{abit}", dgvMilitary.SelectedRows[0].Cells[1].Value.ToString(), wordDocument);
                    ReplaseWords("{document}", dgvMilitary.SelectedRows[0].Cells[2].Value.ToString(), wordDocument);
                    ReplaseWords("{docinfo}", dgvMilitary.SelectedRows[0].Cells[3].Value.ToString(), wordDocument);
                    ReplaseWords("{curr_date}", DateTime.Now.ToLongDateString(), wordDocument);

                    wordDocument.SaveAs(@sfdExport.FileName);
                    wordDocument.Close();
                    MessageBox.Show("Файл успешно сохранен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void tsbExportAll_Discipline_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о профильных дисциплинах", dgvDiscipline);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvDiscipline_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Discipline.Text = dgvDiscipline.SelectedRows[0].Cells[0].Value.ToString();
                tbName_Discipline.Text = dgvDiscipline.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Discipline()
        {
            dgvDiscipline.SelectedRows[0].Cells[0].Value = tbID_Discipline.Text;
            dgvDiscipline.SelectedRows[0].Cells[1].Value = tbName_Discipline.Text;
        }

        private void btnUpdate_Discipline_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Discipline()) return;

            string sql = "UPDATE discipline SET D_title = '" + tbName_Discipline.Text + "' WHERE D_id = " + tbID_Discipline.Text + ";";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена дисциплина", dgvDiscipline.SelectedRows[0].Cells[1].Value.ToString() + " на " + tbName_Discipline.Text);
                MessageBox.Show("Дисциплина успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Discipline();
            }
            else
            {
                MessageBox.Show("Не удалось изменить указанную дисциплину!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Discipline()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbName_Discipline.Text.Length > 40) { errorProvider.SetError(tbName_Discipline, "Название дисциплины должно быть не более 40 символов!"); ret_val = false; }

                if (tbName_Discipline.Text.Length == 0) { errorProvider.SetError(tbName_Discipline, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion




        #endregion

        #region Специальности



        #region Инициализация данных

        private void dgvSpec_Fill()
        {
            string sql = "SELECT spec.S_id AS 'Идентификатор', " +
                "spec.S_shifr AS 'Шифр специальности', " +
                "spec.S_spec AS 'Название квалификации', " +
                "spec.S_title AS 'Название специальности', " +
                "spec.S_short AS 'Аббревеатура', " +
                "IF(spec.S_ochn >= 1, 'Очная', 'Заочная') AS 'Форма обучения', " +
                "IF(spec.S_budjet >= 1, 'Бюджетная', 'Платная') AS 'Основа обучения на специальности', " +
                "disc1.D_title AS 'Первая ведущая дисциплина', " +
                "disc2.D_title AS 'Вторая ведущая дисциплина', " +
                "disc3.D_title AS 'Третья ведущая дисциплина' " +
                "FROM spec " +
                "LEFT JOIN discipline AS disc1 ON(disc1.D_id = spec.S_discipline1) " +
                "LEFT JOIN discipline AS disc2 ON(disc2.D_id = spec.S_discipline2) " +
                "LEFT JOIN discipline AS disc3 ON(disc3.D_id = spec.S_discipline3); ";
            DB.RunQuery(sql, out dtSpec);
            dgvSpec.DataSource = dtSpec;
        }

        private void SortAndFilterIni_Spec()
        {
            tscbSortField_Spec.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Spec.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Spec.SelectedIndex = 0;

            tscbFilterField_Spec.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Spec.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Spec.SelectedIndex = 0;

            foreach (DataColumn i in dtSpec.Columns)
            {
                tscbSortField_Spec.Items.Add(i.ColumnName);
                tscbFilterField_Spec.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Spec.Items.Count != 0) tscbSortField_Spec.SelectedIndex = 0;
            if (tscbFilterField_Spec.Items.Count != 0) tscbFilterField_Spec.SelectedIndex = 0;
            tssbSort_Spec.DropDown.BackColor = Color.LightGray;
            tssbFilter_Spec.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Spec_Click(object sender, EventArgs e)
        {
            new Form_Add_Spec().ShowDialog();
            tsbRefresh_Spec_Click(this, new EventArgs());
            dtSpec_cb_Fill();
        }

        private void tsbChange_Spec_Click(object sender, EventArgs e)
        {
            new Form_Change_Spec().ShowDialog();
            tsbRefresh_Spec_Click(this, new EventArgs());
            dtSpec_cb_Fill();
        }

        private void tsbDelete_Spec_Click(object sender, EventArgs e)
        {
            new Form_Delete_Spec().ShowDialog();
            tsbRefresh_Spec_Click(this, new EventArgs());
            dtSpec_cb_Fill();
        }

        private void tsbRefresh_Spec_Click(object sender, EventArgs e)
        {
            dgvSpec_Fill();
            Update_Spec_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Spec_Click(object sender, EventArgs e)
        {
            tssbSort_Spec.ShowDropDown();
        }

        private void tsmiSortApply_Spec_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Spec.SelectedIndex == 0)
            {
                dtSpec.DefaultView.Sort = "[" + tscbSortField_Spec.Text + "] ASC";
            }
            else
            {
                dtSpec.DefaultView.Sort = "[" + tscbSortField_Spec.Text + "] DESC";
            }
        }

        private void tssbFilter_Spec_Click(object sender, EventArgs e)
        {
            tssbFilter_Spec.ShowDropDown();
        }

        private void tsmiFilterApply_Spec_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Spec())
                {
                    if (tscbFilterOper_Spec.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Spec.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Spec.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Spec.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtSpec.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Spec.Text, operation, tstbFilterValue_Spec.Text);
                }
                else
                {
                    if (tscbFilterOper_Spec.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Spec.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Spec.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Spec.SelectedIndex == 3) operation = "<";

                    dtSpec.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Spec.Text, operation, tstbFilterValue_Spec.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetFieldType_Spec()
        {
            foreach (DataColumn i in dtSpec.Columns)
            {
                if (tscbFilterField_Spec.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsbResetFilter_Spec_Click(object sender, EventArgs e)
        {
            dtSpec.DefaultView.RowFilter = "";
        }


        #endregion

        #region Формирование выходного документа

        private void tsbExport_Spec_Click(object sender, EventArgs e)
        {
            try
            {
                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_spec.docx");

                    ReplaseWords("{spec}", dgvSpec.SelectedRows[0].Cells[3].Value.ToString(), wordDocument);
                    ReplaseWords("{shifr}", dgvSpec.SelectedRows[0].Cells[1].Value.ToString(), wordDocument);
                    ReplaseWords("{docinform}", dgvSpec.SelectedRows[0].Cells[2].Value.ToString(), wordDocument);
                    ReplaseWords("{abbrev}", dgvSpec.SelectedRows[0].Cells[4].Value.ToString(), wordDocument);
                    ReplaseWords("{ochn}", dgvSpec.SelectedRows[0].Cells[5].Value.ToString(), wordDocument);
                    ReplaseWords("{budjet}", dgvSpec.SelectedRows[0].Cells[6].Value.ToString(), wordDocument);
                    ReplaseWords("{disc1}", dgvSpec.SelectedRows[0].Cells[7].Value.ToString(), wordDocument);
                    ReplaseWords("{disc2}", dgvSpec.SelectedRows[0].Cells[8].Value.ToString(), wordDocument);
                    ReplaseWords("{disc3}", dgvSpec.SelectedRows[0].Cells[9].Value.ToString(), wordDocument);
                    ReplaseWords("{curr_date}", DateTime.Now.ToLongDateString(), wordDocument);

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

        private void tsbExportAll_Spec_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о специальностях", dgvSpec);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvSpec_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Spec.Text = dgvSpec.SelectedRows[0].Cells[0].Value.ToString();
                tbShifr_Spec.Text = dgvSpec.SelectedRows[0].Cells[1].Value.ToString();
                tbSpecName_Spec.Text = dgvSpec.SelectedRows[0].Cells[2].Value.ToString();
                tbTitle_Spec.Text = dgvSpec.SelectedRows[0].Cells[3].Value.ToString();
                tbShort_Spec.Text = dgvSpec.SelectedRows[0].Cells[4].Value.ToString();
                cbOchn_Spec.SelectedItem = dgvSpec.SelectedRows[0].Cells[5].Value.ToString();
                cbBudjet_Spec.SelectedItem = dgvSpec.SelectedRows[0].Cells[6].Value.ToString();
                cbDiscipline1_Spec.SelectedItem = dgvSpec.SelectedRows[0].Cells[7].Value.ToString();
                cbDiscipline2_Spec.SelectedItem = dgvSpec.SelectedRows[0].Cells[8].Value.ToString();
                cbDiscipline3_Spec.SelectedItem = dgvSpec.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Spec()
        {
            dgvSpec.SelectedRows[0].Cells[0].Value = tbID_Spec.Text;
            dgvSpec.SelectedRows[0].Cells[1].Value = tbShifr_Spec.Text;
            dgvSpec.SelectedRows[0].Cells[2].Value = tbSpecName_Spec.Text;
            dgvSpec.SelectedRows[0].Cells[3].Value = tbTitle_Spec.Text;
            dgvSpec.SelectedRows[0].Cells[4].Value = tbShort_Spec.Text;
            dgvSpec.SelectedRows[0].Cells[5].Value = cbOchn_Spec.SelectedItem;
            dgvSpec.SelectedRows[0].Cells[6].Value = cbBudjet_Spec.SelectedItem;
            dgvSpec.SelectedRows[0].Cells[7].Value = cbDiscipline1_Spec.SelectedItem;
            dgvSpec.SelectedRows[0].Cells[8].Value = cbDiscipline2_Spec.SelectedItem;
            dgvSpec.SelectedRows[0].Cells[9].Value = cbDiscipline3_Spec.SelectedItem;
        }

        private void btnUpdate_Spec_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Spec()) return;

            string ochn;
            if (cbBudjet_Spec.Text == "Очная") { ochn = "1"; }
            else { ochn = "0"; }

            string budjet;
            if (cbBudjet_Spec.Text == "Бюджетная") { budjet = "1"; }
            else { budjet = "0"; }

            string discipline1_id = FindID_cbDiscipline1_Spec();
            if (discipline1_id == "-1")
            {
                errorProvider.SetError(cbDiscipline1_Spec, "Выберите дисциплину!");
                return;
            }

            string discipline2_id = FindID_cbDiscipline2_Spec();
            if (discipline2_id == "-1")
            {
                errorProvider.SetError(cbDiscipline2_Spec, "Выберите дисциплину!");
                return;
            }

            string discipline3_id = FindID_cbDiscipline3_Spec();
            if (discipline3_id == "-1")
            {
                errorProvider.SetError(cbDiscipline3_Spec, "Выберите дисциплину!");
                return;
            }

            string sql = "UPDATE spec " +
                "SET S_shifr = '" + tbShifr_Spec.Text + "', S_spec = '" + tbSpecName_Spec.Text + "', S_title = '" + tbTitle_Spec.Text + "', S_short = '" + tbShort_Spec.Text + "'," +
                "S_ochn = " + ochn + ", S_budjet = " + budjet + ", S_discipline1 = " + discipline1_id + ", S_discipline2 = " + discipline2_id + ", " +
                "S_discipline3 = " + discipline3_id +  " " +
                "where S_id = " + tbID_Spec.Text + "; ";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена специальность", dgvSpec.SelectedRows[0].Cells[3].Value.ToString() + "; " + tbShifr_Spec.Text + "; " + tbSpecName_Spec.Text + "; ");
                MessageBox.Show("Специальность успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Spec();
            }
            else
            {
                MessageBox.Show("Не удалось изменить специальность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Spec()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbDocument_Military.Text.Length > 40) { errorProvider.SetError(tbDocument_Military, "Документ должен быть не более 40 символов!"); ret_val = false; }

                if (tbShifr_Spec.Text.Length > 10) { errorProvider.SetError(tbShifr_Spec, "Шифр должен быть не более 10 символов!"); ret_val = false; }
                if (tbSpecName_Spec.Text.Length > 45) { errorProvider.SetError(tbSpecName_Spec, "Квалификация по специальности должна быть не более 45 символов!"); ret_val = false; }
                if (tbTitle_Spec.Text.Length > 100) { errorProvider.SetError(tbTitle_Spec, "Название специальности должено быть не более 100 символов!"); ret_val = false; }
                if (tbShort_Spec.Text.Length > 6) { errorProvider.SetError(tbShort_Spec, "Аббревиатура специальности должена быть не более 6 символов"); ret_val = false; }

                if (tbShifr_Spec.Text.Length == 0) { errorProvider.SetError(tbShifr_Spec, "Заполните это поле!"); ret_val = false; }
                if (tbSpecName_Spec.Text.Length == 0) { errorProvider.SetError(tbSpecName_Spec, "Заполните это поле!"); ret_val = false; }
                if (tbTitle_Spec.Text.Length == 0) { errorProvider.SetError(tbSpecName_Spec, "Заполните это поле!"); ret_val = false; }
                if (tbShort_Spec.Text.Length == 0) { errorProvider.SetError(tbShort_Spec, "Заполните это поле!"); ret_val = false; }
                if (cbBudjet_Spec.Text.Length == 0) { errorProvider.SetError(tbShort_Spec, "Заполните это поле!"); ret_val = false; }
                if (cbOchn_Spec.Text.Length == 0) { errorProvider.SetError(tbShort_Spec, "Заполните это поле!"); ret_val = false; }
                if (cbDiscipline1_Spec.Text.Length == 0) { errorProvider.SetError(tbShort_Spec, "Заполните это поле!"); ret_val = false; }
                if (cbDiscipline2_Spec.Text.Length == 0) { errorProvider.SetError(tbShort_Spec, "Заполните это поле!"); ret_val = false; }
                if (cbDiscipline3_Spec.Text.Length == 0) { errorProvider.SetError(tbShort_Spec, "Заполните это поле!"); ret_val = false; }

                if (cbOchn_Spec.Text == null)
                {
                    errorProvider.SetError(cbOchn_Spec, "Выберите форму обучения на специальности!");
                    ret_val = false;
                }

                if (cbBudjet_Spec.Text == null)
                {
                    errorProvider.SetError(cbBudjet_Spec, "Выберите оплату!");
                    ret_val = false;
                }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private string FindID_cbDiscipline1_Spec()
        {
            foreach (DataRow i in dtDiscipline_cb.Rows)
            {
                if (cbDiscipline1_Spec.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private string FindID_cbDiscipline2_Spec()
        {
            foreach (DataRow i in dtDiscipline_cb.Rows)
            {
                if (cbDiscipline2_Spec.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private string FindID_cbDiscipline3_Spec()
        {
            foreach (DataRow i in dtDiscipline_cb.Rows)
            {
                if (cbDiscipline3_Spec.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion




        #endregion

        #region Иностранные языки



        #region Инициализация данных

        private void dgvLang_Fill()
        {
            DB.RunQuery("SELECT L_id AS 'Идентификатор', L_title AS 'Название иностранного языка' FROM lang; ", out dtLang);
            dgvLang.DataSource = dtLang;
        }

        private void SortAndFilterIni_Lang()
        {
            tscbSortField_Lang.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Lang.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Lang.SelectedIndex = 0;

            tscbFilterField_Lang.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Lang.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Lang.SelectedIndex = 0;

            foreach (DataColumn i in dtLang.Columns)
            {
                tscbSortField_Lang.Items.Add(i.ColumnName);
                tscbFilterField_Lang.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Lang.Items.Count != 0) tscbSortField_Lang.SelectedIndex = 0;
            if (tscbFilterField_Lang.Items.Count != 0) tscbFilterField_Lang.SelectedIndex = 0;
            tssbSort_Lang.DropDown.BackColor = Color.LightGray;
            tssbFilter_Lang.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Lang_Click(object sender, EventArgs e)
        {
            new Form_Add_Lang().ShowDialog();
            tsbRefresh_Lang_Click(this, new EventArgs());
        }

        private void tsbChange_Lang_Click(object sender, EventArgs e)
        {
            new Form_Change_Lang().ShowDialog();
            tsbRefresh_Lang_Click(this, new EventArgs());
        }

        private void tsbDelete_Lang_Click(object sender, EventArgs e)
        {
            new Form_Delete_Lang().ShowDialog();
            tsbRefresh_Lang_Click(this, new EventArgs());
        }

        private void tsbRefresh_Lang_Click(object sender, EventArgs e)
        {
            dgvLang_Fill();
            Update_Lang_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Lang_Click(object sender, EventArgs e)
        {
            tssbSort_Lang.ShowDropDown();
        }

        private void tsmiSortApply_Lang_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Lang.SelectedIndex == 0)
            {
                dtLang.DefaultView.Sort = "[" + tscbSortField_Lang.Text + "] ASC";
            }
            else
            {
                dtLang.DefaultView.Sort = "[" + tscbSortField_Lang.Text + "] DESC";
            }
        }

        private void tssbFilter_Lang_Click(object sender, EventArgs e)
        {
            tssbFilter_Lang.ShowDropDown();
        }

        private void tsbResetFilter_Lang_Click(object sender, EventArgs e)
        {
            dtLang.DefaultView.RowFilter = "";
        }

        private bool GetFieldType_Lang()
        {
            foreach (DataColumn i in dtLang.Columns)
            {
                if (tscbFilterField_Lang.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsmiFilterApply_Lang_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Lang())
                {
                    if (tscbFilterOper_Lang.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Lang.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Lang.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Lang.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtLang.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Lang.Text, operation, tstbFilterValue_Lang.Text);
                }
                else
                {
                    if (tscbFilterOper_Lang.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Lang.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Lang.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Lang.SelectedIndex == 3) operation = "<";

                    dtLang.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Lang.Text, operation, tstbFilterValue_Lang.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Lang_Click(object sender, EventArgs e)
        {

        }

        private void tsbExportAll_Lang_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о иностранных языках", dgvLang);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvLang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Lang.Text = dgvLang.SelectedRows[0].Cells[0].Value.ToString();
                tbName_Lang.Text = dgvLang.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Lang()
        {
            dgvLang.SelectedRows[0].Cells[0].Value = tbID_Lang.Text;
            dgvLang.SelectedRows[0].Cells[1].Value = tbName_Lang.Text;
        }

        private void btnUpdate_Lang_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Lang()) return;

            string sql = "UPDATE lang SET L_title = '" + tbName_Lang.Text + "' WHERE L_id = " + tbID_Lang.Text + ";";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменен иностранный язык", dgvLang.SelectedRows[0].Cells[0].Value.ToString() + " на " + tbName_Lang.Text);
                MessageBox.Show("Иностранный язык успешно изменен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Lang();
            }
            else
            {
                MessageBox.Show("Не удалось изменить указанный иностранный язык!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Lang()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbName_Lang.Text.Length > 40) { errorProvider.SetError(tbName_Lang, "Название иностранного языка должно быть не более 40 символов!"); ret_val = false; }

                if (tbName_Lang.Text.Length == 0) { errorProvider.SetError(tbName_Lang, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion




        #endregion

        #region Комиссия




        #region Инициализация данных

        private void dgvKomis_Fill()
        {
            DB.RunQuery("SELECT K_id AS 'Идентификатор', K_FIO AS 'ФИО' FROM komis; ", out dtKomis);
            dgvKomis.DataSource = dtKomis;
        }

        private void SortAndFilterIni_Komis()
        {
            tscbSortField_Komis.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Komis.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Komis.SelectedIndex = 0;

            tscbFilterField_Komis.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Komis.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Komis.SelectedIndex = 0;

            foreach (DataColumn i in dtKomis.Columns)
            {
                tscbSortField_Komis.Items.Add(i.ColumnName);
                tscbFilterField_Komis.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Komis.Items.Count != 0) tscbSortField_Komis.SelectedIndex = 0;
            if (tscbFilterField_Komis.Items.Count != 0) tscbFilterField_Komis.SelectedIndex = 0;
            tssbSort_Komis.DropDown.BackColor = Color.LightGray;
            tssbFilter_Komis.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Komis_Click(object sender, EventArgs e)
        {
            new Form_Add_Komis().ShowDialog();
            tsbRefresh_Komis_Click(this, new EventArgs());
            dtKomis_cb_Fill();
        }

        private void tsbChange_Komis_Click(object sender, EventArgs e)
        {
            new Form_Change_Komis().ShowDialog();
            tsbRefresh_Komis_Click(this, new EventArgs());
            dtKomis_cb_Fill();
        }

        private void tsbDelete_Komis_Click(object sender, EventArgs e)
        {
            new Form_Delete_Komis().ShowDialog();
            tsbRefresh_Komis_Click(this, new EventArgs());
            dtKomis_cb_Fill();
        }

        private void tsbRefresh_Komis_Click(object sender, EventArgs e)
        {
            dgvKomis_Fill();
            Update_Komis_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Komis_Click(object sender, EventArgs e)
        {
            tssbSort_Komis.ShowDropDown();
        }

        private void tsmiSortApply_Komis_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Komis.SelectedIndex == 0)
            {
                dtKomis.DefaultView.Sort = "[" + tscbSortField_Komis.Text + "] ASC";
            }
            else
            {
                dtKomis.DefaultView.Sort = "[" + tscbSortField_Komis.Text + "] DESC";
            }
        }

        private void tssbFilter_Komis_Click(object sender, EventArgs e)
        {
            tssbFilter_Komis.ShowDropDown();
        }

        private void tsbResetFilter_Komis_Click(object sender, EventArgs e)
        {
            dtKomis.DefaultView.RowFilter = "";
        }

        private bool GetFieldType_Komis()
        {
            foreach (DataColumn i in dtKomis.Columns)
            {
                if (tscbFilterField_Komis.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsmiFilterApply_Komis_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Komis())
                {
                    if (tscbFilterOper_Komis.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Komis.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Komis.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Komis.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtKomis.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Komis.Text, operation, tstbFilterValue_Komis.Text);
                }
                else
                {
                    if (tscbFilterOper_Komis.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Komis.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Komis.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Komis.SelectedIndex == 3) operation = "<";

                    dtKomis.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Komis.Text, operation, tstbFilterValue_Komis.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Komis_Click(object sender, EventArgs e)
        {

        }

        private void tsbExportAll_Komis_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о членах комиссии", dgvKomis);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvKomis_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Komis.Text = dgvKomis.SelectedRows[0].Cells[0].Value.ToString();
                tbName_Komis.Text = dgvKomis.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Komis()
        {
            dgvKomis.SelectedRows[0].Cells[0].Value = tbID_Komis.Text;
            dgvKomis.SelectedRows[0].Cells[1].Value = tbName_Komis.Text;
        }

        private void btnUpdate_Komis_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Komis()) return;

            string sql = "UPDATE komis SET K_FIO = '" + tbName_Komis.Text + "' WHERE K_id = " + tbID_Komis.Text + ";";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменен член комиссии", dgvKomis.SelectedRows[0].Cells[0].Value.ToString() + " на " + tbName_Komis.Text);
                MessageBox.Show("Член комиссии успешно изменен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Komis();
            }
            else
            {
                MessageBox.Show("Не удалось изменить указанного члена комиссии!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Komis()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbName_Komis.Text.Length > 50) { errorProvider.SetError(tbName_Komis, "ФИО должно быть не более 50 символов!"); ret_val = false; }

                if (tbName_Komis.Text.Length == 0) { errorProvider.SetError(tbName_Komis, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion




        #endregion

        #region Государства




        #region Инициализация данных

        private void dgvPolity_Fill()
        {
            DB.RunQuery("SELECT Pol_id AS 'Идентификатор', Pol_title AS 'Название государства' FROM polity; ", out dtPolity);
            dgvPolity.DataSource = dtPolity;
        }

        private void SortAndFilterIni_Polity()
        {
            tscbSortField_Polity.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Polity.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Polity.SelectedIndex = 0;

            tscbFilterField_Polity.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Polity.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Polity.SelectedIndex = 0;

            foreach (DataColumn i in dtPolity.Columns)
            {
                tscbSortField_Polity.Items.Add(i.ColumnName);
                tscbFilterField_Polity.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Polity.Items.Count != 0) tscbSortField_Polity.SelectedIndex = 0;
            if (tscbFilterField_Polity.Items.Count != 0) tscbFilterField_Polity.SelectedIndex = 0;
            tssbSort_Polity.DropDown.BackColor = Color.LightGray;
            tssbFilter_Polity.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Polity_Click(object sender, EventArgs e)
        {
            new Form_Add_Polity().ShowDialog();
            tsbRefresh_Polity_Click(this, new EventArgs());
        }

        private void tsbChange_Polity_Click(object sender, EventArgs e)
        {
            new Form_Change_Polity().ShowDialog();
            tsbRefresh_Polity_Click(this, new EventArgs());
        }

        private void tsbDelete_Polity_Click(object sender, EventArgs e)
        {
            new Form_Delete_Polity().ShowDialog();
            tsbRefresh_Polity_Click(this, new EventArgs());
        }

        private void tsbRefresh_Polity_Click(object sender, EventArgs e)
        {
            dgvPolity_Fill();
            Update_Polity_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Polity_Click(object sender, EventArgs e)
        {
            tssbSort_Polity.ShowDropDown();
        }

        private void tsmiSortApply_Polity_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Polity.SelectedIndex == 0)
            {
                dtPolity.DefaultView.Sort = "[" + tscbSortField_Polity.Text + "] ASC";
            }
            else
            {
                dtPolity.DefaultView.Sort = "[" + tscbSortField_Polity.Text + "] DESC";
            }
        }

        private void tssbFilter_Polity_Click(object sender, EventArgs e)
        {
            tssbFilter_Polity.ShowDropDown();
        }

        private void tsbResetFilter_Polity_Click(object sender, EventArgs e)
        {
            dtPolity.DefaultView.RowFilter = "";
        }

        private bool GetFieldType_Polity()
        {
            foreach (DataColumn i in dtPolity.Columns)
            {
                if (tscbFilterField_Polity.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsmiFilterApply_Polity_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Polity())
                {
                    if (tscbFilterOper_Polity.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Polity.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Polity.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Polity.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtPolity.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Polity.Text, operation, tstbFilterValue_Polity.Text);
                }
                else
                {
                    if (tscbFilterOper_Polity.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Polity.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Polity.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Polity.SelectedIndex == 3) operation = "<";

                    dtPolity.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Polity.Text, operation, tstbFilterValue_Polity.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Polity_Click(object sender, EventArgs e)
        {

        }

        private void tsbExportAll_Polity_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о государствах", dgvPolity);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvPolity_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Polity.Text = dgvPolity.SelectedRows[0].Cells[0].Value.ToString();
                tbName_Polity.Text = dgvPolity.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Polity()
        {
            dgvPolity.SelectedRows[0].Cells[0].Value = tbID_Polity.Text;
            dgvPolity.SelectedRows[0].Cells[1].Value = tbName_Polity.Text;
        }

        private void btnUpdate_Polity_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Polity()) return;

            string sql = "UPDATE polity SET Pol_title = '" + tbName_Polity.Text + "' WHERE Pol_id = " + tbID_Polity.Text + ";";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменено государство", dgvPolity.SelectedRows[0].Cells[0].Value.ToString() + " на " + tbName_Polity.Text);
                MessageBox.Show("Государство успешно изменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Polity();
            }
            else
            {
                MessageBox.Show("Не удалось изменить указанное государство!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Polity()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbName_Polity.Text.Length > 40) { errorProvider.SetError(tbName_Polity, "Название государства должно быть не более 40 символов!"); ret_val = false; }

                if (tbName_Polity.Text.Length == 0) { errorProvider.SetError(tbName_Polity, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion




        #endregion

        #region Решения комиссии



        #region Инициализация данных

        private void dgvDecision_Fill()
        {
            string sql = "SELECT " +
                "decision.Des_id AS 'Идентификатор', " +
                "abit.FIO AS 'Абитуриент', " +
                "groups.gr_name AS 'Группа', " +
                "decision.Des_resolution AS 'Решение', " +
                "decision.Comment AS 'Комментарий', " +
                "DATE_FORMAT(decision.Des_date, '%d.%m.%Y') AS 'Дата принятия решения', " +
                "komis.K_FIO AS 'Член комиссии' " +
                "FROM decision " +
                "LEFT JOIN abit ON (decision.Des_abit = abit.id) " +
                "LEFT JOIN groups ON (decision.Des_group = groups.gr_id) " +
                "LEFT JOIN komis ON (decision.Des_komis = komis.K_id); ";
            DB.RunQuery(sql, out dtDecision);
            dgvDecision.DataSource = dtDecision;
        }

        private void SortAndFilterIni_Decision()
        {
            tscbSortField_Decision.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Decision.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Decision.SelectedIndex = 0;

            tscbFilterField_Decision.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Decision.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Decision.SelectedIndex = 0;

            foreach (DataColumn i in dtDecision.Columns)
            {
                tscbSortField_Decision.Items.Add(i.ColumnName);
                tscbFilterField_Decision.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Decision.Items.Count != 0) tscbSortField_Decision.SelectedIndex = 0;
            if (tscbFilterField_Decision.Items.Count != 0) tscbFilterField_Decision.SelectedIndex = 0;
            tssbSort_Decision.DropDown.BackColor = Color.LightGray;
            tssbFilter_Decision.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Decision_Click(object sender, EventArgs e)
        {
            new Form_Add_Decision().ShowDialog();
            tsbRefresh_Decision_Click(this, new EventArgs());
        }
        private void tsbChange_Decision_Click(object sender, EventArgs e)
        {
            new Form_Update_Decision().ShowDialog();
            tsbRefresh_Decision_Click(this, new EventArgs());
        }

        private void tsbDelete_Decision_Click(object sender, EventArgs e)
        {
            new Form_Delete_Decision().ShowDialog();
            tsbRefresh_Decision_Click(this, new EventArgs());
        }

        private void tsbRefresh_Decision_Click(object sender, EventArgs e)
        {
            dgvDecision_Fill();
            Update_Decision_Stats();
        }

        #endregion

        #region Сортировка и фильтрация

        private void tssbSort_Decision_Click(object sender, EventArgs e)
        {
            tssbSort_Decision.ShowDropDown();
        }

        private void tsmiSortApply_Decision_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Decision.SelectedIndex == 0)
            {
                dtDecision.DefaultView.Sort = "[" + tscbSortField_Decision.Text + "] ASC";
            }
            else
            {
                dtDecision.DefaultView.Sort = "[" + tscbSortField_Decision.Text + "] DESC";
            }
        }

        private void tssbFilter_Decision_Click(object sender, EventArgs e)
        {
            tssbFilter_Decision.ShowDropDown();
        }

        private bool GetFieldType_Decision()
        {
            foreach (DataColumn i in dtDecision.Columns)
            {
                if (tscbFilterField_Decision.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsmiFilterApply_Desicion_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Decision())
                {
                    if (tscbFilterOper_Decision.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Decision.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Decision.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Decision.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtDecision.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Decision.Text, operation, tstbFilterValue_Decision.Text);
                }
                else
                {
                    if (tscbFilterOper_Decision.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Decision.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Decision.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Decision.SelectedIndex == 3) operation = "<";

                    dtDecision.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Decision.Text, operation, tstbFilterValue_Decision.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbResetFilter_Desicion_Click(object sender, EventArgs e)
        {
            dtDecision.DefaultView.RowFilter = "";
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Desicion_Click(object sender, EventArgs e)
        {
            try
            {
                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_decision.docx");
                    ReplaseWords("{abit}", dgvDecision.SelectedRows[0].Cells[1].Value.ToString(), wordDocument);
                    ReplaseWords("{group}", dgvDecision.SelectedRows[0].Cells[2].Value.ToString(), wordDocument);
                    ReplaseWords("{resolution}", dgvDecision.SelectedRows[0].Cells[3].Value.ToString(), wordDocument);
                    ReplaseWords("{comment}", dgvDecision.SelectedRows[0].Cells[4].Value.ToString(), wordDocument);
                    ReplaseWords("{date}", dgvDecision.SelectedRows[0].Cells[5].Value.ToString(), wordDocument);
                    ReplaseWords("{komis}", dgvDecision.SelectedRows[0].Cells[6].Value.ToString(), wordDocument);
                    ReplaseWords("{curr_date}", DateTime.Now.ToLongDateString(), wordDocument);

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

        private void tsbExportAll_Desicion_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о решениях о зачислении абитуриентов", dgvDecision);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvDecision_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Decision.Text = dgvDecision.SelectedRows[0].Cells[0].Value.ToString();
                cbGroup_Decision.SelectedItem = dgvDecision.SelectedRows[0].Cells[2].Value.ToString();
                tbResolution_Decision.Text = dgvDecision.SelectedRows[0].Cells[3].Value.ToString();
                tbComment_Decision.Text = dgvDecision.SelectedRows[0].Cells[4].Value.ToString();
                cbKomis_Decision.SelectedItem = dgvDecision.SelectedRows[0].Cells[6].Value.ToString();
                dtpDate_Decision.Value = DateTime.Parse(dgvDecision.SelectedRows[0].Cells[5].Value.ToString());
            }
            catch
            {

            }
        }

        private void UpdateRow_Decision()
        {
            dgvDecision.SelectedRows[0].Cells[0].Value = tbID_Decision.Text;
            dgvDecision.SelectedRows[0].Cells[2].Value = cbGroup_Decision.Text;
            dgvDecision.SelectedRows[0].Cells[3].Value = tbResolution_Decision.Text;
            dgvDecision.SelectedRows[0].Cells[5].Value = dtpDate_Decision.Value.ToShortDateString();
            dgvDecision.SelectedRows[0].Cells[6].Value = cbKomis_Decision.Text;
        }

        private void btnUpdate_Desicion_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Decision()) return;

            string group_id = FindID_cbGroup_Decision();
            if (group_id == "-1")
            {
                if (cbGroup_Decision.Text == "Нет")
                {
                    group_id = "NULL";
                }
                else
                {
                    errorProvider.SetError(cbGroup_Decision, "Выберите группу!");
                    return;
                }
            }

            string komis_id = FindID_cbKomis_Decision();
            if (komis_id == "-1")
            {
                errorProvider.SetError(cbKomis_Decision, "Выберите члена комиссии!");
                return;
            }


            string date = dtpDate_Decision.Value.Year.ToString() + "-" + dtpDate_Decision.Value.Month.ToString() + "-" + dtpDate_Decision.Value.Day.ToString();

            string sql = "UPDATE decision " +
                "SET Des_group = " + group_id + ", Des_resolution = '" + tbResolution_Decision.Text + "', " +
                "Comment = '" + tbComment_Decision.Text + "', Des_date = '" + date + "', Des_komis = '" + komis_id + "' " +
                "where decision.Des_id = " + tbID_Decision.Text + "; ";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменено решение комиссии", dgvDecision.SelectedRows[0].Cells[1].Value.ToString() + "" + tbResolution_Decision.Text);
                MessageBox.Show("Решение комиссии успешно изменено!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Decision();
            }
            else
            {
                MessageBox.Show("Не удалось изменить решение комиссии!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Decision()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbResolution_Decision.Text.Length > 20) { errorProvider.SetError(tbResolution_Decision, "Решение должно быть не более 20 символов!"); ret_val = false; }
                if (tbComment_Decision.Text.Length > 100) { errorProvider.SetError(tbComment_Decision, "Комментарий должен быть не более 100 символов!"); ret_val = false; }

                if (tbResolution_Decision.Text.Length == 0) { errorProvider.SetError(tbResolution_Decision, "Заполните это поле!"); ret_val = false; }
                if (tbComment_Decision.Text.Length == 0) { errorProvider.SetError(tbComment_Decision, "Заполните это поле!"); ret_val = false; }
                if (cbKomis_Decision.Text.Length == 0) { errorProvider.SetError(cbKomis_Decision, "Заполните это поле!"); ret_val = false; }
                if (cbGroup_Decision.Text.Length == 0) { errorProvider.SetError(cbGroup_Decision, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private string FindID_cbGroup_Decision()
        {
            foreach (DataRow i in dtGroups_cb.Rows)
            {
                if (cbGroup_Decision.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private string FindID_cbKomis_Decision()
        {
            foreach (DataRow i in dtKomis_cb.Rows)
            {
                if (cbKomis_Decision.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion




        #endregion

        #region Группы



        #region Инициализация данных

        private void dgvGroups_Fill()
        {
            string sql = "select " +
                "groups.gr_id AS 'Идентификатор', " +
                "groups.gr_name AS 'Название группы', " +
                "spec.S_title AS 'Специальность', " +
                "groups.gr_year AS 'Год формирования', " +
                "groups.gr_students AS 'Целевое количество студентов' " +
                "FROM groups " +
                "LEFT JOIN spec ON(groups.gr_spec = spec.S_id); ";
            DB.RunQuery(sql, out dtGroups);
            dgvGroups.DataSource = dtGroups;
        }

        private void SortAndFilterIni_Groups()
        {
            tscbSortField_Groups.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Groups.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbSortOrder_Groups.SelectedIndex = 0;

            tscbFilterField_Groups.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Groups.DropDownStyle = ComboBoxStyle.DropDownList;
            tscbFilterOper_Groups.SelectedIndex = 0;

            foreach (DataColumn i in dtGroups.Columns)
            {
                tscbSortField_Groups.Items.Add(i.ColumnName);
                tscbFilterField_Groups.Items.Add(i.ColumnName);
            }
            if (tscbSortField_Groups.Items.Count != 0) tscbSortField_Groups.SelectedIndex = 0;
            if (tscbFilterField_Groups.Items.Count != 0) tscbFilterField_Groups.SelectedIndex = 0;
            tssbSort_Groups.DropDown.BackColor = Color.LightGray;
            tssbFilter_Groups.DropDown.BackColor = Color.LightGray;
        }

        #endregion

        #region Добавить, изменить, удалить запись. Обновить таблицу

        private void tsbAdd_Groups_Click(object sender, EventArgs e)
        {
            new Form_Add_Groups().ShowDialog();
            tsbRefresh_Groups_Click(this, new EventArgs());
            dtGroups_cb_Fill();
            lvGroups_Candidates_Fill();
            lvGroups_Formed_Fill();
        }

        private void tsbChange_Groups_Click(object sender, EventArgs e)
        {
            new Form_Change_Groups().ShowDialog();
            tsbRefresh_Groups_Click(this, new EventArgs());
            dtGroups_cb_Fill();
            lvGroups_Candidates_Fill();
            lvGroups_Formed_Fill();
        }

        private void tsbDelete_Groups_Click(object sender, EventArgs e)
        {
            new Form_Delete_Groups().ShowDialog();
            tsbRefresh_Groups_Click(this, new EventArgs());
            dtGroups_cb_Fill();
            lvGroups_Candidates_Fill();
            lvGroups_Formed_Fill();
        }

        private void tsbRefresh_Groups_Click(object sender, EventArgs e)
        {
            dgvGroups_Fill();
            Update_Groups_Stats();
        }

        #endregion

        #region Сортировка и фильтрация


        private void tssbSort_Groups_Click(object sender, EventArgs e)
        {
            tssbSort_Groups.ShowDropDown();
        }

        private void tsmiSortApply_Groups_Click(object sender, EventArgs e)
        {
            if (tscbSortOrder_Groups.SelectedIndex == 0)
            {
                dtGroups.DefaultView.Sort = "[" + tscbSortField_Groups.Text + "] ASC";
            }
            else
            {
                dtGroups.DefaultView.Sort = "[" + tscbSortField_Groups.Text + "] DESC";
            }
        }

        private void tssbFilter_Groups_Click(object sender, EventArgs e)
        {
            tssbFilter_Groups.ShowDropDown();
        }

        private bool GetFieldType_Groups()
        {
            foreach (DataColumn i in dtGroups.Columns)
            {
                if (tscbFilterField_Groups.Text == i.Caption)
                {
                    if (i.DataType.ToString() == "System.String") { return true; }
                    else { return false; }
                }
            }
            return false;
        }

        private void tsmiFilterApply_Groups_Click(object sender, EventArgs e)
        {
            try
            {
                string operation = "";

                if (GetFieldType_Groups())
                {
                    if (tscbFilterOper_Groups.SelectedIndex == 0) operation = "LIKE";
                    if (tscbFilterOper_Groups.SelectedIndex == 1) operation = "NOT LIKE";
                    if (tscbFilterOper_Groups.SelectedIndex == 2) throw new ApplicationException("Недопустимая операция над строковыми данными");
                    if (tscbFilterOper_Groups.SelectedIndex == 3) throw new ApplicationException("Недопустимая операция над строковыми данными");

                    dtGroups.DefaultView.RowFilter = string.Format("[{0}] {1} '%{2}%'", tscbFilterField_Groups.Text, operation, tstbFilterValue_Groups.Text);
                }
                else
                {
                    if (tscbFilterOper_Groups.SelectedIndex == 0) operation = "=";
                    if (tscbFilterOper_Groups.SelectedIndex == 1) operation = "<>";
                    if (tscbFilterOper_Groups.SelectedIndex == 2) operation = ">";
                    if (tscbFilterOper_Groups.SelectedIndex == 3) operation = "<";

                    dtGroups.DefaultView.RowFilter = string.Format("[{0}] {1} {2}", tscbFilterField_Groups.Text, operation, tstbFilterValue_Groups.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void tsbResetFilter_Groups_Click(object sender, EventArgs e)
        {
            dtGroups.DefaultView.RowFilter = "";
        }

        #endregion

        #region Формирование выходного документа

        private void tsbExport_Groups_Click(object sender, EventArgs e)
        {
            try
            {
                sfdExport.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                if (sfdExport.ShowDialog() == DialogResult.OK)
                {
                    string catalog = sfdExport.FileName;

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    var wordDocument = wordApp.Documents.Open(System.IO.Directory.GetCurrentDirectory() + "\\reports\\report_group.docx");
                    ReplaseWords("{group}", dgvGroups.SelectedRows[0].Cells[1].Value.ToString(), wordDocument);
                    ReplaseWords("{spec}", dgvGroups.SelectedRows[0].Cells[2].Value.ToString(), wordDocument);
                    ReplaseWords("{year}", dgvGroups.SelectedRows[0].Cells[3].Value.ToString(), wordDocument);
                    ReplaseWords("{students}", dgvGroups.SelectedRows[0].Cells[4].Value.ToString(), wordDocument);
                    ReplaseWords("{curr_date}", DateTime.Now.ToLongDateString(), wordDocument);

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

        private void tsbExportAll_Groups_Click(object sender, EventArgs e)
        {
            ExportTable("Информация о группах", dgvGroups);
        }

        #endregion

        #region Панель быстрого редактирования

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tbID_Groups.Text = dgvGroups.SelectedRows[0].Cells[0].Value.ToString();
                tbName_Groups.Text = dgvGroups.SelectedRows[0].Cells[1].Value.ToString();
                cbSpec_Groups.SelectedItem = dgvGroups.SelectedRows[0].Cells[2].Value.ToString();
                tbYear_Groups.Text = dgvGroups.SelectedRows[0].Cells[3].Value.ToString();
                tbStudents_Groups.Text = dgvGroups.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void UpdateRow_Groups()
        {
            dgvGroups.SelectedRows[0].Cells[0].Value = tbID_Groups.Text;
            dgvGroups.SelectedRows[0].Cells[1].Value = tbName_Groups.Text;
            dgvGroups.SelectedRows[0].Cells[2].Value = cbSpec_Groups.Text;
            dgvGroups.SelectedRows[0].Cells[3].Value = tbYear_Groups.Text;
            dgvGroups.SelectedRows[0].Cells[4].Value = tbStudents_Groups.Text;
        }

        private void btnUpdate_Groups_Click(object sender, EventArgs e)
        {
            if (!CheckFields_Groups()) return;

            string spec_id = FindID_cbSpec_Groups();
            if (spec_id == "-1")
            {
                errorProvider.SetError(cbSpec_Groups, "Выберите специальность!");
                return;
            }

            string sql = "UPDATE groups SET " +
                "gr_name = '" + tbName_Groups.Text + "', gr_spec = " + spec_id + ", gr_year = '" + tbYear_Groups.Text + "', gr_students = '" + tbStudents_Groups.Text + "' " +
                "where groups.gr_id = " + tbID_Groups.Text + "; ";
            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменена группа", tbName_Groups.Text + " " + tbYear_Groups.Text + " " + tbStudents_Groups.Text);
                MessageBox.Show("Группа успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateRow_Groups();
            }
            else
            {
                MessageBox.Show("Не удалось изменить группу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields_Groups()
        {
            try
            {
                errorProvider.Dispose();
                bool ret_val = true;
                if (tbName_Groups.Text.Length > 20) { errorProvider.SetError(tbName_Groups, "Название группы должно быть не более 20 символов!"); ret_val = false; }
                if (tbYear_Groups.Text.Length > 4) { errorProvider.SetError(tbYear_Groups, "Год создания группы должен быть не более 4 символов!"); ret_val = false; }
                if (tbStudents_Groups.Text.Length > 2) { errorProvider.SetError(tbStudents_Groups, "Количество студентов должно быть не более 2 символов!"); ret_val = false; }

                if (tbName_Groups.Text.Length == 0) { errorProvider.SetError(tbName_Groups, "Заполните это поле!"); ret_val = false; }
                if (cbSpec_Groups.Text.Length == 0) { errorProvider.SetError(cbSpec_Groups, "Заполните это поле!"); ret_val = false; }
                if (tbYear_Groups.Text.Length == 0) { errorProvider.SetError(tbYear_Groups, "Заполните это поле!"); ret_val = false; }
                if (tbStudents_Groups.Text.Length == 0) { errorProvider.SetError(tbStudents_Groups, "Заполните это поле!"); ret_val = false; }
                return ret_val;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private string FindID_cbSpec_Groups()
        {
            foreach (DataRow i in dtSpec_cb.Rows)
            {
                if (cbSpec_Groups.Text == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        #endregion




        #endregion




        #region Кандидаты на зачисление





        #region Инициализация данных

        private void lvGroups_Candidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGroups_Candidates.SelectedItems.Count == 0) return;

            string sql = "SELECT " +
                "abit.id AS 'Идентификатор', " +
                "abit.FIO AS 'ФИО абитуриента', abit.Midball AS 'Средний балл', " +
                "abit.Discipline1 AS 'Оценка 1', abit.Discipline2 AS 'Оценка 2', " +
                "abit.Discipline3 AS 'Оценка 3', spec1.S_title AS 'Специальность 1ый приоритет', " +
                "spec2.S_title AS 'Специальность 2ой приоритет', spec3.S_title AS 'Специальность 3ий приоритет' " +
                "FROM abit " +
                "LEFT JOIN spec AS spec1 ON(spec1.S_id = abit.Prior1) " +
                "LEFT JOIN spec AS spec2 ON(spec2.S_id = abit.Prior2) " +
                "LEFT JOIN spec AS spec3 ON(spec3.S_id = abit.Prior3) " +
                "where spec1.S_title or spec2.S_title or spec3.S_title = " +
                "(SELECT spec.S_title from groups LEFT JOIN spec ON(spec.S_id = groups.gr_spec) " +
                "where groups.gr_name = '" + lvGroups_Candidates.SelectedItems[0].Text + "') and " +
                "(abit.Group_enroll is null)" +
                "order by spec1.S_title asc, spec2.S_title asc, spec3.S_title asc, abit.Midball desc; ";

            DB.RunQuery(sql, out dtAbit_Candidates);
            dgvCandidates.DataSource = dtAbit_Candidates;
            dgvCandidates.Tag = lvGroups_Candidates.SelectedItems[0].Text;

            DataTable buff;
            sql = "select gr_students, gr_students - " +
                "(SELECT count(abit.id) " +
                "FROM abit " +
                "LEFT JOIN spec AS spec1 ON(spec1.S_id = abit.Prior1) " +
                "LEFT JOIN spec AS spec2 ON(spec2.S_id = abit.Prior2) " +
                "LEFT JOIN spec AS spec3 ON(spec3.S_id = abit.Prior3) " +
                "LEFT JOIN groups ON(groups.gr_id = abit.Group_enroll) " +
                "where(spec1.S_title or spec2.S_title or spec3.S_title = " +
                "(SELECT spec.S_title from groups LEFT JOIN spec ON(spec.S_id = groups.gr_spec) " +
                "where groups.gr_name = '" + lvGroups_Candidates.SelectedItems[0].Text + "')) and " +
                "(abit.Group_enroll is not null) " +
                "order by spec1.S_title asc, spec2.S_title asc, spec3.S_title asc, abit.Midball desc) " +
                "from groups where gr_name = '" + lvGroups_Candidates.SelectedItems[0].Text + "'; ";
            DB.RunQuery(sql, out buff);
            tslSlots_Candidates.Text = "Всего мест: " + buff.Rows[0][0].ToString();

            tslFreeSlots_Candidates.Text = "Осталось мест: " + buff.Rows[0][1].ToString();
            tslFreeSlots_Candidates.Tag = buff.Rows[0][1].ToString();
        }

        private void tsbEnroll_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.SelectedRows.Count == 0) return;

            string spec_id = FindID_lvGroups_Candidates();
            if (spec_id == "-1")
            {
                MessageBox.Show("Не удалось найти группу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Convert.ToInt32(tslFreeSlots_Candidates.Tag.ToString()) <= 0)
            {
                MessageBox.Show("В группе нет свободных мест!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "UPDATE abit SET " +
                "abit.Group_enroll = " + spec_id + " " +
                "where abit.id = " + dgvCandidates.SelectedRows[0].Cells[0].Value.ToString() + "; ";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменен сост. группы", dgvCandidates.Tag.ToString() + " Добавлен: " + dgvCandidates.SelectedRows[0].Cells[1].Value.ToString());
                MessageBox.Show("Кандидат успешно добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvGroups_Candidates_SelectedIndexChanged(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Не удалось добавить кандидата!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        private string FindID_lvGroups_Candidates()
        {
            foreach (DataRow i in dtGroups_Candidates.Rows)
            {
                if (dgvCandidates.Tag.ToString() == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private void tsbExportTable_Candidates_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.Rows.Count == 0) return;

            ExportTable("Информация о составе группы \"" + dgvCandidates.Tag.ToString() + "\"", dgvCandidates);
        }

        private void tsbRefresh_Candidates_Click(object sender, EventArgs e)
        {
            lvGroups_Candidates_Fill();
        }





        #endregion

        #region Предварительный состав групп






        #region Инициализация данных

        private void lvGroups_Preliminary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGroups_Preliminary.SelectedItems.Count == 0) return;

            string sql = "SELECT " +
                "abit.id AS 'Идентификатор', " +
                "abit.FIO AS 'ФИО абитуриента', abit.Midball AS 'Средний балл', " +
                "abit.Discipline1 AS 'Оценка 1', abit.Discipline2 AS 'Оценка 2', " +
                "abit.Discipline3 AS 'Оценка 3', spec1.S_title AS 'Специальность 1ый приоритет', " +
                "spec2.S_title AS 'Специальность 2ой приоритет', spec3.S_title AS 'Специальность 3ий приоритет' " +
                "FROM abit " +
                "LEFT JOIN spec AS spec1 ON(spec1.S_id = abit.Prior1) " +
                "LEFT JOIN spec AS spec2 ON(spec2.S_id = abit.Prior2) " +
                "LEFT JOIN spec AS spec3 ON(spec3.S_id = abit.Prior3) " +
                "LEFT JOIN groups ON (groups.gr_id = abit.Group_enroll) " +
                "where spec1.S_title or spec2.S_title or spec3.S_title = " +
                "(SELECT spec.S_title from groups LEFT JOIN spec ON(spec.S_id = groups.gr_spec) where groups.gr_name = '" + lvGroups_Preliminary.SelectedItems[0].Text + "') and " +
                "(groups.gr_name = '" + lvGroups_Preliminary.SelectedItems[0].Text + "') and (abit.Group_enroll is not null)" +
                "order by spec1.S_title asc, spec2.S_title asc, spec3.S_title asc, abit.Midball desc; ";

            DB.RunQuery(sql, out dtAbit_Preliminary);
            dgvPreliminary.DataSource = dtAbit_Preliminary;
            dgvPreliminary.Tag = lvGroups_Preliminary.SelectedItems[0].Text;

            DataTable buff;
            sql = "select gr_students, gr_students - " +
                "(SELECT count(abit.id) " +
                "FROM abit " +
                "LEFT JOIN spec AS spec1 ON(spec1.S_id = abit.Prior1) " +
                "LEFT JOIN spec AS spec2 ON(spec2.S_id = abit.Prior2) " +
                "LEFT JOIN spec AS spec3 ON(spec3.S_id = abit.Prior3) " +
                "LEFT JOIN groups ON(groups.gr_id = abit.Group_enroll) " +
                "where(spec1.S_title or spec2.S_title or spec3.S_title = " +
                "(SELECT spec.S_title from groups LEFT JOIN spec ON(spec.S_id = groups.gr_spec) " +
                "where groups.gr_name = '" + lvGroups_Preliminary.SelectedItems[0].Text + "')) and " +
                "(abit.Group_enroll is not null) " +
                "order by spec1.S_title asc, spec2.S_title asc, spec3.S_title asc, abit.Midball desc) " +
                "from groups where gr_name = '" + lvGroups_Preliminary.SelectedItems[0].Text + "'; ";
            DB.RunQuery(sql, out buff);
            tslSlots_Preliminary.Text = "Всего мест: " + buff.Rows[0][0].ToString();

            tslFreeSlots_Preliminary.Text = "Осталось мест: " + buff.Rows[0][1].ToString();
            tslFreeSlots_Preliminary.Tag = buff.Rows[0][1].ToString();
        }


        #endregion

        private void tsbRefresh_Preliminary_Click(object sender, EventArgs e)
        {
            lvGroups_Preliminary_SelectedIndexChanged(this, new EventArgs());
        }

        private void tsbUnenroll_Click(object sender, EventArgs e)
        {
            if (dgvPreliminary.SelectedRows.Count == 0) return;

            string sql = "UPDATE abit SET " +
                "abit.Group_enroll = NULL " +
                "where abit.id = " + dgvPreliminary.SelectedRows[0].Cells[0].Value.ToString() + "; ";

            if (MainForm.DB.RunCommand(sql))
            {
                MainForm.DB.Add_log("Изменен сост. группы", dgvPreliminary.Tag.ToString() + " Исключен: " + dgvPreliminary.SelectedRows[0].Cells[1].Value.ToString());
                MessageBox.Show("Кандидат успешно удален!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvGroups_Preliminary_SelectedIndexChanged(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Не удалось удалить кандидата!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbDes_Preliminary_Click(object sender, EventArgs e)
        {
            if (dgvPreliminary.SelectedRows.Count == 0) return;

            Form_Add_Decision form = new Form_Add_Decision();
            form.FieldsIni(dgvPreliminary.SelectedRows[0].Cells[1].ToString(), dgvPreliminary.Tag.ToString());
            form.ShowDialog();
        }

        private string FindID_lvGroups_Preliminary()
        {
            foreach (DataRow i in dtGroups_Candidates.Rows)
            {
                if (dgvPreliminary.Tag.ToString() == i[0].ToString())
                {
                    return i[1].ToString();
                }
            }
            return "-1";
        }

        private void tsbExport_Preliminary_Click(object sender, EventArgs e)
        {
            if (dgvPreliminary.Rows.Count == 0) return;

            ExportTable("Информация о составе группы \"" + dgvPreliminary.Tag.ToString() + "\"", dgvPreliminary);
        }





        #endregion

        #region Сформированный состав групп

        private void lvGroups_Formed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGroups_Formed.SelectedItems.Count == 0) return;

            string sql = "SELECT " +
                "abit.id AS 'Идентификатор', " +
                "abit.FIO AS 'ФИО абитуриента', abit.Midball AS 'Средний балл', " +
                "abit.Gender AS 'Пол', abit.BirthDate AS 'Дата рождения', " +
                "abit.Phone AS 'Телефон' " +
                "FROM decision " +
                "LEFT JOIN abit ON (decision.Des_abit = abit.id) " +
                "LEFT JOIN groups ON (groups.gr_id = abit.Group_enroll) " +
                "where groups.gr_name = '" + lvGroups_Formed.SelectedItems[0].Text + "' ";

            DB.RunQuery(sql, out dtAbit_Formed);
            dgvFormed.DataSource = dtAbit_Formed;
            dgvFormed.Tag = lvGroups_Formed.SelectedItems[0].Text;
        }

        private void tsbExportTable_Formed_Click(object sender, EventArgs e)
        {
            if (dgvFormed.Rows.Count == 0) return;

            ExportTable("Информация о составе группы \"" + dgvFormed.Tag.ToString() + "\"", dgvFormed);
        }








        #endregion


    }
}
