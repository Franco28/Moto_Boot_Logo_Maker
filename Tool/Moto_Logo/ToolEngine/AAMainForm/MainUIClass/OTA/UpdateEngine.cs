/* 
#####################################################################
#    File: MainForm.UpdateEngine.cs                                 #
#    Author: Franco28                                               # 
#    Date: 22-05-2021                                               #
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
                    MessageBox.Show(@"Server is down :\", "Moto_Boot_Logo_Maker - updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(res_man.GetString("ToolInternetErrorUpdate", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                timerupdates.Stop();
                return;
            }
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            AutoUpdater.RunUpdateAsAdmin = true;

            if (args.Error == null)
            {
                if (args.IsUpdateAvailable)
                {
                    DialogResult dialogResult;

                    dialogResult = MessageBox.Show(res_man.GetString("ToolNewUpdateText", cul) + $@" {args.CurrentVersion} " + res_man.GetString("ToolNewUpdateText2", cul) + $@" {args.InstalledVersion}. " + res_man.GetString("ToolNewUpdateText3", cul), res_man.GetString("ToolNewUpdateTitle", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                        timerupdates.Stop();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(res_man.GetString("ToolNoUpdate", cul), res_man.GetString("ToolNoUpdateTitle", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show(res_man.GetString("ToolErrorUpdate", cul), res_man.GetString("ToolErrorUpdateTitle", cul), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
                    timerupdates.Stop();
                    return;
                }
                else
                {
                    MessageBox.Show(args.Error.Message, args.Error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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