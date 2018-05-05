namespace EnrolleeApp
{
    partial class Form_Add_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Status));
            this.cbAbit = new System.Windows.Forms.ComboBox();
            this.l_Abit = new System.Windows.Forms.Label();
            this.tbStatusType = new System.Windows.Forms.TextBox();
            this.l_StatusType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.tbDocinform = new System.Windows.Forms.TextBox();
            this.l_Docinform = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAbit
            // 
            this.cbAbit.FormattingEnabled = true;
            this.cbAbit.Location = new System.Drawing.Point(120, 6);
            this.cbAbit.Name = "cbAbit";
            this.cbAbit.Size = new System.Drawing.Size(220, 21);
            this.cbAbit.TabIndex = 40;
            this.toolTip.SetToolTip(this.cbAbit, "Абитуриент, для которого требуется установить статус");
            // 
            // l_Abit
            // 
            this.l_Abit.AutoSize = true;
            this.l_Abit.Location = new System.Drawing.Point(12, 9);
            this.l_Abit.Name = "l_Abit";
            this.l_Abit.Size = new System.Drawing.Size(65, 13);
            this.l_Abit.TabIndex = 39;
            this.l_Abit.Text = "Абитуриент";
            // 
            // tbStatusType
            // 
            this.tbStatusType.Location = new System.Drawing.Point(120, 33);
            this.tbStatusType.Name = "tbStatusType";
            this.tbStatusType.Size = new System.Drawing.Size(220, 20);
            this.tbStatusType.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbStatusType, "Тип статуса, подтверждаемый предоставленным абитуриентом документом");
            // 
            // l_StatusType
            // 
            this.l_StatusType.AutoSize = true;
            this.l_StatusType.Location = new System.Drawing.Point(12, 36);
            this.l_StatusType.Name = "l_StatusType";
            this.l_StatusType.Size = new System.Drawing.Size(68, 13);
            this.l_StatusType.TabIndex = 42;
            this.l_StatusType.Text = "Тип статуса";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Добавить";
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
            this.tbDocinform.Location = new System.Drawing.Point(12, 81);
            this.tbDocinform.Multiline = true;
            this.tbDocinform.Name = "tbDocinform";
            this.tbDocinform.Size = new System.Drawing.Size(328, 80);
            this.tbDocinform.TabIndex = 74;
            this.toolTip.SetToolTip(this.tbDocinform, "Информация из предоставленного абитуриентом документа, подтверждающего статус");
            // 
            // l_Docinform
            // 
            this.l_Docinform.AutoSize = true;
            this.l_Docinform.Location = new System.Drawing.Point(12, 65);
            this.l_Docinform.Name = "l_Docinform";
            this.l_Docinform.Size = new System.Drawing.Size(145, 13);
            this.l_Docinform.TabIndex = 75;
            this.l_Docinform.Text = "Информация из документа";
            // 
            // Form_Add_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 218);
            this.Controls.Add(this.l_Docinform);
            this.Controls.Add(this.tbDocinform);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbStatusType);
            this.Controls.Add(this.l_StatusType);
            this.Controls.Add(this.cbAbit);
            this.Controls.Add(this.l_Abit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить статус абитуриента";
            this.Load += new System.EventHandler(this.Form_Add_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAbit;
        private System.Windows.Forms.Label l_Abit;
        private System.Windows.Forms.TextBox tbStatusType;
        private System.Windows.Forms.Label l_StatusType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.Label l_Docinform;
        private System.Windows.Forms.TextBox tbDocinform;
        private System.Windows.Forms.ToolTip toolTip;
    }
}