namespace EnrolleeApp
{
    partial class Form_Add_Komis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Komis));
            this.tbKomisFIO = new System.Windows.Forms.TextBox();
            this.l_DisciplineName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKomisFIO
            // 
            this.tbKomisFIO.Location = new System.Drawing.Point(52, 12);
            this.tbKomisFIO.Name = "tbKomisFIO";
            this.tbKomisFIO.Size = new System.Drawing.Size(319, 20);
            this.tbKomisFIO.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbKomisFIO, "ФИО члена комиссии");
            // 
            // l_DisciplineName
            // 
            this.l_DisciplineName.AutoSize = true;
            this.l_DisciplineName.Location = new System.Drawing.Point(12, 15);
            this.l_DisciplineName.Name = "l_DisciplineName";
            this.l_DisciplineName.Size = new System.Drawing.Size(34, 13);
            this.l_DisciplineName.TabIndex = 42;
            this.l_DisciplineName.Text = "ФИО";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 36);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Добавить";
            this.toolTip.SetToolTip(this.btnAdd, "Добавить указанного члена комиссии");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Form_Add_Komis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 85);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbKomisFIO);
            this.Controls.Add(this.l_DisciplineName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_Komis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить члена комиссии";
            this.Load += new System.EventHandler(this.Form_Add_Komis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbKomisFIO;
        private System.Windows.Forms.Label l_DisciplineName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
    }
}