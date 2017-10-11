namespace LCASP
{
    partial class SchoolMaintain
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
            this.schoolCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cButton = new LCASP.PulseButton();
            this.dButton = new LCASP.PulseButton();
            this.aButton = new LCASP.PulseButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoolCombo
            // 
            this.schoolCombo.FormattingEnabled = true;
            this.schoolCombo.Location = new System.Drawing.Point(26, 51);
            this.schoolCombo.Name = "schoolCombo";
            this.schoolCombo.Size = new System.Drawing.Size(742, 33);
            this.schoolCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cButton);
            this.groupBox1.Controls.Add(this.schoolCombo);
            this.groupBox1.Controls.Add(this.dButton);
            this.groupBox1.Controls.Add(this.aButton);
            this.groupBox1.Location = new System.Drawing.Point(33, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "School Information";
            // 
            // cButton
            // 
            this.cButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.cButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.cButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.cButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cButton.Location = new System.Drawing.Point(538, 139);
            this.cButton.Name = "cButton";
            this.cButton.PulseSpeed = 0.2F;
            this.cButton.Size = new System.Drawing.Size(230, 101);
            this.cButton.TabIndex = 16;
            this.cButton.Text = "Close";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // dButton
            // 
            this.dButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.dButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.dButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.dButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dButton.Location = new System.Drawing.Point(284, 139);
            this.dButton.Name = "dButton";
            this.dButton.PulseSpeed = 0.2F;
            this.dButton.Size = new System.Drawing.Size(230, 101);
            this.dButton.TabIndex = 15;
            this.dButton.Text = "Delete";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // aButton
            // 
            this.aButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.aButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.aButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.aButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aButton.Location = new System.Drawing.Point(26, 139);
            this.aButton.Name = "aButton";
            this.aButton.PulseSpeed = 0.2F;
            this.aButton.Size = new System.Drawing.Size(230, 101);
            this.aButton.TabIndex = 14;
            this.aButton.Text = "Add";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // SchoolMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SchoolMaintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SchoolMaintain";
            this.Load += new System.EventHandler(this.SchoolMaintain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox schoolCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private LCASP.PulseButton cButton;
        private LCASP.PulseButton dButton;
        private LCASP.PulseButton aButton;
    }
}