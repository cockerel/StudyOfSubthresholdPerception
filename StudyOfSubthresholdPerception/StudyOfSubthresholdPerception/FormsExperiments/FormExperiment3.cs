﻿using System;
using System.Collections.Generic;
using System.Data;
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
        private List<Experiment3ResultsModel> Results { get; set; }

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
            timer1.Interval = 40;
            var ex3 = new Experiment3DataHelper();
            Settings = ex3.GetSettings();
            Data = ex3.GetSelectedData();
            label4.Visible = false;
            SetWord();
        }

        public void FormExperiment3_Load(object sender, EventArgs e)
        {
            TestExp = true;
            Results = new List<Experiment3ResultsModel>();
            Reset();
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
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
                    ExperimentsCount = ExpCount,
                    Incentive = label3.Text,
                    PresentationTime = timer1.Interval
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
                        ColumnName = "Id"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Ответ"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Предъявление"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Дата"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Количество экспериментов"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Время предъявления"
                    });

                    var ex3 = new Experiment3DataHelper();
                    var db = new DB();
                    foreach (var x in Results)
                    {
                        ex3.AddResult(x, db.ID_USER);
                        table.Rows.Add(new object[]
                            {
                                x.Id, x.Answer, x.Incentive, x.Date.ToShortDateString(), x.ExperimentsCount,
                                x.PresentationTime
                            });
                    }
                    MessageBox.Show("Эксперимент завершен успешно. Просмотреть результаты эксперимента.");
                    var formRes = new FormCurrentResult(table);
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
                        label4.Visible = true;
                        buttonNext.Visible = true;
                    }
                    if (ExpCount <= Settings.ExpCount)
                    {
                        buttonNext.Visible = false;
                        labelNumTest.Text = String.Concat("Опыт ", ExpCount, " из ", Settings.ExpCount);
                        PresCount = 1;
                        labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                        label4.Visible = false;
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
                    ExperimentsCount = ExpCount,
                    Incentive = label3.Text,
                    PresentationTime = timer1.Interval
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
                        ColumnName = "Id"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Ответ"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Предъявление"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Дата"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Количество экспериментов"
                    });

                    table.Columns.Add(new DataColumn
                    {
                        ColumnName = "Время предъявления"
                    });

                    var ex3 = new Experiment3DataHelper();
                    var db = new DB();
                    foreach (var x in Results)
                    {
                        ex3.AddResult(x, db.ID_USER);
                        table.Rows.Add(new object[]
                        {
                            x.Id, x.Answer, x.Incentive, x.Date.ToShortDateString(), x.ExperimentsCount,
                            x.PresentationTime
                        });
                    }
                    MessageBox.Show("Эксперимент завершен успешно. Просмотреть результаты эксперимента.");
                    var formRes = new FormCurrentResult(table);
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
                        label4.Visible = true;
                        buttonNext.Visible = true;
                    }
                    if (ExpCount <= Settings.ExpCount)
                    {
                        buttonNext.Visible = false;
                        labelNumTest.Text = String.Concat("Опыт ", ExpCount, " из ", Settings.ExpCount);
                        PresCount = 1;
                        labelNum.Text = String.Concat("Предъявление ", (PresCount), " из ", Settings.PresCount);
                        label4.Visible = false;
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
                    Step++;
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
                        label4.Visible = false;
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
                label1.Text = Data[Index].FirstAnswer;
                label2.Text = Data[Index].SecondAnswer;
                label3.Text = Data[Index].Text;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                timer1.Start();
            }
            else
            {
                label6.Text = Data[Index].FirstAnswer;
                label7.Text = Data[Index].SecondAnswer;
            }
            Index++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Visible = false;
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
                PresCount = 1;
                label6.Visible = false;
                label7.Visible = false;
                EndTraining();
            }
            else
            {
                labelNumSampleTest.Text = String.Concat("Предъявление ", (PresCount), " из ", 5);
                SetWord();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
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
                SetWord();
            }
        }

        private void FormExperiment3_SizeChanged(object sender, EventArgs e)
        {
            panelMain.Location = new System.Drawing.Point(this.ClientSize.Width / 2 - panelMain.Size.Width / 2,
                this.ClientSize.Height / 2 - panelMain.Size.Height / 2);
        }
    }
}
