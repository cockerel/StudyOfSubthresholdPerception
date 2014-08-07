using System;
using System.IO;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.FormsAddData;
using StudyOfSubthresholdPerception.Models.Experiment3;

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
                case (int)Tabs.Experiment2:
                    var ex3 = new FormAddDataToExperiment3(this).ShowDialog();
                    break;
                case (int)Tabs.Experiment3:
                    var ex2 = new FormAddDataToExperiment2(this).ShowDialog();
                    break;
                case (int)Tabs.Experiment4:
                    new FormAddDataToExperiment4(this).ShowDialog();
                    break;
                case (int)Tabs.Experiment5:
                    new FormAddDataToExperiment5(this).ShowDialog();
                    break;
            }
        }

        public void Ex3Load()
        {
            var ex3 = new Experiment3DataHelper();
            var data = ex3.GetData();
            dataGridViewEx3.Rows.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                dataGridViewEx3.Rows.Add(i + 1, data[i].Id, data[i].FirstAnswer, data[i].SecondAnswer);
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
                    Ex3Load();
                    break;
                case (int)Tabs.Experiment3:
                    Exp2Load();
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
            model.Sort((first, second) => first.Id.CompareTo(second.Id));
            for (int i = 0; i < model.Count; i++)
            {
                dataGridViewExperiment4.Rows.Add(new object[] { i + 1, model[i].Id, model[i].Img });
            }
        }

        public void Exp2Load()
        {
            dataGridView1.Rows.Clear();
            var ex2 = new Experiment2DataHelper();
            var model = ex2.GetData();
            model.Sort((first, second) => first.Id.CompareTo(second.Id));
            for (int i = 0; i < model.Count; i++)
            {
                using (var img = new MemoryStream(model[i].Image))
                using (var uimg = new MemoryStream(model[i].UnderImage))
                {
                    dataGridView1.Rows.Add(new object[] { i + 1, model[i].Id, System.Drawing.Image.FromStream(img), System.Drawing.Image.FromStream(uimg), model[i].FirstAnswer, model[i].SecondAnswer });
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    new SetEditor.Experiment1().deleteRow(dataGridViewExperiment1);
                    break;
                case (int)Tabs.Experiment2:
                    if (dataGridViewEx3.SelectedRows.Count > 0)
                    {
                        var id = (int)dataGridViewEx3.SelectedRows[0].Cells[1].Value;
                        var ex3 = new Experiment3DataHelper();
                        ex3.RemoveData(id);
                        var data = ex3.GetData();
                        dataGridViewEx3.Rows.Clear();
                        for (int i = 0; i < data.Count; i++)
                        {
                            dataGridViewEx3.Rows.Add(i + 1, data[i].Id, data[i].FirstAnswer, data[i].SecondAnswer);
                        }
                    }
                    break;
                case (int)Tabs.Experiment3:
                    var ex2 = new Experiment4DataHelper();
                    if (dataGridViewExperiment4.SelectedRows.Count > 0)
                    {
                        var id = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                        Exp4Load();
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
