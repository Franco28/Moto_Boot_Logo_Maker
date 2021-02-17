/* 
#####################################################################
#    File: MainForm.TelegramChannels.cs                             #
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

namespace Moto_Logo
{
    public partial class MainForm
    {
        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTelegramChannel("https://t.me/MotoG4_G5Bootlogos/");
        }

        private void motoG7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTelegramChannel("https://t.me/RiverBootlogos/");
        }

        private void motoG7PowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTelegramChannel("https://t.me/OceanBootlogos/");
        }

        private void motoG7PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTelegramChannel("http://t.me/channelbootlogos");
        }

        private void motoG7PlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTelegramChannel("http://t.me/LakeBootlogos");
        }

        private void motoG6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTelegramChannel("http://t.me/AliBootlogos");
        }

        private void motoG6PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTelegramChannel("http://t.me/AljeterBootlogos");
        }
    }
}