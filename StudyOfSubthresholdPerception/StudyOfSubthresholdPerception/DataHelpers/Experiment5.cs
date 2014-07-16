using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.DataHelpers
{
    class Experiment5
    {
        public static int numOfExp, numOfPresent, numRows;
        public static List<Bitmap> imageList;
        public static DataTable table = new DataTable();
        private List<object> answersPresentation = new List<object>();
        private DB db = new DB();
        private int m = 0; //счетчик текущей строки в table
        private int num = 0;

        internal void loadData()
        {
            try
            {
                string query = "SELECT Id, Value FROM GeneralSettings WHERE Id=9 OR Id=10"; //id=9 - кол-во опытов, id = 10 - кол-во предъявлений
                
                if (DB.connection.State == ConnectionState.Closed)
                    DB.connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, DB.connection);
                table = new DataTable();
                adapter.Fill(table);
                numOfExp = Convert.ToInt32(table.Rows[0][1]);
                numOfPresent = Convert.ToInt32(table.Rows[1][1]);

                query = "SELECT Experiment5.*, SettingsForExperiment5.Is_positive " +
                    "FROM Experiment5, SettingsForExperiment5 WHERE Experiment5.Id = SettingsForExperiment5.Id_presentation";
                adapter = new SqlCeDataAdapter(query, DB.connection);
                table = new DataTable();
                adapter.Fill(table);
                numRows = table.Rows.Count;
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }

        public void loadTestImages()
        {
            imageList = new List<Bitmap>();
            imageList.Add(StudyOfSubthresholdPerception.Properties.Resources.exp5Test1);
            imageList.Add(StudyOfSubthresholdPerception.Properties.Resources.exp5Test2);
            imageList.Add(StudyOfSubthresholdPerception.Properties.Resources.exp5Test3);
            imageList.Add(StudyOfSubthresholdPerception.Properties.Resources.exp5Test4);
            imageList.Add(StudyOfSubthresholdPerception.Properties.Resources.exp5Test5);
        }

        public void addAnswerPresentation(DateTime dTime, int scale)
        {
            answersPresentation.Add(dTime); //текущее время ответа
            answersPresentation.Add((bool)table.Rows[m][4]);
            answersPresentation.Add(scale); //введенный ответ

            m++;
        }

        //сохранение результатов эксперимента 1
        public void saveData(int timeMask, int timePresent)
        {
            string query = "SELECT coalesce(MAX (NumberExperiment),0) FROM ResultsOfExperiment5 WHERE UserId=" + db.ID_USER; //"SELECT MAX (NumberExperiment) FROM ResultOfExperiment1 WHERE UserId=" + db.ID_USER;

            try
            {
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, DB.connection);
                DataTable table = new DataTable();

                if (DB.connection.State == ConnectionState.Closed)
                    DB.connection.Open();
                adapter.Fill(table);
                num = (int)table.Rows[0][0] + 1;

                //-----------------------------
                query = "INSERT INTO ResultsOfExperiment5 (UserId, NumberExperiment, TimeMask, TimePresentation, " +
                    "ADateTime, Is_positive, Scale) VALUES (@userId, @num, @tMask, @tPresent, " +
                    "@dt, @positive, @scale)";
                //List<int> listTime = db.getTime(11, 12);

                SqlCeCommand cmd = new SqlCeCommand(query, DB.connection);

                int i = 0;
                while (i < numRows)
                {
                    cmd.Parameters.AddWithValue("@userId", db.ID_USER);
                    cmd.Parameters.AddWithValue("@num", num);
                    cmd.Parameters.AddWithValue("@tMask", timeMask); //listTime[0]);
                    cmd.Parameters.AddWithValue("@tPresent", timePresent); //listTime[1]);
                    cmd.Parameters.AddWithValue("@dt", answersPresentation[i * 3]);
                    cmd.Parameters.AddWithValue("@positive", answersPresentation[(i * 3) + 1]); //table.Rows[i][2]);
                    cmd.Parameters.AddWithValue("@scale", answersPresentation[(i * 3) + 2]); //table.Rows[i][3]);
                    cmd.ExecuteNonQuery();
                    i++;
                    cmd.Parameters.Clear();
                }
                loadTableResult();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }

        private void loadTableResult()
        {
            try
            {
                string query = "SELECT TimeMask , TimePresentation , ADateTime , Is_positive , Scale " + 
                    "FROM ResultsOfExperiment5 WHERE UserId=" + db.ID_USER + 
                    " AND NumberExperiment=" + num;
                
                if (DB.connection.State == ConnectionState.Closed)
                    DB.connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, DB.connection);
                //table.Clear();
                table = new DataTable();
                table.Columns.Add("№ предъявления");
                adapter.Fill(table);

                table.Columns[1].ColumnName = "Время предъявления маски";
                table.Columns[2].ColumnName = "Время предъявления подпорогового стимула";
                table.Columns[3].ColumnName = "Текущее время";
                table.Columns[4].ColumnName = "Позитивный подпороговый стимул";
                table.Columns[5].ColumnName = "Оценка";

                new FormCurrentResult(table).ShowDialog();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.connection.Close();
            }
        }
    }
}
