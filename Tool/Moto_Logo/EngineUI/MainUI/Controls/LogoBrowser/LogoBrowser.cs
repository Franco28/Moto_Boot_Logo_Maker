
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class LogoBrowser : Form
    {

        public CultureInfo cul;
        public ResourceManager res_man;

        public LogoBrowser()
        {
            InitializeComponent(); 
            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Text = res_man.GetString("savefiledialog1Title", cul) + " logo.bin!";
            label1.Text = res_man.GetString("savefiledialog1Title", cul) + " logo.bin!";
        }

        public void Round(Panel picturebox)
        {
            using (var gp = new GraphicsPath())
            {
                picturebox.BackColor = Color.FromArgb(44, 44, 44);
                Rectangle r = new Rectangle(0, 0, picturebox.Width, picturebox.Height);
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                picturebox.Region = new Region(gp);
            }
        }

        private static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        private void ListDirectory(string path)
        {
            treeView1.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name) { Tag = file });

            return directoryNode;
        }

        private void LogoBrowser_Load(object sender, EventArgs e)
        {
            Round(panel);
            treeView1.Nodes.Clear();
            if (Properties.Profiles.Default.LogoMemory4MB == true)
            {
                if (Properties.Settings.Default.DeviceSelected == "MotoDroid")
                {
                    ListDirectory(exePath + @"\Files\Bin\4MB\MotoDroid\");
                    return;
                }

                if (Properties.Settings.Default.DeviceSelected == "MotoG")
                {
                    ListDirectory(exePath + @"\Files\Bin\4MB\MotoG\");
                    return;
                }

                if (Properties.Settings.Default.DeviceSelected == "MotoE")
                {
                    ListDirectory(exePath + @"\Files\Bin\4MB\MotoE\");
                    return;
                }

                if (Properties.Settings.Default.DeviceSelected == "MotoX")
                {
                    ListDirectory(exePath + @"\Files\Bin\4MB\MotoX\");
                    return;
                }
            }

            if (Properties.Profiles.Default.LogoMemory6MB == true)
            {
                if (Properties.Settings.Default.DeviceSelected == "MotoDroid")
                {
                    ListDirectory(exePath + @"\Files\Bin\6MB\MotoDroid\");
                    return;
                }

                if (Properties.Settings.Default.DeviceSelected == "MotoX")
                {
                    ListDirectory(exePath + @"\Files\Bin\6MB\MotoX\");
                    return;
                }
            }

            if (Properties.Profiles.Default.LogoMemory8MB == true)
            {
                if (Properties.Settings.Default.DeviceSelected == "MotoDroid")
                {
                    ListDirectory(exePath + @"\Files\Bin\8MB\MotoDroid\");
                    return;
                }

                if (Properties.Settings.Default.DeviceSelected == "MotoX")
                {
                    ListDirectory(exePath + @"\Files\Bin\8MB\MotoX\");
                    return;
                }

                if (Properties.Settings.Default.DeviceSelected == "Nexus")
                {
                    ListDirectory(exePath + @"\Files\Bin\8MB\Nexus\");
                    return;
                }
            }
        }

        public void buttonSelect_Click(object sender, EventArgs e)
        {
            string p = (treeView1.SelectedNode?.Tag as FileInfo)?.FullName;
            if (p != null)
            {
                if (p.EndsWith("bin"))
                {
                    this.Hide();
                    var mainform = Form.ActiveForm as MainForm;
                    mainform.OpenFile(p.ToString());
                    mainform.txtComments.Enabled = true;
                    mainform.cboMoto.Enabled = true;
                    mainform.groupBoxLogoFormat.Enabled = true;
                    mainform.groupBoxLogoResolution.Enabled = true;
                    mainform.groupBoxLogoImageOption.Enabled = true;
                    mainform.groupBoxLogoImageOrientation.Enabled = true;
                    mainform.groupBoxLogoExtension.Enabled = true;
                    mainform.textLogoName.Enabled = true;
                    mainform.txtLogoBuildPath.Enabled = true;
                    mainform.btnAttachPath.Enabled = true;
                    mainform.groupBoxLogoMemory.Enabled = false;
                    mainform.DisableControls();
                    mainform.labelbtnStop.Enabled = false;
                    mainform.btnStop.Enabled = false;
                    mainform.labelbtnBuild.Enabled = true;
                    mainform.btnBuild.Enabled = true;
                    Properties.Settings.Default.LogoBinOpen = p.ToString();
                    Properties.Settings.Default.Save();
                    return;
                }
                else
                {
                    MessageBox.Show("File " + p + " is not a .bin file!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("This " + p + " is a directory, not a file...");
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var opendialog = new SelectDevice();
            opendialog.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
