/* 
#####################################################################
#    File: Program.cs                                               #
#    Author: Franco28                                               # 
#    Date: 09-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Media;
using System.Windows.Forms;
using DarkUI.Forms;

namespace Moto_Logo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                // Ini Tool Settings -> IniToolSettings.cs
                IniToolSettings.InitilizeSettings();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception er)
            {
                Logs.DebugErrorLogs(er); 
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError("Moto_Boot_Logo_Maker: Start up error: " + er, "FATAL ERROR: Moto_Boot_Logo_Maker");
                Kill.PanicKill();
                return;
            }
        }
    }
}