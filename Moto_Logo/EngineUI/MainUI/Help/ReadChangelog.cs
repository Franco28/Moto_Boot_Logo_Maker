/* 
#####################################################################
#    File: ReadChangelog.cs                                         #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class ReadChangelog : Form
    {
        public ReadChangelog()
        {
            InitializeComponent();
            this.Text = "Changelog v" + Application.ProductVersion + " build: " + Utils.GetLinkerDateTime(Assembly.GetEntryAssembly(), null).ToString();
            if (Properties.Settings.Default.Theme == "light")
            {
                Light();
            }
        }

        public void Light()
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.ForeColor = Color.FromArgb(38, 38, 38);
            richTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            richTextBox1.ForeColor = Color.FromArgb(38, 38, 38);
        }

        private void ReadChangelog_Load(object sender, EventArgs e)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/Franco28/MotoBootLogoMaker/master/Windows/OTAS/changelog.txt");
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
                richTextBox1.Text = "Can't read changelog, please check your internet connection!";
                return;
            }
        }
    }
}
