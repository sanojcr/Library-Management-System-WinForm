using System;
using LibraryMSWF.BL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF
{
    public partial class UserTransaction : UserControl
    {
        //VARIABLES USED TO STORE RECIEVED BOOK ROW HEADER CLICK EVENT
        public static int BookId;
        int UserId;
        public UserTransaction()
        {
            InitializeComponent();
            UserId = UserForm.UserId;
            UserRequestBL userRequestBL = new UserRequestBL();
            DataSet ds1 = userRequestBL.GetAllRequestUserBL(UserId);
            dgvUserRequest.DataSource = ds1.Tables[0];
            UserRecieveBL userRecieveBL = new UserRecieveBL();
            DataSet ds2 = userRecieveBL.GetAllRecieveUserBL(UserId);
            dgvUserRecieve.DataSource = ds2.Tables[0];
        }

        private void dgvUserRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //REFRESH REQUESTED BOOK GRID VIEW
        private void btnReqRefresh_Click(object sender, EventArgs e)
        {
            UserId = UserForm.UserId;
            UserRequestBL userRequestBL = new UserRequestBL();
            DataSet ds1 = userRequestBL.GetAllRequestUserBL(UserId);
            dgvUserRequest.DataSource = ds1.Tables[0];
        }
        //REFRESH RECIEVED BOOK GRID VIEW
        private void btnRecRefresh_Click(object sender, EventArgs e)
        {
            UserId = UserForm.UserId;
            UserRecieveBL userRecieveBL = new UserRecieveBL();
            DataSet ds2 = userRecieveBL.GetAllRecieveUserBL(UserId);
            dgvUserRecieve.DataSource = ds2.Tables[0];
        }
        //DELETE RECIEVED BOOK FROM RECIEVED BOOK TABLE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BookId>0)
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
        private void dgvUserRecieve_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BookId= int.Parse(dgvUserRecieve.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Select a book properly...");
            }
        }
    }
}
