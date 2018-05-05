namespace EnrolleeApp
{
    partial class Form_Add_Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Groups));
            this.cbSpec = new System.Windows.Forms.ComboBox();
            this.l_Abit = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.l_ParentFIO = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.l_adrreg = new System.Windows.Forms.Label();
            this.tbStudents = new System.Windows.Forms.TextBox();
            this.l_AdrFact = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAbit
            // 
            this.cbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Location = new System.Drawing.Point(138, 38);
            this.cbSpec.Name = "cbAbit";
            this.cbSpec.Size = new System.Drawing.Size(216, 21);
            this.cbSpec.TabIndex = 40;
            this.toolTip.SetToolTip(this.cbSpec, "Специальность, на которую производится зачисление");
            // 
            // l_Abit
            // 
            this.l_Abit.AutoSize = true;
            this.l_Abit.Location = new System.Drawing.Point(12, 41);
            this.l_Abit.Name = "l_Abit";
            this.l_Abit.Size = new System.Drawing.Size(85, 13);
            this.l_Abit.TabIndex = 39;
            this.l_Abit.Text = "Специальность";
            // 
            // tbParentFIO
            // 
            this.tbName.Location = new System.Drawing.Point(138, 12);
            this.tbName.Name = "tbParentFIO";
            this.tbName.Size = new System.Drawing.Size(216, 20);
            this.tbName.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbName, "Название формируемой группы");
            // 
            // l_ParentFIO
            // 
            this.l_ParentFIO.AutoSize = true;
            this.l_ParentFIO.Location = new System.Drawing.Point(12, 15);
            this.l_ParentFIO.Name = "l_ParentFIO";
            this.l_ParentFIO.Size = new System.Drawing.Size(57, 13);
            this.l_ParentFIO.TabIndex = 42;
            this.l_ParentFIO.Text = "Название";
            // 
            // tbAdrReg
            // 
            this.tbYear.Location = new System.Drawing.Point(138, 65);
            this.tbYear.Name = "tbAdrReg";
            this.tbYear.Size = new System.Drawing.Size(216, 20);
            this.tbYear.TabIndex = 45;
            this.toolTip.SetToolTip(this.tbYear, "Год формирования группы ( набор в группу осуществляется только на текущий год)");
            // 
            // l_adrreg
            // 
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(12, 68);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(104, 13);
            this.l_adrreg.TabIndex = 44;
            this.l_adrreg.Text = "Год формирования";
            // 
            // tbAdrFact
            // 
            this.tbStudents.Location = new System.Drawing.Point(138, 91);
            this.tbStudents.Name = "tbAdrFact";
            this.tbStudents.Size = new System.Drawing.Size(216, 20);
            this.tbStudents.TabIndex = 47;
            this.toolTip.SetToolTip(this.tbStudents, "Количество студентов в группе");
            // 
            // l_AdrFact
            // 
            this.l_AdrFact.AutoSize = true;
            this.l_AdrFact.Location = new System.Drawing.Point(12, 94);
            this.l_AdrFact.Name = "l_AdrFact";
            this.l_AdrFact.Size = new System.Drawing.Size(120, 13);
            this.l_AdrFact.TabIndex = 46;
            this.l_AdrFact.Text = "Количество студентов";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Добавить";
            this.toolTip.SetToolTip(this.btnAdd, "Добавить указанную группу");
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
            // Form_Add_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 178);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbStudents);
            this.Controls.Add(this.l_AdrFact);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.l_adrreg);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.l_ParentFIO);
            this.Controls.Add(this.cbSpec);
            this.Controls.Add(this.l_Abit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить группу";
            this.Load += new System.EventHandler(this.Form_AddParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSpec;
        private System.Windows.Forms.Label l_Abit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label l_ParentFIO;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.TextBox tbStudents;
        private System.Windows.Forms.Label l_AdrFact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ToolTip toolTip;
    }
}