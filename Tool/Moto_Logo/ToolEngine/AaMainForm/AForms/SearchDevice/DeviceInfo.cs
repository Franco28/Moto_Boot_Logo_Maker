/* 
#####################################################################
#    File: DeviceInfo.cs                                            #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using DarkUI.Forms;

namespace Moto_Logo
{
    public partial class DeviceInfo : DarkForm
    {
        public readonly CultureInfo cul = null;
        private ResourceManager res_man;

        public DeviceInfo()
        {
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            LabelDeviceTitle.Text = res_man.GetString("DeviceInfoForm_LabelDeviceTitle", cul);
            LabelDisplayTitle.Text = res_man.GetString("DeviceInfoForm_LabelDisplayTitle", cul);
            LabelLogoInfoTitle.Text = res_man.GetString("DeviceInfoForm_LabelLogoInfoTitle", cul);
            label1.Text = res_man.GetString("DeviceInfoForm_LabelPath", cul);
            labelDName.Text = res_man.GetString("DeviceInfoForm_LabelName", cul);
            labelCodeName.Text = res_man.GetString("DeviceInfoForm_LabelCodeName", cul);
            labelResolution.Text = res_man.GetString("DeviceInfoForm_LabelResolution", cul);
            labelLMemory.Text = res_man.GetString("DeviceInfoForm_LabelMemory", cul);
            labelLogoSize.Text = res_man.GetString("DeviceInfoForm_LabelLogoSize", cul);
            labelLogoCreateDate.Text = res_man.GetString("DeviceInfoForm_LabelLogoCreateDate", cul);
            labelLogoModifyDate.Text = res_man.GetString("DeviceInfoForm_LabelLogoModifyDate", cul);
            labelLogoComment.Text = res_man.GetString("DeviceInfoForm_LabelLogoComment", cul);
            labelbtnOpenLogoFile.Text = res_man.GetString("DeviceInfoForm_LabelOpenLogo", cul);
            labelbtnOpenLogoFile2.Text = res_man.GetString("DeviceInfoForm_LabelOpenLogo2", cul);
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