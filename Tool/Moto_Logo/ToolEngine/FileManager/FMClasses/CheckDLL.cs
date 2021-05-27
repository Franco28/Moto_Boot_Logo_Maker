/* 
#####################################################################
#    File: CheckDLL.cs                                              #
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
using System.Windows.Forms;

namespace Moto_Logo
{
    public class CheckDLL
    {
        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public static CultureInfo cul = null;

        public static void openform(string filemissing)
        {
            var res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            MessageBox.Show(@"DLL: " + filemissing + " " + res_man.GetString("ToolDownloadsForm_File_Missing", cul), "Moto_Boot_Logo_Maker - DLL: " + filemissing, MessageBoxButtons.OK, MessageBoxIcon.Error);

            var form = new ToolLibsDownload();
            form.ShowDialog();
        }

        public static void dll()
        {
            if (!File.Exists(exePath + @"\HtmlAgilityPack.dll"))
            {
                openform("HtmlAgilityPack.dll");
            }
            else
            {
                if (!File.Exists(exePath + @"\Newtonsoft.Json.dll"))
                {
                    openform("Newtonsoft.Json.dll");
                }
                else
                {
                    return;
                }
            }
        }
    }
}