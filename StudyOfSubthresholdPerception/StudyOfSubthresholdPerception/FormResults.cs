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
        private enum Tabs { Experiment1, Experiment2, Experiment3, Experiment4, Experiment5 };
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
            switch (tabControlResults.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    new SaveTableToFile(dataGridViewResults1);
                    break;
            }
        }
    }
}
