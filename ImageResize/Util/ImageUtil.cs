using ImageResize.Extension;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Util
{
    internal class ImageUtil
    {
        public static List<Color> ImageToPixels(Bitmap img)
        {
            List<Color> pixels = new List<Color>();
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    pixels.Add(img.GetPixel(i, j));
                }
            }
            return pixels;
        }
        public static byte[]? ImageToBytes(Bitmap img)
        {
            ImageConverter converter = new ImageConverter();
            byte[]? bytes = (byte[]?)converter.ConvertTo(img, typeof(byte[]));
            return bytes.SubArray(54, bytes.Length - 54);
        }

        public static Image? BytesToImage(byte[] bytes)
        {
            Image? result = null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                result = Image.FromStream(ms);
            }
            return result;
        }

        public static void ParseFilter(OpenFileDialog imgOpenDialog)
        {
            if (imgOpenDialog == null)
            {
                throw new NullReferenceException();
            }
            var encoders = ImageCodecInfo.GetImageEncoders();
            string separator = String.Empty;
            foreach (ImageCodecInfo info in encoders)
            {
                string name = info.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                imgOpenDialog.Filter = string.Format(
                    "{0}{1}{2} ({3})|{3}",
                    imgOpenDialog.Filter,
                    separator, name,
                    info.FilenameExtension);
                separator = "|";
            }
            imgOpenDialog.Filter = string.Format(
                    "{0}{1}{2} ({3})|{3}",
                    imgOpenDialog.Filter,
                    separator, "All Files",
                    "*.*");
        }
    }
}
