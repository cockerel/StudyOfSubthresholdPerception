using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using StudyOfSubthresholdPerception.DataHelpers;
using StudyOfSubthresholdPerception.Models.Experiment2;
using StudyOfSubthresholdPerception.Models.Experiment3;
using StudyOfSubthresholdPerception.Models.Experiment4;
using StudyOfSubthresholdPerception.Properties;
using StudyOfSubthresholdPerception.SettingsExperiments;

namespace StudyOfSubthresholdPerception
{
    public partial class FormSetting : Form
    {
        private enum Tabs { Experiment1, Experiment2, Experiment3, Experiment4, Experiment5, GeneralSettings };
        private SettingExperiment1 settingExperiment1;
        private SettingExperiment5 settingExperiment5;

        public FormSetting()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            object[] values = new object[6];

            foreach (DataGridViewColumn column in dataGridViewExperiment1.Columns)
            {
                values[column.Index] = dataGridViewExperiment1[column.Index, dataGridViewExperiment1.CurrentRow.Index].Value;
            }
            /*
            foreach (DataGridViewRow row in dataGridViewExpSetting1.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
             */
            values[0] = dataGridViewExpSetting1.Rows.Count + 1;
            dataGridViewExpSetting1.Rows.Add(values);
        }

        private void FormSetEditor_Load(object sender, EventArgs e)
        {
            new SetEditor.Experiment1().loadData(dataGridViewExperiment1);
            settingExperiment1 = new SettingExperiment1(this);
            settingExperiment1.loadData();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (textBoxEx2Exp.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    break;
                case (int)Tabs.Experiment2:
                    LoadEx3();
                    LoadEx3Setings();
                    break;
                case (int)Tabs.Experiment3:
                    LoadEx2();
                    LoadEx2Setings();
                    break;
                case (int)Tabs.Experiment4:
                    var ex4 = new Experiment4DataHelper();
                    try
                    {
                        var settings = ex4.GetSettings();
                        if (settings != null)
                        {
                            textBoxEx4CirclePeriod.Text = settings.CirclePeriod.ToString(CultureInfo.InvariantCulture);
                            textBoxEx4PointPeriod.Text = settings.PointPeriod.ToString(CultureInfo.InvariantCulture);
                            textBoxEx4ExpCount.Text = settings.Experiments.ToString(CultureInfo.InvariantCulture);
                            textBoxEx4PresCount.Text = settings.Presentations.ToString(CultureInfo.InvariantCulture);
                            textBoxEx4PresCount.Text = settings.UnderTime.ToString(CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            var zeroString = 0.ToString(CultureInfo.InvariantCulture);
                            textBoxEx4CirclePeriod.Text = zeroString;
                            textBoxEx4PointPeriod.Text = zeroString;
                            textBoxEx4ExpCount.Text = zeroString;
                            textBoxEx4PresCount.Text = Resources.DefaultUnderTime;
                        }
                        var model = ex4.GetAll();
                        for (int i = 0; i < model.Count; i++)
                        {
                            dataGridViewEx4Img1.Rows.Add(i + 1, model[i].Id, model[i].Img);
                            dataGridViewEx4Img2.Rows.Add(i + 1, model[i].Id, model[i].Img);
                        }
                        var data = ex4.GetData();
                        for (int i = 0; i < data.Count; i++)
                        {
                            string typeStr = null;
                            switch (data[i].Type)
                            {
                                case (int)PairTypes.TruePair:
                                    typeStr = Resources.textTruePair;
                                    break;
                                case (int)PairTypes.FalsePair:
                                    typeStr = Resources.textFalsePair;
                                    break;
                                case (int)PairTypes.UnderPair:
                                    typeStr = Resources.textUnderPair;
                                    break;
                            }
                            dataGridViewEx4Pairs.Rows.Add(i + 1, data[i].Id, ex4.GetImageById(data[i].Id1).Img, ex4.GetImageById(data[i].Id2).Img, typeStr ?? string.Empty);
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    break;
                case (int)Tabs.Experiment5:
                    new SetEditor.Experiment5().loadData(dataGridViewExperiment5);
                    settingExperiment5 = new SettingExperiment5(this);
                    settingExperiment5.loadData();
                    break;
                case (int)Tabs.GeneralSettings:
                    List<string> listTime = new DB().getTimeMaskAndPresent();
                    textBoxTimeMask1.Text = listTime[0];
                    textBoxTimePresent1.Text = listTime[1];
                    textBoxTimeMask2.Text = listTime[2];
                    textBoxTimePresent2.Text = listTime[3];
                    textBoxTimeMask3.Text = listTime[4];
                    textBoxTimePresent3.Text = listTime[5];
                    textBoxTimeMask4.Text = 0.ToString(CultureInfo.InvariantCulture);
                    textBoxTimeMask4.Enabled = false;
                    textBoxTimePresent4.Text = listTime[7];
                    textBoxTimeMask5.Text = listTime[8];
                    textBoxTimePresent5.Text = listTime[9];
                    textBoxSleep1.Text = listTime[10];
                    textBoxSleep2.Text = listTime[11];
                    textBoxSleep3.Text = listTime[12];
                    textBoxSleep4.Text = 0.ToString(CultureInfo.InvariantCulture);
                    textBoxSleep4.Enabled = false;
                    textBoxSleep5.Text = listTime[14];
                    break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (textBoxEx2Exp.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    new RemoveRowFromTableSettings().removeRow(dataGridViewExpSetting1);
                    break;
                case (int)Tabs.Experiment5:
                    new RemoveRowFromTableSettings().removeRow(dataGridViewExpSetting5);
                    break;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            switch (textBoxEx2Exp.SelectedIndex)
            {
                case (int)Tabs.Experiment1:
                    settingExperiment1.saveData();
                    break;
                case (int)Tabs.Experiment5:
                    settingExperiment5.saveData();
                    break;
            }

        }

        private void textBoxesInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBoxesPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 97 || e.KeyChar > 122)
                && (e.KeyChar < 'а' || e.KeyChar > 'ё'))
                e.Handled = true;
        }

        //---get and set---
        public DataGridView DataGridViewExpSetting1
        {
            get
            {
                return dataGridViewExpSetting1;
            }
        }

        public DataGridView DataGridViewExpSetting5
        {
            get
            {
                return dataGridViewExpSetting5;
            }
        }

        public TextBox TextBoxNumOfExp
        {
            get
            {
                return textBoxNumOfExp;
            }
        }

        public TextBox TextBoxNumOfPresent
        {
            get
            {
                return textBoxNumOfPresent;
            }
        }

        public TextBox TextBoxNumOfExp5
        {
            get
            {
                return textBoxNumOfExp5;
            }
        }

        public TextBox TextBoxNumOfPresent5
        {
            get
            {
                return textBoxNumOfPresent5;
            }
        }
        //--------------------------

        private void buttonSaveGeneralSettings_Click(object sender, EventArgs e)
        {
            if (textBoxTimeMask1.Text != String.Empty && textBoxTimeMask2.Text != String.Empty &&
                textBoxTimeMask3.Text != String.Empty && textBoxTimeMask4.Text != String.Empty &&
                textBoxTimeMask5.Text != String.Empty &&
                textBoxTimePresent1.Text != String.Empty && textBoxTimePresent2.Text != String.Empty &&
                textBoxTimePresent3.Text != String.Empty && textBoxTimePresent4.Text != String.Empty &&
                textBoxTimePresent5.Text != String.Empty && textBoxSleep1.Text != String.Empty &&
                textBoxSleep2.Text != String.Empty && textBoxSleep3.Text != String.Empty &&
                textBoxSleep3.Text != String.Empty && textBoxSleep5.Text != String.Empty)
            {
                List<int> listTime = new List<int>(15);

                listTime.Add(int.Parse(textBoxTimeMask1.Text));
                listTime.Add(int.Parse(textBoxTimePresent1.Text));
                listTime.Add(int.Parse(textBoxTimeMask2.Text));
                listTime.Add(int.Parse(textBoxTimePresent2.Text));
                listTime.Add(int.Parse(textBoxTimeMask3.Text));
                listTime.Add(int.Parse(textBoxTimePresent3.Text));
                listTime.Add(int.Parse(textBoxTimeMask4.Text));
                listTime.Add(int.Parse(textBoxTimePresent4.Text));
                listTime.Add(int.Parse(textBoxTimeMask5.Text));
                listTime.Add(int.Parse(textBoxTimePresent5.Text));
                listTime.Add(int.Parse(textBoxSleep1.Text));
                listTime.Add(int.Parse(textBoxSleep2.Text));
                listTime.Add(int.Parse(textBoxSleep3.Text));
                listTime.Add(int.Parse(textBoxSleep4.Text));
                listTime.Add(int.Parse(textBoxSleep5.Text));

                var ex2 = new Experiment2DataHelper();
                var settingsEx2 = ex2.GetSettings();
                settingsEx2.Interval = textBoxTimePresent2.Text == String.Empty ? 40 : int.Parse(textBoxTimePresent2.Text);
                ex2.SetSettings(settingsEx2);

                var ex3 = new Experiment3DataHelper();
                var settingsEx3 = ex3.GetSettings();
                settingsEx3.Interval = textBoxTimePresent3.Text == String.Empty ? 40 : int.Parse(textBoxTimePresent2.Text);
                ex3.SetSettings(settingsEx3);

                var ex4 = new Experiment4DataHelper();
                var settings = ex4.GetSettings();
                settings.UnderTime = textBoxTimePresent4.Text == String.Empty ? 40 : int.Parse(textBoxTimePresent4.Text);
                ex4.SetSettings(settings);
                new DB().setTimeMaskAndPresent(listTime);
                MessageBox.Show("Данные сохранены");
            }
            else
            {
                MessageBox.Show("Не все поля с временем заполнены либо пароли не совпали!");
            }
        }

        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword1.Text == textBoxPassword2.Text && textBoxPassword1.Text != String.Empty &&
                textBoxPassword2.Text != String.Empty)
            {
                new DB().setNewPassword(textBoxPassword1.Text);
                MessageBox.Show("Новый пароль сохранён");
            }
            else
            {
                MessageBox.Show("Пароли не совпали!");
            }
        }

        private void buttonExp5AddPositive_Click(object sender, EventArgs e)
        {
            object[] values = new object[5];

            foreach (DataGridViewColumn column in dataGridViewExperiment5.Columns)
            {
                if (column.Index == 3)
                    break;
                values[column.Index] = dataGridViewExperiment5[column.Index, dataGridViewExperiment5.CurrentRow.Index].Value;
            }
            values[3] = dataGridViewExperiment5[3, dataGridViewExperiment5.CurrentRow.Index].Value;
            values[4] = true;


            values[0] = dataGridViewExpSetting5.Rows.Count + 1;
            dataGridViewExpSetting5.Rows.Add(values);
        }

        private void buttonExp5AddNegative_Click(object sender, EventArgs e)
        {
            object[] values = new object[5];

            foreach (DataGridViewColumn column in dataGridViewExperiment5.Columns)
            {
                if (column.Index == 3)
                    break;
                values[column.Index] = dataGridViewExperiment5[column.Index, dataGridViewExperiment5.CurrentRow.Index].Value;
            }
            values[3] = dataGridViewExperiment5[4, dataGridViewExperiment5.CurrentRow.Index].Value;
            values[4] = false;

            values[0] = dataGridViewExpSetting5.Rows.Count + 1;
            dataGridViewExpSetting5.Rows.Add(values);

        }

        private void buttonClearResults_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show("Вы действительно хотите удалить результаты экспериментов и всех пользователей?",
                StudyOfSubthresholdPerception.Properties.Resources.StrWarningTitle, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                new DB().clearTable("ResultOfExperiment1");
                new DB().clearTable("ResultsOfExperiment5");
                new DB().clearTable("Users");
            }
        }

        private void buttonExp4AddPair_Click(object sender, EventArgs e)
        {
            if (dataGridViewEx4Img1.SelectedRows.Count > 0 && dataGridViewEx4Img2.SelectedRows.Count > 0)
            {
                var id1 = (int)dataGridViewEx4Img1.SelectedRows[0].Cells[1].Value;
                var id2 = (int)dataGridViewEx4Img2.SelectedRows[0].Cells[1].Value;
                var ex4 = new Experiment4DataHelper();
                var gbValue = gbExp4PairType.Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked);
                var model = new Experiment4Model
                {
                    Id1 = id1,
                    Id2 = id2,
                    Type = gbValue != null ? int.Parse(gbValue.Tag.ToString()) : 0
                };
                ex4.AddData(model);
                var data = ex4.GetData();
                dataGridViewEx4Pairs.Rows.Clear();
                data.Sort((first, second) => first.Id.CompareTo(second.Id));
                for (int i = 0; i < data.Count; i++)
                {
                    string typeStr = null;
                    switch (data[i].Type)
                    {
                        case (int)PairTypes.TruePair:
                            typeStr = Resources.textTruePair;
                            break;
                        case (int)PairTypes.FalsePair:
                            typeStr = Resources.textFalsePair;
                            break;
                        case (int)PairTypes.UnderPair:
                            typeStr = Resources.textUnderPair;
                            break;
                    }
                    dataGridViewEx4Pairs.Rows.Add(new object[] { i + 1, data[i].Id, data[i].ImageItem1, data[i].ImageItem2, typeStr ?? string.Empty });
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ex4 = new Experiment4DataHelper();
            var pointPeriod = 0;
            int.TryParse(textBoxEx4PointPeriod.Text, out pointPeriod);
            var experiments = 0;
            int.TryParse(textBoxEx4ExpCount.Text, out experiments);
            var circlePeriod = 0;
            int.TryParse(textBoxEx4CirclePeriod.Text, out circlePeriod);
            var presentations = 0;
            int.TryParse(textBoxEx4PresCount.Text, out presentations);
            ex4.SetSettings(new Experiment4SettingsModel { PointPeriod = pointPeriod, Experiments = experiments, CirclePeriod = circlePeriod, Presentations = presentations });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewEx4Pairs.SelectedRows.Count > 0)
            {
                var ex4 = new Experiment4DataHelper();
                ex4.RemoveData((int)dataGridViewEx4Pairs.SelectedRows[0].Cells[1].Value);
                var data = ex4.GetData();
                dataGridViewEx4Pairs.Rows.Clear();
                data.Sort((first, second) => first.Id.CompareTo(second.Id));
                for (int i = 0; i < data.Count; i++)
                {
                    string typeStr = null;
                    switch (data[i].Type)
                    {
                        case (int)PairTypes.TruePair:
                            typeStr = Resources.textTruePair;
                            break;
                        case (int)PairTypes.FalsePair:
                            typeStr = Resources.textFalsePair;
                            break;
                        case (int)PairTypes.UnderPair:
                            typeStr = Resources.textUnderPair;
                            break;
                    }
                    dataGridViewEx4Pairs.Rows.Add(new object[] { i + 1, data[i].Id, data[i].ImageItem1, data[i].ImageItem2, typeStr ?? string.Empty });
                }
            }
        }

        private void LoadEx3()
        {
            var ex3 = new Experiment3DataHelper();
            var data = ex3.GetData();
            var selecrteddata = ex3.GetSelectedData();
            dataGridViewEx3.Rows.Clear();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, data[i].Id, data[i].FirstAnswer, data[i].SecondAnswer, data[i].Text);
            }
            for (int i = 0; i < selecrteddata.Count; i++)
            {
                dataGridViewEx3.Rows.Add(i + 1, selecrteddata[i].Id, selecrteddata[i].FirstAnswer, selecrteddata[i].SecondAnswer, selecrteddata[i].Text);
            }

        }

        private void LoadEx2()
        {
            var ex2 = new Experiment2DataHelper();
            var data = ex2.GetData();
            var selecrteddata = ex2.GetSelectedData();
            dataGridViewEx2.Rows.Clear();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView2.Rows.Add(i + 1, data[i].Id, data[i].FirstAnswer, data[i].SecondAnswer);
            }
            for (int i = 0; i < selecrteddata.Count; i++)
            {
                dataGridViewEx2.Rows.Add(i + 1, selecrteddata[i].Id, selecrteddata[i].FirstAnswer, selecrteddata[i].SecondAnswer);
            }

        }

        private void LoadEx3Setings()
        {
            var ex3 = new Experiment3DataHelper();
            var settings = ex3.GetSettings();
            textBoxEx3Exp.Text = settings.ExpCount.ToString(CultureInfo.InvariantCulture);
            textBoxEx3Pres.Text = settings.PresCount.ToString(CultureInfo.InvariantCulture);
        }

        private void LoadEx2Setings()
        {
            var ex2 = new Experiment2DataHelper();
            var settings = ex2.GetSettings();
            textBoxEx2Exp.Text = settings.ExpCount.ToString(CultureInfo.InvariantCulture);
            textBoxEx2Pres.Text = settings.PresCount.ToString(CultureInfo.InvariantCulture);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var ex3 = new Experiment3DataHelper();
            int expCount = 0;
            int.TryParse(textBoxEx3Exp.Text, out expCount);
            int presCount = 0;
            int.TryParse(textBoxEx3Pres.Text, out presCount);
            var count = ex3.GetSelectedData().Count;
            if (expCount * presCount == count)
            {
                var settings = ex3.GetSettings();
                ex3.SetSettings(new Experiment3SettingsModel { ExpCount = expCount, PresCount = presCount, Interval = settings.Interval });
                MessageBox.Show("Данные сохранены.");
            }
            else
            {
                MessageBox.Show("Количество строк в таблице не совпадает с общим количеством предъявлений. Проверьте правильность заполнения!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var ex3 = new Experiment3DataHelper();
                ex3.AddSelectedById((int)dataGridView1.SelectedRows[0].Cells[1].Value);
            }
            LoadEx3();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridViewEx3.SelectedRows.Count > 0)
            {
                var ex3 = new Experiment3DataHelper();
                ex3.RemoveSelectedData((int)dataGridViewEx3.SelectedRows[0].Cells[1].Value);
            }
            LoadEx3();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var ex2 = new Experiment2DataHelper();
                ex2.AddSelectedById((int)dataGridView2.SelectedRows[0].Cells[1].Value);
            }
            LoadEx2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridViewEx2.SelectedRows.Count > 0)
            {
                var ex2 = new Experiment2DataHelper();
                ex2.RemoveSelectedData((int)dataGridViewEx2.SelectedRows[0].Cells[1].Value);
            }
            LoadEx2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var ex2 = new Experiment2DataHelper();
            int expCount = 0;
            int.TryParse(textBox1.Text, out expCount);
            int presCount = 0;
            int.TryParse(textBoxEx2Pres.Text, out presCount);
            ex2.SetSettings(new Experiment2SettingsModel { ExpCount = expCount, PresCount = presCount });
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
