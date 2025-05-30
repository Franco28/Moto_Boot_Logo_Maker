﻿/* 
#####################################################################
#    File: MainForm.ToolEngine.cs                                   #
#    Author: Franco28                                               # 
#    Date: 22-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Moto_Logo.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            MessageBox.Show(res_man.GetString("ErrorLogsWarnigMSG", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    catch (Exception ex)
                    {
                        Logs.DebugErrorLogs(ex);
                        MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);                   
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

        public void FileSystemWatcherErrorLogs()
        {
            CallLogError();
        }

        #region FileSystemWatcher          
        FileSystemWatcher watchererrorlogs = new FileSystemWatcher();

        private void CallLogError()
        {
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
                toolStripSeparatorErrorMsg.Visible = true;
                labelErrorGoToFileInfo.Text = "Send logs";
                labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
                labelGoToError.Visible = true;
            }
            else
            {
                toolStripSeparatorErrorMsg.Visible = false;
                labelErrorGoToFileInfo.Visible = false;
                labelErrorIcon.Visible = false;
                labelErrorInfo.Visible = false;
                labelGoToError.Visible = false;
            }
        }

        private void Watcher_CreatedErrorLog(object sender, FileSystemEventArgs e)
        {
            toolStripSeparatorErrorMsg.Visible = true;
            labelErrorIcon.Visible = true;
            labelErrorInfo.Visible = true;
            labelErrorGoToFileInfo.Visible = true;
            labelErrorGoToFileInfo.Text = "Send logs";
            labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
            labelGoToError.Visible = true;
        }

        private void OnChangedErrorLog(object sender, FileSystemEventArgs e)
        {
            toolStripSeparatorErrorMsg.Visible = true;
            labelErrorIcon.Visible = true;
            labelErrorInfo.Visible = true;
            labelErrorGoToFileInfo.Visible = true;
            labelErrorGoToFileInfo.Text = "Send logs";
            labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
            labelGoToError.Visible = true;
        }

        private void Watcher_DeletedErrorLog(object sender, FileSystemEventArgs e)
        {
            toolStripSeparatorErrorMsg.Visible = false;
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
                MainToolTip.ToolTipTitle = res_man.GetString("ToolTipRGBCOLOUR", cul);
                MainToolTip.AutoPopDelay = 1500;
                MainToolTip.InitialDelay = 400;
                MainToolTip.ReshowDelay = 500;
                MainToolTip.IsBalloon = true;
                MainToolTip.UseAnimation = true;
                MainToolTip.UseFading = true;
                MainToolTip.Active = true;
                MainToolTip.SetToolTip(labelColorDraw, res_man.GetString("ToolTipRGBCOLOUR", cul) + " " + clipboard.ToString() + " " + res_man.GetString("ToolTipRGBCOLOURCOPIED", cul));
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
            var IMGExtension = Path.GetExtension(MainOpenFileDialog.FileName);
            long size = new FileInfo(MainOpenFileDialog.FileName).Length;
           
            if (IMGExtension.EndsWith(".jpg") ||
               IMGExtension.EndsWith(".jpeg") ||
               IMGExtension.EndsWith(".png") ||
               IMGExtension.EndsWith(".bmp") ||
               IMGExtension.EndsWith(".gif") ||
               IMGExtension.EndsWith(".ico"))
            {
                if (size >= size2)
                {
                    MessageBox.Show(res_man.GetString("JPGimgIsToBig", cul).Replace("<IMGExtension>", IMGExtension), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            else
            {
                MessageBox.Show(res_man.GetString("ErrorWrongTypeOfIMG", cul) + " \n- .png\n- .jpg\n- .jpeg\n- .bmp\n- .gif\n- .ico", "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MainToolTip.Dispose();
            MainToolTip.RemoveAll();
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
            Init_cboMoto(res_man.GetString("MainForm_Logo_Custom", cul) + mb, 720, 1080, _logosize, 0x3FFFFFFF);
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

        public void KillTool()
        {
            string closetool = "Moto_Boot_Logo_Maker";

            timerupdates.Stop();
            if (Properties.Settings.Default.SaveProfiles == true)
            {
                SaveProfiles();
            }
            foreach (var process in Process.GetProcessesByName(closetool))
            {
                process.Kill();
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
            #region EnableControlsWhenLoadLogo
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
            #endregion EnableControlsWhenLoadLogo
        }

        public void IniUITool()
        {
            #region Reload
            try
            {
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
                Init_cboMoto(res_man.GetString("MainForm_Logo_Custom", cul), 720, 1080, 4194304, 0x3FFFFFFF);
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
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion Reload
        }
    }
}