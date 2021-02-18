/* 
#####################################################################
#    File: SettingsFiles.cs                                         #
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

    [Serializable()]
    public class SettingsFiles
    {
        private System.String m_oFileVersion;
        private System.String m_oFileURL;
        private System.String m_oFileName;
        private System.String m_oFileSize;
        private System.String m_oDLLSize;
        private System.String m_oDLLName;
        private System.String m_oDLLURL;
        private System.String m_oDLLVersion;

        public System.String DLLSize
        {
            get { return m_oDLLSize; }
            set { m_oDLLSize = value; }
        }

        public System.String DLLVersion
        {
            get { return m_oDLLVersion; }
            set { m_oDLLVersion = value; }
        }

        public System.String DLLURL
        {
            get { return m_oDLLURL; }
            set { m_oDLLURL = value; }
        }

        public System.String DLLName
        {
            get { return m_oDLLName; }
            set { m_oDLLName = value; }
        }

        //

        public System.String FileSize
        {
            get { return m_oFileSize; }
            set { m_oFileSize = value; }
        }

        public System.String FileVersion
        {
            get { return m_oFileVersion; }
            set { m_oFileVersion = value; }
        }

        public System.String FileURL
        {
            get { return m_oFileURL; }
            set { m_oFileURL = value; }
        }

        public System.String FileName
        {
            get { return m_oFileName; }
            set { m_oFileName = value; }
        }
    }
}