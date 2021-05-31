/* 
#####################################################################
#    File: MainForm.ToolStrip.cs                                    #
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
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class MainForm
    {
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region OpenNewLogo
            var openfilename = Properties.Settings.Default.LogoBinOpen;
            if (Properties.Settings.Default.LogoBinOpen.EndsWith(".bin") && Properties.Settings.Default.LogoWasSaved == false)
            {
                DialogResult dialogResult = MessageBox.Show(res_man.GetString("MainForm_ExitLogoWasntSave1", cul) + "\n\n" + openfilename + "\n\n" + res_man.GetString("MainForm_ExitLogoWasntSave2", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ImageStatusBox.Clear();
                    ImageStatusBoxMSG(res_man.GetString("MainForm_ImageStatus_TextLocked", cul));
                    ImageStatusBoxMSG(res_man.GetString("MainForm_ImageStatus_TextUnlocked", cul));
                    Properties.Settings.Default.LogoBinOpen = "";
                    Properties.Settings.Default.Save();
                    buttonAppend.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonExtract.Enabled = true;
                    IniUITool();
                }
                else if (dialogResult == DialogResult.No)
                {
                    try
                    {
                        return;
                    }
                    catch (Exception ex)
                    {
                        Logs.DebugErrorLogs(ex);
                        MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                ImageStatusBox.Clear();
                ImageStatusBoxMSG(res_man.GetString("MainForm_ImageStatus_TextLocked", cul));
                ImageStatusBoxMSG(res_man.GetString("MainForm_ImageStatus_TextUnlocked", cul));
                Properties.Settings.Default.LogoBinOpen = "";
                Properties.Settings.Default.Save();
                buttonAppend.Enabled = true;
                buttonDelete.Enabled = true;
                buttonExtract.Enabled = true;
                IniUITool();
            }
            #endregion OpenNewLogo
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region OpenLogoFile
            if (radioButton4mib.Checked == false && radioButton6MIB.Checked == false && radioButton8MIB.Checked == false && radioButton16MIB.Checked == false && radioButton32MIB.Checked == false)
            {
                MessageBox.Show(res_man.GetString("MainForm_SelectLogoSizeWarn", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var selectdevicetest = new SelectDevice();
                selectdevicetest.Show();
                return;
            }
            #endregion OpenLogoFile
        }

        private void toolStripMenuItemOpenCustomLogo_Click(object sender, EventArgs e)
        {
            #region OpenLogoFileAdmin
            if (CheckAdmin.IsUserAdministrator() == true)
            {
                if (radioButton4mib.Checked == false && radioButton6MIB.Checked == false && radioButton8MIB.Checked == false && radioButton16MIB.Checked == false && radioButton32MIB.Checked == false)
                {
                    MessageBox.Show(res_man.GetString("MainForm_SelectLogoSizeWarn", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MainOpenFileDialog.Filter = @"BIN file|*.bin|ZIP file|*.zip";
                    MainOpenFileDialog.InitialDirectory = userdesktoppath;
                    if (MainOpenFileDialog.ShowDialog() != DialogResult.OK) return;
                    OpenFile(MainOpenFileDialog.FileName);
                    Properties.Settings.Default.LogoBinOpen = MainOpenFileDialog.FileName.ToString();
                    Properties.Settings.Default.Save();
                    toolStripStatusLabel3.Text = @"\ " + res_man.GetString("MainForm_CurrentProjectText", cul) + Properties.Settings.Default.LogoBinOpen;
                    EnableControlsWhenLoadLogo();
                }
            }
            else
            {
                MessageBox.Show(res_man.GetString("MainForm_OpenCustomLogoNoAdminTool", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion OpenLogoFileAdmin
        }

        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternetCheck.CheckInternetProcessStart("https://github.com/Franco28/Moto_Boot_Logo_Maker#readme");
        }

        private void downloadSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                var s = new DownloadS();
                if (s.IsDisposed == false)
                {
                    s.Show();
                }
                else
                {
                    s.Dispose();
                }
            }
        }
    }
}