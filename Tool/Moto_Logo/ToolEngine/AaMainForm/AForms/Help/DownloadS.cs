/* 
#####################################################################
#    File: DownloadS.cs                                             #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;
using DarkUI.Forms;
using System.Media;
using System.Resources;
using System.Globalization;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class DownloadS : DarkForm
    {
        public readonly CultureInfo cul = null;
        private ResourceManager res_man;

        public DownloadS()
        {
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.Text = res_man.GetString("DownloadSForm_Title", cul) + " - Moto_Boot_Logo_Maker";

            btnGoTo.Text = res_man.GetString("DownloadSForm_BTN_Text", cul) + " SourceForge";
            button1.Text = res_man.GetString("DownloadSForm_BTN_Text", cul) + " Android File Host";
        }

        private void Download_Load(object sender, EventArgs e)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData", cul);
                startProgressAsync();
            }
            else
            {
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Error", cul);
                return;
            }
        }

        protected void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText(string.Format("\n" + message));
                console.ScrollToCaret();
            });
        }

        public void LoadSFS()
        {
            try
            {
                cAppend(" SourceForge ");
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". SourceForge";
                var html = @"https://sourceforge.net/projects/motobootlogomaker/files/SETUP/";
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);

                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . SourceForge";
                HtmlNode nodeDownloadTotal = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='files_list']/tfoot/tr/td[4]/a");
                var dt = Regex.Replace(nodeDownloadTotal.InnerText, @"(\d)(\p{L})", "$1 $2");
                cAppend(" Moto_Boot_Logo_Maker: " + dt.ToString());

                var htmlP = @"https://sourceforge.net/projects/motobootlogomaker/files/PORTABLE/";
                HtmlWeb webP = new HtmlWeb();
                var htmlDocP = webP.Load(htmlP);
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . . SourceForge";
                HtmlNode nodeDownloadTotalP = htmlDocP.DocumentNode.SelectSingleNode("//*[@id='files_list']/tfoot/tr/td[4]/a");
                var dtP = Regex.Replace(nodeDownloadTotalP.InnerText, @"(\d)(\p{L})", "$1 $2");
                cAppend(" Moto_Boot_Logo_Maker PORTABLE: " + dtP.ToString());
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . . SourceForge";

                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + " SourceForge. " + res_man.GetString("DownloadSForm_GettingServerData_Done", cul);
            }
            catch (Exception)
            {
                cAppend(" ");
                cAppend(res_man.GetString("DownloadSForm_GettingServerData_Error_SF", cul));
                SystemSounds.Hand.Play();
            }
        }

        public void LoadAFH()
        {
            try
            {
                cAppend(" Android File Host ");
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . . Android File Host";
                var html = @"https://www.androidfilehost.com/?w=files&flid=323184";
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);

                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . Android File Host";
                HtmlNode nodeDownloadTotal = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='wrapper']/div[2]/div[2]/div[1]/ul/li[2]/div[1]/div[2]/div[1]/span");
                var dt = Regex.Replace(nodeDownloadTotal.InnerText, @"(\d)(\p{L})", "$1 $2");
                cAppend(" Moto_Boot_Logo_Maker: " + dt.ToString());

                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". Android File Host";
                HtmlNode nodeDownloadTotalP = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='wrapper']/div[2]/div[2]/div[1]/ul/li[2]/div[1]/div[2]/div[1]/span");
                var dtP = Regex.Replace(nodeDownloadTotalP.InnerText, @"(\d)(\p{L})", "$1 $2");
                cAppend(" Moto_Boot_Logo_Maker PORTABLE: " + dtP.ToString());
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . . Android File Host. " + res_man.GetString("DownloadSForm_GettingServerData_Done", cul);
            }
            catch (Exception)
            {
                cAppend(" ");
                cAppend(res_man.GetString("DownloadSForm_GettingServerData_Error_FH", cul));
                SystemSounds.Hand.Play();
            }          
        }

        public void GetData(IProgress<int> progress)
        {
            Thread.Sleep(100);
            labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". ";
            if (InternetCheck.ConnectToInternet() == true)
            {
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . ";
                InternetCheck.CheckPageIsAliveAsync("https://sourceforge.net/projects/motobootlogomaker/files/");
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . . ";
                InternetCheck.CheckPageIsAliveAsync("https://www.androidfilehost.com/?w=files&flid=323184");
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". ";
                LoadSFS();
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . ";
                cAppend(" ");
                LoadAFH();
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Text", cul) + ". . . ";
            }
            else
            {
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData_Error_Uknown", cul);
                cAppend(res_man.GetString("DownloadSForm_InternetError", cul));
                btnGoTo.Enabled = false;
                button1.Enabled = false;
                return;
            }
        }

        private async void startProgressAsync()
        {
            var progress = new Progress<int>(percent =>
            {
                labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData", cul) + " " + percent;
            });

            await Task.Run(() => GetData(progress));
            labelGetting.Text = res_man.GetString("DownloadSForm_GettingServerData", cul) + res_man.GetString("DownloadSForm_GettingServerData_Done", cul);
            labelGetting.Visible = false;
            console.Dock = DockStyle.Fill;
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            InternetCheck.CheckInternetProcessStart("https://sourceforge.net/projects/motobootlogomaker/files/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InternetCheck.CheckInternetProcessStart("https://www.androidfilehost.com/?w=files&flid=323184");
        }

        private void DownloadS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;   
        }
    }
}