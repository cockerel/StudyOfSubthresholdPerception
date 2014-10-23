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
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void ScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
