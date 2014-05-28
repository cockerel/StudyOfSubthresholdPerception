using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using StudyOfSubthresholdPerception.DAL;
using StudyOfSubthresholdPerception.Models.Experiment4;
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
	        using (var context = new DataContext())
	        {
		        var model = new List<Experiment4Model>();
		      /*  foreach (var item in context.Experiment4Images)
		        {
					var ms = new MemoryStream(item.Image);
			        model.Add(new Experiment4Model{Id = item.Id, ImageItem = System.Drawing.Image.FromStream(ms)});
		        }*/
				dataGridView2.DataSource = model;
				dataGridView3.DataSource = model;
	        }
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
					textBoxTimeMask4.Text = listTime[6];
					textBoxTimePresent4.Text = listTime[7];
					textBoxTimeMask5.Text = listTime[8];
					textBoxTimePresent5.Text = listTime[9];
					textBoxSleep1.Text = listTime[10];
					textBoxSleep2.Text = listTime[11];
					textBoxSleep3.Text = listTime[12];
					textBoxSleep4.Text = listTime[13];
					textBoxSleep5.Text = listTime[14];
					break;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex)
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
			switch (tabControl.SelectedIndex)
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

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}
