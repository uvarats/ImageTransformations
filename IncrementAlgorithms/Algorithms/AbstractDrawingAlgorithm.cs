using Hazdryx.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementAlgorithms.Algorithms
{
    abstract public class AbstractDrawingAlgorithm
    {
        protected FastBitmap _bitmap;

        public Bitmap Bitmap
        {
            get
            {
                return _bitmap.BaseBitmap;
            }
            set
            {
                _bitmap = new FastBitmap(value);
            }
        }
        public AbstractDrawingAlgorithm(Bitmap m)
        {
            _bitmap = new FastBitmap(m);
        }
    }
}
