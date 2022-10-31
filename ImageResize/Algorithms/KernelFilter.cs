using Hazdryx.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Algorithms
{
    internal class KernelFilter
    {
        public Bitmap Filter(Bitmap bmp, double[,] matrix)
        {
            FastBitmap fbmp = new FastBitmap(bmp);

            double normalizeCoeff = 0;
            foreach (double item in matrix)
            {
                normalizeCoeff += item;
            }
            normalizeCoeff = normalizeCoeff == 0 ? 1 : normalizeCoeff;

            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            int offsetX = (width - 1) / 2;
            int offsetY = (height - 1) / 2;
            for (int x = offsetX; x < bmp.Width - offsetX; x++)
            {
                for (int y = offsetY; y < bmp.Height - offsetY; y++)
                {
                    double r = 0d;
                    double g = 0d;
                    double b = 0d;

                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            Color pixel = fbmp.Get(x + i - 1, y + j - 1);
                            r += matrix[j, i] * pixel.R;
                            g += matrix[j, i] * pixel.G;
                            b += matrix[j, i] * pixel.B;
                        }
                    }
                    fbmp.Set(x - 1, y - 1, GetNormalized(r, g, b, normalizeCoeff)); ;
                }
            }
            return fbmp.BaseBitmap;
        }

        // нормирование
        public Color GetNormalized(double r, double g, double b, double coeff)
        {
            r /= coeff;
            g /= coeff;
            b /= coeff;
            int r1 = (int)(r < 0 ? 0 : r > 255 ? 255 : Math.Round(r));
            int g1 = (int)(g < 0 ? 0 : g > 255 ? 255 : Math.Round(g));
            int b1 = (int)(b < 0 ? 0 : b > 255 ? 255 : Math.Round(b));

            return Color.FromArgb(r1, g1, b1);
        }
    }
}
