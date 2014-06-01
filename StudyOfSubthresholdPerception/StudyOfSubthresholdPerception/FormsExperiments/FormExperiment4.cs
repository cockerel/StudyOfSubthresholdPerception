using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.Models;
using StudyOfSubthresholdPerception.Models.Experiment2;
using StudyOfSubthresholdPerception.Models.Experiment4;
using Point = StudyOfSubthresholdPerception.Models.Point;

namespace StudyOfSubthresholdPerception.FormsExperiments
{
    public partial class FormExperiment4 : Form
    {
        public FormExperiment4()
        {
            InitializeComponent();
        }

        private Point _point;
        private Circle _circle;
        private Experiment2ResultModel Result { get; set; }
        private int Count { get; set; }
        private int PresentationsCount { get; set; }
		private int Period { get; set; }
        private bool CircleIsVisible { get; set; }
        private bool TestExperiment { get; set; }
        private List<Experiment4Model> Data { get; set; } 

        private void FormExperiment2_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            CircleIsVisible = true;
            TestExperiment = false;
            var ex4 = new Experiment4DataHelper();
	        var settings = ex4.GetSettings();
	        Period = settings.Period;
	        PresentationsCount = settings.Presentations;
            Data = ex4.GetData();
            Result = new Experiment2ResultModel();
            var temp = (panel1.Width - 10f) / 2f;
            _circle = new Circle(temp+5, temp+5, temp, new Pen(Color.GreenYellow, 3));
            _point = new Point(4f, 4.7f, (float)Math.PI / Period, new SolidBrush(Color.DarkGreen));
            _point.Reset(_circle);
            timer1.Interval = 40;
            timer2.Interval = 40;
            timer1.Start();
            var rand = new Random();
            var randomInt = rand.Next(0, Data.Count);
            pictureBox1.Image = Data[randomInt].ImageItem1;
            pictureBox2.Image = Data[randomInt].ImageItem2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _point.Step(_circle);
            if (Math.Abs(_point.Angle - 4.7f) < 0.05f)
            {
                StopCircle();
            }
            if (Math.Abs(_point.Angle - 0.1f) < 0.05f)
            {
                if (!TestExperiment)
                {
                    pictureBox2.Visible = true;
                    timer2.Start();
                    
                }
            }
            if (Math.Abs(_point.Angle - 3.2f) < 0.05f)
            {
                if (!TestExperiment)
                {
                    pictureBox1.Visible = true;
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
            if (Count < PresentationsCount)
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
