/* 
#####################################################################
#    File: MainForm.cs                                              #
#    Author: Franco28                                               # 
#    Date: 27-04-2021                                               #
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
using System.Diagnostics;
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
using System.Media;
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
        private int _maxFileSize = 4 * 1024 * 1024; // 4MiB
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
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            CheckDLL.dll();
            CheckFiles.files();

            Translations();

            if (Properties.Settings.Default.LogoWasSaved == true)
            {
                Properties.Settings.Default.LogoWasSaved = false;
            }
            Properties.Settings.Default.Save();

            if (exePath != @"C:\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files (x86)\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files\Moto_Boot_Logo_Maker")
            {
                this.Text = "Moto_Boot_Logo_Maker v" + Application.ProductVersion + " - " + Properties.Settings.Default.ToolLang + " - PORTABLE -" + OSArchitecture.Get();
                Properties.Settings.Default.Updates = false;
                Properties.Settings.Default.Save();
                checkForUpdatesToolStripMenuItem.Enabled = false;
                AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
            }
            else
            {
                this.Text = "Moto_Boot_Logo_Maker v" + Application.ProductVersion + " - " + Properties.Settings.Default.ToolLang + " -" + OSArchitecture.Get();
                if (Properties.Settings.Default.Updates == true)
                {
                    CheckForUpdates();
                }
            }

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

            IniUITool();
            #endregion Settings
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            #region LoadSettings 
            ImageStatusBox.Clear();
            ImageStatusBoxMSG(res_man.GetString("materialLabel10", cul));
            ImageStatusBoxMSG(res_man.GetString("materialLabel11", cul));

            if (Properties.Settings.Default.SaveProfiles == true)
            {
                LoadProfiles();
            }
            if (Properties.Settings.Default.LogoBinOpenSave == false)
            {
                Properties.Settings.Default.LogoWasSaved = false;
                Properties.Settings.Default.LogoBinOpen = "";
                Properties.Settings.Default.Save();
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
                    DialogResult answer = MessageBox.Show(res_man.GetString("LoadPreviousLogo", cul),
                      "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    switch (answer)
                    {
                        case DialogResult.Yes:
                            this.Text = res_man.GetString("OpenLogoMemoryTitle", cul) + " " + Properties.Settings.Default.LogoBinOpen + " " + res_man.GetString("OpenLogoMemoryTitle2", cul);
                            OpenFile(Properties.Settings.Default.LogoBinOpen);
                            txtComments.Enabled = true;
                            cboMoto.Enabled = true;
                            groupBoxLogoFormat.Enabled = true;
                            groupBoxLogoResolution.Enabled = true;
                            groupBoxLogoImageOption.Enabled = true;
                            groupBoxLogoImageOrientation.Enabled = true;
                            DisableControls();
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region OpenNewLogo
            var openfilename = Properties.Settings.Default.LogoBinOpen;
            if (Properties.Settings.Default.LogoBinOpen.EndsWith(".bin") && Properties.Settings.Default.LogoWasSaved == false)
            {
                DialogResult dialogResult = MessageBox.Show(res_man.GetString("ExitLogoWasntSave1", cul) + "\n\n" + openfilename + "\n\n" + "Are you sure about to Reload Tool?", "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ImageStatusBox.Clear();
                    ImageStatusBoxMSG(res_man.GetString("materialLabel10", cul));
                    ImageStatusBoxMSG(res_man.GetString("materialLabel11", cul));
                    Properties.Settings.Default.LogoBinOpen = "";
                    Properties.Settings.Default.Save();
                    buttonAppend.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonExtract.Enabled = true;
                    IniUITool();
                }
                else if (dialogResult == DialogResult.No)
                {
                    try
                    {
                        return;
                    }
                    catch (Exception er)
                    {
                        Logs.DebugErrorLogs(er);
                        SystemSounds.Hand.Play();
                        DarkMessageBox.ShowError(er.ToString(), "Moto_Boot_Logo_Maker");
                    }
                }
            } 
            else
            {
                ImageStatusBox.Clear();
                ImageStatusBoxMSG(res_man.GetString("materialLabel10", cul));
                ImageStatusBoxMSG(res_man.GetString("materialLabel11", cul));
                Properties.Settings.Default.LogoBinOpen = "";
                Properties.Settings.Default.Save();
                buttonAppend.Enabled = true;
                buttonDelete.Enabled = true;
                buttonExtract.Enabled = true;
                IniUITool();
            }
            #endregion OpenNewLogo
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region OpenLogoFile
            if (radioButton4mib.Checked == false && radioButton6MIB.Checked == false && radioButton8MIB.Checked == false && radioButton16MIB.Checked == false && radioButton32MIB.Checked == false)
            {
                SystemSounds.Exclamation.Play();
                DarkMessageBox.ShowWarning(res_man.GetString("SelectLogoSizeWarn", cul), "Moto_Boot_Logo_Maker");
                return;
            }
            else
            {
                var selectdevicetest = new SelectDevice();
                selectdevicetest.Show();
                return;
            }
            #endregion OpenLogoFile
        }

        private void toolStripMenuItemOpenCustomLogo_Click(object sender, EventArgs e)
        {
            #region OpenLogoFileAdmin
            if (CheckAdmin.IsUserAdministrator() == true)
            {
                openFileDialog1.Filter = @"BIN file|*.bin|ZIP file|*.zip";
                openFileDialog1.InitialDirectory = userdesktoppath;
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                if (radioButton4mib.Checked == false && radioButton6MIB.Checked == false && radioButton8MIB.Checked == false && radioButton16MIB.Checked == false && radioButton32MIB.Checked == false)
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(res_man.GetString("SelectLogoSizeWarn", cul), "Moto_Boot_Logo_Maker");
                    return;
                }
                else
                {
                    OpenFile(openFileDialog1.FileName);
                    Properties.Settings.Default.LogoBinOpen = openFileDialog1.FileName.ToString();
                    Properties.Settings.Default.Save();
                    toolStripStatusLabel3.Text = @"\ Current project: " + Properties.Settings.Default.LogoBinOpen;
                    EnableControlsWhenLoadLogo();
                }
            }
            else
            {
                if (radioButton4mib.Checked == false && radioButton6MIB.Checked == false && radioButton8MIB.Checked == false && radioButton16MIB.Checked == false && radioButton32MIB.Checked == false)
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(res_man.GetString("SelectLogoSizeWarn", cul), "Moto_Boot_Logo_Maker");
                    return;
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowInformation(res_man.GetString("OpenCustomLogoNoAdminTool", cul), "Moto_Boot_Logo_Maker");
                }
                return;
            }
            #endregion OpenLogoFileAdmin
        }

        private void testLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = new LogoTest();
            if (s.IsDisposed == false)
            {
                s.Show();
            }
            else
            {
                s.Dispose();
            }
        }

        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternetCheck.CheckInternetProcessStart("https://github.com/Franco28/Moto_Boot_Logo_Maker#readme");
        }

        private void downloadSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = new DownloadS();
            if (s.IsDisposed == false)
            {
                s.Show();
            } 
            else
            {
                s.Dispose();
            }
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            #region AppendImageToLogo
            if ((cboMoto.SelectedIndex > 0) && buttonAppend.Text == res_man.GetString("Append", cul)) return;
            if (txtLogoInternalFile.Text == "") return;
            if (buttonAppend.Text == res_man.GetString("Append", cul))
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
            openFileDialog1.Filter = @"Png file|*.png|Jpg file|*.jpg|Jpeg file|*.jpeg|Bitmap file|*.bmp|Gif file|*.gif|Icon file|*.ico|All files|*.*";
            openFileDialog1.InitialDirectory = userdesktoppath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (CheckAllIMG(5621440) == true)
                {
                    return;
                }
                var img = new Bitmap(new MemoryStream(File.ReadAllBytes(openFileDialog1.FileName)));
                AddToBitmapList(img, Path.GetFileName(openFileDialog1.FileName), txtLogoInternalFile.Text);
                toolStripStatusLabel1.Text = openFileDialog1.FileName;
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
            buttonAppend.Text = res_man.GetString("Replace", cul);
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
            saveFileDialog2.Filter = @"Png file|*.png|Jpeg file|*.jpg|Bitmap file|*.bmp|Gif file|*.gif|Icon file|*.ico|All files|*.*";
            if (saveFileDialog2.ShowDialog() != DialogResult.OK) return;
            try
            {
                switch (Path.GetExtension(saveFileDialog2.FileName))
                {
                    case ".gif":
                        img.Save(saveFileDialog2.FileName, ImageFormat.Gif);
                        break;
                    case ".jpg":
                        img.Save(saveFileDialog2.FileName, ImageFormat.Jpeg);
                        break;
                    case ".bmp":
                        img.Save(saveFileDialog2.FileName, ImageFormat.Bmp);
                        break;
                    case ".ico":
                        img.Save(saveFileDialog2.FileName, ImageFormat.Icon);
                        break;
                    default:
                        img.Save(saveFileDialog2.FileName, ImageFormat.Png);
                        break;

                }
                toolStripStatusLabel1.Text = res_man.GetString("ImageSaveOk", cul) + " " + Path.GetFileName(saveFileDialog2.FileName) + " " +
                                             res_man.GetString("ImageSaveOk2", cul) + @" :)";
                Application.DoEvents();
            }
            catch (Exception er)
            {
                Logs.DebugErrorLogs(er);
                toolStripStatusLabel1.Text = res_man.GetString("ExtractLogoError", cul) + @" :(";
                Application.DoEvents();
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
                        txtLogoInternalFile.Text = "Please reload in File/New to see again logos";
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
            openFileDialog1.Filter = @"Png file|*.png|Jpg file|*.jpg|Jpeg file|*.jpeg|Bitmap file|*.bmp|Gif file|*.gif|Icon file|*.ico|All files|*.*";
            openFileDialog1.InitialDirectory = userdesktoppath;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            if (CheckAllIMG(5621440) == true)
            {
                return;
            }
            var img = new Bitmap(new MemoryStream(File.ReadAllBytes(openFileDialog1.FileName)));
            AddToBitmapList(img, Path.GetFileName(openFileDialog1.FileName), tvLogo.SelectedNode.Text);
            toolStripStatusLabel1.Text = openFileDialog1.FileName;
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
            toolStripStatusLabel1.Text = res_man.GetString("MaxLogoBinSize", cul) + @" = " + (_maxFileSize / 1024 / 1024) + @"MiB";
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
                ? res_man.GetString("Replace", cul)
                : res_man.GetString("Append", cul);
        }

        #region LogoSettings
        private void radioButton4mib_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4mib.Checked == true)
            {
                LogoMaxMIB(4194304, " 4MiB");
                Properties.Profiles.Default.LogoMemory4MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory4MB = false;
            }
            Properties.Profiles.Default.Save();
        }

        private void radioButton6MIB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6MIB.Checked == true)
            {
                LogoMaxMIB(6291456, " 6MiB");
                Properties.Profiles.Default.LogoMemory6MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory6MB = false;
            }
            Properties.Profiles.Default.Save();
        }

        private void radioButton8MIB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8MIB.Checked == true)
            {
                LogoMaxMIB(8388608, " 8MiB");
                Properties.Profiles.Default.LogoMemory8MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory8MB = false;
            }
            Properties.Profiles.Default.Save();
        }

        private void radioButton16MIB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16MIB.Checked == true)
            {
                LogoMaxMIB(16777216, " 16MiB");
                Properties.Profiles.Default.LogoMemory16MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory16MB = false;
            }
            Properties.Profiles.Default.Save();
        }

        private void radioButton32MIB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32MIB.Checked == true)
            {
                LogoMaxMIB(34226176, " 32MiB");
                Properties.Profiles.Default.LogoMemory32MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory32MB = false;
            }
            Properties.Profiles.Default.Save();
        }
        #endregion LogoSettings

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.None;
                if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if ((files.Count() == 1) && ((Path.GetExtension(files[0]) == ".bin") ||
                                            (Path.GetExtension(files[0]) == ".zip")))
                    e.Effect = DragDropEffects.Copy;
            } 
            catch (Exception er)
            {
                Logs.DebugErrorLogs(er);
                SystemSounds.Exclamation.Play();
                DarkMessageBox.ShowWarning(er.ToString(), "Moto_Boot_Logo_Maker");
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if ((files.Count() == 1) && ((Path.GetExtension(files[0]) == ".bin") ||
                                         (Path.GetExtension(files[0]) == ".zip")))
            {
                if (radioButton4mib.Checked == false && radioButton6MIB.Checked == false && radioButton8MIB.Checked == false && radioButton16MIB.Checked == false && radioButton32MIB.Checked == false)
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(res_man.GetString("SelectLogoSizeWarn", cul), "Moto_Boot_Logo_Maker");
                    return;
                }
                else
                {
                    OpenFile(files[0]);
                    Properties.Settings.Default.LogoBinOpen = files[0].ToString();
                    Properties.Settings.Default.Save();
                    toolStripStatusLabel3.Text = @"\ Current project: " + Properties.Settings.Default.LogoBinOpen;
                    EnableControlsWhenLoadLogo();
                }
            }
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
                Properties.Settings.Default.IsMax = false;
                Properties.Settings.Default.Save();
            }
            
            if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Refresh();
                pictureBox1.Invalidate();
                pictureBox1.Update();
                ResizeAndDisplayImage();
                Properties.Settings.Default.IsMax = true;
                Properties.Settings.Default.Save();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region ExitToolSaveData
            var openfilename = Properties.Settings.Default.LogoBinOpen;
            string closeadb = "adb";
            string closefastboot = "fastboot";
            string closetool = "Moto_Boot_Logo_Maker";

            if (Properties.Settings.Default.LogoWasSaved == true)
            {
                timerupdates.Stop();
                if (Properties.Settings.Default.SaveProfiles == true)
                {
                    SaveProfiles();
                }
                foreach (var process in Process.GetProcessesByName(closeadb))
                {
                    process.Kill();
                }
                foreach (var process in Process.GetProcessesByName(closefastboot))
                {
                    process.Kill();
                }
                foreach (var process in Process.GetProcessesByName(closetool))
                {
                    process.Kill();
                }
            }

            if (Properties.Settings.Default.LogoBinOpen.EndsWith(".bin") && Properties.Settings.Default.LogoWasSaved == false)
            {
                DialogResult dialogResult = MessageBox.Show(res_man.GetString("ExitLogoWasntSave1", cul) + "\n\n" + openfilename + "\n\n" + res_man.GetString("ExitLogoWasntSave2", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    timerupdates.Stop();
                    if (Properties.Settings.Default.SaveProfiles == true)
                    {
                        SaveProfiles();
                    }
                    foreach (var process in Process.GetProcessesByName(closeadb))
                    {
                        process.Kill();
                    }
                    foreach (var process in Process.GetProcessesByName(closefastboot))
                    {
                        process.Kill();
                    }
                    foreach (var process in Process.GetProcessesByName(closetool))
                    {
                        process.Kill();
                    }
                } 
                else if (dialogResult == DialogResult.No)
                {
                    try
                    {
                        e.Cancel = true;
                        return;
                    }
                    catch (Exception er)
                    {
                        Logs.DebugErrorLogs(er);
                        SystemSounds.Hand.Play();
                        DarkMessageBox.ShowError(er.ToString(), "Moto_Boot_Logo_Maker");
                    }
                }
            }
            else
            {
                timerupdates.Stop();
                if (Properties.Settings.Default.SaveProfiles == true)
                {
                    SaveProfiles();
                }
                foreach (var process in Process.GetProcessesByName(closeadb))
                {
                    process.Kill();
                }
                foreach (var process in Process.GetProcessesByName(closefastboot))
                {
                    process.Kill();
                }
                foreach (var process in Process.GetProcessesByName(closetool))
                {
                    process.Kill();
                }
            }
            #endregion ExitToolSaveData         
        }
    }
}