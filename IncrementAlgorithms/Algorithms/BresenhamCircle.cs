using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementAlgorithms.Algorithms
{
    internal class BresenhamCircle : AbstractDrawingAlgorithm
    {
        public BresenhamCircle(Bitmap m) : base(m)
        {
        }

        // Point p - center of the circle
        public Bitmap Draw(Point p, int radius, Color color)
        {
            int x = 0;
            int y = radius;
            int delta = 1 - 2 * radius;
            int error = 0;

            while (y > x)
            {
                _bitmap.Set(p.X + x, p.Y + y, color);
                _bitmap.Set(p.X + x, p.Y - y, color);
                _bitmap.Set(p.X - x, p.Y + y, color);
                _bitmap.Set(p.X - x, p.Y - y, color);
                _bitmap.Set(p.X + y, p.Y + x, color);
                _bitmap.Set(p.X + y, p.Y - x, color);
                _bitmap.Set(p.X - y, p.Y + x, color);
                _bitmap.Set(p.X - y, p.Y - x, color);

                error = 2 * (delta + y) - 1;
                if ((delta < 0) && (error <= 0))
                {
                    delta += 2 * ++x + 1;
                    continue;
                }
                
                if ((delta > 0) && (error > 0))
                {
                    delta -= 2 * --y + 1;
                }
                delta += 2 * (++x - --y);
            }
            return Bitmap;
        }
    }
}
