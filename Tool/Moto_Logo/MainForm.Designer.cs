/* 
#####################################################################
#    File: MainForm.Designer.cs                                     #
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
            this.tvLogo = new System.Windows.Forms.TreeView();
            this.labelImageStatus = new DarkUI.Controls.DarkTitle();
            this.labelimageInfoDClick = new DarkUI.Controls.DarkTitle();
            this.labelimageInfoClick = new DarkUI.Controls.DarkTitle();
            this.labelColorDraw = new DarkUI.Controls.DarkTitle();
            this.groupBoxLogoImageOrientation = new DarkUI.Controls.DarkGroupBox();
            this.rdoLayoutLandscape = new DarkUI.Controls.DarkRadioButton();
            this.rdoLayoutPortrait = new DarkUI.Controls.DarkRadioButton();
            this.groupBoxLogoImageOption = new DarkUI.Controls.DarkGroupBox();
            this.rdoImageFill = new DarkUI.Controls.DarkRadioButton();
            this.rdoImageStretchAspect = new DarkUI.Controls.DarkRadioButton();
            this.rdoImageCenter = new DarkUI.Controls.DarkRadioButton();
            this.groupBoxLogoFormat = new DarkUI.Controls.DarkGroupBox();
            this.rdoAndroidRAW = new DarkUI.Controls.DarkRadioButton();
            this.rdoAndroid43 = new DarkUI.Controls.DarkRadioButton();
            this.rdoAndroid44 = new DarkUI.Controls.DarkRadioButton();
            this.groupBoxLogoMemory = new DarkUI.Controls.DarkGroupBox();
            this.radioButton32MIB = new DarkUI.Controls.DarkRadioButton();
            this.radioButton16MIB = new DarkUI.Controls.DarkRadioButton();
            this.radioButton8MIB = new DarkUI.Controls.DarkRadioButton();
            this.radioButton6MIB = new DarkUI.Controls.DarkRadioButton();
            this.radioButton4mib = new DarkUI.Controls.DarkRadioButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBoxColors = new System.Windows.Forms.PictureBox();
            this.trbZoomFactor = new System.Windows.Forms.TrackBar();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxLogoExtension = new DarkUI.Controls.DarkGroupBox();
            this.radioButtonBIN = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonZIP = new DarkUI.Controls.DarkRadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.buttonDelete = new DarkUI.Controls.DarkButton();
            this.buttonExtract = new DarkUI.Controls.DarkButton();
            this.buttonAppend = new DarkUI.Controls.DarkButton();
            this.txtLogoInternalFile = new DarkUI.Controls.DarkTextBox();
            this.labelSignYourLogo = new DarkUI.Controls.DarkLabel();
            this.menuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenCustomLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtComments = new DarkUI.Controls.DarkTextBox();
            this.lblZoomFactor = new DarkUI.Controls.DarkLabel();
            this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.udResolutionX = new DarkUI.Controls.DarkNumericUpDown();
            this.label2 = new DarkUI.Controls.DarkLabel();
            this.label5 = new DarkUI.Controls.DarkLabel();
            this.udResolutionY = new DarkUI.Controls.DarkNumericUpDown();
            this.groupBoxLogoResolution = new DarkUI.Controls.DarkGroupBox();
            this.darkToolStrip1 = new DarkUI.Controls.DarkToolStrip();
            this.labelbtnBuild = new System.Windows.Forms.ToolStripLabel();
            this.btnBuild = new System.Windows.Forms.ToolStripButton();
            this.labelbtnStop = new System.Windows.Forms.ToolStripLabel();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.labelLogoName = new System.Windows.Forms.ToolStripLabel();
            this.textLogoName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.labelBuildPath = new System.Windows.Forms.ToolStripLabel();
            this.btnAttachPath = new System.Windows.Forms.ToolStripButton();
            this.txtLogoBuildPath = new System.Windows.Forms.ToolStripTextBox();
            this.labelbtnOpenLogoFile = new System.Windows.Forms.ToolStripLabel();
            this.btnOpenLogoFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cboMoto = new System.Windows.Forms.ToolStripComboBox();
            this.darkToolStrip2 = new DarkUI.Controls.DarkToolStrip();
            this.labelReload = new System.Windows.Forms.ToolStripLabel();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.labelErrorIcon = new System.Windows.Forms.ToolStripButton();
            this.labelErrorInfo = new System.Windows.Forms.ToolStripTextBox();
            this.labelErrorGoToFileInfo = new System.Windows.Forms.ToolStripLabel();
            this.labelGoToError = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.labelSearchDevice = new System.Windows.Forms.ToolStripLabel();
            this.textBoxSearchDevice = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearchDevice = new System.Windows.Forms.ToolStripButton();
            this.groupBoxLogoImageOrientation.SuspendLayout();
            this.groupBoxLogoImageOption.SuspendLayout();
            this.groupBoxLogoFormat.SuspendLayout();
            this.groupBoxLogoMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            this.groupBoxLogoExtension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.darkStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionY)).BeginInit();
            this.groupBoxLogoResolution.SuspendLayout();
            this.darkToolStrip1.SuspendLayout();
            this.darkToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvLogo
            // 
            this.tvLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tvLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tvLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.tvLogo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tvLogo.Location = new System.Drawing.Point(4, 316);
            this.tvLogo.Name = "tvLogo";
            this.tvLogo.ShowNodeToolTips = true;
            this.tvLogo.Size = new System.Drawing.Size(328, 307);
            this.tvLogo.TabIndex = 201;
            this.tvLogo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLogo_AfterSelect);
            this.tvLogo.DoubleClick += new System.EventHandler(this.tvLogo_DoubleClick);
            // 
            // labelImageStatus
            // 
            this.labelImageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImageStatus.AutoSize = true;
            this.labelImageStatus.Location = new System.Drawing.Point(866, 658);
            this.labelImageStatus.Name = "labelImageStatus";
            this.labelImageStatus.Size = new System.Drawing.Size(16, 13);
            this.labelImageStatus.TabIndex = 200;
            this.labelImageStatus.Text = "---";
            // 
            // labelimageInfoDClick
            // 
            this.labelimageInfoDClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelimageInfoDClick.AutoSize = true;
            this.labelimageInfoDClick.Location = new System.Drawing.Point(862, 616);
            this.labelimageInfoDClick.Name = "labelimageInfoDClick";
            this.labelimageInfoDClick.Size = new System.Drawing.Size(173, 13);
            this.labelimageInfoDClick.TabIndex = 199;
            this.labelimageInfoDClick.Text = "* Double click and will be unlocked";
            // 
            // labelimageInfoClick
            // 
            this.labelimageInfoClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelimageInfoClick.AutoSize = true;
            this.labelimageInfoClick.Location = new System.Drawing.Point(862, 586);
            this.labelimageInfoClick.Name = "labelimageInfoClick";
            this.labelimageInfoClick.Size = new System.Drawing.Size(171, 13);
            this.labelimageInfoClick.TabIndex = 198;
            this.labelimageInfoClick.Text = "* Click on image and will be locked";
            // 
            // labelColorDraw
            // 
            this.labelColorDraw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelColorDraw.AutoSize = true;
            this.labelColorDraw.Location = new System.Drawing.Point(866, 518);
            this.labelColorDraw.Name = "labelColorDraw";
            this.labelColorDraw.Size = new System.Drawing.Size(33, 13);
            this.labelColorDraw.TabIndex = 197;
            this.labelColorDraw.Text = "RGB:";
            // 
            // groupBoxLogoImageOrientation
            // 
            this.groupBoxLogoImageOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogoImageOrientation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoImageOrientation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoImageOrientation.Controls.Add(this.rdoLayoutLandscape);
            this.groupBoxLogoImageOrientation.Controls.Add(this.rdoLayoutPortrait);
            this.groupBoxLogoImageOrientation.Location = new System.Drawing.Point(901, 91);
            this.groupBoxLogoImageOrientation.Name = "groupBoxLogoImageOrientation";
            this.groupBoxLogoImageOrientation.Size = new System.Drawing.Size(250, 46);
            this.groupBoxLogoImageOrientation.TabIndex = 196;
            this.groupBoxLogoImageOrientation.TabStop = false;
            this.groupBoxLogoImageOrientation.Text = "Image Orientation Options";
            // 
            // rdoLayoutLandscape
            // 
            this.rdoLayoutLandscape.AutoSize = true;
            this.rdoLayoutLandscape.Location = new System.Drawing.Point(104, 23);
            this.rdoLayoutLandscape.Name = "rdoLayoutLandscape";
            this.rdoLayoutLandscape.Size = new System.Drawing.Size(78, 17);
            this.rdoLayoutLandscape.TabIndex = 7;
            this.rdoLayoutLandscape.Text = "Landscape";
            this.rdoLayoutLandscape.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoLayoutPortrait
            // 
            this.rdoLayoutPortrait.AutoSize = true;
            this.rdoLayoutPortrait.Checked = true;
            this.rdoLayoutPortrait.Location = new System.Drawing.Point(6, 23);
            this.rdoLayoutPortrait.Name = "rdoLayoutPortrait";
            this.rdoLayoutPortrait.Size = new System.Drawing.Size(58, 17);
            this.rdoLayoutPortrait.TabIndex = 6;
            this.rdoLayoutPortrait.TabStop = true;
            this.rdoLayoutPortrait.Text = "Portrait";
            this.rdoLayoutPortrait.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // groupBoxLogoImageOption
            // 
            this.groupBoxLogoImageOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogoImageOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoImageOption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoImageOption.Controls.Add(this.rdoImageFill);
            this.groupBoxLogoImageOption.Controls.Add(this.rdoImageStretchAspect);
            this.groupBoxLogoImageOption.Controls.Add(this.rdoImageCenter);
            this.groupBoxLogoImageOption.Location = new System.Drawing.Point(209, 143);
            this.groupBoxLogoImageOption.Name = "groupBoxLogoImageOption";
            this.groupBoxLogoImageOption.Size = new System.Drawing.Size(942, 46);
            this.groupBoxLogoImageOption.TabIndex = 195;
            this.groupBoxLogoImageOption.TabStop = false;
            this.groupBoxLogoImageOption.Text = "Image Fill Options";
            // 
            // rdoImageFill
            // 
            this.rdoImageFill.Location = new System.Drawing.Point(421, 21);
            this.rdoImageFill.Name = "rdoImageFill";
            this.rdoImageFill.Size = new System.Drawing.Size(500, 17);
            this.rdoImageFill.TabIndex = 8;
            this.rdoImageFill.Text = "Fill";
            this.rdoImageFill.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoImageStretchAspect
            // 
            this.rdoImageStretchAspect.Location = new System.Drawing.Point(131, 23);
            this.rdoImageStretchAspect.Name = "rdoImageStretchAspect";
            this.rdoImageStretchAspect.Size = new System.Drawing.Size(275, 17);
            this.rdoImageStretchAspect.TabIndex = 7;
            this.rdoImageStretchAspect.Text = "Stretch Proportionately";
            this.rdoImageStretchAspect.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoImageCenter
            // 
            this.rdoImageCenter.Checked = true;
            this.rdoImageCenter.Location = new System.Drawing.Point(6, 23);
            this.rdoImageCenter.Name = "rdoImageCenter";
            this.rdoImageCenter.Size = new System.Drawing.Size(119, 17);
            this.rdoImageCenter.TabIndex = 6;
            this.rdoImageCenter.TabStop = true;
            this.rdoImageCenter.Text = "Center";
            this.rdoImageCenter.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // groupBoxLogoFormat
            // 
            this.groupBoxLogoFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogoFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoFormat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoFormat.Controls.Add(this.rdoAndroidRAW);
            this.groupBoxLogoFormat.Controls.Add(this.rdoAndroid43);
            this.groupBoxLogoFormat.Controls.Add(this.rdoAndroid44);
            this.groupBoxLogoFormat.Location = new System.Drawing.Point(450, 91);
            this.groupBoxLogoFormat.Name = "groupBoxLogoFormat";
            this.groupBoxLogoFormat.Size = new System.Drawing.Size(449, 46);
            this.groupBoxLogoFormat.TabIndex = 193;
            this.groupBoxLogoFormat.TabStop = false;
            this.groupBoxLogoFormat.Text = "logo.bin format";
            // 
            // rdoAndroidRAW
            // 
            this.rdoAndroidRAW.Location = new System.Drawing.Point(293, 23);
            this.rdoAndroidRAW.Name = "rdoAndroidRAW";
            this.rdoAndroidRAW.Size = new System.Drawing.Size(150, 17);
            this.rdoAndroidRAW.TabIndex = 8;
            this.rdoAndroidRAW.Text = "Raw 540x540";
            this.rdoAndroidRAW.CheckedChanged += new System.EventHandler(this.rdoAndroidRAW_CheckedChanged);
            // 
            // rdoAndroid43
            // 
            this.rdoAndroid43.Location = new System.Drawing.Point(130, 23);
            this.rdoAndroid43.Name = "rdoAndroid43";
            this.rdoAndroid43.Size = new System.Drawing.Size(157, 17);
            this.rdoAndroid43.TabIndex = 7;
            this.rdoAndroid43.Text = "540x540 Bundle";
            this.rdoAndroid43.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoAndroid44
            // 
            this.rdoAndroid44.Checked = true;
            this.rdoAndroid44.Location = new System.Drawing.Point(6, 23);
            this.rdoAndroid44.Name = "rdoAndroid44";
            this.rdoAndroid44.Size = new System.Drawing.Size(118, 17);
            this.rdoAndroid44.TabIndex = 6;
            this.rdoAndroid44.TabStop = true;
            this.rdoAndroid44.Text = "Default";
            this.rdoAndroid44.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // groupBoxLogoMemory
            // 
            this.groupBoxLogoMemory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoMemory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoMemory.Controls.Add(this.radioButton32MIB);
            this.groupBoxLogoMemory.Controls.Add(this.radioButton16MIB);
            this.groupBoxLogoMemory.Controls.Add(this.radioButton8MIB);
            this.groupBoxLogoMemory.Controls.Add(this.radioButton6MIB);
            this.groupBoxLogoMemory.Controls.Add(this.radioButton4mib);
            this.groupBoxLogoMemory.Location = new System.Drawing.Point(162, 91);
            this.groupBoxLogoMemory.Name = "groupBoxLogoMemory";
            this.groupBoxLogoMemory.Size = new System.Drawing.Size(286, 46);
            this.groupBoxLogoMemory.TabIndex = 186;
            this.groupBoxLogoMemory.TabStop = false;
            this.groupBoxLogoMemory.Text = "Select your logo memory";
            // 
            // radioButton32MIB
            // 
            this.radioButton32MIB.AutoSize = true;
            this.radioButton32MIB.Location = new System.Drawing.Point(224, 23);
            this.radioButton32MIB.Name = "radioButton32MIB";
            this.radioButton32MIB.Size = new System.Drawing.Size(53, 17);
            this.radioButton32MIB.TabIndex = 10;
            this.radioButton32MIB.Text = "32MB";
            this.radioButton32MIB.CheckedChanged += new System.EventHandler(this.radioButton32MIB_CheckedChanged);
            // 
            // radioButton16MIB
            // 
            this.radioButton16MIB.AutoSize = true;
            this.radioButton16MIB.Location = new System.Drawing.Point(165, 23);
            this.radioButton16MIB.Name = "radioButton16MIB";
            this.radioButton16MIB.Size = new System.Drawing.Size(53, 17);
            this.radioButton16MIB.TabIndex = 9;
            this.radioButton16MIB.Text = "16MB";
            this.radioButton16MIB.CheckedChanged += new System.EventHandler(this.radioButton16MIB_CheckedChanged);
            // 
            // radioButton8MIB
            // 
            this.radioButton8MIB.AutoSize = true;
            this.radioButton8MIB.Location = new System.Drawing.Point(112, 23);
            this.radioButton8MIB.Name = "radioButton8MIB";
            this.radioButton8MIB.Size = new System.Drawing.Size(47, 17);
            this.radioButton8MIB.TabIndex = 8;
            this.radioButton8MIB.Text = "8MB";
            this.radioButton8MIB.CheckedChanged += new System.EventHandler(this.radioButton8MIB_CheckedChanged);
            // 
            // radioButton6MIB
            // 
            this.radioButton6MIB.AutoSize = true;
            this.radioButton6MIB.Location = new System.Drawing.Point(59, 23);
            this.radioButton6MIB.Name = "radioButton6MIB";
            this.radioButton6MIB.Size = new System.Drawing.Size(47, 17);
            this.radioButton6MIB.TabIndex = 7;
            this.radioButton6MIB.Text = "6MB";
            this.radioButton6MIB.CheckedChanged += new System.EventHandler(this.radioButton6MIB_CheckedChanged);
            // 
            // radioButton4mib
            // 
            this.radioButton4mib.AutoSize = true;
            this.radioButton4mib.Location = new System.Drawing.Point(6, 23);
            this.radioButton4mib.Name = "radioButton4mib";
            this.radioButton4mib.Size = new System.Drawing.Size(47, 17);
            this.radioButton4mib.TabIndex = 6;
            this.radioButton4mib.Text = "4MB";
            this.radioButton4mib.CheckedChanged += new System.EventHandler(this.radioButton4mib_CheckedChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // pictureBoxColors
            // 
            this.pictureBoxColors.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pictureBoxColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColors.Location = new System.Drawing.Point(865, 534);
            this.pictureBoxColors.Name = "pictureBoxColors";
            this.pictureBoxColors.Size = new System.Drawing.Size(285, 31);
            this.pictureBoxColors.TabIndex = 191;
            this.pictureBoxColors.TabStop = false;
            // 
            // trbZoomFactor
            // 
            this.trbZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trbZoomFactor.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trbZoomFactor.LargeChange = 1;
            this.trbZoomFactor.Location = new System.Drawing.Point(865, 455);
            this.trbZoomFactor.Maximum = 6;
            this.trbZoomFactor.Minimum = 2;
            this.trbZoomFactor.Name = "trbZoomFactor";
            this.trbZoomFactor.Size = new System.Drawing.Size(263, 45);
            this.trbZoomFactor.TabIndex = 189;
            this.trbZoomFactor.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbZoomFactor.Value = 3;
            this.trbZoomFactor.ValueChanged += new System.EventHandler(this.trbZoomFactor_ValueChanged);
            // 
            // picZoom
            // 
            this.picZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.picZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZoom.Location = new System.Drawing.Point(865, 195);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(286, 254);
            this.picZoom.TabIndex = 188;
            this.picZoom.TabStop = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // groupBoxLogoExtension
            // 
            this.groupBoxLogoExtension.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoExtension.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoExtension.Controls.Add(this.radioButtonBIN);
            this.groupBoxLogoExtension.Controls.Add(this.radioButtonZIP);
            this.groupBoxLogoExtension.Location = new System.Drawing.Point(4, 91);
            this.groupBoxLogoExtension.Name = "groupBoxLogoExtension";
            this.groupBoxLogoExtension.Size = new System.Drawing.Size(156, 46);
            this.groupBoxLogoExtension.TabIndex = 185;
            this.groupBoxLogoExtension.TabStop = false;
            this.groupBoxLogoExtension.Text = "Select your extension";
            // 
            // radioButtonBIN
            // 
            this.radioButtonBIN.AutoSize = true;
            this.radioButtonBIN.Checked = true;
            this.radioButtonBIN.Location = new System.Drawing.Point(67, 23);
            this.radioButtonBIN.Name = "radioButtonBIN";
            this.radioButtonBIN.Size = new System.Drawing.Size(42, 17);
            this.radioButtonBIN.TabIndex = 7;
            this.radioButtonBIN.TabStop = true;
            this.radioButtonBIN.Text = ".bin";
            // 
            // radioButtonZIP
            // 
            this.radioButtonZIP.AutoSize = true;
            this.radioButtonZIP.Location = new System.Drawing.Point(6, 23);
            this.radioButtonZIP.Name = "radioButtonZIP";
            this.radioButtonZIP.Size = new System.Drawing.Size(41, 17);
            this.radioButtonZIP.TabIndex = 6;
            this.radioButtonZIP.Text = ".zip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(336, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 183;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(-64, 308);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(39, 13);
            this.darkLabel1.TabIndex = 182;
            this.darkLabel1.Text = "Logos:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(233, 652);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Size = new System.Drawing.Size(98, 23);
            this.buttonDelete.TabIndex = 181;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExtract.Location = new System.Drawing.Point(118, 652);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Padding = new System.Windows.Forms.Padding(5);
            this.buttonExtract.Size = new System.Drawing.Size(98, 23);
            this.buttonExtract.TabIndex = 180;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // buttonAppend
            // 
            this.buttonAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAppend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAppend.Location = new System.Drawing.Point(4, 652);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAppend.Size = new System.Drawing.Size(98, 23);
            this.buttonAppend.TabIndex = 179;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // txtLogoInternalFile
            // 
            this.txtLogoInternalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLogoInternalFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtLogoInternalFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogoInternalFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtLogoInternalFile.Location = new System.Drawing.Point(4, 628);
            this.txtLogoInternalFile.Name = "txtLogoInternalFile";
            this.txtLogoInternalFile.Size = new System.Drawing.Size(328, 20);
            this.txtLogoInternalFile.TabIndex = 178;
            this.txtLogoInternalFile.TextChanged += new System.EventHandler(this.txtLogoInternalFile_TextChanged);
            // 
            // labelSignYourLogo
            // 
            this.labelSignYourLogo.AutoSize = true;
            this.labelSignYourLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelSignYourLogo.Location = new System.Drawing.Point(1, 192);
            this.labelSignYourLogo.Name = "labelSignYourLogo";
            this.labelSignYourLogo.Size = new System.Drawing.Size(59, 13);
            this.labelSignYourLogo.TabIndex = 177;
            this.labelSignYourLogo.Text = "Comments:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 176;
            this.menuStrip1.Text = "darkMenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItemOpenCustomLogo});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "Files";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItemOpenCustomLogo
            // 
            this.toolStripMenuItemOpenCustomLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripMenuItemOpenCustomLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripMenuItemOpenCustomLogo.Name = "toolStripMenuItemOpenCustomLogo";
            this.toolStripMenuItemOpenCustomLogo.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItemOpenCustomLogo.Text = "&Open Custom Logo";
            this.toolStripMenuItemOpenCustomLogo.Click += new System.EventHandler(this.toolStripMenuItemOpenCustomLogo_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.testToolStripMenuItem,
            this.downloadSiteToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.sourceToolStripMenuItem});
            this.toolToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.checkForUpdatesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "&Check Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.testToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.testToolStripMenuItem.Text = "&Test Logo";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testLogoToolStripMenuItem_Click);
            // 
            // downloadSiteToolStripMenuItem
            // 
            this.downloadSiteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.downloadSiteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.downloadSiteToolStripMenuItem.Name = "downloadSiteToolStripMenuItem";
            this.downloadSiteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.downloadSiteToolStripMenuItem.Text = "&Download Site";
            this.downloadSiteToolStripMenuItem.Click += new System.EventHandler(this.downloadSiteToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.changelogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.changelogToolStripMenuItem.Text = "&Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.sourceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sourceToolStripMenuItem.Text = "&Source";
            this.sourceToolStripMenuItem.Click += new System.EventHandler(this.sourceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtComments.Location = new System.Drawing.Point(4, 210);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(327, 87);
            this.txtComments.TabIndex = 175;
            // 
            // lblZoomFactor
            // 
            this.lblZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoomFactor.AutoSize = true;
            this.lblZoomFactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblZoomFactor.Location = new System.Drawing.Point(1134, 470);
            this.lblZoomFactor.Name = "lblZoomFactor";
            this.lblZoomFactor.Size = new System.Drawing.Size(20, 13);
            this.lblZoomFactor.TabIndex = 190;
            this.lblZoomFactor.Text = "X3";
            // 
            // darkStatusStrip1
            // 
            this.darkStatusStrip1.AutoSize = false;
            this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.darkStatusStrip1.Location = new System.Drawing.Point(0, 678);
            this.darkStatusStrip1.Name = "darkStatusStrip1";
            this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip1.Size = new System.Drawing.Size(1155, 33);
            this.darkStatusStrip1.SizingGrip = false;
            this.darkStatusStrip1.TabIndex = 184;
            this.darkStatusStrip1.Text = "darkStatusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(330, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(22, 20);
            this.toolStripStatusLabel1.Text = "---";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 20);
            this.toolStripStatusLabel2.Text = "---";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files|*.bmp;*.png;*.jpg|Bin Files|*.bin|All Files|*.*";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(1, 300);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(39, 13);
            this.darkLabel3.TabIndex = 182;
            this.darkLabel3.Text = "Logos:";
            // 
            // udResolutionX
            // 
            this.udResolutionX.Location = new System.Drawing.Point(29, 18);
            this.udResolutionX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udResolutionX.Name = "udResolutionX";
            this.udResolutionX.Size = new System.Drawing.Size(67, 20);
            this.udResolutionX.TabIndex = 6;
            this.udResolutionX.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.udResolutionX.ValueChanged += new System.EventHandler(this.udResolutionX_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label5.Location = new System.Drawing.Point(102, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y:";
            // 
            // udResolutionY
            // 
            this.udResolutionY.Location = new System.Drawing.Point(125, 18);
            this.udResolutionY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udResolutionY.Name = "udResolutionY";
            this.udResolutionY.Size = new System.Drawing.Size(67, 20);
            this.udResolutionY.TabIndex = 8;
            this.udResolutionY.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.udResolutionY.ValueChanged += new System.EventHandler(this.udResolutionY_ValueChanged);
            // 
            // groupBoxLogoResolution
            // 
            this.groupBoxLogoResolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoResolution.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoResolution.Controls.Add(this.udResolutionY);
            this.groupBoxLogoResolution.Controls.Add(this.label5);
            this.groupBoxLogoResolution.Controls.Add(this.label2);
            this.groupBoxLogoResolution.Controls.Add(this.udResolutionX);
            this.groupBoxLogoResolution.Location = new System.Drawing.Point(4, 143);
            this.groupBoxLogoResolution.Name = "groupBoxLogoResolution";
            this.groupBoxLogoResolution.Size = new System.Drawing.Size(203, 46);
            this.groupBoxLogoResolution.TabIndex = 194;
            this.groupBoxLogoResolution.TabStop = false;
            this.groupBoxLogoResolution.Text = "Resolution";
            // 
            // darkToolStrip1
            // 
            this.darkToolStrip1.AutoSize = false;
            this.darkToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkToolStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelbtnBuild,
            this.btnBuild,
            this.labelbtnStop,
            this.btnStop,
            this.toolStripSeparator7,
            this.labelLogoName,
            this.textLogoName,
            this.toolStripSeparator8,
            this.labelBuildPath,
            this.btnAttachPath,
            this.txtLogoBuildPath,
            this.labelbtnOpenLogoFile,
            this.btnOpenLogoFile,
            this.toolStripSeparator9,
            this.cboMoto});
            this.darkToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.darkToolStrip1.Name = "darkToolStrip1";
            this.darkToolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.darkToolStrip1.Size = new System.Drawing.Size(1155, 28);
            this.darkToolStrip1.TabIndex = 202;
            this.darkToolStrip1.Text = "darkToolStrip1";
            // 
            // labelbtnBuild
            // 
            this.labelbtnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelbtnBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelbtnBuild.Name = "labelbtnBuild";
            this.labelbtnBuild.Size = new System.Drawing.Size(34, 25);
            this.labelbtnBuild.Text = "Build";
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnBuild.Image = global::Moto_Logo.Properties.Resources.Build_x16;
            this.btnBuild.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(23, 25);
            this.btnBuild.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuild.ToolTipText = "Build and save Logo.bin file";
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // labelbtnStop
            // 
            this.labelbtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelbtnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelbtnStop.Name = "labelbtnStop";
            this.labelbtnStop.Size = new System.Drawing.Size(43, 25);
            this.labelbtnStop.Text = "Cancel";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnStop.Image = global::Moto_Logo.Properties.Resources.CancelBuild_x16;
            this.btnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 25);
            this.btnStop.ToolTipText = "Stop logo build process";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // labelLogoName
            // 
            this.labelLogoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelLogoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(69, 25);
            this.labelLogoName.Text = "Logo Name";
            // 
            // textLogoName
            // 
            this.textLogoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.textLogoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textLogoName.Name = "textLogoName";
            this.textLogoName.Size = new System.Drawing.Size(100, 28);
            this.textLogoName.ToolTipText = "Input your logo name for ex: \"logo_by_franco28\"";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
            // 
            // labelBuildPath
            // 
            this.labelBuildPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelBuildPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelBuildPath.Name = "labelBuildPath";
            this.labelBuildPath.Size = new System.Drawing.Size(91, 25);
            this.labelBuildPath.Text = "Logo Build Path";
            // 
            // btnAttachPath
            // 
            this.btnAttachPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnAttachPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAttachPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnAttachPath.Image = global::Moto_Logo.Properties.Resources.OpenFolder_x16;
            this.btnAttachPath.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAttachPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAttachPath.Name = "btnAttachPath";
            this.btnAttachPath.Size = new System.Drawing.Size(23, 25);
            this.btnAttachPath.ToolTipText = "Choose logo build path";
            this.btnAttachPath.Click += new System.EventHandler(this.btnAttachPath_Click);
            // 
            // txtLogoBuildPath
            // 
            this.txtLogoBuildPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.txtLogoBuildPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtLogoBuildPath.Name = "txtLogoBuildPath";
            this.txtLogoBuildPath.Size = new System.Drawing.Size(350, 28);
            // 
            // labelbtnOpenLogoFile
            // 
            this.labelbtnOpenLogoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelbtnOpenLogoFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelbtnOpenLogoFile.Name = "labelbtnOpenLogoFile";
            this.labelbtnOpenLogoFile.Size = new System.Drawing.Size(63, 25);
            this.labelbtnOpenLogoFile.Text = "Open Path";
            // 
            // btnOpenLogoFile
            // 
            this.btnOpenLogoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnOpenLogoFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenLogoFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnOpenLogoFile.Image = global::Moto_Logo.Properties.Resources.folder_x16;
            this.btnOpenLogoFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpenLogoFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenLogoFile.Name = "btnOpenLogoFile";
            this.btnOpenLogoFile.Size = new System.Drawing.Size(23, 25);
            this.btnOpenLogoFile.ToolTipText = "Open logo folder";
            this.btnOpenLogoFile.Click += new System.EventHandler(this.btnOpenLogoFile_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 28);
            // 
            // cboMoto
            // 
            this.cboMoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.cboMoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cboMoto.Name = "cboMoto";
            this.cboMoto.Size = new System.Drawing.Size(158, 28);
            this.cboMoto.Visible = false;
            this.cboMoto.SelectedIndexChanged += new System.EventHandler(this.cboMoto_SelectedIndexChanged);
            // 
            // darkToolStrip2
            // 
            this.darkToolStrip2.AutoSize = false;
            this.darkToolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkToolStrip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkToolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelReload,
            this.btnReload,
            this.toolStripSeparator10,
            this.labelErrorIcon,
            this.labelErrorInfo,
            this.labelErrorGoToFileInfo,
            this.labelGoToError,
            this.toolStripSeparator11,
            this.labelSearchDevice,
            this.textBoxSearchDevice,
            this.btnSearchDevice});
            this.darkToolStrip2.Location = new System.Drawing.Point(0, 52);
            this.darkToolStrip2.Name = "darkToolStrip2";
            this.darkToolStrip2.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.darkToolStrip2.Size = new System.Drawing.Size(1155, 28);
            this.darkToolStrip2.TabIndex = 203;
            this.darkToolStrip2.Text = "darkToolStrip2";
            // 
            // labelReload
            // 
            this.labelReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelReload.Name = "labelReload";
            this.labelReload.Size = new System.Drawing.Size(43, 25);
            this.labelReload.Text = "Reload";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnReload.Image = global::Moto_Logo.Properties.Resources.Reload_x16;
            this.btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(23, 25);
            this.btnReload.ToolTipText = "Reload Tool";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator10.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 28);
            // 
            // labelErrorIcon
            // 
            this.labelErrorIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelErrorIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labelErrorIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelErrorIcon.Image = global::Moto_Logo.Properties.Resources.Error_x16;
            this.labelErrorIcon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.labelErrorIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.labelErrorIcon.Name = "labelErrorIcon";
            this.labelErrorIcon.Size = new System.Drawing.Size(23, 25);
            // 
            // labelErrorInfo
            // 
            this.labelErrorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelErrorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelErrorInfo.Name = "labelErrorInfo";
            this.labelErrorInfo.ReadOnly = true;
            this.labelErrorInfo.Size = new System.Drawing.Size(550, 28);
            this.labelErrorInfo.Text = "---";
            // 
            // labelErrorGoToFileInfo
            // 
            this.labelErrorGoToFileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelErrorGoToFileInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelErrorGoToFileInfo.Name = "labelErrorGoToFileInfo";
            this.labelErrorGoToFileInfo.Size = new System.Drawing.Size(67, 25);
            this.labelErrorGoToFileInfo.Text = "Open Logs:";
            // 
            // labelGoToError
            // 
            this.labelGoToError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelGoToError.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labelGoToError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelGoToError.Image = global::Moto_Logo.Properties.Resources.folder_x16;
            this.labelGoToError.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.labelGoToError.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.labelGoToError.Name = "labelGoToError";
            this.labelGoToError.Size = new System.Drawing.Size(23, 25);
            this.labelGoToError.ToolTipText = "Open logs folder";
            this.labelGoToError.Click += new System.EventHandler(this.labelGoToError_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator11.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 28);
            // 
            // labelSearchDevice
            // 
            this.labelSearchDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelSearchDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelSearchDevice.Name = "labelSearchDevice";
            this.labelSearchDevice.Size = new System.Drawing.Size(83, 25);
            this.labelSearchDevice.Text = "Search Device:";
            // 
            // textBoxSearchDevice
            // 
            this.textBoxSearchDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.textBoxSearchDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxSearchDevice.Name = "textBoxSearchDevice";
            this.textBoxSearchDevice.Size = new System.Drawing.Size(150, 28);
            this.textBoxSearchDevice.ToolTipText = "Input your device model like this: \"moto g8 power\"";
            // 
            // btnSearchDevice
            // 
            this.btnSearchDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnSearchDevice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnSearchDevice.Image = global::Moto_Logo.Properties.Resources.SearchDevice_x16;
            this.btnSearchDevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearchDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchDevice.Name = "btnSearchDevice";
            this.btnSearchDevice.Size = new System.Drawing.Size(23, 25);
            this.btnSearchDevice.ToolTipText = "Search Device";
            this.btnSearchDevice.Click += new System.EventHandler(this.btnSearchDevice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 711);
            this.Controls.Add(this.darkToolStrip2);
            this.Controls.Add(this.darkToolStrip1);
            this.Controls.Add(this.tvLogo);
            this.Controls.Add(this.labelImageStatus);
            this.Controls.Add(this.labelimageInfoDClick);
            this.Controls.Add(this.groupBoxLogoImageOrientation);
            this.Controls.Add(this.labelimageInfoClick);
            this.Controls.Add(this.labelColorDraw);
            this.Controls.Add(this.groupBoxLogoImageOption);
            this.Controls.Add(this.groupBoxLogoResolution);
            this.Controls.Add(this.groupBoxLogoFormat);
            this.Controls.Add(this.groupBoxLogoMemory);
            this.Controls.Add(this.pictureBoxColors);
            this.Controls.Add(this.trbZoomFactor);
            this.Controls.Add(this.picZoom);
            this.Controls.Add(this.groupBoxLogoExtension);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.buttonAppend);
            this.Controls.Add(this.txtLogoInternalFile);
            this.Controls.Add(this.labelSignYourLogo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblZoomFactor);
            this.Controls.Add(this.darkStatusStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moto_Boot_Logo_Maker by Franco28";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBoxLogoImageOrientation.ResumeLayout(false);
            this.groupBoxLogoImageOrientation.PerformLayout();
            this.groupBoxLogoImageOption.ResumeLayout(false);
            this.groupBoxLogoFormat.ResumeLayout(false);
            this.groupBoxLogoMemory.ResumeLayout(false);
            this.groupBoxLogoMemory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            this.groupBoxLogoExtension.ResumeLayout(false);
            this.groupBoxLogoExtension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.darkStatusStrip1.ResumeLayout(false);
            this.darkStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionY)).EndInit();
            this.groupBoxLogoResolution.ResumeLayout(false);
            this.groupBoxLogoResolution.PerformLayout();
            this.darkToolStrip1.ResumeLayout(false);
            this.darkToolStrip1.PerformLayout();
            this.darkToolStrip2.ResumeLayout(false);
            this.darkToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView tvLogo;
        private DarkUI.Controls.DarkTitle labelImageStatus;
        private DarkUI.Controls.DarkTitle labelimageInfoDClick;
        private DarkUI.Controls.DarkTitle labelimageInfoClick;
        private DarkUI.Controls.DarkTitle labelColorDraw;
        public DarkUI.Controls.DarkGroupBox groupBoxLogoImageOrientation;
        private DarkUI.Controls.DarkRadioButton rdoLayoutLandscape;
        private DarkUI.Controls.DarkRadioButton rdoLayoutPortrait;
        public DarkUI.Controls.DarkGroupBox groupBoxLogoImageOption;
        private DarkUI.Controls.DarkRadioButton rdoImageFill;
        private DarkUI.Controls.DarkRadioButton rdoImageStretchAspect;
        private DarkUI.Controls.DarkRadioButton rdoImageCenter;
        public DarkUI.Controls.DarkGroupBox groupBoxLogoFormat;
        private DarkUI.Controls.DarkRadioButton rdoAndroidRAW;
        private DarkUI.Controls.DarkRadioButton rdoAndroid43;
        private DarkUI.Controls.DarkRadioButton rdoAndroid44;
        public DarkUI.Controls.DarkGroupBox groupBoxLogoMemory;
        public DarkUI.Controls.DarkRadioButton radioButton32MIB;
        public DarkUI.Controls.DarkRadioButton radioButton16MIB;
        public DarkUI.Controls.DarkRadioButton radioButton8MIB;
        public DarkUI.Controls.DarkRadioButton radioButton6MIB;
        public DarkUI.Controls.DarkRadioButton radioButton4mib;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PictureBox pictureBoxColors;
        private System.Windows.Forms.TrackBar trbZoomFactor;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public DarkUI.Controls.DarkGroupBox groupBoxLogoExtension;
        private DarkUI.Controls.DarkRadioButton radioButtonBIN;
        private DarkUI.Controls.DarkRadioButton radioButtonZIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkButton buttonDelete;
        private DarkUI.Controls.DarkButton buttonExtract;
        private DarkUI.Controls.DarkButton buttonAppend;
        private DarkUI.Controls.DarkTextBox txtLogoInternalFile;
        private DarkUI.Controls.DarkLabel labelSignYourLogo;
        private DarkUI.Controls.DarkMenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        public DarkUI.Controls.DarkTextBox txtComments;
        private DarkUI.Controls.DarkLabel lblZoomFactor;
        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip ToolTip1;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkNumericUpDown udResolutionX;
        private DarkUI.Controls.DarkLabel label2;
        private DarkUI.Controls.DarkLabel label5;
        private DarkUI.Controls.DarkNumericUpDown udResolutionY;
        public DarkUI.Controls.DarkGroupBox groupBoxLogoResolution;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenCustomLogo;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private DarkUI.Controls.DarkToolStrip darkToolStrip1;
        private DarkUI.Controls.DarkToolStrip darkToolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel labelLogoName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel labelBuildPath;
        private System.Windows.Forms.ToolStripLabel labelbtnOpenLogoFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel labelReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel labelErrorGoToFileInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripLabel labelSearchDevice;
        public System.Windows.Forms.ToolStripTextBox textLogoName;
        public System.Windows.Forms.ToolStripTextBox txtLogoBuildPath;
        public System.Windows.Forms.ToolStripComboBox cboMoto;
        public System.Windows.Forms.ToolStripTextBox labelErrorInfo;
        public System.Windows.Forms.ToolStripTextBox textBoxSearchDevice;
        public System.Windows.Forms.ToolStripButton btnBuild;
        public System.Windows.Forms.ToolStripButton btnStop;
        public System.Windows.Forms.ToolStripButton btnAttachPath;
        public System.Windows.Forms.ToolStripButton btnOpenLogoFile;
        public System.Windows.Forms.ToolStripButton btnReload;
        public System.Windows.Forms.ToolStripButton labelErrorIcon;
        public System.Windows.Forms.ToolStripButton labelGoToError;
        public System.Windows.Forms.ToolStripButton btnSearchDevice;
        public System.Windows.Forms.ToolStripLabel labelbtnBuild;
        public System.Windows.Forms.ToolStripLabel labelbtnStop;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}