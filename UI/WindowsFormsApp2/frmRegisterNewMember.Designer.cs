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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNewMemberName = new System.Windows.Forms.Label();
            this.lbNewMemberIDNumber = new System.Windows.Forms.Label();
            this.lbNewMemberDateOfBirth = new System.Windows.Forms.Label();
            this.lbNewMemberEmail = new System.Windows.Forms.Label();
            this.lbNewMemberAddress = new System.Windows.Forms.Label();
            this.txbNewMemberName = new System.Windows.Forms.TextBox();
            this.txbNewMemberIDNumber = new System.Windows.Forms.TextBox();
            this.txbNewMemberAddress = new System.Windows.Forms.TextBox();
            this.txbNewMemberEmail = new System.Windows.Forms.TextBox();
            this.txbNewMemberDateOfBirth = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txbNewMemberDateOfBirth);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 421);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register new member";
            // 
            // lbNewMemberName
            // 
            this.lbNewMemberName.AutoSize = true;
            this.lbNewMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberName.Location = new System.Drawing.Point(22, 92);
            this.lbNewMemberName.Name = "lbNewMemberName";
            this.lbNewMemberName.Size = new System.Drawing.Size(84, 29);
            this.lbNewMemberName.TabIndex = 1;
            this.lbNewMemberName.Text = "Name:";
            // 
            // lbNewMemberIDNumber
            // 
            this.lbNewMemberIDNumber.AutoSize = true;
            this.lbNewMemberIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberIDNumber.Location = new System.Drawing.Point(22, 147);
            this.lbNewMemberIDNumber.Name = "lbNewMemberIDNumber";
            this.lbNewMemberIDNumber.Size = new System.Drawing.Size(183, 29);
            this.lbNewMemberIDNumber.TabIndex = 1;
            this.lbNewMemberIDNumber.Text = "Identity number:";
            // 
            // lbNewMemberDateOfBirth
            // 
            this.lbNewMemberDateOfBirth.AutoSize = true;
            this.lbNewMemberDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberDateOfBirth.Location = new System.Drawing.Point(22, 200);
            this.lbNewMemberDateOfBirth.Name = "lbNewMemberDateOfBirth";
            this.lbNewMemberDateOfBirth.Size = new System.Drawing.Size(154, 29);
            this.lbNewMemberDateOfBirth.TabIndex = 1;
            this.lbNewMemberDateOfBirth.Text = "Date of birth :";
            // 
            // lbNewMemberEmail
            // 
            this.lbNewMemberEmail.AutoSize = true;
            this.lbNewMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberEmail.Location = new System.Drawing.Point(22, 254);
            this.lbNewMemberEmail.Name = "lbNewMemberEmail";
            this.lbNewMemberEmail.Size = new System.Drawing.Size(80, 29);
            this.lbNewMemberEmail.TabIndex = 1;
            this.lbNewMemberEmail.Text = "Email:";
            // 
            // lbNewMemberAddress
            // 
            this.lbNewMemberAddress.AutoSize = true;
            this.lbNewMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberAddress.Location = new System.Drawing.Point(22, 307);
            this.lbNewMemberAddress.Name = "lbNewMemberAddress";
            this.lbNewMemberAddress.Size = new System.Drawing.Size(114, 29);
            this.lbNewMemberAddress.TabIndex = 1;
            this.lbNewMemberAddress.Text = "Address :";
            // 
            // txbNewMemberName
            // 
            this.txbNewMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberName.Location = new System.Drawing.Point(224, 92);
            this.txbNewMemberName.Name = "txbNewMemberName";
            this.txbNewMemberName.Size = new System.Drawing.Size(521, 34);
            this.txbNewMemberName.TabIndex = 1;
            // 
            // txbNewMemberIDNumber
            // 
            this.txbNewMemberIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberIDNumber.Location = new System.Drawing.Point(224, 147);
            this.txbNewMemberIDNumber.Name = "txbNewMemberIDNumber";
            this.txbNewMemberIDNumber.Size = new System.Drawing.Size(521, 34);
            this.txbNewMemberIDNumber.TabIndex = 2;
            // 
            // txbNewMemberAddress
            // 
            this.txbNewMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberAddress.Location = new System.Drawing.Point(224, 304);
            this.txbNewMemberAddress.Name = "txbNewMemberAddress";
            this.txbNewMemberAddress.Size = new System.Drawing.Size(521, 34);
            this.txbNewMemberAddress.TabIndex = 5;
            // 
            // txbNewMemberEmail
            // 
            this.txbNewMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberEmail.Location = new System.Drawing.Point(224, 254);
            this.txbNewMemberEmail.Name = "txbNewMemberEmail";
            this.txbNewMemberEmail.Size = new System.Drawing.Size(521, 34);
            this.txbNewMemberEmail.TabIndex = 4;
            // 
            // txbNewMemberDateOfBirth
            // 
            this.txbNewMemberDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberDateOfBirth.Location = new System.Drawing.Point(224, 200);
            this.txbNewMemberDateOfBirth.Name = "txbNewMemberDateOfBirth";
            this.txbNewMemberDateOfBirth.Size = new System.Drawing.Size(521, 34);
            this.txbNewMemberDateOfBirth.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(493, 361);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 35);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(626, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRegisterNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 446);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.TextBox txbNewMemberDateOfBirth;
        private System.Windows.Forms.TextBox txbNewMemberEmail;
        private System.Windows.Forms.TextBox txbNewMemberAddress;
        private System.Windows.Forms.TextBox txbNewMemberIDNumber;
        private System.Windows.Forms.TextBox txbNewMemberName;
        private System.Windows.Forms.Label lbNewMemberAddress;
        private System.Windows.Forms.Label lbNewMemberEmail;
    }
}