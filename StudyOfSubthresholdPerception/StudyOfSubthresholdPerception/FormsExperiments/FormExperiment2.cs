using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.Models;
using Point = StudyOfSubthresholdPerception.Models.Point;

namespace StudyOfSubthresholdPerception.FormsExperiments
{
    public partial class FormExperiment2 : Form
    {
        public FormExperiment2()
        {
            InitializeComponent();
        }

        private Point _point;
        private Circle _circle;
        private Experiment2ResultModel Result { get; set; }
        private int Count { get; set; }
        private int ExperimentsCount { get; set; }
        private bool CircleIsVisible { get; set; }
        private bool TestExperiment { get; set; }

        private void FormExperiment2_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            CircleIsVisible = true;
            TestExperiment = false;
            Result = new Experiment2ResultModel();
            var temp = (panel1.Width - 1f) / 2f;
            _circle = new Circle(temp, temp, temp, new Pen(Color.GreenYellow, 3));
            _point = new Point(4f, 4.7f, (float)Math.PI / 30f, new SolidBrush(Color.DarkGreen));
            _point.Reset(_circle);
            timer1.Interval = 40;
            timer2.Interval = 10;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _point.Step(_circle);
            if (Math.Abs(_point.Angle - 4.7f) < 0.05f)
            {
                StopCircle();
            }
            if (Math.Abs(_point.Angle - 0.1f) < 0.05f || Math.Abs(_point.Angle - 3.2f) < 0.05f)
            {
                if (!TestExperiment)
                {
                    ShowPictures();
                    timer2.Start();
                    
                }
            }
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            try
            {
                HidePictures();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HidePictures()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void ShowPictures()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void StopCircle()
        {
            timer1.Stop();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            CircleIsVisible = false;
        }

        private void StartCircle()
        {
            timer1.Start();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            CircleIsVisible = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(panel1.CreateGraphics());
        }

        private void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);
            if (CircleIsVisible)
            {
                _circle.Draw(graphics);
                _point.Draw(graphics);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartExperiment(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StartExperiment(2);
        }

        private void StartExperiment(int imageId)
        {
            Result.SelectedImageIds.Add(imageId);
            Count++;
            if (Count < 2)
            {
                StartCircle();
            }
            else
            {
                var formResult = new FormCurrentResult(new DataTable());
                formResult.Show();
                Close();
            }
        }


    }
}
