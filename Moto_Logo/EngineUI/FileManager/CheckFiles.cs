/* 
#####################################################################
#    File: CheckFiles.cs                                            #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Moto_Logo
{
    public class CheckFiles
    {
        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        
        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public static void openform(string filemissing)
        {
            MessageBox.Show(@"Files from: " + filemissing + " are missing, downloading files again...", "Moto_Boot_Logo_Maker files missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var form = new CheckFilesDownload();
            form.ShowDialog();
        }

        public static void files()
        {
            if (IsDirectoryEmpty(exePath + @"\Files\LogoZip\") == true)
            {
                openform(@"\Files\LogoZip\");
            }
            else
            {
                if (IsDirectoryEmpty(exePath + @"\Files\Bin\4MB\") == true)
                {
                    openform(@"\Files\Bin\4MB\");
                }
                else
                {
                    if (IsDirectoryEmpty(exePath + @"\Files\Bin\6MB\") == true)
                    {
                        openform(@"\Files\Bin\6MB\");
                    }
                    else
                    {
                        if (IsDirectoryEmpty(exePath + @"\Files\Bin\8MB\") == true)
                        {
                            openform(@"\Files\Bin\8MB\");
                        }
                        else
                        {
                            if (IsDirectoryEmpty(exePath + @"\Files\Bin\16MB\") == true)
                            {
                                openform(@"\Files\Bin\16MB\");
                            }
                            else
                            {
                                if (IsDirectoryEmpty(exePath + @"\Files\Bin\32MB\") == true)
                                {
                                    openform(@"\Files\Bin\32MB\");
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}