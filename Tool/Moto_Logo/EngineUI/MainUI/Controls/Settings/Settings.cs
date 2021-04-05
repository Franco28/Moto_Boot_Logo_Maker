/* 
#####################################################################
#    File: Settings.cs                                              #
#    Author: Franco28                                               # 
#    Date: 05-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Media;
using System.Resources;
using System.Threading;
using DarkUI.Forms;

namespace Moto_Logo
{
    public partial class ToolSettings : DarkForm
    {
        public CultureInfo cul;
        public ResourceManager res_man;
        public CultureInfo ci = CultureInfo.InstalledUICulture;

        public ToolSettings()
        {         
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.Text = res_man.GetString("settingsToolStripMenuItem", cul);  
            groupBox1.Text = res_man.GetString("SettingsGroupBox1", cul);
            groupBox2.Text = res_man.GetString("SettingsGroupBox2", cul);
            groupBox3.Text = res_man.GetString("SettingsGroupBox3", cul);
            radioButtonYESUpdates.Text = radioButtonYESLogo.Text = radioButtonYES.Text = res_man.GetString("SettingsYes", cul);
            radioButtonNOUpdates.Text = radioButtonNO.Text = radioButtonNOLogo.Text = res_man.GetString("SettingsNo", cul);
            buttonRTP.Text = res_man.GetString("materialButtonResetAllProfiles", cul);
            buttonRTS.Text = res_man.GetString("materialButtonResetToolSettings", cul);
            label8.Text = res_man.GetString("SettingRT", cul);
            label7.Text = res_man.GetString("SettingGS", cul);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
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
            if (Properties.Settings.Default.Updates == true)
            {
                radioButtonYESUpdates.PerformClick();
            }
            if (Properties.Settings.Default.Updates == false)
            {
                radioButtonNOUpdates.PerformClick();
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

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException ex)
            {
                Logs.DebugErrorLogs(ex); 
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError("File " + ex.ToString(), "Error file locked check");
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public void reset(string path, string task)
        {
            try
            {
                var dir = new DirectoryInfo(path);

                foreach (var file in dir.GetFiles())
                {
                    if (IsFileLocked(file) == false)
                    {
                        file.Delete();
                        Thread.Sleep(1000);
                        this.Hide();
                        var mainf = new MainForm();
                        mainf.RestartApp();
                    }
                    else
                    {
                        SystemSounds.Exclamation.Play();
                        DarkMessageBox.ShowWarning("File " + file.ToString() + " is locked :c \n\n Try to remove it manually or wait!", "Moto_Boot_Logo_Maker");
                        return;
                    }
                }
            }
            catch (Exception er)
            {
                Logs.DebugErrorLogs(er); 
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(er.ToString(), task);
            }
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
            var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            var newpath = path.Replace(@"\user.config", "").Trim();
            reset(newpath.ToString(), "TASK {1}: Reset Settings");
        }

        private void btngotosettingslogs_Click(object sender, EventArgs e)
        {
            var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            var newpath = path.Replace(@"\user.config", "").Trim();
            Process.Start(newpath);
            this.Close();
        }
    }
}