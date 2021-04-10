/* 
#####################################################################
#    File: ReadChangelog.cs                                         #
#    Author: Franco28                                               # 
#    Date: 10-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using DarkUI.Forms;

namespace Moto_Logo
{
    public partial class ReadChangelog : DarkForm
    {
        private CultureInfo cul;
        private ResourceManager res_man;

        public ReadChangelog()
        {
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.Text = "Changelog v" + Application.ProductVersion + " build: " + Utils.GetLinkerDateTime(Assembly.GetEntryAssembly(), null).ToString();
        }

        private void ReadChangelog_Load(object sender, EventArgs e)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/Franco28/Moto_Boot_Logo_Maker/master/Tool/Setup/changelog.txt");
                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    var strContent = reader.ReadToEnd();
                    richTextBox1.Text = strContent.ToString();
                }
            }
            else
            {
                richTextBox1.Text = res_man.GetString("ChangelogFormError", cul);
                return;
            }
        }
    }
}
