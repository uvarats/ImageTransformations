using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Interface
{
    internal interface ScalingAlgorithm
    {
        public Image Scale(Bitmap self, float scaleX, float scaleY);
    }
}
