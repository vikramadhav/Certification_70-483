namespace Ch11RealWorldScenario01
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zipComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox4 = new System.Windows.Forms.TextBox();
            this.quantityTextBox4 = new System.Windows.Forms.TextBox();
            this.unitCostTextBox4 = new System.Windows.Forms.TextBox();
            this.descrTextBox4 = new System.Windows.Forms.TextBox();
            this.totalTextBox3 = new System.Windows.Forms.TextBox();
            this.quantityTextBox3 = new System.Windows.Forms.TextBox();
            this.unitCostTextBox3 = new System.Windows.Forms.TextBox();
            this.descrTextBox3 = new System.Windows.Forms.TextBox();
            this.totalTextBox2 = new System.Windows.Forms.TextBox();
            this.quantityTextBox2 = new System.Windows.Forms.TextBox();
            this.unitCostTextBox2 = new System.Windows.Forms.TextBox();
            this.descrTextBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalTextBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.quantityTextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.unitCostTextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.descrTextBox1 = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(84, 19);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.zipComboBox);
            this.groupBox1.Controls.Add(this.cityComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.stateTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.streetTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Information";
            // 
            // zipComboBox
            // 
            this.zipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zipComboBox.FormattingEnabled = true;
            this.zipComboBox.Items.AddRange(new object[] {
            "Programmeria",
            "Bugsville",
            "Abend"});
            this.zipComboBox.Location = new System.Drawing.Point(170, 123);
            this.zipComboBox.Name = "zipComboBox";
            this.zipComboBox.Size = new System.Drawing.Size(54, 21);
            this.zipComboBox.TabIndex = 12;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Programmeria",
            "Bugsville",
            "Abend"});
            this.cityComboBox.Location = new System.Drawing.Point(84, 97);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(233, 21);
            this.cityComboBox.TabIndex = 6;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ZIP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(84, 123);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(36, 20);
            this.stateTextBox.TabIndex = 9;
            this.stateTextBox.Text = "FL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Street:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(84, 71);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(233, 20);
            this.streetTextBox.TabIndex = 5;
            this.streetTextBox.TextChanged += new System.EventHandler(this.streetTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(84, 45);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.grandTotalTextBox);
            this.groupBox2.Controls.Add(this.totalTextBox4);
            this.groupBox2.Controls.Add(this.quantityTextBox4);
            this.groupBox2.Controls.Add(this.unitCostTextBox4);
            this.groupBox2.Controls.Add(this.descrTextBox4);
            this.groupBox2.Controls.Add(this.totalTextBox3);
            this.groupBox2.Controls.Add(this.quantityTextBox3);
            this.groupBox2.Controls.Add(this.unitCostTextBox3);
            this.groupBox2.Controls.Add(this.descrTextBox3);
            this.groupBox2.Controls.Add(this.totalTextBox2);
            this.groupBox2.Controls.Add(this.quantityTextBox2);
            this.groupBox2.Controls.Add(this.unitCostTextBox2);
            this.groupBox2.Controls.Add(this.descrTextBox2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.totalTextBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.quantityTextBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.unitCostTextBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.descrTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Grand Total:";
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(322, 142);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.ReadOnly = true;
            this.grandTotalTextBox.Size = new System.Drawing.Size(70, 20);
            this.grandTotalTextBox.TabIndex = 22;
            this.grandTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTextBox4
            // 
            this.totalTextBox4.Location = new System.Drawing.Point(322, 116);
            this.totalTextBox4.Name = "totalTextBox4";
            this.totalTextBox4.ReadOnly = true;
            this.totalTextBox4.Size = new System.Drawing.Size(70, 20);
            this.totalTextBox4.TabIndex = 21;
            this.totalTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityTextBox4
            // 
            this.quantityTextBox4.Location = new System.Drawing.Point(246, 116);
            this.quantityTextBox4.Name = "quantityTextBox4";
            this.quantityTextBox4.Size = new System.Drawing.Size(70, 20);
            this.quantityTextBox4.TabIndex = 20;
            this.quantityTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextBox4.TextChanged += new System.EventHandler(this.row4_TextChanged);
            // 
            // unitCostTextBox4
            // 
            this.unitCostTextBox4.Location = new System.Drawing.Point(170, 116);
            this.unitCostTextBox4.Name = "unitCostTextBox4";
            this.unitCostTextBox4.Size = new System.Drawing.Size(70, 20);
            this.unitCostTextBox4.TabIndex = 19;
            this.unitCostTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitCostTextBox4.TextChanged += new System.EventHandler(this.row4_TextChanged);
            // 
            // descrTextBox4
            // 
            this.descrTextBox4.Location = new System.Drawing.Point(19, 116);
            this.descrTextBox4.Name = "descrTextBox4";
            this.descrTextBox4.Size = new System.Drawing.Size(145, 20);
            this.descrTextBox4.TabIndex = 18;
            this.descrTextBox4.TextChanged += new System.EventHandler(this.row4_TextChanged);
            // 
            // totalTextBox3
            // 
            this.totalTextBox3.Location = new System.Drawing.Point(322, 90);
            this.totalTextBox3.Name = "totalTextBox3";
            this.totalTextBox3.ReadOnly = true;
            this.totalTextBox3.Size = new System.Drawing.Size(70, 20);
            this.totalTextBox3.TabIndex = 17;
            this.totalTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityTextBox3
            // 
            this.quantityTextBox3.Location = new System.Drawing.Point(246, 90);
            this.quantityTextBox3.Name = "quantityTextBox3";
            this.quantityTextBox3.Size = new System.Drawing.Size(70, 20);
            this.quantityTextBox3.TabIndex = 16;
            this.quantityTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextBox3.TextChanged += new System.EventHandler(this.row3_TextChanged);
            // 
            // unitCostTextBox3
            // 
            this.unitCostTextBox3.Location = new System.Drawing.Point(170, 90);
            this.unitCostTextBox3.Name = "unitCostTextBox3";
            this.unitCostTextBox3.Size = new System.Drawing.Size(70, 20);
            this.unitCostTextBox3.TabIndex = 15;
            this.unitCostTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitCostTextBox3.TextChanged += new System.EventHandler(this.row3_TextChanged);
            // 
            // descrTextBox3
            // 
            this.descrTextBox3.Location = new System.Drawing.Point(19, 90);
            this.descrTextBox3.Name = "descrTextBox3";
            this.descrTextBox3.Size = new System.Drawing.Size(145, 20);
            this.descrTextBox3.TabIndex = 14;
            this.descrTextBox3.TextChanged += new System.EventHandler(this.row3_TextChanged);
            // 
            // totalTextBox2
            // 
            this.totalTextBox2.Location = new System.Drawing.Point(322, 64);
            this.totalTextBox2.Name = "totalTextBox2";
            this.totalTextBox2.ReadOnly = true;
            this.totalTextBox2.Size = new System.Drawing.Size(70, 20);
            this.totalTextBox2.TabIndex = 13;
            this.totalTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityTextBox2
            // 
            this.quantityTextBox2.Location = new System.Drawing.Point(246, 64);
            this.quantityTextBox2.Name = "quantityTextBox2";
            this.quantityTextBox2.Size = new System.Drawing.Size(70, 20);
            this.quantityTextBox2.TabIndex = 12;
            this.quantityTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextBox2.TextChanged += new System.EventHandler(this.row2_TextChanged);
            // 
            // unitCostTextBox2
            // 
            this.unitCostTextBox2.Location = new System.Drawing.Point(170, 64);
            this.unitCostTextBox2.Name = "unitCostTextBox2";
            this.unitCostTextBox2.Size = new System.Drawing.Size(70, 20);
            this.unitCostTextBox2.TabIndex = 11;
            this.unitCostTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitCostTextBox2.TextChanged += new System.EventHandler(this.row2_TextChanged);
            // 
            // descrTextBox2
            // 
            this.descrTextBox2.Location = new System.Drawing.Point(19, 64);
            this.descrTextBox2.Name = "descrTextBox2";
            this.descrTextBox2.Size = new System.Drawing.Size(145, 20);
            this.descrTextBox2.TabIndex = 10;
            this.descrTextBox2.TextChanged += new System.EventHandler(this.row2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total";
            // 
            // totalTextBox1
            // 
            this.totalTextBox1.Location = new System.Drawing.Point(322, 38);
            this.totalTextBox1.Name = "totalTextBox1";
            this.totalTextBox1.ReadOnly = true;
            this.totalTextBox1.Size = new System.Drawing.Size(70, 20);
            this.totalTextBox1.TabIndex = 9;
            this.totalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quantity";
            // 
            // quantityTextBox1
            // 
            this.quantityTextBox1.Location = new System.Drawing.Point(246, 38);
            this.quantityTextBox1.Name = "quantityTextBox1";
            this.quantityTextBox1.Size = new System.Drawing.Size(70, 20);
            this.quantityTextBox1.TabIndex = 7;
            this.quantityTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextBox1.TextChanged += new System.EventHandler(this.row1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Unit Cost";
            // 
            // unitCostTextBox1
            // 
            this.unitCostTextBox1.Location = new System.Drawing.Point(170, 38);
            this.unitCostTextBox1.Name = "unitCostTextBox1";
            this.unitCostTextBox1.Size = new System.Drawing.Size(70, 20);
            this.unitCostTextBox1.TabIndex = 5;
            this.unitCostTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitCostTextBox1.TextChanged += new System.EventHandler(this.row1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Description";
            // 
            // descrTextBox1
            // 
            this.descrTextBox1.Location = new System.Drawing.Point(19, 38);
            this.descrTextBox1.Name = "descrTextBox1";
            this.descrTextBox1.Size = new System.Drawing.Size(145, 20);
            this.descrTextBox1.TabIndex = 3;
            this.descrTextBox1.TextChanged += new System.EventHandler(this.row1_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(256, 352);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(337, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(424, 387);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "New Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox zipComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox unitCostTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox descrTextBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox4;
        private System.Windows.Forms.TextBox quantityTextBox4;
        private System.Windows.Forms.TextBox unitCostTextBox4;
        private System.Windows.Forms.TextBox descrTextBox4;
        private System.Windows.Forms.TextBox totalTextBox3;
        private System.Windows.Forms.TextBox quantityTextBox3;
        private System.Windows.Forms.TextBox unitCostTextBox3;
        private System.Windows.Forms.TextBox descrTextBox3;
        private System.Windows.Forms.TextBox totalTextBox2;
        private System.Windows.Forms.TextBox quantityTextBox2;
        private System.Windows.Forms.TextBox unitCostTextBox2;
        private System.Windows.Forms.TextBox descrTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quantityTextBox1;
    }
}

