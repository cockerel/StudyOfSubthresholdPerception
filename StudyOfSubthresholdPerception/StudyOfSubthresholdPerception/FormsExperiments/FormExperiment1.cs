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
using StudyOfSubthresholdPerception.DataHelpers;
using CustomTimer = StudyOfSubthresholdPerception.Timer.Timer;
using System.Threading;

namespace StudyOfSubthresholdPerception
{
    public partial class FormExperiment1 : Form
    {
        private enum Tabs { Description, SampleTest, Test };
        private int k = 0; //счетчик тестовых предъявлений
        private bool isTest = false; //проверка выполняется ли тест
        private bool isFirst = true;
        private bool isClose = false;
        private bool check = false; //если false, то отбразится маска, true - предъявление
        private int numChange = 0; //счетчик кол-ва смен изображений (маска - предъявление - маска)
        private DB db = new DB();
        private List<int> listTime = new List<int>(2);
        private Experiment1 exp1 = new Experiment1();
        //private bool isSampleTestButtonNext = false; //проверка была ли нажата кнопка "Далее" в пробном тесте во второй раз (true - нажата)
        private int n = 0, m = 0; //счетчик кол-ва опытов и предъявлений
        private Stopwatch stopwatch = new Stopwatch();
        private CustomTimer timer = new CustomTimer();
        private ImageConverter imageConverter = new ImageConverter();

        public FormExperiment1()
        {
            listTime = db.getTime(11, 12, 22);
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
                        if (isFirst == true)
                        {
                            tabPageEX2.Enabled = true;
                            tabControl.SelectedIndex = (int)Tabs.SampleTest;
                            buttonFinish.Visible = true;
                            pictureBoxSample.Visible = false;
                            /*
                            if (listTime[0] > 0)
                            {
                                timer.Period = listTime[0];
                            }
                            else
                            {
                                timer.Period = listTime[1];
                            }
                             */
                            //timer.Period = 1500;

                            if (listTime[0] > 0)
                            {
                                timer.Period = listTime[0];
                            }
                            //Thread.Sleep(listTime[2]);
                            timer.Start();
                            isClose = true;
                            buttonNext.Enabled = false;
                            isFirst = false;
                        }
                        else
                        {
                            tabControl.SelectedIndex = (int)Tabs.SampleTest;
                        }
                    }
                    else
                    {
                        tabControl.SelectedIndex = (int)Tabs.Test;
                    }
                    
                    textBoxSampleAnswer.Select();
                    break;
                case (int)Tabs.SampleTest:
                    isClose = true;
                    buttonFinish.Enabled = false;
                    buttonNext.Enabled = false;
                    if (k < 9)
                    {
                        pictureBoxSample.Visible = false;
                        labelSampleAnagram.Visible = false;
                        //Thread.Sleep(listTime[2]);
                        if (listTime[0] > 0)
                        {
                            //pictureBoxSample.Visible = true;
                            timer.Period = listTime[0];
                            //timer.Start();
                        }
                        //else
                        //{
                            //timer.Period = listTime[1];
                            timer.Start();
                        //}

                        textBoxSampleAnswer.Text = String.Empty;
                        k++;
                        labelNumSampleTest.Text = "Стимул " + (k + 1) + " из 10";
                        textBoxSampleAnswer.Select();
                    }
                    else
                    {
                        MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.StrAttention1);
                        moveToTabExp();
                        buttonNext.Enabled = false;
                        isClose = true;
                        //textBoxAnswer.Select();
                        textBoxAnswer.BeginInvoke(new Action(delegate()
                        {
                            textBoxAnswer.Select();
                        }));
                    }
                    break;
                case (int)Tabs.Test:
                    isClose = true;
                    buttonNext.Enabled = false;
                    
                loop1:
                    if (m < Experiment1.numOfPresent * Experiment1.numOfExp - 1)
                    {
                        //m++;      
                        if (k < Experiment1.numOfPresent) // Experiments.Experiment1.numOfExp)
                        {
                            m++;
                            if (n <= Experiment1.numOfExp)
                            {
                                if (listTime[0] > 0)
                                {
                                    timer.Period = listTime[0];
                                    //pictureBoxMask.Visible = true;
                                }
                                //else
                                //    timer.Period = listTime[1];
                                timer.Start();
                                labelAnagram.Visible = false;

                                k++;
                                labelNum.Text = "Стимул " + k + " из " + (Experiment1.numOfPresent); // Experiments.Experiment1.numOfExp);
                                exp1.addAnswerPresentation(DateTime.Now, textBoxAnswer.Text);
                                textBoxAnswer.Text = String.Empty;
                                textBoxAnswer.Select();
                            }
                        }
                        else
                        {
                            k = 0;
                            if (n != Experiment1.numOfExp)
                            {
                                labelNumTest.Text = "Опыт " + (++n) + " из " + Experiment1.numOfExp;
                            }
                            MessageBox.Show("Опыт завершен. Перейти к следующему опыту.");
                            goto loop1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эксперимент завершен успешно. Просмотреть результаты эксперимента.");
                        exp1.addAnswerPresentation(DateTime.Now, textBoxAnswer.Text);
                        exp1.saveData(listTime[0], listTime[1]);
                        //new FormCurrentResult().ShowDialog();
                        isClose = false;
                        Close();
                    }
                    break;
            }
        }

        private void FormExperiment1_Load(object sender, EventArgs e)
        {
            try
            {
                DoubleBuffered = true;
                //new DB().loadTime();
                tabControl.SelectedIndex = 0;
                exp1.loadData();
                exp1.loadTestAnagrams();
                labelDescription.Text = labelDescription.Text.Replace("N", Experiment1.numOfExp.ToString());
                labelDescription.Text = labelDescription.Text.Replace("M", Experiment1.numOfPresent.ToString());

                /*
                if (listTime[0] == 0)
                {
                    pictureBoxSample.BeginInvoke(new Action(delegate()
                    {
                        pictureBoxSample.Visible = false;
                    }));
                    pictureBoxMask.Visible = false;
                }
                 */
                if (Experiment1.table.Rows.Count == 0)
                {
                    MessageBox.Show("Произошла ошибка. Проверьте настройки эксперимента.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Проверьте настройки эксперимента.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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
                labelNumTest.Text = "Опыт " + (++n) + " из " + Experiment1.numOfExp;
            }));
            labelNum.BeginInvoke(new Action(delegate()
            {
                labelNum.Text = "Стимул " + ++k + " из " + (Experiment1.numOfPresent); // Experiments.Experiment1.numOfExp);
            }));
            timer.Start();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.StrAttention1);
            moveToTabExp();
            buttonNext.Enabled = false;
            textBoxAnswer.BeginInvoke(new Action(delegate()
            {
                textBoxAnswer.Select();
            }));
            //textBoxAnswer.Select();
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
                            //pictureBoxSample.Image = StudyOfSubthresholdPerception.Properties.Resources.exp5Test;
                            pictureBoxSample.Visible = false;
                        }));
                        timer.Period = listTime[1];
                        break;
                    case 2:
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            //pictureBoxSample.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                            pictureBoxSample.Visible = true;
                        }));
                        timer.Period = listTime[0];
                        
                        break;
                    case 3:
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Visible = false;
                        }));
                        Thread.Sleep(listTime[2]);
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
                            //pictureBoxSample.Image = StudyOfSubthresholdPerception.Properties.Resources.exp5Test;
                            //pictureBoxSample.Visible = true;
                        }));
                        timer.Period = listTime[1];
                        break;
                    case 2:
                        pictureBoxSample.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxSample.Visible = false;
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
                check = false;
                labelSampleAnagram.BeginInvoke(new Action(delegate()
                {
                    labelSampleAnagram.Text = Experiment1.anagrams[k];
                    labelSampleAnagram.Visible = true;
                }));
                textBoxSampleAnswer.BeginInvoke(new Action(delegate()
                {
                    textBoxSampleAnswer.MaxLength = labelSampleAnagram.Text.Length;
                    //textBoxAnswer.Select();
                }));
                
                buttonNext.BeginInvoke(new Action(delegate()
                    {
                        buttonNext.Enabled = true;
                    }));
                buttonFinish.BeginInvoke(new Action(delegate()
                {
                    buttonFinish.Enabled = true;
                }));
                isClose = false;
            }
        }

        private void nextPresentation()
        {
            isClose = true;

            if (numChange < 4 && listTime[0] > 0)
            {
                switch (numChange)
                {
                    //очеееееень быстро или же так лагает
                    //   /*
                    //pictureBox.Image = StudyOfSubthresholdPerception.Properties.Resources.тв_шум;
                    case 0:
                        Thread.Sleep(listTime[2]);

                        pictureBoxMask.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxMask.Visible = true;
                        }));

                        byte[] byteArray = new byte[0];
                        byteArray = (byte[])Experiment1.table.Rows[m][1];

                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Image = (Image)imageConverter.ConvertFrom(byteArray);
                        }));
                        
                        timer.Period = listTime[0];
                        break;
                    case 1:
                        //--------------загрузка картинки-------
                        ////stopwatch.Start();

                        pictureBoxPresentation.BeginInvoke(new Action(delegate()
                        {
                            pictureBoxPresentation.Visible = true;
                        }));
                        ////stopwatch.Stop();
                        ////Console.WriteLine("Отображение(отрисовка) на экране: {0}", stopwatch.Elapsed);
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
            else if (listTime[0] == 0 && numChange < 2)
            {
                switch (numChange)
                {
                    case 0:

                        byte[] byteArray = new byte[0];
                        byteArray = (byte[])Experiment1.table.Rows[m][1];

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

            //---------------------------------
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
                    labelAnagram.Text = (string)Experiment1.table.Rows[m][2];
                    labelAnagram.Visible = true;
                }));

                textBoxAnswer.BeginInvoke(new Action(delegate()
                    {
                        textBoxAnswer.MaxLength = labelAnagram.Text.Length;
                    }));

                buttonNext.BeginInvoke(new Action(delegate()
                {
                    buttonNext.Enabled = true;
                }));

                isClose = false;

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

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void tabPageEX2_Click(object sender, EventArgs e)
        {

        }

        private void FormExperiment1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClose;
        }
    }
}
