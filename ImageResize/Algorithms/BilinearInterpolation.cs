using Hazdryx.Drawing;
using ImageResize.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Algorithms
{
    internal class BilinearInterpolation : ScalingAlgorithm
    {
        private float Lerp(float s, float e, float t)
        {
            return s + (e - s) * t;
        }
        private float Blerp(float c00, float c10, float c01, float c11, float tx, float ty)
        {
            return Lerp(Lerp(c00, c10, tx), Lerp(c01, c11, tx), ty);
        }
        public Image Scale(Bitmap self, float scaleX, float scaleY)
        {
            int newWidth = (int)(self.Width * scaleX);
            int newHeight = (int)(self.Height * scaleY);
            Bitmap newImage = new Bitmap(newWidth, newHeight, self.PixelFormat);

            FastBitmap fbSelf = new FastBitmap(self);
            FastBitmap fbNew = new FastBitmap(newImage);

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    float gx = (float)x / scaleX;
                    float gy = (float)y / scaleY;
                    int gxi = (int)gx;
                    int gyi = (int)gy;

                    if (gxi == self.Width - 1 && gyi == self.Height - 1)
                    {
                        fbNew.Set(x, y, fbSelf.Get(gxi, gyi));
                        continue;
                    }

                    if (gyi == self.Height - 1)
                    {
                        Color c00_0 = fbSelf.Get(gxi, gyi);
                        Color c10_1 = fbSelf.Get(gxi + 1, gyi);

                        int r1 = (int)Lerp(c00_0.R, c10_1.R, gx - gxi);
                        int g1 = (int)Lerp(c00_0.G, c10_1.G, gx - gxi);
                        int b1 = (int)Lerp(c00_0.B, c10_1.B, gx - gxi);
                        fbNew.Set(x, y, Color.FromArgb(r1, g1, b1));
                        continue;
                    }

                    if (gxi == self.Width - 1)
                    {
                        Color c00_1 = fbSelf.Get(gxi, gyi);
                        Color c01_1 = fbSelf.Get(gxi, gyi + 1);

                        int r2 = (int)Lerp(c00_1.R, c01_1.R, gy - gyi);
                        int g2 = (int)Lerp(c00_1.G, c01_1.G, gy - gyi);
                        int b2 = (int)Lerp(c00_1.B, c01_1.B, gy - gyi);
                        fbNew.Set(x, y, Color.FromArgb(r2, g2, b2));
                        continue;
                    }

                    Color c00 = fbSelf.Get(gxi, gyi);
                    Color c10 = fbSelf.Get(gxi + 1, gyi);
                    Color c01 = fbSelf.Get(gxi, gyi + 1);
                    Color c11 = fbSelf.Get(gxi + 1, gyi + 1);

                    int red = (int)Blerp(c00.R, c10.R, c01.R, c11.R, gx - gxi, gy - gyi);
                    int green = (int)Blerp(c00.G, c10.G, c01.G, c11.G, gx - gxi, gy - gyi);
                    int blue = (int)Blerp(c00.B, c10.B, c01.B, c11.B, gx - gxi, gy - gyi);
                    Color rgb = Color.FromArgb(red, green, blue);
                    fbNew.Set(x, y, rgb);
                }
            }

            return fbNew.BaseBitmap;
        }

        public override string ToString()
        {
            return "Билинейная интерполяция";
        }
    }
}
