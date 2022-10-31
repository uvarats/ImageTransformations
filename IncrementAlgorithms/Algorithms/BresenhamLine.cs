using Hazdryx.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementAlgorithms.Algorithms
{
    internal class BresenhamLine : AbstractDrawingAlgorithm
    {
        public BresenhamLine(Bitmap m) : base(m)
        {
        }

        public Bitmap Draw(Point p0, Point p1, Color lineColor)
        {
            int dx = Math.Abs(p1.X - p0.X);
            int dy = Math.Abs(p1.Y - p0.Y);
            int error = 0;
            int deltaError = dy + 1;
            int y = p0.Y;

            int diffY = (p1.Y - p0.Y);
            if (diffY > 0)
            {
                diffY = 1;
            }
            if (diffY < 0)
            {
                diffY = -1;
            }
            int startX = p0.X < p1.X ? p0.X : p1.X;
            int endX = p0.X > p1.X ? p0.X : p1.X;
            for (int x = startX; x < endX; x++)
            {
                _bitmap.Set(x, y, lineColor);
                error += deltaError;
                if (error >= dx + 1)
                {
                    y += diffY;
                    error -= dx + 1;
                }
            }
            return Bitmap;
        }
    }
}
