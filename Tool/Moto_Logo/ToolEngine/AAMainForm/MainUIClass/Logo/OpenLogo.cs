/* 
#####################################################################
#    File: MainForm.OpenLogo.cs                                     #
#    Author: Franco28                                               # 
#    Date: 22-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;

namespace Moto_Logo
{
    public partial class MainForm
    {
        public static byte[] ExtractLogoBin(string zipfilename)
        {
            byte[] buffer = null;
            using (var input = new ZipInputStream(zipfilename))
            {
                ZipEntry e;
                while ((e = input.GetNextEntry()) != null)
                {
                    if (e.IsDirectory) continue;
                    if (Path.GetFileName(e.FileName) != "logo.bin") continue;
                    buffer = new byte[e.UncompressedSize];
                    input.Read(buffer, 0, buffer.Length);
                    break;
                }
            }
            return buffer;
        }

        // ReSharper disable once InconsistentNaming
        public Bitmap Decode540x540Image(BinaryReader reader)
        {
            var img = new Bitmap(540, 540, PixelFormat.Format24bppRgb);
            ProgressBar.Visible = true;
            ProgressBar.Maximum = 540;
            ProgressBar.Value = 0;
            ProgressBar.Minimum = 0;
            Application.DoEvents();

            for (var y = 0; y < 540; y++)
            {
                for (var x = 0; x < 540; x++)
                {
                    var blue = reader.ReadByte();
                    var green = reader.ReadByte();
                    var red = reader.ReadByte();
                    img.SetPixel(x, y,
                        Color.FromArgb(blue, green, red));
                }
                ProgressBar.Value++;
                Application.DoEvents();
            }
            ProgressBar.Visible = false;
            Application.DoEvents();
            return img;
        }

        public void OpenFile(string filename)
        {
            var zipFile = false;
            byte[] logobin = null;

            try
            {
                if (ZipFile.IsZipFile(filename))
                {
                    zipFile = true;
                    if ((logobin = ExtractLogoBin(filename)) == null)
                    {
                        toolStripStatusLabel1.Text = res_man.GetString("Zipfile_logo_bin_error", cul).Replace("<ZFN>", filename);
                        Logs.LogoOpenError(res_man.GetString("Zipfile_logo_bin_error", cul).Replace("<ZFN>", filename));
                        Application.DoEvents();
                        return;
                    }
                }
                Stream stream;
                try
                {
                    if (zipFile)
                    {
                        stream = new MemoryStream(logobin);
                    }
                    else
                    {
                        stream = new FileStream(filename, FileMode.Open);
                    }
                }
                catch (Exception ex)
                {
                    Logs.DebugErrorLogs(ex);
                    ProgressBar.Visible = false;
                    toolStripStatusLabel1.Text = res_man.GetString("FileOpenError", cul).Replace("<FN>", filename);
                    Logs.LogoOpenError(res_man.GetString("FileOpenError", cul).Replace("<FN>", filename) + " Error: " + ex.ToString());
                    return;
                }

                using (var reader = new BinaryReader(stream))
                {
                    _tvLogoAfterSelectProcessing = true;
                    pictureBox1.Image = new Bitmap(1, 1);
                    var android43 = false;
                    cboMoto.SelectedIndex = 0;
                    rdoAndroid44.Checked = true;
                    rdoImageCenter.Checked = true;
                    rdoLayoutPortrait.Checked = true;
                    udResolutionX.Value = 720;
                    udResolutionY.Value = 1280;
                    tvLogo.Nodes.Clear();
                    ClearBitmapList();
                    Bitmap img;
                    if ((reader.ReadInt64() != 0x6F676F4C6F746F4DL) || (reader.ReadByte() != 0x00))
                    {
                        if (reader.BaseStream.Length != 0xD5930)
                        {
                            toolStripStatusLabel1.Text = res_man.GetString("LogoBinInvalid", cul);
                            return;
                        }
                        reader.BaseStream.Position = 0;
                        rdoAndroidRAW.Checked = true;
                        img = Decode540x540Image(reader);

                        AddToBitmapList(img,
                            Path.GetFileName(filename) + (zipFile
                                ? @"\logo.bin\logo_unlocked"
                                : @"\logo_unlocked"),
                            "logo_unlocked");
                        toolStripStatusLabel1.Text = res_man.GetString("LogoBinProcessOk", cul);
                        return;
                    }
                    var count = (reader.ReadInt32() - 0x0D) / 0x20;
                    var name = new string[count];
                    var offset = new Int32[count];
                    var size = new Int32[count];
                    for (var i = 0; i < count; i++)
                    {
                        reader.BaseStream.Position = 0x0D + (0x20 * i);
                        name[i] = Encoding.ASCII.GetString(reader.ReadBytes(0x18)).Split('\0')[0];
                        offset[i] = reader.ReadInt32();
                        size[i] = reader.ReadInt32();
                    }
                    var comment = "";
                    var temp = reader.ReadInt32();
                    switch (temp)
                    {
                        case -2:
                            {
                                temp = reader.ReadInt32();
                                var device = Encoding.UTF8.GetString(reader.ReadBytes(temp));
                                for (var i = 0; i < cboMoto.Items.Count; i++)
                                {
                                    if ((string)cboMoto.Items[i] != device) continue;
                                    cboMoto.SelectedIndex = i;
                                    break;
                                }

                                temp = reader.ReadInt32();
                                txtComments.Text = Encoding.ASCII.GetString(reader.ReadBytes(temp)).Replace("@TeamDeluxe", "@Franco28").Trim();
                                temp = reader.ReadInt32();
                                comment = Encoding.UTF8.GetString(reader.ReadBytes(temp));
                                Properties.Settings.Default.LogoMessage = txtComments.Text.ToString();
                                Properties.Settings.Default.Save();

                                if (cboMoto.SelectedIndex == 0)
                                {
                                    var resx = reader.ReadUInt16();
                                    var resy = reader.ReadUInt16();

                                    if (resx != 0xFFFF)
                                        udResolutionX.Value = resx;
                                    if (resy != 0xFFFF)
                                        udResolutionY.Value = resy;
                                }
                                Application.DoEvents();
                            }
                            break;
                    }

                    reader.BaseStream.Position = offset[0];

                    if (reader.ReadInt64() != 0x006E75526F746F4DL)
                    {
                        android43 = true;
                        rdoAndroid43.Checked = true;
                    }
                    for (var i = 0; i < count; i++)
                    {
                        toolStripStatusLabel1.Text = res_man.GetString("LogoBinProccesing", cul) + ": " + name[i];
                        ProgressBar.Value = 0;
                        Application.DoEvents();

                        if (!android43)
                        {
                            reader.BaseStream.Position = offset[i] + 8;
                            var x = (UInt16)(reader.ReadByte() << 8);
                            x |= reader.ReadByte();
                            var y = (UInt16)(reader.ReadByte() << 8);
                            y |= reader.ReadByte();
                            if (x > udResolutionX.Value)
                                udResolutionX.Value = x;
                            if (y > udResolutionY.Value)
                                udResolutionY.Value = y;
                            img = new Bitmap(x, y, PixelFormat.Format24bppRgb);
                            var xx = 0;
                            var yy = 0;
                            ProgressBar.Visible = true;
                            ProgressBar.Maximum = y;
                            ProgressBar.Value = 0;
                            ProgressBar.Minimum = 0;
                            Application.DoEvents();
                            while (yy < y)
                            {
                                var pixelcount = (UInt16)(reader.ReadByte() << 8);
                                pixelcount |= reader.ReadByte();
                                var repeat = (pixelcount & 0x8000) == 0x8000;
                                pixelcount &= 0x7FFF;

                                int red, green, blue;

                                if (repeat)
                                {
                                    blue = reader.ReadByte();
                                    green = reader.ReadByte();
                                    red = reader.ReadByte();
                                    while (pixelcount-- > 0)
                                    {
                                        img.SetPixel(xx++, yy,
                                            Color.FromArgb(red, green, blue));
                                        if (xx != x) continue;
                                        ProgressBar.Value++;
                                        Application.DoEvents();
                                        xx = 0;
                                        yy++;
                                        if (yy == y) break;
                                    }
                                }
                                else
                                {
                                    while (pixelcount-- > 0)
                                    {
                                        blue = reader.ReadByte();
                                        green = reader.ReadByte();
                                        red = reader.ReadByte();
                                        img.SetPixel(xx++, yy,
                                            Color.FromArgb(red, green, blue));
                                        if (xx != x) continue;
                                        ProgressBar.Value++;
                                        Application.DoEvents();
                                        xx = 0;
                                        yy++;
                                        if (yy == y) break;
                                    }
                                }
                            }
                            ProgressBar.Visible = false;
                            Application.DoEvents();
                        }
                        else
                        {
                            reader.BaseStream.Position = offset[i];
                            img = Decode540x540Image(reader);
                        }
                        AddToBitmapList(img,
                            Path.GetFileName(filename) + (zipFile
                                ? @"\logo.bin\"
                                : @"\") + name[i],
                            name[i]);
                    }
                    txtComments.Text = comment;
                    _tvLogoAfterSelectProcessing = false;
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProgressBar.Visible = false;
                toolStripStatusLabel1.Text = @"Error: " + ex.GetBaseException();
                Logs.LogoOpenError(@"Error: " + ex.GetBaseException());
                return;
            }

            toolStripStatusLabel1.Text = res_man.GetString("FileLoadOk", cul);
        }
    }
}