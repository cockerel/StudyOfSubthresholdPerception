using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.SetEditor
{
    class Experiment1
    {
        internal void loadData(DataGridView dataGridViewExperiment1)
        {
            dataGridViewExperiment1.Rows.Clear();
            string query = "SELECT * FROM Experiment1 ORDER BY Id";

            try
            {
                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    connection.Open();

                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        //dataGridViewExperiment1.DataSource = table;
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            //dataGridViewExperiment1.Columns.Insert((i + 1), table.Columns[i]);
                            //dataGridViewExperiment1.Columns[i + 1] = table.Columns[0];
                            dataGridViewExperiment1.Rows.Add();
                            dataGridViewExperiment1.Rows[i].Cells[0].Value = (i + 1).ToString();
                            //dataGridViewExperiment1["№", 0].Value = "asd";//(i + 1).ToString();
                            //заполняем в строке ячейки с 1 по 5
                            for (int j = 1; j < 6; j++)
                            {
                                int k = j - 1;
                                dataGridViewExperiment1.Rows[i].Cells[j].Value = table.Rows[i][k];
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

        internal void deleteRow(DataGridView dataGridViewExperiment1)
        {
            string id = dataGridViewExperiment1.Rows[dataGridViewExperiment1.CurrentRow.Index].Cells[1].Value.ToString();
            string query = "DELETE FROM Experiment1 WHERE Id=" + id;

            try
            {
                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + DB.connectionString + ";Max Database Size=2048"))
                {
                    SqlCeCommand command = new SqlCeCommand(query, connection);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                new SetEditor.Experiment1().loadData(dataGridViewExperiment1);
            }
        }
    }
}
