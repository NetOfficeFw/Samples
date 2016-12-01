namespace LoaderShim
{
    partial class SelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.ProceedButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.AddinGrid = new System.Windows.Forms.DataGridView();
            this.HintLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AddinGrid)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProceedButton
            // 
            this.ProceedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProceedButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ProceedButton.Enabled = false;
            this.ProceedButton.Location = new System.Drawing.Point(271, 289);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 0;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = true;
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbortButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AbortButton.Location = new System.Drawing.Point(372, 289);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(75, 23);
            this.AbortButton.TabIndex = 1;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            // 
            // AddinGrid
            // 
            this.AddinGrid.AllowUserToAddRows = false;
            this.AddinGrid.AllowUserToDeleteRows = false;
            this.AddinGrid.AllowUserToResizeColumns = false;
            this.AddinGrid.AllowUserToResizeRows = false;
            this.AddinGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddinGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AddinGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddinGrid.ColumnHeadersVisible = false;
            this.AddinGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn});
            this.AddinGrid.Location = new System.Drawing.Point(31, 79);
            this.AddinGrid.Name = "AddinGrid";
            this.AddinGrid.RowHeadersVisible = false;
            this.AddinGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddinGrid.Size = new System.Drawing.Size(416, 149);
            this.AddinGrid.TabIndex = 2;
            this.AddinGrid.DoubleClick += new System.EventHandler(this.AddinGrid_DoubleClick);
            // 
            // HintLabel
            // 
            this.HintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HintLabel.Image = ((System.Drawing.Image)(resources.GetObject("HintLabel.Image")));
            this.HintLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HintLabel.Location = new System.Drawing.Point(30, 240);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(429, 34);
            this.HintLabel.TabIndex = 3;
            this.HintLabel.Text = "            Use AddinRemoval.exe to clean your system from NetOffice example addi" +
    "ns.";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(486, 50);
            this.HeaderPanel.TabIndex = 4;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(28, 16);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(281, 20);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "NetOffice Sample Addin Selection";
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "";
            this.NameColumn.Name = "NameColumn";
            // 
            // SelectionForm
            // 
            this.AcceptButton = this.ProceedButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AbortButton;
            this.ClientSize = new System.Drawing.Size(485, 334);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.AddinGrid);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.ProceedButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Sample Addin";
            ((System.ComponentModel.ISupportInitialize)(this.AddinGrid)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.DataGridView AddinGrid;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
    }
}