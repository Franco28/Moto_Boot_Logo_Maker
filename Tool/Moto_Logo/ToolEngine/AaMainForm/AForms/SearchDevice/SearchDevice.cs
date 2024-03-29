﻿/* 
#####################################################################
#    File: MainForm.SearchDevice.cs                                 #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Moto_Logo.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class MainForm
    {
        public void CallForm(string title, string dname, string dcn, string reso, string mem, long logosize, string logopath, string logopath2, Bitmap picture)
        {
            Form fc = Application.OpenForms["DeviceInfo"];
            if (fc != null)
            {
                MessageBox.Show(res_man.GetString("SearchDeviceForm_AlreadyOpened", cul) + " " + fc.Text + ", " + res_man.GetString("SearchDeviceForm_AlreadyOpened2", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fc.BringToFront();
            }
            else
            {
                var searchdevice = new DeviceInfo();
                textBoxSearchDevice.Text = "";
                try
                {
                    Stream stream;
                    stream = new FileStream(logopath, FileMode.Open);
                    using (var reader = new BinaryReader(stream))
                    {
                        if ((reader.ReadInt64() != 0x6F676F4C6F746F4DL) || (reader.ReadByte() != 0x00))
                        {
                            if (reader.BaseStream.Length != 0xD5930)
                            {
                                return;
                            }
                            reader.BaseStream.Position = 0;
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
                                    searchdevice.labelLogoComment.Text = "Logo " + res_man.GetString("DeviceInfoForm_LabelLogoComment", cul) + " " + Encoding.ASCII.GetString(reader.ReadBytes(temp)).Trim().ToString();
                                    temp = reader.ReadInt32();
                                    comment = Encoding.UTF8.GetString(reader.ReadBytes(temp));
                                    searchdevice.labelLogoComment.Text = "Logo " + res_man.GetString("DeviceInfoForm_LabelLogoComment", cul) + " " + Encoding.ASCII.GetString(reader.ReadBytes(temp)).Trim().ToString();
                                    Application.DoEvents();
                                }
                                break;
                        }
                        reader.BaseStream.Position = offset[0];
                    }
                }
                catch
                {
                    searchdevice.labelLogoComment.Text = "Logo " + res_man.GetString("DeviceInfoForm_LabelLogoComment", cul) + " " + res_man.GetString("DeviceInfoForm_LabelLogoComment_Error", cul); 
                }

                DateTime creation = File.GetCreationTime(logopath);
                DateTime modification = File.GetLastWriteTime(logopath);

                searchdevice.Show();
                searchdevice.Text = "Motorola " + res_man.GetString("DeviceInfoForm_Label_Device", cul) + " " + title;
                searchdevice.labelDName.Text = res_man.GetString("DeviceInfoForm_LabelName", cul) + " " + dname;
                searchdevice.labelCodeName.Text = res_man.GetString("DeviceInfoForm_LabelCodeName", cul) + " " + dcn;
                searchdevice.labelResolution.Text = res_man.GetString("DeviceInfoForm_LabelResolution", cul) + " " + reso;
                searchdevice.labelLMemory.Text = res_man.GetString("DeviceInfoForm_LabelMemory", cul) + " " + mem + "MB";
                searchdevice.labelLogoCreateDate.Text = res_man.GetString("DeviceInfoForm_LabelLogoCreateDate", cul) + " " + creation;
                searchdevice.labelLogoModifyDate.Text = res_man.GetString("DeviceInfoForm_LabelLogoModifyDate", cul) + " " + modification;
                searchdevice.labelLogoSize.Text = res_man.GetString("DeviceInfoForm_LabelLogoSize", cul) + " " + logosize.ToString() + " bytes";
                searchdevice.labelLogoPath.Text = logopath;
                searchdevice.labelLogoPath2.Text = logopath2;
                searchdevice.pictureBoxDevice.Image = picture;
                return;
            }
        }

        public long LogoSize(string devicelogo)
        {
            //string logopath = exePath + @"\Files\Bin\";
            //string fileName = devicelogo;
            FileInfo fi = new FileInfo(devicelogo);
            long size = fi.Length;
            return size;
        }

        public void CheckDevice()
        {
            //BIN
            string logo32path = exePath + @"\Files\Bin\32MB\";
            string logo16path = exePath + @"\Files\Bin\16MB\";
            string logo8path = exePath + @"\Files\Bin\8MB\";
            string logo6path = exePath + @"\Files\Bin\6MB\";
            string logo4path = exePath + @"\Files\Bin\4MB\";

            //MotoG
            string MotoGPath32 = logo32path + @"MotoG\";
            string MotoGPath16 = logo16path + @"MotoG\";
            string MotoGPath4 = logo4path + @"MotoG\";
         
            //Nexus
            string NexusPath8 = logo16path + @"Nexus\";

            //MotoE
            string MotoEPath16 = logo16path + @"MotoE\";
            string MotoEPath4 = logo4path + @"MotoE\";

            //MotoEdge
            string MotoEdgePath16 = logo16path + @"MotoEdge\";

            //MotoOne
            string MotoOnePath32 = logo32path + @"MotoOne\";
            string MotoOnePath16 = logo16path + @"MotoOne\";

            //MotoDroid
            string MotoDroidPath4 = logo4path + @"MotoDroid\";
            string MotoDroidPath6 = logo6path + @"MotoDroid\";
            string MotoDroidPath8 = logo8path + @"MotoDroid\";

            //MotoP    
            string MotoPPath32 = logo32path + @"MotoP\";
            string MotoPPath16 = logo16path + @"MotoP\";

            //MotoX   
            string MotoXPath32 = logo32path + @"MotoX\";
            string MotoXPath8 = logo8path + @"MotoX\";
            string MotoXPath6 = logo6path + @"MotoX\";
            string MotoXPath4 = logo4path + @"MotoX\";

            //MotoZ   
            string MotoZPath32 = logo32path + @"MotoZ\";
            string MotoZPath16 = logo16path + @"MotoZ\";

            if (textBoxSearchDevice.Text == string.Empty)
            {
                MessageBox.Show(res_man.GetString("SearchDeviceForm_PleaseInputDevice", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Separator 32MIB

                #region 32MIB Devices
                if (textBoxSearchDevice.Text.ToLower() == "moto g6 plus" || textBoxSearchDevice.Text.ToLower().Contains("evert"))
                {
                    CallForm("Motorola Moto G6 Plus - Evert", 
                        "Motorola Moto G6 Plus", 
                        "Evert", 
                        "1080 x 2160", 
                        "32", 
                        LogoSize(MotoGPath32 + @"G6_Plus\1080x2160.bin"),
                        MotoGPath32 + @"G6_Plus\1080x2160.bin", 
                        null, 
                        Resources.motorola_moto_g6_plus_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g8 plus" || textBoxSearchDevice.Text.ToLower().Contains("one vision plus") || textBoxSearchDevice.Text.ToLower().Contains("doha"))
                {   
                    CallForm("Motorola Moto G8 Plus / One Vision Plus - Doha",
                        "Motorola Moto G8 Plus / One Vision Plus", 
                        "Doha", 
                        "1080 x 2280", 
                        "32", 
                        LogoSize(MotoGPath32 + @"G8_Plus\1080x2280.bin"),
                        MotoGPath32 + @"G8_Plus\1080x2280.bin",
                        MotoOnePath32 + @"One_Vision_Plus\1080x2280.bin",
                        Resources.motorola_moto_g8_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g power" || textBoxSearchDevice.Text.ToLower() == "sofia")
                {
                    CallForm("Motorola Moto G Power - Sofia",
                        "Motorola Moto G Power",
                        "Sofia",
                        "1080 x 2300",
                        "32",
                        LogoSize(MotoGPath32 + @"G_Power\1080x2300.bin"),
                        MotoGPath32 + @"G_Power\1080x2300.bin",
                        MotoGPath32 + @"G8_Power\1080x2300.bin",
                        Resources.motorola_moto_g_power_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g8 power" || textBoxSearchDevice.Text.ToLower() == "sofiar")
                {
                    CallForm("Motorola Moto G8 Power - Sofiar",
                        "Motorola Moto G8 Power",
                        "Sofiar",
                        "1080 x 2300",
                        "32",
                        LogoSize(MotoGPath32 + @"G8_Power\1080x2300.bin"),
                        MotoGPath32 + @"G8_Power\1080x2300.bin",
                        MotoGPath32 + @"G_Power\1080x2300.bin",
                        Resources.motorola_moto_g8_power_r1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g pro" || textBoxSearchDevice.Text.ToLower() == "sofiap_ao")
                {
                    CallForm("Motorola Moto G Pro - Sofiap_ao",
                        "Moto G Pro",
                        "Sofiap_ao",
                        "1080 x 2300",
                        "32",
                        LogoSize(MotoGPath32 + @"32MB\Moto G Pro\1080x2300.bin"),
                        MotoGPath32 + @"G_Pro\1080x2300.bin",
                        null,
                        Resources.motorola_moto_g_stylus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g stylus" || textBoxSearchDevice.Text.ToLower() == "sofiap")
                {
                    CallForm("Motorola Moto G Stylus - Sofiap",
                        "Moto G Stylus",
                        "Sofiap",
                        "1080 x 2300",
                        "32",
                        LogoSize(MotoGPath32 + @"G_Stylus\1080x2300.bin"),
                        MotoGPath32 + @"G_Stylus\1080x2300.bin",
                        null,
                        Resources.motorola_moto_g_stylus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g stylus 2021" || textBoxSearchDevice.Text.ToLower() == "minsk")
                {
                    CallForm("Motorola Moto G Stylus 2021 - Minsk",
                        "Moto G Stylus 2021",
                        "Minsk",
                        "1080 x 2400",
                        "32",
                        LogoSize(MotoGPath32 + @"G_Stylus(2021)\1080x2400.bin"),
                        MotoGPath32 + @"G_Stylus(2021)\1080x2400.bin", 
                        null,
                        Resources.motorola_moto_g_stylus_2021_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g8" || textBoxSearchDevice.Text.ToLower() == "moto g fast" || textBoxSearchDevice.Text.ToLower().Contains("rav"))
                {
                    CallForm("Motorola Moto G8 / G Fast - Rav", 
                        "Motorola Moto G8 / G Fast", 
                        "Rav", 
                        "720 x 1560", 
                        "32", 
                        LogoSize(MotoGPath32 + @"G8\720x1560.bin"),
                        MotoGPath32 + @"G8\720x1560.bin",
                        MotoGPath32 + @"G_Fast\720x1560.bin",
                        Resources.motorola_moto_g8_1); 
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g9 plus" || textBoxSearchDevice.Text.ToLower().Contains("odessa"))
                {
                    CallForm("Motorola Moto G9 Plus - Odessa",
                        "Moto G9 Plus",
                        "Odessa",
                        "1080 x 2400",
                        "32",
                        LogoSize(MotoGPath32 + @"G9_Plus\1080x2400.bin"),
                        MotoGPath32 + @"G9_Plus\1080x2400.bin",
                        null,
                        Resources.motorola_moto_g9_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto x4" || textBoxSearchDevice.Text.ToLower() == "moto x4 android one" || textBoxSearchDevice.Text.ToLower().Contains("payton"))
                {
                    CallForm("Motorola Moto X4 / X4 Android One - Payton",
                        "Moto X4 / X4 Android One",
                        "Payton",
                        "1080 x 1920",
                        "32",
                        LogoSize(MotoXPath32 + @"X4\1080x1920.bin"),
                        MotoXPath32 + @"X4\1080x1920.bin",
                        MotoXPath32 + @"X4_Android_One\1080x1920.bin",
                        Resources.motorola_moto_x4_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto z2 force" || textBoxSearchDevice.Text.ToLower() == "moto z 2018" || textBoxSearchDevice.Text.ToLower().Contains("nash"))
                {
                    CallForm("Motorola Moto Z2 Force / Z 2018 - Nash",
                        "Moto Z2 Force / Z 2018",
                        "Nash",
                        "1440 x 2560",
                        "32",
                        LogoSize(MotoZPath32 + @"Z2_Force\1440x2560.bin"),
                        MotoZPath32 + @"Z2_Force\1440x2560.bin",
                        MotoZPath32 + @"Z_2018\1440x2560.bin",
                        Resources.motorola_moto_z2_force_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto z3 play" || textBoxSearchDevice.Text.ToLower().Contains("beckham"))
                {
                    CallForm("Motorola Moto Z3 Play - Beckham",
                        "Moto Z3 Play",
                        "Beckham",
                        "1080 x 2160",
                        "32",
                        LogoSize(MotoZPath32 + @"Z3_Play\1080x2160.bin"),
                        MotoZPath32 + @"Z3_Play\1080x2160.bin", 
                        null,
                        Resources.motorola_moto_z3_play_5);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto z3" || textBoxSearchDevice.Text.ToLower().Contains("messi"))
                {
                    CallForm("Motorola Moto Z3 - Messi",
                        "Moto Z3",
                        "Messi",
                        "1080 x 2160",
                        "32",
                        LogoSize(MotoZPath32 + @"Z3\1080x2160.bin"),
                        MotoZPath32 + @"Z3\1080x2160.bin",
                        null,
                        Resources.motorola_moto_z3v_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto z4" || textBoxSearchDevice.Text.ToLower().Contains("foles"))
                {
                    CallForm("Motorola Moto Z4 - Foles",
                        "Moto Z4",
                        "Foles",
                        "1080 x 2340",
                        "32",
                        LogoSize(MotoZPath32 + @"Z4\1080x2340.bin"),
                        MotoZPath32 + @"Z4\1080x2340.bin",
                        null,
                        Resources.motorola_moto_z4_r);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g7 plus" || textBoxSearchDevice.Text.ToLower().Contains("lake"))
                {
                    CallForm("Motorola Moto G7 Plus - Lake",
                        "Motorola Moto G7 Plus",
                        "Lake",
                        "1080 x 2270",
                        "32",
                        LogoSize(MotoGPath32 + @"G7_Plus\1080x2270.bin"),
                        MotoGPath32 + @"G7_Plus\1080x2270.bin", 
                        null,
                        Resources.motorola_moto_g7_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one power" || textBoxSearchDevice.Text.ToLower() == "moto p30 note" || textBoxSearchDevice.Text.ToLower().Contains("chef"))
                {
                    CallForm("Motorola Moto One Power / P30 Note - Chef",
                        "Motorola Moto One Power / P30 Note",
                        "Chef",
                        "1080 x 2246",
                        "32",
                        LogoSize(MotoOnePath32 + @"One_Power\1080x2246.bin"),
                        MotoOnePath32 + @"One_Power\1080x2246.bin",
                        MotoPPath32 + @"P30_P30_Note\1080x2246.bin",
                        Resources.motorola_one_power_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one zoom" || textBoxSearchDevice.Text.ToLower().Contains("parker"))
                {
                    CallForm("Motorola Moto One Zoom - Parker",
                        "Motorola Moto One Zoom",
                        "Parker",
                        "1080 x 2340",
                        "32",
                        LogoSize(MotoOnePath32 + @"One_Zoom\1080x2340.bin"),
                        MotoOnePath32 + @"One_Zoom\1080x2340.bin", 
                        null,
                        Resources.motorola_one_zoom_r1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one hyper" || textBoxSearchDevice.Text.ToLower().Contains("def"))
                {
                    CallForm("Motorola Moto One Hyper - Def",
                        "Motorola Moto One Hyper",
                        "Def",
                        "1080 x 2340",
                        "32",
                        LogoSize(MotoOnePath32 + @"One_Hyper\1080x2340.bin"),
                        MotoOnePath32 + @"One_Hyper\1080x2340.bin", 
                        null,
                        Resources.motorola_one_hyper_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one fusion+" || textBoxSearchDevice.Text.ToLower().Contains("liber"))
                {
                    CallForm("Motorola Moto One Fusion+ - Liber",
                        "Motorola Moto One Fusion+",
                        "Liber",
                        "1080 x 2340",
                        "32",
                        LogoSize(MotoOnePath32 + @"One_Fusion+\1080x2340.bin"),
                        MotoOnePath32 + @"One_Fusion+\1080x2340.bin", 
                        null,
                        Resources.motorola_one_fusion_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one fusion" || textBoxSearchDevice.Text.ToLower().Contains("astro"))
                {
                    CallForm("Motorola Moto One Fusion - Astro",
                        "Motorola Moto One Fusion",
                        "Astro",
                        "720 x 1600",
                        "32",
                        LogoSize(MotoOnePath32 + @"One_Fusion\720x1600.bin"),
                        MotoOnePath32 + @"One_Fusion\720x1600.bin", 
                        null,
                        Resources.one_fusion_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto p30" || textBoxSearchDevice.Text.ToLower().Contains("robusta"))
                {
                    CallForm("Motorola Moto P30 - Robusta",
                        "Motorola Moto P30",
                        "Robusta",
                        "1080x2246",
                        "32",
                        LogoSize(MotoPPath32 + @"P30_P30_Note\1080x2246.bin"),
                        MotoPPath32 + @"P30_P30_Note\1080x2246.bin", 
                        null,
                        Resources.motorola_moto_p30_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g 5g" || textBoxSearchDevice.Text.ToLower() == "moto g 5g ace" || textBoxSearchDevice.Text.ToLower().Contains("kiev"))
                {
                    CallForm("Motorola Moto G 5G / Moto One 5G ACE - Kiev",
                        "Motorola Moto G 5G",
                        "Kiev",
                        "1080 x 2400",
                        "32",
                        LogoSize(MotoGPath32 + @"G_5G\1080x2400.bin"),
                        MotoGPath32 + @"G_5G\1080x2400.bin",
                        MotoOnePath32 + @"One_5G_Ace\1080x2400.bin", 
                        Resources.motorola_moto_g_5g_1);
                    return;
                }
                #endregion 32MIB Devices

                // Separator 16MIB

                #region 16MIB Devices
                if (textBoxSearchDevice.Text.ToLower() == "moto e4" || textBoxSearchDevice.Text.ToLower().Contains("perry"))
                {
                    CallForm("Motorola Moto E4 - Perry",
                        "Motorola Moto E4",
                        "Perry",
                        "720 x 1280",
                        "16",
                        LogoSize(MotoEPath16 +  @"E4\720x1280.bin"),
                        MotoEPath16 + @"E4\720x1280.bin", 
                        null,
                        Resources.motorola_moto_e4_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e4 plus" || textBoxSearchDevice.Text.ToLower().Contains("owens"))
                {
                    CallForm("Motorola Moto E4 Plus - Owens",
                        "Motorola Moto E4 Plus",
                        "Owens",
                        "720 x 1280",
                        "16",
                        LogoSize(MotoEPath16 + @"E4_Plus\720x1280.bin"),
                        MotoEPath16 + @"E4_Plus\720x1280.bin", 
                        null,
                        Resources.motorola_moto_e4_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e5 play" || textBoxSearchDevice.Text.ToLower().Contains("rjames"))
                {
                    CallForm("Motorola Moto E5 Play - Rjames",
                        "Motorola Moto E5 Play",
                        "Rjames",
                        "720 x 1280",
                        "16",
                        LogoSize(MotoEPath16 + @"E5_Play\720x1280.bin"),
                        MotoEPath16 + @"E5_Play\720x1280.bin", 
                        null,
                        Resources.motorola_moto_e5_play_);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e5 cruise" || textBoxSearchDevice.Text.ToLower().Contains("james"))
                {
                    CallForm("Motorola Moto E5 Cruise - James",
                        "Motorola Moto E5 Cruise",
                        "James",
                        "720 x 1280",
                        "16",
                        LogoSize(MotoEPath16 + @"E5_Cruise\720x1280.bin"),
                        MotoEPath16 + @"E5_Cruise\720x1280.bin", 
                        null,
                        Resources.motorola_moto_e5_cruise);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e5 go" || textBoxSearchDevice.Text.ToLower().Contains("rjames_go"))
                {
                    CallForm("Motorola Moto E5 Go - Rjames_go",
                        "Motorola Moto E5 Go",
                        "Rjames_go",
                        "720 x 1280",
                        "16",
                        LogoSize(MotoEPath16 + @"E5_Go\720x1280.bin"),
                        MotoEPath16 + @"E5_Go\720x1280.bin", 
                        null,
                        Resources.motorola_moto_e5_play_android_go_edition_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e5" || textBoxSearchDevice.Text.ToLower().Contains("nora"))
                {
                    CallForm("Motorola Moto E5 - Nora",
                        "Motorola Moto E5",
                        "Nora",
                        "720 x 1440",
                        "16",
                        LogoSize(MotoEPath16 + @"E5\720x1440.bin"),
                        MotoEPath16 + @"E5\720x1440.bin", 
                        null,
                        Resources.motorola_moto_e5_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e5 plus" || textBoxSearchDevice.Text.ToLower() == "moto e5 supra" || textBoxSearchDevice.Text.ToLower().Contains("rhannah"))
                {
                    CallForm("Motorola Moto E5 Plus / E5 Supra - RHannah",
                        "Motorola Moto E5 Plus / E5 Supra",
                        "RHannah",
                        "720 x 1440",
                        "16",
                        LogoSize(MotoEPath16 + @"E5_Plus\720x1440.bin"),
                        MotoEPath16 + @"E5_Plus\720x1440.bin",
                        MotoEPath16 + @"E5_Supra\720x1440.bin",
                        Resources.motorola_moto_e5_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e5 play go" || textBoxSearchDevice.Text.ToLower().Contains("pettyl"))
                {
                    CallForm("Motorola Moto E5 Play Go - Pettyl",
                        "Motorola Moto E5 Play Go",
                        "Pettyl",
                        "720 x 1440",
                        "16",
                        LogoSize(MotoEPath16 + @"E5_Play_Go\720x1440.bin"),
                        MotoEPath16 + @"E5_Play_Go\720x1440.bin", 
                        null,
                        Resources.motorola_moto_e5_play_android_go_edition_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e6" || textBoxSearchDevice.Text.ToLower().Contains("surfna"))
                {
                    CallForm("Motorola Moto E6 - Surfna",
                        "Motorola Moto E6",
                        "Surfna",
                        "720 x 1440",
                        "16",
                        LogoSize(MotoEPath16 + @"E6\720x1440.bin"),
                        MotoEPath16 + @"E6\720x1440.bin", 
                        null,
                        Resources.motorola_moto_e6_xt2005_navy_blue1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e 2020" || textBoxSearchDevice.Text.ToLower().Contains("ginna"))
                {
                    CallForm("Motorola Moto E 2020 - Ginna",
                        "Motorola Moto E 2020",
                        "Ginna",
                        "720 x 1520",
                        "16",
                        LogoSize(MotoEPath16 + @"E\720x1520.bin"),
                        MotoEPath16 + @"E\720x1520.bin", 
                        null,
                        Resources.motorola_moto_e_2020_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g4" || textBoxSearchDevice.Text.ToLower().Contains("athene"))
                {
                    CallForm("Motorola Moto G4 / G4 Plus - Athene",
                        "Motorola Moto G4 / G4 Plus",
                        "Athene",
                        "1080 x 1920",
                        "16",
                        LogoSize(MotoGPath16 + @"G4\1080x1920.bin"),
                        MotoGPath16 + @"G4\1080x1920.bin", 
                        null,
                        Resources.motorola_moto_g4_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g4 plus" || textBoxSearchDevice.Text.ToLower().Contains("athene"))
                {
                    CallForm("Motorola Moto G4 Plus / G4 - Athene",
                        "Motorola Moto G4 Plus / G4",
                        "Athene",
                        "1080 x 1920",
                        "16",
                        LogoSize(MotoGPath16 + @"G4_Plus\1080x1920.bin"),
                        MotoGPath16 + @"G4_Plus\1080x1920.bin", 
                        null,
                        Resources.motorola_moto_g4_plus_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g5" || textBoxSearchDevice.Text.ToLower().Contains("cedric"))
                {
                    CallForm("Motorola Moto G5 - Cedric",
                        "Motorola Moto G5",
                        "Athene",
                        "1080 x 1920",
                        "16",
                        LogoSize(MotoGPath16 + @"G5\1080x1920.bin"),
                        MotoGPath16 + @"G5\1080x1920.bin", 
                        null,
                        Resources.motorola_moto_g5_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g5 plus" || textBoxSearchDevice.Text.ToLower().Contains("potter"))
                {
                    CallForm("Motorola Moto G5 Plus - Potter",
                        "Motorola Moto G5 Plus",
                        "Potter",
                        "1080 x 1920",
                        "16",
                        LogoSize(MotoGPath16 + @"G5_Plus\1080x1920.bin"),
                        MotoGPath16 + @"G5_Plus\1080x1920.bin", 
                        null,
                        Resources.motorola_moto_g5_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g5s" || textBoxSearchDevice.Text.ToLower().Contains("montana"))
                {
                    CallForm("Motorola Moto G5s - Montana",
                        "Motorola Moto G5s",
                        "Montana",
                        "1080 x 1920",
                        "16",
                        LogoSize(MotoGPath16 + @"G5s\1080x1920.bin"),
                        MotoGPath16 + @"G5s\1080x1920.bin", 
                        null,
                        Resources.motorola_moto_g5s_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g5s plus" || textBoxSearchDevice.Text.ToLower().Contains("sanders"))
                {
                    CallForm("Motorola Moto G5s Plus - Sanders",
                        "Motorola Moto G5s Plus",
                        "Sanders",
                        "1080 x 1920",
                        "16",
                        LogoSize(MotoGPath16 + @"G5s_Plus\1080x1920.bin"),
                        MotoGPath16 + @"G5s_Plus\1080x1920.bin",
                        null, 
                        Resources.motorola_moto_g5s_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g6" || textBoxSearchDevice.Text.ToLower().Contains("ali"))
                {
                    CallForm("Motorola Moto G6 - Ali",
                        "Motorola Moto G6",
                        "Ali",
                        "1080 x 2160",
                        "16",
                        LogoSize(MotoGPath16 + @"G6\1080x2160.bin"),
                        MotoGPath16 + @"G6\1080x2160.bin", 
                        null,
                        Resources.motorola_moto_g6_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g6 play" || textBoxSearchDevice.Text.ToLower().Contains("jeter") || textBoxSearchDevice.Text.ToLower().Contains("aljeter"))
                {
                    CallForm("Motorola Moto G6 Play / G6 Forge - al/jeter",
                        "Motorola Moto G6 Play / G6 Forge",
                        "al/jeter",
                        "720 x 1440",
                        "16",
                        LogoSize(MotoGPath16 + @"G6_Play\720x1440.bin"),
                        MotoGPath16 + @"G6_Play\720x1440.bin", 
                        null,
                        Resources.motorola_moto_g6_play_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g7" || textBoxSearchDevice.Text.ToLower().Contains("river"))
                {
                    CallForm("Motorola Moto G7 - River",
                        "Motorola Moto G7",
                        "River",
                        "1080 x 2270",
                        "16",
                        LogoSize(MotoGPath16 + @"G7\1080x2270.bin"),
                        MotoGPath16 + @"G7\1080x2270.bin", 
                        null,
                        Resources.motorola_moto_g7_0);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g7 play" || textBoxSearchDevice.Text.ToLower() == "moto g7 optimo" || textBoxSearchDevice.Text.ToLower().Contains("channel"))
                {
                    CallForm("Motorola Moto G7 Play / G7 Optimo - Channel",
                        "Motorola Moto G7 Play / G7 Optimo",
                        "Channel",
                        "720 x 1512",
                        "16",
                        LogoSize(MotoGPath16 + @"G7_Play\720x1512.bin"),
                        MotoGPath16 + @"G7_Play\720x1512.bin",
                        MotoGPath16 + @"G7_Optimo\720x1512.bin",
                        Resources.motorola_moto_g7_play_0);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g7 power" || textBoxSearchDevice.Text.ToLower() == "moto g7 supra" || textBoxSearchDevice.Text.ToLower() == "moto g7 optimo maxx" || textBoxSearchDevice.Text.ToLower().Contains("ocean"))
                {
                    CallForm("Motorola Moto G7 Power / G7 Supra / G7 Optimo Maxx - Ocean",
                        "Motorola Moto G7 Power / G7 Supra / G7 Optimo Maxx",
                        "Ocean",
                        "720 x 1512",
                        "16",
                        LogoSize(MotoGPath16 + @"G7_Power_G7_Supra\720x1512.bin"),
                        MotoGPath16 + @"G7_Power_G7_Supra\720x1512.bin",
                        MotoGPath16 + @"G7_Optimo_Maxx\720x1512.bin",
                        Resources.motorola_moto_g7_power_0);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g9" || textBoxSearchDevice.Text.ToLower() == "moto g9 play" || textBoxSearchDevice.Text.ToLower().Contains("guamp"))
                {
                    CallForm("Motorola Moto G9 / G9 Play - Guamp",
                        "Motorola Moto G9 / G9 Play",
                        "Guamp",
                        "720 x 1600",
                        "16",
                        LogoSize(MotoGPath16 + @"G9\720x1600.bin"),
                        MotoGPath16 + @"G9\720x1600.bin",
                        MotoGPath16 + @"G9_Play\720x1600.bin",
                        Resources.motorola_moto_g9_play_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto z" || textBoxSearchDevice.Text.ToLower() == "moto z droid" || textBoxSearchDevice.Text.ToLower().Contains("griffin"))
                {
                    CallForm("Motorola Moto Z / Z Droid - Griffin",
                        "Motorola Moto Z / Z Droid",
                        "Griffin",
                        "1440 x 2560",
                        "16",
                        LogoSize(MotoZPath16 + @"Z\1440x2560.bin"),
                        MotoZPath16 + @"Z\1440x2560.bin",
                        MotoZPath16 + @"Z_Droid\1440x2560.bin",                       
                        Resources.motorola_moto_z_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto z force" || textBoxSearchDevice.Text.ToLower().Contains("sheridan"))
                {
                    CallForm("Motorola Moto Z Force - Sheridan",
                        "Motorola Moto Z Force",
                        "Sheridan",
                        "1440 x 2560",
                        "16",
                        LogoSize(MotoZPath16 + @"Z_Force\1440x2560.bin"),
                        MotoZPath16 + @"Z_Force\1440x2560.bin", 
                        null,
                        Resources.motorola_moto_z_force_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto z play" || textBoxSearchDevice.Text.ToLower() == "moto z play droid" || textBoxSearchDevice.Text.ToLower().Contains("addison"))
                {
                    CallForm("Motorola Moto Z Play / Z Play Droid - Addison",
                        "Motorola Moto Z Play / Z Play Droid",
                        "Addison",
                        "1080 x 1920",
                        "16",
                        LogoSize(MotoZPath16 + @"Z_Play\1080x1920.bin"),
                        MotoZPath16 + @"Z_Play\1080x1920.bin",
                        MotoZPath16 + @"Z_Play_Droid\1080x1920.bin",
                        Resources.motorola_moto_z_play_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto z2 play" || textBoxSearchDevice.Text.ToLower().Contains("albus"))
                {
                    CallForm("Motorola Moto Z2 Play - Albus",
                        "Motorola Moto Z2 Play",
                        "Albus",
                        "1080 x 1920",
                        "16",
                        LogoSize(MotoZPath16 + @"Z2_Play\1080x1920.bin"),
                        MotoZPath16 + @"Z2_Play\1080x1920.bin",
                        null,
                        Resources.motorola_moto_z_play_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one" || textBoxSearchDevice.Text.ToLower().Contains("deen"))
                {
                    CallForm("Motorola Moto One - Deen",
                        "Motorola Moto One",
                        "Deen",
                        "720 x 1520",
                        "16",
                        LogoSize(MotoOnePath16 + @"One\720x1520.bin"),
                        MotoOnePath16 + @"One\720x1520.bin", 
                        null,
                        Resources.motorola_one_02);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g 5g plus" || textBoxSearchDevice.Text.ToLower().Contains("nairo"))
                {
                    CallForm("Motorola Moto G 5G Plus - Nairo",
                        "Moto G 5G Plus",
                        "Nairo",
                        "1080 x 2520",
                        "16",
                        LogoSize(MotoGPath16 + @"G_5G_Plus\1080x2520.bin"),
                        MotoGPath16 + @"G_5G_Plus\1080x2520.bin", 
                        null,
                        Resources.motorola_moto_g_5g_plus_03);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto edge plus" || textBoxSearchDevice.Text.ToLower() == "moto edge+" || textBoxSearchDevice.Text.ToLower().Contains("burton"))
                {
                    CallForm("Motorola Moto Edge Plus - Burton",
                        "Moto Edge Plus",
                        "Burton",
                        "1080 x 2340",
                        "16",
                        LogoSize(MotoEdgePath16 + @"Edge_Plus\1080x2340.bin"),
                        MotoEdgePath16 + @"Edge_Plus\1080x2340.bin", 
                        null,
                        Resources.motorola_edge_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto edge" || textBoxSearchDevice.Text.ToLower().Contains("racer"))
                {
                    CallForm("Motorola Moto Edge - Racer",
                        "Moto Edge",
                        "Racer",
                        "1080 x 2340",
                        "16",
                        LogoSize(MotoEdgePath16 + @"Edge\1080x2340.bin"),
                        MotoEdgePath16 + @"Edge\1080x2340.bin", 
                        null,
                        Resources.motorola_edge_midnight_magenta_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto edge s" || textBoxSearchDevice.Text.ToLower().Contains("nio"))
                {
                    CallForm("Motorola Moto Edge S - Nio",
                        "Moto Edge S",
                        "Racer",
                        "1080 x 2520",
                        "16",
                        LogoSize(MotoEdgePath16 + @"Edge_S\1080x2520.bin"),
                        MotoEdgePath16 + @"Edge_S\1080x2520.bin",
                        null,
                        Resources.motorola_moto_edge_s);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e7 plus" || textBoxSearchDevice.Text.ToLower().Contains("guam"))
                {
                    CallForm("Motorola Moto E7 Plus - Guam",
                        "Moto E7 Plus",
                        "Guam",
                        "720 x 1600",
                        "16",
                        LogoSize(MotoEPath16 + @"E7_Plus\720x1600.bin"),
                        MotoEPath16 + @"E7_Plus\720x1600.bin",
                        null,
                        Resources.motorola_moto_e7_plus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g9 power" || textBoxSearchDevice.Text.ToLower().Contains("cebu"))
                {
                    CallForm("Motorola Moto G9 Power - Cebu",
                        "Moto G9 Power",
                        "Cebu",
                        "720 x 1600",
                        "16",
                        LogoSize(MotoGPath16 + @"G9_Power\720x1600.bin"),
                        MotoGPath16 + @"G9_Power\720x1600.bin",
                        null,
                        Resources.motorola_moto_g9_power_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g10" || textBoxSearchDevice.Text.ToLower().Contains("capri"))
                {
                    CallForm("Motorola Moto G10 - Capri",
                        "Motorola Moto G10",
                        "Capri",
                        "720 x 1600",
                        "16",
                        LogoSize(MotoGPath16 + @"G10\720x1600.bin"),
                        MotoGPath16 + @"G10\720x1600.bin",
                        null,
                        Resources.motorola_moto_g10_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g30" || textBoxSearchDevice.Text.ToLower().Contains("caprip"))
                {
                    CallForm("Motorola Moto G30 - Caprip",
                        "Motorola Moto G30",
                        "Caprip",
                        "720 x 1600",
                        "16",
                        LogoSize(MotoGPath16 + @"G30\720x1600.bin"),
                        MotoGPath16 + @"G30\720x1600.bin",
                        null,
                        Resources.motorola_moto_g30_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g play 2021" || textBoxSearchDevice.Text.ToLower().Contains("guamna"))
                {
                    CallForm("Motorola Moto G Play 2021 - Guamna",
                        "Motorola Moto G Play 2021",
                        "Guamna",
                        "720 x 1600",
                        "16",
                        LogoSize(MotoGPath16 + @"G_Play(2021)\720x1600.bin"),
                        MotoGPath16 + @"G_Play(2021)\720x1600.bin",
                        null,
                        Resources.motorola_moto_g_play_2021_1);
                    return;
                }


                if (textBoxSearchDevice.Text.ToLower() == "moto g power 2021" || textBoxSearchDevice.Text.ToLower().Contains("borneo"))
                {
                    CallForm("Motorola Moto G Power 2021 - Borneo",
                        "Motorola Moto G Power 2021",
                        "Borneo",
                        "720 x 1600",
                        "16",
                        LogoSize(MotoGPath16 + @"G_Power(2021)\720x1600.bin"),
                        MotoGPath16 + @"G_Power(2021)\720x1600.bin",
                        null,
                        Resources.motorola_moto_g_power_2021_1);
                    return;
                }
                #endregion 16MIB Devices

                // Separator 8MIB

                #region 8MIB Devices
                if (textBoxSearchDevice.Text.ToLower() == "moto droid turbo" || textBoxSearchDevice.Text.ToLower() == "moto maxx" || textBoxSearchDevice.Text.ToLower().Contains("quark"))
                {
                    CallForm("Motorola Moto Droid Turbo / Maxx - Quark",
                        "Motorola Moto Droid Turbo / Maxx",
                        "Quark",
                        "1440 x 2560",
                        "8",
                        LogoSize(MotoDroidPath8 + @"Turbo\1440x2560.bin"),
                        MotoDroidPath8 + @"Turbo\1440x2560.bin",
                        MotoDroidPath8 + @"Maxx\1440x2560.bin",
                        Resources.motorola_droid_turbo_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto droid turbo 2" || textBoxSearchDevice.Text.ToLower() == "moto x force" || textBoxSearchDevice.Text.ToLower().Contains("kinzie"))
                {
                    CallForm("Motorola Moto Droid Turbo 2 / X Force - Kinzie",
                        "Motorola Moto Droid Turbo 2 / X Force",
                        "Kinzie",
                        "1440 x 2560",
                        "8",
                        LogoSize(MotoDroidPath8 + @"Turbo_2\1440x2560.bin"),
                        MotoDroidPath8 + @"Turbo_2\1440x2560.bin",
                        MotoXPath8 + @"X3_Force\1440x2560.bin",
                        Resources.motorola_moto_x_force4);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto x pro" || textBoxSearchDevice.Text.ToLower() == "nexus 6" || textBoxSearchDevice.Text.ToLower().Contains("shamu"))
                {
                    CallForm("Motorola Moto X Pro / Nexus 6 - Shamu",
                        "Motorola Moto X Pro / Nexus 6",
                        "Shamu",
                        "1440 x 2560",
                        "8",
                        LogoSize(MotoXPath8 + @"X_Pro\1440x2560.bin"),
                        MotoXPath8 + @"X_Pro\1440x2560.bin",
                        NexusPath8 + @"Nexus6\1440x2560.bin",
                        Resources.motorola_nexus_6_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto x style" || textBoxSearchDevice.Text.ToLower() == "moto x pure" || textBoxSearchDevice.Text.ToLower().Contains("clark"))
                {
                    CallForm("Motorola Moto X Style / X Pure Edition - Clark",
                        "Motorola Moto X Style / X Pure Edition",
                        "Clark",
                        "1440 x 2560",
                        "8",
                        LogoSize(MotoXPath8 + @"X_Style\1440x2560.bin"),
                        MotoXPath8 + @"X_Style\1440x2560.bin",
                        MotoXPath8 + @"X_Pure\1440x2560.bin",
                        Resources.moto_x_style_1);
                    return;
                }
                #endregion 8MIB Devices

                // Separator 6MIB

                #region 6MIB Devices
                if (textBoxSearchDevice.Text.ToLower() == "moto droid maxx 2" || textBoxSearchDevice.Text.ToLower() == "moto x3 play" || textBoxSearchDevice.Text.ToLower().Contains("lux"))
                {
                    CallForm("Motorola Moto Droid Maxx 2 / X3 Play - Lux",
                        "Motorola Moto Droid Maxx 2 / X3 Play",
                        "Lux",
                        "1080 x 1920",
                        "6",
                        LogoSize(MotoDroidPath6 + @"Maxx2\1080x1920.bin"),
                        MotoDroidPath6 + @"Maxx2\1080x1920.bin",
                        MotoXPath6 + @"X3_Play\1080x1920.bin",
                        Resources.motorola_droid_maxx_2);
                    return;
                }
                #endregion 6MIB Devices

                // Separator 4MIB

                #region 4MIB Devices
                if (textBoxSearchDevice.Text.ToLower() == "moto droid maxx" || textBoxSearchDevice.Text.ToLower().Contains("obake-maxx"))
                {
                    CallForm("Motorola Moto Droid Maxx - Obake-Maxx",
                        "Motorola Moto Droid Maxx",
                        "Obake-Maxx",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoDroidPath4 + @"Maxx(2013)\720x1280.bin"),
                        MotoDroidPath4 + @"Maxx(2013)\720x1280.bin",
                        null,
                        Resources.motorola_droid_maxx1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto droid mini" || textBoxSearchDevice.Text.ToLower().Contains("obakem"))
                {
                    CallForm("Motorola Moto Droid Mini - Obakem",
                        "Motorola Moto Droid Mini",
                        "Obakem",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoDroidPath4 + @"Mini\720x1280.bin"),
                        MotoDroidPath4 + @"Mini\720x1280.bin", 
                        null,
                        Resources.motorola_droid_mini2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto droid ultra" || textBoxSearchDevice.Text.ToLower().Contains("obake"))
                {
                    CallForm("Motorola Moto Droid Ultra - Obake",
                        "Motorola Moto Droid Ultra",
                        "Obake",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoDroidPath4 + @"Ultra\720x1280.bin"),
                        MotoDroidPath4 + @"Ultra\720x1280.bin", 
                        null,
                        Resources.motorola_droid_ultra_2);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e" || textBoxSearchDevice.Text.ToLower().Contains("condor"))
                {
                    CallForm("Motorola Moto E - Condor",
                        "Motorola Moto E",
                        "Condor",
                        "540 x 960",
                        "4",
                        LogoSize(MotoEPath4 + @"E\560x960.bin"),
                        MotoEPath4 + @"E\560x960.bin", 
                        null,
                        Resources.motorola_moto_e_3);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e2" || textBoxSearchDevice.Text.ToLower().Contains("otus"))
                {
                    CallForm("Motorola Moto E2 - Otus",
                        "Motorola Moto E2",
                        "Otus",
                        "540 x 960",
                        "4",
                        LogoSize(MotoEPath4 + @"E2\560x960.bin"),
                        MotoEPath4 + @"E2\560x960.bin", 
                        null,
                        Resources.motorola_moto_e_2015_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e2 lte" || textBoxSearchDevice.Text.ToLower().Contains("surnia"))
                {
                    CallForm("Motorola Moto E2 LTE - Surnia",
                        "Motorola Moto E2 LTE",
                        "Surnia",
                        "540 x 960",
                        "4",
                        LogoSize(MotoEPath4 + @"E2_LTE\560x960.bin"),
                        MotoEPath4 + @"E2_LTE\560x960.bin", 
                        null,
                        Resources.motorola_moto_e_2015_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g" || textBoxSearchDevice.Text.ToLower() == "moto g google play" || textBoxSearchDevice.Text.ToLower() == "moto g forte" || textBoxSearchDevice.Text.ToLower() == "moto g ferrari" || textBoxSearchDevice.Text.ToLower().Contains("falcon"))
                {
                    CallForm("Motorola Moto G/G Google Play Edition/G Forte/G Ferrari Edition - Falcon",
                        "Motorola Moto G/G Google Play Edition/G Forte/G Ferrari Edition",
                        "Falcon",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoGPath4 + @"G_G_Ferrari_G_Forte_G_Google_Play\720x1280.bin"),
                        MotoGPath4 + @"G_G_Ferrari_G_Forte_G_Google_Play\720x1280.bin", 
                        null,
                        Resources.motorola_moto_g_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g lte" || textBoxSearchDevice.Text.ToLower().Contains("peregrine"))
                {
                    CallForm("Motorola Moto G LTE - Peregrine",
                        "Motorola Moto G LTE",
                        "Peregrine",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoGPath4 + @"G_LTE\720x1280.bin"),
                        MotoGPath4 + @"G_LTE\720x1280.bin", 
                        null,
                        Resources.motorola_moto_g_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g2" || textBoxSearchDevice.Text.ToLower().Contains("titan"))
                {
                    CallForm("Motorola Moto G2 - Titan",
                        "Motorola Moto G2",
                        "Titan",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoGPath4 + @"G2\720x1280.bin"),
                        MotoGPath4 + @"G2\720x1280.bin", 
                        null,
                        Resources.moto_g_2014_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g2 lte" || textBoxSearchDevice.Text.ToLower().Contains("thea"))
                {
                    CallForm("Motorola Moto G2 LTE - Thea",
                        "Motorola Moto G2 LTE",
                        "Thea",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoGPath4 + @"G2_LTE\720x1280.bin"),
                        MotoGPath4 + @"G2_LTE\720x1280.bin", 
                        null,
                        Resources.moto_g_2014_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g3" || textBoxSearchDevice.Text.ToLower().Contains("osprey"))
                {
                    CallForm("Motorola Moto G3 - Osprey",
                        "Motorola Moto G3",
                        "Osprey",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoGPath4 + @"G3\720x1280.bin"),
                        MotoGPath4 + @"G3\720x1280.bin", 
                        null,
                        Resources.motorola_moto_g_3rd_gen_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g3 turbo" || textBoxSearchDevice.Text.ToLower().Contains("merlin"))
                {
                    CallForm("Motorola Moto G3 Turbo - Merlin",
                        "Motorola Moto G3 Turbo",
                        "Merlin",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoGPath4 + @"G3_Turbo\720x1280.bin"),
                        MotoGPath4 + @"G3_Turbo\720x1280.bin", 
                        null,
                        Resources.motorola_moto_g_3rd_gen_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g4 play" || textBoxSearchDevice.Text.ToLower().Contains("harpia"))
                {
                    CallForm("Motorola Moto G4 Play - Harpia",
                        "Motorola Moto G4 Play",
                        "Harpia",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoGPath4 + @"G4_Play\720x1280.bin"),
                        MotoGPath4 + @"G4_Play\720x1280.bin", 
                        null,
                        Resources.motorola_moto_g4_play_4);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto x" || textBoxSearchDevice.Text.ToLower() == "moto x 2013" || textBoxSearchDevice.Text.ToLower().Contains("ghost"))
                {
                    CallForm("Motorola Moto X - Ghost",
                        "Motorola Moto X",
                        "Ghost",
                        "720 x 1280",
                        "4",
                        LogoSize(MotoXPath4 + @"X\720x1280.bin"),
                        MotoXPath4 + @"X\720x1280.bin", 
                        null,
                        Resources.motorola_moto_x_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto x2" || textBoxSearchDevice.Text.ToLower() == "moto x 2014" || textBoxSearchDevice.Text.ToLower().Contains("victara"))
                {
                    CallForm("Motorola Moto X2 2014 - Victara",
                        "Motorola Moto X2 2014",
                        "Victara",
                        "1080 x 1920",
                        "4",
                        LogoSize(MotoXPath4 + @"X2\1080x1920.bin"),
                        MotoXPath4 + @"X2\1080x1920.bin", 
                        null,
                        Resources.moto_x_2014_2);
                    return;
                }
                #endregion 4MIB Devices

                MessageBox.Show(textBoxSearchDevice.Text + ", " + res_man.GetString("SearchDeviceForm_NotFound", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchDevice_Click(object sender, EventArgs e)
        {
            CheckDevice();
        }
    }
}