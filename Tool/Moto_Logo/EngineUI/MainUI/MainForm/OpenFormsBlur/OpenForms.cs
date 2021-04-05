/* 
#####################################################################
#    File: MainForm.OpenForms.cs                                    #
#    Author: Franco28                                               # 
#    Date: 30-03-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class MainForm
    {

        private void downloadSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (DownloadS uu = new DownloadS())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (AboutBox uu = new AboutBox())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (ReadChangelog uu = new ReadChangelog())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (ToolSettings uu = new ToolSettings())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void testYourNewLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (LogoTest uu = new LogoTest())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
    }
}