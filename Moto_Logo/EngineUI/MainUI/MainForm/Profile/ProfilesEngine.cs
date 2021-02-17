/* 
#####################################################################
#    File: MainForm.ProfilesEngine.cs                               #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

namespace Moto_Logo
{
    public partial class MainForm
    {
        public void LoadProfiles()
        {
            textLogoName.Text = Properties.Profiles.Default.LogoName;
            txtLogoBuildPath.Text = Properties.Profiles.Default.LogoPath;
            if (Properties.Profiles.Default.LogoExtensionBIN == true)
            {
                radioButtonBIN.PerformClick();
            }
            if (Properties.Profiles.Default.LogoExtensionZIP == true)
            {
                radioButtonZIP.PerformClick();
            }
            if (Properties.Profiles.Default.LogoMemory4MB == true)
            {
                radioButton4mib.PerformClick();
            }
            if (Properties.Profiles.Default.LogoMemory6MB == true)
            {
                radioButton6MIB.PerformClick();
            }
            if (Properties.Profiles.Default.LogoMemory8MB == true)
            {
                radioButton8MIB.PerformClick();
            }
            if (Properties.Profiles.Default.LogoMemory16MB == true)
            {
                radioButton16MIB.PerformClick();
            }
            if (Properties.Profiles.Default.LogoMemory32MB == true)
            {
                radioButton32MIB.PerformClick();
            }
            if (Properties.Profiles.Default.LogoImageCenter == true)
            {
                rdoImageCenter.PerformClick();
            }
            if (Properties.Profiles.Default.LogoImageFill == true)
            {
                rdoImageFill.PerformClick();
            }
            if (Properties.Profiles.Default.LogoImageStrech == true)
            {
                rdoImageStretchAspect.PerformClick();
            }
            if (Properties.Profiles.Default.LogoImagePortrait == true)
            {
                rdoLayoutPortrait.PerformClick();
            }
            if (Properties.Profiles.Default.LogoImageLandscape == true)
            {
                rdoLayoutLandscape.PerformClick();
            }
            if (Properties.Profiles.Default.LogoBinFormatDefault == true)
            {
                rdoAndroid44.PerformClick();
            }
            if (Properties.Profiles.Default.LogoBinFormatBundle == true)
            {
                rdoAndroid43.PerformClick();
            }
            if (Properties.Profiles.Default.LogoBinFormatRaw == true)
            {
                rdoAndroidRAW.PerformClick();
            }
        }

        public void SaveProfiles()
        {
            Properties.Profiles.Default.LogoName = textLogoName.Text;
            Properties.Profiles.Default.LogoPath = txtLogoBuildPath.Text;
            if (radioButtonBIN.Checked == true)
            {
                Properties.Profiles.Default.LogoExtensionBIN = true;
            }
            else
            {
                Properties.Profiles.Default.LogoExtensionBIN = false;
            }
            if (radioButtonZIP.Checked == true)
            {
                Properties.Profiles.Default.LogoExtensionZIP = true;
            }
            else
            {
                Properties.Profiles.Default.LogoExtensionZIP = false;
            }
            if (radioButton4mib.Checked == true)
            {
                Properties.Profiles.Default.LogoMemory4MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory4MB = false;
            }
            if (radioButton8MIB.Checked == true)
            {
                Properties.Profiles.Default.LogoMemory8MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory8MB = false;
            }
            if (radioButton16MIB.Checked == true)
            {
                Properties.Profiles.Default.LogoMemory16MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory16MB = false;
            }
            if (radioButton32MIB.Checked == true)
            {
                Properties.Profiles.Default.LogoMemory32MB = true;
            }
            else
            {
                Properties.Profiles.Default.LogoMemory32MB = false;
            }
            if (rdoImageCenter.Checked == true)
            {
                Properties.Profiles.Default.LogoImageCenter = true;
            }
            else
            {
                Properties.Profiles.Default.LogoImageCenter = false;
            }
            if (rdoImageStretchAspect.Checked == true)
            {
                Properties.Profiles.Default.LogoImageStrech = true;
            }
            else
            {
                Properties.Profiles.Default.LogoImageStrech = false;
            }
            if (rdoImageFill.Checked == true)
            {
                Properties.Profiles.Default.LogoImageFill = true;
            }
            else
            {
                Properties.Profiles.Default.LogoImageFill = false;
            }
            if (rdoLayoutPortrait.Checked == true)
            {
                Properties.Profiles.Default.LogoImagePortrait = true;
            }
            else
            {
                Properties.Profiles.Default.LogoImagePortrait = false;
            }
            if (rdoLayoutLandscape.Checked == true)
            {
                Properties.Profiles.Default.LogoImageLandscape = true;
            }
            else
            {
                Properties.Profiles.Default.LogoImageLandscape = false;
            }
            if (rdoAndroid44.Checked == true)
            {
                Properties.Profiles.Default.LogoBinFormatDefault = true;
            }
            else
            {
                Properties.Profiles.Default.LogoBinFormatDefault = false;
            }
            if (rdoAndroid43.Checked == true)
            {
                Properties.Profiles.Default.LogoBinFormatBundle = true;
            }
            else
            {
                Properties.Profiles.Default.LogoBinFormatBundle = false;
            }
            if (rdoAndroidRAW.Checked == true)
            {
                Properties.Profiles.Default.LogoBinFormatRaw = true;
            }
            else
            {
                Properties.Profiles.Default.LogoBinFormatRaw = false;
            }
            Properties.Profiles.Default.Save();
        }
    }
}