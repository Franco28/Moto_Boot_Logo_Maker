﻿/* 
#####################################################################
#    File: MainForm.Translations.cs                                 #
#    Author: Franco28                                               # 
#    Date: 06-01-2021                                               #
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

            labelimageInfoClick.Text = res_man.GetString("materialLabel10", cul);
            labelimageInfoDClick.Text = res_man.GetString("materialLabel11", cul);
            fileToolStripMenuItem.Text = res_man.GetString("fileToolStripMenuItem", cul);
            newToolStripMenuItem.Text = res_man.GetString("newToolStripMenuItem", cul);
            openToolStripMenuItem.Text = res_man.GetString("openToolStripMenuItem", cul);
            othersToolStripMenuItem.Text = res_man.GetString("othersToolStripMenuItem", cul);
            checkForUpdatesToolStripMenuItem.Text = res_man.GetString("checkForUpdatesToolStripMenuItem", cul);
            sourceToolStripMenuItem.Text = res_man.GetString("sourceToolStripMenuItem", cul);
            aboutToolStripMenuItem1.Text = res_man.GetString("aboutToolStripMenuItem1", cul);
            helpToolStripMenuItem.Text = res_man.GetString("helpToolStripMenuItem", cul);
            downloadSiteToolStripMenuItem.Text = res_man.GetString("downloadSiteToolStripMenuItem", cul);
            groupBoxLogoFormat.Text = res_man.GetString("groupBox2", cul);
            groupBoxLogoResolution.Text = res_man.GetString("groupBox3", cul);
            groupBoxLogoImageOption.Text = res_man.GetString("groupBox4", cul);
            groupBoxLogoImageOrientation.Text = res_man.GetString("groupBox5", cul);
            groupBoxLogoMemory.Text = res_man.GetString("groupBox6", cul);
            groupBoxLogoExtension.Text = res_man.GetString("groupBox7", cul);
            labelSignYourLogo.Text = res_man.GetString("SignYourLogo", cul);
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
            themetoolStripMenuItem.Text = res_man.GetString("themetoolStripMenuItem", cul);
            darktoolStripMenuItem.Text = res_man.GetString("darktoolStripMenuItem", cul);
            lighttoolStripMenuItem.Text = res_man.GetString("lighttoolStripMenuItem", cul);
            joinTelegramBootLogosToolStripMenuItem.Text = res_man.GetString("joinTelegramBootLogosToolStripMenuItem", cul);
            testToolStripMenuItem.Text = res_man.GetString("testToolStripMenuItem", cul);
            testYourNewLogoToolStripMenuItem.Text = res_man.GetString("testYourNewLogoToolStripMenuItem", cul);
            settingsToolStripMenuItem.Text = res_man.GetString("settingsToolStripMenuItem", cul);
            labelBuildPath.Text = res_man.GetString("labelBuildPath", cul);
            labelbtnBuild.Text = res_man.GetString("btnBuild", cul);
            labelbtnStop.Text = res_man.GetString("btnStop", cul);
            labelbtnOpenLogoFile.Text = res_man.GetString("btnOpenLogoFile", cul);
            labelSearchDevice.Text = res_man.GetString("labelSearchDevice", cul);
            labelReload.Text = res_man.GetString("labelReloadTool", cul);
        }
    }
}