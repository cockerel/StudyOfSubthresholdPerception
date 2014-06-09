using System;
using System.Drawing;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;

namespace StudyOfSubthresholdPerception.FormsAddData
{
    public partial class FormAddDataToExperiment4 : Form
    {
        private Image _img;
        private FormSetEditor _editor;
        public FormAddDataToExperiment4(FormSetEditor editor)
        {
            _editor = editor;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = _img;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ex4 = new Experiment4DataHelper();
            ex4.AddImage(_img);
            _editor.Exp4Load();
        }
    }
}
