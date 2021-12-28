using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Student.Models
{
    public class UserDL
    {
        string cs = ConfigurationManager.ConnectionStrings["SQLMVCConnectionString"].ConnectionString;

        public int UpdateLoginStatus(String Email, String Password)
        {
            try
            {
                int i;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("UserLogin", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Email", Email);
                    com.Parameters.AddWithValue("@Password", Password);
                    i = (Int32)com.ExecuteScalar();
                }
                return i;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}