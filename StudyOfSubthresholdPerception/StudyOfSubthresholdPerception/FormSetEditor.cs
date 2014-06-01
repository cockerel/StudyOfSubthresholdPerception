using System;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.FormsAddData;

namespace StudyOfSubthresholdPerception
{
    public partial class FormSetEditor : Form
    {
        private enum Tabs { Experiment1, Experiment2, Experiment3, Experiment4, Experiment5 };

        public FormSetEditor()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    new FormAddDataToExperiment1(this).ShowDialog();
                    break;
                case (int)Tabs.Experiment4:
                    new FormAddDataToExperiment4(this).ShowDialog();
                    break;
                case (int)Tabs.Experiment5:
                    new FormAddDataToExperiment5(this).ShowDialog();
                    break;
            }
        }

        private void FormSetEditor_Load(object sender, EventArgs e)
        {
            new SetEditor.Experiment1().loadData(dataGridViewExperiment1);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    break;
                case (int)Tabs.Experiment2:
                    break;
                case (int)Tabs.Experiment3:
                    break;
                case (int)Tabs.Experiment4:
                    Exp4Load();
                    break;
                case (int)Tabs.Experiment5:
                    new SetEditor.Experiment5().loadData(dataGridViewExperiment5);
                    break;
            }
        }

        public void Exp4Load()
        {
            dataGridViewExperiment4.Rows.Clear();
            var ex4 = new Experiment4DataHelper();
            var model = ex4.GetAll();
            model.Sort((first, second)=>first.Id.CompareTo(second.Id));
            for (int i = 0; i < model.Count; i++)
            {
                dataGridViewExperiment4.Rows.Add(new object[] { i + 1, model[i].Id, model[i].Img });
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    new SetEditor.Experiment1().deleteRow(dataGridViewExperiment1);
                    break;
                case (int)Tabs.Experiment4:
                    var ex4 = new Experiment4DataHelper();
                    if (dataGridViewExperiment4.SelectedRows.Count > 0)
                    {
                        var id = (int)dataGridViewExperiment4.SelectedRows[0].Cells[1].Value;
                        ex4.RemoveImage(id);
                        Exp4Load();
                    }
                    break;
                case (int)Tabs.Experiment5:
                    new SetEditor.Experiment5().deleteRow(dataGridViewExperiment5);
                    break;
            }


        }

        public DataGridView DataGridViewExperiment1
        {
            get
            {
                return dataGridViewExperiment1;
            }
        }

        public DataGridView DataGridViewExperiment5
        {
            get
            {
                return dataGridViewExperiment5;
            }
        }
    }
}
