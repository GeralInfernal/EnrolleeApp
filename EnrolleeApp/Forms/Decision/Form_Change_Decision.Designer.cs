namespace EnrolleeApp
{
    partial class Form_Update_Decision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update_Decision));
            this.tbResolution = new System.Windows.Forms.TextBox();
            this.l_ParentFIO = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.l_adrreg = new System.Windows.Forms.Label();
            this.l_AdrFact = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.cbAbit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKomis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbResolution
            // 
            this.tbResolution.Location = new System.Drawing.Point(107, 99);
            this.tbResolution.Name = "tbResolution";
            this.tbResolution.Size = new System.Drawing.Size(220, 20);
            this.tbResolution.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbResolution, "Решение комиссии");
            // 
            // l_ParentFIO
            // 
            this.l_ParentFIO.AutoSize = true;
            this.l_ParentFIO.Location = new System.Drawing.Point(14, 102);
            this.l_ParentFIO.Name = "l_ParentFIO";
            this.l_ParentFIO.Size = new System.Drawing.Size(52, 13);
            this.l_ParentFIO.TabIndex = 42;
            this.l_ParentFIO.Text = "Решение";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(107, 125);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(220, 62);
            this.tbComment.TabIndex = 45;
            this.toolTip.SetToolTip(this.tbComment, "Комментарий к решению комиссии");
            // 
            // l_adrreg
            // 
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(14, 128);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(77, 13);
            this.l_adrreg.TabIndex = 44;
            this.l_adrreg.Text = "Комментарий";
            // 
            // l_AdrFact
            // 
            this.l_AdrFact.AutoSize = true;
            this.l_AdrFact.Location = new System.Drawing.Point(14, 223);
            this.l_AdrFact.Name = "l_AdrFact";
            this.l_AdrFact.Size = new System.Drawing.Size(86, 13);
            this.l_AdrFact.TabIndex = 46;
            this.l_AdrFact.Text = "Член комиссии";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Изменить";
            this.toolTip.SetToolTip(this.btnUpdate, "Изменить решение комиссии");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
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
            // cbAbit
            // 
            this.cbAbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbit.FormattingEnabled = true;
            this.cbAbit.Location = new System.Drawing.Point(107, 12);
            this.cbAbit.Name = "cbAbit";
            this.cbAbit.Size = new System.Drawing.Size(220, 21);
            this.cbAbit.TabIndex = 75;
            this.toolTip.SetToolTip(this.cbAbit, "Абитурьент, для которого требуется изменить решение");
            this.cbAbit.SelectedIndexChanged += new System.EventHandler(this.cbAbit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Абитуриент";
            // 
            // cbKomis
            // 
            this.cbKomis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKomis.FormattingEnabled = true;
            this.cbKomis.Location = new System.Drawing.Point(107, 220);
            this.cbKomis.Name = "cbKomis";
            this.cbKomis.Size = new System.Drawing.Size(220, 21);
            this.cbKomis.TabIndex = 77;
            this.toolTip.SetToolTip(this.cbKomis, "Член комиссии");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Дата";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(107, 194);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(220, 20);
            this.dtpDate.TabIndex = 85;
            this.toolTip.SetToolTip(this.dtpDate, "Дата принятия решения");
            this.dtpDate.Value = new System.DateTime(2017, 5, 27, 22, 41, 3, 0);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(107, 46);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(220, 20);
            this.tbID.TabIndex = 86;
            this.toolTip.SetToolTip(this.tbID, "Идентификатор решения комиссии");
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(107, 72);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(220, 21);
            this.cbGroup.TabIndex = 89;
            this.toolTip.SetToolTip(this.cbGroup, "Группа, в которую производится зачисление абитуриента");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Идентификатор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Группа";
            // 
            // Form_Update_Decision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 309);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKomis);
            this.Controls.Add(this.cbAbit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.l_AdrFact);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.l_adrreg);
            this.Controls.Add(this.tbResolution);
            this.Controls.Add(this.l_ParentFIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Update_Decision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить решение комиссии";
            this.Load += new System.EventHandler(this.Form_Change_Decision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbResolution;
        private System.Windows.Forms.Label l_ParentFIO;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.Label l_AdrFact;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ComboBox cbKomis;
        private System.Windows.Forms.ComboBox cbAbit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label3;
    }
}