using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.SetEditor
{
    class Experiment5
    {
        public void loadData(DataGridView dgView)
        {
            dgView.Rows.Clear();
            string query = "SELECT * FROM Experiment5 ORDER BY Id";

            try
            {
                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    connection.Open();

                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            dgView.Rows.Add();
                            dgView.Rows[i].Cells[0].Value = (i + 1).ToString();
                            //заполняем в строке ячейки с 1 по 4
                            for (int j = 1; j < 5; j++)
                            {
                                int k = j - 1;
                                dgView.Rows[i].Cells[j].Value = table.Rows[i][k];
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void deleteRow(DataGridView dgView)
        {
            try
            {
                string id = dgView.Rows[dgView.CurrentRow.Index].Cells[1].Value.ToString();
                string query = "DELETE FROM Experiment5 WHERE Id=" + id;

                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    try
                    {
                        SqlCeCommand command = new SqlCeCommand(query, connection);
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    finally
                    {
                        connection.Close();
                        loadData(dgView);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выберите набор для удаления!");
            }
        }
    }
}
