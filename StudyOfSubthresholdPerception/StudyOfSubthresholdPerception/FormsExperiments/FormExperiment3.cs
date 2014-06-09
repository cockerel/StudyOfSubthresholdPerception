using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Schema;
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

        public FormExperiment3()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            Index = 0;
            PresCount = 0;
            ExpCount = 0;
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
            Reset();
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            PresCount++;
            if (PresCount > Settings.PresCount)
            {
                PresCount = 0;
                ExpCount++;
                if (!TestExp)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = true;
                    buttonNext.Visible = true;
                }
            }
            else
            {
                SetWord();
            }
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            PresCount++;
            if (PresCount > Settings.PresCount)
            {
                PresCount = 0;
                ExpCount++;
                if (!TestExp)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = true;
                    buttonNext.Visible = true;
                }
            }
            else
            {
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

                    Step++;
                    break;
                case 1:
                    break;
                case 2:
                    if (ExpCount > Settings.ExpCount)
                    {
                        var formRes = new FormResults();
                        formRes.Show();
                    }
                    else
                    {
                        label4.Visible = false;
                        SetWord();
                    }
                    break;
            }
        }

        private void buttonFinish_Click(object sender, System.EventArgs e)
        {
            Reset();
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
            if (PresCount > Settings.PresCount)
            {
                PresCount = 0;
                label6.Visible = false;
                label7.Visible = false;
                label5.Visible = true;
            }
            else
            {
                SetWord();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            PresCount++;
            if (PresCount > Settings.PresCount)
            {
                PresCount = 0;
                label6.Visible = false;
                label7.Visible = false;
                label5.Visible = true;
            }
            else
            {
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
