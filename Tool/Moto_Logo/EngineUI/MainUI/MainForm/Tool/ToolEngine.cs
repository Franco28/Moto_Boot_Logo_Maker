/* 
#####################################################################
#    File: MainForm.ToolEngine.cs                                   #
#    Author: Franco28                                               # 
#    Date: 17-02-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Moto_Logo.Properties;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
            try
            {
                var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
                var newpath = path.Replace(@"\user.config", "").Trim();
                string filePath = newpath + @"\DebugLogs\Error_" + Environment.UserName + ".txt";

                if (File.Exists(filePath))
                {
                    DialogResult dialogResult = MessageBox.Show(res_man.GetString("LogsErrorSend", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                        {
                            stream.Dispose();
                            watchererrorlogs.Dispose();
                            watchererrorlogs.Changed -= new FileSystemEventHandler(OnChangedErrorLog);
                            watchererrorlogs.Created -= Watcher_CreatedErrorLog;
                            watchererrorlogs.Deleted -= Watcher_DeletedErrorLog;
                          
                            SendLogs.sendMailToAdmin();

                            stream.Dispose();
                        }
                        this.Refresh();
                        Form NewForm = new MainForm();
                        NewForm.Show();
                        this.Dispose(false);
                        Application.DoEvents();
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion gotoerror
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Form NewForm = new MainForm();
            NewForm.Show();
            this.Dispose(false);
            Application.DoEvents();
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
            var logpath = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            var newlogpath = logpath.Replace(@"\user.config", "").Trim();
            string fileLogPath = newlogpath + @"\DebugLogs\";

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
                labelErrorIcon.Show();
                labelErrorInfo.Show();
                labelErrorGoToFileInfo.Show();
                labelErrorGoToFileInfo.Text = "Send logs";
                labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
                labelGoToError.Show();
            }
            else
            {
                labelErrorGoToFileInfo.Hide();
                labelErrorIcon.Hide();
                labelErrorInfo.Hide();
                labelGoToError.Hide();
            }
        }

        private void Watcher_CreatedErrorLog(object sender, FileSystemEventArgs e)
        {
            labelErrorIcon.Show();
            labelErrorInfo.Show();
            labelErrorGoToFileInfo.Show();
            labelErrorGoToFileInfo.Text = "Send logs";
            labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
            labelGoToError.Show();
        }

        private void OnChangedErrorLog(object sender, FileSystemEventArgs e)
        {
            labelErrorIcon.Show();
            labelErrorInfo.Show();
            labelErrorGoToFileInfo.Show();
            labelErrorGoToFileInfo.Text = "Send logs";
            labelErrorInfo.Text = res_man.GetString("ToolErrorShow", cul);
            labelGoToError.Show();
        }

        private void Watcher_DeletedErrorLog(object sender, FileSystemEventArgs e)
        {
            labelErrorGoToFileInfo.Hide();
            labelErrorIcon.Hide();
            labelErrorInfo.Hide();
            labelGoToError.Hide();
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

        private void CheckIMGsize(int size2)
        {
            var path = Path.GetExtension(".jpg");
            if (openFileDialog1.FileName.EndsWith(path))
            {
                long size = openFileDialog1.FileName.Length;
                if (size > size2)
                {
                    MessageBox.Show(res_man.GetString("JPGimgIsToBig", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void labelColorDraw_Click(object sender, EventArgs e)
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

        public static string Dpt(string strData)
        {
            return Encoding.UTF8.GetString(Dpt(Convert.FromBase64String(strData)));
        }

        public static class Global
        {
            public const String strPermutation = "ouiveyxaqtd";
            public const Int32 bytePermutation1 = 0x19;
            public const Int32 bytePermutation2 = 0x59;
            public const Int32 bytePermutation3 = 0x17;
            public const Int32 bytePermutation4 = 0x41;
        }

        public static byte[] Dpt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(Global.strPermutation,
            new byte[] { Global.bytePermutation1,
                         Global.bytePermutation2,
                         Global.bytePermutation3,
                         Global.bytePermutation4
            });
            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);
            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateDecryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
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
                var bbl = new BootLogoChannels();
                bbl.webBrowser1.Navigate(url);
                bbl.Show();
            }
            else
            {
                MessageBox.Show(res_man.GetString("InternetCheck", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            btnAttachPath.Enabled = true;
            groupBoxLogoMemory.Enabled = false;
            buttonExtract.Enabled = true;
            #endregion DisableControls
        }

        public void CallReloadItems(string message, string logomessage)
        {
            #region Reload
            textBoxSearchDevice.Text = "";
            txtComments.Enabled = false;
            cboMoto.Enabled = false;
            txtLogoBuildPath.Enabled = false;
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
            cboMoto.Items.Clear();
            _deviceResolutionX.Clear();
            _deviceResolutionY.Clear();
            _deviceLogoBinSize.Clear();
            _deviceLogoBinContents.Clear();
            Init_cboMoto(res_man.GetString("DevicesCustom", cul), 720, 1080, 4194304, 0x3FFFFFFF);
            cboMoto.SelectedIndex = 0;
            cboMoto_SelectedIndexChanged(null, null);
            picZoom.SizeMode = PictureBoxSizeMode.StretchImage;
            _BackColor = pictureBox1.BackColor;
            _ZoomFactor = trbZoomFactor.Value;
            lblZoomFactor.Text = string.Format("x{0}", _ZoomFactor);
            pictureBoxColors.Image = new Bitmap(1, 1);
            Properties.Profiles.Default.LogoName = logomessage;
            textLogoName.Text = Properties.Profiles.Default.LogoName;
            txtComments.Text = message;
            txtLogoInternalFile.Text = "";
            labelColorDraw.Text = "RGB: ";
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            if (txtLogoBuildPath.Text == string.Empty)
            {
                txtLogoBuildPath.Text = @"C:\NewMotoLogo\";
                Properties.Profiles.Default.LogoPath = txtLogoBuildPath.Text;
            }
            Properties.Profiles.Default.Save();
            if (File.Exists(exePath + @"\Files\Images\Logo\logo.png"))
            {
                pictureBox1.Image = Image.FromFile(exePath + @"\Files\Images\Logo\logo.png");
                picZoom.Image = pictureBox1.Image;
                _OriginalImage = pictureBox1.Image;
            }
            else
            {
                pictureBox1.Image = Resources.logo;
                picZoom.Image = pictureBox1.Image;
                _OriginalImage = pictureBox1.Image;
            }
            ResizeAndDisplayImage();
            #endregion Reload
        }

        public void Reload()
        {
            #region Reload
            CallReloadItems("", "logo");
            #endregion Reload
        }
    }
}