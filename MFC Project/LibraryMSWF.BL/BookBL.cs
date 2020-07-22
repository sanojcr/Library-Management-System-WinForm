using System;
using System.Collections.Generic;
using System.Linq;
using LibraryMSWF.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.BL
{
    public class BookBL
    {
        //VALIDATION METHOD FOR VALIDATE BOOK DETAILS
        public string BookValidate(string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            
            if (bookName.Equals(string.Empty)||bookName.Length>15 || bookName.Length<4)
            {
                return "Invalid book name, ";
            }
            else if(bookAuthor.Equals(string.Empty) || bookAuthor.Length > 15 || bookAuthor.Length < 4)
            {
                return "Invalid author name, ";
            }
            else if (bookISBN.Equals(string.Empty) || bookISBN.Length > 15 || bookISBN.Length < 4)
            {
                return "Invalid book ISBN, ";
            }
            else if(bookPrice==0 || bookPrice <= 10)
            {
                return "Invalid book price, ";
            }
            else if(bookCopies==0 || bookCopies > 200)
            {
                return "Invalid book copies, ";
            }
            else
            {
                return "true";
            }
            
        }
        //RETURN THE COMPLETE BOOKS FROM BOOK TABLE =>BL
        public DataSet GetAllBooksBL()
        {
            BookDAL bookDal = new BookDAL();
            DataSet ds = bookDal.GetAllBooksDAL();
            return ds;
        }
        /*public bool AddBookBL(string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            BookDAL bookDAL = new BookDAL();
            bool isDone = bookDAL.AddBookDAL(bookName, bookAuthor, bookISBN, bookPrice, bookCopies);
            return isDone;
        }*/
        //ADD BOOK INTO BOOK TABLE => BL
        public string AddBookBL(string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            string isBookValid = BookValidate(bookName,bookAuthor,bookISBN,bookPrice,bookCopies);
            if (isBookValid=="true")
            {
                BookDAL bookDAL = new BookDAL();
                bool isDone = bookDAL.AddBookDAL(bookName, bookAuthor, bookISBN, bookPrice, bookCopies);
                if (isDone!=true)
                {
                    return "Server error, ";
                }
                else
                {
                    return "true";
                }
            }
            else
            {
                return isBookValid;
            }
            
        }
        //UPDATE THE BOOK FROM BOOK TABLE =>BL
        /* public string UpdateBookBL(int bookId, string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
         {
             string isBookValid = BookValidate(bookName, bookAuthor, bookISBN, bookPrice, bookCopies);
             if (isBookValid == "true")
             {
                 BookDAL bookDAL = new BookDAL();
                 bool isDone = bookDAL.UpdateBookDAL(bookId, bookName, bookAuthor, bookISBN, bookPrice, bookCopies);
                 if (isDone != true)
                 {
                     return "Server error, ";
                 }
                 else
                 {
                     return "true";
                 }
             }
             else
             {
                 return isBookValid;
             }
         }*/
        public bool UpdateBookBL(int bookId, string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            BookDAL bookDAL = new BookDAL();
            bool isDone = bookDAL.UpdateBookDAL(bookId, bookName, bookAuthor, bookISBN, bookPrice, bookCopies);
            return isDone;
        }
        //DELETE THE BOOK FROM BOOK TABLE =>BL
        public bool DeleteBookBL(int bookId)
        {
            BookDAL bookDAL = new BookDAL();
            bool isDone = bookDAL.DeleteBookDAL(bookId);
            return isDone;
        }
        //INCREMENT THE BOOK COPIES OF A BOOK BY 1 =>BL
        public bool IncBookCopyBL(int bookId)
        {
            BookDAL bookDAL = new BookDAL();
            bool isDone = bookDAL.IncBookCopyDAL(bookId);
            return isDone;
        }

    }
}
