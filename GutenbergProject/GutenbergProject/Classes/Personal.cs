using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace GutenbergProject.Classes
{
    class Personal
    {
        Connection connection = new Connection();

        #region fields
        private int personelID;
        private int personelJobID;
        private string personelName;
        private string personelPassword;
        #endregion

        #region properties
        public int PersonelID { get => personelID; set => personelID = value; }
        public int PersonelJobID { get => personelJobID; set => personelJobID = value; }
        public string PersonelName { get => personelName; set => personelName = value; }
        public string PersonelPassword { get => personelPassword; set => personelPassword = value; }
        #endregion

        public bool personalEntryControl(string _password, int _userID)
        {
            bool result = false;

            SqlConnection conn = new SqlConnection(connection.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM staff WHERE ID=@id AND Password=@password", conn);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = _userID;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = _password;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                string error = ex.Message;
                throw;
            }

            return result;
        }

        public void getPersonalInformation(DevExpress.XtraEditors.ComboBoxEdit cb)
        {
            cb.Properties.Items.Clear();

            SqlConnection conn = new SqlConnection(connection.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM staff ", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Personal p = new Personal();
                p.personelID = Convert.ToInt32(dr["ID"]);
                p.personelJobID = Convert.ToInt32(dr["JobID"]);
                p.personelName = Convert.ToString(dr["Name"]);
                p.personelPassword = Convert.ToString(dr["Password"]);
                cb.Properties.Items.Add(p);
            }

            dr.Close();
            conn.Close();
        }

        public override string ToString()
        {
            return PersonelName;
        }
    }
}