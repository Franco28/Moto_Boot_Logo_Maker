﻿/* 
#####################################################################
#    File: Settings.Designer.cs                                     #
#    Author: Franco28                                               # 
#    Date: 17-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

namespace Moto_Logo
{
    partial class ToolSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSettings));
            this.labelIconWarning = new System.Windows.Forms.Label();
            this.groupBoxEASP = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonNO = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonYES = new DarkUI.Controls.DarkRadioButton();
            this.buttonOpenToolFolder = new DarkUI.Controls.DarkButton();
            this.buttonRTP = new DarkUI.Controls.DarkButton();
            this.buttonRTS = new DarkUI.Controls.DarkButton();
            this.labelGeneralSettings = new DarkUI.Controls.DarkTitle();
            this.labelResetTool = new DarkUI.Controls.DarkTitle();
            this.groupBoxEASLIM = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonNOLogo = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonYESLogo = new DarkUI.Controls.DarkRadioButton();
            this.groupBoxEU = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonNOUpdates = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonYESUpdates = new DarkUI.Controls.DarkRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxEASP.SuspendLayout();
            this.groupBoxEASLIM.SuspendLayout();
            this.groupBoxEU.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIconWarning
            // 
            this.labelIconWarning.Image = ((System.Drawing.Image)(resources.GetObject("labelIconWarning.Image")));
            this.labelIconWarning.Location = new System.Drawing.Point(9, 21);
            this.labelIconWarning.Name = "labelIconWarning";
            this.labelIconWarning.Size = new System.Drawing.Size(28, 28);
            this.labelIconWarning.TabIndex = 10;
            // 
            // groupBoxEASP
            // 
            this.groupBoxEASP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxEASP.Controls.Add(this.radioButtonNO);
            this.groupBoxEASP.Controls.Add(this.radioButtonYES);
            this.groupBoxEASP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxEASP.Location = new System.Drawing.Point(55, 234);
            this.groupBoxEASP.Name = "groupBoxEASP";
            this.groupBoxEASP.Size = new System.Drawing.Size(512, 50);
            this.groupBoxEASP.TabIndex = 41;
            this.groupBoxEASP.TabStop = false;
            this.groupBoxEASP.Text = "Enable auto save profiles?";
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Location = new System.Drawing.Point(74, 22);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNO.TabIndex = 1;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.CheckedChanged += new System.EventHandler(this.radioButtonNO_CheckedChanged);
            // 
            // radioButtonYES
            // 
            this.radioButtonYES.AutoSize = true;
            this.radioButtonYES.Checked = true;
            this.radioButtonYES.Location = new System.Drawing.Point(6, 22);
            this.radioButtonYES.Name = "radioButtonYES";
            this.radioButtonYES.Size = new System.Drawing.Size(53, 21);
            this.radioButtonYES.TabIndex = 0;
            this.radioButtonYES.TabStop = true;
            this.radioButtonYES.Text = "YES";
            this.radioButtonYES.CheckedChanged += new System.EventHandler(this.radioButtonYES_CheckedChanged);
            // 
            // buttonOpenToolFolder
            // 
            this.buttonOpenToolFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenToolFolder.Location = new System.Drawing.Point(12, 195);
            this.buttonOpenToolFolder.Name = "buttonOpenToolFolder";
            this.buttonOpenToolFolder.Padding = new System.Windows.Forms.Padding(5);
            this.buttonOpenToolFolder.Size = new System.Drawing.Size(555, 23);
            this.buttonOpenToolFolder.TabIndex = 42;
            this.buttonOpenToolFolder.Text = "Open Tool Folder";
            this.buttonOpenToolFolder.Click += new System.EventHandler(this.btngotosettingslogs_Click);
            // 
            // buttonRTP
            // 
            this.buttonRTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRTP.Location = new System.Drawing.Point(12, 76);
            this.buttonRTP.Name = "buttonRTP";
            this.buttonRTP.Padding = new System.Windows.Forms.Padding(5);
            this.buttonRTP.Size = new System.Drawing.Size(555, 23);
            this.buttonRTP.TabIndex = 43;
            this.buttonRTP.Text = "Reset Tool Profile";
            this.buttonRTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRTS
            // 
            this.buttonRTS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRTS.Location = new System.Drawing.Point(12, 105);
            this.buttonRTS.Name = "buttonRTS";
            this.buttonRTS.Padding = new System.Windows.Forms.Padding(5);
            this.buttonRTS.Size = new System.Drawing.Size(555, 23);
            this.buttonRTS.TabIndex = 44;
            this.buttonRTS.Text = "Reset Tool Settings";
            this.buttonRTS.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelGeneralSettings
            // 
            this.labelGeneralSettings.AutoSize = true;
            this.labelGeneralSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelGeneralSettings.Location = new System.Drawing.Point(43, 147);
            this.labelGeneralSettings.Name = "labelGeneralSettings";
            this.labelGeneralSettings.Size = new System.Drawing.Size(192, 29);
            this.labelGeneralSettings.TabIndex = 45;
            this.labelGeneralSettings.Text = "General Settings";
            // 
            // labelResetTool
            // 
            this.labelResetTool.AutoSize = true;
            this.labelResetTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelResetTool.Location = new System.Drawing.Point(43, 21);
            this.labelResetTool.Name = "labelResetTool";
            this.labelResetTool.Size = new System.Drawing.Size(132, 29);
            this.labelResetTool.TabIndex = 46;
            this.labelResetTool.Text = "Reset Tool";
            // 
            // groupBoxEASLIM
            // 
            this.groupBoxEASLIM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxEASLIM.Controls.Add(this.radioButtonNOLogo);
            this.groupBoxEASLIM.Controls.Add(this.radioButtonYESLogo);
            this.groupBoxEASLIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxEASLIM.Location = new System.Drawing.Point(55, 297);
            this.groupBoxEASLIM.Name = "groupBoxEASLIM";
            this.groupBoxEASLIM.Size = new System.Drawing.Size(512, 50);
            this.groupBoxEASLIM.TabIndex = 42;
            this.groupBoxEASLIM.TabStop = false;
            this.groupBoxEASLIM.Text = "Enable auto save logo in memory?";
            // 
            // radioButtonNOLogo
            // 
            this.radioButtonNOLogo.AutoSize = true;
            this.radioButtonNOLogo.Checked = true;
            this.radioButtonNOLogo.Location = new System.Drawing.Point(74, 22);
            this.radioButtonNOLogo.Name = "radioButtonNOLogo";
            this.radioButtonNOLogo.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNOLogo.TabIndex = 1;
            this.radioButtonNOLogo.TabStop = true;
            this.radioButtonNOLogo.Text = "NO";
            this.radioButtonNOLogo.CheckedChanged += new System.EventHandler(this.radioButtonNOLogo_CheckedChanged);
            // 
            // radioButtonYESLogo
            // 
            this.radioButtonYESLogo.AutoSize = true;
            this.radioButtonYESLogo.Location = new System.Drawing.Point(6, 22);
            this.radioButtonYESLogo.Name = "radioButtonYESLogo";
            this.radioButtonYESLogo.Size = new System.Drawing.Size(53, 21);
            this.radioButtonYESLogo.TabIndex = 0;
            this.radioButtonYESLogo.Text = "YES";
            this.radioButtonYESLogo.CheckedChanged += new System.EventHandler(this.radioButtonYESLogo_CheckedChanged);
            // 
            // groupBoxEU
            // 
            this.groupBoxEU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxEU.Controls.Add(this.radioButtonNOUpdates);
            this.groupBoxEU.Controls.Add(this.radioButtonYESUpdates);
            this.groupBoxEU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxEU.Location = new System.Drawing.Point(55, 356);
            this.groupBoxEU.Name = "groupBoxEU";
            this.groupBoxEU.Size = new System.Drawing.Size(512, 50);
            this.groupBoxEU.TabIndex = 42;
            this.groupBoxEU.TabStop = false;
            this.groupBoxEU.Text = "Enable auto updates?";
            // 
            // radioButtonNOUpdates
            // 
            this.radioButtonNOUpdates.AutoSize = true;
            this.radioButtonNOUpdates.Location = new System.Drawing.Point(74, 22);
            this.radioButtonNOUpdates.Name = "radioButtonNOUpdates";
            this.radioButtonNOUpdates.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNOUpdates.TabIndex = 1;
            this.radioButtonNOUpdates.Text = "NO";
            this.radioButtonNOUpdates.CheckedChanged += new System.EventHandler(this.radioButtonNOUpdates_CheckedChanged);
            // 
            // radioButtonYESUpdates
            // 
            this.radioButtonYESUpdates.AutoSize = true;
            this.radioButtonYESUpdates.Checked = true;
            this.radioButtonYESUpdates.Location = new System.Drawing.Point(6, 22);
            this.radioButtonYESUpdates.Name = "radioButtonYESUpdates";
            this.radioButtonYESUpdates.Size = new System.Drawing.Size(53, 21);
            this.radioButtonYESUpdates.TabIndex = 0;
            this.radioButtonYESUpdates.TabStop = true;
            this.radioButtonYESUpdates.Text = "YES";
            this.radioButtonYESUpdates.CheckedChanged += new System.EventHandler(this.radioButtonYESUpdates_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Image = global::Moto_Logo.Properties.Resources.generalsettings_x32;
            this.label1.Location = new System.Drawing.Point(9, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Image = global::Moto_Logo.Properties.Resources.sprofile_x32;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 50);
            this.label2.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Image = global::Moto_Logo.Properties.Resources.smemory_x32;
            this.label3.Location = new System.Drawing.Point(12, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 50);
            this.label3.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Image = global::Moto_Logo.Properties.Resources.aupdates_x32;
            this.label4.Location = new System.Drawing.Point(12, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 50);
            this.label4.TabIndex = 50;
            // 
            // ToolSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(579, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxEU);
            this.Controls.Add(this.groupBoxEASLIM);
            this.Controls.Add(this.labelResetTool);
            this.Controls.Add(this.labelGeneralSettings);
            this.Controls.Add(this.buttonRTS);
            this.Controls.Add(this.buttonRTP);
            this.Controls.Add(this.buttonOpenToolFolder);
            this.Controls.Add(this.groupBoxEASP);
            this.Controls.Add(this.labelIconWarning);
            this.FlatBorder = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolSettings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBoxEASP.ResumeLayout(false);
            this.groupBoxEASP.PerformLayout();
            this.groupBoxEASLIM.ResumeLayout(false);
            this.groupBoxEASLIM.PerformLayout();
            this.groupBoxEU.ResumeLayout(false);
            this.groupBoxEU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIconWarning;
        private DarkUI.Controls.DarkGroupBox groupBoxEASP;
        private DarkUI.Controls.DarkRadioButton radioButtonNO;
        private DarkUI.Controls.DarkRadioButton radioButtonYES;
        private DarkUI.Controls.DarkButton buttonOpenToolFolder;
        private DarkUI.Controls.DarkButton buttonRTP;
        private DarkUI.Controls.DarkButton buttonRTS;
        private DarkUI.Controls.DarkTitle labelGeneralSettings;
        private DarkUI.Controls.DarkTitle labelResetTool;
        private DarkUI.Controls.DarkGroupBox groupBoxEASLIM;
        private DarkUI.Controls.DarkRadioButton radioButtonNOLogo;
        private DarkUI.Controls.DarkRadioButton radioButtonYESLogo;
        private DarkUI.Controls.DarkGroupBox groupBoxEU;
        private DarkUI.Controls.DarkRadioButton radioButtonNOUpdates;
        private DarkUI.Controls.DarkRadioButton radioButtonYESUpdates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}