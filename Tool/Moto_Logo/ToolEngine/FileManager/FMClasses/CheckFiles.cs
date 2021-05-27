/* 
#####################################################################
#    File: CheckFiles.cs                                            #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Moto_Logo
{
    public class CheckFiles
    {
        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public static CultureInfo cul = null;

        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public static void openform(string filemissing)
        {
            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            MessageBox.Show(res_man.GetString("ToolDownloadsForm_File_Missing2", cul) + " " + filemissing + " " + res_man.GetString("ToolDownloadsForm_File_Missing3", cul), "Moto_Boot_Logo_Maker" , MessageBoxButtons.OK, MessageBoxIcon.Error);

            var form = new CheckFilesDownload();
            form.ShowDialog();
        }

        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }

        public static void CheckFSize(string dirpath, int size, string foldername)
        {
            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            if (DirSize(new DirectoryInfo(dirpath)) != size)
            {
                MessageBox.Show(res_man.GetString("ToolDownloadsForm_File_Error", cul) + " " + dirpath + ", " + res_man.GetString("ToolDownloadsForm_File_Error2", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);

                openform(foldername);
            }
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
                                    CheckFSize(exePath + @"\Files\LogoZip\", 208425, @"\Files\LogoZip\");
                                    CheckFSize(exePath + @"\Files\Bin\4MB\", 5318719, @"\Files\Bin\4MB\");
                                    CheckFSize(exePath + @"\Files\Bin\6MB\", 3348696, @"\Files\Bin\6MB\");
                                    CheckFSize(exePath + @"\Files\Bin\8MB\", 12513554, @"\Files\Bin\8MB\");
                                    CheckFSize(exePath + @"\Files\Bin\16MB\", 81354833, @"\Files\Bin\16MB\");
                                    CheckFSize(exePath + @"\Files\Bin\32MB\", 86740758, @"\Files\Bin\32MB\");
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