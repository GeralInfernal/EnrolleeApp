namespace EnrolleeApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiMenu_Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeConnections = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu_EventLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LocalEventLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEventLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsciAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsl_PrevOpStatus = new System.Windows.Forms.ToolStripLabel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbID_Parent = new System.Windows.Forms.TextBox();
            this.tbPhone_Parent = new System.Windows.Forms.TextBox();
            this.tbWorkpost_Parent = new System.Windows.Forms.TextBox();
            this.tbAdrFact_Parent = new System.Windows.Forms.TextBox();
            this.tbAdrReg_Parent = new System.Windows.Forms.TextBox();
            this.tbFIO_Parent = new System.Windows.Forms.TextBox();
            this.tbID_Status = new System.Windows.Forms.TextBox();
            this.tbDocinform_Status = new System.Windows.Forms.TextBox();
            this.tbStatusType_Status = new System.Windows.Forms.TextBox();
            this.cbAbit_Status = new System.Windows.Forms.ComboBox();
            this.tbID_Military = new System.Windows.Forms.TextBox();
            this.tbDocinform_Military = new System.Windows.Forms.TextBox();
            this.tbDocument_Military = new System.Windows.Forms.TextBox();
            this.cbAbit_Military = new System.Windows.Forms.ComboBox();
            this.tbID_Spec = new System.Windows.Forms.TextBox();
            this.tbTitle_Spec = new System.Windows.Forms.TextBox();
            this.cbBudjet_Spec = new System.Windows.Forms.ComboBox();
            this.cbOchn_Spec = new System.Windows.Forms.ComboBox();
            this.cbDiscipline3_Spec = new System.Windows.Forms.ComboBox();
            this.cbDiscipline2_Spec = new System.Windows.Forms.ComboBox();
            this.cbDiscipline1_Spec = new System.Windows.Forms.ComboBox();
            this.tbShort_Spec = new System.Windows.Forms.TextBox();
            this.tbSpecName_Spec = new System.Windows.Forms.TextBox();
            this.tbShifr_Spec = new System.Windows.Forms.TextBox();
            this.tbID_Discipline = new System.Windows.Forms.TextBox();
            this.tbName_Discipline = new System.Windows.Forms.TextBox();
            this.tbID_Base = new System.Windows.Forms.TextBox();
            this.tbName_Base = new System.Windows.Forms.TextBox();
            this.tbID_Lang = new System.Windows.Forms.TextBox();
            this.tbName_Lang = new System.Windows.Forms.TextBox();
            this.tbID_Komis = new System.Windows.Forms.TextBox();
            this.tbName_Komis = new System.Windows.Forms.TextBox();
            this.tbID_Polity = new System.Windows.Forms.TextBox();
            this.tbName_Polity = new System.Windows.Forms.TextBox();
            this.cbGroup_Decision = new System.Windows.Forms.ComboBox();
            this.tbID_Decision = new System.Windows.Forms.TextBox();
            this.dtpDate_Decision = new System.Windows.Forms.DateTimePicker();
            this.cbKomis_Decision = new System.Windows.Forms.ComboBox();
            this.tbComment_Decision = new System.Windows.Forms.TextBox();
            this.tbResolution_Decision = new System.Windows.Forms.TextBox();
            this.tbID_Groups = new System.Windows.Forms.TextBox();
            this.tbStudents_Groups = new System.Windows.Forms.TextBox();
            this.tbYear_Groups = new System.Windows.Forms.TextBox();
            this.tbName_Groups = new System.Windows.Forms.TextBox();
            this.cbSpec_Groups = new System.Windows.Forms.ComboBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tcMain_Table = new System.Windows.Forms.TabControl();
            this.tpAbit = new System.Windows.Forms.TabPage();
            this.tcAbit = new System.Windows.Forms.TabControl();
            this.tpTable_Abit = new System.Windows.Forms.TabPage();
            this.dgvAbit = new System.Windows.Forms.DataGridView();
            this.tsClients = new System.Windows.Forms.ToolStrip();
            this.tsbAddAbit = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeAbit = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteAbit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbShowColumns = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator103 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Abit = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Abit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator43 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Abit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator44 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Abit = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator45 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Abit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilterAbit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Abit = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Abit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator29 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Abit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator30 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Abit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Abit = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Abit = new System.Windows.Forms.TabPage();
            this.l_stats_Objective = new System.Windows.Forms.Label();
            this.l_stats_Orphan = new System.Windows.Forms.Label();
            this.l_stats_abitCount = new System.Windows.Forms.Label();
            this.l_stats_Invalid = new System.Windows.Forms.Label();
            this.l_stats_AbitCountCurr = new System.Windows.Forms.Label();
            this.l_stats_Contract = new System.Windows.Forms.Label();
            this.l_stats_NeedHostelCurr = new System.Windows.Forms.Label();
            this.l_stats_NeedHostel = new System.Windows.Forms.Label();
            this.l_stats_Male = new System.Windows.Forms.Label();
            this.l_stats_MidballCurr = new System.Windows.Forms.Label();
            this.l_stats_Female = new System.Windows.Forms.Label();
            this.l_stats_Midball = new System.Windows.Forms.Label();
            this.tpParents = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTable_Parent = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_Workpost = new System.Windows.Forms.Label();
            this.l_AdrFact = new System.Windows.Forms.Label();
            this.l_adrreg = new System.Windows.Forms.Label();
            this.l_ParentFIO = new System.Windows.Forms.Label();
            this.cbAbit_Parent = new System.Windows.Forms.ComboBox();
            this.l_Abit = new System.Windows.Forms.Label();
            this.dgvParent = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Parent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter_Parent = new System.Windows.Forms.Splitter();
            this.tsParent = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Parent = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Parent = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Parent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Parent = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Parent = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Parent = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Parent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Parent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Parent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Parent = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Parent = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Parent = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Parent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Parent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport_Parent = new System.Windows.Forms.ToolStripButton();
            this.tsbExportAll_Parent = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Parent = new System.Windows.Forms.TabPage();
            this.l_stats_ParentCount = new System.Windows.Forms.Label();
            this.tpStatus = new System.Windows.Forms.TabPage();
            this.tcStatus = new System.Windows.Forms.TabControl();
            this.tpTable_Status = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.l_Docinform = new System.Windows.Forms.Label();
            this.l_StatusType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Status = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter_Status = new System.Windows.Forms.Splitter();
            this.tsStatus = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Status = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Status = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Status = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Status = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Status = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Status = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Status = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Status = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Status = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Status = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Status = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Status = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport_Status = new System.Windows.Forms.ToolStripButton();
            this.tsbExportAll_Status = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Status = new System.Windows.Forms.TabPage();
            this.l_stats_StatusCount = new System.Windows.Forms.Label();
            this.tpMilitary = new System.Windows.Forms.TabPage();
            this.tcMilitary = new System.Windows.Forms.TabControl();
            this.tpTable_Military = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMilitary = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Military = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter_Military = new System.Windows.Forms.Splitter();
            this.tsMilitary = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Military = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Military = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Military = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Military = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Military = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator31 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Military = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator32 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Military = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator33 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Military = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Military = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator34 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Military = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Military = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator35 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Military = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator36 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Military = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator37 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Military = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator38 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport_Military = new System.Windows.Forms.ToolStripButton();
            this.tsbExportAll_Military = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Military = new System.Windows.Forms.TabPage();
            this.l_stats_Military = new System.Windows.Forms.Label();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.tcInfo_Table = new System.Windows.Forms.TabControl();
            this.tpSpec = new System.Windows.Forms.TabPage();
            this.tcSpec = new System.Windows.Forms.TabControl();
            this.tpTable_Spec = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvSpec = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Spec = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.splitter_Spec = new System.Windows.Forms.Splitter();
            this.tsSpec = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Spec = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Spec = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Spec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator39 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Spec = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Spec = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator40 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Spec = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator41 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Spec = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator42 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Spec = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Spec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator46 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Spec = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Spec = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator47 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Spec = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator48 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Spec = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator49 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Spec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator50 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport_Spec = new System.Windows.Forms.ToolStripButton();
            this.tsbExportAll_Spec = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Spec = new System.Windows.Forms.TabPage();
            this.l_stats_SpecChargeable = new System.Windows.Forms.Label();
            this.l_stats_SpecBudjet = new System.Windows.Forms.Label();
            this.l_stats_SpecCount = new System.Windows.Forms.Label();
            this.l_stats_SpecZaochn = new System.Windows.Forms.Label();
            this.l_stats_SpecOchn = new System.Windows.Forms.Label();
            this.tpDiscipline = new System.Windows.Forms.TabPage();
            this.tcDiscipline = new System.Windows.Forms.TabControl();
            this.tpTable_Discipline = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.l_DisciplineName = new System.Windows.Forms.Label();
            this.dgvDiscipline = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Discipline = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.splitter_Discipline = new System.Windows.Forms.Splitter();
            this.tsDiscipline = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Discipline = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Discipline = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Discipline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator51 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Discipline = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Discipline = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator52 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Discipline = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator53 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Discipline = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator54 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Discipline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Discipline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator55 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Discipline = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Discipline = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator56 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Discipline = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator57 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Discipline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator58 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Discipline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator59 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportAll_Discipline = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Discipline = new System.Windows.Forms.TabPage();
            this.l_stats_DisciplineCount = new System.Windows.Forms.Label();
            this.tpBase = new System.Windows.Forms.TabPage();
            this.tcBase = new System.Windows.Forms.TabControl();
            this.tpTable_Base = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Base = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.splitter_Base = new System.Windows.Forms.Splitter();
            this.tsBase = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Base = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Base = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Base = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator60 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Base = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Base = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator61 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Base = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator62 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Base = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator63 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Base = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Base = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator64 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Base = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Base = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator65 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Base = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator66 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Base = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator67 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Base = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator68 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportAll_Base = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Base = new System.Windows.Forms.TabPage();
            this.l_stats_BaseCount = new System.Windows.Forms.Label();
            this.tpLang = new System.Windows.Forms.TabPage();
            this.tcLang = new System.Windows.Forms.TabControl();
            this.tpTable_Lang = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.dgvLang = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Lang = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.splitter_Lang = new System.Windows.Forms.Splitter();
            this.tsLang = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Lang = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Lang = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Lang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator69 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Lang = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Lang = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator70 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Lang = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator71 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Lang = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator72 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Lang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Lang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator73 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Lang = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Lang = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator74 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Lang = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator75 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Lang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator76 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Lang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator77 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportAll_Lang = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Lang = new System.Windows.Forms.TabPage();
            this.l_stats_LangCount = new System.Windows.Forms.Label();
            this.tpKomis2 = new System.Windows.Forms.TabPage();
            this.tcKomis = new System.Windows.Forms.TabControl();
            this.tpTable_Komis = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.dgvKomis = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Komis = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.splitter_Komis = new System.Windows.Forms.Splitter();
            this.tsKomis = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Komis = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Komis = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Komis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator78 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Komis = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Komis = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator79 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Komis = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator80 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem43 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Komis = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator81 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Komis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Komis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator82 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Komis = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem44 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Komis = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator83 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem45 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Komis = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator84 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Komis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator85 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Komis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator86 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportAll_Komis = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Komis = new System.Windows.Forms.TabPage();
            this.l_stats_KomisCount = new System.Windows.Forms.Label();
            this.tpPolity = new System.Windows.Forms.TabPage();
            this.tcPolity = new System.Windows.Forms.TabControl();
            this.tpTable_Polity = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.dgvPolity = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Polity = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.splitter_Polity = new System.Windows.Forms.Splitter();
            this.tsPolity = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Polity = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Polity = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Polity = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Polity = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem46 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Polity = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem47 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Polity = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Polity = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator87 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Polity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Polity = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator88 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Polity = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Polity = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator89 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Polity = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator90 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Polity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator91 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Polity = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator92 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportAll_Polity = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Polity = new System.Windows.Forms.TabPage();
            this.l_stats_PolityCount = new System.Windows.Forms.Label();
            this.tpEnrollment = new System.Windows.Forms.TabPage();
            this.tcEnlistment = new System.Windows.Forms.TabControl();
            this.tpGroups = new System.Windows.Forms.TabPage();
            this.tcGroups = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Groups = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.splitter_Groups = new System.Windows.Forms.Splitter();
            this.tsGroups = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Groups = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Groups = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Groups = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator105 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Groups = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem56 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Groups = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator106 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem57 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Groups = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator107 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem58 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Groups = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator108 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Groups = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Groups = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator109 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Groups = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem60 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Groups = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator110 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem61 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Groups = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator111 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Groups = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator112 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Groups = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator113 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport_Groups = new System.Windows.Forms.ToolStripButton();
            this.tsbExportAll_Groups = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.tpCandidates = new System.Windows.Forms.TabPage();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.tsCandidates = new System.Windows.Forms.ToolStrip();
            this.tsbEnroll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator114 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Candidates = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator122 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportTable_Candidates = new System.Windows.Forms.ToolStripButton();
            this.tslFreeSlots_Candidates = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator102 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSlots_Candidates = new System.Windows.Forms.ToolStripLabel();
            this.lvGroups_Candidates = new System.Windows.Forms.ListView();
            this.tpPreliminaryGroups = new System.Windows.Forms.TabPage();
            this.dgvPreliminary = new System.Windows.Forms.DataGridView();
            this.tsPreliminary = new System.Windows.Forms.ToolStrip();
            this.tsbDes_Preliminary = new System.Windows.Forms.ToolStripButton();
            this.tsbUnenroll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Preliminary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator130 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport_Preliminary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator104 = new System.Windows.Forms.ToolStripSeparator();
            this.tslFreeSlots_Preliminary = new System.Windows.Forms.ToolStripLabel();
            this.tslSlots_Preliminary = new System.Windows.Forms.ToolStripLabel();
            this.lvGroups_Preliminary = new System.Windows.Forms.ListView();
            this.tpDecision = new System.Windows.Forms.TabPage();
            this.tcDesicion = new System.Windows.Forms.TabControl();
            this.tpTable_Desicion = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.dgvDecision = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Desicion = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.splitter_Decision = new System.Windows.Forms.Splitter();
            this.tsDecision = new System.Windows.Forms.ToolStrip();
            this.tsbAdd_Decision = new System.Windows.Forms.ToolStripButton();
            this.tsbChange_Decision = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete_Decision = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator93 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbFilter_Decision = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterField_Decision = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator94 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem52 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilterOper_Decision = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator95 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilterValue_Decision = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator96 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilterApply_Decision = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetFilter_Decision = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator97 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbSort_Decision = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortField_Decision = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator98 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbSortOrder_Decision = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator99 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortApply_Decision = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator100 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh_Decision = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator101 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport_Decision = new System.Windows.Forms.ToolStripButton();
            this.tsbExportAll_Decision = new System.Windows.Forms.ToolStripButton();
            this.tpStats_Desicion = new System.Windows.Forms.TabPage();
            this.l_DecisionPercentYear = new System.Windows.Forms.Label();
            this.l_DecisionCount = new System.Windows.Forms.Label();
            this.l_DecisionCountYear = new System.Windows.Forms.Label();
            this.l_DecisionPercent = new System.Windows.Forms.Label();
            this.tpFormedGroups = new System.Windows.Forms.TabPage();
            this.dgvFormed = new System.Windows.Forms.DataGridView();
            this.tsFormed = new System.Windows.Forms.ToolStrip();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator139 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportTable_Formed = new System.Windows.Forms.ToolStripButton();
            this.lvGroups_Formed = new System.Windows.Forms.ListView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tcMain_Table.SuspendLayout();
            this.tpAbit.SuspendLayout();
            this.tcAbit.SuspendLayout();
            this.tpTable_Abit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbit)).BeginInit();
            this.tsClients.SuspendLayout();
            this.tpStats_Abit.SuspendLayout();
            this.tpParents.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTable_Parent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent)).BeginInit();
            this.tsParent.SuspendLayout();
            this.tpStats_Parent.SuspendLayout();
            this.tpStatus.SuspendLayout();
            this.tcStatus.SuspendLayout();
            this.tpTable_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.tsStatus.SuspendLayout();
            this.tpStats_Status.SuspendLayout();
            this.tpMilitary.SuspendLayout();
            this.tcMilitary.SuspendLayout();
            this.tpTable_Military.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilitary)).BeginInit();
            this.tsMilitary.SuspendLayout();
            this.tpStats_Military.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tcInfo_Table.SuspendLayout();
            this.tpSpec.SuspendLayout();
            this.tcSpec.SuspendLayout();
            this.tpTable_Spec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpec)).BeginInit();
            this.tsSpec.SuspendLayout();
            this.tpStats_Spec.SuspendLayout();
            this.tpDiscipline.SuspendLayout();
            this.tcDiscipline.SuspendLayout();
            this.tpTable_Discipline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscipline)).BeginInit();
            this.tsDiscipline.SuspendLayout();
            this.tpStats_Discipline.SuspendLayout();
            this.tpBase.SuspendLayout();
            this.tcBase.SuspendLayout();
            this.tpTable_Base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            this.tsBase.SuspendLayout();
            this.tpStats_Base.SuspendLayout();
            this.tpLang.SuspendLayout();
            this.tcLang.SuspendLayout();
            this.tpTable_Lang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLang)).BeginInit();
            this.tsLang.SuspendLayout();
            this.tpStats_Lang.SuspendLayout();
            this.tpKomis2.SuspendLayout();
            this.tcKomis.SuspendLayout();
            this.tpTable_Komis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomis)).BeginInit();
            this.tsKomis.SuspendLayout();
            this.tpStats_Komis.SuspendLayout();
            this.tpPolity.SuspendLayout();
            this.tcPolity.SuspendLayout();
            this.tpTable_Polity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolity)).BeginInit();
            this.tsPolity.SuspendLayout();
            this.tpStats_Polity.SuspendLayout();
            this.tpEnrollment.SuspendLayout();
            this.tcEnlistment.SuspendLayout();
            this.tpGroups.SuspendLayout();
            this.tcGroups.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.tsGroups.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tpCandidates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            this.tsCandidates.SuspendLayout();
            this.tpPreliminaryGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreliminary)).BeginInit();
            this.tsPreliminary.SuspendLayout();
            this.tpDecision.SuspendLayout();
            this.tcDesicion.SuspendLayout();
            this.tpTable_Desicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecision)).BeginInit();
            this.tsDecision.SuspendLayout();
            this.tpStats_Desicion.SuspendLayout();
            this.tpFormedGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormed)).BeginInit();
            this.tsFormed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu_Connection,
            this.tsmiMenu_EventLog,
            this.tsmiHelp,
            this.tsmiUser});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(995, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiMenu_Connection
            // 
            this.tsmiMenu_Connection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetup,
            this.toolStripSeparator3,
            this.tsmiDisconnect});
            this.tsmiMenu_Connection.Name = "tsmiMenu_Connection";
            this.tsmiMenu_Connection.Size = new System.Drawing.Size(97, 20);
            this.tsmiMenu_Connection.Text = "&Подключение";
            // 
            // tsmiSetup
            // 
            this.tsmiSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangeConnections});
            this.tsmiSetup.Name = "tsmiSetup";
            this.tsmiSetup.Size = new System.Drawing.Size(148, 22);
            this.tsmiSetup.Text = "Настройка";
            // 
            // tsmiChangeConnections
            // 
            this.tsmiChangeConnections.Name = "tsmiChangeConnections";
            this.tsmiChangeConnections.Size = new System.Drawing.Size(172, 22);
            this.tsmiChangeConnections.Text = "Наборы настроек";
            this.tsmiChangeConnections.Click += new System.EventHandler(this.tsmiChangeConnections_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiDisconnect
            // 
            this.tsmiDisconnect.Name = "tsmiDisconnect";
            this.tsmiDisconnect.Size = new System.Drawing.Size(148, 22);
            this.tsmiDisconnect.Text = "Отключиться";
            this.tsmiDisconnect.Click += new System.EventHandler(this.tsmiDisconnect_Click);
            // 
            // tsmiMenu_EventLog
            // 
            this.tsmiMenu_EventLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_LocalEventLog,
            this.tsmiEventLog});
            this.tsmiMenu_EventLog.Name = "tsmiMenu_EventLog";
            this.tsmiMenu_EventLog.Size = new System.Drawing.Size(114, 20);
            this.tsmiMenu_EventLog.Text = "Журнал событий";
            // 
            // tsmi_LocalEventLog
            // 
            this.tsmi_LocalEventLog.Name = "tsmi_LocalEventLog";
            this.tsmi_LocalEventLog.Size = new System.Drawing.Size(233, 22);
            this.tsmi_LocalEventLog.Text = "Локальный журнал событий";
            this.tsmi_LocalEventLog.Click += new System.EventHandler(this.tsmi_LocalEventLog_Click);
            // 
            // tsmiEventLog
            // 
            this.tsmiEventLog.Name = "tsmiEventLog";
            this.tsmiEventLog.Size = new System.Drawing.Size(233, 22);
            this.tsmiEventLog.Text = "Журнал событий";
            this.tsmiEventLog.Click += new System.EventHandler(this.tsmiEventLog_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiContent,
            this.toolStripSeparator5,
            this.tsciAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(65, 20);
            this.tsmiHelp.Text = "Спра&вка";
            // 
            // tsmiContent
            // 
            this.tsmiContent.Name = "tsmiContent";
            this.tsmiContent.Size = new System.Drawing.Size(158, 22);
            this.tsmiContent.Text = "&Содержание";
            this.tsmiContent.Click += new System.EventHandler(this.tsmiContent_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // tsciAbout
            // 
            this.tsciAbout.Name = "tsciAbout";
            this.tsciAbout.Size = new System.Drawing.Size(158, 22);
            this.tsciAbout.Text = "&О программе...";
            this.tsciAbout.Click += new System.EventHandler(this.tsciAbout_Click);
            // 
            // tsmiUser
            // 
            this.tsmiUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePass});
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(96, 20);
            this.tsmiUser.Text = "Пользователь";
            // 
            // tsmiChangePass
            // 
            this.tsmiChangePass.Name = "tsmiChangePass";
            this.tsmiChangePass.Size = new System.Drawing.Size(165, 22);
            this.tsmiChangePass.Text = "Сменить пароль";
            this.tsmiChangePass.Click += new System.EventHandler(this.tsmiChangePass_Click_1);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_PrevOpStatus});
            this.toolStrip.Location = new System.Drawing.Point(0, 506);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(995, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsl_PrevOpStatus
            // 
            this.tsl_PrevOpStatus.Name = "tsl_PrevOpStatus";
            this.tsl_PrevOpStatus.Size = new System.Drawing.Size(48, 22);
            this.tsl_PrevOpStatus.Text = "Готово!";
            // 
            // tbID_Parent
            // 
            this.tbID_Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Parent.Location = new System.Drawing.Point(651, 65);
            this.tbID_Parent.Name = "tbID_Parent";
            this.tbID_Parent.ReadOnly = true;
            this.tbID_Parent.Size = new System.Drawing.Size(294, 20);
            this.tbID_Parent.TabIndex = 111;
            this.toolTip.SetToolTip(this.tbID_Parent, "Идентификатор записи о родителе");
            // 
            // tbPhone_Parent
            // 
            this.tbPhone_Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhone_Parent.Location = new System.Drawing.Point(651, 222);
            this.tbPhone_Parent.Name = "tbPhone_Parent";
            this.tbPhone_Parent.Size = new System.Drawing.Size(294, 20);
            this.tbPhone_Parent.TabIndex = 109;
            this.toolTip.SetToolTip(this.tbPhone_Parent, "Номер телефона родителя");
            // 
            // tbWorkpost_Parent
            // 
            this.tbWorkpost_Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWorkpost_Parent.Location = new System.Drawing.Point(651, 196);
            this.tbWorkpost_Parent.Name = "tbWorkpost_Parent";
            this.tbWorkpost_Parent.Size = new System.Drawing.Size(294, 20);
            this.tbWorkpost_Parent.TabIndex = 107;
            this.toolTip.SetToolTip(this.tbWorkpost_Parent, "Место работы и занимаимая должность родителя, если есть");
            // 
            // tbAdrFact_Parent
            // 
            this.tbAdrFact_Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdrFact_Parent.Location = new System.Drawing.Point(651, 170);
            this.tbAdrFact_Parent.Name = "tbAdrFact_Parent";
            this.tbAdrFact_Parent.Size = new System.Drawing.Size(294, 20);
            this.tbAdrFact_Parent.TabIndex = 105;
            this.toolTip.SetToolTip(this.tbAdrFact_Parent, "Адрес проживания родителя");
            // 
            // tbAdrReg_Parent
            // 
            this.tbAdrReg_Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdrReg_Parent.Location = new System.Drawing.Point(651, 144);
            this.tbAdrReg_Parent.Name = "tbAdrReg_Parent";
            this.tbAdrReg_Parent.Size = new System.Drawing.Size(294, 20);
            this.tbAdrReg_Parent.TabIndex = 103;
            this.toolTip.SetToolTip(this.tbAdrReg_Parent, "Адрес регистрации родителя");
            // 
            // tbFIO_Parent
            // 
            this.tbFIO_Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFIO_Parent.Location = new System.Drawing.Point(651, 118);
            this.tbFIO_Parent.Name = "tbFIO_Parent";
            this.tbFIO_Parent.Size = new System.Drawing.Size(294, 20);
            this.tbFIO_Parent.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbFIO_Parent, "ФИО родителя");
            // 
            // tbID_Status
            // 
            this.tbID_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Status.Location = new System.Drawing.Point(708, 63);
            this.tbID_Status.Name = "tbID_Status";
            this.tbID_Status.ReadOnly = true;
            this.tbID_Status.Size = new System.Drawing.Size(240, 20);
            this.tbID_Status.TabIndex = 105;
            this.toolTip.SetToolTip(this.tbID_Status, "Идентификатор статуса");
            // 
            // tbDocinform_Status
            // 
            this.tbDocinform_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocinform_Status.Location = new System.Drawing.Point(620, 164);
            this.tbDocinform_Status.Multiline = true;
            this.tbDocinform_Status.Name = "tbDocinform_Status";
            this.tbDocinform_Status.Size = new System.Drawing.Size(328, 80);
            this.tbDocinform_Status.TabIndex = 102;
            this.toolTip.SetToolTip(this.tbDocinform_Status, "Информация из предоставленного абитуриентом документа, подтверждающего статус");
            // 
            // tbStatusType_Status
            // 
            this.tbStatusType_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatusType_Status.Location = new System.Drawing.Point(708, 116);
            this.tbStatusType_Status.Name = "tbStatusType_Status";
            this.tbStatusType_Status.Size = new System.Drawing.Size(240, 20);
            this.tbStatusType_Status.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbStatusType_Status, "Тип статуса, подтверждаемый предоставленным абитуриентом документом");
            // 
            // cbAbit_Status
            // 
            this.cbAbit_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbit_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbit_Status.FormattingEnabled = true;
            this.cbAbit_Status.Location = new System.Drawing.Point(708, 89);
            this.cbAbit_Status.Name = "cbAbit_Status";
            this.cbAbit_Status.Size = new System.Drawing.Size(240, 21);
            this.cbAbit_Status.TabIndex = 99;
            this.toolTip.SetToolTip(this.cbAbit_Status, "Абитуриент, для которого устанавливается статус");
            // 
            // tbID_Military
            // 
            this.tbID_Military.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Military.Location = new System.Drawing.Point(709, 63);
            this.tbID_Military.Name = "tbID_Military";
            this.tbID_Military.ReadOnly = true;
            this.tbID_Military.Size = new System.Drawing.Size(235, 20);
            this.tbID_Military.TabIndex = 105;
            this.toolTip.SetToolTip(this.tbID_Military, "Идентификатор воинской обязанности");
            // 
            // tbDocinform_Military
            // 
            this.tbDocinform_Military.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocinform_Military.Location = new System.Drawing.Point(616, 164);
            this.tbDocinform_Military.Multiline = true;
            this.tbDocinform_Military.Name = "tbDocinform_Military";
            this.tbDocinform_Military.Size = new System.Drawing.Size(328, 80);
            this.tbDocinform_Military.TabIndex = 102;
            this.toolTip.SetToolTip(this.tbDocinform_Military, "Информация из предоставленного абитуриентом документа, подтверждающего воинскую о" +
        "бязанность");
            // 
            // tbDocument_Military
            // 
            this.tbDocument_Military.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocument_Military.Location = new System.Drawing.Point(709, 116);
            this.tbDocument_Military.Name = "tbDocument_Military";
            this.tbDocument_Military.Size = new System.Drawing.Size(235, 20);
            this.tbDocument_Military.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbDocument_Military, "Название документа, подтверждающего воинскую обязанность");
            // 
            // cbAbit_Military
            // 
            this.cbAbit_Military.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbit_Military.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbit_Military.FormattingEnabled = true;
            this.cbAbit_Military.Location = new System.Drawing.Point(709, 89);
            this.cbAbit_Military.Name = "cbAbit_Military";
            this.cbAbit_Military.Size = new System.Drawing.Size(235, 21);
            this.cbAbit_Military.TabIndex = 99;
            this.toolTip.SetToolTip(this.cbAbit_Military, "Абитуриент, для которого устанавливается воинская обязанность");
            // 
            // tbID_Spec
            // 
            this.tbID_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Spec.Location = new System.Drawing.Point(609, 59);
            this.tbID_Spec.Name = "tbID_Spec";
            this.tbID_Spec.ReadOnly = true;
            this.tbID_Spec.Size = new System.Drawing.Size(334, 20);
            this.tbID_Spec.TabIndex = 119;
            this.toolTip.SetToolTip(this.tbID_Spec, "Шифр специальности");
            // 
            // tbTitle_Spec
            // 
            this.tbTitle_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle_Spec.Location = new System.Drawing.Point(609, 137);
            this.tbTitle_Spec.Name = "tbTitle_Spec";
            this.tbTitle_Spec.Size = new System.Drawing.Size(334, 20);
            this.tbTitle_Spec.TabIndex = 117;
            this.toolTip.SetToolTip(this.tbTitle_Spec, "Название специальности");
            // 
            // cbBudjet_Spec
            // 
            this.cbBudjet_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBudjet_Spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBudjet_Spec.FormattingEnabled = true;
            this.cbBudjet_Spec.Items.AddRange(new object[] {
            "Бюджетная",
            "Платная"});
            this.cbBudjet_Spec.Location = new System.Drawing.Point(609, 216);
            this.cbBudjet_Spec.Name = "cbBudjet_Spec";
            this.cbBudjet_Spec.Size = new System.Drawing.Size(334, 21);
            this.cbBudjet_Spec.TabIndex = 115;
            this.toolTip.SetToolTip(this.cbBudjet_Spec, "Основа обучения на специальности");
            // 
            // cbOchn_Spec
            // 
            this.cbOchn_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOchn_Spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOchn_Spec.FormattingEnabled = true;
            this.cbOchn_Spec.Items.AddRange(new object[] {
            "Очная",
            "Заочная"});
            this.cbOchn_Spec.Location = new System.Drawing.Point(609, 190);
            this.cbOchn_Spec.Name = "cbOchn_Spec";
            this.cbOchn_Spec.Size = new System.Drawing.Size(334, 21);
            this.cbOchn_Spec.TabIndex = 114;
            this.toolTip.SetToolTip(this.cbOchn_Spec, "Форма обучения на специальности");
            // 
            // cbDiscipline3_Spec
            // 
            this.cbDiscipline3_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiscipline3_Spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscipline3_Spec.FormattingEnabled = true;
            this.cbDiscipline3_Spec.Location = new System.Drawing.Point(660, 296);
            this.cbDiscipline3_Spec.Name = "cbDiscipline3_Spec";
            this.cbDiscipline3_Spec.Size = new System.Drawing.Size(283, 21);
            this.cbDiscipline3_Spec.TabIndex = 111;
            this.toolTip.SetToolTip(this.cbDiscipline3_Spec, "Третья ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // cbDiscipline2_Spec
            // 
            this.cbDiscipline2_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiscipline2_Spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscipline2_Spec.FormattingEnabled = true;
            this.cbDiscipline2_Spec.Location = new System.Drawing.Point(660, 269);
            this.cbDiscipline2_Spec.Name = "cbDiscipline2_Spec";
            this.cbDiscipline2_Spec.Size = new System.Drawing.Size(283, 21);
            this.cbDiscipline2_Spec.TabIndex = 109;
            this.toolTip.SetToolTip(this.cbDiscipline2_Spec, "Вторая ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // cbDiscipline1_Spec
            // 
            this.cbDiscipline1_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiscipline1_Spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscipline1_Spec.FormattingEnabled = true;
            this.cbDiscipline1_Spec.Location = new System.Drawing.Point(660, 242);
            this.cbDiscipline1_Spec.Name = "cbDiscipline1_Spec";
            this.cbDiscipline1_Spec.Size = new System.Drawing.Size(283, 21);
            this.cbDiscipline1_Spec.TabIndex = 107;
            this.toolTip.SetToolTip(this.cbDiscipline1_Spec, "Первая ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // tbShort_Spec
            // 
            this.tbShort_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShort_Spec.Location = new System.Drawing.Point(609, 164);
            this.tbShort_Spec.Name = "tbShort_Spec";
            this.tbShort_Spec.Size = new System.Drawing.Size(334, 20);
            this.tbShort_Spec.TabIndex = 103;
            this.toolTip.SetToolTip(this.tbShort_Spec, "Аббревиатура специальности");
            // 
            // tbSpecName_Spec
            // 
            this.tbSpecName_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpecName_Spec.Location = new System.Drawing.Point(609, 111);
            this.tbSpecName_Spec.Name = "tbSpecName_Spec";
            this.tbSpecName_Spec.Size = new System.Drawing.Size(334, 20);
            this.tbSpecName_Spec.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbSpecName_Spec, "Название квалификации по специальности");
            // 
            // tbShifr_Spec
            // 
            this.tbShifr_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShifr_Spec.Location = new System.Drawing.Point(609, 85);
            this.tbShifr_Spec.Name = "tbShifr_Spec";
            this.tbShifr_Spec.Size = new System.Drawing.Size(334, 20);
            this.tbShifr_Spec.TabIndex = 99;
            this.toolTip.SetToolTip(this.tbShifr_Spec, "Шифр специальности");
            // 
            // tbID_Discipline
            // 
            this.tbID_Discipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Discipline.Location = new System.Drawing.Point(720, 69);
            this.tbID_Discipline.Name = "tbID_Discipline";
            this.tbID_Discipline.ReadOnly = true;
            this.tbID_Discipline.Size = new System.Drawing.Size(226, 20);
            this.tbID_Discipline.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbID_Discipline, "Идентификатор дисциплины");
            // 
            // tbName_Discipline
            // 
            this.tbName_Discipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName_Discipline.Location = new System.Drawing.Point(720, 95);
            this.tbName_Discipline.Name = "tbName_Discipline";
            this.tbName_Discipline.Size = new System.Drawing.Size(226, 20);
            this.tbName_Discipline.TabIndex = 99;
            this.toolTip.SetToolTip(this.tbName_Discipline, "Название дисциплины");
            // 
            // tbID_Base
            // 
            this.tbID_Base.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Base.Location = new System.Drawing.Point(745, 70);
            this.tbID_Base.Name = "tbID_Base";
            this.tbID_Base.ReadOnly = true;
            this.tbID_Base.Size = new System.Drawing.Size(199, 20);
            this.tbID_Base.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbID_Base, "Идентификатор базы образования");
            // 
            // tbName_Base
            // 
            this.tbName_Base.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName_Base.Location = new System.Drawing.Point(745, 99);
            this.tbName_Base.Multiline = true;
            this.tbName_Base.Name = "tbName_Base";
            this.tbName_Base.Size = new System.Drawing.Size(199, 47);
            this.tbName_Base.TabIndex = 99;
            this.toolTip.SetToolTip(this.tbName_Base, "Название базы образования");
            // 
            // tbID_Lang
            // 
            this.tbID_Lang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Lang.Location = new System.Drawing.Point(730, 64);
            this.tbID_Lang.Name = "tbID_Lang";
            this.tbID_Lang.ReadOnly = true;
            this.tbID_Lang.Size = new System.Drawing.Size(217, 20);
            this.tbID_Lang.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbID_Lang, "Идентификатор иностранного языка");
            // 
            // tbName_Lang
            // 
            this.tbName_Lang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName_Lang.Location = new System.Drawing.Point(730, 90);
            this.tbName_Lang.Name = "tbName_Lang";
            this.tbName_Lang.Size = new System.Drawing.Size(217, 20);
            this.tbName_Lang.TabIndex = 99;
            this.toolTip.SetToolTip(this.tbName_Lang, "ФИО члена комиссии");
            // 
            // tbID_Komis
            // 
            this.tbID_Komis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Komis.Location = new System.Drawing.Point(658, 64);
            this.tbID_Komis.Name = "tbID_Komis";
            this.tbID_Komis.ReadOnly = true;
            this.tbID_Komis.Size = new System.Drawing.Size(286, 20);
            this.tbID_Komis.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbID_Komis, "Идентификатор члена комиссии");
            // 
            // tbName_Komis
            // 
            this.tbName_Komis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName_Komis.Location = new System.Drawing.Point(658, 90);
            this.tbName_Komis.Name = "tbName_Komis";
            this.tbName_Komis.Size = new System.Drawing.Size(286, 20);
            this.tbName_Komis.TabIndex = 99;
            this.toolTip.SetToolTip(this.tbName_Komis, "ФИО члена комиссии");
            // 
            // tbID_Polity
            // 
            this.tbID_Polity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Polity.Location = new System.Drawing.Point(724, 61);
            this.tbID_Polity.Name = "tbID_Polity";
            this.tbID_Polity.ReadOnly = true;
            this.tbID_Polity.Size = new System.Drawing.Size(220, 20);
            this.tbID_Polity.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbID_Polity, "Идентификатор государства");
            // 
            // tbName_Polity
            // 
            this.tbName_Polity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName_Polity.Location = new System.Drawing.Point(724, 87);
            this.tbName_Polity.Name = "tbName_Polity";
            this.tbName_Polity.Size = new System.Drawing.Size(220, 20);
            this.tbName_Polity.TabIndex = 99;
            this.toolTip.SetToolTip(this.tbName_Polity, "Название государства");
            // 
            // cbGroup_Decision
            // 
            this.cbGroup_Decision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroup_Decision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup_Decision.FormattingEnabled = true;
            this.cbGroup_Decision.Location = new System.Drawing.Point(722, 88);
            this.cbGroup_Decision.Name = "cbGroup_Decision";
            this.cbGroup_Decision.Size = new System.Drawing.Size(220, 21);
            this.cbGroup_Decision.TabIndex = 109;
            this.toolTip.SetToolTip(this.cbGroup_Decision, "Группа, в которую производится зачисление абитуриента");
            // 
            // tbID_Decision
            // 
            this.tbID_Decision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Decision.Location = new System.Drawing.Point(722, 62);
            this.tbID_Decision.Name = "tbID_Decision";
            this.tbID_Decision.ReadOnly = true;
            this.tbID_Decision.Size = new System.Drawing.Size(220, 20);
            this.tbID_Decision.TabIndex = 106;
            this.toolTip.SetToolTip(this.tbID_Decision, "Идентификатор решения комиссии");
            // 
            // dtpDate_Decision
            // 
            this.dtpDate_Decision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate_Decision.Location = new System.Drawing.Point(722, 210);
            this.dtpDate_Decision.Name = "dtpDate_Decision";
            this.dtpDate_Decision.Size = new System.Drawing.Size(220, 20);
            this.dtpDate_Decision.TabIndex = 105;
            this.toolTip.SetToolTip(this.dtpDate_Decision, "Дата принятия решения");
            this.dtpDate_Decision.Value = new System.DateTime(2017, 5, 27, 22, 41, 3, 0);
            // 
            // cbKomis_Decision
            // 
            this.cbKomis_Decision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKomis_Decision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKomis_Decision.FormattingEnabled = true;
            this.cbKomis_Decision.Location = new System.Drawing.Point(722, 236);
            this.cbKomis_Decision.Name = "cbKomis_Decision";
            this.cbKomis_Decision.Size = new System.Drawing.Size(220, 21);
            this.cbKomis_Decision.TabIndex = 103;
            this.toolTip.SetToolTip(this.cbKomis_Decision, "Член комиссии");
            // 
            // tbComment_Decision
            // 
            this.tbComment_Decision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment_Decision.Location = new System.Drawing.Point(722, 141);
            this.tbComment_Decision.Multiline = true;
            this.tbComment_Decision.Name = "tbComment_Decision";
            this.tbComment_Decision.Size = new System.Drawing.Size(220, 62);
            this.tbComment_Decision.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbComment_Decision, "Комментарий к решению комиссии");
            // 
            // tbResolution_Decision
            // 
            this.tbResolution_Decision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResolution_Decision.Location = new System.Drawing.Point(722, 115);
            this.tbResolution_Decision.Name = "tbResolution_Decision";
            this.tbResolution_Decision.Size = new System.Drawing.Size(220, 20);
            this.tbResolution_Decision.TabIndex = 99;
            this.toolTip.SetToolTip(this.tbResolution_Decision, "Решение комиссии");
            // 
            // tbID_Groups
            // 
            this.tbID_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID_Groups.Location = new System.Drawing.Point(730, 65);
            this.tbID_Groups.Name = "tbID_Groups";
            this.tbID_Groups.ReadOnly = true;
            this.tbID_Groups.Size = new System.Drawing.Size(216, 20);
            this.tbID_Groups.TabIndex = 107;
            this.toolTip.SetToolTip(this.tbID_Groups, "Идентификатор группы");
            // 
            // tbStudents_Groups
            // 
            this.tbStudents_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudents_Groups.Location = new System.Drawing.Point(730, 170);
            this.tbStudents_Groups.Name = "tbStudents_Groups";
            this.tbStudents_Groups.Size = new System.Drawing.Size(216, 20);
            this.tbStudents_Groups.TabIndex = 105;
            this.toolTip.SetToolTip(this.tbStudents_Groups, "Количество студентов в группе");
            // 
            // tbYear_Groups
            // 
            this.tbYear_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbYear_Groups.Location = new System.Drawing.Point(730, 144);
            this.tbYear_Groups.Name = "tbYear_Groups";
            this.tbYear_Groups.Size = new System.Drawing.Size(216, 20);
            this.tbYear_Groups.TabIndex = 103;
            this.toolTip.SetToolTip(this.tbYear_Groups, "Год формирования группы ( набор в группу осуществляется только на текущий год)");
            // 
            // tbName_Groups
            // 
            this.tbName_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName_Groups.Location = new System.Drawing.Point(730, 91);
            this.tbName_Groups.Name = "tbName_Groups";
            this.tbName_Groups.Size = new System.Drawing.Size(216, 20);
            this.tbName_Groups.TabIndex = 101;
            this.toolTip.SetToolTip(this.tbName_Groups, "Название формируемой группы");
            // 
            // cbSpec_Groups
            // 
            this.cbSpec_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpec_Groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpec_Groups.FormattingEnabled = true;
            this.cbSpec_Groups.Location = new System.Drawing.Point(730, 117);
            this.cbSpec_Groups.Name = "cbSpec_Groups";
            this.cbSpec_Groups.Size = new System.Drawing.Size(216, 21);
            this.cbSpec_Groups.TabIndex = 99;
            this.toolTip.SetToolTip(this.cbSpec_Groups, "Специальность, на которую производится зачисление");
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tpInfo);
            this.tcMain.Controls.Add(this.tpEnrollment);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 24);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(995, 482);
            this.tcMain.TabIndex = 4;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.tcMain_Table);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(987, 456);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Основная информация";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // tcMain_Table
            // 
            this.tcMain_Table.Controls.Add(this.tpAbit);
            this.tcMain_Table.Controls.Add(this.tpParents);
            this.tcMain_Table.Controls.Add(this.tpStatus);
            this.tcMain_Table.Controls.Add(this.tpMilitary);
            this.tcMain_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain_Table.Location = new System.Drawing.Point(0, 0);
            this.tcMain_Table.Name = "tcMain_Table";
            this.tcMain_Table.Padding = new System.Drawing.Point(0, 0);
            this.tcMain_Table.SelectedIndex = 0;
            this.tcMain_Table.Size = new System.Drawing.Size(987, 456);
            this.tcMain_Table.TabIndex = 11;
            // 
            // tpAbit
            // 
            this.tpAbit.Controls.Add(this.tcAbit);
            this.tpAbit.Location = new System.Drawing.Point(4, 22);
            this.tpAbit.Margin = new System.Windows.Forms.Padding(0);
            this.tpAbit.Name = "tpAbit";
            this.tpAbit.Size = new System.Drawing.Size(979, 430);
            this.tpAbit.TabIndex = 2;
            this.tpAbit.Text = "Абитуриент";
            this.tpAbit.UseVisualStyleBackColor = true;
            // 
            // tcAbit
            // 
            this.tcAbit.Controls.Add(this.tpTable_Abit);
            this.tcAbit.Controls.Add(this.tpStats_Abit);
            this.tcAbit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAbit.Location = new System.Drawing.Point(0, 0);
            this.tcAbit.Margin = new System.Windows.Forms.Padding(0);
            this.tcAbit.Name = "tcAbit";
            this.tcAbit.SelectedIndex = 0;
            this.tcAbit.Size = new System.Drawing.Size(979, 430);
            this.tcAbit.TabIndex = 10;
            // 
            // tpTable_Abit
            // 
            this.tpTable_Abit.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Abit.Controls.Add(this.dgvAbit);
            this.tpTable_Abit.Controls.Add(this.tsClients);
            this.tpTable_Abit.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Abit.Name = "tpTable_Abit";
            this.tpTable_Abit.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Abit.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Abit.TabIndex = 0;
            this.tpTable_Abit.Text = "Просмотр";
            // 
            // dgvAbit
            // 
            this.dgvAbit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAbit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAbit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbit.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvAbit.Location = new System.Drawing.Point(3, 28);
            this.dgvAbit.MultiSelect = false;
            this.dgvAbit.Name = "dgvAbit";
            this.dgvAbit.ReadOnly = true;
            this.dgvAbit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbit.Size = new System.Drawing.Size(965, 373);
            this.dgvAbit.TabIndex = 87;
            // 
            // tsClients
            // 
            this.tsClients.BackColor = System.Drawing.SystemColors.Control;
            this.tsClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAbit,
            this.tsbChangeAbit,
            this.tsbDeleteAbit,
            this.toolStripSeparator6,
            this.tssbShowColumns,
            this.toolStripSeparator103,
            this.tssbFilter_Abit,
            this.tsbResetFilterAbit,
            this.toolStripSeparator7,
            this.tssbSort_Abit,
            this.toolStripSeparator8,
            this.tsbRefresh_Abit});
            this.tsClients.Location = new System.Drawing.Point(3, 3);
            this.tsClients.Name = "tsClients";
            this.tsClients.Size = new System.Drawing.Size(965, 25);
            this.tsClients.TabIndex = 5;
            this.tsClients.Text = "toolStrip1";
            // 
            // tsbAddAbit
            // 
            this.tsbAddAbit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAbit.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddAbit.Image")));
            this.tsbAddAbit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAbit.Name = "tsbAddAbit";
            this.tsbAddAbit.Size = new System.Drawing.Size(23, 22);
            this.tsbAddAbit.Text = "tsbAddClient";
            this.tsbAddAbit.ToolTipText = "Добавить абитуриента";
            this.tsbAddAbit.Click += new System.EventHandler(this.tsbAdd_Abit_Click);
            // 
            // tsbChangeAbit
            // 
            this.tsbChangeAbit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChangeAbit.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeAbit.Image")));
            this.tsbChangeAbit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeAbit.Name = "tsbChangeAbit";
            this.tsbChangeAbit.Size = new System.Drawing.Size(23, 22);
            this.tsbChangeAbit.Text = "tsbChangeClient";
            this.tsbChangeAbit.ToolTipText = "Изменить абитуриента";
            this.tsbChangeAbit.Click += new System.EventHandler(this.tsbChange_Abit_Click);
            // 
            // tsbDeleteAbit
            // 
            this.tsbDeleteAbit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteAbit.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteAbit.Image")));
            this.tsbDeleteAbit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteAbit.Name = "tsbDeleteAbit";
            this.tsbDeleteAbit.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteAbit.Text = "tsbDeleteClient";
            this.tsbDeleteAbit.ToolTipText = "Удалить абитуриента";
            this.tsbDeleteAbit.Click += new System.EventHandler(this.tsbDelete_Abit_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbShowColumns
            // 
            this.tssbShowColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbShowColumns.DropDownButtonWidth = 20;
            this.tssbShowColumns.Image = ((System.Drawing.Image)(resources.GetObject("tssbShowColumns.Image")));
            this.tssbShowColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbShowColumns.Name = "tssbShowColumns";
            this.tssbShowColumns.Size = new System.Drawing.Size(41, 22);
            this.tssbShowColumns.ToolTipText = "Настроить отображение столбцов";
            // 
            // toolStripSeparator103
            // 
            this.toolStripSeparator103.Name = "toolStripSeparator103";
            this.toolStripSeparator103.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Abit
            // 
            this.tssbFilter_Abit.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Abit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Abit.DropDownButtonWidth = 20;
            this.tssbFilter_Abit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem23,
            this.tscbFilterField_Abit,
            this.toolStripSeparator43,
            this.toolStripMenuItem24,
            this.tscbFilterOper_Abit,
            this.toolStripSeparator44,
            this.toolStripMenuItem25,
            this.tstbFilterValue_Abit,
            this.toolStripSeparator45,
            this.tsmiFilterApply_Abit});
            this.tssbFilter_Abit.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Abit.Image")));
            this.tssbFilter_Abit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Abit.Name = "tssbFilter_Abit";
            this.tssbFilter_Abit.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Abit.Text = "toolStripSplitButton1";
            this.tssbFilter_Abit.ToolTipText = "Фильтр";
            this.tssbFilter_Abit.Click += new System.EventHandler(this.tssbFilter_Abit_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem23.Text = "Поле";
            // 
            // tscbFilterField_Abit
            // 
            this.tscbFilterField_Abit.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Abit.Name = "tscbFilterField_Abit";
            this.tscbFilterField_Abit.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator43
            // 
            this.toolStripSeparator43.Name = "toolStripSeparator43";
            this.toolStripSeparator43.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem24.Text = "Операция";
            // 
            // tscbFilterOper_Abit
            // 
            this.tscbFilterOper_Abit.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Abit.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Abit.Name = "tscbFilterOper_Abit";
            this.tscbFilterOper_Abit.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator44
            // 
            this.toolStripSeparator44.Name = "toolStripSeparator44";
            this.toolStripSeparator44.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem25.Text = "Искомое";
            // 
            // tstbFilterValue_Abit
            // 
            this.tstbFilterValue_Abit.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Abit.Name = "tstbFilterValue_Abit";
            this.tstbFilterValue_Abit.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator45
            // 
            this.toolStripSeparator45.Name = "toolStripSeparator45";
            this.toolStripSeparator45.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Abit
            // 
            this.tsmiFilterApply_Abit.Name = "tsmiFilterApply_Abit";
            this.tsmiFilterApply_Abit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Abit.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Abit.Text = "Применить фильтр";
            this.tsmiFilterApply_Abit.Click += new System.EventHandler(this.tsmiFilterApply_Abit_Click);
            // 
            // tsbResetFilterAbit
            // 
            this.tsbResetFilterAbit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilterAbit.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilterAbit.Image")));
            this.tsbResetFilterAbit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilterAbit.Name = "tsbResetFilterAbit";
            this.tsbResetFilterAbit.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilterAbit.Text = "toolStripButton1";
            this.tsbResetFilterAbit.ToolTipText = "Удалить фильтр";
            this.tsbResetFilterAbit.Click += new System.EventHandler(this.tsbResetFilterAbit_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Abit
            // 
            this.tssbSort_Abit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Abit.DropDownButtonWidth = 20;
            this.tssbSort_Abit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.tscbSortField_Abit,
            this.toolStripSeparator29,
            this.toolStripMenuItem10,
            this.tscbSortOrder_Abit,
            this.toolStripSeparator30,
            this.tsmiSortApply_Abit});
            this.tssbSort_Abit.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Abit.Image")));
            this.tssbSort_Abit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Abit.Name = "tssbSort_Abit";
            this.tssbSort_Abit.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Abit.Text = "Сортировка";
            this.tssbSort_Abit.Click += new System.EventHandler(this.tssbSort_Abit_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem9.Text = "Поле";
            // 
            // tscbSortField_Abit
            // 
            this.tscbSortField_Abit.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Abit.Name = "tscbSortField_Abit";
            this.tscbSortField_Abit.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator29
            // 
            this.toolStripSeparator29.Name = "toolStripSeparator29";
            this.toolStripSeparator29.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem10.Text = "Режим";
            // 
            // tscbSortOrder_Abit
            // 
            this.tscbSortOrder_Abit.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Abit.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Abit.Name = "tscbSortOrder_Abit";
            this.tscbSortOrder_Abit.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator30
            // 
            this.toolStripSeparator30.Name = "toolStripSeparator30";
            this.toolStripSeparator30.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Abit
            // 
            this.tsmiSortApply_Abit.Name = "tsmiSortApply_Abit";
            this.tsmiSortApply_Abit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Abit.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Abit.Text = "Применить";
            this.tsmiSortApply_Abit.Click += new System.EventHandler(this.tsmiSortApply_Abit_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Abit
            // 
            this.tsbRefresh_Abit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Abit.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Abit.Image")));
            this.tsbRefresh_Abit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Abit.Name = "tsbRefresh_Abit";
            this.tsbRefresh_Abit.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Abit.Text = "tsbRefresh";
            this.tsbRefresh_Abit.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Abit.Click += new System.EventHandler(this.tsbRefresh_Abit_Click);
            // 
            // tpStats_Abit
            // 
            this.tpStats_Abit.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Abit.Controls.Add(this.l_stats_Objective);
            this.tpStats_Abit.Controls.Add(this.l_stats_Orphan);
            this.tpStats_Abit.Controls.Add(this.l_stats_abitCount);
            this.tpStats_Abit.Controls.Add(this.l_stats_Invalid);
            this.tpStats_Abit.Controls.Add(this.l_stats_AbitCountCurr);
            this.tpStats_Abit.Controls.Add(this.l_stats_Contract);
            this.tpStats_Abit.Controls.Add(this.l_stats_NeedHostelCurr);
            this.tpStats_Abit.Controls.Add(this.l_stats_NeedHostel);
            this.tpStats_Abit.Controls.Add(this.l_stats_Male);
            this.tpStats_Abit.Controls.Add(this.l_stats_MidballCurr);
            this.tpStats_Abit.Controls.Add(this.l_stats_Female);
            this.tpStats_Abit.Controls.Add(this.l_stats_Midball);
            this.tpStats_Abit.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Abit.Name = "tpStats_Abit";
            this.tpStats_Abit.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Abit.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Abit.TabIndex = 1;
            this.tpStats_Abit.Text = "Статистика";
            // 
            // l_stats_Objective
            // 
            this.l_stats_Objective.AutoSize = true;
            this.l_stats_Objective.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_Objective.Location = new System.Drawing.Point(6, 267);
            this.l_stats_Objective.Name = "l_stats_Objective";
            this.l_stats_Objective.Size = new System.Drawing.Size(231, 24);
            this.l_stats_Objective.TabIndex = 11;
            this.l_stats_Objective.Text = "По целевому контракту: ";
            // 
            // l_stats_Orphan
            // 
            this.l_stats_Orphan.AutoSize = true;
            this.l_stats_Orphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_Orphan.Location = new System.Drawing.Point(3, 243);
            this.l_stats_Orphan.Name = "l_stats_Orphan";
            this.l_stats_Orphan.Size = new System.Drawing.Size(89, 24);
            this.l_stats_Orphan.TabIndex = 10;
            this.l_stats_Orphan.Text = "Сироты: ";
            // 
            // l_stats_abitCount
            // 
            this.l_stats_abitCount.AutoSize = true;
            this.l_stats_abitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_abitCount.Location = new System.Drawing.Point(3, 3);
            this.l_stats_abitCount.Name = "l_stats_abitCount";
            this.l_stats_abitCount.Size = new System.Drawing.Size(205, 24);
            this.l_stats_abitCount.TabIndex = 0;
            this.l_stats_abitCount.Text = "Всего абитуриентов: ";
            // 
            // l_stats_Invalid
            // 
            this.l_stats_Invalid.AutoSize = true;
            this.l_stats_Invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_Invalid.Location = new System.Drawing.Point(3, 219);
            this.l_stats_Invalid.Name = "l_stats_Invalid";
            this.l_stats_Invalid.Size = new System.Drawing.Size(111, 24);
            this.l_stats_Invalid.TabIndex = 7;
            this.l_stats_Invalid.Text = "Инвалиды: ";
            // 
            // l_stats_AbitCountCurr
            // 
            this.l_stats_AbitCountCurr.AutoSize = true;
            this.l_stats_AbitCountCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_AbitCountCurr.Location = new System.Drawing.Point(3, 27);
            this.l_stats_AbitCountCurr.Name = "l_stats_AbitCountCurr";
            this.l_stats_AbitCountCurr.Size = new System.Drawing.Size(240, 24);
            this.l_stats_AbitCountCurr.TabIndex = 1;
            this.l_stats_AbitCountCurr.Text = "В текущем текущем году: ";
            // 
            // l_stats_Contract
            // 
            this.l_stats_Contract.AutoSize = true;
            this.l_stats_Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_Contract.Location = new System.Drawing.Point(3, 195);
            this.l_stats_Contract.Name = "l_stats_Contract";
            this.l_stats_Contract.Size = new System.Drawing.Size(192, 24);
            this.l_stats_Contract.TabIndex = 6;
            this.l_stats_Contract.Text = "На платной основе: ";
            // 
            // l_stats_NeedHostelCurr
            // 
            this.l_stats_NeedHostelCurr.AutoSize = true;
            this.l_stats_NeedHostelCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_NeedHostelCurr.Location = new System.Drawing.Point(3, 171);
            this.l_stats_NeedHostelCurr.Name = "l_stats_NeedHostelCurr";
            this.l_stats_NeedHostelCurr.Size = new System.Drawing.Size(159, 24);
            this.l_stats_NeedHostelCurr.TabIndex = 9;
            this.l_stats_NeedHostelCurr.Text = "В текущем году: ";
            // 
            // l_stats_NeedHostel
            // 
            this.l_stats_NeedHostel.AutoSize = true;
            this.l_stats_NeedHostel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_NeedHostel.Location = new System.Drawing.Point(3, 147);
            this.l_stats_NeedHostel.Name = "l_stats_NeedHostel";
            this.l_stats_NeedHostel.Size = new System.Drawing.Size(246, 24);
            this.l_stats_NeedHostel.TabIndex = 5;
            this.l_stats_NeedHostel.Text = "Нуждаются в общежитии: ";
            // 
            // l_stats_Male
            // 
            this.l_stats_Male.AutoSize = true;
            this.l_stats_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_Male.Location = new System.Drawing.Point(3, 51);
            this.l_stats_Male.Name = "l_stats_Male";
            this.l_stats_Male.Size = new System.Drawing.Size(91, 24);
            this.l_stats_Male.TabIndex = 2;
            this.l_stats_Male.Text = "Мужчин: ";
            // 
            // l_stats_MidballCurr
            // 
            this.l_stats_MidballCurr.AutoSize = true;
            this.l_stats_MidballCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_MidballCurr.Location = new System.Drawing.Point(3, 123);
            this.l_stats_MidballCurr.Name = "l_stats_MidballCurr";
            this.l_stats_MidballCurr.Size = new System.Drawing.Size(159, 24);
            this.l_stats_MidballCurr.TabIndex = 8;
            this.l_stats_MidballCurr.Text = "В текущем году: ";
            // 
            // l_stats_Female
            // 
            this.l_stats_Female.AutoSize = true;
            this.l_stats_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_Female.Location = new System.Drawing.Point(3, 75);
            this.l_stats_Female.Name = "l_stats_Female";
            this.l_stats_Female.Size = new System.Drawing.Size(93, 24);
            this.l_stats_Female.TabIndex = 3;
            this.l_stats_Female.Text = "Женщин: ";
            // 
            // l_stats_Midball
            // 
            this.l_stats_Midball.AutoSize = true;
            this.l_stats_Midball.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_Midball.Location = new System.Drawing.Point(3, 99);
            this.l_stats_Midball.Name = "l_stats_Midball";
            this.l_stats_Midball.Size = new System.Drawing.Size(250, 24);
            this.l_stats_Midball.TabIndex = 4;
            this.l_stats_Midball.Text = "Средний проходной балл: ";
            // 
            // tpParents
            // 
            this.tpParents.Controls.Add(this.tabControl1);
            this.tpParents.Location = new System.Drawing.Point(4, 22);
            this.tpParents.Margin = new System.Windows.Forms.Padding(0);
            this.tpParents.Name = "tpParents";
            this.tpParents.Size = new System.Drawing.Size(979, 430);
            this.tpParents.TabIndex = 3;
            this.tpParents.Text = "Родители абитуриента";
            this.tpParents.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTable_Parent);
            this.tabControl1.Controls.Add(this.tpStats_Parent);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 430);
            this.tabControl1.TabIndex = 12;
            // 
            // tpTable_Parent
            // 
            this.tpTable_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Parent.Controls.Add(this.tbID_Parent);
            this.tpTable_Parent.Controls.Add(this.label3);
            this.tpTable_Parent.Controls.Add(this.tbPhone_Parent);
            this.tpTable_Parent.Controls.Add(this.label1);
            this.tpTable_Parent.Controls.Add(this.tbWorkpost_Parent);
            this.tpTable_Parent.Controls.Add(this.l_Workpost);
            this.tpTable_Parent.Controls.Add(this.tbAdrFact_Parent);
            this.tpTable_Parent.Controls.Add(this.l_AdrFact);
            this.tpTable_Parent.Controls.Add(this.tbAdrReg_Parent);
            this.tpTable_Parent.Controls.Add(this.l_adrreg);
            this.tpTable_Parent.Controls.Add(this.tbFIO_Parent);
            this.tpTable_Parent.Controls.Add(this.l_ParentFIO);
            this.tpTable_Parent.Controls.Add(this.cbAbit_Parent);
            this.tpTable_Parent.Controls.Add(this.l_Abit);
            this.tpTable_Parent.Controls.Add(this.dgvParent);
            this.tpTable_Parent.Controls.Add(this.btnUpdate_Parent);
            this.tpTable_Parent.Controls.Add(this.label2);
            this.tpTable_Parent.Controls.Add(this.splitter_Parent);
            this.tpTable_Parent.Controls.Add(this.tsParent);
            this.tpTable_Parent.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Parent.Name = "tpTable_Parent";
            this.tpTable_Parent.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Parent.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Parent.TabIndex = 0;
            this.tpTable_Parent.Text = "Просмотр";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Идентификатор";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Телефон";
            // 
            // l_Workpost
            // 
            this.l_Workpost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Workpost.AutoSize = true;
            this.l_Workpost.Location = new System.Drawing.Point(543, 199);
            this.l_Workpost.Name = "l_Workpost";
            this.l_Workpost.Size = new System.Drawing.Size(79, 13);
            this.l_Workpost.TabIndex = 106;
            this.l_Workpost.Text = "Место работы";
            // 
            // l_AdrFact
            // 
            this.l_AdrFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_AdrFact.AutoSize = true;
            this.l_AdrFact.Location = new System.Drawing.Point(543, 173);
            this.l_AdrFact.Name = "l_AdrFact";
            this.l_AdrFact.Size = new System.Drawing.Size(103, 13);
            this.l_AdrFact.TabIndex = 104;
            this.l_AdrFact.Text = "Адрес проживания";
            // 
            // l_adrreg
            // 
            this.l_adrreg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(543, 147);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(105, 13);
            this.l_adrreg.TabIndex = 102;
            this.l_adrreg.Text = "Адрес регистрации";
            // 
            // l_ParentFIO
            // 
            this.l_ParentFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_ParentFIO.AutoSize = true;
            this.l_ParentFIO.Location = new System.Drawing.Point(543, 121);
            this.l_ParentFIO.Name = "l_ParentFIO";
            this.l_ParentFIO.Size = new System.Drawing.Size(34, 13);
            this.l_ParentFIO.TabIndex = 100;
            this.l_ParentFIO.Text = "ФИО";
            // 
            // cbAbit_Parent
            // 
            this.cbAbit_Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbit_Parent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbit_Parent.FormattingEnabled = true;
            this.cbAbit_Parent.Location = new System.Drawing.Point(651, 91);
            this.cbAbit_Parent.Name = "cbAbit_Parent";
            this.cbAbit_Parent.Size = new System.Drawing.Size(294, 21);
            this.cbAbit_Parent.TabIndex = 99;
            // 
            // l_Abit
            // 
            this.l_Abit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Abit.AutoSize = true;
            this.l_Abit.Location = new System.Drawing.Point(543, 94);
            this.l_Abit.Name = "l_Abit";
            this.l_Abit.Size = new System.Drawing.Size(65, 13);
            this.l_Abit.TabIndex = 98;
            this.l_Abit.Text = "Абитуриент";
            // 
            // dgvParent
            // 
            this.dgvParent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvParent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParent.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvParent.Location = new System.Drawing.Point(3, 28);
            this.dgvParent.MultiSelect = false;
            this.dgvParent.Name = "dgvParent";
            this.dgvParent.ReadOnly = true;
            this.dgvParent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParent.Size = new System.Drawing.Size(534, 373);
            this.dgvParent.TabIndex = 97;
            this.dgvParent.SelectionChanged += new System.EventHandler(this.dgvParents_SelectionChanged);
            // 
            // btnUpdate_Parent
            // 
            this.btnUpdate_Parent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Parent.Location = new System.Drawing.Point(687, 257);
            this.btnUpdate_Parent.Name = "btnUpdate_Parent";
            this.btnUpdate_Parent.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Parent.TabIndex = 96;
            this.btnUpdate_Parent.Text = "Обновить";
            this.btnUpdate_Parent.UseVisualStyleBackColor = false;
            this.btnUpdate_Parent.Click += new System.EventHandler(this.btnUpdate_Parent_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Изменить данные";
            // 
            // splitter_Parent
            // 
            this.splitter_Parent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Parent.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Parent.Location = new System.Drawing.Point(537, 28);
            this.splitter_Parent.Name = "splitter_Parent";
            this.splitter_Parent.Size = new System.Drawing.Size(431, 373);
            this.splitter_Parent.TabIndex = 88;
            this.splitter_Parent.TabStop = false;
            // 
            // tsParent
            // 
            this.tsParent.BackColor = System.Drawing.SystemColors.Control;
            this.tsParent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Parent,
            this.tsbChange_Parent,
            this.tsbDelete_Parent,
            this.toolStripSeparator9,
            this.tssbFilter_Parent,
            this.tsbResetFilter_Parent,
            this.toolStripSeparator13,
            this.tssbSort_Parent,
            this.toolStripSeparator16,
            this.tsbRefresh_Parent,
            this.toolStripSeparator17,
            this.tsbExport_Parent,
            this.tsbExportAll_Parent});
            this.tsParent.Location = new System.Drawing.Point(3, 3);
            this.tsParent.Name = "tsParent";
            this.tsParent.Size = new System.Drawing.Size(965, 25);
            this.tsParent.TabIndex = 5;
            this.tsParent.Text = "toolStrip1";
            // 
            // tsbAdd_Parent
            // 
            this.tsbAdd_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Parent.Image")));
            this.tsbAdd_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Parent.Name = "tsbAdd_Parent";
            this.tsbAdd_Parent.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Parent.Text = "tsbAddClient";
            this.tsbAdd_Parent.ToolTipText = "Добавить родителя абитуриента";
            this.tsbAdd_Parent.Click += new System.EventHandler(this.tsbAdd_Parent_Click);
            // 
            // tsbChange_Parent
            // 
            this.tsbChange_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Parent.Image")));
            this.tsbChange_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Parent.Name = "tsbChange_Parent";
            this.tsbChange_Parent.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Parent.Text = "tsbChangeClient";
            this.tsbChange_Parent.ToolTipText = "Изменить родителя абитуриента";
            this.tsbChange_Parent.Click += new System.EventHandler(this.tsbChange_Parent_Click);
            // 
            // tsbDelete_Parent
            // 
            this.tsbDelete_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Parent.Image")));
            this.tsbDelete_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Parent.Name = "tsbDelete_Parent";
            this.tsbDelete_Parent.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Parent.Text = "tsbDeleteClient";
            this.tsbDelete_Parent.ToolTipText = "Удалить родителя абитуринта";
            this.tsbDelete_Parent.Click += new System.EventHandler(this.tsbDelete_Parent_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Parent
            // 
            this.tssbFilter_Parent.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Parent.DropDownButtonWidth = 20;
            this.tssbFilter_Parent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tscbFilterField_Parent,
            this.toolStripSeparator10,
            this.toolStripMenuItem2,
            this.tscbFilterOper_Parent,
            this.toolStripSeparator11,
            this.toolStripMenuItem3,
            this.tstbFilterValue_Parent,
            this.toolStripSeparator12,
            this.tsmiFilterApply_Parent});
            this.tssbFilter_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Parent.Image")));
            this.tssbFilter_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Parent.Name = "tssbFilter_Parent";
            this.tssbFilter_Parent.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Parent.Text = "toolStripSplitButton1";
            this.tssbFilter_Parent.ToolTipText = "Фильтр";
            this.tssbFilter_Parent.Click += new System.EventHandler(this.tssbFilter_Parent_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "Поле";
            // 
            // tscbFilterField_Parent
            // 
            this.tscbFilterField_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Parent.Name = "tscbFilterField_Parent";
            this.tscbFilterField_Parent.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem2.Text = "Операция";
            // 
            // tscbFilterOper_Parent
            // 
            this.tscbFilterOper_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Parent.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Parent.Name = "tscbFilterOper_Parent";
            this.tscbFilterOper_Parent.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem3.Text = "Искомое";
            // 
            // tstbFilterValue_Parent
            // 
            this.tstbFilterValue_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Parent.Name = "tstbFilterValue_Parent";
            this.tstbFilterValue_Parent.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Parent
            // 
            this.tsmiFilterApply_Parent.Name = "tsmiFilterApply_Parent";
            this.tsmiFilterApply_Parent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Parent.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Parent.Text = "Применить фильтр";
            this.tsmiFilterApply_Parent.Click += new System.EventHandler(this.tsmiFilterApply_Parent_Click);
            // 
            // tsbResetFilter_Parent
            // 
            this.tsbResetFilter_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Parent.Image")));
            this.tsbResetFilter_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Parent.Name = "tsbResetFilter_Parent";
            this.tsbResetFilter_Parent.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Parent.Text = "toolStripButton1";
            this.tsbResetFilter_Parent.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Parent.Click += new System.EventHandler(this.tsbResetFilter_Parent_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Parent
            // 
            this.tssbSort_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Parent.DropDownButtonWidth = 20;
            this.tssbSort_Parent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.tscbSortField_Parent,
            this.toolStripSeparator14,
            this.toolStripMenuItem6,
            this.tscbSortOrder_Parent,
            this.toolStripSeparator15,
            this.tsmiSortApply_Parent});
            this.tssbSort_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Parent.Image")));
            this.tssbSort_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Parent.Name = "tssbSort_Parent";
            this.tssbSort_Parent.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Parent.Text = "Сортировка";
            this.tssbSort_Parent.Click += new System.EventHandler(this.tssbSort_Parent_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem5.Text = "Поле";
            // 
            // tscbSortField_Parent
            // 
            this.tscbSortField_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Parent.Name = "tscbSortField_Parent";
            this.tscbSortField_Parent.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem6.Text = "Режим";
            // 
            // tscbSortOrder_Parent
            // 
            this.tscbSortOrder_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Parent.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Parent.Name = "tscbSortOrder_Parent";
            this.tscbSortOrder_Parent.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Parent
            // 
            this.tsmiSortApply_Parent.Name = "tsmiSortApply_Parent";
            this.tsmiSortApply_Parent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Parent.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Parent.Text = "Применить";
            this.tsmiSortApply_Parent.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmiSortApply_Parent.Click += new System.EventHandler(this.tsmiSortApply_Parent_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Parent
            // 
            this.tsbRefresh_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Parent.Image")));
            this.tsbRefresh_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Parent.Name = "tsbRefresh_Parent";
            this.tsbRefresh_Parent.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Parent.Text = "tsbRefresh";
            this.tsbRefresh_Parent.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Parent.Click += new System.EventHandler(this.tsbRefresh_Parent_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport_Parent
            // 
            this.tsbExport_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport_Parent.Image")));
            this.tsbExport_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport_Parent.Name = "tsbExport_Parent";
            this.tsbExport_Parent.Size = new System.Drawing.Size(23, 22);
            this.tsbExport_Parent.Text = "tsbExportClients";
            this.tsbExport_Parent.ToolTipText = "Создать отчет по выделенному родителю";
            this.tsbExport_Parent.Click += new System.EventHandler(this.tsbExport_Parent_Click);
            // 
            // tsbExportAll_Parent
            // 
            this.tsbExportAll_Parent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Parent.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Parent.Image")));
            this.tsbExportAll_Parent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Parent.Name = "tsbExportAll_Parent";
            this.tsbExportAll_Parent.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Parent.Text = "toolStripButton1";
            this.tsbExportAll_Parent.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Parent.Click += new System.EventHandler(this.tsbExportAll_Parent_Click);
            // 
            // tpStats_Parent
            // 
            this.tpStats_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Parent.Controls.Add(this.l_stats_ParentCount);
            this.tpStats_Parent.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Parent.Name = "tpStats_Parent";
            this.tpStats_Parent.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Parent.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Parent.TabIndex = 1;
            this.tpStats_Parent.Text = "Статистика";
            // 
            // l_stats_ParentCount
            // 
            this.l_stats_ParentCount.AutoSize = true;
            this.l_stats_ParentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_ParentCount.Location = new System.Drawing.Point(6, 3);
            this.l_stats_ParentCount.Name = "l_stats_ParentCount";
            this.l_stats_ParentCount.Size = new System.Drawing.Size(152, 24);
            this.l_stats_ParentCount.TabIndex = 4;
            this.l_stats_ParentCount.Text = "Всего записей: ";
            // 
            // tpStatus
            // 
            this.tpStatus.Controls.Add(this.tcStatus);
            this.tpStatus.Location = new System.Drawing.Point(4, 22);
            this.tpStatus.Margin = new System.Windows.Forms.Padding(0);
            this.tpStatus.Name = "tpStatus";
            this.tpStatus.Size = new System.Drawing.Size(979, 430);
            this.tpStatus.TabIndex = 4;
            this.tpStatus.Text = "Статус абитуриента";
            this.tpStatus.UseVisualStyleBackColor = true;
            // 
            // tcStatus
            // 
            this.tcStatus.Controls.Add(this.tpTable_Status);
            this.tcStatus.Controls.Add(this.tpStats_Status);
            this.tcStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStatus.Location = new System.Drawing.Point(0, 0);
            this.tcStatus.Margin = new System.Windows.Forms.Padding(0);
            this.tcStatus.Name = "tcStatus";
            this.tcStatus.SelectedIndex = 0;
            this.tcStatus.Size = new System.Drawing.Size(979, 430);
            this.tcStatus.TabIndex = 12;
            // 
            // tpTable_Status
            // 
            this.tpTable_Status.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Status.Controls.Add(this.tbID_Status);
            this.tpTable_Status.Controls.Add(this.label6);
            this.tpTable_Status.Controls.Add(this.l_Docinform);
            this.tpTable_Status.Controls.Add(this.tbDocinform_Status);
            this.tpTable_Status.Controls.Add(this.tbStatusType_Status);
            this.tpTable_Status.Controls.Add(this.l_StatusType);
            this.tpTable_Status.Controls.Add(this.cbAbit_Status);
            this.tpTable_Status.Controls.Add(this.label7);
            this.tpTable_Status.Controls.Add(this.dgvStatus);
            this.tpTable_Status.Controls.Add(this.btnUpdate_Status);
            this.tpTable_Status.Controls.Add(this.label4);
            this.tpTable_Status.Controls.Add(this.splitter_Status);
            this.tpTable_Status.Controls.Add(this.tsStatus);
            this.tpTable_Status.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Status.Name = "tpTable_Status";
            this.tpTable_Status.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Status.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Status.TabIndex = 0;
            this.tpTable_Status.Text = "Просмотр";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "Идентификатор";
            // 
            // l_Docinform
            // 
            this.l_Docinform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Docinform.AutoSize = true;
            this.l_Docinform.Location = new System.Drawing.Point(617, 148);
            this.l_Docinform.Name = "l_Docinform";
            this.l_Docinform.Size = new System.Drawing.Size(145, 13);
            this.l_Docinform.TabIndex = 103;
            this.l_Docinform.Text = "Информация из документа";
            // 
            // l_StatusType
            // 
            this.l_StatusType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_StatusType.AutoSize = true;
            this.l_StatusType.Location = new System.Drawing.Point(617, 119);
            this.l_StatusType.Name = "l_StatusType";
            this.l_StatusType.Size = new System.Drawing.Size(68, 13);
            this.l_StatusType.TabIndex = 100;
            this.l_StatusType.Text = "Тип статуса";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Абитуриент";
            // 
            // dgvStatus
            // 
            this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatus.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvStatus.Location = new System.Drawing.Point(3, 28);
            this.dgvStatus.MultiSelect = false;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatus.Size = new System.Drawing.Size(608, 373);
            this.dgvStatus.TabIndex = 97;
            this.dgvStatus.SelectionChanged += new System.EventHandler(this.dgvStatus_SelectionChanged);
            // 
            // btnUpdate_Status
            // 
            this.btnUpdate_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Status.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Status.Location = new System.Drawing.Point(724, 259);
            this.btnUpdate_Status.Name = "btnUpdate_Status";
            this.btnUpdate_Status.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Status.TabIndex = 96;
            this.btnUpdate_Status.Text = "Обновить";
            this.btnUpdate_Status.UseVisualStyleBackColor = false;
            this.btnUpdate_Status.Click += new System.EventHandler(this.btnUpdate_Status_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Изменить данные";
            // 
            // splitter_Status
            // 
            this.splitter_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Status.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Status.Location = new System.Drawing.Point(611, 28);
            this.splitter_Status.Name = "splitter_Status";
            this.splitter_Status.Size = new System.Drawing.Size(357, 373);
            this.splitter_Status.TabIndex = 88;
            this.splitter_Status.TabStop = false;
            // 
            // tsStatus
            // 
            this.tsStatus.BackColor = System.Drawing.SystemColors.Control;
            this.tsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Status,
            this.tsbChange_Status,
            this.tsbDelete_Status,
            this.toolStripSeparator18,
            this.tssbFilter_Status,
            this.tsbResetFilter_Status,
            this.toolStripSeparator23,
            this.tssbSort_Status,
            this.toolStripSeparator26,
            this.tsbRefresh_Status,
            this.toolStripSeparator27,
            this.tsbExport_Status,
            this.tsbExportAll_Status});
            this.tsStatus.Location = new System.Drawing.Point(3, 3);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(965, 25);
            this.tsStatus.TabIndex = 5;
            this.tsStatus.Text = "toolStrip1";
            // 
            // tsbAdd_Status
            // 
            this.tsbAdd_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Status.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Status.Image")));
            this.tsbAdd_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Status.Name = "tsbAdd_Status";
            this.tsbAdd_Status.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Status.Text = "tsbAddClient";
            this.tsbAdd_Status.ToolTipText = "Добавить статус абитуриента";
            this.tsbAdd_Status.Click += new System.EventHandler(this.tsbAdd_Status_Click);
            // 
            // tsbChange_Status
            // 
            this.tsbChange_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Status.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Status.Image")));
            this.tsbChange_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Status.Name = "tsbChange_Status";
            this.tsbChange_Status.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Status.Text = "tsbChangeClient";
            this.tsbChange_Status.ToolTipText = "Изменить статус абитуриента";
            this.tsbChange_Status.Click += new System.EventHandler(this.tsbChange_Status_Click);
            // 
            // tsbDelete_Status
            // 
            this.tsbDelete_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Status.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Status.Image")));
            this.tsbDelete_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Status.Name = "tsbDelete_Status";
            this.tsbDelete_Status.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Status.Text = "tsbDeleteClient";
            this.tsbDelete_Status.ToolTipText = "Удалить статус абитуриента";
            this.tsbDelete_Status.Click += new System.EventHandler(this.tsbDelete_Status_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Status
            // 
            this.tssbFilter_Status.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Status.DropDownButtonWidth = 20;
            this.tssbFilter_Status.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.tscbFilterField_Status,
            this.toolStripSeparator19,
            this.toolStripMenuItem8,
            this.tscbFilterOper_Status,
            this.toolStripSeparator20,
            this.toolStripMenuItem11,
            this.tstbFilterValue_Status,
            this.toolStripSeparator22,
            this.tsmiFilterApply_Status});
            this.tssbFilter_Status.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Status.Image")));
            this.tssbFilter_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Status.Name = "tssbFilter_Status";
            this.tssbFilter_Status.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Status.Text = "toolStripSplitButton1";
            this.tssbFilter_Status.ToolTipText = "Фильтр";
            this.tssbFilter_Status.Click += new System.EventHandler(this.tssbFilter_Status_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem7.Text = "Поле";
            // 
            // tscbFilterField_Status
            // 
            this.tscbFilterField_Status.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Status.Name = "tscbFilterField_Status";
            this.tscbFilterField_Status.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem8.Text = "Операция";
            // 
            // tscbFilterOper_Status
            // 
            this.tscbFilterOper_Status.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Status.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Status.Name = "tscbFilterOper_Status";
            this.tscbFilterOper_Status.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem11.Text = "Искомое";
            // 
            // tstbFilterValue_Status
            // 
            this.tstbFilterValue_Status.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Status.Name = "tstbFilterValue_Status";
            this.tstbFilterValue_Status.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Status
            // 
            this.tsmiFilterApply_Status.Name = "tsmiFilterApply_Status";
            this.tsmiFilterApply_Status.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Status.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Status.Text = "Применить фильтр";
            this.tsmiFilterApply_Status.Click += new System.EventHandler(this.tsmiFilterApply_Status_Click);
            // 
            // tsbResetFilter_Status
            // 
            this.tsbResetFilter_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Status.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Status.Image")));
            this.tsbResetFilter_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Status.Name = "tsbResetFilter_Status";
            this.tsbResetFilter_Status.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Status.Text = "toolStripButton1";
            this.tsbResetFilter_Status.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Status.Click += new System.EventHandler(this.tsbResetFilter_Status_Click);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Status
            // 
            this.tssbSort_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Status.DropDownButtonWidth = 20;
            this.tssbSort_Status.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.tscbSortField_Status,
            this.toolStripSeparator24,
            this.toolStripMenuItem14,
            this.tscbSortOrder_Status,
            this.toolStripSeparator25,
            this.tsmiSortApply_Status});
            this.tssbSort_Status.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Status.Image")));
            this.tssbSort_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Status.Name = "tssbSort_Status";
            this.tssbSort_Status.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Status.Text = "Сортировка";
            this.tssbSort_Status.Click += new System.EventHandler(this.tssbSort_Status_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem13.Text = "Поле";
            // 
            // tscbSortField_Status
            // 
            this.tscbSortField_Status.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Status.Name = "tscbSortField_Status";
            this.tscbSortField_Status.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem14.Text = "Режим";
            // 
            // tscbSortOrder_Status
            // 
            this.tscbSortOrder_Status.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Status.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Status.Name = "tscbSortOrder_Status";
            this.tscbSortOrder_Status.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Status
            // 
            this.tsmiSortApply_Status.Name = "tsmiSortApply_Status";
            this.tsmiSortApply_Status.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Status.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Status.Text = "Применить";
            this.tsmiSortApply_Status.Click += new System.EventHandler(this.tsmiSortApply_Status_Click);
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Status
            // 
            this.tsbRefresh_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Status.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Status.Image")));
            this.tsbRefresh_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Status.Name = "tsbRefresh_Status";
            this.tsbRefresh_Status.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Status.Text = "tsbRefresh";
            this.tsbRefresh_Status.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Status.Click += new System.EventHandler(this.tsbRefresh_Status_Click);
            // 
            // toolStripSeparator27
            // 
            this.toolStripSeparator27.Name = "toolStripSeparator27";
            this.toolStripSeparator27.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport_Status
            // 
            this.tsbExport_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport_Status.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport_Status.Image")));
            this.tsbExport_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport_Status.Name = "tsbExport_Status";
            this.tsbExport_Status.Size = new System.Drawing.Size(23, 22);
            this.tsbExport_Status.Text = "tsbExportClients";
            this.tsbExport_Status.ToolTipText = "Создать отчет по выделенному статусу";
            this.tsbExport_Status.Click += new System.EventHandler(this.tsbExport_Status_Click);
            // 
            // tsbExportAll_Status
            // 
            this.tsbExportAll_Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Status.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Status.Image")));
            this.tsbExportAll_Status.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Status.Name = "tsbExportAll_Status";
            this.tsbExportAll_Status.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Status.Text = "toolStripButton1";
            this.tsbExportAll_Status.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Status.Click += new System.EventHandler(this.tsbExportAll_Status_Click);
            // 
            // tpStats_Status
            // 
            this.tpStats_Status.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Status.Controls.Add(this.l_stats_StatusCount);
            this.tpStats_Status.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Status.Name = "tpStats_Status";
            this.tpStats_Status.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Status.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Status.TabIndex = 1;
            this.tpStats_Status.Text = "Статистика";
            // 
            // l_stats_StatusCount
            // 
            this.l_stats_StatusCount.AutoSize = true;
            this.l_stats_StatusCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_StatusCount.Location = new System.Drawing.Point(6, 3);
            this.l_stats_StatusCount.Name = "l_stats_StatusCount";
            this.l_stats_StatusCount.Size = new System.Drawing.Size(152, 24);
            this.l_stats_StatusCount.TabIndex = 3;
            this.l_stats_StatusCount.Text = "Всего записей: ";
            // 
            // tpMilitary
            // 
            this.tpMilitary.Controls.Add(this.tcMilitary);
            this.tpMilitary.Location = new System.Drawing.Point(4, 22);
            this.tpMilitary.Margin = new System.Windows.Forms.Padding(0);
            this.tpMilitary.Name = "tpMilitary";
            this.tpMilitary.Size = new System.Drawing.Size(979, 430);
            this.tpMilitary.TabIndex = 5;
            this.tpMilitary.Text = "Воинская обязанность";
            this.tpMilitary.UseVisualStyleBackColor = true;
            // 
            // tcMilitary
            // 
            this.tcMilitary.Controls.Add(this.tpTable_Military);
            this.tcMilitary.Controls.Add(this.tpStats_Military);
            this.tcMilitary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMilitary.Location = new System.Drawing.Point(0, 0);
            this.tcMilitary.Margin = new System.Windows.Forms.Padding(0);
            this.tcMilitary.Name = "tcMilitary";
            this.tcMilitary.SelectedIndex = 0;
            this.tcMilitary.Size = new System.Drawing.Size(979, 430);
            this.tcMilitary.TabIndex = 12;
            // 
            // tpTable_Military
            // 
            this.tpTable_Military.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Military.Controls.Add(this.tbID_Military);
            this.tpTable_Military.Controls.Add(this.label8);
            this.tpTable_Military.Controls.Add(this.label9);
            this.tpTable_Military.Controls.Add(this.tbDocinform_Military);
            this.tpTable_Military.Controls.Add(this.tbDocument_Military);
            this.tpTable_Military.Controls.Add(this.label10);
            this.tpTable_Military.Controls.Add(this.cbAbit_Military);
            this.tpTable_Military.Controls.Add(this.label11);
            this.tpTable_Military.Controls.Add(this.dgvMilitary);
            this.tpTable_Military.Controls.Add(this.btnUpdate_Military);
            this.tpTable_Military.Controls.Add(this.label5);
            this.tpTable_Military.Controls.Add(this.splitter_Military);
            this.tpTable_Military.Controls.Add(this.tsMilitary);
            this.tpTable_Military.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Military.Name = "tpTable_Military";
            this.tpTable_Military.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Military.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Military.TabIndex = 0;
            this.tpTable_Military.Text = "Просмотр";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "Идентификатор";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(611, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Информация из документа";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(611, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Документ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(611, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Абитуриент";
            // 
            // dgvMilitary
            // 
            this.dgvMilitary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMilitary.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMilitary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMilitary.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvMilitary.Location = new System.Drawing.Point(3, 28);
            this.dgvMilitary.MultiSelect = false;
            this.dgvMilitary.Name = "dgvMilitary";
            this.dgvMilitary.ReadOnly = true;
            this.dgvMilitary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMilitary.Size = new System.Drawing.Size(602, 373);
            this.dgvMilitary.TabIndex = 97;
            this.dgvMilitary.SelectionChanged += new System.EventHandler(this.dgvMilitary_SelectionChanged);
            // 
            // btnUpdate_Military
            // 
            this.btnUpdate_Military.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Military.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Military.Location = new System.Drawing.Point(721, 263);
            this.btnUpdate_Military.Name = "btnUpdate_Military";
            this.btnUpdate_Military.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Military.TabIndex = 96;
            this.btnUpdate_Military.Text = "Обновить";
            this.btnUpdate_Military.UseVisualStyleBackColor = false;
            this.btnUpdate_Military.Click += new System.EventHandler(this.btnUpdate_Military_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Изменить данные";
            // 
            // splitter_Military
            // 
            this.splitter_Military.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Military.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Military.Location = new System.Drawing.Point(605, 28);
            this.splitter_Military.Name = "splitter_Military";
            this.splitter_Military.Size = new System.Drawing.Size(363, 373);
            this.splitter_Military.TabIndex = 88;
            this.splitter_Military.TabStop = false;
            // 
            // tsMilitary
            // 
            this.tsMilitary.BackColor = System.Drawing.SystemColors.Control;
            this.tsMilitary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Military,
            this.tsbChange_Military,
            this.tsbDelete_Military,
            this.toolStripSeparator28,
            this.tssbFilter_Military,
            this.tsbResetFilter_Military,
            this.toolStripSeparator34,
            this.tssbSort_Military,
            this.toolStripSeparator37,
            this.tsbRefresh_Military,
            this.toolStripSeparator38,
            this.tsbExport_Military,
            this.tsbExportAll_Military});
            this.tsMilitary.Location = new System.Drawing.Point(3, 3);
            this.tsMilitary.Name = "tsMilitary";
            this.tsMilitary.Size = new System.Drawing.Size(965, 25);
            this.tsMilitary.TabIndex = 5;
            this.tsMilitary.Text = "toolStrip1";
            // 
            // tsbAdd_Military
            // 
            this.tsbAdd_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Military.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Military.Image")));
            this.tsbAdd_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Military.Name = "tsbAdd_Military";
            this.tsbAdd_Military.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Military.Text = "tsbAddClient";
            this.tsbAdd_Military.ToolTipText = "Добавить воинскую обязанность";
            this.tsbAdd_Military.Click += new System.EventHandler(this.tsbAdd_Military_Click);
            // 
            // tsbChange_Military
            // 
            this.tsbChange_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Military.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Military.Image")));
            this.tsbChange_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Military.Name = "tsbChange_Military";
            this.tsbChange_Military.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Military.Text = "tsbChangeClient";
            this.tsbChange_Military.ToolTipText = "Изменить воинскую обязанность";
            this.tsbChange_Military.Click += new System.EventHandler(this.tsbChange_Military_Click);
            // 
            // tsbDelete_Military
            // 
            this.tsbDelete_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Military.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Military.Image")));
            this.tsbDelete_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Military.Name = "tsbDelete_Military";
            this.tsbDelete_Military.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Military.Text = "tsbDeleteClient";
            this.tsbDelete_Military.ToolTipText = "Удалить воинскую обязанность";
            this.tsbDelete_Military.Click += new System.EventHandler(this.tsbDelete_Military_Click);
            // 
            // toolStripSeparator28
            // 
            this.toolStripSeparator28.Name = "toolStripSeparator28";
            this.toolStripSeparator28.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Military
            // 
            this.tssbFilter_Military.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Military.DropDownButtonWidth = 20;
            this.tssbFilter_Military.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.tscbFilterField_Military,
            this.toolStripSeparator31,
            this.toolStripMenuItem12,
            this.tscbFilterOper_Military,
            this.toolStripSeparator32,
            this.toolStripMenuItem15,
            this.tstbFilterValue_Military,
            this.toolStripSeparator33,
            this.tsmiFilterApply_Military});
            this.tssbFilter_Military.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Military.Image")));
            this.tssbFilter_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Military.Name = "tssbFilter_Military";
            this.tssbFilter_Military.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Military.Text = "toolStripSplitButton1";
            this.tssbFilter_Military.ToolTipText = "Фильтр";
            this.tssbFilter_Military.Click += new System.EventHandler(this.tssbFilter_Military_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem4.Text = "Поле";
            // 
            // tscbFilterField_Military
            // 
            this.tscbFilterField_Military.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Military.Name = "tscbFilterField_Military";
            this.tscbFilterField_Military.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator31
            // 
            this.toolStripSeparator31.Name = "toolStripSeparator31";
            this.toolStripSeparator31.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem12.Text = "Операция";
            // 
            // tscbFilterOper_Military
            // 
            this.tscbFilterOper_Military.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Military.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Military.Name = "tscbFilterOper_Military";
            this.tscbFilterOper_Military.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator32
            // 
            this.toolStripSeparator32.Name = "toolStripSeparator32";
            this.toolStripSeparator32.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem15.Text = "Искомое";
            // 
            // tstbFilterValue_Military
            // 
            this.tstbFilterValue_Military.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Military.Name = "tstbFilterValue_Military";
            this.tstbFilterValue_Military.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator33
            // 
            this.toolStripSeparator33.Name = "toolStripSeparator33";
            this.toolStripSeparator33.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Military
            // 
            this.tsmiFilterApply_Military.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Military.Name = "tsmiFilterApply_Military";
            this.tsmiFilterApply_Military.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Military.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Military.Text = "Применить фильтр";
            this.tsmiFilterApply_Military.Click += new System.EventHandler(this.tsmiFilterApply_Military_Click);
            // 
            // tsbResetFilter_Military
            // 
            this.tsbResetFilter_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Military.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Military.Image")));
            this.tsbResetFilter_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Military.Name = "tsbResetFilter_Military";
            this.tsbResetFilter_Military.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Military.Text = "toolStripButton1";
            this.tsbResetFilter_Military.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Military.Click += new System.EventHandler(this.tsbResetFilter_Military_Click);
            // 
            // toolStripSeparator34
            // 
            this.toolStripSeparator34.Name = "toolStripSeparator34";
            this.toolStripSeparator34.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Military
            // 
            this.tssbSort_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Military.DropDownButtonWidth = 20;
            this.tssbSort_Military.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16,
            this.tscbSortField_Military,
            this.toolStripSeparator35,
            this.toolStripMenuItem17,
            this.tscbSortOrder_Military,
            this.toolStripSeparator36,
            this.tsmiSortApply_Military});
            this.tssbSort_Military.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Military.Image")));
            this.tssbSort_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Military.Name = "tssbSort_Military";
            this.tssbSort_Military.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Military.Text = "Сортировка";
            this.tssbSort_Military.Click += new System.EventHandler(this.tssbSort_Military_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem16.Text = "Поле";
            // 
            // tscbSortField_Military
            // 
            this.tscbSortField_Military.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Military.Name = "tscbSortField_Military";
            this.tscbSortField_Military.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator35
            // 
            this.toolStripSeparator35.Name = "toolStripSeparator35";
            this.toolStripSeparator35.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem17.Text = "Режим";
            // 
            // tscbSortOrder_Military
            // 
            this.tscbSortOrder_Military.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Military.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Military.Name = "tscbSortOrder_Military";
            this.tscbSortOrder_Military.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator36
            // 
            this.toolStripSeparator36.Name = "toolStripSeparator36";
            this.toolStripSeparator36.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Military
            // 
            this.tsmiSortApply_Military.Name = "tsmiSortApply_Military";
            this.tsmiSortApply_Military.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Military.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Military.Text = "Применить";
            this.tsmiSortApply_Military.Click += new System.EventHandler(this.tsmiSortApply_Military_Click);
            // 
            // toolStripSeparator37
            // 
            this.toolStripSeparator37.Name = "toolStripSeparator37";
            this.toolStripSeparator37.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Military
            // 
            this.tsbRefresh_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Military.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Military.Image")));
            this.tsbRefresh_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Military.Name = "tsbRefresh_Military";
            this.tsbRefresh_Military.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Military.Text = "tsbRefresh";
            this.tsbRefresh_Military.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Military.Click += new System.EventHandler(this.tsbRefresh_Military_Click);
            // 
            // toolStripSeparator38
            // 
            this.toolStripSeparator38.Name = "toolStripSeparator38";
            this.toolStripSeparator38.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport_Military
            // 
            this.tsbExport_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport_Military.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport_Military.Image")));
            this.tsbExport_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport_Military.Name = "tsbExport_Military";
            this.tsbExport_Military.Size = new System.Drawing.Size(23, 22);
            this.tsbExport_Military.Text = "tsbExportClients";
            this.tsbExport_Military.ToolTipText = "Создать отчет по выделенной воинской обязанности";
            this.tsbExport_Military.Click += new System.EventHandler(this.tsbExport_Military_Click);
            // 
            // tsbExportAll_Military
            // 
            this.tsbExportAll_Military.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Military.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Military.Image")));
            this.tsbExportAll_Military.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Military.Name = "tsbExportAll_Military";
            this.tsbExportAll_Military.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Military.Text = "toolStripButton1";
            this.tsbExportAll_Military.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Military.Click += new System.EventHandler(this.tsbExportAll_Military_Click);
            // 
            // tpStats_Military
            // 
            this.tpStats_Military.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Military.Controls.Add(this.l_stats_Military);
            this.tpStats_Military.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Military.Name = "tpStats_Military";
            this.tpStats_Military.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Military.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Military.TabIndex = 1;
            this.tpStats_Military.Text = "Статистика";
            // 
            // l_stats_Military
            // 
            this.l_stats_Military.AutoSize = true;
            this.l_stats_Military.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_Military.Location = new System.Drawing.Point(6, 3);
            this.l_stats_Military.Name = "l_stats_Military";
            this.l_stats_Military.Size = new System.Drawing.Size(152, 24);
            this.l_stats_Military.TabIndex = 2;
            this.l_stats_Military.Text = "Всего записей: ";
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.tcInfo_Table);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Size = new System.Drawing.Size(987, 456);
            this.tpInfo.TabIndex = 1;
            this.tpInfo.Text = "Нормативно-справочная информация";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // tcInfo_Table
            // 
            this.tcInfo_Table.Controls.Add(this.tpSpec);
            this.tcInfo_Table.Controls.Add(this.tpDiscipline);
            this.tcInfo_Table.Controls.Add(this.tpBase);
            this.tcInfo_Table.Controls.Add(this.tpLang);
            this.tcInfo_Table.Controls.Add(this.tpKomis2);
            this.tcInfo_Table.Controls.Add(this.tpPolity);
            this.tcInfo_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInfo_Table.Location = new System.Drawing.Point(0, 0);
            this.tcInfo_Table.Name = "tcInfo_Table";
            this.tcInfo_Table.SelectedIndex = 0;
            this.tcInfo_Table.Size = new System.Drawing.Size(987, 456);
            this.tcInfo_Table.TabIndex = 19;
            // 
            // tpSpec
            // 
            this.tpSpec.Controls.Add(this.tcSpec);
            this.tpSpec.Location = new System.Drawing.Point(4, 22);
            this.tpSpec.Name = "tpSpec";
            this.tpSpec.Size = new System.Drawing.Size(979, 430);
            this.tpSpec.TabIndex = 0;
            this.tpSpec.Text = "Специальности";
            this.tpSpec.UseVisualStyleBackColor = true;
            // 
            // tcSpec
            // 
            this.tcSpec.Controls.Add(this.tpTable_Spec);
            this.tcSpec.Controls.Add(this.tpStats_Spec);
            this.tcSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSpec.Location = new System.Drawing.Point(0, 0);
            this.tcSpec.Margin = new System.Windows.Forms.Padding(0);
            this.tcSpec.Name = "tcSpec";
            this.tcSpec.SelectedIndex = 0;
            this.tcSpec.Size = new System.Drawing.Size(979, 430);
            this.tcSpec.TabIndex = 12;
            // 
            // tpTable_Spec
            // 
            this.tpTable_Spec.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Spec.Controls.Add(this.tbID_Spec);
            this.tpTable_Spec.Controls.Add(this.label13);
            this.tpTable_Spec.Controls.Add(this.tbTitle_Spec);
            this.tpTable_Spec.Controls.Add(this.label14);
            this.tpTable_Spec.Controls.Add(this.cbBudjet_Spec);
            this.tpTable_Spec.Controls.Add(this.cbOchn_Spec);
            this.tpTable_Spec.Controls.Add(this.cbDiscipline3_Spec);
            this.tpTable_Spec.Controls.Add(this.label16);
            this.tpTable_Spec.Controls.Add(this.cbDiscipline2_Spec);
            this.tpTable_Spec.Controls.Add(this.label17);
            this.tpTable_Spec.Controls.Add(this.cbDiscipline1_Spec);
            this.tpTable_Spec.Controls.Add(this.label18);
            this.tpTable_Spec.Controls.Add(this.label19);
            this.tpTable_Spec.Controls.Add(this.label20);
            this.tpTable_Spec.Controls.Add(this.tbShort_Spec);
            this.tpTable_Spec.Controls.Add(this.label21);
            this.tpTable_Spec.Controls.Add(this.tbSpecName_Spec);
            this.tpTable_Spec.Controls.Add(this.label22);
            this.tpTable_Spec.Controls.Add(this.tbShifr_Spec);
            this.tpTable_Spec.Controls.Add(this.label23);
            this.tpTable_Spec.Controls.Add(this.dgvSpec);
            this.tpTable_Spec.Controls.Add(this.btnUpdate_Spec);
            this.tpTable_Spec.Controls.Add(this.label12);
            this.tpTable_Spec.Controls.Add(this.splitter_Spec);
            this.tpTable_Spec.Controls.Add(this.tsSpec);
            this.tpTable_Spec.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Spec.Name = "tpTable_Spec";
            this.tpTable_Spec.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Spec.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Spec.TabIndex = 0;
            this.tpTable_Spec.Text = "Просмотр";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(501, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "Идентификатор";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(501, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 116;
            this.label14.Text = "Название";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(501, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 13);
            this.label16.TabIndex = 110;
            this.label16.Text = "Третья ведущая дисциплина";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(501, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 13);
            this.label17.TabIndex = 108;
            this.label17.Text = "Вторая ведущая дисциплина";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(501, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 13);
            this.label18.TabIndex = 106;
            this.label18.Text = "Первая ведущая дисциплина";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(501, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 105;
            this.label19.Text = "Основа обучения";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(501, 193);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 104;
            this.label20.Text = "Форма обучения";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(501, 167);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 102;
            this.label21.Text = "Аббревеатура";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(501, 114);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 13);
            this.label22.TabIndex = 100;
            this.label22.Text = "Квалификация";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(501, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 98;
            this.label23.Text = "Шифр";
            // 
            // dgvSpec
            // 
            this.dgvSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSpec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpec.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvSpec.Location = new System.Drawing.Point(3, 28);
            this.dgvSpec.MultiSelect = false;
            this.dgvSpec.Name = "dgvSpec";
            this.dgvSpec.ReadOnly = true;
            this.dgvSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpec.Size = new System.Drawing.Size(492, 373);
            this.dgvSpec.TabIndex = 97;
            this.dgvSpec.SelectionChanged += new System.EventHandler(this.dgvSpec_SelectionChanged);
            // 
            // btnUpdate_Spec
            // 
            this.btnUpdate_Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Spec.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Spec.Location = new System.Drawing.Point(671, 337);
            this.btnUpdate_Spec.Name = "btnUpdate_Spec";
            this.btnUpdate_Spec.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Spec.TabIndex = 96;
            this.btnUpdate_Spec.Text = "Обновить";
            this.btnUpdate_Spec.UseVisualStyleBackColor = false;
            this.btnUpdate_Spec.Click += new System.EventHandler(this.btnUpdate_Spec_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 95;
            this.label12.Text = "Изменить данные";
            // 
            // splitter_Spec
            // 
            this.splitter_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Spec.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Spec.Location = new System.Drawing.Point(495, 28);
            this.splitter_Spec.Name = "splitter_Spec";
            this.splitter_Spec.Size = new System.Drawing.Size(473, 373);
            this.splitter_Spec.TabIndex = 88;
            this.splitter_Spec.TabStop = false;
            // 
            // tsSpec
            // 
            this.tsSpec.BackColor = System.Drawing.SystemColors.Control;
            this.tsSpec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Spec,
            this.tsbChange_Spec,
            this.tsbDelete_Spec,
            this.toolStripSeparator39,
            this.tssbFilter_Spec,
            this.tsbResetFilter_Spec,
            this.toolStripSeparator46,
            this.tssbSort_Spec,
            this.toolStripSeparator49,
            this.tsbRefresh_Spec,
            this.toolStripSeparator50,
            this.tsbExport_Spec,
            this.tsbExportAll_Spec});
            this.tsSpec.Location = new System.Drawing.Point(3, 3);
            this.tsSpec.Name = "tsSpec";
            this.tsSpec.Size = new System.Drawing.Size(965, 25);
            this.tsSpec.TabIndex = 5;
            this.tsSpec.Text = "toolStrip1";
            // 
            // tsbAdd_Spec
            // 
            this.tsbAdd_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Spec.Image")));
            this.tsbAdd_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Spec.Name = "tsbAdd_Spec";
            this.tsbAdd_Spec.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Spec.Text = "tsbAddClient";
            this.tsbAdd_Spec.ToolTipText = "Добавить специальность";
            this.tsbAdd_Spec.Click += new System.EventHandler(this.tsbAdd_Spec_Click);
            // 
            // tsbChange_Spec
            // 
            this.tsbChange_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Spec.Image")));
            this.tsbChange_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Spec.Name = "tsbChange_Spec";
            this.tsbChange_Spec.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Spec.Text = "tsbChangeClient";
            this.tsbChange_Spec.ToolTipText = "Изменить специальность";
            this.tsbChange_Spec.Click += new System.EventHandler(this.tsbChange_Spec_Click);
            // 
            // tsbDelete_Spec
            // 
            this.tsbDelete_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Spec.Image")));
            this.tsbDelete_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Spec.Name = "tsbDelete_Spec";
            this.tsbDelete_Spec.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Spec.Text = "tsbDeleteClient";
            this.tsbDelete_Spec.ToolTipText = "Удалить специальность";
            this.tsbDelete_Spec.Click += new System.EventHandler(this.tsbDelete_Spec_Click);
            // 
            // toolStripSeparator39
            // 
            this.toolStripSeparator39.Name = "toolStripSeparator39";
            this.toolStripSeparator39.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Spec
            // 
            this.tssbFilter_Spec.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Spec.DropDownButtonWidth = 20;
            this.tssbFilter_Spec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem18,
            this.tscbFilterField_Spec,
            this.toolStripSeparator40,
            this.toolStripMenuItem19,
            this.tscbFilterOper_Spec,
            this.toolStripSeparator41,
            this.toolStripMenuItem20,
            this.tstbFilterValue_Spec,
            this.toolStripSeparator42,
            this.tsmiFilterApply_Spec});
            this.tssbFilter_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Spec.Image")));
            this.tssbFilter_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Spec.Name = "tssbFilter_Spec";
            this.tssbFilter_Spec.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Spec.Text = "toolStripSplitButton1";
            this.tssbFilter_Spec.ToolTipText = "Фильтр";
            this.tssbFilter_Spec.Click += new System.EventHandler(this.tssbFilter_Spec_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem18.Text = "Поле";
            // 
            // tscbFilterField_Spec
            // 
            this.tscbFilterField_Spec.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Spec.Name = "tscbFilterField_Spec";
            this.tscbFilterField_Spec.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator40
            // 
            this.toolStripSeparator40.Name = "toolStripSeparator40";
            this.toolStripSeparator40.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem19.Text = "Операция";
            // 
            // tscbFilterOper_Spec
            // 
            this.tscbFilterOper_Spec.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Spec.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Spec.Name = "tscbFilterOper_Spec";
            this.tscbFilterOper_Spec.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator41
            // 
            this.toolStripSeparator41.Name = "toolStripSeparator41";
            this.toolStripSeparator41.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem20.Text = "Искомое";
            // 
            // tstbFilterValue_Spec
            // 
            this.tstbFilterValue_Spec.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Spec.Name = "tstbFilterValue_Spec";
            this.tstbFilterValue_Spec.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator42
            // 
            this.toolStripSeparator42.Name = "toolStripSeparator42";
            this.toolStripSeparator42.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Spec
            // 
            this.tsmiFilterApply_Spec.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Spec.Name = "tsmiFilterApply_Spec";
            this.tsmiFilterApply_Spec.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Spec.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Spec.Text = "Применить фильтр";
            this.tsmiFilterApply_Spec.Click += new System.EventHandler(this.tsmiFilterApply_Spec_Click);
            // 
            // tsbResetFilter_Spec
            // 
            this.tsbResetFilter_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Spec.Image")));
            this.tsbResetFilter_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Spec.Name = "tsbResetFilter_Spec";
            this.tsbResetFilter_Spec.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Spec.Text = "toolStripButton1";
            this.tsbResetFilter_Spec.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Spec.Click += new System.EventHandler(this.tsbResetFilter_Spec_Click);
            // 
            // toolStripSeparator46
            // 
            this.toolStripSeparator46.Name = "toolStripSeparator46";
            this.toolStripSeparator46.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Spec
            // 
            this.tssbSort_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Spec.DropDownButtonWidth = 20;
            this.tssbSort_Spec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem21,
            this.tscbSortField_Spec,
            this.toolStripSeparator47,
            this.toolStripMenuItem22,
            this.tscbSortOrder_Spec,
            this.toolStripSeparator48,
            this.tsmiSortApply_Spec});
            this.tssbSort_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Spec.Image")));
            this.tssbSort_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Spec.Name = "tssbSort_Spec";
            this.tssbSort_Spec.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Spec.Text = "Сортировка";
            this.tssbSort_Spec.Click += new System.EventHandler(this.tssbSort_Spec_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem21.Text = "Поле";
            // 
            // tscbSortField_Spec
            // 
            this.tscbSortField_Spec.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Spec.Name = "tscbSortField_Spec";
            this.tscbSortField_Spec.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator47
            // 
            this.toolStripSeparator47.Name = "toolStripSeparator47";
            this.toolStripSeparator47.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem22.Text = "Режим";
            // 
            // tscbSortOrder_Spec
            // 
            this.tscbSortOrder_Spec.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Spec.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Spec.Name = "tscbSortOrder_Spec";
            this.tscbSortOrder_Spec.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator48
            // 
            this.toolStripSeparator48.Name = "toolStripSeparator48";
            this.toolStripSeparator48.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Spec
            // 
            this.tsmiSortApply_Spec.Name = "tsmiSortApply_Spec";
            this.tsmiSortApply_Spec.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Spec.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Spec.Text = "Применить";
            this.tsmiSortApply_Spec.Click += new System.EventHandler(this.tsmiSortApply_Spec_Click);
            // 
            // toolStripSeparator49
            // 
            this.toolStripSeparator49.Name = "toolStripSeparator49";
            this.toolStripSeparator49.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Spec
            // 
            this.tsbRefresh_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Spec.Image")));
            this.tsbRefresh_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Spec.Name = "tsbRefresh_Spec";
            this.tsbRefresh_Spec.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Spec.Text = "tsbRefresh";
            this.tsbRefresh_Spec.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Spec.Click += new System.EventHandler(this.tsbRefresh_Spec_Click);
            // 
            // toolStripSeparator50
            // 
            this.toolStripSeparator50.Name = "toolStripSeparator50";
            this.toolStripSeparator50.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport_Spec
            // 
            this.tsbExport_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport_Spec.Image")));
            this.tsbExport_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport_Spec.Name = "tsbExport_Spec";
            this.tsbExport_Spec.Size = new System.Drawing.Size(23, 22);
            this.tsbExport_Spec.Text = "tsbExportClients";
            this.tsbExport_Spec.ToolTipText = "Создать отчет по выделенной записи";
            this.tsbExport_Spec.Click += new System.EventHandler(this.tsbExport_Spec_Click);
            // 
            // tsbExportAll_Spec
            // 
            this.tsbExportAll_Spec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Spec.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Spec.Image")));
            this.tsbExportAll_Spec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Spec.Name = "tsbExportAll_Spec";
            this.tsbExportAll_Spec.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Spec.Text = "toolStripButton1";
            this.tsbExportAll_Spec.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Spec.Click += new System.EventHandler(this.tsbExportAll_Spec_Click);
            // 
            // tpStats_Spec
            // 
            this.tpStats_Spec.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Spec.Controls.Add(this.l_stats_SpecChargeable);
            this.tpStats_Spec.Controls.Add(this.l_stats_SpecBudjet);
            this.tpStats_Spec.Controls.Add(this.l_stats_SpecCount);
            this.tpStats_Spec.Controls.Add(this.l_stats_SpecZaochn);
            this.tpStats_Spec.Controls.Add(this.l_stats_SpecOchn);
            this.tpStats_Spec.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Spec.Name = "tpStats_Spec";
            this.tpStats_Spec.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Spec.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Spec.TabIndex = 1;
            this.tpStats_Spec.Text = "Статистика";
            // 
            // l_stats_SpecChargeable
            // 
            this.l_stats_SpecChargeable.AutoSize = true;
            this.l_stats_SpecChargeable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_SpecChargeable.Location = new System.Drawing.Point(3, 99);
            this.l_stats_SpecChargeable.Name = "l_stats_SpecChargeable";
            this.l_stats_SpecChargeable.Size = new System.Drawing.Size(192, 24);
            this.l_stats_SpecChargeable.TabIndex = 5;
            this.l_stats_SpecChargeable.Text = "На платной основе: ";
            // 
            // l_stats_SpecBudjet
            // 
            this.l_stats_SpecBudjet.AutoSize = true;
            this.l_stats_SpecBudjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_SpecBudjet.Location = new System.Drawing.Point(3, 75);
            this.l_stats_SpecBudjet.Name = "l_stats_SpecBudjet";
            this.l_stats_SpecBudjet.Size = new System.Drawing.Size(120, 24);
            this.l_stats_SpecBudjet.TabIndex = 4;
            this.l_stats_SpecBudjet.Text = "На бюджет: ";
            // 
            // l_stats_SpecCount
            // 
            this.l_stats_SpecCount.AutoSize = true;
            this.l_stats_SpecCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_SpecCount.Location = new System.Drawing.Point(3, 3);
            this.l_stats_SpecCount.Name = "l_stats_SpecCount";
            this.l_stats_SpecCount.Size = new System.Drawing.Size(227, 24);
            this.l_stats_SpecCount.TabIndex = 1;
            this.l_stats_SpecCount.Text = "Всего специальностей: ";
            // 
            // l_stats_SpecZaochn
            // 
            this.l_stats_SpecZaochn.AutoSize = true;
            this.l_stats_SpecZaochn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_SpecZaochn.Location = new System.Drawing.Point(3, 51);
            this.l_stats_SpecZaochn.Name = "l_stats_SpecZaochn";
            this.l_stats_SpecZaochn.Size = new System.Drawing.Size(99, 24);
            this.l_stats_SpecZaochn.TabIndex = 3;
            this.l_stats_SpecZaochn.Text = "Заочные: ";
            // 
            // l_stats_SpecOchn
            // 
            this.l_stats_SpecOchn.AutoSize = true;
            this.l_stats_SpecOchn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_SpecOchn.Location = new System.Drawing.Point(3, 27);
            this.l_stats_SpecOchn.Name = "l_stats_SpecOchn";
            this.l_stats_SpecOchn.Size = new System.Drawing.Size(80, 24);
            this.l_stats_SpecOchn.TabIndex = 2;
            this.l_stats_SpecOchn.Text = "Очные: ";
            // 
            // tpDiscipline
            // 
            this.tpDiscipline.Controls.Add(this.tcDiscipline);
            this.tpDiscipline.Location = new System.Drawing.Point(4, 22);
            this.tpDiscipline.Name = "tpDiscipline";
            this.tpDiscipline.Size = new System.Drawing.Size(979, 430);
            this.tpDiscipline.TabIndex = 1;
            this.tpDiscipline.Text = "Профильные дисциплины";
            this.tpDiscipline.UseVisualStyleBackColor = true;
            // 
            // tcDiscipline
            // 
            this.tcDiscipline.Controls.Add(this.tpTable_Discipline);
            this.tcDiscipline.Controls.Add(this.tpStats_Discipline);
            this.tcDiscipline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDiscipline.Location = new System.Drawing.Point(0, 0);
            this.tcDiscipline.Margin = new System.Windows.Forms.Padding(0);
            this.tcDiscipline.Name = "tcDiscipline";
            this.tcDiscipline.SelectedIndex = 0;
            this.tcDiscipline.Size = new System.Drawing.Size(979, 430);
            this.tcDiscipline.TabIndex = 12;
            // 
            // tpTable_Discipline
            // 
            this.tpTable_Discipline.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Discipline.Controls.Add(this.tbID_Discipline);
            this.tpTable_Discipline.Controls.Add(this.label30);
            this.tpTable_Discipline.Controls.Add(this.tbName_Discipline);
            this.tpTable_Discipline.Controls.Add(this.l_DisciplineName);
            this.tpTable_Discipline.Controls.Add(this.dgvDiscipline);
            this.tpTable_Discipline.Controls.Add(this.btnUpdate_Discipline);
            this.tpTable_Discipline.Controls.Add(this.label24);
            this.tpTable_Discipline.Controls.Add(this.splitter_Discipline);
            this.tpTable_Discipline.Controls.Add(this.tsDiscipline);
            this.tpTable_Discipline.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Discipline.Name = "tpTable_Discipline";
            this.tpTable_Discipline.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Discipline.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Discipline.TabIndex = 0;
            this.tpTable_Discipline.Text = "Просмотр";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(592, 72);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 13);
            this.label30.TabIndex = 100;
            this.label30.Text = "Идентификатор";
            // 
            // l_DisciplineName
            // 
            this.l_DisciplineName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_DisciplineName.AutoSize = true;
            this.l_DisciplineName.Location = new System.Drawing.Point(592, 98);
            this.l_DisciplineName.Name = "l_DisciplineName";
            this.l_DisciplineName.Size = new System.Drawing.Size(122, 13);
            this.l_DisciplineName.TabIndex = 98;
            this.l_DisciplineName.Text = "Название дисциплины";
            // 
            // dgvDiscipline
            // 
            this.dgvDiscipline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDiscipline.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDiscipline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiscipline.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvDiscipline.Location = new System.Drawing.Point(3, 28);
            this.dgvDiscipline.MultiSelect = false;
            this.dgvDiscipline.Name = "dgvDiscipline";
            this.dgvDiscipline.ReadOnly = true;
            this.dgvDiscipline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscipline.Size = new System.Drawing.Size(583, 373);
            this.dgvDiscipline.TabIndex = 97;
            this.dgvDiscipline.SelectionChanged += new System.EventHandler(this.dgvDiscipline_SelectionChanged);
            // 
            // btnUpdate_Discipline
            // 
            this.btnUpdate_Discipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Discipline.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Discipline.Location = new System.Drawing.Point(712, 130);
            this.btnUpdate_Discipline.Name = "btnUpdate_Discipline";
            this.btnUpdate_Discipline.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Discipline.TabIndex = 96;
            this.btnUpdate_Discipline.Text = "Обновить";
            this.btnUpdate_Discipline.UseVisualStyleBackColor = false;
            this.btnUpdate_Discipline.Click += new System.EventHandler(this.btnUpdate_Discipline_Click);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(728, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 13);
            this.label24.TabIndex = 95;
            this.label24.Text = "Изменить данные";
            // 
            // splitter_Discipline
            // 
            this.splitter_Discipline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Discipline.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Discipline.Location = new System.Drawing.Point(586, 28);
            this.splitter_Discipline.Name = "splitter_Discipline";
            this.splitter_Discipline.Size = new System.Drawing.Size(382, 373);
            this.splitter_Discipline.TabIndex = 88;
            this.splitter_Discipline.TabStop = false;
            // 
            // tsDiscipline
            // 
            this.tsDiscipline.BackColor = System.Drawing.SystemColors.Control;
            this.tsDiscipline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Discipline,
            this.tsbChange_Discipline,
            this.tsbDelete_Discipline,
            this.toolStripSeparator51,
            this.tssbFilter_Discipline,
            this.tsbResetFilter_Discipline,
            this.toolStripSeparator55,
            this.tssbSort_Discipline,
            this.toolStripSeparator58,
            this.tsbRefresh_Discipline,
            this.toolStripSeparator59,
            this.tsbExportAll_Discipline});
            this.tsDiscipline.Location = new System.Drawing.Point(3, 3);
            this.tsDiscipline.Name = "tsDiscipline";
            this.tsDiscipline.Size = new System.Drawing.Size(965, 25);
            this.tsDiscipline.TabIndex = 5;
            this.tsDiscipline.Text = "toolStrip1";
            // 
            // tsbAdd_Discipline
            // 
            this.tsbAdd_Discipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Discipline.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Discipline.Image")));
            this.tsbAdd_Discipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Discipline.Name = "tsbAdd_Discipline";
            this.tsbAdd_Discipline.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Discipline.Text = "tsbAddClient";
            this.tsbAdd_Discipline.ToolTipText = "Добавить дисциплину";
            this.tsbAdd_Discipline.Click += new System.EventHandler(this.tsbAdd_Discipline_Click);
            // 
            // tsbChange_Discipline
            // 
            this.tsbChange_Discipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Discipline.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Discipline.Image")));
            this.tsbChange_Discipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Discipline.Name = "tsbChange_Discipline";
            this.tsbChange_Discipline.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Discipline.Text = "tsbChangeClient";
            this.tsbChange_Discipline.ToolTipText = "Изменить дисциплину";
            this.tsbChange_Discipline.Click += new System.EventHandler(this.tsbChange_Discipline_Click);
            // 
            // tsbDelete_Discipline
            // 
            this.tsbDelete_Discipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Discipline.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Discipline.Image")));
            this.tsbDelete_Discipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Discipline.Name = "tsbDelete_Discipline";
            this.tsbDelete_Discipline.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Discipline.Text = "tsbDeleteClient";
            this.tsbDelete_Discipline.ToolTipText = "Удалить дисциплину";
            this.tsbDelete_Discipline.Click += new System.EventHandler(this.tsbDelete_Discipline_Click);
            // 
            // toolStripSeparator51
            // 
            this.toolStripSeparator51.Name = "toolStripSeparator51";
            this.toolStripSeparator51.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Discipline
            // 
            this.tssbFilter_Discipline.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Discipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Discipline.DropDownButtonWidth = 20;
            this.tssbFilter_Discipline.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem26,
            this.tscbFilterField_Discipline,
            this.toolStripSeparator52,
            this.toolStripMenuItem27,
            this.tscbFilterOper_Discipline,
            this.toolStripSeparator53,
            this.toolStripMenuItem28,
            this.tstbFilterValue_Discipline,
            this.toolStripSeparator54,
            this.tsmiFilterApply_Discipline});
            this.tssbFilter_Discipline.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Discipline.Image")));
            this.tssbFilter_Discipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Discipline.Name = "tssbFilter_Discipline";
            this.tssbFilter_Discipline.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Discipline.Text = "toolStripSplitButton1";
            this.tssbFilter_Discipline.ToolTipText = "Фильтр";
            this.tssbFilter_Discipline.Click += new System.EventHandler(this.tssbFilter_Discipline_Click);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem26.Text = "Поле";
            // 
            // tscbFilterField_Discipline
            // 
            this.tscbFilterField_Discipline.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Discipline.Name = "tscbFilterField_Discipline";
            this.tscbFilterField_Discipline.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator52
            // 
            this.toolStripSeparator52.Name = "toolStripSeparator52";
            this.toolStripSeparator52.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem27.Text = "Операция";
            // 
            // tscbFilterOper_Discipline
            // 
            this.tscbFilterOper_Discipline.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Discipline.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Discipline.Name = "tscbFilterOper_Discipline";
            this.tscbFilterOper_Discipline.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator53
            // 
            this.toolStripSeparator53.Name = "toolStripSeparator53";
            this.toolStripSeparator53.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem28.Text = "Искомое";
            // 
            // tstbFilterValue_Discipline
            // 
            this.tstbFilterValue_Discipline.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Discipline.Name = "tstbFilterValue_Discipline";
            this.tstbFilterValue_Discipline.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator54
            // 
            this.toolStripSeparator54.Name = "toolStripSeparator54";
            this.toolStripSeparator54.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Discipline
            // 
            this.tsmiFilterApply_Discipline.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Discipline.Name = "tsmiFilterApply_Discipline";
            this.tsmiFilterApply_Discipline.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Discipline.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Discipline.Text = "Применить фильтр";
            this.tsmiFilterApply_Discipline.Click += new System.EventHandler(this.tsmiFilterApply_Discipline_Click);
            // 
            // tsbResetFilter_Discipline
            // 
            this.tsbResetFilter_Discipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Discipline.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Discipline.Image")));
            this.tsbResetFilter_Discipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Discipline.Name = "tsbResetFilter_Discipline";
            this.tsbResetFilter_Discipline.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Discipline.Text = "toolStripButton1";
            this.tsbResetFilter_Discipline.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Discipline.Click += new System.EventHandler(this.tsbResetFilter_Discipline_Click);
            // 
            // toolStripSeparator55
            // 
            this.toolStripSeparator55.Name = "toolStripSeparator55";
            this.toolStripSeparator55.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Discipline
            // 
            this.tssbSort_Discipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Discipline.DropDownButtonWidth = 20;
            this.tssbSort_Discipline.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem29,
            this.tscbSortField_Discipline,
            this.toolStripSeparator56,
            this.toolStripMenuItem30,
            this.tscbSortOrder_Discipline,
            this.toolStripSeparator57,
            this.tsmiSortApply_Discipline});
            this.tssbSort_Discipline.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Discipline.Image")));
            this.tssbSort_Discipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Discipline.Name = "tssbSort_Discipline";
            this.tssbSort_Discipline.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Discipline.Text = "Сортировка";
            this.tssbSort_Discipline.Click += new System.EventHandler(this.tssbSort_Discipline_Click);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem29.Text = "Поле";
            // 
            // tscbSortField_Discipline
            // 
            this.tscbSortField_Discipline.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Discipline.Name = "tscbSortField_Discipline";
            this.tscbSortField_Discipline.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator56
            // 
            this.toolStripSeparator56.Name = "toolStripSeparator56";
            this.toolStripSeparator56.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem30.Text = "Режим";
            // 
            // tscbSortOrder_Discipline
            // 
            this.tscbSortOrder_Discipline.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Discipline.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Discipline.Name = "tscbSortOrder_Discipline";
            this.tscbSortOrder_Discipline.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator57
            // 
            this.toolStripSeparator57.Name = "toolStripSeparator57";
            this.toolStripSeparator57.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Discipline
            // 
            this.tsmiSortApply_Discipline.Name = "tsmiSortApply_Discipline";
            this.tsmiSortApply_Discipline.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Discipline.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Discipline.Text = "Применить";
            this.tsmiSortApply_Discipline.Click += new System.EventHandler(this.tsmiSortApply_Discipline_Click);
            // 
            // toolStripSeparator58
            // 
            this.toolStripSeparator58.Name = "toolStripSeparator58";
            this.toolStripSeparator58.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Discipline
            // 
            this.tsbRefresh_Discipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Discipline.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Discipline.Image")));
            this.tsbRefresh_Discipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Discipline.Name = "tsbRefresh_Discipline";
            this.tsbRefresh_Discipline.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Discipline.Text = "tsbRefresh";
            this.tsbRefresh_Discipline.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Discipline.Click += new System.EventHandler(this.tsbRefresh_Discipline_Click);
            // 
            // toolStripSeparator59
            // 
            this.toolStripSeparator59.Name = "toolStripSeparator59";
            this.toolStripSeparator59.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExportAll_Discipline
            // 
            this.tsbExportAll_Discipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Discipline.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Discipline.Image")));
            this.tsbExportAll_Discipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Discipline.Name = "tsbExportAll_Discipline";
            this.tsbExportAll_Discipline.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Discipline.Text = "toolStripButton1";
            this.tsbExportAll_Discipline.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Discipline.Click += new System.EventHandler(this.tsbExportAll_Discipline_Click);
            // 
            // tpStats_Discipline
            // 
            this.tpStats_Discipline.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Discipline.Controls.Add(this.l_stats_DisciplineCount);
            this.tpStats_Discipline.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Discipline.Name = "tpStats_Discipline";
            this.tpStats_Discipline.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Discipline.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Discipline.TabIndex = 1;
            this.tpStats_Discipline.Text = "Статистика";
            // 
            // l_stats_DisciplineCount
            // 
            this.l_stats_DisciplineCount.AutoSize = true;
            this.l_stats_DisciplineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_DisciplineCount.Location = new System.Drawing.Point(6, 3);
            this.l_stats_DisciplineCount.Name = "l_stats_DisciplineCount";
            this.l_stats_DisciplineCount.Size = new System.Drawing.Size(152, 24);
            this.l_stats_DisciplineCount.TabIndex = 1;
            this.l_stats_DisciplineCount.Text = "Всего записей: ";
            // 
            // tpBase
            // 
            this.tpBase.Controls.Add(this.tcBase);
            this.tpBase.Location = new System.Drawing.Point(4, 22);
            this.tpBase.Name = "tpBase";
            this.tpBase.Size = new System.Drawing.Size(979, 430);
            this.tpBase.TabIndex = 2;
            this.tpBase.Text = "Базы образования";
            this.tpBase.UseVisualStyleBackColor = true;
            // 
            // tcBase
            // 
            this.tcBase.Controls.Add(this.tpTable_Base);
            this.tcBase.Controls.Add(this.tpStats_Base);
            this.tcBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBase.Location = new System.Drawing.Point(0, 0);
            this.tcBase.Margin = new System.Windows.Forms.Padding(0);
            this.tcBase.Name = "tcBase";
            this.tcBase.SelectedIndex = 0;
            this.tcBase.Size = new System.Drawing.Size(979, 430);
            this.tcBase.TabIndex = 12;
            // 
            // tpTable_Base
            // 
            this.tpTable_Base.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Base.Controls.Add(this.tbID_Base);
            this.tpTable_Base.Controls.Add(this.label31);
            this.tpTable_Base.Controls.Add(this.tbName_Base);
            this.tpTable_Base.Controls.Add(this.label32);
            this.tpTable_Base.Controls.Add(this.dgvBase);
            this.tpTable_Base.Controls.Add(this.btnUpdate_Base);
            this.tpTable_Base.Controls.Add(this.label25);
            this.tpTable_Base.Controls.Add(this.splitter_Base);
            this.tpTable_Base.Controls.Add(this.tsBase);
            this.tpTable_Base.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Base.Name = "tpTable_Base";
            this.tpTable_Base.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Base.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Base.TabIndex = 0;
            this.tpTable_Base.Text = "Просмотр";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(580, 73);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 13);
            this.label31.TabIndex = 100;
            this.label31.Text = "Идентификатор";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(580, 99);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(155, 13);
            this.label32.TabIndex = 98;
            this.label32.Text = "Название базы образования";
            // 
            // dgvBase
            // 
            this.dgvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBase.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvBase.Location = new System.Drawing.Point(3, 28);
            this.dgvBase.MultiSelect = false;
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.ReadOnly = true;
            this.dgvBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBase.Size = new System.Drawing.Size(571, 373);
            this.dgvBase.TabIndex = 97;
            this.dgvBase.SelectionChanged += new System.EventHandler(this.dgvBase_SelectionChanged);
            // 
            // btnUpdate_Base
            // 
            this.btnUpdate_Base.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Base.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Base.Location = new System.Drawing.Point(706, 167);
            this.btnUpdate_Base.Name = "btnUpdate_Base";
            this.btnUpdate_Base.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Base.TabIndex = 96;
            this.btnUpdate_Base.Text = "Обновить";
            this.btnUpdate_Base.UseVisualStyleBackColor = false;
            this.btnUpdate_Base.Click += new System.EventHandler(this.btnUpdate_Base_Click);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(722, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 13);
            this.label25.TabIndex = 95;
            this.label25.Text = "Изменить данные";
            // 
            // splitter_Base
            // 
            this.splitter_Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Base.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Base.Location = new System.Drawing.Point(574, 28);
            this.splitter_Base.Name = "splitter_Base";
            this.splitter_Base.Size = new System.Drawing.Size(394, 373);
            this.splitter_Base.TabIndex = 88;
            this.splitter_Base.TabStop = false;
            // 
            // tsBase
            // 
            this.tsBase.BackColor = System.Drawing.SystemColors.Control;
            this.tsBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Base,
            this.tsbChange_Base,
            this.tsbDelete_Base,
            this.toolStripSeparator60,
            this.tssbFilter_Base,
            this.tsbResetFilter_Base,
            this.toolStripSeparator64,
            this.tssbSort_Base,
            this.toolStripSeparator67,
            this.tsbRefresh_Base,
            this.toolStripSeparator68,
            this.tsbExportAll_Base});
            this.tsBase.Location = new System.Drawing.Point(3, 3);
            this.tsBase.Name = "tsBase";
            this.tsBase.Size = new System.Drawing.Size(965, 25);
            this.tsBase.TabIndex = 5;
            this.tsBase.Text = "toolStrip1";
            // 
            // tsbAdd_Base
            // 
            this.tsbAdd_Base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Base.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Base.Image")));
            this.tsbAdd_Base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Base.Name = "tsbAdd_Base";
            this.tsbAdd_Base.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Base.Text = "tsbAddClient";
            this.tsbAdd_Base.ToolTipText = "Добавить базу образования";
            this.tsbAdd_Base.Click += new System.EventHandler(this.tsbAdd_Base_Click);
            // 
            // tsbChange_Base
            // 
            this.tsbChange_Base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Base.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Base.Image")));
            this.tsbChange_Base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Base.Name = "tsbChange_Base";
            this.tsbChange_Base.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Base.Text = "tsbChangeClient";
            this.tsbChange_Base.ToolTipText = "Изменить базу образования";
            this.tsbChange_Base.Click += new System.EventHandler(this.tsbChange_Base_Click);
            // 
            // tsbDelete_Base
            // 
            this.tsbDelete_Base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Base.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Base.Image")));
            this.tsbDelete_Base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Base.Name = "tsbDelete_Base";
            this.tsbDelete_Base.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Base.Text = "tsbDeleteClient";
            this.tsbDelete_Base.ToolTipText = "Удалить базу образования";
            this.tsbDelete_Base.Click += new System.EventHandler(this.tsbDelete_Base_Click);
            // 
            // toolStripSeparator60
            // 
            this.toolStripSeparator60.Name = "toolStripSeparator60";
            this.toolStripSeparator60.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Base
            // 
            this.tssbFilter_Base.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Base.DropDownButtonWidth = 20;
            this.tssbFilter_Base.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem31,
            this.tscbFilterField_Base,
            this.toolStripSeparator61,
            this.toolStripMenuItem32,
            this.tscbFilterOper_Base,
            this.toolStripSeparator62,
            this.toolStripMenuItem33,
            this.tstbFilterValue_Base,
            this.toolStripSeparator63,
            this.tsmiFilterApply_Base});
            this.tssbFilter_Base.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Base.Image")));
            this.tssbFilter_Base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Base.Name = "tssbFilter_Base";
            this.tssbFilter_Base.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Base.Text = "toolStripSplitButton1";
            this.tssbFilter_Base.ToolTipText = "Фильтр";
            this.tssbFilter_Base.Click += new System.EventHandler(this.tssbFilter_Base_Click);
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem31.Text = "Поле";
            // 
            // tscbFilterField_Base
            // 
            this.tscbFilterField_Base.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Base.Name = "tscbFilterField_Base";
            this.tscbFilterField_Base.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator61
            // 
            this.toolStripSeparator61.Name = "toolStripSeparator61";
            this.toolStripSeparator61.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem32.Text = "Операция";
            // 
            // tscbFilterOper_Base
            // 
            this.tscbFilterOper_Base.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Base.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Base.Name = "tscbFilterOper_Base";
            this.tscbFilterOper_Base.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator62
            // 
            this.toolStripSeparator62.Name = "toolStripSeparator62";
            this.toolStripSeparator62.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem33.Text = "Искомое";
            // 
            // tstbFilterValue_Base
            // 
            this.tstbFilterValue_Base.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Base.Name = "tstbFilterValue_Base";
            this.tstbFilterValue_Base.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator63
            // 
            this.toolStripSeparator63.Name = "toolStripSeparator63";
            this.toolStripSeparator63.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Base
            // 
            this.tsmiFilterApply_Base.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Base.Name = "tsmiFilterApply_Base";
            this.tsmiFilterApply_Base.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Base.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Base.Text = "Применить фильтр";
            this.tsmiFilterApply_Base.Click += new System.EventHandler(this.tsmiFilterApply_Base_Click);
            // 
            // tsbResetFilter_Base
            // 
            this.tsbResetFilter_Base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Base.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Base.Image")));
            this.tsbResetFilter_Base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Base.Name = "tsbResetFilter_Base";
            this.tsbResetFilter_Base.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Base.Text = "toolStripButton1";
            this.tsbResetFilter_Base.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Base.Click += new System.EventHandler(this.tsbResetFilter_Base_Click);
            // 
            // toolStripSeparator64
            // 
            this.toolStripSeparator64.Name = "toolStripSeparator64";
            this.toolStripSeparator64.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Base
            // 
            this.tssbSort_Base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Base.DropDownButtonWidth = 20;
            this.tssbSort_Base.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem34,
            this.tscbSortField_Base,
            this.toolStripSeparator65,
            this.toolStripMenuItem35,
            this.tscbSortOrder_Base,
            this.toolStripSeparator66,
            this.tsmiSortApply_Base});
            this.tssbSort_Base.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Base.Image")));
            this.tssbSort_Base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Base.Name = "tssbSort_Base";
            this.tssbSort_Base.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Base.Text = "Сортировка";
            this.tssbSort_Base.Click += new System.EventHandler(this.tssbSort_Base_Click);
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem34.Text = "Поле";
            // 
            // tscbSortField_Base
            // 
            this.tscbSortField_Base.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Base.Name = "tscbSortField_Base";
            this.tscbSortField_Base.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator65
            // 
            this.toolStripSeparator65.Name = "toolStripSeparator65";
            this.toolStripSeparator65.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem35.Text = "Режим";
            // 
            // tscbSortOrder_Base
            // 
            this.tscbSortOrder_Base.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Base.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Base.Name = "tscbSortOrder_Base";
            this.tscbSortOrder_Base.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator66
            // 
            this.toolStripSeparator66.Name = "toolStripSeparator66";
            this.toolStripSeparator66.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Base
            // 
            this.tsmiSortApply_Base.Name = "tsmiSortApply_Base";
            this.tsmiSortApply_Base.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Base.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Base.Text = "Применить";
            this.tsmiSortApply_Base.Click += new System.EventHandler(this.tsmiSortApply_Base_Click);
            // 
            // toolStripSeparator67
            // 
            this.toolStripSeparator67.Name = "toolStripSeparator67";
            this.toolStripSeparator67.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Base
            // 
            this.tsbRefresh_Base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Base.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Base.Image")));
            this.tsbRefresh_Base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Base.Name = "tsbRefresh_Base";
            this.tsbRefresh_Base.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Base.Text = "tsbRefresh";
            this.tsbRefresh_Base.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Base.Click += new System.EventHandler(this.tsbRefresh_Base_Click);
            // 
            // toolStripSeparator68
            // 
            this.toolStripSeparator68.Name = "toolStripSeparator68";
            this.toolStripSeparator68.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExportAll_Base
            // 
            this.tsbExportAll_Base.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Base.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Base.Image")));
            this.tsbExportAll_Base.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Base.Name = "tsbExportAll_Base";
            this.tsbExportAll_Base.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Base.Text = "toolStripButton1";
            this.tsbExportAll_Base.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Base.Click += new System.EventHandler(this.tsbExportAll_Base_Click);
            // 
            // tpStats_Base
            // 
            this.tpStats_Base.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Base.Controls.Add(this.l_stats_BaseCount);
            this.tpStats_Base.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Base.Name = "tpStats_Base";
            this.tpStats_Base.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Base.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Base.TabIndex = 1;
            this.tpStats_Base.Text = "Статистика";
            // 
            // l_stats_BaseCount
            // 
            this.l_stats_BaseCount.AutoSize = true;
            this.l_stats_BaseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_BaseCount.Location = new System.Drawing.Point(3, 3);
            this.l_stats_BaseCount.Name = "l_stats_BaseCount";
            this.l_stats_BaseCount.Size = new System.Drawing.Size(152, 24);
            this.l_stats_BaseCount.TabIndex = 1;
            this.l_stats_BaseCount.Text = "Всего записей: ";
            // 
            // tpLang
            // 
            this.tpLang.Controls.Add(this.tcLang);
            this.tpLang.Location = new System.Drawing.Point(4, 22);
            this.tpLang.Name = "tpLang";
            this.tpLang.Size = new System.Drawing.Size(979, 430);
            this.tpLang.TabIndex = 3;
            this.tpLang.Text = "Иностранные языки";
            this.tpLang.UseVisualStyleBackColor = true;
            // 
            // tcLang
            // 
            this.tcLang.Controls.Add(this.tpTable_Lang);
            this.tcLang.Controls.Add(this.tpStats_Lang);
            this.tcLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLang.Location = new System.Drawing.Point(0, 0);
            this.tcLang.Margin = new System.Windows.Forms.Padding(0);
            this.tcLang.Name = "tcLang";
            this.tcLang.SelectedIndex = 0;
            this.tcLang.Size = new System.Drawing.Size(979, 430);
            this.tcLang.TabIndex = 12;
            // 
            // tpTable_Lang
            // 
            this.tpTable_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Lang.Controls.Add(this.tbID_Lang);
            this.tpTable_Lang.Controls.Add(this.label33);
            this.tpTable_Lang.Controls.Add(this.tbName_Lang);
            this.tpTable_Lang.Controls.Add(this.label34);
            this.tpTable_Lang.Controls.Add(this.dgvLang);
            this.tpTable_Lang.Controls.Add(this.btnUpdate_Lang);
            this.tpTable_Lang.Controls.Add(this.label26);
            this.tpTable_Lang.Controls.Add(this.splitter_Lang);
            this.tpTable_Lang.Controls.Add(this.tsLang);
            this.tpTable_Lang.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Lang.Name = "tpTable_Lang";
            this.tpTable_Lang.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Lang.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Lang.TabIndex = 0;
            this.tpTable_Lang.Text = "Просмотр";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(563, 67);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 13);
            this.label33.TabIndex = 100;
            this.label33.Text = "Идентификатор";
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(563, 93);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(165, 13);
            this.label34.TabIndex = 98;
            this.label34.Text = "Название иностранного языка";
            // 
            // dgvLang
            // 
            this.dgvLang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLang.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvLang.Location = new System.Drawing.Point(3, 28);
            this.dgvLang.MultiSelect = false;
            this.dgvLang.Name = "dgvLang";
            this.dgvLang.ReadOnly = true;
            this.dgvLang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLang.Size = new System.Drawing.Size(554, 373);
            this.dgvLang.TabIndex = 97;
            this.dgvLang.SelectionChanged += new System.EventHandler(this.dgvLang_SelectionChanged);
            // 
            // btnUpdate_Lang
            // 
            this.btnUpdate_Lang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Lang.Location = new System.Drawing.Point(697, 131);
            this.btnUpdate_Lang.Name = "btnUpdate_Lang";
            this.btnUpdate_Lang.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Lang.TabIndex = 96;
            this.btnUpdate_Lang.Text = "Обновить";
            this.btnUpdate_Lang.UseVisualStyleBackColor = false;
            this.btnUpdate_Lang.Click += new System.EventHandler(this.btnUpdate_Lang_Click);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(713, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 13);
            this.label26.TabIndex = 95;
            this.label26.Text = "Изменить данные";
            // 
            // splitter_Lang
            // 
            this.splitter_Lang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Lang.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Lang.Location = new System.Drawing.Point(557, 28);
            this.splitter_Lang.Name = "splitter_Lang";
            this.splitter_Lang.Size = new System.Drawing.Size(411, 373);
            this.splitter_Lang.TabIndex = 88;
            this.splitter_Lang.TabStop = false;
            // 
            // tsLang
            // 
            this.tsLang.BackColor = System.Drawing.SystemColors.Control;
            this.tsLang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Lang,
            this.tsbChange_Lang,
            this.tsbDelete_Lang,
            this.toolStripSeparator69,
            this.tssbFilter_Lang,
            this.tsbResetFilter_Lang,
            this.toolStripSeparator73,
            this.tssbSort_Lang,
            this.toolStripSeparator76,
            this.tsbRefresh_Lang,
            this.toolStripSeparator77,
            this.tsbExportAll_Lang});
            this.tsLang.Location = new System.Drawing.Point(3, 3);
            this.tsLang.Name = "tsLang";
            this.tsLang.Size = new System.Drawing.Size(965, 25);
            this.tsLang.TabIndex = 5;
            this.tsLang.Text = "toolStrip1";
            // 
            // tsbAdd_Lang
            // 
            this.tsbAdd_Lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Lang.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Lang.Image")));
            this.tsbAdd_Lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Lang.Name = "tsbAdd_Lang";
            this.tsbAdd_Lang.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Lang.Text = "tsbAddClient";
            this.tsbAdd_Lang.ToolTipText = "Добавить иностранный язык";
            this.tsbAdd_Lang.Click += new System.EventHandler(this.tsbAdd_Lang_Click);
            // 
            // tsbChange_Lang
            // 
            this.tsbChange_Lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Lang.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Lang.Image")));
            this.tsbChange_Lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Lang.Name = "tsbChange_Lang";
            this.tsbChange_Lang.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Lang.Text = "tsbChangeClient";
            this.tsbChange_Lang.ToolTipText = "Изменить иностранный язык";
            this.tsbChange_Lang.Click += new System.EventHandler(this.tsbChange_Lang_Click);
            // 
            // tsbDelete_Lang
            // 
            this.tsbDelete_Lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Lang.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Lang.Image")));
            this.tsbDelete_Lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Lang.Name = "tsbDelete_Lang";
            this.tsbDelete_Lang.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Lang.Text = "tsbDeleteClient";
            this.tsbDelete_Lang.ToolTipText = "Удалить иностранный язык";
            this.tsbDelete_Lang.Click += new System.EventHandler(this.tsbDelete_Lang_Click);
            // 
            // toolStripSeparator69
            // 
            this.toolStripSeparator69.Name = "toolStripSeparator69";
            this.toolStripSeparator69.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Lang
            // 
            this.tssbFilter_Lang.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Lang.DropDownButtonWidth = 20;
            this.tssbFilter_Lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem36,
            this.tscbFilterField_Lang,
            this.toolStripSeparator70,
            this.toolStripMenuItem37,
            this.tscbFilterOper_Lang,
            this.toolStripSeparator71,
            this.toolStripMenuItem38,
            this.tstbFilterValue_Lang,
            this.toolStripSeparator72,
            this.tsmiFilterApply_Lang});
            this.tssbFilter_Lang.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Lang.Image")));
            this.tssbFilter_Lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Lang.Name = "tssbFilter_Lang";
            this.tssbFilter_Lang.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Lang.Text = "toolStripSplitButton1";
            this.tssbFilter_Lang.ToolTipText = "Фильтр";
            this.tssbFilter_Lang.Click += new System.EventHandler(this.tssbFilter_Lang_Click);
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem36.Text = "Поле";
            // 
            // tscbFilterField_Lang
            // 
            this.tscbFilterField_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Lang.Name = "tscbFilterField_Lang";
            this.tscbFilterField_Lang.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator70
            // 
            this.toolStripSeparator70.Name = "toolStripSeparator70";
            this.toolStripSeparator70.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem37
            // 
            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
            this.toolStripMenuItem37.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem37.Text = "Операция";
            // 
            // tscbFilterOper_Lang
            // 
            this.tscbFilterOper_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Lang.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Lang.Name = "tscbFilterOper_Lang";
            this.tscbFilterOper_Lang.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator71
            // 
            this.toolStripSeparator71.Name = "toolStripSeparator71";
            this.toolStripSeparator71.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem38
            // 
            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
            this.toolStripMenuItem38.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem38.Text = "Искомое";
            // 
            // tstbFilterValue_Lang
            // 
            this.tstbFilterValue_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Lang.Name = "tstbFilterValue_Lang";
            this.tstbFilterValue_Lang.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator72
            // 
            this.toolStripSeparator72.Name = "toolStripSeparator72";
            this.toolStripSeparator72.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Lang
            // 
            this.tsmiFilterApply_Lang.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Lang.Name = "tsmiFilterApply_Lang";
            this.tsmiFilterApply_Lang.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Lang.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Lang.Text = "Применить фильтр";
            this.tsmiFilterApply_Lang.Click += new System.EventHandler(this.tsmiFilterApply_Lang_Click);
            // 
            // tsbResetFilter_Lang
            // 
            this.tsbResetFilter_Lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Lang.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Lang.Image")));
            this.tsbResetFilter_Lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Lang.Name = "tsbResetFilter_Lang";
            this.tsbResetFilter_Lang.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Lang.Text = "toolStripButton1";
            this.tsbResetFilter_Lang.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Lang.Click += new System.EventHandler(this.tsbResetFilter_Lang_Click);
            // 
            // toolStripSeparator73
            // 
            this.toolStripSeparator73.Name = "toolStripSeparator73";
            this.toolStripSeparator73.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Lang
            // 
            this.tssbSort_Lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Lang.DropDownButtonWidth = 20;
            this.tssbSort_Lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem39,
            this.tscbSortField_Lang,
            this.toolStripSeparator74,
            this.toolStripMenuItem40,
            this.tscbSortOrder_Lang,
            this.toolStripSeparator75,
            this.tsmiSortApply_Lang});
            this.tssbSort_Lang.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Lang.Image")));
            this.tssbSort_Lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Lang.Name = "tssbSort_Lang";
            this.tssbSort_Lang.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Lang.Text = "Сортировка";
            this.tssbSort_Lang.Click += new System.EventHandler(this.tssbSort_Lang_Click);
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem39.Text = "Поле";
            // 
            // tscbSortField_Lang
            // 
            this.tscbSortField_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Lang.Name = "tscbSortField_Lang";
            this.tscbSortField_Lang.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator74
            // 
            this.toolStripSeparator74.Name = "toolStripSeparator74";
            this.toolStripSeparator74.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem40.Text = "Режим";
            // 
            // tscbSortOrder_Lang
            // 
            this.tscbSortOrder_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Lang.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Lang.Name = "tscbSortOrder_Lang";
            this.tscbSortOrder_Lang.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator75
            // 
            this.toolStripSeparator75.Name = "toolStripSeparator75";
            this.toolStripSeparator75.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Lang
            // 
            this.tsmiSortApply_Lang.Name = "tsmiSortApply_Lang";
            this.tsmiSortApply_Lang.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Lang.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Lang.Text = "Применить";
            this.tsmiSortApply_Lang.Click += new System.EventHandler(this.tsmiSortApply_Lang_Click);
            // 
            // toolStripSeparator76
            // 
            this.toolStripSeparator76.Name = "toolStripSeparator76";
            this.toolStripSeparator76.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Lang
            // 
            this.tsbRefresh_Lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Lang.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Lang.Image")));
            this.tsbRefresh_Lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Lang.Name = "tsbRefresh_Lang";
            this.tsbRefresh_Lang.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Lang.Text = "tsbRefresh";
            this.tsbRefresh_Lang.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Lang.Click += new System.EventHandler(this.tsbRefresh_Lang_Click);
            // 
            // toolStripSeparator77
            // 
            this.toolStripSeparator77.Name = "toolStripSeparator77";
            this.toolStripSeparator77.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExportAll_Lang
            // 
            this.tsbExportAll_Lang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Lang.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Lang.Image")));
            this.tsbExportAll_Lang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Lang.Name = "tsbExportAll_Lang";
            this.tsbExportAll_Lang.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Lang.Text = "toolStripButton1";
            this.tsbExportAll_Lang.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Lang.Click += new System.EventHandler(this.tsbExportAll_Lang_Click);
            // 
            // tpStats_Lang
            // 
            this.tpStats_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Lang.Controls.Add(this.l_stats_LangCount);
            this.tpStats_Lang.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Lang.Name = "tpStats_Lang";
            this.tpStats_Lang.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Lang.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Lang.TabIndex = 1;
            this.tpStats_Lang.Text = "Статистика";
            // 
            // l_stats_LangCount
            // 
            this.l_stats_LangCount.AutoSize = true;
            this.l_stats_LangCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_LangCount.Location = new System.Drawing.Point(6, 3);
            this.l_stats_LangCount.Name = "l_stats_LangCount";
            this.l_stats_LangCount.Size = new System.Drawing.Size(142, 24);
            this.l_stats_LangCount.TabIndex = 1;
            this.l_stats_LangCount.Text = "Всего языков: ";
            // 
            // tpKomis2
            // 
            this.tpKomis2.Controls.Add(this.tcKomis);
            this.tpKomis2.Location = new System.Drawing.Point(4, 22);
            this.tpKomis2.Name = "tpKomis2";
            this.tpKomis2.Size = new System.Drawing.Size(979, 430);
            this.tpKomis2.TabIndex = 4;
            this.tpKomis2.Text = "Комиссия";
            this.tpKomis2.UseVisualStyleBackColor = true;
            // 
            // tcKomis
            // 
            this.tcKomis.Controls.Add(this.tpTable_Komis);
            this.tcKomis.Controls.Add(this.tpStats_Komis);
            this.tcKomis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcKomis.Location = new System.Drawing.Point(0, 0);
            this.tcKomis.Margin = new System.Windows.Forms.Padding(0);
            this.tcKomis.Name = "tcKomis";
            this.tcKomis.SelectedIndex = 0;
            this.tcKomis.Size = new System.Drawing.Size(979, 430);
            this.tcKomis.TabIndex = 12;
            // 
            // tpTable_Komis
            // 
            this.tpTable_Komis.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Komis.Controls.Add(this.tbID_Komis);
            this.tpTable_Komis.Controls.Add(this.label35);
            this.tpTable_Komis.Controls.Add(this.tbName_Komis);
            this.tpTable_Komis.Controls.Add(this.label36);
            this.tpTable_Komis.Controls.Add(this.dgvKomis);
            this.tpTable_Komis.Controls.Add(this.btnUpdate_Komis);
            this.tpTable_Komis.Controls.Add(this.label27);
            this.tpTable_Komis.Controls.Add(this.splitter_Komis);
            this.tpTable_Komis.Controls.Add(this.tsKomis);
            this.tpTable_Komis.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Komis.Name = "tpTable_Komis";
            this.tpTable_Komis.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Komis.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Komis.TabIndex = 0;
            this.tpTable_Komis.Text = "Просмотр";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(564, 67);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(87, 13);
            this.label35.TabIndex = 100;
            this.label35.Text = "Идентификатор";
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(564, 93);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 13);
            this.label36.TabIndex = 98;
            this.label36.Text = "ФИО";
            // 
            // dgvKomis
            // 
            this.dgvKomis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKomis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKomis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKomis.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvKomis.Location = new System.Drawing.Point(3, 28);
            this.dgvKomis.MultiSelect = false;
            this.dgvKomis.Name = "dgvKomis";
            this.dgvKomis.ReadOnly = true;
            this.dgvKomis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomis.Size = new System.Drawing.Size(555, 373);
            this.dgvKomis.TabIndex = 97;
            this.dgvKomis.SelectionChanged += new System.EventHandler(this.dgvKomis_SelectionChanged);
            // 
            // btnUpdate_Komis
            // 
            this.btnUpdate_Komis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Komis.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Komis.Location = new System.Drawing.Point(698, 131);
            this.btnUpdate_Komis.Name = "btnUpdate_Komis";
            this.btnUpdate_Komis.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Komis.TabIndex = 96;
            this.btnUpdate_Komis.Text = "Обновить";
            this.btnUpdate_Komis.UseVisualStyleBackColor = false;
            this.btnUpdate_Komis.Click += new System.EventHandler(this.btnUpdate_Komis_Click);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(714, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 13);
            this.label27.TabIndex = 95;
            this.label27.Text = "Изменить данные";
            // 
            // splitter_Komis
            // 
            this.splitter_Komis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Komis.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Komis.Location = new System.Drawing.Point(558, 28);
            this.splitter_Komis.Name = "splitter_Komis";
            this.splitter_Komis.Size = new System.Drawing.Size(410, 373);
            this.splitter_Komis.TabIndex = 88;
            this.splitter_Komis.TabStop = false;
            // 
            // tsKomis
            // 
            this.tsKomis.BackColor = System.Drawing.SystemColors.Control;
            this.tsKomis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Komis,
            this.tsbChange_Komis,
            this.tsbDelete_Komis,
            this.toolStripSeparator78,
            this.tssbFilter_Komis,
            this.tsbResetFilter_Komis,
            this.toolStripSeparator82,
            this.tssbSort_Komis,
            this.toolStripSeparator85,
            this.tsbRefresh_Komis,
            this.toolStripSeparator86,
            this.tsbExportAll_Komis});
            this.tsKomis.Location = new System.Drawing.Point(3, 3);
            this.tsKomis.Name = "tsKomis";
            this.tsKomis.Size = new System.Drawing.Size(965, 25);
            this.tsKomis.TabIndex = 5;
            this.tsKomis.Text = "toolStrip1";
            // 
            // tsbAdd_Komis
            // 
            this.tsbAdd_Komis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Komis.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Komis.Image")));
            this.tsbAdd_Komis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Komis.Name = "tsbAdd_Komis";
            this.tsbAdd_Komis.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Komis.Text = "tsbAddClient";
            this.tsbAdd_Komis.ToolTipText = "Добавить члена комиссии";
            this.tsbAdd_Komis.Click += new System.EventHandler(this.tsbAdd_Komis_Click);
            // 
            // tsbChange_Komis
            // 
            this.tsbChange_Komis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Komis.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Komis.Image")));
            this.tsbChange_Komis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Komis.Name = "tsbChange_Komis";
            this.tsbChange_Komis.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Komis.Text = "tsbChangeClient";
            this.tsbChange_Komis.ToolTipText = "Изменить члена комиссии";
            this.tsbChange_Komis.Click += new System.EventHandler(this.tsbChange_Komis_Click);
            // 
            // tsbDelete_Komis
            // 
            this.tsbDelete_Komis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Komis.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Komis.Image")));
            this.tsbDelete_Komis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Komis.Name = "tsbDelete_Komis";
            this.tsbDelete_Komis.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Komis.Text = "tsbDeleteClient";
            this.tsbDelete_Komis.ToolTipText = "Удалить члена комиссии";
            this.tsbDelete_Komis.Click += new System.EventHandler(this.tsbDelete_Komis_Click);
            // 
            // toolStripSeparator78
            // 
            this.toolStripSeparator78.Name = "toolStripSeparator78";
            this.toolStripSeparator78.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Komis
            // 
            this.tssbFilter_Komis.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Komis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Komis.DropDownButtonWidth = 20;
            this.tssbFilter_Komis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem41,
            this.tscbFilterField_Komis,
            this.toolStripSeparator79,
            this.toolStripMenuItem42,
            this.tscbFilterOper_Komis,
            this.toolStripSeparator80,
            this.toolStripMenuItem43,
            this.tstbFilterValue_Komis,
            this.toolStripSeparator81,
            this.tsmiFilterApply_Komis});
            this.tssbFilter_Komis.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Komis.Image")));
            this.tssbFilter_Komis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Komis.Name = "tssbFilter_Komis";
            this.tssbFilter_Komis.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Komis.Text = "toolStripSplitButton1";
            this.tssbFilter_Komis.ToolTipText = "Фильтр";
            this.tssbFilter_Komis.Click += new System.EventHandler(this.tssbFilter_Komis_Click);
            // 
            // toolStripMenuItem41
            // 
            this.toolStripMenuItem41.Name = "toolStripMenuItem41";
            this.toolStripMenuItem41.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem41.Text = "Поле";
            // 
            // tscbFilterField_Komis
            // 
            this.tscbFilterField_Komis.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Komis.Name = "tscbFilterField_Komis";
            this.tscbFilterField_Komis.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator79
            // 
            this.toolStripSeparator79.Name = "toolStripSeparator79";
            this.toolStripSeparator79.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem42
            // 
            this.toolStripMenuItem42.Name = "toolStripMenuItem42";
            this.toolStripMenuItem42.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem42.Text = "Операция";
            // 
            // tscbFilterOper_Komis
            // 
            this.tscbFilterOper_Komis.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Komis.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Komis.Name = "tscbFilterOper_Komis";
            this.tscbFilterOper_Komis.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator80
            // 
            this.toolStripSeparator80.Name = "toolStripSeparator80";
            this.toolStripSeparator80.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem43
            // 
            this.toolStripMenuItem43.Name = "toolStripMenuItem43";
            this.toolStripMenuItem43.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem43.Text = "Искомое";
            // 
            // tstbFilterValue_Komis
            // 
            this.tstbFilterValue_Komis.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Komis.Name = "tstbFilterValue_Komis";
            this.tstbFilterValue_Komis.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator81
            // 
            this.toolStripSeparator81.Name = "toolStripSeparator81";
            this.toolStripSeparator81.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Komis
            // 
            this.tsmiFilterApply_Komis.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Komis.Name = "tsmiFilterApply_Komis";
            this.tsmiFilterApply_Komis.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Komis.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Komis.Text = "Применить фильтр";
            this.tsmiFilterApply_Komis.Click += new System.EventHandler(this.tsmiFilterApply_Komis_Click);
            // 
            // tsbResetFilter_Komis
            // 
            this.tsbResetFilter_Komis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Komis.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Komis.Image")));
            this.tsbResetFilter_Komis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Komis.Name = "tsbResetFilter_Komis";
            this.tsbResetFilter_Komis.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Komis.Text = "toolStripButton1";
            this.tsbResetFilter_Komis.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Komis.Click += new System.EventHandler(this.tsbResetFilter_Komis_Click);
            // 
            // toolStripSeparator82
            // 
            this.toolStripSeparator82.Name = "toolStripSeparator82";
            this.toolStripSeparator82.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Komis
            // 
            this.tssbSort_Komis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Komis.DropDownButtonWidth = 20;
            this.tssbSort_Komis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem44,
            this.tscbSortField_Komis,
            this.toolStripSeparator83,
            this.toolStripMenuItem45,
            this.tscbSortOrder_Komis,
            this.toolStripSeparator84,
            this.tsmiSortApply_Komis});
            this.tssbSort_Komis.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Komis.Image")));
            this.tssbSort_Komis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Komis.Name = "tssbSort_Komis";
            this.tssbSort_Komis.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Komis.Text = "Сортировка";
            this.tssbSort_Komis.Click += new System.EventHandler(this.tssbSort_Komis_Click);
            // 
            // toolStripMenuItem44
            // 
            this.toolStripMenuItem44.Name = "toolStripMenuItem44";
            this.toolStripMenuItem44.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem44.Text = "Поле";
            // 
            // tscbSortField_Komis
            // 
            this.tscbSortField_Komis.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Komis.Name = "tscbSortField_Komis";
            this.tscbSortField_Komis.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator83
            // 
            this.toolStripSeparator83.Name = "toolStripSeparator83";
            this.toolStripSeparator83.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem45
            // 
            this.toolStripMenuItem45.Name = "toolStripMenuItem45";
            this.toolStripMenuItem45.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem45.Text = "Режим";
            // 
            // tscbSortOrder_Komis
            // 
            this.tscbSortOrder_Komis.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Komis.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Komis.Name = "tscbSortOrder_Komis";
            this.tscbSortOrder_Komis.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator84
            // 
            this.toolStripSeparator84.Name = "toolStripSeparator84";
            this.toolStripSeparator84.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Komis
            // 
            this.tsmiSortApply_Komis.Name = "tsmiSortApply_Komis";
            this.tsmiSortApply_Komis.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Komis.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Komis.Text = "Применить";
            this.tsmiSortApply_Komis.Click += new System.EventHandler(this.tsmiSortApply_Komis_Click);
            // 
            // toolStripSeparator85
            // 
            this.toolStripSeparator85.Name = "toolStripSeparator85";
            this.toolStripSeparator85.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Komis
            // 
            this.tsbRefresh_Komis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Komis.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Komis.Image")));
            this.tsbRefresh_Komis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Komis.Name = "tsbRefresh_Komis";
            this.tsbRefresh_Komis.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Komis.Text = "tsbRefresh";
            this.tsbRefresh_Komis.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Komis.Click += new System.EventHandler(this.tsbRefresh_Komis_Click);
            // 
            // toolStripSeparator86
            // 
            this.toolStripSeparator86.Name = "toolStripSeparator86";
            this.toolStripSeparator86.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExportAll_Komis
            // 
            this.tsbExportAll_Komis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Komis.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Komis.Image")));
            this.tsbExportAll_Komis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Komis.Name = "tsbExportAll_Komis";
            this.tsbExportAll_Komis.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Komis.Text = "toolStripButton1";
            this.tsbExportAll_Komis.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Komis.Click += new System.EventHandler(this.tsbExportAll_Komis_Click);
            // 
            // tpStats_Komis
            // 
            this.tpStats_Komis.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Komis.Controls.Add(this.l_stats_KomisCount);
            this.tpStats_Komis.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Komis.Name = "tpStats_Komis";
            this.tpStats_Komis.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Komis.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Komis.TabIndex = 1;
            this.tpStats_Komis.Text = "Статистика";
            // 
            // l_stats_KomisCount
            // 
            this.l_stats_KomisCount.AutoSize = true;
            this.l_stats_KomisCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_KomisCount.Location = new System.Drawing.Point(6, 3);
            this.l_stats_KomisCount.Name = "l_stats_KomisCount";
            this.l_stats_KomisCount.Size = new System.Drawing.Size(152, 24);
            this.l_stats_KomisCount.TabIndex = 1;
            this.l_stats_KomisCount.Text = "Всего записей: ";
            // 
            // tpPolity
            // 
            this.tpPolity.Controls.Add(this.tcPolity);
            this.tpPolity.Location = new System.Drawing.Point(4, 22);
            this.tpPolity.Name = "tpPolity";
            this.tpPolity.Size = new System.Drawing.Size(979, 430);
            this.tpPolity.TabIndex = 5;
            this.tpPolity.Text = "Государства";
            this.tpPolity.UseVisualStyleBackColor = true;
            // 
            // tcPolity
            // 
            this.tcPolity.Controls.Add(this.tpTable_Polity);
            this.tcPolity.Controls.Add(this.tpStats_Polity);
            this.tcPolity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPolity.Location = new System.Drawing.Point(0, 0);
            this.tcPolity.Margin = new System.Windows.Forms.Padding(0);
            this.tcPolity.Name = "tcPolity";
            this.tcPolity.SelectedIndex = 0;
            this.tcPolity.Size = new System.Drawing.Size(979, 430);
            this.tcPolity.TabIndex = 12;
            // 
            // tpTable_Polity
            // 
            this.tpTable_Polity.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Polity.Controls.Add(this.tbID_Polity);
            this.tpTable_Polity.Controls.Add(this.label37);
            this.tpTable_Polity.Controls.Add(this.tbName_Polity);
            this.tpTable_Polity.Controls.Add(this.label38);
            this.tpTable_Polity.Controls.Add(this.dgvPolity);
            this.tpTable_Polity.Controls.Add(this.btnUpdate_Polity);
            this.tpTable_Polity.Controls.Add(this.label28);
            this.tpTable_Polity.Controls.Add(this.splitter_Polity);
            this.tpTable_Polity.Controls.Add(this.tsPolity);
            this.tpTable_Polity.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Polity.Name = "tpTable_Polity";
            this.tpTable_Polity.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Polity.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Polity.TabIndex = 0;
            this.tpTable_Polity.Text = "Просмотр";
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(597, 64);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(87, 13);
            this.label37.TabIndex = 100;
            this.label37.Text = "Идентификатор";
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(597, 90);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(123, 13);
            this.label38.TabIndex = 98;
            this.label38.Text = "Название государства";
            // 
            // dgvPolity
            // 
            this.dgvPolity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPolity.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPolity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPolity.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvPolity.Location = new System.Drawing.Point(3, 28);
            this.dgvPolity.MultiSelect = false;
            this.dgvPolity.Name = "dgvPolity";
            this.dgvPolity.ReadOnly = true;
            this.dgvPolity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolity.Size = new System.Drawing.Size(588, 373);
            this.dgvPolity.TabIndex = 97;
            this.dgvPolity.SelectionChanged += new System.EventHandler(this.dgvPolity_SelectionChanged);
            // 
            // btnUpdate_Polity
            // 
            this.btnUpdate_Polity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Polity.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Polity.Location = new System.Drawing.Point(714, 126);
            this.btnUpdate_Polity.Name = "btnUpdate_Polity";
            this.btnUpdate_Polity.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Polity.TabIndex = 96;
            this.btnUpdate_Polity.Text = "Обновить";
            this.btnUpdate_Polity.UseVisualStyleBackColor = false;
            this.btnUpdate_Polity.Click += new System.EventHandler(this.btnUpdate_Polity_Click);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(730, 37);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(99, 13);
            this.label28.TabIndex = 95;
            this.label28.Text = "Изменить данные";
            // 
            // splitter_Polity
            // 
            this.splitter_Polity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Polity.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Polity.Location = new System.Drawing.Point(591, 28);
            this.splitter_Polity.Name = "splitter_Polity";
            this.splitter_Polity.Size = new System.Drawing.Size(377, 373);
            this.splitter_Polity.TabIndex = 88;
            this.splitter_Polity.TabStop = false;
            // 
            // tsPolity
            // 
            this.tsPolity.BackColor = System.Drawing.SystemColors.Control;
            this.tsPolity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Polity,
            this.tsbChange_Polity,
            this.tsbDelete_Polity,
            this.toolStripSeparator1,
            this.tssbFilter_Polity,
            this.tsbResetFilter_Polity,
            this.toolStripSeparator88,
            this.tssbSort_Polity,
            this.toolStripSeparator91,
            this.tsbRefresh_Polity,
            this.toolStripSeparator92,
            this.tsbExportAll_Polity});
            this.tsPolity.Location = new System.Drawing.Point(3, 3);
            this.tsPolity.Name = "tsPolity";
            this.tsPolity.Size = new System.Drawing.Size(965, 25);
            this.tsPolity.TabIndex = 5;
            this.tsPolity.Text = "toolStrip1";
            // 
            // tsbAdd_Polity
            // 
            this.tsbAdd_Polity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Polity.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Polity.Image")));
            this.tsbAdd_Polity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Polity.Name = "tsbAdd_Polity";
            this.tsbAdd_Polity.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Polity.Text = "tsbAddClient";
            this.tsbAdd_Polity.ToolTipText = "Добавить государство";
            this.tsbAdd_Polity.Click += new System.EventHandler(this.tsbAdd_Polity_Click);
            // 
            // tsbChange_Polity
            // 
            this.tsbChange_Polity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Polity.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Polity.Image")));
            this.tsbChange_Polity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Polity.Name = "tsbChange_Polity";
            this.tsbChange_Polity.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Polity.Text = "tsbChangeClient";
            this.tsbChange_Polity.ToolTipText = "Изменить государство";
            this.tsbChange_Polity.Click += new System.EventHandler(this.tsbChange_Polity_Click);
            // 
            // tsbDelete_Polity
            // 
            this.tsbDelete_Polity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Polity.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Polity.Image")));
            this.tsbDelete_Polity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Polity.Name = "tsbDelete_Polity";
            this.tsbDelete_Polity.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Polity.Text = "tsbDeleteClient";
            this.tsbDelete_Polity.ToolTipText = "Удалить государство";
            this.tsbDelete_Polity.Click += new System.EventHandler(this.tsbDelete_Polity_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Polity
            // 
            this.tssbFilter_Polity.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Polity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Polity.DropDownButtonWidth = 20;
            this.tssbFilter_Polity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem46,
            this.tscbFilterField_Polity,
            this.toolStripSeparator2,
            this.toolStripMenuItem47,
            this.tscbFilterOper_Polity,
            this.toolStripSeparator4,
            this.toolStripMenuItem48,
            this.tstbFilterValue_Polity,
            this.toolStripSeparator87,
            this.tsmiFilterApply_Polity});
            this.tssbFilter_Polity.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Polity.Image")));
            this.tssbFilter_Polity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Polity.Name = "tssbFilter_Polity";
            this.tssbFilter_Polity.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Polity.Text = "toolStripSplitButton1";
            this.tssbFilter_Polity.ToolTipText = "Фильтр";
            this.tssbFilter_Polity.Click += new System.EventHandler(this.tssbFilter_Polity_Click);
            // 
            // toolStripMenuItem46
            // 
            this.toolStripMenuItem46.Name = "toolStripMenuItem46";
            this.toolStripMenuItem46.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem46.Text = "Поле";
            // 
            // tscbFilterField_Polity
            // 
            this.tscbFilterField_Polity.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Polity.Name = "tscbFilterField_Polity";
            this.tscbFilterField_Polity.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem47
            // 
            this.toolStripMenuItem47.Name = "toolStripMenuItem47";
            this.toolStripMenuItem47.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem47.Text = "Операция";
            // 
            // tscbFilterOper_Polity
            // 
            this.tscbFilterOper_Polity.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Polity.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Polity.Name = "tscbFilterOper_Polity";
            this.tscbFilterOper_Polity.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem48
            // 
            this.toolStripMenuItem48.Name = "toolStripMenuItem48";
            this.toolStripMenuItem48.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem48.Text = "Искомое";
            // 
            // tstbFilterValue_Polity
            // 
            this.tstbFilterValue_Polity.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Polity.Name = "tstbFilterValue_Polity";
            this.tstbFilterValue_Polity.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator87
            // 
            this.toolStripSeparator87.Name = "toolStripSeparator87";
            this.toolStripSeparator87.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Polity
            // 
            this.tsmiFilterApply_Polity.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Polity.Name = "tsmiFilterApply_Polity";
            this.tsmiFilterApply_Polity.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Polity.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Polity.Text = "Применить фильтр";
            this.tsmiFilterApply_Polity.Click += new System.EventHandler(this.tsmiFilterApply_Polity_Click);
            // 
            // tsbResetFilter_Polity
            // 
            this.tsbResetFilter_Polity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Polity.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Polity.Image")));
            this.tsbResetFilter_Polity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Polity.Name = "tsbResetFilter_Polity";
            this.tsbResetFilter_Polity.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Polity.Text = "toolStripButton1";
            this.tsbResetFilter_Polity.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Polity.Click += new System.EventHandler(this.tsbResetFilter_Polity_Click);
            // 
            // toolStripSeparator88
            // 
            this.toolStripSeparator88.Name = "toolStripSeparator88";
            this.toolStripSeparator88.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Polity
            // 
            this.tssbSort_Polity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Polity.DropDownButtonWidth = 20;
            this.tssbSort_Polity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem49,
            this.tscbSortField_Polity,
            this.toolStripSeparator89,
            this.toolStripMenuItem50,
            this.tscbSortOrder_Polity,
            this.toolStripSeparator90,
            this.tsmiSortApply_Polity});
            this.tssbSort_Polity.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Polity.Image")));
            this.tssbSort_Polity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Polity.Name = "tssbSort_Polity";
            this.tssbSort_Polity.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Polity.Text = "Сортировка";
            this.tssbSort_Polity.Click += new System.EventHandler(this.tssbSort_Polity_Click);
            // 
            // toolStripMenuItem49
            // 
            this.toolStripMenuItem49.Name = "toolStripMenuItem49";
            this.toolStripMenuItem49.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem49.Text = "Поле";
            // 
            // tscbSortField_Polity
            // 
            this.tscbSortField_Polity.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Polity.Name = "tscbSortField_Polity";
            this.tscbSortField_Polity.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator89
            // 
            this.toolStripSeparator89.Name = "toolStripSeparator89";
            this.toolStripSeparator89.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem50
            // 
            this.toolStripMenuItem50.Name = "toolStripMenuItem50";
            this.toolStripMenuItem50.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem50.Text = "Режим";
            // 
            // tscbSortOrder_Polity
            // 
            this.tscbSortOrder_Polity.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Polity.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Polity.Name = "tscbSortOrder_Polity";
            this.tscbSortOrder_Polity.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator90
            // 
            this.toolStripSeparator90.Name = "toolStripSeparator90";
            this.toolStripSeparator90.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Polity
            // 
            this.tsmiSortApply_Polity.Name = "tsmiSortApply_Polity";
            this.tsmiSortApply_Polity.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Polity.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Polity.Text = "Применить";
            this.tsmiSortApply_Polity.Click += new System.EventHandler(this.tsmiSortApply_Polity_Click);
            // 
            // toolStripSeparator91
            // 
            this.toolStripSeparator91.Name = "toolStripSeparator91";
            this.toolStripSeparator91.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Polity
            // 
            this.tsbRefresh_Polity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Polity.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Polity.Image")));
            this.tsbRefresh_Polity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Polity.Name = "tsbRefresh_Polity";
            this.tsbRefresh_Polity.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Polity.Text = "tsbRefresh";
            this.tsbRefresh_Polity.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Polity.Click += new System.EventHandler(this.tsbRefresh_Polity_Click);
            // 
            // toolStripSeparator92
            // 
            this.toolStripSeparator92.Name = "toolStripSeparator92";
            this.toolStripSeparator92.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExportAll_Polity
            // 
            this.tsbExportAll_Polity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Polity.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Polity.Image")));
            this.tsbExportAll_Polity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Polity.Name = "tsbExportAll_Polity";
            this.tsbExportAll_Polity.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Polity.Text = "toolStripButton1";
            this.tsbExportAll_Polity.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Polity.Click += new System.EventHandler(this.tsbExportAll_Polity_Click);
            // 
            // tpStats_Polity
            // 
            this.tpStats_Polity.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Polity.Controls.Add(this.l_stats_PolityCount);
            this.tpStats_Polity.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Polity.Name = "tpStats_Polity";
            this.tpStats_Polity.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Polity.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Polity.TabIndex = 1;
            this.tpStats_Polity.Text = "Статистика";
            // 
            // l_stats_PolityCount
            // 
            this.l_stats_PolityCount.AutoSize = true;
            this.l_stats_PolityCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_stats_PolityCount.Location = new System.Drawing.Point(6, 3);
            this.l_stats_PolityCount.Name = "l_stats_PolityCount";
            this.l_stats_PolityCount.Size = new System.Drawing.Size(181, 24);
            this.l_stats_PolityCount.TabIndex = 1;
            this.l_stats_PolityCount.Text = "Всего государств: ";
            // 
            // tpEnrollment
            // 
            this.tpEnrollment.Controls.Add(this.tcEnlistment);
            this.tpEnrollment.Location = new System.Drawing.Point(4, 22);
            this.tpEnrollment.Margin = new System.Windows.Forms.Padding(0);
            this.tpEnrollment.Name = "tpEnrollment";
            this.tpEnrollment.Size = new System.Drawing.Size(987, 456);
            this.tpEnrollment.TabIndex = 2;
            this.tpEnrollment.Text = "Зачисление абитуриентов";
            this.tpEnrollment.UseVisualStyleBackColor = true;
            // 
            // tcEnlistment
            // 
            this.tcEnlistment.Controls.Add(this.tpGroups);
            this.tcEnlistment.Controls.Add(this.tpCandidates);
            this.tcEnlistment.Controls.Add(this.tpPreliminaryGroups);
            this.tcEnlistment.Controls.Add(this.tpDecision);
            this.tcEnlistment.Controls.Add(this.tpFormedGroups);
            this.tcEnlistment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEnlistment.Location = new System.Drawing.Point(0, 0);
            this.tcEnlistment.Name = "tcEnlistment";
            this.tcEnlistment.SelectedIndex = 0;
            this.tcEnlistment.Size = new System.Drawing.Size(987, 456);
            this.tcEnlistment.TabIndex = 24;
            // 
            // tpGroups
            // 
            this.tpGroups.Controls.Add(this.tcGroups);
            this.tpGroups.Location = new System.Drawing.Point(4, 22);
            this.tpGroups.Name = "tpGroups";
            this.tpGroups.Size = new System.Drawing.Size(979, 430);
            this.tpGroups.TabIndex = 0;
            this.tpGroups.Text = "Список групп";
            this.tpGroups.UseVisualStyleBackColor = true;
            // 
            // tcGroups
            // 
            this.tcGroups.Controls.Add(this.tabPage1);
            this.tcGroups.Controls.Add(this.tabPage2);
            this.tcGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcGroups.Location = new System.Drawing.Point(0, 0);
            this.tcGroups.Margin = new System.Windows.Forms.Padding(0);
            this.tcGroups.Name = "tcGroups";
            this.tcGroups.SelectedIndex = 0;
            this.tcGroups.Size = new System.Drawing.Size(979, 430);
            this.tcGroups.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tbID_Groups);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.tbStudents_Groups);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.tbYear_Groups);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.tbName_Groups);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cbSpec_Groups);
            this.tabPage1.Controls.Add(this.label48);
            this.tabPage1.Controls.Add(this.dgvGroups);
            this.tabPage1.Controls.Add(this.btnUpdate_Groups);
            this.tabPage1.Controls.Add(this.label49);
            this.tabPage1.Controls.Add(this.splitter_Groups);
            this.tabPage1.Controls.Add(this.tsGroups);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(604, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 106;
            this.label15.Text = "Идентификатор";
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(604, 173);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(120, 13);
            this.label45.TabIndex = 104;
            this.label45.Text = "Количество студентов";
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(604, 147);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(104, 13);
            this.label46.TabIndex = 102;
            this.label46.Text = "Год формирования";
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(604, 94);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(57, 13);
            this.label47.TabIndex = 100;
            this.label47.Text = "Название";
            // 
            // label48
            // 
            this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(604, 120);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(85, 13);
            this.label48.TabIndex = 98;
            this.label48.Text = "Специальность";
            // 
            // dgvGroups
            // 
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvGroups.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvGroups.Location = new System.Drawing.Point(3, 28);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(592, 373);
            this.dgvGroups.TabIndex = 97;
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // btnUpdate_Groups
            // 
            this.btnUpdate_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Groups.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Groups.Location = new System.Drawing.Point(716, 214);
            this.btnUpdate_Groups.Name = "btnUpdate_Groups";
            this.btnUpdate_Groups.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Groups.TabIndex = 96;
            this.btnUpdate_Groups.Text = "Обновить";
            this.btnUpdate_Groups.UseVisualStyleBackColor = false;
            this.btnUpdate_Groups.Click += new System.EventHandler(this.btnUpdate_Groups_Click);
            // 
            // label49
            // 
            this.label49.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(732, 37);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(99, 13);
            this.label49.TabIndex = 95;
            this.label49.Text = "Изменить данные";
            // 
            // splitter_Groups
            // 
            this.splitter_Groups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Groups.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Groups.Location = new System.Drawing.Point(595, 28);
            this.splitter_Groups.Name = "splitter_Groups";
            this.splitter_Groups.Size = new System.Drawing.Size(373, 373);
            this.splitter_Groups.TabIndex = 88;
            this.splitter_Groups.TabStop = false;
            // 
            // tsGroups
            // 
            this.tsGroups.BackColor = System.Drawing.SystemColors.Control;
            this.tsGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Groups,
            this.tsbChange_Groups,
            this.tsbDelete_Groups,
            this.toolStripSeparator105,
            this.tssbFilter_Groups,
            this.tsbResetFilter_Groups,
            this.toolStripSeparator109,
            this.tssbSort_Groups,
            this.toolStripSeparator112,
            this.tsbRefresh_Groups,
            this.toolStripSeparator113,
            this.tsbExport_Groups,
            this.tsbExportAll_Groups});
            this.tsGroups.Location = new System.Drawing.Point(3, 3);
            this.tsGroups.Name = "tsGroups";
            this.tsGroups.Size = new System.Drawing.Size(965, 25);
            this.tsGroups.TabIndex = 5;
            this.tsGroups.Text = "toolStrip1";
            // 
            // tsbAdd_Groups
            // 
            this.tsbAdd_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Groups.Image")));
            this.tsbAdd_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Groups.Name = "tsbAdd_Groups";
            this.tsbAdd_Groups.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Groups.Text = "tsbAddClient";
            this.tsbAdd_Groups.ToolTipText = "Добавить группу";
            this.tsbAdd_Groups.Click += new System.EventHandler(this.tsbAdd_Groups_Click);
            // 
            // tsbChange_Groups
            // 
            this.tsbChange_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Groups.Image")));
            this.tsbChange_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Groups.Name = "tsbChange_Groups";
            this.tsbChange_Groups.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Groups.Text = "tsbChangeClient";
            this.tsbChange_Groups.ToolTipText = "Изменить группу";
            this.tsbChange_Groups.Click += new System.EventHandler(this.tsbChange_Groups_Click);
            // 
            // tsbDelete_Groups
            // 
            this.tsbDelete_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Groups.Image")));
            this.tsbDelete_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Groups.Name = "tsbDelete_Groups";
            this.tsbDelete_Groups.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Groups.Text = "tsbDeleteClient";
            this.tsbDelete_Groups.ToolTipText = "Удалить группу";
            this.tsbDelete_Groups.Click += new System.EventHandler(this.tsbDelete_Groups_Click);
            // 
            // toolStripSeparator105
            // 
            this.toolStripSeparator105.Name = "toolStripSeparator105";
            this.toolStripSeparator105.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Groups
            // 
            this.tssbFilter_Groups.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Groups.DropDownButtonWidth = 20;
            this.tssbFilter_Groups.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem56,
            this.tscbFilterField_Groups,
            this.toolStripSeparator106,
            this.toolStripMenuItem57,
            this.tscbFilterOper_Groups,
            this.toolStripSeparator107,
            this.toolStripMenuItem58,
            this.tstbFilterValue_Groups,
            this.toolStripSeparator108,
            this.tsmiFilterApply_Groups});
            this.tssbFilter_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Groups.Image")));
            this.tssbFilter_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Groups.Name = "tssbFilter_Groups";
            this.tssbFilter_Groups.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Groups.Text = "toolStripSplitButton1";
            this.tssbFilter_Groups.ToolTipText = "Фильтр";
            this.tssbFilter_Groups.Click += new System.EventHandler(this.tssbFilter_Groups_Click);
            // 
            // toolStripMenuItem56
            // 
            this.toolStripMenuItem56.Name = "toolStripMenuItem56";
            this.toolStripMenuItem56.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem56.Text = "Поле";
            // 
            // tscbFilterField_Groups
            // 
            this.tscbFilterField_Groups.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Groups.Name = "tscbFilterField_Groups";
            this.tscbFilterField_Groups.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator106
            // 
            this.toolStripSeparator106.Name = "toolStripSeparator106";
            this.toolStripSeparator106.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem57
            // 
            this.toolStripMenuItem57.Name = "toolStripMenuItem57";
            this.toolStripMenuItem57.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem57.Text = "Операция";
            // 
            // tscbFilterOper_Groups
            // 
            this.tscbFilterOper_Groups.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Groups.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Groups.Name = "tscbFilterOper_Groups";
            this.tscbFilterOper_Groups.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator107
            // 
            this.toolStripSeparator107.Name = "toolStripSeparator107";
            this.toolStripSeparator107.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem58
            // 
            this.toolStripMenuItem58.Name = "toolStripMenuItem58";
            this.toolStripMenuItem58.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem58.Text = "Искомое";
            // 
            // tstbFilterValue_Groups
            // 
            this.tstbFilterValue_Groups.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Groups.Name = "tstbFilterValue_Groups";
            this.tstbFilterValue_Groups.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator108
            // 
            this.toolStripSeparator108.Name = "toolStripSeparator108";
            this.toolStripSeparator108.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Groups
            // 
            this.tsmiFilterApply_Groups.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Groups.Name = "tsmiFilterApply_Groups";
            this.tsmiFilterApply_Groups.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Groups.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Groups.Text = "Применить фильтр";
            this.tsmiFilterApply_Groups.Click += new System.EventHandler(this.tsmiFilterApply_Groups_Click);
            // 
            // tsbResetFilter_Groups
            // 
            this.tsbResetFilter_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Groups.Image")));
            this.tsbResetFilter_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Groups.Name = "tsbResetFilter_Groups";
            this.tsbResetFilter_Groups.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Groups.Text = "toolStripButton1";
            this.tsbResetFilter_Groups.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Groups.Click += new System.EventHandler(this.tsbResetFilter_Groups_Click);
            // 
            // toolStripSeparator109
            // 
            this.toolStripSeparator109.Name = "toolStripSeparator109";
            this.toolStripSeparator109.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Groups
            // 
            this.tssbSort_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Groups.DropDownButtonWidth = 20;
            this.tssbSort_Groups.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem60,
            this.tscbSortField_Groups,
            this.toolStripSeparator110,
            this.toolStripMenuItem61,
            this.tscbSortOrder_Groups,
            this.toolStripSeparator111,
            this.tsmiSortApply_Groups});
            this.tssbSort_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Groups.Image")));
            this.tssbSort_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Groups.Name = "tssbSort_Groups";
            this.tssbSort_Groups.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Groups.Text = "Сортировка";
            this.tssbSort_Groups.Click += new System.EventHandler(this.tssbSort_Groups_Click);
            // 
            // toolStripMenuItem60
            // 
            this.toolStripMenuItem60.Name = "toolStripMenuItem60";
            this.toolStripMenuItem60.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem60.Text = "Поле";
            // 
            // tscbSortField_Groups
            // 
            this.tscbSortField_Groups.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Groups.Name = "tscbSortField_Groups";
            this.tscbSortField_Groups.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator110
            // 
            this.toolStripSeparator110.Name = "toolStripSeparator110";
            this.toolStripSeparator110.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem61
            // 
            this.toolStripMenuItem61.Name = "toolStripMenuItem61";
            this.toolStripMenuItem61.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem61.Text = "Режим";
            // 
            // tscbSortOrder_Groups
            // 
            this.tscbSortOrder_Groups.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbSortOrder_Groups.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Groups.Name = "tscbSortOrder_Groups";
            this.tscbSortOrder_Groups.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator111
            // 
            this.toolStripSeparator111.Name = "toolStripSeparator111";
            this.toolStripSeparator111.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Groups
            // 
            this.tsmiSortApply_Groups.Name = "tsmiSortApply_Groups";
            this.tsmiSortApply_Groups.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Groups.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Groups.Text = "Применить";
            this.tsmiSortApply_Groups.Click += new System.EventHandler(this.tsmiSortApply_Groups_Click);
            // 
            // toolStripSeparator112
            // 
            this.toolStripSeparator112.Name = "toolStripSeparator112";
            this.toolStripSeparator112.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Groups
            // 
            this.tsbRefresh_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Groups.Image")));
            this.tsbRefresh_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Groups.Name = "tsbRefresh_Groups";
            this.tsbRefresh_Groups.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Groups.Text = "tsbRefresh";
            this.tsbRefresh_Groups.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Groups.Click += new System.EventHandler(this.tsbRefresh_Groups_Click);
            // 
            // toolStripSeparator113
            // 
            this.toolStripSeparator113.Name = "toolStripSeparator113";
            this.toolStripSeparator113.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport_Groups
            // 
            this.tsbExport_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport_Groups.Image")));
            this.tsbExport_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport_Groups.Name = "tsbExport_Groups";
            this.tsbExport_Groups.Size = new System.Drawing.Size(23, 22);
            this.tsbExport_Groups.Text = "tsbExportClients";
            this.tsbExport_Groups.ToolTipText = "Создать отчет по выделенной записи";
            this.tsbExport_Groups.Click += new System.EventHandler(this.tsbExport_Groups_Click);
            // 
            // tsbExportAll_Groups
            // 
            this.tsbExportAll_Groups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Groups.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Groups.Image")));
            this.tsbExportAll_Groups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Groups.Name = "tsbExportAll_Groups";
            this.tsbExportAll_Groups.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Groups.Text = "toolStripButton1";
            this.tsbExportAll_Groups.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Groups.Click += new System.EventHandler(this.tsbExportAll_Groups_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label50);
            this.tabPage2.Controls.Add(this.label51);
            this.tabPage2.Controls.Add(this.label52);
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(971, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(105, 55);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(56, 13);
            this.label50.TabIndex = 4;
            this.label50.Text = "Процент: ";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(71, 16);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(90, 13);
            this.label51.TabIndex = 1;
            this.label51.Text = "Всего решений: ";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(20, 42);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(141, 13);
            this.label52.TabIndex = 3;
            this.label52.Text = "В текущем текущем году: ";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(105, 29);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(56, 13);
            this.label53.TabIndex = 2;
            this.label53.Text = "Процент: ";
            // 
            // tpCandidates
            // 
            this.tpCandidates.Controls.Add(this.dgvCandidates);
            this.tpCandidates.Controls.Add(this.tsCandidates);
            this.tpCandidates.Controls.Add(this.lvGroups_Candidates);
            this.tpCandidates.Location = new System.Drawing.Point(4, 22);
            this.tpCandidates.Name = "tpCandidates";
            this.tpCandidates.Size = new System.Drawing.Size(979, 430);
            this.tpCandidates.TabIndex = 1;
            this.tpCandidates.Text = "Кандидаты на зачисление";
            this.tpCandidates.UseVisualStyleBackColor = true;
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCandidates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCandidates.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvCandidates.Location = new System.Drawing.Point(253, 25);
            this.dgvCandidates.MultiSelect = false;
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(726, 405);
            this.dgvCandidates.TabIndex = 98;
            // 
            // tsCandidates
            // 
            this.tsCandidates.BackColor = System.Drawing.SystemColors.Control;
            this.tsCandidates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEnroll,
            this.toolStripSeparator114,
            this.tsbRefresh_Candidates,
            this.toolStripSeparator122,
            this.tsbExportTable_Candidates,
            this.tslFreeSlots_Candidates,
            this.toolStripSeparator102,
            this.tslSlots_Candidates});
            this.tsCandidates.Location = new System.Drawing.Point(253, 0);
            this.tsCandidates.Name = "tsCandidates";
            this.tsCandidates.Size = new System.Drawing.Size(726, 25);
            this.tsCandidates.TabIndex = 6;
            this.tsCandidates.Text = "toolStrip1";
            // 
            // tsbEnroll
            // 
            this.tsbEnroll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEnroll.Image = ((System.Drawing.Image)(resources.GetObject("tsbEnroll.Image")));
            this.tsbEnroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEnroll.Name = "tsbEnroll";
            this.tsbEnroll.Size = new System.Drawing.Size(23, 22);
            this.tsbEnroll.Text = "tsbAddClient";
            this.tsbEnroll.ToolTipText = "Добавить выбранного кандидата";
            this.tsbEnroll.Click += new System.EventHandler(this.tsbEnroll_Click);
            // 
            // toolStripSeparator114
            // 
            this.toolStripSeparator114.Name = "toolStripSeparator114";
            this.toolStripSeparator114.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Candidates
            // 
            this.tsbRefresh_Candidates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Candidates.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Candidates.Image")));
            this.tsbRefresh_Candidates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Candidates.Name = "tsbRefresh_Candidates";
            this.tsbRefresh_Candidates.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Candidates.Text = "tsbRefresh";
            this.tsbRefresh_Candidates.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Candidates.Click += new System.EventHandler(this.tsbRefresh_Candidates_Click);
            // 
            // toolStripSeparator122
            // 
            this.toolStripSeparator122.Name = "toolStripSeparator122";
            this.toolStripSeparator122.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExportTable_Candidates
            // 
            this.tsbExportTable_Candidates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportTable_Candidates.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportTable_Candidates.Image")));
            this.tsbExportTable_Candidates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportTable_Candidates.Name = "tsbExportTable_Candidates";
            this.tsbExportTable_Candidates.Size = new System.Drawing.Size(23, 22);
            this.tsbExportTable_Candidates.Text = "toolStripButton1";
            this.tsbExportTable_Candidates.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportTable_Candidates.Click += new System.EventHandler(this.tsbExportTable_Candidates_Click);
            // 
            // tslFreeSlots_Candidates
            // 
            this.tslFreeSlots_Candidates.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslFreeSlots_Candidates.Name = "tslFreeSlots_Candidates";
            this.tslFreeSlots_Candidates.Size = new System.Drawing.Size(94, 22);
            this.tslFreeSlots_Candidates.Text = "Осталось мест: ";
            // 
            // toolStripSeparator102
            // 
            this.toolStripSeparator102.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator102.Name = "toolStripSeparator102";
            this.toolStripSeparator102.Size = new System.Drawing.Size(6, 25);
            // 
            // tslSlots_Candidates
            // 
            this.tslSlots_Candidates.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslSlots_Candidates.Name = "tslSlots_Candidates";
            this.tslSlots_Candidates.Size = new System.Drawing.Size(73, 22);
            this.tslSlots_Candidates.Text = "Всего мест: ";
            // 
            // lvGroups_Candidates
            // 
            this.lvGroups_Candidates.BackColor = System.Drawing.SystemColors.Control;
            this.lvGroups_Candidates.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvGroups_Candidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvGroups_Candidates.Location = new System.Drawing.Point(0, 0);
            this.lvGroups_Candidates.MultiSelect = false;
            this.lvGroups_Candidates.Name = "lvGroups_Candidates";
            this.lvGroups_Candidates.Size = new System.Drawing.Size(253, 430);
            this.lvGroups_Candidates.TabIndex = 0;
            this.lvGroups_Candidates.UseCompatibleStateImageBehavior = false;
            this.lvGroups_Candidates.View = System.Windows.Forms.View.List;
            this.lvGroups_Candidates.SelectedIndexChanged += new System.EventHandler(this.lvGroups_Candidates_SelectedIndexChanged);
            // 
            // tpPreliminaryGroups
            // 
            this.tpPreliminaryGroups.Controls.Add(this.dgvPreliminary);
            this.tpPreliminaryGroups.Controls.Add(this.tsPreliminary);
            this.tpPreliminaryGroups.Controls.Add(this.lvGroups_Preliminary);
            this.tpPreliminaryGroups.Location = new System.Drawing.Point(4, 22);
            this.tpPreliminaryGroups.Name = "tpPreliminaryGroups";
            this.tpPreliminaryGroups.Size = new System.Drawing.Size(979, 430);
            this.tpPreliminaryGroups.TabIndex = 4;
            this.tpPreliminaryGroups.Text = "Предварительный состав групп";
            this.tpPreliminaryGroups.UseVisualStyleBackColor = true;
            // 
            // dgvPreliminary
            // 
            this.dgvPreliminary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPreliminary.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPreliminary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreliminary.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvPreliminary.Location = new System.Drawing.Point(253, 25);
            this.dgvPreliminary.MultiSelect = false;
            this.dgvPreliminary.Name = "dgvPreliminary";
            this.dgvPreliminary.ReadOnly = true;
            this.dgvPreliminary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreliminary.Size = new System.Drawing.Size(726, 405);
            this.dgvPreliminary.TabIndex = 101;
            // 
            // tsPreliminary
            // 
            this.tsPreliminary.BackColor = System.Drawing.SystemColors.Control;
            this.tsPreliminary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDes_Preliminary,
            this.tsbUnenroll,
            this.toolStripSeparator21,
            this.tsbRefresh_Preliminary,
            this.toolStripSeparator130,
            this.tsbExport_Preliminary,
            this.toolStripSeparator104,
            this.tslFreeSlots_Preliminary,
            this.tslSlots_Preliminary});
            this.tsPreliminary.Location = new System.Drawing.Point(253, 0);
            this.tsPreliminary.Name = "tsPreliminary";
            this.tsPreliminary.Size = new System.Drawing.Size(726, 25);
            this.tsPreliminary.TabIndex = 100;
            this.tsPreliminary.Text = "toolStrip1";
            // 
            // tsbDes_Preliminary
            // 
            this.tsbDes_Preliminary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDes_Preliminary.Image = ((System.Drawing.Image)(resources.GetObject("tsbDes_Preliminary.Image")));
            this.tsbDes_Preliminary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDes_Preliminary.Name = "tsbDes_Preliminary";
            this.tsbDes_Preliminary.Size = new System.Drawing.Size(23, 22);
            this.tsbDes_Preliminary.Text = "tsbAddClient";
            this.tsbDes_Preliminary.ToolTipText = "Создать решение о зачислении";
            this.tsbDes_Preliminary.Click += new System.EventHandler(this.tsbDes_Preliminary_Click);
            // 
            // tsbUnenroll
            // 
            this.tsbUnenroll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnenroll.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnenroll.Image")));
            this.tsbUnenroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnenroll.Name = "tsbUnenroll";
            this.tsbUnenroll.Size = new System.Drawing.Size(23, 22);
            this.tsbUnenroll.Text = "tsbAddClient";
            this.tsbUnenroll.ToolTipText = "Удалить из состава группы";
            this.tsbUnenroll.Click += new System.EventHandler(this.tsbUnenroll_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Preliminary
            // 
            this.tsbRefresh_Preliminary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Preliminary.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Preliminary.Image")));
            this.tsbRefresh_Preliminary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Preliminary.Name = "tsbRefresh_Preliminary";
            this.tsbRefresh_Preliminary.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Preliminary.Text = "tsbRefresh";
            this.tsbRefresh_Preliminary.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Preliminary.Click += new System.EventHandler(this.tsbRefresh_Preliminary_Click);
            // 
            // toolStripSeparator130
            // 
            this.toolStripSeparator130.Name = "toolStripSeparator130";
            this.toolStripSeparator130.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport_Preliminary
            // 
            this.tsbExport_Preliminary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport_Preliminary.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport_Preliminary.Image")));
            this.tsbExport_Preliminary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport_Preliminary.Name = "tsbExport_Preliminary";
            this.tsbExport_Preliminary.Size = new System.Drawing.Size(23, 22);
            this.tsbExport_Preliminary.Text = "toolStripButton1";
            this.tsbExport_Preliminary.ToolTipText = "Экспорт всей таблицы";
            this.tsbExport_Preliminary.Click += new System.EventHandler(this.tsbExport_Preliminary_Click);
            // 
            // toolStripSeparator104
            // 
            this.toolStripSeparator104.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator104.Name = "toolStripSeparator104";
            this.toolStripSeparator104.Size = new System.Drawing.Size(6, 25);
            // 
            // tslFreeSlots_Preliminary
            // 
            this.tslFreeSlots_Preliminary.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslFreeSlots_Preliminary.Name = "tslFreeSlots_Preliminary";
            this.tslFreeSlots_Preliminary.Size = new System.Drawing.Size(94, 22);
            this.tslFreeSlots_Preliminary.Text = "Осталось мест: ";
            // 
            // tslSlots_Preliminary
            // 
            this.tslSlots_Preliminary.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslSlots_Preliminary.Name = "tslSlots_Preliminary";
            this.tslSlots_Preliminary.Size = new System.Drawing.Size(73, 22);
            this.tslSlots_Preliminary.Text = "Всего мест: ";
            // 
            // lvGroups_Preliminary
            // 
            this.lvGroups_Preliminary.BackColor = System.Drawing.SystemColors.Control;
            this.lvGroups_Preliminary.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvGroups_Preliminary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvGroups_Preliminary.Location = new System.Drawing.Point(0, 0);
            this.lvGroups_Preliminary.MultiSelect = false;
            this.lvGroups_Preliminary.Name = "lvGroups_Preliminary";
            this.lvGroups_Preliminary.Size = new System.Drawing.Size(253, 430);
            this.lvGroups_Preliminary.TabIndex = 99;
            this.lvGroups_Preliminary.UseCompatibleStateImageBehavior = false;
            this.lvGroups_Preliminary.View = System.Windows.Forms.View.List;
            this.lvGroups_Preliminary.SelectedIndexChanged += new System.EventHandler(this.lvGroups_Preliminary_SelectedIndexChanged);
            // 
            // tpDecision
            // 
            this.tpDecision.Controls.Add(this.tcDesicion);
            this.tpDecision.Location = new System.Drawing.Point(4, 22);
            this.tpDecision.Name = "tpDecision";
            this.tpDecision.Size = new System.Drawing.Size(979, 430);
            this.tpDecision.TabIndex = 2;
            this.tpDecision.Text = "Решения комиссии";
            this.tpDecision.UseVisualStyleBackColor = true;
            // 
            // tcDesicion
            // 
            this.tcDesicion.Controls.Add(this.tpTable_Desicion);
            this.tcDesicion.Controls.Add(this.tpStats_Desicion);
            this.tcDesicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDesicion.Location = new System.Drawing.Point(0, 0);
            this.tcDesicion.Margin = new System.Windows.Forms.Padding(0);
            this.tcDesicion.Name = "tcDesicion";
            this.tcDesicion.SelectedIndex = 0;
            this.tcDesicion.Size = new System.Drawing.Size(979, 430);
            this.tcDesicion.TabIndex = 23;
            // 
            // tpTable_Desicion
            // 
            this.tpTable_Desicion.BackColor = System.Drawing.SystemColors.Control;
            this.tpTable_Desicion.Controls.Add(this.cbGroup_Decision);
            this.tpTable_Desicion.Controls.Add(this.label39);
            this.tpTable_Desicion.Controls.Add(this.label40);
            this.tpTable_Desicion.Controls.Add(this.tbID_Decision);
            this.tpTable_Desicion.Controls.Add(this.dtpDate_Decision);
            this.tpTable_Desicion.Controls.Add(this.label41);
            this.tpTable_Desicion.Controls.Add(this.cbKomis_Decision);
            this.tpTable_Desicion.Controls.Add(this.label42);
            this.tpTable_Desicion.Controls.Add(this.tbComment_Decision);
            this.tpTable_Desicion.Controls.Add(this.label43);
            this.tpTable_Desicion.Controls.Add(this.tbResolution_Decision);
            this.tpTable_Desicion.Controls.Add(this.label44);
            this.tpTable_Desicion.Controls.Add(this.dgvDecision);
            this.tpTable_Desicion.Controls.Add(this.btnUpdate_Desicion);
            this.tpTable_Desicion.Controls.Add(this.label29);
            this.tpTable_Desicion.Controls.Add(this.splitter_Decision);
            this.tpTable_Desicion.Controls.Add(this.tsDecision);
            this.tpTable_Desicion.Location = new System.Drawing.Point(4, 22);
            this.tpTable_Desicion.Name = "tpTable_Desicion";
            this.tpTable_Desicion.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable_Desicion.Size = new System.Drawing.Size(971, 404);
            this.tpTable_Desicion.TabIndex = 0;
            this.tpTable_Desicion.Text = "Просмотр";
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(629, 91);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(42, 13);
            this.label39.TabIndex = 108;
            this.label39.Text = "Группа";
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(629, 65);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(87, 13);
            this.label40.TabIndex = 107;
            this.label40.Text = "Идентификатор";
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(629, 213);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(33, 13);
            this.label41.TabIndex = 104;
            this.label41.Text = "Дата";
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(629, 239);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(86, 13);
            this.label42.TabIndex = 102;
            this.label42.Text = "Член комиссии";
            // 
            // label43
            // 
            this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(629, 144);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(77, 13);
            this.label43.TabIndex = 100;
            this.label43.Text = "Комментарий";
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(629, 118);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(52, 13);
            this.label44.TabIndex = 98;
            this.label44.Text = "Решение";
            // 
            // dgvDecision
            // 
            this.dgvDecision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDecision.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDecision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDecision.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvDecision.Location = new System.Drawing.Point(3, 28);
            this.dgvDecision.MultiSelect = false;
            this.dgvDecision.Name = "dgvDecision";
            this.dgvDecision.ReadOnly = true;
            this.dgvDecision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDecision.Size = new System.Drawing.Size(620, 373);
            this.dgvDecision.TabIndex = 97;
            this.dgvDecision.SelectionChanged += new System.EventHandler(this.dgvDecision_SelectionChanged);
            // 
            // btnUpdate_Desicion
            // 
            this.btnUpdate_Desicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_Desicion.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Desicion.Location = new System.Drawing.Point(730, 276);
            this.btnUpdate_Desicion.Name = "btnUpdate_Desicion";
            this.btnUpdate_Desicion.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate_Desicion.TabIndex = 96;
            this.btnUpdate_Desicion.Text = "Обновить";
            this.btnUpdate_Desicion.UseVisualStyleBackColor = false;
            this.btnUpdate_Desicion.Click += new System.EventHandler(this.btnUpdate_Desicion_Click);
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(746, 37);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(99, 13);
            this.label29.TabIndex = 95;
            this.label29.Text = "Изменить данные";
            // 
            // splitter_Decision
            // 
            this.splitter_Decision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_Decision.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Decision.Location = new System.Drawing.Point(623, 28);
            this.splitter_Decision.Name = "splitter_Decision";
            this.splitter_Decision.Size = new System.Drawing.Size(345, 373);
            this.splitter_Decision.TabIndex = 88;
            this.splitter_Decision.TabStop = false;
            // 
            // tsDecision
            // 
            this.tsDecision.BackColor = System.Drawing.SystemColors.Control;
            this.tsDecision.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd_Decision,
            this.tsbChange_Decision,
            this.tsbDelete_Decision,
            this.toolStripSeparator93,
            this.tssbFilter_Decision,
            this.tsbResetFilter_Decision,
            this.toolStripSeparator97,
            this.tssbSort_Decision,
            this.toolStripSeparator100,
            this.tsbRefresh_Decision,
            this.toolStripSeparator101,
            this.tsbExport_Decision,
            this.tsbExportAll_Decision});
            this.tsDecision.Location = new System.Drawing.Point(3, 3);
            this.tsDecision.Name = "tsDecision";
            this.tsDecision.Size = new System.Drawing.Size(965, 25);
            this.tsDecision.TabIndex = 5;
            this.tsDecision.Text = "toolStrip1";
            // 
            // tsbAdd_Decision
            // 
            this.tsbAdd_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd_Decision.Image")));
            this.tsbAdd_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd_Decision.Name = "tsbAdd_Decision";
            this.tsbAdd_Decision.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd_Decision.Text = "tsbAddClient";
            this.tsbAdd_Decision.ToolTipText = "Добавить решение комиссии";
            this.tsbAdd_Decision.Click += new System.EventHandler(this.tsbAdd_Decision_Click);
            // 
            // tsbChange_Decision
            // 
            this.tsbChange_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChange_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tsbChange_Decision.Image")));
            this.tsbChange_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange_Decision.Name = "tsbChange_Decision";
            this.tsbChange_Decision.Size = new System.Drawing.Size(23, 22);
            this.tsbChange_Decision.Text = "tsbChangeClient";
            this.tsbChange_Decision.ToolTipText = "Изменить решение комиссии";
            this.tsbChange_Decision.Click += new System.EventHandler(this.tsbChange_Decision_Click);
            // 
            // tsbDelete_Decision
            // 
            this.tsbDelete_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete_Decision.Image")));
            this.tsbDelete_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete_Decision.Name = "tsbDelete_Decision";
            this.tsbDelete_Decision.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete_Decision.Text = "tsbDeleteClient";
            this.tsbDelete_Decision.ToolTipText = "Удалить решение комиссии";
            this.tsbDelete_Decision.Click += new System.EventHandler(this.tsbDelete_Decision_Click);
            // 
            // toolStripSeparator93
            // 
            this.toolStripSeparator93.Name = "toolStripSeparator93";
            this.toolStripSeparator93.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbFilter_Decision
            // 
            this.tssbFilter_Decision.BackColor = System.Drawing.Color.LightYellow;
            this.tssbFilter_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFilter_Decision.DropDownButtonWidth = 20;
            this.tssbFilter_Decision.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem51,
            this.tscbFilterField_Decision,
            this.toolStripSeparator94,
            this.toolStripMenuItem52,
            this.tscbFilterOper_Decision,
            this.toolStripSeparator95,
            this.toolStripMenuItem53,
            this.tstbFilterValue_Decision,
            this.toolStripSeparator96,
            this.tsmiFilterApply_Decision});
            this.tssbFilter_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tssbFilter_Decision.Image")));
            this.tssbFilter_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFilter_Decision.Name = "tssbFilter_Decision";
            this.tssbFilter_Decision.Size = new System.Drawing.Size(41, 22);
            this.tssbFilter_Decision.Text = "toolStripSplitButton1";
            this.tssbFilter_Decision.ToolTipText = "Фильтр";
            this.tssbFilter_Decision.Click += new System.EventHandler(this.tssbFilter_Decision_Click);
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem51.Text = "Поле";
            // 
            // tscbFilterField_Decision
            // 
            this.tscbFilterField_Decision.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterField_Decision.Name = "tscbFilterField_Decision";
            this.tscbFilterField_Decision.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator94
            // 
            this.toolStripSeparator94.Name = "toolStripSeparator94";
            this.toolStripSeparator94.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem52
            // 
            this.toolStripMenuItem52.Name = "toolStripMenuItem52";
            this.toolStripMenuItem52.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem52.Text = "Операция";
            // 
            // tscbFilterOper_Decision
            // 
            this.tscbFilterOper_Decision.BackColor = System.Drawing.SystemColors.Control;
            this.tscbFilterOper_Decision.Items.AddRange(new object[] {
            "Равно",
            "Не равно",
            "Больше",
            "Меньше"});
            this.tscbFilterOper_Decision.Name = "tscbFilterOper_Decision";
            this.tscbFilterOper_Decision.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator95
            // 
            this.toolStripSeparator95.Name = "toolStripSeparator95";
            this.toolStripSeparator95.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem53
            // 
            this.toolStripMenuItem53.Name = "toolStripMenuItem53";
            this.toolStripMenuItem53.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem53.Text = "Искомое";
            // 
            // tstbFilterValue_Decision
            // 
            this.tstbFilterValue_Decision.BackColor = System.Drawing.SystemColors.Control;
            this.tstbFilterValue_Decision.Name = "tstbFilterValue_Decision";
            this.tstbFilterValue_Decision.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator96
            // 
            this.toolStripSeparator96.Name = "toolStripSeparator96";
            this.toolStripSeparator96.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiFilterApply_Decision
            // 
            this.tsmiFilterApply_Decision.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.tsmiFilterApply_Decision.Name = "tsmiFilterApply_Decision";
            this.tsmiFilterApply_Decision.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiFilterApply_Decision.Size = new System.Drawing.Size(181, 30);
            this.tsmiFilterApply_Decision.Text = "Применить фильтр";
            this.tsmiFilterApply_Decision.Click += new System.EventHandler(this.tsmiFilterApply_Desicion_Click);
            // 
            // tsbResetFilter_Decision
            // 
            this.tsbResetFilter_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetFilter_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetFilter_Decision.Image")));
            this.tsbResetFilter_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetFilter_Decision.Name = "tsbResetFilter_Decision";
            this.tsbResetFilter_Decision.Size = new System.Drawing.Size(23, 22);
            this.tsbResetFilter_Decision.Text = "toolStripButton1";
            this.tsbResetFilter_Decision.ToolTipText = "Удалить фильтр";
            this.tsbResetFilter_Decision.Click += new System.EventHandler(this.tsbResetFilter_Desicion_Click);
            // 
            // toolStripSeparator97
            // 
            this.toolStripSeparator97.Name = "toolStripSeparator97";
            this.toolStripSeparator97.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbSort_Decision
            // 
            this.tssbSort_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbSort_Decision.DropDownButtonWidth = 20;
            this.tssbSort_Decision.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem54,
            this.tscbSortField_Decision,
            this.toolStripSeparator98,
            this.toolStripMenuItem55,
            this.tscbSortOrder_Decision,
            this.toolStripSeparator99,
            this.tsmiSortApply_Decision});
            this.tssbSort_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tssbSort_Decision.Image")));
            this.tssbSort_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSort_Decision.Name = "tssbSort_Decision";
            this.tssbSort_Decision.Size = new System.Drawing.Size(41, 22);
            this.tssbSort_Decision.Text = "Сортировка";
            this.tssbSort_Decision.Click += new System.EventHandler(this.tssbSort_Decision_Click);
            // 
            // toolStripMenuItem54
            // 
            this.toolStripMenuItem54.Name = "toolStripMenuItem54";
            this.toolStripMenuItem54.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem54.Text = "Поле";
            // 
            // tscbSortField_Decision
            // 
            this.tscbSortField_Decision.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortField_Decision.Name = "tscbSortField_Decision";
            this.tscbSortField_Decision.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator98
            // 
            this.toolStripSeparator98.Name = "toolStripSeparator98";
            this.toolStripSeparator98.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem55
            // 
            this.toolStripMenuItem55.Name = "toolStripMenuItem55";
            this.toolStripMenuItem55.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem55.Text = "Режим";
            // 
            // tscbSortOrder_Decision
            // 
            this.tscbSortOrder_Decision.BackColor = System.Drawing.SystemColors.Control;
            this.tscbSortOrder_Decision.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.tscbSortOrder_Decision.Name = "tscbSortOrder_Decision";
            this.tscbSortOrder_Decision.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator99
            // 
            this.toolStripSeparator99.Name = "toolStripSeparator99";
            this.toolStripSeparator99.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiSortApply_Decision
            // 
            this.tsmiSortApply_Decision.Name = "tsmiSortApply_Decision";
            this.tsmiSortApply_Decision.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmiSortApply_Decision.Size = new System.Drawing.Size(181, 30);
            this.tsmiSortApply_Decision.Text = "Применить";
            this.tsmiSortApply_Decision.Click += new System.EventHandler(this.tsmiSortApply_Decision_Click);
            // 
            // toolStripSeparator100
            // 
            this.toolStripSeparator100.Name = "toolStripSeparator100";
            this.toolStripSeparator100.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh_Decision
            // 
            this.tsbRefresh_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh_Decision.Image")));
            this.tsbRefresh_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh_Decision.Name = "tsbRefresh_Decision";
            this.tsbRefresh_Decision.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh_Decision.Text = "tsbRefresh";
            this.tsbRefresh_Decision.ToolTipText = "Обновить таблицу";
            this.tsbRefresh_Decision.Click += new System.EventHandler(this.tsbRefresh_Decision_Click);
            // 
            // toolStripSeparator101
            // 
            this.toolStripSeparator101.Name = "toolStripSeparator101";
            this.toolStripSeparator101.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport_Decision
            // 
            this.tsbExport_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport_Decision.Image")));
            this.tsbExport_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport_Decision.Name = "tsbExport_Decision";
            this.tsbExport_Decision.Size = new System.Drawing.Size(23, 22);
            this.tsbExport_Decision.Text = "tsbExportClients";
            this.tsbExport_Decision.ToolTipText = "Создать отчет по выделенному решению комиссии";
            this.tsbExport_Decision.Click += new System.EventHandler(this.tsbExport_Desicion_Click);
            // 
            // tsbExportAll_Decision
            // 
            this.tsbExportAll_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportAll_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportAll_Decision.Image")));
            this.tsbExportAll_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportAll_Decision.Name = "tsbExportAll_Decision";
            this.tsbExportAll_Decision.Size = new System.Drawing.Size(23, 22);
            this.tsbExportAll_Decision.Text = "toolStripButton1";
            this.tsbExportAll_Decision.ToolTipText = "Экспорт всей таблицы";
            this.tsbExportAll_Decision.Click += new System.EventHandler(this.tsbExportAll_Desicion_Click);
            // 
            // tpStats_Desicion
            // 
            this.tpStats_Desicion.BackColor = System.Drawing.SystemColors.Control;
            this.tpStats_Desicion.Controls.Add(this.l_DecisionPercentYear);
            this.tpStats_Desicion.Controls.Add(this.l_DecisionCount);
            this.tpStats_Desicion.Controls.Add(this.l_DecisionCountYear);
            this.tpStats_Desicion.Controls.Add(this.l_DecisionPercent);
            this.tpStats_Desicion.Location = new System.Drawing.Point(4, 22);
            this.tpStats_Desicion.Name = "tpStats_Desicion";
            this.tpStats_Desicion.Padding = new System.Windows.Forms.Padding(3);
            this.tpStats_Desicion.Size = new System.Drawing.Size(971, 404);
            this.tpStats_Desicion.TabIndex = 1;
            this.tpStats_Desicion.Text = "Статистика";
            // 
            // l_DecisionPercentYear
            // 
            this.l_DecisionPercentYear.AutoSize = true;
            this.l_DecisionPercentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_DecisionPercentYear.Location = new System.Drawing.Point(6, 75);
            this.l_DecisionPercentYear.Name = "l_DecisionPercentYear";
            this.l_DecisionPercentYear.Size = new System.Drawing.Size(98, 24);
            this.l_DecisionPercentYear.TabIndex = 4;
            this.l_DecisionPercentYear.Text = "Процент: ";
            // 
            // l_DecisionCount
            // 
            this.l_DecisionCount.AutoSize = true;
            this.l_DecisionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_DecisionCount.Location = new System.Drawing.Point(6, 3);
            this.l_DecisionCount.Name = "l_DecisionCount";
            this.l_DecisionCount.Size = new System.Drawing.Size(158, 24);
            this.l_DecisionCount.TabIndex = 1;
            this.l_DecisionCount.Text = "Всего решений: ";
            // 
            // l_DecisionCountYear
            // 
            this.l_DecisionCountYear.AutoSize = true;
            this.l_DecisionCountYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_DecisionCountYear.Location = new System.Drawing.Point(6, 51);
            this.l_DecisionCountYear.Name = "l_DecisionCountYear";
            this.l_DecisionCountYear.Size = new System.Drawing.Size(240, 24);
            this.l_DecisionCountYear.TabIndex = 3;
            this.l_DecisionCountYear.Text = "В текущем текущем году: ";
            // 
            // l_DecisionPercent
            // 
            this.l_DecisionPercent.AutoSize = true;
            this.l_DecisionPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_DecisionPercent.Location = new System.Drawing.Point(6, 27);
            this.l_DecisionPercent.Name = "l_DecisionPercent";
            this.l_DecisionPercent.Size = new System.Drawing.Size(98, 24);
            this.l_DecisionPercent.TabIndex = 2;
            this.l_DecisionPercent.Text = "Процент: ";
            // 
            // tpFormedGroups
            // 
            this.tpFormedGroups.Controls.Add(this.dgvFormed);
            this.tpFormedGroups.Controls.Add(this.tsFormed);
            this.tpFormedGroups.Controls.Add(this.lvGroups_Formed);
            this.tpFormedGroups.Location = new System.Drawing.Point(4, 22);
            this.tpFormedGroups.Name = "tpFormedGroups";
            this.tpFormedGroups.Size = new System.Drawing.Size(979, 430);
            this.tpFormedGroups.TabIndex = 3;
            this.tpFormedGroups.Text = "Сформированный состав групп";
            this.tpFormedGroups.UseVisualStyleBackColor = true;
            // 
            // dgvFormed
            // 
            this.dgvFormed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvFormed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFormed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormed.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvFormed.Location = new System.Drawing.Point(253, 25);
            this.dgvFormed.MultiSelect = false;
            this.dgvFormed.Name = "dgvFormed";
            this.dgvFormed.ReadOnly = true;
            this.dgvFormed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormed.Size = new System.Drawing.Size(726, 405);
            this.dgvFormed.TabIndex = 101;
            // 
            // tsFormed
            // 
            this.tsFormed.BackColor = System.Drawing.SystemColors.Control;
            this.tsFormed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripSeparator139,
            this.tsbExportTable_Formed});
            this.tsFormed.Location = new System.Drawing.Point(253, 0);
            this.tsFormed.Name = "tsFormed";
            this.tsFormed.Size = new System.Drawing.Size(726, 25);
            this.tsFormed.TabIndex = 100;
            this.tsFormed.Text = "toolStrip1";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "tsbRefresh";
            this.toolStripButton10.ToolTipText = "Обновить таблицу";
            // 
            // toolStripSeparator139
            // 
            this.toolStripSeparator139.Name = "toolStripSeparator139";
            this.toolStripSeparator139.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExportTable_Formed
            // 
            this.tsbExportTable_Formed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportTable_Formed.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportTable_Formed.Image")));
            this.tsbExportTable_Formed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportTable_Formed.Name = "tsbExportTable_Formed";
            this.tsbExportTable_Formed.Size = new System.Drawing.Size(23, 22);
            this.tsbExportTable_Formed.Text = "toolStripButton1";
            this.tsbExportTable_Formed.ToolTipText = "Отчет по составу группы";
            this.tsbExportTable_Formed.Click += new System.EventHandler(this.tsbExportTable_Formed_Click);
            // 
            // lvGroups_Formed
            // 
            this.lvGroups_Formed.BackColor = System.Drawing.SystemColors.Control;
            this.lvGroups_Formed.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvGroups_Formed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvGroups_Formed.Location = new System.Drawing.Point(0, 0);
            this.lvGroups_Formed.MultiSelect = false;
            this.lvGroups_Formed.Name = "lvGroups_Formed";
            this.lvGroups_Formed.Size = new System.Drawing.Size(253, 430);
            this.lvGroups_Formed.TabIndex = 99;
            this.lvGroups_Formed.UseCompatibleStateImageBehavior = false;
            this.lvGroups_Formed.View = System.Windows.Forms.View.List;
            this.lvGroups_Formed.SelectedIndexChanged += new System.EventHandler(this.lvGroups_Formed_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "docx";
            this.sfdExport.Filter = "Word|*.docx";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 531);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(869, 512);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Абитуриент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tcMain_Table.ResumeLayout(false);
            this.tpAbit.ResumeLayout(false);
            this.tcAbit.ResumeLayout(false);
            this.tpTable_Abit.ResumeLayout(false);
            this.tpTable_Abit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbit)).EndInit();
            this.tsClients.ResumeLayout(false);
            this.tsClients.PerformLayout();
            this.tpStats_Abit.ResumeLayout(false);
            this.tpStats_Abit.PerformLayout();
            this.tpParents.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpTable_Parent.ResumeLayout(false);
            this.tpTable_Parent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent)).EndInit();
            this.tsParent.ResumeLayout(false);
            this.tsParent.PerformLayout();
            this.tpStats_Parent.ResumeLayout(false);
            this.tpStats_Parent.PerformLayout();
            this.tpStatus.ResumeLayout(false);
            this.tcStatus.ResumeLayout(false);
            this.tpTable_Status.ResumeLayout(false);
            this.tpTable_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.tsStatus.ResumeLayout(false);
            this.tsStatus.PerformLayout();
            this.tpStats_Status.ResumeLayout(false);
            this.tpStats_Status.PerformLayout();
            this.tpMilitary.ResumeLayout(false);
            this.tcMilitary.ResumeLayout(false);
            this.tpTable_Military.ResumeLayout(false);
            this.tpTable_Military.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilitary)).EndInit();
            this.tsMilitary.ResumeLayout(false);
            this.tsMilitary.PerformLayout();
            this.tpStats_Military.ResumeLayout(false);
            this.tpStats_Military.PerformLayout();
            this.tpInfo.ResumeLayout(false);
            this.tcInfo_Table.ResumeLayout(false);
            this.tpSpec.ResumeLayout(false);
            this.tcSpec.ResumeLayout(false);
            this.tpTable_Spec.ResumeLayout(false);
            this.tpTable_Spec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpec)).EndInit();
            this.tsSpec.ResumeLayout(false);
            this.tsSpec.PerformLayout();
            this.tpStats_Spec.ResumeLayout(false);
            this.tpStats_Spec.PerformLayout();
            this.tpDiscipline.ResumeLayout(false);
            this.tcDiscipline.ResumeLayout(false);
            this.tpTable_Discipline.ResumeLayout(false);
            this.tpTable_Discipline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscipline)).EndInit();
            this.tsDiscipline.ResumeLayout(false);
            this.tsDiscipline.PerformLayout();
            this.tpStats_Discipline.ResumeLayout(false);
            this.tpStats_Discipline.PerformLayout();
            this.tpBase.ResumeLayout(false);
            this.tcBase.ResumeLayout(false);
            this.tpTable_Base.ResumeLayout(false);
            this.tpTable_Base.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            this.tsBase.ResumeLayout(false);
            this.tsBase.PerformLayout();
            this.tpStats_Base.ResumeLayout(false);
            this.tpStats_Base.PerformLayout();
            this.tpLang.ResumeLayout(false);
            this.tcLang.ResumeLayout(false);
            this.tpTable_Lang.ResumeLayout(false);
            this.tpTable_Lang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLang)).EndInit();
            this.tsLang.ResumeLayout(false);
            this.tsLang.PerformLayout();
            this.tpStats_Lang.ResumeLayout(false);
            this.tpStats_Lang.PerformLayout();
            this.tpKomis2.ResumeLayout(false);
            this.tcKomis.ResumeLayout(false);
            this.tpTable_Komis.ResumeLayout(false);
            this.tpTable_Komis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomis)).EndInit();
            this.tsKomis.ResumeLayout(false);
            this.tsKomis.PerformLayout();
            this.tpStats_Komis.ResumeLayout(false);
            this.tpStats_Komis.PerformLayout();
            this.tpPolity.ResumeLayout(false);
            this.tcPolity.ResumeLayout(false);
            this.tpTable_Polity.ResumeLayout(false);
            this.tpTable_Polity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolity)).EndInit();
            this.tsPolity.ResumeLayout(false);
            this.tsPolity.PerformLayout();
            this.tpStats_Polity.ResumeLayout(false);
            this.tpStats_Polity.PerformLayout();
            this.tpEnrollment.ResumeLayout(false);
            this.tcEnlistment.ResumeLayout(false);
            this.tpGroups.ResumeLayout(false);
            this.tcGroups.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.tsGroups.ResumeLayout(false);
            this.tsGroups.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tpCandidates.ResumeLayout(false);
            this.tpCandidates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.tsCandidates.ResumeLayout(false);
            this.tsCandidates.PerformLayout();
            this.tpPreliminaryGroups.ResumeLayout(false);
            this.tpPreliminaryGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreliminary)).EndInit();
            this.tsPreliminary.ResumeLayout(false);
            this.tsPreliminary.PerformLayout();
            this.tpDecision.ResumeLayout(false);
            this.tcDesicion.ResumeLayout(false);
            this.tpTable_Desicion.ResumeLayout(false);
            this.tpTable_Desicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecision)).EndInit();
            this.tsDecision.ResumeLayout(false);
            this.tsDecision.PerformLayout();
            this.tpStats_Desicion.ResumeLayout(false);
            this.tpStats_Desicion.PerformLayout();
            this.tpFormedGroups.ResumeLayout(false);
            this.tpFormedGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormed)).EndInit();
            this.tsFormed.ResumeLayout(false);
            this.tsFormed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsciAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_Connection;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisconnect;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeConnections;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tsl_PrevOpStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_EventLog;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LocalEventLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiEventLog;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabControl tcMain_Table;
        private System.Windows.Forms.TabPage tpAbit;
        private System.Windows.Forms.TabControl tcAbit;
        private System.Windows.Forms.TabPage tpTable_Abit;
        private System.Windows.Forms.DataGridView dgvAbit;
        private System.Windows.Forms.ToolStrip tsClients;
        private System.Windows.Forms.ToolStripButton tsbAddAbit;
        private System.Windows.Forms.ToolStripButton tsbChangeAbit;
        private System.Windows.Forms.ToolStripButton tsbDeleteAbit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Abit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Abit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator43;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Abit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator44;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Abit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator45;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Abit;
        private System.Windows.Forms.ToolStripButton tsbResetFilterAbit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Abit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Abit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator29;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Abit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator30;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Abit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Abit;
        private System.Windows.Forms.TabPage tpStats_Abit;
        private System.Windows.Forms.Label l_stats_Objective;
        private System.Windows.Forms.Label l_stats_Orphan;
        private System.Windows.Forms.Label l_stats_abitCount;
        private System.Windows.Forms.Label l_stats_AbitCountCurr;
        private System.Windows.Forms.Label l_stats_NeedHostelCurr;
        private System.Windows.Forms.Label l_stats_Male;
        private System.Windows.Forms.Label l_stats_Female;
        private System.Windows.Forms.Label l_stats_Midball;
        private System.Windows.Forms.Label l_stats_MidballCurr;
        private System.Windows.Forms.Label l_stats_NeedHostel;
        private System.Windows.Forms.Label l_stats_Contract;
        private System.Windows.Forms.Label l_stats_Invalid;
        private System.Windows.Forms.TabPage tpParents;
        private System.Windows.Forms.TabPage tpStatus;
        private System.Windows.Forms.Label l_stats_StatusCount;
        private System.Windows.Forms.TabPage tpMilitary;
        private System.Windows.Forms.Label l_stats_Military;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.Label l_stats_DisciplineCount;
        private System.Windows.Forms.Label l_stats_SpecChargeable;
        private System.Windows.Forms.Label l_stats_SpecBudjet;
        private System.Windows.Forms.Label l_stats_SpecZaochn;
        private System.Windows.Forms.Label l_stats_SpecOchn;
        private System.Windows.Forms.Label l_stats_SpecCount;
        private System.Windows.Forms.Label l_stats_PolityCount;
        private System.Windows.Forms.Label l_stats_KomisCount;
        private System.Windows.Forms.Label l_stats_LangCount;
        private System.Windows.Forms.Label l_stats_BaseCount;
        private System.Windows.Forms.TabPage tpEnrollment;
        private System.Windows.Forms.Label l_DecisionPercentYear;
        private System.Windows.Forms.Label l_DecisionCountYear;
        private System.Windows.Forms.Label l_DecisionPercent;
        private System.Windows.Forms.Label l_DecisionCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTable_Parent;
        private System.Windows.Forms.DataGridView dgvParent;
        private System.Windows.Forms.Button btnUpdate_Parent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter_Parent;
        private System.Windows.Forms.ToolStrip tsParent;
        private System.Windows.Forms.ToolStripButton tsbAdd_Parent;
        private System.Windows.Forms.ToolStripButton tsbChange_Parent;
        private System.Windows.Forms.ToolStripButton tsbDelete_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Parent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Parent;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Parent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton tsbExport_Parent;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Parent;
        private System.Windows.Forms.TabPage tpStats_Parent;
        private System.Windows.Forms.TextBox tbID_Parent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone_Parent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWorkpost_Parent;
        private System.Windows.Forms.Label l_Workpost;
        private System.Windows.Forms.TextBox tbAdrFact_Parent;
        private System.Windows.Forms.Label l_AdrFact;
        private System.Windows.Forms.TextBox tbAdrReg_Parent;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.TextBox tbFIO_Parent;
        private System.Windows.Forms.Label l_ParentFIO;
        private System.Windows.Forms.ComboBox cbAbit_Parent;
        private System.Windows.Forms.Label l_Abit;
        private System.Windows.Forms.TabControl tcStatus;
        private System.Windows.Forms.TabPage tpTable_Status;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Button btnUpdate_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Splitter splitter_Status;
        private System.Windows.Forms.ToolStrip tsStatus;
        private System.Windows.Forms.ToolStripButton tsbAdd_Status;
        private System.Windows.Forms.ToolStripButton tsbChange_Status;
        private System.Windows.Forms.ToolStripButton tsbDelete_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Status;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Status;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Status;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator26;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator27;
        private System.Windows.Forms.ToolStripButton tsbExport_Status;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Status;
        private System.Windows.Forms.TabPage tpStats_Status;
        private System.Windows.Forms.TabControl tcMilitary;
        private System.Windows.Forms.TabPage tpTable_Military;
        private System.Windows.Forms.DataGridView dgvMilitary;
        private System.Windows.Forms.Button btnUpdate_Military;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Splitter splitter_Military;
        private System.Windows.Forms.ToolStrip tsMilitary;
        private System.Windows.Forms.ToolStripButton tsbAdd_Military;
        private System.Windows.Forms.ToolStripButton tsbChange_Military;
        private System.Windows.Forms.ToolStripButton tsbDelete_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator28;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Military;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator31;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator32;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator33;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Military;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator34;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Military;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator35;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator36;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator37;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Military;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator38;
        private System.Windows.Forms.ToolStripButton tsbExport_Military;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Military;
        private System.Windows.Forms.TabPage tpStats_Military;
        private System.Windows.Forms.TextBox tbID_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_Docinform;
        private System.Windows.Forms.TextBox tbDocinform_Status;
        private System.Windows.Forms.TextBox tbStatusType_Status;
        private System.Windows.Forms.Label l_StatusType;
        private System.Windows.Forms.ComboBox cbAbit_Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbID_Military;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDocinform_Military;
        private System.Windows.Forms.TextBox tbDocument_Military;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbAbit_Military;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_stats_ParentCount;
        private System.Windows.Forms.TabControl tcInfo_Table;
        private System.Windows.Forms.TabPage tpSpec;
        private System.Windows.Forms.TabPage tpDiscipline;
        private System.Windows.Forms.TabPage tpBase;
        private System.Windows.Forms.TabPage tpLang;
        private System.Windows.Forms.TabPage tpKomis2;
        private System.Windows.Forms.TabPage tpPolity;
        private System.Windows.Forms.TabControl tcSpec;
        private System.Windows.Forms.TabPage tpTable_Spec;
        private System.Windows.Forms.DataGridView dgvSpec;
        private System.Windows.Forms.Button btnUpdate_Spec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Splitter splitter_Spec;
        private System.Windows.Forms.ToolStrip tsSpec;
        private System.Windows.Forms.ToolStripButton tsbAdd_Spec;
        private System.Windows.Forms.ToolStripButton tsbChange_Spec;
        private System.Windows.Forms.ToolStripButton tsbDelete_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator39;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Spec;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator40;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator41;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator42;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Spec;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator46;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Spec;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator47;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator48;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator49;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Spec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator50;
        private System.Windows.Forms.ToolStripButton tsbExport_Spec;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Spec;
        private System.Windows.Forms.TabPage tpStats_Spec;
        private System.Windows.Forms.TextBox tbID_Spec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTitle_Spec;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbBudjet_Spec;
        private System.Windows.Forms.ComboBox cbOchn_Spec;
        private System.Windows.Forms.ComboBox cbDiscipline3_Spec;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbDiscipline2_Spec;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbDiscipline1_Spec;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbShort_Spec;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbSpecName_Spec;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbShifr_Spec;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tcDiscipline;
        private System.Windows.Forms.TabPage tpTable_Discipline;
        private System.Windows.Forms.DataGridView dgvDiscipline;
        private System.Windows.Forms.Button btnUpdate_Discipline;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Splitter splitter_Discipline;
        private System.Windows.Forms.ToolStrip tsDiscipline;
        private System.Windows.Forms.ToolStripButton tsbAdd_Discipline;
        private System.Windows.Forms.ToolStripButton tsbChange_Discipline;
        private System.Windows.Forms.ToolStripButton tsbDelete_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator51;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Discipline;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator52;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator53;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator54;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Discipline;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator55;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Discipline;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem29;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator56;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator57;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator58;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Discipline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator59;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Discipline;
        private System.Windows.Forms.TabPage tpStats_Discipline;
        private System.Windows.Forms.TabControl tcBase;
        private System.Windows.Forms.TabPage tpTable_Base;
        private System.Windows.Forms.DataGridView dgvBase;
        private System.Windows.Forms.Button btnUpdate_Base;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Splitter splitter_Base;
        private System.Windows.Forms.ToolStrip tsBase;
        private System.Windows.Forms.ToolStripButton tsbAdd_Base;
        private System.Windows.Forms.ToolStripButton tsbChange_Base;
        private System.Windows.Forms.ToolStripButton tsbDelete_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator60;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Base;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator61;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator62;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator63;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Base;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator64;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Base;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator65;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator66;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator67;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Base;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator68;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Base;
        private System.Windows.Forms.TabPage tpStats_Base;
        private System.Windows.Forms.TabControl tcLang;
        private System.Windows.Forms.TabPage tpTable_Lang;
        private System.Windows.Forms.DataGridView dgvLang;
        private System.Windows.Forms.Button btnUpdate_Lang;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Splitter splitter_Lang;
        private System.Windows.Forms.ToolStrip tsLang;
        private System.Windows.Forms.ToolStripButton tsbAdd_Lang;
        private System.Windows.Forms.ToolStripButton tsbChange_Lang;
        private System.Windows.Forms.ToolStripButton tsbDelete_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator69;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Lang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator70;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem37;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator71;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem38;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator72;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Lang;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator73;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Lang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem39;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator74;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem40;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator75;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator76;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Lang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator77;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Lang;
        private System.Windows.Forms.TabPage tpStats_Lang;
        private System.Windows.Forms.TabControl tcKomis;
        private System.Windows.Forms.TabPage tpTable_Komis;
        private System.Windows.Forms.DataGridView dgvKomis;
        private System.Windows.Forms.Button btnUpdate_Komis;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Splitter splitter_Komis;
        private System.Windows.Forms.ToolStrip tsKomis;
        private System.Windows.Forms.ToolStripButton tsbAdd_Komis;
        private System.Windows.Forms.ToolStripButton tsbChange_Komis;
        private System.Windows.Forms.ToolStripButton tsbDelete_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator78;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Komis;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem41;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator79;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem42;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator80;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem43;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator81;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Komis;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator82;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Komis;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem44;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator83;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem45;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator84;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator85;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Komis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator86;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Komis;
        private System.Windows.Forms.TabPage tpStats_Komis;
        private System.Windows.Forms.TabControl tcPolity;
        private System.Windows.Forms.TabPage tpTable_Polity;
        private System.Windows.Forms.DataGridView dgvPolity;
        private System.Windows.Forms.Button btnUpdate_Polity;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Splitter splitter_Polity;
        private System.Windows.Forms.ToolStrip tsPolity;
        private System.Windows.Forms.ToolStripButton tsbAdd_Polity;
        private System.Windows.Forms.ToolStripButton tsbChange_Polity;
        private System.Windows.Forms.ToolStripButton tsbDelete_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Polity;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem46;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem47;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem48;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator87;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Polity;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator88;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Polity;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem49;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator89;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem50;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator90;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator91;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Polity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator92;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Polity;
        private System.Windows.Forms.TabPage tpStats_Polity;
        private System.Windows.Forms.TabControl tcDesicion;
        private System.Windows.Forms.TabPage tpTable_Desicion;
        private System.Windows.Forms.DataGridView dgvDecision;
        private System.Windows.Forms.Button btnUpdate_Desicion;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Splitter splitter_Decision;
        private System.Windows.Forms.ToolStrip tsDecision;
        private System.Windows.Forms.ToolStripButton tsbAdd_Decision;
        private System.Windows.Forms.ToolStripButton tsbChange_Decision;
        private System.Windows.Forms.ToolStripButton tsbDelete_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator93;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Decision;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem51;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator94;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem52;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator95;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem53;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator96;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Decision;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator97;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Decision;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem54;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator98;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem55;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator99;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator100;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Decision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator101;
        private System.Windows.Forms.ToolStripButton tsbExport_Decision;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Decision;
        private System.Windows.Forms.TabPage tpStats_Desicion;
        private System.Windows.Forms.TextBox tbID_Discipline;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbName_Discipline;
        private System.Windows.Forms.Label l_DisciplineName;
        private System.Windows.Forms.TextBox tbID_Base;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbName_Base;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbID_Lang;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbName_Lang;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbID_Komis;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbName_Komis;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbID_Polity;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbName_Polity;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePass;
        private System.Windows.Forms.ToolStripSplitButton tssbShowColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator103;
        private System.Windows.Forms.TabControl tcEnlistment;
        private System.Windows.Forms.TabPage tpGroups;
        private System.Windows.Forms.TabPage tpCandidates;
        private System.Windows.Forms.TabPage tpDecision;
        private System.Windows.Forms.TabPage tpFormedGroups;
        private System.Windows.Forms.TabControl tcGroups;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Button btnUpdate_Groups;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Splitter splitter_Groups;
        private System.Windows.Forms.ToolStrip tsGroups;
        private System.Windows.Forms.ToolStripButton tsbAdd_Groups;
        private System.Windows.Forms.ToolStripButton tsbChange_Groups;
        private System.Windows.Forms.ToolStripButton tsbDelete_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator105;
        private System.Windows.Forms.ToolStripSplitButton tssbFilter_Groups;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem56;
        private System.Windows.Forms.ToolStripComboBox tscbFilterField_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator106;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem57;
        private System.Windows.Forms.ToolStripComboBox tscbFilterOper_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator107;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem58;
        private System.Windows.Forms.ToolStripTextBox tstbFilterValue_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator108;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterApply_Groups;
        private System.Windows.Forms.ToolStripButton tsbResetFilter_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator109;
        private System.Windows.Forms.ToolStripSplitButton tssbSort_Groups;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem60;
        private System.Windows.Forms.ToolStripComboBox tscbSortField_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator110;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem61;
        private System.Windows.Forms.ToolStripComboBox tscbSortOrder_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator111;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortApply_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator112;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator113;
        private System.Windows.Forms.ToolStripButton tsbExport_Groups;
        private System.Windows.Forms.ToolStripButton tsbExportAll_Groups;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.ComboBox cbGroup_Decision;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tbID_Decision;
        private System.Windows.Forms.DateTimePicker dtpDate_Decision;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cbKomis_Decision;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tbComment_Decision;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox tbResolution_Decision;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.ToolStrip tsCandidates;
        private System.Windows.Forms.ToolStripButton tsbEnroll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator114;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Candidates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator122;
        private System.Windows.Forms.ToolStripButton tsbExportTable_Candidates;
        private System.Windows.Forms.ListView lvGroups_Candidates;
        private System.Windows.Forms.ToolStripLabel tslFreeSlots_Candidates;
        private System.Windows.Forms.TextBox tbID_Groups;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbStudents_Groups;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbYear_Groups;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbName_Groups;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox cbSpec_Groups;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TabPage tpPreliminaryGroups;
        private System.Windows.Forms.DataGridView dgvPreliminary;
        private System.Windows.Forms.ToolStrip tsPreliminary;
        private System.Windows.Forms.ToolStripButton tsbUnenroll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripButton tsbRefresh_Preliminary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator130;
        private System.Windows.Forms.ToolStripButton tsbExport_Preliminary;
        private System.Windows.Forms.ListView lvGroups_Preliminary;
        private System.Windows.Forms.DataGridView dgvFormed;
        private System.Windows.Forms.ToolStrip tsFormed;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator139;
        private System.Windows.Forms.ToolStripButton tsbExportTable_Formed;
        private System.Windows.Forms.ListView lvGroups_Formed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator102;
        private System.Windows.Forms.ToolStripLabel tslSlots_Candidates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator104;
        private System.Windows.Forms.ToolStripLabel tslFreeSlots_Preliminary;
        private System.Windows.Forms.ToolStripLabel tslSlots_Preliminary;
        private System.Windows.Forms.ToolStripButton tsbDes_Preliminary;
    }
}

