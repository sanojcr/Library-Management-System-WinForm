using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL
{
    public class UserDAL
    {
        //RETURN COMPLETE USERS FROM USER TABLE =>DAL
        public DataSet GetAllUsersDAL()
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("GetAllUsers", conn);
            DataSet ds = new DataSet("Users");
            da.Fill(ds);
            return ds;
        }
        //ADD USER INTO USER TABLE =>DAL
        public bool AddUserDAL(string userName, int userAdNo, string userEmail, string userPass)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("AddUser @name, @adno, @email, @pass", conn);
            cmd.Parameters.Add(new SqlParameter("@name", userName));
            cmd.Parameters.Add(new SqlParameter("@adno", userAdNo));
            cmd.Parameters.Add(new SqlParameter("@email", userEmail));
            cmd.Parameters.Add(new SqlParameter("@pass", userPass));
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
        //UPDATE THE USER FROM USER TABLE =>DAL
        public bool UpdateUserDAL(int userId, string userName, int userAdNo, string userEmail, string userPass)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("UpdateUser @id, @name, @adno, @email, @pass", conn);
            cmd.Parameters.Add(new SqlParameter("@id", userId));
            cmd.Parameters.Add(new SqlParameter("@name", userName));
            cmd.Parameters.Add(new SqlParameter("@adno", userAdNo));
            cmd.Parameters.Add(new SqlParameter("@email", userEmail));
            cmd.Parameters.Add(new SqlParameter("@pass", userPass));
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
        //DELETE THE USER FROM USER TABLE =>DAL
        public bool DeleteUserDAL(int userId)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("DeleteUser @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", userId));
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
        //RETURN USER NAME =>DAL
        public string TakeUserNameDAL(int userId)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("TakeUserName @userId", conn);
            cmd.Parameters.Add(new SqlParameter("@userId", userId));
            conn.Open();
            string userName = (string)cmd.ExecuteScalar();
            conn.Close();
            return userName;
        }
        //CHECK THE USER LOGIN CREDENTIALS RETURN USER ID =>DAL
        public int UserLoginDAL(string userEmail, string userPass)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
                SqlCommand cmd = new SqlCommand("UserLogin @email, @pass", conn);
                cmd.Parameters.Add(new SqlParameter("@email", userEmail));
                cmd.Parameters.Add(new SqlParameter("@pass", userPass));
                conn.Open();
                int userId = (int)cmd.ExecuteScalar();
                conn.Close();
                return userId;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
