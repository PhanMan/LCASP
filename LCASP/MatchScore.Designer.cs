namespace LCASP
{
    partial class MatchScore
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
            this.cancelButton = new LCASP.PulseButton();
            this.dataList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smButton = new LCASP.PulseButton();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.cancelButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.cancelButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(1228, 920);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PulseSpeed = 0.2F;
            this.cancelButton.Size = new System.Drawing.Size(230, 101);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dataList
            // 
            this.dataList.FormattingEnabled = true;
            this.dataList.ItemHeight = 25;
            this.dataList.Location = new System.Drawing.Point(39, 75);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(1821, 829);
            this.dataList.TabIndex = 25;
            this.dataList.SelectedIndexChanged += new System.EventHandler(this.dataList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(970, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Archer Name       Score      10\'s      9\'s       8\'s      7\'s       6\'s       5\'s" +
    "      4\'s      3\'s       2\'s       1\'s      0\'s";
            // 
            // smButton
            // 
            this.smButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.smButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.smButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.smButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.smButton.Location = new System.Drawing.Point(322, 920);
            this.smButton.Name = "smButton";
            this.smButton.PulseSpeed = 0.2F;
            this.smButton.Size = new System.Drawing.Size(230, 101);
            this.smButton.TabIndex = 27;
            this.smButton.Text = "Score Match";
            this.smButton.UseVisualStyleBackColor = true;
            this.smButton.Click += new System.EventHandler(this.scoreMatch_Button);
            // 
            // MatchScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1047);
            this.Controls.Add(this.smButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.cancelButton);
            this.Name = "MatchScore";
            this.Text = "MatchScore";
            this.Load += new System.EventHandler(this.MatchScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PulseButton cancelButton;
        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.Label label1;
        private PulseButton smButton;
    }
}