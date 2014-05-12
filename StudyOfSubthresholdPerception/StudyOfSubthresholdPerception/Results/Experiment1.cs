using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.Results
{
    class Experiment1
    {
        private DataTable tableUsers = new DataTable();
        private DataTable tableResults = new DataTable();
        private FormResults formResults;

        public Experiment1(FormResults formResults)
        {
            this.formResults = formResults;
        }

        public void loadUsers()
        {
            string query = "SELECT * FROM Users";
            try
            {
                if (DB.connection.State == ConnectionState.Closed)
                    DB.connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, DB.connection);
                adapter.Fill(tableUsers);

                
                //formResults.ComboBoxUsers.DataSource = tableUsers;
                //formResults.ComboBoxUsers.DisplayMember = "Name";
                //formResults.ComboBoxUsers.SelectedIndex = 0;

                formResults.ComboBoxUsers.Items.Add("Все пользователи");
                for (int i = 0; i < tableUsers.Rows.Count; i++)
                {
                    formResults.ComboBoxUsers.Items.Add(tableUsers.Rows[i][1]);
                }
                formResults.ComboBoxUsers.SelectedIndex = 0;
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

        public void loadResult(int userId)
        {
            string query;
            if (userId == -1)
                query = "SELECT * FROM ResultOfExperiment1";
            else
                query = "SELECT * FROM ResultOfExperiment1 WHERE UserId=" + userId;
            try
            {
                if (DB.connection.State == ConnectionState.Closed)
                    DB.connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, DB.connection);
                adapter.Fill(tableResults);

                formResults.DataGridViewResults1.Rows.Clear();

                for (int i = 0; i < tableResults.Rows.Count; i++)
                {
                    formResults.DataGridViewResults1.Rows.Add();
                    formResults.DataGridViewResults1.Rows[i].Cells[0].Value = (i + 1).ToString();
                    
                    for (int j = 0; j < tableResults.Columns.Count; j++)
                    {
                        formResults.DataGridViewResults1.Rows[i].Cells[j+1].Value = tableResults.Rows[i][j];
                    }
                }
                tableResults.Clear();
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

        //-----get and set-----
        public DataTable TableUsers
        {
            get
            {
                return tableUsers;
            }
        }

        internal void getUserInfo(int index)
        {
            if (index == 0)
            {
                formResults.LabelUserInfo.Text = String.Empty;
                loadResult(-1);
            }
            else
            {
                --index;
                formResults.LabelUserInfo.Text = "Id = " + tableUsers.Rows[index][0] + ", пол - " +
                    tableUsers.Rows[index][2] + ", возраст - " + tableUsers.Rows[index][3] + ", группа - " + tableUsers.Rows[index][4];
                loadResult((int)tableUsers.Rows[index][0]);
            }
            //formResults.DataGridViewResults1.Rows.Clear();
        }
    }
}
