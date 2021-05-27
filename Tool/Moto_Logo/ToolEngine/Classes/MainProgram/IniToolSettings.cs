/* 
#####################################################################
#    File: IniToolSettings.cs                                       #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Bluegrams.Application;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Moto_Logo
{
    public static class IniToolSettings
    {
        public static CultureInfo cul = null;
        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public static void CreateDirectory(string directory)
        {
            if (!Directory.Exists(exePath + @"\Files\" + directory))
            {
                Directory.CreateDirectory(exePath + @"\Files\" + directory);
            }
        }

        public static bool OTAFILE(string fileName)
        {
            var workingDirectory = Environment.CurrentDirectory;
            var file = $@"{workingDirectory}\{fileName}";
            return File.Exists(file);
        }

        public static void InitilizeSettings()
        {
            // Tool Initial Settings

            if (!Directory.Exists(exePath + @"\Logs\"))
            {
                Directory.CreateDirectory(exePath + @"\Logs\");
            }

            CheckNetFamework.IFNOT48();

            if (!Directory.Exists(exePath + @"\Settings\"))
            {
                Directory.CreateDirectory(exePath + @"\Settings\");
            }

            PortableSettingsProvider.SettingsFileName = "Settings.config";
            PortableSettingsProvider.SettingsDirectory = "Settings\\";
            PortableSettingsProvider.ApplyProvider(Properties.Settings.Default);
            PortableSettingsProvider.ApplyProvider(Properties.Profiles.Default);

            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            if (!OSVersionInfo.Name.Equals("Windows 10") && !OSVersionInfo.Name.Equals("Windows 8.1") && !OSVersionInfo.Name.Equals("Windows 8") && !OSVersionInfo.Name.Equals("Windows 7"))
            {
                CheckNetFamework.Get48FromRegistry();
                MessageBox.Show(res_man.GetString("ProgramCheckWindows", cul) + " " + OSVersionInfo.Name, res_man.GetString("ProgramCheckWindows2", cul), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Kill.PanicKillInternal();
                return;
            }
            else
            {
                CheckNetFamework.Get48FromRegistry();
            }

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

            if (CheckAdmin.IsUserAdministrator() == true)
            {
                Properties.Settings.Default.IsAdmin = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.IsAdmin = false;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.LogoWasSaved == true)
            {
                Properties.Settings.Default.LogoWasSaved = false;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.LogoBinOpenSave == false)
            {
                Properties.Settings.Default.LogoWasSaved = false;
                Properties.Settings.Default.LogoBinOpen = "";
                Properties.Settings.Default.Save();
            }

            string x86path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string x64path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

            if (exePath == x86path || exePath == x64path)
            {
                if (CheckAdmin.IsUserAdministrator() == false)
                {
                    MessageBox.Show(res_man.GetString("ProgramCheckPrivileges", cul), res_man.GetString("ProgramCheckPrivileges2", cul), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Kill.PanicKillInternal();
                    return;
                }
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
        }
    }
}
