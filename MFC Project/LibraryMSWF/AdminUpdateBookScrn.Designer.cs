namespace LibraryMSWF
{
    partial class AdminUpdateBookScrn
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
            this.tbBCopy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbBCopy
            // 
            this.tbBCopy.Location = new System.Drawing.Point(130, 198);
            this.tbBCopy.Name = "tbBCopy";
            this.tbBCopy.Size = new System.Drawing.Size(162, 20);
            this.tbBCopy.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Book Copies";
            // 
            // tbBPrice
            // 
            this.tbBPrice.Location = new System.Drawing.Point(130, 159);
            this.tbBPrice.Name = "tbBPrice";
            this.tbBPrice.Size = new System.Drawing.Size(162, 20);
            this.tbBPrice.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Book Price";
            // 
            // tbBISBN
            // 
            this.tbBISBN.Location = new System.Drawing.Point(130, 119);
            this.tbBISBN.Name = "tbBISBN";
            this.tbBISBN.Size = new System.Drawing.Size(162, 20);
            this.tbBISBN.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Book ISBN";
            // 
            // tbBAuthor
            // 
            this.tbBAuthor.Location = new System.Drawing.Point(130, 80);
            this.tbBAuthor.Name = "tbBAuthor";
            this.tbBAuthor.Size = new System.Drawing.Size(162, 20);
            this.tbBAuthor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Author Name";
            // 
            // tbBName
            // 
            this.tbBName.Location = new System.Drawing.Point(130, 40);
            this.tbBName.Name = "tbBName";
            this.tbBName.Size = new System.Drawing.Size(162, 20);
            this.tbBName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Book Name";
            // 
            // AdminUpdateBookScrn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(328, 308);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbBCopy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBName);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "AdminUpdateBookScrn";
            this.Text = "Update Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbBCopy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBName;
        private System.Windows.Forms.Label label1;
    }
}