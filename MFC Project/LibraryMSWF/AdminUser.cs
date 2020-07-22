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
    public partial class AdminUser : UserControl
    {
        //VARIABLES USED TO STORE USER GRID VIEW CLICK ROW HEADER EVENT
        public static int UserId;
        public static string UserName;
        public static int UserAdNO;
        public static string UserEmail;
        public static string UserPass;

        public AdminUser()
        {
            InitializeComponent();
            UserBL userBl = new UserBL();
            DataSet ds = userBl.GetAllUsersBL();
            dgvUserDetails.DataSource = ds.Tables[0];
        }
        //DELTE USER FROM USER TABLE
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (UserId > 0)
            {
                UserBL userBL = new UserBL();
                bool isDone=userBL.DeleteUserBL(UserId);
                if (isDone==true)
                {
                    MessageBox.Show("User deleted successfully...");
                }
                else
                {
                    MessageBox.Show("Server is in maintainance try again later...");
                }
            }
            else
            {
                MessageBox.Show("Select a user to delete...");
            }
        }
        //REFRESH THE USER GRID VIEW
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UserBL userBl = new UserBL();
            DataSet ds = userBl.GetAllUsersBL();
            dgvUserDetails.DataSource = ds.Tables[0];
        }
        //OPEN ADD USER WINDOW =>PL
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AdminAddUserScrn adminAddUser = new AdminAddUserScrn();
            adminAddUser.Show();
        }
        //USER GRID VIEW ROW HEADER CLICK EVENT =>PL
        private void dgvUserDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                UserId = int.Parse(dgvUserDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                UserName = dgvUserDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                UserAdNO = int.Parse(dgvUserDetails.Rows[e.RowIndex].Cells[2].Value.ToString());
                UserEmail = dgvUserDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
                UserPass = dgvUserDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a user properly...");
            }
            
        }
        //OPEN UPDATE USER WINDOW
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (UserId > 0)
            {
                AdminUpdateUserScrn adminUpdateUser = new AdminUpdateUserScrn();
                adminUpdateUser.Show();
            }
            else
            {
                MessageBox.Show("Select a user to update...");
            }
        }
    }
}
