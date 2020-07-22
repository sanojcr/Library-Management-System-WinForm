namespace LibraryMSWF
{
    partial class UserHomescreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnUserBorrow = new System.Windows.Forms.Button();
            this.btnUserRequested = new System.Windows.Forms.Button();
            this.userBorrow1 = new LibraryMSWF.UserBorrow();
            this.userTransaction1 = new LibraryMSWF.UserTransaction();
            this.SuspendLayout();
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Location = new System.Drawing.Point(8, 341);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(113, 23);
            this.btnAdminLogout.TabIndex = 12;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = true;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnUserBorrow
            // 
            this.btnUserBorrow.Location = new System.Drawing.Point(8, 19);
            this.btnUserBorrow.Name = "btnUserBorrow";
            this.btnUserBorrow.Size = new System.Drawing.Size(113, 23);
            this.btnUserBorrow.TabIndex = 10;
            this.btnUserBorrow.Text = "Borrow";
            this.btnUserBorrow.UseVisualStyleBackColor = true;
            this.btnUserBorrow.Click += new System.EventHandler(this.btnUserBorrow_Click);
            // 
            // btnUserRequested
            // 
            this.btnUserRequested.Location = new System.Drawing.Point(8, 48);
            this.btnUserRequested.Name = "btnUserRequested";
            this.btnUserRequested.Size = new System.Drawing.Size(113, 23);
            this.btnUserRequested.TabIndex = 11;
            this.btnUserRequested.Text = "Transaction";
            this.btnUserRequested.UseVisualStyleBackColor = true;
            this.btnUserRequested.Click += new System.EventHandler(this.btnUserRequested_Click);
            // 
            // userBorrow1
            // 
            this.userBorrow1.Location = new System.Drawing.Point(113, 0);
            this.userBorrow1.Name = "userBorrow1";
            this.userBorrow1.Size = new System.Drawing.Size(764, 382);
            this.userBorrow1.TabIndex = 14;
            // 
            // userTransaction1
            // 
            this.userTransaction1.Location = new System.Drawing.Point(110, 0);
            this.userTransaction1.Name = "userTransaction1";
            this.userTransaction1.Size = new System.Drawing.Size(764, 384);
            this.userTransaction1.TabIndex = 15;
            // 
            // UserHomescreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 382);
            this.Controls.Add(this.btnAdminLogout);
            this.Controls.Add(this.btnUserBorrow);
            this.Controls.Add(this.btnUserRequested);
            this.Controls.Add(this.userTransaction1);
            this.Controls.Add(this.userBorrow1);
            this.MaximizeBox = false;
            this.Name = "UserHomescreen";
            this.Text = "User Homescreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Button btnUserBorrow;
        private System.Windows.Forms.Button btnUserRequested;
        private UserBorrow userBorrow1;
        private UserTransaction userTransaction1;
    }
}