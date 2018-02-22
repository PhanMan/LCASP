namespace Lcasp
{
    partial class LCASPMain
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
            this.aSchoolButton = new Lcasp.PulseButton();
            this.exitButton = new Lcasp.PulseButton();
            this.aArcherButton = new Lcasp.PulseButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectScoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetButton = new Lcasp.PulseButton();
            this.psButton = new Lcasp.PulseButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aSchoolButton
            // 
            this.aSchoolButton.BackColor = System.Drawing.SystemColors.Control;
            this.aSchoolButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.aSchoolButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.aSchoolButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.aSchoolButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSchoolButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aSchoolButton.Location = new System.Drawing.Point(30, 69);
            this.aSchoolButton.Name = "aSchoolButton";
            this.aSchoolButton.PulseSpeed = 0.5F;
            this.aSchoolButton.PulseWidth = 20;
            this.aSchoolButton.Size = new System.Drawing.Size(476, 233);
            this.aSchoolButton.TabIndex = 1;
            this.aSchoolButton.Text = "Maintain Schools";
            this.aSchoolButton.UseVisualStyleBackColor = false;
            this.aSchoolButton.Click += new System.EventHandler(this.ASchool_Button);
            // 
            // exitButton
            // 
            this.exitButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.exitButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.exitButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(795, 308);
            this.exitButton.Name = "exitButton";
            this.exitButton.PulseSpeed = 0.5F;
            this.exitButton.PulseWidth = 20;
            this.exitButton.Size = new System.Drawing.Size(476, 233);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // aArcherButton
            // 
            this.aArcherButton.BackColor = System.Drawing.SystemColors.Control;
            this.aArcherButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.aArcherButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.aArcherButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.aArcherButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aArcherButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aArcherButton.Location = new System.Drawing.Point(524, 69);
            this.aArcherButton.Name = "aArcherButton";
            this.aArcherButton.PulseSpeed = 0.5F;
            this.aArcherButton.PulseWidth = 20;
            this.aArcherButton.Size = new System.Drawing.Size(476, 233);
            this.aArcherButton.TabIndex = 3;
            this.aArcherButton.Text = "Maintain Archers";
            this.aArcherButton.UseVisualStyleBackColor = false;
            this.aArcherButton.Click += new System.EventHandler(this.ArcherButton_CLick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1558, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectScoresMenuItem,
            this.toolStripSeparator1,
            this.clearDatabaseToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // projectScoresMenuItem
            // 
            this.projectScoresMenuItem.CheckOnClick = true;
            this.projectScoresMenuItem.Name = "projectScoresMenuItem";
            this.projectScoresMenuItem.Size = new System.Drawing.Size(298, 38);
            this.projectScoresMenuItem.Text = "Project Scores";
            this.projectScoresMenuItem.Click += new System.EventHandler(this.projectScoresMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(295, 6);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(298, 38);
            this.clearDatabaseToolStripMenuItem.Text = "Clear Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ClearDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(295, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(298, 38);
            this.toolStripMenuItem1.Text = "Backup Database";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.backupDatabaseMenuClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(295, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(298, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // meetButton
            // 
            this.meetButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.meetButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.meetButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.meetButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.meetButton.Location = new System.Drawing.Point(272, 308);
            this.meetButton.Name = "meetButton";
            this.meetButton.PulseSpeed = 0.5F;
            this.meetButton.PulseWidth = 20;
            this.meetButton.Size = new System.Drawing.Size(476, 233);
            this.meetButton.TabIndex = 5;
            this.meetButton.Text = "Scan Results";
            this.meetButton.UseVisualStyleBackColor = true;
            this.meetButton.Click += new System.EventHandler(this.MeetButton_Click);
            // 
            // psButton
            // 
            this.psButton.BackColor = System.Drawing.SystemColors.Control;
            this.psButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.psButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.psButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.psButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.psButton.Location = new System.Drawing.Point(1018, 69);
            this.psButton.Name = "psButton";
            this.psButton.PulseSpeed = 0.5F;
            this.psButton.PulseWidth = 20;
            this.psButton.Size = new System.Drawing.Size(476, 233);
            this.psButton.TabIndex = 6;
            this.psButton.Text = "Print Scan Forms";
            this.psButton.UseVisualStyleBackColor = false;
            this.psButton.Click += new System.EventHandler(this.PsButton_Click);
            // 
            // LCASPMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1558, 571);
            this.Controls.Add(this.psButton);
            this.Controls.Add(this.meetButton);
            this.Controls.Add(this.aArcherButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aSchoolButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LCASPMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCASP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Lcasp.PulseButton aSchoolButton;
        private Lcasp.PulseButton exitButton;
        private Lcasp.PulseButton aArcherButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private PulseButton meetButton;
        private PulseButton psButton;
        private System.Windows.Forms.ToolStripMenuItem projectScoresMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

