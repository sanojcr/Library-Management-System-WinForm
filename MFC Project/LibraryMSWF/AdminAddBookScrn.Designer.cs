namespace LibraryMSWF
{
    partial class AdminAddBookScrn
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBName = new System.Windows.Forms.TextBox();
            this.tbBAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBCopy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // tbBName
            // 
            this.tbBName.Location = new System.Drawing.Point(124, 40);
            this.tbBName.Name = "tbBName";
            this.tbBName.Size = new System.Drawing.Size(162, 20);
            this.tbBName.TabIndex = 1;
            // 
            // tbBAuthor
            // 
            this.tbBAuthor.Location = new System.Drawing.Point(124, 80);
            this.tbBAuthor.Name = "tbBAuthor";
            this.tbBAuthor.Size = new System.Drawing.Size(162, 20);
            this.tbBAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author Name";
            // 
            // tbBPrice
            // 
            this.tbBPrice.Location = new System.Drawing.Point(124, 159);
            this.tbBPrice.Name = "tbBPrice";
            this.tbBPrice.Size = new System.Drawing.Size(162, 20);
            this.tbBPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Book Price";
            // 
            // tbBISBN
            // 
            this.tbBISBN.Location = new System.Drawing.Point(124, 119);
            this.tbBISBN.Name = "tbBISBN";
            this.tbBISBN.Size = new System.Drawing.Size(162, 20);
            this.tbBISBN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book ISBN";
            // 
            // tbBCopy
            // 
            this.tbBCopy.Location = new System.Drawing.Point(124, 198);
            this.tbBCopy.Name = "tbBCopy";
            this.tbBCopy.Size = new System.Drawing.Size(162, 20);
            this.tbBCopy.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Book Copies";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AdminAddBookScrn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(329, 308);
            this.Controls.Add(this.btnAdd);
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
            this.MaximizeBox = false;
            this.Name = "AdminAddBookScrn";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AdminAddBookScrn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBName;
        private System.Windows.Forms.TextBox tbBAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBCopy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
    }
}