using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception
{
    class DB
    {
        private string query;
        public static string connectionString = Environment.CurrentDirectory + @"\Data\Data.sdf";
        public static SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + connectionString + ";Max Database Size=2048"); 
        //public static int timeBefore, time;
        private List<int> listTime = new List<int>();
        private static int idUser;

        public void clearTable(string name)
        {
            query = "DELETE FROM " + name;

            try
            {
                SqlCeCommand command = new SqlCeCommand(query, connection);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command.ExecuteNonQuery();

            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        /*
        public void loadTime()
        {
            try
            {
                using (SqlCeConnection connection = new SqlCeConnection(@"Data Source=" + connectionString + ";Max Database Size=2048"))
                {
                    connection.Open();
                    string query = "SELECT Id, Value FROM GeneralSettings WHERE Id=11 OR Id=12"; //id=11 - время до(после) предъявления, id=12 - время предъявления

                    SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    timeBefore = Convert.ToInt32(table.Rows[0][1]);
                    time = Convert.ToInt32(table.Rows[1][1]);
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
         */

        //почлучение времени
        public List<int> getTime(int idTimeMask, int idTimePresent)
        {
            try
            {
                string query = "SELECT Id, Value FROM GeneralSettings WHERE " +
                    "Id=" + idTimeMask + " OR Id=" + idTimePresent; //id=idTimeMask - время до(после) предъявления, id=idTimePresent - время предъявления
                
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                int i = 0;
                while (i < table.Rows.Count)
                {
                    listTime.Add(Convert.ToInt32(table.Rows[i][1]));
                    i++;
                }
                //return listTime;
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return listTime;
        }

        public void createUser(string name, string gender, int age, int group)
        {
            //string query = "SELECT Id, Name FROM Users WHERE Name='" + name + "'";
            string query = "SELECT * FROM Users WHERE Name='" + name + "' AND Gender='" + 
                gender + "' AND Age=" + age + " AND AGroup=" + group;
                
            try
            {
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                DataTable table = new DataTable();

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                adapter.Fill(table);

                if (table.Rows.Count > 0 && name == (string)table.Rows[0][1] && gender == (string)table.Rows[0][2] &&
                    age == (int)table.Rows[0][3] && group == (int)table.Rows[0][4])
                {
                    MessageBox.Show("Данная учетная запись уже существует. Вход будет осуществлен под старой учетной записью.",
                        StudyOfSubthresholdPerception.Properties.Resources.StrWarningTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idUser = (int)table.Rows[0][0];
                }
                else
                {
                    addNewUser(name, gender, age, group);
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void addNewUser(string name, string gender, int age, int group)
        {
            query = "INSERT INTO Users (Name, Gender, Age, AGroup) Values (@name, @gender, @age, @group)";

            SqlCeCommand cmd = new SqlCeCommand(query, connection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@group", group);

            cmd.ExecuteNonQuery();

            query = "SELECT MAX(Id) FROM USERS";
            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            idUser = (int)table.Rows[0][0];
        }

        public void setNewPassword(string pass)
        {
            query = "UPDATE GeneralSettings SET Value=(@pass) WHERE Id=21"; //пароль
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCeCommand cmd = new SqlCeCommand(query, connection);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.ExecuteNonQuery();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public string getPassword()
        {
            string pass = String.Empty;
            query = "SELECT Value FROM GeneralSettings WHERE Id=21"; //пароль

            try
            {
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                DataTable table = new DataTable();

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                adapter.Fill(table);

                pass = (string)table.Rows[0][0];
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return pass;
        }

        public void setTimeMaskAndPresent(List<int> list)
        {
            int id = 11;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCeCommand cmd;

                for (int i = 0; i < list.Count; i++)
                {
                    query = "UPDATE GeneralSettings SET Value=(@time) WHERE Id=" + id; //пароль
                    cmd = new SqlCeCommand(query, connection);
                    cmd.Parameters.AddWithValue("@time", list[i].ToString());
                    cmd.ExecuteNonQuery();
                    id++;
                }
                    
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<string> getTimeMaskAndPresent()
        {
            List<string> listTime = new List<string>(10);
            query = "SELECT Value FROM GeneralSettings WHERE Id BETWEEN 11 AND 20"; //время

            try
            {
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                DataTable table = new DataTable();

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                adapter.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    listTime.Add((string)table.Rows[i][0]);
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, StudyOfSubthresholdPerception.Properties.Resources.StrErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return listTime;
        }

        //-----get and set-----
        public int ID_USER
        {
            get
            {
                return idUser;
            }
        }
    }
}
