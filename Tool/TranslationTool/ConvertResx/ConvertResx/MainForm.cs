
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ConvertResx
{
    public partial class MainForm : Form
    {
        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        private CultureInfo ci = CultureInfo.InstalledUICulture;

        public MainForm()
        {
            InitializeComponent();
        }

        public void ExecuteCommandSync(object command)
        {
            try
            {
                ProcessStartInfo procStartInfo =
                    new ProcessStartInfo("cmd", "/c " + command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();
                cAppend("");
                cAppend(result);
                cAppend("Done!");
            }
            catch (Exception ex)
            {
                cAppend("");
                cAppend("Error: " + ex.ToString());
                cAppend("");
                return;
            }
        }

        public void cAppend(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText("\n" + message);
                console.ScrollToCaret();
            });
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.None;
                if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if ((files.Count() == 1) && ((Path.GetExtension(files[0]) == ".resx") ||
                                            (Path.GetExtension(files[0]) == ".txt")))
                {
                    e.Effect = DragDropEffects.Copy;
                }               
            }
            catch (Exception ex)
            {
                cAppend("");
                cAppend("Error: " + ex.ToString());
                return;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if ((files.Count() == 1) && ((Path.GetExtension(files[0]) == ".resx") ||
                                             (Path.GetExtension(files[0]) == ".txt")))
                {
                    cAppend("");
                    cAppend("File: " + files[0].ToString());

                    string[] fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
                    string filename = Path.GetFileName(fileList[0]);
                    Properties.Settings.Default.FilePath = files[0].ToString();
                    Properties.Settings.Default.FileName = filename;
                    Properties.Settings.Default.Save();

                    if (Path.GetExtension(Properties.Settings.Default.FileName) == ".resx")
                    {
                        buttonResx.FlatAppearance.BorderColor = Color.Blue;
                    }

                    if (Path.GetExtension(Properties.Settings.Default.FileName) == ".txt")
                    {
                        buttonTXT.FlatAppearance.BorderColor = Color.Blue;
                    }
                }
                else
                {
                    cAppend("");
                    cAppend("Error: " + files[0] + " is not a .resx file or .txt file");
                    return;
                }
            }
            catch (Exception ex)
            {
                cAppend("");
                cAppend("Error: " + ex.ToString());
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "resx <--> txt file converter by Franco28 - " + "v" + Application.ProductVersion;
            cAppend("resx <--> txt file converter by Franco28");
            cAppend("\nTo start: \nDrag and drop the .resx or .txt file to convert into this Page!");
            cAppend("");

            if (File.Exists(exePath + "\\Settings.config"))
            {
                if (Properties.Settings.Default.FileName != string.Empty && Properties.Settings.Default.FilePath != string.Empty && Properties.Settings.Default.LangCul != string.Empty)
                {
                    cAppend("- Previous File Info: ");
                    if (Properties.Settings.Default.FileName != string.Empty)
                    {
                        cAppend("* File Name: " + Properties.Settings.Default.FileName);
                    }
                    if (Properties.Settings.Default.FilePath != string.Empty)
                    {
                        cAppend("* File: " + Properties.Settings.Default.FilePath);
                    }
                    if (Properties.Settings.Default.LangCul != string.Empty)
                    {
                        cAppend("* File Culture: " + Properties.Settings.Default.LangCul);
                        textBoxLang.Text = Properties.Settings.Default.LangCul;
                    }
                }
            }     
        }

        private void buttonResx_Click(object sender, EventArgs e)
        {         
            if (Properties.Settings.Default.FileName == string.Empty)
            {
                return;
            }

            if (Path.GetExtension(Properties.Settings.Default.FileName) == ".txt")
            {
                buttonResx.FlatAppearance.BorderColor = Color.Red;
                return;
            }

            if (textBoxLang.Text == string.Empty)
            {
                MessageBox.Show("Please input the lang culture");
                textBoxLang.Focus();
                return;
            }

            // Start
            ExecuteCommandSync("resgen.exe " + Properties.Settings.Default.FilePath + " " + textBoxLang.Text + ".txt");
        }

        private void buttonTXT_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FileName == string.Empty)
            {
                return;
            }

            if (Path.GetExtension(Properties.Settings.Default.FileName) == ".resx")
            {
                buttonTXT.FlatAppearance.BorderColor = Color.Red;
                return;
            }

            if (textBoxLang.Text == string.Empty)
            {
                textBoxLang.Focus();
                return;
            }

            // Start
            ExecuteCommandSync("resgen.exe " + Properties.Settings.Default.FilePath + " " + "Resources." + Path.GetFileNameWithoutExtension(Properties.Settings.Default.FileName) + ".resx");
        }

        private void buttonClearConsole_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FileName = "";
            Properties.Settings.Default.Save();

            if (buttonTXT.FlatAppearance.BorderColor == Color.Red || buttonTXT.FlatAppearance.BorderColor == Color.Blue)
            {
                buttonTXT.FlatAppearance.BorderColor = Color.Black;
            }

            if (buttonResx.FlatAppearance.BorderColor == Color.Red || buttonResx.FlatAppearance.BorderColor == Color.Blue)
            {
                buttonResx.FlatAppearance.BorderColor = Color.Black;
            }

            console.Clear();
            cAppend("resx <--> txt file converter by Franco28");
            cAppend("\nTo start: \nDrag and drop the .resx or .txt file to convert into this Page!");
            cAppend("");
        }

        private void textBoxLang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxLang_TextChanged(object sender, EventArgs e)
        {
            cAppend("");
            cAppend("Selected Lang: " + textBoxLang.Text);
            Properties.Settings.Default.LangCul = textBoxLang.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/bingmaps/rest-services/common-parameters-and-types/supported-culture-codes");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();

            string taskname = "ConvertResx";
            foreach (var process in Process.GetProcessesByName(taskname))
            {
                process.Kill();
            }
        }
    }
}
