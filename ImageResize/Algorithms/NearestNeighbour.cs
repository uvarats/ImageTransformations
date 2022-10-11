using Hazdryx.Drawing;
using ImageResize.Interface;

namespace ImageResize.Algorithms
{
    internal class NearestNeighbour : ScalingAlgorithm
    {
        public Image Scale(Bitmap self, float scaleX, float scaleY)
        {
            int newWidth = (int)(self.Width * scaleX);
            int newHeight = (int)(self.Height * scaleY);
            if (newWidth == 0 || newHeight == 0)
            {
                return self;
            }
            Bitmap newImage = new Bitmap(newWidth, newHeight, self.PixelFormat);
            FastBitmap fbSelf = new FastBitmap(self);
            FastBitmap fbNew = new FastBitmap(newImage);
            for (int i = 0; i < newHeight; i++)
            {
                for (int j = 0; j < newWidth; j++)
                {
                    int x = (int)Math.Floor(j / scaleX);
                    int y = (int)Math.Floor(i / scaleY);
                    fbNew.Set(j, i, fbSelf.Get(x, y));
                }
            }

            return fbNew.BaseBitmap;
        }
        public override string ToString()
        {
            return "Ближайшего соседа";
        }
    }
}
