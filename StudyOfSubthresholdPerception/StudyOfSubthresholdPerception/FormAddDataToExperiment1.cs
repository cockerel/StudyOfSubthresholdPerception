using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace StudyOfSubthresholdPerception
{
    public partial class FormAddDataToExperiment1 : Form
    {
        private String pathToImage;
        private FormSetEditor formSetEditor;

        public FormAddDataToExperiment1(FormSetEditor formSetEditor)
        {
            this.formSetEditor = formSetEditor;
            InitializeComponent();
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialogSelectImage.Filter = "Точечные рисунки (*.bmp)|*.bmp|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|All files (*.*)|*.*";
            openFileDialogSelectImage.FilterIndex = 4;
            openFileDialogSelectImage.ShowDialog();
        }

        private void openFileDialogSelectImage_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                pathToImage = openFileDialogSelectImage.FileName;
                pictureBox.Load(pathToImage);
            }
            catch
            {
                MessageBox.Show("Выбран неверный файл!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && textBoxAnagram.Text != ""
                && textBoxAnswer1.Text != "" && textBoxAnswer2.Text != "")
            {
                string query = "INSERT INTO Experiment1 (Image, Anagram, Answer1, Answer2) VALUES (@img, @anagram, @answ1, @answ2)";

                using (SqlCeConnection sc = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    byte[] data;

                    try
                    {
                        data = System.IO.File.ReadAllBytes(pathToImage);
                        SqlCeCommand cmd = new SqlCeCommand(query, sc);
                        cmd.Parameters.AddWithValue("@img", data);
                        cmd.Parameters.AddWithValue("@anagram", textBoxAnagram.Text);
                        cmd.Parameters.AddWithValue("@answ1", textBoxAnswer1.Text);
                        cmd.Parameters.AddWithValue("@answ2", textBoxAnswer2.Text);
                        if (sc.State == ConnectionState.Closed)
                            sc.Open();
                        cmd.ExecuteNonQuery();
                        sc.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    finally
                    {
                        pictureBox.Image = null;
                        textBoxAnagram.Clear();
                        textBoxAnswer1.Clear();
                        textBoxAnswer2.Clear();
                        //formSetEditor.loadDataExperiment1();
                        new SetEditor.Experiment1().loadData(formSetEditor.DataGridViewExperiment1);
                        //FormSetEditor.loadDataExperiment1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            
        }
    }
}
