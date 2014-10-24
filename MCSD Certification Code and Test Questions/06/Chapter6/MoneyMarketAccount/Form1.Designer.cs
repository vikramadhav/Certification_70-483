namespace MoneyMarketAccount
{
    partial class Form1
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
            this.debitButton = new System.Windows.Forms.Button();
            this.creditButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.feeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debitButton
            // 
            this.debitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.debitButton.Location = new System.Drawing.Point(198, 87);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(75, 23);
            this.debitButton.TabIndex = 11;
            this.debitButton.Text = "Debit";
            this.debitButton.UseVisualStyleBackColor = true;
            this.debitButton.Click += new System.EventHandler(this.debitButton_Click);
            // 
            // creditButton
            // 
            this.creditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creditButton.Location = new System.Drawing.Point(198, 58);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(75, 23);
            this.creditButton.TabIndex = 10;
            this.creditButton.Text = "Credit";
            this.creditButton.UseVisualStyleBackColor = true;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.Location = new System.Drawing.Point(65, 74);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(127, 20);
            this.amountTextBox.TabIndex = 9;
            this.amountTextBox.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount:";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceTextBox.Location = new System.Drawing.Point(65, 10);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(127, 20);
            this.balanceTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Balance:";
            // 
            // feeButton
            // 
            this.feeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.feeButton.Location = new System.Drawing.Point(198, 116);
            this.feeButton.Name = "feeButton";
            this.feeButton.Size = new System.Drawing.Size(75, 23);
            this.feeButton.TabIndex = 12;
            this.feeButton.Text = "Fee";
            this.feeButton.UseVisualStyleBackColor = true;
            this.feeButton.Click += new System.EventHandler(this.feeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.feeButton);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MoneyMarketAccount";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button feeButton;
    }
}

