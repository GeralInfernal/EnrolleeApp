namespace EnrolleeApp
{
    partial class Form_Add_Spec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Spec));
            this.tbShifr = new System.Windows.Forms.TextBox();
            this.l_ParentFIO = new System.Windows.Forms.Label();
            this.tbSpecName = new System.Windows.Forms.TextBox();
            this.l_adrreg = new System.Windows.Forms.Label();
            this.tbSpecAbbr = new System.Windows.Forms.TextBox();
            this.l_AdrFact = new System.Windows.Forms.Label();
            this.l_Workpost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.cbDiscipline1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDiscipline2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDiscipline3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOchn = new System.Windows.Forms.ComboBox();
            this.cbBudjet = new System.Windows.Forms.ComboBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbShifr
            // 
            this.tbShifr.Location = new System.Drawing.Point(123, 14);
            this.tbShifr.Name = "tbShifr";
            this.tbShifr.Size = new System.Drawing.Size(324, 20);
            this.tbShifr.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbShifr, "Шифр специальности");
            // 
            // l_ParentFIO
            // 
            this.l_ParentFIO.AutoSize = true;
            this.l_ParentFIO.Location = new System.Drawing.Point(15, 17);
            this.l_ParentFIO.Name = "l_ParentFIO";
            this.l_ParentFIO.Size = new System.Drawing.Size(36, 13);
            this.l_ParentFIO.TabIndex = 42;
            this.l_ParentFIO.Text = "Шифр";
            // 
            // tbSpecName
            // 
            this.tbSpecName.Location = new System.Drawing.Point(123, 40);
            this.tbSpecName.Name = "tbSpecName";
            this.tbSpecName.Size = new System.Drawing.Size(324, 20);
            this.tbSpecName.TabIndex = 45;
            this.toolTip.SetToolTip(this.tbSpecName, "Название квалификации по специальности");
            // 
            // l_adrreg
            // 
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(15, 43);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(82, 13);
            this.l_adrreg.TabIndex = 44;
            this.l_adrreg.Text = "Квалификация";
            // 
            // tbSpecAbbr
            // 
            this.tbSpecAbbr.Location = new System.Drawing.Point(123, 93);
            this.tbSpecAbbr.Name = "tbSpecAbbr";
            this.tbSpecAbbr.Size = new System.Drawing.Size(324, 20);
            this.tbSpecAbbr.TabIndex = 47;
            this.toolTip.SetToolTip(this.tbSpecAbbr, "Аббревиатура специальности");
            // 
            // l_AdrFact
            // 
            this.l_AdrFact.AutoSize = true;
            this.l_AdrFact.Location = new System.Drawing.Point(15, 96);
            this.l_AdrFact.Name = "l_AdrFact";
            this.l_AdrFact.Size = new System.Drawing.Size(78, 13);
            this.l_AdrFact.TabIndex = 46;
            this.l_AdrFact.Text = "Аббревеатура";
            // 
            // l_Workpost
            // 
            this.l_Workpost.AutoSize = true;
            this.l_Workpost.Location = new System.Drawing.Point(15, 122);
            this.l_Workpost.Name = "l_Workpost";
            this.l_Workpost.Size = new System.Drawing.Size(93, 13);
            this.l_Workpost.TabIndex = 48;
            this.l_Workpost.Text = "Форма обучения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Основа обучения";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Добавить";
            this.toolTip.SetToolTip(this.btnAdd, "Добавить указанную специальность");
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
            // cbDiscipline1
            // 
            this.cbDiscipline1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscipline1.FormattingEnabled = true;
            this.cbDiscipline1.Location = new System.Drawing.Point(174, 171);
            this.cbDiscipline1.Name = "cbDiscipline1";
            this.cbDiscipline1.Size = new System.Drawing.Size(273, 21);
            this.cbDiscipline1.TabIndex = 75;
            this.toolTip.SetToolTip(this.cbDiscipline1, "Первая ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Первая ведущая дисциплина";
            // 
            // cbDiscipline2
            // 
            this.cbDiscipline2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscipline2.FormattingEnabled = true;
            this.cbDiscipline2.Location = new System.Drawing.Point(174, 198);
            this.cbDiscipline2.Name = "cbDiscipline2";
            this.cbDiscipline2.Size = new System.Drawing.Size(273, 21);
            this.cbDiscipline2.TabIndex = 77;
            this.toolTip.SetToolTip(this.cbDiscipline2, "Вторая ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Вторая ведущая дисциплина";
            // 
            // cbDiscipline3
            // 
            this.cbDiscipline3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscipline3.FormattingEnabled = true;
            this.cbDiscipline3.Location = new System.Drawing.Point(174, 225);
            this.cbDiscipline3.Name = "cbDiscipline3";
            this.cbDiscipline3.Size = new System.Drawing.Size(273, 21);
            this.cbDiscipline3.TabIndex = 79;
            this.toolTip.SetToolTip(this.cbDiscipline3, "Третья ведущая дисциплина, важная в принятии решения о зачислении абитуриентов на" +
        " специальность");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Третья ведущая дисциплина";
            // 
            // cbOchn
            // 
            this.cbOchn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOchn.FormattingEnabled = true;
            this.cbOchn.Items.AddRange(new object[] {
            "Очная",
            "Заочная"});
            this.cbOchn.Location = new System.Drawing.Point(123, 119);
            this.cbOchn.Name = "cbOchn";
            this.cbOchn.Size = new System.Drawing.Size(324, 21);
            this.cbOchn.TabIndex = 82;
            this.toolTip.SetToolTip(this.cbOchn, "Форма обучения на специальности");
            // 
            // cbBudjet
            // 
            this.cbBudjet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBudjet.FormattingEnabled = true;
            this.cbBudjet.Items.AddRange(new object[] {
            "Бюджетная",
            "Платная"});
            this.cbBudjet.Location = new System.Drawing.Point(123, 145);
            this.cbBudjet.Name = "cbBudjet";
            this.cbBudjet.Size = new System.Drawing.Size(324, 21);
            this.cbBudjet.TabIndex = 83;
            this.toolTip.SetToolTip(this.cbBudjet, "Основа обучения на специальности");
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(123, 66);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(324, 20);
            this.tbTitle.TabIndex = 85;
            this.toolTip.SetToolTip(this.tbTitle, "Название специальности");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Название";
            // 
            // Form_Add_Spec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 307);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBudjet);
            this.Controls.Add(this.cbOchn);
            this.Controls.Add(this.cbDiscipline3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDiscipline2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDiscipline1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_Workpost);
            this.Controls.Add(this.tbSpecAbbr);
            this.Controls.Add(this.l_AdrFact);
            this.Controls.Add(this.tbSpecName);
            this.Controls.Add(this.l_adrreg);
            this.Controls.Add(this.tbShifr);
            this.Controls.Add(this.l_ParentFIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Spec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить специальность";
            this.Load += new System.EventHandler(this.Form_AddParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbShifr;
        private System.Windows.Forms.Label l_ParentFIO;
        private System.Windows.Forms.TextBox tbSpecName;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.TextBox tbSpecAbbr;
        private System.Windows.Forms.Label l_AdrFact;
        private System.Windows.Forms.Label l_Workpost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ComboBox cbDiscipline3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDiscipline2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDiscipline1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBudjet;
        private System.Windows.Forms.ComboBox cbOchn;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip;
    }
}