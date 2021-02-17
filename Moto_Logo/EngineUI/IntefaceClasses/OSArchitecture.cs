/* 
#####################################################################
#    File: OSArchicteture.cs                                        #
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
    public class OSArchitecture
    {
        public static string Get()
        {
            if (IntPtr.Size == 8)
            {
                return " x64";
            }
            else
            {
                return " x86";
            }
        }
    }
}
