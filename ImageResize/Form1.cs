using ImageResize.Algorithms;
using ImageResize.Interface;
using ImageResize.Util;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageResize
{
    public partial class Form1 : Form
    {
        string imagePath = @"C:\Users\User\Desktop\dog.bmp";
        private Bitmap img;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ScalingAlgorithm[] algos = { new NearestNeighbour(), new KTimes(), new BilinearInterpolation() };
            algoSelectComboBox.Items.AddRange(algos);
            algoSelectComboBox.SelectedIndex = 0;

            ImageUtil.ParseFilter(imgOpenDialog);
            imgSaveDialog.Filter = imgOpenDialog.Filter;
            if (imgOpenDialog.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }

            imagePath = imgOpenDialog.FileName;
            img = new Bitmap(imagePath);
            pictureBox1.Image = img;

            dimensionBefore.Text = $"Разрешение: {string.Format("{0}x{1}", img.Width, img.Height)}";
            long length = new FileInfo(imgOpenDialog.FileName).Length;
            filesizeBefore.Text = $"Размер файла: {Math.Round(length / 1024.0, 2)} Кб";
            dimensionAfter.Text = "";
            filesizeAfter.Text = "";
        }

        private void bilinearResizeButton_Click(object sender, EventArgs e)
        {
            ScalingAlgorithm sa = algoSelectComboBox.SelectedItem as ScalingAlgorithm;
            float x = (float)xScaleValue.Value;
            float y = (float)yScaleValue.Value;
            Task t = new Task(() =>
            {
                pictureBox1.BeginInvoke(() =>
                {
                    Image image = sa.Scale(img, x, y);
                    pictureBox1.Image = image;
                    dimensionAfter.Text = $"Разрешение: {string.Format("{0}x{1}", image.Width, image.Height)}";
                    string tempfile = "temp.bmp";
                    image.Save(tempfile);
                    long length = new FileInfo(tempfile).Length;
                    File.Delete(tempfile);
                    filesizeAfter.Text = $"Размер файла: {Math.Round(length / 1024.0, 2)} Кб";
                });
            });
            t.Start();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (imgSaveDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string fileName = imgSaveDialog.FileName;
            pictureBox1.Image.Save(fileName);
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            Rotation r = new Rotation();
            float angle = (float)angleUpDown.Value;
            Image res = r.Rotate(img, angle);
            pictureBox1.Image = res;
        }
    }
}