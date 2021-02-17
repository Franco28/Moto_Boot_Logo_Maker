/* 
#####################################################################
#    File: MainForm.SearchDevice.cs                                 #
#    Author: Franco28                                               # 
#    Date: 07-01-2021                                               #
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

        public void CallForm(string title, string dname, string dcn, string reso, string mem, long logosize, string logopath, Bitmap picture)
        {
            Form fc = Application.OpenForms["DeviceInfo"];
            if (fc != null)
            {
                MessageBox.Show("Device already opened: " + fc.Text + ", close it to search new devices!", "Device already opened", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                    searchdevice.labelLogoComment.Text = "Logo Comment: " + Encoding.ASCII.GetString(reader.ReadBytes(temp)).Replace("@TeamDeluxe", "@Franco28").Trim().ToString();
                                    temp = reader.ReadInt32();
                                    comment = Encoding.UTF8.GetString(reader.ReadBytes(temp));
                                    searchdevice.labelLogoComment.Text = "Logo Comment: "+ comment.Replace("@TeamDeluxe", "@Franco28").Trim().ToString();
                                    Application.DoEvents();
                                }
                                break;
                        }
                        reader.BaseStream.Position = offset[0];
                    }
                }
                catch
                {
                    searchdevice.labelLogoComment.Text = "Logo Comment: Can´t read comments...";
                }

                DateTime creation = File.GetCreationTime(logopath);
                DateTime modification = File.GetLastWriteTime(logopath);

                searchdevice.Show();
                searchdevice.Text = "Motorola device: " + title;
                searchdevice.labelDName.Text = "Name: " + dname;
                searchdevice.labelCodeName.Text = "Code Name: " + dcn;
                searchdevice.labelResolution.Text = "Resolution: " + reso;
                searchdevice.labelLMemory.Text = "Memory: " + mem + "MIB";
                searchdevice.labelLogoCreateDate.Text = "Logo Create Date: " + creation;
                searchdevice.labelLogoModifyDate.Text = "Logo Modify Date: " + modification;
                searchdevice.labelLogoSize.Text = "Logo Size: " + logosize.ToString() + " bytes";
                searchdevice.labelLogoPath.Text = logopath;
                searchdevice.pictureBoxDevice.Image = picture;
                return;
            }
        }

        public long LogoSize(string devicelogo)
        {
            string logo32path = exePath + @"\Files\Bin\";
            string fileName = logo32path + devicelogo;
            FileInfo fi = new FileInfo(fileName);
            long size = fi.Length;
            return size;
        }

        public void CheckDevice()
        {
            string logo32path = exePath + @"\Files\Bin\32MB\";
            string logo16path = exePath + @"\Files\Bin\16MB\";
            string logo8path = exePath + @"\Files\Bin\8MB\";
            string logo6path = exePath + @"\Files\Bin\6MB\";
            string logo4path = exePath + @"\Files\Bin\4MB\";

            if (textBoxSearchDevice.Text == string.Empty)
            {
                MessageBox.Show("Please input a device!", "Search Device", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        LogoSize(@"32MB\Moto G6 Plus\1080x2160.bin"), 
                        logo32path + @"Moto G6 Plus\1080x2160.bin", 
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
                        LogoSize(@"32MB\Moto G8 Plus-Motorola One Vision Plus\1080x2280.bin"), 
                        logo32path + @"Moto G8 Plus-Motorola One Vision Plus\1080x2280.bin", 
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
                        LogoSize(@"32MB\Moto G Power-G8 Power\1080x2300.bin"),
                        logo32path + @"Moto G Power-G8 Power\1080x2300.bin",
                        Resources.motorola_moto_g_power_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g8 power" || textBoxSearchDevice.Text.ToLower() == "moto g power" || textBoxSearchDevice.Text.ToLower() == "sofiar")
                {
                    CallForm("Motorola Moto G8 Power - Sofiar",
                        "Motorola Moto G8 Power",
                        "Sofiar",
                        "1080 x 2300",
                        "32",
                        LogoSize(@"32MB\Moto G Power-G8 Power\1080x2300.bin"),
                        logo32path + @"Moto G Power-G8 Power\1080x2300.bin",
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
                        LogoSize(@"32MB\Moto G Pro\1080x2300.bin"),
                        logo32path + @"Moto G Pro\1080x2300.bin",
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
                        LogoSize(@"32MB\Moto G Stylus\1080x2300.bin"),
                        logo32path + @"Moto G Stylus\1080x2300.bin",
                        Resources.motorola_moto_g_stylus_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g8" || textBoxSearchDevice.Text.ToLower() == "moto g fast" || textBoxSearchDevice.Text.ToLower().Contains("rav"))
                {
                    CallForm("Motorola Moto G8 / G Fast - Rav", 
                        "Motorola Moto G8 / G Fast", 
                        "Rav", 
                        "720 x 1560", 
                        "32", 
                        LogoSize(@"32MB\Moto G8-G Fast\720x1560.bin"), 
                        logo32path + @"Moto G8-G Fast\720x1560.bin", 
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
                        LogoSize(@"32MB\Moto G9 Plus\1080x2400.bin"),
                        logo32path + @"Moto G9 Plus\1080x2400.bin",
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
                        LogoSize(@"32MB\Moto X4-X4 Android One\1080x1920.bin"),
                        logo32path + @"Moto X4-X4 Android One\1080x1920.bin",
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
                        LogoSize(@"32MB\Moto Z2 Force Edition-Z 2018\1440x2560.bin"),
                        logo32path + @"Moto Z2 Force Edition-Z 2018\1440x2560.bin",
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
                        LogoSize(@"32MB\Moto Z3 Play-Z3-Motorola Z3\1080x2160.bin"),
                        logo32path + @"Moto Z3 Play-Z3-Motorola Z3\1080x2160.bin",
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
                        LogoSize(@"32MB\Moto Z3 Play-Z3-Motorola Z3\1080x2160.bin"),
                        logo32path + @"Moto Z3 Play-Z3-Motorola Z3\1080x2160.bin",
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
                        LogoSize(@"32MB\Moto Z4\1080x2340.bin"),
                        logo32path + @"Moto Z4\1080x2340.bin",
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
                        LogoSize(@"32MB\Moto G7 Plus-Motorola G7 Plus\1080x2270.bin"),
                        logo32path + @"Moto G7 Plus-Motorola G7 Plus\1080x2270.bin",
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
                        LogoSize(@"32MB\Motorola One Power-P30-P30 Note\1080x2246.bin"),
                        logo32path + @"Motorola One Power-P30-P30 Note\1080x2246.bin",
                        Resources.motorola_one_power_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one vision" || textBoxSearchDevice.Text.ToLower() == "moto p50" || textBoxSearchDevice.Text.ToLower().Contains("kane"))
                {
                    CallForm("Motorola Moto One Vision / P50 - Kane",
                        "Motorola Moto One Vision / P50",
                        "Kane",
                        "1080 x 2520",
                        "32",
                        LogoSize(@"32MB\Motorola One Vision_One Action_P50\1080x2520.bin"),
                        logo32path + @"Motorola One Vision_One Action_P50\1080x2520.bin",
                        Resources.motorola_one_vision_0);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one action" || textBoxSearchDevice.Text.ToLower().Contains("troika"))
                {
                    CallForm("Motorola Moto One Action - Troika",
                        "Motorola Moto One Action",
                        "Troika",
                        "1080 x 2520",
                        "32",
                        LogoSize(@"32MB\Motorola One Vision_One Action_P50\1080x2520.bin"),
                        logo32path + @"Motorola One Vision_One Action_P50\1080x2520.bin",
                        Resources.motorola_one_action_denim_gray);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto one zoom" || textBoxSearchDevice.Text.ToLower().Contains("parker"))
                {
                    CallForm("Motorola Moto One Zoom - Parker",
                        "Motorola Moto One Zoom",
                        "Parker",
                        "1080 x 2340",
                        "32",
                        LogoSize(@"32MB\Motorola One Zoom\1080x2340.bin"),
                        logo32path + @"Motorola One Zoom\1080x2340.bin",
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
                        LogoSize(@"32MB\Motorola One Hyper-One Fusion+\1080x2340.bin"),
                        logo32path + @"Motorola One Hyper-One Fusion+\1080x2340.bin",
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
                        LogoSize(@"32MB\Motorola One Hyper-One Fusion+\1080x2340.bin"),
                        logo32path + @"Motorola One Hyper-One Fusion+\1080x2340.bin",
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
                        LogoSize(@"32MB\Motorola One Fusion\720x1600.bin"),
                        logo32path + @"Motorola One Fusion\720x1600.bin",
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
                        LogoSize(@"32MB\Motorola One Power-P30-P30 Note\1080x2246.bin"),
                        logo32path + @"Motorola One Power-P30-P30 Note\1080x2246.bin",
                        Resources.motorola_moto_p30_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto g 5g" || textBoxSearchDevice.Text.ToLower().Contains("kiev"))
                {
                    CallForm("Motorola Moto G 5G - Kiev",
                        "Motorola Moto G 5G",
                        "Kiev",
                        "1080 x 2400",
                        "32",
                        LogoSize(@"32MB\Moto G 5G\1080x2400.bin"),
                        logo32path + @"Moto G 5G\1080x2400.bin",
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
                        LogoSize(@"16MB\Moto E4-E4 Plus\720x1280.bin"),
                        logo16path + @"Moto E4-E4 Plus\720x1280.bin",
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
                        LogoSize(@"16MB\Moto E4-E4 Plus\720x1280.bin"),
                        logo16path + @"Moto E4-E4 Plus\720x1280.bin",
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
                        LogoSize(@"16MB\Moto E5 Play-E5 Cruise-E5 Go\720x1280.bin"),
                        logo16path + @"Moto E5 Play-E5 Cruise-E5 Go\720x1280.bin",
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
                        LogoSize(@"16MB\Moto E5 Play-E5 Cruise-E5 Go\720x1280.bin"),
                        logo16path + @"Moto E5 Play-E5 Cruise-E5 Go\720x1280.bin",
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
                        LogoSize(@"16MB\Moto E5 Play-E5 Cruise-E5 Go\720x1280.bin"),
                        logo16path + @"Moto E5 Play-E5 Cruise-E5 Go\720x1280.bin",
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
                        LogoSize(@"16MB\Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin"),
                        logo16path + @"Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin",
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
                        LogoSize(@"16MB\Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin"),
                        logo16path + @"Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin",
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
                        LogoSize(@"16MB\Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin"),
                        logo16path + @"Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin",
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
                        LogoSize(@"16MB\Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin"),
                        logo16path + @"Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin",
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
                        LogoSize(@"16MB\Moto E-G7 Power-G7 Supra-G7 Optimo Maxx-Motorola One-P30 Play\720x1520.bin"),
                        logo16path + @"Moto E-G7 Power-G7 Supra-G7 Optimo Maxx-Motorola One-P30 Play\720x1520.bin",
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
                        LogoSize(@"16MB\Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin"),
                        logo16path + @"Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin",
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
                        LogoSize(@"16MB\Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin"),
                        logo16path + @"Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin",
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
                        LogoSize(@"16MB\Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin"),
                        logo16path + @"Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin",
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
                        LogoSize(@"16MB\Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin"),
                        logo16path + @"Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin",
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
                        LogoSize(@"16MB\Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin"),
                        logo16path + @"Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin",
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
                        LogoSize(@"16MB\Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin"),
                        logo16path + @"Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin",
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
                        LogoSize(@"16MB\Moto G6-Green Poemlo 1s\1080x2160.bin"),
                        logo16path + @"Moto G6-Green Poemlo 1s\1080x2160.bin",
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
                        LogoSize(@"16MB\Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin"),
                        logo16path + @"Moto E5-E5 Plus-E5 Supra-E6-G6 Play-G6 Forge-Motorola E5 Plus\720x1440.bin",
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
                        LogoSize(@"16MB\Moto G7\1080x2270.bin"),
                        logo16path + @"Moto G7\1080x2270.bin",
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
                        LogoSize(@"16MB\Moto G7 Play-G7 Optimo\720x1512.bin"),
                        logo16path + @"Moto G7 Play-G7 Optimo\720x1512.bin",
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
                        LogoSize(@"16MB\Moto G7 Play-G7 Optimo\720x1512.bin"),
                        logo16path + @"Moto G7 Play-G7 Optimo\720x1512.bin",
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
                        LogoSize(@"16MB\Moto E7 Plus-G9-G9 Play\720x1600.bin"),
                        logo16path + @"Moto E7 Plus-G9-G9 Play\720x1600.bin",
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
                        LogoSize(@"16MB\Moto Z_Z Droid_Z Force Droid\1440x2560.bin"),
                        logo16path + @"Moto Z_Z Droid_Z Force Droid\1440x2560.bin",
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
                        LogoSize(@"16MB\Moto Z_Z Droid_Z Force Droid\1440x2560.bin"),
                        logo16path + @"Moto Z_Z Droid_Z Force Droid\1440x2560.bin",
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
                        LogoSize(@"16MB\Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin"),
                        logo16path + @"Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin",
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
                        LogoSize(@"16MB\Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin"),
                        logo16path + @"Moto G4-G4 Plus-G5-G5 Plus-G5s-G5s Plus-Green Pomelo-Z Play-Z Play Droid-Z2 Play\1080x1920.bin",
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
                        LogoSize(@"16MB\Moto E-G7 Power-G7 Supra-G7 Optimo Maxx-Motorola One-P30 Play\720x1520.bin"),
                        logo16path + @"Moto E-G7 Power-G7 Supra-G7 Optimo Maxx-Motorola One-P30 Play\720x1520.bin",
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
                        LogoSize(@"16MB\Moto G 5G Plus-Motorola One 5G\1080x2520.bin"),
                        logo16path + @"Moto G 5G Plus-Motorola One 5G\1080x2520.bin",
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
                        LogoSize(@"16MB\Motorola Edge Plus\1080x2340.bin"),
                        logo16path + @"Motorola Edge Plus\1080x2340.bin",
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
                        LogoSize(@"16MB\Motorola Edge\1080x2340.bin"),
                        logo16path + @"Motorola Edge\1080x2340.bin",
                        Resources.motorola_edge_midnight_magenta_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto e7 plus" || textBoxSearchDevice.Text.ToLower().Contains("guam"))
                {
                    CallForm("Motorola Moto E7 Plus - Guam",
                        "Moto E7 Plus",
                        "Guam",
                        "720 x 1600",
                        "16",
                        LogoSize(@"16MB\Moto E7 Plus-G9-G9 Play\720x1600.bin"),
                        logo16path + @"Moto E7 Plus-G9-G9 Play\720x1600.bin",
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
                        LogoSize(@"16MB\Moto G9 Power\720x1600.bin"),
                        logo16path + @"Moto G9 Power\720x1600.bin",
                        Resources.motorola_moto_g9_power_2);
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
                        LogoSize(@"8MB\Droid Turbo-Moto Maxx-X Pro\1440x2560.bin"),
                        logo8path + @"Droid Turbo-Moto Maxx-X Pro\1440x2560.bin",
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
                        LogoSize(@"8MB\Droid Turbo 2-Moto X3 Force\1440x2560.bin"),
                        logo8path + @"Droid Turbo 2-Moto X3 Force\1440x2560.bin",
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
                        LogoSize(@"8MB\Droid Turbo-Moto Maxx-X Pro\1440x2560.bin"),
                        logo8path + @"Droid Turbo-Moto Maxx-X Pro\1440x2560.bin",
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
                        LogoSize(@"8MB\Moto X3 Style-X3 Pure Edition\1440x2560.bin"),
                        logo8path + @"Moto X3 Style-X3 Pure Edition\1440x2560.bin",
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
                        LogoSize(@"6MB\Droid Maxx 2-Moto X3 Play\1080x1920.bin"),
                        logo6path + @"Droid Maxx 2-Moto X3 Play\1080x1920.bin",
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
                        LogoSize(@"4MB\DroidMaxx-Mini-Ultra-MotoX\720x1280.bin"),
                        logo4path + @"DroidMaxx-Mini-Ultra-MotoX\720x1280.bin",
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
                        LogoSize(@"4MB\DroidMaxx-Mini-Ultra-MotoX\720x1280.bin"),
                        logo4path + @"DroidMaxx-Mini-Ultra-MotoX\720x1280.bin",
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
                        LogoSize(@"4MB\DroidMaxx-Mini-Ultra-MotoX\720x1280.bin"),
                        logo4path + @"DroidMaxx-Mini-Ultra-MotoX\720x1280.bin",
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
                        LogoSize(@"4MB\Moto E-E2\560x960.bin"),
                        logo4path + @"Moto E-E2\560x960.bin",
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
                        LogoSize(@"4MB\Moto E-E2\560x960.bin"),
                        logo4path + @"Moto E-E2\560x960.bin",
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
                        LogoSize(@"4MB\Moto E-E2\560x960.bin"),
                        logo4path + @"Moto E-E2\560x960.bin",
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
                        LogoSize(@"4MB\Moto-G-G Google Play Edition-G Forte-G Ferrar iEdition-G-LTE\720x1280.bin"),
                        logo4path + @"Moto-G-G Google Play Edition-G Forte-G Ferrar iEdition-G-LTE\720x1280.bin",
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
                        LogoSize(@"4MB\Moto-G-G Google Play Edition-G Forte-G Ferrar iEdition-G-LTE\720x1280.bin"),
                        logo4path + @"Moto-G-G Google Play Edition-G Forte-G Ferrar iEdition-G-LTE\720x1280.bin",
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
                        LogoSize(@"4MB\Moto G2-G2 LTE\720x1280.bin"),
                        logo4path + @"Moto G2-G2 LTE\720x1280.bin",
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
                        LogoSize(@"4MB\Moto G2-G2 LTE\720x1280.bin"),
                        logo4path + @"Moto G2-G2 LTE\720x1280.bin",
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
                        LogoSize(@"4MB\Moto G3\720x1280.bin"),
                        logo4path + @"Moto G3\720x1280.bin",
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
                        LogoSize(@"4MB\Moto G3 Turbo Edition\720x1280.bin"),
                        logo4path + @"Moto G3 Turbo Edition\720x1280.bin",
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
                        LogoSize(@"4MB\Moto G4 Play\720x1280.bin"),
                        logo4path + @"Moto G4 Play\720x1280.bin",
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
                        LogoSize(@"4MB\DroidMaxx-Mini-Ultra-MotoX\720x1280.bin"),
                        logo4path + @"DroidMaxx-Mini-Ultra-MotoX\720x1280.bin",
                        Resources.motorola_moto_x_1);
                    return;
                }

                if (textBoxSearchDevice.Text.ToLower() == "moto x2" || textBoxSearchDevice.Text.ToLower() == "moto x 2014" || textBoxSearchDevice.Text.ToLower().Contains("victara"))
                {
                    CallForm("Motorola Moto X2 / 2014 - Victara",
                        "Motorola Moto X2 / 2014",
                        "Victara",
                        "1080 x 1920",
                        "4",
                        LogoSize(@"4MB\Moto X2\1080x1920.bin"),
                        logo4path + @"Moto X2\1080x1920.bin",
                        Resources.moto_x_2014_2);
                    return;
                }
                #endregion 4MIB Devices

                MessageBox.Show("Device: " + textBoxSearchDevice.Text + ", was not found, please input like this: moto g6 plus", "Device was not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchDevice_Click(object sender, EventArgs e)
        {
            CheckDevice();
        }
    }
}