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
        private Results.UsersInfo uInfo;

        public FormResults()
        {
            InitializeComponent();
            uInfo = new Results.UsersInfo(this);
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            uInfo.loadUsers();
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case (int)Tabs.Experiment1:
                        dataGridViewResults1.Rows.Clear();
                        uInfo.getUserInfo(comboBoxUsers.SelectedIndex, dataGridViewResults1, i);
                        break;
                    case (int)Tabs.Experiment5:
                        dataGridViewResults5.Rows.Clear();
                        uInfo.getUserInfo(comboBoxUsers.SelectedIndex, dataGridViewResults5, i);
                        break;
                }
            }
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

        public int tabControlResultsSelectedIndex
        {
            get
            {
                return tabControlResults.SelectedIndex;
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
                switch (tabControlResults.SelectedIndex)
                {
                    case (int)Tabs.Experiment1:
                        new DB().clearTable("ResultOfExperiment1");
                        dataGridViewResults1.Rows.Clear();
                        break;
                }

            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            switch (tabControlResults.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    new SaveTableToFile(dataGridViewResults1);
                    break;
                case (int)Tabs.Experiment5:
                    new SaveTableToFile(dataGridViewResults5);
                    break;
            }
        }
    }
}
