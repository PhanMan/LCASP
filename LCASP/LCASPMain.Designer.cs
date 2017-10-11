﻿namespace LCASP
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
            this.aSchoolButton = new LCASP.PulseButton();
            this.exitButton = new LCASP.PulseButton();
            this.aArcherButton = new LCASP.PulseButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetButton = new LCASP.PulseButton();
            this.psButton = new LCASP.PulseButton();
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
            this.aSchoolButton.Location = new System.Drawing.Point(35, 331);
            this.aSchoolButton.Name = "aSchoolButton";
            this.aSchoolButton.PulseSpeed = 0.2F;
            this.aSchoolButton.PulseWidth = 20;
            this.aSchoolButton.Size = new System.Drawing.Size(476, 233);
            this.aSchoolButton.TabIndex = 1;
            this.aSchoolButton.Text = "Add / Delete Schools";
            this.aSchoolButton.UseVisualStyleBackColor = false;
            this.aSchoolButton.Click += new System.EventHandler(this.aSchool_Button);
            // 
            // exitButton
            // 
            this.exitButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.exitButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.exitButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(792, 92);
            this.exitButton.Name = "exitButton";
            this.exitButton.PulseSpeed = 0.2F;
            this.exitButton.PulseWidth = 20;
            this.exitButton.Size = new System.Drawing.Size(476, 233);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aArcherButton
            // 
            this.aArcherButton.BackColor = System.Drawing.SystemColors.Control;
            this.aArcherButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.aArcherButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.aArcherButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.aArcherButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aArcherButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aArcherButton.Location = new System.Drawing.Point(528, 331);
            this.aArcherButton.Name = "aArcherButton";
            this.aArcherButton.PulseSpeed = 0.2F;
            this.aArcherButton.PulseWidth = 20;
            this.aArcherButton.Size = new System.Drawing.Size(476, 233);
            this.aArcherButton.TabIndex = 3;
            this.aArcherButton.Text = "Add / Delete Archers";
            this.aArcherButton.UseVisualStyleBackColor = false;
            this.aArcherButton.Click += new System.EventHandler(this.aArcherButton_Click);
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
            this.clearDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.clearDatabaseToolStripMenuItem.Text = "Clear Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // meetButton
            // 
            this.meetButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.meetButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.meetButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.meetButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.meetButton.Location = new System.Drawing.Point(254, 92);
            this.meetButton.Name = "meetButton";
            this.meetButton.PulseSpeed = 0.2F;
            this.meetButton.PulseWidth = 20;
            this.meetButton.Size = new System.Drawing.Size(476, 233);
            this.meetButton.TabIndex = 5;
            this.meetButton.Text = "Start New Meet";
            this.meetButton.UseVisualStyleBackColor = true;
            this.meetButton.Click += new System.EventHandler(this.meetButton_Click);
            // 
            // psButton
            // 
            this.psButton.BackColor = System.Drawing.SystemColors.Control;
            this.psButton.ButtonColorBottom = System.Drawing.Color.SeaGreen;
            this.psButton.ButtonColorTop = System.Drawing.Color.LimeGreen;
            this.psButton.FocusColor = System.Drawing.Color.SpringGreen;
            this.psButton.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.psButton.Location = new System.Drawing.Point(1023, 331);
            this.psButton.Name = "psButton";
            this.psButton.PulseSpeed = 0.2F;
            this.psButton.PulseWidth = 20;
            this.psButton.Size = new System.Drawing.Size(476, 233);
            this.psButton.TabIndex = 6;
            this.psButton.Text = "Print Scan Forms";
            this.psButton.UseVisualStyleBackColor = false;
            this.psButton.Click += new System.EventHandler(this.psButton_Click);
            // 
            // LCASPMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1558, 618);
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
        private LCASP.PulseButton aSchoolButton;
        private LCASP.PulseButton exitButton;
        private LCASP.PulseButton aArcherButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private PulseButton meetButton;
        private PulseButton psButton;
    }
}

