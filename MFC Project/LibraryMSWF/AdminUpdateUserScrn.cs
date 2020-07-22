using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using LibraryMSWF.BL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF
{
    public partial class AdminUpdateUserScrn : Form
    {
        public int userId;
        
        public AdminUpdateUserScrn()
        {
            InitializeComponent();
            //STORING USER DETAILS FROM USER GRID VIEW
            userId = AdminUser.UserId;
            tbUName.Text = AdminUser.UserName;
            tbUAdNo.Text = AdminUser.UserAdNO.ToString();
            tbUEmail.Text = AdminUser.UserEmail;
            tbUPass.Text = AdminUser.UserPass;
        }
        //UPDATE USER DETAILS FROM USER TABLE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UserBL userBL = new UserBL();
                bool isDone = userBL.UpdateUserBL(userId, tbUName.Text, int.Parse(tbUAdNo.Text), tbUEmail.Text, tbUPass.Text);
                if (isDone)
                {
                    MessageBox.Show("User updated successfuly..");
                }
                else
                {
                    MessageBox.Show("Try later..");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the fields properly..");
            }
           

        }
    }
}
