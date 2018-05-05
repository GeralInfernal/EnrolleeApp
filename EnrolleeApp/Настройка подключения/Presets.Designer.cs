namespace EnrolleeApp
{
    partial class Presets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presets));
            this.dgvPresets = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_auto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataset = new System.Data.DataSet();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowPass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiActivatePreset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.sfdSavePresets = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPresets
            // 
            this.dgvPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPresets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.p_name,
            this.p_serv,
            this.p_user,
            this.p_db,
            this.p_port,
            this.p_pass,
            this.p_auto});
            this.dgvPresets.Location = new System.Drawing.Point(0, 24);
            this.dgvPresets.Name = "dgvPresets";
            this.dgvPresets.ReadOnly = true;
            this.dgvPresets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresets.Size = new System.Drawing.Size(647, 247);
            this.dgvPresets.TabIndex = 0;
            // 
            // p_id
            // 
            this.p_id.HeaderText = "Идентификатор";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Visible = false;
            // 
            // p_name
            // 
            this.p_name.HeaderText = "Название";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // p_serv
            // 
            this.p_serv.HeaderText = "Сервер";
            this.p_serv.Name = "p_serv";
            this.p_serv.ReadOnly = true;
            // 
            // p_user
            // 
            this.p_user.HeaderText = "Пользователь";
            this.p_user.Name = "p_user";
            this.p_user.ReadOnly = true;
            // 
            // p_db
            // 
            this.p_db.HeaderText = "База данных";
            this.p_db.Name = "p_db";
            this.p_db.ReadOnly = true;
            // 
            // p_port
            // 
            this.p_port.HeaderText = "Порт";
            this.p_port.Name = "p_port";
            this.p_port.ReadOnly = true;
            // 
            // p_pass
            // 
            this.p_pass.HeaderText = "Пароль";
            this.p_pass.Name = "p_pass";
            this.p_pass.ReadOnly = true;
            this.p_pass.Visible = false;
            // 
            // p_auto
            // 
            this.p_auto.HeaderText = "Автоматическое подключение";
            this.p_auto.Name = "p_auto";
            this.p_auto.ReadOnly = true;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "NewDataSet";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiHelpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(647, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.toolStripSeparator4,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(172, 22);
            this.tsmiSave.Text = "&Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiExit.Size = new System.Drawing.Size(172, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowID,
            this.tsmiShowPass,
            this.toolStripSeparator3,
            this.tsmiActivatePreset});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(59, 20);
            this.tsmiEdit.Text = "Правка";
            // 
            // tsmiShowID
            // 
            this.tsmiShowID.Name = "tsmiShowID";
            this.tsmiShowID.Size = new System.Drawing.Size(255, 22);
            this.tsmiShowID.Text = "Показать идентификаторы";
            this.tsmiShowID.Click += new System.EventHandler(this.tsmiShowID_Click);
            // 
            // tsmiShowPass
            // 
            this.tsmiShowPass.Name = "tsmiShowPass";
            this.tsmiShowPass.Size = new System.Drawing.Size(255, 22);
            this.tsmiShowPass.Text = "Показать пароли";
            this.tsmiShowPass.Click += new System.EventHandler(this.tsmiShowPass_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(252, 6);
            // 
            // tsmiActivatePreset
            // 
            this.tsmiActivatePreset.Name = "tsmiActivatePreset";
            this.tsmiActivatePreset.Size = new System.Drawing.Size(255, 22);
            this.tsmiActivatePreset.Text = "Сделать подключение активным";
            this.tsmiActivatePreset.Click += new System.EventHandler(this.tsmiActivatePreset_Click);
            // 
            // tsmiHelpMenu
            // 
            this.tsmiHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.toolStripSeparator5,
            this.tsmiAbout});
            this.tsmiHelpMenu.Name = "tsmiHelpMenu";
            this.tsmiHelpMenu.Size = new System.Drawing.Size(65, 20);
            this.tsmiHelpMenu.Text = "Справка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.содержаниеToolStripMenuItem.Text = "&Содержание";
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
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(12, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(244, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(128, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 40);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActivate.Location = new System.Drawing.Point(525, 277);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(110, 40);
            this.btnActivate.TabIndex = 6;
            this.btnActivate.Text = "Сделать активным";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // sfdSavePresets
            // 
            this.sfdSavePresets.DefaultExt = "txt";
            this.sfdSavePresets.Filter = "Текстовые файлы|*.txt";
            // 
            // Presets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 328);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPresets);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(663, 366);
            this.Name = "Presets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Наборы настроек подключения";
            this.Load += new System.EventHandler(this.Presets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPresets;
        private System.Data.DataSet dataset;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPass;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_db;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_port;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_auto;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivatePreset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.SaveFileDialog sfdSavePresets;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}