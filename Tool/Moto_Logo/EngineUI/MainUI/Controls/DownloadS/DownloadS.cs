/* 
#####################################################################
#    File: DownloadS.cs                                             #
#    Author: Franco28                                               # 
#    Date: 04-04-2021                                               #
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
            cAppend(" SourceForge ");
            var html = @"https://sourceforge.net/projects/motobootlogomaker/files/stats/timeline";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);

            HtmlNode nodeDownloadTotal = htmlDoc.DocumentNode.SelectSingleNode("//ul[@class='sidebarmenu']//li[1]");
            HtmlNode nodeCountryStats = htmlDoc.DocumentNode.SelectSingleNode("//ul[@class='sidebarmenu']//li[2]");
            HtmlNode nodeOSStats = htmlDoc.DocumentNode.SelectSingleNode("//ul[@class='sidebarmenu']//li[3]");

            var dt = Regex.Replace(nodeDownloadTotal.InnerText, @"\s+", " ");
            var cs = Regex.Replace(nodeCountryStats.InnerText, @"\s+", " ");
            var oss = Regex.Replace(nodeOSStats.InnerText, @"\s+", " ");

            cAppend(" Total " + dt);
            cAppend(cs);
            cAppend(oss);
        }

        public void LoadAFH()
        {
            cAppend(" Android File Host ");
            var html = @"https://www.androidfilehost.com/?w=files&flid=323184";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);

            HtmlNode nodeDownloadTotal = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[2]/div[2]/div[2]/div[1]/ul/li/div[1]/div[2]/div[1]/span");
            var dt = Regex.Replace(nodeDownloadTotal.InnerText, @"(\d)(\p{L})", "$1 $2");
            cAppend(" Moto_Boot_Logo_Maker: " + dt.ToString());
        }

        private void Download_Load(object sender, EventArgs e)
        {
            try
            {
                if (InternetCheck.ConnectToInternet() == true)
                {
                    LoadSFS();
                    cAppend(" ");
                    LoadAFH();
                }
                else
                {
                    cAppend(res_man.GetString("DownloadSFormInternetError", cul));
                    btnGoTo.Enabled = false;
                    button1.Enabled = false;
                    return;
                }
            }
            catch (Exception er)
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(er.Message, er.Source);
            }
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            InternetCheck.CheckInternetProcessStart("https://sourceforge.net/projects/motobootlogomaker/files/");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InternetCheck.CheckInternetProcessStart("https://www.androidfilehost.com/?w=files&flid=323184");
            this.Close();
        }
    }
}