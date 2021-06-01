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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.txbLocation = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
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
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddImage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.Controls.Add(this.txbLocation);
            this.panel1.Controls.Add(this.btnCancle);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 657);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(448, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(1, 611);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(74, 20);
            this.labelLocation.TabIndex = 51;
            this.labelLocation.Text = "Location:";
            // 
            // txbLocation
            // 
            this.txbLocation.Location = new System.Drawing.Point(104, 611);
            this.txbLocation.Name = "txbLocation";
            this.txbLocation.Size = new System.Drawing.Size(282, 20);
            this.txbLocation.TabIndex = 50;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(692, 597);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(140, 49);
            this.btnCancle.TabIndex = 39;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(106, 342);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(200, 21);
            this.cbState.TabIndex = 8;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(3, 339);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(52, 20);
            this.lbState.TabIndex = 37;
            this.lbState.Text = "State:";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(106, 544);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(280, 20);
            this.txbPrice.TabIndex = 7;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(3, 540);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 20);
            this.lbPrice.TabIndex = 35;
            this.lbPrice.Text = "Price:";
            // 
            // txbPublishYear
            // 
            this.txbPublishYear.Location = new System.Drawing.Point(106, 479);
            this.txbPublishYear.Name = "txbPublishYear";
            this.txbPublishYear.Size = new System.Drawing.Size(280, 20);
            this.txbPublishYear.TabIndex = 5;
            // 
            // txbPublisher
            // 
            this.txbPublisher.Location = new System.Drawing.Point(106, 411);
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Size = new System.Drawing.Size(280, 20);
            this.txbPublisher.TabIndex = 1;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(106, 274);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(280, 20);
            this.txbAuthor.TabIndex = 6;
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(106, 202);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(200, 21);
            this.cbGenre.TabIndex = 4;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(106, 134);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(280, 20);
            this.txbBookID.TabIndex = 2;
            // 
            // lbPublishYear
            // 
            this.lbPublishYear.AutoSize = true;
            this.lbPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublishYear.Location = new System.Drawing.Point(3, 476);
            this.lbPublishYear.Name = "lbPublishYear";
            this.lbPublishYear.Size = new System.Drawing.Size(102, 20);
            this.lbPublishYear.TabIndex = 33;
            this.lbPublishYear.Text = "Publish Year:";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(3, 73);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(55, 20);
            this.lbBookName.TabIndex = 22;
            this.lbBookName.Text = "Name:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(106, 73);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(280, 20);
            this.txbBookName.TabIndex = 0;
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookID.Location = new System.Drawing.Point(3, 134);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(71, 20);
            this.lbBookID.TabIndex = 25;
            this.lbBookID.Text = "Book ID:";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(3, 201);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(62, 20);
            this.lbGenre.TabIndex = 28;
            this.lbGenre.Text = "Genre: ";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(3, 274);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(65, 20);
            this.lbAuthor.TabIndex = 31;
            this.lbAuthor.Text = "AuThor:";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.Location = new System.Drawing.Point(3, 409);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(78, 20);
            this.lbPublisher.TabIndex = 32;
            this.lbPublisher.Text = "Publisher:";
            // 
            // lbBookInfomation
            // 
            this.lbBookInfomation.AutoSize = true;
            this.lbBookInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookInfomation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBookInfomation.Location = new System.Drawing.Point(304, 0);
            this.lbBookInfomation.Name = "lbBookInfomation";
            this.lbBookInfomation.Size = new System.Drawing.Size(267, 39);
            this.lbBookInfomation.TabIndex = 20;
            this.lbBookInfomation.Text = "Book Infomation";
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1000, 1000);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "button2";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.Location = new System.Drawing.Point(537, 597);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(140, 49);
            this.btnAddImage.TabIndex = 53;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // frmBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(869, 668);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book infomation";
            this.Load += new System.EventHandler(this.frmBookInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnCancle;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox txbLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddImage;
    }
}