/* 
#####################################################################
#    File: Logs.cs                                                  #
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
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Moto_Logo
{
    public class Logs
    {
        public static CultureInfo ci = CultureInfo.InstalledUICulture;
        static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public class IpInfo
        {
            public string Country { get; set; }
        }

        public static void LogoOpenError(string error)
        {
            string filePath = exePath + @"\Logs\LogoOpenError.txt";

            using (FileStream fs = File.Create(filePath))
            {

            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("File Generated Date: " + DateTime.Now.ToString());
                writer.WriteLine("Error: \n " + error);
            }
        }

        public static void LogoBuildError(string error)
        {
            string filePath = exePath + @"\Logs\LogoBuild.txt";

            using (FileStream fs = File.Create(filePath))
            {

            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("File Generated Date: " + DateTime.Now.ToString());
                writer.WriteLine("Error: \n " + error);
            }
        }

        public static void DebugWindwosInfo(string netframworkversion, string windowsver)
        {
            //Old folder
            //var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            //var newpath = path.Replace(@"\user.config", "").Trim();
            //string filePath = newpath + @"\DebugLogs\WinInfo_" + Environment.UserName + ".txt";

            /*if (!Directory.Exists(newpath + @"\DebugLogs"))
            {
                Directory.CreateDirectory(newpath + @"\DebugLogs");
            }*/

            string filePath = exePath + @"\Logs\ToolInfo_" + Environment.UserName + ".txt";

            using (FileStream fs = File.Create(filePath))
            {

            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("File Generated Date: " + DateTime.Now.ToString());
                writer.WriteLine("Username: " + Environment.UserName);
                writer.WriteLine("Computer Name: " + SystemInformation.ComputerName);
                writer.WriteLine("Tool Version: v" + Application.ProductVersion);
                writer.WriteLine("Tool Build Date: " + Utils.GetLinkerDateTime(Assembly.GetEntryAssembly(), null).ToString());
                writer.WriteLine("Main Windows Culture: " + ci.Name.ToString());
                writer.WriteLine(netframworkversion);
                writer.WriteLine(windowsver);

                if (InternetCheck.ConnectToInternet() == true)
                {
                    IpInfo ipInfo = new IpInfo();
                    string info = new WebClient().DownloadString("http://ipinfo.io");
                    JavaScriptSerializer jsonObject = new JavaScriptSerializer();
                    ipInfo = jsonObject.Deserialize<IpInfo>(info);
                    RegionInfo region = new RegionInfo(ipInfo.Country);
                    writer.WriteLine("Country: " + region.EnglishName);
                }
                else
                {
                    writer.WriteLine("Country: Can´t connect to IP... Waiting for internet connection...");
                }
            }

            using (StreamReader sr = File.OpenText(filePath))
            {
                while ((sr.ReadLine()).StartsWith("Windows:") && (sr.ReadLine()).StartsWith("NetFramework:"))
                {
                    return;
                }
            }
        }

        public static int GetLineNumber(Exception ex)
        {
            var lineNumber = 0;
            const string lineSearch = ":line ";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                if (int.TryParse(lineNumberText, out lineNumber))
                {
                }
            }
            return lineNumber;
        }

        public static string GetClassName(Exception ex)
        {
            StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
            string classname = trace.GetFrame(0).GetMethod().ReflectedType.FullName;

            return classname;
        }

        public static void DebugErrorLogs(Exception er)
        {
            //var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            //var newpath = path.Replace(@"\user.config", "").Trim();
            //string filePath = newpath + @"\DebugLogs\Error_" + Environment.UserName + ".txt";

            /*if (!Directory.Exists(newpath + @"\DebugLogs"))
            {
                Directory.CreateDirectory(newpath + @"\DebugLogs");
            }*/

            string filePath = exePath + @"\Logs\Error_" + Environment.UserName + ".txt";

            Exception ex = er;

            int lineerror = GetLineNumber(ex);
            string classname = GetClassName(ex);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("File Generated Date: " + DateTime.Now.ToString());
                writer.WriteLine("Tool Version: v" + Application.ProductVersion);
                writer.WriteLine("Tool Build Date: " + Utils.GetLinkerDateTime(Assembly.GetEntryAssembly(), null).ToString());
                writer.WriteLine();
                writer.WriteLine("Class Name: " + classname.ToString());
                writer.WriteLine("Line: " + lineerror.ToString());
                writer.WriteLine();

                while (ex != null)
                {
                    writer.WriteLine(ex.GetType().FullName);
                    writer.WriteLine("Message: " + ex.Message);
                    writer.WriteLine("StackTrace: " + ex.StackTrace);
                    ex = ex.InnerException;
                    writer.WriteLine("-----------------------------------------------------------------------------");
                }
            }
        }
    }
}