namespace EnrolleeApp
{
    partial class Form_Delete_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete_Status));
            this.l_Abit = new System.Windows.Forms.Label();
            this.tbStatusType = new System.Windows.Forms.TextBox();
            this.l_StatusType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.tbDocinform = new System.Windows.Forms.TextBox();
            this.l_Docinform = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbChangingAbit = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbChangingStatus = new System.Windows.Forms.ComboBox();
            this.tbAbit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Abit
            // 
            this.l_Abit.AutoSize = true;
            this.l_Abit.Location = new System.Drawing.Point(12, 116);
            this.l_Abit.Name = "l_Abit";
            this.l_Abit.Size = new System.Drawing.Size(65, 13);
            this.l_Abit.TabIndex = 39;
            this.l_Abit.Text = "Абитуриент";
            // 
            // tbStatusType
            // 
            this.tbStatusType.Location = new System.Drawing.Point(120, 140);
            this.tbStatusType.Name = "tbStatusType";
            this.tbStatusType.ReadOnly = true;
            this.tbStatusType.Size = new System.Drawing.Size(220, 20);
            this.tbStatusType.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbStatusType, "Тип статуса, подтверждаемый предоставленным абитуриентом документом");
            // 
            // l_StatusType
            // 
            this.l_StatusType.AutoSize = true;
            this.l_StatusType.Location = new System.Drawing.Point(12, 143);
            this.l_StatusType.Name = "l_StatusType";
            this.l_StatusType.Size = new System.Drawing.Size(68, 13);
            this.l_StatusType.TabIndex = 42;
            this.l_StatusType.Text = "Тип статуса";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Удалить статус";
            this.toolTip.SetToolTip(this.btnAdd, "Удалить данный статус");
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
            // tbDocinform
            // 
            this.tbDocinform.Location = new System.Drawing.Point(12, 188);
            this.tbDocinform.Multiline = true;
            this.tbDocinform.Name = "tbDocinform";
            this.tbDocinform.ReadOnly = true;
            this.tbDocinform.Size = new System.Drawing.Size(328, 80);
            this.tbDocinform.TabIndex = 74;
            this.toolTip.SetToolTip(this.tbDocinform, "Информация из предоставленного абитуриентом документа, подтверждающего статус");
            // 
            // l_Docinform
            // 
            this.l_Docinform.AutoSize = true;
            this.l_Docinform.Location = new System.Drawing.Point(12, 172);
            this.l_Docinform.Name = "l_Docinform";
            this.l_Docinform.Size = new System.Drawing.Size(145, 13);
            this.l_Docinform.TabIndex = 75;
            this.l_Docinform.Text = "Информация из документа";
            // 
            // cbChangingAbit
            // 
            this.cbChangingAbit.FormattingEnabled = true;
            this.cbChangingAbit.Location = new System.Drawing.Point(120, 12);
            this.cbChangingAbit.Name = "cbChangingAbit";
            this.cbChangingAbit.Size = new System.Drawing.Size(220, 21);
            this.cbChangingAbit.TabIndex = 77;
            this.toolTip.SetToolTip(this.cbChangingAbit, "Абитуриент, для которого требуется удалить статус");
            this.cbChangingAbit.SelectedIndexChanged += new System.EventHandler(this.cbChangingAbit_SelectedIndexChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(120, 87);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(220, 20);
            this.tbID.TabIndex = 79;
            this.toolTip.SetToolTip(this.tbID, "Идентификатор статуса");
            // 
            // cbChangingStatus
            // 
            this.cbChangingStatus.FormattingEnabled = true;
            this.cbChangingStatus.Location = new System.Drawing.Point(120, 39);
            this.cbChangingStatus.Name = "cbChangingStatus";
            this.cbChangingStatus.Size = new System.Drawing.Size(220, 21);
            this.cbChangingStatus.TabIndex = 81;
            this.toolTip.SetToolTip(this.cbChangingStatus, "Статус, имеющийся у выбранного абитуриента");
            this.cbChangingStatus.SelectedIndexChanged += new System.EventHandler(this.cbChangingStatus_SelectedIndexChanged);
            // 
            // tbAbit
            // 
            this.tbAbit.Location = new System.Drawing.Point(120, 113);
            this.tbAbit.Name = "tbAbit";
            this.tbAbit.ReadOnly = true;
            this.tbAbit.Size = new System.Drawing.Size(220, 20);
            this.tbAbit.TabIndex = 82;
            this.toolTip.SetToolTip(this.tbAbit, "Тип статуса, подтверждаемый предоставленным абитуриентом документом");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Абитуриент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Идентификатор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Тип статуса";
            // 
            // Form_Delete_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 333);
            this.Controls.Add(this.tbAbit);
            this.Controls.Add(this.cbChangingStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChangingAbit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_Docinform);
            this.Controls.Add(this.tbDocinform);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbStatusType);
            this.Controls.Add(this.l_StatusType);
            this.Controls.Add(this.l_Abit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Delete_Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить статус абитуриента";
            this.Load += new System.EventHandler(this.Form_Add_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_Abit;
        private System.Windows.Forms.TextBox tbStatusType;
        private System.Windows.Forms.Label l_StatusType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.Label l_Docinform;
        private System.Windows.Forms.TextBox tbDocinform;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbChangingAbit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChangingStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAbit;
    }
}