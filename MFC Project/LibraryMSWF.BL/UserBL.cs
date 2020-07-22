using System;
using System.Collections.Generic;
using LibraryMSWF.DAL;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.BL
{
    public class UserBL
    {
        //VALIDATION METHOD FOR VALIDATE USER DETAILS => BL
        public string UserValidate(string userName, int userAdNo, string userEmail, string userPass)
        {

            if (userName.Equals(string.Empty) || userName.Length > 15 || userName.Length < 4)
            {
                return "Invalid user name, ";
            }
            else if (userEmail.Equals(string.Empty) || userEmail.Length > 15 || userEmail.Length < 4)
            {
                return "Invalid user email , ";
            }
            else if (userPass.Equals(string.Empty) || userPass.Length > 15 || userPass.Length < 6)
            {
                return "Invalid user password , ";
            }
            else if (userAdNo == 0 || userAdNo <= 1000)
            {
                return "Invalid user admission number, ";
            }
            else
            {
                return "true";
            }

        }

        //RETURN COMPLETE USERS FROM USER TABLE =>BL
        public DataSet GetAllUsersBL()
        {
            UserDAL userBl = new UserDAL();
            DataSet ds = userBl.GetAllUsersDAL();
            return ds;
        }
        /*public bool AddUserBL(string userName, int userAdNo, string userEmail, string userPass)
        {
            UserDAL userDAL = new UserDAL();
            bool isDone = userDAL.AddUserDAL(userName, userAdNo, userEmail, userPass);
            return isDone;
        }*/

        //ADD USER INTO USER TABLE =>BL
        public string AddUserBL(string userName, int userAdNo, string userEmail, string userPass)
        {
            string isUserValid = UserValidate(userName, userAdNo, userEmail, userPass);
            if (isUserValid=="true")
            {
                UserDAL userDAL = new UserDAL();
                bool isDone = userDAL.AddUserDAL(userName, userAdNo, userEmail, userPass);
                if (isDone!=true)
                {
                    return "Server error ,";
                }
                else
                {
                    return "true";
                }
            }
            else
            {
                return isUserValid;
            }
        }
        //UPDATE THE USER FROM USER TABLE =>BL
        public bool UpdateUserBL(int userId, string userName, int userAdNo, string userEmail, string userPass)
        {
            UserDAL userDAL = new UserDAL();
            bool isDone = userDAL.UpdateUserDAL(userId, userName, userAdNo, userEmail, userPass);
            return isDone;
        }
        //DELETE THE USER FROM USER TABLE =>BL
        public bool DeleteUserBL(int userId)
        {
            UserDAL userDAL = new UserDAL();
            bool isDone = userDAL.DeleteUserDAL(userId);
            return isDone;
        }
        //CHECK THE USER LOGIN CREDENTIALS RETURN USER ID =>BL
        public int UserLoginBL(string userEmail, string userPass)
        {
            UserDAL userDAL = new UserDAL();
            int isDone = userDAL.UserLoginDAL(userEmail,userPass);
            return isDone;
        }
    }
}
