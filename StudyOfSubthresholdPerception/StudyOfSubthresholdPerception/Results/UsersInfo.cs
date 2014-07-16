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
                formResults.ComboBoxUsers.Items.Add("Экспериментатор");
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
                    else if (userId == -2)
                        query = "SELECT * FROM ResultOfExperiment1 WHERE UserId=0";
                    else
                        query = "SELECT * FROM ResultOfExperiment1 WHERE UserId=" + userId;
                    break;
                case 4:
                    if (userId == -1)
                        query = "SELECT * FROM ResultsOfExperiment5";
                    else if (userId == -2)
                        query = "SELECT * FROM ResultsOfExperiment5 WHERE UserId=0";
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
                        if (j < 2)
                        {
                            dgView.Rows[i].Cells[j + 1].Value = tableResults.Rows[i][j];
                        }
                        else
                        {
                            dgView.Rows[i].Cells[j + 2].Value = tableResults.Rows[i][j];
                        }

                        if (j == 2) //если текущая ячейка с id юзера
                        {
                            dgView.Rows[i].Cells[j + 1].Value = getUserName((int)tableResults.Rows[i][j-1]);
                        }
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
            else if (index == 1)
            {
                formResults.LabelUserInfo.Text = String.Empty;
                loadResult(-2);
                return this.dgView;
            }
            else
            {
                //--index;
                index -= 2;
                formResults.LabelUserInfo.Text = "Id = " + tableUsers.Rows[index][0] + ", пол - " +
                    tableUsers.Rows[index][2] + ", возраст - " + tableUsers.Rows[index][3] + ", группа - " + tableUsers.Rows[index][4];
                loadResult((int)tableUsers.Rows[index][0]);
                return this.dgView;
            }
        }

        private String getUserName(int idUser)
        {
            String name = "Преподаватель";

            for (int i = 0; i < tableUsers.Rows.Count; i++)
            {
                if ((int)tableUsers.Rows[i][0] == idUser)
                {
                    name = tableUsers.Rows[i][1].ToString();
                }
            }

            return name;
        }
    }
}
