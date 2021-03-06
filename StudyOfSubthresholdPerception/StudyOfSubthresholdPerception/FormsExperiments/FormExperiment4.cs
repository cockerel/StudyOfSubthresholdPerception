﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.Models;
using StudyOfSubthresholdPerception.Models.Experiment2;
using StudyOfSubthresholdPerception.Models.Experiment4;
using StudyOfSubthresholdPerception.Properties;
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
        private int ExpCount { get; set; }
        private int PresCount { get; set; }
        private int ExperimentsCount { get; set; }
        private int PresentationsCount { get; set; }
        private int Step { get; set; }
        private int PointPeriod { get; set; }
        private bool CircleIsVisible { get; set; }
        private int CircleCount { get; set; }
        private int CirclePeriod { get; set; }
        private bool TestExperiment { get; set; }
        private bool Image1Shown { get; set; }
        private Experiment4Model UnderImage { get; set; }
        private bool Image2Shown { get; set; }
        private List<Experiment4Model> Data { get; set; }
        private List<Image> TestData { get; set; }
        private int TestDataCount = 0;

        private void FormExperiment2_Load(object sender, EventArgs e)
        {
            Reset();
            try
            {
                TestData = new List<Image>
				{
                    Resources.exp4Test1,
                    Resources.exp4Test2,
                    Resources.exp4Test3,
                    Resources.exp4Test4,
                    Resources.exp4Test5,
                    Resources.exp4Test6,
                    Resources.exp4Test7,
                    Resources.exp4Test8,
                    Resources.exp4Test9,
                    Resources.exp4Test10
				};
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetNextImage();
            label2.Text = label2.Text.Replace("N", ExperimentsCount.ToString(CultureInfo.InvariantCulture))
                 .Replace("M", PresentationsCount.ToString(CultureInfo.InvariantCulture));
            tabControlEX1.SelectTab(tabPageEX1);
        }

        private void Reset()
        {
            Step = 0;
            ExpCount = 0;
            PresCount = 0;
            CircleCount = 0;
            DoubleBuffered = true;
            CircleIsVisible = true;
            TestExperiment = true;
            var ex4 = new Experiment4DataHelper();
            var settings = ex4.GetSettings();
            PointPeriod = settings.PointPeriod;
            ExperimentsCount = settings.Experiments;
            PresentationsCount = settings.Presentations;
            CirclePeriod = settings.CirclePeriod;
            Data = ex4.GetData();
            var temp = (panel1.Width - 10f) / 2f;
            _circle = new Circle(temp + 5, temp + 5, temp, new Pen(Color.GreenYellow, 3));
            _point = new Point(4f, 4.8f, (float)(Math.PI / (PointPeriod * 10)) * 2, new SolidBrush(Color.DarkGreen));
            _point.Reset(_circle);
            timer1.Interval = 100;
            timer2.Interval = settings.UnderTime == 0 ? 40 : settings.UnderTime;
            UnderImage = Data.FirstOrDefault(x => x.Type == 3);
            Data.Remove(UnderImage);
            Image1Shown = false;
            Image2Shown = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _point.Step(_circle);
            if (Math.Abs(_point.Angle - 4.8f) < 0.1f)
            {
                StopCircle();
                SetNextImage();
            }
            if (Math.Abs(_point.Angle - 0.1f) < 0.1f && !Image2Shown && !TestExperiment)
            {
                if (!TestExperiment)
                {
                    pictureBox2.Visible = true;
                    Image2Shown = true;
                    Image1Shown = false;
                    timer2.Start();

                }
            }
            if (Math.Abs(_point.Angle - 3.2f) < 0.1f && !Image1Shown && !TestExperiment)
            {
                if (!TestExperiment)
                {
                    pictureBox1.Visible = true;
                    Image1Shown = true;
                    Image2Shown = false;
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
            if (!TestExperiment)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }
            CircleIsVisible = false;
        }

        private void SetNextImage()
        {
            if (!TestExperiment)
            {
                var rand = new Random();
                var randomInt = rand.Next(0, Data.Count);
                if (Data.Count > 0)
                {
                    pictureBox1.Image = Data[randomInt].ImageItem1;
                    pictureBox2.Image = Data[randomInt].ImageItem2;

                }
            }
            else
            {
                pictureBox3.Image = TestData[TestDataCount];
                pictureBox4.Image = TestData[++TestDataCount];
            }
        }

        private void SetUnderImage()
        {
            if (UnderImage != null)
            {
                pictureBox1.Image = UnderImage.ImageItem1;
                pictureBox2.Image = UnderImage.ImageItem2;
            }
        }

        private void StartCircle()
        {
            if (!TestExperiment)
            {
                if (PresCount < PresentationsCount)
                {
                    if (CircleCount == 0 || CircleCount == CirclePeriod)
                    {
                        CircleCount = 1;
                        timer1.Start();
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        CircleIsVisible = true;
                    }
                    else
                    {
                        SetNextImage();
                        CircleCount++;
                    }
                }
                else
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    CircleIsVisible = false;
                    buttonNext.Visible = true;
                    labelExp.Visible = true;
                }
            }
            else
            {
                if (PresCount < 5)
                {
                    if (CircleCount == 0 || CircleCount == CirclePeriod)
                    {
                        CircleCount = 1;
                        timer1.Start();
                        pictureBox4.Visible = false;
                        pictureBox3.Visible = false;
                        CircleIsVisible = true;
                    }
                    else
                    {
                        SetNextImage();
                        CircleCount++;
                    }
                }
                else
                {
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    CircleIsVisible = false;
                    buttonNext.Visible = false;
                    MessageBox.Show(Properties.Resources.StrAttention1);
                    label1.Visible = true;
                    EndTest();
                }
            }
            if (TestExperiment)
            {
                labelNumSampleTest.Text = String.Concat("Предъявление ", (PresCount + 1), " из ", 5);
            }
            else
            {
                labelNum.Text = String.Concat("Предъявление ", (PresCount + 1), " из ", PresentationsCount);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(!TestExperiment ? panel1.CreateGraphics() : panel2.CreateGraphics());
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
            SetUnderImage();
            PresCount++;
            StartCircle();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetUnderImage();
            PresCount++;
            StartCircle();
        }

        private void StartExperiment()
        {
            Image1Shown = false;
            Image2Shown = false;
            if (PresCount < PresentationsCount)
            {
                StartCircle();
            }
            else
            {
                if (TestExperiment)
                {
                    label1.Visible = true;
                    EndTest();
                }
                else
                {
                    buttonNext.Visible = true;
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            switch (Step)
            {
                case 0:
                    tabControlEX1.SelectTab(tabPageEX2);
                    buttonFinish.Visible = true;
                    tabPageEX2.Enabled = true;
                    labelNumSampleTest.Text = String.Concat("Предъявление ", (0), " из ", PresentationsCount);
                    Step++;
                    ExpCount++;
                    PresCount = 0;
                    labelExp.Visible = false;
                    buttonNext.Visible = false;
                    CircleCount = 0;
                    StartExperiment();
                    break;
                case 1:
                    labelNum.Text = String.Concat("Предъявление ", (0), " из ", PresentationsCount);
                    ExpCount++;
                    PresCount = 0;
                    labelExp.Visible = false;
                    buttonNext.Visible = false;
                    StartExperiment();
                    break;
                case 2:
                    if (ExpCount < ExperimentsCount)
                    {
                        labelNumTest.Text = String.Concat("Опыт ", ExpCount + 1, " из ", ExperimentsCount);
                        ExpCount++;
                        PresCount = 0;
                        labelExp.Visible = false;
                        buttonNext.Visible = false;
                        CircleCount = 0;
                        StartExperiment();
                    }
                    else
                    {
                        MessageBox.Show(Resources.EndExpMessage);
                        Close();
                    }
                    break;
            }

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            CircleIsVisible = false;
            buttonNext.Visible = false;
            MessageBox.Show(Properties.Resources.StrAttention1);
            label1.Visible = true;
            timer1.Stop();
            timer2.Stop();
            EndTest();
        }

        private void EndTest()
        {
            tabPageEX3.Enabled = true;
            tabPageEX2.Enabled = false;
            tabControlEX1.SelectTab(tabPageEX3);
            Step++;
            buttonFinish.Visible = false;
            buttonNext.Visible = true;
            Reset();
            Step = 2;
            TestExperiment = false;
            MessageBox.Show(Properties.Resources.StrAttention1);
            SetNextImage();
            labelNumTest.Text = String.Concat("Опыт ", ExpCount + 1, " из ", ExperimentsCount);
            labelNum.Text = String.Concat("Предъявление ", (PresCount + 1), " из ", PresentationsCount);
        }

        private void FormExperiment4_SizeChanged(object sender, EventArgs e)
        {
            panelMain.Location = new System.Drawing.Point(this.ClientSize.Width / 2 - panelMain.Size.Width / 2,
                this.ClientSize.Height / 2 - panelMain.Size.Height / 2);
        }

        private void FormExperiment4_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formResult = new FormCurrentResult(new DataTable());
            formResult.Show();
            formResult.Focus();
        }
    }
}

