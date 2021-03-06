﻿/* 
#####################################################################
#    File: CheckFilesDownload.Designer.cs                           #
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
    partial class CheckFilesDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckFilesDownload));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelInformation = new DarkUI.Controls.DarkTitle();
            this.labelPerc = new DarkUI.Controls.DarkTitle();
            this.labelfilesize = new DarkUI.Controls.DarkTitle();
            this.labelspeed = new DarkUI.Controls.DarkTitle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar.Location = new System.Drawing.Point(76, 113);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(654, 22);
            this.progressBar.TabIndex = 8;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(68, 148);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcon.TabIndex = 7;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelInformation.Location = new System.Drawing.Point(75, 9);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(140, 21);
            this.labelInformation.TabIndex = 142;
            this.labelInformation.Text = "Downloading File...";
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelPerc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPerc.Location = new System.Drawing.Point(701, 89);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(29, 20);
            this.labelPerc.TabIndex = 143;
            this.labelPerc.Text = "0%";
            this.labelPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfilesize
            // 
            this.labelfilesize.AutoSize = true;
            this.labelfilesize.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelfilesize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelfilesize.Location = new System.Drawing.Point(75, 49);
            this.labelfilesize.Name = "labelfilesize";
            this.labelfilesize.Size = new System.Drawing.Size(88, 20);
            this.labelfilesize.TabIndex = 144;
            this.labelfilesize.Text = "File Size: ---";
            this.labelfilesize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelspeed
            // 
            this.labelspeed.AutoSize = true;
            this.labelspeed.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelspeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelspeed.Location = new System.Drawing.Point(75, 80);
            this.labelspeed.Name = "labelspeed";
            this.labelspeed.Size = new System.Drawing.Size(76, 20);
            this.labelspeed.TabIndex = 145;
            this.labelspeed.Text = "Speed: ---";
            this.labelspeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckFilesDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(743, 148);
            this.Controls.Add(this.labelspeed);
            this.Controls.Add(this.labelfilesize);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBoxIcon);
            this.DoubleBuffered = true;
            this.FlatBorder = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CheckFilesDownload";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloading file...";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckFilesDownload_FormClosing);
            this.Load += new System.EventHandler(this.CheckFilesDownload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private DarkUI.Controls.DarkTitle labelInformation;
        private DarkUI.Controls.DarkTitle labelPerc;
        private DarkUI.Controls.DarkTitle labelfilesize;
        private DarkUI.Controls.DarkTitle labelspeed;
    }
}