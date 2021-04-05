/* 
#####################################################################
#    File: CheckNetFramework.cs                                     #
#    Author: Franco28                                               # 
#    Date: 04-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Microsoft.Win32;
using System;

namespace Moto_Logo
{
    public class CheckNetFamework
    {
        public static void Get48FromRegistry()
        {
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                int releaseKey = Convert.ToInt32(ndpKey.GetValue("Release"));

                try
                {
                    Logs.DebugWindwosInfo("NetFramework: v" + CheckFor48DotVersion(releaseKey), "OS: " + OSVersionInfo.Name.ToString());
                }
                catch (ArgumentException ex)
                {
                    Logs.DebugWindwosInfo("NetFramework: Unable to reach out net framework version... " + ex.ToString(), "OS: " + OSVersionInfo.Name.ToString());
                    return;
                }
            }
        }

        public static string CheckFor48DotVersion(int releaseKey)
        {
            if (releaseKey >= 528049)
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
            return "No .NET 4.5 or later version detected. So Tool won´t be launched. Please if you want to fix this, install .NET 4.8.";
        }
    }
}