using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.SettingsExperiments
{
    class SettingExperiment1
    {
        private FormSetting formSetting;

        public SettingExperiment1(FormSetting formSetting)
        {
            this.formSetting = formSetting;
        }

        public void saveData()
        {
            int numOfExp = Convert.ToInt32(formSetting.TextBoxNumOfExp.Text);
            int numOfPresent = Convert.ToInt32(formSetting.TextBoxNumOfPresent.Text);
            int numOfAllPresent = numOfExp * numOfPresent;

            if (numOfAllPresent == formSetting.DataGridViewExpSetting1.Rows.Count)
            {
                new DB().clearTable("SettingForExperiment1");

                string query = "INSERT INTO SettingForExperiment1 (Id, Presentation) VALUES (@id, @present)";
                string queryExp = "UPDATE GeneralSettings SET Value='" + numOfExp + "' WHERE Id=1"; //id=1 - Кол-во_опытов_экс1
                string queryPresent = "UPDATE GeneralSettings SET Value='" + numOfPresent + "' WHERE Id=2"; //id=2 - Кол-во_предъявлений_экс1

                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    try
                    {
                        SqlCeCommand command = new SqlCeCommand(query, connection);
                        SqlCeCommand commandExp = new SqlCeCommand(queryExp, connection);
                        SqlCeCommand commandPresent = new SqlCeCommand(queryPresent, connection);

                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        foreach (DataGridViewRow row in formSetting.DataGridViewExpSetting1.Rows)
                        {
                            command.Parameters.AddWithValue("@id", row.Cells[0].Value);
                            command.Parameters.AddWithValue("@present", row.Cells[1].Value);
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
                MessageBox.Show("Таблица заполнена не польностью. Проверьте данные!", StudyOfSubthresholdPerception.Properties.Resources.StrWarningTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void loadData()
        {
            try
            {
                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    connection.Open();
                    string query = "SELECT Experiment1.*, SettingForExperiment1.Presentation " +
                        "FROM Experiment1, SettingForExperiment1 WHERE Experiment1.Id = SettingForExperiment1.Presentation";

                    SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    //dataGridViewExperiment1.DataSource = table;
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        formSetting.DataGridViewExpSetting1.Rows.Add();
                        formSetting.DataGridViewExpSetting1.Rows[i].Cells[0].Value = (i + 1).ToString();
                        //заполняем в строке ячейки с 1 по 5
                        for (int j = 1; j < 6; j++)
                        {
                            int k = j - 1;
                            formSetting.DataGridViewExpSetting1.Rows[i].Cells[j].Value = table.Rows[i][k];
                        }
                    }
                    query = "SELECT Id, Value FROM GeneralSettings WHERE Id=1 OR Id=2";
                    adapter = new SqlCeDataAdapter(query, connection);
                    table = new DataTable();
                    adapter.Fill(table);
                    formSetting.TextBoxNumOfExp.Text = (string)table.Rows[0][1];
                    formSetting.TextBoxNumOfPresent.Text = (string)table.Rows[1][1];
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
