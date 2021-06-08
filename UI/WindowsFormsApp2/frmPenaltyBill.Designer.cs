namespace WindowsFormsApp2
{
    partial class frmPenaltyBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPenaltyBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSoTienThuEx = new System.Windows.Forms.Label();
            this.txbStillOwed = new System.Windows.Forms.TextBox();
            this.lbStillOwed = new System.Windows.Forms.Label();
            this.txbPaid = new System.Windows.Forms.TextBox();
            this.lbPaid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalOwedMoney = new System.Windows.Forms.TextBox();
            this.lbTotalOwedMoney = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txbMemberId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMemberName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbSoTienThuEx);
            this.panel1.Controls.Add(this.txbStillOwed);
            this.panel1.Controls.Add(this.lbStillOwed);
            this.panel1.Controls.Add(this.txbPaid);
            this.panel1.Controls.Add(this.lbPaid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTotalOwedMoney);
            this.panel1.Controls.Add(this.lbTotalOwedMoney);
            this.panel1.Controls.Add(this.lbMemberName);
            this.panel1.Controls.Add(this.txbMemberId);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 229);
            this.panel1.TabIndex = 0;
            // 
            // txbMemberName
            // 
            this.txbMemberName.Location = new System.Drawing.Point(148, 81);
            this.txbMemberName.Name = "txbMemberName";
            this.txbMemberName.Size = new System.Drawing.Size(261, 20);
            this.txbMemberName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name:";
            // 
            // lbSoTienThuEx
            // 
            this.lbSoTienThuEx.AutoSize = true;
            this.lbSoTienThuEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienThuEx.ForeColor = System.Drawing.Color.Red;
            this.lbSoTienThuEx.Location = new System.Drawing.Point(108, 176);
            this.lbSoTienThuEx.Name = "lbSoTienThuEx";
            this.lbSoTienThuEx.Size = new System.Drawing.Size(0, 15);
            this.lbSoTienThuEx.TabIndex = 28;
            // 
            // txbStillOwed
            // 
            this.txbStillOwed.Location = new System.Drawing.Point(148, 194);
            this.txbStillOwed.Name = "txbStillOwed";
            this.txbStillOwed.Size = new System.Drawing.Size(261, 20);
            this.txbStillOwed.TabIndex = 26;
            // 
            // lbStillOwed
            // 
            this.lbStillOwed.AutoSize = true;
            this.lbStillOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbStillOwed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbStillOwed.Location = new System.Drawing.Point(3, 194);
            this.lbStillOwed.Name = "lbStillOwed";
            this.lbStillOwed.Size = new System.Drawing.Size(80, 20);
            this.lbStillOwed.TabIndex = 27;
            this.lbStillOwed.Text = "Still owed:";
            // 
            // txbPaid
            // 
            this.txbPaid.Location = new System.Drawing.Point(148, 153);
            this.txbPaid.Name = "txbPaid";
            this.txbPaid.Size = new System.Drawing.Size(261, 20);
            this.txbPaid.TabIndex = 24;
            // 
            // lbPaid
            // 
            this.lbPaid.AutoSize = true;
            this.lbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPaid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPaid.Location = new System.Drawing.Point(3, 153);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(44, 20);
            this.lbPaid.TabIndex = 25;
            this.lbPaid.Text = "Paid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bill";
            // 
            // txbTotalOwedMoney
            // 
            this.txbTotalOwedMoney.Location = new System.Drawing.Point(148, 115);
            this.txbTotalOwedMoney.Name = "txbTotalOwedMoney";
            this.txbTotalOwedMoney.Size = new System.Drawing.Size(261, 20);
            this.txbTotalOwedMoney.TabIndex = 21;
            // 
            // lbTotalOwedMoney
            // 
            this.lbTotalOwedMoney.AutoSize = true;
            this.lbTotalOwedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTotalOwedMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTotalOwedMoney.Location = new System.Drawing.Point(3, 115);
            this.lbTotalOwedMoney.Name = "lbTotalOwedMoney";
            this.lbTotalOwedMoney.Size = new System.Drawing.Size(137, 20);
            this.lbTotalOwedMoney.TabIndex = 22;
            this.lbTotalOwedMoney.Text = "Total owed money";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberName.Location = new System.Drawing.Point(3, 50);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(92, 20);
            this.lbMemberName.TabIndex = 20;
            this.lbMemberName.Text = "Member ID:";
            // 
            // txbMemberId
            // 
            this.txbMemberId.Enabled = false;
            this.txbMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMemberId.Location = new System.Drawing.Point(148, 53);
            this.txbMemberId.Name = "txbMemberId";
            this.txbMemberId.Size = new System.Drawing.Size(261, 19);
            this.txbMemberId.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCreateBill);
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Location = new System.Drawing.Point(13, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 29);
            this.panel2.TabIndex = 1;
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Location = new System.Drawing.Point(252, 3);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBill.TabIndex = 1;
            this.btnCreateBill.Text = "Create bill";
            this.btnCreateBill.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(333, 4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmPenaltyBill
            // 
            this.AcceptButton = this.btnCreateBill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(451, 288);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPenaltyBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.frmPenaltyBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbStillOwed;
        private System.Windows.Forms.Label lbStillOwed;
        private System.Windows.Forms.TextBox txbPaid;
        private System.Windows.Forms.Label lbPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotalOwedMoney;
        private System.Windows.Forms.Label lbTotalOwedMoney;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txbMemberId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lbSoTienThuEx;
        private System.Windows.Forms.TextBox txbMemberName;
        private System.Windows.Forms.Label label2;
    }
}