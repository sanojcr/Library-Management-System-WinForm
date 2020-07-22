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
    public partial class AdminBookRecieve : UserControl
    {
        //VARIABLES USED TO STORE RECIEVED GRID VIEW CLICK ROW HEADER EVENT =>PL
        public static int BookId;
        public static int UserId;
        public AdminBookRecieve()
        {
            InitializeComponent();
            UserRecieveBL userRecieve = new UserRecieveBL();
            DataSet ds = userRecieve.GetAllRecieveDAL();
            dgvRecieveDetails.DataSource = ds.Tables[0];
        }
        //REFRESH THE RECIEVED BOOK GRID VIEW =>PL
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UserRecieveBL userRecieve = new UserRecieveBL();
            DataSet ds = userRecieve.GetAllRecieveDAL();
            dgvRecieveDetails.DataSource = ds.Tables[0];
        }
        //DELETE THE RECIEVED BOOK =>PL
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BookId > 0)
            {
                UserRecieveBL userRecieveBL = new UserRecieveBL();
                bool isDone1 = userRecieveBL.DeleteRecieveBL(BookId, UserId);
                BookBL bookBL = new BookBL();
                bool isDone2 = bookBL.IncBookCopyBL(BookId);
                if (isDone1 == true && isDone2 == true)
                {
                    MessageBox.Show("Book deleted successfully...");
                }
                else
                {
                    MessageBox.Show("Try again...");
                }
            }
            else
            {
                MessageBox.Show("Select a book properly...");
            }
        }
        //RECIEVED BOOK GRID VIEW ROW HEADER CLICK EVENT
        private void dgvRecieveDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BookId = int.Parse(dgvRecieveDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                UserId = int.Parse(dgvRecieveDetails.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Select a book properly...");
            }
        }
    }
}
