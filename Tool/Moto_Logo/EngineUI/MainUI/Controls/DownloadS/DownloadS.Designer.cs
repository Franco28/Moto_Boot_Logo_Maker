/* 
#####################################################################
#    File: DownloadS.Designer.cs                                    #
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
    partial class DownloadS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadS));
            this.console = new System.Windows.Forms.RichTextBox();
            this.btnGoTo = new DarkUI.Controls.DarkButton();
            this.button1 = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.console.Dock = System.Windows.Forms.DockStyle.Top;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(665, 339);
            this.console.TabIndex = 38;
            this.console.Text = "";
            // 
            // btnGoTo
            // 
            this.btnGoTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoTo.Location = new System.Drawing.Point(12, 345);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Padding = new System.Windows.Forms.Padding(5);
            this.btnGoTo.Size = new System.Drawing.Size(275, 23);
            this.btnGoTo.TabIndex = 40;
            this.btnGoTo.Text = "Go to SourceForge";
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(378, 345);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(275, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Go to Android File Host";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DownloadS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(665, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.console);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadS";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloads - Moto_Boot_Logo_Maker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Download_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox console;
        private DarkUI.Controls.DarkButton btnGoTo;
        private DarkUI.Controls.DarkButton button1;
    }
}