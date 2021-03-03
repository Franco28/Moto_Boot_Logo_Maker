/* 
#####################################################################
#    File: MainForm.ThemeEngine.cs                                  #
#    Author: Franco28                                               # 
#    Date: 03-03-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class MainForm
    {
        private void toolStripSeparator2_Paint(object sender, PaintEventArgs e)
        {
            ToolStripSeparator sep = (ToolStripSeparator)sender;
            if (Properties.Settings.Default.Theme == "dark")
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), 0, 0, sep.Width, sep.Height);
                e.Graphics.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), 30, sep.Height / 2, sep.Width - 4, sep.Height / 2);
            }
            if (Properties.Settings.Default.Theme == "light")
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 0, 0, sep.Width, sep.Height);
                e.Graphics.DrawLine(new Pen(Color.FromArgb(38, 38, 38)), 30, sep.Height / 2, sep.Width - 4, sep.Height / 2);
            }
        }

        private void btnBuild_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnBuild.BackColor = Color.FromArgb(48, 48, 48);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnBuild.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnBuild_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnBuild.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnBuild.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnStop_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnStop.BackColor = Color.FromArgb(48, 48, 48);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnStop.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnStop.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnStop.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnAttachPath_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnAttachPath.BackColor = Color.FromArgb(48, 48, 48);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnAttachPath.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnAttachPath_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnAttachPath.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnAttachPath.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnOpenLogoFile_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnOpenLogoFile.BackColor = Color.FromArgb(48, 48, 48);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnOpenLogoFile.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnOpenLogoFile_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnOpenLogoFile.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnOpenLogoFile.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnSearchDevice_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnSearchDevice.BackColor = Color.FromArgb(48, 48, 48);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnSearchDevice.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnSearchDevice_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnSearchDevice.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnSearchDevice.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnExit.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnExit.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnMaximize_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnMaximize.BackColor = Color.FromArgb(48, 48, 48);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnMaximize.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnMaximize.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnMaximize.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnMinimize.BackColor = Color.FromArgb(48, 48, 48);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnMinimize.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnMinimize.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnMinimize.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnReload_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnReload.BackColor = Color.FromArgb(48, 48, 48);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnReload.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void btnReload_MouseLeave(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                btnReload.BackColor = Color.FromArgb(38, 38, 38);
            }
            else if (Properties.Settings.Default.Theme == "light")
            {
                btnReload.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        public async void Dark()
        {
            await Task.Run(() =>
            {
                LoadMenuStripItemsTheme();
                menuStrip1.Renderer = new RendererDarkTheme();

                statusStrip1.BackColor = menuStrip1.BackColor = Color.FromArgb(38, 38, 38);
                statusStrip1.ForeColor = groupBoxLogoExtension.ForeColor = groupBoxLogoFormat.ForeColor = groupBoxLogoResolution.ForeColor = groupBoxLogoImageOption.ForeColor = groupBoxLogoImageOrientation.ForeColor = groupBoxLogoMemory.ForeColor = menuStrip1.ForeColor = Color.FromArgb(250, 232, 232);

                buttonDelete.ForeColor = Color.Red;
                buttonAppend.ForeColor = Color.Green;
                buttonAppend.FlatStyle = buttonDelete.FlatStyle = buttonExtract.FlatStyle = FlatStyle.Flat;
                buttonAppend.BackColor = buttonDelete.BackColor = buttonExtract.BackColor = Color.FromArgb(38, 38, 38);
                buttonExtract.ForeColor = Color.FromArgb(250, 232, 232);
            });
        }

        public async void Light()
        {
            await Task.Run(() =>
            {
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(38, 38, 38);

                menuStrip1.Renderer = new RendererLighTheme();

                textBoxSearchDevice.BackColor = helpToolStripMenuItem.BackColor = settingsToolStripMenuItem.BackColor = testToolStripMenuItem.BackColor = othersToolStripMenuItem.BackColor = fileToolStripMenuItem.BackColor = labelErrorInfo.BackColor = labelErrorIcon.BackColor = labelGoToError.BackColor = labelErrorGoToFileInfo.BackColor = cboMoto.BackColor = textLogoName.BackColor = statusStrip1.BackColor = groupBoxLogoExtension.BackColor = labelBuildPath.BackColor = txtLogoBuildPath.BackColor =  menuStrip1.BackColor = labelimageInfoDClick.BackColor = labelimageInfoClick.BackColor = labelColorDraw.BackColor = labelImageStatus.BackColor = picZoom.BackColor = udResolutionX.BackColor = udResolutionY.BackColor = flowLayoutPanel3.BackColor = flowLayoutPanel4.BackColor = flowLayoutPanel5.BackColor = flowLayoutPanel6.BackColor = groupBoxLogoMemory.BackColor = groupBoxLogoImageOrientation.BackColor = groupBoxLogoImageOption.BackColor = labelLogos.BackColor = groupBoxLogoFormat.BackColor = groupBoxLogoResolution.BackColor = txtLogoInternalFile.BackColor = txtComments.BackColor = tvLogo.BackColor = Color.FromArgb(255, 255, 255);
                textBoxSearchDevice.ForeColor = helpToolStripMenuItem.ForeColor = settingsToolStripMenuItem.ForeColor = testToolStripMenuItem.ForeColor = othersToolStripMenuItem.ForeColor = fileToolStripMenuItem.ForeColor = labelErrorInfo.ForeColor = labelErrorIcon.ForeColor = labelGoToError.ForeColor = labelErrorGoToFileInfo.ForeColor = cboMoto.ForeColor = textLogoName.ForeColor = statusStrip1.ForeColor = groupBoxLogoExtension.ForeColor = labelBuildPath.ForeColor = txtLogoBuildPath.ForeColor = menuStrip1.ForeColor = labelimageInfoDClick.ForeColor = labelimageInfoClick.ForeColor = labelColorDraw.ForeColor = labelImageStatus.ForeColor = udResolutionX.ForeColor = udResolutionY.ForeColor = flowLayoutPanel3.ForeColor = flowLayoutPanel4.ForeColor = flowLayoutPanel5.ForeColor = flowLayoutPanel6.ForeColor = groupBoxLogoMemory.ForeColor = groupBoxLogoImageOrientation.ForeColor = groupBoxLogoImageOption.ForeColor = labelLogos.ForeColor = groupBoxLogoFormat.ForeColor = groupBoxLogoResolution.ForeColor = txtLogoInternalFile.ForeColor = txtComments.ForeColor = tvLogo.ForeColor = Color.FromArgb(38, 38, 38);
                buttonDelete.ForeColor = Color.Red;
                buttonAppend.ForeColor = Color.Green;
                buttonAppend.BackColor = buttonDelete.BackColor = buttonExtract.BackColor = Color.FromArgb(255, 255, 255);
                buttonExtract.ForeColor = Color.FromArgb(38, 38, 38);
            });
        }

        private void LoadMenuStripItemsTheme()
        {
            toolStripMenuItemOpenCustomLogo.BackColor = motoG6ToolStripMenuItem.BackColor = motoG6PlayToolStripMenuItem.BackColor = motoG7PlusToolStripMenuItem.BackColor = downloadSiteToolStripMenuItem.BackColor = motoG7PlayToolStripMenuItem.BackColor = lighttoolStripMenuItem.BackColor = darktoolStripMenuItem.BackColor = checkForUpdatesToolStripMenuItem.BackColor = themetoolStripMenuItem.BackColor = aboutToolStripMenuItem1.BackColor = changelogToolStripMenuItem.BackColor = sourceToolStripMenuItem.BackColor = testYourNewLogoToolStripMenuItem.BackColor = motoG7PowerToolStripMenuItem.BackColor = motoG7ToolStripMenuItem.BackColor = mToolStripMenuItem.BackColor = joinTelegramBootLogosToolStripMenuItem.BackColor = openToolStripMenuItem.BackColor = newToolStripMenuItem.BackColor = Color.FromArgb(38, 38, 38);
            toolStripMenuItemOpenCustomLogo.ForeColor = motoG6ToolStripMenuItem.ForeColor = motoG6PlayToolStripMenuItem.ForeColor = motoG7PlusToolStripMenuItem.ForeColor = downloadSiteToolStripMenuItem.ForeColor = motoG7PlayToolStripMenuItem.ForeColor = lighttoolStripMenuItem.ForeColor = darktoolStripMenuItem.ForeColor = checkForUpdatesToolStripMenuItem.ForeColor = themetoolStripMenuItem.ForeColor = aboutToolStripMenuItem1.ForeColor = changelogToolStripMenuItem.ForeColor = sourceToolStripMenuItem.ForeColor = testYourNewLogoToolStripMenuItem.ForeColor = motoG7PowerToolStripMenuItem.ForeColor = motoG7ToolStripMenuItem.ForeColor = mToolStripMenuItem.ForeColor = joinTelegramBootLogosToolStripMenuItem.ForeColor = openToolStripMenuItem.ForeColor = newToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private class RendererLighTheme : ToolStripProfessionalRenderer
        {
            public RendererLighTheme() : base(new ColorsLighTheme()) { }
        }

        private class ColorsLighTheme : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(255, 255, 255); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(255, 255, 255); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(255, 255, 255); }
            }
        }

        private class RendererDarkTheme : ToolStripProfessionalRenderer
        {
            public RendererDarkTheme() : base(new ColorsDarkTheme()) { }
        }

        private class ColorsDarkTheme : ProfessionalColorTable
        {
            public override Color MenuBorder
            {
                get { return Color.FromArgb(255, 80, 80, 80); }
            }
            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(255, 80, 80, 80); }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(255, 80, 80, 80); }
            }
            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.FromArgb(255, 80, 80, 80); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(255, 80, 80, 80); }
            }
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(125, 114, 114); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(125, 114, 114); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(255, 80, 80, 80); }
            }
        }

        public void ChangeTheme(string theme)
        {
            AutoClosingMessageBox.Show(res_man.GetString("ChangeThemeInfo", cul), "Moto_Boot_Logo_Maker", 2000);
            Properties.Settings.Default.Theme = theme;
            Properties.Settings.Default.Save();
            RestartApp();
        }

        private void darktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("dark");
        }

        private void lighttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("light");
        }
    }
}