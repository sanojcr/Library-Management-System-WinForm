using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL
{
    public class UserRecieveDAL
    {
        //ADD THE RECIEVED BOOK INTO RECIEVED TABLE =>DAL
        public bool AddRecieveDAL(int bookId, string bookName, int userId, string userName)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("AddRecieve @bId, @bName, @date, @uId, @uName", conn);
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
        //RETURN THE COMPLETE RECIEVED BOOKS FROM RECIEVED TABLE  =>DAL
        public DataSet GetAllRecieveDAL()
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("GetAllRecieve", conn);
            DataSet ds = new DataSet("Recieved");
            da.Fill(ds);
            return ds;
        }
        //RETURN THE PERTICULAR USER RECIEVED BOOKS FROM RECIEVED TABLE  =>DAL
        public DataSet GetAllRecieveUserDAL(int userId)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("GetAllRecieveUser " + userId + "", conn);
            DataSet ds = new DataSet("UserRecieved");
            da.Fill(ds);
            return ds;
        }
        //DELETE THE RECIEVED BOOK FROM RECIEVED TABLE =>DAL
        public bool DeleteRecieveDAL(int bookId, int userId)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("DeleteRecieve @bId, @uId", conn);
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
