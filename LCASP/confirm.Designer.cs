namespace LCASP
{
    partial class Confirm
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
            this.yesButton = new LCASP.PulseButton();
            this.noButton = new LCASP.PulseButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you SURE?";
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.SystemColors.Control;
            this.yesButton.ButtonColorBottom = System.Drawing.Color.Crimson;
            this.yesButton.ButtonColorTop = System.Drawing.Color.Red;
            this.yesButton.FocusColor = System.Drawing.Color.DarkRed;
            this.yesButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yesButton.Location = new System.Drawing.Point(81, 131);
            this.yesButton.Name = "yesButton";
            this.yesButton.PulseSpeed = 0.5F;
            this.yesButton.PulseWidth = 30;
            this.yesButton.Size = new System.Drawing.Size(430, 223);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.SystemColors.Control;
            this.noButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.noButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.noButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.noButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noButton.Location = new System.Drawing.Point(583, 131);
            this.noButton.Name = "noButton";
            this.noButton.PulseSpeed = 0.2F;
            this.noButton.PulseWidth = 20;
            this.noButton.Size = new System.Drawing.Size(430, 223);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 409);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.Name = "confirm";
            this.Text = "confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PulseButton yesButton;
        private PulseButton noButton;
    }
}