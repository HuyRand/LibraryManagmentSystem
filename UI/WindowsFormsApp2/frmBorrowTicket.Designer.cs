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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbMemberInfo = new System.Windows.Forms.Label();
            this.txbBorrowMemberCardNumber = new System.Windows.Forms.TextBox();
            this.lbBorrowMemberName = new System.Windows.Forms.Label();
            this.lbBorrowMemberCardNumber = new System.Windows.Forms.Label();
            this.txblbBorrowMemberName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.cbTimSachTheoMa = new System.Windows.Forms.ComboBox();
            this.cbSearchBookWithID = new System.Windows.Forms.Label();
            this.btnCreateBorrowTicket = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbState = new System.Windows.Forms.Label();
            this.lbBorrowDate = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbBookID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkChonSach = new System.Windows.Forms.CheckBox();
            this.lbBorrowedBook = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBorrowBook = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.lbMemberInfo);
            this.panel1.Controls.Add(this.txbBorrowMemberCardNumber);
            this.panel1.Controls.Add(this.lbBorrowMemberName);
            this.panel1.Controls.Add(this.lbBorrowMemberCardNumber);
            this.panel1.Controls.Add(this.txblbBorrowMemberName);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1333, 1231);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "button1";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // lbMemberInfo
            // 
            this.lbMemberInfo.AutoSize = true;
            this.lbMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberInfo.Location = new System.Drawing.Point(479, 0);
            this.lbMemberInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberInfo.Name = "lbMemberInfo";
            this.lbMemberInfo.Size = new System.Drawing.Size(196, 52);
            this.lbMemberInfo.TabIndex = 8;
            this.lbMemberInfo.Text = "Member ";
            // 
            // txbBorrowMemberCardNumber
            // 
            this.txbBorrowMemberCardNumber.Location = new System.Drawing.Point(162, 74);
            this.txbBorrowMemberCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbBorrowMemberCardNumber.Name = "txbBorrowMemberCardNumber";
            this.txbBorrowMemberCardNumber.Size = new System.Drawing.Size(351, 22);
            this.txbBorrowMemberCardNumber.TabIndex = 5;
            this.txbBorrowMemberCardNumber.TabStop = false;
            // 
            // lbBorrowMemberName
            // 
            this.lbBorrowMemberName.AutoSize = true;
            this.lbBorrowMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbBorrowMemberName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBorrowMemberName.Location = new System.Drawing.Point(621, 70);
            this.lbBorrowMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBorrowMemberName.Name = "lbBorrowMemberName";
            this.lbBorrowMemberName.Size = new System.Drawing.Size(70, 25);
            this.lbBorrowMemberName.TabIndex = 6;
            this.lbBorrowMemberName.Text = "Name:";
            // 
            // lbBorrowMemberCardNumber
            // 
            this.lbBorrowMemberCardNumber.AutoSize = true;
            this.lbBorrowMemberCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbBorrowMemberCardNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBorrowMemberCardNumber.Location = new System.Drawing.Point(11, 70);
            this.lbBorrowMemberCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBorrowMemberCardNumber.Name = "lbBorrowMemberCardNumber";
            this.lbBorrowMemberCardNumber.Size = new System.Drawing.Size(132, 25);
            this.lbBorrowMemberCardNumber.TabIndex = 7;
            this.lbBorrowMemberCardNumber.Text = "Card number:";
            // 
            // txblbBorrowMemberName
            // 
            this.txblbBorrowMemberName.Location = new System.Drawing.Point(761, 70);
            this.txblbBorrowMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.txblbBorrowMemberName.Name = "txblbBorrowMemberName";
            this.txblbBorrowMemberName.Size = new System.Drawing.Size(348, 22);
            this.txblbBorrowMemberName.TabIndex = 4;
            this.txblbBorrowMemberName.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbError);
            this.panel2.Controls.Add(this.cbTimSachTheoMa);
            this.panel2.Controls.Add(this.cbSearchBookWithID);
            this.panel2.Controls.Add(this.btnCreateBorrowTicket);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lbBorrowedBook);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(17, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 457);
            this.panel2.TabIndex = 19;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(15, 91);
            this.lbError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 23;
            // 
            // cbTimSachTheoMa
            // 
            this.cbTimSachTheoMa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTimSachTheoMa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTimSachTheoMa.FormattingEnabled = true;
            this.cbTimSachTheoMa.Location = new System.Drawing.Point(120, 60);
            this.cbTimSachTheoMa.Margin = new System.Windows.Forms.Padding(4);
            this.cbTimSachTheoMa.Name = "cbTimSachTheoMa";
            this.cbTimSachTheoMa.Size = new System.Drawing.Size(351, 24);
            this.cbTimSachTheoMa.TabIndex = 0;
            // 
            // cbSearchBookWithID
            // 
            this.cbSearchBookWithID.AutoSize = true;
            this.cbSearchBookWithID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchBookWithID.Location = new System.Drawing.Point(9, 62);
            this.cbSearchBookWithID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cbSearchBookWithID.Name = "cbSearchBookWithID";
            this.cbSearchBookWithID.Size = new System.Drawing.Size(87, 25);
            this.cbSearchBookWithID.TabIndex = 22;
            this.cbSearchBookWithID.Text = "Book ID:";
            // 
            // btnCreateBorrowTicket
            // 
            this.btnCreateBorrowTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBorrowTicket.Location = new System.Drawing.Point(929, 22);
            this.btnCreateBorrowTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateBorrowTicket.Name = "btnCreateBorrowTicket";
            this.btnCreateBorrowTicket.Size = new System.Drawing.Size(181, 78);
            this.btnCreateBorrowTicket.TabIndex = 1;
            this.btnCreateBorrowTicket.Text = "Create borrow ticket";
            this.btnCreateBorrowTicket.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbState);
            this.panel4.Controls.Add(this.lbBorrowDate);
            this.panel4.Controls.Add(this.lbBookName);
            this.panel4.Controls.Add(this.lbBookID);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(5, 119);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 50);
            this.panel4.TabIndex = 19;
            // 
            // lbState
            // 
            this.lbState.AutoEllipsis = true;
            this.lbState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(838, 4);
            this.lbState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(251, 43);
            this.lbState.TabIndex = 30;
            this.lbState.Text = "State";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBorrowDate
            // 
            this.lbBorrowDate.AutoEllipsis = true;
            this.lbBorrowDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowDate.Location = new System.Drawing.Point(559, 4);
            this.lbBorrowDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBorrowDate.Name = "lbBorrowDate";
            this.lbBorrowDate.Size = new System.Drawing.Size(279, 43);
            this.lbBorrowDate.TabIndex = 29;
            this.lbBorrowDate.Text = "Borrow date";
            this.lbBorrowDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoEllipsis = true;
            this.lbBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(240, 4);
            this.lbBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(321, 43);
            this.lbBookName.TabIndex = 27;
            this.lbBookName.Text = "Book name";
            this.lbBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBookID
            // 
            this.lbBookID.AutoEllipsis = true;
            this.lbBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookID.Location = new System.Drawing.Point(53, 4);
            this.lbBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(191, 43);
            this.lbBookID.TabIndex = 26;
            this.lbBookID.Text = "BookID";
            this.lbBookID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.chkChonSach);
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 43);
            this.panel6.TabIndex = 28;
            // 
            // chkChonSach
            // 
            this.chkChonSach.AutoSize = true;
            this.chkChonSach.Location = new System.Drawing.Point(15, 11);
            this.chkChonSach.Margin = new System.Windows.Forms.Padding(4);
            this.chkChonSach.Name = "chkChonSach";
            this.chkChonSach.Size = new System.Drawing.Size(18, 17);
            this.chkChonSach.TabIndex = 0;
            this.chkChonSach.TabStop = false;
            this.chkChonSach.UseVisualStyleBackColor = true;
            // 
            // lbBorrowedBook
            // 
            this.lbBorrowedBook.AutoSize = true;
            this.lbBorrowedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowedBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBorrowedBook.Location = new System.Drawing.Point(468, 11);
            this.lbBorrowedBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBorrowedBook.Name = "lbBorrowedBook";
            this.lbBorrowedBook.Size = new System.Drawing.Size(273, 52);
            this.lbBorrowedBook.TabIndex = 15;
            this.lbBorrowedBook.Text = "Borrow Book";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dgvBorrowBook);
            this.panel3.Location = new System.Drawing.Point(5, 172);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1117, 277);
            this.panel3.TabIndex = 18;
            // 
            // dgvBorrowBook
            // 
            this.dgvBorrowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowBook.Location = new System.Drawing.Point(2, -4);
            this.dgvBorrowBook.Name = "dgvBorrowBook";
            this.dgvBorrowBook.RowHeadersWidth = 51;
            this.dgvBorrowBook.RowTemplate.Height = 24;
            this.dgvBorrowBook.Size = new System.Drawing.Size(1091, 278);
            this.dgvBorrowBook.TabIndex = 0;
            // 
            // frmBorrowTicket
            // 
            this.AcceptButton = this.btnCreateBorrowTicket;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(1169, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrowTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Ticket";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbBorrowDate;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox chkChonSach;
        private System.Windows.Forms.Label lbBorrowedBook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTimSachTheoMa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label cbSearchBookWithID;
        private System.Windows.Forms.DataGridView dgvBorrowBook;
    }
}