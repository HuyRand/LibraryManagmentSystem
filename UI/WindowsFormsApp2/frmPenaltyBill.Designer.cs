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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSoTienThuEx = new System.Windows.Forms.Label();
            this.txbStillOwed = new System.Windows.Forms.TextBox();
            this.lbStillOwed = new System.Windows.Forms.Label();
            this.txbPaid = new System.Windows.Forms.TextBox();
            this.lbPaid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalOwedMoney = new System.Windows.Forms.TextBox();
            this.lbTotalOwedMoney = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txbMemberName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSoTienThuEx);
            this.panel1.Controls.Add(this.txbStillOwed);
            this.panel1.Controls.Add(this.lbStillOwed);
            this.panel1.Controls.Add(this.txbPaid);
            this.panel1.Controls.Add(this.lbPaid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTotalOwedMoney);
            this.panel1.Controls.Add(this.lbTotalOwedMoney);
            this.panel1.Controls.Add(this.lbMemberName);
            this.panel1.Controls.Add(this.txbMemberName);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 241);
            this.panel1.TabIndex = 0;
            // 
            // lbSoTienThuEx
            // 
            this.lbSoTienThuEx.AutoSize = true;
            this.lbSoTienThuEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienThuEx.ForeColor = System.Drawing.Color.Red;
            this.lbSoTienThuEx.Location = new System.Drawing.Point(144, 185);
            this.lbSoTienThuEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoTienThuEx.Name = "lbSoTienThuEx";
            this.lbSoTienThuEx.Size = new System.Drawing.Size(0, 18);
            this.lbSoTienThuEx.TabIndex = 28;
            // 
            // txbStillOwed
            // 
            this.txbStillOwed.Enabled = false;
            this.txbStillOwed.Location = new System.Drawing.Point(197, 207);
            this.txbStillOwed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStillOwed.Name = "txbStillOwed";
            this.txbStillOwed.Size = new System.Drawing.Size(347, 22);
            this.txbStillOwed.TabIndex = 26;
            // 
            // lbStillOwed
            // 
            this.lbStillOwed.AutoSize = true;
            this.lbStillOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbStillOwed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbStillOwed.Location = new System.Drawing.Point(4, 207);
            this.lbStillOwed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStillOwed.Name = "lbStillOwed";
            this.lbStillOwed.Size = new System.Drawing.Size(101, 25);
            this.lbStillOwed.TabIndex = 27;
            this.lbStillOwed.Text = "Still owed:";
            // 
            // txbPaid
            // 
            this.txbPaid.Location = new System.Drawing.Point(197, 156);
            this.txbPaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPaid.Name = "txbPaid";
            this.txbPaid.Size = new System.Drawing.Size(347, 22);
            this.txbPaid.TabIndex = 24;
            // 
            // lbPaid
            // 
            this.lbPaid.AutoSize = true;
            this.lbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPaid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPaid.Location = new System.Drawing.Point(4, 156);
            this.lbPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(57, 25);
            this.lbPaid.TabIndex = 25;
            this.lbPaid.Text = "Paid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 54);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bill";
            // 
            // txbTotalOwedMoney
            // 
            this.txbTotalOwedMoney.Enabled = false;
            this.txbTotalOwedMoney.Location = new System.Drawing.Point(197, 110);
            this.txbTotalOwedMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotalOwedMoney.Name = "txbTotalOwedMoney";
            this.txbTotalOwedMoney.Size = new System.Drawing.Size(347, 22);
            this.txbTotalOwedMoney.TabIndex = 21;
            // 
            // lbTotalOwedMoney
            // 
            this.lbTotalOwedMoney.AutoSize = true;
            this.lbTotalOwedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTotalOwedMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTotalOwedMoney.Location = new System.Drawing.Point(4, 110);
            this.lbTotalOwedMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalOwedMoney.Name = "lbTotalOwedMoney";
            this.lbTotalOwedMoney.Size = new System.Drawing.Size(172, 25);
            this.lbTotalOwedMoney.TabIndex = 22;
            this.lbTotalOwedMoney.Text = "Total owed money";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMemberName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMemberName.Location = new System.Drawing.Point(4, 61);
            this.lbMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(90, 25);
            this.lbMemberName.TabIndex = 20;
            this.lbMemberName.Text = "Member:";
            // 
            // txbMemberName
            // 
            this.txbMemberName.Enabled = false;
            this.txbMemberName.Location = new System.Drawing.Point(197, 65);
            this.txbMemberName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMemberName.Name = "txbMemberName";
            this.txbMemberName.Size = new System.Drawing.Size(347, 22);
            this.txbMemberName.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTaoPhieu);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Location = new System.Drawing.Point(17, 265);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 36);
            this.panel2.TabIndex = 1;
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.Enabled = false;
            this.btnTaoPhieu.Location = new System.Drawing.Point(336, 4);
            this.btnTaoPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(100, 28);
            this.btnTaoPhieu.TabIndex = 1;
            this.btnTaoPhieu.Text = "Tạo phiếu";
            this.btnTaoPhieu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(444, 5);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmPenaltyBill
            // 
            this.AcceptButton = this.btnTaoPhieu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(601, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPenaltyBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
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
        private System.Windows.Forms.TextBox txbMemberName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbSoTienThuEx;
    }
}