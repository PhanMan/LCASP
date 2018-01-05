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
            this.nasButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new Lcasp.PulseButton();
            this.cancelButton = new Lcasp.PulseButton();
            this.InsButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsButton
            // 
            this.nsButton.AutoSize = true;
            this.nsButton.Location = new System.Drawing.Point(41, 38);
            this.nsButton.Name = "nsButton";
            this.nsButton.Size = new System.Drawing.Size(148, 29);
            this.nsButton.TabIndex = 0;
            this.nsButton.TabStop = true;
            this.nsButton.Text = "Name, Sex";
            this.nsButton.UseVisualStyleBackColor = true;
            this.nsButton.CheckedChanged += new System.EventHandler(this.NsButton_CheckedChanged);
            // 
            // nasButton
            // 
            this.nasButton.AutoSize = true;
            this.nasButton.Location = new System.Drawing.Point(41, 84);
            this.nasButton.Name = "nasButton";
            this.nasButton.Size = new System.Drawing.Size(237, 29);
            this.nasButton.TabIndex = 1;
            this.nasButton.TabStop = true;
            this.nasButton.Text = "Name, AIMS ID, Sex";
            this.nasButton.UseVisualStyleBackColor = true;
            this.nasButton.CheckedChanged += new System.EventHandler(this.NasButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.InsButton);
            this.panel1.Controls.Add(this.nasButton);
            this.panel1.Controls.Add(this.nsButton);
            this.panel1.Location = new System.Drawing.Point(112, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 209);
            this.panel1.TabIndex = 3;
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
            // InsButton
            // 
            this.InsButton.AutoSize = true;
            this.InsButton.Location = new System.Drawing.Point(41, 130);
            this.InsButton.Name = "InsButton";
            this.InsButton.Size = new System.Drawing.Size(237, 29);
            this.InsButton.TabIndex = 2;
            this.InsButton.TabStop = true;
            this.InsButton.Text = "AIMS ID, Name, Sex";
            this.InsButton.UseVisualStyleBackColor = true;
            this.InsButton.CheckedChanged += new System.EventHandler(this.InsButton_CheckedChanged);
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
        private System.Windows.Forms.RadioButton nasButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private PulseButton okButton;
        private PulseButton cancelButton;
        private System.Windows.Forms.RadioButton InsButton;
    }
}