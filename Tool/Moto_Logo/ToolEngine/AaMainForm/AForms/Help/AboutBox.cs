/* 
#####################################################################
#    File: AboutBox.cs                                              #
#    Author: Franco28                                               # 
#    Date: 28-04-2021                                               #
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
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using DarkUI.Forms;

namespace Moto_Logo
{
    partial class AboutBox : DarkForm
    {
        public readonly CultureInfo cul = null;
        public ResourceManager res_man;
        string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public static CultureInfo ci = CultureInfo.InstalledUICulture;

        public void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText("\n" + message);
                console.ScrollToCaret();
            });
        }

        public AboutBox()
        {         
            InitializeComponent();

            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            button1.Hide();
            labelTITLEMAINTEINERS.Text = res_man.GetString("AboutMainteiners", cul);

            if (exePath != @"C:\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files (x86)\Moto_Boot_Logo_Maker" && exePath != @"C:\Program Files\Moto_Boot_Logo_Maker")
            {
                this.Text = String.Format(res_man.GetString("aboutToolStripMenuItem1", cul), AssemblyTitle) + " Moto_Boot_Logo_Maker - PORTABLE - Build: " + Utils.GetLinkerDateTime(Assembly.GetEntryAssembly(), null).ToString();
            }
            else
            {
                this.Text = String.Format(res_man.GetString("aboutToolStripMenuItem1", cul), AssemblyTitle) + " Moto_Boot_Logo_Maker - Build: " + Utils.GetLinkerDateTime(Assembly.GetEntryAssembly(), null).ToString();
            }

            button2.Text = res_man.GetString("AboutBTNContributors", cul);
            button1.Text = res_man.GetString("AboutBTNDownloadUpdate", cul);
            label12.Text = res_man.GetString("AboutDonationMSG", cul);
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            cAppend("------------------------------------------ Tool Info ------------------------------------------");
            cAppend(res_man.GetString("AboutBoxToolName", cul) + " " + AssemblyProduct);
            cAppend(res_man.GetString("AboutBoxToolVer", cul) + " v" + Application.ProductVersion);
            cAppend(res_man.GetString("AboutBoxToolPath", cul) + " " + exePath);
            cAppend(res_man.GetString("AboutBoxToolCul", cul) + " " + ci.Name.ToString());
            cAppend(res_man.GetString("AboutBoxOS", cul) + " " + OSVersionInfo.Name.ToString());

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

            cAppend(res_man.GetString("AboutBoxImageRunTime", cul) + " " + typeof(string).Assembly.ImageRuntimeVersion);
            cAppend(res_man.GetString("AboutBoxAppTrusted", cul) +  " " + typeof(string).Assembly.IsFullyTrusted);

            cAppend("---------------------------------------- End Tool Info ----------------------------------------");

            cAppend(" ");
            cAppend(res_man.GetString("AboutUpdates", cul) + " " + res_man.GetString("AboutCheckinf4Updates", cul));
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
                    cAppend(res_man.GetString("AboutUpdates", cul) + " " + res_man.GetString("AboutDownloadUpdateServerDown", cul));
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
                cAppend(res_man.GetString("AboutUpdates", cul) + " " + res_man.GetString("AboutNoInternet", cul));
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
                cAppend(res_man.GetString("AboutUpdates", cul) + " " + res_man.GetString("AboutDownloadUpdateNetLost", cul));
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
                    cAppend(res_man.GetString("AboutUpdates", cul) + " " + res_man.GetString("ToolNewUpdateText", cul) + $@" {args.CurrentVersion} " + res_man.GetString("ToolNewUpdateText2", cul) + $@" {args.InstalledVersion}. " + res_man.GetString("ToolNewUpdateText3", cul));
                    return;
                }
                else
                {
                    button1.Hide();
                    timer1.Stop();
                    timer1.Dispose();
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    cAppend(res_man.GetString("AboutUpdates", cul) + " " + res_man.GetString("AboutUpdates2", cul));
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
            var main = new MainForm();
            main.OpenTelegramChannel(url);
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (Credits uu = new Credits())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
            }
            finally
            {
                formBackground.Dispose();
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "AFH";
            MessageBoxManager.No = "SF";
            MessageBoxManager.Cancel = "Cancel";
            MessageBoxManager.Register();
            DialogResult answer = MessageBox.Show(res_man.GetString("AboutDownloadUpdateServer", cul) + " \n*Android File Host (AFH) \n*SourceForge (SF)",
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