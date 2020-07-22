namespace LibraryMSWF
{
    partial class AdminUpdateUserScrn
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbUPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUAdNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbUPass
            // 
            this.tbUPass.Location = new System.Drawing.Point(130, 160);
            this.tbUPass.Name = "tbUPass";
            this.tbUPass.Size = new System.Drawing.Size(162, 20);
            this.tbUPass.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Password";
            // 
            // tbUEmail
            // 
            this.tbUEmail.Location = new System.Drawing.Point(130, 120);
            this.tbUEmail.Name = "tbUEmail";
            this.tbUEmail.Size = new System.Drawing.Size(162, 20);
            this.tbUEmail.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // tbUAdNo
            // 
            this.tbUAdNo.Location = new System.Drawing.Point(130, 81);
            this.tbUAdNo.Name = "tbUAdNo";
            this.tbUAdNo.Size = new System.Drawing.Size(162, 20);
            this.tbUAdNo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Admission No";
            // 
            // tbUName
            // 
            this.tbUName.Location = new System.Drawing.Point(130, 41);
            this.tbUName.Name = "tbUName";
            this.tbUName.Size = new System.Drawing.Size(162, 20);
            this.tbUName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "User Name";
            // 
            // AdminUpdateUserScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 274);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbUPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUAdNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUName);
            this.Controls.Add(this.label1);
            this.Name = "AdminUpdateUserScrn";
            this.Text = "Update User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbUPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUAdNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUName;
        private System.Windows.Forms.Label label1;
    }
}