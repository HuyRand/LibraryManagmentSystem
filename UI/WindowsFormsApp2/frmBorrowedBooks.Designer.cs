namespace WindowsFormsApp2
{
    partial class frmBorrowedBooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowedBooks));
            this.lbBorrowedBooks = new System.Windows.Forms.Label();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txbMemid = new System.Windows.Forms.TextBox();
            this.txbBookid = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpReserve = new System.Windows.Forms.DateTimePicker();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBorrowedBooks
            // 
            this.lbBorrowedBooks.AutoSize = true;
            this.lbBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowedBooks.Location = new System.Drawing.Point(328, 33);
            this.lbBorrowedBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorrowedBooks.Name = "lbBorrowedBooks";
            this.lbBorrowedBooks.Size = new System.Drawing.Size(249, 37);
            this.lbBorrowedBooks.TabIndex = 0;
            this.lbBorrowedBooks.Text = "Borrowed books";
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(334, 113);
            this.dgvBorrowedBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.RowHeadersWidth = 51;
            this.dgvBorrowedBooks.RowTemplate.Height = 24;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(555, 353);
            this.dgvBorrowedBooks.TabIndex = 1;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(770, 488);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(129, 54);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txbMemid
            // 
            this.txbMemid.Enabled = false;
            this.txbMemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMemid.Location = new System.Drawing.Point(134, 113);
            this.txbMemid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMemid.Name = "txbMemid";
            this.txbMemid.Size = new System.Drawing.Size(137, 19);
            this.txbMemid.TabIndex = 3;
            // 
            // txbBookid
            // 
            this.txbBookid.Enabled = false;
            this.txbBookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBookid.Location = new System.Drawing.Point(134, 150);
            this.txbBookid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBookid.Name = "txbBookid";
            this.txbBookid.Size = new System.Drawing.Size(137, 19);
            this.txbBookid.TabIndex = 4;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(183, 319);
            this.refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(87, 40);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Update";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Member id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reserve date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Due date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Return date:";
            // 
            // dtpReserve
            // 
            this.dtpReserve.CustomFormat = "yyyy/MM/dd";
            this.dtpReserve.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReserve.Location = new System.Drawing.Point(134, 190);
            this.dtpReserve.Name = "dtpReserve";
            this.dtpReserve.Size = new System.Drawing.Size(137, 20);
            this.dtpReserve.TabIndex = 14;
            // 
            // dtpDue
            // 
            this.dtpDue.CustomFormat = "yyyy/MM/dd";
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDue.Location = new System.Drawing.Point(134, 227);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(137, 20);
            this.dtpDue.TabIndex = 15;
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "yyyy/MM/dd";
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(134, 266);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(137, 20);
            this.dtpReturn.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 547);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.dtpDue);
            this.Controls.Add(this.dtpReserve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.txbBookid);
            this.Controls.Add(this.txbMemid);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.dgvBorrowedBooks);
            this.Controls.Add(this.lbBorrowedBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBorrowedBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowed books";
            this.Load += new System.EventHandler(this.frmBorrowedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBorrowedBooks;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txbMemid;
        private System.Windows.Forms.TextBox txbBookid;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpReserve;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}