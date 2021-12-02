using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseWinform.loginManager
{
    class DBAccount
    {
        public static DataTable AccountCheck(string account)
        {
            string connectionstring = "Data Source=localhost\\SQLExpress;Initial Catalog=ERP;Integrated Security=true";

            string querystring = @"SELECT * from StaffList where Account = @Account;";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(querystring, con);
                command.Parameters.AddWithValue("@Account", account);

                try
                {
                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    reader.Close();

                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
