using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.SettingsExperiments
{
    class RemoveRowFromTableSettings
    {
        public void removeRow(DataGridView dgView)
        {
            if (dgView.Rows.Count > 0)
            {
                dgView.Rows.RemoveAt(dgView.CurrentRow.Index);
                foreach (DataGridViewRow row in dgView.Rows)
                {
                    row.Cells[0].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Таблица пустая!");
            }
        }
    }
}
