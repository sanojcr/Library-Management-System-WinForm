using System;
using LibraryMSWF.BL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF
{
    public partial class AdminAddBookScrn : Form
    {
        public AdminAddBookScrn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void AdminAddBookScrn_Load(object sender, EventArgs e)
        {

        }
        //ADD THE BOOKS DETAILS INTO BOOK TABEL =>PL
        private void btnAdd_Click(object sender, EventArgs e)
        {          
            if (tbBName.Text != string.Empty && tbBAuthor.Text != string.Empty && tbBISBN.Text != string.Empty && tbBPrice.Text != string.Empty &&
                tbBCopy.Text != string.Empty
                )
            {
                try
                {
                    BookBL bookBL = new BookBL();
                    string isDone = bookBL.AddBookBL(tbBName.Text, tbBAuthor.Text, tbBISBN.Text, double.Parse(tbBPrice.Text), int.Parse(tbBCopy.Text));
                    if (isDone=="true")
                    {
                        MessageBox.Show("Book added successfuly..");
                    }
                    else
                    {
                        MessageBox.Show(isDone+"Try again..");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter the fields properly...");
                }
            }
            else
            {
                MessageBox.Show("Enter the fields properly..");
            }


            /*if (tbBName.Text!=string.Empty && tbBAuthor.Text!= string.Empty && tbBISBN.Text != string.Empty && tbBPrice.Text != string.Empty &&
                tbBCopy.Text != string.Empty
                )
                {
                try
                    {
                        BookBL bookBL = new BookBL();
                        bool isDone = bookBL.AddBookBL(tbBName.Text, tbBAuthor.Text, tbBISBN.Text, double.Parse(tbBPrice.Text), int.Parse(tbBCopy.Text));
                        if (isDone)
                        {
                        MessageBox.Show("Book added successfuly..");
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
            }
            else
            {
                MessageBox.Show("Enter the fields properly..");
            }*/
        }
    }
}
