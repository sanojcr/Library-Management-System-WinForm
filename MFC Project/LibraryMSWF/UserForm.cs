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
    public partial class UserForm : Form
    {
        public static int UserId;
        public UserForm()
        {
            InitializeComponent();
        }
        //CHECK THE USER CREDENTIALS AND OPEN USER HOMESCREEN WINDOW =>PL
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if ((tbUserEmail.Text != string.Empty || tbUserPass.Text != string.Empty) || (tbUserEmail.Text != string.Empty && tbUserPass.Text != string.Empty))
            {
                UserBL userBL = new UserBL();
                int isDone = userBL.UserLoginBL(tbUserEmail.Text, tbUserPass.Text);
                if (isDone!=0)
                {
                    UserId = isDone;
                    alertUser.Text = "";
                    MessageBox.Show("Logged in successfully...");
                    UserHomescreen userHomescreen = new UserHomescreen();
                    userHomescreen.Show();
                    tbUserEmail.Clear();
                    tbUserPass.Clear();
                }
                else
                {
                    alertUser.ForeColor = Color.Red;
                    alertUser.Text = "Invalid email id or password...";
                    tbUserEmail.Clear();
                    tbUserPass.Clear();
                }
            }
            else
            {
                alertUser.ForeColor = Color.Red;
                alertUser.Text = "Enter the fields properly...";

            }
        }
    }
}
