using Hazdryx.Drawing;
using ImageResize.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Algorithms
{
    internal class KTimes : ScalingAlgorithm
    {
        private float Lerp(float s, float e, float t)
        {
            float result = s + (e - s) * t;
            return result;
        }
        public Image Scale(Bitmap self, float scaleX, float scaleY)
        {
            int newWidth = (int)(self.Width * scaleX);
            int newHeight = (int)(self.Height * scaleY);
            Bitmap result = new Bitmap(newWidth, self.Height, self.PixelFormat);
            FastBitmap fastNew = new FastBitmap(result);
            FastBitmap fastOld = new FastBitmap(self);

            for(int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < self.Height; y++)
                {
                    float gx = (float)x / newWidth * (self.Width - 1);
                    int gxi = (int)gx;

                    Color x0 = fastOld.Get(gxi, y);
                    Color x1 = fastOld.Get(gxi + 1, y);

                    int red = (int)Lerp(x0.R, x1.R, gx - gxi);
                    int green = (int)Lerp(x0.G, x1.G, gx - gxi);
                    int blue = (int)Lerp(x0.B, x1.B, gx - gxi);
                    Color newP = Color.FromArgb(red, green, blue);
                    fastNew.Set(x, y, newP);
                }
            }
            fastOld = fastNew;
            Bitmap xyScaled = new Bitmap(newWidth, newHeight, fastNew.BaseBitmap.PixelFormat);
            FastBitmap fastResult = new FastBitmap(xyScaled);
            

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    float gy = (float)y / newHeight * (self.Height - 1);
                    int gyi = (int)gy;

                    Color y0 = fastOld.Get(x, gyi);
                    Color y1 = fastOld.Get(x, gyi + 1);

                    int red = (int)Lerp(y0.R, y1.R, gy - gyi);
                    int green = (int)Lerp(y0.G, y1.G, gy - gyi);
                    int blue = (int)Lerp(y0.B, y1.B, gy - gyi);
                    Color newP = Color.FromArgb(red, green, blue);
                    fastResult.Set(x, y, newP);
                }
            }

            return fastResult.BaseBitmap;
        }
        public override string ToString()
        {
            return "Увеличение в K раз";
        }
    }
}
