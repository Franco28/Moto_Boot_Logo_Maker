/* 
#####################################################################
#    File: CheckDLL.cs                                              #
#    Author: Franco28                                               # 
#    Date: 17-02-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.IO;
using System.Windows.Forms;

namespace Moto_Logo
{
    public class CheckDLL
    {
        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public static void openform(string filemissing)
        {
            MessageBox.Show(@"DLL: " + filemissing + " is missing, downloading...", "Moto_Boot_Logo_Maker dll missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var form = new ToolLibsDownload();
            form.ShowDialog();
        }

        public static void dll()
        {
            if (!File.Exists(exePath + @"\AndroidLib.dll"))
            {
                openform("AndroidLib.dll");
            }
            else
            {
                if (!File.Exists(exePath + @"\HtmlAgilityPack.dll"))
                {
                    openform("HtmlAgilityPack.dll");
                }
                else
                {
                    return;
                }
            }
        }
    }
}