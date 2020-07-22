namespace LibraryMSWF
{
    partial class WelcomeForm
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
            this.WelcmLb = new System.Windows.Forms.Label();
            this.LoginLb = new System.Windows.Forms.Label();
            this.UserLb = new System.Windows.Forms.Label();
            this.AdminLb = new System.Windows.Forms.Label();
            this.AdminPic = new System.Windows.Forms.PictureBox();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcmLb
            // 
            this.WelcmLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcmLb.AutoSize = true;
            this.WelcmLb.Font = new System.Drawing.Font("Stencil Std", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcmLb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcmLb.Location = new System.Drawing.Point(49, 30);
            this.WelcmLb.Name = "WelcmLb";
            this.WelcmLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WelcmLb.Size = new System.Drawing.Size(541, 26);
            this.WelcmLb.TabIndex = 0;
            this.WelcmLb.Text = "Welcome to ABC Library Management System";
            this.WelcmLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginLb
            // 
            this.LoginLb.AutoSize = true;
            this.LoginLb.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLb.Location = new System.Drawing.Point(279, 81);
            this.LoginLb.Name = "LoginLb";
            this.LoginLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginLb.Size = new System.Drawing.Size(78, 22);
            this.LoginLb.TabIndex = 1;
            this.LoginLb.Text = "Login as...";
            this.LoginLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserLb
            // 
            this.UserLb.AutoSize = true;
            this.UserLb.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLb.Location = new System.Drawing.Point(194, 244);
            this.UserLb.Name = "UserLb";
            this.UserLb.Size = new System.Drawing.Size(40, 22);
            this.UserLb.TabIndex = 4;
            this.UserLb.Text = "User";
            // 
            // AdminLb
            // 
            this.AdminLb.AutoSize = true;
            this.AdminLb.Font = new System.Drawing.Font("Pristina", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLb.Location = new System.Drawing.Point(378, 244);
            this.AdminLb.Name = "AdminLb";
            this.AdminLb.Size = new System.Drawing.Size(53, 22);
            this.AdminLb.TabIndex = 5;
            this.AdminLb.Text = "Admin";
            // 
            // AdminPic
            // 
            this.AdminPic.BackColor = System.Drawing.Color.Transparent;
            this.AdminPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminPic.Image = global::LibraryMSWF.Properties.Resources.icons8_admin_settings_male_100;
            this.AdminPic.Location = new System.Drawing.Point(326, 112);
            this.AdminPic.Name = "AdminPic";
            this.AdminPic.Size = new System.Drawing.Size(156, 129);
            this.AdminPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminPic.TabIndex = 3;
            this.AdminPic.TabStop = false;
            this.AdminPic.Click += new System.EventHandler(this.AdminPic_Click);
            // 
            // UserPic
            // 
            this.UserPic.BackColor = System.Drawing.Color.Transparent;
            this.UserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserPic.Image = global::LibraryMSWF.Properties.Resources.icons8_user_100;
            this.UserPic.Location = new System.Drawing.Point(140, 112);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(156, 129);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPic.TabIndex = 2;
            this.UserPic.TabStop = false;
            this.UserPic.Click += new System.EventHandler(this.UserPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 281);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "abcinfo@abc.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(640, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcmLb);
            this.Controls.Add(this.AdminLb);
            this.Controls.Add(this.UserLb);
            this.Controls.Add(this.AdminPic);
            this.Controls.Add(this.UserPic);
            this.Controls.Add(this.LoginLb);
            this.Font = new System.Drawing.Font("Rosewood Std Regular", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "ABC Library MS";
            ((System.ComponentModel.ISupportInitialize)(this.AdminPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcmLb;
        private System.Windows.Forms.Label LoginLb;
        private System.Windows.Forms.PictureBox UserPic;
        private System.Windows.Forms.PictureBox AdminPic;
        private System.Windows.Forms.Label UserLb;
        private System.Windows.Forms.Label AdminLb;
        private System.Windows.Forms.Label label1;
    }
}

