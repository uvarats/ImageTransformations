using ImageResize.Algorithms;
using ImageResize.Interface;
using ImageResize.Util;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageResize
{
    public partial class Form1 : Form
    {
        string imagePath = @"C:\Users\User\Desktop\dog.bmp";
        private Bitmap img;

        private NumericUpDown[,] updowns;

        public AfterInfo AfterInfo
        {
            set
            {
                dimensionAfter.Text = $"Разрешение: {value.Resolution}";
                filesizeAfter.Text = $"Размер файла: {value.FileSize} Кб";
                timeElapsed.Text = value.Elapsed.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            NumericUpDown[,] updowns = {
                { k00, k01, k02},
                { k10, k11, k12},
                { k20, k21, k22},
            };
            this.updowns = updowns;

            ScalingAlgorithm[] algos = { new NearestNeighbour(), new KTimes(), new BilinearInterpolation() };
            algoSelectComboBox.Items.AddRange(algos);
            algoSelectComboBox.SelectedIndex = 0;

            //InitFilters();

            ImageUtil.ParseFilter(imgOpenDialog);
            imgSaveDialog.Filter = imgOpenDialog.Filter;

            dimensionBefore.Text = "";
            filesizeBefore.Text = "";

            dimensionAfter.Text = "";
            filesizeAfter.Text = "";
            timeElapsed.Text = "";
        }

        //private void InitFilters()
        //{
        //    Filter[] predefinedKernels = { new BoxBlurFilter(), new EdgeFilter(), new ReliefFilter() };
        //    kernelsComboBox.Items.AddRange(predefinedKernels);
        //    kernelsComboBox.SelectedIndex = 0;
        //}

        private void bilinearResizeButton_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                return;
            }
            ScalingAlgorithm sa = algoSelectComboBox.SelectedItem as ScalingAlgorithm;
            float x = (float)xScaleValue.Value;
            float y = (float)yScaleValue.Value;
            Stopwatch swatch = Stopwatch.StartNew();
            Image image = sa.Scale(img, x, y);
            swatch.Stop();
            pictureBox1.Image = image;
            AfterInfo = AfterInfo.GetInfo(image, swatch.Elapsed);
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
            if (img == null)
            {
                return;
            }
            Rotation r = new Rotation();
            float angle = (float)angleUpDown.Value;
            Stopwatch swatch = Stopwatch.StartNew();
            Image res = r.Rotate(img, angle);
            swatch.Stop();
            pictureBox1.Image = res;

            AfterInfo = AfterInfo.GetInfo(res, swatch.Elapsed);
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
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
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            double[,] kernel = 
            {
                {(double)k00.Value, (double)k01.Value, (double)k02.Value },
                {(double)k10.Value, (double)k11.Value, (double)k12.Value },
                {(double)k20.Value, (double)k21.Value, (double)k22.Value },
            };
            KernelFilter filter = new KernelFilter();

            pictureBox1.Image = filter.Filter(img, kernel);
        }

        private void medianFilterButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = img.NewMedianFilter((int)medianMatrixSize.Value);
        }

        private void cleanMatrix_Click(object sender, EventArgs e)
        {
            foreach (var updown in updowns)
            {
                updown.Value = 0.0m;
            }
        }
    }
}