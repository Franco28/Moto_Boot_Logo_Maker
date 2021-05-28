
using Bluegrams.Application;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConvertResx
{
    static class Program
    {
        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        [STAThread]
        static void Main()
        {
            int process = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;
            if (process > 1)
            {
                return;
            }

            // Set DPI AWARE
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            PortableSettingsProvider.SettingsFileName = "Settings.config";
            PortableSettingsProvider.SettingsDirectory = exePath;
            PortableSettingsProvider.ApplyProvider(Properties.Settings.Default);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Start();
        }

        public static void Start()
        {
            Application.Run(new MainForm());
        }

        [DllImport("User32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
