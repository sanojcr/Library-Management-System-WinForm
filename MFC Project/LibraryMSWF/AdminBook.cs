using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using LibraryMSWF.BL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF
{
    public partial class AdminBook : UserControl
    {
        //VARIABLES USED TO STORE BOOK GRID VIEW CLICK ROW HEADER EVENT
        public static int BookId;
        public static string BookName;
        public static string BookAuthor;
        public static string BookISBN;
        public static double BookPrice;
        public static int BookCopy;
        public AdminBook()
        {
            InitializeComponent();
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.GetAllBooksBL();
            dgvBookDetails.DataSource = ds.Tables[0];
        }

        //OPEN ADD BOOK WINDOW =>PL
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AdminAddBookScrn adminAddBook = new AdminAddBookScrn();
            adminAddBook.Show();
        }
        //OPEN UPDATE BOOK WINDOW =>PL
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (BookId > 0)
            {
                AdminUpdateBookScrn adminUpdateBook = new AdminUpdateBookScrn();
                adminUpdateBook.Show();
            }
            else
            {
                MessageBox.Show("Select a book to update...");
            }
        }
        //DELETE THE BOOK FROM BOOK TABLE =>PL
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (BookId > 0)
            {
                BookBL bookBL = new BookBL();
                bool isDone = bookBL.DeleteBookBL(BookId);
                if (isDone)
                {
                    MessageBox.Show("Book deleted successfuly..");
                }
                else
                {
                    MessageBox.Show("Try later..");
                }
            }
            else
            {
                MessageBox.Show("Select a book to delete...");
            }
        }
        //REFRESH THE BOOK GRID VIEW =>PL
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.GetAllBooksBL();
            dgvBookDetails.DataSource = ds.Tables[0];
        }
        //BOOK GRID VIEW ROW HEADER CLICK EVENT =>PL
        private void dgvBookDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BookId = int.Parse(dgvBookDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                BookName = dgvBookDetails.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
                BookAuthor = dgvBookDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                BookISBN = dgvBookDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
                BookPrice = double.Parse(dgvBookDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
                BookCopy = int.Parse(dgvBookDetails.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Select a book properly...");
            }
            
        }
        
        private void dgvBookDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
