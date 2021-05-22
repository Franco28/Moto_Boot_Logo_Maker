
namespace AutoUpdaterDotNET
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new DarkUI.Controls.DarkButton();
            this.labelReleaseNotes = new DarkUI.Controls.DarkTitle();
            this.labelIconDownload = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.RichTextBox();
            this.labelPerc = new DarkUI.Controls.DarkTitle();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelfilesize = new System.Windows.Forms.Label();
            this.labelspeed = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::Moto_Logo.Properties.Resources.update;
            resources.ApplyResources(this.pictureBoxIcon, "pictureBoxIcon");
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // labelReleaseNotes
            // 
            resources.ApplyResources(this.labelReleaseNotes, "labelReleaseNotes");
            this.labelReleaseNotes.Name = "labelReleaseNotes";
            // 
            // labelIconDownload
            // 
            this.labelIconDownload.Image = global::Moto_Logo.Properties.Resources.download_32;
            resources.ApplyResources(this.labelIconDownload, "labelIconDownload");
            this.labelIconDownload.Name = "labelIconDownload";
            // 
            // labelUpdate
            // 
            resources.ApplyResources(this.labelUpdate, "labelUpdate");
            this.labelUpdate.Name = "labelUpdate";
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.Name = "labelDescription";
            // 
            // webBrowser
            // 
            this.webBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.ForeColor = System.Drawing.Color.White;
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ReadOnly = true;
            // 
            // labelPerc
            // 
            resources.ApplyResources(this.labelPerc, "labelPerc");
            this.labelPerc.Name = "labelPerc";
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moto_Logo.Properties.Resources.downloadgif;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // labelfilesize
            // 
            resources.ApplyResources(this.labelfilesize, "labelfilesize");
            this.labelfilesize.Name = "labelfilesize";
            // 
            // labelspeed
            // 
            resources.ApplyResources(this.labelspeed, "labelspeed");
            this.labelspeed.Name = "labelspeed";
            // 
            // labelInformation
            // 
            resources.ApplyResources(this.labelInformation, "labelInformation");
            this.labelInformation.Name = "labelInformation";
            // 
            // UpdateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelspeed);
            this.Controls.Add(this.labelfilesize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelIconDownload);
            this.Controls.Add(this.labelReleaseNotes);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.pictureBoxIcon);
            this.DoubleBuffered = true;
            this.FlatBorder = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.UpdateFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private DarkUI.Controls.DarkButton buttonUpdate;
        private DarkUI.Controls.DarkTitle labelReleaseNotes;
        private System.Windows.Forms.Label labelIconDownload;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox webBrowser;
        private DarkUI.Controls.DarkTitle labelPerc;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelfilesize;
        private System.Windows.Forms.Label labelspeed;
        private System.Windows.Forms.Label labelInformation;
    }
}