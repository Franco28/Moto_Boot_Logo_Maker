/* 
#####################################################################
#    File: Credits.cs                                               #
#    Author: Franco28                                               # 
#    Date: 18-02-2021                                               #
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
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class Credits : Form
    {
        string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public Credits()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Theme == "light")
            {
                console.BackColor = BackColor = Color.FromArgb(255, 255, 255);
                console.ForeColor = ForeColor = Color.FromArgb(0, 0, 0);

                foreach (Label label in Controls.OfType<Label>())
                {
                    label.BackColor = Color.FromArgb(255, 255, 255);
                    label.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }
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
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString(), "Read credits", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logs.DebugErrorLogs(er);
                    return;
                }
            }
            else
            {
                cAppend("Can´t read credits... file is missing!");
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}