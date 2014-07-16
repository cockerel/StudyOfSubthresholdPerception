using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.DataHelpers
{
    class Experiment1
    {
        public static int numOfExp, numOfPresent, numRows;
        public static List<string> anagrams = new List<string>();
        public static DataTable table = new DataTable();
        private List<object> answersPresentation = new List<object>();
        private DB db = new DB();
        private int m = 0; //счетчик текущей строки в table
        private int num = 0;

        internal void loadData()
        {
            try
            {
                string query = "SELECT Id, Value FROM GeneralSettings WHERE Id=1 OR Id=2"; //id=1 - кол-во опытов, id = 2 - кол-во предъявлений
                
                if (DB.connection.State == ConnectionState.Closed)
                    DB.connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, DB.connection);
                table = new DataTable();
                adapter.Fill(table);
                numOfExp = Convert.ToInt32(table.Rows[0][1]);
                numOfPresent = Convert.ToInt32(table.Rows[1][1]);

                query = "SELECT Experiment1.*, SettingForExperiment1.Presentation " +
                    "FROM Experiment1, SettingForExperiment1 WHERE Experiment1.Id = SettingForExperiment1.Presentation";
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

        public void loadTestAnagrams()
        {
            string str = StudyOfSubthresholdPerception.Properties.Resources.TestAnagramForExperiment1;
            string anagram = "";
            for (int i = 0; i < str.Length; i++)
            { 
                anagram += Convert.ToString(str[i]);
                if (str[i + 1] == ',')
                {
                    anagrams.Add(anagram);
                    anagram = String.Empty;
                    i++;
                }
            }
        }

        public void addAnswerPresentation(DateTime dTime, string typedAnswer)
        {
            answersPresentation.Add(dTime); //текущее время ответа
            answersPresentation.Add(typedAnswer); //введенный ответ

            //проверка на равенство введенного ответа и правильного
            if (typedAnswer == (string)table.Rows[m][3]) 
                answersPresentation.Add(1); //правильно ввели
            else
                answersPresentation.Add(0);

            answersPresentation.Add(table.Rows[m][2]); //анаграмма
            answersPresentation.Add(table.Rows[m][3]); //правильный ответ
            m++;
        }

        //сохранение результатов эксперимента 1
        public void saveData(int timeMask, int timePresent)
        {
            string query = "SELECT coalesce(MAX (NumberExperiment),0) FROM ResultOfExperiment1 WHERE UserId=" + db.ID_USER; //"SELECT MAX (NumberExperiment) FROM ResultOfExperiment1 WHERE UserId=" + db.ID_USER;

            try
            {
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, DB.connection);
                DataTable table = new DataTable();

                if (DB.connection.State == ConnectionState.Closed)
                    DB.connection.Open();
                adapter.Fill(table);
                num = (int)table.Rows[0][0] + 1;

                //-----------------------------
                query = "INSERT INTO ResultOfExperiment1 (UserId, NumberExperiment, TimeMask, TimePresentation, " +
                    "ADateTime, Anagram, CorrectAnswer, TypedAnswer, Coincided) VALUES (@userId, @num, @tMask, @tPresent, " +
                    "@dt, @anagram, @correct, @typed, @coincided)";
                //List<int> listTime = db.getTime(11, 12);

                SqlCeCommand cmd = new SqlCeCommand(query, DB.connection);

                int i = 0;
                while (i < numRows)
                {
                    cmd.Parameters.AddWithValue("@userId", db.ID_USER);
                    cmd.Parameters.AddWithValue("@num", num);
                    cmd.Parameters.AddWithValue("@tMask", timeMask); //listTime[0]);
                    cmd.Parameters.AddWithValue("@tPresent", timePresent); //listTime[1]);
                    cmd.Parameters.AddWithValue("@dt", answersPresentation[i * 5]);
                    cmd.Parameters.AddWithValue("@anagram", answersPresentation[(i * 5) + 3]); //table.Rows[i][2]);
                    cmd.Parameters.AddWithValue("@correct", answersPresentation[(i * 5) + 4]); //table.Rows[i][3]);
                    cmd.Parameters.AddWithValue("@typed", answersPresentation[(i * 5) + 1]);
                    cmd.Parameters.AddWithValue("@coincided", answersPresentation[(i * 5) + 2]);
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
                string query = "SELECT TimeMask , TimePresentation , ADateTime , Anagram , CorrectAnswer , TypedAnswer , Coincided " + 
                    "FROM ResultOfExperiment1 WHERE UserId=" + db.ID_USER + 
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
                table.Columns[4].ColumnName = "Анаграмма";
                table.Columns[5].ColumnName = "Вариант (совпадающий)";
                table.Columns[6].ColumnName = "Введенный ответ";
                table.Columns[7].ColumnName = "Совпадение";

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
