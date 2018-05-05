namespace EnrolleeApp
{
    partial class Form_Add_Military
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Military));
            this.cbAbit = new System.Windows.Forms.ComboBox();
            this.l_Abit = new System.Windows.Forms.Label();
            this.tbDocument = new System.Windows.Forms.TextBox();
            this.l_Document = new System.Windows.Forms.Label();
            this.tbDocumentInfo = new System.Windows.Forms.TextBox();
            this.l_adrreg = new System.Windows.Forms.Label();
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
            this.toolTip.SetToolTip(this.cbAbit, "Абитуриент, для которого требуется добавить воинскую обязанность");
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
            // tbDocument
            // 
            this.tbDocument.Location = new System.Drawing.Point(120, 39);
            this.tbDocument.Name = "tbDocument";
            this.tbDocument.Size = new System.Drawing.Size(220, 20);
            this.tbDocument.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbDocument, "Тип документа, подтверждающего воинскую обязанность абитуриента.");
            // 
            // l_Document
            // 
            this.l_Document.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.l_Document.AutoSize = true;
            this.l_Document.Location = new System.Drawing.Point(12, 42);
            this.l_Document.Name = "l_Document";
            this.l_Document.Size = new System.Drawing.Size(58, 13);
            this.l_Document.TabIndex = 42;
            this.l_Document.Text = "Документ";
            // 
            // tbDocumentInfo
            // 
            this.tbDocumentInfo.Location = new System.Drawing.Point(12, 84);
            this.tbDocumentInfo.Multiline = true;
            this.tbDocumentInfo.Name = "tbDocumentInfo";
            this.tbDocumentInfo.Size = new System.Drawing.Size(328, 89);
            this.tbDocumentInfo.TabIndex = 45;
            this.toolTip.SetToolTip(this.tbDocumentInfo, "Информация из предоставленного абитуриентом документа, подтверждаемого воинскую о" +
        "бязанность");
            // 
            // l_adrreg
            // 
            this.l_adrreg.AutoSize = true;
            this.l_adrreg.Location = new System.Drawing.Point(12, 68);
            this.l_adrreg.Name = "l_adrreg";
            this.l_adrreg.Size = new System.Drawing.Size(145, 13);
            this.l_adrreg.TabIndex = 44;
            this.l_adrreg.Text = "Информация из документа";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Добавить";
            this.toolTip.SetToolTip(this.btnAdd, "Добавить воинскую обязанность");
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
            // Form_Add_Military
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 241);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDocumentInfo);
            this.Controls.Add(this.l_adrreg);
            this.Controls.Add(this.tbDocument);
            this.Controls.Add(this.l_Document);
            this.Controls.Add(this.cbAbit);
            this.Controls.Add(this.l_Abit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Military";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить воинскую обязанность";
            this.Load += new System.EventHandler(this.Form_AddParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAbit;
        private System.Windows.Forms.Label l_Abit;
        private System.Windows.Forms.TextBox tbDocument;
        private System.Windows.Forms.Label l_Document;
        private System.Windows.Forms.TextBox tbDocumentInfo;
        private System.Windows.Forms.Label l_adrreg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.ToolTip toolTip;
    }
}