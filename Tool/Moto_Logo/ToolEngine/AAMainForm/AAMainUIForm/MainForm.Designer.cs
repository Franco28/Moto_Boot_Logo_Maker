/* 
#####################################################################
#    File: MainForm.Designer.cs                                     #
#    Author: Franco28                                               # 
#    Date: 22-05-2021                                               #
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
            this.labelColorDraw = new DarkUI.Controls.DarkTitle();
            this.groupBoxLogoImageOrientation = new DarkUI.Controls.DarkGroupBox();
            this.flowLayoutPanelgroupBoxLogoImageOrientation = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoLayoutLandscape = new DarkUI.Controls.DarkRadioButton();
            this.rdoLayoutPortrait = new DarkUI.Controls.DarkRadioButton();
            this.groupBoxLogoImageOption = new DarkUI.Controls.DarkGroupBox();
            this.flowLayoutPanelgroupBoxLogoImageOption = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoImageCenter = new DarkUI.Controls.DarkRadioButton();
            this.rdoImageFill = new DarkUI.Controls.DarkRadioButton();
            this.rdoImageStretchAspect = new DarkUI.Controls.DarkRadioButton();
            this.groupBoxLogoFormat = new DarkUI.Controls.DarkGroupBox();
            this.flowLayoutPanelgroupBoxLogoFormat = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoAndroid44 = new DarkUI.Controls.DarkRadioButton();
            this.rdoAndroidRAW = new DarkUI.Controls.DarkRadioButton();
            this.rdoAndroid43 = new DarkUI.Controls.DarkRadioButton();
            this.groupBoxLogoMemory = new DarkUI.Controls.DarkGroupBox();
            this.flowLayoutPanelgroupBoxLogoMemory = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton4mib = new DarkUI.Controls.DarkRadioButton();
            this.radioButton6MIB = new DarkUI.Controls.DarkRadioButton();
            this.radioButton8MIB = new DarkUI.Controls.DarkRadioButton();
            this.radioButton16MIB = new DarkUI.Controls.DarkRadioButton();
            this.radioButton32MIB = new DarkUI.Controls.DarkRadioButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBoxColors = new System.Windows.Forms.PictureBox();
            this.trbZoomFactor = new System.Windows.Forms.TrackBar();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.groupBoxLogoExtension = new DarkUI.Controls.DarkGroupBox();
            this.flowLayoutPanelgroupBoxLogoExtension = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonBIN = new DarkUI.Controls.DarkRadioButton();
            this.radioButtonZIP = new DarkUI.Controls.DarkRadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new DarkUI.Controls.DarkButton();
            this.buttonExtract = new DarkUI.Controls.DarkButton();
            this.buttonAppend = new DarkUI.Controls.DarkButton();
            this.txtLogoInternalFile = new DarkUI.Controls.DarkTextBox();
            this.txtComments = new DarkUI.Controls.DarkTextBox();
            this.lblZoomFactor = new DarkUI.Controls.DarkLabel();
            this.MainFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SecondSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxLogoResolution = new DarkUI.Controls.DarkGroupBox();
            this.flowLayoutPanelgroupBoxLogoResolution = new System.Windows.Forms.FlowLayoutPanel();
            this.labeludResoX = new DarkUI.Controls.DarkLabel();
            this.udResolutionX = new DarkUI.Controls.DarkNumericUpDown();
            this.labeludResoY = new DarkUI.Controls.DarkLabel();
            this.udResolutionY = new DarkUI.Controls.DarkNumericUpDown();
            this.ImageStatusBox = new System.Windows.Forms.RichTextBox();
            this.labelIconRGB = new System.Windows.Forms.Label();
            this.labelIconImageBox = new System.Windows.Forms.Label();
            this.labelIconLUImage = new System.Windows.Forms.Label();
            this.labelIconMessageBoxLogo = new System.Windows.Forms.Label();
            this.labelIconTVLogo = new System.Windows.Forms.Label();
            this.labelIconZoomFC = new System.Windows.Forms.Label();
            this.labelIcontxtLogoInternalFile = new System.Windows.Forms.Label();
            this.labelIconBTNDelete = new System.Windows.Forms.Label();
            this.labelIconBTNExtract = new System.Windows.Forms.Label();
            this.labelIconBTNAppend = new System.Windows.Forms.Label();
            this.darkSectionPanelMainBTNS = new DarkUI.Controls.DarkSectionPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tvLogo = new System.Windows.Forms.TreeView();
            this.ToolStripMainMenu = new DarkUI.Controls.DarkToolStrip();
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
            this.MainMenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenCustomLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new DarkUI.Controls.DarkStatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripMainMenu2 = new DarkUI.Controls.DarkToolStrip();
            this.labelReload = new System.Windows.Forms.ToolStripLabel();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorErrorMsg = new System.Windows.Forms.ToolStripSeparator();
            this.labelErrorIcon = new System.Windows.Forms.ToolStripButton();
            this.labelErrorInfo = new System.Windows.Forms.ToolStripTextBox();
            this.labelErrorGoToFileInfo = new System.Windows.Forms.ToolStripLabel();
            this.labelGoToError = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.labelSearchDevice = new System.Windows.Forms.ToolStripLabel();
            this.textBoxSearchDevice = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearchDevice = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanelGroupBox = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxLogoImageOrientation.SuspendLayout();
            this.flowLayoutPanelgroupBoxLogoImageOrientation.SuspendLayout();
            this.groupBoxLogoImageOption.SuspendLayout();
            this.flowLayoutPanelgroupBoxLogoImageOption.SuspendLayout();
            this.groupBoxLogoFormat.SuspendLayout();
            this.flowLayoutPanelgroupBoxLogoFormat.SuspendLayout();
            this.groupBoxLogoMemory.SuspendLayout();
            this.flowLayoutPanelgroupBoxLogoMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            this.groupBoxLogoExtension.SuspendLayout();
            this.flowLayoutPanelgroupBoxLogoExtension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxLogoResolution.SuspendLayout();
            this.flowLayoutPanelgroupBoxLogoResolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionY)).BeginInit();
            this.darkSectionPanelMainBTNS.SuspendLayout();
            this.ToolStripMainMenu.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.ToolStripMainMenu2.SuspendLayout();
            this.flowLayoutPanelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelColorDraw
            // 
            this.labelColorDraw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelColorDraw.AutoSize = true;
            this.labelColorDraw.Location = new System.Drawing.Point(1036, 514);
            this.labelColorDraw.Name = "labelColorDraw";
            this.labelColorDraw.Size = new System.Drawing.Size(33, 13);
            this.labelColorDraw.TabIndex = 197;
            this.labelColorDraw.Text = "RGB:";
            this.labelColorDraw.Click += new System.EventHandler(this.labelColorDraw_Click);
            // 
            // groupBoxLogoImageOrientation
            // 
            this.groupBoxLogoImageOrientation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoImageOrientation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoImageOrientation.Controls.Add(this.flowLayoutPanelgroupBoxLogoImageOrientation);
            this.groupBoxLogoImageOrientation.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxLogoImageOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLogoImageOrientation.Location = new System.Drawing.Point(826, 3);
            this.groupBoxLogoImageOrientation.Name = "groupBoxLogoImageOrientation";
            this.groupBoxLogoImageOrientation.Size = new System.Drawing.Size(201, 67);
            this.groupBoxLogoImageOrientation.TabIndex = 196;
            this.groupBoxLogoImageOrientation.TabStop = false;
            this.groupBoxLogoImageOrientation.Text = "Image Orientation Options";
            // 
            // flowLayoutPanelgroupBoxLogoImageOrientation
            // 
            this.flowLayoutPanelgroupBoxLogoImageOrientation.Controls.Add(this.rdoLayoutLandscape);
            this.flowLayoutPanelgroupBoxLogoImageOrientation.Controls.Add(this.rdoLayoutPortrait);
            this.flowLayoutPanelgroupBoxLogoImageOrientation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelgroupBoxLogoImageOrientation.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelgroupBoxLogoImageOrientation.Name = "flowLayoutPanelgroupBoxLogoImageOrientation";
            this.flowLayoutPanelgroupBoxLogoImageOrientation.Size = new System.Drawing.Size(195, 48);
            this.flowLayoutPanelgroupBoxLogoImageOrientation.TabIndex = 8;
            // 
            // rdoLayoutLandscape
            // 
            this.rdoLayoutLandscape.AutoSize = true;
            this.rdoLayoutLandscape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoLayoutLandscape.Location = new System.Drawing.Point(3, 3);
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
            this.rdoLayoutPortrait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoLayoutPortrait.Location = new System.Drawing.Point(87, 3);
            this.rdoLayoutPortrait.Name = "rdoLayoutPortrait";
            this.rdoLayoutPortrait.Size = new System.Drawing.Size(58, 17);
            this.rdoLayoutPortrait.TabIndex = 6;
            this.rdoLayoutPortrait.TabStop = true;
            this.rdoLayoutPortrait.Text = "Portrait";
            this.rdoLayoutPortrait.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // groupBoxLogoImageOption
            // 
            this.groupBoxLogoImageOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoImageOption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoImageOption.Controls.Add(this.flowLayoutPanelgroupBoxLogoImageOption);
            this.groupBoxLogoImageOption.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxLogoImageOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLogoImageOption.Location = new System.Drawing.Point(631, 3);
            this.groupBoxLogoImageOption.Name = "groupBoxLogoImageOption";
            this.groupBoxLogoImageOption.Size = new System.Drawing.Size(189, 67);
            this.groupBoxLogoImageOption.TabIndex = 195;
            this.groupBoxLogoImageOption.TabStop = false;
            this.groupBoxLogoImageOption.Text = "Image Fill Options";
            // 
            // flowLayoutPanelgroupBoxLogoImageOption
            // 
            this.flowLayoutPanelgroupBoxLogoImageOption.Controls.Add(this.rdoImageCenter);
            this.flowLayoutPanelgroupBoxLogoImageOption.Controls.Add(this.rdoImageFill);
            this.flowLayoutPanelgroupBoxLogoImageOption.Controls.Add(this.rdoImageStretchAspect);
            this.flowLayoutPanelgroupBoxLogoImageOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelgroupBoxLogoImageOption.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelgroupBoxLogoImageOption.Name = "flowLayoutPanelgroupBoxLogoImageOption";
            this.flowLayoutPanelgroupBoxLogoImageOption.Size = new System.Drawing.Size(183, 48);
            this.flowLayoutPanelgroupBoxLogoImageOption.TabIndex = 9;
            // 
            // rdoImageCenter
            // 
            this.rdoImageCenter.AutoSize = true;
            this.rdoImageCenter.Checked = true;
            this.rdoImageCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoImageCenter.Location = new System.Drawing.Point(3, 3);
            this.rdoImageCenter.Name = "rdoImageCenter";
            this.rdoImageCenter.Size = new System.Drawing.Size(56, 17);
            this.rdoImageCenter.TabIndex = 6;
            this.rdoImageCenter.TabStop = true;
            this.rdoImageCenter.Text = "Center";
            this.rdoImageCenter.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoImageFill
            // 
            this.rdoImageFill.AutoSize = true;
            this.rdoImageFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoImageFill.Location = new System.Drawing.Point(65, 3);
            this.rdoImageFill.Name = "rdoImageFill";
            this.rdoImageFill.Size = new System.Drawing.Size(37, 17);
            this.rdoImageFill.TabIndex = 8;
            this.rdoImageFill.Text = "Fill";
            this.rdoImageFill.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoImageStretchAspect
            // 
            this.rdoImageStretchAspect.AutoSize = true;
            this.rdoImageStretchAspect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoImageStretchAspect.Location = new System.Drawing.Point(3, 26);
            this.rdoImageStretchAspect.Name = "rdoImageStretchAspect";
            this.rdoImageStretchAspect.Size = new System.Drawing.Size(132, 17);
            this.rdoImageStretchAspect.TabIndex = 7;
            this.rdoImageStretchAspect.Text = "Stretch Proportionately";
            this.rdoImageStretchAspect.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // groupBoxLogoFormat
            // 
            this.groupBoxLogoFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogoFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoFormat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoFormat.Controls.Add(this.flowLayoutPanelgroupBoxLogoFormat);
            this.groupBoxLogoFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLogoFormat.Location = new System.Drawing.Point(419, 3);
            this.groupBoxLogoFormat.Name = "groupBoxLogoFormat";
            this.groupBoxLogoFormat.Size = new System.Drawing.Size(206, 67);
            this.groupBoxLogoFormat.TabIndex = 193;
            this.groupBoxLogoFormat.TabStop = false;
            this.groupBoxLogoFormat.Text = "logo.bin format";
            // 
            // flowLayoutPanelgroupBoxLogoFormat
            // 
            this.flowLayoutPanelgroupBoxLogoFormat.Controls.Add(this.rdoAndroid44);
            this.flowLayoutPanelgroupBoxLogoFormat.Controls.Add(this.rdoAndroidRAW);
            this.flowLayoutPanelgroupBoxLogoFormat.Controls.Add(this.rdoAndroid43);
            this.flowLayoutPanelgroupBoxLogoFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelgroupBoxLogoFormat.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelgroupBoxLogoFormat.Name = "flowLayoutPanelgroupBoxLogoFormat";
            this.flowLayoutPanelgroupBoxLogoFormat.Size = new System.Drawing.Size(200, 48);
            this.flowLayoutPanelgroupBoxLogoFormat.TabIndex = 0;
            // 
            // rdoAndroid44
            // 
            this.rdoAndroid44.AutoSize = true;
            this.rdoAndroid44.Checked = true;
            this.rdoAndroid44.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAndroid44.Location = new System.Drawing.Point(3, 3);
            this.rdoAndroid44.Name = "rdoAndroid44";
            this.rdoAndroid44.Size = new System.Drawing.Size(59, 17);
            this.rdoAndroid44.TabIndex = 6;
            this.rdoAndroid44.TabStop = true;
            this.rdoAndroid44.Text = "Default";
            this.rdoAndroid44.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // rdoAndroidRAW
            // 
            this.rdoAndroidRAW.AutoSize = true;
            this.rdoAndroidRAW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAndroidRAW.Location = new System.Drawing.Point(68, 3);
            this.rdoAndroidRAW.Name = "rdoAndroidRAW";
            this.rdoAndroidRAW.Size = new System.Drawing.Size(91, 17);
            this.rdoAndroidRAW.TabIndex = 8;
            this.rdoAndroidRAW.Text = "Raw 540x540";
            this.rdoAndroidRAW.CheckedChanged += new System.EventHandler(this.rdoAndroidRAW_CheckedChanged);
            // 
            // rdoAndroid43
            // 
            this.rdoAndroid43.AutoSize = true;
            this.rdoAndroid43.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAndroid43.Location = new System.Drawing.Point(3, 26);
            this.rdoAndroid43.Name = "rdoAndroid43";
            this.rdoAndroid43.Size = new System.Drawing.Size(102, 17);
            this.rdoAndroid43.TabIndex = 7;
            this.rdoAndroid43.Text = "540x540 Bundle";
            this.rdoAndroid43.CheckedChanged += new System.EventHandler(this.rdoAndroid43_CheckedChanged);
            // 
            // groupBoxLogoMemory
            // 
            this.groupBoxLogoMemory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoMemory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoMemory.Controls.Add(this.flowLayoutPanelgroupBoxLogoMemory);
            this.groupBoxLogoMemory.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLogoMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLogoMemory.Location = new System.Drawing.Point(39, 3);
            this.groupBoxLogoMemory.Name = "groupBoxLogoMemory";
            this.groupBoxLogoMemory.Size = new System.Drawing.Size(231, 67);
            this.groupBoxLogoMemory.TabIndex = 186;
            this.groupBoxLogoMemory.TabStop = false;
            this.groupBoxLogoMemory.Text = "Select your logo memory";
            // 
            // flowLayoutPanelgroupBoxLogoMemory
            // 
            this.flowLayoutPanelgroupBoxLogoMemory.Controls.Add(this.radioButton4mib);
            this.flowLayoutPanelgroupBoxLogoMemory.Controls.Add(this.radioButton6MIB);
            this.flowLayoutPanelgroupBoxLogoMemory.Controls.Add(this.radioButton8MIB);
            this.flowLayoutPanelgroupBoxLogoMemory.Controls.Add(this.radioButton16MIB);
            this.flowLayoutPanelgroupBoxLogoMemory.Controls.Add(this.radioButton32MIB);
            this.flowLayoutPanelgroupBoxLogoMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelgroupBoxLogoMemory.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelgroupBoxLogoMemory.Name = "flowLayoutPanelgroupBoxLogoMemory";
            this.flowLayoutPanelgroupBoxLogoMemory.Size = new System.Drawing.Size(225, 48);
            this.flowLayoutPanelgroupBoxLogoMemory.TabIndex = 187;
            // 
            // radioButton4mib
            // 
            this.radioButton4mib.AutoSize = true;
            this.radioButton4mib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4mib.Location = new System.Drawing.Point(3, 3);
            this.radioButton4mib.Name = "radioButton4mib";
            this.radioButton4mib.Size = new System.Drawing.Size(47, 17);
            this.radioButton4mib.TabIndex = 6;
            this.radioButton4mib.Text = "4MB";
            this.radioButton4mib.CheckedChanged += new System.EventHandler(this.radioButton4mib_CheckedChanged);
            // 
            // radioButton6MIB
            // 
            this.radioButton6MIB.AutoSize = true;
            this.radioButton6MIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6MIB.Location = new System.Drawing.Point(56, 3);
            this.radioButton6MIB.Name = "radioButton6MIB";
            this.radioButton6MIB.Size = new System.Drawing.Size(47, 17);
            this.radioButton6MIB.TabIndex = 7;
            this.radioButton6MIB.Text = "6MB";
            this.radioButton6MIB.CheckedChanged += new System.EventHandler(this.radioButton6MIB_CheckedChanged);
            // 
            // radioButton8MIB
            // 
            this.radioButton8MIB.AutoSize = true;
            this.radioButton8MIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8MIB.Location = new System.Drawing.Point(109, 3);
            this.radioButton8MIB.Name = "radioButton8MIB";
            this.radioButton8MIB.Size = new System.Drawing.Size(47, 17);
            this.radioButton8MIB.TabIndex = 8;
            this.radioButton8MIB.Text = "8MB";
            this.radioButton8MIB.CheckedChanged += new System.EventHandler(this.radioButton8MIB_CheckedChanged);
            // 
            // radioButton16MIB
            // 
            this.radioButton16MIB.AutoSize = true;
            this.radioButton16MIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton16MIB.Location = new System.Drawing.Point(162, 3);
            this.radioButton16MIB.Name = "radioButton16MIB";
            this.radioButton16MIB.Size = new System.Drawing.Size(53, 17);
            this.radioButton16MIB.TabIndex = 9;
            this.radioButton16MIB.Text = "16MB";
            this.radioButton16MIB.CheckedChanged += new System.EventHandler(this.radioButton16MIB_CheckedChanged);
            // 
            // radioButton32MIB
            // 
            this.radioButton32MIB.AutoSize = true;
            this.radioButton32MIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton32MIB.Location = new System.Drawing.Point(3, 26);
            this.radioButton32MIB.Name = "radioButton32MIB";
            this.radioButton32MIB.Size = new System.Drawing.Size(53, 17);
            this.radioButton32MIB.TabIndex = 10;
            this.radioButton32MIB.Text = "32MB";
            this.radioButton32MIB.CheckedChanged += new System.EventHandler(this.radioButton32MIB_CheckedChanged);
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
            this.pictureBoxColors.Location = new System.Drawing.Point(1039, 530);
            this.pictureBoxColors.Name = "pictureBoxColors";
            this.pictureBoxColors.Size = new System.Drawing.Size(237, 31);
            this.pictureBoxColors.TabIndex = 191;
            this.pictureBoxColors.TabStop = false;
            this.pictureBoxColors.Click += new System.EventHandler(this.pictureBoxColors_Click);
            // 
            // trbZoomFactor
            // 
            this.trbZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trbZoomFactor.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trbZoomFactor.LargeChange = 1;
            this.trbZoomFactor.Location = new System.Drawing.Point(1039, 429);
            this.trbZoomFactor.Maximum = 6;
            this.trbZoomFactor.Minimum = 2;
            this.trbZoomFactor.Name = "trbZoomFactor";
            this.trbZoomFactor.Size = new System.Drawing.Size(214, 45);
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
            this.picZoom.Location = new System.Drawing.Point(1005, 182);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(271, 241);
            this.picZoom.TabIndex = 188;
            this.picZoom.TabStop = false;
            // 
            // groupBoxLogoExtension
            // 
            this.groupBoxLogoExtension.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.groupBoxLogoExtension.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoExtension.Controls.Add(this.flowLayoutPanelgroupBoxLogoExtension);
            this.groupBoxLogoExtension.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLogoExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLogoExtension.Location = new System.Drawing.Point(276, 3);
            this.groupBoxLogoExtension.Name = "groupBoxLogoExtension";
            this.groupBoxLogoExtension.Size = new System.Drawing.Size(137, 67);
            this.groupBoxLogoExtension.TabIndex = 185;
            this.groupBoxLogoExtension.TabStop = false;
            this.groupBoxLogoExtension.Text = "Select your extension";
            // 
            // flowLayoutPanelgroupBoxLogoExtension
            // 
            this.flowLayoutPanelgroupBoxLogoExtension.Controls.Add(this.radioButtonBIN);
            this.flowLayoutPanelgroupBoxLogoExtension.Controls.Add(this.radioButtonZIP);
            this.flowLayoutPanelgroupBoxLogoExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelgroupBoxLogoExtension.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelgroupBoxLogoExtension.Name = "flowLayoutPanelgroupBoxLogoExtension";
            this.flowLayoutPanelgroupBoxLogoExtension.Size = new System.Drawing.Size(131, 48);
            this.flowLayoutPanelgroupBoxLogoExtension.TabIndex = 8;
            // 
            // radioButtonBIN
            // 
            this.radioButtonBIN.AutoSize = true;
            this.radioButtonBIN.Checked = true;
            this.radioButtonBIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonBIN.Location = new System.Drawing.Point(3, 3);
            this.radioButtonBIN.Name = "radioButtonBIN";
            this.radioButtonBIN.Size = new System.Drawing.Size(42, 17);
            this.radioButtonBIN.TabIndex = 7;
            this.radioButtonBIN.TabStop = true;
            this.radioButtonBIN.Text = ".bin";
            // 
            // radioButtonZIP
            // 
            this.radioButtonZIP.AutoSize = true;
            this.radioButtonZIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonZIP.Location = new System.Drawing.Point(51, 3);
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
            this.pictureBox1.Location = new System.Drawing.Point(359, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 183;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(223, 49);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Size = new System.Drawing.Size(120, 23);
            this.buttonDelete.TabIndex = 181;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExtract.Location = new System.Drawing.Point(35, 70);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Padding = new System.Windows.Forms.Padding(5);
            this.buttonExtract.Size = new System.Drawing.Size(125, 23);
            this.buttonExtract.TabIndex = 180;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // buttonAppend
            // 
            this.buttonAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAppend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAppend.Location = new System.Drawing.Point(35, 30);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAppend.Size = new System.Drawing.Size(125, 23);
            this.buttonAppend.TabIndex = 179;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // txtLogoInternalFile
            // 
            this.txtLogoInternalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLogoInternalFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtLogoInternalFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogoInternalFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogoInternalFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtLogoInternalFile.Location = new System.Drawing.Point(45, 624);
            this.txtLogoInternalFile.Name = "txtLogoInternalFile";
            this.txtLogoInternalFile.Size = new System.Drawing.Size(308, 22);
            this.txtLogoInternalFile.TabIndex = 178;
            this.txtLogoInternalFile.TextChanged += new System.EventHandler(this.txtLogoInternalFile_TextChanged);
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtComments.Location = new System.Drawing.Point(48, 182);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(305, 71);
            this.txtComments.TabIndex = 175;
            // 
            // lblZoomFactor
            // 
            this.lblZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoomFactor.AutoSize = true;
            this.lblZoomFactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblZoomFactor.Location = new System.Drawing.Point(1259, 442);
            this.lblZoomFactor.Name = "lblZoomFactor";
            this.lblZoomFactor.Size = new System.Drawing.Size(20, 13);
            this.lblZoomFactor.TabIndex = 190;
            this.lblZoomFactor.Text = "X3";
            // 
            // MainOpenFileDialog
            // 
            this.MainOpenFileDialog.Filter = "Image files|*.bmp;*.png;*.jpg|Bin Files|*.bin|All Files|*.*";
            // 
            // groupBoxLogoResolution
            // 
            this.groupBoxLogoResolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogoResolution.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBoxLogoResolution.Controls.Add(this.flowLayoutPanelgroupBoxLogoResolution);
            this.groupBoxLogoResolution.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxLogoResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLogoResolution.Location = new System.Drawing.Point(1033, 3);
            this.groupBoxLogoResolution.Name = "groupBoxLogoResolution";
            this.groupBoxLogoResolution.Size = new System.Drawing.Size(245, 67);
            this.groupBoxLogoResolution.TabIndex = 194;
            this.groupBoxLogoResolution.TabStop = false;
            this.groupBoxLogoResolution.Text = "Resolution";
            // 
            // flowLayoutPanelgroupBoxLogoResolution
            // 
            this.flowLayoutPanelgroupBoxLogoResolution.Controls.Add(this.labeludResoX);
            this.flowLayoutPanelgroupBoxLogoResolution.Controls.Add(this.udResolutionX);
            this.flowLayoutPanelgroupBoxLogoResolution.Controls.Add(this.labeludResoY);
            this.flowLayoutPanelgroupBoxLogoResolution.Controls.Add(this.udResolutionY);
            this.flowLayoutPanelgroupBoxLogoResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelgroupBoxLogoResolution.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelgroupBoxLogoResolution.Name = "flowLayoutPanelgroupBoxLogoResolution";
            this.flowLayoutPanelgroupBoxLogoResolution.Size = new System.Drawing.Size(239, 48);
            this.flowLayoutPanelgroupBoxLogoResolution.TabIndex = 17;
            // 
            // labeludResoX
            // 
            this.labeludResoX.AutoSize = true;
            this.labeludResoX.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeludResoX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labeludResoX.Location = new System.Drawing.Point(3, 0);
            this.labeludResoX.Name = "labeludResoX";
            this.labeludResoX.Size = new System.Drawing.Size(17, 13);
            this.labeludResoX.TabIndex = 15;
            this.labeludResoX.Text = "X:";
            // 
            // udResolutionX
            // 
            this.udResolutionX.Dock = System.Windows.Forms.DockStyle.Top;
            this.udResolutionX.InterceptArrowKeys = false;
            this.udResolutionX.Location = new System.Drawing.Point(26, 3);
            this.udResolutionX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udResolutionX.Name = "udResolutionX";
            this.udResolutionX.ReadOnly = true;
            this.udResolutionX.Size = new System.Drawing.Size(67, 20);
            this.udResolutionX.TabIndex = 13;
            this.udResolutionX.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // labeludResoY
            // 
            this.labeludResoY.AutoSize = true;
            this.labeludResoY.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeludResoY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeludResoY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labeludResoY.Location = new System.Drawing.Point(99, 0);
            this.labeludResoY.Name = "labeludResoY";
            this.labeludResoY.Size = new System.Drawing.Size(17, 13);
            this.labeludResoY.TabIndex = 16;
            this.labeludResoY.Text = "Y:";
            // 
            // udResolutionY
            // 
            this.udResolutionY.Dock = System.Windows.Forms.DockStyle.Top;
            this.udResolutionY.InterceptArrowKeys = false;
            this.udResolutionY.Location = new System.Drawing.Point(122, 3);
            this.udResolutionY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udResolutionY.Name = "udResolutionY";
            this.udResolutionY.ReadOnly = true;
            this.udResolutionY.Size = new System.Drawing.Size(67, 20);
            this.udResolutionY.TabIndex = 14;
            this.udResolutionY.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // ImageStatusBox
            // 
            this.ImageStatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageStatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ImageStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageStatusBox.ForeColor = System.Drawing.Color.White;
            this.ImageStatusBox.Location = new System.Drawing.Point(1039, 624);
            this.ImageStatusBox.Name = "ImageStatusBox";
            this.ImageStatusBox.ReadOnly = true;
            this.ImageStatusBox.Size = new System.Drawing.Size(237, 91);
            this.ImageStatusBox.TabIndex = 204;
            this.ImageStatusBox.Text = "";
            // 
            // labelIconRGB
            // 
            this.labelIconRGB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIconRGB.Image = global::Moto_Logo.Properties.Resources.rgb_x24;
            this.labelIconRGB.Location = new System.Drawing.Point(1005, 530);
            this.labelIconRGB.Name = "labelIconRGB";
            this.labelIconRGB.Size = new System.Drawing.Size(28, 31);
            this.labelIconRGB.TabIndex = 205;
            // 
            // labelIconImageBox
            // 
            this.labelIconImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIconImageBox.Image = global::Moto_Logo.Properties.Resources.image_x20;
            this.labelIconImageBox.Location = new System.Drawing.Point(1005, 624);
            this.labelIconImageBox.Name = "labelIconImageBox";
            this.labelIconImageBox.Size = new System.Drawing.Size(28, 91);
            this.labelIconImageBox.TabIndex = 206;
            // 
            // labelIconLUImage
            // 
            this.labelIconLUImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIconLUImage.Location = new System.Drawing.Point(1039, 718);
            this.labelIconLUImage.Name = "labelIconLUImage";
            this.labelIconLUImage.Size = new System.Drawing.Size(237, 31);
            this.labelIconLUImage.TabIndex = 207;
            // 
            // labelIconMessageBoxLogo
            // 
            this.labelIconMessageBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("labelIconMessageBoxLogo.Image")));
            this.labelIconMessageBoxLogo.Location = new System.Drawing.Point(9, 182);
            this.labelIconMessageBoxLogo.Name = "labelIconMessageBoxLogo";
            this.labelIconMessageBoxLogo.Size = new System.Drawing.Size(33, 71);
            this.labelIconMessageBoxLogo.TabIndex = 208;
            // 
            // labelIconTVLogo
            // 
            this.labelIconTVLogo.Image = ((System.Drawing.Image)(resources.GetObject("labelIconTVLogo.Image")));
            this.labelIconTVLogo.Location = new System.Drawing.Point(6, 259);
            this.labelIconTVLogo.Name = "labelIconTVLogo";
            this.labelIconTVLogo.Size = new System.Drawing.Size(36, 287);
            this.labelIconTVLogo.TabIndex = 209;
            // 
            // labelIconZoomFC
            // 
            this.labelIconZoomFC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIconZoomFC.Image = global::Moto_Logo.Properties.Resources.zoom_x24;
            this.labelIconZoomFC.Location = new System.Drawing.Point(1005, 426);
            this.labelIconZoomFC.Name = "labelIconZoomFC";
            this.labelIconZoomFC.Size = new System.Drawing.Size(28, 48);
            this.labelIconZoomFC.TabIndex = 210;
            // 
            // labelIcontxtLogoInternalFile
            // 
            this.labelIcontxtLogoInternalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIcontxtLogoInternalFile.Image = global::Moto_Logo.Properties.Resources.textInfo_x24;
            this.labelIcontxtLogoInternalFile.Location = new System.Drawing.Point(6, 623);
            this.labelIcontxtLogoInternalFile.Name = "labelIcontxtLogoInternalFile";
            this.labelIcontxtLogoInternalFile.Size = new System.Drawing.Size(36, 22);
            this.labelIcontxtLogoInternalFile.TabIndex = 211;
            // 
            // labelIconBTNDelete
            // 
            this.labelIconBTNDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIconBTNDelete.Image = global::Moto_Logo.Properties.Resources.delete_x16;
            this.labelIconBTNDelete.Location = new System.Drawing.Point(192, 49);
            this.labelIconBTNDelete.Name = "labelIconBTNDelete";
            this.labelIconBTNDelete.Size = new System.Drawing.Size(25, 23);
            this.labelIconBTNDelete.TabIndex = 212;
            // 
            // labelIconBTNExtract
            // 
            this.labelIconBTNExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIconBTNExtract.Image = global::Moto_Logo.Properties.Resources.extract_x16;
            this.labelIconBTNExtract.Location = new System.Drawing.Point(7, 70);
            this.labelIconBTNExtract.Name = "labelIconBTNExtract";
            this.labelIconBTNExtract.Size = new System.Drawing.Size(26, 23);
            this.labelIconBTNExtract.TabIndex = 213;
            // 
            // labelIconBTNAppend
            // 
            this.labelIconBTNAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIconBTNAppend.Image = global::Moto_Logo.Properties.Resources.add_x16;
            this.labelIconBTNAppend.Location = new System.Drawing.Point(7, 30);
            this.labelIconBTNAppend.Name = "labelIconBTNAppend";
            this.labelIconBTNAppend.Size = new System.Drawing.Size(26, 23);
            this.labelIconBTNAppend.TabIndex = 214;
            // 
            // darkSectionPanelMainBTNS
            // 
            this.darkSectionPanelMainBTNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.darkSectionPanelMainBTNS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.darkSectionPanelMainBTNS.Controls.Add(this.buttonAppend);
            this.darkSectionPanelMainBTNS.Controls.Add(this.labelIconBTNAppend);
            this.darkSectionPanelMainBTNS.Controls.Add(this.buttonExtract);
            this.darkSectionPanelMainBTNS.Controls.Add(this.labelIconBTNExtract);
            this.darkSectionPanelMainBTNS.Controls.Add(this.buttonDelete);
            this.darkSectionPanelMainBTNS.Controls.Add(this.labelIconBTNDelete);
            this.darkSectionPanelMainBTNS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSectionPanelMainBTNS.Location = new System.Drawing.Point(6, 652);
            this.darkSectionPanelMainBTNS.Name = "darkSectionPanelMainBTNS";
            this.darkSectionPanelMainBTNS.SectionHeader = "Logo List Controls";
            this.darkSectionPanelMainBTNS.Size = new System.Drawing.Size(347, 97);
            this.darkSectionPanelMainBTNS.TabIndex = 215;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Image = global::Moto_Logo.Properties.Resources.settings_mainform_x24;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 73);
            this.label6.TabIndex = 216;
            // 
            // tvLogo
            // 
            this.tvLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tvLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tvLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.tvLogo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tvLogo.Location = new System.Drawing.Point(48, 259);
            this.tvLogo.Name = "tvLogo";
            this.tvLogo.ShowNodeToolTips = true;
            this.tvLogo.Size = new System.Drawing.Size(305, 359);
            this.tvLogo.TabIndex = 201;
            this.tvLogo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLogo_AfterSelect);
            this.tvLogo.DoubleClick += new System.EventHandler(this.tvLogo_DoubleClick);
            // 
            // ToolStripMainMenu
            // 
            this.ToolStripMainMenu.AutoSize = false;
            this.ToolStripMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripMainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ToolStripMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStripMainMenu.Location = new System.Drawing.Point(0, 24);
            this.ToolStripMainMenu.Name = "ToolStripMainMenu";
            this.ToolStripMainMenu.Padding = new System.Windows.Forms.Padding(7, 0, 1, 0);
            this.ToolStripMainMenu.Size = new System.Drawing.Size(1284, 39);
            this.ToolStripMainMenu.TabIndex = 222;
            // 
            // labelbtnBuild
            // 
            this.labelbtnBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelbtnBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelbtnBuild.Name = "labelbtnBuild";
            this.labelbtnBuild.Size = new System.Drawing.Size(34, 36);
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
            this.btnBuild.Size = new System.Drawing.Size(23, 36);
            this.btnBuild.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuild.ToolTipText = "Build and save Logo.bin file";
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // labelbtnStop
            // 
            this.labelbtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelbtnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelbtnStop.Name = "labelbtnStop";
            this.labelbtnStop.Size = new System.Drawing.Size(43, 36);
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
            this.btnStop.Size = new System.Drawing.Size(23, 36);
            this.btnStop.ToolTipText = "Stop logo build process";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // labelLogoName
            // 
            this.labelLogoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelLogoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(69, 36);
            this.labelLogoName.Text = "Logo Name";
            // 
            // textLogoName
            // 
            this.textLogoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.textLogoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textLogoName.Name = "textLogoName";
            this.textLogoName.Size = new System.Drawing.Size(150, 39);
            this.textLogoName.ToolTipText = "Input your logo name for ex: \"logo_by_franco28\"";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // labelBuildPath
            // 
            this.labelBuildPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelBuildPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelBuildPath.Name = "labelBuildPath";
            this.labelBuildPath.Size = new System.Drawing.Size(91, 36);
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
            this.btnAttachPath.Size = new System.Drawing.Size(23, 36);
            this.btnAttachPath.ToolTipText = "Choose logo build path";
            this.btnAttachPath.Click += new System.EventHandler(this.btnAttachPath_Click);
            // 
            // txtLogoBuildPath
            // 
            this.txtLogoBuildPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.txtLogoBuildPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtLogoBuildPath.Name = "txtLogoBuildPath";
            this.txtLogoBuildPath.Size = new System.Drawing.Size(520, 39);
            // 
            // labelbtnOpenLogoFile
            // 
            this.labelbtnOpenLogoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelbtnOpenLogoFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelbtnOpenLogoFile.Name = "labelbtnOpenLogoFile";
            this.labelbtnOpenLogoFile.Size = new System.Drawing.Size(63, 36);
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
            this.btnOpenLogoFile.Size = new System.Drawing.Size(23, 36);
            this.btnOpenLogoFile.ToolTipText = "Open logo folder";
            this.btnOpenLogoFile.Click += new System.EventHandler(this.btnOpenLogoFile_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 39);
            // 
            // cboMoto
            // 
            this.cboMoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.cboMoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.cboMoto.Name = "cboMoto";
            this.cboMoto.Size = new System.Drawing.Size(75, 39);
            this.cboMoto.Visible = false;
            this.cboMoto.SelectedIndexChanged += new System.EventHandler(this.cboMoto_SelectedIndexChanged);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MainMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(1284, 24);
            this.MainMenuStrip.TabIndex = 220;
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
            // MainStatusStrip
            // 
            this.MainStatusStrip.AutoSize = false;
            this.MainStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MainStatusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 752);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Padding = new System.Windows.Forms.Padding(0, 6, 0, 4);
            this.MainStatusStrip.Size = new System.Drawing.Size(1284, 31);
            this.MainStatusStrip.SizingGrip = false;
            this.MainStatusStrip.TabIndex = 221;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(353, 15);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(22, 16);
            this.toolStripStatusLabel1.Text = "---";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 16);
            this.toolStripStatusLabel2.Text = "---";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(22, 16);
            this.toolStripStatusLabel3.Text = "---";
            // 
            // ToolStripMainMenu2
            // 
            this.ToolStripMainMenu2.AutoSize = false;
            this.ToolStripMainMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripMainMenu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripMainMenu2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripMainMenu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripMainMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelReload,
            this.btnReload,
            this.toolStripSeparatorErrorMsg,
            this.labelErrorIcon,
            this.labelErrorInfo,
            this.labelErrorGoToFileInfo,
            this.labelGoToError,
            this.toolStripSeparator11,
            this.labelSearchDevice,
            this.textBoxSearchDevice,
            this.btnSearchDevice});
            this.ToolStripMainMenu2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStripMainMenu2.Location = new System.Drawing.Point(0, 63);
            this.ToolStripMainMenu2.Name = "ToolStripMainMenu2";
            this.ToolStripMainMenu2.Padding = new System.Windows.Forms.Padding(7, 0, 1, 0);
            this.ToolStripMainMenu2.Size = new System.Drawing.Size(1284, 39);
            this.ToolStripMainMenu2.TabIndex = 223;
            // 
            // labelReload
            // 
            this.labelReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelReload.Name = "labelReload";
            this.labelReload.Size = new System.Drawing.Size(43, 36);
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
            this.btnReload.Size = new System.Drawing.Size(23, 36);
            this.btnReload.ToolTipText = "Reload Tool";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // toolStripSeparatorErrorMsg
            // 
            this.toolStripSeparatorErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparatorErrorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparatorErrorMsg.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparatorErrorMsg.Name = "toolStripSeparatorErrorMsg";
            this.toolStripSeparatorErrorMsg.Size = new System.Drawing.Size(6, 39);
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
            this.labelErrorIcon.Size = new System.Drawing.Size(23, 36);
            // 
            // labelErrorInfo
            // 
            this.labelErrorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelErrorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelErrorInfo.Name = "labelErrorInfo";
            this.labelErrorInfo.ReadOnly = true;
            this.labelErrorInfo.Size = new System.Drawing.Size(700, 39);
            this.labelErrorInfo.Text = "---";
            // 
            // labelErrorGoToFileInfo
            // 
            this.labelErrorGoToFileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelErrorGoToFileInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelErrorGoToFileInfo.Name = "labelErrorGoToFileInfo";
            this.labelErrorGoToFileInfo.Size = new System.Drawing.Size(67, 36);
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
            this.labelGoToError.Size = new System.Drawing.Size(23, 36);
            this.labelGoToError.ToolTipText = "Open logs folder";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator11.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 39);
            // 
            // labelSearchDevice
            // 
            this.labelSearchDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.labelSearchDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelSearchDevice.Name = "labelSearchDevice";
            this.labelSearchDevice.Size = new System.Drawing.Size(83, 36);
            this.labelSearchDevice.Text = "Search Device:";
            // 
            // textBoxSearchDevice
            // 
            this.textBoxSearchDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.textBoxSearchDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxSearchDevice.Name = "textBoxSearchDevice";
            this.textBoxSearchDevice.Size = new System.Drawing.Size(180, 39);
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
            this.btnSearchDevice.Size = new System.Drawing.Size(23, 36);
            this.btnSearchDevice.ToolTipText = "Search Device";
            this.btnSearchDevice.Click += new System.EventHandler(this.btnSearchDevice_Click);
            // 
            // flowLayoutPanelGroupBox
            // 
            this.flowLayoutPanelGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelGroupBox.Controls.Add(this.label6);
            this.flowLayoutPanelGroupBox.Controls.Add(this.groupBoxLogoMemory);
            this.flowLayoutPanelGroupBox.Controls.Add(this.groupBoxLogoExtension);
            this.flowLayoutPanelGroupBox.Controls.Add(this.groupBoxLogoFormat);
            this.flowLayoutPanelGroupBox.Controls.Add(this.groupBoxLogoImageOption);
            this.flowLayoutPanelGroupBox.Controls.Add(this.groupBoxLogoImageOrientation);
            this.flowLayoutPanelGroupBox.Controls.Add(this.groupBoxLogoResolution);
            this.flowLayoutPanelGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelGroupBox.Location = new System.Drawing.Point(0, 102);
            this.flowLayoutPanelGroupBox.Name = "flowLayoutPanelGroupBox";
            this.flowLayoutPanelGroupBox.Size = new System.Drawing.Size(1284, 74);
            this.flowLayoutPanelGroupBox.TabIndex = 230;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 783);
            this.Controls.Add(this.labelIconMessageBoxLogo);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.flowLayoutPanelGroupBox);
            this.Controls.Add(this.ToolStripMainMenu2);
            this.Controls.Add(this.ToolStripMainMenu);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.darkSectionPanelMainBTNS);
            this.Controls.Add(this.labelIcontxtLogoInternalFile);
            this.Controls.Add(this.labelIconZoomFC);
            this.Controls.Add(this.labelIconTVLogo);
            this.Controls.Add(this.labelIconLUImage);
            this.Controls.Add(this.labelIconImageBox);
            this.Controls.Add(this.labelIconRGB);
            this.Controls.Add(this.ImageStatusBox);
            this.Controls.Add(this.tvLogo);
            this.Controls.Add(this.labelColorDraw);
            this.Controls.Add(this.pictureBoxColors);
            this.Controls.Add(this.trbZoomFactor);
            this.Controls.Add(this.picZoom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLogoInternalFile);
            this.Controls.Add(this.lblZoomFactor);
            this.DoubleBuffered = true;
            this.FlatBorder = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1000, 822);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moto_Boot_Logo_Maker by Franco28";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBoxLogoImageOrientation.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoImageOrientation.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoImageOrientation.PerformLayout();
            this.groupBoxLogoImageOption.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoImageOption.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoImageOption.PerformLayout();
            this.groupBoxLogoFormat.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoFormat.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoFormat.PerformLayout();
            this.groupBoxLogoMemory.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoMemory.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoMemory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            this.groupBoxLogoExtension.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoExtension.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoExtension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxLogoResolution.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoResolution.ResumeLayout(false);
            this.flowLayoutPanelgroupBoxLogoResolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udResolutionY)).EndInit();
            this.darkSectionPanelMainBTNS.ResumeLayout(false);
            this.ToolStripMainMenu.ResumeLayout(false);
            this.ToolStripMainMenu.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ToolStripMainMenu2.ResumeLayout(false);
            this.ToolStripMainMenu2.PerformLayout();
            this.flowLayoutPanelGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        public DarkUI.Controls.DarkGroupBox groupBoxLogoExtension;
        private DarkUI.Controls.DarkRadioButton radioButtonBIN;
        private DarkUI.Controls.DarkRadioButton radioButtonZIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkButton buttonDelete;
        private DarkUI.Controls.DarkButton buttonExtract;
        private DarkUI.Controls.DarkButton buttonAppend;
        private DarkUI.Controls.DarkTextBox txtLogoInternalFile;
        public DarkUI.Controls.DarkTextBox txtComments;
        private DarkUI.Controls.DarkLabel lblZoomFactor;
        private System.Windows.Forms.FolderBrowserDialog MainFolderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog SecondSaveFileDialog;
        public System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog MainSaveFileDialog;
        private System.Windows.Forms.ToolTip MainToolTip;
        public DarkUI.Controls.DarkGroupBox groupBoxLogoResolution;
        private System.Windows.Forms.RichTextBox ImageStatusBox;
        private System.Windows.Forms.Label labelIconRGB;
        private System.Windows.Forms.Label labelIconImageBox;
        private System.Windows.Forms.Label labelIconLUImage;
        private System.Windows.Forms.Label labelIconMessageBoxLogo;
        private System.Windows.Forms.Label labelIconTVLogo;
        private System.Windows.Forms.Label labelIconZoomFC;
        private System.Windows.Forms.Label labelIcontxtLogoInternalFile;
        private System.Windows.Forms.Label labelIconBTNDelete;
        private System.Windows.Forms.Label labelIconBTNExtract;
        private System.Windows.Forms.Label labelIconBTNAppend;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanelMainBTNS;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TreeView tvLogo;
        private DarkUI.Controls.DarkToolStrip ToolStripMainMenu;
        public System.Windows.Forms.ToolStripLabel labelbtnBuild;
        public System.Windows.Forms.ToolStripButton btnBuild;
        public System.Windows.Forms.ToolStripLabel labelbtnStop;
        public System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel labelLogoName;
        public System.Windows.Forms.ToolStripTextBox textLogoName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel labelBuildPath;
        public System.Windows.Forms.ToolStripButton btnAttachPath;
        public System.Windows.Forms.ToolStripTextBox txtLogoBuildPath;
        private System.Windows.Forms.ToolStripLabel labelbtnOpenLogoFile;
        public System.Windows.Forms.ToolStripButton btnOpenLogoFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        public System.Windows.Forms.ToolStripComboBox cboMoto;
        private new DarkUI.Controls.DarkMenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenCustomLogo;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private DarkUI.Controls.DarkStatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private DarkUI.Controls.DarkToolStrip ToolStripMainMenu2;
        private System.Windows.Forms.ToolStripLabel labelReload;
        public System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorErrorMsg;
        public System.Windows.Forms.ToolStripButton labelErrorIcon;
        public System.Windows.Forms.ToolStripTextBox labelErrorInfo;
        private System.Windows.Forms.ToolStripLabel labelErrorGoToFileInfo;
        public System.Windows.Forms.ToolStripButton labelGoToError;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripLabel labelSearchDevice;
        public System.Windows.Forms.ToolStripTextBox textBoxSearchDevice;
        public System.Windows.Forms.ToolStripButton btnSearchDevice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelgroupBoxLogoMemory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelgroupBoxLogoExtension;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelgroupBoxLogoFormat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelgroupBoxLogoImageOption;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelgroupBoxLogoImageOrientation;
        private DarkUI.Controls.DarkLabel labeludResoX;
        private DarkUI.Controls.DarkLabel labeludResoY;
        private DarkUI.Controls.DarkNumericUpDown udResolutionY;
        private DarkUI.Controls.DarkNumericUpDown udResolutionX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelgroupBoxLogoResolution;
    }
}