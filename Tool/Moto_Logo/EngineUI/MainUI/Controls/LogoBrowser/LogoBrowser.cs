
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

        public void CheckDeviceAndFolder(string device, string path)
        {
            if (Properties.Settings.Default.DeviceSelected == device)
            {
                ListDirectory(exePath + @"\Files\Bin\" + path);
                return;
            }
        }

        private void LogoBrowser_Load(object sender, EventArgs e)
        {
            Round(panel);
            treeView1.Nodes.Clear();
            if (Properties.Profiles.Default.LogoMemory4MB == true)
            {
                CheckDeviceAndFolder("MotoDroid", @"4MB\MotoDroid\");
                CheckDeviceAndFolder("MotoG", @"4MB\MotoG\");
                CheckDeviceAndFolder("MotoE", @"4MB\MotoE\");
                CheckDeviceAndFolder("MotoX", @"4MB\MotoX\");
            }

            if (Properties.Profiles.Default.LogoMemory6MB == true)
            {
                CheckDeviceAndFolder("MotoDroid", @"6MB\MotoDroid\");
                CheckDeviceAndFolder("MotoX", @"6MB\MotoX\");
            }

            if (Properties.Profiles.Default.LogoMemory8MB == true)
            {
                CheckDeviceAndFolder("MotoDroid", @"8MB\MotoDroid\");
                CheckDeviceAndFolder("MotoX", @"8MB\MotoX\");
                CheckDeviceAndFolder("Nexus", @"8MB\Nexus\");
            }

            if (Properties.Profiles.Default.LogoMemory16MB == true)
            {
                CheckDeviceAndFolder("MotoE", @"16MB\MotoE\");
                CheckDeviceAndFolder("MotoEdge", @"16MB\MotoEdge\");
                CheckDeviceAndFolder("MotoG", @"16MB\MotoG\");
                CheckDeviceAndFolder("MotoOne", @"16MB\MotoOne\");
                CheckDeviceAndFolder("MotoZ", @"16MB\MotoZ\");
            }

            if (Properties.Profiles.Default.LogoMemory32MB == true)
            {
                CheckDeviceAndFolder("MotoEdge", @"32MB\MotoEdge\");
                CheckDeviceAndFolder("MotoG", @"32MB\MotoG\");
                CheckDeviceAndFolder("MotoOne", @"32MB\MotoOne\");
                CheckDeviceAndFolder("MotoZ", @"32MB\MotoZ\");
                CheckDeviceAndFolder("MotoX", @"32MB\MotoX\");
            }
        }

        public void buttonSelect_Click(object sender, EventArgs e)
        {
            string sN = (treeView1.SelectedNode?.Tag as FileInfo)?.FullName;
            if (sN != null)
            {
                if (sN.EndsWith("bin"))
                {
                    this.Hide();
                    var mainform = Form.ActiveForm as MainForm;
                    mainform.OpenFile(sN.ToString());
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
                    Properties.Settings.Default.LogoBinOpen = sN.ToString();
                    Properties.Settings.Default.Save();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("File " + sN + " is not a .bin file... Select only .bin files!", "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("This " + sN + " is a directory...", "Moto_Boot_Logo_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
