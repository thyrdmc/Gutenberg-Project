using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GutenbergProject.Classes
{
    class LoginHistory
    {
        Connection connection = new Connection();

        #region fields
        private int ID;
        private int jobID;
        private string login;
        private DateTime date;
        #endregion

        #region properties
        public int ID1 { get => ID; set => ID = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public string Login { get => login; set => login = value; }
        public DateTime Date { get => date; set => date = value; }
        #endregion

        public bool PersonnelAction(LoginHistory loginHistory)
        {
            bool result = false;

            SqlConnection conn = new SqlConnection(connection.conString);
            SqlCommand cmd = new SqlCommand("INSERT INTO staffMovements(PersonelID, JobID, Operations, Date)Values(@PersonelID, @JobID, @operations, @date)", conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Connection.personelID;
                cmd.Parameters.Add("@JobID", SqlDbType.Int).Value =loginHistory.JobID;
                cmd.Parameters.Add("@operations", SqlDbType.VarChar).Value = loginHistory.login;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = loginHistory.date;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }

            return result;
        }
    }
}
