namespace EnrolleeApp
{
    partial class Form_Delete_Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete_Parent));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWorkpost = new System.Windows.Forms.TextBox();
            this.l_Workpost = new System.Windows.Forms.Label();
            this.tbAdrFact = new System.Windows.Forms.TextBox();
            this.l_AdrFact = new System.Windows.Forms.Label();
            this.tbAdrReg = new System.Windows.Forms.TextBox();
            this.l_adrreg = new System.Windows.Forms.Label();
            this.tbParentFIO = new System.Windows.Forms.TextBox();
            this.l_ParentFIO = new System.Windows.Forms.Label();
            this.l_Abit = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.cbParent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbAbit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(159, 231);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 40);
            this.btnConfirm.TabIndex = 86;
            this.btnConfirm.Text = "Удалить родителя";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(120, 202);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(294, 20);
            this.tbPhone.TabIndex = 85;
            this.toolTip.SetToolTip(this.tbPhone, "Номер телефона родителя");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Телефон";
            // 
            // tbWorkpost
            // 
            this.tbWorkpost.Location = new System.Drawing.Point(120, 176);
            this.tbWorkpost.Name = "tbWorkpost";
            this.tbWorkpost.ReadOnly = true;
            this.tbWorkpost.Size = new System.Drawing.Size(294, 20);
            this.tbWorkpost.TabIndex = 83;
            this.toolTip.SetToolTip(this.tbWorkpost, "Место работы и занимаимая должность родителя, если есть");
            // 
            // l_Workpost
            // 
            this.l_Workpost.AutoSize = true;
            this.l_Workpost.Location = new System.Drawing.Point(12, 179);
            this.l_Workpost.Name = "l_Workpost";
            this.l_Workpost.Size = new System.Drawing.Size(79, 13);
            this.l_Workpost.TabIndex = 82;
            this.l_Workpost.Text = "Место работы";
            // 
            // tbAdrFact
            // 
            this.tbAdrFact.Location = new System.Drawing.Point(120, 150);
            this.tbAdrFact.Name = "tbAdrFact";
            this.tbAdrFact.ReadOnly = true;
            this.tbAdrFact.Size = new System.Drawing.Size(294, 20);
            this.tbAdrFact.TabIndex = 81;
            this.toolTip.SetToolTip(this.tbAdrFact, "Адрес проживания родителя");
            // 
            // l_AdrFact
            // 
            this.l_AdrFact.AutoSize = true;
            this.l_AdrFact.Location = new System.Drawing.Point(12, 153);
            this.l_AdrFact.Name = "l_AdrFact";
            this.l_AdrFact.Size = new System.Drawing.Size(103, 13);
            this.l_AdrFact.TabIndex = 80;
            this.l_AdrFact.Text = "Адрес проживания";
            // 
            // tbAdrReg
            // 
            this.tbAdrReg.Location = new System.Drawing.Point(120, 124);
            this.tbAdrReg.Name = "tbAdrReg";
            this.tbAdrReg.ReadOnly = true;
            this.tbAdrReg.Size = new System.Drawing.Size(294, 20);
            this.tbAdrReg.TabIndex = 79;
            this.toolTip.SetToolTip(this.tbAdrReg, "Адрес регистрации родителя");
            // 
            // l_adrreg
            // 
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(12, 127);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(105, 13);
            this.l_adrreg.TabIndex = 78;
            this.l_adrreg.Text = "Адрес регистрации";
            // 
            // tbParentFIO
            // 
            this.tbParentFIO.Location = new System.Drawing.Point(120, 98);
            this.tbParentFIO.Name = "tbParentFIO";
            this.tbParentFIO.ReadOnly = true;
            this.tbParentFIO.Size = new System.Drawing.Size(294, 20);
            this.tbParentFIO.TabIndex = 77;
            this.toolTip.SetToolTip(this.tbParentFIO, "ФИО родителя");
            // 
            // l_ParentFIO
            // 
            this.l_ParentFIO.AutoSize = true;
            this.l_ParentFIO.Location = new System.Drawing.Point(12, 101);
            this.l_ParentFIO.Name = "l_ParentFIO";
            this.l_ParentFIO.Size = new System.Drawing.Size(34, 13);
            this.l_ParentFIO.TabIndex = 76;
            this.l_ParentFIO.Text = "ФИО";
            // 
            // l_Abit
            // 
            this.l_Abit.AutoSize = true;
            this.l_Abit.Location = new System.Drawing.Point(12, 74);
            this.l_Abit.Name = "l_Abit";
            this.l_Abit.Size = new System.Drawing.Size(65, 13);
            this.l_Abit.TabIndex = 74;
            this.l_Abit.Text = "Абитуриент";
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
            // cbParent
            // 
            this.cbParent.FormattingEnabled = true;
            this.cbParent.Location = new System.Drawing.Point(120, 6);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(294, 21);
            this.cbParent.TabIndex = 89;
            this.toolTip.SetToolTip(this.cbParent, "ФИО родителя, которого необходимо удалить");
            this.cbParent.SelectedIndexChanged += new System.EventHandler(this.cbParent_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "ФИО";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(120, 45);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(294, 20);
            this.tbID.TabIndex = 91;
            this.toolTip.SetToolTip(this.tbID, "Идентификатор записи о родителе");
            // 
            // tbAbit
            // 
            this.tbAbit.Location = new System.Drawing.Point(120, 71);
            this.tbAbit.Name = "tbAbit";
            this.tbAbit.ReadOnly = true;
            this.tbAbit.Size = new System.Drawing.Size(294, 20);
            this.tbAbit.TabIndex = 92;
            this.toolTip.SetToolTip(this.tbAbit, "Идентификатор записи о родителе");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Идентификатор";
            // 
            // Form_Delete_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(437, 283);
            this.Controls.Add(this.tbAbit);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbParent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
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
            this.Controls.Add(this.l_Abit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Delete_Parent";
            this.Text = "Удалить родителя";
            this.Load += new System.EventHandler(this.Form_Change_Parent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWorkpost;
        private System.Windows.Forms.Label l_Workpost;
        private System.Windows.Forms.TextBox tbAdrFact;
        private System.Windows.Forms.Label l_AdrFact;
        private System.Windows.Forms.TextBox tbAdrReg;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.TextBox tbParentFIO;
        private System.Windows.Forms.Label l_ParentFIO;
        private System.Windows.Forms.Label l_Abit;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cbParent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAbit;
    }
}