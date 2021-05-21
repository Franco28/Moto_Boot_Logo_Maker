/* 
#####################################################################
#    File: MainForm.ToolEngine.cs                                   #
#    Author: Franco28                                               # 
#    Date: 24-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using DarkUI.Forms;
using Moto_Logo.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class MainForm
    {
        
        private void labelGoToError_Click(object sender, EventArgs e)
        {
            #region gotoerror
            //var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            //var newpath = path.Replace(@"\user.config", "").Trim();
            //string errorpath = newpath + @"\DebugLogs\";

            string errorpath = exePath + @"\Logs\";
            SystemSounds.Exclamation.Play();
            DarkMessageBox.ShowInformation(res_man.GetString("ErrorLogsWarnigMSG", cul), "Moto_Boot_Logo_Maker");
            Process.Start(errorpath);
            return;
            #endregion gotoerror
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var openfilename = Properties.Settings.Default.LogoBinOpen;

            if (Properties.Settings.Default.LogoBinOpen.EndsWith(".bin") && Properties.Settings.Default.LogoWasSaved == false)
            {
                DialogResult dialogResult = MessageBox.Show(res_man.GetString("ExitLogoWasntSave1", cul) + "\n\n" + openfilename + "\n\n" + "Are you sure about to Reload Tool?", "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Refresh();
                    Form NewForm = new MainForm();
                    NewForm.Show();
                    this.Dispose(false);
                    Application.DoEvents();
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
                this.Refresh();
                Form NewForm = new MainForm();
                NewForm.Show();
                this.Dispose(false);
                Application.DoEvents();
            }
        }

        private void LogoTree(Bitmap resourcesimg)
        {
            pictureBox1.Refresh();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = FixedSizePreview(resourcesimg);
            picZoom.Image = pictureBox1.Image;
            _OriginalImage = FixedSizePreview(resourcesimg);
            ResizeAndDisplayImage();
        }

        public void FileSystemWatcherFilesFolder()
        {
            CallFilesFolderError();
        }

        public void FileSystemWatcherErrorLogs()
        {
            CallLogError();
        }

        #region FileSystemWatcher

        FileSystemWatcher watchFilesFolder = new FileSystemWatcher(exePath + @"\Files");
     
        private void CallFilesFolderError()
        {
            watchFilesFolder.IncludeSubdirectories = true; 
            watchFilesFolder.NotifyFilter = NotifyFilters.DirectoryName;
            watchFilesFolder.Changed += new FileSystemEventHandler(watchFilesFolder_Changed);
            watchFilesFolder.Created += watchFilesFolder_Created;
            watchFilesFolder.Deleted += watchFilesFolder_Deleted;
            watchFilesFolder.EnableRaisingEvents = true;
        }

        private void watchFilesFolder_Deleted(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("Se elimino la carpeta... " + e.Name);
            return;
        }

        private void watchFilesFolder_Created(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("Se creo una nueva carpeta... " + e.Name);
            return;
        }

        private void watchFilesFolder_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.Name == "Bin")
            {
                MessageBox.Show("Se renombro la carpeta... " + e.Name);
                Directory.Move(exePath + @"\Files\Bin", exePath + @"\Files\Bin");
            }
            if (e.Name == "Images")
            {
                MessageBox.Show("Se renombro la carpeta... " + e.Name);
                Directory.Move(exePath + @"\Files\Images", exePath + @"\Files\Images");
            }
            if (e.Name == "LogoZip")
            {
                MessageBox.Show("Se renombro la carpeta... " + e.Name);
                Directory.Move(exePath + @"\Files\LogoZip", exePath + @"\Files\LogoZip");
            }
            return;
        }

        FileSystemWatcher watchererrorlogs = new FileSystemWatcher();

        private void CallLogError()
        {
            //var logpath = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            //var newlogpath = logpath.Replace(@"\user.config", "").Trim();
            //string fileLogPath = newlogpath + @"\DebugLogs\";

            string fileLogPath = exePath + @"\Logs\";

            watchererrorlogs.Path = fileLogPath;
            watchererrorlogs.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watchererrorlogs.Filter = "Error_" + Environment.UserName + ".txt";
            watchererrorlogs.Changed += new FileSystemEventHandler(OnChangedErrorLog);
            watchererrorlogs.Created += Watcher_CreatedErrorLog;
            watchererrorlogs.Deleted += Watcher_DeletedErrorLog;
            watchererrorlogs.EnableRaisingEvents = true;
            Console.Read();

            if (File.Exists(fileLogPath + "Error_" + Environment.UserName + ".txt") && new FileInfo(fileLogPath + "Error_" + Environment.UserName + ".txt").Length != 0)
            {
                labelErrorIcon.Visible = true;
                labelErrorInfo.Visible = true;
                labelErrorGoToFileInfo.Visible = true;
                labelErrorGoToFileInfo.Text = "Send logs";
                labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
                labelGoToError.Visible = true;
            }
            else
            {
                labelErrorGoToFileInfo.Visible = false;
                labelErrorIcon.Visible = false;
                labelErrorInfo.Visible = false;
                labelGoToError.Visible = false;
            }
        }

        private void Watcher_CreatedErrorLog(object sender, FileSystemEventArgs e)
        {
            labelErrorIcon.Visible = true;
            labelErrorInfo.Visible = true;
            labelErrorGoToFileInfo.Visible = true;
            labelErrorGoToFileInfo.Text = "Send logs";
            labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
            labelGoToError.Visible = true;
        }

        private void OnChangedErrorLog(object sender, FileSystemEventArgs e)
        {
            labelErrorIcon.Visible = true;
            labelErrorInfo.Visible = true;
            labelErrorGoToFileInfo.Visible = true;
            labelErrorGoToFileInfo.Text = "Send logs";
            labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
            labelGoToError.Visible = true;
        }

        private void Watcher_DeletedErrorLog(object sender, FileSystemEventArgs e)
        {
            labelErrorGoToFileInfo.Visible = false;
            labelErrorIcon.Visible = false;
            labelErrorInfo.Visible = false;
            labelGoToError.Visible = false;
        }
        #endregion FileSystemWatcher

        private void SetClipboard()
        {
            var regx = new Regex(@"^RGB\s*:\s*(\d*)\s*$");
            var result = regx.Match(labelColorDraw.Text);
            if (!result.Success)
            {
                StringBuilder clipboard = new StringBuilder();
                clipboard.Append(labelColorDraw.Text.Replace("RGB:", "").Trim());
                Clipboard.SetText(clipboard.ToString());
                ToolTip1.ToolTipTitle = res_man.GetString("ToolTipRGBCOLOUR", cul);
                ToolTip1.AutoPopDelay = 1500;
                ToolTip1.InitialDelay = 400;
                ToolTip1.ReshowDelay = 500;
                ToolTip1.IsBalloon = true;
                ToolTip1.UseAnimation = true;
                ToolTip1.UseFading = true;
                ToolTip1.Active = true;
                ToolTip1.SetToolTip(labelColorDraw, res_man.GetString("ToolTipRGBCOLOUR", cul) + " " + clipboard.ToString() + " " + res_man.GetString("ToolTipRGBCOLOURCOPIED", cul));
                return;
            }
            else
            {
                return;
            }
        }

        private bool CheckAllIMG(int size2)
        {
            // NOTE: Need to check if new moto devices support more than 5.6MB (5621440 bytes)
            var IMGExtension = Path.GetExtension(openFileDialog1.FileName);
            long size = new FileInfo(openFileDialog1.FileName).Length;
           
            if (IMGExtension.EndsWith(".jpg") ||
               IMGExtension.EndsWith(".jpeg") ||
               IMGExtension.EndsWith(".png") ||
               IMGExtension.EndsWith(".bmp") ||
               IMGExtension.EndsWith(".gif") ||
               IMGExtension.EndsWith(".ico"))
            {
                if (size >= size2)
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(res_man.GetString("JPGimgIsToBig", cul).Replace("<IMGExtension>", IMGExtension), "Moto_Boot_Logo_Maker");
                    return true;
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(res_man.GetString("ErrorWrongTypeOfIMG", cul) + " \n- .png\n- .jpg\n- .jpeg\n- .bmp\n- .gif\n- .ico", "Moto_Boot_Logo_Maker");
                return true;
            }
            return false;
        }

        private void labelColorDraw_Click(object sender, EventArgs e)
        {
            SetClipboard();
        }

        private void pictureBoxColors_Click(object sender, EventArgs e)
        {
            SetClipboard();
        }

        private void labelImageStatus_MouseLeave(object sender, EventArgs e)
        {
            ToolTip1.Dispose();
            ToolTip1.RemoveAll();
        }

        public void RestartApp()
        {
            Process process = null;
            try
            {
                timerupdates.Stop();
                process = Process.GetCurrentProcess();
                process.WaitForExit(1000);
            }
            catch (ArgumentException ex)
            {
                Logs.DebugErrorLogs(ex);
            }
            Process.Start("Moto_Boot_Logo_Maker");
            process.Kill();
        }

        private void SetRadioButtons(int index)
        {
            SetRadioButtons(_loadedbitmapimageoptions[index], _loadedbitmapimagelayout[index]);
        }

        private void ClearBitmapList()
        {
            _loadedbitmaps.Clear();
            _loadedbitmapnames.Clear();
            _loadedbitmapimageoptions.Clear();
            _loadedbitmapimagelayout.Clear();
        }

        private void SetRadioButtons(ImageOption imageOption, ImageLayout imageLayout)
        {
            switch (imageOption)
            {
                case ImageOption.ImageOptionCenter:
                    rdoImageCenter.Checked = true;
                    break;
                case ImageOption.ImageOptionFill:
                    rdoImageFill.Checked = true;
                    break;
                case ImageOption.ImageOptionStretchProportionately:
                    rdoImageStretchAspect.Checked = true;
                    break;
            }
            switch (imageLayout)
            {
                case ImageLayout.ImageLayoutPortrait:
                    rdoLayoutPortrait.Checked = true;
                    break;
                case ImageLayout.ImageLayoutLandscape:
                    rdoLayoutLandscape.Checked = true;
                    break;
            }
        }

        private void AddToBitmapList(Bitmap img, string filename, string logoname)
        {
            var nodeindex = -1;
            for (var i = 0; i < tvLogo.Nodes.Count; i++)
            {
                if (tvLogo.Nodes[i].Text != logoname) continue;
                nodeindex = i;
                break;
            }
            if (nodeindex == -1)
            {
                tvLogo.Nodes.Add(logoname);
                nodeindex = tvLogo.Nodes.Count - 1;
            }
            try
            {
                if (_loadedbitmaps.IndexOf(img) != -1) return;
                _loadedbitmaps.Add(img);
                tvLogo.Nodes[nodeindex].Name = _loadedbitmaps.IndexOf(img).ToString();
                _loadedbitmapnames.Add(filename);
                _loadedbitmapimageoptions.Add(rdoImageCenter.Checked
                    ? ImageOption.ImageOptionCenter
                    : rdoImageStretchAspect.Checked
                        ? ImageOption.ImageOptionStretchProportionately
                        : ImageOption.ImageOptionFill);
                _loadedbitmapimagelayout.Add(rdoLayoutLandscape.Checked
                    ? ImageLayout.ImageLayoutLandscape
                    : ImageLayout.ImageLayoutPortrait);
            }
            catch
            {
                tvLogo.Nodes[nodeindex].Name = "";
            }
        }

        private void LogoMaxMIB(int size, string mb)
        {
            _logosize = size;
            cboMoto.Items.Clear();
            _deviceLogoBinSize.Clear();
            Init_cboMoto(res_man.GetString("DevicesCustom", cul) + mb, 720, 1080, _logosize, 0x3FFFFFFF);
            toolStripStatusLabel1.Text = res_man.GetString("MaxLogoBinSize", cul) + @" = " + (_maxFileSize / 1024 / 1024) + @"MiB";
            cboMoto.SelectedIndex = 0;
        }

        private void Init_cboMoto(string device, int resolutionX, int resolutionY, int logobinsize, UInt32 logoContents)
        {
            cboMoto.Items.Add(device);
            _deviceResolutionX.Add(resolutionX);
            _deviceResolutionY.Add(resolutionY);
            _deviceLogoBinSize.Add(logobinsize);
            _deviceLogoBinContents.Add(logoContents);
        }

        public void OpenTelegramChannel(string url)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                Process.Start(url);
            }
            else
            {
                SystemSounds.Exclamation.Play();
                DarkMessageBox.ShowWarning(res_man.GetString("InternetCheck", cul), "Moto_Boot_Logo_Maker");
                return;
            }
        }

        public void DisableControls()
        {
            #region DisableControls
            txtComments.Enabled = true;
            cboMoto.Enabled = true;
            groupBoxLogoFormat.Enabled = true;
            groupBoxLogoResolution.Enabled = true;
            groupBoxLogoImageOption.Enabled = true;
            groupBoxLogoImageOrientation.Enabled = true;
            groupBoxLogoExtension.Enabled = true;
            textLogoName.Enabled = true;
            txtLogoBuildPath.Enabled = true;
            labelBuildPath.Enabled = true;
            labelLogoName.Enabled = true;
            btnAttachPath.Enabled = true;
            groupBoxLogoMemory.Enabled = false;
            buttonExtract.Enabled = true;
            #endregion DisableControls
        }

        public void EnableControlsWhenLoadLogo()
        {
            txtComments.Enabled = true;
            cboMoto.Enabled = true;
            groupBoxLogoFormat.Enabled = true;
            groupBoxLogoResolution.Enabled = true;
            groupBoxLogoImageOption.Enabled = true;
            groupBoxLogoImageOrientation.Enabled = true;
            groupBoxLogoExtension.Enabled = true;
            textLogoName.Enabled = true;
            txtLogoBuildPath.Enabled = true;
            btnAttachPath.Enabled = true;
            groupBoxLogoMemory.Enabled = false;
            DisableControls();
            labelbtnStop.Enabled = false;
            btnStop.Enabled = false;
            labelbtnBuild.Enabled = true;
            btnBuild.Enabled = true;
        }
        
        public void IniUITool()
        {
            #region Reload
            try
            {
                labelResoTitle.Visible = false;
                labelDRX.Visible = false;
                labelDRY.Visible = false;

                groupBoxLogoResolution.Visible = false;
                groupBoxLogoResolution.Hide();

                if (groupBoxLogoResolution.Visible == false)
                {
                    rdoLayoutLandscape.Location = new Point(6, 42);
                }

                if (Properties.Settings.Default.KeepLogoBinFormatGrid == false)
                {
                    groupBoxLogoFormat.Hide();
                    groupBoxLogoFormat.Visible = false;
                    groupBoxLogoImageOption.Location = new Point(453, 91);
                    groupBoxLogoImageOrientation.Location = new Point(760, 91);
                    groupBoxLogoImageOrientation.Size = new Size(420, 98);
                }

                if (Properties.Settings.Default.KeepLogoBinFormatGrid == true)
                {
                    groupBoxLogoImageOrientation.Location = new Point(936, 91);
                    groupBoxLogoImageOrientation.Size = new Size(244, 98);
                    rdoLayoutLandscape.Location = new Point(6, 42);
                }

                if (labelResoTitle.Visible == false && labelDRX.Visible == false && labelDRY.Visible == false)
                {
                    groupBoxLogoExtension.Size = new Size(191, 98);
                    groupBoxLogoMemory.Size = new Size(217, 98);
                }

                txtComments.Enabled = false;
                cboMoto.Enabled = false;
                txtLogoBuildPath.Enabled = false;
                labelBuildPath.Enabled = false;
                labelLogoName.Enabled = false;
                btnAttachPath.Enabled = false;
                groupBoxLogoFormat.Enabled = false;
                groupBoxLogoResolution.Enabled = false;
                groupBoxLogoImageOption.Enabled = false;
                groupBoxLogoImageOrientation.Enabled = false;
                groupBoxLogoExtension.Enabled = false;
                textLogoName.Enabled = false;
                btnStop.Enabled = false;
                labelbtnStop.Enabled = false;
                btnBuild.Enabled = false;
                labelbtnBuild.Enabled = false;
                groupBoxLogoMemory.Enabled = true;
                radioButton4mib.Checked = false;
                radioButton6MIB.Checked = false;
                radioButton8MIB.Checked = false;
                radioButton16MIB.Checked = false;
                radioButton32MIB.Checked = false;
                rdoAndroid44.Checked = true;
                rdoImageCenter.Checked = true;
                ProgressBar.Visible = false;
                tvLogo.SelectedNode = null;
                tvLogo.Invalidate();
                tvLogo.Nodes.Clear();
                _loadedbitmaps.Clear();
                _loadedbitmapnames.Clear();
                _deviceResolutionX.Clear();
                _deviceResolutionY.Clear();
                _deviceLogoBinSize.Clear();
                _deviceLogoBinContents.Clear();
                cboMoto.Items.Clear();
                Init_cboMoto(res_man.GetString("DevicesCustom", cul), 720, 1080, 4194304, 0x3FFFFFFF);
                cboMoto.SelectedIndex = 0;
                //cboMoto_SelectedIndexChanged(null, null);
                textBoxSearchDevice.Text = "";
                txtComments.Text = "";
                txtLogoInternalFile.Text = "";
                labelColorDraw.Text = "RGB: ";
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel2.Text = "";
                toolStripStatusLabel3.Text = "";
                if (txtLogoBuildPath.Text == string.Empty)
                {
                    txtLogoBuildPath.Text = @"C:\NewMotoLogo\";
                    Properties.Profiles.Default.LogoPath = txtLogoBuildPath.Text;
                }
                if (textLogoName.Text == string.Empty)
                {
                    textLogoName.Text = @"logo";
                    Properties.Profiles.Default.LogoName = textLogoName.Text;
                }
                if (Properties.Settings.Default.IsMax == true)
                {
                    this.WindowState = FormWindowState.Maximized;
                    Properties.Settings.Default.IsMax = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.StartPosition = FormStartPosition.CenterScreen;
                    Properties.Settings.Default.IsMax = false;
                    Properties.Settings.Default.Save();
                }
                Properties.Profiles.Default.Save();
                picZoom.SizeMode = PictureBoxSizeMode.StretchImage;
                _BackColor = pictureBox1.BackColor;
                _ZoomFactor = trbZoomFactor.Value;
                lblZoomFactor.Text = string.Format("x{0}", _ZoomFactor);
                pictureBoxColors.Image = new Bitmap(1, 1);
                pictureBox1.Image = Resources.logo;
                picZoom.Image = pictureBox1.Image;
                _OriginalImage = pictureBox1.Image;
                ResizeAndDisplayImage();
            } 
            catch (Exception er)
            {
                Logs.DebugErrorLogs(er);
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(er.ToString(), "Moto_Boot_Logo_Maker");
            }               
            #endregion Reload
        }
    }
}