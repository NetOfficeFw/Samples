namespace AccessExamplesCS4
{
    partial class Example04
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewInfo = new System.Windows.Forms.TreeView();
            this.buttonSelectDatabase = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // treeViewInfo
            //
            this.treeViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewInfo.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewInfo.Location = new System.Drawing.Point(95, 76);
            this.treeViewInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewInfo.Name = "treeViewInfo";
            this.treeViewInfo.Size = new System.Drawing.Size(884, 387);
            this.treeViewInfo.TabIndex = 9;
            //
            // buttonSelectDatabase
            //
            this.buttonSelectDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectDatabase.Location = new System.Drawing.Point(989, 36);
            this.buttonSelectDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelectDatabase.Name = "buttonSelectDatabase";
            this.buttonSelectDatabase.Size = new System.Drawing.Size(60, 32);
            this.buttonSelectDatabase.TabIndex = 8;
            this.buttonSelectDatabase.Text = "...";
            this.buttonSelectDatabase.UseVisualStyleBackColor = true;
            this.buttonSelectDatabase.Click += new System.EventHandler(this.buttonSelectDatabase_Click);
            //
            // textBoxFilePath
            //
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilePath.Location = new System.Drawing.Point(95, 40);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(886, 26);
            this.textBoxFilePath.TabIndex = 7;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select database file to display detailed information about it.";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database";
            //
            // Example04
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.treeViewInfo);
            this.Controls.Add(this.buttonSelectDatabase);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Example04";
            this.Size = new System.Drawing.Size(1108, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewInfo;
        private System.Windows.Forms.Button buttonSelectDatabase;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
