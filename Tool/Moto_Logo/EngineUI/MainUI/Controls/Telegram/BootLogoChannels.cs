/* 
#####################################################################
#    File: BootLogoChannels.cs                                      #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class BootLogoChannels : Form
    {
        public CultureInfo cul;
        public ResourceManager res_man;

        public BootLogoChannels()
        {
            InitializeComponent();
        }             

        private void BootLogoChannels_Load(object sender, System.EventArgs e)
        {

        }
    }
}
