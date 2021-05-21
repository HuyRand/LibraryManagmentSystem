namespace WindowsFormsApp2
{
    partial class frmBookInfo
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.pnlBookPicture = new System.Windows.Forms.Panel();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lbState = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txbPublishYear = new System.Windows.Forms.TextBox();
            this.txbPublisher = new System.Windows.Forms.TextBox();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.lbPublishYear = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.lbBookID = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbBookInfomation = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.picimageBook = new System.Windows.Forms.PictureBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panel1.SuspendLayout();
            this.pnlBookPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.pnlBookPicture);
            this.panel1.Controls.Add(this.cbState);
            this.panel1.Controls.Add(this.lbState);
            this.panel1.Controls.Add(this.txbPrice);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.txbPublishYear);
            this.panel1.Controls.Add(this.txbPublisher);
            this.panel1.Controls.Add(this.txbAuthor);
            this.panel1.Controls.Add(this.cbGenre);
            this.panel1.Controls.Add(this.txbBookID);
            this.panel1.Controls.Add(this.lbPublishYear);
            this.panel1.Controls.Add(this.lbBookName);
            this.panel1.Controls.Add(this.txbBookName);
            this.panel1.Controls.Add(this.lbBookID);
            this.panel1.Controls.Add(this.lbGenre);
            this.panel1.Controls.Add(this.lbAuthor);
            this.panel1.Controls.Add(this.lbPublisher);
            this.panel1.Controls.Add(this.lbBookInfomation);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 809);
            this.panel1.TabIndex = 18;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(923, 735);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(187, 60);
            this.btnCancle.TabIndex = 39;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // pnlBookPicture
            // 
            this.pnlBookPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBookPicture.Controls.Add(this.picimageBook);
            this.pnlBookPicture.Location = new System.Drawing.Point(598, 66);
            this.pnlBookPicture.Name = "pnlBookPicture";
            this.pnlBookPicture.Size = new System.Drawing.Size(512, 640);
            this.pnlBookPicture.TabIndex = 38;
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(142, 421);
            this.cbState.Margin = new System.Windows.Forms.Padding(4);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(265, 24);
            this.cbState.TabIndex = 8;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(4, 417);
            this.lbState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(64, 25);
            this.lbState.TabIndex = 37;
            this.lbState.Text = "State:";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(142, 669);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(372, 22);
            this.txbPrice.TabIndex = 7;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(4, 665);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(62, 25);
            this.lbPrice.TabIndex = 35;
            this.lbPrice.Text = "Price:";
            // 
            // txbPublishYear
            // 
            this.txbPublishYear.Location = new System.Drawing.Point(142, 590);
            this.txbPublishYear.Margin = new System.Windows.Forms.Padding(4);
            this.txbPublishYear.Name = "txbPublishYear";
            this.txbPublishYear.Size = new System.Drawing.Size(372, 22);
            this.txbPublishYear.TabIndex = 5;
            // 
            // txbPublisher
            // 
            this.txbPublisher.Location = new System.Drawing.Point(142, 506);
            this.txbPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Size = new System.Drawing.Size(372, 22);
            this.txbPublisher.TabIndex = 1;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(142, 337);
            this.txbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(372, 22);
            this.txbAuthor.TabIndex = 6;
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(142, 248);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(265, 24);
            this.cbGenre.TabIndex = 4;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(142, 165);
            this.txbBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(372, 22);
            this.txbBookID.TabIndex = 2;
            // 
            // lbPublishYear
            // 
            this.lbPublishYear.AutoSize = true;
            this.lbPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublishYear.Location = new System.Drawing.Point(4, 586);
            this.lbPublishYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublishYear.Name = "lbPublishYear";
            this.lbPublishYear.Size = new System.Drawing.Size(128, 25);
            this.lbPublishYear.TabIndex = 33;
            this.lbPublishYear.Text = "Publish Year:";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(4, 90);
            this.lbBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(70, 25);
            this.lbBookName.TabIndex = 22;
            this.lbBookName.Text = "Name:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(142, 90);
            this.txbBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(372, 22);
            this.txbBookName.TabIndex = 0;
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookID.Location = new System.Drawing.Point(4, 165);
            this.lbBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(87, 25);
            this.lbBookID.TabIndex = 25;
            this.lbBookID.Text = "Book ID:";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(4, 247);
            this.lbGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(77, 25);
            this.lbGenre.TabIndex = 28;
            this.lbGenre.Text = "Genre: ";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(4, 337);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(84, 25);
            this.lbAuthor.TabIndex = 31;
            this.lbAuthor.Text = "AuThor:";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.Location = new System.Drawing.Point(4, 503);
            this.lbPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(99, 25);
            this.lbPublisher.TabIndex = 32;
            this.lbPublisher.Text = "Publisher:";
            // 
            // lbBookInfomation
            // 
            this.lbBookInfomation.AutoSize = true;
            this.lbBookInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookInfomation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBookInfomation.Location = new System.Drawing.Point(405, 0);
            this.lbBookInfomation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookInfomation.Name = "lbBookInfomation";
            this.lbBookInfomation.Size = new System.Drawing.Size(337, 52);
            this.lbBookInfomation.TabIndex = 20;
            this.lbBookInfomation.Text = "Book Infomation";
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1333, 1231);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "button2";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // picimageBook
            // 
            this.picimageBook.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picimageBook.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.picBack;
            this.picimageBook.ErrorImage = global::WindowsFormsApp2.Properties.Resources.picBack;
            this.picimageBook.Image = global::WindowsFormsApp2.Properties.Resources.pic11;
            this.picimageBook.Location = new System.Drawing.Point(3, 3);
            this.picimageBook.Name = "picimageBook";
            this.picimageBook.Size = new System.Drawing.Size(509, 637);
            this.picimageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picimageBook.TabIndex = 0;
            this.picimageBook.TabStop = false;
            // 
            // frmBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(1159, 822);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book infomation";
            this.Load += new System.EventHandler(this.frmBookInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBookPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picimageBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbBookInfomation;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txbPublishYear;
        private System.Windows.Forms.TextBox txbPublisher;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.Label lbPublishYear;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlBookPicture;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.PictureBox picimageBook;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
    }
}