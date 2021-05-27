/* 
#####################################################################
#    File: MainForm.Translations.cs                                 #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Globalization;
using System.Threading;

namespace Moto_Logo
{
    public partial class MainForm
    {
        public void CreateCulture(string lang)
        {
            Properties.Settings.Default.ToolLang = lang;

            cul = CultureInfo.CreateSpecificCulture(lang);

            NumberFormatInfo numberInfo = CultureInfo.CreateSpecificCulture(lang).NumberFormat;

            CultureInfo info = new CultureInfo(lang);
            info.NumberFormat = numberInfo;
            info.DateTimeFormat.DateSeparator = "/";
            info.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";

            CultureInfo ui_culture = new CultureInfo(lang);
            CultureInfo culture = new CultureInfo(lang);

            Thread.CurrentThread.CurrentUICulture = ui_culture;
            Thread.CurrentThread.CurrentCulture = culture;

            Properties.Settings.Default.Save();

            Translate();
        }

        public void Translate()
        {
            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            // Tool Strip Menu Item
            fileToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_file", cul);
            newToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_new", cul);
            openToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_open", cul);
            checkForUpdatesToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_checkForUpdates", cul);
            sourceToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_source", cul);
            aboutToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_about", cul);
            helpToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_help", cul);
            downloadSiteToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_downloadSite", cul);
            toolStripMenuItemOpenCustomLogo.Text = res_man.GetString("MainForm_ToolStripMenu_OpenCustomLogo", cul);
            toolToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_tool", cul);
            settingsToolStripMenuItem.Text = res_man.GetString("MainForm_ToolStripMenu_settings", cul);

            // Main TVLogo Buttons 
            darkSectionPanelMainBTNS.SectionHeader = res_man.GetString("MainForm_PanelMainBTNS", cul);
            buttonAppend.Text = res_man.GetString("MainForm_BTN_Append", cul);
            buttonDelete.Text = res_man.GetString("MainForm_BTN_Delete", cul);
            buttonExtract.Text = res_man.GetString("MainForm_BTN_Extract", cul);

            // GroupBox & RadioButtons
            groupBoxLogoFormat.Text = res_man.GetString("MainForm_GB_LogoFormat", cul);
            groupBoxLogoResolution.Text = res_man.GetString("MainForm_GB_LogoResolution", cul);
            groupBoxLogoImageOption.Text = res_man.GetString("MainForm_GB_LogoImageFillOptions", cul);
            groupBoxLogoImageOrientation.Text = res_man.GetString("MainForm_GB_LogoImageOrientationOptions", cul);
            groupBoxLogoMemory.Text = res_man.GetString("MainForm_GB_SelectLogoMemory", cul);
            groupBoxLogoExtension.Text = res_man.GetString("MainForm_GB_SelectExtension", cul);
            rdoAndroid44.Text = res_man.GetString("MainForm_RDO_rdoAndroid44", cul);
            rdoAndroid43.Text = res_man.GetString("MainForm_RDO_rdoAndroid43", cul);
            rdoLayoutPortrait.Text = res_man.GetString("MainForm_RDO_rdoLayoutPortrait", cul);
            rdoLayoutLandscape.Text = res_man.GetString("MainForm_RDO_rdoLayoutLandscape", cul);
            rdoImageCenter.Text = res_man.GetString("MainForm_RDO_rdoImageCenter", cul);
            rdoImageStretchAspect.Text = res_man.GetString("MainForm_RDO_rdoImageStretchAspect", cul);
            rdoImageFill.Text = res_man.GetString("MainForm_RDO_rdoImageFill", cul);

            // Main Labels and BTNS
            labelLogoName.Text = res_man.GetString("MainForm_Logo_Name", cul);
            labelBuildPath.Text = res_man.GetString("MainForm_label_BuildPath", cul);
            labelbtnBuild.Text = res_man.GetString("MainForm_BTN_Build", cul);
            labelbtnStop.Text = res_man.GetString("MainForm_BTN_Stop", cul);
            labelbtnOpenLogoFile.Text = res_man.GetString("MainForm_BTN_OpenLogoFile", cul);
            labelSearchDevice.Text = res_man.GetString("MainForm_label_SearchDevice", cul);
            labelReload.Text = res_man.GetString("MainForm_label_ReloadTool", cul);
            labelErrorGoToFileInfo.Text = res_man.GetString("MainForm_label_ErrorGoToFileInfo", cul);

            // Status Panel BTNS ToolTipText
            labelGoToError.ToolTipText = res_man.GetString("MainForm_label_GoToErrorToolTipText", cul);
            btnBuild.ToolTipText = res_man.GetString("MainForm_BTN_BuildToolTipText", cul);
            btnStop.ToolTipText = res_man.GetString("MainForm_BTN_StopToolTipText", cul);
            btnAttachPath.ToolTipText = res_man.GetString("MainForm_BTN_AttachPathToolTipText", cul);
            btnOpenLogoFile.ToolTipText = res_man.GetString("MainForm_BTN_OpenLogoFileToolTipText", cul);
            btnReload.ToolTipText = res_man.GetString("MainForm_BTN_ReloadToolTipText", cul);
            btnSearchDevice.ToolTipText = res_man.GetString("MainForm_BTN_SearchDeviceToolTipText", cul);
            textBoxSearchDevice.ToolTipText = res_man.GetString("MainForm_ToolTip_SearchDevice", cul);
        }

        public void Translations()
        {
            if (ci.Name == string.Empty)
            {
                CreateCulture("en");
                return;
            }

            if (ci.Name.Contains("en"))
            {
                CreateCulture(ci.Name.ToString());
                return;
            }
            else
            {
                CreateCulture("en");
                return;
            }
        }
    }
}