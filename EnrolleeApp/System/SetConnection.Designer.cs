namespace EnrolleeApp
{
    partial class SetConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetConnection));
            this.lAdress = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.lDBName = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.cbShowSymbols = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lPreset = new System.Windows.Forms.Label();
            this.cbPresets = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSetPresets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lAdress
            // 
            this.lAdress.AutoSize = true;
            this.lAdress.Location = new System.Drawing.Point(14, 42);
            this.lAdress.Name = "lAdress";
            this.lAdress.Size = new System.Drawing.Size(83, 13);
            this.lAdress.TabIndex = 0;
            this.lAdress.Text = "Адрес сервера";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(119, 39);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(134, 20);
            this.tbServer.TabIndex = 1;
            this.tbServer.Text = "localhost";
            this.toolTip.SetToolTip(this.tbServer, "До 200 символов");
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(119, 65);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(134, 20);
            this.tbUser.TabIndex = 3;
            this.tbUser.Text = "root";
            this.toolTip.SetToolTip(this.tbUser, "До 50 символов");
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(14, 68);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(103, 13);
            this.lUsername.TabIndex = 2;
            this.lUsername.Text = "Имя пользователя";
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(119, 91);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(134, 20);
            this.tbDB.TabIndex = 5;
            this.tbDB.Text = "enrolleeDB";
            this.toolTip.SetToolTip(this.tbDB, "До 30 символов");
            // 
            // lDBName
            // 
            this.lDBName.AutoSize = true;
            this.lDBName.Location = new System.Drawing.Point(14, 94);
            this.lDBName.Name = "lDBName";
            this.lDBName.Size = new System.Drawing.Size(72, 13);
            this.lDBName.TabIndex = 4;
            this.lDBName.Text = "База данных";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(119, 117);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(134, 20);
            this.tbPort.TabIndex = 7;
            this.tbPort.Text = "3306";
            this.toolTip.SetToolTip(this.tbPort, "по умолчанию 3306");
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(14, 120);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(32, 13);
            this.lPort.TabIndex = 6;
            this.lPort.Text = "Порт";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(119, 143);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(134, 20);
            this.tbPass.TabIndex = 9;
            this.tbPass.Text = "1010";
            this.toolTip.SetToolTip(this.tbPass, "До 100 символов");
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(14, 146);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(45, 13);
            this.lPassword.TabIndex = 8;
            this.lPassword.Text = "Пароль";
            // 
            // cbShowSymbols
            // 
            this.cbShowSymbols.AutoSize = true;
            this.cbShowSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowSymbols.Location = new System.Drawing.Point(119, 169);
            this.cbShowSymbols.Name = "cbShowSymbols";
            this.cbShowSymbols.Size = new System.Drawing.Size(114, 17);
            this.cbShowSymbols.TabIndex = 10;
            this.cbShowSymbols.Text = "Показать пароль";
            this.cbShowSymbols.UseVisualStyleBackColor = true;
            this.cbShowSymbols.CheckedChanged += new System.EventHandler(this.cbShowSymbols_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(42, 192);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(182, 37);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Подключиться";
            this.toolTip.SetToolTip(this.btnConnect, "Выполнить подключение с указанными параметрами");
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lPreset
            // 
            this.lPreset.AutoSize = true;
            this.lPreset.Location = new System.Drawing.Point(14, 15);
            this.lPreset.Name = "lPreset";
            this.lPreset.Size = new System.Drawing.Size(89, 13);
            this.lPreset.TabIndex = 13;
            this.lPreset.Text = "Набор настроек";
            // 
            // cbPreset
            // 
            this.cbPresets.FormattingEnabled = true;
            this.cbPresets.Location = new System.Drawing.Point(119, 12);
            this.cbPresets.Name = "cbPreset";
            this.cbPresets.Size = new System.Drawing.Size(105, 21);
            this.cbPresets.TabIndex = 14;
            this.cbPresets.SelectedIndexChanged += new System.EventHandler(this.cbPreset_SelectedIndexChanged);
            // 
            // btnSetPresets
            // 
            this.btnSetPresets.BackColor = System.Drawing.Color.Transparent;
            this.btnSetPresets.BackgroundImage = global::EnrolleeApp.Properties.Resources.w512h5121377940132185095settingsstreamline;
            this.btnSetPresets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetPresets.Location = new System.Drawing.Point(230, 12);
            this.btnSetPresets.Name = "btnSetPresets";
            this.btnSetPresets.Size = new System.Drawing.Size(23, 21);
            this.btnSetPresets.TabIndex = 15;
            this.toolTip.SetToolTip(this.btnSetPresets, "Изменить набор");
            this.btnSetPresets.UseVisualStyleBackColor = false;
            this.btnSetPresets.Click += new System.EventHandler(this.btnSetPresets_Click);
            // 
            // SetConnection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(270, 241);
            this.Controls.Add(this.btnSetPresets);
            this.Controls.Add(this.cbPresets);
            this.Controls.Add(this.lPreset);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbShowSymbols);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 279);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(286, 279);
            this.Name = "SetConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подключение к базе данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetConnection_FormClosing);
            this.Load += new System.EventHandler(this.SetConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAdress;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label lDBName;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.CheckBox cbShowSymbols;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbPresets;
        private System.Windows.Forms.Label lPreset;
        private System.Windows.Forms.Button btnSetPresets;
        private System.Windows.Forms.ToolTip toolTip;
    }
}