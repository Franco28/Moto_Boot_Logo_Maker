﻿/* 
#####################################################################
#    File: CheckFilesDownload.cs                                    #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
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
using System.Globalization;
using System.IO;
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
        public static CultureInfo cul = null;

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
            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

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
                    MessageBox.Show(res_man.GetString("AboutForm_DownloadUpdate_NetLost", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString() + " " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
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

            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            labelInformation.Text = res_man.GetString("ToolDownloadsForm_Label_DownloadFile", cul);
            labelfilesize.Text = res_man.GetString("ToolDownloadsForm_Label_FileSize", cul);
            labelspeed.Text = res_man.GetString("ToolDownloadsForm_Label_DSpeed", cul);

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
                    MessageBox.Show(oConfigMng.Config.FileName + " " + res_man.GetString("ToolDownloadsForm_File_Corrupt", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CallDownload();
                    return;
                }
                else
                {
                    progressBar.Cursor = Cursors.WaitCursor;
                    labelInformation.Text = res_man.GetString("ToolDownloadsForm_File_Extract", cul) + " " + oConfigMng.Config.FileName + "...";
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
        }

        public void CallDownload()
        {
            this.Show();
            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

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
                        MessageBox.Show(res_man.GetString("AboutForm_DownloadUpdate_ServerDown", cul), "Moto_Boot_Logo_Maker - file updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        labelInformation.Text = res_man.GetString("ToolDownloadsForm_Label_Download", cul) + " " + oConfigMng.Config.FileName + "...";
                        this.Text = labelInformation.Text;
                        sw.Start();
                        webClient.DownloadFileAsync(URL, location);
                    }
                }
                else
                {
                    DialogResult answer = MessageBox.Show(res_man.GetString("ToolDownloadsForm_Label_Download_Retry", cul),
                    res_man.GetString("ToolDownloadsForm_Label_Download_Retry_Title", cul), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                DialogResult answer = MessageBox.Show(res_man.GetString("ToolDownloadsForm_Label_Download_Uknown_Error", cul),
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
            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            webClient.CancelAsync();
            webClient.Dispose();
            try
            {
                long length = new FileInfo(exePath + @"\Files\" + oConfigMng.Config.FileName).Length;
                string vIn = oConfigMng.Config.FileSize;
                long vOut = Convert.ToInt64(vIn);

                if (length != vOut)
                {
                    MessageBox.Show(oConfigMng.Config.FileName + " " + res_man.GetString("ToolDownloadsForm_File_Corrupt", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CallDownload();
                    return;
                }
                else
                {
                    progressBar.Cursor = Cursors.Default;
                    labelInformation.Text = res_man.GetString("ToolDownloadsForm_File_Extract", cul) + " " + oConfigMng.Config.FileName + "...";
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
            catch (Exception ex)
            {
                sw.Stop();
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            return;
        }

        private void CheckFilesDownload_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            string closetool = "Moto_Boot_Logo_Maker";

            if (webClient != null && webClient.IsBusy == true)
            {
                DialogResult answer = MessageBox.Show(res_man.GetString("ToolDownloadsForm_Exit", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (answer)
                {
                    case DialogResult.Yes:
                        webClient.CancelAsync();
                        webClient.Dispose();
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
        }
    }
}