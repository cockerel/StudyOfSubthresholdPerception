using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.Models.Experiment2;

namespace StudyOfSubthresholdPerception.FormsExperiments
{
    public partial class FormExperiment2 : Form
    {
        private int Step { get; set; }
        private Experiment2SettingsModel Settings { get; set; }
        private List<Experiment2DataModel> Data { get; set; }
        private int ExpCount { get; set; }
        private int PresCount { get; set; }
        private int Index { get; set; }
        private bool TestExp { get; set; }

        public FormExperiment2()
        {
            InitializeComponent();
            tabControlEx3.SelectTab(tabPage1);
        }

        private void Reset()
        {
            Index = 0;
            PresCount = 1;
            ExpCount = 1;
            var ex2 = new Experiment2DataHelper();
            Settings = ex2.GetSettings();
            Data = ex2.GetData();
            if (Settings.ExpCount <= 0 || Settings.PresCount <= 0 || Data.Count == 0)
            {
                MessageBox.Show("Произошла ошибка. Проверьте настройки эксперимента");
                Close();
            }
            timer1.Interval = Settings.Interval == 0 ? 40 : Settings.Interval;
            pictureBox2.Visible = true;
            SetWord();
        }

        public void FormExperiment2_Load(object sender, EventArgs e)
        {
            TestExp = true;
            Reset();
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            PresCount++;
            if (PresCount > Settings.PresCount)
            {
                if (ExpCount > Settings.ExpCount)
                {
                    MessageBox.Show("Эксперимент завершен успешно. Просмотреть результаты эксперимента.");
                    var formRes = new FormCurrentResult(new DataTable());
                    formRes.Show();
                    Close();
                }
                else
                {
                    labelNumTest.Text = String.Concat("Опыт ", ExpCount, " из ", Settings.ExpCount);
                    pictureBox2.Visible = true;
                    PresCount = 1;
                    ExpCount++;
                    labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                    if (!TestExp)
                    {
                        label1.Visible = false;
                        label2.Visible = false;
                        pictureBox2.Visible = false;
                        MessageBox.Show("Опыт завершен. Перейти к следующему опыту.");
                    }
                    SetWord();
                }
            }
            else
            {
                labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                SetWord();
            }
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            PresCount++;
            if (PresCount > Settings.PresCount)
            {
                if (ExpCount > Settings.ExpCount)
                {
                    MessageBox.Show("Эксперимент завершен успешно. Просмотреть результаты эксперимента.");
                    var formRes = new FormCurrentResult(new DataTable());
                    formRes.Show();
                    Close();
                }
                else
                {
                    labelNumTest.Text = String.Concat("Опыт ", ExpCount, " из ", Settings.ExpCount);
                    pictureBox2.Visible = true;
                    PresCount = 1;
                    ExpCount++;
                    labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                    if (!TestExp)
                    {
                        label1.Visible = false;
                        label2.Visible = false;
                        pictureBox2.Visible = false;
                        MessageBox.Show("Опыт завершен. Перейти к следующему опыту.");
                    }
                    SetWord();
                }
            }
            else
            {
                labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                SetWord();
            }
        }

        private void buttonNext_Click(object sender, System.EventArgs e)
        {
            switch (Step)
            {
                case 0:
                    tabPage2.Enabled = true;
                    tabPage3.Enabled = false;
                    tabControlEx3.SelectTab(tabPage2);
                    buttonFinish.Visible = true;
                    buttonNext.Visible = false;
                    labelNumSampleTest.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                    Step++;
                    break;
                case 1:
                    PresCount = 0;
                    labelNumSampleTest.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                    break;
                case 2:

                    break;
            }
        }

        private void buttonFinish_Click(object sender, System.EventArgs e)
        {
            EndTest();
        }

        private void EndTest()
        {
            Reset();
            labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
            labelNumTest.Text = String.Concat("Опыт ", ExpCount, " из ", Settings.ExpCount);
            tabControlEx3.SelectTab(tabPage3);
            TestExp = false;
            buttonFinish.Visible = false;
            buttonNext.Visible = false;
            Step = 2;
            SetWord();
            tabPage2.Enabled = false;
            tabPage3.Enabled = true;
            MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.StrAttention1);
        }

        private void SetWord()
        {
            if (Data.Count == Index)
            {
                Index = 0;
            }
            if (!TestExp)
            {
                label1.Text = Data[Index].FirstAnswer;
                label2.Text = Data[Index].SecondAnswer;
                using (var img = new MemoryStream(Data[Index].Image))
                using (var uimg = new MemoryStream(Data[Index].UnderImage))
                {
                    pictureBox2.Image = Image.FromStream(img);
                    pictureBox3.Image = Image.FromStream(uimg);
                }
                pictureBox3.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                timer1.Start();
            }
            Index++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            timer1.Stop();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            PresCount++;
            if (PresCount > 5)
            {
                PresCount = 0;
                label6.Visible = false;
                label7.Visible = false;
                pictureBox1.Visible = false;
                EndTest();
            }
            else
            {
                labelNumSampleTest.Text = String.Concat("Предъявление ", (PresCount), " из ", 5);
                switch (PresCount)
                {
                    case 1:
                        label6.Text = "Печь";
                        label7.Text = "Медведь";
                        break;
                    case 2:
                        label6.Text = "Мопед";
                        label7.Text = "Стол";
                        break;
                    case 3:
                        label6.Text = "Баян";
                        label7.Text = "Ондатра";
                        break;
                    case 4:
                        label6.Text = "Сырок";
                        label7.Text = "Тазик";
                        break;
                    case 5:
                        label6.Text = "Мороз";
                        label7.Text = "Табуретка";
                        break;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            PresCount++;
            if (PresCount > 5)
            {
                PresCount = 0;
                label6.Visible = false;
                label7.Visible = false;
                pictureBox1.Visible = false;
                EndTest();
            }
            else
            {
                labelNumSampleTest.Text = String.Concat("Предъявление ", (PresCount), " из ", 5);
                switch (PresCount)
                {
                    case 1:
                         label6.Text = "Печь";
                         label7.Text = "Медведь";
                        break;
                    case 2:
                        label6.Text = "Мопед";
                        label7.Text = "Стол";
                        break;
                    case 3:
                        label6.Text = "Баян";
                        label7.Text = "Ондатра";
                        break;
                    case 4:
                        label6.Text = "Сырок";
                        label7.Text = "Тазик";
                        break;
                    case 5:
                        label6.Text = "Мороз";
                        label7.Text = "Табуретка";
                        break;
                }
            }
        }

        private void FormExperiment2_SizeChanged(object sender, EventArgs e)
        {
            panelMain.Location = new System.Drawing.Point(this.ClientSize.Width / 2 - panelMain.Size.Width / 2,
                this.ClientSize.Height / 2 - panelMain.Size.Height / 2);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
