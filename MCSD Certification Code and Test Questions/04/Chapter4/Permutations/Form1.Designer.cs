namespace Permutations
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
            this.numPermutationsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numLettersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.permutationsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stringBuilderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.concatenationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLettersNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numPermutationsTextBox
            // 
            this.numPermutationsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numPermutationsTextBox.Location = new System.Drawing.Point(113, 185);
            this.numPermutationsTextBox.Name = "numPermutationsTextBox";
            this.numPermutationsTextBox.ReadOnly = true;
            this.numPermutationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numPermutationsTextBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "# Permutations:";
            // 
            // numLettersNumericUpDown
            // 
            this.numLettersNumericUpDown.Location = new System.Drawing.Point(70, 6);
            this.numLettersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLettersNumericUpDown.Name = "numLettersNumericUpDown";
            this.numLettersNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.numLettersNumericUpDown.TabIndex = 21;
            this.numLettersNumericUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // permutationsTextBox
            // 
            this.permutationsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permutationsTextBox.Location = new System.Drawing.Point(15, 32);
            this.permutationsTextBox.Multiline = true;
            this.permutationsTextBox.Name = "permutationsTextBox";
            this.permutationsTextBox.ReadOnly = true;
            this.permutationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.permutationsTextBox.Size = new System.Drawing.Size(211, 147);
            this.permutationsTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "# Letters:";
            // 
            // stringBuilderTextBox
            // 
            this.stringBuilderTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stringBuilderTextBox.Location = new System.Drawing.Point(113, 237);
            this.stringBuilderTextBox.Name = "stringBuilderTextBox";
            this.stringBuilderTextBox.ReadOnly = true;
            this.stringBuilderTextBox.Size = new System.Drawing.Size(100, 20);
            this.stringBuilderTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "StringBuilder:";
            // 
            // concatenationTextBox
            // 
            this.concatenationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.concatenationTextBox.Location = new System.Drawing.Point(113, 211);
            this.concatenationTextBox.Name = "concatenationTextBox";
            this.concatenationTextBox.ReadOnly = true;
            this.concatenationTextBox.Size = new System.Drawing.Size(100, 20);
            this.concatenationTextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Concatenation:";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(151, 3);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 22;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 261);
            this.Controls.Add(this.numPermutationsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numLettersNumericUpDown);
            this.Controls.Add(this.permutationsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stringBuilderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.concatenationTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goButton);
            this.Name = "Form1";
            this.Text = "Permutations";
            ((System.ComponentModel.ISupportInitialize)(this.numLettersNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numPermutationsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLettersNumericUpDown;
        private System.Windows.Forms.TextBox permutationsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stringBuilderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox concatenationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goButton;
    }
}

