/* 
#####################################################################
#    File: MainForm.cs                                              #
#    Author: Franco28                                               # 
#    Date: 31-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Moto_Logo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using Timer = System.Windows.Forms.Timer;
using TreeNode = System.Windows.Forms.TreeNode;
using DarkUI.Forms;
using AutoUpdaterDotNET;

namespace Moto_Logo
{
    public partial class MainForm : DarkForm
    {
        private static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        private string userdesktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private CultureInfo ci = CultureInfo.InstalledUICulture;
        private CultureInfo cul;
        private ResourceManager res_man;
        public Timer timerupdates = new Timer();
        private bool _autoselectlogobinversion = true;
        private int _maxFileSize = 4 * 1024 * 1024; // 4MB
        private int _logosize;
        private bool _tvLogoAfterSelectProcessing;
        private readonly List<String> _loadedbitmapnames = new List<string>();
        private readonly List<Bitmap> _loadedbitmaps = new List<Bitmap>();
        private readonly List<ImageOption> _loadedbitmapimageoptions = new List<ImageOption>();
        private readonly List<ImageLayout> _loadedbitmapimagelayout = new List<ImageLayout>();
        private readonly List<int> _deviceResolutionX = new List<int>();
        private readonly List<int> _deviceResolutionY = new List<int>();
        private readonly List<int> _deviceLogoBinSize = new List<int>();
        private readonly List<UInt64> _deviceLogoBinContents = new List<UInt64>();

        public MainForm()
        {
            #region Settings
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            this.MinimumSize = new Size(1000, 910);

            CheckDLL.dll();
            CheckFiles.files();

            Translations();

            if (exePath != @"C:\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files (x86)\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files\Moto_Boot_Logo_Maker")
            {
                if (Properties.Settings.Default.IsAdmin == true)
                {
                    Properties.Settings.Default.ToolTitle = "Moto_Boot_Logo_Maker v" + Application.ProductVersion + " - " + Properties.Settings.Default.ToolLang + " - PORTABLE -" + OSArchitecture.Get() + " - " + res_man.GetString("ProgramIsAdmin", cul);
                    Properties.Settings.Default.Save();
                } 
                else
                {
                    Properties.Settings.Default.ToolTitle = "Moto_Boot_Logo_Maker v" + Application.ProductVersion + " - " + Properties.Settings.Default.ToolLang + " - PORTABLE -" + OSArchitecture.Get();
                    Properties.Settings.Default.Save();
                }

                this.Text = Properties.Settings.Default.ToolTitle;
                Properties.Settings.Default.Updates = false;
                Properties.Settings.Default.Save();
                checkForUpdatesToolStripMenuItem.Enabled = false;
                AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
            }
            else
            {
                if (Properties.Settings.Default.IsAdmin == true)
                {
                    Properties.Settings.Default.ToolTitle = "Moto_Boot_Logo_Maker v" + Application.ProductVersion + " - " + Properties.Settings.Default.ToolLang + " -" + OSArchitecture.Get() + " - " + res_man.GetString("ProgramIsAdmin", cul);
                    Properties.Settings.Default.Save();
                } 
                else
                {
                    Properties.Settings.Default.ToolTitle = "Moto_Boot_Logo_Maker v" + Application.ProductVersion + " - " + Properties.Settings.Default.ToolLang + " -" + OSArchitecture.Get();
                    Properties.Settings.Default.Save();
                }

                this.Text = Properties.Settings.Default.ToolTitle;
                if (Properties.Settings.Default.Updates == true)
                {
                    CheckForUpdates();
                }
                Properties.Settings.Default.Save();
            }

            labelErrorIcon.Visible = false;
            labelErrorInfo.Visible = false;
            labelErrorGoToFileInfo.Visible = false;
            labelGoToError.Visible = false;
            toolStripSeparatorErrorMsg.Visible = false;

            FileSystemWatcherErrorLogs();

            this.backgroundWorkerLogBuild = new BackgroundWorker();
            this.backgroundWorkerLogBuild.DoWork += new DoWorkEventHandler(this.backgroundWorkerLogBuild_DoWork);
            this.backgroundWorkerLogBuild.RunWorkerCompleted += backgroundWorkerLogBuild_RunWorkerCompleted;
            this.backgroundWorkerLogBuild.WorkerReportsProgress = true;
            this.backgroundWorkerLogBuild.WorkerSupportsCancellation = true;

            txtComments.Enabled = false;
            cboMoto.Enabled = false;
            groupBoxLogoFormat.Enabled = false;
            groupBoxLogoResolution.Enabled = false;
            groupBoxLogoImageOption.Enabled = false;
            groupBoxLogoImageOrientation.Enabled = false;
            groupBoxLogoMemory.Enabled = false;
            groupBoxLogoExtension.Enabled = false;
            textLogoName.Enabled = false;
            txtLogoBuildPath.Enabled = false;
            btnAttachPath.Enabled = false;

            _ZoomFactor = trbZoomFactor.Value;
            _BackColor = pictureBox1.BackColor;
            picZoom.SizeMode = PictureBoxSizeMode.StretchImage;

            udResolutionX.Controls[0].Enabled = false;
            udResolutionY.Controls[0].Enabled = false;

            IniUITool();
            #endregion Settings
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            #region LoadSettings 
            ImageStatusBox.Clear();
            ImageStatusBoxMSG(res_man.GetString("MainForm_ImageStatus_TextLocked", cul));
            ImageStatusBoxMSG(res_man.GetString("MainForm_ImageStatus_TextUnlocked", cul));

            if (Properties.Settings.Default.SaveProfiles == true)
            {
                LoadProfiles();
            }

            if (Properties.Settings.Default.LogoBinOpenSave == true)
            {
                if (Properties.Settings.Default.LogoBinOpen == "")
                {
                    Properties.Settings.Default.LogoWasSaved = false;
                    Properties.Settings.Default.LogoBinOpen = "";
                    Properties.Settings.Default.Save();
                }
                else
                {
                    this.Show();
                    DialogResult answer = MessageBox.Show(res_man.GetString("MainForm_LoadPreviousLogo", cul),
                      "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    switch (answer)
                    {
                        case DialogResult.Yes:
                            this.Text = res_man.GetString("MainForm_OpenLogoMemoryTitle", cul) + " " + Properties.Settings.Default.LogoBinOpen + " " + res_man.GetString("MainForm_OpenLogoMemoryTitle2", cul);
                            OpenFile(Properties.Settings.Default.LogoBinOpen);
                            txtComments.Enabled = true;
                            cboMoto.Enabled = true;
                            groupBoxLogoFormat.Enabled = true;
                            groupBoxLogoResolution.Enabled = true;
                            groupBoxLogoImageOption.Enabled = true;
                            groupBoxLogoImageOrientation.Enabled = true;
                            DisableControls();
                            this.Text = Properties.Settings.Default.ToolTitle;
                            break;
                        case DialogResult.No:
                            Properties.Settings.Default.LogoWasSaved = false;
                            Properties.Settings.Default.LogoBinOpen = "";
                            Properties.Settings.Default.Save();
                            break;
                    }
                }
            }
            #endregion LoadSettings 
        }      

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            #region AppendImageToLogo
            if ((cboMoto.SelectedIndex > 0) && buttonAppend.Text == res_man.GetString("MainForm_BTN_Append", cul)) return;
            if (txtLogoInternalFile.Text == "") return;
            if (buttonAppend.Text == res_man.GetString("MainForm_BTN_Append", cul))
                switch (txtLogoInternalFile.Text)
                {
                    case "logo_boot":
                        init_tree(LOGO.LOGO_BOOT);
                        break;
                    case "logo_battery":
                        init_tree(LOGO.LOGO_BATTERY);
                        break;
                    case "logo_unlocked":
                        init_tree(LOGO.LOGO_UNLOCKED);
                        break;
                    case "logo_lowpower":
                        init_tree(LOGO.LOGO_LOWPOWER);
                        break;
                    case "logo_unplug":
                        init_tree(LOGO.LOGO_UNPLUG);
                        break;
                    case "logo_charge":
                        init_tree(LOGO.LOGO_CHARGE);
                        break;
                    case "logo_yellow":
                        init_tree(LOGO.LOGO_YELLOW);
                        break;
                    case "logo_red":
                        init_tree(LOGO.LOGO_RED);
                        break;
                    case "logo_orange":
                        init_tree(LOGO.LOGO_ORANGE);
                        break;
                }
            MainOpenFileDialog.Filter = @"Png file|*.png|Jpg file|*.jpg|Jpeg file|*.jpeg|Bitmap file|*.bmp|Gif file|*.gif|Icon file|*.ico|All files|*.*";
            MainOpenFileDialog.InitialDirectory = userdesktoppath;
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (CheckAllIMG(5621440) == true)
                {
                    return;
                }
                var img = new Bitmap(new MemoryStream(File.ReadAllBytes(MainOpenFileDialog.FileName)));
                AddToBitmapList(img, Path.GetFileName(MainOpenFileDialog.FileName), txtLogoInternalFile.Text);
                toolStripStatusLabel1.Text = MainOpenFileDialog.FileName;
            }
            else
            {
                var nodeFound = false;
                foreach (var node in tvLogo.Nodes.Cast<TreeNode>().Where(node => node.Text == txtLogoInternalFile.Text))
                {
                    node.Name = "";
                    nodeFound = true;
                }
                if (!nodeFound) tvLogo.Nodes.Add(txtLogoInternalFile.Text);
            }
            buttonAppend.Text = res_man.GetString("MainForm_BTN_Replace", cul);
            #endregion AppendImageToLogo
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            #region ExtractImageFromLogo
            Bitmap img;
            if (tvLogo.SelectedNode == null) return;
            try
            {
                img = File.Exists(tvLogo.SelectedNode.Name)
                    ? new Bitmap(new MemoryStream(File.ReadAllBytes(tvLogo.SelectedNode.Name)))
                    : _loadedbitmaps[Convert.ToInt32(tvLogo.SelectedNode.Name)];
            }
            catch (Exception)
            {
                switch (tvLogo.SelectedNode.Text)
                {
                    default:
                        return;
                    case "logo_boot":
                        img = Resources.logo_boot;
                        break;
                    case "logo_lowpower":
                        img = Resources.logo_lowpower;
                        break;
                    case "logo_battery":
                        img = Resources.logo_battery;
                        break;
                    case "logo_unplug":
                        img = Resources.logo_unplug;
                        break;
                    case "logo_charge":
                        img = Resources.logo_charge;
                        break;
                    case "logo_yellow":
                        img = Resources.logo_yellow;
                        break;
                    case "logo_orange":
                        img = Resources.logo_orange;
                        break;
                    case "logo_red":
                        img = Resources.logo_red;
                        break;
                }
            }
            SecondSaveFileDialog.Filter = @"Png file|*.png|Jpeg file|*.jpg|Bitmap file|*.bmp|Gif file|*.gif|Icon file|*.ico|All files|*.*";
            if (SecondSaveFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                switch (Path.GetExtension(SecondSaveFileDialog.FileName))
                {
                    case ".gif":
                        img.Save(SecondSaveFileDialog.FileName, ImageFormat.Gif);
                        break;
                    case ".jpeg":
                        img.Save(SecondSaveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                    case ".bmp":
                        img.Save(SecondSaveFileDialog.FileName, ImageFormat.Bmp);
                        break;
                    case ".ico":
                        img.Save(SecondSaveFileDialog.FileName, ImageFormat.Icon);
                        break;
                    default:
                        img.Save(SecondSaveFileDialog.FileName, ImageFormat.Png);
                        break;

                }
                toolStripStatusLabel1.Text = res_man.GetString("MainForm_ImageSaveOk", cul) + " " + Path.GetFileName(SecondSaveFileDialog.FileName) + " " +
                                             res_man.GetString("MainForm_ImageSaveOk2", cul) + @" :)";
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                toolStripStatusLabel1.Text = res_man.GetString("MainForm_ExtractLogoError", cul) + @" :(";
                MessageBox.Show(res_man.GetString("MainForm_ExtractLogoError", cul) + @" :(", @"Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.DoEvents();
                return;
            }
            #endregion ExtractImageFromLogo
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            #region DeleteLogo
            if (tvLogo.SelectedNode == null)
            {
                return;
            }
            else
            {
                if ((cboMoto.SelectedIndex == 0))
                {
                    tvLogo.SelectedNode.Remove();
                    if (tvLogo.Nodes.Count.Equals(0))
                    {
                        txtLogoInternalFile.Text = res_man.GetString("MainForm_TVLogo_ReloadList", cul);
                        tvLogo.Nodes.Add("Please reload in File/New to see again logos");
                        buttonAppend.Enabled = false;
                        buttonDelete.Enabled = false;
                        buttonExtract.Enabled = false;
                        pictureBox1.Image = FixedSizePreview(Resources._null);
                        if (tvLogo.SelectedNode == null) return;
                    }
                }
                else
                {
                    tvLogo.SelectedNode.Name = "";
                    if (tvLogo.Nodes.Count == 0)
                    {
                        ClearBitmapList();
                    }
                }
            }
            #endregion DeleteLogo
        }

        private void rdoAndroid43_CheckedChanged(object sender, EventArgs e)
        {
            if (_tvLogoAfterSelectProcessing) return;
            if (tvLogo.SelectedNode == null) return;
            if (string.IsNullOrEmpty(tvLogo.SelectedNode.Name)) return;
            var index = Convert.ToInt32(tvLogo.SelectedNode.Name);
            _loadedbitmapimageoptions[index] = rdoImageCenter.Checked
                ? ImageOption.ImageOptionCenter
                : rdoImageStretchAspect.Checked
                ? ImageOption.ImageOptionStretchProportionately
                : ImageOption.ImageOptionFill;
            _loadedbitmapimagelayout[index] = rdoLayoutLandscape.Checked
                ? ImageLayout.ImageLayoutLandscape
                : ImageLayout.ImageLayoutPortrait;
            tvLogo_AfterSelect(sender, null);
        }

        private void rdoAndroidRAW_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAndroidRAW.Checked)
            {
                if (tvLogo.Nodes.Count <= 1) return;
                for (var i = tvLogo.Nodes.Count - 1; i >= 0; i--)
                {
                    if (tvLogo.Nodes[i].Text == @"logo_unlocked") continue;
                    if (tvLogo.Nodes.Count > 1)
                        tvLogo.Nodes[i].Remove();
                }
            }
            else
            {
                _autoselectlogobinversion = false;
                cboMoto_SelectedIndexChanged(sender, e);
                _autoselectlogobinversion = true;
            }
            tvLogo_AfterSelect(sender, null);
        }

        private void tvLogo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            #region LogoAfterSelect
            if (tvLogo.SelectedNode == null) return;
            if (_tvLogoAfterSelectProcessing) return;
            txtLogoInternalFile.Text = tvLogo.SelectedNode.Text;
            _tvLogoAfterSelectProcessing = true;
            try
            {
                var index = Convert.ToInt32(tvLogo.SelectedNode.Name);
                var bitmap = _loadedbitmaps[index];
                if (bitmap == null) return;
                SetRadioButtons(index);
                toolStripStatusLabel1.Text = _loadedbitmapnames[index]
                    + @": " + bitmap.Width + @"x" + bitmap.Height;
                pictureBox1.BackColor = Color.Transparent;
                pictureBox1.Image = FixedSizePreview(bitmap);
                _OriginalImage = FixedSizePreview(bitmap);
                ResizeAndDisplayImage();
                Application.DoEvents();
            }
            catch
            {
                SetRadioButtons(ImageOption.ImageOptionCenter, ImageLayout.ImageLayoutPortrait);
                switch (tvLogo.SelectedNode.Text)
                {
                    default:
                        if (File.Exists(exePath + @"\Files\Images\Logo\logo.png"))
                        {
                            pictureBox1.Image = Image.FromFile(exePath + @"\Files\Images\Logo\logo.png");
                        }
                        else
                        {
                            pictureBox1.Image = Resources.logo;
                        }
                        picZoom.Image = pictureBox1.Image;
                        _OriginalImage = pictureBox1.Image;
                        ResizeAndDisplayImage();
                        break;
                    case "logo_lowpower":
                        LogoTree(Resources.logo_lowpower);
                        break;
                    case "logo_battery":
                        LogoTree(Resources.logo_battery);
                        break;
                    case "logo_unplug":
                        LogoTree(Resources.logo_unplug);
                        break;
                    case "logo_charge":
                        LogoTree(Resources.logo_charge);
                        break;
                    case "logo_boot":
                    case "logo_unlocked":
                        LogoTree(Resources.logo_boot);
                        break;
                    case "logo_yellow":
                        LogoTree(Resources.logo_yellow);
                        break;
                    case "logo_red":
                        LogoTree(Resources.logo_red);
                        break;
                    case "logo_orange":
                        LogoTree(Resources.logo_orange);
                        break;
                    case "Please reload in File/New to see again logos":
                        LogoTree(Resources._null);
                        break;
                }
                Application.DoEvents();
                toolStripStatusLabel1.Text = "";
            }
            _tvLogoAfterSelectProcessing = false;
            #endregion LogoAfterSelect
        }

        private void tvLogo_DoubleClick(object sender, EventArgs e)
        {
            if (tvLogo.SelectedNode == null) return;
            MainOpenFileDialog.Filter = @"Png file|*.png|Jpg file|*.jpg|Jpeg file|*.jpeg|Bitmap file|*.bmp|Gif file|*.gif|Icon file|*.ico|All files|*.*";
            MainOpenFileDialog.InitialDirectory = userdesktoppath;
            if (MainOpenFileDialog.ShowDialog() != DialogResult.OK) return;
            if (CheckAllIMG(5621440) == true)
            {
                return;
            }
            var img = new Bitmap(new MemoryStream(File.ReadAllBytes(MainOpenFileDialog.FileName)));
            AddToBitmapList(img, Path.GetFileName(MainOpenFileDialog.FileName), tvLogo.SelectedNode.Text);
            toolStripStatusLabel1.Text = MainOpenFileDialog.FileName;
            tvLogo_AfterSelect(sender, null);
        }

        private void cboMoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMoto.SelectedIndex == 0)
                groupBoxLogoMemory.Enabled = true;
            else
                groupBoxLogoMemory.Enabled = false;
            var idx = cboMoto.SelectedIndex;
            udResolutionX.Enabled = (idx == 0);
            udResolutionY.Enabled = (idx == 0);
            udResolutionX.Value = _deviceResolutionX[idx];
            udResolutionY.Value = _deviceResolutionY[idx];
            _maxFileSize = _deviceLogoBinSize[idx];
            init_tree(_deviceLogoBinContents[idx]);
            toolStripStatusLabel1.Text = res_man.GetString("MainForm_Logo_MaxBinSize", cul) + @" = " + (_maxFileSize / 1024 / 1024) + @"MB";
        }

        private void udResolutionY_ValueChanged(object sender, EventArgs e)
        {
            tvLogo_AfterSelect(sender, null);
        }

        private void udResolutionX_ValueChanged(object sender, EventArgs e)
        {
            tvLogo_AfterSelect(sender, null);
        }

        private void txtLogoInternalFile_TextChanged(object sender, EventArgs e)
        {
            buttonAppend.Text = tvLogo.Nodes.Cast<TreeNode>().Any(node => node.Text == txtLogoInternalFile.Text)
                ? res_man.GetString("MainForm_BTN_Replace", cul)
                : res_man.GetString("MainForm_BTN_Append", cul);
        } 

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Refresh();
                pictureBox1.Invalidate();
                pictureBox1.Update();
                ResizeAndDisplayImage();
            }
            
            if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Refresh();
                pictureBox1.Invalidate();
                pictureBox1.Update();
                ResizeAndDisplayImage();
            }
            AvoidFlick();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region ExitToolSaveData
            var openfilename = Properties.Settings.Default.LogoBinOpen;

            if (Properties.Settings.Default.LogoWasSaved == true)
            {
                KillTool();
            }

            if (Properties.Settings.Default.LogoBinOpen.EndsWith(".bin") && Properties.Settings.Default.LogoWasSaved == false)
            {
                DialogResult dialogResult = MessageBox.Show(res_man.GetString("MainForm_ExitLogoWasntSave1", cul) + "\n\n" + openfilename + "\n\n" + res_man.GetString("MainForm_ExitLogoWasntSave2", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Properties.Settings.Default.SaveProfiles == true)
                    {
                        SaveProfiles();
                    }
                    KillTool();
                }
                else if (dialogResult == DialogResult.No)
                {
                    try
                    {
                        e.Cancel = true;
                        return;
                    }
                    catch (Exception ex)
                    {
                        Logs.DebugErrorLogs(ex);
                        MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                KillTool();
            }
            #endregion ExitToolSaveData         
        }
    }
}