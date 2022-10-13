using Hazdryx.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResize.Algorithms
{
    internal class Rotation
    {
        public Image Rotate(Bitmap img, float angle)
        {
            return rotateImageOri(img, angle);
        }

        // Вращение с прямым искажением
        public Bitmap rotateImageDis(Bitmap Image, double degree)
        {
            int Wo = Image.Width;
            int Lo = Image.Height;

            double Wt = (int)(Math.Abs(Wo * Math.Cos(Math.PI * (degree / 180))) + Math.Abs(Lo * Math.Sin(Math.PI * (degree / 180))) + 0.5);
            double Lt = (int)(Math.Abs(Wo * Math.Sin(Math.PI * (degree / 180))) + Math.Abs(Lo * Math.Cos(Math.PI * (degree / 180))) + 0.5);
            Bitmap rotateImageData = new Bitmap((int)Wt, (int)Lt, PixelFormat.Format24bppRgb);

            //x и y - это координаты исходного изображения, а x1 и y1 - координаты после поворота.
            for (int y = 0; y < Lo; y++)
            {
                for (int x = 0; x < Wo; x++)
                {
                    int x1 = (int)Math.Round(x * Math.Cos(Math.PI * (degree / 180)) - y * Math.Sin(Math.PI * (degree / 180)) - (Wo - 1) / 2.0 * Math.Cos(Math.PI * (degree / 180)) + (Lo - 1) / 2.0 * Math.Sin(Math.PI * (degree / 180)) + (Wt - 1) / 2.0);
                    int y1 = (int)Math.Round(x * Math.Sin(Math.PI * (degree / 180)) + y * Math.Cos(Math.PI * (degree / 180)) - (Wo - 1) / 2.0 * Math.Sin(Math.PI * (degree / 180)) - (Lo - 1) / 2.0 * Math.Cos(Math.PI * (degree / 180)) + (Lt - 1) / 2.0);
                    rotateImageData.SetPixel(x1, y1, Image.GetPixel(x, y));
                }
            }
            return rotateImageData;
        }
        // Обратная билинейная интерполяция
        public Bitmap rotateImageOri(Bitmap Image, double degree)
        {
            int Wo = Image.Width;
            int Lo = Image.Height;

            // Округление используется для определения размера изображения после поворота.
            double Wt = (int)(Math.Abs(Wo * Math.Cos(Math.PI * (degree / 180))) + Math.Abs(Lo * Math.Sin(Math.PI * (degree / 180))) + 0.5);
            double Lt = (int)(Math.Abs(Wo * Math.Sin(Math.PI * (degree / 180))) + Math.Abs(Lo * Math.Cos(Math.PI * (degree / 180))) + 0.5);
            Bitmap rotateImageData = new Bitmap((int)Wt, (int)Lt, PixelFormat.Format24bppRgb);
            

            //x1, y1 - координаты повернутого изображения, x и y - координаты оригинального изображения
            for (int y1 = 0; y1 < Lt; y1++)
            {
                for (int x1 = 0; x1 < Wt; x1++)
                {
                    double x = x1 * Math.Cos(Math.PI * (degree / 180)) + y1 * Math.Sin(Math.PI * (degree / 180)) - (Wt - 1) / 2.0 * Math.Cos(Math.PI * (degree / 180)) - (Lt - 1) / 2.0 * Math.Sin(Math.PI * (degree / 180)) + (Wo - 1) / 2.0;
                    double y = -x1 * Math.Sin(Math.PI * (degree / 180)) + y1 * Math.Cos(Math.PI * (degree / 180)) + (Wt - 1) / 2.0 * Math.Sin(Math.PI * (degree / 180)) - (Lt - 1) / 2.0 * Math.Cos(Math.PI * (degree / 180)) + (Lo - 1) / 2.0;
                    if (-0.001 <= x & x <= (Wo - 1) & -0.001 <= y & y <= (Lo - 1))
                    {
                        Color RGB = new Color();

                        int a1 = (int)x;
                        int b1 = (int)y;
                        int a2 = (int)Math.Ceiling(x);
                        int b2 = (int)y;
                        int a3 = (int)x;
                        int b3 = (int)Math.Ceiling(y);
                        int a4 = (int)Math.Ceiling(x);
                        int b4 = (int)Math.Ceiling(y);

                        double xa13 = x - a1;
                        double xa24 = a2 - x;
                        double yb12 = y - b1;
                        double yb34 = b3 - y;

                        if (xa13 != 0 & xa24 != 0 & yb12 != 0 & yb34 != 0)
                        {//对应回原图是非整数坐标，双线性插值。
                            byte R1 = Image.GetPixel(a1, b1).R;
                            byte G1 = Image.GetPixel(a1, b1).G;
                            byte B1 = Image.GetPixel(a1, b1).B;
                            byte R2 = Image.GetPixel(a2, b2).R;
                            byte G2 = Image.GetPixel(a2, b2).G;
                            byte B2 = Image.GetPixel(a2, b2).B;
                            byte R3 = Image.GetPixel(a3, b3).R;
                            byte G3 = Image.GetPixel(a3, b3).G;
                            byte B3 = Image.GetPixel(a3, b3).B;
                            byte R4 = Image.GetPixel(a4, b4).R;
                            byte G4 = Image.GetPixel(a4, b4).G;
                            byte B4 = Image.GetPixel(a4, b4).B;

                            byte R = (byte)((R1 * xa24 + R2 * xa13) * yb34 + (R3 * xa24 + R4 * xa13) * yb12);
                            byte G = (byte)((G1 * xa24 + G2 * xa13) * yb34 + (G3 * xa24 + G4 * xa13) * yb12);
                            byte B = (byte)((B1 * xa24 + B2 * xa13) * yb34 + (B3 * xa24 + B4 * xa13) * yb12);

                            RGB = Color.FromArgb(R, G, B);
                        }
                        else
                        {//对应回原图是整数坐标,直接取Pixel。
                            RGB = Image.GetPixel(a1, b1);
                        }
                        rotateImageData.SetPixel(x1, y1, RGB);
                    }
                }
            }
            return rotateImageData;
        }
    }
}
