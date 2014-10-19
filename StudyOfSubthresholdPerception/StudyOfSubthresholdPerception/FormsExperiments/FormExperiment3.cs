using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DAL.Models.Experiment3;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.Models.Experiment3;

namespace StudyOfSubthresholdPerception.FormsExperiments
{
    public partial class FormExperiment3 : Form
    {
        private int Step { get; set; }
        private Experiment3SettingsModel Settings { get; set; }
        private List<Experiment3SelectedData> Data { get; set; }
        private int ExpCount { get; set; }
        private int PresCount { get; set; }
        private int Index { get; set; }
        private bool TestExp { get; set; }
        private int UserExpCount { get; set; }
        private bool IsFirstLabelRight { get; set; }
        private List<Experiment3ResultsModel> Results { get; set; }
        private int ExSessionCount { get; set; }

        public FormExperiment3()
        {
            InitializeComponent();
            tabControlEx3.SelectTab(tabPage1);
        }

        private void Reset()
        {
            Index = 0;
            PresCount = 1;
            ExpCount = 1;
            var ex3 = new Experiment3DataHelper();
            WordShownFlag = false;
            Settings = ex3.GetSettings();
            timer1.Interval = Settings.Interval;
            timer2.Interval = Settings.Mask == 0 ? 1 : Settings.Mask;
            Data = ex3.GetSelectedData();
            SetWord();
            var db = new DB();
            var prevRes = ex3.GetResults().Where(x => x.UserId == db.ID_USER).ToList();
            if (prevRes.Any())
            {
                prevRes.Sort((x, y) => x.ExperimentsCount.CompareTo(y.ExperimentsCount));
                UserExpCount = prevRes[prevRes.Count - 1].ExperimentsCount;
            }
            UserExpCount++;
            var res = ex3.GetResults();
            if (res != null && res.Any())
            {
                ExSessionCount = res.First().ExperimentsCount + 1;
            }
            else
            {
                ExSessionCount = 1;
            }
            timer3.Interval = Settings.MaskAfter == 0 ? 1 : Settings.MaskAfter;
        }

        public void FormExperiment3_Load(object sender, EventArgs e)
        {
            try
            {
                TestExp = true;
                Results = new List<Experiment3ResultsModel>();
                Reset();
                tabPage2.Enabled = false;
                tabPage3.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка. Проверьте настройки эксперимента.");
                Close();
            }
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            PresCount++;
            if (!TestExp)
            {
                Results.Add(new Experiment3ResultsModel
                {
                    Answer = label1.Text,
                    Date = DateTime.Now,
                    ExperimentsCount = ExSessionCount,
                    Incentive = label3.Text,
                    PresentationTime = timer1.Interval,
                    IsRight = IsFirstLabelRight,
                    Mask = Settings.Mask,
                    MaskAfter = Settings.MaskAfter,
                    AnswerRight = IsFirstLabelRight ? label1.Text : label2.Text
                });
            }
            if (PresCount > Settings.PresCount)
            {
                PresCount = 1;
                ExpCount++;
                if (ExpCount > Settings.ExpCount)
                {
                    var table = new DataTable();

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "№ предъявления"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Время предъявления маски"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Время предъявления подпорогового стимула"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Текущее время"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Подпороговый стимул"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Вариант (совпадающий)"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Выбранный вариант"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Совпадение",
                        DataType = typeof(bool)
                    });

                    var ex3 = new Experiment3DataHelper();
                    var db = new DB();
                    var i = 0;
                    foreach (var x in Results)
                    {
                        i++;
                        ex3.AddResult(x, db.ID_USER);
                        table.Rows.Add(new object[]
                        {
                            i, Settings.Mask, x.PresentationTime, x.Date, x.Incentive, x.AnswerRight, x.Answer, x.IsRight
                        });
                    }
                    MessageBox.Show("Эксперимент завершен успешно. Просмотреть результаты эксперимента.");
                    var formRes = new FormCurrentResult(table);
                    formRes.TopMost = true;
                    formRes.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Опыт завершен. Перейти к следующему опыту.");
                    if (!TestExp)
                    {
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        buttonNext.Visible = true;
                    }
                    if (ExpCount <= Settings.ExpCount)
                    {
                        buttonNext.Visible = false;
                        labelNumTest.Text = String.Concat("Опыт ", ExpCount, " из ", Settings.ExpCount);
                        PresCount = 1;
                        labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                        SetWord();
                    }
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
            if (!TestExp)
            {
                Results.Add(new Experiment3ResultsModel
                {
                    Answer = label2.Text,
                    Date = DateTime.Now,
                    ExperimentsCount = ExSessionCount,
                    Incentive = label3.Text,
                    PresentationTime = timer1.Interval,
                    IsRight = !IsFirstLabelRight,
                    Mask = Settings.Mask,
                    MaskAfter = Settings.MaskAfter,
                    AnswerRight = IsFirstLabelRight ? label1.Text : label2.Text
                });
            }
            if (PresCount > Settings.PresCount)
            {
                PresCount = 1;
                ExpCount++;
                if (ExpCount > Settings.ExpCount)
                {
                    var table = new DataTable();

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "№ предъявления"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Время предъявления маски"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Время предъявления подпорогового стимула"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Текущее время"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Подпороговый стимул"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Вариант (совпадающий)"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Выбранный вариант"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Совпадение",
                        DataType = typeof(bool)
                    });

                    var ex3 = new Experiment3DataHelper();
                    var db = new DB();
                    var i = 0;
                    foreach (var x in Results)
                    {
                        i++;
                        ex3.AddResult(x, db.ID_USER);
                        table.Rows.Add(new object[]
                        {
                            i, Settings.Mask, x.PresentationTime, x.Date, x.Incentive, x.AnswerRight, x.Answer, x.IsRight
                        });
                    }
                    MessageBox.Show("Эксперимент завершен успешно. Просмотреть результаты эксперимента.");
                    var formRes = new FormCurrentResult(table);
                    formRes.TopMost = true;
                    formRes.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Опыт завершен. Перейти к следующему опыту.");
                    if (!TestExp)
                    {
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        buttonNext.Visible = true;
                    }
                    if (ExpCount <= Settings.ExpCount)
                    {
                        buttonNext.Visible = false;
                        labelNumTest.Text = String.Concat("Опыт ", ExpCount, " из ", Settings.ExpCount);
                        PresCount = 1;
                        labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                        SetWord();
                    }
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
                    labelNumSampleTest.Text = String.Concat("Предъявление ", (PresCount), " из ", 5);
                    label6.Visible = false;
                    label7.Visible = false;
                    timer3.Start();
                    Step++;
                    buttonFinish.Enabled = false;
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
                    break;
                case 1:
                    PresCount = 1;
                    labelNumSampleTest.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                    buttonNext.Visible = false;
                    break;
                case 2:
                    if (ExpCount <= Settings.ExpCount)
                    {
                        buttonNext.Visible = false;
                        labelNumTest.Text = String.Concat("Опыт ", ExpCount, " из ", Settings.ExpCount);
                        PresCount = 1;
                        labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                        SetWord();
                    }
                    break;
            }
        }

        private void buttonFinish_Click(object sender, System.EventArgs e)
        {
            EndTraining();
        }

        private void EndTraining()
        {
            MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.StrAttention1);
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
        }

        private void SetWord()
        {
            if (Data.Count == Index)
            {
                Index = 0;
            }
            if (!TestExp)
            {
                var random = new Random();
                int randomNum = random.Next(2);
                if (randomNum == 0)
                {
                    label1.Text = Data[Index].FirstAnswer;
                    label2.Text = Data[Index].SecondAnswer;
                    IsFirstLabelRight = true;
                }
                else
                {
                    label2.Text = Data[Index].FirstAnswer;
                    label1.Text = Data[Index].SecondAnswer;
                    IsFirstLabelRight = false;
                }
                label3.Text = Data[Index].Text;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                timer3.Start();
            }
            Index++;
        }

        private bool IsEndFlag { get; set; }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (IsEndFlag)
            {
                buttonFinish.Enabled = true;
                if (!TestExp)
                {
                    pictureBox3.Visible = false;
                    label3.Visible = false;
                    timer3.Stop();
                    label1.Visible = true;
                    label2.Visible = true;
                    IsEndFlag = false;
                }
                else
                {
                    pictureBox1.Visible = false;
                    timer3.Stop();
                    label6.Visible = true;
                    label7.Visible = true;
                    IsEndFlag = false;
                }
            }
            else
            {
                if (!TestExp)
                {
                    timer2.Start();
                    timer3.Stop();
                    pictureBox3.Visible = true;
                    label3.Visible = true;
                    IsEndFlag = true;
                }
                else
                {
                    timer2.Start();
                    timer3.Stop();
                    pictureBox1.Visible = true;
                    IsEndFlag = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!TestExp)
            {
                label3.Visible = false;
                timer1.Stop();
                WordShownFlag = true;
                if (Settings.Mask > 0)
                {
                    pictureBox3.Visible = true;
                }
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                WordShownFlag = true;
                timer2.Start();
                if (Settings.Mask > 0)
                {
                    pictureBox1.Visible = true;
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            buttonFinish.Enabled = false;
            PresCount++;
            if (PresCount > 5)
            {
                PresCount = 1;
                label6.Visible = false;
                label7.Visible = false;
                EndTraining();
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
                label6.Visible = false;
                label7.Visible = false;
                timer3.Start();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            buttonFinish.Enabled = false;
            PresCount++;
            if (PresCount > 5)
            {
                PresCount = 1;
                label6.Visible = false;
                label7.Visible = false;
                EndTraining();
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
                label6.Visible = false;
                label7.Visible = false;
                timer3.Start();
            }
        }

        private void FormExperiment3_SizeChanged(object sender, EventArgs e)
        {
            panelMain.Location = new System.Drawing.Point(this.ClientSize.Width / 2 - panelMain.Size.Width / 2,
                this.ClientSize.Height / 2 - panelMain.Size.Height / 2);
        }

        private bool WordShownFlag { get; set; }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            timer2.Stop();
            if (!WordShownFlag)
            {
                timer1.Start();
            }
            else
            {
                WordShownFlag = false;
                timer3.Start();
            }
        }
    }
}
