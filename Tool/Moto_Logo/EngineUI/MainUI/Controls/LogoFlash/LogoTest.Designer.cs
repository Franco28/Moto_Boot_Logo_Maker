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
            this.buttonFlashLogo = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonBootloader = new System.Windows.Forms.RadioButton();
            this.buttonsavelogs = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonAB = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFlashLogo
            // 
            this.buttonFlashLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlashLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFlashLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlashLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFlashLogo.Location = new System.Drawing.Point(0, 333);
            this.buttonFlashLogo.Name = "buttonFlashLogo";
            this.buttonFlashLogo.Size = new System.Drawing.Size(749, 28);
            this.buttonFlashLogo.TabIndex = 5;
            this.buttonFlashLogo.Text = "Flash Logo";
            this.buttonFlashLogo.UseVisualStyleBackColor = true;
            this.buttonFlashLogo.Click += new System.EventHandler(this.buttonFlashLogo_Click);
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.console.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.console.ForeColor = System.Drawing.Color.Gold;
            this.console.Location = new System.Drawing.Point(5, 67);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(739, 151);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reboot option";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonBootloader);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 25);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // radioButtonBootloader
            // 
            this.radioButtonBootloader.AutoSize = true;
            this.radioButtonBootloader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonBootloader.Location = new System.Drawing.Point(3, 3);
            this.radioButtonBootloader.Name = "radioButtonBootloader";
            this.radioButtonBootloader.Size = new System.Drawing.Size(87, 19);
            this.radioButtonBootloader.TabIndex = 0;
            this.radioButtonBootloader.Text = "Bootloader";
            this.radioButtonBootloader.UseVisualStyleBackColor = true;
            // 
            // buttonsavelogs
            // 
            this.buttonsavelogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsavelogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsavelogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsavelogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonsavelogs.Location = new System.Drawing.Point(5, 276);
            this.buttonsavelogs.Name = "buttonsavelogs";
            this.buttonsavelogs.Size = new System.Drawing.Size(739, 28);
            this.buttonsavelogs.TabIndex = 8;
            this.buttonsavelogs.Text = "Save console logs";
            this.buttonsavelogs.UseVisualStyleBackColor = true;
            this.buttonsavelogs.Click += new System.EventHandler(this.buttonsavelogs_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 310);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(749, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(378, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select your device partition";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioButtonA);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonAB);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(360, 25);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonA.Location = new System.Drawing.Point(3, 3);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(33, 19);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonAB
            // 
            this.radioButtonAB.AutoSize = true;
            this.radioButtonAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAB.Location = new System.Drawing.Point(42, 3);
            this.radioButtonAB.Name = "radioButtonAB";
            this.radioButtonAB.Size = new System.Drawing.Size(46, 19);
            this.radioButtonAB.TabIndex = 1;
            this.radioButtonAB.Text = "A/B";
            this.radioButtonAB.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(696, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.TabIndex = 15;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Flash logo.bin";
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 54);
            this.label4.TabIndex = 35;
            // 
            // LogoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(749, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonsavelogs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.buttonFlashLogo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogoTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogoTest";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogoTest_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogoTest_FormClosed);
            this.Load += new System.EventHandler(this.LogoTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonsavelogs;
        public System.Windows.Forms.RadioButton radioButtonBootloader;
        public System.Windows.Forms.Button buttonFlashLogo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.RadioButton radioButtonA;
        public System.Windows.Forms.RadioButton radioButtonAB;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}