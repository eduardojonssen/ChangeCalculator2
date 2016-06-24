namespace ChangeCalculator.UI.WindowsForms
{
    partial class UxFrmChangeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxFrmChangeCalculator));
            this.UxGrpbSales = new System.Windows.Forms.GroupBox();
            this.UxBtnCalculate = new System.Windows.Forms.Button();
            this.UxGrpbChange = new System.Windows.Forms.GroupBox();
            this.UxLblCoins = new System.Windows.Forms.Label();
            this.UxTxtAmount = new System.Windows.Forms.TextBox();
            this.UxLblTotalValue = new System.Windows.Forms.Label();
            this.UxTxtTotalPaid = new System.Windows.Forms.TextBox();
            this.UxLblTotalPaid = new System.Windows.Forms.Label();
            this.UxTxtTotalPayment = new System.Windows.Forms.TextBox();
            this.UxLblTotalPayment = new System.Windows.Forms.Label();
            this.UxTxbCoins = new System.Windows.Forms.TextBox();
            this.UxGrpbSales.SuspendLayout();
            this.UxGrpbChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxGrpbSales
            // 
            this.UxGrpbSales.Controls.Add(this.UxBtnCalculate);
            this.UxGrpbSales.Controls.Add(this.UxGrpbChange);
            this.UxGrpbSales.Controls.Add(this.UxTxtTotalPaid);
            this.UxGrpbSales.Controls.Add(this.UxLblTotalPaid);
            this.UxGrpbSales.Controls.Add(this.UxTxtTotalPayment);
            this.UxGrpbSales.Controls.Add(this.UxLblTotalPayment);
            this.UxGrpbSales.Location = new System.Drawing.Point(12, 12);
            this.UxGrpbSales.Name = "UxGrpbSales";
            this.UxGrpbSales.Size = new System.Drawing.Size(521, 389);
            this.UxGrpbSales.TabIndex = 0;
            this.UxGrpbSales.TabStop = false;
            this.UxGrpbSales.Text = "Sale";
            // 
            // UxBtnCalculate
            // 
            this.UxBtnCalculate.Location = new System.Drawing.Point(227, 61);
            this.UxBtnCalculate.Name = "UxBtnCalculate";
            this.UxBtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.UxBtnCalculate.TabIndex = 6;
            this.UxBtnCalculate.Text = "Calculate";
            this.UxBtnCalculate.UseVisualStyleBackColor = true;
            this.UxBtnCalculate.Click += new System.EventHandler(this.UxBtnCalculate_Click);
            // 
            // UxGrpbChange
            // 
            this.UxGrpbChange.Controls.Add(this.UxTxbCoins);
            this.UxGrpbChange.Controls.Add(this.UxLblCoins);
            this.UxGrpbChange.Controls.Add(this.UxTxtAmount);
            this.UxGrpbChange.Controls.Add(this.UxLblTotalValue);
            this.UxGrpbChange.Location = new System.Drawing.Point(6, 90);
            this.UxGrpbChange.Name = "UxGrpbChange";
            this.UxGrpbChange.Size = new System.Drawing.Size(508, 285);
            this.UxGrpbChange.TabIndex = 5;
            this.UxGrpbChange.TabStop = false;
            this.UxGrpbChange.Text = "Change";
            // 
            // UxLblCoins
            // 
            this.UxLblCoins.AutoSize = true;
            this.UxLblCoins.Location = new System.Drawing.Point(14, 63);
            this.UxLblCoins.Name = "UxLblCoins";
            this.UxLblCoins.Size = new System.Drawing.Size(36, 13);
            this.UxLblCoins.TabIndex = 7;
            this.UxLblCoins.Text = "Coins:";
            // 
            // UxTxtAmount
            // 
            this.UxTxtAmount.Enabled = false;
            this.UxTxtAmount.Location = new System.Drawing.Point(95, 26);
            this.UxTxtAmount.Name = "UxTxtAmount";
            this.UxTxtAmount.Size = new System.Drawing.Size(100, 20);
            this.UxTxtAmount.TabIndex = 5;
            // 
            // UxLblTotalValue
            // 
            this.UxLblTotalValue.AutoSize = true;
            this.UxLblTotalValue.Location = new System.Drawing.Point(14, 29);
            this.UxLblTotalValue.Name = "UxLblTotalValue";
            this.UxLblTotalValue.Size = new System.Drawing.Size(46, 13);
            this.UxLblTotalValue.TabIndex = 4;
            this.UxLblTotalValue.Text = "Amount:";
            // 
            // UxTxtTotalPaid
            // 
            this.UxTxtTotalPaid.Location = new System.Drawing.Point(101, 64);
            this.UxTxtTotalPaid.Name = "UxTxtTotalPaid";
            this.UxTxtTotalPaid.Size = new System.Drawing.Size(100, 20);
            this.UxTxtTotalPaid.TabIndex = 3;
            // 
            // UxLblTotalPaid
            // 
            this.UxLblTotalPaid.AutoSize = true;
            this.UxLblTotalPaid.Location = new System.Drawing.Point(20, 64);
            this.UxLblTotalPaid.Name = "UxLblTotalPaid";
            this.UxLblTotalPaid.Size = new System.Drawing.Size(58, 13);
            this.UxLblTotalPaid.TabIndex = 2;
            this.UxLblTotalPaid.Text = "Total Paid:";
            // 
            // UxTxtTotalPayment
            // 
            this.UxTxtTotalPayment.Location = new System.Drawing.Point(101, 22);
            this.UxTxtTotalPayment.Name = "UxTxtTotalPayment";
            this.UxTxtTotalPayment.Size = new System.Drawing.Size(100, 20);
            this.UxTxtTotalPayment.TabIndex = 1;
            // 
            // UxLblTotalPayment
            // 
            this.UxLblTotalPayment.AutoSize = true;
            this.UxLblTotalPayment.Location = new System.Drawing.Point(17, 29);
            this.UxLblTotalPayment.Name = "UxLblTotalPayment";
            this.UxLblTotalPayment.Size = new System.Drawing.Size(78, 13);
            this.UxLblTotalPayment.TabIndex = 0;
            this.UxLblTotalPayment.Text = "Total Payment:";
            // 
            // UxTxbCoins
            // 
            this.UxTxbCoins.Location = new System.Drawing.Point(17, 80);
            this.UxTxbCoins.Multiline = true;
            this.UxTxbCoins.Name = "UxTxbCoins";
            this.UxTxbCoins.Size = new System.Drawing.Size(462, 137);
            this.UxTxbCoins.TabIndex = 8;
            // 
            // UxFrmChangeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 413);
            this.Controls.Add(this.UxGrpbSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UxFrmChangeCalculator";
            this.Text = "Change Calculator";
            this.UxGrpbSales.ResumeLayout(false);
            this.UxGrpbSales.PerformLayout();
            this.UxGrpbChange.ResumeLayout(false);
            this.UxGrpbChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UxGrpbSales;
        private System.Windows.Forms.Label UxLblTotalPayment;
        private System.Windows.Forms.GroupBox UxGrpbChange;
        private System.Windows.Forms.Label UxLblCoins;
        private System.Windows.Forms.TextBox UxTxtAmount;
        private System.Windows.Forms.Label UxLblTotalValue;
        private System.Windows.Forms.TextBox UxTxtTotalPaid;
        private System.Windows.Forms.Label UxLblTotalPaid;
        private System.Windows.Forms.TextBox UxTxtTotalPayment;
        private System.Windows.Forms.Button UxBtnCalculate;
        private System.Windows.Forms.TextBox UxTxbCoins;
    }
}