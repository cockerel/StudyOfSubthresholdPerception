using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                groupBox1.Enabled = true;
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
    }
}
