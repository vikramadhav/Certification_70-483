namespace GraphFunction
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
            this.equationComboBox = new System.Windows.Forms.ComboBox();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // equationComboBox
            // 
            this.equationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equationComboBox.FormattingEnabled = true;
            this.equationComboBox.Items.AddRange(new object[] {
            "12 * Sin(3 * x) / (1 + |x|)",
            "|20 * Cos(|x|) / (|x| + 1)|",
            "Ax^6 + Bx^5 + Cx^4 + Dx^3 + Ex^2 + Fx + G"});
            this.equationComboBox.Location = new System.Drawing.Point(12, 13);
            this.equationComboBox.Name = "equationComboBox";
            this.equationComboBox.Size = new System.Drawing.Size(260, 21);
            this.equationComboBox.TabIndex = 6;
            this.equationComboBox.SelectedIndexChanged += new System.EventHandler(this.equationComboBox_SelectedIndexChanged);
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphPictureBox.Location = new System.Drawing.Point(12, 40);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(260, 260);
            this.graphPictureBox.TabIndex = 5;
            this.graphPictureBox.TabStop = false;
            this.graphPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.graphPictureBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.equationComboBox);
            this.Controls.Add(this.graphPictureBox);
            this.Name = "Form1";
            this.Text = "GraphFunction";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox equationComboBox;
        private System.Windows.Forms.PictureBox graphPictureBox;
    }
}

