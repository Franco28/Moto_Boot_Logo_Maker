/* 
#####################################################################
#    File: SendLogs.cs                                              #
#    Author: Franco28                                               # 
#    Date: 06-01-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Microsoft.Win32;
using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Reflection;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Moto_Logo
{
    class SendLogs
    {
        public static void Call()
        {
            string appName = "Moto_Boot_Logo_Maker.exe";
            Configuration config = ConfigurationManager.OpenExeConfiguration(appName);
            ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;
            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            config.Save();
        }

        protected static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public void sendLogs()
        {
            var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
            var newpath = path.Replace(@"\user.config", "").Trim();
            string filePath = newpath + @"\DebugLogs\Error_" + Environment.UserName + ".txt";

            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                stream.Dispose();
                Attachment attachment = new Attachment(filePath, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = attachment.ContentDisposition;
                disposition.CreationDate = File.GetCreationTime(filePath);
                disposition.ModificationDate = File.GetLastWriteTime(filePath);
                disposition.ReadDate = File.GetLastAccessTime(filePath);
                disposition.FileName = Path.GetFileName(filePath);
                disposition.Size = new FileInfo(filePath).Length;
                disposition.DispositionType = DispositionTypeNames.Attachment;
                stream.Dispose();
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to send logs?", "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.OpenFileDialog file = new System.Windows.Forms.OpenFileDialog();
                file.InitialDirectory = newpath;
                file.FileName = filePath;
                file.Title = "Select your .txt file";
                file.Filter = "TXT|.txt";
                file.ShowDialog();
            }
            else if(dialogResult == DialogResult.No)
            {
                FileInfo file = new FileInfo(filePath);
                for (int tries = 0; IsFileLocked(file) && tries < 3; tries++)
                    Thread.Sleep(500);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                file.Delete();
            }
        }

        public static void sendMailToAdmin()
        {
            try
            {           
                var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath.ToString();
                var newpath = path.Replace(@"\user.config", "").Trim();
                string filePath = newpath + @"\DebugLogs\Error_" + Environment.UserName + ".txt";
               
                FileInfo file = new FileInfo(filePath);
                for (int tries = 0; IsFileLocked(file) && tries < 3; tries++)
                    Thread.Sleep(500);
                GC.Collect();
                GC.WaitForPendingFinalizers();

                string sourceFile = filePath;
                string destinationFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.Move(sourceFile, destinationFile);
                MessageBox.Show("Hey, logs were moved to Desktop, send me that file!", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (File.Exists(filePath))
                {
                    file.Delete();
                }
                else
                {
                    return;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString(), "Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}