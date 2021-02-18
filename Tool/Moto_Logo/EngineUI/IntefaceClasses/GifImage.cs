/* 
#####################################################################
#    File: GifImage.cs                                              #
#    Author: Franco28                                               # 
#    Date: 22-12-2020                                               #
#    Note: If you are someone that extracted the assemblie,         #
#          please if you want something ask me,                     #
#          don´t try to corrupt or break Tool!                      #
#    Personal Contact:                                              #
#    Telegram: https://t.me/francom28/                              #
#####################################################################
 */

using System.Drawing.Imaging;
using System.Drawing;

namespace Moto_Logo
{
    public class GifImage
    {
        private Image gifImage;
        private FrameDimension dimension;
        private int frameCount;
        private int currentFrame = -1;
        private bool reverse;
        private int step = 1;

        public GifImage(string path)
        {
            gifImage = Image.FromFile(path);
            dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
            frameCount = gifImage.GetFrameCount(dimension);
        }

        public bool ReverseAtEnd
        {
            get { return reverse; }
            set { reverse = value; }
        }

        public Image GetNextFrame()
        {
            currentFrame += step;

            if (currentFrame >= frameCount || currentFrame < 0)
            {
                if (reverse)
                {
                    step *= -1;
                    currentFrame += step;
                }
                else
                {
                    currentFrame = 0;
                }
            }
            return GetFrame(currentFrame);
        }

        public Image GetFrame(int index)
        {
            gifImage.SelectActiveFrame(dimension, index);
            return (Image)gifImage.Clone();
        }
    }
}