using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.SettingsExperiments
{
    class SettingExperiment5
    {
        private FormSetting formSetting;

        public SettingExperiment5(FormSetting formSetting)
        {
            this.formSetting = formSetting;
        }
        public void saveData()
        {
            int numOfExp = 0;
            int numOfPresent = 0;
            int numOfAllPresent = 0;

            try
            {
                numOfExp = Convert.ToInt32(formSetting.TextBoxNumOfExp5.Text);
            }
            catch 
            {
                formSetting.TextBoxNumOfExp5.Text = "1";
            }

            try
            {
                numOfPresent = Convert.ToInt32(formSetting.TextBoxNumOfPresent5.Text);
            }
            catch
            {
                formSetting.TextBoxNumOfPresent5.Text = "1";
            }
            
            numOfAllPresent = numOfExp * numOfPresent;

            if (numOfAllPresent == formSetting.DataGridViewExpSetting5.Rows.Count)
            {
                new DB().clearTable("SettingsForExperiment5");

                string query = "INSERT INTO SettingsForExperiment5 (Id_presentation, Is_positive) VALUES (@id, @is_positive)";
                string queryExp = "UPDATE GeneralSettings SET Value='" + numOfExp + "' WHERE Id=9"; //id=9 - Кол-во_опытов_экс5
                string queryPresent = "UPDATE GeneralSettings SET Value='" + numOfPresent + "' WHERE Id=10"; //id=10 - Кол-во_предъявлений_экс5

                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    try
                    {
                        SqlCeCommand command = new SqlCeCommand(query, connection);
                        SqlCeCommand commandExp = new SqlCeCommand(queryExp, connection);
                        SqlCeCommand commandPresent = new SqlCeCommand(queryPresent, connection);

                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        foreach (DataGridViewRow row in formSetting.DataGridViewExpSetting5.Rows)
                        {
                            command.Parameters.AddWithValue("@id", row.Cells[1].Value); //id предъявления
                            command.Parameters.AddWithValue("@is_positive", row.Cells[4].Value); //is_positive
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                        commandExp.ExecuteNonQuery();
                        commandPresent.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Настройки сохранены!");
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Количество строк в таблице предъявлений не совпадает с общим количеством заданных опытов и предъявлений. Проверьте корректность введенных данных!",
                    StudyOfSubthresholdPerception.Properties.Resources.StrWarningTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadData()
        {
            formSetting.DataGridViewExpSetting5.Rows.Clear();

            try
            {
                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    connection.Open();
                    string query = "SELECT Experiment5.*, SettingsForExperiment5.Is_positive " +
                        "FROM Experiment5, SettingsForExperiment5 WHERE Experiment5.Id = SettingsForExperiment5.Id_presentation ORDER BY SettingsForExperiment5.Id";

                    SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    //dataGridViewExperiment1.DataSource = table;
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        formSetting.DataGridViewExpSetting5.Rows.Add();
                        formSetting.DataGridViewExpSetting5.Rows[i].Cells[0].Value = (i + 1).ToString();
                        //заполняем в строке ячейки с 1 по 5
                        for (int j = 1; j < 3; j++)
                        {
                            int k = j - 1;
                            formSetting.DataGridViewExpSetting5.Rows[i].Cells[j].Value = table.Rows[i][k];
                        }
                        if ((bool)table.Rows[i][4] == true)
                            formSetting.DataGridViewExpSetting5.Rows[i].Cells[3].Value = table.Rows[i][2];
                        else
                            formSetting.DataGridViewExpSetting5.Rows[i].Cells[3].Value = table.Rows[i][3];
                        formSetting.DataGridViewExpSetting5.Rows[i].Cells[4].Value = table.Rows[i][4];
                    }
                    query = "SELECT Id, Value FROM GeneralSettings WHERE Id=9 OR Id=10";
                    adapter = new SqlCeDataAdapter(query, connection);
                    table = new DataTable();
                    adapter.Fill(table);
                    formSetting.TextBoxNumOfExp5.Text = (string)table.Rows[0][1];
                    formSetting.TextBoxNumOfPresent5.Text = (string)table.Rows[1][1];
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
