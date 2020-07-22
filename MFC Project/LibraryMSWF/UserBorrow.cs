using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using LibraryMSWF.BL;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF
{
    public partial class UserBorrow : UserControl
    {   
        //VARIABLES USED TO STORE THE BORROW BOOK ROW HEADER CLICK EVENT =>PL
        public int BookId;
        public string BookName;
        public string BookAuthor;
        public string BookISBN;
        public double BookPrice;
        public int BookCopy;

        public int userId;
        public UserBorrow()
        {
            InitializeComponent();
            userId = UserForm.UserId;
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.GetAllBooksBL();
            dgvBookDetails.DataSource = ds.Tables[0];
        }
        //REFRESH BORROW BOOK GRID VIEW =>PL
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BookBL bookBl = new BookBL();
            DataSet ds = bookBl.GetAllBooksBL();
            dgvBookDetails.DataSource = ds.Tables[0];
        }
        //BORROW BOOK ROW HEADER CLICK EVENT =>PL
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
        //REQUEST TO BORROW A BOOK FROM BORROW BOOK TABLE =>PL
        private void btnRequestBook_Click(object sender, EventArgs e)
        {
            if (BookId > 0)
            {
                if (BookCopy == 0)
                {
                    MessageBox.Show("Book is empty...");
                }
                else
                {
                    BookCopy = BookCopy - 1;
                    BookBL bookBL = new BookBL();
                    UserRequestBL userRequestBL = new UserRequestBL();
                    bool isDone1 = bookBL.UpdateBookBL(BookId, BookName, BookAuthor, BookISBN, BookPrice, BookCopy);
                    bool isDone2 = userRequestBL.AddRequestBL(BookId, BookName, userId);
                    if (isDone1==true && isDone2==true)
                    {
                        MessageBox.Show("Requested successfully..");
                    }
                    else
                    {
                        MessageBox.Show("Try again..");
                    }

                }
            }
            else
            {
                MessageBox.Show("Select a book to request...");
            }
        }
    }
}
