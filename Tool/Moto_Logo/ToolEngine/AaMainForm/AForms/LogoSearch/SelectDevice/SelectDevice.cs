/* 
#####################################################################
#    File: SelectDevice.cs                                          #
#    Author: Franco28                                               # 
#    Date: 22-05-2021                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using Moto_Logo.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using DarkUI.Forms;
using System.Media;

namespace Moto_Logo
{
    public partial class SelectDevice : DarkForm
    {
        public CultureInfo cul;
        public ResourceManager res_man;

        public SelectDevice()
        {
            InitializeComponent();
            res_man = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));           
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

        public void RoundP(PictureBox picturebox)
        {
            using (var gp = new GraphicsPath())
            {
                Rectangle r = new Rectangle(0, 0, picturebox.Width, picturebox.Height);
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                picturebox.Region = new Region(gp);
            }
        }

        public void RoundF(Form form)
        {
            using (var gp = new GraphicsPath())
            {
                Rectangle r = new Rectangle(0, 0, form.Width, form.Height);
                int d = 50;
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                form.Region = new Region(gp);
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

            panelMotoDroid.Hide();
            panelMotoE.Hide();
            panelMotoX.Hide();
            panelMotoEdge.Hide();
            panelMotoOne.Hide();
            panelMotoG.Hide();
            panelMotoZ.Hide();
            panelMotoP.Hide();

            pictureBoxMotoG.Hide();
            pictureBoxMotoX.Hide();
            pictureBoxMotoDroid.Hide();
            pictureBoxMotoE.Hide();
            pictureBoxMotoEdge.Hide();
            pictureBoxMotoOne.Hide();
            pictureBoxMotoZ.Hide();
            pictureBoxMotoP.Hide();

            labelMotoDroi.Hide();
            labelMotoG.Hide();
            labelMotoE.Hide();
            labelMotoZ.Hide();
            labelMotoX.Hide();
            labelMotoEdge.Hide();
            labelMotoOne.Hide();
            labelMotoP.Hide();

            pictureBoxMotoDroid.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMotoG.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMotoEdge.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMotoX.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMotoOne.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMotoP.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMotoZ.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMotoE.SizeMode = PictureBoxSizeMode.Zoom;

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
                this.CenterToScreen();
                labelLogoMemory.Text = @"Logo Memory: 4MB";
                this.Text = @"Select your device - Logo Memory: 4MB";

                panelMotoDroid.Show();
                labelMotoDroi.Show();
                pictureBoxMotoDroid.Show();
                pictureBoxMotoDroid.Enabled = true;
                pictureBoxMotoDroid.Cursor = Cursors.Hand;
                panelMotoDroid.Cursor = Cursors.Hand;

                panelMotoE.Show();
                labelMotoE.Show();
                pictureBoxMotoE.Show();
                pictureBoxMotoE.Enabled = true;
                pictureBoxMotoE.Cursor = Cursors.Hand;
                panelMotoE.Cursor = Cursors.Hand;

                panelMotoG.Show();
                labelMotoG.Show();
                pictureBoxMotoG.Show();
                pictureBoxMotoG.Enabled = true;
                pictureBoxMotoG.Cursor = Cursors.Hand;
                panelMotoG.Cursor = Cursors.Hand;

                panelMotoX.Show();
                labelMotoX.Show();
                pictureBoxMotoX.Show();
                pictureBoxMotoX.Enabled = true;
                pictureBoxMotoX.Cursor = Cursors.Hand;
                panelMotoX.Cursor = Cursors.Hand; 
            }

            if (mainform.radioButton6MIB.Checked == true)
            {
                this.CenterToScreen();
                labelLogoMemory.Text = @"Logo Memory: 6MB";
                this.Text = @"Select your device - Logo Memory: 6MB";

                panelMotoDroid.Show();
                labelMotoDroi.Show();
                pictureBoxMotoDroid.Show();
                pictureBoxMotoDroid.Enabled = true;
                pictureBoxMotoDroid.Cursor = Cursors.Hand;
                panelMotoDroid.Cursor = Cursors.Hand;

                panelMotoX.Show();
                labelMotoX.Show();
                pictureBoxMotoX.Show();
                pictureBoxMotoX.Enabled = true;
                pictureBoxMotoX.Cursor = Cursors.Hand;
                panelMotoX.Cursor = Cursors.Hand;
            }

            if (mainform.radioButton8MIB.Checked == true)
            {
                this.CenterToScreen();
                labelLogoMemory.Text = @"Logo Memory: 8MB";
                this.Text = @"Select your device - Logo Memory: 8MB";

                panelMotoDroid.Show();
                labelMotoDroi.Show();
                pictureBoxMotoDroid.Show();
                pictureBoxMotoDroid.Enabled = true;
                pictureBoxMotoDroid.Cursor = Cursors.Hand;
                panelMotoDroid.Cursor = Cursors.Hand;

                panelMotoX.Show();
                labelMotoX.Show();
                pictureBoxMotoX.Show();
                pictureBoxMotoX.Enabled = true;
                pictureBoxMotoX.Cursor = Cursors.Hand;
                panelMotoX.Cursor = Cursors.Hand;
            }

            if (mainform.radioButton16MIB.Checked == true)
            {
                this.CenterToScreen();
                labelLogoMemory.Text = @"Logo Memory: 16MB";
                this.Text = @"Select your device - Logo Memory: 16MB";

                panelMotoE.Show();
                labelMotoE.Show();
                pictureBoxMotoE.Show();
                pictureBoxMotoE.Enabled = true;
                pictureBoxMotoE.Cursor = Cursors.Hand;
                panelMotoE.Cursor = Cursors.Hand;

                panelMotoEdge.Show();
                labelMotoEdge.Show();
                pictureBoxMotoEdge.Show();
                pictureBoxMotoEdge.Enabled = true;
                pictureBoxMotoEdge.Cursor = Cursors.Hand;
                panelMotoEdge.Cursor = Cursors.Hand;

                panelMotoG.Show();
                labelMotoG.Show();
                pictureBoxMotoG.Show();
                pictureBoxMotoG.Enabled = true;
                pictureBoxMotoG.Cursor = Cursors.Hand;
                panelMotoG.Cursor = Cursors.Hand;

                panelMotoOne.Show();
                labelMotoOne.Show();
                pictureBoxMotoOne.Show();
                pictureBoxMotoOne.Enabled = true;
                pictureBoxMotoOne.Cursor = Cursors.Hand;
                panelMotoOne.Cursor = Cursors.Hand;

                panelMotoP.Show();
                labelMotoP.Show();
                pictureBoxMotoP.Show();
                pictureBoxMotoP.Enabled = true;
                pictureBoxMotoP.Cursor = Cursors.Hand;
                panelMotoP.Cursor = Cursors.Hand;

                panelMotoZ.Show();
                labelMotoZ.Show();
                pictureBoxMotoZ.Show();
                pictureBoxMotoZ.Enabled = true;
                pictureBoxMotoZ.Cursor = Cursors.Hand;
                panelMotoZ.Cursor = Cursors.Hand;
            }

            if (mainform.radioButton32MIB.Checked == true)
            {
                this.CenterToScreen();
                labelLogoMemory.Text = "Logo Memory: 32MB";
                this.Text = @"Select your device - Logo Memory: 32MB";

                panelMotoG.Show();
                labelMotoG.Show();
                pictureBoxMotoG.Show();
                pictureBoxMotoG.Enabled = true;
                pictureBoxMotoG.Cursor = Cursors.Hand;
                panelMotoG.Cursor = Cursors.Hand;

                panelMotoOne.Show();
                labelMotoOne.Show();
                pictureBoxMotoOne.Show();
                pictureBoxMotoOne.Enabled = true;
                pictureBoxMotoOne.Cursor = Cursors.Hand;
                panelMotoOne.Cursor = Cursors.Hand;

                panelMotoP.Show();
                labelMotoP.Show();
                pictureBoxMotoP.Show();
                pictureBoxMotoP.Enabled = true;
                pictureBoxMotoP.Cursor = Cursors.Hand;
                panelMotoP.Cursor = Cursors.Hand;

                panelMotoX.Show();
                labelMotoX.Show();
                pictureBoxMotoX.Show();
                pictureBoxMotoX.Enabled = true;
                pictureBoxMotoX.Cursor = Cursors.Hand;
                panelMotoX.Cursor = Cursors.Hand;

                panelMotoZ.Show();
                labelMotoZ.Show();
                pictureBoxMotoZ.Show();
                pictureBoxMotoZ.Enabled = true;
                pictureBoxMotoZ.Cursor = Cursors.Hand;
                panelMotoZ.Cursor = Cursors.Hand;
            }
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
                SystemSounds.Exclamation.Play();
                DarkMessageBox.ShowWarning("Already opened: " + fc.Text + ", close it to open a new one!", "Logo " + fc.Text + " already opened");
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
