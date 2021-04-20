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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(375, 523);
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
            this.pictureBox2.Location = new System.Drawing.Point(482, 382);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 138);
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
            this.label12.Location = new System.Drawing.Point(378, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 63);
            this.label12.TabIndex = 46;
            this.label12.Text = "If you want to buy me a beer or a pizza, scan QR or click it!";
            // 
            // labelTITLEMAINTEINERS
            // 
            this.labelTITLEMAINTEINERS.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelTITLEMAINTEINERS.ForeColor = System.Drawing.Color.White;
            this.labelTITLEMAINTEINERS.Location = new System.Drawing.Point(12, 433);
            this.labelTITLEMAINTEINERS.Name = "labelTITLEMAINTEINERS";
            this.labelTITLEMAINTEINERS.Size = new System.Drawing.Size(253, 27);
            this.labelTITLEMAINTEINERS.TabIndex = 50;
            this.labelTITLEMAINTEINERS.Text = "Mainteiners";
            this.labelTITLEMAINTEINERS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "@Franco28 - Main Tool Dev";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 505);
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
            this.label29.Location = new System.Drawing.Point(9, 491);
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
            this.label30.Location = new System.Drawing.Point(9, 525);
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
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.console.Dock = System.Windows.Forms.DockStyle.Top;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.Location = new System.Drawing.Point(9, 9);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(617, 298);
            this.console.TabIndex = 180;
            this.console.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(9, 345);
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
            this.button2.Location = new System.Drawing.Point(9, 316);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(256, 23);
            this.button2.TabIndex = 183;
            this.button2.Text = "See Contributors / Credits";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(635, 543);
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
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutBox_FormClosing);
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}
