/* 
#####################################################################
#    File: MainForm.Translations.cs                                 #
#    Author: Franco28                                               # 
#    Date: 20-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Globalization;

namespace Moto_Logo
{
    public partial class MainForm
    {
        public void CreateCulture(string lang)
        {
            if (ci.Name.Contains(lang))
            {
                Properties.Settings.Default.ToolLang = ci.Name.ToString();
                cul = CultureInfo.CreateSpecificCulture(lang);
                Properties.Settings.Default.Save();
            }
        }

        public void Translations()
        {
            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            if (ci.Name.Contains("en") || 
                ci.Name.Contains("es") || 
                ci.Name.Contains("pt") || 
                ci.Name.Contains("it") || 
                ci.Name.Contains("fr") || 
                ci.Name.Contains("pl") ||
                ci.Name.Contains("ru") || 
                ci.Name.Contains("ga") || 
                ci.Name.Contains("de") ||
                ci.Name.Contains("tr") ||
                ci.Name.Contains("ja") || 
                ci.Name.Contains("zh-Hans") ||
                ci.Name.Contains("zh-Hant") ||
                ci.Name.Contains("zh-CN"))
            {
                CreateCulture(ci.Name.ToString());
            }
            else
            {
                CreateCulture("en");
            }

            fileToolStripMenuItem.Text = res_man.GetString("fileToolStripMenuItem", cul);
            newToolStripMenuItem.Text = res_man.GetString("newToolStripMenuItem", cul);
            openToolStripMenuItem.Text = res_man.GetString("openToolStripMenuItem", cul);
            checkForUpdatesToolStripMenuItem.Text = res_man.GetString("checkForUpdatesToolStripMenuItem", cul);
            sourceToolStripMenuItem.Text = res_man.GetString("sourceToolStripMenuItem", cul);
            aboutToolStripMenuItem.Text = res_man.GetString("aboutToolStripMenuItem1", cul);
            aboutToolStripMenuItem.Text = res_man.GetString("aboutToolStripMenuItem1", cul);
            helpToolStripMenuItem.Text = res_man.GetString("helpToolStripMenuItem", cul);
            downloadSiteToolStripMenuItem.Text = res_man.GetString("downloadSiteToolStripMenuItem", cul);
            groupBoxLogoFormat.Text = res_man.GetString("groupBox2", cul);
            groupBoxLogoResolution.Text = res_man.GetString("groupBox3", cul);
            groupBoxLogoImageOption.Text = res_man.GetString("groupBox4", cul);
            groupBoxLogoImageOrientation.Text = res_man.GetString("groupBox5", cul);
            groupBoxLogoMemory.Text = res_man.GetString("groupBox6", cul);
            groupBoxLogoExtension.Text = res_man.GetString("groupBox7", cul);
            labelLogoName.Text = res_man.GetString("LogoName", cul);
            buttonAppend.Text = res_man.GetString("button1", cul);
            buttonDelete.Text = res_man.GetString("button2", cul);
            buttonExtract.Text = res_man.GetString("button3", cul);
            rdoAndroid44.Text = res_man.GetString("rdoAndroid44", cul);
            rdoAndroid43.Text = res_man.GetString("rdoAndroid43", cul);
            rdoLayoutPortrait.Text = res_man.GetString("rdoLayoutPortrait", cul);
            rdoLayoutLandscape.Text = res_man.GetString("rdoLayoutLandscape", cul);
            rdoImageCenter.Text = res_man.GetString("rdoImageCenter", cul);
            rdoImageStretchAspect.Text = res_man.GetString("rdoImageStretchAspect", cul);
            rdoImageFill.Text = res_man.GetString("rdoImageFill", cul);
            settingsToolStripMenuItem.Text = res_man.GetString("settingsToolStripMenuItem", cul);
            labelBuildPath.Text = res_man.GetString("labelBuildPath", cul);
            labelbtnBuild.Text = res_man.GetString("btnBuild", cul);
            labelbtnStop.Text = res_man.GetString("btnStop", cul);
            labelbtnOpenLogoFile.Text = res_man.GetString("btnOpenLogoFile", cul);
            labelSearchDevice.Text = res_man.GetString("labelSearchDevice", cul);
            labelReload.Text = res_man.GetString("labelReloadTool", cul);
            btnBuild.ToolTipText = res_man.GetString("btnBuildToolTipText", cul);
            btnStop.ToolTipText = res_man.GetString("btnStopToolTipText", cul);
            btnAttachPath.ToolTipText = res_man.GetString("btnAttachPathToolTipText", cul);
            btnOpenLogoFile.ToolTipText = res_man.GetString("btnOpenLogoFileToolTipText", cul);
            btnReload.ToolTipText = res_man.GetString("btnReloadToolTipText", cul);
            labelGoToError.ToolTipText = res_man.GetString("labelGoToErrorToolTipText", cul);
            textBoxSearchDevice.ToolTipText = res_man.GetString("textBoxSearchDeviceToolTipText", cul);
            btnSearchDevice.ToolTipText = res_man.GetString("btnSearchDeviceToolTipText", cul);
            toolStripMenuItemOpenCustomLogo.Text = res_man.GetString("toolStripMenuItemOpenCustomLogo", cul);
            toolToolStripMenuItem.Text = res_man.GetString("toolToolStripMenuItem", cul);
            labelErrorGoToFileInfo.Text = res_man.GetString("labelErrorGoToFileInfo", cul);
        }
    }
}