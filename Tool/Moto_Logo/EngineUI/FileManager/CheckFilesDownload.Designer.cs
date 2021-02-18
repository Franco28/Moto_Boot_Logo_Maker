/* 
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
            this.btnMinimize = new System.Windows.Forms.Label();
            this.labelPerc = new System.Windows.Forms.Label();
            this.labelfilesize = new System.Windows.Forms.Label();
            this.labelspeed = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar.Location = new System.Drawing.Point(115, 138);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(628, 10);
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
            this.pictureBoxIcon.Size = new System.Drawing.Size(115, 148);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcon.TabIndex = 7;
            this.pictureBoxIcon.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(690, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 37);
            this.btnMinimize.TabIndex = 136;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // labelPerc
            // 
            this.labelPerc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPerc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPerc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPerc.Location = new System.Drawing.Point(629, 106);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(102, 28);
            this.labelPerc.TabIndex = 138;
            this.labelPerc.Text = "0%";
            this.labelPerc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelfilesize
            // 
            this.labelfilesize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelfilesize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelfilesize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelfilesize.Location = new System.Drawing.Point(122, 46);
            this.labelfilesize.Name = "labelfilesize";
            this.labelfilesize.Size = new System.Drawing.Size(311, 28);
            this.labelfilesize.TabIndex = 141;
            this.labelfilesize.Text = "File Size: ---";
            this.labelfilesize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelspeed
            // 
            this.labelspeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelspeed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelspeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelspeed.Location = new System.Drawing.Point(122, 87);
            this.labelspeed.Name = "labelspeed";
            this.labelspeed.Size = new System.Drawing.Size(311, 28);
            this.labelspeed.TabIndex = 140;
            this.labelspeed.Text = "Speed: ---";
            this.labelspeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInformation
            // 
            this.labelInformation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelInformation.Location = new System.Drawing.Point(123, 4);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(560, 31);
            this.labelInformation.TabIndex = 139;
            this.labelInformation.Text = "Downloading file...";
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckFilesDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(743, 148);
            this.Controls.Add(this.labelfilesize);
            this.Controls.Add(this.labelspeed);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBoxIcon);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckFilesDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckFilesDownload";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CheckFilesDownload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label labelPerc;
        private System.Windows.Forms.Label labelfilesize;
        private System.Windows.Forms.Label labelspeed;
        private System.Windows.Forms.Label labelInformation;
    }
}