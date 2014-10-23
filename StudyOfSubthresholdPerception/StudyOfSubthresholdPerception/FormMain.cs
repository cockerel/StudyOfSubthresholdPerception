using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.FormsExperiments;

namespace StudyOfSubthresholdPerception
{
    public partial class FormMain : Form
    {
        //private bool p; //true - админ

        public FormMain(bool p)
        {
            InitializeComponent();
            //this.p = p;
            if (p == true) //true - админ
            {
                groupBox1.Visible = true;
            }
            else 
            {
                groupBox2.Location = new Point(12, 12);
                groupBox3.Location = new Point(12, 120);
                this.Size = new Size(640, 260);
            }
        }

        private void buttonSetEditor_Click(object sender, EventArgs e)
        {
            new FormSetEditor().ShowDialog();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            new FormSetting().ShowDialog();
        }

        private void buttonExperiment1_Click(object sender, EventArgs e)
        {
            new FormExperiment1().ShowDialog();
        }

        private void buttonCalibration_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormResults().ShowDialog();
        }

        private void toolStripMenuItemChangePass_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExperiment5_Click(object sender, EventArgs e)
        {
            new FormExperiment5().ShowDialog();
        }

        private void buttonExperiment2_Click(object sender, EventArgs e)
        {
            new FormExperiment2().ShowDialog();
        }

        private void buttonExperiment4_Click(object sender, EventArgs e)
        {
            new FormExperiment4().ShowDialog();
        }

		private void buttonExperiment3_Click(object sender, EventArgs e)
		{
			new FormExperiment3().ShowDialog();
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.buttonExperiment1.Enabled = false;
            this.buttonExperiment2.Enabled = false;
            this.buttonExperiment3.Enabled = false;
            this.buttonExperiment4.Enabled = false;
            this.buttonExperiment5.Enabled = false;
            this.button3.Enabled = false;
            this.buttonSetEditor.Enabled = false;
            this.buttonSetting.Enabled = false;
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Enabled = false;
            var ex3 = new Experiment3DataHelper();
            ex3.GetSettings();
            this.buttonExperiment1.Enabled = true;
            this.buttonExperiment2.Enabled = true;
            this.buttonExperiment3.Enabled = true;
            this.buttonExperiment4.Enabled = true;
            this.buttonExperiment5.Enabled = true;
            this.button3.Enabled = true;
            this.buttonSetEditor.Enabled = true;
            this.buttonSetting.Enabled = true;
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Enabled = true;
            timer1.Enabled = false;
        }
    }
}
