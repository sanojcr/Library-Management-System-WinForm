using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMSWF.DAL
{
    public class BookDAL
    {
        //RETURN THE COMPLETE BOOKS FROM BOOK TABLE =>DAL
        public DataSet GetAllBooksDAL()
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("GetAllBooks", conn);
            DataSet ds = new DataSet("Books");
            da.Fill(ds);
            return ds;
        }
        //ADD BOOK INTO BOOK TABLE => DAL
        public bool AddBookDAL(string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("AddBook @name, @author,@isbn,@price,@copy", conn);
            cmd.Parameters.Add(new SqlParameter("@name", bookName));
            cmd.Parameters.Add(new SqlParameter("@author", bookAuthor));
            cmd.Parameters.Add(new SqlParameter("@isbn", bookISBN));
            cmd.Parameters.Add(new SqlParameter("@price", bookPrice));
            cmd.Parameters.Add(new SqlParameter("@copy", bookCopies));
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
        //UPDATE THE BOOK FROM BOOK TABLE =>DAL
        public bool UpdateBookDAL(int bookId, string bookName, string bookAuthor, string bookISBN, double bookPrice, int bookCopies)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("UpdateBook @id, @name, @author,@isbn,@price,@copy", conn);
            cmd.Parameters.Add(new SqlParameter("@id", bookId));
            cmd.Parameters.Add(new SqlParameter("@name", bookName));
            cmd.Parameters.Add(new SqlParameter("@author", bookAuthor));
            cmd.Parameters.Add(new SqlParameter("@isbn", bookISBN));
            cmd.Parameters.Add(new SqlParameter("@price", bookPrice));
            cmd.Parameters.Add(new SqlParameter("@copy", bookCopies));
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
        //DELETE THE BOOK FROM BOOK TABLE =>DAL
        public bool DeleteBookDAL(int bookId)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("DeleteBook @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", bookId));
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
        //INCREMENT THE BOOK COPIES OF A BOOK BY 1 =>DAL
        public bool IncBookCopyDAL(int bookId)
        {
            SqlConnection conn = new SqlConnection("Server=IAMSAN; Database=LibraryMSWF; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("IncBookCopy @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", bookId));
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
