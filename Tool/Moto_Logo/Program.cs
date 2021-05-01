/* 
#####################################################################
#    File: Program.cs                                               #
#    Author: Franco28                                               # 
#    Date: 01-05-2021                                               #
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
using System.Media;
using System.Windows.Forms;
using DarkUI.Forms;

namespace Moto_Logo
{
    static class Program
    {
        public static CultureInfo cul = null;

        [STAThread]
        static void Main()
        {
            try
            {
                var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

                if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                {
                    SystemSounds.Hand.Play();
                    DarkMessageBox.ShowError(res_man.GetString("ProgramCheckBackRun", cul), res_man.GetString("ProgramCheckBackRun2", cul));
                    return;
                }

                // Ini Tool Settings -> IniToolSettings.cs
                IniToolSettings.InitilizeSettings();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Start();
            }
            catch (Exception er)
            {
                Logs.DebugErrorLogs(er); 
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError("Moto_Boot_Logo_Maker: Start up error: " + er, "EXECUTING FATAL ERROR: Moto_Boot_Logo_Maker");
                Kill.PanicKill();
                return;
            }
        }

        public static void Start() 
        {
            Application.Run(new MainForm());
        }
    }
}