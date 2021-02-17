/* 
#####################################################################
#    File: LogoTest.cs                                              #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using RegawMOD.Android;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class LogoTest : Form
    {
        public CultureInfo cul;
        public ResourceManager res_man;
        Device device; AndroidController android = null; string serial;

        public LogoTest()
        {
            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            InitializeComponent();
            this.Text = res_man.GetString("LogoTestTitle", cul);
            buttonsavelogs.Text = res_man.GetString("LogoTestSaveLogsBTN", cul);
            groupBox1.Text = res_man.GetString("LogoTestRO", cul);
            groupBox2.Text = res_man.GetString("LogoTestSelectUDP", cul);
            buttonFlashLogo.Hide();
            groupBox2.Hide();
            groupBox1.Hide();
            buttonsavelogs.Hide();
            if (Properties.Settings.Default.Theme == "light")
            {
                LighTheme();
            }
        }

        private async void LogoTest_Load(object sender, EventArgs e)
        {
            cAppend(res_man.GetString("LogoTestADBstart", cul));
            IProgress<int> progress = new Progress<int>(
                value => { progressBar1.Value = value; });

            await Task.Run(() =>
            {
                progress.Report(50);
                android = AndroidController.Instance;
                progress.Report(70);
                cAppend(res_man.GetString("LogoTestADBstart", cul) + "... {OK}");
                progress.Report(90);
            });
            progressBar1.Hide();
            buttonFlashLogo.Show();
            groupBox1.Show();
            groupBox2.Show();
            buttonsavelogs.Show();
            console.Clear();
            isConnected();
            progress.Report(100);
        }

        #region theme

        private void LighTheme()
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.ForeColor = Color.FromArgb(38, 38, 38);

            groupBox2.BackColor = groupBox1.BackColor = console.BackColor = Color.FromArgb(255, 255, 255);
            groupBox2.ForeColor = groupBox1.ForeColor = console.ForeColor = Color.FromArgb(38, 38, 38);

            buttonsavelogs.FlatStyle = buttonFlashLogo.FlatStyle = FlatStyle.Flat;
            buttonsavelogs.BackColor = buttonFlashLogo.BackColor = Color.FromArgb(255, 255, 255);
            buttonsavelogs.ForeColor = buttonFlashLogo.ForeColor = Color.FromArgb(38, 38, 38);
        }

        #endregion theme

        public void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText(string.Format("\n{0} : {1}", DateTime.Now, message));
                console.ScrollToCaret();
            });
        }

        bool isConnected()
        {
            bool i = false;
            android.UpdateDeviceList();
            if (android.HasConnectedDevices)
            {
                serial = android.ConnectedDevices[0];
                device = android.GetConnectedDevice(serial);
                i = true;
                cAppend(res_man.GetString("LogoTestDeviceConnected", cul) + " " + serial.ToString());
            }
            else
                i = false;
            cAppend(res_man.GetString("LogoTestDeviceConnected", cul) + " " + i.ToString());
            return i;
        }

        private void buttonFlashLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonA.Checked == false && radioButtonAB.Checked == false)
                {
                    MessageBox.Show(res_man.GetString("LogoTestSelectYourDP", cul), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // A
                    if (radioButtonA.Checked == true)
                    {
                        DirectoryInfo dir = new DirectoryInfo(@"C:\adb\");
                        FileInfo[] files = dir.GetFiles("*.bin");
                        if (files.Length > 0)
                        {
                            foreach (FileInfo file in files)
                            {
                                openFileDialog1.InitialDirectory = @"C:\adb\";
                                openFileDialog1.Title = "Logo.bin";
                                openFileDialog1.Filter = @"Logo Files|*.bin";

                                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                                else
                                    cAppend("-------------");
                                var path = Path.GetExtension(openFileDialog1.FileName);
                                cAppend("File is: " + path);
                                if (openFileDialog1.FileName.EndsWith(path))
                                {
                                    cAppend("Path: " + openFileDialog1.FileName.ToString());
                                    if (isConnected())
                                    {
                                        if (radioButtonBootloader.Checked == true)
                                        {
                                            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot bootloader"));
                                        }
                                        cAppend("Flashing logo...");
                                        string flash = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(" flash logo " + openFileDialog1.FileName.ToString()));
                                        cAppend(flash.ToString());
                                        cAppend("Flashing logo... {OK}");
                                        Thread.Sleep(1000);
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show(res_man.GetString("LogoTestDeviceError", cul), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(res_man.GetString("LogTestWrongBin", cul) + " " + path, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            Application.DoEvents();
                        }
                        else
                        {
                            MessageBox.Show(res_man.GetString("LogoTestMoveThis", cul) + @" - C:\adb\", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Process.Start(@"C:\adb\");
                            return;
                        }
                    }

                    // A/B
                    if (radioButtonAB.Checked == true)
                    {
                        DirectoryInfo dir = new DirectoryInfo(@"C:\adb\");
                        FileInfo[] files = dir.GetFiles("*.bin");
                        if (files.Length > 0)
                        {
                            foreach (FileInfo file in files)
                            {
                                openFileDialog1.InitialDirectory = @"C:\adb\";
                                openFileDialog1.Title = "Logo.bin";
                                openFileDialog1.Filter = @"Logo Files|*.bin";

                                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                                else
                                    cAppend("-------------");
                                var path = Path.GetExtension(openFileDialog1.FileName);
                                cAppend("File is: " + path);
                                if (openFileDialog1.FileName.EndsWith(path))
                                {
                                    cAppend("Path: " + openFileDialog1.FileName.ToString());
                                    if (isConnected())
                                    {
                                        if (radioButtonBootloader.Checked == true)
                                        {
                                            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot bootloader"));
                                        }
                                        cAppend("Flashing logo_a...");
                                        Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(" flash logo_a " + openFileDialog1.FileName.ToString()));
                                        cAppend("Flashing logo_a... {OK}");
                                        MessageBox.Show(res_man.GetString("LogoTestLogoB", cul), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        openFileDialog2.InitialDirectory = @"C:\adb\";
                                        openFileDialog2.Title = "Logo.bin";
                                        openFileDialog2.Filter = @"Logo Files|*.bin";
                                        if (openFileDialog2.ShowDialog() != DialogResult.OK) return;
                                        else
                                        if (openFileDialog2.FileName.EndsWith(path))
                                        {
                                            cAppend("Flashing logo_b...");
                                            Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(" flash logo_b " + openFileDialog2.FileName.ToString()));
                                            cAppend("Flashing logo_b... {OK}");
                                            Thread.Sleep(3000);
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show(res_man.GetString("LogTestWrongBin", cul) + " " + path, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(res_man.GetString("LogoTestDeviceError", cul), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(res_man.GetString("LogTestWrongBin", cul) + " " + path, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            Application.DoEvents();
                        }
                        else
                        {
                            MessageBox.Show(res_man.GetString("LogoTestMoveThis", cul) + @" - C:\adb\", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Process.Start(@"C:\adb\");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(@"" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cAppend("ERROR TASK {FLASHING}: " + ex.ToString());
            }
        }

        private void buttonsavelogs_Click(object sender, EventArgs e)
        {
            try
            {
                console.SaveFile(@"C:\adb\Flash_Logo_Logs.txt", RichTextBoxStreamType.PlainText);
                Process.Start(@"C:\adb\");
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(res_man.GetString("LogoTestSaveLogsBTN", cul) + ": " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cAppend("ERROR TASK {SAVING LOGS}: " + ex.ToString());
            }
        }

        private void LogoTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void LogoTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string taskname = "adb";
                foreach (var process in Process.GetProcessesByName(taskname))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                cAppend("ERROR TASK {KILLING ADB SERVICES}: " + ex.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}