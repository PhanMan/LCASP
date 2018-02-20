namespace Lcasp
{
    partial class InterimSchoolChoice
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
            this.cancelButton = new Lcasp.PulseButton();
            this.PrintButton = new Lcasp.PulseButton();
            this.SchoolComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.cancelButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.cancelButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(415, 191);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PulseSpeed = 0.5F;
            this.cancelButton.PulseWidth = 20;
            this.cancelButton.Size = new System.Drawing.Size(368, 195);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.PrintButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.PrintButton.Enabled = false;
            this.PrintButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.PrintButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PrintButton.Location = new System.Drawing.Point(41, 191);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.PulseSpeed = 0.5F;
            this.PrintButton.PulseWidth = 20;
            this.PrintButton.Size = new System.Drawing.Size(368, 195);
            this.PrintButton.TabIndex = 27;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.ScoreMatch_Button);
            // 
            // SchoolComboBox
            // 
            this.SchoolComboBox.FormattingEnabled = true;
            this.SchoolComboBox.Location = new System.Drawing.Point(54, 93);
            this.SchoolComboBox.Name = "SchoolComboBox";
            this.SchoolComboBox.Size = new System.Drawing.Size(729, 33);
            this.SchoolComboBox.TabIndex = 28;
            this.SchoolComboBox.SelectedIndexChanged += new System.EventHandler(this.SchoolComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select School to Print";
            // 
            // InterimSchoolChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SchoolComboBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "InterimSchoolChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose School to Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PulseButton cancelButton;
        private PulseButton PrintButton;
        private System.Windows.Forms.ComboBox SchoolComboBox;
        private System.Windows.Forms.Label label1;
    }
}