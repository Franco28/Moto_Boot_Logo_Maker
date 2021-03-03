/* 
#####################################################################
#    File: Program.cs                                               #
#    Author: Franco28                                               # 
#    Date: 03-03-2021                                               #
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
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace Moto_Logo
{
    static class Program
    {
        public static CultureInfo cul = null;
      
        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public static void CreateDirectory(string directory)
        {
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            if (!Directory.Exists(exePath + @"\Files\" + directory))
            {
                Directory.CreateDirectory(exePath + @"\Files\" + directory);
            }
        }

        [STAThread]
        static void Main()
        {
            try
            {
                var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

                if (exePath == @"C:\Program Files (x86)\Moto_Boot_Logo_Maker" || exePath == @"C:\Program Files\Moto_Boot_Logo_Maker")
                {
                    if (IsUserAdministrator() == false)
                    {
                        MessageBox.Show(res_man.GetString("ProgramCheckPrivileges", cul), res_man.GetString("ProgramCheckPrivileges2", cul), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PanicKillInternal();
                        return;
                    }
                }

                if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                {
                    MessageBox.Show(res_man.GetString("ProgramCheckBackRun", cul), res_man.GetString("ProgramCheckBackRun2", cul), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!OSVersionInfo.Name.Equals("Windows 10") && !OSVersionInfo.Name.Equals("Windows 8.1") && !OSVersionInfo.Name.Equals("Windows 8") && !OSVersionInfo.Name.Equals("Windows 7"))
                {
                    CheckNetFamework.Get45or451FromRegistry();
                    MessageBox.Show(res_man.GetString("ProgramCheckWindows", cul) + " " + OSVersionInfo.Name, res_man.GetString("ProgramCheckWindows2", cul), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PanicKillInternal();
                    return;
                }
                else
                {
                    CheckNetFamework.Get45or451FromRegistry();
                }

                if (!Directory.Exists(exePath + @"\Files\"))
                {
                    Directory.CreateDirectory(exePath + @"\Files\");
                } 

                CreateDirectory(@"LogoZip");
                CreateDirectory(@"Images\Logo");
                CreateDirectory(@"Images\Icons");
                CreateDirectory(@"Bin");
                CreateDirectory(@"Bin\4MB");
                CreateDirectory(@"Bin\6MB");
                CreateDirectory(@"Bin\8MB");
                CreateDirectory(@"Bin\16MB");
                CreateDirectory(@"Bin\32MB");

                if (File.Exists(exePath + @"\Files\*.zip"))
                {
                    File.Delete(exePath + @"\Files\*.zip");
                }

                if (File.Exists(exePath + @"\*.zip"))
                {
                    File.Delete(exePath + @"\*.zip");
                }

                string ADBpath = @"C:\\adb\\";

                if (!Directory.Exists(ADBpath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(ADBpath);
                    if (IsDirectoryEmpty(ADBpath) == true)
                    {
                        Directory.CreateDirectory(ADBpath);
                        di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    }
                }
                else
                {
                    var dir = new DirectoryInfo(ADBpath);
                    if (IsDirectoryEmpty(ADBpath) == false)
                    {
                        dir.Attributes = dir.Attributes & ~FileAttributes.Hidden;
                    }
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception er)
            {
                Logs.DebugErrorLogs(er);
                MessageBox.Show("Moto_Boot_Logo_Maker: Start up error: " + er, "FATAL ERROR: Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PanicKill();
                return;
            }
        }

        public static void PanicKillInternal()
        {
            string taskname = "adb";
            string taskname2 = "Moto_Boot_Logo_Maker";
            foreach (var process in Process.GetProcessesByName(taskname))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName(taskname2))
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
            string taskname = "adb";
            string taskname2 = "Moto_Boot_Logo_Maker";
            foreach (var process in Process.GetProcessesByName(taskname))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName(taskname2))
            {
                process.Kill();
            }
            Application.Exit();
        }
    }
}