/* 
#####################################################################
#    File: BootLogoChannels.cs                                      #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class BootLogoChannels : Form
    {
        public CultureInfo cul;
        public ResourceManager res_man;

        public BootLogoChannels()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Theme == "light")
            {
                LighTheme();
            }
            if (Properties.Settings.Default.Theme == "dark")
            {
                DarkTheme();
            }
        }

        public void DarkTheme()
        {
            webBrowser1.BackColor = Color.FromArgb(38, 38, 38);
            webBrowser1.ForeColor = Color.FromArgb(250, 232, 232);

        }

        public void LighTheme()
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.ForeColor = Color.FromArgb(0, 0, 0);

            webBrowser1.BackColor = Color.FromArgb(255, 255, 255);
            webBrowser1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BootLogoChannels_Load(object sender, System.EventArgs e)
        {

        }
    }
}
