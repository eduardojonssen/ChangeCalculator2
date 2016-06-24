namespace ChangeCalculator.UI.WindowsForms
{
    partial class UxFrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxFrmAbout));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UxPctBox = new System.Windows.Forms.PictureBox();
            this.UxLblProductName = new System.Windows.Forms.Label();
            this.UxLblVersion = new System.Windows.Forms.Label();
            this.UxLblCopyright = new System.Windows.Forms.Label();
            this.UxLblCompanyName = new System.Windows.Forms.Label();
            this.UxTxtBoxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UxPctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.UxPctBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.UxLblProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.UxLblVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.UxLblCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.UxLblCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.UxTxtBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // UxPctBox
            // 
            this.UxPctBox.Image = ((System.Drawing.Image)(resources.GetObject("UxPctBox.Image")));
            this.UxPctBox.Location = new System.Drawing.Point(3, 3);
            this.UxPctBox.Name = "UxPctBox";
            this.tableLayoutPanel.SetRowSpan(this.UxPctBox, 6);
            this.UxPctBox.Size = new System.Drawing.Size(131, 259);
            this.UxPctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UxPctBox.TabIndex = 12;
            this.UxPctBox.TabStop = false;
            // 
            // UxLblProductName
            // 
            this.UxLblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxLblProductName.Location = new System.Drawing.Point(143, 0);
            this.UxLblProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.UxLblProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.UxLblProductName.Name = "UxLblProductName";
            this.UxLblProductName.Size = new System.Drawing.Size(271, 17);
            this.UxLblProductName.TabIndex = 19;
            this.UxLblProductName.Text = "Product Name: Change Calculator";
            this.UxLblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UxLblProductName.Click += new System.EventHandler(this.labelProductName_Click);
            // 
            // UxLblVersion
            // 
            this.UxLblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxLblVersion.Location = new System.Drawing.Point(143, 26);
            this.UxLblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.UxLblVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.UxLblVersion.Name = "UxLblVersion";
            this.UxLblVersion.Size = new System.Drawing.Size(271, 17);
            this.UxLblVersion.TabIndex = 0;
            this.UxLblVersion.Text = "Version: 1.0.0.0";
            this.UxLblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UxLblCopyright
            // 
            this.UxLblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxLblCopyright.Location = new System.Drawing.Point(143, 52);
            this.UxLblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.UxLblCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.UxLblCopyright.Name = "UxLblCopyright";
            this.UxLblCopyright.Size = new System.Drawing.Size(271, 17);
            this.UxLblCopyright.TabIndex = 21;
            this.UxLblCopyright.Text = "Copyright: Stone";
            this.UxLblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UxLblCompanyName
            // 
            this.UxLblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxLblCompanyName.Location = new System.Drawing.Point(143, 78);
            this.UxLblCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.UxLblCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.UxLblCompanyName.Name = "UxLblCompanyName";
            this.UxLblCompanyName.Size = new System.Drawing.Size(271, 17);
            this.UxLblCompanyName.TabIndex = 22;
            this.UxLblCompanyName.Text = "Company Name: Stone";
            this.UxLblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UxTxtBoxDescription
            // 
            this.UxTxtBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxTxtBoxDescription.Location = new System.Drawing.Point(143, 107);
            this.UxTxtBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.UxTxtBoxDescription.Multiline = true;
            this.UxTxtBoxDescription.Name = "UxTxtBoxDescription";
            this.UxTxtBoxDescription.ReadOnly = true;
            this.UxTxtBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UxTxtBoxDescription.Size = new System.Drawing.Size(271, 126);
            this.UxTxtBoxDescription.TabIndex = 23;
            this.UxTxtBoxDescription.TabStop = false;
            this.UxTxtBoxDescription.Text = "\r\n";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(339, 239);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // UxFrmAbout
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UxFrmAbout";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UxFrmAbout";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UxPctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox UxPctBox;
        private System.Windows.Forms.Label UxLblProductName;
        private System.Windows.Forms.Label UxLblVersion;
        private System.Windows.Forms.Label UxLblCopyright;
        private System.Windows.Forms.Label UxLblCompanyName;
        private System.Windows.Forms.TextBox UxTxtBoxDescription;
        private System.Windows.Forms.Button okButton;
    }
}
