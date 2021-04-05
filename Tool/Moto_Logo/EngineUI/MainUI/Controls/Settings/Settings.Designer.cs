/* 
#####################################################################
#    File: Settings.Designer.cs                                     #
#    Author: Franco28                                               # 
#    Date: 18-02-2021                                               #
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonYES = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonNO = new DarkUI.Controls.DarkRadioButton();
            this.btngotosettingslogs = new DarkUI.Controls.DarkButton();
            this.buttonRTP = new DarkUI.Controls.DarkButton();
            this.buttonRTS = new DarkUI.Controls.DarkButton();
            this.label7 = new DarkUI.Controls.DarkTitle();
            this.label8 = new DarkUI.Controls.DarkTitle();
            this.groupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonNOLogo = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonYESLogo = new DarkUI.Controls.DarkRadioButton();
            this.groupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonYESUpdates = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonNOUpdates = new DarkUI.Controls.DarkRadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(9, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 28);
            this.label2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.radioButtonNO);
            this.groupBox1.Controls.Add(this.radioButtonYES);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 50);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enable auto save profiles?";
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
            // btngotosettingslogs
            // 
            this.btngotosettingslogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngotosettingslogs.Location = new System.Drawing.Point(12, 195);
            this.btngotosettingslogs.Name = "btngotosettingslogs";
            this.btngotosettingslogs.Padding = new System.Windows.Forms.Padding(5);
            this.btngotosettingslogs.Size = new System.Drawing.Size(486, 23);
            this.btngotosettingslogs.TabIndex = 42;
            this.btngotosettingslogs.Text = "Go to settings and logs folder";
            this.btngotosettingslogs.Click += new System.EventHandler(this.btngotosettingslogs_Click);
            // 
            // buttonRTP
            // 
            this.buttonRTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRTP.Location = new System.Drawing.Point(43, 71);
            this.buttonRTP.Name = "buttonRTP";
            this.buttonRTP.Padding = new System.Windows.Forms.Padding(5);
            this.buttonRTP.Size = new System.Drawing.Size(455, 23);
            this.buttonRTP.TabIndex = 43;
            this.buttonRTP.Text = "Reset Tool Profile";
            this.buttonRTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRTS
            // 
            this.buttonRTS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRTS.Location = new System.Drawing.Point(43, 105);
            this.buttonRTS.Name = "buttonRTS";
            this.buttonRTS.Padding = new System.Windows.Forms.Padding(5);
            this.buttonRTS.Size = new System.Drawing.Size(455, 23);
            this.buttonRTS.TabIndex = 44;
            this.buttonRTS.Text = "Reset Tool Settings";
            this.buttonRTS.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 29);
            this.label7.TabIndex = 45;
            this.label7.Text = "General Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 29);
            this.label8.TabIndex = 46;
            this.label8.Text = "Reset Tool";
            // 
            // groupBox2
            // 
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Controls.Add(this.radioButtonNOLogo);
            this.groupBox2.Controls.Add(this.radioButtonYESLogo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 50);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enable auto save logo in memory?";
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
            // groupBox3
            // 
            this.groupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox3.Controls.Add(this.radioButtonNOUpdates);
            this.groupBox3.Controls.Add(this.radioButtonYESUpdates);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(12, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 50);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enable auto save profiles?";
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
            // ToolSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(510, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonRTS);
            this.Controls.Add(this.buttonRTP);
            this.Controls.Add(this.btngotosettingslogs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DarkUI.Controls.DarkGroupBox groupBox1;
        private DarkUI.Controls.DarkRadioButton radioButtonNO;
        private DarkUI.Controls.DarkRadioButton radioButtonYES;
        private DarkUI.Controls.DarkButton btngotosettingslogs;
        private DarkUI.Controls.DarkButton buttonRTP;
        private DarkUI.Controls.DarkButton buttonRTS;
        private DarkUI.Controls.DarkTitle label7;
        private DarkUI.Controls.DarkTitle label8;
        private DarkUI.Controls.DarkGroupBox groupBox2;
        private DarkUI.Controls.DarkRadioButton radioButtonNOLogo;
        private DarkUI.Controls.DarkRadioButton radioButtonYESLogo;
        private DarkUI.Controls.DarkGroupBox groupBox3;
        private DarkUI.Controls.DarkRadioButton radioButtonNOUpdates;
        private DarkUI.Controls.DarkRadioButton radioButtonYESUpdates;
    }
}