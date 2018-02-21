namespace Lcasp
{
    partial class RealTimeDisplay
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
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DataListBox
            // 
            this.DataListBox.BackColor = System.Drawing.Color.Black;
            this.DataListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataListBox.ForeColor = System.Drawing.Color.White;
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.ItemHeight = 25;
            this.DataListBox.Location = new System.Drawing.Point(0, 0);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(2043, 1224);
            this.DataListBox.TabIndex = 26;
            // 
            // RealTimeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2043, 1224);
            this.Controls.Add(this.DataListBox);
            this.Name = "RealTimeDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LCASP Real Time Scoring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RealTimeDisplay_FormClosing);
            this.Load += new System.EventHandler(this.RealTimeDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DataListBox;
    }
}