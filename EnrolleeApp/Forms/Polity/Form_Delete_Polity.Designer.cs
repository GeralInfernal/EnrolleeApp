﻿namespace EnrolleeApp
{
    partial class Form_Delete_Polity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete_Polity));
            this.tbPolityName = new System.Windows.Forms.TextBox();
            this.l_DisciplineName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbId = new System.Windows.Forms.TextBox();
            this.cbPolity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPolityName
            // 
            this.tbPolityName.Location = new System.Drawing.Point(141, 70);
            this.tbPolityName.Name = "tbPolityName";
            this.tbPolityName.ReadOnly = true;
            this.tbPolityName.Size = new System.Drawing.Size(220, 20);
            this.tbPolityName.TabIndex = 43;
            this.toolTip.SetToolTip(this.tbPolityName, "Название государства");
            // 
            // l_DisciplineName
            // 
            this.l_DisciplineName.AutoSize = true;
            this.l_DisciplineName.Location = new System.Drawing.Point(13, 73);
            this.l_DisciplineName.Name = "l_DisciplineName";
            this.l_DisciplineName.Size = new System.Drawing.Size(123, 13);
            this.l_DisciplineName.TabIndex = 42;
            this.l_DisciplineName.Text = "Название государства";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(123, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 36);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Удалить";
            this.toolTip.SetToolTip(this.btnUpdate, "Удалить указанное государство");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(141, 44);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(220, 20);
            this.tbId.TabIndex = 76;
            this.toolTip.SetToolTip(this.tbId, "Идентификатор государства");
            // 
            // cbPolity
            // 
            this.cbPolity.FormattingEnabled = true;
            this.cbPolity.Location = new System.Drawing.Point(141, 13);
            this.cbPolity.Name = "cbPolity";
            this.cbPolity.Size = new System.Drawing.Size(220, 21);
            this.cbPolity.TabIndex = 73;
            this.toolTip.SetToolTip(this.cbPolity, "Выберите удаляемую запись");
            this.cbPolity.SelectedIndexChanged += new System.EventHandler(this.cbDiscipline_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Название государства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Идентификатор";
            // 
            // Form_Delete_Polity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 148);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPolity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbPolityName);
            this.Controls.Add(this.l_DisciplineName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Delete_Polity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить государство";
            this.Load += new System.EventHandler(this.Form_Update_Polity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPolityName;
        private System.Windows.Forms.Label l_DisciplineName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPolity;
    }
}