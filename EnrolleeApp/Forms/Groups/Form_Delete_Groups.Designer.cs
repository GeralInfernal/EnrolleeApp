namespace EnrolleeApp
{
    partial class Form_Delete_Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete_Groups));
            this.l_Abit = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.l_ParentFIO = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.l_adrreg = new System.Windows.Forms.Label();
            this.tbStudents = new System.Windows.Forms.TextBox();
            this.l_AdrFact = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Abit
            // 
            this.l_Abit.AutoSize = true;
            this.l_Abit.Location = new System.Drawing.Point(12, 110);
            this.l_Abit.Name = "l_Abit";
            this.l_Abit.Size = new System.Drawing.Size(85, 13);
            this.l_Abit.TabIndex = 39;
            this.l_Abit.Text = "Специальность";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(138, 81);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(216, 20);
            this.tbName.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbName, "Название группы");
            // 
            // l_ParentFIO
            // 
            this.l_ParentFIO.AutoSize = true;
            this.l_ParentFIO.Location = new System.Drawing.Point(12, 84);
            this.l_ParentFIO.Name = "l_ParentFIO";
            this.l_ParentFIO.Size = new System.Drawing.Size(57, 13);
            this.l_ParentFIO.TabIndex = 42;
            this.l_ParentFIO.Text = "Название";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(138, 134);
            this.tbYear.Name = "tbYear";
            this.tbYear.ReadOnly = true;
            this.tbYear.Size = new System.Drawing.Size(216, 20);
            this.tbYear.TabIndex = 45;
            this.toolTip.SetToolTip(this.tbYear, "Год формирования группы ( набор в группу осуществляется только на текущий год)");
            // 
            // l_adrreg
            // 
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(12, 137);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(104, 13);
            this.l_adrreg.TabIndex = 44;
            this.l_adrreg.Text = "Год формирования";
            // 
            // tbStudents
            // 
            this.tbStudents.Location = new System.Drawing.Point(138, 160);
            this.tbStudents.Name = "tbStudents";
            this.tbStudents.ReadOnly = true;
            this.tbStudents.Size = new System.Drawing.Size(216, 20);
            this.tbStudents.TabIndex = 47;
            this.toolTip.SetToolTip(this.tbStudents, "Количество студентов в группе");
            // 
            // l_AdrFact
            // 
            this.l_AdrFact.AutoSize = true;
            this.l_AdrFact.Location = new System.Drawing.Point(12, 163);
            this.l_AdrFact.Name = "l_AdrFact";
            this.l_AdrFact.Size = new System.Drawing.Size(120, 13);
            this.l_AdrFact.TabIndex = 46;
            this.l_AdrFact.Text = "Количество студентов";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(124, 195);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(120, 40);
            this.btnChange.TabIndex = 72;
            this.btnChange.Text = "Удалить";
            this.toolTip.SetToolTip(this.btnChange, "Удалить указанную группу");
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnAdd_Click);
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
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(138, 55);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(216, 20);
            this.tbID.TabIndex = 74;
            this.toolTip.SetToolTip(this.tbID, "Идентификатор группы");
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(138, 12);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(216, 21);
            this.cbGroup.TabIndex = 76;
            this.toolTip.SetToolTip(this.cbGroup, "Группа, которую требуется удалить");
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // tbSpec
            // 
            this.tbSpec.Location = new System.Drawing.Point(138, 107);
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.ReadOnly = true;
            this.tbSpec.Size = new System.Drawing.Size(216, 20);
            this.tbSpec.TabIndex = 77;
            this.toolTip.SetToolTip(this.tbSpec, "Специальность, на которой обучается группа");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Идентификатор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Группа";
            // 
            // Form_Delete_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 246);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbStudents);
            this.Controls.Add(this.l_AdrFact);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.l_adrreg);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.l_ParentFIO);
            this.Controls.Add(this.l_Abit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Delete_Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить группу";
            this.Load += new System.EventHandler(this.Form_AddParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_Abit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label l_ParentFIO;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.TextBox tbStudents;
        private System.Windows.Forms.Label l_AdrFact;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpec;
    }
}