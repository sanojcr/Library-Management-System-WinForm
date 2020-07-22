using System;
using System.Collections.Generic;
using System.ComponentModel;
using LibraryMSWF.BL;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF
{
    public partial class AdminBookRequest : UserControl
    {
        //VARIABLES USED TO STORE REQUESTED GRID VIEW CLICK ROW HEADER EVENT =>PL
        public static int BookId;
        public static string BookName;
        public static string DateRequested;
        public static int UserId;
        public static string UserName;
        
        public AdminBookRequest()
        {
            InitializeComponent();
            UserRequestBL userRequestBL = new UserRequestBL();
            DataSet ds = userRequestBL.GetAllRequestBL();
            dgvRequestDetails.DataSource = ds.Tables[0];
        }
        //REFRESH THE REQUESTED BOOK GRID VIEW =>PL
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UserRequestBL userRequestBL = new UserRequestBL();
            DataSet ds = userRequestBL.GetAllRequestBL();
            dgvRequestDetails.DataSource = ds.Tables[0];
        }
        //REQUESTED BOOK GRID VIEW ROW HEADER CLICK EVENT
        private void dgvRequestDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BookId = int.Parse(dgvRequestDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                BookName = dgvRequestDetails.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
                DateRequested = dgvRequestDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                UserId = int.Parse(dgvRequestDetails.Rows[e.RowIndex].Cells[3].Value.ToString()); 
                UserName = dgvRequestDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a book properly...");
            }
        }
        //ACCEPT THE REQUESTED BOOK =>PL
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (BookId>0)
            {
                UserRecieveBL userRecieveBL = new UserRecieveBL();
                bool isDone1 = userRecieveBL.AddRecieveBL(BookId, BookName, UserId, UserName);
                UserRequestBL userRequest = new UserRequestBL();
                bool isDone2 = userRequest.DeleteRequestBL(BookId, UserId);
                if (isDone1 == true && isDone2 == true)
                {
                    MessageBox.Show("Accepted request successfully...");
                }
                else
                {
                    MessageBox.Show("Try again latter...");
                }
            }
            else
            {
                MessageBox.Show("Select book properly...");
            }
        }
        //REJECT THE REQUESTED BOOK =>PL
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (BookId > 0)
            {
                BookBL bookBL = new BookBL();
                bool isDone1 = bookBL.IncBookCopyBL(BookId);
                UserRequestBL userRequest = new UserRequestBL();
                bool isDone2 = userRequest.DeleteRequestBL(BookId, UserId);
                if (isDone1 == true && isDone2 == true)
                {
                    MessageBox.Show("Deleted request successfully...");
                }
                else
                {
                    MessageBox.Show("Try again latter...");
                }
            }
            else
            {
                MessageBox.Show("Select book properly...");
            }
        }
    }
}
