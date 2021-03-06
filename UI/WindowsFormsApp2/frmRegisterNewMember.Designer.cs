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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterNewMember));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addImageBttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbNewMemberEmail = new System.Windows.Forms.TextBox();
            this.txbNewMemberAddress = new System.Windows.Forms.TextBox();
            this.txbNewMemberName = new System.Windows.Forms.TextBox();
            this.lbNewMemberAddress = new System.Windows.Forms.Label();
            this.lbNewMemberEmail = new System.Windows.Forms.Label();
            this.lbNewMemberDateOfBirth = new System.Windows.Forms.Label();
            this.lbNewMemberName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNewMemberMajor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNewMemberClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbNewMemberMajor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbNewMemberClass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addImageBttn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txbNewMemberEmail);
            this.panel1.Controls.Add(this.txbNewMemberAddress);
            this.panel1.Controls.Add(this.txbNewMemberName);
            this.panel1.Controls.Add(this.lbNewMemberAddress);
            this.panel1.Controls.Add(this.lbNewMemberEmail);
            this.panel1.Controls.Add(this.lbNewMemberDateOfBirth);
            this.panel1.Controls.Add(this.lbNewMemberName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 345);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addImageBttn
            // 
            this.addImageBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageBttn.Location = new System.Drawing.Point(673, 302);
            this.addImageBttn.Margin = new System.Windows.Forms.Padding(2);
            this.addImageBttn.Name = "addImageBttn";
            this.addImageBttn.Size = new System.Drawing.Size(89, 28);
            this.addImageBttn.TabIndex = 9;
            this.addImageBttn.Text = "Add Image";
            this.addImageBttn.UseVisualStyleBackColor = true;
            this.addImageBttn.Click += new System.EventHandler(this.addImageBttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(608, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dtpDateOfBirth.Location = new System.Drawing.Point(168, 161);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(243, 28);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(278, 302);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnRegister.Location = new System.Drawing.Point(169, 302);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
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
            this.txbNewMemberEmail.Location = new System.Drawing.Point(168, 205);
            this.txbNewMemberEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbNewMemberEmail.Name = "txbNewMemberEmail";
            this.txbNewMemberEmail.Size = new System.Drawing.Size(392, 28);
            this.txbNewMemberEmail.TabIndex = 4;
            this.txbNewMemberEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNewMemberEmail_KeyPress);
            // 
            // txbNewMemberAddress
            // 
            this.txbNewMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberAddress.Location = new System.Drawing.Point(168, 246);
            this.txbNewMemberAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txbNewMemberAddress.Name = "txbNewMemberAddress";
            this.txbNewMemberAddress.Size = new System.Drawing.Size(392, 28);
            this.txbNewMemberAddress.TabIndex = 5;
            this.txbNewMemberAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNewMemberEmail_KeyPress);
            // 
            // txbNewMemberName
            // 
            this.txbNewMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberName.Location = new System.Drawing.Point(168, 75);
            this.txbNewMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.txbNewMemberName.Name = "txbNewMemberName";
            this.txbNewMemberName.Size = new System.Drawing.Size(392, 28);
            this.txbNewMemberName.TabIndex = 1;
            this.txbNewMemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNewMemberName_KeyPress);
            // 
            // lbNewMemberAddress
            // 
            this.lbNewMemberAddress.AutoSize = true;
            this.lbNewMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMemberAddress.Location = new System.Drawing.Point(16, 248);
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
            this.lbNewMemberEmail.Location = new System.Drawing.Point(16, 205);
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
            this.lbNewMemberDateOfBirth.Location = new System.Drawing.Point(16, 161);
            this.lbNewMemberDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewMemberDateOfBirth.Name = "lbNewMemberDateOfBirth";
            this.lbNewMemberDateOfBirth.Size = new System.Drawing.Size(119, 24);
            this.lbNewMemberDateOfBirth.TabIndex = 1;
            this.lbNewMemberDateOfBirth.Text = "Date of birth :";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Class:";
            // 
            // txbNewMemberMajor
            // 
            this.txbNewMemberMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberMajor.Location = new System.Drawing.Point(423, 120);
            this.txbNewMemberMajor.Margin = new System.Windows.Forms.Padding(2);
            this.txbNewMemberMajor.Name = "txbNewMemberMajor";
            this.txbNewMemberMajor.Size = new System.Drawing.Size(89, 28);
            this.txbNewMemberMajor.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Major:";
            // 
            // txbNewMemberClass
            // 
            this.txbNewMemberClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewMemberClass.Location = new System.Drawing.Point(227, 120);
            this.txbNewMemberClass.Margin = new System.Windows.Forms.Padding(2);
            this.txbNewMemberClass.Name = "txbNewMemberClass";
            this.txbNewMemberClass.Size = new System.Drawing.Size(89, 28);
            this.txbNewMemberClass.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Class/Major";
            // 
            // frmRegisterNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 363);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegisterNewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register new member";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegisterNewMember_FormClosing);
            this.Load += new System.EventHandler(this.frmRegisterNewMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNewMemberDateOfBirth;
        private System.Windows.Forms.Label lbNewMemberName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txbNewMemberEmail;
        private System.Windows.Forms.TextBox txbNewMemberAddress;
        private System.Windows.Forms.TextBox txbNewMemberName;
        private System.Windows.Forms.Label lbNewMemberAddress;
        private System.Windows.Forms.Label lbNewMemberEmail;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addImageBttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNewMemberMajor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNewMemberClass;
        private System.Windows.Forms.Label label2;
    }
}