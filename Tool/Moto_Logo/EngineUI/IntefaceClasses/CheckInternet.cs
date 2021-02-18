/* 
#####################################################################
#    File: CheckInternet.cs                                         #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Resources;
using System.Windows.Forms;

namespace Moto_Logo
{
    public class InternetCheck
    {
        public static readonly CultureInfo cul = null;
        public static ResourceManager res_man;

        public static void CheckInternetProcessStart(string url)
        {
            if (InternetCheck.ConnectToInternet() == true)
            {
                Process.Start(url);
            }
            else
            {
                MessageBox.Show(res_man.GetString("InternetCheck", cul), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public static bool ConnectToInternet(int timeout_per_host_millis = 1000, string[] hosts_to_ping = null)
        {
            bool network_available = NetworkInterface.GetIsNetworkAvailable();

            if (network_available)
            {
                string[] hosts = hosts_to_ping ?? new string[] { "www.google.com", "www.facebook.com" };
                Ping p = new Ping();

                foreach (string host in hosts)
                {
                    try
                    {
                        PingReply r = p.Send(host, timeout_per_host_millis);
                        if (r.Status == IPStatus.Success)
                            return true;
                    }
                    catch { }
                }
            }
            return false;
        }

        public static bool CheckServerRed(string serverurl, int timeout_per_host_millis = 1000, string[] hosts_to_ping = null)
        {
            bool network_available = NetworkInterface.GetIsNetworkAvailable();

            if (network_available)
            {
                string[] hosts = hosts_to_ping ?? new string[] { serverurl };
                Ping p = new Ping();

                foreach (string host in hosts)
                {
                    try
                    {
                        PingReply r = p.Send(host, timeout_per_host_millis);
                        if (r.Status == IPStatus.Success)
                            return true;
                    }
                    catch { }
                }
            }
            return false;
        }
    }
}