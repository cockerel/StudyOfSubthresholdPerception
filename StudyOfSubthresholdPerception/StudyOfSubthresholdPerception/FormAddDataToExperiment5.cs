using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception
{
    public partial class FormAddDataToExperiment5 : Form
    {
        //private const String messageWrongFile = "Выбран неверный файл!";
        private FormSetEditor formSetEditor;
        private MyOpenFileDialog openFile = new MyOpenFileDialog();

        public FormAddDataToExperiment5()
        {
            InitializeComponent();
        }

        public FormAddDataToExperiment5(FormSetEditor formSetEditor)
        {
            InitializeComponent();
            this.formSetEditor = formSetEditor;
        }

        private void buttonAddNeutral_Click(object sender, EventArgs e)
        {
            openFile.SelectAnImage();
            try
            {
                pictureBoxNeutral.Load(openFile.getPathToFile);
            }
            catch
            {
                MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.MessageWrongFile);
            }
            
        }

        private void buttonAddPositive_Click(object sender, EventArgs e)
        {
            openFile.SelectAnImage();
            try 
            { 
                pictureBoxPositive.Load(openFile.getPathToFile);
            }
            catch
            {
                MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.MessageWrongFile);
            }
        }

        private void buttonAddNegative_Click(object sender, EventArgs e)
        {
            openFile.SelectAnImage();
            try 
            { 
                pictureBoxNegative.Load(openFile.getPathToFile);
            }
            catch
            {
                MessageBox.Show(StudyOfSubthresholdPerception.Properties.Resources.MessageWrongFile);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxNeutral.Image != null && pictureBoxPositive.Image != null
                && pictureBoxNegative.Image != null)
            {
                string query = "INSERT INTO Experiment5 (Image_neutral, Image_positive, Image_negative) VALUES (@img1, @img2, @img3)";

                using (SqlCeConnection sc = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    try
                    {
                        SqlCeCommand cmd = new SqlCeCommand(query, sc);
                        cmd.Parameters.AddWithValue("@img1", imageToByteArray(pictureBoxNeutral.Image));
                        cmd.Parameters.AddWithValue("@img2", imageToByteArray(pictureBoxPositive.Image));
                        cmd.Parameters.AddWithValue("@img3", imageToByteArray(pictureBoxNegative.Image));
                        if (sc.State == ConnectionState.Closed)
                            sc.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    finally
                    {
                        sc.Close();
                        pictureBoxNeutral.Image = null;
                        pictureBoxPositive.Image = null;
                        pictureBoxNegative.Image = null;
                        new SetEditor.Experiment5().loadData(formSetEditor.DataGridViewExperiment5);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выбраны не все предъявления!");
            }

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            //===!!!===---желательно исправить чтобы сохраняли в формат исходного файла
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
