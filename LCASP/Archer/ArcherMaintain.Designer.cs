namespace LCASP
{
    partial class ArcherMaintain
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
            this.cButton = new LCASP.PulseButton();
            this.aCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aButton = new LCASP.PulseButton();
            this.dButton = new LCASP.PulseButton();
            this.SuspendLayout();
            // 
            // sCombo
            // 
            this.sCombo.FormattingEnabled = true;
            this.sCombo.Location = new System.Drawing.Point(36, 87);
            this.sCombo.Name = "sCombo";
            this.sCombo.Size = new System.Drawing.Size(702, 33);
            this.sCombo.TabIndex = 0;
            this.sCombo.SelectedIndexChanged += new System.EventHandler(this.schoolCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
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
            this.cButton.Location = new System.Drawing.Point(508, 287);
            this.cButton.Name = "cButton";
            this.cButton.PulseSpeed = 0.2F;
            this.cButton.Size = new System.Drawing.Size(230, 101);
            this.cButton.TabIndex = 17;
            this.cButton.Text = "Close";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // aCombo
            // 
            this.aCombo.Enabled = false;
            this.aCombo.FormattingEnabled = true;
            this.aCombo.Location = new System.Drawing.Point(36, 206);
            this.aCombo.Name = "aCombo";
            this.aCombo.Size = new System.Drawing.Size(702, 33);
            this.aCombo.TabIndex = 18;
            this.aCombo.SelectedIndexChanged += new System.EventHandler(this.aCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Archer";
            // 
            // aButton
            // 
            this.aButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.aButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.aButton.Enabled = false;
            this.aButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.aButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aButton.Location = new System.Drawing.Point(36, 287);
            this.aButton.Name = "aButton";
            this.aButton.PulseSpeed = 0.2F;
            this.aButton.Size = new System.Drawing.Size(230, 101);
            this.aButton.TabIndex = 20;
            this.aButton.Text = "Add";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // dButton
            // 
            this.dButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.dButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.dButton.Enabled = false;
            this.dButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.dButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dButton.Location = new System.Drawing.Point(272, 287);
            this.dButton.Name = "dButton";
            this.dButton.PulseSpeed = 0.2F;
            this.dButton.Size = new System.Drawing.Size(230, 101);
            this.dButton.TabIndex = 21;
            this.dButton.Text = "Delete";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // ArcherMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 446);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aCombo);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sCombo);
            this.Name = "ArcherMaintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArcherMaintain";
            this.Load += new System.EventHandler(this.ArcherMaintain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sCombo;
        private System.Windows.Forms.Label label1;
        private LCASP.PulseButton cButton;
        private System.Windows.Forms.ComboBox aCombo;
        private System.Windows.Forms.Label label2;
        private LCASP.PulseButton aButton;
        private LCASP.PulseButton dButton;
    }
}