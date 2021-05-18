namespace WindowsFormsApp2
{
    partial class borrowBookLine
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
            this.chkChoseBook = new System.Windows.Forms.CheckBox();
            this.lbBookID = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbBookState = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkChoseBook
            // 
            this.chkChoseBook.AutoSize = true;
            this.chkChoseBook.Location = new System.Drawing.Point(16, 37);
            this.chkChoseBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkChoseBook.Name = "chkChoseBook";
            this.chkChoseBook.Size = new System.Drawing.Size(18, 17);
            this.chkChoseBook.TabIndex = 0;
            this.chkChoseBook.UseVisualStyleBackColor = true;
            // 
            // lbBookID
            // 
            this.lbBookID.AutoEllipsis = true;
            this.lbBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookID.Location = new System.Drawing.Point(48, 0);
            this.lbBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(191, 86);
            this.lbBookID.TabIndex = 1;
            this.lbBookID.Text = "BookID";
            this.lbBookID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoEllipsis = true;
            this.lbBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(235, 0);
            this.lbBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(321, 86);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "BookName";
            this.lbBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpBorrowDate);
            this.panel1.Location = new System.Drawing.Point(555, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 86);
            this.panel1.TabIndex = 3;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Enabled = false;
            this.dtpBorrowDate.Location = new System.Drawing.Point(5, 33);
            this.dtpBorrowDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(265, 22);
            this.dtpBorrowDate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbBookState);
            this.panel2.Location = new System.Drawing.Point(832, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 86);
            this.panel2.TabIndex = 5;
            // 
            // cbBookState
            // 
            this.cbBookState.FormattingEnabled = true;
            this.cbBookState.Location = new System.Drawing.Point(5, 33);
            this.cbBookState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBookState.Name = "cbBookState";
            this.cbBookState.Size = new System.Drawing.Size(243, 24);
            this.cbBookState.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chkChoseBook);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(49, 86);
            this.panel3.TabIndex = 6;
            // 
            // borrowBookLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbBookID);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "borrowBookLine";
            this.Size = new System.Drawing.Size(1088, 86);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.CheckBox chkChoseBook;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox cbBookState;
        private System.Windows.Forms.Panel panel3;
    }
}
