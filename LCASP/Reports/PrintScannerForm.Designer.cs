namespace Lcasp
{
    partial class PrintScannerForm
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
            this.SchoolComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cButton = new Lcasp.PulseButton();
            this.PrintButton = new Lcasp.PulseButton();
            this.ScanFormComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ArcherComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HoroText = new System.Windows.Forms.TextBox();
            this.VerticalAdjust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sCombo
            // 
            this.SchoolComboBox.FormattingEnabled = true;
            this.SchoolComboBox.Location = new System.Drawing.Point(33, 77);
            this.SchoolComboBox.Name = "sCombo";
            this.SchoolComboBox.Size = new System.Drawing.Size(708, 33);
            this.SchoolComboBox.TabIndex = 0;
            this.SchoolComboBox.SelectedIndexChanged += new System.EventHandler(this.SCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select School";
            // 
            // cButton
            // 
            this.cButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.cButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.cButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.cButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cButton.Location = new System.Drawing.Point(393, 489);
            this.cButton.Name = "cButton";
            this.cButton.PulseSpeed = 0.2F;
            this.cButton.Size = new System.Drawing.Size(230, 101);
            this.cButton.TabIndex = 18;
            this.cButton.Text = "Close";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // printButton
            // 
            this.PrintButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.PrintButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.PrintButton.Enabled = false;
            this.PrintButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.PrintButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PrintButton.Location = new System.Drawing.Point(104, 489);
            this.PrintButton.Name = "printButton";
            this.PrintButton.PulseSpeed = 0.2F;
            this.PrintButton.Size = new System.Drawing.Size(230, 101);
            this.PrintButton.TabIndex = 19;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // scanFormBox
            // 
            this.ScanFormComboBox.FormattingEnabled = true;
            this.ScanFormComboBox.Location = new System.Drawing.Point(33, 286);
            this.ScanFormComboBox.Name = "scanFormBox";
            this.ScanFormComboBox.Size = new System.Drawing.Size(708, 33);
            this.ScanFormComboBox.TabIndex = 20;
            this.ScanFormComboBox.SelectedIndexChanged += new System.EventHandler(this.ScanFormBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select Scan Form";
            // 
            // aCombo
            // 
            this.ArcherComboBox.FormattingEnabled = true;
            this.ArcherComboBox.Location = new System.Drawing.Point(33, 176);
            this.ArcherComboBox.Name = "aCombo";
            this.ArcherComboBox.Size = new System.Drawing.Size(708, 33);
            this.ArcherComboBox.TabIndex = 22;
            this.ArcherComboBox.SelectedIndexChanged += new System.EventHandler(this.ArcherCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Select Archer";
            // 
            // HoroText
            // 
            this.HoroText.Location = new System.Drawing.Point(118, 63);
            this.HoroText.Name = "HoroText";
            this.HoroText.Size = new System.Drawing.Size(100, 31);
            this.HoroText.TabIndex = 24;
            this.HoroText.Text = "0";
            this.HoroText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HoroText.TextChanged += new System.EventHandler(this.HoroText_TextChanged);
            // 
            // VerticalAdjust
            // 
            this.VerticalAdjust.Location = new System.Drawing.Point(411, 63);
            this.VerticalAdjust.Name = "VerticalAdjust";
            this.VerticalAdjust.Size = new System.Drawing.Size(100, 31);
            this.VerticalAdjust.TabIndex = 25;
            this.VerticalAdjust.Text = "0";
            this.VerticalAdjust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VerticalAdjust.TextChanged += new System.EventHandler(this.VerticalAdjust_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Horozontal Adjust";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Vertical Adjust";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VerticalAdjust);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.HoroText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(63, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 106);
            this.panel1.TabIndex = 28;
            // 
            // PrintScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 647);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArcherComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScanFormComboBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SchoolComboBox);
            this.Name = "PrintScannerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Scanner Form";
            this.Load += new System.EventHandler(this.PrintScannerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SchoolComboBox;
        private System.Windows.Forms.Label label1;
        private PulseButton cButton;
        private PulseButton PrintButton;
        private System.Windows.Forms.ComboBox ScanFormComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ArcherComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HoroText;
        private System.Windows.Forms.TextBox VerticalAdjust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}