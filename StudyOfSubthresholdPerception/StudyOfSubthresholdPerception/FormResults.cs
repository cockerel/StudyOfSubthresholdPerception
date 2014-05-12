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
    public partial class FormResults : Form
    {
        private Results.Experiment1 exp1;

        public FormResults()
        {
            InitializeComponent();
            exp1 = new Results.Experiment1(this);
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            exp1.loadUsers();
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewResults1.Rows.Clear();
            exp1.getUserInfo(comboBoxUsers.SelectedIndex);
        }

        //-----get and set-----
        public ComboBox ComboBoxUsers
        {
            get 
            {
                return comboBoxUsers;
            }
        }

        public Label LabelUserInfo
        {
            get
            {
                return labelUserInfo;
            }
        }

        public DataGridView DataGridViewResults1
        {
            get
            {
                return dataGridViewResults1;
            }
        }

        private void buttonClearTable_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show("Вы желаете очистить таблицу?", StudyOfSubthresholdPerception.Properties.Resources.StrWarningTitle, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                new DB().clearTable("ResultOfExperiment1");
                dataGridViewResults1.Rows.Clear();
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
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
            foreach (DataGridViewColumn column in dataGridViewResults1.Columns)
            {
                if (!firstHeader) sw.Write(";");
                sw.Write(column.HeaderText.ToString());
                firstHeader = false;
            }
            sw.WriteLine();

            foreach (DataGridViewRow row in dataGridViewResults1.Rows) //запись
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
