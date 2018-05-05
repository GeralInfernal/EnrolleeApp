namespace EnrolleeApp
{
    partial class Form_Delete_Spec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete_Spec));
            this.tbShifr = new System.Windows.Forms.TextBox();
            this.l_ParentFIO = new System.Windows.Forms.Label();
            this.tbSpecName = new System.Windows.Forms.TextBox();
            this.l_adrreg = new System.Windows.Forms.Label();
            this.tbShort = new System.Windows.Forms.TextBox();
            this.l_AdrFact = new System.Windows.Forms.Label();
            this.l_Workpost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.tbDiscipline1 = new System.Windows.Forms.TextBox();
            this.tbDiscipline2 = new System.Windows.Forms.TextBox();
            this.tbDiscipline3 = new System.Windows.Forms.TextBox();
            this.tbOchn = new System.Windows.Forms.TextBox();
            this.tbBudjet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbShifr
            // 
            this.tbShifr.Location = new System.Drawing.Point(122, 73);
            this.tbShifr.Name = "tbShifr";
            this.tbShifr.ReadOnly = true;
            this.tbShifr.Size = new System.Drawing.Size(290, 20);
            this.tbShifr.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbShifr, "Шифр специальности");
            // 
            // l_ParentFIO
            // 
            this.l_ParentFIO.AutoSize = true;
            this.l_ParentFIO.Location = new System.Drawing.Point(14, 76);
            this.l_ParentFIO.Name = "l_ParentFIO";
            this.l_ParentFIO.Size = new System.Drawing.Size(36, 13);
            this.l_ParentFIO.TabIndex = 42;
            this.l_ParentFIO.Text = "Шифр";
            // 
            // tbSpecName
            // 
            this.tbSpecName.Location = new System.Drawing.Point(122, 99);
            this.tbSpecName.Name = "tbSpecName";
            this.tbSpecName.ReadOnly = true;
            this.tbSpecName.Size = new System.Drawing.Size(290, 20);
            this.tbSpecName.TabIndex = 45;
            this.toolTip.SetToolTip(this.tbSpecName, "Название квалификации по специальности");
            // 
            // l_adrreg
            // 
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(14, 102);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(82, 13);
            this.l_adrreg.TabIndex = 44;
            this.l_adrreg.Text = "Квалификация";
            // 
            // tbShort
            // 
            this.tbShort.Location = new System.Drawing.Point(122, 152);
            this.tbShort.Name = "tbShort";
            this.tbShort.ReadOnly = true;
            this.tbShort.Size = new System.Drawing.Size(290, 20);
            this.tbShort.TabIndex = 47;
            this.toolTip.SetToolTip(this.tbShort, "Аббревиатура специальности");
            // 
            // l_AdrFact
            // 
            this.l_AdrFact.AutoSize = true;
            this.l_AdrFact.Location = new System.Drawing.Point(14, 155);
            this.l_AdrFact.Name = "l_AdrFact";
            this.l_AdrFact.Size = new System.Drawing.Size(78, 13);
            this.l_AdrFact.TabIndex = 46;
            this.l_AdrFact.Text = "Аббревеатура";
            // 
            // l_Workpost
            // 
            this.l_Workpost.AutoSize = true;
            this.l_Workpost.Location = new System.Drawing.Point(14, 181);
            this.l_Workpost.Name = "l_Workpost";
            this.l_Workpost.Size = new System.Drawing.Size(93, 13);
            this.l_Workpost.TabIndex = 48;
            this.l_Workpost.Text = "Форма обучения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Основа обучения";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 72;
            this.btnDelete.Text = "Удалить";
            this.toolTip.SetToolTip(this.btnDelete, "Удалить указанную специальность");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnAdd_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Первая ведущая дисциплина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Вторая ведущая дисциплина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Третья ведущая дисциплина";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(122, 125);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(290, 20);
            this.tbTitle.TabIndex = 85;
            this.toolTip.SetToolTip(this.tbTitle, "Название специальности");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Название";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(122, 47);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(290, 20);
            this.tbID.TabIndex = 87;
            this.toolTip.SetToolTip(this.tbID, "Шифр специальности");
            // 
            // cbTitle
            // 
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(122, 12);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(290, 21);
            this.cbTitle.TabIndex = 89;
            this.toolTip.SetToolTip(this.cbTitle, "Форма обучения на специальности");
            this.cbTitle.SelectedIndexChanged += new System.EventHandler(this.cbSpecName_SelectedIndexChanged);
            // 
            // tbDiscipline1
            // 
            this.tbDiscipline1.Location = new System.Drawing.Point(175, 230);
            this.tbDiscipline1.Name = "tbDiscipline1";
            this.tbDiscipline1.ReadOnly = true;
            this.tbDiscipline1.Size = new System.Drawing.Size(237, 20);
            this.tbDiscipline1.TabIndex = 90;
            this.toolTip.SetToolTip(this.tbDiscipline1, "Первая ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // tbDiscipline2
            // 
            this.tbDiscipline2.Location = new System.Drawing.Point(175, 257);
            this.tbDiscipline2.Name = "tbDiscipline2";
            this.tbDiscipline2.ReadOnly = true;
            this.tbDiscipline2.Size = new System.Drawing.Size(237, 20);
            this.tbDiscipline2.TabIndex = 91;
            this.toolTip.SetToolTip(this.tbDiscipline2, "Вторая ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // tbDiscipline3
            // 
            this.tbDiscipline3.Location = new System.Drawing.Point(175, 284);
            this.tbDiscipline3.Name = "tbDiscipline3";
            this.tbDiscipline3.ReadOnly = true;
            this.tbDiscipline3.Size = new System.Drawing.Size(237, 20);
            this.tbDiscipline3.TabIndex = 92;
            this.toolTip.SetToolTip(this.tbDiscipline3, "Третья ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // tbOchn
            // 
            this.tbOchn.Location = new System.Drawing.Point(122, 178);
            this.tbOchn.Name = "tbOchn";
            this.tbOchn.ReadOnly = true;
            this.tbOchn.Size = new System.Drawing.Size(290, 20);
            this.tbOchn.TabIndex = 93;
            this.toolTip.SetToolTip(this.tbOchn, "Форма обучения на специальности");
            // 
            // tbBudjet
            // 
            this.tbBudjet.Location = new System.Drawing.Point(122, 204);
            this.tbBudjet.Name = "tbBudjet";
            this.tbBudjet.ReadOnly = true;
            this.tbBudjet.Size = new System.Drawing.Size(290, 20);
            this.tbBudjet.TabIndex = 94;
            this.toolTip.SetToolTip(this.tbBudjet, "Основа обучения на специальности");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Идентификатор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Название";
            // 
            // Form_Delete_Spec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 370);
            this.Controls.Add(this.tbBudjet);
            this.Controls.Add(this.tbOchn);
            this.Controls.Add(this.tbDiscipline3);
            this.Controls.Add(this.tbDiscipline2);
            this.Controls.Add(this.tbDiscipline1);
            this.Controls.Add(this.cbTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_Workpost);
            this.Controls.Add(this.tbShort);
            this.Controls.Add(this.l_AdrFact);
            this.Controls.Add(this.tbSpecName);
            this.Controls.Add(this.l_adrreg);
            this.Controls.Add(this.tbShifr);
            this.Controls.Add(this.l_ParentFIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Delete_Spec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить специальность";
            this.Load += new System.EventHandler(this.Form_Delete_Spec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbShifr;
        private System.Windows.Forms.Label l_ParentFIO;
        private System.Windows.Forms.TextBox tbSpecName;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.TextBox tbShort;
        private System.Windows.Forms.Label l_AdrFact;
        private System.Windows.Forms.Label l_Workpost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBudjet;
        private System.Windows.Forms.TextBox tbOchn;
        private System.Windows.Forms.TextBox tbDiscipline3;
        private System.Windows.Forms.TextBox tbDiscipline2;
        private System.Windows.Forms.TextBox tbDiscipline1;
    }
}