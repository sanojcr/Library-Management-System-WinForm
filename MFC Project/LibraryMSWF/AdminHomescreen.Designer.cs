namespace LibraryMSWF
{
    partial class AdminHomescreen
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
            this.btnBookMenu = new System.Windows.Forms.Button();
            this.btnUserMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnAccepted = new System.Windows.Forms.Button();
            this.adminBookRecieve1 = new LibraryMSWF.AdminBookRecieve();
            this.adminBookRequest1 = new LibraryMSWF.AdminBookRequest();
            this.adminUser = new LibraryMSWF.AdminUser();
            this.adminBook = new LibraryMSWF.AdminBook();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookMenu
            // 
            this.btnBookMenu.Location = new System.Drawing.Point(8, 19);
            this.btnBookMenu.Name = "btnBookMenu";
            this.btnBookMenu.Size = new System.Drawing.Size(113, 23);
            this.btnBookMenu.TabIndex = 6;
            this.btnBookMenu.Text = "Books";
            this.btnBookMenu.UseVisualStyleBackColor = true;
            this.btnBookMenu.Click += new System.EventHandler(this.btnBookMenu_Click);
            // 
            // btnUserMenu
            // 
            this.btnUserMenu.Location = new System.Drawing.Point(8, 48);
            this.btnUserMenu.Name = "btnUserMenu";
            this.btnUserMenu.Size = new System.Drawing.Size(113, 23);
            this.btnUserMenu.TabIndex = 7;
            this.btnUserMenu.Text = "Users";
            this.btnUserMenu.UseVisualStyleBackColor = true;
            this.btnUserMenu.Click += new System.EventHandler(this.btnUserMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminBook);
            this.panel1.Controls.Add(this.adminBookRecieve1);
            this.panel1.Controls.Add(this.adminBookRequest1);
            this.panel1.Controls.Add(this.adminUser);
            this.panel1.Location = new System.Drawing.Point(124, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 389);
            this.panel1.TabIndex = 8;
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Location = new System.Drawing.Point(8, 341);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(113, 23);
            this.btnAdminLogout.TabIndex = 9;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = true;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.Location = new System.Drawing.Point(5, 137);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(113, 23);
            this.btnRequests.TabIndex = 10;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnAccepted
            // 
            this.btnAccepted.Location = new System.Drawing.Point(5, 166);
            this.btnAccepted.Name = "btnAccepted";
            this.btnAccepted.Size = new System.Drawing.Size(113, 23);
            this.btnAccepted.TabIndex = 11;
            this.btnAccepted.Text = "Accepted";
            this.btnAccepted.UseVisualStyleBackColor = true;
            this.btnAccepted.Click += new System.EventHandler(this.btnAccepted_Click);
            // 
            // adminBookRecieve1
            // 
            this.adminBookRecieve1.Location = new System.Drawing.Point(-11, 5);
            this.adminBookRecieve1.Name = "adminBookRecieve1";
            this.adminBookRecieve1.Size = new System.Drawing.Size(772, 380);
            this.adminBookRecieve1.TabIndex = 7;
            // 
            // adminBookRequest1
            // 
            this.adminBookRequest1.Location = new System.Drawing.Point(-13, 3);
            this.adminBookRequest1.Name = "adminBookRequest1";
            this.adminBookRequest1.Size = new System.Drawing.Size(772, 383);
            this.adminBookRequest1.TabIndex = 6;
            // 
            // adminUser
            // 
            this.adminUser.Location = new System.Drawing.Point(-12, 2);
            this.adminUser.Name = "adminUser";
            this.adminUser.Size = new System.Drawing.Size(765, 387);
            this.adminUser.TabIndex = 0;
            // 
            // adminBook
            // 
            this.adminBook.Location = new System.Drawing.Point(-12, 2);
            this.adminBook.Name = "adminBook";
            this.adminBook.Size = new System.Drawing.Size(765, 372);
            this.adminBook.TabIndex = 5;
            // 
            // AdminHomescreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 384);
            this.Controls.Add(this.btnAccepted);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.btnAdminLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBookMenu);
            this.Controls.Add(this.btnUserMenu);
            this.MaximizeBox = false;
            this.Name = "AdminHomescreen";
            this.Text = "Admin Homescreen";
            this.Load += new System.EventHandler(this.AdminHomescreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AdminBook adminBook;
        private System.Windows.Forms.Button btnBookMenu;
        private System.Windows.Forms.Button btnUserMenu;
        private AdminUser adminUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminLogout;
        private AdminBookRequest adminBookRequest1;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnAccepted;
        private AdminBookRecieve adminBookRecieve1;
    }
}