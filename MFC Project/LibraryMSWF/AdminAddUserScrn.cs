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
    public partial class AdminAddUserScrn : Form
    {
        public AdminAddUserScrn()
        {
            InitializeComponent();
        }
        //ADD THE USER DETAILS INTO USER TABEL =>PL
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbUName.Text!=string.Empty && tbUAdNo.Text!=string.Empty && tbUEmail.Text!=string.Empty && tbUPass.Text!=string.Empty)
            {
                try
                {
                    UserBL userBL = new UserBL();
                    string isDone = userBL.AddUserBL(tbUName.Text, int.Parse(tbUAdNo.Text), tbUEmail.Text, tbUPass.Text);
                    if (isDone=="true")
                    {
                        MessageBox.Show("User added successfuly..");
                    }
                    else
                    {
                        MessageBox.Show(isDone+"Try again..");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter the fields properly..");

                }
            }
            else
            {
                MessageBox.Show("Enter the fields properly..");
            }
           
        }

        private void AdminAddUserScrn_Load(object sender, EventArgs e)
        {

        }
    }
}
