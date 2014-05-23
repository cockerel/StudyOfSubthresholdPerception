using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using CustomTimer = StudyOfSubthresholdPerception.Timer.Timer;
using System.Threading;

namespace StudyOfSubthresholdPerception
{
    public partial class FormExperiment5 : Form
    {
        private enum Tabs { Description, SampleTest, Test };
        private int k = 0; //счетчик тестовых предъявлений
        private bool isTest = false; //проверка выполняется ли тест
        private bool check = false; //если false, то отбразится маска, true - предъявление
        private int numChange = 0; //счетчик кол-ва смен изображений (маска - предъявление - маска)
        private DB db = new DB();
        private List<int> listTime = new List<int>(2);
        private Experiments.Experiment5 exp5 = new Experiments.Experiment5();
        //private bool isSampleTestButtonNext = false; //проверка была ли нажата кнопка "Далее" в пробном тесте во второй раз (true - нажата)
        private int n = 0, m = 0; //счетчик кол-ва опытов и предъявлений
        private Stopwatch stopwatch = new Stopwatch();
        private CustomTimer timer = new CustomTimer();
        private ImageConverter imageConverter = new ImageConverter();
        private int countImage = 0;

        public FormExperiment5()
        {
            listTime = db.getTime(19, 20, 26);
            timer.Tick += timer_Tick;
            InitializeComponent();
        }

        private void FormExperiment5_SizeChanged(object sender, EventArgs e)
        {
            panelMain.Location = new Point(this.ClientSize.Width / 2 - panelMain.Size.Width / 2,
                this.ClientSize.Height / 2 - panelMain.Size.Height / 2);
            //panel.Anchor = AnchorStyles.None;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case (int)Tabs.Description:
                    if (isTest == false)
                    {
                        tabPageEX2.Enabled = true;
                        tabControl.SelectedIndex = (int)Tabs.SampleTest;
                        buttonFinish.Visible = true;
                        pictureBoxSample.Visible = false;
                        if (listTime[0] > 0)
                        {
                            timer.Period = listTime[0];
                        }
                        //Thread.Sleep(listTime[2]);
                        timer.Start();
                    }
                    else
                    {
                        tabControl.SelectedIndex = (int)Tabs.Test;
                    }
                    break;
                case (int)Tabs.SampleTest:
                    pictureBoxSample.Visible = false;
                    //Thread.Sleep(listTime[2]);
                    if (k < 4)
                    {
                        if (listTime[0] > 0)
                        {
                            timer.Period = listTime[0];
                        }

                        timer.Start();
                        //pictureBoxSample.Visible = true;
                        k++;
                        labelNumSampleTest.Text = "Предъявление " + (k + 1) + " из 5";
                    }
                    else
                    {
                        MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.StrAttention1);
                        moveToTabExp();
                    }
                    break;
                case (int)Tabs.Test:
                loop1:
                    if (m < Experiments.Experiment5.numOfPresent * Experiments.Experiment5.numOfExp - 1)
                    {
                        //m++;      
                        if (k < Experiments.Experiment5.numOfPresent) // Experiments.Experiment1.numOfExp)
                        {
                            m++;
                            if (n <= Experiments.Experiment5.numOfExp)
                            {
                                if (listTime[0] > 0)
                                {
                                    timer.Period = listTime[0];
                                    //pictureBoxMask.Visible = true;
                                }
                                //else
                                    //pictureBoxMask.Visible = false;
                                //pictureBoxPresentation.Visible = false;

                                pictureBoxPresentation.BeginInvoke(new Action(delegate()
                                {
                                    pictureBoxPresentation.Visible = false;
                                }));

                                timer.Start();
                                
                                k++;
                                labelNum.Text = "Предъявление " + k + " из " + (Experiments.Experiment5.numOfPresent); // Experiments.Experiment1.numOfExp);
                                exp5.addAnswerPresentation(DateTime.Now, trackBarScale.Value);
                                trackBarScale.Value = 0;
                            }
                        }
                        else
                        {
                            k = 0;
                            if (n != Experiments.Experiment5.numOfExp)
                            {
                                labelNumTest.Text = "Опыт " + (++n) + " из " + Experiments.Experiment5.numOfExp;
                            }
                            MessageBox.Show("Опыт завершен. Перейти к следующему опыту.");
                            goto loop1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эксперимент завершен успешно. Просмотреть результаты эксперимента.");
                        exp5.addAnswerPresentation(DateTime.Now, trackBarScale.Value);
                        exp5.saveData(listTime[0], listTime[1]);
                        //new FormCurrentResult().ShowDialog();
                        Close();
                    }
                    break;
            }
        }

        private void FormExperiment5_Load(object sender, EventArgs e)
        {
            //new DB().loadTime();
            tabControl.SelectedIndex = 0;
            exp5.loadData();
            exp5.loadTestImages();
            labelDescription.Text = labelDescription.Text.Replace("N", Experiments.Experiment5.numOfExp.ToString());
            labelDescription.Text = labelDescription.Text.Replace("M", Experiments.Experiment5.numOfPresent.ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //тестовые предъявления
            if (isTest == false)
            {
                sampleTest();
            }
            //выполнение теста
            else
            {
                nextPresentation();
            }
        }

        private void moveToTabExp()
        {
            tabPageEX2.BeginInvoke(new Action(delegate()
            {
                tabPageEX2.Enabled = false;
            }));
            tabPageEX3.BeginInvoke(new Action(delegate()
            {
                tabPageEX3.Enabled = true;
            }));
            tabControl.BeginInvoke(new Action(delegate()
            {
                tabControl.SelectedIndex = (int)Tabs.Test;
            }));
            buttonFinish.BeginInvoke(new Action(delegate()
            {
                buttonFinish.Visible = false;
            }));
            isTest = true;
            k = 0;
            labelNumTest.BeginInvoke(new Action(delegate()
            {
                labelNumTest.Text = "Опыт " + (++n) + " из " + Experiments.Experiment5.numOfExp;
            }));
            labelNum.BeginInvoke(new Action(delegate()
            {
                labelNum.Text = "Предъявление " + ++k + " из " + (Experiments.Experiment5.numOfPresent); // Experiments.Experiment1.numOfExp);
            }));
            
            timer.Start();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.StrAttention1);
            moveToTabExp();
        }

        private void sampleTest()
        {
            if (numChange < 4 && listTime[0] > 0)
            {
                switch (numChange)
                {
                    case 0:
                        Thread.Sleep(listTime[2]);

                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                            pictureBoxSample.Visible = true;
                        }));
                        timer.Period = listTime[0];
                        break;
                    case 1:
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Image = StudyOfSubthresholdPerception.Properties.Resources.exp5Test;
                            //pictureBoxSample.Visible = false;
                        }));
                        timer.Period = listTime[1];
                        break;
                    case 2:
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                            //pictureBoxSample.Visible = true;
                        }));

                        timer.Period = listTime[0];
                        break;
                    case 3:
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Visible = false;
                        }));
                        
                        Thread.Sleep(listTime[2]);

                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Visible = true;
                            pictureBoxSample.Image = Experiments.Experiment5.imageList[countImage++];
                        }));
                        timer.Period = listTime[0];
                        break;
                }
                numChange++;
            }
            else if (listTime[0] == 0 && numChange < 3)
            {
                switch (numChange)
                {
                    case 0:
                        Thread.Sleep(listTime[2]);
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Visible = false;
                        }));
                        break;
                    case 1:
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Image = StudyOfSubthresholdPerception.Properties.Resources.exp5Test;
                            pictureBoxSample.Visible = true;
                        }));
                        timer.Period = listTime[1];
                        break;
                    case 2:
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Visible = false;
                        }));

                        Thread.Sleep(listTime[2]);
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Visible = true;
                            pictureBoxSample.Image = Experiments.Experiment5.imageList[countImage++];
                        }));
                        break;
                }
                numChange++;
            }
            else
            {
                timer.Stop();
                numChange = 0;
                check = false;
            }
        }

        private void nextPresentation()
        {
            //есть маска
            if (numChange < 4 && listTime[0] > 0)
            {
                switch (numChange)
                {
                    case 0:
                        

                        Thread.Sleep(listTime[2]);

                        pictureBoxMask.BeginInvoke(new Action(delegate()
                        {
                            //pictureBoxMask.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                            pictureBoxMask.Visible = true;
                        }));

                        byte[] byteArray = new byte[0];
                        if ((bool)Experiments.Experiment5.table.Rows[m][4] == true)
                            byteArray = (byte[])Experiments.Experiment5.table.Rows[m][2];
                        else
                            byteArray = (byte[])Experiments.Experiment5.table.Rows[m][3];

                        

                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Image = (Image)imageConverter.ConvertFrom(byteArray);
                        }));

                        timer.Period = listTime[0];
                        break;
                    case 1:
                        //--------------загрузка картинки-------
                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Visible = true;
                        }));
                        //--------------------------------------
                        timer.Period = listTime[1];
                        break;
                    case 2:
                        //pictureBox.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;

                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Visible = false;
                        }));
                        
                        timer.Period = listTime[0];
                        break;
                    case 3:
                        pictureBoxMask.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxMask.Visible = false;
                        }));

                        Thread.Sleep(listTime[2]);

                        //timer.Period = listTime[0];
                        break;
                }
                numChange++;
            }
            //нет маски
            else if (listTime[0] == 0 && numChange < 2)
            {
                switch (numChange)
                {
                    case 0:
                        
                        byte[] byteArray = new byte[0];
                        if ((bool)Experiments.Experiment5.table.Rows[m][4] == true)
                            byteArray = (byte[])Experiments.Experiment5.table.Rows[m][2];
                        else
                            byteArray = (byte[])Experiments.Experiment5.table.Rows[m][3];
                        Thread.Sleep(listTime[2]);
                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Image = (Image)imageConverter.ConvertFrom(byteArray);
                            pictureBoxPresentation.Visible = true;
                        }));
                        timer.Period = listTime[1];
                        break;
                    
                    case 1:
                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Visible = false;
                        }));
                        Thread.Sleep(listTime[2]);
                        break;
                }
                numChange++;
            }
            else
            {
                timer.Stop();
                numChange = 0;
                byte[] byteArray = new byte[0];
                byteArray = (byte[])Experiments.Experiment5.table.Rows[m][1];

                pictureBoxPresentation.BeginInvoke(new Action(delegate()
                {
                    pictureBoxPresentation.Image = (Image)imageConverter.ConvertFrom(byteArray);
                    pictureBoxPresentation.Visible = true;
                }));
            }
        }

        private void trackBarScaleTest_Scroll(object sender, EventArgs e)
        {
            labelScaleTest.Text = "Оценка: " + trackBarScaleTest.Value;
        }

        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            labelScale.Text = "Оценка: " + trackBarScale.Value;
        }
    }
}
