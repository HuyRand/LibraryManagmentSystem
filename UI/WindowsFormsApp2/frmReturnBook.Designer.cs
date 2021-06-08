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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbReturnMemberInfo = new System.Windows.Forms.Label();
            this.txbReturnMemberCardNumber = new System.Windows.Forms.TextBox();
            this.lbReturnMemberName = new System.Windows.Forms.Label();
            this.txbReturnMemberName = new System.Windows.Forms.TextBox();
            this.lbReturnMemberCardNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReturnBook = new System.Windows.Forms.DataGridView();
            this.lbReturnBook = new System.Windows.Forms.Label();
            this.dtbReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txbTotalOwedMoney = new System.Windows.Forms.TextBox();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.lbTotalOwedMoney = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReturnBorrow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBook)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lbReturnMemberInfo);
            this.panel1.Controls.Add(this.txbReturnMemberCardNumber);
            this.panel1.Controls.Add(this.lbReturnMemberName);
            this.panel1.Controls.Add(this.txbReturnMemberName);
            this.panel1.Controls.Add(this.lbReturnMemberCardNumber);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 98);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(-2, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 42);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbReturnMemberInfo
            // 
            this.lbReturnMemberInfo.AutoSize = true;
            this.lbReturnMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnMemberInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnMemberInfo.Location = new System.Drawing.Point(361, 0);
            this.lbReturnMemberInfo.Name = "lbReturnMemberInfo";
            this.lbReturnMemberInfo.Size = new System.Drawing.Size(145, 39);
            this.lbReturnMemberInfo.TabIndex = 8;
            this.lbReturnMemberInfo.Text = "Member";
            // 
            // txbReturnMemberCardNumber
            // 
            this.txbReturnMemberCardNumber.Enabled = false;
            this.txbReturnMemberCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReturnMemberCardNumber.Location = new System.Drawing.Point(121, 57);
            this.txbReturnMemberCardNumber.Name = "txbReturnMemberCardNumber";
            this.txbReturnMemberCardNumber.Size = new System.Drawing.Size(264, 19);
            this.txbReturnMemberCardNumber.TabIndex = 5;
            this.txbReturnMemberCardNumber.TabStop = false;
            // 
            // lbReturnMemberName
            // 
            this.lbReturnMemberName.AutoSize = true;
            this.lbReturnMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbReturnMemberName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnMemberName.Location = new System.Drawing.Point(465, 56);
            this.lbReturnMemberName.Name = "lbReturnMemberName";
            this.lbReturnMemberName.Size = new System.Drawing.Size(55, 20);
            this.lbReturnMemberName.TabIndex = 6;
            this.lbReturnMemberName.Text = "Name:";
            // 
            // txbReturnMemberName
            // 
            this.txbReturnMemberName.Enabled = false;
            this.txbReturnMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReturnMemberName.Location = new System.Drawing.Point(586, 56);
            this.txbReturnMemberName.Name = "txbReturnMemberName";
            this.txbReturnMemberName.Size = new System.Drawing.Size(246, 19);
            this.txbReturnMemberName.TabIndex = 4;
            this.txbReturnMemberName.TabStop = false;
            // 
            // lbReturnMemberCardNumber
            // 
            this.lbReturnMemberCardNumber.AutoSize = true;
            this.lbReturnMemberCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbReturnMemberCardNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnMemberCardNumber.Location = new System.Drawing.Point(6, 54);
            this.lbReturnMemberCardNumber.Name = "lbReturnMemberCardNumber";
            this.lbReturnMemberCardNumber.Size = new System.Drawing.Size(105, 20);
            this.lbReturnMemberCardNumber.TabIndex = 7;
            this.lbReturnMemberCardNumber.Text = "Card number:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dgvReturnBook);
            this.panel3.Location = new System.Drawing.Point(578, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 226);
            this.panel3.TabIndex = 18;
            // 
            // dgvReturnBook
            // 
            this.dgvReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBook.Enabled = false;
            this.dgvReturnBook.Location = new System.Drawing.Point(2, 2);
            this.dgvReturnBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReturnBook.Name = "dgvReturnBook";
            this.dgvReturnBook.RowHeadersWidth = 51;
            this.dgvReturnBook.RowTemplate.Height = 24;
            this.dgvReturnBook.Size = new System.Drawing.Size(250, 223);
            this.dgvReturnBook.TabIndex = 1;
            this.dgvReturnBook.SelectionChanged += new System.EventHandler(this.dgvReturnBook_SelectionChanged);
            // 
            // lbReturnBook
            // 
            this.lbReturnBook.AutoSize = true;
            this.lbReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnBook.Location = new System.Drawing.Point(332, 0);
            this.lbReturnBook.Name = "lbReturnBook";
            this.lbReturnBook.Size = new System.Drawing.Size(205, 39);
            this.lbReturnBook.TabIndex = 15;
            this.lbReturnBook.Text = "Return book";
            // 
            // dtbReturnDate
            // 
            this.dtbReturnDate.Enabled = false;
            this.dtbReturnDate.Location = new System.Drawing.Point(104, 63);
            this.dtbReturnDate.Name = "dtbReturnDate";
            this.dtbReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtbReturnDate.TabIndex = 21;
            this.dtbReturnDate.TabStop = false;
            // 
            // txbTotalOwedMoney
            // 
            this.txbTotalOwedMoney.Enabled = false;
            this.txbTotalOwedMoney.Location = new System.Drawing.Point(587, 60);
            this.txbTotalOwedMoney.Name = "txbTotalOwedMoney";
            this.txbTotalOwedMoney.Size = new System.Drawing.Size(246, 20);
            this.txbTotalOwedMoney.TabIndex = 22;
            this.txbTotalOwedMoney.TabStop = false;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbReturnDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReturnDate.Location = new System.Drawing.Point(7, 60);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(101, 20);
            this.lbReturnDate.TabIndex = 9;
            this.lbReturnDate.Text = "Return Date:";
            // 
            // lbTotalOwedMoney
            // 
            this.lbTotalOwedMoney.AutoSize = true;
            this.lbTotalOwedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTotalOwedMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTotalOwedMoney.Location = new System.Drawing.Point(448, 58);
            this.lbTotalOwedMoney.Name = "lbTotalOwedMoney";
            this.lbTotalOwedMoney.Size = new System.Drawing.Size(141, 20);
            this.lbTotalOwedMoney.TabIndex = 23;
            this.lbTotalOwedMoney.Text = "Total owed money:";
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1000, 1000);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "button1";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvReturnBorrow);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbId);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.lbTotalOwedMoney);
            this.panel2.Controls.Add(this.lbReturnDate);
            this.panel2.Controls.Add(this.txbTotalOwedMoney);
            this.panel2.Controls.Add(this.dtbReturnDate);
            this.panel2.Controls.Add(this.lbReturnBook);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(11, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 372);
            this.panel2.TabIndex = 20;
            // 
            // dgvReturnBorrow
            // 
            this.dgvReturnBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBorrow.Location = new System.Drawing.Point(10, 130);
            this.dgvReturnBorrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReturnBorrow.Name = "dgvReturnBorrow";
            this.dgvReturnBorrow.RowHeadersWidth = 51;
            this.dgvReturnBorrow.RowTemplate.Height = 24;
            this.dgvReturnBorrow.Size = new System.Drawing.Size(550, 226);
            this.dgvReturnBorrow.TabIndex = 28;
            this.dgvReturnBorrow.SelectionChanged += new System.EventHandler(this.dgvReturnBorrow_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Book id:";
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(104, 104);
            this.txbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(200, 20);
            this.txbId.TabIndex = 26;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReturn.FlatAppearance.BorderSize = 2;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(715, 9);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(118, 40);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmReturnTicket
            // 
            this.AcceptButton = this.btnHuy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(877, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReturnTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return ticket";
            this.Load += new System.EventHandler(this.frmReturnTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBorrow)).EndInit();
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
        private System.Windows.Forms.Label lbReturnBook;
        private System.Windows.Forms.DateTimePicker dtbReturnDate;
        private System.Windows.Forms.TextBox txbTotalOwedMoney;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.Label lbTotalOwedMoney;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReturnBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvReturnBorrow;
    }
}