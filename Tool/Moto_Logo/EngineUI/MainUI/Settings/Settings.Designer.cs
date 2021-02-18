/* 
#####################################################################
#    File: Settings.Designer.cs                                     #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonYES = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonYESLogo = new System.Windows.Forms.RadioButton();
            this.radioButtonNOLogo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonYESUpdates = new System.Windows.Forms.RadioButton();
            this.radioButtonNOUpdates = new System.Windows.Forms.RadioButton();
            this.buttonRTP = new System.Windows.Forms.Button();
            this.buttonRTS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.RichTextBox();
            this.btngotosettingslogs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBox1.Controls.Add(this.flowLayoutPanel6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enable auto save profiles?";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.radioButtonYES);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonNO);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(801, 23);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // radioButtonYES
            // 
            this.radioButtonYES.AutoSize = true;
            this.radioButtonYES.Checked = true;
            this.radioButtonYES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonYES.Location = new System.Drawing.Point(3, 3);
            this.radioButtonYES.Name = "radioButtonYES";
            this.radioButtonYES.Size = new System.Drawing.Size(48, 21);
            this.radioButtonYES.TabIndex = 0;
            this.radioButtonYES.TabStop = true;
            this.radioButtonYES.Text = "YES";
            this.radioButtonYES.UseVisualStyleBackColor = true;
            this.radioButtonYES.CheckedChanged += new System.EventHandler(this.radioButtonYES_CheckedChanged);
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNO.Location = new System.Drawing.Point(57, 3);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(46, 21);
            this.radioButtonNO.TabIndex = 1;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            this.radioButtonNO.CheckedChanged += new System.EventHandler(this.radioButtonNO_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enable auto save logo in memory?";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonYESLogo);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonNOLogo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(801, 23);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // radioButtonYESLogo
            // 
            this.radioButtonYESLogo.AutoSize = true;
            this.radioButtonYESLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonYESLogo.Location = new System.Drawing.Point(3, 3);
            this.radioButtonYESLogo.Name = "radioButtonYESLogo";
            this.radioButtonYESLogo.Size = new System.Drawing.Size(48, 21);
            this.radioButtonYESLogo.TabIndex = 0;
            this.radioButtonYESLogo.Text = "YES";
            this.radioButtonYESLogo.UseVisualStyleBackColor = true;
            this.radioButtonYESLogo.CheckedChanged += new System.EventHandler(this.radioButtonYESLogo_CheckedChanged);
            // 
            // radioButtonNOLogo
            // 
            this.radioButtonNOLogo.AutoSize = true;
            this.radioButtonNOLogo.Checked = true;
            this.radioButtonNOLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNOLogo.Location = new System.Drawing.Point(57, 3);
            this.radioButtonNOLogo.Name = "radioButtonNOLogo";
            this.radioButtonNOLogo.Size = new System.Drawing.Size(46, 21);
            this.radioButtonNOLogo.TabIndex = 1;
            this.radioButtonNOLogo.TabStop = true;
            this.radioButtonNOLogo.Text = "NO";
            this.radioButtonNOLogo.UseVisualStyleBackColor = true;
            this.radioButtonNOLogo.CheckedChanged += new System.EventHandler(this.radioButtonNOLogo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(4, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(807, 47);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enable auto check for updates?";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioButtonYESUpdates);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonNOUpdates);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(801, 23);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // radioButtonYESUpdates
            // 
            this.radioButtonYESUpdates.AutoSize = true;
            this.radioButtonYESUpdates.Checked = true;
            this.radioButtonYESUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonYESUpdates.Location = new System.Drawing.Point(3, 3);
            this.radioButtonYESUpdates.Name = "radioButtonYESUpdates";
            this.radioButtonYESUpdates.Size = new System.Drawing.Size(48, 21);
            this.radioButtonYESUpdates.TabIndex = 0;
            this.radioButtonYESUpdates.TabStop = true;
            this.radioButtonYESUpdates.Text = "YES";
            this.radioButtonYESUpdates.UseVisualStyleBackColor = true;
            this.radioButtonYESUpdates.CheckedChanged += new System.EventHandler(this.radioButtonYESUpdates_CheckedChanged);
            // 
            // radioButtonNOUpdates
            // 
            this.radioButtonNOUpdates.AutoSize = true;
            this.radioButtonNOUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNOUpdates.Location = new System.Drawing.Point(57, 3);
            this.radioButtonNOUpdates.Name = "radioButtonNOUpdates";
            this.radioButtonNOUpdates.Size = new System.Drawing.Size(46, 21);
            this.radioButtonNOUpdates.TabIndex = 1;
            this.radioButtonNOUpdates.Text = "NO";
            this.radioButtonNOUpdates.UseVisualStyleBackColor = true;
            this.radioButtonNOUpdates.CheckedChanged += new System.EventHandler(this.radioButtonNOUpdates_CheckedChanged);
            // 
            // buttonRTP
            // 
            this.buttonRTP.AutoSize = true;
            this.buttonRTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRTP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRTP.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonRTP.Location = new System.Drawing.Point(50, 149);
            this.buttonRTP.Name = "buttonRTP";
            this.buttonRTP.Size = new System.Drawing.Size(297, 28);
            this.buttonRTP.TabIndex = 7;
            this.buttonRTP.Text = "Reset Tool Profile";
            this.buttonRTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRTP.UseVisualStyleBackColor = true;
            this.buttonRTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRTS
            // 
            this.buttonRTS.AutoSize = true;
            this.buttonRTS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRTS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRTS.ForeColor = System.Drawing.Color.Red;
            this.buttonRTS.Location = new System.Drawing.Point(50, 183);
            this.buttonRTS.Name = "buttonRTS";
            this.buttonRTS.Size = new System.Drawing.Size(297, 28);
            this.buttonRTS.TabIndex = 8;
            this.buttonRTS.Text = "Reset Tool Settings";
            this.buttonRTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRTS.UseVisualStyleBackColor = true;
            this.buttonRTS.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(16, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 28);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "Settings";
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 54);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(763, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 37);
            this.label5.TabIndex = 13;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 41);
            this.label7.TabIndex = 16;
            this.label7.Text = "General Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(162, 41);
            this.label8.TabIndex = 17;
            this.label8.Text = "Reset Tool";
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.Location = new System.Drawing.Point(353, 62);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(458, 259);
            this.console.TabIndex = 39;
            this.console.Text = "";
            // 
            // btngotosettingslogs
            // 
            this.btngotosettingslogs.AutoSize = true;
            this.btngotosettingslogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngotosettingslogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngotosettingslogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btngotosettingslogs.ForeColor = System.Drawing.Color.Green;
            this.btngotosettingslogs.Location = new System.Drawing.Point(4, 293);
            this.btngotosettingslogs.Name = "btngotosettingslogs";
            this.btngotosettingslogs.Size = new System.Drawing.Size(343, 28);
            this.btngotosettingslogs.TabIndex = 40;
            this.btngotosettingslogs.Text = "Go to settings and logs folder";
            this.btngotosettingslogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngotosettingslogs.UseVisualStyleBackColor = true;
            this.btngotosettingslogs.Click += new System.EventHandler(this.btngotosettingslogs_Click);
            // 
            // ToolSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(816, 501);
            this.Controls.Add(this.btngotosettingslogs);
            this.Controls.Add(this.console);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRTS);
            this.Controls.Add(this.buttonRTP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        public System.Windows.Forms.RadioButton radioButtonYES;
        public System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.RadioButton radioButtonYESLogo;
        public System.Windows.Forms.RadioButton radioButtonNOLogo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.RadioButton radioButtonYESUpdates;
        public System.Windows.Forms.RadioButton radioButtonNOUpdates;
        private System.Windows.Forms.Button buttonRTP;
        private System.Windows.Forms.Button buttonRTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button btngotosettingslogs;
    }
}