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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        //OPEN USER LOGIN WINDOW
        private void UserPic_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
        }
        //OPEN ADMIN LOGIN WINDOW
        private void AdminPic_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
        }
    }
}
