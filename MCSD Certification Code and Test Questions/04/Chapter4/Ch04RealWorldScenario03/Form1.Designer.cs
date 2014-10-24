namespace Ch04RealWorldScenario03
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
            this.stringBuilderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stringBuilderTextBox
            // 
            this.stringBuilderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stringBuilderTextBox.Location = new System.Drawing.Point(12, 11);
            this.stringBuilderTextBox.Multiline = true;
            this.stringBuilderTextBox.Name = "stringBuilderTextBox";
            this.stringBuilderTextBox.ReadOnly = true;
            this.stringBuilderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stringBuilderTextBox.Size = new System.Drawing.Size(284, 238);
            this.stringBuilderTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.Controls.Add(this.stringBuilderTextBox);
            this.Name = "Form1";
            this.Text = "Ch04RealWorldScenario03";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringBuilderTextBox;
    }
}

