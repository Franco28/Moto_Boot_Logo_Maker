/* 
#####################################################################
#    File: MainForm.DragDrop.cs                                     #
#    Author: Franco28                                               # 
#    Date: 31-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class MainForm
    {
        #region DragAndDrop
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.None;
                if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if ((files.Count() == 1) && ((Path.GetExtension(files[0]) == ".bin") ||
                                            (Path.GetExtension(files[0]) == ".zip")))
                    e.Effect = DragDropEffects.Copy;
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if ((files.Count() == 1) && ((Path.GetExtension(files[0]) == ".bin") ||
                                         (Path.GetExtension(files[0]) == ".zip")))
            {
                if (radioButton4mib.Checked == false && radioButton6MIB.Checked == false && radioButton8MIB.Checked == false && radioButton16MIB.Checked == false && radioButton32MIB.Checked == false)
                {
                    MessageBox.Show(res_man.GetString("MainForm_SelectLogoSizeWarn", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    OpenFile(files[0]);
                    Properties.Settings.Default.LogoBinOpen = files[0].ToString();
                    Properties.Settings.Default.Save();
                    toolStripStatusLabel3.Text = @"\ " + res_man.GetString("MainForm_CurrentProjectText", cul) + Properties.Settings.Default.LogoBinOpen;
                    EnableControlsWhenLoadLogo();
                }
            }
        }
        #endregion DragAndDrop
    }
}