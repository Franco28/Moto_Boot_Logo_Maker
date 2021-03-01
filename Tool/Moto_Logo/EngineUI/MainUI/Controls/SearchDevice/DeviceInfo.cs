/* 
#####################################################################
#    File: DeviceInfo.cs                                            #
#    Author: Franco28                                               # 
#    Date: 01-03-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class DeviceInfo : Form
    {
        public DeviceInfo()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Theme == "light")
            {
                pictureBoxDevice.BackColor = BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);

                foreach (Label label in Controls.OfType<Label>())
                {
                    label.BackColor = Color.FromArgb(255, 255, 255);
                    label.ForeColor = Color.FromArgb(0, 0, 0);
                }

                label5.ForeColor = labelBuildPath.ForeColor = label3.ForeColor = Color.Gold;
            }
        }

        private void btnOpenLogoFile_Click(object sender, System.EventArgs e)
        {
            string dirname = Path.GetDirectoryName(labelLogoPath.Text);
            Process.Start(dirname);            
        }

        private void btnOpenLogoFile2_Click(object sender, System.EventArgs e)
        {
            string dirname = Path.GetDirectoryName(labelLogoPath2.Text);
            Process.Start(dirname);
        }

        private void DeviceInfo_Load(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelLogoPath2.Text))
            {
                labelbtnOpenLogoFile2.Show();
                btnOpenLogoFile2.Show();
            }
            else
            {
                labelbtnOpenLogoFile2.Hide();
                btnOpenLogoFile2.Hide();
            }
        }
    }
}