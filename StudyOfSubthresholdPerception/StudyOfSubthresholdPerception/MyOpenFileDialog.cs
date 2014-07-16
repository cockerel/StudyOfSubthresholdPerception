using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception
{
    class MyOpenFileDialog
    {
        private OpenFileDialog openFile = new OpenFileDialog();
        private static bool cheakCancel = false;

        public void SelectAnImage() {
            openFile.Filter = "Точечные рисунки (*.bmp)|*.bmp|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|All files (*.*)|*.*";
            openFile.FilterIndex = 4;
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                cheakCancel = true;
            }
            else
            {
                cheakCancel = false;
            }
        }

        public String getPathToFile
        {
            get 
            {
                return openFile.FileName;
            }
        }

        public Boolean getCheck
        {
            get
            {
                return cheakCancel;
            }
        }

    }
}
