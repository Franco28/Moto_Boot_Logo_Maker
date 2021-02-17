/* 
#####################################################################
#    File: MainForm.LogoTree.cs                                     #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
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

        // ReSharper disable InconsistentNaming
        [Flags]
        private enum LOGO
        {
            LOGO_RAW = 0,
            LOGO_BOOT = 1,
            LOGO_BATTERY = 2,
            LOGO_UNLOCKED = 4,
            LOGO_LOWPOWER = 8,
            LOGO_UNPLUG = 0x10,
            LOGO_CHARGE = 0x20,
            DEFAULT_DISABLED = 0x40000000,
            LOGO_YELLOW = 0x30,
            LOGO_ORANGE = 0x40,
            LOGO_RED = 0x50
        };
        // ReSharper restore InconsistentNaming

        private void init_tree(LOGO logo)
        {
            init_tree((UInt64)logo);
        }

        private void init_tree(UInt64 logobincontents)
        {
            if (logobincontents == (int)LOGO.LOGO_RAW)
            {
                init_tree(LOGO.LOGO_UNLOCKED);
                rdoAndroid43.Enabled = false;
                rdoAndroid44.Enabled = false;
                rdoAndroidRAW.Checked = true;
                return;
            }
            var enableDefault = ((logobincontents & (int)LOGO.DEFAULT_DISABLED) == 0);
            rdoAndroid43.Enabled = true;
            rdoAndroid44.Enabled = enableDefault;
            if (_autoselectlogobinversion && enableDefault) rdoAndroid44.Checked = true;
            else if (_autoselectlogobinversion && rdoAndroid44.Checked) rdoAndroid43.Checked = true;
            init_tree((logobincontents & (UInt64)LOGO.LOGO_BOOT) == (UInt64)LOGO.LOGO_BOOT,
                (logobincontents & (UInt64)LOGO.LOGO_BATTERY) == (UInt64)LOGO.LOGO_BATTERY,
                (logobincontents & (UInt64)LOGO.LOGO_UNLOCKED) == (UInt64)LOGO.LOGO_UNLOCKED,
                (logobincontents & (UInt64)LOGO.LOGO_LOWPOWER) == (UInt64)LOGO.LOGO_LOWPOWER,
                (logobincontents & (UInt64)LOGO.LOGO_UNPLUG) == (UInt64)LOGO.LOGO_UNPLUG,
                (logobincontents & (UInt64)LOGO.LOGO_CHARGE) == (UInt64)LOGO.LOGO_CHARGE,
                (logobincontents & (UInt64)LOGO.LOGO_ORANGE) == (UInt64)LOGO.LOGO_ORANGE,
                (logobincontents & (UInt64)LOGO.LOGO_RED) == (UInt64)LOGO.LOGO_RED,
                (logobincontents & (UInt64)LOGO.LOGO_YELLOW) == (UInt64)LOGO.LOGO_YELLOW);
        }

        private bool Keeptreenode(TreeNode node, bool keep)
        {
            if (!keep && (cboMoto.SelectedIndex > 0)) node.Remove();
            return keep;
        }

        private void init_tree(bool logoboot, bool logobattery,
            bool logounlocked, bool logolowpower, bool logounplug, bool logocharge, bool logoyellow, bool logored, bool logoorange)
        {
            var logoBoot = false;
            var logoBattery = false;
            var logoUnlocked = false;
            var logoLowpower = false;
            var logoUnplug = false;
            var logoCharge = false;
            var logoOrange = false;
            var logoRed = false;
            var logoYellow = false;
            for (var index = tvLogo.Nodes.Count - 1; index >= 0; index--)
            {
                var node = tvLogo.Nodes[index];
                switch (node.Text)
                {
                    case "logo_boot":
                        logoBoot = Keeptreenode(node, logoboot);
                        break;
                    case "logo_battery":
                        logoBattery = Keeptreenode(node, logobattery);
                        break;
                    case "logo_unlocked":
                        logoUnlocked = Keeptreenode(node, logounlocked);
                        break;
                    case "logo_lowpower":
                        logoLowpower = Keeptreenode(node, logolowpower);
                        break;
                    case "logo_unplug":
                        logoUnplug = Keeptreenode(node, logounplug);
                        break;
                    case "logo_charge":
                        logoCharge = Keeptreenode(node, logocharge);
                        break;
                    case "logo_yellow":
                        logoYellow = Keeptreenode(node, logoyellow);
                        break;
                    case "logo_orange":
                        logoOrange = Keeptreenode(node, logoorange);
                        break;
                    case "logo_red":
                        logoRed = Keeptreenode(node, logored);
                        break;
                }
            }
            if (!logoBoot && logoboot) tvLogo.Nodes.Add("logo_boot");
            if (!logoBattery && logobattery) tvLogo.Nodes.Add("logo_battery");
            if (!logoUnlocked && logounlocked) tvLogo.Nodes.Add("logo_unlocked");
            if (!logoLowpower && logolowpower) tvLogo.Nodes.Add("logo_lowpower");
            if (!logoUnplug && logounplug) tvLogo.Nodes.Add("logo_unplug");
            if (!logoCharge && logocharge) tvLogo.Nodes.Add("logo_charge");
            if (!logoOrange && logoorange) tvLogo.Nodes.Add("logo_orange");
            if (!logoYellow && logoyellow) tvLogo.Nodes.Add("logo_yellow");
            if (!logoRed && logored) tvLogo.Nodes.Add("logo_red");
            for (var index = tvLogo.Nodes.Count - 1; index >= 0; index--)
            {
                var node = tvLogo.Nodes[index];
                switch (node.Text)
                {
                    case "logo_boot":
                        node.ToolTipText = res_man.GetString("logo_boot_ToolTipText", cul) + " " +
                                           res_man.GetString("logo_boot_ToolTipText2", cul);
                        break;
                    case "logo_battery":
                        node.ToolTipText = res_man.GetString("logo_battery_ToolTipText", cul) + " " +
                                           res_man.GetString("logo_battery_ToolTipText2", cul);
                        break;
                    case "logo_unlocked":
                        node.ToolTipText = res_man.GetString("logo_unlocked_ToolTipText", cul) + " " +
                                           res_man.GetString("logo_unlocked_ToolTipText2", cul);
                        break;
                    case "logo_lowpower":
                        node.ToolTipText = res_man.GetString("logo_lowpower_ToolTipText", cul) + " \n" +
                                           res_man.GetString("logo_lowpower_ToolTipText2", cul);
                        break;
                    case "logo_unplug":
                        node.ToolTipText = res_man.GetString("logo_unplug_ToolTipText", cul) + " \n" +
                                           res_man.GetString("logo_unplug_ToolTipText2", cul);
                        break;
                    case "logo_charge":
                        node.ToolTipText = res_man.GetString("logo_charge_ToolTipText", cul) + " " +
                                           res_man.GetString("logo_charge_ToolTipText2", cul);
                        break;
                    case "logo_red":
                        node.ToolTipText = res_man.GetString("logo_red_ToolTipText", cul);
                        break;
                    case "logo_yellow":
                        node.ToolTipText = res_man.GetString("logo_yellow_ToolTipText", cul);
                        break;
                    case "logo_orange":
                        node.ToolTipText = res_man.GetString("logo_orange_ToolTipText", cul) + " " +
                                           res_man.GetString("logo_orange_ToolTipText2", cul);
                        break;
                }
            }
        }
    }
}