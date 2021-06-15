namespace WindowsFormsApp2
{
    partial class frmMemberInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberInfo));
            this.lbMemberAddress = new System.Windows.Forms.Label();
            this.lbMemberEmail = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbIdentityNumber = new System.Windows.Forms.Label();
            this.txbMemberName = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbMemberType = new System.Windows.Forms.Label();
            this.lbMemberInfo = new System.Windows.Forms.Label();
            this.txbIdentityNumber = new System.Windows.Forms.TextBox();
            this.cbMemberType = new System.Windows.Forms.ComboBox();
            this.txbMemberEmail = new System.Windows.Forms.TextBox();
            this.txbMemberAddress = new System.Windows.Forms.TextBox();
            this.lbRegistrationDate = new System.Windows.Forms.Label();
            this.btnCreateReturnTicket = new System.Windows.Forms.Button();
            this.btnCreateBorrowTicket = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addImageBtton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbRegistrationDate = new System.Windows.Forms.TextBox();
            this.txbDateOfBirth = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txbOwedMoney = new System.Windows.Forms.TextBox();
            this.lbOwedMoney = new System.Windows.Forms.Label();
            this.txbMemberMajor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMemberClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMemberAddress
            // 
            this.lbMemberAddress.AutoSize = true;
            this.lbMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberAddress.Location = new System.Drawing.Point(14, 392);
            this.lbMemberAddress.Name = "lbMemberAddress";
            this.lbMemberAddress.Size = new System.Drawing.Size(72, 20);
            this.lbMemberAddress.TabIndex = 9;
            this.lbMemberAddress.Text = "Address:";
            // 
            // lbMemberEmail
            // 
            this.lbMemberEmail.AutoSize = true;
            this.lbMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberEmail.Location = new System.Drawing.Point(14, 343);
            this.lbMemberEmail.Name = "lbMemberEmail";
            this.lbMemberEmail.Size = new System.Drawing.Size(52, 20);
            this.lbMemberEmail.TabIndex = 7;
            this.lbMemberEmail.Text = "Email:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDateOfBirth.Location = new System.Drawing.Point(14, 204);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(101, 20);
            this.lbDateOfBirth.TabIndex = 5;
            this.lbDateOfBirth.Text = "Date of birth:";
            // 
            // lbIdentityNumber
            // 
            this.lbIdentityNumber.AutoSize = true;
            this.lbIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbIdentityNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbIdentityNumber.Location = new System.Drawing.Point(14, 79);
            this.lbIdentityNumber.Name = "lbIdentityNumber";
            this.lbIdentityNumber.Size = new System.Drawing.Size(123, 20);
            this.lbIdentityNumber.TabIndex = 3;
            this.lbIdentityNumber.Text = "Identity number:";
            // 
            // txbMemberName
            // 
            this.txbMemberName.Location = new System.Drawing.Point(167, 127);
            this.txbMemberName.Name = "txbMemberName";
            this.txbMemberName.ReadOnly = true;
            this.txbMemberName.Size = new System.Drawing.Size(289, 20);
            this.txbMemberName.TabIndex = 0;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberName.Location = new System.Drawing.Point(14, 127);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(55, 20);
            this.lbMemberName.TabIndex = 1;
            this.lbMemberName.Text = "Name:";
            // 
            // lbMemberType
            // 
            this.lbMemberType.AutoSize = true;
            this.lbMemberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberType.Location = new System.Drawing.Point(14, 254);
            this.lbMemberType.Name = "lbMemberType";
            this.lbMemberType.Size = new System.Drawing.Size(109, 20);
            this.lbMemberType.TabIndex = 14;
            this.lbMemberType.Text = "Member Type:";
            // 
            // lbMemberInfo
            // 
            this.lbMemberInfo.AutoSize = true;
            this.lbMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberInfo.Location = new System.Drawing.Point(303, -1);
            this.lbMemberInfo.Name = "lbMemberInfo";
            this.lbMemberInfo.Size = new System.Drawing.Size(316, 39);
            this.lbMemberInfo.TabIndex = 0;
            this.lbMemberInfo.Text = "Member Infomation";
            // 
            // txbIdentityNumber
            // 
            this.txbIdentityNumber.Location = new System.Drawing.Point(167, 79);
            this.txbIdentityNumber.Name = "txbIdentityNumber";
            this.txbIdentityNumber.ReadOnly = true;
            this.txbIdentityNumber.Size = new System.Drawing.Size(264, 20);
            this.txbIdentityNumber.TabIndex = 1;
            // 
            // cbMemberType
            // 
            this.cbMemberType.FormattingEnabled = true;
            this.cbMemberType.Location = new System.Drawing.Point(167, 252);
            this.cbMemberType.Name = "cbMemberType";
            this.cbMemberType.Size = new System.Drawing.Size(200, 21);
            this.cbMemberType.TabIndex = 4;
            // 
            // txbMemberEmail
            // 
            this.txbMemberEmail.Location = new System.Drawing.Point(167, 343);
            this.txbMemberEmail.Name = "txbMemberEmail";
            this.txbMemberEmail.ReadOnly = true;
            this.txbMemberEmail.Size = new System.Drawing.Size(264, 20);
            this.txbMemberEmail.TabIndex = 3;
            // 
            // txbMemberAddress
            // 
            this.txbMemberAddress.Location = new System.Drawing.Point(167, 392);
            this.txbMemberAddress.Name = "txbMemberAddress";
            this.txbMemberAddress.ReadOnly = true;
            this.txbMemberAddress.Size = new System.Drawing.Size(264, 20);
            this.txbMemberAddress.TabIndex = 5;
            // 
            // lbRegistrationDate
            // 
            this.lbRegistrationDate.AutoSize = true;
            this.lbRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRegistrationDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRegistrationDate.Location = new System.Drawing.Point(14, 299);
            this.lbRegistrationDate.Name = "lbRegistrationDate";
            this.lbRegistrationDate.Size = new System.Drawing.Size(138, 20);
            this.lbRegistrationDate.TabIndex = 17;
            this.lbRegistrationDate.Text = "Registration Date:";
            // 
            // btnCreateReturnTicket
            // 
            this.btnCreateReturnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReturnTicket.Location = new System.Drawing.Point(325, 472);
            this.btnCreateReturnTicket.Name = "btnCreateReturnTicket";
            this.btnCreateReturnTicket.Size = new System.Drawing.Size(110, 29);
            this.btnCreateReturnTicket.TabIndex = 18;
            this.btnCreateReturnTicket.Text = "Create return ticket";
            this.btnCreateReturnTicket.UseVisualStyleBackColor = true;
            this.btnCreateReturnTicket.Click += new System.EventHandler(this.btnCreateReturnTicket_Click);
            // 
            // btnCreateBorrowTicket
            // 
            this.btnCreateBorrowTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBorrowTicket.Location = new System.Drawing.Point(169, 472);
            this.btnCreateBorrowTicket.Name = "btnCreateBorrowTicket";
            this.btnCreateBorrowTicket.Size = new System.Drawing.Size(132, 29);
            this.btnCreateBorrowTicket.TabIndex = 17;
            this.btnCreateBorrowTicket.Text = "Create borrow ticket";
            this.btnCreateBorrowTicket.UseVisualStyleBackColor = true;
            this.btnCreateBorrowTicket.Click += new System.EventHandler(this.btnCreateBorrowTicket_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1000, 1000);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "button2";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMemberMajor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbMemberClass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addImageBtton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txbRegistrationDate);
            this.panel1.Controls.Add(this.txbDateOfBirth);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnCreateBorrowTicket);
            this.panel1.Controls.Add(this.btnCreateReturnTicket);
            this.panel1.Controls.Add(this.lbRegistrationDate);
            this.panel1.Controls.Add(this.txbOwedMoney);
            this.panel1.Controls.Add(this.txbMemberAddress);
            this.panel1.Controls.Add(this.txbMemberEmail);
            this.panel1.Controls.Add(this.cbMemberType);
            this.panel1.Controls.Add(this.txbIdentityNumber);
            this.panel1.Controls.Add(this.lbMemberInfo);
            this.panel1.Controls.Add(this.lbMemberType);
            this.panel1.Controls.Add(this.lbMemberName);
            this.panel1.Controls.Add(this.txbMemberName);
            this.panel1.Controls.Add(this.lbIdentityNumber);
            this.panel1.Controls.Add(this.lbDateOfBirth);
            this.panel1.Controls.Add(this.lbMemberEmail);
            this.panel1.Controls.Add(this.lbOwedMoney);
            this.panel1.Controls.Add(this.lbMemberAddress);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 524);
            this.panel1.TabIndex = 17;
            // 
            // addImageBtton
            // 
            this.addImageBtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageBtton.Location = new System.Drawing.Point(596, 425);
            this.addImageBtton.Name = "addImageBtton";
            this.addImageBtton.Size = new System.Drawing.Size(144, 29);
            this.addImageBtton.TabIndex = 23;
            this.addImageBtton.Text = "Add Image";
            this.addImageBtton.UseVisualStyleBackColor = true;
            this.addImageBtton.Click += new System.EventHandler(this.addImageBtton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(533, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txbRegistrationDate
            // 
            this.txbRegistrationDate.Location = new System.Drawing.Point(167, 302);
            this.txbRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbRegistrationDate.Name = "txbRegistrationDate";
            this.txbRegistrationDate.ReadOnly = true;
            this.txbRegistrationDate.Size = new System.Drawing.Size(200, 20);
            this.txbRegistrationDate.TabIndex = 21;
            // 
            // txbDateOfBirth
            // 
            this.txbDateOfBirth.Location = new System.Drawing.Point(167, 207);
            this.txbDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbDateOfBirth.Name = "txbDateOfBirth";
            this.txbDateOfBirth.ReadOnly = true;
            this.txbDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.txbDateOfBirth.TabIndex = 20;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(469, 472);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(89, 29);
            this.btnCancle.TabIndex = 17;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txbOwedMoney
            // 
            this.txbOwedMoney.Location = new System.Drawing.Point(167, 431);
            this.txbOwedMoney.Name = "txbOwedMoney";
            this.txbOwedMoney.ReadOnly = true;
            this.txbOwedMoney.Size = new System.Drawing.Size(264, 20);
            this.txbOwedMoney.TabIndex = 5;
            // 
            // lbOwedMoney
            // 
            this.lbOwedMoney.AutoSize = true;
            this.lbOwedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbOwedMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbOwedMoney.Location = new System.Drawing.Point(14, 428);
            this.lbOwedMoney.Name = "lbOwedMoney";
            this.lbOwedMoney.Size = new System.Drawing.Size(105, 20);
            this.lbOwedMoney.TabIndex = 9;
            this.lbOwedMoney.Text = "Owed Money:";
            // 
            // txbMemberMajor
            // 
            this.txbMemberMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbMemberMajor.Location = new System.Drawing.Point(278, 167);
            this.txbMemberMajor.Margin = new System.Windows.Forms.Padding(2);
            this.txbMemberMajor.Name = "txbMemberMajor";
            this.txbMemberMajor.ReadOnly = true;
            this.txbMemberMajor.Size = new System.Drawing.Size(89, 20);
            this.txbMemberMajor.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "/";
            // 
            // txbMemberClass
            // 
            this.txbMemberClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbMemberClass.Location = new System.Drawing.Point(168, 167);
            this.txbMemberClass.Margin = new System.Windows.Forms.Padding(2);
            this.txbMemberClass.Name = "txbMemberClass";
            this.txbMemberClass.ReadOnly = true;
            this.txbMemberClass.Size = new System.Drawing.Size(89, 20);
            this.txbMemberClass.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Class/Major";
            // 
            // frmMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(826, 539);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMemberInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Infomation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMemberInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmMemberInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMemberAddress;
        private System.Windows.Forms.Label lbMemberEmail;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbIdentityNumber;
        private System.Windows.Forms.TextBox txbMemberName;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbMemberType;
        private System.Windows.Forms.Label lbMemberInfo;
        private System.Windows.Forms.TextBox txbIdentityNumber;
        private System.Windows.Forms.ComboBox cbMemberType;
        private System.Windows.Forms.TextBox txbMemberEmail;
        private System.Windows.Forms.TextBox txbMemberAddress;
        private System.Windows.Forms.Label lbRegistrationDate;
        private System.Windows.Forms.Button btnCreateReturnTicket;
        private System.Windows.Forms.Button btnCreateBorrowTicket;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txbDateOfBirth;
        private System.Windows.Forms.TextBox txbRegistrationDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addImageBtton;
        private System.Windows.Forms.TextBox txbOwedMoney;
        private System.Windows.Forms.Label lbOwedMoney;
        private System.Windows.Forms.TextBox txbMemberMajor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMemberClass;
        private System.Windows.Forms.Label label2;
    }
}