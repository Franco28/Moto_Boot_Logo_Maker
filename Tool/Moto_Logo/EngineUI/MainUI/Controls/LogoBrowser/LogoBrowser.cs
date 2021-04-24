/* 
#####################################################################
#    File: LogoBrowser.cs                                           #
#    Author: Franco28                                               # 
#    Date: 21-04-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Media;
using System.Resources;
using System.Windows.Forms;
using DarkUI.Forms;
using Moto_Logo.Properties;

namespace Moto_Logo
{
    public partial class LogoBrowser : DarkForm
    {

        public CultureInfo cul;
        public ResourceManager res_man;

        public LogoBrowser()
        {
            InitializeComponent(); 
            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            buttonSelect.Text = res_man.GetString("LogoBrowserSelectButton", cul);
        }


        // Add Small Icon to TreeView
        static ImageList _imageList;
        public static ImageList ImageList
        {
            get
            {
                if (_imageList == null)
                {
                    _imageList = new ImageList();
                    _imageList.Images.Add("FolderClosed", Resources.folder_Closed_LogoBrowser_16xLG);
                    _imageList.Images.Add("FolderOpened", Resources.folder_LogoBrowser_16x);
                    _imageList.Images.Add("File", Resources.filesLogoBrowser_x16);
                }
                return _imageList;
            }
        }

        public void Round(Panel panel)
        {
            using (var gp = new GraphicsPath())
            {
                Rectangle r = new Rectangle(0, 0, panel.Width, panel.Height);
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                panel.Region = new Region(gp);
            }
        }

        public static string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public void ListDirectory(string path)
        {
            treeView1.Nodes.Clear();

            // Set Image to TreeView
            treeView1.ImageList = LogoBrowser.ImageList;

            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        public static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
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

        public void LogoBrowser_Load(object sender, EventArgs e)
        {
            Round(panel);
            treeView1.Nodes.Clear();
            try
            {
                if (Properties.Profiles.Default.LogoMemory4MB == true)
                {
                    this.Text = res_man.GetString("savefiledialog1Title", cul) + " 4MB logo.bin...";
                    label1.Text = res_man.GetString("savefiledialog1Title", cul) + " 4MB logo.bin...";

                    CheckDeviceAndFolder("MotoDroid", @"4MB\MotoDroid\");
                    CheckDeviceAndFolder("MotoG", @"4MB\MotoG\");
                    CheckDeviceAndFolder("MotoE", @"4MB\MotoE\");
                    CheckDeviceAndFolder("MotoX", @"4MB\MotoX\");
                }

                if (Properties.Profiles.Default.LogoMemory6MB == true)
                {
                    this.Text = res_man.GetString("savefiledialog1Title", cul) + " 6MB logo.bin...";
                    label1.Text = res_man.GetString("savefiledialog1Title", cul) + " 6MB logo.bin...";

                    CheckDeviceAndFolder("MotoDroid", @"6MB\MotoDroid\");
                    CheckDeviceAndFolder("MotoX", @"6MB\MotoX\");
                }

                if (Properties.Profiles.Default.LogoMemory8MB == true)
                {
                    this.Text = res_man.GetString("savefiledialog1Title", cul) + " 8MB logo.bin...";
                    label1.Text = res_man.GetString("savefiledialog1Title", cul) + " 8MB logo.bin...";

                    CheckDeviceAndFolder("MotoDroid", @"8MB\MotoDroid\");
                    CheckDeviceAndFolder("MotoX", @"8MB\MotoX\");
                    CheckDeviceAndFolder("Nexus", @"8MB\Nexus\");
                }

                if (Properties.Profiles.Default.LogoMemory16MB == true)
                {
                    this.Text = res_man.GetString("savefiledialog1Title", cul) + " 16MB logo.bin...";
                    label1.Text = res_man.GetString("savefiledialog1Title", cul) + " 16MB logo.bin...";

                    CheckDeviceAndFolder("MotoE", @"16MB\MotoE\");
                    CheckDeviceAndFolder("MotoEdge", @"16MB\MotoEdge\");
                    CheckDeviceAndFolder("MotoG", @"16MB\MotoG\");
                    CheckDeviceAndFolder("MotoOne", @"16MB\MotoOne\");
                    CheckDeviceAndFolder("MotoZ", @"16MB\MotoZ\");
                    CheckDeviceAndFolder("MotoP", @"16MB\MotoP\");
                }

                if (Properties.Profiles.Default.LogoMemory32MB == true)
                {
                    this.Text = res_man.GetString("savefiledialog1Title", cul) + " 32MB logo.bin...";
                    label1.Text = res_man.GetString("savefiledialog1Title", cul) + " 32MB logo.bin...";

                    CheckDeviceAndFolder("MotoEdge", @"32MB\MotoEdge\");
                    CheckDeviceAndFolder("MotoG", @"32MB\MotoG\");
                    CheckDeviceAndFolder("MotoOne", @"32MB\MotoOne\");
                    CheckDeviceAndFolder("MotoZ", @"32MB\MotoZ\");
                    CheckDeviceAndFolder("MotoX", @"32MB\MotoX\");
                    CheckDeviceAndFolder("MotoP", @"32MB\MotoP\");
                }
            } 
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                DarkMessageBox.ShowError(ex.Message.ToString(), "Moto_Boot_Logo_Maker");
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
                    mainform.toolStripStatusLabel3.Text = @"\ Current project: " + sN.ToString();
                    Properties.Settings.Default.Save();
                    this.Close();
                    return;
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    DarkMessageBox.ShowWarning(sN + " " + res_man.GetString("LogoBrowserErrorBinFile", cul), "Moto_Boot_Logo_Maker");
                    return;
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                DarkMessageBox.ShowWarning(sN + " " + res_man.GetString("LogoBrowserIsADir", cul), "Moto_Boot_Logo_Maker");
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var sd = new SelectDevice();
            this.Hide();
            sd.Show();
            this.Show();
            this.Close();
        }

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageKey = "FolderClosed";
            e.Node.SelectedImageKey = "FolderClosed";
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageKey = "FolderOpened";
            e.Node.SelectedImageKey = "FolderOpened";
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageKey = "FolderClosed";
            e.Node.SelectedImageKey = "FolderClosed";
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageKey = "FolderOpened";
            e.Node.SelectedImageKey = "FolderOpened";
        }
    }
}
