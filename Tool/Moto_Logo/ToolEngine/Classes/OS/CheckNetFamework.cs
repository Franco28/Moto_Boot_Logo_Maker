/* 
#####################################################################
#    File: CheckNetFramework.cs                                     #
#    Author: Franco28                                               # 
#    Date: 10-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using DarkUI.Forms;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Media;
using System.Resources;

namespace Moto_Logo
{
    public class CheckNetFamework
    {
        public static CultureInfo cul = null;
        public static ResourceManager res_man;

        public static void IFNOT48()
        {
            try
            {
                const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
                using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
                {
                    int releaseKey = Convert.ToInt32(ndpKey.GetValue("Release"));
                    if (ndpKey != null && ndpKey.GetValue("Release") != null)
                    {
                        if (CheckFor48DotVersion(releaseKey) != "4.8")
                        {
                            SystemSounds.Hand.Play();
                            DarkMessageBox.ShowError(".NET Framework version does not match with v4.8! \nDebug Info: " + CheckFor48DotVersion(releaseKey), "Moto_Boot_Logo_Maker cannot be launched... .NET Framework troubles");
                            Process.Start("https://dotnet.microsoft.com/download/dotnet-framework/net48");
                            Kill.PanicKillInternal();
                            return;
                        }
                    }
                    else
                    {
                        if (CheckFor48DotVersion(releaseKey) != "4.8")
                        {
                            SystemSounds.Hand.Play();
                            DarkMessageBox.ShowError(".NET Framework error missig or lower than v4.8 \nDebug Info: " + CheckFor48DotVersion(releaseKey), "Moto_Boot_Logo_Maker cannot be launched... .NET Framework troubles");
                            Process.Start("https://dotnet.microsoft.com/download/dotnet-framework/net48");
                            Kill.PanicKillInternal();
                            return;
                        }
                    }
                }
            }
            catch (Exception er)
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(".NET Framework error" + er.ToString(), "Moto_Boot_Logo_Maker cannot be launched... .NET Framework troubles");
                Process.Start("https://dotnet.microsoft.com/download/dotnet-framework/net48");
                Kill.PanicKillInternal();
                return;
            }
        }

        public static void Get48FromRegistry()
        {
            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            try
            {
                const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
                using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
                {
                    int releaseKey = Convert.ToInt32(ndpKey.GetValue("Release"));
                    if (ndpKey != null && ndpKey.GetValue("Release") != null)
                    {
                        Logs.DebugWindwosInfo($".NET Framework: v" + CheckFor48DotVersion(releaseKey), "OS: " + OSVersionInfo.Name.ToString());
                    }
                    else
                    {
                        Logs.DebugWindwosInfo(res_man.GetString("NETFRAMEWORKERROR", cul), "OS: " + OSVersionInfo.Name.ToString());
                    }
                }
            } 
            catch (Exception er)
            {
                Logs.DebugWindwosInfo(res_man.GetString("NETFRAMEWORKERROR", cul) + " \n" + er.ToString(), "OS: " + OSVersionInfo.Name.ToString());
            }
        }

        public static string CheckFor48DotVersion(int releaseKey)
        {
            if (releaseKey >= 528372)
            {
                return "4.8";
            }
            if (releaseKey >= 461808)
            {
                return "4.7.2";
            }
            if (releaseKey >= 461308)
            {
                return "4.7.1";
            }
            if (releaseKey >= 460798)
            {
                return "4.7";
            }
            if (releaseKey >= 394802)
            {
                return "4.6.2";
            }
            if (releaseKey >= 394254)
            {
                return "4.6.1";
            }
            if (releaseKey >= 393295)
            {
                return "4.6";
            }
            if (releaseKey >= 393273)
            {
                return "4.6 RC";
            }
            if ((releaseKey >= 379893))
            {
                return "4.5.2";
            }
            if ((releaseKey >= 378675))
            {
                return "4.5.1";
            }
            if ((releaseKey >= 378389))
            {
                return "4.5 or later";
            }
            InternetCheck.CheckInternetProcessStart("https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-web-installer");
            return "No .NET 4.5 or later version detected. So Tool won´t be launched. Please if you want to fix this, install .NET v4.8.";
        }
    }
}