using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;

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
                    case (int)Tabs.Experiment2:
                        dataGridViewResults2.Rows.Clear();
                        var ex3 = new Experiment3DataHelper();
                        var results = ex3.GetResults();
                        var userId = uInfo.getUserId(comboBoxUsers.SelectedIndex);
                        if (userId > -1)
                        {
                            results = results.Where(x => x.UserId == userId).ToList();
                        }
                        for (var count = 0; count < results.Count; count++)
                        {
                            dataGridViewResults2.Rows.Add(new object[]
                            {
                                count+1,
                                results[count].Id,
                                results[count].UserId,
                                uInfo.getUserName(results[count].UserId),
                                results[count].ExperimentsCount,
                                results[count].Mask,
                                results[count].PresentationTime,
                                results[count].Date,
                                results[count].Incentive,
                                results[count].AnswerRight,
                                results[count].Answer,
                                results[count].IsRight
                            });
                        }
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

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            switch (tabControlResults.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    new SaveTableToFile(dataGridViewResults1);
                    break;
                case (int)Tabs.Experiment2:
                    new SaveTableToFile(dataGridViewResults2);
                    break;
                case (int)Tabs.Experiment5:
                    new SaveTableToFile(dataGridViewResults5);
                    break;
            }
        }
    }
}
