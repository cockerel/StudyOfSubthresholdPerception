using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.FormsExperiments
{
    public partial class FormExperiment3 : Form
    {
        private int Step { get; set; }
        public FormExperiment3()
        {
            InitializeComponent();
	        timer1.Interval = 20;
        }

		private void label2_Click(object sender, System.EventArgs e)
		{
			
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
		    MessageBox.Show("fdfd");
		}

        private void buttonNext_Click(object sender, System.EventArgs e)
        {
            switch (Step)
            {
                case 0:
                    tabControlEx3.SelectTab(tabPage2);
                    buttonFinish.Visible = true;
                    buttonNext.Visible = false;
                    Step++;
                    break;
                case 1:
                    break;
                case 2:
                   break;
            }
        }

        private void buttonFinish_Click(object sender, System.EventArgs e)
        {
            tabControlEx3.SelectTab(tabPage2);
            buttonFinish.Visible = false;
            buttonNext.Visible = false;
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click_1(object sender, System.EventArgs e)
        {

        }

        private void SetWord()
        {
            
        }
    }
}
