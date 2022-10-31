using Hazdryx.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Algorithms
{
    static internal class MedianFilterClass
    {
        
        public static Bitmap NewMedianFilter(this Bitmap bmp, int matrixSize)
        {
            FastBitmap fast = new FastBitmap(bmp);

            int matrixOffset = (matrixSize - 1) / 2;

            for (int y = matrixOffset; y < bmp.Height - matrixOffset; y++)
            {
                for (int x = matrixOffset; x < bmp.Width - matrixOffset; x++)
                {
                    List<int> pixels = new List<int>();
                    
                    for (int i = -matrixOffset; i <= matrixOffset; i++)
                    {
                        for (int j = -matrixOffset; j <= matrixOffset; j++)
                        {
                            Color p = fast.Get(x + i, y + j);
                            pixels.Add(p.ToArgb());
                        }
                    }

                    pixels.Sort();
                    int middle = pixels[pixels.Count / 2];
                    fast.Set(x, y, Color.FromArgb(middle));
                }
            }
            return fast.BaseBitmap;
        }
    }

}
