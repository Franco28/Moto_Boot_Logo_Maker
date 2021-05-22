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

namespace Moto_Logo
{
    public partial class MainForm
    {

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changelog = new ReadChangelog();
            changelog.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new ToolSettings();
            settings.ShowDialog();
        }       
    }
}