using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL
{
    public class AdminDAL
    {
        //CHECK THE ADMIN LOGIN CREDENTIALS =>DAL
        public bool AdminLoginDAL(string adminEmail, string adminPass)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("AdminLogin @email, @pwd", conn);
            cmd.Parameters.Add(new SqlParameter("@email", adminEmail));
            cmd.Parameters.Add(new SqlParameter("@pwd", adminPass));
            conn.Open();
            int rowAffected = (int)cmd.ExecuteScalar();
            
            if (rowAffected!=0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
