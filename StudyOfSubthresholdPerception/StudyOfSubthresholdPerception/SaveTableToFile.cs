using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception
{
    class SaveTableToFile
    {
        public SaveTableToFile(DataGridView dataGridView)
        {
            // диалоговое окно
            var save = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "bin",
                Filter = @"Текстовые файлы (*.txt)|*.txt|CSV-файл (*.csv)|*.csv|Bin-файл (*.bin)|*.bin",
                FilterIndex = 2,
                RestoreDirectory = true

            };

            if (save.ShowDialog() != DialogResult.OK) return;
            var sw = new StreamWriter(save.FileName, true, Encoding.UTF8);

            var firstHeader = true;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (!firstHeader) sw.Write(";");
                sw.Write(column.HeaderText.ToString());
                firstHeader = false;
            }
            sw.WriteLine();

            foreach (DataGridViewRow row in dataGridView.Rows) //запись
                if (!row.IsNewRow)
                {
                    var first = true;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!first) sw.Write(";");
                        sw.Write(cell.Value.ToString());
                        first = false;
                    }
                    sw.WriteLine();
                }
            sw.Close();
        }
    }
}
