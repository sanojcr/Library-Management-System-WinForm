using System;
using LibraryMSWF.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.BL
{
    public class UserRequestBL
    {
        //ADD THE BOOK REQUEST INTO REQUEST TABLE =>BL
        public bool AddRequestBL(int bookId, string bookName, int userId)
        {
            UserDAL userDAL = new UserDAL();
            string userName = userDAL.TakeUserNameDAL(userId);
            UserRequestDAL userRequestDAL = new UserRequestDAL();
            bool isDone=userRequestDAL.AddRequestDAL(bookId, bookName, userId, userName);
            return isDone;
        }
        //RETURN THE PERTICULAR USER REQUESTED BOOKS FROM REQUEST TABLE  =>BL
        public DataSet GetAllRequestUserBL(int userId)
        {
            UserRequestDAL userRequestDAL = new UserRequestDAL();
            DataSet ds = userRequestDAL.GetAllRequestUserDAL(userId);
            return ds;
        }
        //RETURN THE COMPLETE REQUESTED BOOKS FROM REQUEST TABLE  =>BL
        public DataSet GetAllRequestBL()
        {
            UserRequestDAL userRequestDAL = new UserRequestDAL();
            DataSet ds = userRequestDAL.GetAllRequestDAL();
            return ds;
        }
        //DELETE THE BOOK REQUEST FROM REQUEST TABLE =>BL
        public bool DeleteRequestBL(int bookId, int userId)
        {
            UserRequestDAL userRequestDAL = new UserRequestDAL();
            bool isDone=userRequestDAL.DeleteRequestDAL(bookId, userId);
            return isDone;
        }
    }
}
