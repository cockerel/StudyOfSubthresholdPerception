using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyOfSubthresholdPerception.Results
{
    class UsersInfo
    {
        private DataTable tableUsers = new DataTable();
        private DataTable tableResults = new DataTable();
        private FormResults formResults;
        private DataGridView dgView;
        private string query;
        private int tabIndex;

        public UsersInfo(FormResults formResults)
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
            switch (tabIndex)
            {
                case 0:
                    if (userId == -1)
                        query = "SELECT * FROM ResultOfExperiment1";
                    else
                        query = "SELECT * FROM ResultOfExperiment1 WHERE UserId=" + userId;
                    break;
                case 4:
                    if (userId == -1)
                        query = "SELECT * FROM ResultsOfExperiment5";
                    else
                        query = "SELECT * FROM ResultsOfExperiment5 WHERE UserId=" + userId;
                    break;
            }

            try
            {
                if (DB.connection.State == ConnectionState.Closed)
                    DB.connection.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, DB.connection);
                adapter.Fill(tableResults);

                dgView.Rows.Clear();

                for (int i = 0; i < tableResults.Rows.Count; i++)
                {
                    dgView.Rows.Add();
                    dgView.Rows[i].Cells[0].Value = (i + 1).ToString();

                    for (int j = 0; j < tableResults.Columns.Count; j++)
                    {
                        dgView.Rows[i].Cells[j + 1].Value = tableResults.Rows[i][j];
                    }
                }
                tableResults.Clear();
                tableResults.Columns.Clear();
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

        public DataGridView getUserInfo(int index, DataGridView dgView, int tabIndex)
        {
            this.dgView = dgView;
            this.tabIndex = tabIndex;
            if (index == 0)
            {
                formResults.LabelUserInfo.Text = String.Empty;
                loadResult(-1);
                return this.dgView;
            }
            else
            {
                --index;
                formResults.LabelUserInfo.Text = "Id = " + tableUsers.Rows[index][0] + ", пол - " +
                    tableUsers.Rows[index][2] + ", возраст - " + tableUsers.Rows[index][3] + ", группа - " + tableUsers.Rows[index][4];
                loadResult((int)tableUsers.Rows[index][0]);
                return this.dgView;
            }
        }
    }
}
