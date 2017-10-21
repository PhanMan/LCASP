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
            this.sCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cButton = new Lcasp.PulseButton();
            this.printButton = new Lcasp.PulseButton();
            this.scanFormBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sCombo
            // 
            this.sCombo.FormattingEnabled = true;
            this.sCombo.Location = new System.Drawing.Point(33, 77);
            this.sCombo.Name = "sCombo";
            this.sCombo.Size = new System.Drawing.Size(708, 33);
            this.sCombo.TabIndex = 0;
            this.sCombo.SelectedIndexChanged += new System.EventHandler(this.sCombo_SelectedIndexChanged);
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
            this.cButton.Location = new System.Drawing.Point(414, 247);
            this.cButton.Name = "cButton";
            this.cButton.PulseSpeed = 0.2F;
            this.cButton.Size = new System.Drawing.Size(230, 101);
            this.cButton.TabIndex = 18;
            this.cButton.Text = "Close";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // printButton
            // 
            this.printButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.printButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.printButton.Enabled = false;
            this.printButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.printButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.printButton.Location = new System.Drawing.Point(108, 247);
            this.printButton.Name = "printButton";
            this.printButton.PulseSpeed = 0.2F;
            this.printButton.Size = new System.Drawing.Size(230, 101);
            this.printButton.TabIndex = 19;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // scanFormBox
            // 
            this.scanFormBox.FormattingEnabled = true;
            this.scanFormBox.Location = new System.Drawing.Point(33, 177);
            this.scanFormBox.Name = "scanFormBox";
            this.scanFormBox.Size = new System.Drawing.Size(708, 33);
            this.scanFormBox.TabIndex = 20;
            this.scanFormBox.SelectedIndexChanged += new System.EventHandler(this.scanFormBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select Scan Form";
            // 
            // PrintScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scanFormBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sCombo);
            this.Name = "PrintScannerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Scanner Form";
            this.Load += new System.EventHandler(this.PrintScannerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sCombo;
        private System.Windows.Forms.Label label1;
        private PulseButton cButton;
        private PulseButton printButton;
        private System.Windows.Forms.ComboBox scanFormBox;
        private System.Windows.Forms.Label label2;
    }
}