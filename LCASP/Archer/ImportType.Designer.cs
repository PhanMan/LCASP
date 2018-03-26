namespace Lcasp
{
    partial class ImportType
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
            this.nsButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InsButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new Lcasp.PulseButton();
            this.cancelButton = new Lcasp.PulseButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsButton
            // 
            this.nsButton.AutoSize = true;
            this.nsButton.Location = new System.Drawing.Point(41, 37);
            this.nsButton.Name = "nsButton";
            this.nsButton.Size = new System.Drawing.Size(155, 29);
            this.nsButton.TabIndex = 0;
            this.nsButton.TabStop = true;
            this.nsButton.Text = "Manual File";
            this.nsButton.UseVisualStyleBackColor = true;
            this.nsButton.CheckedChanged += new System.EventHandler(this.NsButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InsButton);
            this.panel1.Controls.Add(this.nsButton);
            this.panel1.Location = new System.Drawing.Point(112, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 209);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "AIMS ID, First Last, Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Last,Sex";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InsButton
            // 
            this.InsButton.AutoSize = true;
            this.InsButton.Location = new System.Drawing.Point(41, 130);
            this.InsButton.Name = "InsButton";
            this.InsButton.Size = new System.Drawing.Size(195, 29);
            this.InsButton.TabIndex = 2;
            this.InsButton.TabStop = true;
            this.InsButton.Text = "AIMS Download";
            this.InsButton.UseVisualStyleBackColor = true;
            this.InsButton.CheckedChanged += new System.EventHandler(this.InsButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the type of import.";
            // 
            // okButton
            // 
            this.okButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.okButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.okButton.Enabled = false;
            this.okButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.okButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.okButton.Location = new System.Drawing.Point(30, 314);
            this.okButton.Name = "okButton";
            this.okButton.PulseSpeed = 0.2F;
            this.okButton.Size = new System.Drawing.Size(230, 101);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.cancelButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.cancelButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(266, 314);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PulseSpeed = 0.2F;
            this.cancelButton.Size = new System.Drawing.Size(230, 101);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ImportType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 517);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ImportType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImportType";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton nsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private PulseButton okButton;
        private PulseButton cancelButton;
        private System.Windows.Forms.RadioButton InsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}