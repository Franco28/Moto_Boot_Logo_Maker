
using Moto_Logo.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class SelectDevice : Form
    {

        public SelectDevice()
        {
            InitializeComponent();
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

        public void RoundP(PictureBox picturebox)
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

        public void RoundF(Form picturebox)
        {
            using (var gp = new GraphicsPath())
            {
                picturebox.BackColor = Color.FromArgb(38, 38, 38);
                Rectangle r = new Rectangle(0, 0, picturebox.Width, picturebox.Height);
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                picturebox.Region = new Region(gp);
            }
        }

        public void Opa(PictureBox pict, Bitmap img)
        {
            Bitmap pic = new Bitmap(img);
            for (int w = 0; w < pic.Width; w++)
            {
                for (int h = 0; h < pic.Height; h++)
                {
                    Color c = pic.GetPixel(w, h);
                    Color newC = Color.FromArgb(30, c);
                    pic.SetPixel(w, h, newC);
                }
            }            
            pict.Image = pic;
        }

        public void RemoveOpa(PictureBox pict, Bitmap img)
        {
            Bitmap pic = new Bitmap(img);
            pict.Image = pic;
        }

        private void SelectDevice_Load(object sender, EventArgs e)
        {
            RoundF(this);
            RoundP(pictureBoxMotoG);
            RoundP(pictureBoxMotoX);
            RoundP(pictureBoxMotoDroid);
            RoundP(pictureBoxMotoE);
            RoundP(pictureBoxMotoEdge);
            RoundP(pictureBoxMotoOne);
            RoundP(pictureBoxMotoZ);
            RoundP(pictureBoxMotoP);
            Round(panelMotoDroid);
            Round(panelMotoE);
            Round(panelMotoX);
            Round(panelMotoEdge);
            Round(panelMotoOne);
            Round(panelMotoG);
            Round(panelMotoZ);
            Round(panelMotoP);

            pictureBoxMotoG.Enabled = false;
            pictureBoxMotoX.Enabled = false;
            pictureBoxMotoDroid.Enabled = false;
            pictureBoxMotoE.Enabled = false;
            pictureBoxMotoEdge.Enabled = false;
            pictureBoxMotoOne.Enabled = false;
            pictureBoxMotoZ.Enabled = false;
            pictureBoxMotoP.Enabled = false;

            pictureBoxMotoG.Cursor = Cursors.No;
            pictureBoxMotoX.Cursor = Cursors.No;
            pictureBoxMotoDroid.Cursor = Cursors.No;
            pictureBoxMotoE.Cursor = Cursors.No;
            pictureBoxMotoEdge.Cursor = Cursors.No;
            pictureBoxMotoOne.Cursor = Cursors.No;
            pictureBoxMotoZ.Cursor = Cursors.No;
            pictureBoxMotoP.Cursor = Cursors.No;

            panelMotoDroid.Cursor = Cursors.No;
            panelMotoE.Cursor = Cursors.No;
            panelMotoX.Cursor = Cursors.No;
            panelMotoEdge.Cursor = Cursors.No;
            panelMotoOne.Cursor = Cursors.No;
            panelMotoG.Cursor = Cursors.No;
            panelMotoZ.Cursor = Cursors.No;
            panelMotoP.Cursor = Cursors.No;

            var mainform = Form.ActiveForm as MainForm;

            if (mainform.radioButton4mib.Checked == true)
            {
                labelLogoMemory.Text = @"Logo Memory: 4MB";
                
                pictureBoxMotoDroid.Enabled = true;
                pictureBoxMotoDroid.Cursor = Cursors.Hand;
                panelMotoDroid.Cursor = Cursors.Hand;

                pictureBoxMotoE.Enabled = true;
                pictureBoxMotoE.Cursor = Cursors.Hand;
                panelMotoE.Cursor = Cursors.Hand;

                pictureBoxMotoG.Enabled = true;
                pictureBoxMotoG.Cursor = Cursors.Hand;
                panelMotoG.Cursor = Cursors.Hand;

                pictureBoxMotoX.Enabled = true;
                pictureBoxMotoX.Cursor = Cursors.Hand;
                panelMotoX.Cursor = Cursors.Hand; 
            }

            if (mainform.radioButton6MIB.Checked == true)
            {
                labelLogoMemory.Text = @"Logo Memory: 6MB";

                pictureBoxMotoDroid.Enabled = true;
                pictureBoxMotoDroid.Cursor = Cursors.Hand;
                panelMotoDroid.Cursor = Cursors.Hand;

                pictureBoxMotoX.Enabled = true;
                pictureBoxMotoX.Cursor = Cursors.Hand;
                panelMotoX.Cursor = Cursors.Hand;
            }

            if (mainform.radioButton8MIB.Checked == true)
            {
                labelLogoMemory.Text = @"Logo Memory: 8MB";

                pictureBoxMotoDroid.Enabled = true;
                pictureBoxMotoDroid.Cursor = Cursors.Hand;
                panelMotoDroid.Cursor = Cursors.Hand;

                pictureBoxMotoX.Enabled = true;
                pictureBoxMotoX.Cursor = Cursors.Hand;
                panelMotoX.Cursor = Cursors.Hand;
            }

            if (mainform.radioButton16MIB.Checked == true)
            {
                labelLogoMemory.Text = @"Logo Memory: 16MB";

                pictureBoxMotoE.Enabled = true;
                pictureBoxMotoE.Cursor = Cursors.Hand;
                panelMotoE.Cursor = Cursors.Hand;

                pictureBoxMotoEdge.Enabled = true;
                pictureBoxMotoEdge.Cursor = Cursors.Hand;
                panelMotoEdge.Cursor = Cursors.Hand;

                pictureBoxMotoG.Enabled = true;
                pictureBoxMotoG.Cursor = Cursors.Hand;
                panelMotoG.Cursor = Cursors.Hand;

                pictureBoxMotoOne.Enabled = true;
                pictureBoxMotoOne.Cursor = Cursors.Hand;
                panelMotoOne.Cursor = Cursors.Hand;

                pictureBoxMotoP.Enabled = true;
                pictureBoxMotoP.Cursor = Cursors.Hand;
                panelMotoP.Cursor = Cursors.Hand;

                pictureBoxMotoZ.Enabled = true;
                pictureBoxMotoZ.Cursor = Cursors.Hand;
                panelMotoZ.Cursor = Cursors.Hand;
            }

            if (mainform.radioButton32MIB.Checked == true)
            {
                labelLogoMemory.Text = "Logo Memory: 32MB";

                pictureBoxMotoG.Enabled = true;
                pictureBoxMotoG.Cursor = Cursors.Hand;
                panelMotoG.Cursor = Cursors.Hand;

                pictureBoxMotoOne.Enabled = true;
                pictureBoxMotoOne.Cursor = Cursors.Hand;
                panelMotoOne.Cursor = Cursors.Hand;

                pictureBoxMotoP.Enabled = true;
                pictureBoxMotoP.Cursor = Cursors.Hand;
                panelMotoP.Cursor = Cursors.Hand;

                pictureBoxMotoX.Enabled = true;
                pictureBoxMotoX.Cursor = Cursors.Hand;
                panelMotoX.Cursor = Cursors.Hand;

                pictureBoxMotoZ.Enabled = true;
                pictureBoxMotoZ.Cursor = Cursors.Hand;
                panelMotoZ.Cursor = Cursors.Hand;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMotoDroid_MouseHover(object sender, EventArgs e)
        {
            Opa(pictureBoxMotoDroid, Resources.MotoDroid);
        }

        private void pictureBoxMotoDroid_MouseLeave(object sender, EventArgs e)
        {
            RemoveOpa(pictureBoxMotoDroid, Resources.MotoDroid);
        }

        private void pictureBoxMotoG_MouseHover(object sender, EventArgs e)
        {
            Opa(pictureBoxMotoG, Resources.MotoG);
        }

        private void pictureBoxMotoG_MouseLeave(object sender, EventArgs e)
        {
            RemoveOpa(pictureBoxMotoG, Resources.MotoG);
        }

        private void pictureBoxMotoE_MouseHover(object sender, EventArgs e)
        {
            Opa(pictureBoxMotoE, Resources.MotoE);
        }

        private void pictureBoxMotoE_MouseLeave(object sender, EventArgs e)
        {
            RemoveOpa(pictureBoxMotoE, Resources.MotoE);
        }

        private void pictureBoxMotoX_MouseHover(object sender, EventArgs e)
        {
            Opa(pictureBoxMotoX, Resources.MotoX);
        }

        private void pictureBoxMotoX_MouseLeave(object sender, EventArgs e)
        {
            RemoveOpa(pictureBoxMotoX, Resources.MotoX);
        }

        private void pictureBoxMotoEdge_MouseHover(object sender, EventArgs e)
        {
            Opa(pictureBoxMotoEdge, Resources.MotoEdge);
        }

        private void pictureBoxMotoEdge_MouseLeave(object sender, EventArgs e)
        {
            RemoveOpa(pictureBoxMotoEdge, Resources.MotoEdge);
        }

        private void pictureBoxMotoOne_MouseHover(object sender, EventArgs e)
        {
            Opa(pictureBoxMotoOne, Resources.MotoOne);
        }

        private void pictureBoxMotoOne_MouseLeave(object sender, EventArgs e)
        {
            RemoveOpa(pictureBoxMotoOne, Resources.MotoOne);
        }

        private void pictureBoxMotoZ_MouseHover(object sender, EventArgs e)
        {
            Opa(pictureBoxMotoZ, Resources.MotoZ);
        }

        private void pictureBoxMotoZ_MouseLeave(object sender, EventArgs e)
        {
            RemoveOpa(pictureBoxMotoZ, Resources.MotoZ);
        }

        private void pictureBoxMotoP_MouseHover(object sender, EventArgs e)
        {
            Opa(pictureBoxMotoP, Resources.MotoP);
        }

        private void pictureBoxMotoP_MouseLeave(object sender, EventArgs e)
        {
            RemoveOpa(pictureBoxMotoP, Resources.MotoP);
        }

        public void OpenForm()
        {
            Form fc = Application.OpenForms["LogoBrowser"];
            if (fc != null)
            {
                MessageBox.Show("Already opened: " + fc.Text + ", close it to open a new one!", "Logo " + fc.Text + " already opened", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fc.BringToFront();
            } 
            else
            {
                var opendialog = new LogoBrowser();
                opendialog.Show();
                this.Close();
            }
        }

        private void pictureBoxMotoDroid_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceSelected = "MotoDroid";
            Properties.Settings.Default.Save();
            OpenForm();
        }

        private void pictureBoxMotoG_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceSelected = "MotoG";
            Properties.Settings.Default.Save(); 
            OpenForm();
        }

        private void pictureBoxMotoE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceSelected = "MotoE";
            Properties.Settings.Default.Save();
            OpenForm();
        }

        private void pictureBoxMotoX_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceSelected = "MotoX";
            Properties.Settings.Default.Save();
            OpenForm();
        }

        private void pictureBoxMotoEdge_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceSelected = "MotoEdge";
            Properties.Settings.Default.Save();
            OpenForm();
        }

        private void pictureBoxMotoOne_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceSelected = "MotoOne";
            Properties.Settings.Default.Save();
            OpenForm();
        }

        private void pictureBoxMotoZ_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceSelected = "MotoZ";
            Properties.Settings.Default.Save();
            OpenForm();
        }

        private void pictureBoxMotoP_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeviceSelected = "MotoP";
            Properties.Settings.Default.Save();
            OpenForm();
        }
    }
}
