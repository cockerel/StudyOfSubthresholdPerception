using System;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.Models.Experiment3;

namespace StudyOfSubthresholdPerception
{
    public partial class FormAddDataToExperiment3 : Form
    {
        private string pathToImage;
        private FormSetEditor formSetEditor;

        public FormAddDataToExperiment3(FormSetEditor formSetEditor)
        {
            this.formSetEditor = formSetEditor;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var ex3 = new Experiment3DataHelper();
            string und = textBoxEx3Und.Text;
            string word1 = textBoxEx3Down1.Text;
            string word2 = textBoxEx3Down2.Text;
            ex3.AddData(new Experiment3DataModel { FirstAnswer = word1, SecondAnswer = word2, Text = und });
            formSetEditor.Ex3Load();
            textBoxEx3Und.Text = string.Empty;
            textBoxEx3Down1.Text = string.Empty;
            textBoxEx3Down2.Text = string.Empty;
        }
    }
}
