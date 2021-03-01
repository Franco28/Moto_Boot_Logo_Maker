
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
            RoundP(pictureBoxMotoG);
            RoundP(pictureBoxMotoX);
            RoundP(pictureBoxMotoDroid);
            RoundP(pictureBoxMotoE);
            RoundP(pictureBoxMotoEdge);
            RoundP(pictureBoxMotoOne);
            Round(panel2);
            Round(panel3);
            Round(panelMotoX);
            Round(panel1);
            Round(panelMotoOne);
            Round(panelMotoG);
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

        public void OpenForm()
        {
            var opendialog = new LogoBrowser();
            opendialog.Show();
            this.Close();
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
    }
}
