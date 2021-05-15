/* 
#####################################################################
#    File: DownloadS.cs                                             #
#    Author: Franco28                                               # 
#    Date: 14-05-2021                                               #
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
        }

        private void Download_Load(object sender, EventArgs e)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                labelGetting.Text = "Getting server data... Please wait... ";
                startProgressAsync();
            }
            else
            {
                labelGetting.Text = "Getting server data... {ERROR} No internet connection...";
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
                labelGetting.Text = "Getting server data. SourceForge";
                var html = @"https://sourceforge.net/projects/motobootlogomaker/files/SETUP/";
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);

                labelGetting.Text = "Getting server data. . SourceForge";
                HtmlNode nodeDownloadTotal = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='files_list']/tfoot/tr/td[4]/a");
                var dt = Regex.Replace(nodeDownloadTotal.InnerText, @"(\d)(\p{L})", "$1 $2");
                cAppend(" Moto_Boot_Logo_Maker: " + dt.ToString());

                var htmlP = @"https://sourceforge.net/projects/motobootlogomaker/files/PORTABLE/";
                HtmlWeb webP = new HtmlWeb();
                var htmlDocP = webP.Load(htmlP);
                labelGetting.Text = "Getting server data. . . SourceForge";
                HtmlNode nodeDownloadTotalP = htmlDocP.DocumentNode.SelectSingleNode("//*[@id='files_list']/tfoot/tr/td[4]/a");
                var dtP = Regex.Replace(nodeDownloadTotalP.InnerText, @"(\d)(\p{L})", "$1 $2");
                cAppend(" Moto_Boot_Logo_Maker PORTABLE: " + dtP.ToString());
                labelGetting.Text = "Getting server data. . . SourceForge. Done!";
            }
            catch (Exception)
            {
                cAppend(" ");
                cAppend("Error getting server data from SourceForge, retry later...");
                SystemSounds.Hand.Play();
            }
        }

        public void LoadAFH()
        {
            try
            {
                cAppend(" Android File Host ");
                labelGetting.Text = "Getting server data. . . Android File Host";
                var html = @"https://www.androidfilehost.com/?w=files&flid=323184";
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);

                labelGetting.Text = "Getting server data. . Android File Host";
                HtmlNode nodeDownloadTotal = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='wrapper']/div[2]/div[2]/div[1]/ul/li[2]/div[1]/div[2]/div[1]/span");
                var dt = Regex.Replace(nodeDownloadTotal.InnerText, @"(\d)(\p{L})", "$1 $2");
                cAppend(" Moto_Boot_Logo_Maker: " + dt.ToString());

                labelGetting.Text = "Getting server data. Android File Host";
                HtmlNode nodeDownloadTotalP = htmlDoc.DocumentNode.SelectSingleNode("//*[@id='wrapper']/div[2]/div[2]/div[1]/ul/li[2]/div[1]/div[2]/div[1]/span");
                var dtP = Regex.Replace(nodeDownloadTotalP.InnerText, @"(\d)(\p{L})", "$1 $2");
                cAppend(" Moto_Boot_Logo_Maker PORTABLE: " + dtP.ToString());
                labelGetting.Text = "Getting server data. . . Android File Host. Done!";
            }
            catch (Exception)
            {
                cAppend(" ");
                cAppend("Error getting server data from Android File Host, retry later...");
                SystemSounds.Hand.Play();
            }          
        }

        public void GetData(IProgress<int> progress)
        {
            Thread.Sleep(100);
            labelGetting.Text = "Getting server data. ";
            if (InternetCheck.ConnectToInternet() == true)
            {
                labelGetting.Text = "Getting server data. . ";
                InternetCheck.CheckPageIsAliveAsync("https://sourceforge.net/projects/motobootlogomaker/files/");
                labelGetting.Text = "Getting server data. . . ";
                InternetCheck.CheckPageIsAliveAsync("https://www.androidfilehost.com/?w=files&flid=323184");
                labelGetting.Text = "Getting server data. ";
                LoadSFS();
                labelGetting.Text = "Getting server data. . ";
                cAppend(" ");
                LoadAFH();
                labelGetting.Text = "Getting server data. . . ";
            }
            else
            {
                labelGetting.Text = "Getting server data... ERROR ";
                cAppend(res_man.GetString("DownloadSFormInternetError", cul));
                btnGoTo.Enabled = false;
                button1.Enabled = false;
                return;
            }
        }

        private async void startProgressAsync()
        {
            var progress = new Progress<int>(percent =>
            {
                labelGetting.Text = "Getting server data... Please wait... " + percent;
            });

            await Task.Run(() => GetData(progress));
            labelGetting.Text = "Getting server data... DONE! " ;
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