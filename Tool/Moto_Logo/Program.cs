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
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DarkUI.Forms;

namespace Moto_Logo
{
    static class Program
    {
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);

        public static CultureInfo cul = null;

        [STAThread]
        static void Main()
        {
            try
            {
                var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

                int process = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;
                if (process > 1)
                {
                    SetForegroundWindow(process);
                    SystemSounds.Exclamation.Play();          
                    DarkMessageBox.ShowError(res_man.GetString("ProgramCheckBackRun", cul), res_man.GetString("ProgramCheckBackRun2", cul));
                    return;
                }

                // Ini Tool Settings -> IniToolSettings.cs
                IniToolSettings.InitilizeSettings();
                
                if (Environment.OSVersion.Version.Major >= 6)
                    SetProcessDPIAware();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Start();
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex); 
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError("Moto_Boot_Logo_Maker: Start up error: " + ex, "EXECUTING FATAL ERROR: Moto_Boot_Logo_Maker " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex));
                Kill.PanicKill();
                return;
            }
        }

        public static void Start() 
        {
            Application.Run(new MainForm());
        }

        [DllImport("User32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}