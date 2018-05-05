namespace EnrolleeApp
{
    partial class Form_AddStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddStatus));
            this.cbAbit = new System.Windows.Forms.ComboBox();
            this.l_Abit = new System.Windows.Forms.Label();
            this.tbParentFIO = new System.Windows.Forms.TextBox();
            this.l_ParentFIO = new System.Windows.Forms.Label();
            this.tbAdrReg = new System.Windows.Forms.TextBox();
            this.l_adrreg = new System.Windows.Forms.Label();
            this.tbAdrFact = new System.Windows.Forms.TextBox();
            this.l_AdrFact = new System.Windows.Forms.Label();
            this.tbWorkpost = new System.Windows.Forms.TextBox();
            this.l_Workpost = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAbit
            // 
            this.cbAbit.FormattingEnabled = true;
            this.cbAbit.Location = new System.Drawing.Point(120, 12);
            this.cbAbit.Name = "cbAbit";
            this.cbAbit.Size = new System.Drawing.Size(220, 21);
            this.cbAbit.TabIndex = 40;
            this.toolTip.SetToolTip(this.cbAbit, "Абитуриент, для которого добавляется родитель");
            // 
            // l_Abit
            // 
            this.l_Abit.AutoSize = true;
            this.l_Abit.Location = new System.Drawing.Point(12, 15);
            this.l_Abit.Name = "l_Abit";
            this.l_Abit.Size = new System.Drawing.Size(65, 13);
            this.l_Abit.TabIndex = 39;
            this.l_Abit.Text = "Абитуриент";
            // 
            // tbParentFIO
            // 
            this.tbParentFIO.Location = new System.Drawing.Point(120, 39);
            this.tbParentFIO.Name = "tbParentFIO";
            this.tbParentFIO.Size = new System.Drawing.Size(220, 20);
            this.tbParentFIO.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbParentFIO, "ФИО родителя");
            // 
            // l_ParentFIO
            // 
            this.l_ParentFIO.AutoSize = true;
            this.l_ParentFIO.Location = new System.Drawing.Point(12, 42);
            this.l_ParentFIO.Name = "l_ParentFIO";
            this.l_ParentFIO.Size = new System.Drawing.Size(34, 13);
            this.l_ParentFIO.TabIndex = 42;
            this.l_ParentFIO.Text = "ФИО";
            // 
            // tbAdrReg
            // 
            this.tbAdrReg.Location = new System.Drawing.Point(120, 65);
            this.tbAdrReg.Name = "tbAdrReg";
            this.tbAdrReg.Size = new System.Drawing.Size(220, 20);
            this.tbAdrReg.TabIndex = 45;
            this.toolTip.SetToolTip(this.tbAdrReg, "Адрес регистрации родителя");
            // 
            // l_adrreg
            // 
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(12, 68);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(105, 13);
            this.l_adrreg.TabIndex = 44;
            this.l_adrreg.Text = "Адрес регистрации";
            // 
            // tbAdrFact
            // 
            this.tbAdrFact.Location = new System.Drawing.Point(120, 91);
            this.tbAdrFact.Name = "tbAdrFact";
            this.tbAdrFact.Size = new System.Drawing.Size(220, 20);
            this.tbAdrFact.TabIndex = 47;
            this.toolTip.SetToolTip(this.tbAdrFact, "Адрес проживания родителя");
            // 
            // l_AdrFact
            // 
            this.l_AdrFact.AutoSize = true;
            this.l_AdrFact.Location = new System.Drawing.Point(12, 94);
            this.l_AdrFact.Name = "l_AdrFact";
            this.l_AdrFact.Size = new System.Drawing.Size(103, 13);
            this.l_AdrFact.TabIndex = 46;
            this.l_AdrFact.Text = "Адрес проживания";
            // 
            // tbWorkpost
            // 
            this.tbWorkpost.Location = new System.Drawing.Point(120, 117);
            this.tbWorkpost.Name = "tbWorkpost";
            this.tbWorkpost.Size = new System.Drawing.Size(220, 20);
            this.tbWorkpost.TabIndex = 49;
            this.toolTip.SetToolTip(this.tbWorkpost, "Место работы и занимаимая должность родителя, если есть");
            // 
            // l_Workpost
            // 
            this.l_Workpost.AutoSize = true;
            this.l_Workpost.Location = new System.Drawing.Point(12, 120);
            this.l_Workpost.Name = "l_Workpost";
            this.l_Workpost.Size = new System.Drawing.Size(79, 13);
            this.l_Workpost.TabIndex = 48;
            this.l_Workpost.Text = "Место работы";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(120, 143);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(220, 20);
            this.tbPhone.TabIndex = 51;
            this.toolTip.SetToolTip(this.tbPhone, "Номер телефона родителя");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Телефон";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Добавить";
            this.toolTip.SetToolTip(this.btnAdd, "Добавить родителя в базу данных");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // Form_AddStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 227);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWorkpost);
            this.Controls.Add(this.l_Workpost);
            this.Controls.Add(this.tbAdrFact);
            this.Controls.Add(this.l_AdrFact);
            this.Controls.Add(this.tbAdrReg);
            this.Controls.Add(this.l_adrreg);
            this.Controls.Add(this.tbParentFIO);
            this.Controls.Add(this.l_ParentFIO);
            this.Controls.Add(this.cbAbit);
            this.Controls.Add(this.l_Abit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить родителя";
            this.Load += new System.EventHandler(this.Form_AddParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAbit;
        private System.Windows.Forms.Label l_Abit;
        private System.Windows.Forms.TextBox tbParentFIO;
        private System.Windows.Forms.Label l_ParentFIO;
        private System.Windows.Forms.TextBox tbAdrReg;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.TextBox tbAdrFact;
        private System.Windows.Forms.Label l_AdrFact;
        private System.Windows.Forms.TextBox tbWorkpost;
        private System.Windows.Forms.Label l_Workpost;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ToolTip toolTip;
    }
}