namespace LibraryMSWF
{
    partial class UserTransaction
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
            this.dgvUserRequest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUserRecieve = new System.Windows.Forms.DataGridView();
            this.btnReqRefresh = new System.Windows.Forms.Button();
            this.btnRecRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRecieve)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserRequest
            // 
            this.dgvUserRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRequest.Location = new System.Drawing.Point(18, 42);
            this.dgvUserRequest.Name = "dgvUserRequest";
            this.dgvUserRequest.Size = new System.Drawing.Size(320, 273);
            this.dgvUserRequest.TabIndex = 0;
            this.dgvUserRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserRequest_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requested Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recieved Books";
            // 
            // dgvUserRecieve
            // 
            this.dgvUserRecieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRecieve.Location = new System.Drawing.Point(343, 42);
            this.dgvUserRecieve.Name = "dgvUserRecieve";
            this.dgvUserRecieve.Size = new System.Drawing.Size(327, 273);
            this.dgvUserRecieve.TabIndex = 2;
            this.dgvUserRecieve.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserRecieve_RowHeaderMouseClick);
            // 
            // btnReqRefresh
            // 
            this.btnReqRefresh.Location = new System.Drawing.Point(263, 330);
            this.btnReqRefresh.Name = "btnReqRefresh";
            this.btnReqRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnReqRefresh.TabIndex = 4;
            this.btnReqRefresh.Text = "Refresh";
            this.btnReqRefresh.UseVisualStyleBackColor = true;
            this.btnReqRefresh.Click += new System.EventHandler(this.btnReqRefresh_Click);
            // 
            // btnRecRefresh
            // 
            this.btnRecRefresh.Location = new System.Drawing.Point(595, 330);
            this.btnRecRefresh.Name = "btnRecRefresh";
            this.btnRecRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRecRefresh.TabIndex = 5;
            this.btnRecRefresh.Text = "Refresh";
            this.btnRecRefresh.UseVisualStyleBackColor = true;
            this.btnRecRefresh.Click += new System.EventHandler(this.btnRecRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(514, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UserTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecRefresh);
            this.Controls.Add(this.btnReqRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUserRecieve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUserRequest);
            this.Name = "UserTransaction";
            this.Size = new System.Drawing.Size(683, 384);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRecieve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUserRecieve;
        private System.Windows.Forms.Button btnReqRefresh;
        private System.Windows.Forms.Button btnRecRefresh;
        private System.Windows.Forms.Button btnDelete;
    }
}
