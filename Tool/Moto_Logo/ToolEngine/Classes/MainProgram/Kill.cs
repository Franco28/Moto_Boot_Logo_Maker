/* 
#####################################################################
#    File: Kill.cs                                                  #
#    Author: Franco28                                               # 
#    Date: 22-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Diagnostics;
using System.Windows.Forms;

namespace Moto_Logo
{
    public static class Kill
    {
        public static void PanicKillInternal()
        {
            string taskname = "Moto_Boot_Logo_Maker";
            foreach (var process in Process.GetProcessesByName(taskname))
            {
                process.Kill();
            }
            Application.Exit();
        }

        public static void PanicKill()
        {
            var main = new MainForm();
            main.timerupdates.Stop();
            Properties.Settings.Default.Save();
            Properties.Profiles.Default.Save();
            string taskname = "Moto_Boot_Logo_Maker";
            foreach (var process in Process.GetProcessesByName(taskname))
            {
                process.Kill();
            }
            Application.Exit();
        }
    }
}
