namespace WindowsFormsApp2
{
    partial class frmRegisterNewMember
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbNewMemberEmail = new System.Windows.Forms.TextBox();
            this.txbNewMemberAddress = new System.Windows.Forms.TextBox();
            this.txbNewMemberIDNumber = new System.Windows.Forms.TextBox();
            this.txbNewMemberName = new System.Windows.Forms.TextBox();
            this.lbNewMemberAddress = new System.Windows.Forms.Label();
            this.lbNewMemberEmail = new System.Windows.Forms.Label();
            this.lbNewMemberDateOfBirth = new System.Windows.Forms.Label();
            this.lbNewMemberIDNumber = new System.Windows.Forms.Label();
            this.lbNewMemberName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNewMemberBooksAllowed = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbNewMemberBooksAllowed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txbNewMemberEmail);
            this.panel1.Controls.Add(this.txbNewMemberAddress);
            this.panel1.Controls.Add(this.txbNewMemberIDNumber);
            this.panel1.Controls.Add(this.txbNewMemberName);
            this.panel1.Controls.Add(this.lbNewMemberAddress);
            this.panel1.Controls.Add(this.lbNewMemberEmail);
            this.panel1.Controls.Add(this.lbNewMemberDateOfBirth);
            this.panel1.Controls.Add(this.lbNewMemberIDNumber);
            this.panel1.Controls.Add(this.lbNewMemberName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 410);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(471, 344);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(371, 344);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 28);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txbNewMemberEmail
            // 
            this.txbNewMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberEmail.Location = new System.Drawing.Point(168, 206);
            this.txbNewMemberEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNewMemberEmail.Name = "txbNewMemberEmail";
            this.txbNewMemberEmail.Size = new System.Drawing.Size(392, 28);
            this.txbNewMemberEmail.TabIndex = 4;
            // 
            // txbNewMemberAddress
            // 
            this.txbNewMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberAddress.Location = new System.Drawing.Point(168, 247);
            this.txbNewMemberAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNewMemberAddress.Name = "txbNewMemberAddress";
            this.txbNewMemberAddress.Size = new System.Drawing.Size(392, 28);
            this.txbNewMemberAddress.TabIndex = 5;
            // 
            // txbNewMemberIDNumber
            // 
            this.txbNewMemberIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberIDNumber.Location = new System.Drawing.Point(168, 119);
            this.txbNewMemberIDNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNewMemberIDNumber.Name = "txbNewMemberIDNumber";
            this.txbNewMemberIDNumber.Size = new System.Drawing.Size(392, 28);
            this.txbNewMemberIDNumber.TabIndex = 2;
            // 
            // txbNewMemberName
            // 
            this.txbNewMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberName.Location = new System.Drawing.Point(168, 75);
            this.txbNewMemberName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNewMemberName.Name = "txbNewMemberName";
            this.txbNewMemberName.Size = new System.Drawing.Size(392, 28);
            this.txbNewMemberName.TabIndex = 1;
            // 
            // lbNewMemberAddress
            // 
            this.lbNewMemberAddress.AutoSize = true;
            this.lbNewMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberAddress.Location = new System.Drawing.Point(16, 249);
            this.lbNewMemberAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewMemberAddress.Name = "lbNewMemberAddress";
            this.lbNewMemberAddress.Size = new System.Drawing.Size(90, 24);
            this.lbNewMemberAddress.TabIndex = 1;
            this.lbNewMemberAddress.Text = "Address :";
            // 
            // lbNewMemberEmail
            // 
            this.lbNewMemberEmail.AutoSize = true;
            this.lbNewMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberEmail.Location = new System.Drawing.Point(16, 206);
            this.lbNewMemberEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewMemberEmail.Name = "lbNewMemberEmail";
            this.lbNewMemberEmail.Size = new System.Drawing.Size(62, 24);
            this.lbNewMemberEmail.TabIndex = 1;
            this.lbNewMemberEmail.Text = "Email:";
            // 
            // lbNewMemberDateOfBirth
            // 
            this.lbNewMemberDateOfBirth.AutoSize = true;
            this.lbNewMemberDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberDateOfBirth.Location = new System.Drawing.Point(16, 162);
            this.lbNewMemberDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewMemberDateOfBirth.Name = "lbNewMemberDateOfBirth";
            this.lbNewMemberDateOfBirth.Size = new System.Drawing.Size(119, 24);
            this.lbNewMemberDateOfBirth.TabIndex = 1;
            this.lbNewMemberDateOfBirth.Text = "Date of birth :";
            // 
            // lbNewMemberIDNumber
            // 
            this.lbNewMemberIDNumber.AutoSize = true;
            this.lbNewMemberIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberIDNumber.Location = new System.Drawing.Point(16, 119);
            this.lbNewMemberIDNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewMemberIDNumber.Name = "lbNewMemberIDNumber";
            this.lbNewMemberIDNumber.Size = new System.Drawing.Size(144, 24);
            this.lbNewMemberIDNumber.TabIndex = 1;
            this.lbNewMemberIDNumber.Text = "Identity number:";
            // 
            // lbNewMemberName
            // 
            this.lbNewMemberName.AutoSize = true;
            this.lbNewMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberName.Location = new System.Drawing.Point(16, 75);
            this.lbNewMemberName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewMemberName.Name = "lbNewMemberName";
            this.lbNewMemberName.Size = new System.Drawing.Size(66, 24);
            this.lbNewMemberName.TabIndex = 1;
            this.lbNewMemberName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register new member";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dtpDateOfBirth.Location = new System.Drawing.Point(168, 162);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(243, 28);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of\r\nBooks Allowed";
            // 
            // txbNewMemberBooksAllowed
            // 
            this.txbNewMemberBooksAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txbNewMemberBooksAllowed.Location = new System.Drawing.Point(168, 295);
            this.txbNewMemberBooksAllowed.Name = "txbNewMemberBooksAllowed";
            this.txbNewMemberBooksAllowed.Size = new System.Drawing.Size(392, 28);
            this.txbNewMemberBooksAllowed.TabIndex = 9;
            // 
            // frmRegisterNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 431);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegisterNewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register new member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNewMemberDateOfBirth;
        private System.Windows.Forms.Label lbNewMemberIDNumber;
        private System.Windows.Forms.Label lbNewMemberName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txbNewMemberEmail;
        private System.Windows.Forms.TextBox txbNewMemberAddress;
        private System.Windows.Forms.TextBox txbNewMemberIDNumber;
        private System.Windows.Forms.TextBox txbNewMemberName;
        private System.Windows.Forms.Label lbNewMemberAddress;
        private System.Windows.Forms.Label lbNewMemberEmail;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txbNewMemberBooksAllowed;
        private System.Windows.Forms.Label label2;
    }
}