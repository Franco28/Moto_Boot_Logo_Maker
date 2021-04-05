/* 
#####################################################################
#    File: MainForm.BuildLogo.cs                                    #
#    Author: Franco28                                               # 
#    Date: 05-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */ 

using Ionic.Zip;
using Moto_Logo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DarkUI.Forms;
using System.Media;

namespace Moto_Logo
{
    public partial class MainForm
    {

        public BackgroundWorker backgroundWorkerLogBuild;

        private void btnBuild_Click(object sender, EventArgs e)
        {
            backgroundWorkerLogBuild.RunWorkerAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerLogBuild.IsBusy)
            {
                backgroundWorkerLogBuild.CancelAsync();
            }

            if (!backgroundWorkerLogBuild.IsBusy)
            {
                backgroundWorkerLogBuild.CancelAsync();
            }

            toolStripStatusLabel1.Text = res_man.GetString("LogoBinProcessAborted", cul);
            toolStripStatusLabel2.Text = "";
            Thread.Sleep(500);
            DirectoryInfo di = new DirectoryInfo(txtLogoBuildPath.Text);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        private void btnAttachPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                txtLogoBuildPath.Text = folderBrowserDialog1.SelectedPath + @"\";
                Properties.Profiles.Default.LogoPath = folderBrowserDialog1.SelectedPath + @"\";
                txtLogoBuildPath.Text = Properties.Profiles.Default.LogoPath;
                Properties.Profiles.Default.Save();
            }
        }

        private void btnOpenLogoFile_Click(object sender, EventArgs e)
        {
            if (txtLogoBuildPath.Text == string.Empty)
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(res_man.GetString("LogoBuildFolderError", cul), "Moto_Boot_Logo_Maker");
                return;
            }
            if (Directory.Exists(txtLogoBuildPath.Text))
            {
                Process.Start(txtLogoBuildPath.Text);
            }
            else
            {
                Directory.CreateDirectory(txtLogoBuildPath.Text);
                Process.Start(txtLogoBuildPath.Text);
            }
        }

        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        private void backgroundWorkerLogBuild_DoWork(object sender, DoWorkEventArgs e)
        {
            // Build Cancel
            if (backgroundWorkerLogBuild.CancellationPending)
            {
                e.Cancel = true;
                backgroundWorkerLogBuild.ReportProgress(0);
                backgroundWorkerLogBuild.CancelAsync();
                Reload();
                return;
            }

            // First Settings
            string LOGOpath = txtLogoBuildPath.Text;
            if (!Directory.Exists(LOGOpath))
            {
                Directory.CreateDirectory(LOGOpath);
            }
            labelbtnStop.Enabled = true;
            btnStop.Enabled = true;
            btnBuild.Enabled = true;
            labelbtnBuild.Enabled = true;
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel2.Visible = true;

            // File To Save Check
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            if (radioButtonBIN.Checked == false && radioButtonZIP.Checked == false)
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(res_man.GetString("CompileRadioBTNEmpty", cul), "Moto_Boot_Logo_Maker");
                return;
            }

            string pathbuild = txtLogoBuildPath.Text;
            if (!pathbuild.EndsWith(@"\"))
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(res_man.GetString("CompilePathISWrong", cul).Replace("<pathbuild>", txtLogoBuildPath.Text), "Moto_Boot_Logo_Maker");
                return;
            }

            if (String.IsNullOrEmpty(txtLogoBuildPath.Text) && String.IsNullOrEmpty(textLogoName.Text))
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(res_man.GetString("ComplieLNandPNEmpty", cul), "Moto_Boot_Logo_Maker");
                return;
            }
            else
            {
                try
                {
                    // LogoBuildEngine
                    labelbtnStop.Enabled = true;
                    btnStop.Enabled = true;
                    btnBuild.Enabled = false;
                    labelbtnBuild.Enabled = false;
                    var stream = new MemoryStream();
                    var errorCount = 0;
                    var blankCount = 0;
                    var errorproceed = false;

                    using (var writer = new BinaryWriter(stream))
                    {
                        if (backgroundWorkerLogBuild.CancellationPending)
                        {
                            e.Cancel = true;
                            backgroundWorkerLogBuild.ReportProgress(0);
                            backgroundWorkerLogBuild.CancelAsync();
                            return;
                        }

                        if (rdoAndroidRAW.Checked)
                        {
                            try
                            {
                                _tvLogoAfterSelectProcessing = true;
                                SetRadioButtons(Convert.ToInt32(tvLogo.Nodes[0].Name));
                                var img = FixedSizeSave(_loadedbitmaps[Convert.ToInt32(tvLogo.Nodes[0].Name)]);
                                _tvLogoAfterSelectProcessing = false;
                                writer.Write(encode_image(img));
                            }
                            catch
                            {
                                if (tvLogo.Nodes[0].Name != "")
                                {
                                    toolStripStatusLabel1.Text = res_man.GetString("ErrorLoadImage", cul);
                                    writer.Close();
                                    return;
                                }
                                if (MessageBox.Show(res_man.GetString("ContinueWithBlankImge", cul),
                                    @"Moto_Boot_Logo_Maker",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                                {
                                    toolStripStatusLabel1.Text = res_man.GetString("LogoBinProcessAborted", cul);
                                    writer.Close();
                                    return;
                                }
                                writer.Write(Resources._540x540);
                            }
                        }
                        else
                        {
                            var logoBootEmpty = false;
                            var logoBootIndex = -1;
                            var logoUnlockedEmpty = false;
                            var logoUnlockedIndex = -1;

                            var hashes = new List<byte[]>();
                            var offsets = new List<int>();
                            var sizes = new List<int>();

                            writer.Write(0x6F676F4C6F746F4DL);
                            writer.Write((byte)0);
                            writer.Write(0x0D + (tvLogo.Nodes.Count * 0x20));
                            var android43 = rdoAndroid43.Checked;
                            for (var i = 0; i < tvLogo.Nodes.Count; i++)
                            {
                                if (backgroundWorkerLogBuild.CancellationPending)
                                {
                                    e.Cancel = true;
                                    backgroundWorkerLogBuild.ReportProgress(0);
                                    backgroundWorkerLogBuild.CancelAsync();
                                    return;
                                }

                                writer.BaseStream.Position = 0x0D + (i * 0x20);
                                var name = Encoding.ASCII.GetBytes(tvLogo.Nodes[i].Text);
                                writer.Write(name);
                                writer.Write(new byte[0x20 - name.Length]);
                                switch (tvLogo.Nodes[i].Text)
                                {
                                    case "logo_boot":
                                        logoBootIndex = i;
                                        logoBootEmpty = tvLogo.Nodes[i].Name == "";
                                        break;
                                    case "logo_unlocked":
                                        logoUnlockedIndex = i;
                                        logoUnlockedEmpty = tvLogo.Nodes[i].Name == "";
                                        break;
                                }
                            }

                            var sectorfillstr = Encoding.ASCII.GetBytes("*---==|This amazing Moto Boot Logo was created with \"" +
                                            Application.ProductName + " " +
                                            Application.ProductVersion + "\" MOD By @Franco28|==---*");
                            writer.Write(-2);
                            var cboMotoItem = (string)cboMoto.SelectedItem;
                            writer.Write(Encoding.UTF8.GetBytes(cboMotoItem).Length);
                            writer.Write(Encoding.UTF8.GetBytes(cboMotoItem));
                            writer.Write(sectorfillstr.Length);
                            writer.Write(sectorfillstr);
                            writer.Write(Encoding.UTF8.GetBytes(txtComments.Text).Length);
                            writer.Write(Encoding.UTF8.GetBytes(txtComments.Text));
                            writer.Write((UInt16)udResolutionX.Value);
                            writer.Write((UInt16)udResolutionY.Value);

                            var bothLogoEmpty = ((logoBootIndex == -1) || logoBootEmpty) &&
                                                 ((logoUnlockedIndex == -1) || logoUnlockedEmpty);
                            for (var i = 0; i < tvLogo.Nodes.Count; i++)
                            {
                                if (backgroundWorkerLogBuild.CancellationPending)
                                {
                                    e.Cancel = true;
                                    backgroundWorkerLogBuild.ReportProgress(0);
                                    backgroundWorkerLogBuild.CancelAsync();
                                    return;
                                }

                                toolStripStatusLabel1.Text = res_man.GetString("LogoBinProccesing", cul) + @": " + tvLogo.Nodes[i].Text;
                                toolStripStatusLabel2.Text = " - " + res_man.GetString("LogoBinStatus", cul) + " " + i.ToString();
                                while ((writer.BaseStream.Position % 0x200) != 0)
                                    writer.Write((byte)0xFF);
                                byte[] result;
                                try
                                {
                                    _tvLogoAfterSelectProcessing = true;
                                    SetRadioButtons(Convert.ToInt32(tvLogo.Nodes[i].Name));
                                    var img = FixedSizeSave(_loadedbitmaps[Convert.ToInt32(tvLogo.Nodes[i].Name)]);
                                    result = encode_image(img);
                                    _tvLogoAfterSelectProcessing = false;
                                    if (!errorproceed && (errorCount > 0))
                                    {
                                        if (MessageBox.Show(res_man.GetString("ImageLoadFail", cul),
                                            @"Moto_Boot_Logo_Maker",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2) == DialogResult.No)
                                        {
                                            toolStripStatusLabel1.Text = res_man.GetString("LogoBinProcessAborted", cul);
                                            writer.Close();
                                            return;
                                        }
                                        errorproceed = true;
                                    }
                                }
                                catch
                                {
                                    if (tvLogo.Nodes[i].Name != "")
                                        errorCount++;
                                    else
                                        blankCount++;
                                    if ((blankCount == tvLogo.Nodes.Count) &&
                                       (MessageBox.Show(res_man.GetString("NoImageLoad", cul),
                                       @"Moto_Boot_Logo_Maker",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question,
                                       MessageBoxDefaultButton.Button2) == DialogResult.No))
                                    {
                                        toolStripStatusLabel1.Text = res_man.GetString("LogoBinProcessAborted", cul);
                                        writer.Close();
                                        return;
                                    }
                                    if (((errorCount + blankCount) == tvLogo.Nodes.Count) && (errorCount > 0))
                                    {
                                        toolStripStatusLabel1.Text = res_man.GetString("AllImageFailed", cul);
                                        writer.Close();
                                        return;
                                    }
                                    _tvLogoAfterSelectProcessing = true;
                                    SetRadioButtons(ImageOption.ImageOptionCenter, ImageLayout.ImageLayoutPortrait);
                                    _tvLogoAfterSelectProcessing = false;

                                    switch (tvLogo.Nodes[i].Text)
                                    {
                                        case "logo_lowpower":
                                            result = encode_image(FixedSizeSave(Resources.logo_lowpower));
                                            break;
                                        case "logo_battery":
                                            result = encode_image(FixedSizeSave(Resources.logo_battery));
                                            break;
                                        case "logo_unplug":
                                            result = encode_image(FixedSizeSave(Resources.logo_unplug));
                                            break;
                                        case "logo_charge":
                                            result = encode_image(FixedSizeSave(Resources.logo_charge));
                                            break;
                                        case "logo_yellow":
                                            result = encode_image(FixedSizeSave(Resources.logo_yellow));
                                            break;
                                        case "logo_red":
                                            result = encode_image(FixedSizeSave(Resources.logo_red));
                                            break;
                                        case "logo_orange":
                                            result = encode_image(FixedSizeSave(Resources.logo_orange));
                                            break;
                                        case "logo_unlocked":
                                        case "logo_boot":
                                            if (!bothLogoEmpty)
                                                continue;
                                            result = encode_image(FixedSizeSave(Resources.logo_boot));
                                            break;
                                        default:
                                            result = android43
                                                ? Resources._540x540
                                                : Resources.motorun;
                                            break;
                                    }
                                }

                                var tempoffset = (int)writer.BaseStream.Position;
                                var tempsize = result.Length;
                                var hash = SHA256.Create().ComputeHash(result);
                                var hashmatch = false;
                                for (var j = 0; j < hashes.Count; j++)
                                {
                                    if (backgroundWorkerLogBuild.CancellationPending)
                                    {
                                        e.Cancel = true;
                                        backgroundWorkerLogBuild.ReportProgress(0);
                                        backgroundWorkerLogBuild.CancelAsync();
                                        return;
                                    }

                                    if (!hashes[j].SequenceEqual(hash)) continue;
                                    hashmatch = true;
                                    tempoffset = offsets[j];
                                    tempsize = sizes[j];
                                    break;
                                }

                                if ((logoBootIndex == i) && (logoUnlockedIndex > -1) && logoUnlockedEmpty)
                                {
                                    writer.BaseStream.Position = 0x0D + (logoUnlockedIndex * 0x20) + 0x18;
                                    writer.Write(tempoffset);
                                    writer.Write(tempsize);
                                    writer.BaseStream.Position = tempoffset;
                                }
                                if ((logoUnlockedIndex == i) && (logoBootIndex > -1) && logoBootEmpty)
                                {
                                    writer.BaseStream.Position = 0x0D + (logoBootIndex * 0x20) + 0x18;
                                    writer.Write(tempoffset);
                                    writer.Write(tempsize);
                                    writer.BaseStream.Position = tempoffset;
                                }

                                if (!hashmatch)
                                {
                                    hashes.Add(hash);
                                    offsets.Add(tempoffset);
                                    sizes.Add(result.Length);
                                    writer.Write(result);
                                }

                                writer.BaseStream.Position = 0x0D + 0x18 + (i * 0x20);
                                writer.Write(tempoffset);
                                writer.Write(tempsize);
                                writer.BaseStream.Position = writer.BaseStream.Length;
                                if (writer.BaseStream.Length <= _maxFileSize) continue;
                                toolStripStatusLabel1.Text = res_man.GetString("ErrorLogoFitImage", cul) + ": " + tvLogo.Nodes[i].Text + " " + res_man.GetString("ErrorLogoFitImage2", cul) + " " + (writer.BaseStream.Length - _maxFileSize) + " " + res_man.GetString("ErrorLogoFitImage3", cul);
                                return;
                            }
                        }
                    }

                    // ZIP LOGO
                    if (radioButtonBIN.Checked == true || radioButtonZIP.Checked == true)
                    {
                        string pathbuild2 = txtLogoBuildPath.Text + textLogoName.Text;
                        if (radioButtonZIP.Checked == true && radioButtonBIN.Checked == false)
                        {
                            using (var zip = new ZipFile())
                            {
                                if (backgroundWorkerLogBuild.CancellationPending)
                                {
                                    e.Cancel = true;
                                    backgroundWorkerLogBuild.ReportProgress(0);
                                    backgroundWorkerLogBuild.CancelAsync();
                                    return;
                                }

                                if (File.Exists(exePath + @"\Files\LogoZip\updater-script") && File.Exists(exePath + @"\Files\LogoZip\update-binary"))
                                {
                                    zip.AddEntry("logo.bin", stream.ToArray());
                                    zip.AddDirectoryByName("META-INF");
                                    zip.AddDirectoryByName("META-INF\\com");
                                    zip.AddDirectoryByName("META-INF\\com\\google");
                                    zip.AddDirectoryByName("META-INF\\com\\google\\android");
                                    zip.AddEntry("META-INF\\com\\google\\android\\updater-script", File.ReadAllBytes(exePath + @"\Files\LogoZip\updater-script"));
                                    zip.AddEntry("META-INF\\com\\google\\android\\update-binary", File.ReadAllBytes(exePath + @"\Files\LogoZip\update-binary"));
                                    zip.Save(pathbuild2 + ".zip");
                                }
                                else
                                {
                                    SystemSounds.Exclamation.Play();
                                    DarkMessageBox.ShowWarning(res_man.GetString("LogoBuildZipFileM", cul), res_man.GetString("LogoBuildZipFileMTitle", cul));
                                    File.WriteAllBytes(pathbuild2 + ".bin", stream.ToArray());
                                    toolStripStatusLabel1.Text = res_man.GetString("LogoBinProcessOk", cul);
                                    labelbtnStop.Enabled = false;
                                    btnStop.Enabled = false;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            File.WriteAllBytes(pathbuild2 + ".bin", stream.ToArray());
                        }
                        toolStripStatusLabel1.Text = res_man.GetString("LogoBinProcessOk", cul);
                        labelbtnStop.Enabled = false;
                        btnStop.Enabled = false;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = res_man.GetString("LogoBinProcessAborted", cul);
                        labelbtnStop.Enabled = false;
                        btnStop.Enabled = false;
                        return;
                    }

                    // Apply Latest Settings
                    Properties.Settings.Default.LogoWasSaved = true;
                    Properties.Settings.Default.Save();
                    labelbtnStop.Enabled = false;
                    btnStop.Enabled = false;
                    string LOGOpath2 = txtLogoBuildPath.Text;
                    var dir2 = new DirectoryInfo(LOGOpath2);
                    if (IsDirectoryEmpty(LOGOpath2) == false)
                    {
                        dir2.Attributes = dir2.Attributes & ~FileAttributes.Hidden;
                    }
                }
                catch (Exception ex)
                {
                    Logs.DebugErrorLogs(ex);
                    ProgressBar.Visible = false;
                    toolStripStatusLabel1.Text = res_man.GetString("FileSaveError", cul) + @": " + ex.GetBaseException();
                    labelbtnStop.Enabled = false;
                    btnStop.Enabled = false;
                    labelbtnBuild.Enabled = false;
                    btnBuild.Enabled = false;
                }
            }
            // Done
            backgroundWorkerLogBuild.ReportProgress(100);
            labelbtnStop.Enabled = false;
            btnStop.Enabled = false;
            labelbtnBuild.Enabled = true;
            btnBuild.Enabled = true;
        }

        private byte[] encode_image(Bitmap img)
        {
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);
            ProgressBar.Visible = true;
            ProgressBar.Minimum = 0;
            ProgressBar.Value = 0;
            ProgressBar.Maximum = img.Height;
            Application.DoEvents();
            if (!rdoAndroid44.Checked)
            {
                for (var y = 0; y < 540; y++)
                {

                    for (var x = 0; x < 540; x++)
                    {
                        writer.Write(img.GetPixel(x, y).B);
                        writer.Write(img.GetPixel(x, y).G);
                        writer.Write(img.GetPixel(x, y).R);
                    }
                    ProgressBar.Value++;
                    Application.DoEvents();
                }
            }
            else
            {
                writer.Write(0x006E75526F746F4DL);
                writer.Write((byte)(img.Width >> 8));
                writer.Write((byte)(img.Width & 0xFF));
                writer.Write((byte)(img.Height >> 8));
                writer.Write((byte)(img.Height & 0xFF));

                for (var y = 0; y < img.Height; y++)
                {
                    var colors = new Color[img.Width];
                    for (var x = 0; x < img.Width; x++)
                        colors[x] = Color.FromArgb(255, img.GetPixel(x, y));
                    var compress = compress_row(colors);
                    writer.Write(compress);
                    ProgressBar.Value++;
                    Application.DoEvents();
                }
            }
            ProgressBar.Visible = false;
            Application.DoEvents();
            return stream.ToArray();
        }

        private static byte[] compress_row(IList<Color> colors)
        {
            var j = 0;
            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);
            while (j < colors.Count)
            {
                var k = j;
                while ((k < colors.Count) && (colors[j] == colors[k]))
                {
                    k++;
                }
                if ((k - j) > 1)
                {
                    writer.Write((byte)(0x80 | ((k - j) >> 8)));
                    writer.Write((byte)((k - j) & 0xFF));
                    writer.Write(colors[j].B);
                    writer.Write(colors[j].G);
                    writer.Write(colors[j].R);
                    j = k;
                }
                else
                {
                    var l = k;
                    int m;
                    do
                    {
                        k = l - 1;
                        while ((l < colors.Count) && (colors[k] != colors[l]))
                        {
                            k++;
                            l++;
                        }
                        while ((l < colors.Count) && (colors[k] == colors[l]))
                        {
                            l++;
                        }
                        if (l == colors.Count)
                            break;
                        m = l;
                        while ((m < colors.Count) && (colors[l] == colors[m]))
                        {
                            m++;
                        }
                    }
                    while (((l - k) < 3) && ((m - l) < 2));
                    if ((k - j) == 0)
                    {
                        writer.Write((byte)0);
                        writer.Write((byte)1);
                        writer.Write(colors[colors.Count - 1].B);
                        writer.Write(colors[colors.Count - 1].G);
                        writer.Write(colors[colors.Count - 1].R);
                        break;
                    }
                    if (k == (colors.Count - 1))
                        k++;
                    writer.Write((byte)((k - j) >> 8));
                    writer.Write((byte)((k - j) & 0xFF));
                    for (l = 0; l < (k - j); l++)
                    {
                        writer.Write(colors[j + l].B);
                        writer.Write(colors[j + l].G);
                        writer.Write(colors[j + l].R);
                    }
                    j = k;
                }
            }
            return stream.ToArray();
        }

        private void backgroundWorkerLogBuild_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                SystemSounds.Exclamation.Play();
                DarkMessageBox.ShowWarning(res_man.GetString("LogoBuildCancel", cul), "Moto_Boot_Logo_Maker");
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel2.Text = "";
                ProgressBar.Visible = false;
                labelbtnStop.Enabled = false;
                btnStop.Enabled = false;
                labelbtnBuild.Enabled = true;
                btnBuild.Enabled = true;
                return;
            }
            else if (e.Error != null)
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(res_man.GetString("LogoBuildError", cul), "Moto_Boot_Logo_Maker");
                labelbtnStop.Enabled = false;
                btnStop.Enabled = false;
                labelbtnBuild.Enabled = true;
                btnBuild.Enabled = true;
            }
            else
            {
                SystemSounds.Exclamation.Play();
                DarkMessageBox.ShowInformation(res_man.GetString("LogoBuildOK", cul), "Moto_Boot_Logo_Maker");
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel2.Text = "";
                ProgressBar.Visible = false;
                labelbtnStop.Enabled = false;
                btnStop.Enabled = false;
                labelbtnBuild.Enabled = true;
                btnBuild.Enabled = true;
                return;
            }
        }
    }
}