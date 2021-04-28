/* 
#####################################################################
#    File: LogoTest.Designer.cs                                     #
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
    partial class LogoTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoTest));
            this.console = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonBootloader = new DarkUI.Controls.DarkRadioButton();
            this.groupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonAB = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonA = new DarkUI.Controls.DarkRadioButton();
            this.buttonsavelogs = new DarkUI.Controls.DarkButton();
            this.buttonFlashLogo = new DarkUI.Controls.DarkButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.console.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.console.Dock = System.Windows.Forms.DockStyle.Top;
            this.console.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(749, 202);
            this.console.TabIndex = 6;
            this.console.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files|*.bmp;*.png;*.jpg|Bin Files|*.bin|All Files|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Image files|*.bmp;*.png;*.jpg|Bin Files|*.bin|All Files|*.*";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(12, 296);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(725, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.radioButtonBootloader);
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 47);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reboot option";
            // 
            // radioButtonBootloader
            // 
            this.radioButtonBootloader.AutoSize = true;
            this.radioButtonBootloader.Location = new System.Drawing.Point(6, 19);
            this.radioButtonBootloader.Name = "radioButtonBootloader";
            this.radioButtonBootloader.Size = new System.Drawing.Size(76, 17);
            this.radioButtonBootloader.TabIndex = 0;
            this.radioButtonBootloader.TabStop = true;
            this.radioButtonBootloader.Text = "Bootloader";
            // 
            // groupBox2
            // 
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Controls.Add(this.radioButtonAB);
            this.groupBox2.Controls.Add(this.radioButtonA);
            this.groupBox2.Location = new System.Drawing.Point(303, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 47);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select your device partition";
            // 
            // radioButtonAB
            // 
            this.radioButtonAB.AutoSize = true;
            this.radioButtonAB.Location = new System.Drawing.Point(84, 19);
            this.radioButtonAB.Name = "radioButtonAB";
            this.radioButtonAB.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAB.TabIndex = 1;
            this.radioButtonAB.TabStop = true;
            this.radioButtonAB.Text = "A/B";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(6, 19);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            // 
            // buttonsavelogs
            // 
            this.buttonsavelogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsavelogs.Location = new System.Drawing.Point(303, 261);
            this.buttonsavelogs.Name = "buttonsavelogs";
            this.buttonsavelogs.Padding = new System.Windows.Forms.Padding(5);
            this.buttonsavelogs.Size = new System.Drawing.Size(434, 23);
            this.buttonsavelogs.TabIndex = 13;
            this.buttonsavelogs.Text = "Save console logs";
            this.buttonsavelogs.Click += new System.EventHandler(this.buttonsavelogs_Click);
            // 
            // buttonFlashLogo
            // 
            this.buttonFlashLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlashLogo.Location = new System.Drawing.Point(12, 261);
            this.buttonFlashLogo.Name = "buttonFlashLogo";
            this.buttonFlashLogo.Padding = new System.Windows.Forms.Padding(5);
            this.buttonFlashLogo.Size = new System.Drawing.Size(285, 23);
            this.buttonFlashLogo.TabIndex = 14;
            this.buttonFlashLogo.Text = "Flash Logo";
            this.buttonFlashLogo.Click += new System.EventHandler(this.buttonFlashLogo_Click);
            // 
            // LogoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(749, 331);
            this.Controls.Add(this.buttonFlashLogo);
            this.Controls.Add(this.buttonsavelogs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.console);
            this.FlatBorder = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogoTest";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logo Flash & Test";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogoTest_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogoTest_FormClosed);
            this.Load += new System.EventHandler(this.LogoTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DarkUI.Controls.DarkGroupBox groupBox1;
        private DarkUI.Controls.DarkRadioButton radioButtonBootloader;
        private DarkUI.Controls.DarkGroupBox groupBox2;
        private DarkUI.Controls.DarkRadioButton radioButtonAB;
        private DarkUI.Controls.DarkRadioButton radioButtonA;
        private DarkUI.Controls.DarkButton buttonsavelogs;
        private DarkUI.Controls.DarkButton buttonFlashLogo;
    }
}