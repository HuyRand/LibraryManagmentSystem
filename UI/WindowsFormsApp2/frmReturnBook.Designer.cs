namespace WindowsFormsApp2
{
    partial class frmReturnTicket
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
            this.lbReturnMemberInfo = new System.Windows.Forms.Label();
            this.txbReturnMemberCardNumber = new System.Windows.Forms.TextBox();
            this.lbReturnMemberName = new System.Windows.Forms.Label();
            this.txbReturnMemberName = new System.Windows.Forms.TextBox();
            this.lbReturnMemberCardNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnReturnedBookList = new System.Windows.Forms.Panel();
            this.lbReturnBook = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbPenalty = new System.Windows.Forms.Label();
            this.lbDaysBorrowed = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbBookID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkChoseBook = new System.Windows.Forms.CheckBox();
            this.dtbReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txbTotalOwedMoney = new System.Windows.Forms.TextBox();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.lbTotalOwedMoney = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbReturnMemberInfo);
            this.panel1.Controls.Add(this.txbReturnMemberCardNumber);
            this.panel1.Controls.Add(this.lbReturnMemberName);
            this.panel1.Controls.Add(this.txbReturnMemberName);
            this.panel1.Controls.Add(this.lbReturnMemberCardNumber);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 120);
            this.panel1.TabIndex = 1;
            // 
            // lbReturnMemberInfo
            // 
            this.lbReturnMemberInfo.AutoSize = true;
            this.lbReturnMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnMemberInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnMemberInfo.Location = new System.Drawing.Point(481, 0);
            this.lbReturnMemberInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReturnMemberInfo.Name = "lbReturnMemberInfo";
            this.lbReturnMemberInfo.Size = new System.Drawing.Size(184, 52);
            this.lbReturnMemberInfo.TabIndex = 8;
            this.lbReturnMemberInfo.Text = "Member";
            // 
            // txbReturnMemberCardNumber
            // 
            this.txbReturnMemberCardNumber.Location = new System.Drawing.Point(161, 70);
            this.txbReturnMemberCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbReturnMemberCardNumber.Name = "txbReturnMemberCardNumber";
            this.txbReturnMemberCardNumber.Size = new System.Drawing.Size(351, 22);
            this.txbReturnMemberCardNumber.TabIndex = 5;
            this.txbReturnMemberCardNumber.TabStop = false;
            // 
            // lbReturnMemberName
            // 
            this.lbReturnMemberName.AutoSize = true;
            this.lbReturnMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbReturnMemberName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnMemberName.Location = new System.Drawing.Point(620, 69);
            this.lbReturnMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReturnMemberName.Name = "lbReturnMemberName";
            this.lbReturnMemberName.Size = new System.Drawing.Size(70, 25);
            this.lbReturnMemberName.TabIndex = 6;
            this.lbReturnMemberName.Text = "Name:";
            // 
            // txbReturnMemberName
            // 
            this.txbReturnMemberName.Location = new System.Drawing.Point(781, 69);
            this.txbReturnMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.txbReturnMemberName.Name = "txbReturnMemberName";
            this.txbReturnMemberName.Size = new System.Drawing.Size(327, 22);
            this.txbReturnMemberName.TabIndex = 4;
            this.txbReturnMemberName.TabStop = false;
            // 
            // lbReturnMemberCardNumber
            // 
            this.lbReturnMemberCardNumber.AutoSize = true;
            this.lbReturnMemberCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbReturnMemberCardNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnMemberCardNumber.Location = new System.Drawing.Point(8, 66);
            this.lbReturnMemberCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReturnMemberCardNumber.Name = "lbReturnMemberCardNumber";
            this.lbReturnMemberCardNumber.Size = new System.Drawing.Size(132, 25);
            this.lbReturnMemberCardNumber.TabIndex = 7;
            this.lbReturnMemberCardNumber.Text = "Card number:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pnReturnedBookList);
            this.panel3.Location = new System.Drawing.Point(5, 172);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1117, 277);
            this.panel3.TabIndex = 18;
            // 
            // pnReturnedBookList
            // 
            this.pnReturnedBookList.AutoSize = true;
            this.pnReturnedBookList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnReturnedBookList.Location = new System.Drawing.Point(4, 4);
            this.pnReturnedBookList.Margin = new System.Windows.Forms.Padding(4);
            this.pnReturnedBookList.Name = "pnReturnedBookList";
            this.pnReturnedBookList.Size = new System.Drawing.Size(1089, 268);
            this.pnReturnedBookList.TabIndex = 19;
            // 
            // lbReturnBook
            // 
            this.lbReturnBook.AutoSize = true;
            this.lbReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnBook.Location = new System.Drawing.Point(443, 0);
            this.lbReturnBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReturnBook.Name = "lbReturnBook";
            this.lbReturnBook.Size = new System.Drawing.Size(260, 52);
            this.lbReturnBook.TabIndex = 15;
            this.lbReturnBook.Text = "Return book";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbPenalty);
            this.panel4.Controls.Add(this.lbDaysBorrowed);
            this.panel4.Controls.Add(this.lbBookName);
            this.panel4.Controls.Add(this.lbBookID);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(5, 119);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 50);
            this.panel4.TabIndex = 19;
            // 
            // lbPenalty
            // 
            this.lbPenalty.AutoEllipsis = true;
            this.lbPenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPenalty.Location = new System.Drawing.Point(837, 4);
            this.lbPenalty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPenalty.Name = "lbPenalty";
            this.lbPenalty.Size = new System.Drawing.Size(251, 43);
            this.lbPenalty.TabIndex = 30;
            this.lbPenalty.Text = "Penalty";
            this.lbPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDaysBorrowed
            // 
            this.lbDaysBorrowed.AutoEllipsis = true;
            this.lbDaysBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDaysBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDaysBorrowed.Location = new System.Drawing.Point(559, 4);
            this.lbDaysBorrowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDaysBorrowed.Name = "lbDaysBorrowed";
            this.lbDaysBorrowed.Size = new System.Drawing.Size(279, 43);
            this.lbDaysBorrowed.TabIndex = 29;
            this.lbDaysBorrowed.Text = "Days Borrowed ";
            this.lbDaysBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel6.Controls.Add(this.chkChoseBook);
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 43);
            this.panel6.TabIndex = 28;
            // 
            // chkChoseBook
            // 
            this.chkChoseBook.AutoSize = true;
            this.chkChoseBook.Enabled = false;
            this.chkChoseBook.Location = new System.Drawing.Point(15, 11);
            this.chkChoseBook.Margin = new System.Windows.Forms.Padding(4);
            this.chkChoseBook.Name = "chkChoseBook";
            this.chkChoseBook.Size = new System.Drawing.Size(18, 17);
            this.chkChoseBook.TabIndex = 1;
            this.chkChoseBook.UseVisualStyleBackColor = true;
            // 
            // dtbReturnDate
            // 
            this.dtbReturnDate.Enabled = false;
            this.dtbReturnDate.Location = new System.Drawing.Point(138, 77);
            this.dtbReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtbReturnDate.Name = "dtbReturnDate";
            this.dtbReturnDate.Size = new System.Drawing.Size(265, 22);
            this.dtbReturnDate.TabIndex = 21;
            this.dtbReturnDate.TabStop = false;
            // 
            // txbTotalOwedMoney
            // 
            this.txbTotalOwedMoney.Enabled = false;
            this.txbTotalOwedMoney.Location = new System.Drawing.Point(783, 74);
            this.txbTotalOwedMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalOwedMoney.Name = "txbTotalOwedMoney";
            this.txbTotalOwedMoney.Size = new System.Drawing.Size(327, 22);
            this.txbTotalOwedMoney.TabIndex = 22;
            this.txbTotalOwedMoney.TabStop = false;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbReturnDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnDate.Location = new System.Drawing.Point(9, 74);
            this.lbReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(121, 25);
            this.lbReturnDate.TabIndex = 9;
            this.lbReturnDate.Text = "Return Date:";
            // 
            // lbTotalOwedMoney
            // 
            this.lbTotalOwedMoney.AutoSize = true;
            this.lbTotalOwedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTotalOwedMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTotalOwedMoney.Location = new System.Drawing.Point(597, 71);
            this.lbTotalOwedMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalOwedMoney.Name = "lbTotalOwedMoney";
            this.lbTotalOwedMoney.Size = new System.Drawing.Size(178, 25);
            this.lbTotalOwedMoney.TabIndex = 23;
            this.lbTotalOwedMoney.Text = "Total owed money:";
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1333, 1231);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "button1";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.lbTotalOwedMoney);
            this.panel2.Controls.Add(this.lbReturnDate);
            this.panel2.Controls.Add(this.txbTotalOwedMoney);
            this.panel2.Controls.Add(this.dtbReturnDate);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lbReturnBook);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(15, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 457);
            this.panel2.TabIndex = 20;
            // 
            // frmReturnTicket
            // 
            this.AcceptButton = this.btnHuy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(1169, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReturnTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return ticket";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbReturnMemberInfo;
        private System.Windows.Forms.TextBox txbReturnMemberCardNumber;
        private System.Windows.Forms.Label lbReturnMemberName;
        private System.Windows.Forms.TextBox txbReturnMemberName;
        private System.Windows.Forms.Label lbReturnMemberCardNumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnReturnedBookList;
        private System.Windows.Forms.Label lbReturnBook;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbPenalty;
        private System.Windows.Forms.Label lbDaysBorrowed;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox chkChoseBook;
        private System.Windows.Forms.DateTimePicker dtbReturnDate;
        private System.Windows.Forms.TextBox txbTotalOwedMoney;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.Label lbTotalOwedMoney;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel2;
    }
}