using System;
using LibraryMSWF.BL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMSWF
{
    public partial class AdminHomescreen : Form
    {
        public AdminHomescreen()
        {
            InitializeComponent();
            adminBookRecieve1.Hide();
            adminBookRequest1.Hide();
            adminUser.Hide();
            adminBook.Hide();
            adminBook.Show();
        }

        private void AdminHomescreen_Load(object sender, EventArgs e)
        {
           
        }

        //SHOW BOOK MENU USER CONTROLLER ONLY =>PL
        private void btnBookMenu_Click(object sender, EventArgs e)
        {
            adminBookRecieve1.Hide();
            adminBookRequest1.Hide();
            adminUser.Hide();
            adminBook.Show();
        }
        //SHOW BOOK USER USER CONTROLLER ONLY =>PL
        private void btnUserMenu_Click(object sender, EventArgs e)
        {
            adminBookRecieve1.Hide();
            adminBookRequest1.Hide();
            adminBook.Hide();
            adminUser.Show();
        }
        //LOGOUT ADMIN HOMESCREEN =>PL
        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //SHOW REQUEST MENU USER CONTROLLER ONLY =>PL
        private void btnRequests_Click(object sender, EventArgs e)
        {
            adminBookRecieve1.Hide();
            adminBook.Hide();
            adminUser.Hide();
            adminBookRequest1.Show();
        }
        //SHOW ACCEPT MENU USER CONTROLLER ONLY =>PL
        private void btnAccepted_Click(object sender, EventArgs e)
        {
            adminBookRecieve1.Hide();
            adminBook.Hide();
            adminUser.Hide();
            adminBookRequest1.Hide();
            adminBookRecieve1.Show();
        }
    }
}
