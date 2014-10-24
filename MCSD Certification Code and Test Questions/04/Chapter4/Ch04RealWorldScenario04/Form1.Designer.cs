namespace Ch04RealWorldScenario01
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.taxRateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.extendedPrice4TextBox = new System.Windows.Forms.TextBox();
            this.priceEach4TextBox = new System.Windows.Forms.TextBox();
            this.quantity4TextBox = new System.Windows.Forms.TextBox();
            this.descr4TextBox = new System.Windows.Forms.TextBox();
            this.extendedPrice3TextBox = new System.Windows.Forms.TextBox();
            this.priceEach3TextBox = new System.Windows.Forms.TextBox();
            this.quantity3TextBox = new System.Windows.Forms.TextBox();
            this.descr3TextBox = new System.Windows.Forms.TextBox();
            this.extendedPrice2TextBox = new System.Windows.Forms.TextBox();
            this.priceEach2TextBox = new System.Windows.Forms.TextBox();
            this.quantity2TextBox = new System.Windows.Forms.TextBox();
            this.descr2TextBox = new System.Windows.Forms.TextBox();
            this.extendedPrice1TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceEach1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descr1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(341, 273);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 74;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(260, 273);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 73;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 5);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(345, 235);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.ReadOnly = true;
            this.grandTotalTextBox.Size = new System.Drawing.Size(72, 20);
            this.grandTotalTextBox.TabIndex = 89;
            this.grandTotalTextBox.TabStop = false;
            this.grandTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Grand Total:";
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(344, 198);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(72, 20);
            this.salesTaxTextBox.TabIndex = 87;
            this.salesTaxTextBox.TabStop = false;
            this.salesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Sales Tax:";
            // 
            // taxRateTextBox
            // 
            this.taxRateTextBox.Location = new System.Drawing.Point(344, 172);
            this.taxRateTextBox.Name = "taxRateTextBox";
            this.taxRateTextBox.Size = new System.Drawing.Size(72, 20);
            this.taxRateTextBox.TabIndex = 72;
            this.taxRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Tax Rate:";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(344, 146);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(72, 20);
            this.subtotalTextBox.TabIndex = 84;
            this.subtotalTextBox.TabStop = false;
            this.subtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Subtotal:";
            // 
            // extendedPrice4TextBox
            // 
            this.extendedPrice4TextBox.Location = new System.Drawing.Point(344, 120);
            this.extendedPrice4TextBox.Name = "extendedPrice4TextBox";
            this.extendedPrice4TextBox.ReadOnly = true;
            this.extendedPrice4TextBox.Size = new System.Drawing.Size(72, 20);
            this.extendedPrice4TextBox.TabIndex = 82;
            this.extendedPrice4TextBox.TabStop = false;
            this.extendedPrice4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceEach4TextBox
            // 
            this.priceEach4TextBox.Location = new System.Drawing.Point(266, 120);
            this.priceEach4TextBox.Name = "priceEach4TextBox";
            this.priceEach4TextBox.Size = new System.Drawing.Size(72, 20);
            this.priceEach4TextBox.TabIndex = 71;
            this.priceEach4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantity4TextBox
            // 
            this.quantity4TextBox.Location = new System.Drawing.Point(188, 120);
            this.quantity4TextBox.Name = "quantity4TextBox";
            this.quantity4TextBox.Size = new System.Drawing.Size(72, 20);
            this.quantity4TextBox.TabIndex = 70;
            this.quantity4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descr4TextBox
            // 
            this.descr4TextBox.Location = new System.Drawing.Point(12, 120);
            this.descr4TextBox.Name = "descr4TextBox";
            this.descr4TextBox.Size = new System.Drawing.Size(170, 20);
            this.descr4TextBox.TabIndex = 69;
            // 
            // extendedPrice3TextBox
            // 
            this.extendedPrice3TextBox.Location = new System.Drawing.Point(344, 94);
            this.extendedPrice3TextBox.Name = "extendedPrice3TextBox";
            this.extendedPrice3TextBox.ReadOnly = true;
            this.extendedPrice3TextBox.Size = new System.Drawing.Size(72, 20);
            this.extendedPrice3TextBox.TabIndex = 81;
            this.extendedPrice3TextBox.TabStop = false;
            this.extendedPrice3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceEach3TextBox
            // 
            this.priceEach3TextBox.Location = new System.Drawing.Point(266, 94);
            this.priceEach3TextBox.Name = "priceEach3TextBox";
            this.priceEach3TextBox.Size = new System.Drawing.Size(72, 20);
            this.priceEach3TextBox.TabIndex = 68;
            this.priceEach3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantity3TextBox
            // 
            this.quantity3TextBox.Location = new System.Drawing.Point(188, 94);
            this.quantity3TextBox.Name = "quantity3TextBox";
            this.quantity3TextBox.Size = new System.Drawing.Size(72, 20);
            this.quantity3TextBox.TabIndex = 67;
            this.quantity3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descr3TextBox
            // 
            this.descr3TextBox.Location = new System.Drawing.Point(12, 94);
            this.descr3TextBox.Name = "descr3TextBox";
            this.descr3TextBox.Size = new System.Drawing.Size(170, 20);
            this.descr3TextBox.TabIndex = 66;
            // 
            // extendedPrice2TextBox
            // 
            this.extendedPrice2TextBox.Location = new System.Drawing.Point(344, 68);
            this.extendedPrice2TextBox.Name = "extendedPrice2TextBox";
            this.extendedPrice2TextBox.ReadOnly = true;
            this.extendedPrice2TextBox.Size = new System.Drawing.Size(72, 20);
            this.extendedPrice2TextBox.TabIndex = 80;
            this.extendedPrice2TextBox.TabStop = false;
            this.extendedPrice2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceEach2TextBox
            // 
            this.priceEach2TextBox.Location = new System.Drawing.Point(266, 68);
            this.priceEach2TextBox.Name = "priceEach2TextBox";
            this.priceEach2TextBox.Size = new System.Drawing.Size(72, 20);
            this.priceEach2TextBox.TabIndex = 65;
            this.priceEach2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantity2TextBox
            // 
            this.quantity2TextBox.Location = new System.Drawing.Point(188, 68);
            this.quantity2TextBox.Name = "quantity2TextBox";
            this.quantity2TextBox.Size = new System.Drawing.Size(72, 20);
            this.quantity2TextBox.TabIndex = 64;
            this.quantity2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descr2TextBox
            // 
            this.descr2TextBox.Location = new System.Drawing.Point(12, 68);
            this.descr2TextBox.Name = "descr2TextBox";
            this.descr2TextBox.Size = new System.Drawing.Size(170, 20);
            this.descr2TextBox.TabIndex = 63;
            // 
            // extendedPrice1TextBox
            // 
            this.extendedPrice1TextBox.Location = new System.Drawing.Point(344, 42);
            this.extendedPrice1TextBox.Name = "extendedPrice1TextBox";
            this.extendedPrice1TextBox.ReadOnly = true;
            this.extendedPrice1TextBox.Size = new System.Drawing.Size(72, 20);
            this.extendedPrice1TextBox.TabIndex = 79;
            this.extendedPrice1TextBox.TabStop = false;
            this.extendedPrice1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(344, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 78;
            this.label4.Text = "Extended Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceEach1TextBox
            // 
            this.priceEach1TextBox.Location = new System.Drawing.Point(266, 42);
            this.priceEach1TextBox.Name = "priceEach1TextBox";
            this.priceEach1TextBox.Size = new System.Drawing.Size(72, 20);
            this.priceEach1TextBox.TabIndex = 62;
            this.priceEach1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(266, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "Price Each";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantity1TextBox
            // 
            this.quantity1TextBox.Location = new System.Drawing.Point(188, 42);
            this.quantity1TextBox.Name = "quantity1TextBox";
            this.quantity1TextBox.Size = new System.Drawing.Size(72, 20);
            this.quantity1TextBox.TabIndex = 61;
            this.quantity1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(188, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 76;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descr1TextBox
            // 
            this.descr1TextBox.Location = new System.Drawing.Point(12, 42);
            this.descr1TextBox.Name = "descr1TextBox";
            this.descr1TextBox.Size = new System.Drawing.Size(170, 20);
            this.descr1TextBox.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 75;
            this.label1.Text = "Description";
            // 
            // Form1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(429, 307);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grandTotalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.taxRateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.extendedPrice4TextBox);
            this.Controls.Add(this.priceEach4TextBox);
            this.Controls.Add(this.quantity4TextBox);
            this.Controls.Add(this.descr4TextBox);
            this.Controls.Add(this.extendedPrice3TextBox);
            this.Controls.Add(this.priceEach3TextBox);
            this.Controls.Add(this.quantity3TextBox);
            this.Controls.Add(this.descr3TextBox);
            this.Controls.Add(this.extendedPrice2TextBox);
            this.Controls.Add(this.priceEach2TextBox);
            this.Controls.Add(this.quantity2TextBox);
            this.Controls.Add(this.descr2TextBox);
            this.Controls.Add(this.extendedPrice1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceEach1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantity1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descr1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ch04RealWorldScenario01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox taxRateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox extendedPrice4TextBox;
        private System.Windows.Forms.TextBox priceEach4TextBox;
        private System.Windows.Forms.TextBox quantity4TextBox;
        private System.Windows.Forms.TextBox descr4TextBox;
        private System.Windows.Forms.TextBox extendedPrice3TextBox;
        private System.Windows.Forms.TextBox priceEach3TextBox;
        private System.Windows.Forms.TextBox quantity3TextBox;
        private System.Windows.Forms.TextBox descr3TextBox;
        private System.Windows.Forms.TextBox extendedPrice2TextBox;
        private System.Windows.Forms.TextBox priceEach2TextBox;
        private System.Windows.Forms.TextBox quantity2TextBox;
        private System.Windows.Forms.TextBox descr2TextBox;
        private System.Windows.Forms.TextBox extendedPrice1TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceEach1TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantity1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descr1TextBox;
        private System.Windows.Forms.Label label1;
    }
}

