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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void tbAdminPass_TextChanged(object sender, EventArgs e)
        {

        }
        //CHECK THE ADMIN LOGIN CREDENTIALS AND OPEN ADMIN HOMESCREEN =>PL
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if ((tbAdminEmail.Text !=string.Empty || tbAdminPass.Text !=string.Empty) || (tbAdminEmail.Text != string.Empty && tbAdminPass.Text != string.Empty))
            {
                AdminBL adminBl = new AdminBL();
                bool isDone = adminBl.AdminLoginBL(tbAdminEmail.Text, tbAdminPass.Text);
                if (isDone)
                {
                    alertAdmin.Text = "";
                    MessageBox.Show("Logged in successfully...");
                    AdminHomescreen adminHomescreen = new AdminHomescreen();
                    adminHomescreen.Show();
                    tbAdminEmail.Clear();
                    tbAdminPass.Clear();
                }
                else
                {
                    alertAdmin.ForeColor = Color.Red;
                    alertAdmin.Text = "Invalid email id or password...";
                    tbAdminEmail.Clear();
                    tbAdminPass.Clear();
                }
            }
            else
            {
                alertAdmin.ForeColor = Color.Red;
                alertAdmin.Text = "Enter the fields properly...";
                
            }
            
        }
        private void tbAdminEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
