/* 
#####################################################################
#    File: Settings.cs                                              #
#    Author: Franco28                                               # 
#    Date: 17-02-2021                                               #
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
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class ToolSettings : Form
    {
        public CultureInfo cul;
        public ResourceManager res_man;
        public CultureInfo ci = CultureInfo.InstalledUICulture;

        public ToolSettings()
        {         
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            this.Text = res_man.GetString("settingsToolStripMenuItem", cul);  
            label3.Text = res_man.GetString("settingsToolStripMenuItem", cul);
            groupBox1.Text = res_man.GetString("SettingsGroupBox1", cul);
            groupBox2.Text = res_man.GetString("SettingsGroupBox2", cul);
            groupBox3.Text = res_man.GetString("SettingsGroupBox3", cul);
            radioButtonYESUpdates.Text = radioButtonYESLogo.Text = radioButtonYES.Text = res_man.GetString("SettingsYes", cul);
            radioButtonNOUpdates.Text = radioButtonNO.Text = radioButtonNOLogo.Text = res_man.GetString("SettingsNo", cul);
            buttonRTP.Text = res_man.GetString("materialButtonResetAllProfiles", cul);
            buttonRTS.Text = res_man.GetString("materialButtonResetToolSettings", cul);
            label8.Text = res_man.GetString("SettingRT", cul);
            label7.Text = res_man.GetString("SettingGS", cul);

            if (Properties.Settings.Default.Theme == "light")
            {
                LighTheme();
            }
        }

        public void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText("\n" + message);
                console.ScrollToCaret();
            });
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            cAppend(res_man.GetString("SettingCLoading", cul));
            if (Properties.Settings.Default.SaveProfiles == true)
            {
                radioButtonYES.PerformClick();
                cAppend("Loading SaveProfiles... {OK}");
            }
            if (Properties.Settings.Default.SaveProfiles == false)
            {
                radioButtonNO.PerformClick();
                cAppend("Loading SaveProfiles... {FALSE}");
            }
            if (Properties.Settings.Default.LogoBinOpenSave == false)
            {
                radioButtonNOLogo.PerformClick();
                cAppend("Loading LogoBinOpenSave... {FALSE}");
            }
            if (Properties.Settings.Default.LogoBinOpenSave == true)
            {
                radioButtonYESLogo.PerformClick();
                cAppend("Loading LogoBinOpenSave... {OK}");
            }
            if (Properties.Settings.Default.Updates == true)
            {
                radioButtonYESUpdates.PerformClick();
                cAppend("Loading Updates... {OK}");
            }
            if (Properties.Settings.Default.Updates == false)
            {
                radioButtonNOUpdates.PerformClick();
                cAppend("Loading Updates... {FALSE}");
            }
            cAppend(res_man.GetString("SettingCLoading", cul) + " {DONE}");
        }

        #region theme
        public void LighTheme()
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.ForeColor = Color.FromArgb(0, 0, 0);

            console.BackColor = label5.BackColor = label3.BackColor = groupBox3.BackColor = groupBox2.BackColor = groupBox1.BackColor = Color.FromArgb(255, 255, 255);
            console.ForeColor = label5.ForeColor = label3.ForeColor = groupBox3.ForeColor = groupBox2.ForeColor = groupBox1.ForeColor = Color.FromArgb(0, 0, 0);

            buttonRTP.BackColor = buttonRTS.BackColor = Color.FromArgb(255, 255, 255);
            buttonRTP.ForeColor = Color.DarkOrange;
            buttonRTS.ForeColor = Color.Red;
        }
        #endregion theme

        private void radioButtonYES_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveProfiles = true;
            Properties.Settings.Default.Save();
            cAppend("Enable SaveProfiles... {TRUE}");
        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveProfiles = false;
            Properties.Settings.Default.Save();
            cAppend("Enable SaveProfiles... {FALSE}");
        }

        private void radioButtonNOLogo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogoBinOpenSave = false;
            Properties.Settings.Default.Save();
            cAppend("Enable LogoBinOpenSave... {FALSE}");
        }

        private void radioButtonYESLogo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogoBinOpenSave = true;
            Properties.Settings.Default.Save();
            cAppend("Enable LogoBinOpenSave... {TRUE}");
        }

        private void radioButtonYESUpdates_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Updates = true;
            Properties.Settings.Default.Save();
            cAppend("Enable Updates... {TRUE}");
        }

        private void radioButtonNOUpdates_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Updates = false;
            Properties.Settings.Default.Save();
            cAppend("Enable Updates... {FALSE}");
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
                MessageBox.Show("File " + ex.ToString(), "Error file locked check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("File " + file.ToString() + " is locked :c \n\n Try to remove it manually or wait!", "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception er)
            {
                Logs.DebugErrorLogs(er);
                MessageBox.Show(er.ToString(), task);
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}