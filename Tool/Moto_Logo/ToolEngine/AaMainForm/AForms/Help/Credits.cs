/* 
#####################################################################
#    File: Credits.cs                                               #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
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
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using DarkUI.Forms;

namespace Moto_Logo
{
    public partial class Credits : DarkForm
    {
        string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public readonly CultureInfo cul = null;
        private ResourceManager res_man;

        public Credits()
        {
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.Text = res_man.GetString("CreditsForm_Title", cul);
        }

        public void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText("\n" + message);
                console.ScrollToCaret();
            });
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            if (File.Exists(exePath + @"\credits.txt"))
            {
                try
                {
                    StreamReader sr = new StreamReader(exePath + @"\credits.txt");
                    cAppend(sr.ReadToEnd());
                    sr.Close();
                    sr.Dispose();
                }
                catch (Exception ex)
                {
                    Logs.DebugErrorLogs(ex);
                    MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                cAppend(res_man.GetString("CreditsForm_Error", cul));
                return;
            }
        }
    }
}