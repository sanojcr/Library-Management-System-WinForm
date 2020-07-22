namespace LibraryMSWF
{
    partial class UserForm
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
            this.UserLoginPic = new System.Windows.Forms.PictureBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.tbUserPass = new System.Windows.Forms.TextBox();
            this.AdminPass = new System.Windows.Forms.Label();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.AdminId = new System.Windows.Forms.Label();
            this.alertUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserLoginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLoginPic
            // 
            this.UserLoginPic.BackColor = System.Drawing.Color.Transparent;
            this.UserLoginPic.Image = global::LibraryMSWF.Properties.Resources.icons8_user_100;
            this.UserLoginPic.Location = new System.Drawing.Point(21, 24);
            this.UserLoginPic.Name = "UserLoginPic";
            this.UserLoginPic.Size = new System.Drawing.Size(158, 166);
            this.UserLoginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserLoginPic.TabIndex = 0;
            this.UserLoginPic.TabStop = false;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(214, 172);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAdminLogin.TabIndex = 11;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // tbUserPass
            // 
            this.tbUserPass.Location = new System.Drawing.Point(214, 133);
            this.tbUserPass.Name = "tbUserPass";
            this.tbUserPass.PasswordChar = '*';
            this.tbUserPass.Size = new System.Drawing.Size(152, 20);
            this.tbUserPass.TabIndex = 10;
            // 
            // AdminPass
            // 
            this.AdminPass.AutoSize = true;
            this.AdminPass.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPass.Location = new System.Drawing.Point(210, 95);
            this.AdminPass.Name = "AdminPass";
            this.AdminPass.Size = new System.Drawing.Size(71, 24);
            this.AdminPass.TabIndex = 9;
            this.AdminPass.Text = "Password";
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(214, 60);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(152, 20);
            this.tbUserEmail.TabIndex = 8;
            // 
            // AdminId
            // 
            this.AdminId.AutoSize = true;
            this.AdminId.Font = new System.Drawing.Font("Pristina", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminId.Location = new System.Drawing.Point(206, 21);
            this.AdminId.Name = "AdminId";
            this.AdminId.Size = new System.Drawing.Size(74, 24);
            this.AdminId.TabIndex = 7;
            this.AdminId.Text = "Email ID";
            // 
            // alertUser
            // 
            this.alertUser.AutoSize = true;
            this.alertUser.Location = new System.Drawing.Point(217, 209);
            this.alertUser.Name = "alertUser";
            this.alertUser.Size = new System.Drawing.Size(0, 13);
            this.alertUser.TabIndex = 12;
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 244);
            this.Controls.Add(this.UserLoginPic);
            this.Controls.Add(this.alertUser);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.tbUserPass);
            this.Controls.Add(this.AdminPass);
            this.Controls.Add(this.tbUserEmail);
            this.Controls.Add(this.AdminId);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "User Login";
            ((System.ComponentModel.ISupportInitialize)(this.UserLoginPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserLoginPic;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox tbUserPass;
        private System.Windows.Forms.Label AdminPass;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.Label AdminId;
        private System.Windows.Forms.Label alertUser;
    }
}