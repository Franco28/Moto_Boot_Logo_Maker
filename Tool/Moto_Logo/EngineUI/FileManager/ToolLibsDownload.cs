/* 
#####################################################################
#    File: ToolLibsDownload.cs                                      #
#    Author: Franco28                                               # 
#    Date: 05-04-2021                                               #
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
    public partial class ToolLibsDownload : DarkForm
    {
        public string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public WebClient webClient;
        public Stopwatch sw = new Stopwatch();
        public FilesMng oConfigMng = new FilesMng();

        public string xmlUrl = "https://raw.githubusercontent.com/Franco28/Moto_Boot_Logo_Maker/master/Windows/OTAS/updates_files.xml";
        public string fileverDLL = "";
        public string urlDLL = "";
        public string filenameDLL = "";

        public XmlTextReader reader = null;

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
                                        case "fileverDLL":
                                            fileverDLL = reader.Value;
                                            oConfigMng.Config.DLLVersion = fileverDLL;
                                            oConfigMng.SaveConfig();
                                            break;
                                        case "urlDLL":
                                            urlDLL = reader.Value;
                                            oConfigMng.Config.DLLURL = urlDLL;
                                            oConfigMng.SaveConfig();
                                            break;
                                        case "filenameDLL":
                                            filenameDLL = reader.Value;
                                            oConfigMng.Config.DLLName = filenameDLL;
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

        public void RestartApp()
        {
            Process process = null;
            try
            {
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

        public ToolLibsDownload()
        {
            InitializeComponent();
        }

        private void ToolLibsDownload_Load(object sender, EventArgs e)
        {
            oConfigMng.LoadConfig();
            ReadXMLFile();
            oConfigMng.LoadConfig();

            if (File.Exists(exePath + @"\" + oConfigMng.Config.DLLName))
            {
                long length = new FileInfo(exePath + @"\" + oConfigMng.Config.DLLName).Length;
                string vIn = oConfigMng.Config.DLLSize;
                long vOut = Convert.ToInt64(vIn);

                if (length != vOut)
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(oConfigMng.Config.DLLName + " is corrupted, downloading again...", "");
                    CallDownload();
                    return;
                }
                else
                {
                    progressBar.Cursor = Cursors.WaitCursor;
                    labelInformation.Text = "Extracting " + oConfigMng.Config.DLLName + "...";
                    this.Text = labelInformation.Text;

                    if (File.Exists(exePath + @"\" + oConfigMng.Config.DLLName))
                    {
                        using (FileStream stream = new FileStream(exePath + @"\" + oConfigMng.Config.DLLName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                        {
                            ZipFile zip = ZipFile.Read(stream);
                            foreach (ZipEntry ex in zip)
                            {
                                ex.Extract(exePath + @"\", ExtractExistingFileAction.OverwriteSilently);
                            }
                            stream.Dispose();
                        }
                        File.Delete(exePath + @"\" + oConfigMng.Config.DLLName);
                    }
                    RestartApp();
                }
                return;
            }
            else
            {
                CallDownload();
                return;
            }
        }

        public void CallDownload()
        {
            this.Show();
            labelInformation.Text = "Downloading " + oConfigMng.Config.DLLName + "...";
            this.Text = labelInformation.Text;

            using (webClient = new WebClient())
            {
                string urlAddress = oConfigMng.Config.DLLURL;
                string location = exePath + @"\" + oConfigMng.Config.DLLName;
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
            oConfigMng.Config.DLLSize = e.TotalBytesToReceive.ToString();
            oConfigMng.SaveConfig();
        }

        public void Completed(object sender, AsyncCompletedEventArgs e)
        {
            webClient.CancelAsync();
            webClient.Dispose();
            try
            {
                long length = new FileInfo(exePath + @"\" + oConfigMng.Config.DLLName).Length;
                string vIn = oConfigMng.Config.DLLSize;
                long vOut = Convert.ToInt64(vIn);

                if (length != vOut)
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(oConfigMng.Config.DLLName + " is corrupted, downloading again...", "");
                    CallDownload();
                    return;
                }
                else
                {
                    progressBar.Cursor = Cursors.Default;
                    labelInformation.Text = "Extracting " + oConfigMng.Config.DLLName + "...";
                    this.Text = labelInformation.Text;

                    if (File.Exists(exePath + @"\" + oConfigMng.Config.DLLName))
                    {
                        progressBar.Cursor = Cursors.WaitCursor;
                        using (FileStream stream = new FileStream(exePath + @"\" + oConfigMng.Config.DLLName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                        {
                            ZipFile zip = ZipFile.Read(stream);
                            foreach (ZipEntry ex in zip)
                            {
                                ex.Extract(exePath + @"\", ExtractExistingFileAction.DoNotOverwrite);
                            }
                            stream.Dispose();
                        }
                        File.Delete(exePath + @"\" + oConfigMng.Config.DLLName);
                        RestartApp();
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
    }
}