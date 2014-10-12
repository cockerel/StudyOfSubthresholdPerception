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
                        if (comboBoxUsers.SelectedIndex - 1 > -1)
                            results = results.Where(x => x.UserId == comboBoxUsers.SelectedIndex - 1).ToList();
                        for (var count = 0; count < results.Count; count++)
                        {
                            dataGridViewResults2.Rows.Add(new object[]
                            {
                                count+1,
                                uInfo.getUserName(results[count].UserId),
                                results[count].ExperimentsCount,
                                results[count].Mask,
                                results[count].MaskAfter,
                                results[count].PresentationTime,
                                results[count].Date.ToString(CultureInfo.InvariantCulture),
                                results[count].Incentive,
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
