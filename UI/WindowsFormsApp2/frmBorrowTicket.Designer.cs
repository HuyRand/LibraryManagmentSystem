namespace WindowsFormsApp2
{
    partial class frmBorrowTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbMemberInfo = new System.Windows.Forms.Label();
            this.txbBorrowMemberCardNumber = new System.Windows.Forms.TextBox();
            this.lbBorrowMemberName = new System.Windows.Forms.Label();
            this.lbBorrowMemberCardNumber = new System.Windows.Forms.Label();
            this.txblbBorrowMemberName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdbook = new System.Windows.Forms.TextBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.cbSearchBookWithID = new System.Windows.Forms.Label();
            this.btnCreateBorrowTicket = new System.Windows.Forms.Button();
            this.lbBorrowedBook = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBorrowBook = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.lbMemberInfo);
            this.panel1.Controls.Add(this.txbBorrowMemberCardNumber);
            this.panel1.Controls.Add(this.lbBorrowMemberName);
            this.panel1.Controls.Add(this.lbBorrowMemberCardNumber);
            this.panel1.Controls.Add(this.txblbBorrowMemberName);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 98);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(-2, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 42);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1000, 1000);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "button1";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // lbMemberInfo
            // 
            this.lbMemberInfo.AutoSize = true;
            this.lbMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberInfo.Location = new System.Drawing.Point(359, 0);
            this.lbMemberInfo.Name = "lbMemberInfo";
            this.lbMemberInfo.Size = new System.Drawing.Size(154, 39);
            this.lbMemberInfo.TabIndex = 8;
            this.lbMemberInfo.Text = "Member ";
            // 
            // txbBorrowMemberCardNumber
            // 
            this.txbBorrowMemberCardNumber.Enabled = false;
            this.txbBorrowMemberCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBorrowMemberCardNumber.Location = new System.Drawing.Point(122, 60);
            this.txbBorrowMemberCardNumber.Name = "txbBorrowMemberCardNumber";
            this.txbBorrowMemberCardNumber.Size = new System.Drawing.Size(264, 19);
            this.txbBorrowMemberCardNumber.TabIndex = 5;
            this.txbBorrowMemberCardNumber.TabStop = false;
            // 
            // lbBorrowMemberName
            // 
            this.lbBorrowMemberName.AutoSize = true;
            this.lbBorrowMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbBorrowMemberName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBorrowMemberName.Location = new System.Drawing.Point(466, 57);
            this.lbBorrowMemberName.Name = "lbBorrowMemberName";
            this.lbBorrowMemberName.Size = new System.Drawing.Size(55, 20);
            this.lbBorrowMemberName.TabIndex = 6;
            this.lbBorrowMemberName.Text = "Name:";
            // 
            // lbBorrowMemberCardNumber
            // 
            this.lbBorrowMemberCardNumber.AutoSize = true;
            this.lbBorrowMemberCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbBorrowMemberCardNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBorrowMemberCardNumber.Location = new System.Drawing.Point(8, 57);
            this.lbBorrowMemberCardNumber.Name = "lbBorrowMemberCardNumber";
            this.lbBorrowMemberCardNumber.Size = new System.Drawing.Size(105, 20);
            this.lbBorrowMemberCardNumber.TabIndex = 7;
            this.lbBorrowMemberCardNumber.Text = "Card number:";
            // 
            // txblbBorrowMemberName
            // 
            this.txblbBorrowMemberName.Enabled = false;
            this.txblbBorrowMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txblbBorrowMemberName.Location = new System.Drawing.Point(571, 57);
            this.txblbBorrowMemberName.Name = "txblbBorrowMemberName";
            this.txblbBorrowMemberName.Size = new System.Drawing.Size(262, 19);
            this.txblbBorrowMemberName.TabIndex = 4;
            this.txblbBorrowMemberName.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbIdbook);
            this.panel2.Controls.Add(this.txbSearch);
            this.panel2.Controls.Add(this.lbError);
            this.panel2.Controls.Add(this.cbSearchBookWithID);
            this.panel2.Controls.Add(this.btnCreateBorrowTicket);
            this.panel2.Controls.Add(this.lbBorrowedBook);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(13, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 372);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Book id:";
            // 
            // txbIdbook
            // 
            this.txbIdbook.Location = new System.Drawing.Point(472, 54);
            this.txbIdbook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbIdbook.Name = "txbIdbook";
            this.txbIdbook.Size = new System.Drawing.Size(195, 20);
            this.txbIdbook.TabIndex = 25;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(149, 53);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(236, 20);
            this.txbSearch.TabIndex = 24;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(11, 74);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 23;
            // 
            // cbSearchBookWithID
            // 
            this.cbSearchBookWithID.AutoSize = true;
            this.cbSearchBookWithID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchBookWithID.Location = new System.Drawing.Point(7, 50);
            this.cbSearchBookWithID.Name = "cbSearchBookWithID";
            this.cbSearchBookWithID.Size = new System.Drawing.Size(147, 20);
            this.cbSearchBookWithID.TabIndex = 22;
            this.cbSearchBookWithID.Text = "Search book name:";
            // 
            // btnCreateBorrowTicket
            // 
            this.btnCreateBorrowTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBorrowTicket.Location = new System.Drawing.Point(697, 18);
            this.btnCreateBorrowTicket.Name = "btnCreateBorrowTicket";
            this.btnCreateBorrowTicket.Size = new System.Drawing.Size(136, 63);
            this.btnCreateBorrowTicket.TabIndex = 1;
            this.btnCreateBorrowTicket.Text = "Create borrow ticket";
            this.btnCreateBorrowTicket.UseVisualStyleBackColor = true;
            this.btnCreateBorrowTicket.Click += new System.EventHandler(this.btnCreateBorrowTicket_Click);
            // 
            // lbBorrowedBook
            // 
            this.lbBorrowedBook.AutoSize = true;
            this.lbBorrowedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowedBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBorrowedBook.Location = new System.Drawing.Point(351, 9);
            this.lbBorrowedBook.Name = "lbBorrowedBook";
            this.lbBorrowedBook.Size = new System.Drawing.Size(215, 39);
            this.lbBorrowedBook.TabIndex = 15;
            this.lbBorrowedBook.Text = "Borrow Book";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dgvBorrowBook);
            this.panel3.Location = new System.Drawing.Point(4, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 274);
            this.panel3.TabIndex = 18;
            // 
            // dgvBorrowBook
            // 
            this.dgvBorrowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowBook.Location = new System.Drawing.Point(2, 2);
            this.dgvBorrowBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBorrowBook.Name = "dgvBorrowBook";
            this.dgvBorrowBook.RowHeadersWidth = 51;
            this.dgvBorrowBook.RowTemplate.Height = 24;
            this.dgvBorrowBook.Size = new System.Drawing.Size(834, 269);
            this.dgvBorrowBook.TabIndex = 0;
            this.dgvBorrowBook.SelectionChanged += new System.EventHandler(this.dgvBorrowBook_SelectionChanged);
            // 
            // frmBorrowTicket
            // 
            this.AcceptButton = this.btnCreateBorrowTicket;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(877, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrowTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Ticket";
            this.Load += new System.EventHandler(this.frmBorrowTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbBorrowMemberCardNumber;
        private System.Windows.Forms.Label lbBorrowMemberName;
        private System.Windows.Forms.TextBox txblbBorrowMemberName;
        private System.Windows.Forms.Label lbBorrowMemberCardNumber;
        private System.Windows.Forms.Label lbMemberInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateBorrowTicket;
        private System.Windows.Forms.Label lbBorrowedBook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label cbSearchBookWithID;
        private System.Windows.Forms.DataGridView dgvBorrowBook;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdbook;
        private System.Windows.Forms.Button btnRefresh;
    }
}