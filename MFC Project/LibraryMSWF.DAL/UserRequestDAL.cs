using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL
{
    public class UserRequestDAL
    {
        //ADD THE BOOK REQUEST INTO REQUEST TABLE =>DAL
        public bool AddRequestDAL(int bookId, string bookName, int userId, string userName)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("AddRequest @bId, @bName, @date, @uId, @uName", conn);
            cmd.Parameters.Add(new SqlParameter("@bId", bookId));
            cmd.Parameters.Add(new SqlParameter("@bName", bookName));
            cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now.Date));
            cmd.Parameters.Add(new SqlParameter("@uId", userId));
            cmd.Parameters.Add(new SqlParameter("@uName", userName));
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //RETURN THE PERTICULAR USER REQUESTED BOOKS FROM REQUEST TABLE  =>DAL
        public DataSet GetAllRequestUserDAL(int userId)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("GetAllRequestUser "+userId+"", conn);
            DataSet ds = new DataSet("UsersRequests");
            da.Fill(ds);
            return ds;
        }
        //RETURN THE COMPLETE REQUESTED BOOKS FROM REQUEST TABLE  =>DAL
        public DataSet GetAllRequestDAL()
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("GetAllRequest", conn);
            DataSet ds = new DataSet("Requests");
            da.Fill(ds);
            return ds;
        }
        //DELETE THE BOOK REQUEST FROM REQUEST TABLE =>DAL
        public bool DeleteRequestDAL(int bookId, int userId)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("DeleteRequest @bId, @uId", conn);
            cmd.Parameters.Add(new SqlParameter("@bId", bookId));
            cmd.Parameters.Add(new SqlParameter("@uId", userId));
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
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
