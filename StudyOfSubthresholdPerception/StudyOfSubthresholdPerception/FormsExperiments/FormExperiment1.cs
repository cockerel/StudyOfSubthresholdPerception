﻿using System;
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

namespace StudyOfSubthresholdPerception
{
    public partial class FormExperiment1 : Form
    {
        private enum Tabs { Description, SampleTest, Test };
        private int k = 0; //счетчик тестовых предъявлений
        private bool isTest = false; //проверка выполняется ли тест
        private bool check = false; //если false, то отбразится маска, true - предъявление
        private int numChange = 0; //счетчик кол-ва смен изображений (маска - предъявление - маска)
        private DB db = new DB();
        private List<int> listTime = new List<int>(2);
        private Experiments.Experiment1 exp1 = new Experiments.Experiment1();
        //private bool isSampleTestButtonNext = false; //проверка была ли нажата кнопка "Далее" в пробном тесте во второй раз (true - нажата)
        private int n = 0, m = 0; //счетчик кол-ва опытов и предъявлений
        private Stopwatch stopwatch = new Stopwatch();
        private CustomTimer timer = new CustomTimer();
        private ImageConverter imageConverter = new ImageConverter();

        public FormExperiment1()
        {
            listTime = db.getTime(11, 12);
            timer.Tick += timer_Tick;
            InitializeComponent();
        }

        private void FormExperiment1_SizeChanged(object sender, EventArgs e)
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
                        timer.Period = 1500;
                        timer.Start();
                    }
                    else
                    {
                        tabControl.SelectedIndex = (int)Tabs.Test;
                    }
                    break;
                case (int)Tabs.SampleTest:
                    if (k < 9)
                    {
                        timer.Period = listTime[0];
                        timer.Start();
                        labelSampleAnagram.Visible = false;
                        pictureBoxSample.Visible = true;
                        textBoxSampleAnswer.Text = String.Empty;
                        k++;
                        labelNumSampleTest.Text = "Предъявление " + (k + 1) + " из 10";
                    }
                    else
                    {
                        moveToTabExp();
                    }
                    break;
                case (int)Tabs.Test:
            loop1:
                    if (m < Experiments.Experiment1.numOfPresent * Experiments.Experiment1.numOfExp - 1)
                    {
                        //m++;      
                        if (k < Experiments.Experiment1.numOfPresent) // Experiments.Experiment1.numOfExp)
                        {
                            m++;
                            if (n <= Experiments.Experiment1.numOfExp)
                            {
                                timer.Period = listTime[0];
                                timer.Start();
                                labelAnagram.Visible = false;
                                pictureBoxMask.Visible = true;
                                k++;
                                labelNum.Text = "Предъявление " + k + " из " + (Experiments.Experiment1.numOfPresent); // Experiments.Experiment1.numOfExp);
                                exp1.addAnswerPresentation(DateTime.Now, textBoxAnswer.Text);
                                textBoxAnswer.Text = String.Empty;
                            }
                        }
                        else
                        {
                            k = 0;
                            if (n != Experiments.Experiment1.numOfExp)
                            {
                                labelNumTest.Text = "Опыт " + (++n) + " из " + Experiments.Experiment1.numOfExp;
                            }
                            MessageBox.Show("Опыт пройден. Перейти к следующему опыту.");
                            goto loop1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эксперимент пройден успешно. Просмотреть результаты эксперимента.");
                        exp1.addAnswerPresentation(DateTime.Now, textBoxAnswer.Text);
                        exp1.saveData(listTime[0], listTime[1]);
                        //new FormCurrentResult().ShowDialog();
                        Close();
                    }
                    break;
            }
        }

        private void FormExperiment1_Load(object sender, EventArgs e)
        {
            //new DB().loadTime();
            
            exp1.loadData();
            exp1.loadTestAnagrams();
            labelDescription.Text = labelDescription.Text.Replace("N", Experiments.Experiment1.numOfExp.ToString());
            labelDescription.Text = labelDescription.Text.Replace("M", Experiments.Experiment1.numOfPresent.ToString());
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
                labelNumTest.Text = "Опыт " + (++n) + " из " + Experiments.Experiment1.numOfExp;
            }));
            labelNum.BeginInvoke(new Action(delegate()
            {
                labelNum.Text = "Предъявление " + ++k + " из " + (Experiments.Experiment1.numOfPresent); // Experiments.Experiment1.numOfExp);
            }));
            timer.Start();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            moveToTabExp();
        }

        private void sampleTest()
        {
            if (numChange < 3)
            {
                if (check == false)
                {
                    timer.Stop();

                    pictureBoxSample.BeginInvoke(new Action(delegate()
                    {
                        pictureBoxSample.Visible = false;
                    })); 
                    check = true;
                    numChange++;
                    timer.Period = listTime[1];
                    timer.Start();
                }
                else
                {
                    timer.Stop();
                    pictureBoxSample.BeginInvoke(new Action(delegate()
                    {
                        pictureBoxSample.Visible = true;
                    })); 
                    check = false;
                    numChange++;
                    timer.Period = listTime[0];
                    timer.Start();
                }
            }
            else
            {
                timer.Stop();
                numChange = 0;
                check = false;
                labelSampleAnagram.BeginInvoke(new Action(delegate()
                {
                    labelSampleAnagram.Text = Experiments.Experiment1.anagrams[k];
                    labelSampleAnagram.Visible = true;
                }));
                textBoxSampleAnswer.BeginInvoke(new Action(delegate()
                    {
                        textBoxSampleAnswer.MaxLength = labelSampleAnagram.Text.Length;
                    }));
             
            }
        }

        private void nextPresentation()
        {
            if (numChange < 3)
            {
                switch (numChange)
                {
                    //очеееееень быстро или же так лагает
                    //   /*
                    //pictureBox.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                    case 0:
                        //pictureBox.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                        stopwatch.Start();
                        byte[] byteArray = new byte[0];
                        byteArray = (byte[])Experiments.Experiment1.table.Rows[m][1];
                        //  MemoryStream ms = new MemoryStream(byteArray);

                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Image = (Image)imageConverter.ConvertFrom(byteArray);
                        }));

                        // ms.Close();
                        stopwatch.Stop();
                        Console.WriteLine("Загрузка картинки в pictureBox: {0}", stopwatch.Elapsed);

                        timer.Period = listTime[0];
                        break;
                    case 1:
                        //--------------загрузка картинки-------
                        stopwatch.Start();

                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Visible = true;
                        }));
                        stopwatch.Stop();
                        Console.WriteLine("Отображение(отрисовка) на экране: {0}", stopwatch.Elapsed);
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
                    // */


                    //вроде бы нормально, но бывают подтупливания
                    /*
                  case 0:
                      pictureBox.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                      timer.Interval = DB.timeBefore;
                      break;
                  case 1:
                      //--------------загрузка картинки-------
                      byte[] byteArray = new byte[0];
                      byteArray = (byte[])Experiments.Experiment1.table.Rows[m][1];
                      MemoryStream ms = new MemoryStream(byteArray);
                      pictureBox.Image = Image.FromStream(ms);
                      ms.Close();
                      //--------------------------------------
                      timer.Interval = DB.time;
                      break;
                  case 2:
                      pictureBox.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                      timer.Interval = DB.timeBefore;
                      break;
                       */
                }
                numChange++;
            }
            else
            {
                timer.Stop();
                numChange = 0;

                pictureBoxMask.BeginInvoke(new Action(delegate()
                {
                    pictureBoxMask.Visible = false;
                }));


                labelAnagram.BeginInvoke(new Action(delegate()
                {
                    labelAnagram.Text = (string)Experiments.Experiment1.table.Rows[m][2];
                    labelAnagram.Visible = true;
                }));

                textBoxAnswer.BeginInvoke(new Action(delegate()
                    {
                        textBoxAnswer.MaxLength = labelAnagram.Text.Length;
                    }));

                //check = false;
                //labelSampleAnagram.Text = Experiments.Experiment1.anagrams[k];
                //labelSampleAnagram.Visible = true;
            }
        }

        private void textBoxesAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 'а' || e.KeyChar > 'ё'))
                e.Handled = true; 
        }
    }
}