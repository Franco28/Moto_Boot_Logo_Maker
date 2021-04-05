/* 
#####################################################################
#    File: DeviceInfo.cs                                            #
#    Author: Franco28                                               # 
#    Date: 05-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Diagnostics;
using System.IO;
using DarkUI.Forms;

namespace Moto_Logo
{
    public partial class DeviceInfo : DarkForm
    {
        public DeviceInfo()
        {
            InitializeComponent();
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