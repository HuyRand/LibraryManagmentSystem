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
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txbMemberAddress = new System.Windows.Forms.TextBox();
            this.lbTotalOwedMoney = new System.Windows.Forms.Label();
            this.lbRegistrationDate = new System.Windows.Forms.Label();
            this.btnCreateReturnTicket = new System.Windows.Forms.Button();
            this.txbTotalOwedMoney = new System.Windows.Forms.TextBox();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateBorrowTicket = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMemberAddress
            // 
            this.lbMemberAddress.AutoSize = true;
            this.lbMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberAddress.Location = new System.Drawing.Point(620, 176);
            this.lbMemberAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberAddress.Name = "lbMemberAddress";
            this.lbMemberAddress.Size = new System.Drawing.Size(91, 25);
            this.lbMemberAddress.TabIndex = 9;
            this.lbMemberAddress.Text = "Address:";
            // 
            // lbMemberEmail
            // 
            this.lbMemberEmail.AutoSize = true;
            this.lbMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberEmail.Location = new System.Drawing.Point(620, 116);
            this.lbMemberEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberEmail.Name = "lbMemberEmail";
            this.lbMemberEmail.Size = new System.Drawing.Size(66, 25);
            this.lbMemberEmail.TabIndex = 7;
            this.lbMemberEmail.Text = "Email:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDateOfBirth.Location = new System.Drawing.Point(4, 118);
            this.lbDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(122, 25);
            this.lbDateOfBirth.TabIndex = 5;
            this.lbDateOfBirth.Text = "Date of birth:";
            // 
            // lbIdentityNumber
            // 
            this.lbIdentityNumber.AutoSize = true;
            this.lbIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbIdentityNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbIdentityNumber.Location = new System.Drawing.Point(620, 63);
            this.lbIdentityNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdentityNumber.Name = "lbIdentityNumber";
            this.lbIdentityNumber.Size = new System.Drawing.Size(151, 25);
            this.lbIdentityNumber.TabIndex = 3;
            this.lbIdentityNumber.Text = "Identity number:";
            // 
            // txbMemberName
            // 
            this.txbMemberName.Location = new System.Drawing.Point(187, 63);
            this.txbMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.txbMemberName.Name = "txbMemberName";
            this.txbMemberName.Size = new System.Drawing.Size(384, 22);
            this.txbMemberName.TabIndex = 0;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberName.Location = new System.Drawing.Point(4, 65);
            this.lbMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(70, 25);
            this.lbMemberName.TabIndex = 1;
            this.lbMemberName.Text = "Name:";
            // 
            // lbMemberType
            // 
            this.lbMemberType.AutoSize = true;
            this.lbMemberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberType.Location = new System.Drawing.Point(4, 180);
            this.lbMemberType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberType.Name = "lbMemberType";
            this.lbMemberType.Size = new System.Drawing.Size(140, 25);
            this.lbMemberType.TabIndex = 14;
            this.lbMemberType.Text = "Member Type:";
            // 
            // lbMemberInfo
            // 
            this.lbMemberInfo.AutoSize = true;
            this.lbMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberInfo.Location = new System.Drawing.Point(404, -1);
            this.lbMemberInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberInfo.Name = "lbMemberInfo";
            this.lbMemberInfo.Size = new System.Drawing.Size(399, 52);
            this.lbMemberInfo.TabIndex = 0;
            this.lbMemberInfo.Text = "Member Infomation";
            // 
            // txbIdentityNumber
            // 
            this.txbIdentityNumber.Location = new System.Drawing.Point(811, 63);
            this.txbIdentityNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbIdentityNumber.Name = "txbIdentityNumber";
            this.txbIdentityNumber.Size = new System.Drawing.Size(351, 22);
            this.txbIdentityNumber.TabIndex = 1;
            // 
            // cbMemberType
            // 
            this.cbMemberType.FormattingEnabled = true;
            this.cbMemberType.Location = new System.Drawing.Point(187, 177);
            this.cbMemberType.Margin = new System.Windows.Forms.Padding(4);
            this.cbMemberType.Name = "cbMemberType";
            this.cbMemberType.Size = new System.Drawing.Size(265, 24);
            this.cbMemberType.TabIndex = 4;
            // 
            // txbMemberEmail
            // 
            this.txbMemberEmail.Location = new System.Drawing.Point(811, 116);
            this.txbMemberEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbMemberEmail.Name = "txbMemberEmail";
            this.txbMemberEmail.Size = new System.Drawing.Size(351, 22);
            this.txbMemberEmail.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(187, 118);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(265, 22);
            this.dtpDateOfBirth.TabIndex = 2;
            // 
            // txbMemberAddress
            // 
            this.txbMemberAddress.Location = new System.Drawing.Point(811, 176);
            this.txbMemberAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbMemberAddress.Name = "txbMemberAddress";
            this.txbMemberAddress.Size = new System.Drawing.Size(351, 22);
            this.txbMemberAddress.TabIndex = 5;
            // 
            // lbTotalOwedMoney
            // 
            this.lbTotalOwedMoney.AutoSize = true;
            this.lbTotalOwedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTotalOwedMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTotalOwedMoney.Location = new System.Drawing.Point(620, 233);
            this.lbTotalOwedMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalOwedMoney.Name = "lbTotalOwedMoney";
            this.lbTotalOwedMoney.Size = new System.Drawing.Size(183, 25);
            this.lbTotalOwedMoney.TabIndex = 18;
            this.lbTotalOwedMoney.Text = "Total owed money: ";
            // 
            // lbRegistrationDate
            // 
            this.lbRegistrationDate.AutoSize = true;
            this.lbRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRegistrationDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRegistrationDate.Location = new System.Drawing.Point(4, 235);
            this.lbRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegistrationDate.Name = "lbRegistrationDate";
            this.lbRegistrationDate.Size = new System.Drawing.Size(166, 25);
            this.lbRegistrationDate.TabIndex = 17;
            this.lbRegistrationDate.Text = "Registration Date:";
            // 
            // btnCreateReturnTicket
            // 
            this.btnCreateReturnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReturnTicket.Location = new System.Drawing.Point(867, 282);
            this.btnCreateReturnTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateReturnTicket.Name = "btnCreateReturnTicket";
            this.btnCreateReturnTicket.Size = new System.Drawing.Size(152, 65);
            this.btnCreateReturnTicket.TabIndex = 18;
            this.btnCreateReturnTicket.Text = "Create return ticket";
            this.btnCreateReturnTicket.UseVisualStyleBackColor = true;
            this.btnCreateReturnTicket.Click += new System.EventHandler(this.btnCreateReturnTicket_Click);
            // 
            // txbTotalOwedMoney
            // 
            this.txbTotalOwedMoney.Location = new System.Drawing.Point(811, 233);
            this.txbTotalOwedMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalOwedMoney.Name = "txbTotalOwedMoney";
            this.txbTotalOwedMoney.Size = new System.Drawing.Size(351, 22);
            this.txbTotalOwedMoney.TabIndex = 16;
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(187, 235);
            this.dtpRegistrationDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(265, 22);
            this.dtpRegistrationDate.TabIndex = 15;
            // 
            // btnCreateBorrowTicket
            // 
            this.btnCreateBorrowTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBorrowTicket.Location = new System.Drawing.Point(665, 282);
            this.btnCreateBorrowTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateBorrowTicket.Name = "btnCreateBorrowTicket";
            this.btnCreateBorrowTicket.Size = new System.Drawing.Size(181, 65);
            this.btnCreateBorrowTicket.TabIndex = 17;
            this.btnCreateBorrowTicket.Text = "Create borrow ticket";
            this.btnCreateBorrowTicket.UseVisualStyleBackColor = true;
            this.btnCreateBorrowTicket.Click += new System.EventHandler(this.btnCreateBorrowTicket_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1333, 1231);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "button2";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnCreateBorrowTicket);
            this.panel1.Controls.Add(this.dtpRegistrationDate);
            this.panel1.Controls.Add(this.txbTotalOwedMoney);
            this.panel1.Controls.Add(this.btnCreateReturnTicket);
            this.panel1.Controls.Add(this.lbRegistrationDate);
            this.panel1.Controls.Add(this.lbTotalOwedMoney);
            this.panel1.Controls.Add(this.txbMemberAddress);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
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
            this.panel1.Controls.Add(this.lbMemberAddress);
            this.panel1.Location = new System.Drawing.Point(16, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 361);
            this.panel1.TabIndex = 17;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(1043, 282);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(119, 65);
            this.btnCancle.TabIndex = 17;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(1218, 365);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMemberInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Infomation";
            this.Load += new System.EventHandler(this.frmMemberInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txbMemberAddress;
        private System.Windows.Forms.Label lbTotalOwedMoney;
        private System.Windows.Forms.Label lbRegistrationDate;
        private System.Windows.Forms.Button btnCreateReturnTicket;
        private System.Windows.Forms.TextBox txbTotalOwedMoney;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.Button btnCreateBorrowTicket;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancle;
    }
}