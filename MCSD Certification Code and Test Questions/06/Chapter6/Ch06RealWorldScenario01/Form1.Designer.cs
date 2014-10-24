namespace Ch06RealWorldScenario01
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
            this.overdraftDebitButton = new System.Windows.Forms.Button();
            this.overdraftCreditButton = new System.Windows.Forms.Button();
            this.overdraftAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.overdraftBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savingsBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.savingsAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.savingsDebitButton = new System.Windows.Forms.Button();
            this.savingsCreditButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // overdraftDebitButton
            // 
            this.overdraftDebitButton.Location = new System.Drawing.Point(181, 69);
            this.overdraftDebitButton.Name = "overdraftDebitButton";
            this.overdraftDebitButton.Size = new System.Drawing.Size(75, 23);
            this.overdraftDebitButton.TabIndex = 18;
            this.overdraftDebitButton.Text = "Debit";
            this.overdraftDebitButton.UseVisualStyleBackColor = true;
            this.overdraftDebitButton.Click += new System.EventHandler(this.overdraftDebitButton_Click);
            // 
            // overdraftCreditButton
            // 
            this.overdraftCreditButton.Location = new System.Drawing.Point(181, 40);
            this.overdraftCreditButton.Name = "overdraftCreditButton";
            this.overdraftCreditButton.Size = new System.Drawing.Size(75, 23);
            this.overdraftCreditButton.TabIndex = 17;
            this.overdraftCreditButton.Text = "Credit";
            this.overdraftCreditButton.UseVisualStyleBackColor = true;
            this.overdraftCreditButton.Click += new System.EventHandler(this.overdraftCreditButton_Click);
            // 
            // overdraftAmountTextBox
            // 
            this.overdraftAmountTextBox.Location = new System.Drawing.Point(75, 56);
            this.overdraftAmountTextBox.Name = "overdraftAmountTextBox";
            this.overdraftAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.overdraftAmountTextBox.TabIndex = 16;
            this.overdraftAmountTextBox.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amount:";
            // 
            // overdraftBalanceTextBox
            // 
            this.overdraftBalanceTextBox.Location = new System.Drawing.Point(75, 19);
            this.overdraftBalanceTextBox.Name = "overdraftBalanceTextBox";
            this.overdraftBalanceTextBox.ReadOnly = true;
            this.overdraftBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.overdraftBalanceTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Balance:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.overdraftBalanceTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.overdraftAmountTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.overdraftDebitButton);
            this.groupBox1.Controls.Add(this.overdraftCreditButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 98);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overdraft";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.savingsBalanceTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.savingsAmountTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.savingsDebitButton);
            this.groupBox2.Controls.Add(this.savingsCreditButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 98);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Savings";
            // 
            // savingsBalanceTextBox
            // 
            this.savingsBalanceTextBox.Location = new System.Drawing.Point(75, 19);
            this.savingsBalanceTextBox.Name = "savingsBalanceTextBox";
            this.savingsBalanceTextBox.ReadOnly = true;
            this.savingsBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.savingsBalanceTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Balance:";
            // 
            // savingsAmountTextBox
            // 
            this.savingsAmountTextBox.Location = new System.Drawing.Point(75, 56);
            this.savingsAmountTextBox.Name = "savingsAmountTextBox";
            this.savingsAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.savingsAmountTextBox.TabIndex = 16;
            this.savingsAmountTextBox.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount:";
            // 
            // savingsDebitButton
            // 
            this.savingsDebitButton.Location = new System.Drawing.Point(181, 69);
            this.savingsDebitButton.Name = "savingsDebitButton";
            this.savingsDebitButton.Size = new System.Drawing.Size(75, 23);
            this.savingsDebitButton.TabIndex = 18;
            this.savingsDebitButton.Text = "Debit";
            this.savingsDebitButton.UseVisualStyleBackColor = true;
            this.savingsDebitButton.Click += new System.EventHandler(this.savingsDebitButton_Click);
            // 
            // savingsCreditButton
            // 
            this.savingsCreditButton.Location = new System.Drawing.Point(181, 40);
            this.savingsCreditButton.Name = "savingsCreditButton";
            this.savingsCreditButton.Size = new System.Drawing.Size(75, 23);
            this.savingsCreditButton.TabIndex = 17;
            this.savingsCreditButton.Text = "Credit";
            this.savingsCreditButton.UseVisualStyleBackColor = true;
            this.savingsCreditButton.Click += new System.EventHandler(this.savingsCreditButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 226);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ch06RealWorldScenario01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button overdraftDebitButton;
        private System.Windows.Forms.Button overdraftCreditButton;
        private System.Windows.Forms.TextBox overdraftAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox overdraftBalanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox savingsBalanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox savingsAmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button savingsDebitButton;
        private System.Windows.Forms.Button savingsCreditButton;
    }
}

