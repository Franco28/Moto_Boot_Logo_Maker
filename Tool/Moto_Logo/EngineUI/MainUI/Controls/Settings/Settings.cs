/* 
#####################################################################
#    File: Settings.cs                                              #
#    Author: Franco28                                               # 
#    Date: 20-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using DarkUI.Forms;

namespace Moto_Logo
{
    public partial class ToolSettings : DarkForm
    {
        public CultureInfo cul;
        public ResourceManager res_man;
        public CultureInfo ci = CultureInfo.InstalledUICulture;
        string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public ToolSettings()
        {         
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.Text = res_man.GetString("settingsToolStripMenuItem", cul);  
            groupBoxEASP.Text = res_man.GetString("SettingsGroupBox1", cul);
            groupBoxEASLIM.Text = res_man.GetString("SettingsGroupBox2", cul);
            groupBoxEU.Text = res_man.GetString("SettingsGroupBox3", cul);
            radioButtonYESUpdates.Text = radioButtonYESLogo.Text = radioButtonYES.Text = res_man.GetString("SettingsYes", cul);
            radioButtonNOUpdates.Text = radioButtonNO.Text = radioButtonNOLogo.Text = res_man.GetString("SettingsNo", cul);
            buttonRTP.Text = res_man.GetString("materialButtonResetAllProfiles", cul);
            buttonRTS.Text = res_man.GetString("materialButtonResetToolSettings", cul);
            labelResetTool.Text = res_man.GetString("SettingRT", cul);
            labelGeneralSettings.Text = res_man.GetString("SettingGS", cul);
            buttonOpenToolFolder.Text = res_man.GetString("SettingsbuttonOpenToolFolder", cul);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            groupBoxEU.Enabled = false;
            label4.Enabled = false;

            if (Properties.Settings.Default.SaveProfiles == true)
            {
                radioButtonYES.PerformClick();
            }
            if (Properties.Settings.Default.SaveProfiles == false)
            {
                radioButtonNO.PerformClick();
            }
            if (Properties.Settings.Default.LogoBinOpenSave == false)
            {
                radioButtonNOLogo.PerformClick();
            }
            if (Properties.Settings.Default.LogoBinOpenSave == true)
            {
                radioButtonYESLogo.PerformClick();
            }

            if (exePath != @"C:\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files (x86)\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files\Moto_Boot_Logo_Maker")
            {
                this.Text = res_man.GetString("settingsToolStripMenuItem", cul) + " - PORTABLE";

                groupBoxEU.Enabled = false;
                label4.Enabled = false;
                radioButtonYESUpdates.Checked = false;
                radioButtonNOUpdates.Checked = false;
            }
            else
            {
                groupBoxEU.Enabled = true;
                label4.Enabled = true;
                if (Properties.Settings.Default.Updates == true)
                {
                    radioButtonYESUpdates.PerformClick();
                }
                if (Properties.Settings.Default.Updates == false)
                {
                    radioButtonNOUpdates.PerformClick();
                }
            }
        }

        private void radioButtonYES_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveProfiles = true;
            Properties.Settings.Default.Save();
        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveProfiles = false;
            Properties.Settings.Default.Save();
        }

        private void radioButtonNOLogo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogoBinOpenSave = false;
            Properties.Settings.Default.Save();
        }

        private void radioButtonYESLogo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogoBinOpenSave = true;
            Properties.Settings.Default.Save();
        }

        private void radioButtonYESUpdates_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Updates = true;
            Properties.Settings.Default.Save();
        }

        private void radioButtonNOUpdates_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Updates = false;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Profiles.Default.Reset();
            this.Hide();
            var mainf = new MainForm();
            mainf.RestartApp();
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            Properties.Settings.Default.Reset();
            this.Hide();
            var mainf = new MainForm();
            mainf.RestartApp();
        }

        private void btngotosettingslogs_Click(object sender, EventArgs e)
        {
            //var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            //var newpath = path.Replace(@"\user.config", "").Trim();
            Process.Start(exePath);
            this.Close();
        }

        private void ToolSettings_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}