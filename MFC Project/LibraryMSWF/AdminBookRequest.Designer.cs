namespace LibraryMSWF
{
    partial class AdminBookRequest
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
            this.dgvRequestDetails = new System.Windows.Forms.DataGridView();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequestDetails
            // 
            this.dgvRequestDetails.AccessibleName = "RequestsDetails";
            this.dgvRequestDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestDetails.Location = new System.Drawing.Point(15, 38);
            this.dgvRequestDetails.Name = "dgvRequestDetails";
            this.dgvRequestDetails.Size = new System.Drawing.Size(528, 329);
            this.dgvRequestDetails.TabIndex = 6;
            this.dgvRequestDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequestDetails_RowHeaderMouseClick);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(550, 45);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(120, 23);
            this.btnReject.TabIndex = 12;
            this.btnReject.Text = "Reject Request";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(550, 194);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(550, 16);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(120, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept Request";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Request Section";
            // 
            // AdminBookRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dgvRequestDetails);
            this.Name = "AdminBookRequest";
            this.Size = new System.Drawing.Size(684, 383);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequestDetails;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
    }
}
