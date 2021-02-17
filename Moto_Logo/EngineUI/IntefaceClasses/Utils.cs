/* 
#####################################################################
#    File: Utils.cs                                                 #
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
using System.Runtime.InteropServices;
using Assembly = System.Reflection.Assembly;

namespace Moto_Logo
{
    public static class Utils
    {
        public static DateTime GetLinkerDateTime(this Assembly assembly, TimeZoneInfo tzi = null)
        {
            // Constants related to the Windows PE file format.
            const int PE_HEADER_OFFSET = 60;
            const int LINKER_TIMESTAMP_OFFSET = 8;

            // Discover the base memory address where our assembly is loaded
            var entryModule = assembly.ManifestModule;
            var hMod = Marshal.GetHINSTANCE(entryModule);
            if (hMod == IntPtr.Zero - 1) throw new Exception("Failed to get HINSTANCE.");

            // Read the linker timestamp
            var offset = Marshal.ReadInt32(hMod, PE_HEADER_OFFSET);
            var secondsSince1970 = Marshal.ReadInt32(hMod, offset + LINKER_TIMESTAMP_OFFSET);

            // Convert the timestamp to a DateTime
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var linkTimeUtc = epoch.AddSeconds(secondsSince1970);
            var dt = TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, tzi ?? TimeZoneInfo.Local);
            return dt;
        }
    }
}