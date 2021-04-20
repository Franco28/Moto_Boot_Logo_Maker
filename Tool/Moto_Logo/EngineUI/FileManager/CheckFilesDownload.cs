/* 
#####################################################################
#    File: CheckFilesDownload.cs                                    #
#    Author: Franco28                                               # 
#    Date: 20-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using DarkUI.Forms;
using Ionic.Zip;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace Moto_Logo
{
    public partial class CheckFilesDownload : DarkForm
    {
        public WebClient webClient = new WebClient();
        public Stopwatch sw = new Stopwatch();

        public string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public FilesMng oConfigMng = new FilesMng();

        public string xmlUrl = "https://raw.githubusercontent.com/Franco28/Moto_Boot_Logo_Maker/master/Windows/OTAS/updates_files.xml";
        public string filever = "";
        public string url = "";
        public string filename = "";

        public XmlTextReader reader = null;

        public CheckFilesDownload()
        {
            InitializeComponent();           
        }

        #region XML
        public void ReadXMLFile()
        {
            try
            {
                if (InternetCheck.ConnectToInternet() == true)
                {
                    reader = new XmlTextReader(xmlUrl);
                    reader.MoveToContent();
                    string elementName = "";
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "item"))
                    {
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                elementName = reader.Name;
                            }
                            else
                            {
                                if ((reader.NodeType == XmlNodeType.Text) && (reader.HasValue))
                                {
                                    switch (elementName)
                                    {
                                        case "filever":
                                            filever = reader.Value;
                                            oConfigMng.Config.FileVersion = filever;
                                            oConfigMng.SaveConfig();
                                            break;
                                        case "url":
                                            url = reader.Value;
                                            oConfigMng.Config.FileURL = url;
                                            oConfigMng.SaveConfig();
                                            break;
                                        case "filename":
                                            filename = reader.Value;
                                            oConfigMng.Config.FileName = filename;
                                            oConfigMng.SaveConfig();
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    SystemSounds.Hand.Play();
                    DarkMessageBox.ShowError("Check your internet connection...", "Error Internet Connection");
                }
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(ex.ToString(), ex.Source);
                this.Close();
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        #endregion XML

        private void CheckFilesDownload_Load(object sender, EventArgs e)
        {
            this.Hide();

            oConfigMng.LoadConfig();
            ReadXMLFile();
            oConfigMng.LoadConfig();

            if (File.Exists(exePath + @"\Files\" + oConfigMng.Config.FileName))
            {
                long length = new FileInfo(exePath + @"\Files\" + oConfigMng.Config.FileName).Length;
                string vIn = oConfigMng.Config.FileSize;
                long vOut = Convert.ToInt64(vIn);

                if (length != vOut)
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(oConfigMng.Config.FileName + " is corrupted, downloading again...", "");
                    CallDownload();
                    return;
                }
                else
                {
                    progressBar.Cursor = Cursors.WaitCursor;
                    labelInformation.Text = "Extracting " + oConfigMng.Config.FileName + "...";
                    this.Text = labelInformation.Text;

                    if (File.Exists(exePath + @"\Files\" + oConfigMng.Config.FileName))
                    {
                        using (FileStream stream = new FileStream(exePath + @"\Files\" + oConfigMng.Config.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                        {
                            ZipFile zip = ZipFile.Read(stream);
                            foreach (ZipEntry ex in zip)
                            {
                                ex.Extract(exePath + @"\Files\", ExtractExistingFileAction.OverwriteSilently);
                            }
                            stream.Dispose();
                        }
                        File.Delete(exePath + @"\Files\" + oConfigMng.Config.FileName);
                        this.Close();
                    }
                }
                return;
            }
            else
            {
                CallDownload();
                return;
            }

            //string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            /*if (oConfigMng.Config.FileVersion != assemblyVersion)
              {
                  MessageBox.Show("A new version v" + oConfigMng.Config.FileVersion + " of Tool files was found, this will be downloaded!", "File Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  CallDownload();
                  return;
              }
              else
              {

              }*/
        }

        public void CallDownload()
        {
            this.Show();
            labelInformation.Text = "Starting download... please wait";
            this.Text = labelInformation.Text;

            string urlAddress = oConfigMng.Config.FileURL;
            string location = exePath + @"\Files\" + oConfigMng.Config.FileName;
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            Uri URL = urlAddress.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri(urlAddress);
            try
            {
                if (InternetCheck.ConnectToInternet() == true)
                {
                    if (InternetCheck.CheckServerRed(oConfigMng.Config.FileURL) == true)
                    {
                        SystemSounds.Hand.Play();
                        DarkMessageBox.ShowError(@"Server is down :\", "Moto_Boot_Logo_Maker - file updates");
                        this.Close();
                    }
                    else
                    {
                        labelInformation.Text = "Downloading " + oConfigMng.Config.FileName + "...";
                        this.Text = labelInformation.Text;
                        sw.Start();
                        webClient.DownloadFileAsync(URL, location);
                    }
                }
                else
                {
                    DialogResult answer = MessageBox.Show("Can´t acces to internet connection, do you want to retry?",
                    "Lost internet connection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (answer)
                    {
                        case DialogResult.Yes:
                            sw.Stop();
                            sw.Reset();
                            CallDownload();
                            break;
                        case DialogResult.No:
                            sw.Stop();
                            this.Close();
                            break;
                    }
                }
            }
            catch (Exception er)
            {
                DialogResult answer = MessageBox.Show("Unknown error has occurred, do you want to retry?",
                er.Source, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                switch (answer)
                {
                    case DialogResult.Yes:
                        sw.Stop();
                        sw.Reset();
                        CallDownload();
                        break;
                    case DialogResult.No:
                        sw.Stop();
                        this.Close();
                        break;
                }
            }
        }

        public void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Cursor = Cursors.WaitCursor;
            labelspeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";
            labelfilesize.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
            progressBar.Value = e.ProgressPercentage;
            oConfigMng.LoadConfig();
            oConfigMng.Config.FileSize = e.TotalBytesToReceive.ToString();
            oConfigMng.SaveConfig();
        }

        public void Completed(object sender, AsyncCompletedEventArgs e)
        {
            webClient.CancelAsync();
            webClient.Dispose();
            try
            {
                long length = new FileInfo(exePath + @"\Files\" + oConfigMng.Config.FileName).Length;
                string vIn = oConfigMng.Config.FileSize;
                long vOut = Convert.ToInt64(vIn);

                if (length != vOut)
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(oConfigMng.Config.FileName + " is corrupted, downloading again...", "");
                    CallDownload();
                    return;
                }
                else
                {
                    progressBar.Cursor = Cursors.Default;
                    labelInformation.Text = "Extracting " + oConfigMng.Config.FileName + "...";
                    this.Text = labelInformation.Text;
                    if (File.Exists(exePath + @"\Files\" + oConfigMng.Config.FileName))
                    {
                        progressBar.Cursor = Cursors.WaitCursor;
                        using (FileStream stream = new FileStream(exePath + @"\Files\" + oConfigMng.Config.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                        {
                            ZipFile zip = ZipFile.Read(stream);
                            foreach (ZipEntry ex in zip)
                            {
                                ex.Extract(exePath + @"\Files\", ExtractExistingFileAction.OverwriteSilently);
                            }
                            stream.Dispose();
                        }
                        File.Delete(exePath + @"\Files\" + oConfigMng.Config.FileName);
                        this.Close();
                    }
                }
            }
            catch (Exception er)
            {
                sw.Stop(); 
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(er.ToString(), "File Extraction Error");
                this.Close();
            }
            return;
        }

        private void CheckFilesDownload_FormClosing(object sender, FormClosingEventArgs e)
        {
            string closeadb = "adb";
            string closefastboot = "fastboot";
            string closetool = "Moto_Boot_Logo_Maker";

            if (webClient != null && webClient.IsBusy == true)
            {
                DialogResult answer = MessageBox.Show("Do you want to exit download? This will kill Tool and downloaded files will be damaged...", "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (answer)
                {
                    case DialogResult.Yes:
                        webClient.CancelAsync();
                        webClient.Dispose();
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
                        break;
                    case DialogResult.No:
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
                        break;
                }
            }
        }
    }
}