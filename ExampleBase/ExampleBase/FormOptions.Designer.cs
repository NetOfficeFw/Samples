namespace ExampleBase
{
    partial class FormOptions
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.radioButtonApplicationFolder = new System.Windows.Forms.RadioButton();
            this.radioButtonDocumentsFolder = new System.Windows.Forms.RadioButton();
            this.groupBoxFolder = new System.Windows.Forms.GroupBox();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.radioButtonLanguage1031 = new System.Windows.Forms.RadioButton();
            this.radioButtonLanguage1033 = new System.Windows.Forms.RadioButton();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxFolder.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonApplicationFolder
            // 
            this.radioButtonApplicationFolder.AutoSize = true;
            this.radioButtonApplicationFolder.Checked = true;
            this.radioButtonApplicationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonApplicationFolder.Location = new System.Drawing.Point(28, 45);
            this.radioButtonApplicationFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonApplicationFolder.Name = "radioButtonApplicationFolder";
            this.radioButtonApplicationFolder.Size = new System.Drawing.Size(159, 24);
            this.radioButtonApplicationFolder.TabIndex = 0;
            this.radioButtonApplicationFolder.TabStop = true;
            this.radioButtonApplicationFolder.Text = "Application Folder";
            this.radioButtonApplicationFolder.UseVisualStyleBackColor = true;
            // 
            // radioButtonDocumentsFolder
            // 
            this.radioButtonDocumentsFolder.AutoSize = true;
            this.radioButtonDocumentsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonDocumentsFolder.Location = new System.Drawing.Point(28, 80);
            this.radioButtonDocumentsFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonDocumentsFolder.Name = "radioButtonDocumentsFolder";
            this.radioButtonDocumentsFolder.Size = new System.Drawing.Size(163, 24);
            this.radioButtonDocumentsFolder.TabIndex = 1;
            this.radioButtonDocumentsFolder.Text = "Documents Folder";
            this.radioButtonDocumentsFolder.UseVisualStyleBackColor = true;
            // 
            // groupBoxFolder
            // 
            this.groupBoxFolder.Controls.Add(this.radioButtonDocumentsFolder);
            this.groupBoxFolder.Controls.Add(this.radioButtonApplicationFolder);
            this.groupBoxFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFolder.Location = new System.Drawing.Point(34, 37);
            this.groupBoxFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFolder.Name = "groupBoxFolder";
            this.groupBoxFolder.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFolder.Size = new System.Drawing.Size(423, 137);
            this.groupBoxFolder.TabIndex = 2;
            this.groupBoxFolder.TabStop = false;
            this.groupBoxFolder.Text = "Select base folder for generated documents";
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.radioButtonLanguage1031);
            this.groupBoxLanguage.Controls.Add(this.radioButtonLanguage1033);
            this.groupBoxLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLanguage.Location = new System.Drawing.Point(34, 200);
            this.groupBoxLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLanguage.Size = new System.Drawing.Size(423, 137);
            this.groupBoxLanguage.TabIndex = 3;
            this.groupBoxLanguage.TabStop = false;
            this.groupBoxLanguage.Text = "Select Language";
            // 
            // radioButtonLanguage1031
            // 
            this.radioButtonLanguage1031.AutoSize = true;
            this.radioButtonLanguage1031.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonLanguage1031.Location = new System.Drawing.Point(28, 82);
            this.radioButtonLanguage1031.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonLanguage1031.Name = "radioButtonLanguage1031";
            this.radioButtonLanguage1031.Size = new System.Drawing.Size(164, 24);
            this.radioButtonLanguage1031.TabIndex = 3;
            this.radioButtonLanguage1031.Text = "German (Deutsch)";
            this.radioButtonLanguage1031.UseVisualStyleBackColor = true;
            // 
            // radioButtonLanguage1033
            // 
            this.radioButtonLanguage1033.AutoSize = true;
            this.radioButtonLanguage1033.Checked = true;
            this.radioButtonLanguage1033.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonLanguage1033.Location = new System.Drawing.Point(28, 46);
            this.radioButtonLanguage1033.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonLanguage1033.Name = "radioButtonLanguage1033";
            this.radioButtonLanguage1033.Size = new System.Drawing.Size(121, 24);
            this.radioButtonLanguage1033.TabIndex = 2;
            this.radioButtonLanguage1033.TabStop = true;
            this.radioButtonLanguage1033.Text = "English (US)";
            this.radioButtonLanguage1033.UseVisualStyleBackColor = true;
            this.radioButtonLanguage1033.CheckedChanged += new System.EventHandler(this.radioButtonLanguage1033_CheckedChanged);
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.ForeColor = System.Drawing.Color.Blue;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDone.Location = new System.Drawing.Point(201, 365);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(256, 45);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Return to Examples";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormOptions
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.buttonDone;
            this.ClientSize = new System.Drawing.Size(500, 435);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxLanguage);
            this.Controls.Add(this.groupBoxFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.groupBoxFolder.ResumeLayout(false);
            this.groupBoxFolder.PerformLayout();
            this.groupBoxLanguage.ResumeLayout(false);
            this.groupBoxLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonApplicationFolder;
        private System.Windows.Forms.RadioButton radioButtonDocumentsFolder;
        private System.Windows.Forms.GroupBox groupBoxFolder;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.RadioButton radioButtonLanguage1031;
        private System.Windows.Forms.RadioButton radioButtonLanguage1033;
        private System.Windows.Forms.Button buttonDone;

    }
}
