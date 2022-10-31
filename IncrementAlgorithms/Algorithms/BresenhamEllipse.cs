using Hazdryx.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementAlgorithms.Algorithms
{
    internal class BresenhamEllipse
    {
        public Bitmap Draw(Bitmap bmp, int xc, int yc, int rx, int ry, Color color)
        {
            FastBitmap bp = new FastBitmap(bmp);
            double pp = (ry * ry) - (rx * rx * ry) + (.25 * (rx * rx));
            int p1 = (int)pp;
            int x = 0, y = ry;
            while ((2 * rx * rx * y) > (2 * ry * ry * x))
            {
                bp.Set(xc + x, yc + y, color);
                bp.Set(xc - x, yc + y, color);
                bp.Set(xc - x, yc - y, color);
                bp.Set(xc + x, yc - y, color);

                x++;

                if (p1 < 0)
                    p1 += (2 * ry * ry * x) + (ry * ry);
                else
                {
                    y--;
                    p1 += (2 * ry * ry * x) - (2 * rx * rx * y) + (ry * ry);
                }
            }

            // regoin 2
            pp = ((ry * ry) * (x + 0.5) * (x + 0.5)) + ((rx * rx) * (y - 1) * (y - 1)) - (rx * rx * ry * ry);
            int p2 = (int)pp;
            while (y >= 0)
            {


                y--;
                if (p2 > 0)
                    p2 -= (2 * rx * rx * y) + (rx * rx);
                else
                {
                    x++;
                    p2 += (2 * ry * ry * x) - (2 * rx * rx * y) + (rx * rx);
                }
                bp.Set(xc + x, yc + y, color);
                bp.Set(xc - x, yc + y, color);
                bp.Set(xc - x, yc - y, color);
                bp.Set(xc + x, yc - y, color);
            }
            return bp.BaseBitmap;
        }
    }
}
