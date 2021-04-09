/* 
#####################################################################
#    File: IniToolSettings.cs                                       #
#    Author: Franco28                                               # 
#    Date: 09-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Bluegrams.Application;
using DarkUI.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;

namespace Moto_Logo
{
    public static class IniToolSettings
    {
        public static CultureInfo cul = null;

        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public static void CreateDirectory(string directory)
        {
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            if (!Directory.Exists(exePath + @"\Files\" + directory))
            {
                Directory.CreateDirectory(exePath + @"\Files\" + directory);
            }
        }

        public static void InitilizeSettings()
        {
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            // Tool Settings
            if (!Directory.Exists(exePath + @"\Settings\"))
            {
                Directory.CreateDirectory(exePath + @"\Settings\");
            }

            if (!Directory.Exists(exePath + @"\Logs\"))
            {
                Directory.CreateDirectory(exePath + @"\Logs\");
            }

            PortableSettingsProvider.SettingsFileName = "settings.config";
            PortableSettingsProvider.SettingsDirectory = "Settings\\";
            PortableSettingsProvider.ApplyProvider(Properties.Settings.Default);
            PortableSettingsProvider.ApplyProvider(Properties.Profiles.Default);

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            if (Properties.Settings.Default.ToolVersion == "")
            {
                if (Properties.Settings.Default.UpgradeRequired == true)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.UpgradeRequired = false;
                }
                Properties.Settings.Default.ToolVersion = version;
                Properties.Settings.Default.Save();
            }

            if (version != Properties.Settings.Default.ToolVersion)
            {
                Properties.Settings.Default.ToolVersion = version;
                Properties.Settings.Default.Save();
            }

            // Check Others
            if (exePath == @"C:\Program Files (x86)\Moto_Boot_Logo_Maker" || exePath == @"C:\Program Files\Moto_Boot_Logo_Maker")
            {
                if (CheckAdmin.IsUserAdministrator() == false)
                {
                    SystemSounds.Hand.Play();
                    DarkMessageBox.ShowError(res_man.GetString("ProgramCheckPrivileges", cul), res_man.GetString("ProgramCheckPrivileges2", cul));
                    Kill.PanicKillInternal();
                    return;
                }
            }

            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(res_man.GetString("ProgramCheckBackRun", cul), res_man.GetString("ProgramCheckBackRun2", cul));
                return;
            }

            if (!OSVersionInfo.Name.Equals("Windows 10") && !OSVersionInfo.Name.Equals("Windows 8.1") && !OSVersionInfo.Name.Equals("Windows 8") && !OSVersionInfo.Name.Equals("Windows 7"))
            {
                CheckNetFamework.Get48FromRegistry();
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(res_man.GetString("ProgramCheckWindows", cul) + " " + OSVersionInfo.Name, res_man.GetString("ProgramCheckWindows2", cul));
                Kill.PanicKillInternal();
                return;
            }
            else
            {
                CheckNetFamework.Get48FromRegistry();
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
        }
    }
}
