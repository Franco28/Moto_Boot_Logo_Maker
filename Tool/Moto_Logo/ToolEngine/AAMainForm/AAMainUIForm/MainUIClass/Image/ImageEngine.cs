/* 
#####################################################################
#    File: MainForm.ImageEngine.cs                                  #
#    Author: Franco28                                               # 
#    Date: 27-05-2021                                               #
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
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Moto_Logo
{
    public partial class MainForm
    {

        private int _ZoomFactor;
        private Color _BackColor;
        private Image _OriginalImage;

        public void ImageStatusBoxMSG(string message)
        {
            this.Invoke((Action)delegate
            {
                ImageStatusBox.AppendText("\n" + message);
                ImageStatusBox.ScrollToCaret();
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseMove -= pictureBox1_MouseMove;
            labelIconLUImage.Image = Resources.lock_x20;
            ImageStatusBox.Clear();
            ImageStatusBoxMSG(res_man.GetString("MainForm_label_ImageStatusLocked", cul));
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            labelIconLUImage.Image = Resources.unlock_x20;
            ImageStatusBox.Clear();
            ImageStatusBoxMSG(res_man.GetString("MainForm_label_ImageStatusUnlocked", cul));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                {
                    labelIconLUImage.Image = null;
                    ImageStatusBox.Clear();
                    ImageStatusBoxMSG(res_man.GetString("MainForm_ImageStatus_TextLocked", cul));
                    ImageStatusBoxMSG(res_man.GetString("MainForm_ImageStatus_TextUnlocked", cul));
                    return;
                }
                else
                {
                    UpdateZoomedImage(e);
                }
            }
            catch (Exception ex)
            {
                Logs.DebugErrorLogs(ex);
                MessageBox.Show(ex.ToString(), @"Moto_Boot_Logo_Maker: " + Logs.GetClassName(ex) + " " + Logs.GetLineNumber(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void trbZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            _ZoomFactor = trbZoomFactor.Value;
            lblZoomFactor.Text = string.Format("x{0}", _ZoomFactor);
        }

        private void UpdateZoomedImage(MouseEventArgs e)
        {
            int zoomWidth = picZoom.Width / _ZoomFactor;
            int zoomHeight = picZoom.Height / _ZoomFactor;
            int halfWidth = zoomWidth / 2;
            int halfHeight = zoomHeight / 2;
            Bitmap tempBitmap = new Bitmap(zoomWidth, zoomHeight, PixelFormat.Format24bppRgb);
            Graphics bmGraphics = Graphics.FromImage(tempBitmap);
            bmGraphics.Clear(_BackColor);
            bmGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            bmGraphics.DrawImage(pictureBox1.Image,
                                 new Rectangle(0, 0, zoomWidth, zoomHeight),
                                 new Rectangle(e.X - halfWidth, e.Y - halfHeight, zoomWidth, zoomHeight),
                                 GraphicsUnit.Pixel);
            picZoom.Image = tempBitmap;
            Bitmap b = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(b, pictureBox1.ClientRectangle);
            Color colour = b.GetPixel(e.X, e.Y);
            labelColorDraw.Text = "RGB: " + colour.R.ToString() + ", " + colour.G.ToString() + ", " + colour.B.ToString();
            pictureBoxColors.BackColor = colour;
            Pen getcolour = new Pen(Color.FromArgb(colour.ToArgb() ^ 0xFFFFFFF), 1);
            bmGraphics.DrawLine(getcolour, halfWidth + 1, halfHeight - 4, halfWidth + 1, halfHeight - 1);
            bmGraphics.DrawLine(getcolour, halfWidth + 1, halfHeight + 6, halfWidth + 1, halfHeight + 3);
            bmGraphics.DrawLine(getcolour, halfWidth - 4, halfHeight + 1, halfWidth - 1, halfHeight + 1);
            bmGraphics.DrawLine(getcolour, halfWidth + 6, halfHeight + 1, halfWidth + 3, halfHeight + 1);
            b.Dispose();
            bmGraphics.Dispose();
            picZoom.Refresh();
        }

        private void ResizeAndDisplayImage()
        {
            pictureBox1.BackColor = _BackColor;
            picZoom.BackColor = _BackColor;

            if (_OriginalImage == null)
            {
                return;
            }
            else
            {
                pictureBox1.Image = _OriginalImage;

                int sourceWidth = _OriginalImage.Width;
                int sourceHeight = _OriginalImage.Height;
                int targetWidth;
                int targetHeight;
                double ratio;
                if (sourceWidth > sourceHeight)
                {
                    targetWidth = pictureBox1.Width;
                    ratio = (double)targetWidth / sourceWidth;
                    targetHeight = (int)(ratio * sourceHeight);
                }
                else if (sourceWidth < sourceHeight)
                {
                    targetHeight = pictureBox1.Height;
                    ratio = (double)targetHeight / sourceHeight;
                    targetWidth = (int)(ratio * sourceWidth);
                }
                else
                {
                    targetHeight = pictureBox1.Height;
                    targetWidth = pictureBox1.Width;
                }

                int targetTop = (pictureBox1.Height - targetHeight) / 2;
                int targetLeft = (pictureBox1.Width - targetWidth) / 2;
                Bitmap tempBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format24bppRgb);
                tempBitmap.SetResolution(_OriginalImage.HorizontalResolution, _OriginalImage.VerticalResolution);
                Graphics bmGraphics = Graphics.FromImage(tempBitmap);
                bmGraphics.Clear(_BackColor);
                bmGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                bmGraphics.DrawImage(_OriginalImage,
                                     new Rectangle(targetLeft, targetTop, targetWidth, targetHeight),
                                     new Rectangle(0, 0, sourceWidth, sourceHeight),
                                     GraphicsUnit.Pixel);
                bmGraphics.Dispose();
                pictureBox1.Image = tempBitmap;
            }
        }

        enum ImageOption
        {
            ImageOptionCenter,
            ImageOptionStretchProportionately,
            ImageOptionFill
        };

        enum ImageLayout
        {
            ImageLayoutPortrait,
            ImageLayoutLandscape
        };

        private Image FixedSizePreview(Image imgPhoto)
        {
            return FixedSize(!rdoAndroid44.Checked ? FixedSize(imgPhoto, 540, 540) : imgPhoto,
                (int)udResolutionX.Value, (int)udResolutionY.Value,
                !rdoAndroid44.Checked);
        }

        private Bitmap FixedSizeSave(Image imgPhoto)
        {
            var xmax = rdoAndroid44.Checked ? (int)udResolutionX.Value : 540;
            var ymax = rdoAndroid44.Checked ? (int)udResolutionY.Value : 540;
            return (rdoImageCenter.Checked && (imgPhoto.Width <= xmax)
                    && (imgPhoto.Height <= ymax) && rdoAndroid44.Checked)
                        ? (Bitmap)imgPhoto
                        : FixedSize(imgPhoto, xmax, ymax);
        }      

        private Bitmap FixedSize(Image imgPhoto, int imgWidth, int imgHeight, bool forceCenter = false)
        {
            // Logo_image
            var landscape = (Image)imgPhoto.Clone();
            landscape.RotateFlip(RotateFlipType.Rotate90FlipNone);
            var img = (rdoLayoutLandscape.Checked ? landscape : imgPhoto);

            var sourceWidth = img.Width;
            var sourceHeight = img.Height;
            const int sourceX = 0;
            const int sourceY = 0;
            var destX = 0;
            var destY = 0;

            float nPercent = 0;

            var nPercentW = ((float)imgWidth / (float)sourceWidth);
            var nPercentH = ((float)imgHeight / (float)sourceHeight);

            if (((sourceWidth <= imgWidth) && (sourceHeight <= imgHeight)) && (rdoImageCenter.Checked || forceCenter))
            {
                nPercent = 1.0f;
                destX = (imgWidth - sourceWidth) / 2;
                destY = (imgHeight - sourceHeight) / 2;
            }
            else if ((nPercentH < nPercentW) && (!rdoImageFill.Checked || forceCenter))
            {
                nPercent = nPercentH;
                destX = Convert.ToInt16((imgWidth -
                              (sourceWidth * nPercent)) / 2);
            }
            else if (!rdoImageFill.Checked || forceCenter)
            {
                nPercent = nPercentW;
                destY = Convert.ToInt16((imgHeight -
                              (sourceHeight * nPercent)) / 2);
            }

            var destWidth = (int)(sourceWidth * ((rdoImageFill.Checked && !forceCenter) ? nPercentW : nPercent));
            var destHeight = (int)(sourceHeight * ((rdoImageFill.Checked && !forceCenter) ? nPercentH : nPercent));

            var bmPhoto = new Bitmap(imgWidth, imgHeight,
                PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(img.HorizontalResolution,
                             img.VerticalResolution);

            var grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(((Bitmap)img).GetPixel(0, 0));
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;
        
            grPhoto.DrawImage(img,
                    new Rectangle(destX, destY, destWidth, destHeight),
                    new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                    GraphicsUnit.Pixel);
                    grPhoto.Dispose();

            return bmPhoto;
        }
    }
}