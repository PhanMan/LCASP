namespace LCASP
{
    partial class ArcherAdd
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new LCASP.PulseButton();
            this.cancelButton = new LCASP.PulseButton();
            this.importButton = new LCASP.PulseButton();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(54, 78);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(616, 31);
            this.nameBox.TabIndex = 0;
            // 
            // sexBox
            // 
            this.sexBox.Location = new System.Drawing.Point(713, 78);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(170, 31);
            this.sexBox.TabIndex = 1;
            this.sexBox.TextChanged += new System.EventHandler(this.sexBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archer Sex (M/F)";
            // 
            // saveButton
            // 
            this.saveButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.saveButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.saveButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(75, 145);
            this.saveButton.Name = "saveButton";
            this.saveButton.PulseSpeed = 0.2F;
            this.saveButton.Size = new System.Drawing.Size(230, 101);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.cancelButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.cancelButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(575, 145);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PulseSpeed = 0.2F;
            this.cancelButton.Size = new System.Drawing.Size(230, 101);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // importButton
            // 
            this.importButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.importButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.importButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.importButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.importButton.Location = new System.Drawing.Point(325, 145);
            this.importButton.Name = "importButton";
            this.importButton.PulseSpeed = 0.2F;
            this.importButton.Size = new System.Drawing.Size(230, 101);
            this.importButton.TabIndex = 24;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // ArcherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 285);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.nameBox);
            this.Name = "ArcherAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddArcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox sexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PulseButton saveButton;
        private PulseButton cancelButton;
        private PulseButton importButton;
    }
}