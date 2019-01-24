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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.projectScoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printInterimScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printFinalScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleScoreReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maleScoreReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printOverallScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.setComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualCOMSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psButton = new Lcasp.PulseButton();
            this.meetButton = new Lcasp.PulseButton();
            this.aArcherButton = new Lcasp.PulseButton();
            this.exitButton = new Lcasp.PulseButton();
            this.aSchoolButton = new Lcasp.PulseButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1558, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.projectScoresMenuItem,
            this.toolStripSeparator1,
            this.databaseToolStripMenuItem,
            this.toolStripSeparator3,
            this.scoringToolStripMenuItem,
            this.toolStripSeparator5,
            this.setComPortToolStripMenuItem,
            this.toolStripSeparator7,
            this.exitToolStripMenuItem,
            this.toolStripSeparator6});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(265, 6);
            // 
            // projectScoresMenuItem
            // 
            this.projectScoresMenuItem.CheckOnClick = true;
            this.projectScoresMenuItem.Name = "projectScoresMenuItem";
            this.projectScoresMenuItem.Size = new System.Drawing.Size(268, 38);
            this.projectScoresMenuItem.Text = "Project Scores";
            this.projectScoresMenuItem.Click += new System.EventHandler(this.projectScoresMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDatabaseToolStripMenuItem1,
            this.backupDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // clearDatabaseToolStripMenuItem1
            // 
            this.clearDatabaseToolStripMenuItem1.Name = "clearDatabaseToolStripMenuItem1";
            this.clearDatabaseToolStripMenuItem1.Size = new System.Drawing.Size(296, 38);
            this.clearDatabaseToolStripMenuItem1.Text = "Clear Database";
            this.clearDatabaseToolStripMenuItem1.Click += new System.EventHandler(this.ClearDatabaseClick);
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.backupDatabaseToolStripMenuItem.Text = "Backup Database";
            this.backupDatabaseToolStripMenuItem.Click += new System.EventHandler(this.BackupDatabaseClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(265, 6);
            // 
            // scoringToolStripMenuItem
            // 
            this.scoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printInterimScoresToolStripMenuItem,
            this.printFinalScoresToolStripMenuItem,
            this.printOverallScoresToolStripMenuItem,
            this.femaleScoreReportToolStripMenuItem1,
            this.maleScoreReportToolStripMenuItem1});
            this.scoringToolStripMenuItem.Name = "scoringToolStripMenuItem";
            this.scoringToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.scoringToolStripMenuItem.Text = "Scoring";
            // 
            // printInterimScoresToolStripMenuItem
            // 
            this.printInterimScoresToolStripMenuItem.Name = "printInterimScoresToolStripMenuItem";
            this.printInterimScoresToolStripMenuItem.Size = new System.Drawing.Size(334, 38);
            this.printInterimScoresToolStripMenuItem.Text = "Print Interim Scores";
            this.printInterimScoresToolStripMenuItem.Click += new System.EventHandler(this.printInterimScoresToolStripMenuItem_Click);
            // 
            // printFinalScoresToolStripMenuItem
            // 
            this.printFinalScoresToolStripMenuItem.Name = "printFinalScoresToolStripMenuItem";
            this.printFinalScoresToolStripMenuItem.Size = new System.Drawing.Size(334, 38);
            this.printFinalScoresToolStripMenuItem.Text = "Print Final Scores";
            this.printFinalScoresToolStripMenuItem.Click += new System.EventHandler(this.printFinalScoresToolStripMenuItem_Click);
            // 
            // femaleScoreReportToolStripMenuItem1
            // 
            this.femaleScoreReportToolStripMenuItem1.Name = "femaleScoreReportToolStripMenuItem1";
            this.femaleScoreReportToolStripMenuItem1.Size = new System.Drawing.Size(334, 38);
            this.femaleScoreReportToolStripMenuItem1.Text = "Female Score Report";
            this.femaleScoreReportToolStripMenuItem1.Click += new System.EventHandler(this.FemaleScoreReportClick);
            // 
            // maleScoreReportToolStripMenuItem1
            // 
            this.maleScoreReportToolStripMenuItem1.Name = "maleScoreReportToolStripMenuItem1";
            this.maleScoreReportToolStripMenuItem1.Size = new System.Drawing.Size(334, 38);
            this.maleScoreReportToolStripMenuItem1.Text = "Male Score Report";
            this.maleScoreReportToolStripMenuItem1.Click += new System.EventHandler(this.MaleScoreReportClick);
            // 
            // printOverallScoresToolStripMenuItem
            // 
            this.printOverallScoresToolStripMenuItem.Name = "printOverallScoresToolStripMenuItem";
            this.printOverallScoresToolStripMenuItem.Size = new System.Drawing.Size(334, 38);
            this.printOverallScoresToolStripMenuItem.Text = "Print Overall Scores";
            this.printOverallScoresToolStripMenuItem.Click += new System.EventHandler(this.OverallScoreClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(265, 6);
            // 
            // setComPortToolStripMenuItem
            // 
            this.setComPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualCOMSetupToolStripMenuItem});
            this.setComPortToolStripMenuItem.Name = "setComPortToolStripMenuItem";
            this.setComPortToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.setComPortToolStripMenuItem.Text = "Manual Setup";
            // 
            // manualCOMSetupToolStripMenuItem
            // 
            this.manualCOMSetupToolStripMenuItem.Name = "manualCOMSetupToolStripMenuItem";
            this.manualCOMSetupToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.manualCOMSetupToolStripMenuItem.Text = "Manual COM Setup";
            this.manualCOMSetupToolStripMenuItem.Click += new System.EventHandler(this.manualCOMSetupToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(265, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(265, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
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
        private PulseButton meetButton;
        private PulseButton psButton;
        private System.Windows.Forms.ToolStripMenuItem projectScoresMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem setComPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem manualCOMSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printInterimScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printFinalScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femaleScoreReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maleScoreReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printOverallScoresToolStripMenuItem;
    }
}

