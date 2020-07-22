using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using LibraryMSWF.DAL;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.BL
{
    public class UserRecieveBL
    {
        //ADD THE RECIEVED BOOK INTO RECIEVED TABLE =>BL
        public bool AddRecieveBL(int bookId, string bookName, int userId, string userName)
        {
            UserRecieveDAL userRecieveDAL = new UserRecieveDAL();
            bool isDone = userRecieveDAL.AddRecieveDAL(bookId,bookName,userId,userName);
            return isDone;
        }
        //RETURN THE COMPLETE RECIEVED BOOKS FROM RECIEVED TABLE  =>BL
        public DataSet GetAllRecieveDAL()
        {
            UserRecieveDAL userRecieveDAL = new UserRecieveDAL();
            DataSet ds = userRecieveDAL.GetAllRecieveDAL();
            return ds;
        }
        //RETURN THE PERTICULAR USER RECIEVED BOOKS FROM RECIEVED TABLE  =>BL
        public DataSet GetAllRecieveUserBL(int userId)
        {
            UserRecieveDAL userRecieveDAL = new UserRecieveDAL();
            DataSet ds = userRecieveDAL.GetAllRecieveUserDAL(userId);
            return ds;
        }
        //DELETE THE RECIEVED BOOK FROM RECIEVED TABLE =>BL
        public bool DeleteRecieveBL(int bookId, int userId)
        {
            UserRecieveDAL userRecieveDAL = new UserRecieveDAL();
            bool isDone = userRecieveDAL.DeleteRecieveDAL(bookId, userId);
            return isDone;
        }

    }
}
