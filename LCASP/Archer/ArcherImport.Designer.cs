namespace LCASP
{
    partial class ArcherImport
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
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iButton = new LCASP.PulseButton();
            this.cButton = new LCASP.PulseButton();
            this.SuspendLayout();
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(56, 81);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(782, 31);
            this.fileNameBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // chooseButton
            // 
            this.chooseButton.BackgroundImage = global::LCASP.Properties.Resources.images;
            this.chooseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseButton.Location = new System.Drawing.Point(866, 66);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(62, 60);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Import CSV file.";
            // 
            // iButton
            // 
            this.iButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.iButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.iButton.Enabled = false;
            this.iButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.iButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iButton.Location = new System.Drawing.Point(168, 161);
            this.iButton.Name = "iButton";
            this.iButton.PulseSpeed = 0.2F;
            this.iButton.Size = new System.Drawing.Size(230, 101);
            this.iButton.TabIndex = 24;
            this.iButton.Text = "Import";
            this.iButton.UseVisualStyleBackColor = true;
            this.iButton.Click += new System.EventHandler(this.iButton_Click);
            // 
            // cButton
            // 
            this.cButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.cButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.cButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.cButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cButton.Location = new System.Drawing.Point(619, 161);
            this.cButton.Name = "cButton";
            this.cButton.PulseSpeed = 0.2F;
            this.cButton.Size = new System.Drawing.Size(230, 101);
            this.cButton.TabIndex = 25;
            this.cButton.Text = "Close";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // importForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 323);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.iButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.fileNameBox);
            this.Name = "importForm";
            this.Text = "importForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label label1;
        private PulseButton iButton;
        private PulseButton cButton;
    }
}