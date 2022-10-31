using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Util
{
    public class AfterInfo
    {
        private Image _img;
        private double _fileSize;

        public Image Image
        {
            get
            {
                return _img;
            }
        }
        public string Resolution
        {
            get
            {
                return string.Format("{0}x{1}", _img.Width, _img.Height);
            }
        }

        public double FileSize
        {
            get
            {
                return _fileSize;
            }
            private set
            {
                _fileSize = value;
            }
        }
        public TimeSpan Elapsed { get; private set; }
        private AfterInfo(Image img)
        {
            _img = img;
        }
        
        public static AfterInfo GetInfo(Image img, TimeSpan elapsed)
        {
            AfterInfo info = new AfterInfo(img);
            info.Elapsed = elapsed;
            string tempfile = "temp.bmp";
            img.Save(tempfile);
            long length = new FileInfo(tempfile).Length;
            File.Delete(tempfile);
            info.FileSize = Math.Round(length / 1024.0, 2);
            return info;
        }
    }
}
