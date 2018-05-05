namespace EnrolleeApp
{
    partial class AddPreset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPreset));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lPreset = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.lDBName = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.lAdress = new System.Windows.Forms.Label();
            this.tbPreset = new System.Windows.Forms.TextBox();
            this.cbShowSymbols = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbAutoConn = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(128, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lPreset
            // 
            this.lPreset.AutoSize = true;
            this.lPreset.Location = new System.Drawing.Point(9, 10);
            this.lPreset.Name = "lPreset";
            this.lPreset.Size = new System.Drawing.Size(96, 13);
            this.lPreset.TabIndex = 25;
            this.lPreset.Text = "Название набора";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(114, 137);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(124, 20);
            this.tbPass.TabIndex = 24;
            this.toolTip.SetToolTip(this.tbPass, "До 100 символов");
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(9, 140);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(45, 13);
            this.lPassword.TabIndex = 23;
            this.lPassword.Text = "Пароль";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(114, 111);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(124, 20);
            this.tbPort.TabIndex = 22;
            this.tbPort.Text = "3306";
            this.toolTip.SetToolTip(this.tbPort, "по умолчанию 3306");
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(9, 114);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(32, 13);
            this.lPort.TabIndex = 21;
            this.lPort.Text = "Порт";
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(114, 85);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(124, 20);
            this.tbDB.TabIndex = 20;
            this.toolTip.SetToolTip(this.tbDB, "До 30 символов");
            // 
            // lDBName
            // 
            this.lDBName.AutoSize = true;
            this.lDBName.Location = new System.Drawing.Point(9, 88);
            this.lDBName.Name = "lDBName";
            this.lDBName.Size = new System.Drawing.Size(72, 13);
            this.lDBName.TabIndex = 19;
            this.lDBName.Text = "База данных";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(114, 59);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(124, 20);
            this.tbUser.TabIndex = 18;
            this.toolTip.SetToolTip(this.tbUser, "До 50 символов");
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(9, 62);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(103, 13);
            this.lUsername.TabIndex = 17;
            this.lUsername.Text = "Имя пользователя";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(114, 33);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(124, 20);
            this.tbServer.TabIndex = 16;
            this.toolTip.SetToolTip(this.tbServer, "До 200 символов");
            // 
            // lAdress
            // 
            this.lAdress.AutoSize = true;
            this.lAdress.Location = new System.Drawing.Point(9, 36);
            this.lAdress.Name = "lAdress";
            this.lAdress.Size = new System.Drawing.Size(83, 13);
            this.lAdress.TabIndex = 15;
            this.lAdress.Text = "Адрес сервера";
            // 
            // tbPreset
            // 
            this.tbPreset.Location = new System.Drawing.Point(114, 7);
            this.tbPreset.Name = "tbPreset";
            this.tbPreset.Size = new System.Drawing.Size(124, 20);
            this.tbPreset.TabIndex = 26;
            this.toolTip.SetToolTip(this.tbPreset, "До 100 символов");
            // 
            // cbShowSymbols
            // 
            this.cbShowSymbols.AutoSize = true;
            this.cbShowSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowSymbols.Location = new System.Drawing.Point(12, 163);
            this.cbShowSymbols.Name = "cbShowSymbols";
            this.cbShowSymbols.Size = new System.Drawing.Size(114, 17);
            this.cbShowSymbols.TabIndex = 27;
            this.cbShowSymbols.Text = "Показать пароль";
            this.cbShowSymbols.UseVisualStyleBackColor = true;
            this.cbShowSymbols.CheckedChanged += new System.EventHandler(this.cbShowSymbols_CheckedChanged);
            // 
            // cbAutoConn
            // 
            this.cbAutoConn.AutoSize = true;
            this.cbAutoConn.Location = new System.Drawing.Point(12, 186);
            this.cbAutoConn.Name = "cbAutoConn";
            this.cbAutoConn.Size = new System.Drawing.Size(180, 17);
            this.cbAutoConn.TabIndex = 28;
            this.cbAutoConn.Text = "Подключаться автоматически";
            this.cbAutoConn.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 270);
            this.Controls.Add(this.cbAutoConn);
            this.Controls.Add(this.cbShowSymbols);
            this.Controls.Add(this.tbPreset);
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
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(268, 308);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(268, 308);
            this.Name = "AddPreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить набор настроек";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPreset_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.TextBox tbPreset;
        private System.Windows.Forms.CheckBox cbShowSymbols;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox cbAutoConn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}