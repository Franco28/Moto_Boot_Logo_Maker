/* 
#####################################################################
#    File: MainForm.UpdateEngine.cs                                 #
#    Author: Franco28                                               # 
#    Date: 05-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using AutoUpdaterDotNET;
using System;
using System.Net;
using System.Windows.Forms;
using DarkUI.Forms;
using System.Media;

namespace Moto_Logo
{
    public partial class MainForm
    {
        private void AutoUpdater_ApplicationExitEvent()
        {
            this.Text = res_man.GetString("ToolUpdating", cul);
            timerupdates.Stop();
            Application.Exit();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
        }

        private void toolupdates(object sender, EventArgs e)
        {
            AutoUpdater.Start("https://raw.githubusercontent.com/Franco28/Moto_Boot_Logo_Maker/master/Windows/OTAS/updates.xml");
        }

        public void CheckForUpdates()
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                if (InternetCheck.CheckServerRed("https://raw.githubusercontent.com/Franco28/Moto_Boot_Logo_Maker/master/Windows/OTAS/updates.xml") == true)
                {
                    SystemSounds.Hand.Play();
                    DarkMessageBox.ShowError(@"Server is down :\", "Moto_Boot_Logo_Maker - updates");
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    timerupdates.Stop();
                    return;
                }
                timerupdates.Interval = (1 * 5 * 100);
                timerupdates.Tick += new EventHandler(toolupdates);
                MainForm SynchronizingObject = this;
                timerupdates.Start();
                AvoidFlick();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                DarkMessageBox.ShowWarning(res_man.GetString("ToolInternetErrorUpdate", cul), "Moto_Boot_Logo_Maker");
                AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                timerupdates.Stop();
                return;
            }
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;
            AutoUpdater.RunUpdateAsAdmin = true;

            if (args.Error == null)
            {
                if (args.IsUpdateAvailable)
                {
                    DialogResult dialogResult;
                    if (args.Mandatory.Value)
                    {
                        SystemSounds.Exclamation.Play();
                        dialogResult = DarkMessageBox.ShowInformation(res_man.GetString("ToolNewUpdateText", cul) + $@" {args.CurrentVersion} " + res_man.GetString("ToolNewUpdateText2", cul) + $@" {args.InstalledVersion}. " + res_man.GetString("ToolNewUpdateText3", cul), res_man.GetString("ToolNewUpdateTitle", cul));
                    }
                    try
                    {
                        if (AutoUpdater.DownloadUpdate(args))
                        {
                            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logs.DebugErrorLogs(ex); 
                        SystemSounds.Hand.Play();
                        DarkMessageBox.ShowError(ex.Message, ex.GetType().ToString());
                        AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                        timerupdates.Stop();
                        return;
                    }
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowInformation(res_man.GetString("ToolNoUpdate", cul), res_man.GetString("ToolNoUpdateTitle", cul));
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    timerupdates.Stop();
                    return;
                }
            }
            else
            {
                if (args.Error is WebException)
                {
                    SystemSounds.Hand.Play();
                    DarkMessageBox.ShowError(res_man.GetString("ToolErrorUpdate", cul), res_man.GetString("ToolErrorUpdateTitle", cul));
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    timerupdates.Stop();
                    return;
                }
                else
                {
                    SystemSounds.Hand.Play();
                    DarkMessageBox.ShowError(args.Error.Message, args.Error.GetType().ToString());
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    timerupdates.Stop();
                    return;
                }
            }
        }

        private void AvoidFlick()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
    }
}