using System;
using System.Collections.Generic;
using System.ComponentModel;
using LibraryMSWF.BL;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF
{
    public partial class AdminUpdateBookScrn : Form
    {
        public int bookId;
        public AdminUpdateBookScrn()
        {
            InitializeComponent();
            //STORING BOOK DETAILS FROM BOOK GRID VIEW
            this.bookId = AdminBook.BookId;
            tbBName.Text = AdminBook.BookName;
            tbBAuthor.Text = AdminBook.BookAuthor;
            tbBISBN.Text = AdminBook.BookISBN;
            tbBPrice.Text = AdminBook.BookPrice.ToString();
            tbBCopy.Text = AdminBook.BookCopy.ToString();

        }
        //UPDATE BOOK DETAILS FROM BOOK TABLE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BookBL bookBL = new BookBL();
                bool isDone = bookBL.UpdateBookBL(this.bookId, tbBName.Text, tbBAuthor.Text, tbBISBN.Text, double.Parse(tbBPrice.Text), int.Parse(tbBCopy.Text));
                if (isDone)
                {
                    MessageBox.Show("Book updated successfuly..");
                }
                else
                {
                    MessageBox.Show("Try later..");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Enter the fields properly...");
            }

            /*try
            {
                BookBL bookBL = new BookBL();
                bool isDone = bookBL.UpdateBookBL(this.bookId, tbBName.Text, tbBAuthor.Text, tbBISBN.Text, double.Parse(tbBPrice.Text), int.Parse(tbBCopy.Text));
                if (isDone)
                {
                    MessageBox.Show("Book updated successfuly..");
                }
                else
                {
                    MessageBox.Show("Try later..");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Enter the fields properly...");
            }*/

        }
    }
}
