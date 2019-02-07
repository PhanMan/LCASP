namespace Lcasp
{
    partial class SiteNameForm
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
            this.SaveButton = new Lcasp.PulseButton();
            this.MyCancelButton = new Lcasp.PulseButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SiteNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.SaveButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.SaveButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveButton.Location = new System.Drawing.Point(89, 304);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.PulseSpeed = 0.5F;
            this.SaveButton.PulseWidth = 20;
            this.SaveButton.Size = new System.Drawing.Size(368, 195);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.MyCancelButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.MyCancelButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.MyCancelButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MyCancelButton.Location = new System.Drawing.Point(489, 304);
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.PulseSpeed = 0.5F;
            this.MyCancelButton.PulseWidth = 20;
            this.MyCancelButton.Size = new System.Drawing.Size(368, 195);
            this.MyCancelButton.TabIndex = 29;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Enter School or Organization Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SiteNameBox
            // 
            this.SiteNameBox.Location = new System.Drawing.Point(220, 222);
            this.SiteNameBox.Name = "SiteNameBox";
            this.SiteNameBox.Size = new System.Drawing.Size(522, 31);
            this.SiteNameBox.TabIndex = 31;
            this.SiteNameBox.TextChanged += new System.EventHandler(this.SiteNameBox_TextChanged);
            // 
            // SiteNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 547);
            this.Controls.Add(this.SiteNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "SiteNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Site Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PulseButton SaveButton;
        private PulseButton MyCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SiteNameBox;
    }
}