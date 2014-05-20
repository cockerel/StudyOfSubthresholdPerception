using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using StudyOfSubthresholdPerception.SettingsExperiments;

namespace StudyOfSubthresholdPerception
{
    public partial class FormSetting : Form
    {
        private enum Tabs { Experiment1, Experiment2, Experiment3, Experiment4, Experiment5, GeneralSettings };
        private SettingExperiment1 settingExperiment1;

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
            switch (tabControl.SelectedIndex)
            { 
                case (int)Tabs.Experiment1:
                    break;
                case (int)Tabs.Experiment2:
                    break;
                case (int)Tabs.Experiment3:
                    break;
                case (int)Tabs.Experiment4:
                    break;
                case (int)Tabs.Experiment5:
                    new SetEditor.Experiment5().loadData(dataGridViewExperiment5);
                    break;
                case (int)Tabs.GeneralSettings:
                    List<string> listTime = new DB().getTimeMaskAndPresent();
                    textBoxTimeMask1.Text = listTime[0];
                    textBoxTimePresent1.Text = listTime[1];
                    textBoxTimeMask2.Text = listTime[2];
                    textBoxTimePresent2.Text = listTime[3];
                    textBoxTimeMask3.Text = listTime[4];
                    textBoxTimePresent3.Text = listTime[5];
                    textBoxTimeMask4.Text = listTime[6];
                    textBoxTimePresent4.Text = listTime[7];
                    textBoxTimeMask5.Text = listTime[8];
                    textBoxTimePresent5.Text = listTime[9];
                    break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpSetting1.Rows.Count > 0)
            {
                dataGridViewExpSetting1.Rows.RemoveAt(dataGridViewExpSetting1.CurrentRow.Index);
                foreach (DataGridViewRow row in dataGridViewExpSetting1.Rows)
                {
                    row.Cells[0].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Таблица пустая!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            settingExperiment1.saveData();
        }

        private void textBoxesInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true; 
        }

        private void textBoxesPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 97 || e.KeyChar > 122))
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
        //--------------------------

        private void buttonSaveGeneralSettings_Click(object sender, EventArgs e)
        {
            if (textBoxTimeMask1.Text != String.Empty && textBoxTimeMask2.Text != String.Empty &&
                textBoxTimeMask3.Text != String.Empty && textBoxTimeMask4.Text != String.Empty &&
                textBoxTimeMask5.Text != String.Empty &&
                textBoxTimePresent1.Text != String.Empty && textBoxTimePresent2.Text != String.Empty &&
                textBoxTimePresent3.Text != String.Empty && textBoxTimePresent4.Text != String.Empty &&
                textBoxTimePresent5.Text != String.Empty)
            {
                List<int> listTime = new List<int>(10);

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
    }
}
