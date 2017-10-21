namespace Lcasp
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new Lcasp.PulseButton();
            this.cancelButton = new Lcasp.PulseButton();
            this.importButton = new Lcasp.PulseButton();
            this.StateIDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(54, 78);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(616, 31);
            this.NameBox.TabIndex = 0;
            // 
            // SexBox
            // 
            this.SexBox.Location = new System.Drawing.Point(885, 78);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(170, 31);
            this.SexBox.TabIndex = 1;
            this.SexBox.TextChanged += new System.EventHandler(this.sexBox_TextChanged);
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
            this.label2.Location = new System.Drawing.Point(880, 29);
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
            this.cancelButton.Location = new System.Drawing.Point(793, 145);
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
            this.importButton.Location = new System.Drawing.Point(440, 145);
            this.importButton.Name = "importButton";
            this.importButton.PulseSpeed = 0.2F;
            this.importButton.Size = new System.Drawing.Size(230, 101);
            this.importButton.TabIndex = 24;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // StateIDBox
            // 
            this.StateIDBox.Location = new System.Drawing.Point(697, 78);
            this.StateIDBox.Name = "StateIDBox";
            this.StateIDBox.Size = new System.Drawing.Size(170, 31);
            this.StateIDBox.TabIndex = 25;
            this.StateIDBox.TextChanged += new System.EventHandler(this.StateIDBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "AIMS ID";
            // 
            // ArcherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StateIDBox);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.NameBox);
            this.Name = "ArcherAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddArcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PulseButton saveButton;
        private PulseButton cancelButton;
        private PulseButton importButton;
        private System.Windows.Forms.TextBox StateIDBox;
        private System.Windows.Forms.Label label3;
    }
}