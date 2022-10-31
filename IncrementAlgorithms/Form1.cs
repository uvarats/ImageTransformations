using IncrementAlgorithms.Algorithms;

namespace IncrementAlgorithms
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Color _color;
        public Form1()
        {
            InitializeComponent();
            _bitmap = new Bitmap(1000, 1000);
            _color = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Point p0 = new Point((int)x1Value.Value, (int)y1Value.Value);
            Point p1 = new Point((int)x2Value.Value, (int)y2Value.Value);
            BresenhamLine lineAlgo = new BresenhamLine(_bitmap);
            pictureBox1.Image = lineAlgo.Draw(p0, p1, _color);
        }

        private void drawCircleButton_Click(object sender, EventArgs e)
        {
            Point p = new Point((int)centerX.Value, (int)centerY.Value);
            BresenhamCircle circle = new BresenhamCircle(_bitmap);
            pictureBox1.Image = circle.Draw(p, (int)radius.Value, _color);
        }

        private void drawEllipseButton_Click(object sender, EventArgs e)
        {
            BresenhamEllipse ellipse = new BresenhamEllipse();
            pictureBox1.Image = ellipse.Draw(
                _bitmap,
                (int)ellipseCenterX.Value,
                (int)ellipseCenterY.Value,
                (int)ellipseRadiusX.Value,
                (int)ellipseRadiusY.Value,
                _color
                );
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            _color = colorDialog1.Color;
        }
    }
}