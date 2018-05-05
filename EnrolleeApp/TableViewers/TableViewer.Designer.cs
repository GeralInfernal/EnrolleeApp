namespace EnrolleeApp
{
    partial class TableViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableViewer));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsl_RowsCount = new System.Windows.Forms.ToolStripLabel();
            this.tsl_PrevOpResult = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiMenu_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОтчетПоВыбранномуСтолбцуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.sfdTable = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_RowsCount,
            this.tsl_PrevOpResult});
            this.toolStrip.Location = new System.Drawing.Point(0, 399);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(705, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsl_RowsCount
            // 
            this.tsl_RowsCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_RowsCount.Name = "tsl_RowsCount";
            this.tsl_RowsCount.Size = new System.Drawing.Size(0, 22);
            // 
            // tsl_PrevOpResult
            // 
            this.tsl_PrevOpResult.Name = "tsl_PrevOpResult";
            this.tsl_PrevOpResult.Size = new System.Drawing.Size(45, 22);
            this.tsl_PrevOpResult.Text = "Готово";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu_File,
            this.stmiMenu_Report,
            this.tsmiMenu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(705, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiMenu_File
            // 
            this.tsmiMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveAs,
            this.toolStripSeparator1,
            this.tsmiPrint,
            this.tsmiPreview,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.tsmiMenu_File.Name = "tsmiMenu_File";
            this.tsmiMenu_File.Size = new System.Drawing.Size(48, 20);
            this.tsmiMenu_File.Text = "&Файл";
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveAs.Image")));
            this.tsmiSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(233, 22);
            this.tsmiSaveAs.Text = "&Сохранить как";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPrint.Image")));
            this.tsmiPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiPrint.Size = new System.Drawing.Size(233, 22);
            this.tsmiPrint.Text = "&Печать";
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // tsmiPreview
            // 
            this.tsmiPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPreview.Image")));
            this.tsmiPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiPreview.Name = "tsmiPreview";
            this.tsmiPreview.Size = new System.Drawing.Size(233, 22);
            this.tsmiPreview.Text = "Предварительный про&смотр";
            this.tsmiPreview.Click += new System.EventHandler(this.tsmiPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // stmiMenu_Report
            // 
            this.stmiMenu_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОтчетПоВыбранномуСтолбцуToolStripMenuItem});
            this.stmiMenu_Report.Name = "stmiMenu_Report";
            this.stmiMenu_Report.Size = new System.Drawing.Size(60, 20);
            this.stmiMenu_Report.Text = "Отчеты";
            // 
            // создатьОтчетПоВыбранномуСтолбцуToolStripMenuItem
            // 
            this.создатьОтчетПоВыбранномуСтолбцуToolStripMenuItem.Name = "создатьОтчетПоВыбранномуСтолбцуToolStripMenuItem";
            this.создатьОтчетПоВыбранномуСтолбцуToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.создатьОтчетПоВыбранномуСтолбцуToolStripMenuItem.Text = "Создать отчет по выбранному столбцу";
            // 
            // tsmiMenu_Help
            // 
            this.tsmiMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.toolStripSeparator5,
            this.tsmiAbout});
            this.tsmiMenu_Help.Name = "tsmiMenu_Help";
            this.tsmiMenu_Help.Size = new System.Drawing.Size(65, 20);
            this.tsmiMenu_Help.Text = "Спра&вка";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(158, 22);
            this.tsmiHelp.Text = "&Содержание";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(158, 22);
            this.tsmiAbout.Text = "&О программе...";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 24);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.Size = new System.Drawing.Size(705, 375);
            this.dgvTable.TabIndex = 2;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // sfdTable
            // 
            this.sfdTable.DefaultExt = "docx";
            this.sfdTable.Filter = "Текстовые файлы|*.txt|Word|*.docx";
            // 
            // TableViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 424);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TableViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Название таблицы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableViewer_FormClosing);
            this.Load += new System.EventHandler(this.TableViewer_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_File;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.ToolStripLabel tsl_RowsCount;
        private System.Windows.Forms.ToolStripLabel tsl_PrevOpResult;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.SaveFileDialog sfdTable;
        private System.Windows.Forms.ToolStripMenuItem stmiMenu_Report;
        private System.Windows.Forms.ToolStripMenuItem создатьОтчетПоВыбранномуСтолбцуToolStripMenuItem;
    }
}