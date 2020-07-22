using System;
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
    public partial class UserHomescreen : Form
    {
        public UserHomescreen()
        {
            InitializeComponent();
            userTransaction1.Hide();
            userBorrow1.Hide();
            userBorrow1.Show();
        }
        //SHOW BOOK BORROW MENU
        private void btnUserBorrow_Click(object sender, EventArgs e)
        {
            userTransaction1.Hide();
            userBorrow1.Show();
        }
        //SHOW BOOK REQUEST AND BOOK RECIEVED MENU
        private void btnUserRequested_Click(object sender, EventArgs e)
        { 
            userBorrow1.Hide();
            userTransaction1.Show();
        }
        //LOGOUT USER HOMESCREEN
        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
