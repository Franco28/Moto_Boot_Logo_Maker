/* 
#####################################################################
#    File: FilesMng.cs                                              #
#    Author: Franco28                                               # 
#    Date: 22-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace Moto_Logo
{
    public class FilesMng
    {
        public string m_sConfigFileName = "FilesInfo.xml";
        public SettingsFiles m_oConfig = new SettingsFiles();
        public string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public SettingsFiles Config
        {
            get { return m_oConfig; }
            set { m_oConfig = value; }
        }

        public void LoadConfig()
        {
            try
            {
                var settingspath = exePath + "\\Files\\";
                if (File.Exists(settingspath + m_sConfigFileName))
                {
                    StreamReader srReader = File.OpenText(settingspath + m_sConfigFileName);
                    Type tType = m_oConfig.GetType();
                    System.Xml.Serialization.XmlSerializer xsSerializer = new System.Xml.Serialization.XmlSerializer(tType);
                    object oData = xsSerializer.Deserialize(srReader);
                    m_oConfig = (SettingsFiles)oData;
                    srReader.Close();
                }

            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString() + " " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SaveConfig()
        {
            try
            {
                var settingspath = exePath + "\\Files\\";
                StreamWriter swWriter = File.CreateText(settingspath + m_sConfigFileName);
                Type tType = m_oConfig.GetType();
                if (tType.IsSerializable)
                {
                    System.Xml.Serialization.XmlSerializer xsSerializer = new System.Xml.Serialization.XmlSerializer(tType);
                    xsSerializer.Serialize(swWriter, m_oConfig);
                    swWriter.Close();
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString() + " " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
