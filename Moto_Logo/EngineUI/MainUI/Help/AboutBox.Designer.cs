/* 
#####################################################################
#    File: AboutBox.Designer.cs                                     #
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
            this.labelTITLE = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.labelMainToolIcon = new System.Windows.Forms.Label();
            this.pictureBoxMotoGif = new System.Windows.Forms.PictureBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxMotoGifHallo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotoGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotoGifHallo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(679, 555);
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
            this.pictureBox2.Location = new System.Drawing.Point(5, 323);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 257);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(5, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 80);
            this.label12.TabIndex = 46;
            this.label12.Text = "If you want to buy me a beer or a pizza, scan QR or click it!";
            // 
            // labelTITLEMAINTEINERS
            // 
            this.labelTITLEMAINTEINERS.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelTITLEMAINTEINERS.ForeColor = System.Drawing.Color.White;
            this.labelTITLEMAINTEINERS.Location = new System.Drawing.Point(204, 471);
            this.labelTITLEMAINTEINERS.Name = "labelTITLEMAINTEINERS";
            this.labelTITLEMAINTEINERS.Size = new System.Drawing.Size(730, 36);
            this.labelTITLEMAINTEINERS.TabIndex = 50;
            this.labelTITLEMAINTEINERS.Text = "Mainteiners";
            this.labelTITLEMAINTEINERS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(205, 508);
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
            this.label8.Location = new System.Drawing.Point(205, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "@Deivid_21 - Logos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelTITLE
            // 
            this.labelTITLE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTITLE.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTITLE.ForeColor = System.Drawing.Color.Red;
            this.labelTITLE.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTITLE.Location = new System.Drawing.Point(5, 1);
            this.labelTITLE.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelTITLE.Name = "labelTITLE";
            this.labelTITLE.Size = new System.Drawing.Size(872, 46);
            this.labelTITLE.TabIndex = 55;
            this.labelTITLE.Text = "Moto_Boot_Logo_Maker:";
            this.labelTITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(568, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 26);
            this.button1.TabIndex = 56;
            this.button1.Text = "Download Update";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(206, 527);
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
            this.label30.Location = new System.Drawing.Point(206, 561);
            this.label30.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label30.MaximumSize = new System.Drawing.Size(0, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(256, 16);
            this.label30.TabIndex = 75;
            this.label30.Text = "--------------------------------------------------------------";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMainToolIcon
            // 
            this.labelMainToolIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMainToolIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelMainToolIcon.Image")));
            this.labelMainToolIcon.Location = new System.Drawing.Point(5, 49);
            this.labelMainToolIcon.Name = "labelMainToolIcon";
            this.labelMainToolIcon.Size = new System.Drawing.Size(193, 183);
            this.labelMainToolIcon.TabIndex = 177;
            // 
            // pictureBoxMotoGif
            // 
            this.pictureBoxMotoGif.BackColor = System.Drawing.Color.White;
            this.pictureBoxMotoGif.Image = global::Moto_Logo.Properties.Resources.motosnow;
            this.pictureBoxMotoGif.Location = new System.Drawing.Point(74, 133);
            this.pictureBoxMotoGif.Name = "pictureBoxMotoGif";
            this.pictureBoxMotoGif.Size = new System.Drawing.Size(58, 61);
            this.pictureBoxMotoGif.TabIndex = 179;
            this.pictureBoxMotoGif.TabStop = false;
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.Location = new System.Drawing.Point(204, 49);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(730, 385);
            this.console.TabIndex = 180;
            this.console.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(204, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(358, 26);
            this.button2.TabIndex = 181;
            this.button2.Text = "See Contributors / Credits";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(883, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 37);
            this.label5.TabIndex = 182;
            this.label5.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pictureBoxMotoGifHallo
            // 
            this.pictureBoxMotoGifHallo.BackColor = System.Drawing.Color.White;
            this.pictureBoxMotoGifHallo.Image = global::Moto_Logo.Properties.Resources.motoHallowen;
            this.pictureBoxMotoGifHallo.Location = new System.Drawing.Point(74, 133);
            this.pictureBoxMotoGifHallo.Name = "pictureBoxMotoGifHallo";
            this.pictureBoxMotoGifHallo.Size = new System.Drawing.Size(58, 61);
            this.pictureBoxMotoGifHallo.TabIndex = 183;
            this.pictureBoxMotoGifHallo.TabStop = false;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(936, 580);
            this.Controls.Add(this.pictureBoxMotoGifHallo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.console);
            this.Controls.Add(this.pictureBoxMotoGif);
            this.Controls.Add(this.labelMainToolIcon);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTITLE);
            this.Controls.Add(this.labelTITLEMAINTEINERS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelCopyright);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotoGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotoGifHallo)).EndInit();
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
        private System.Windows.Forms.Label labelTITLE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label labelMainToolIcon;
        private System.Windows.Forms.PictureBox pictureBoxMotoGif;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxMotoGifHallo;
    }
}
