using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception
{
    public partial class FormCurrentResult : Form
    {
        public FormCurrentResult(DataTable table)
        {
            InitializeComponent();
            dataGridViewResult.DataSource = table.DefaultView;

            foreach (DataGridViewRow row in dataGridViewResult.Rows)
            {
                dataGridViewResult.Rows[row.Index].Cells[0].Value = (row.Index + 1).ToString();
            }
            dataGridViewResult.Update();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            new SaveTableToFile(dataGridViewResult);
        }

        private void FormCurrentResult_Load(object sender, EventArgs e)
        {

        }
    }
}
