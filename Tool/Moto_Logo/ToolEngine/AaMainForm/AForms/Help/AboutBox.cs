/* 
#####################################################################
#    File: AboutBox.cs                                              #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using AutoUpdaterDotNET;
using Microsoft.Win32;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using DarkUI.Forms;
using System.Diagnostics;

namespace Moto_Logo
{
    partial class AboutBox : DarkForm
    {
        public readonly CultureInfo cul = null;
        public ResourceManager res_man;
        string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public static CultureInfo ci = CultureInfo.InstalledUICulture;

        public AboutBox()
        {         
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            button1.Hide();
            labelTITLEMAINTEINERS.Text = res_man.GetString("AboutForm_Mainteiners", cul);

            if (exePath != @"C:\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files (x86)\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files\Moto_Boot_Logo_Maker")
            {
                this.Text = String.Format(res_man.GetString("AboutForm_Title", cul), AssemblyTitle) + " Moto_Boot_Logo_Maker - PORTABLE - Build: " + Utils.GetLinkerDateTime(Assembly.GetEntryAssembly(), null).ToString();
            }
            else
            {
                this.Text = String.Format(res_man.GetString("AboutForm_Title", cul), AssemblyTitle) + " Moto_Boot_Logo_Maker - Build: " + Utils.GetLinkerDateTime(Assembly.GetEntryAssembly(), null).ToString();
            }

            button2.Text = res_man.GetString("AboutForm_BTN_Contributors", cul);
            button1.Text = res_man.GetString("AboutForm_BTN_DownloadUpdate", cul);
            label12.Text = res_man.GetString("AboutForm_DonationMSG", cul);
        }

        public void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText("\n" + message);
                console.ScrollToCaret();
            });
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            cAppend("------------------------------------------ Tool Info ------------------------------------------");
            cAppend(res_man.GetString("AboutForm_Box_ToolName", cul) + " " + AssemblyProduct);
            cAppend(res_man.GetString("AboutForm_Box_ToolVer", cul) + " v" + Application.ProductVersion);
            cAppend(res_man.GetString("AboutForm_Box_ToolPath", cul) + " " + exePath);
            cAppend(res_man.GetString("AboutForm_Box_ToolCul", cul) + " " + ci.Name.ToString());
            cAppend(res_man.GetString("AboutForm_Box_OS", cul) + " " + OSVersionInfo.Name.ToString());

            try
            {
                const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
                using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
                {
                    int releaseKey = Convert.ToInt32(ndpKey.GetValue("Release"));
                    if (ndpKey != null && ndpKey.GetValue("Release") != null)
                    {
                        cAppend(".NET Framework: v" + CheckNetFamework.CheckFor48DotVersion(releaseKey));
                    }
                    else
                    {
                        cAppend(res_man.GetString("NETFRAMEWORKERROR", cul));
                    }
                }
            }             
            catch (Exception er)
            {
                Logs.DebugWindwosInfo(res_man.GetString("NETFRAMEWORKERROR", cul) + " \n" + er.ToString(), "OS: " + OSVersionInfo.Name.ToString());
            }

            cAppend(res_man.GetString("AboutForm_Box_ImageRunTime", cul) + " " + typeof(string).Assembly.ImageRuntimeVersion);
            cAppend(res_man.GetString("AboutForm_Box_AppTrusted", cul) +  " " + typeof(string).Assembly.IsFullyTrusted);

            cAppend("---------------------------------------- End Tool Info ----------------------------------------");

            cAppend(" ");
            cAppend(res_man.GetString("AboutForm_Updates", cul) + " " + res_man.GetString("AboutForm_Checkinf4Updates", cul));
            CheckForUpdates();
        }

        #region updatesinfo
        private void timer1_Tick(object sender, EventArgs e)
        {
            //CheckForUpdates();
        }

        public void CheckForUpdates()
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                if (InternetCheck.CheckServerRed("https://raw.githubusercontent.com/Franco28/Moto_Boot_Logo_Maker/master/Windows/OTAS/updates.xml") == true)
                {
                    cAppend(res_man.GetString("AboutForm_Updates", cul) + " " + res_man.GetString("AboutForm_DownloadUpdate_ServerDown", cul));
                    return;
                }
                else
                {
                    AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
                    timer1.Interval = (2 * 5 * 100);
                    timer1.Tick += new EventHandler(toolupdates);
                    AboutBox SynchronizingObject = this;
                    timer1.Start();
                }
            }
            else
            {
                AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                timer1.Stop();
                cAppend(res_man.GetString("AboutForm_Updates", cul) + " " + res_man.GetString("AboutForm_DownloadUpdate_NetLost", cul));
                return;
            }
        }

        private void toolupdates(object sender, EventArgs e)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                AutoUpdater.Start("https://raw.githubusercontent.com/Franco28/Moto_Boot_Logo_Maker/master/Windows/OTAS/updates.xml");
            }
            else
            {
                AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                timer1.Stop();
                cAppend(res_man.GetString("AboutForm_Updates", cul) + " " + res_man.GetString("AboutForm_DownloadUpdate_NetLost", cul));
                return;
            }
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    button1.Show();
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    timer1.Stop();
                    timer1.Dispose();
                    cAppend(res_man.GetString("AboutForm_Updates", cul) + " " + res_man.GetString("MainForm_Update_NewUpdateText", cul) + $@" {args.CurrentVersion} " + res_man.GetString("MainForm_Update_NewUpdateText2", cul) + $@" {args.InstalledVersion}. " + res_man.GetString("MainForm_Update_NewUpdateText3", cul));
                    return;
                }
                else
                {
                    button1.Hide();
                    timer1.Stop();
                    timer1.Dispose();
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    cAppend(res_man.GetString("AboutForm_Updates", cul) + " " + res_man.GetString("AboutForm_Updates2", cul));
                    return;
                }
            }
        }
        #endregion updatesinfo

        #region AssemblyInfo
        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public string AssemblyTitle
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length <= 0)
                    return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
                var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                return titleAttribute.Title != "" ? titleAttribute.Title : Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        #endregion AssemblyInfo


        public void OpenTelegram(string url)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                Process.Start(url);
            }
            else
            {
                MessageBox.Show(res_man.GetString("MainForm_InternetCheck", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(exePath + @"\credits.txt"))
            {
                return;
            }
            var credits = new Credits();
            credits.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "AFH";
            MessageBoxManager.No = "SF";
            MessageBoxManager.Cancel = "Cancel";
            MessageBoxManager.Register();
            DialogResult answer = MessageBox.Show(res_man.GetString("AboutForm_DownloadUpdate_Server", cul) + " \n*Android File Host (AFH) \n*SourceForge (SF)",
            "Moto_Boot_Logo_Maker " + res_man.GetString("AboutDownloadUpdateServerTitle", cul), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            switch (answer)
            {
                case DialogResult.Yes:
                    InternetCheck.CheckInternetProcessStart("https://androidfilehost.com/?w=files&flid=323184");
                    MessageBoxManager.Unregister();
                    this.Close();
                    break;
                case DialogResult.No:
                    InternetCheck.CheckInternetProcessStart("https://sourceforge.net/projects/motobootlogomaker/files/PORTABLE/");
                    MessageBoxManager.Unregister();
                    this.Close();
                    break;
                case DialogResult.Cancel:
                    MessageBoxManager.Unregister();
                    return;
            }
            MessageBoxManager.Unregister();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenTelegram("https://t.me/francom28");
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            OpenTelegram("https://t.me/Deivid_21");
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InternetCheck.CheckInternetProcessStart("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=RPY4ZNYX2VA4G&source=url");
            this.Close();
        }

        private void AboutBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
        }
    }
}