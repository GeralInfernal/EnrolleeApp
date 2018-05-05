namespace EnrolleeApp
{
    partial class UpdatePreset
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePreset));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPreset = new System.Windows.Forms.TextBox();
            this.lPreset = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.lDBName = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.lAdress = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbAutoConn = new System.Windows.Forms.CheckBox();
            this.cbShowSymbols = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(117, 136);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(124, 20);
            this.tbPass.TabIndex = 36;
            this.toolTip.SetToolTip(this.tbPass, "До 100 символов");
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(117, 110);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(124, 20);
            this.tbPort.TabIndex = 34;
            this.tbPort.Text = "3306";
            this.toolTip.SetToolTip(this.tbPort, "по умолчанию 3306");
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(117, 84);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(124, 20);
            this.tbDB.TabIndex = 32;
            this.toolTip.SetToolTip(this.tbDB, "До 30 символов");
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(117, 58);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(124, 20);
            this.tbUser.TabIndex = 30;
            this.toolTip.SetToolTip(this.tbUser, "До 50 символов");
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(117, 32);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(124, 20);
            this.tbServer.TabIndex = 28;
            this.toolTip.SetToolTip(this.tbServer, "До 200 символов");
            // 
            // tbPreset
            // 
            this.tbPreset.Location = new System.Drawing.Point(117, 6);
            this.tbPreset.Name = "tbPreset";
            this.tbPreset.Size = new System.Drawing.Size(124, 20);
            this.tbPreset.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbPreset, "До 200 символов");
            // 
            // lPreset
            // 
            this.lPreset.AutoSize = true;
            this.lPreset.Location = new System.Drawing.Point(12, 9);
            this.lPreset.Name = "lPreset";
            this.lPreset.Size = new System.Drawing.Size(96, 13);
            this.lPreset.TabIndex = 37;
            this.lPreset.Text = "Название набора";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 139);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(45, 13);
            this.lPassword.TabIndex = 35;
            this.lPassword.Text = "Пароль";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(12, 113);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(32, 13);
            this.lPort.TabIndex = 33;
            this.lPort.Text = "Порт";
            // 
            // lDBName
            // 
            this.lDBName.AutoSize = true;
            this.lDBName.Location = new System.Drawing.Point(12, 87);
            this.lDBName.Name = "lDBName";
            this.lDBName.Size = new System.Drawing.Size(72, 13);
            this.lDBName.TabIndex = 31;
            this.lDBName.Text = "База данных";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(12, 61);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(103, 13);
            this.lUsername.TabIndex = 29;
            this.lUsername.Text = "Имя пользователя";
            // 
            // lAdress
            // 
            this.lAdress.AutoSize = true;
            this.lAdress.Location = new System.Drawing.Point(12, 35);
            this.lAdress.Name = "lAdress";
            this.lAdress.Size = new System.Drawing.Size(83, 13);
            this.lAdress.TabIndex = 27;
            this.lAdress.Text = "Адрес сервера";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 40);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(131, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 40);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbAutoConn
            // 
            this.cbAutoConn.AutoSize = true;
            this.cbAutoConn.Location = new System.Drawing.Point(15, 185);
            this.cbAutoConn.Name = "cbAutoConn";
            this.cbAutoConn.Size = new System.Drawing.Size(180, 17);
            this.cbAutoConn.TabIndex = 42;
            this.cbAutoConn.Text = "Подключаться автоматически";
            this.cbAutoConn.UseVisualStyleBackColor = true;
            // 
            // cbShowSymbols
            // 
            this.cbShowSymbols.AutoSize = true;
            this.cbShowSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowSymbols.Location = new System.Drawing.Point(15, 162);
            this.cbShowSymbols.Name = "cbShowSymbols";
            this.cbShowSymbols.Size = new System.Drawing.Size(114, 17);
            this.cbShowSymbols.TabIndex = 41;
            this.cbShowSymbols.Text = "Показать пароль";
            this.cbShowSymbols.UseVisualStyleBackColor = true;
            this.cbShowSymbols.Click += new System.EventHandler(this.cbShowSymbols_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // UpdatePreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 260);
            this.Controls.Add(this.tbPreset);
            this.Controls.Add(this.cbAutoConn);
            this.Controls.Add(this.cbShowSymbols);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lPreset);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.lDBName);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.lAdress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(272, 298);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(272, 298);
            this.Name = "UpdatePreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обновить набор настроек";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdatePreset_FormClosing);
            this.Load += new System.EventHandler(this.UpdatePreset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lPreset;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label lDBName;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label lAdress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbAutoConn;
        private System.Windows.Forms.CheckBox cbShowSymbols;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbPreset;
    }
}