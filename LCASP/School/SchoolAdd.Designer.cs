namespace LCASP
{
    partial class SchoolAdd
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cButton = new LCASP.PulseButton();
            this.sButton = new LCASP.PulseButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Name (Required)";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(30, 66);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(496, 31);
            this.nameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "School Address";
            // 
            // addBox
            // 
            this.addBox.Enabled = false;
            this.addBox.Location = new System.Drawing.Point(30, 156);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(496, 31);
            this.addBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // cityBox
            // 
            this.cityBox.Enabled = false;
            this.cityBox.Location = new System.Drawing.Point(30, 247);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(243, 31);
            this.cityBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "State";
            // 
            // stateBox
            // 
            this.stateBox.Enabled = false;
            this.stateBox.Location = new System.Drawing.Point(302, 247);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(81, 31);
            this.stateBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zip";
            // 
            // zipBox
            // 
            this.zipBox.Enabled = false;
            this.zipBox.Location = new System.Drawing.Point(412, 247);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(114, 31);
            this.zipBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sButton);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.zipBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addBox);
            this.groupBox1.Controls.Add(this.stateBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cityBox);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 454);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // cButton
            // 
            this.cButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.cButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.cButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.cButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cButton.Location = new System.Drawing.Point(296, 301);
            this.cButton.Name = "cButton";
            this.cButton.PulseSpeed = 0.2F;
            this.cButton.Size = new System.Drawing.Size(230, 101);
            this.cButton.TabIndex = 14;
            this.cButton.Text = "Close";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // sButton
            // 
            this.sButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.sButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.sButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.sButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sButton.Location = new System.Drawing.Point(30, 301);
            this.sButton.Name = "sButton";
            this.sButton.PulseSpeed = 0.2F;
            this.sButton.Size = new System.Drawing.Size(230, 101);
            this.sButton.TabIndex = 13;
            this.sButton.Text = "Save";
            this.sButton.UseVisualStyleBackColor = true;
            this.sButton.Click += new System.EventHandler(this.sButton_Click);
            // 
            // AddSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 527);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSchool";
            this.Text = "AddSchool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private LCASP.PulseButton cButton;
        private LCASP.PulseButton sButton;
    }
}