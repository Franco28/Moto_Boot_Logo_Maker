/* 
#####################################################################
#    File: MainForm.LogoMemory.cs                                   #
#    Author: Franco28                                               # 
#    Date: 31-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;

namespace Moto_Logo
{
    public partial class MainForm
    {
        #region LogoSettings
        private void radioButton4mib_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4mib.Checked == true)
            {
                LogoMaxMIB(4194304, " 4MB");
                Properties.Profiles.Default.LogoMemory4MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory4MB = false;
            }
            Properties.Profiles.Default.Save();
        }

        private void radioButton6MIB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6MIB.Checked == true)
            {
                LogoMaxMIB(6291456, " 6MB");
                Properties.Profiles.Default.LogoMemory6MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory6MB = false;
            }
            Properties.Profiles.Default.Save();
        }

        private void radioButton8MIB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8MIB.Checked == true)
            {
                LogoMaxMIB(8388608, " 8MB");
                Properties.Profiles.Default.LogoMemory8MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory8MB = false;
            }
            Properties.Profiles.Default.Save();
        }

        private void radioButton16MIB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16MIB.Checked == true)
            {
                LogoMaxMIB(16777216, " 16MB");
                Properties.Profiles.Default.LogoMemory16MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory16MB = false;
            }
            Properties.Profiles.Default.Save();
        }

        private void radioButton32MIB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32MIB.Checked == true)
            {
                LogoMaxMIB(34226176, " 32MB");
                Properties.Profiles.Default.LogoMemory32MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory32MB = false;
            }
            Properties.Profiles.Default.Save();
        }
        #endregion LogoSettings
    }
}