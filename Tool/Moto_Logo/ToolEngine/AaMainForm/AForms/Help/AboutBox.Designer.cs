/* 
#####################################################################
#    File: AboutBox.Designer.cs                                     #
#    Author: Franco28                                               # 
#    Date: 10-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

namespace Moto_Logo
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.labelCopyright = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTITLEMAINTEINERS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new DarkUI.Controls.DarkButton();
            this.button2 = new DarkUI.Controls.DarkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelFileToTrasnlate = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabelMoreInfoTranslate = new System.Windows.Forms.LinkLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleChangeFontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(382, 687);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(251, 16);
            this.labelCopyright.TabIndex = 36;
            this.labelCopyright.Text = "Copyright © 2020 - 2021 @Franco28";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(492, 382);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(271, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(365, 56);
            this.label12.TabIndex = 46;
            this.label12.Text = "If you want to buy me a beer or a pizza, scan QR or click it!";
            // 
            // labelTITLEMAINTEINERS
            // 
            this.labelTITLEMAINTEINERS.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelTITLEMAINTEINERS.ForeColor = System.Drawing.Color.White;
            this.labelTITLEMAINTEINERS.Location = new System.Drawing.Point(4, 595);
            this.labelTITLEMAINTEINERS.Name = "labelTITLEMAINTEINERS";
            this.labelTITLEMAINTEINERS.Size = new System.Drawing.Size(261, 27);
            this.labelTITLEMAINTEINERS.TabIndex = 50;
            this.labelTITLEMAINTEINERS.Text = "Mainteiners";
            this.labelTITLEMAINTEINERS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "@Franco28 - Main Tool Dev";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 667);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "@Deivid_21 - Logos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(6, 653);
            this.label29.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label29.MaximumSize = new System.Drawing.Size(0, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(256, 16);
            this.label29.TabIndex = 74;
            this.label29.Text = "--------------------------------------------------------------";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(6, 687);
            this.label30.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label30.MaximumSize = new System.Drawing.Size(0, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(256, 16);
            this.label30.TabIndex = 75;
            this.label30.Text = "--------------------------------------------------------------";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Dock = System.Windows.Forms.DockStyle.Top;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.console.ForeColor = System.Drawing.Color.Red;
            this.console.Location = new System.Drawing.Point(9, 33);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(627, 286);
            this.console.TabIndex = 180;
            this.console.Text = "";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(9, 352);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(256, 23);
            this.button1.TabIndex = 182;
            this.button1.Text = "Download Update";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(9, 323);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(256, 23);
            this.button2.TabIndex = 183;
            this.button2.Text = "See Contributors / Credits";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 27);
            this.label1.TabIndex = 184;
            this.label1.Text = "Contribute Tool Translation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(6, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 17);
            this.label2.TabIndex = 185;
            this.label2.Text = "How to request a new language?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 16);
            this.label3.TabIndex = 186;
            this.label3.Text = "*Please read all info inside en.txt file!";
            // 
            // linkLabelFileToTrasnlate
            // 
            this.linkLabelFileToTrasnlate.AutoSize = true;
            this.linkLabelFileToTrasnlate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelFileToTrasnlate.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelFileToTrasnlate.Location = new System.Drawing.Point(247, 487);
            this.linkLabelFileToTrasnlate.Name = "linkLabelFileToTrasnlate";
            this.linkLabelFileToTrasnlate.Size = new System.Drawing.Size(104, 13);
            this.linkLabelFileToTrasnlate.TabIndex = 187;
            this.linkLabelFileToTrasnlate.TabStop = true;
            this.linkLabelFileToTrasnlate.Text = "File To Translate EN";
            this.linkLabelFileToTrasnlate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFileToTrasnlate_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 16);
            this.label4.TabIndex = 188;
            this.label4.Text = "*Download english file to translate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 16);
            this.label5.TabIndex = 189;
            this.label5.Text = "*You will see your language in future updates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 16);
            this.label6.TabIndex = 190;
            this.label6.Text = "*Remember to send me this file translated to my Telegram account";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 376);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label9.MaximumSize = new System.Drawing.Size(0, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(484, 16);
            this.label9.TabIndex = 191;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 579);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label10.MaximumSize = new System.Drawing.Size(0, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(484, 16);
            this.label10.TabIndex = 192;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelMoreInfoTranslate
            // 
            this.linkLabelMoreInfoTranslate.AutoSize = true;
            this.linkLabelMoreInfoTranslate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelMoreInfoTranslate.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelMoreInfoTranslate.Location = new System.Drawing.Point(450, 566);
            this.linkLabelMoreInfoTranslate.Name = "linkLabelMoreInfoTranslate";
            this.linkLabelMoreInfoTranslate.Size = new System.Drawing.Size(52, 13);
            this.linkLabelMoreInfoTranslate.TabIndex = 193;
            this.linkLabelMoreInfoTranslate.TabStop = true;
            this.linkLabelMoreInfoTranslate.Text = "More Info";
            this.linkLabelMoreInfoTranslate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMoreInfoTranslate_LinkClicked);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem,
            this.consoleChangeFontColorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 194;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.consoleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consoleToolStripMenuItem.Image")));
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(229, 20);
            this.consoleToolStripMenuItem.Text = "Console - Change Background Color";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundColorToolStripMenuItem_Click);
            // 
            // consoleChangeFontColorToolStripMenuItem
            // 
            this.consoleChangeFontColorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consoleChangeFontColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consoleChangeFontColorToolStripMenuItem.Image")));
            this.consoleChangeFontColorToolStripMenuItem.Name = "consoleChangeFontColorToolStripMenuItem";
            this.consoleChangeFontColorToolStripMenuItem.Size = new System.Drawing.Size(189, 20);
            this.consoleChangeFontColorToolStripMenuItem.Text = "Console - Change Font Color";
            this.consoleChangeFontColorToolStripMenuItem.Click += new System.EventHandler(this.changeFontColorToolStripMenuItem_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(645, 712);
            this.Controls.Add(this.linkLabelMoreInfoTranslate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabelFileToTrasnlate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.labelTITLEMAINTEINERS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.menuStrip1);
            this.FlatBorder = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutBox_FormClosing);
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelTITLEMAINTEINERS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Timer timer1;
        private DarkUI.Controls.DarkButton button1;
        private DarkUI.Controls.DarkButton button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelFileToTrasnlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabelMoreInfoTranslate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleChangeFontColorToolStripMenuItem;
    }
}
