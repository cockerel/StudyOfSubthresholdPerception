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

        public void SelectAnImage() {
            openFile.Filter = "Точечные рисунки (*.bmp)|*.bmp|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|All files (*.*)|*.*";
            openFile.FilterIndex = 4;
            openFile.ShowDialog();
        }

        public String getPathToFile
        {
            get 
            {
                return openFile.FileName;
            }
        }
    }
}
