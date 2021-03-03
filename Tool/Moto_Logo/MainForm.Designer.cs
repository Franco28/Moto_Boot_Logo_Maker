/* 
#####################################################################
#    File: MainForm.Designer.cs                                     #
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
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxSearchDevice = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExit = new System.Windows.Forms.Label();
            this.labelMainIconTool = new System.Windows.Forms.Label();
            this.ToolTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOpenCustomLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darktoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lighttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.joinTelegramBootLogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoG6PlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoG6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoG7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoG7PlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoG7PowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoG7PlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testYourNewLogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Label();
            this.labelbtnStop = new System.Windows.Forms.Label();
            this.labelbtnBuild = new System.Windows.Forms.Label();
            this.textLogoName = new System.Windows.Forms.TextBox();
            this.labelLogoName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Label();
            this.labelLicenseTimer = new System.Windows.Forms.Label();
            this.btnOpenLogoFile = new System.Windows.Forms.Label();
            this.labelbtnOpenLogoFile = new System.Windows.Forms.Label();
            this.btnAttachPath = new System.Windows.Forms.Label();
            this.txtLogoBuildPath = new System.Windows.Forms.TextBox();
            this.labelBuildPath = new System.Windows.Forms.Label();
            this.groupBoxLogoImageOrientation = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoLayoutPortrait = new System.Windows.Forms.RadioButton();
            this.rdoLayoutLandscape = new System.Windows.Forms.RadioButton();
            this.groupBoxLogoMemory = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton4mib = new System.Windows.Forms.RadioButton();
            this.radioButton6MIB = new System.Windows.Forms.RadioButton();
            this.radioButton8MIB = new System.Windows.Forms.RadioButton();
            this.radioButton16MIB = new System.Windows.Forms.RadioButton();
            this.radioButton32MIB = new System.Windows.Forms.RadioButton();
            this.groupBoxLogoImageOption = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoImageCenter = new System.Windows.Forms.RadioButton();
            this.rdoImageStretchAspect = new System.Windows.Forms.RadioButton();
            this.rdoImageFill = new System.Windows.Forms.RadioButton();
            this.groupBoxLogoFormat = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoAndroid44 = new System.Windows.Forms.RadioButton();
            this.rdoAndroid43 = new System.Windows.Forms.RadioButton();
            this.rdoAndroidRAW = new System.Windows.Forms.RadioButton();
            this.groupBoxLogoResolution = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.udResolutionX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.udResolutionY = new System.Windows.Forms.NumericUpDown();
            this.groupBoxLogoExtension = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonBIN = new System.Windows.Forms.RadioButton();
            this.radioButtonZIP = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.labelSignYourLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tvLogo = new System.Windows.Forms.TreeView();
            this.cboMoto = new System.Windows.Forms.ComboBox();
            this.labelLogos = new System.Windows.Forms.Label();
            this.txtLogoInternalFile = new System.Windows.Forms.TextBox();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.lblZoomFactor = new System.Windows.Forms.Label();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.trbZoomFactor = new System.Windows.Forms.TrackBar();
            this.labelImageStatus = new System.Windows.Forms.Label();
            this.labelColorDraw = new System.Windows.Forms.Label();
            this.labelimageInfoDClick = new System.Windows.Forms.Label();
            this.labelimageInfoClick = new System.Windows.Forms.Label();
            this.pictureBoxColors = new System.Windows.Forms.PictureBox();
            this.labelErrorGoToFileInfo = new System.Windows.Forms.Label();
            this.labelErrorInfo = new System.Windows.Forms.Label();
            this.labelGoToError = new System.Windows.Forms.Label();
            this.labelErrorIcon = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Label();
            this.labelReload = new System.Windows.Forms.Label();
            this.pictureBoxFireworks = new System.Windows.Forms.PictureBox();
            this.pictureBoxMotoGif = new System.Windows.Forms.PictureBox();
            this.labelSearchDevice = new System.Windows.Forms.Label();
            this.btnSearchDevice = new System.Windows.Forms.Label();
            this.pictureBoxMotoGifHallo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxLogoImageOrientation.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBoxLogoMemory.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.groupBoxLogoImageOption.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBoxLogoFormat.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBoxLogoResolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionY)).BeginInit();
            this.groupBoxLogoExtension.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFireworks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotoGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotoGifHallo)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files|*.bmp;*.png;*.jpg|Bin Files|*.bin|All Files|*.*";
            // 
            // textBoxSearchDevice
            // 
            this.textBoxSearchDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBoxSearchDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxSearchDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.textBoxSearchDevice.Location = new System.Drawing.Point(1072, 171);
            this.textBoxSearchDevice.Name = "textBoxSearchDevice";
            this.textBoxSearchDevice.Size = new System.Drawing.Size(172, 23);
            this.textBoxSearchDevice.TabIndex = 178;
            this.ToolTip1.SetToolTip(this.textBoxSearchDevice, "Input your device model like this: \"moto g8 power\"");
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1233, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // labelMainIconTool
            // 
            this.labelMainIconTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMainIconTool.Image = ((System.Drawing.Image)(resources.GetObject("labelMainIconTool.Image")));
            this.labelMainIconTool.Location = new System.Drawing.Point(0, 0);
            this.labelMainIconTool.Name = "labelMainIconTool";
            this.labelMainIconTool.Size = new System.Drawing.Size(206, 205);
            this.labelMainIconTool.TabIndex = 16;
            // 
            // ToolTitle
            // 
            this.ToolTitle.AutoSize = true;
            this.ToolTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTitle.Location = new System.Drawing.Point(207, 5);
            this.ToolTitle.Name = "ToolTitle";
            this.ToolTitle.Size = new System.Drawing.Size(231, 25);
            this.ToolTitle.TabIndex = 15;
            this.ToolTitle.Text = "Moto_Boot_Logo_Maker";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.othersToolStripMenuItem,
            this.testToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(207, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(511, 26);
            this.menuStrip1.TabIndex = 112;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator6,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItemOpenCustomLogo});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(191, 6);
            this.toolStripSeparator6.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            this.toolStripSeparator2.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // toolStripMenuItemOpenCustomLogo
            // 
            this.toolStripMenuItemOpenCustomLogo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemOpenCustomLogo.Image")));
            this.toolStripMenuItemOpenCustomLogo.Name = "toolStripMenuItemOpenCustomLogo";
            this.toolStripMenuItemOpenCustomLogo.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItemOpenCustomLogo.Text = "&Open Custom Logo";
            this.toolStripMenuItemOpenCustomLogo.Click += new System.EventHandler(this.toolStripMenuItemOpenCustomLogo_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themetoolStripMenuItem,
            this.toolStripSeparator3,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator4,
            this.joinTelegramBootLogosToolStripMenuItem,
            this.toolStripSeparator7,
            this.downloadSiteToolStripMenuItem});
            this.othersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.othersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("othersToolStripMenuItem.Image")));
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // themetoolStripMenuItem
            // 
            this.themetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darktoolStripMenuItem,
            this.lighttoolStripMenuItem});
            this.themetoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("themetoolStripMenuItem.Image")));
            this.themetoolStripMenuItem.Name = "themetoolStripMenuItem";
            this.themetoolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.themetoolStripMenuItem.Text = "Theme";
            // 
            // darktoolStripMenuItem
            // 
            this.darktoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("darktoolStripMenuItem.Image")));
            this.darktoolStripMenuItem.Name = "darktoolStripMenuItem";
            this.darktoolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.darktoolStripMenuItem.Text = "Dark";
            this.darktoolStripMenuItem.Click += new System.EventHandler(this.darktoolStripMenuItem_Click);
            // 
            // lighttoolStripMenuItem
            // 
            this.lighttoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lighttoolStripMenuItem.Image")));
            this.lighttoolStripMenuItem.Name = "lighttoolStripMenuItem";
            this.lighttoolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.lighttoolStripMenuItem.Text = "Light";
            this.lighttoolStripMenuItem.Click += new System.EventHandler(this.lighttoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            this.toolStripSeparator3.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkForUpdatesToolStripMenuItem.Image")));
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(229, 6);
            this.toolStripSeparator4.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // joinTelegramBootLogosToolStripMenuItem
            // 
            this.joinTelegramBootLogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.motoG6PlayToolStripMenuItem,
            this.motoG6ToolStripMenuItem,
            this.motoG7ToolStripMenuItem,
            this.motoG7PlusToolStripMenuItem,
            this.motoG7PowerToolStripMenuItem,
            this.motoG7PlayToolStripMenuItem});
            this.joinTelegramBootLogosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("joinTelegramBootLogosToolStripMenuItem.Image")));
            this.joinTelegramBootLogosToolStripMenuItem.Name = "joinTelegramBootLogosToolStripMenuItem";
            this.joinTelegramBootLogosToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.joinTelegramBootLogosToolStripMenuItem.Text = "Join Telegram Boot Logos";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mToolStripMenuItem.Text = "Moto G4 \\ G5";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // motoG6PlayToolStripMenuItem
            // 
            this.motoG6PlayToolStripMenuItem.Name = "motoG6PlayToolStripMenuItem";
            this.motoG6PlayToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.motoG6PlayToolStripMenuItem.Text = "Moto G6 Play";
            this.motoG6PlayToolStripMenuItem.Click += new System.EventHandler(this.motoG6PlayToolStripMenuItem_Click);
            // 
            // motoG6ToolStripMenuItem
            // 
            this.motoG6ToolStripMenuItem.Name = "motoG6ToolStripMenuItem";
            this.motoG6ToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.motoG6ToolStripMenuItem.Text = "Moto G6";
            this.motoG6ToolStripMenuItem.Click += new System.EventHandler(this.motoG6ToolStripMenuItem_Click);
            // 
            // motoG7ToolStripMenuItem
            // 
            this.motoG7ToolStripMenuItem.Name = "motoG7ToolStripMenuItem";
            this.motoG7ToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.motoG7ToolStripMenuItem.Text = "Moto G7";
            this.motoG7ToolStripMenuItem.Click += new System.EventHandler(this.motoG7ToolStripMenuItem_Click);
            // 
            // motoG7PlusToolStripMenuItem
            // 
            this.motoG7PlusToolStripMenuItem.Name = "motoG7PlusToolStripMenuItem";
            this.motoG7PlusToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.motoG7PlusToolStripMenuItem.Text = "Moto G7 Plus";
            this.motoG7PlusToolStripMenuItem.Click += new System.EventHandler(this.motoG7PlusToolStripMenuItem_Click);
            // 
            // motoG7PowerToolStripMenuItem
            // 
            this.motoG7PowerToolStripMenuItem.Name = "motoG7PowerToolStripMenuItem";
            this.motoG7PowerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.motoG7PowerToolStripMenuItem.Text = "Moto G7 Power";
            this.motoG7PowerToolStripMenuItem.Click += new System.EventHandler(this.motoG7PowerToolStripMenuItem_Click);
            // 
            // motoG7PlayToolStripMenuItem
            // 
            this.motoG7PlayToolStripMenuItem.Name = "motoG7PlayToolStripMenuItem";
            this.motoG7PlayToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.motoG7PlayToolStripMenuItem.Text = "Moto G7 Play";
            this.motoG7PlayToolStripMenuItem.Click += new System.EventHandler(this.motoG7PlayToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(229, 6);
            this.toolStripSeparator7.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // downloadSiteToolStripMenuItem
            // 
            this.downloadSiteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadSiteToolStripMenuItem.Image")));
            this.downloadSiteToolStripMenuItem.Name = "downloadSiteToolStripMenuItem";
            this.downloadSiteToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.downloadSiteToolStripMenuItem.Text = "Download Site";
            this.downloadSiteToolStripMenuItem.Click += new System.EventHandler(this.downloadSiteToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testYourNewLogoToolStripMenuItem});
            this.testToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.testToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem.Image")));
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // testYourNewLogoToolStripMenuItem
            // 
            this.testYourNewLogoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.testYourNewLogoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testYourNewLogoToolStripMenuItem.Image")));
            this.testYourNewLogoToolStripMenuItem.Name = "testYourNewLogoToolStripMenuItem";
            this.testYourNewLogoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.testYourNewLogoToolStripMenuItem.Text = "Test your new logo";
            this.testYourNewLogoToolStripMenuItem.Click += new System.EventHandler(this.testYourNewLogoToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceToolStripMenuItem,
            this.toolStripSeparator1,
            this.changelogToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceToolStripMenuItem.Image")));
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sourceToolStripMenuItem.Text = "Source";
            this.sourceToolStripMenuItem.Click += new System.EventHandler(this.sourceToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            this.toolStripSeparator1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changelogToolStripMenuItem.Image")));
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(138, 6);
            this.toolStripSeparator5.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator2_Paint);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem1.Image")));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(415, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 132;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuild
            // 
            this.btnBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuild.Image = ((System.Drawing.Image)(resources.GetObject("btnBuild.Image")));
            this.btnBuild.Location = new System.Drawing.Point(213, 69);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(29, 25);
            this.btnBuild.TabIndex = 131;
            this.btnBuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            this.btnBuild.MouseLeave += new System.EventHandler(this.btnBuild_MouseLeave);
            this.btnBuild.MouseHover += new System.EventHandler(this.btnBuild_MouseHover);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(320, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(29, 25);
            this.btnStop.TabIndex = 130;
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseLeave += new System.EventHandler(this.btnStop_MouseLeave);
            this.btnStop.MouseHover += new System.EventHandler(this.btnStop_MouseHover);
            // 
            // labelbtnStop
            // 
            this.labelbtnStop.AutoSize = true;
            this.labelbtnStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelbtnStop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelbtnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelbtnStop.Location = new System.Drawing.Point(355, 74);
            this.labelbtnStop.Name = "labelbtnStop";
            this.labelbtnStop.Size = new System.Drawing.Size(47, 17);
            this.labelbtnStop.TabIndex = 129;
            this.labelbtnStop.Text = "Cancel";
            this.labelbtnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelbtnBuild
            // 
            this.labelbtnBuild.AutoSize = true;
            this.labelbtnBuild.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelbtnBuild.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelbtnBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelbtnBuild.Location = new System.Drawing.Point(248, 74);
            this.labelbtnBuild.Name = "labelbtnBuild";
            this.labelbtnBuild.Size = new System.Drawing.Size(38, 17);
            this.labelbtnBuild.TabIndex = 128;
            this.labelbtnBuild.Text = "Build";
            this.labelbtnBuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLogoName
            // 
            this.textLogoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textLogoName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textLogoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.textLogoName.Location = new System.Drawing.Point(449, 121);
            this.textLogoName.Name = "textLogoName";
            this.textLogoName.Size = new System.Drawing.Size(165, 23);
            this.textLogoName.TabIndex = 127;
            this.textLogoName.Text = "logo";
            // 
            // labelLogoName
            // 
            this.labelLogoName.AutoSize = true;
            this.labelLogoName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelLogoName.Location = new System.Drawing.Point(414, 100);
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(78, 17);
            this.labelLogoName.TabIndex = 126;
            this.labelLogoName.Text = "Logo Name";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1139, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 37);
            this.btnMinimize.TabIndex = 134;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1186, 9);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 37);
            this.btnMaximize.TabIndex = 135;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.btnMaximize_MouseLeave);
            this.btnMaximize.MouseHover += new System.EventHandler(this.btnMaximize_MouseHover);
            // 
            // labelLicenseTimer
            // 
            this.labelLicenseTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLicenseTimer.AutoSize = true;
            this.labelLicenseTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelLicenseTimer.Location = new System.Drawing.Point(654, 333);
            this.labelLicenseTimer.Name = "labelLicenseTimer";
            this.labelLicenseTimer.Size = new System.Drawing.Size(0, 17);
            this.labelLicenseTimer.TabIndex = 141;
            // 
            // btnOpenLogoFile
            // 
            this.btnOpenLogoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenLogoFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenLogoFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenLogoFile.Image")));
            this.btnOpenLogoFile.Location = new System.Drawing.Point(1067, 120);
            this.btnOpenLogoFile.Name = "btnOpenLogoFile";
            this.btnOpenLogoFile.Size = new System.Drawing.Size(31, 25);
            this.btnOpenLogoFile.TabIndex = 140;
            this.btnOpenLogoFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenLogoFile.Click += new System.EventHandler(this.btnOpenLogoFile_Click);
            this.btnOpenLogoFile.MouseLeave += new System.EventHandler(this.btnOpenLogoFile_MouseLeave);
            this.btnOpenLogoFile.MouseHover += new System.EventHandler(this.btnOpenLogoFile_MouseHover);
            // 
            // labelbtnOpenLogoFile
            // 
            this.labelbtnOpenLogoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelbtnOpenLogoFile.AutoSize = true;
            this.labelbtnOpenLogoFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelbtnOpenLogoFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelbtnOpenLogoFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelbtnOpenLogoFile.Location = new System.Drawing.Point(1104, 123);
            this.labelbtnOpenLogoFile.Name = "labelbtnOpenLogoFile";
            this.labelbtnOpenLogoFile.Size = new System.Drawing.Size(97, 17);
            this.labelbtnOpenLogoFile.TabIndex = 139;
            this.labelbtnOpenLogoFile.Text = "Open File Path";
            this.labelbtnOpenLogoFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAttachPath
            // 
            this.btnAttachPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttachPath.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachPath.Image")));
            this.btnAttachPath.Location = new System.Drawing.Point(621, 120);
            this.btnAttachPath.Name = "btnAttachPath";
            this.btnAttachPath.Size = new System.Drawing.Size(31, 25);
            this.btnAttachPath.TabIndex = 138;
            this.btnAttachPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAttachPath.Click += new System.EventHandler(this.btnAttachPath_Click);
            this.btnAttachPath.MouseLeave += new System.EventHandler(this.btnAttachPath_MouseLeave);
            this.btnAttachPath.MouseHover += new System.EventHandler(this.btnAttachPath_MouseHover);
            // 
            // txtLogoBuildPath
            // 
            this.txtLogoBuildPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogoBuildPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtLogoBuildPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogoBuildPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtLogoBuildPath.Location = new System.Drawing.Point(657, 122);
            this.txtLogoBuildPath.Name = "txtLogoBuildPath";
            this.txtLogoBuildPath.Size = new System.Drawing.Size(404, 22);
            this.txtLogoBuildPath.TabIndex = 137;
            // 
            // labelBuildPath
            // 
            this.labelBuildPath.AutoSize = true;
            this.labelBuildPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBuildPath.Location = new System.Drawing.Point(620, 100);
            this.labelBuildPath.Name = "labelBuildPath";
            this.labelBuildPath.Size = new System.Drawing.Size(104, 17);
            this.labelBuildPath.TabIndex = 136;
            this.labelBuildPath.Text = "Logo Build Path";
            this.labelBuildPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxLogoImageOrientation
            // 
            this.groupBoxLogoImageOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogoImageOrientation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBoxLogoImageOrientation.Controls.Add(this.flowLayoutPanel5);
            this.groupBoxLogoImageOrientation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxLogoImageOrientation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.groupBoxLogoImageOrientation.Location = new System.Drawing.Point(776, 197);
            this.groupBoxLogoImageOrientation.Name = "groupBoxLogoImageOrientation";
            this.groupBoxLogoImageOrientation.Size = new System.Drawing.Size(506, 44);
            this.groupBoxLogoImageOrientation.TabIndex = 142;
            this.groupBoxLogoImageOrientation.TabStop = false;
            this.groupBoxLogoImageOrientation.Text = "Image Orientation Options";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.rdoLayoutPortrait);
            this.flowLayoutPanel5.Controls.Add(this.rdoLayoutLandscape);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(500, 22);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // rdoLayoutPortrait
            // 
            this.rdoLayoutPortrait.AutoSize = true;
            this.rdoLayoutPortrait.Checked = true;
            this.rdoLayoutPortrait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoLayoutPortrait.Location = new System.Drawing.Point(3, 3);
            this.rdoLayoutPortrait.Name = "rdoLayoutPortrait";
            this.rdoLayoutPortrait.Size = new System.Drawing.Size(64, 19);
            this.rdoLayoutPortrait.TabIndex = 0;
            this.rdoLayoutPortrait.TabStop = true;
            this.rdoLayoutPortrait.Text = "Portrait";
            this.rdoLayoutPortrait.UseVisualStyleBackColor = true;
            this.rdoLayoutPortrait.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoLayoutLandscape
            // 
            this.rdoLayoutLandscape.AutoSize = true;
            this.rdoLayoutLandscape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoLayoutLandscape.Location = new System.Drawing.Point(73, 3);
            this.rdoLayoutLandscape.Name = "rdoLayoutLandscape";
            this.rdoLayoutLandscape.Size = new System.Drawing.Size(81, 19);
            this.rdoLayoutLandscape.TabIndex = 1;
            this.rdoLayoutLandscape.Text = "Landscape";
            this.rdoLayoutLandscape.UseVisualStyleBackColor = true;
            this.rdoLayoutLandscape.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // groupBoxLogoMemory
            // 
            this.groupBoxLogoMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBoxLogoMemory.Controls.Add(this.flowLayoutPanel6);
            this.groupBoxLogoMemory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxLogoMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.groupBoxLogoMemory.Location = new System.Drawing.Point(209, 146);
            this.groupBoxLogoMemory.Name = "groupBoxLogoMemory";
            this.groupBoxLogoMemory.Size = new System.Drawing.Size(320, 48);
            this.groupBoxLogoMemory.TabIndex = 145;
            this.groupBoxLogoMemory.TabStop = false;
            this.groupBoxLogoMemory.Text = "Select your logo memory";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.radioButton4mib);
            this.flowLayoutPanel6.Controls.Add(this.radioButton6MIB);
            this.flowLayoutPanel6.Controls.Add(this.radioButton8MIB);
            this.flowLayoutPanel6.Controls.Add(this.radioButton16MIB);
            this.flowLayoutPanel6.Controls.Add(this.radioButton32MIB);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(314, 26);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // radioButton4mib
            // 
            this.radioButton4mib.AutoSize = true;
            this.radioButton4mib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4mib.Location = new System.Drawing.Point(3, 3);
            this.radioButton4mib.Name = "radioButton4mib";
            this.radioButton4mib.Size = new System.Drawing.Size(54, 19);
            this.radioButton4mib.TabIndex = 0;
            this.radioButton4mib.Text = "4MIB";
            this.radioButton4mib.UseVisualStyleBackColor = true;
            this.radioButton4mib.CheckedChanged += new System.EventHandler(this.radioButton4mib_CheckedChanged);
            // 
            // radioButton6MIB
            // 
            this.radioButton6MIB.AutoSize = true;
            this.radioButton6MIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6MIB.Location = new System.Drawing.Point(63, 3);
            this.radioButton6MIB.Name = "radioButton6MIB";
            this.radioButton6MIB.Size = new System.Drawing.Size(54, 19);
            this.radioButton6MIB.TabIndex = 1;
            this.radioButton6MIB.Text = "6MIB";
            this.radioButton6MIB.UseVisualStyleBackColor = true;
            this.radioButton6MIB.CheckedChanged += new System.EventHandler(this.radioButton6MIB_CheckedChanged);
            // 
            // radioButton8MIB
            // 
            this.radioButton8MIB.AutoSize = true;
            this.radioButton8MIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8MIB.Location = new System.Drawing.Point(123, 3);
            this.radioButton8MIB.Name = "radioButton8MIB";
            this.radioButton8MIB.Size = new System.Drawing.Size(54, 19);
            this.radioButton8MIB.TabIndex = 2;
            this.radioButton8MIB.Text = "8MIB";
            this.radioButton8MIB.UseVisualStyleBackColor = true;
            this.radioButton8MIB.CheckedChanged += new System.EventHandler(this.radioButton8MIB_CheckedChanged);
            // 
            // radioButton16MIB
            // 
            this.radioButton16MIB.AutoSize = true;
            this.radioButton16MIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton16MIB.Location = new System.Drawing.Point(183, 3);
            this.radioButton16MIB.Name = "radioButton16MIB";
            this.radioButton16MIB.Size = new System.Drawing.Size(59, 19);
            this.radioButton16MIB.TabIndex = 3;
            this.radioButton16MIB.Text = "16MIB";
            this.radioButton16MIB.UseVisualStyleBackColor = true;
            this.radioButton16MIB.CheckedChanged += new System.EventHandler(this.radioButton16MIB_CheckedChanged);
            // 
            // radioButton32MIB
            // 
            this.radioButton32MIB.AutoSize = true;
            this.radioButton32MIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton32MIB.Location = new System.Drawing.Point(248, 3);
            this.radioButton32MIB.Name = "radioButton32MIB";
            this.radioButton32MIB.Size = new System.Drawing.Size(61, 19);
            this.radioButton32MIB.TabIndex = 4;
            this.radioButton32MIB.Text = "32MIB";
            this.radioButton32MIB.UseVisualStyleBackColor = true;
            this.radioButton32MIB.CheckedChanged += new System.EventHandler(this.radioButton32MIB_CheckedChanged);
            // 
            // groupBoxLogoImageOption
            // 
            this.groupBoxLogoImageOption.AutoSize = true;
            this.groupBoxLogoImageOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBoxLogoImageOption.Controls.Add(this.flowLayoutPanel3);
            this.groupBoxLogoImageOption.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxLogoImageOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.groupBoxLogoImageOption.Location = new System.Drawing.Point(399, 197);
            this.groupBoxLogoImageOption.Name = "groupBoxLogoImageOption";
            this.groupBoxLogoImageOption.Size = new System.Drawing.Size(373, 44);
            this.groupBoxLogoImageOption.TabIndex = 144;
            this.groupBoxLogoImageOption.TabStop = false;
            this.groupBoxLogoImageOption.Text = "Image Fill Options";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.rdoImageCenter);
            this.flowLayoutPanel3.Controls.Add(this.rdoImageStretchAspect);
            this.flowLayoutPanel3.Controls.Add(this.rdoImageFill);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(367, 22);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // rdoImageCenter
            // 
            this.rdoImageCenter.AutoSize = true;
            this.rdoImageCenter.Checked = true;
            this.rdoImageCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoImageCenter.Location = new System.Drawing.Point(3, 3);
            this.rdoImageCenter.Name = "rdoImageCenter";
            this.rdoImageCenter.Size = new System.Drawing.Size(59, 19);
            this.rdoImageCenter.TabIndex = 0;
            this.rdoImageCenter.TabStop = true;
            this.rdoImageCenter.Text = "Center";
            this.rdoImageCenter.UseVisualStyleBackColor = true;
            this.rdoImageCenter.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoImageStretchAspect
            // 
            this.rdoImageStretchAspect.AutoSize = true;
            this.rdoImageStretchAspect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoImageStretchAspect.Location = new System.Drawing.Point(68, 3);
            this.rdoImageStretchAspect.Name = "rdoImageStretchAspect";
            this.rdoImageStretchAspect.Size = new System.Drawing.Size(148, 19);
            this.rdoImageStretchAspect.TabIndex = 1;
            this.rdoImageStretchAspect.Text = "Stretch Proportionately";
            this.rdoImageStretchAspect.UseVisualStyleBackColor = true;
            this.rdoImageStretchAspect.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoImageFill
            // 
            this.rdoImageFill.AutoSize = true;
            this.rdoImageFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoImageFill.Location = new System.Drawing.Point(222, 3);
            this.rdoImageFill.Name = "rdoImageFill";
            this.rdoImageFill.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.rdoImageFill.Size = new System.Drawing.Size(41, 19);
            this.rdoImageFill.TabIndex = 2;
            this.rdoImageFill.Text = "Fill";
            this.rdoImageFill.UseVisualStyleBackColor = true;
            this.rdoImageFill.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // groupBoxLogoFormat
            // 
            this.groupBoxLogoFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogoFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBoxLogoFormat.Controls.Add(this.flowLayoutPanel4);
            this.groupBoxLogoFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxLogoFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.groupBoxLogoFormat.Location = new System.Drawing.Point(535, 146);
            this.groupBoxLogoFormat.Name = "groupBoxLogoFormat";
            this.groupBoxLogoFormat.Size = new System.Drawing.Size(531, 48);
            this.groupBoxLogoFormat.TabIndex = 143;
            this.groupBoxLogoFormat.TabStop = false;
            this.groupBoxLogoFormat.Text = "logo.bin format";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.rdoAndroid44);
            this.flowLayoutPanel4.Controls.Add(this.rdoAndroid43);
            this.flowLayoutPanel4.Controls.Add(this.rdoAndroidRAW);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(525, 26);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // rdoAndroid44
            // 
            this.rdoAndroid44.AutoSize = true;
            this.rdoAndroid44.Checked = true;
            this.rdoAndroid44.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAndroid44.Location = new System.Drawing.Point(3, 3);
            this.rdoAndroid44.Name = "rdoAndroid44";
            this.rdoAndroid44.Size = new System.Drawing.Size(64, 19);
            this.rdoAndroid44.TabIndex = 1;
            this.rdoAndroid44.TabStop = true;
            this.rdoAndroid44.Text = "Default";
            this.rdoAndroid44.UseVisualStyleBackColor = true;
            this.rdoAndroid44.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoAndroid43
            // 
            this.rdoAndroid43.AutoSize = true;
            this.rdoAndroid43.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAndroid43.Location = new System.Drawing.Point(73, 3);
            this.rdoAndroid43.Name = "rdoAndroid43";
            this.rdoAndroid43.Size = new System.Drawing.Size(113, 19);
            this.rdoAndroid43.TabIndex = 0;
            this.rdoAndroid43.Text = "540x540 Bundle";
            this.rdoAndroid43.UseVisualStyleBackColor = true;
            this.rdoAndroid43.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoAndroidRAW
            // 
            this.rdoAndroidRAW.AutoSize = true;
            this.rdoAndroidRAW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAndroidRAW.Location = new System.Drawing.Point(192, 3);
            this.rdoAndroidRAW.Name = "rdoAndroidRAW";
            this.rdoAndroidRAW.Size = new System.Drawing.Size(98, 19);
            this.rdoAndroidRAW.TabIndex = 2;
            this.rdoAndroidRAW.TabStop = true;
            this.rdoAndroidRAW.Text = "Raw 540x540";
            this.rdoAndroidRAW.UseVisualStyleBackColor = true;
            this.rdoAndroidRAW.CheckedChanged += new System.EventHandler(this.rdoAndroidRAW_CheckedChanged);
            // 
            // groupBoxLogoResolution
            // 
            this.groupBoxLogoResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBoxLogoResolution.Controls.Add(this.label2);
            this.groupBoxLogoResolution.Controls.Add(this.udResolutionX);
            this.groupBoxLogoResolution.Controls.Add(this.label5);
            this.groupBoxLogoResolution.Controls.Add(this.udResolutionY);
            this.groupBoxLogoResolution.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxLogoResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.groupBoxLogoResolution.Location = new System.Drawing.Point(209, 197);
            this.groupBoxLogoResolution.Name = "groupBoxLogoResolution";
            this.groupBoxLogoResolution.Size = new System.Drawing.Size(186, 44);
            this.groupBoxLogoResolution.TabIndex = 146;
            this.groupBoxLogoResolution.TabStop = false;
            this.groupBoxLogoResolution.Text = "Resolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            // 
            // udResolutionX
            // 
            this.udResolutionX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.udResolutionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.udResolutionX.Enabled = false;
            this.udResolutionX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.udResolutionX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.udResolutionX.Location = new System.Drawing.Point(29, 16);
            this.udResolutionX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udResolutionX.Name = "udResolutionX";
            this.udResolutionX.Size = new System.Drawing.Size(62, 23);
            this.udResolutionX.TabIndex = 6;
            this.udResolutionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udResolutionX.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.udResolutionX.ValueChanged += new System.EventHandler(this.udResolutionX_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y:";
            // 
            // udResolutionY
            // 
            this.udResolutionY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.udResolutionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.udResolutionY.Enabled = false;
            this.udResolutionY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.udResolutionY.Location = new System.Drawing.Point(115, 16);
            this.udResolutionY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udResolutionY.Name = "udResolutionY";
            this.udResolutionY.Size = new System.Drawing.Size(62, 23);
            this.udResolutionY.TabIndex = 8;
            this.udResolutionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udResolutionY.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.udResolutionY.ValueChanged += new System.EventHandler(this.udResolutionY_ValueChanged);
            // 
            // groupBoxLogoExtension
            // 
            this.groupBoxLogoExtension.Controls.Add(this.label7);
            this.groupBoxLogoExtension.Controls.Add(this.label8);
            this.groupBoxLogoExtension.Controls.Add(this.radioButtonBIN);
            this.groupBoxLogoExtension.Controls.Add(this.radioButtonZIP);
            this.groupBoxLogoExtension.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxLogoExtension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.groupBoxLogoExtension.Location = new System.Drawing.Point(209, 101);
            this.groupBoxLogoExtension.Name = "groupBoxLogoExtension";
            this.groupBoxLogoExtension.Size = new System.Drawing.Size(203, 43);
            this.groupBoxLogoExtension.TabIndex = 147;
            this.groupBoxLogoExtension.TabStop = false;
            this.groupBoxLogoExtension.Text = "Select your extension";
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 25);
            this.label7.TabIndex = 25;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(99, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 25);
            this.label8.TabIndex = 24;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonBIN
            // 
            this.radioButtonBIN.AutoSize = true;
            this.radioButtonBIN.Checked = true;
            this.radioButtonBIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonBIN.Location = new System.Drawing.Point(134, 19);
            this.radioButtonBIN.Name = "radioButtonBIN";
            this.radioButtonBIN.Size = new System.Drawing.Size(45, 19);
            this.radioButtonBIN.TabIndex = 1;
            this.radioButtonBIN.TabStop = true;
            this.radioButtonBIN.Text = ".bin";
            this.radioButtonBIN.UseVisualStyleBackColor = true;
            // 
            // radioButtonZIP
            // 
            this.radioButtonZIP.AutoSize = true;
            this.radioButtonZIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonZIP.Location = new System.Drawing.Point(41, 19);
            this.radioButtonZIP.Name = "radioButtonZIP";
            this.radioButtonZIP.Size = new System.Drawing.Size(44, 19);
            this.radioButtonZIP.TabIndex = 0;
            this.radioButtonZIP.TabStop = true;
            this.radioButtonZIP.Text = ".zip";
            this.radioButtonZIP.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1285, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 148;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(188, 19);
            this.ProgressBar.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtComments.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtComments.Location = new System.Drawing.Point(1, 247);
            this.txtComments.MaxLength = 150;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(354, 114);
            this.txtComments.TabIndex = 150;
            // 
            // labelSignYourLogo
            // 
            this.labelSignYourLogo.AutoSize = true;
            this.labelSignYourLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSignYourLogo.Location = new System.Drawing.Point(3, 225);
            this.labelSignYourLogo.Name = "labelSignYourLogo";
            this.labelSignYourLogo.Size = new System.Drawing.Size(77, 17);
            this.labelSignYourLogo.TabIndex = 149;
            this.labelSignYourLogo.Text = "Comments:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(361, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 151;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // tvLogo
            // 
            this.tvLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tvLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tvLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.tvLogo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tvLogo.Location = new System.Drawing.Point(1, 394);
            this.tvLogo.Name = "tvLogo";
            this.tvLogo.ShowNodeToolTips = true;
            this.tvLogo.Size = new System.Drawing.Size(354, 233);
            this.tvLogo.TabIndex = 152;
            this.tvLogo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLogo_AfterSelect);
            this.tvLogo.DoubleClick += new System.EventHandler(this.tvLogo_DoubleClick);
            // 
            // cboMoto
            // 
            this.cboMoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cboMoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMoto.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.cboMoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cboMoto.FormattingEnabled = true;
            this.cboMoto.Location = new System.Drawing.Point(108, 366);
            this.cboMoto.Name = "cboMoto";
            this.cboMoto.Size = new System.Drawing.Size(247, 23);
            this.cboMoto.TabIndex = 154;
            this.cboMoto.SelectedIndexChanged += new System.EventHandler(this.cboMoto_SelectedIndexChanged);
            // 
            // labelLogos
            // 
            this.labelLogos.AutoSize = true;
            this.labelLogos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelLogos.Location = new System.Drawing.Point(3, 371);
            this.labelLogos.Name = "labelLogos";
            this.labelLogos.Size = new System.Drawing.Size(47, 17);
            this.labelLogos.TabIndex = 153;
            this.labelLogos.Text = "Logos:";
            // 
            // txtLogoInternalFile
            // 
            this.txtLogoInternalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLogoInternalFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtLogoInternalFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLogoInternalFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtLogoInternalFile.Location = new System.Drawing.Point(1, 630);
            this.txtLogoInternalFile.MaxLength = 24;
            this.txtLogoInternalFile.Name = "txtLogoInternalFile";
            this.txtLogoInternalFile.Size = new System.Drawing.Size(354, 25);
            this.txtLogoInternalFile.TabIndex = 155;
            this.txtLogoInternalFile.TextChanged += new System.EventHandler(this.txtLogoInternalFile_TextChanged);
            // 
            // buttonAppend
            // 
            this.buttonAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAppend.AutoSize = true;
            this.buttonAppend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAppend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppend.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAppend.ForeColor = System.Drawing.Color.Green;
            this.buttonAppend.Location = new System.Drawing.Point(1, 661);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(91, 29);
            this.buttonAppend.TabIndex = 156;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExtract.AutoSize = true;
            this.buttonExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtract.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonExtract.Location = new System.Drawing.Point(128, 661);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(91, 29);
            this.buttonExtract.TabIndex = 158;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(258, 661);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 29);
            this.buttonDelete.TabIndex = 157;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // lblZoomFactor
            // 
            this.lblZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoomFactor.AutoSize = true;
            this.lblZoomFactor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblZoomFactor.Location = new System.Drawing.Point(1259, 476);
            this.lblZoomFactor.Name = "lblZoomFactor";
            this.lblZoomFactor.Size = new System.Drawing.Size(23, 17);
            this.lblZoomFactor.TabIndex = 161;
            this.lblZoomFactor.Text = "X3";
            // 
            // picZoom
            // 
            this.picZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.picZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZoom.Location = new System.Drawing.Point(993, 247);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(289, 212);
            this.picZoom.TabIndex = 160;
            this.picZoom.TabStop = false;
            // 
            // trbZoomFactor
            // 
            this.trbZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trbZoomFactor.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trbZoomFactor.LargeChange = 1;
            this.trbZoomFactor.Location = new System.Drawing.Point(992, 465);
            this.trbZoomFactor.Maximum = 6;
            this.trbZoomFactor.Minimum = 2;
            this.trbZoomFactor.Name = "trbZoomFactor";
            this.trbZoomFactor.Size = new System.Drawing.Size(261, 45);
            this.trbZoomFactor.TabIndex = 159;
            this.trbZoomFactor.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbZoomFactor.Value = 3;
            this.trbZoomFactor.ValueChanged += new System.EventHandler(this.trbZoomFactor_ValueChanged);
            // 
            // labelImageStatus
            // 
            this.labelImageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImageStatus.AutoSize = true;
            this.labelImageStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelImageStatus.Location = new System.Drawing.Point(994, 670);
            this.labelImageStatus.Name = "labelImageStatus";
            this.labelImageStatus.Size = new System.Drawing.Size(23, 17);
            this.labelImageStatus.TabIndex = 166;
            this.labelImageStatus.Text = "---";
            this.labelImageStatus.MouseLeave += new System.EventHandler(this.labelImageStatus_MouseLeave);
            // 
            // labelColorDraw
            // 
            this.labelColorDraw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelColorDraw.AutoSize = true;
            this.labelColorDraw.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelColorDraw.Location = new System.Drawing.Point(994, 530);
            this.labelColorDraw.Name = "labelColorDraw";
            this.labelColorDraw.Size = new System.Drawing.Size(33, 17);
            this.labelColorDraw.TabIndex = 165;
            this.labelColorDraw.Text = "RGB";
            this.labelColorDraw.Click += new System.EventHandler(this.labelColorDraw_Click);
            // 
            // labelimageInfoDClick
            // 
            this.labelimageInfoDClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelimageInfoDClick.AutoSize = true;
            this.labelimageInfoDClick.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelimageInfoDClick.Location = new System.Drawing.Point(994, 639);
            this.labelimageInfoDClick.Name = "labelimageInfoDClick";
            this.labelimageInfoDClick.Size = new System.Drawing.Size(218, 17);
            this.labelimageInfoDClick.TabIndex = 164;
            this.labelimageInfoDClick.Text = "* Double click and will be unlocked";
            // 
            // labelimageInfoClick
            // 
            this.labelimageInfoClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelimageInfoClick.AutoSize = true;
            this.labelimageInfoClick.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelimageInfoClick.Location = new System.Drawing.Point(993, 607);
            this.labelimageInfoClick.Name = "labelimageInfoClick";
            this.labelimageInfoClick.Size = new System.Drawing.Size(218, 17);
            this.labelimageInfoClick.TabIndex = 163;
            this.labelimageInfoClick.Text = "* Click on image and will be locked";
            // 
            // pictureBoxColors
            // 
            this.pictureBoxColors.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBoxColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColors.Location = new System.Drawing.Point(993, 552);
            this.pictureBoxColors.Name = "pictureBoxColors";
            this.pictureBoxColors.Size = new System.Drawing.Size(289, 31);
            this.pictureBoxColors.TabIndex = 162;
            this.pictureBoxColors.TabStop = false;
            // 
            // labelErrorGoToFileInfo
            // 
            this.labelErrorGoToFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorGoToFileInfo.AutoSize = true;
            this.labelErrorGoToFileInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelErrorGoToFileInfo.Location = new System.Drawing.Point(1120, 73);
            this.labelErrorGoToFileInfo.Name = "labelErrorGoToFileInfo";
            this.labelErrorGoToFileInfo.Size = new System.Drawing.Size(23, 17);
            this.labelErrorGoToFileInfo.TabIndex = 170;
            this.labelErrorGoToFileInfo.Text = "---";
            // 
            // labelErrorInfo
            // 
            this.labelErrorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelErrorInfo.Location = new System.Drawing.Point(655, 57);
            this.labelErrorInfo.Name = "labelErrorInfo";
            this.labelErrorInfo.Size = new System.Drawing.Size(426, 38);
            this.labelErrorInfo.TabIndex = 169;
            this.labelErrorInfo.Text = "---";
            // 
            // labelGoToError
            // 
            this.labelGoToError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGoToError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToError.Image = ((System.Drawing.Image)(resources.GetObject("labelGoToError.Image")));
            this.labelGoToError.Location = new System.Drawing.Point(1087, 68);
            this.labelGoToError.Name = "labelGoToError";
            this.labelGoToError.Size = new System.Drawing.Size(27, 22);
            this.labelGoToError.TabIndex = 168;
            this.labelGoToError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelGoToError.Click += new System.EventHandler(this.labelGoToError_Click);
            this.labelGoToError.MouseLeave += new System.EventHandler(this.btnOpenLogoFile_MouseLeave);
            this.labelGoToError.MouseHover += new System.EventHandler(this.btnOpenLogoFile_MouseLeave);
            // 
            // labelErrorIcon
            // 
            this.labelErrorIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelErrorIcon.Image")));
            this.labelErrorIcon.Location = new System.Drawing.Point(620, 57);
            this.labelErrorIcon.Name = "labelErrorIcon";
            this.labelErrorIcon.Size = new System.Drawing.Size(29, 33);
            this.labelErrorIcon.TabIndex = 167;
            this.labelErrorIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(483, 70);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(29, 26);
            this.btnReload.TabIndex = 171;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            this.btnReload.MouseLeave += new System.EventHandler(this.btnReload_MouseLeave);
            this.btnReload.MouseHover += new System.EventHandler(this.btnReload_MouseHover);
            // 
            // labelReload
            // 
            this.labelReload.AutoSize = true;
            this.labelReload.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelReload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelReload.Location = new System.Drawing.Point(518, 74);
            this.labelReload.Name = "labelReload";
            this.labelReload.Size = new System.Drawing.Size(49, 17);
            this.labelReload.TabIndex = 172;
            this.labelReload.Text = "Reload";
            this.labelReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFireworks
            // 
            this.pictureBoxFireworks.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFireworks.Image = global::Moto_Logo.Properties.Resources.fireworks;
            this.pictureBoxFireworks.Location = new System.Drawing.Point(45, -11);
            this.pictureBoxFireworks.Name = "pictureBoxFireworks";
            this.pictureBoxFireworks.Size = new System.Drawing.Size(130, 102);
            this.pictureBoxFireworks.TabIndex = 173;
            this.pictureBoxFireworks.TabStop = false;
            // 
            // pictureBoxMotoGif
            // 
            this.pictureBoxMotoGif.BackColor = System.Drawing.Color.White;
            this.pictureBoxMotoGif.Image = global::Moto_Logo.Properties.Resources.motosnow;
            this.pictureBoxMotoGif.Location = new System.Drawing.Point(75, 92);
            this.pictureBoxMotoGif.Name = "pictureBoxMotoGif";
            this.pictureBoxMotoGif.Size = new System.Drawing.Size(58, 61);
            this.pictureBoxMotoGif.TabIndex = 176;
            this.pictureBoxMotoGif.TabStop = false;
            // 
            // labelSearchDevice
            // 
            this.labelSearchDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearchDevice.AutoSize = true;
            this.labelSearchDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSearchDevice.Location = new System.Drawing.Point(1069, 151);
            this.labelSearchDevice.Name = "labelSearchDevice";
            this.labelSearchDevice.Size = new System.Drawing.Size(91, 17);
            this.labelSearchDevice.TabIndex = 177;
            this.labelSearchDevice.Text = "Search Device";
            // 
            // btnSearchDevice
            // 
            this.btnSearchDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDevice.Image")));
            this.btnSearchDevice.Location = new System.Drawing.Point(1250, 169);
            this.btnSearchDevice.Name = "btnSearchDevice";
            this.btnSearchDevice.Size = new System.Drawing.Size(29, 25);
            this.btnSearchDevice.TabIndex = 179;
            this.btnSearchDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchDevice.Click += new System.EventHandler(this.btnSearchDevice_Click);
            this.btnSearchDevice.MouseLeave += new System.EventHandler(this.btnSearchDevice_MouseLeave);
            this.btnSearchDevice.MouseHover += new System.EventHandler(this.btnSearchDevice_MouseHover);
            // 
            // pictureBoxMotoGifHallo
            // 
            this.pictureBoxMotoGifHallo.BackColor = System.Drawing.Color.White;
            this.pictureBoxMotoGifHallo.Image = global::Moto_Logo.Properties.Resources.motoHallowen;
            this.pictureBoxMotoGifHallo.Location = new System.Drawing.Point(75, 92);
            this.pictureBoxMotoGifHallo.Name = "pictureBoxMotoGifHallo";
            this.pictureBoxMotoGifHallo.Size = new System.Drawing.Size(58, 61);
            this.pictureBoxMotoGifHallo.TabIndex = 180;
            this.pictureBoxMotoGifHallo.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1285, 715);
            this.Controls.Add(this.pictureBoxMotoGifHallo);
            this.Controls.Add(this.btnSearchDevice);
            this.Controls.Add(this.textBoxSearchDevice);
            this.Controls.Add(this.labelSearchDevice);
            this.Controls.Add(this.pictureBoxMotoGif);
            this.Controls.Add(this.pictureBoxFireworks);
            this.Controls.Add(this.labelReload);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.labelErrorGoToFileInfo);
            this.Controls.Add(this.labelErrorInfo);
            this.Controls.Add(this.labelGoToError);
            this.Controls.Add(this.labelErrorIcon);
            this.Controls.Add(this.labelImageStatus);
            this.Controls.Add(this.labelColorDraw);
            this.Controls.Add(this.labelimageInfoDClick);
            this.Controls.Add(this.labelimageInfoClick);
            this.Controls.Add(this.pictureBoxColors);
            this.Controls.Add(this.lblZoomFactor);
            this.Controls.Add(this.picZoom);
            this.Controls.Add(this.trbZoomFactor);
            this.Controls.Add(this.buttonAppend);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.txtLogoInternalFile);
            this.Controls.Add(this.tvLogo);
            this.Controls.Add(this.cboMoto);
            this.Controls.Add(this.labelLogos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.labelSignYourLogo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxLogoResolution);
            this.Controls.Add(this.groupBoxLogoExtension);
            this.Controls.Add(this.groupBoxLogoImageOrientation);
            this.Controls.Add(this.groupBoxLogoMemory);
            this.Controls.Add(this.groupBoxLogoImageOption);
            this.Controls.Add(this.groupBoxLogoFormat);
            this.Controls.Add(this.labelLicenseTimer);
            this.Controls.Add(this.btnOpenLogoFile);
            this.Controls.Add(this.labelbtnOpenLogoFile);
            this.Controls.Add(this.btnAttachPath);
            this.Controls.Add(this.txtLogoBuildPath);
            this.Controls.Add(this.labelBuildPath);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelbtnStop);
            this.Controls.Add(this.labelbtnBuild);
            this.Controls.Add(this.textLogoName);
            this.Controls.Add(this.labelLogoName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelMainIconTool);
            this.Controls.Add(this.ToolTitle);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moto_Boot_Logo_Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxLogoImageOrientation.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.groupBoxLogoMemory.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.groupBoxLogoImageOption.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBoxLogoFormat.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBoxLogoResolution.ResumeLayout(false);
            this.groupBoxLogoResolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionY)).EndInit();
            this.groupBoxLogoExtension.ResumeLayout(false);
            this.groupBoxLogoExtension.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFireworks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotoGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotoGifHallo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label labelMainIconTool;
        private System.Windows.Forms.Label ToolTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darktoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lighttoolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem joinTelegramBootLogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoG6PlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoG6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoG7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoG7PlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoG7PowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoG7PlayToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem downloadSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testYourNewLogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label btnMaximize;
        public System.Windows.Forms.Label labelLicenseTimer;
        private System.Windows.Forms.Label btnOpenLogoFile;
        private System.Windows.Forms.Label labelbtnOpenLogoFile;
        public System.Windows.Forms.TextBox txtLogoBuildPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.RadioButton rdoLayoutPortrait;
        private System.Windows.Forms.RadioButton rdoLayoutLandscape;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton rdoImageCenter;
        private System.Windows.Forms.RadioButton rdoImageStretchAspect;
        private System.Windows.Forms.RadioButton rdoImageFill;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton rdoAndroid44;
        private System.Windows.Forms.RadioButton rdoAndroid43;
        private System.Windows.Forms.RadioButton rdoAndroidRAW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udResolutionX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown udResolutionY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonBIN;
        private System.Windows.Forms.RadioButton radioButtonZIP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label labelSignYourLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogos;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label lblZoomFactor;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.TrackBar trbZoomFactor;
        private System.Windows.Forms.Label labelImageStatus;
        private System.Windows.Forms.Label labelColorDraw;
        private System.Windows.Forms.Label labelimageInfoDClick;
        private System.Windows.Forms.Label labelimageInfoClick;
        private System.Windows.Forms.PictureBox pictureBoxColors;
        private System.Windows.Forms.Label labelErrorGoToFileInfo;
        private System.Windows.Forms.Label labelErrorInfo;
        private System.Windows.Forms.Label labelGoToError;
        private System.Windows.Forms.Label labelErrorIcon;
        private System.Windows.Forms.Label btnReload;
        private System.Windows.Forms.Label labelReload;
        private System.Windows.Forms.PictureBox pictureBoxFireworks;
        private System.Windows.Forms.PictureBox pictureBoxMotoGif;
        private System.Windows.Forms.TextBox textBoxSearchDevice;
        private System.Windows.Forms.Label labelSearchDevice;
        private System.Windows.Forms.Label btnSearchDevice;
        private System.Windows.Forms.PictureBox pictureBoxMotoGifHallo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textLogoName;
        public System.Windows.Forms.Label labelLogoName;
        public System.Windows.Forms.Label btnAttachPath;
        public System.Windows.Forms.Label labelBuildPath;
        public System.Windows.Forms.GroupBox groupBoxLogoImageOrientation;
        public System.Windows.Forms.GroupBox groupBoxLogoMemory;
        public System.Windows.Forms.GroupBox groupBoxLogoImageOption;
        public System.Windows.Forms.GroupBox groupBoxLogoFormat;
        public System.Windows.Forms.GroupBox groupBoxLogoResolution;
        public System.Windows.Forms.GroupBox groupBoxLogoExtension;
        public System.Windows.Forms.TextBox txtComments;
        public System.Windows.Forms.TreeView tvLogo;
        public System.Windows.Forms.TextBox txtLogoInternalFile;
        public System.Windows.Forms.Label btnBuild;
        public System.Windows.Forms.Label btnStop;
        public System.Windows.Forms.Label labelbtnStop;
        public System.Windows.Forms.Label labelbtnBuild;
        public System.Windows.Forms.ComboBox cboMoto;
        public System.Windows.Forms.RadioButton radioButton4mib;
        public System.Windows.Forms.RadioButton radioButton6MIB;
        public System.Windows.Forms.RadioButton radioButton8MIB;
        public System.Windows.Forms.RadioButton radioButton16MIB;
        public System.Windows.Forms.RadioButton radioButton32MIB;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenCustomLogo;
    }
}