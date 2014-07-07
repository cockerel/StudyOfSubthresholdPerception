using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.Models.Experiment2;

namespace StudyOfSubthresholdPerception.FormsAddData
{
    public partial class FormAddDataToExperiment2 : Form
    {
        private Image _img;
        private Image _uimg;
        private FormSetEditor _editor;
        public FormAddDataToExperiment2(FormSetEditor editor)
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
            var ex2 = new Experiment2DataHelper();
            using (var img = new MemoryStream())
            using (var uimg = new MemoryStream())
            {
                _img.Save(img, _img.RawFormat);
                _uimg.Save(uimg, _img.RawFormat);
                ex2.AddData(new Experiment2DataModel { FirstAnswer = FirstAnswerTextBox.Text, SecondAnswer = SecondAnswerTextBox.Text, Id = 0, Image = img.ToArray(), UnderImage = uimg.ToArray() });
                _editor.Exp2Load();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _uimg = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.Image = _uimg;
            }
        }
    }
}
