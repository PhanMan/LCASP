namespace Lcasp
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZipBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CButton = new Lcasp.PulseButton();
            this.SButton = new Lcasp.PulseButton();
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
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(30, 66);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(496, 31);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBoxChanged);
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
            // AddBox
            // 
            this.AddBox.Enabled = false;
            this.AddBox.Location = new System.Drawing.Point(30, 156);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(496, 31);
            this.AddBox.TabIndex = 3;
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
            // CityBox
            // 
            this.CityBox.Enabled = false;
            this.CityBox.Location = new System.Drawing.Point(30, 247);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(243, 31);
            this.CityBox.TabIndex = 5;
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
            // StateBox
            // 
            this.StateBox.Enabled = false;
            this.StateBox.Location = new System.Drawing.Point(302, 247);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(81, 31);
            this.StateBox.TabIndex = 7;
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
            // ZipBox
            // 
            this.ZipBox.Enabled = false;
            this.ZipBox.Location = new System.Drawing.Point(412, 247);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(114, 31);
            this.ZipBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SButton);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.ZipBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddBox);
            this.groupBox1.Controls.Add(this.StateBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CityBox);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 454);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // CButton
            // 
            this.CButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.CButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.CButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.CButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CButton.Location = new System.Drawing.Point(296, 301);
            this.CButton.Name = "CButton";
            this.CButton.PulseSpeed = 0.2F;
            this.CButton.Size = new System.Drawing.Size(230, 101);
            this.CButton.TabIndex = 14;
            this.CButton.Text = "Close";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButtonClick);
            // 
            // SButton
            // 
            this.SButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.SButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.SButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.SButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SButton.Location = new System.Drawing.Point(30, 301);
            this.SButton.Name = "SButton";
            this.SButton.PulseSpeed = 0.2F;
            this.SButton.Size = new System.Drawing.Size(230, 101);
            this.SButton.TabIndex = 13;
            this.SButton.Text = "Save";
            this.SButton.UseVisualStyleBackColor = true;
            this.SButton.Click += new System.EventHandler(this.SButtonClick);
            // 
            // SchoolAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 527);
            this.Controls.Add(this.groupBox1);
            this.Name = "SchoolAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add School";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ZipBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private Lcasp.PulseButton CButton;
        private Lcasp.PulseButton SButton;
    }
}