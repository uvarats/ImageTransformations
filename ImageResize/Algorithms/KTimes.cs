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
        public Image Scale(Bitmap self, float scaleX, float scaleY)
        {
            Bitmap yScaled = ScaleY(self, scaleY);
            Bitmap xScaled = ScaleX(yScaled, scaleX);
            return xScaled;
        }

        private Bitmap ScaleX(Bitmap bmp, float scaleX)
        {
            int newWidth = (int)(bmp.Width * scaleX);
            Bitmap resized = new Bitmap(newWidth, bmp.Height, bmp.PixelFormat);

            FastBitmap fastOrig = new FastBitmap(bmp);
            FastBitmap fast = new FastBitmap(resized);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width - 1; x++)
                {
                    Color val1 = fastOrig.Get(x, y);
                    Color val2 = fastOrig.Get(x + 1, y);
                    int diffR = val2.R - val1.R;
                    int diffG = val2.G - val1.G;
                    int diffB = val2.B - val1.B;
                    int scaleC = ((int)((x + 1) * scaleX) - (int)(x * scaleX));

                    scaleC = scaleC == 0 ? 1 : scaleC;
                    float opR = diffR / scaleC;
                    float opG = diffG / scaleC;
                    float opB = diffB / scaleC;
                    float currentR = val1.R;
                    float currentG = val1.G;
                    float currentB = val1.B;

                    for (int i = (int)(x * scaleX); i < (int)((x + 1) * scaleX); i++)
                    {
                        currentR += opR;
                        currentG += opG;
                        currentB += opB;
                        fast.Set(i, y, Color.FromArgb((int)currentR, (int)currentB, (int)currentG));
                    }
                }
            }
            return fast.BaseBitmap;
        }

        private Bitmap ScaleY(Bitmap bmp, float scaleY)
        {
            int newHeight = (int)(bmp.Height * scaleY);
            Bitmap resized = new Bitmap(bmp.Width, newHeight);

            FastBitmap fastOrig = new FastBitmap(bmp);
            FastBitmap fast = new FastBitmap(resized);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height - 1; y++)
                {
                    Color val1 = fastOrig.Get(x, y);
                    Color val2 = fastOrig.Get(x, y + 1);
                    int diffR = val2.R - val1.R;
                    int diffG = val2.G - val1.G;
                    int diffB = val2.B - val1.B;
                    int scaleC = ((int)((y + 1) * scaleY) - (int)(y * scaleY));
                    scaleC = scaleC == 0 ? 1 : scaleC;
                    float opR = diffR / scaleC;
                    float opG = diffG / scaleC;
                    float opB = diffB / scaleC;
                    float currentR = val1.R;
                    float currentG = val1.G;
                    float currentB = val1.B;

                    for (int i = (int)(y * scaleY); i < (int)((y + 1) * scaleY); i++)
                    {
                        currentR += opR;
                        currentG += opG;
                        currentB += opB;
                        fast.Set(x, i, Color.FromArgb((int)currentR, (int)currentB, (int)currentG));
                    }
                }
            }
            return fast.BaseBitmap;
        }
        public override string ToString()
        {
            return "Увеличение в K раз";
        }
    }
}
