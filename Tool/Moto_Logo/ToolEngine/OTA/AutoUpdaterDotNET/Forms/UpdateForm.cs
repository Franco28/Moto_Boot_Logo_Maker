
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Windows.Forms;
using DarkUI.Forms;
using Moto_Logo;

namespace AutoUpdaterDotNET
{
    internal partial class UpdateForm : DarkForm
    {
        private readonly UpdateInfoEventArgs _args;
        private string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        private string _tempFile;
        private MyWebClient _webClient;
        private DateTime _startedAt;
        public Stopwatch sw = new Stopwatch();

        public UpdateForm(UpdateInfoEventArgs args)
        {
            _args = args;
            InitializeComponent();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            Text = string.Format(resources.GetString("$this.Text", CultureInfo.CurrentCulture),
                AutoUpdater.AppTitle, _args.CurrentVersion);
            labelUpdate.Text = string.Format(resources.GetString("labelUpdate.Text", CultureInfo.CurrentCulture),
                AutoUpdater.AppTitle);
            labelDescription.Text =
                string.Format(resources.GetString("labelDescription.Text", CultureInfo.CurrentCulture),
                    AutoUpdater.AppTitle, _args.CurrentVersion, _args.InstalledVersion);
        }

        private void UpdateFormLoad(object sender, EventArgs e)
        {
            webBrowser.Size = new Size(723, 461);
            labelInformation.Hide();
            pictureBox1.Hide();
            labelfilesize.Hide();
            labelspeed.Hide();
            labelPerc.Hide();
            progressBar.Hide();

            if (string.IsNullOrEmpty(_args.ChangelogURL))
            {
                var reduceHeight = labelReleaseNotes.Height + webBrowser.Height;
                labelReleaseNotes.Hide();
                webBrowser.Hide();
                Height -= reduceHeight;
            }
            else
            {
                WebClient Client = new WebClient();
                //long length = new FileInfo(exePath + @"\changelog.txt").Length;

                Client.DownloadFile("https://raw.githubusercontent.com/Franco28/Moto_Boot_Logo_Maker/master/Tool/Setup/changelog.txt", exePath + @"\changelog.txt");
                Client.Dispose();
                Client.CancelAsync();

                webBrowser.Text = File.ReadAllText(exePath + @"\changelog.txt");
            }

            var labelSize = new Size(Width - 110, 0);
            labelDescription.MaximumSize = labelUpdate.MaximumSize = labelSize;
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            webBrowser.Size = new Size(723, 323);
            labelInformation.Show();
            pictureBox1.Show();
            labelfilesize.Show();
            labelspeed.Show();
            labelPerc.Show();
            progressBar.Show();

            var uri = new Uri(_args.DownloadURL);
            _webClient = AutoUpdater.GetWebClient(uri, AutoUpdater.BasicAuthDownload);
           
            _tempFile = Path.Combine(exePath + AutoUpdater.DownloadPath, $"{Guid.NewGuid().ToString()}.tmp");
           
            if (!Directory.Exists(exePath + AutoUpdater.DownloadPath))
            {
                Directory.CreateDirectory(exePath + AutoUpdater.DownloadPath);
            }

            _webClient.DownloadProgressChanged += OnDownloadProgressChanged;
            _webClient.DownloadFileCompleted += WebClientOnDownloadFileCompleted;
            _webClient.DownloadFileAsync(uri, _tempFile);

            sw.Start();
            labelInformation.Text = "Downloading in... " + _tempFile;
            progressBar.Cursor = Cursors.WaitCursor;
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (_startedAt == default(DateTime))
            {
                _startedAt = DateTime.Now;
            }
            labelspeed.Text = string.Format("{0} KB's", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";
            labelfilesize.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
            progressBar.Value = e.ProgressPercentage;
        }

        private void WebClientOnDownloadFileCompleted(object sender, AsyncCompletedEventArgs asyncCompletedEventArgs)
        {
            progressBar.Cursor = Cursors.Default;
            sw.Stop();

            if (asyncCompletedEventArgs.Cancelled)
            {
                return;
            }

            try
            {
                if (asyncCompletedEventArgs.Error != null)
                {
                    throw asyncCompletedEventArgs.Error;
                }

                ContentDisposition contentDisposition = null;
                if (_webClient.ResponseHeaders["Content-Disposition"] != null)
                {
                    contentDisposition = new ContentDisposition(_webClient.ResponseHeaders["Content-Disposition"]);
                }

                var fileName = string.IsNullOrEmpty(contentDisposition?.FileName)
                    ? Path.GetFileName(_webClient.ResponseUri.LocalPath)
                    : contentDisposition.FileName;

                var tempPath = Path.Combine(exePath + AutoUpdater.DownloadPath, fileName);

                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }

                File.Move(_tempFile, tempPath);

                string installerArgs = null;
                if (!string.IsNullOrEmpty(_args.InstallerArgs))
                {
                    installerArgs = _args.InstallerArgs.Replace("%path%",
                        Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
                }

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = tempPath,
                    UseShellExecute = true,
                    Arguments = installerArgs
                };

                var extension = Path.GetExtension(tempPath);
                
                if (extension.Equals(".msi", StringComparison.OrdinalIgnoreCase))
                {
                    processStartInfo = new ProcessStartInfo
                    {
                        FileName = "msiexec",
                        Arguments = $"/i \"{tempPath}\""
                    };
                    if (!string.IsNullOrEmpty(installerArgs))
                    {
                        processStartInfo.Arguments += " " + installerArgs;
                    }
                }

                if (AutoUpdater.RunUpdateAsAdmin)
                {
                    processStartInfo.Verb = "runas";
                }

                try
                {
                    Process.Start(processStartInfo);
                }
                catch (Win32Exception exception)
                {
                    if (exception.NativeErrorCode == 1223)
                    {
                        _webClient = null;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
                _webClient = null;
            }
            finally
            {
                DialogResult = _webClient == null ? DialogResult.Cancel : DialogResult.OK;
                FormClosing -= UpdateForm_FormClosing;
                Close();
            }
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AutoUpdater.Running = true;
        }

        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string closetool = "Moto_Boot_Logo_Maker";

            if (_webClient != null && _webClient.IsBusy)
            {
                DialogResult answer = MessageBox.Show("Do you want to exit Tool UPDATE? This will kill Tool and this form will be shown in next Tool launch...", "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (answer)
                {
                    case DialogResult.Yes:
                        _webClient.CancelAsync();
                        _webClient.Dispose();
                        foreach (var process in Process.GetProcessesByName(closetool))
                        {
                            process.Kill();
                        }
                        break;
                    case DialogResult.No:
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
                        break;
                }
            } 
            else
            {
                AutoUpdater.Running = true;
                this.Dispose();
            }
        }
    }
}