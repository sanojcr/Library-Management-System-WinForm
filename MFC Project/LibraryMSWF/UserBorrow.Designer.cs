namespace LibraryMSWF
{
    partial class UserBorrow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.btnRequestBook = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.AccessibleName = "BooksDetails";
            this.dgvBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookDetails.Location = new System.Drawing.Point(14, 43);
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.Size = new System.Drawing.Size(531, 324);
            this.dgvBookDetails.TabIndex = 6;
            this.dgvBookDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBookDetails_RowHeaderMouseClick);
            // 
            // btnRequestBook
            // 
            this.btnRequestBook.Location = new System.Drawing.Point(552, 18);
            this.btnRequestBook.Name = "btnRequestBook";
            this.btnRequestBook.Size = new System.Drawing.Size(120, 23);
            this.btnRequestBook.TabIndex = 11;
            this.btnRequestBook.Text = "Request Book";
            this.btnRequestBook.UseVisualStyleBackColor = true;
            this.btnRequestBook.Click += new System.EventHandler(this.btnRequestBook_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(553, 138);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Borrow Section";
            // 
            // UserBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRequestBook);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvBookDetails);
            this.Name = "UserBorrow";
            this.Size = new System.Drawing.Size(686, 382);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookDetails;
        private System.Windows.Forms.Button btnRequestBook;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
    }
}
