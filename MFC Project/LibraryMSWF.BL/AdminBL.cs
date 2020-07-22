using System;
using LibraryMSWF.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.BL
{
    //CHECK THE ADMIN LOGIN CREDENTIALS =>BL
    public class AdminBL
    {
        public bool AdminLoginBL(string adminEmail, string adminPass)
        {
            AdminDAL adminDal = new AdminDAL();
            bool isDone = adminDal.AdminLoginDAL(adminEmail, adminPass);
            return isDone;
        }
    }
}
