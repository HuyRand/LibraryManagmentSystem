﻿namespace WindowsFormsApp2
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageborrowReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBorrowTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReturnTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.borrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedBooksDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmBạnĐọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSáchTrảTrễToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTìnhHìnhMượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.sttError = new System.Windows.Forms.StatusStrip();
            this.sttErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMainMenu = new System.Windows.Forms.TabControl();
            this.tpMember = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvMemberInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSearchWithMemberName = new System.Windows.Forms.Label();
            this.lbSearchWithCardnumber = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txbSearchWithMemberName = new System.Windows.Forms.TextBox();
            this.txbSearchWithCardnumber = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegisterNewMember = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTenbandocEX = new System.Windows.Forms.Label();
            this.lbEmailEX = new System.Windows.Forms.Label();
            this.lbCmndEX = new System.Windows.Forms.Label();
            this.dtpRegistrationerDate = new System.Windows.Forms.DateTimePicker();
            this.lbRegistrationDate = new System.Windows.Forms.Label();
            this.btnUserInfoDetail = new System.Windows.Forms.Button();
            this.txbMemberAddress = new System.Windows.Forms.TextBox();
            this.dtpDayOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txbMemberEmail = new System.Windows.Forms.TextBox();
            this.cbMemberType = new System.Windows.Forms.ComboBox();
            this.txbIdentityNumber = new System.Windows.Forms.TextBox();
            this.lbMemberType = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txbMemberName = new System.Windows.Forms.TextBox();
            this.lbIdentityNumber = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbMemberEmail = new System.Windows.Forms.Label();
            this.lbMemberAddress = new System.Windows.Forms.Label();
            this.tpBook = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbSearchWithBookName = new System.Windows.Forms.TextBox();
            this.cbSearchWithGenre = new System.Windows.Forms.ComboBox();
            this.lbSearchWithAuthor = new System.Windows.Forms.Label();
            this.txbSearchWithAuthor = new System.Windows.Forms.TextBox();
            this.lbSearchWithGenre = new System.Windows.Forms.Label();
            this.lbSearchWithBookName = new System.Windows.Forms.Label();
            this.lbSearchWithBookID = new System.Windows.Forms.Label();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.txbSearchWithBookID = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnChangeBookInfo = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbNamxbEX = new System.Windows.Forms.Label();
            this.lbMasSachEX = new System.Windows.Forms.Label();
            this.lbGiaTriEX = new System.Windows.Forms.Label();
            this.cbBookState = new System.Windows.Forms.ComboBox();
            this.lbBookState = new System.Windows.Forms.Label();
            this.btnBookInfoDetail = new System.Windows.Forms.Button();
            this.txbBookPrice = new System.Windows.Forms.TextBox();
            this.lbBookPrice = new System.Windows.Forms.Label();
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
            this.tpStatistics = new System.Windows.Forms.TabPage();
            this.btnShowList = new System.Windows.Forms.Button();
            this.lbTimeOfStatistic = new System.Windows.Forms.Label();
            this.dtmThongKe = new System.Windows.Forms.DateTimePicker();
            this.pnlTypeOfStatistic = new System.Windows.Forms.Panel();
            this.rdoTheLoai = new System.Windows.Forms.RadioButton();
            this.rdoTacGiaYeuThich = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbOwedMoney = new System.Windows.Forms.Label();
            this.txbOwedMoney = new System.Windows.Forms.TextBox();
            this.receivePenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.sttError.SuspendLayout();
            this.tcMainMenu.SuspendLayout();
            this.tpMember.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpBook.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tpStatistics.SuspendLayout();
            this.pnlTypeOfStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.ManageborrowReturnToolStripMenuItem,
            this.borrowedBooksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterNewMemberToolStripMenuItem,
            this.addNewBookToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // RegisterNewMemberToolStripMenuItem
            // 
            this.RegisterNewMemberToolStripMenuItem.Name = "RegisterNewMemberToolStripMenuItem";
            this.RegisterNewMemberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.RegisterNewMemberToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.RegisterNewMemberToolStripMenuItem.Text = "Register new member";
            this.RegisterNewMemberToolStripMenuItem.Click += new System.EventHandler(this.RegisterNewMemberToolStripMenuItem_Click);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.addNewBookToolStripMenuItem.Text = "Add new book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // ManageborrowReturnToolStripMenuItem
            // 
            this.ManageborrowReturnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBorrowTicketToolStripMenuItem,
            this.createReturnTicketToolStripMenuItem,
            this.toolStripMenuItem1,
            this.receivePenaltyToolStripMenuItem});
            this.ManageborrowReturnToolStripMenuItem.Name = "ManageborrowReturnToolStripMenuItem";
            this.ManageborrowReturnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ManageborrowReturnToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.ManageborrowReturnToolStripMenuItem.Text = "Manage Borrow/Return ";
            // 
            // createBorrowTicketToolStripMenuItem
            // 
            this.createBorrowTicketToolStripMenuItem.Name = "createBorrowTicketToolStripMenuItem";
            this.createBorrowTicketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.createBorrowTicketToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.createBorrowTicketToolStripMenuItem.Text = "Create borrow ticket";
            this.createBorrowTicketToolStripMenuItem.Click += new System.EventHandler(this.createBorrowTicketToolStripMenuItem_Click);
            // 
            // createReturnTicketToolStripMenuItem
            // 
            this.createReturnTicketToolStripMenuItem.Name = "createReturnTicketToolStripMenuItem";
            this.createReturnTicketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.createReturnTicketToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.createReturnTicketToolStripMenuItem.Text = "Create return ticket";
            this.createReturnTicketToolStripMenuItem.Click += new System.EventHandler(this.createReturnTicketToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(306, 6);
            // 
            // borrowedBooksToolStripMenuItem
            // 
            this.borrowedBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowedBooksDetailToolStripMenuItem});
            this.borrowedBooksToolStripMenuItem.Name = "borrowedBooksToolStripMenuItem";
            this.borrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.borrowedBooksToolStripMenuItem.Text = "Borrowed books";
            // 
            // borrowedBooksDetailToolStripMenuItem
            // 
            this.borrowedBooksDetailToolStripMenuItem.Name = "borrowedBooksDetailToolStripMenuItem";
            this.borrowedBooksDetailToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.borrowedBooksDetailToolStripMenuItem.Text = "Borrowed books detail";
            this.borrowedBooksDetailToolStripMenuItem.Click += new System.EventHandler(this.borrowedBooksDetailToolStripMenuItem_Click);
            // 
            // tìmKiếmBạnĐọcToolStripMenuItem
            // 
            this.tìmKiếmBạnĐọcToolStripMenuItem.Name = "tìmKiếmBạnĐọcToolStripMenuItem";
            this.tìmKiếmBạnĐọcToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tìmKiếmSáchToolStripMenuItem
            // 
            this.tìmKiếmSáchToolStripMenuItem.Name = "tìmKiếmSáchToolStripMenuItem";
            this.tìmKiếmSáchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // thốngKêSáchTrảTrễToolStripMenuItem
            // 
            this.thốngKêSáchTrảTrễToolStripMenuItem.Name = "thốngKêSáchTrảTrễToolStripMenuItem";
            this.thốngKêSáchTrảTrễToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // thốngKêTìnhHìnhMượnSáchToolStripMenuItem
            // 
            this.thốngKêTìnhHìnhMượnSáchToolStripMenuItem.Name = "thốngKêTìnhHìnhMượnSáchToolStripMenuItem";
            this.thốngKêTìnhHìnhMượnSáchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.sttError);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tcMainMenu);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1293, 708);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1293, 736);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // sttError
            // 
            this.sttError.Dock = System.Windows.Forms.DockStyle.None;
            this.sttError.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sttError.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttErrorLabel,
            this.toolStripStatusLabel1});
            this.sttError.Location = new System.Drawing.Point(7, 676);
            this.sttError.Name = "sttError";
            this.sttError.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sttError.Size = new System.Drawing.Size(22, 22);
            this.sttError.TabIndex = 20;
            this.sttError.Text = "statusStrip1";
            // 
            // sttErrorLabel
            // 
            this.sttErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.sttErrorLabel.Name = "sttErrorLabel";
            this.sttErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.sttErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // tcMainMenu
            // 
            this.tcMainMenu.Controls.Add(this.tpMember);
            this.tcMainMenu.Controls.Add(this.tpBook);
            this.tcMainMenu.Controls.Add(this.tpStatistics);
            this.tcMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMainMenu.ItemSize = new System.Drawing.Size(150, 50);
            this.tcMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tcMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tcMainMenu.Name = "tcMainMenu";
            this.tcMainMenu.SelectedIndex = 0;
            this.tcMainMenu.Size = new System.Drawing.Size(1293, 676);
            this.tcMainMenu.TabIndex = 1;
            this.tcMainMenu.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // tpMember
            // 
            this.tpMember.Controls.Add(this.panel11);
            this.tpMember.Controls.Add(this.panel1);
            this.tpMember.Controls.Add(this.flowLayoutPanel4);
            this.tpMember.Controls.Add(this.flowLayoutPanel3);
            this.tpMember.Location = new System.Drawing.Point(4, 54);
            this.tpMember.Margin = new System.Windows.Forms.Padding(4);
            this.tpMember.Name = "tpMember";
            this.tpMember.Padding = new System.Windows.Forms.Padding(4);
            this.tpMember.Size = new System.Drawing.Size(1285, 618);
            this.tpMember.TabIndex = 0;
            this.tpMember.Text = "   Member  ";
            this.tpMember.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvMemberInfo);
            this.panel11.Location = new System.Drawing.Point(4, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(633, 591);
            this.panel11.TabIndex = 3;
            // 
            // dgvMemberInfo
            // 
            this.dgvMemberInfo.AllowUserToAddRows = false;
            this.dgvMemberInfo.AllowUserToDeleteRows = false;
            this.dgvMemberInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvMemberInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMemberInfo.Name = "dgvMemberInfo";
            this.dgvMemberInfo.ReadOnly = true;
            this.dgvMemberInfo.RowHeadersWidth = 51;
            this.dgvMemberInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberInfo.Size = new System.Drawing.Size(633, 591);
            this.dgvMemberInfo.TabIndex = 0;
            this.dgvMemberInfo.TabStop = false;
            this.dgvMemberInfo.SelectionChanged += new System.EventHandler(this.dgvMemberInfo_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbSearchWithMemberName);
            this.panel1.Controls.Add(this.lbSearchWithCardnumber);
            this.panel1.Controls.Add(this.btnSearchUser);
            this.panel1.Controls.Add(this.txbSearchWithMemberName);
            this.panel1.Controls.Add(this.txbSearchWithCardnumber);
            this.panel1.Location = new System.Drawing.Point(645, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 114);
            this.panel1.TabIndex = 0;
            // 
            // lbSearchWithMemberName
            // 
            this.lbSearchWithMemberName.AutoSize = true;
            this.lbSearchWithMemberName.Location = new System.Drawing.Point(5, 59);
            this.lbSearchWithMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchWithMemberName.Name = "lbSearchWithMemberName";
            this.lbSearchWithMemberName.Size = new System.Drawing.Size(90, 29);
            this.lbSearchWithMemberName.TabIndex = 4;
            this.lbSearchWithMemberName.Text = " Name:";
            // 
            // lbSearchWithCardnumber
            // 
            this.lbSearchWithCardnumber.AutoSize = true;
            this.lbSearchWithCardnumber.Location = new System.Drawing.Point(5, 16);
            this.lbSearchWithCardnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchWithCardnumber.Name = "lbSearchWithCardnumber";
            this.lbSearchWithCardnumber.Size = new System.Drawing.Size(164, 29);
            this.lbSearchWithCardnumber.TabIndex = 3;
            this.lbSearchWithCardnumber.Text = "Card Number:";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(500, 14);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(121, 79);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txbSearchWithMemberName
            // 
            this.txbSearchWithMemberName.Location = new System.Drawing.Point(204, 57);
            this.txbSearchWithMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchWithMemberName.Name = "txbSearchWithMemberName";
            this.txbSearchWithMemberName.Size = new System.Drawing.Size(285, 34);
            this.txbSearchWithMemberName.TabIndex = 1;
            // 
            // txbSearchWithCardnumber
            // 
            this.txbSearchWithCardnumber.Location = new System.Drawing.Point(204, 14);
            this.txbSearchWithCardnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchWithCardnumber.Name = "txbSearchWithCardnumber";
            this.txbSearchWithCardnumber.Size = new System.Drawing.Size(285, 34);
            this.txbSearchWithCardnumber.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.btnRegisterNewMember);
            this.flowLayoutPanel4.Controls.Add(this.btnChange);
            this.flowLayoutPanel4.Controls.Add(this.btnDelete);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(645, 482);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(629, 118);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // btnRegisterNewMember
            // 
            this.btnRegisterNewMember.Location = new System.Drawing.Point(4, 4);
            this.btnRegisterNewMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterNewMember.Name = "btnRegisterNewMember";
            this.btnRegisterNewMember.Size = new System.Drawing.Size(201, 111);
            this.btnRegisterNewMember.TabIndex = 0;
            this.btnRegisterNewMember.Text = "Register new member";
            this.btnRegisterNewMember.UseVisualStyleBackColor = true;
            this.btnRegisterNewMember.Click += new System.EventHandler(this.btnRegisterNewMember_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(213, 4);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(201, 111);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(422, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 111);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.panel3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(645, 126);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(628, 349);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTenbandocEX);
            this.panel3.Controls.Add(this.lbEmailEX);
            this.panel3.Controls.Add(this.lbCmndEX);
            this.panel3.Controls.Add(this.dtpRegistrationerDate);
            this.panel3.Controls.Add(this.lbRegistrationDate);
            this.panel3.Controls.Add(this.btnUserInfoDetail);
            this.panel3.Controls.Add(this.txbOwedMoney);
            this.panel3.Controls.Add(this.txbMemberAddress);
            this.panel3.Controls.Add(this.dtpDayOfBirth);
            this.panel3.Controls.Add(this.txbMemberEmail);
            this.panel3.Controls.Add(this.cbMemberType);
            this.panel3.Controls.Add(this.txbIdentityNumber);
            this.panel3.Controls.Add(this.lbOwedMoney);
            this.panel3.Controls.Add(this.lbMemberType);
            this.panel3.Controls.Add(this.lbMemberName);
            this.panel3.Controls.Add(this.txbMemberName);
            this.panel3.Controls.Add(this.lbIdentityNumber);
            this.panel3.Controls.Add(this.lbDateOfBirth);
            this.panel3.Controls.Add(this.lbMemberEmail);
            this.panel3.Controls.Add(this.lbMemberAddress);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 606);
            this.panel3.TabIndex = 3;
            // 
            // lbTenbandocEX
            // 
            this.lbTenbandocEX.AutoSize = true;
            this.lbTenbandocEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenbandocEX.ForeColor = System.Drawing.Color.Red;
            this.lbTenbandocEX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTenbandocEX.Location = new System.Drawing.Point(147, 112);
            this.lbTenbandocEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenbandocEX.Name = "lbTenbandocEX";
            this.lbTenbandocEX.Size = new System.Drawing.Size(0, 18);
            this.lbTenbandocEX.TabIndex = 25;
            // 
            // lbEmailEX
            // 
            this.lbEmailEX.AutoSize = true;
            this.lbEmailEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailEX.ForeColor = System.Drawing.Color.Red;
            this.lbEmailEX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEmailEX.Location = new System.Drawing.Point(147, 320);
            this.lbEmailEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmailEX.Name = "lbEmailEX";
            this.lbEmailEX.Size = new System.Drawing.Size(0, 18);
            this.lbEmailEX.TabIndex = 24;
            // 
            // lbCmndEX
            // 
            this.lbCmndEX.AutoSize = true;
            this.lbCmndEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCmndEX.ForeColor = System.Drawing.Color.Red;
            this.lbCmndEX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCmndEX.Location = new System.Drawing.Point(147, 188);
            this.lbCmndEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCmndEX.Name = "lbCmndEX";
            this.lbCmndEX.Size = new System.Drawing.Size(0, 18);
            this.lbCmndEX.TabIndex = 23;
            // 
            // dtpRegistrationerDate
            // 
            this.dtpRegistrationerDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRegistrationerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegistrationerDate.Location = new System.Drawing.Point(167, 494);
            this.dtpRegistrationerDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRegistrationerDate.Name = "dtpRegistrationerDate";
            this.dtpRegistrationerDate.Size = new System.Drawing.Size(265, 34);
            this.dtpRegistrationerDate.TabIndex = 19;
            // 
            // lbRegistrationDate
            // 
            this.lbRegistrationDate.AutoSize = true;
            this.lbRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrationDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRegistrationDate.Location = new System.Drawing.Point(5, 494);
            this.lbRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegistrationDate.Name = "lbRegistrationDate";
            this.lbRegistrationDate.Size = new System.Drawing.Size(154, 24);
            this.lbRegistrationDate.TabIndex = 21;
            this.lbRegistrationDate.Text = "Registration date:";
            // 
            // btnUserInfoDetail
            // 
            this.btnUserInfoDetail.Location = new System.Drawing.Point(9, 4);
            this.btnUserInfoDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserInfoDetail.Name = "btnUserInfoDetail";
            this.btnUserInfoDetail.Size = new System.Drawing.Size(568, 62);
            this.btnUserInfoDetail.TabIndex = 0;
            this.btnUserInfoDetail.Text = "Detail";
            this.btnUserInfoDetail.UseVisualStyleBackColor = true;
            this.btnUserInfoDetail.Click += new System.EventHandler(this.btnUserInfoDetail_Click);
            // 
            // txbMemberAddress
            // 
            this.txbMemberAddress.Location = new System.Drawing.Point(144, 356);
            this.txbMemberAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbMemberAddress.Name = "txbMemberAddress";
            this.txbMemberAddress.Size = new System.Drawing.Size(432, 34);
            this.txbMemberAddress.TabIndex = 5;
            this.txbMemberAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMemberAddress_KeyPress);
            // 
            // dtpDayOfBirth
            // 
            this.dtpDayOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDayOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayOfBirth.Location = new System.Drawing.Point(144, 222);
            this.dtpDayOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDayOfBirth.Name = "dtpDayOfBirth";
            this.dtpDayOfBirth.Size = new System.Drawing.Size(265, 34);
            this.dtpDayOfBirth.TabIndex = 3;
            // 
            // txbMemberEmail
            // 
            this.txbMemberEmail.Location = new System.Drawing.Point(144, 281);
            this.txbMemberEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbMemberEmail.Name = "txbMemberEmail";
            this.txbMemberEmail.Size = new System.Drawing.Size(432, 34);
            this.txbMemberEmail.TabIndex = 4;
            this.txbMemberEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMemberAddress_KeyPress);
            // 
            // cbMemberType
            // 
            this.cbMemberType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMemberType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMemberType.FormattingEnabled = true;
            this.cbMemberType.Location = new System.Drawing.Point(144, 418);
            this.cbMemberType.Margin = new System.Windows.Forms.Padding(4);
            this.cbMemberType.Name = "cbMemberType";
            this.cbMemberType.Size = new System.Drawing.Size(265, 37);
            this.cbMemberType.TabIndex = 6;
            // 
            // txbIdentityNumber
            // 
            this.txbIdentityNumber.Enabled = false;
            this.txbIdentityNumber.Location = new System.Drawing.Point(144, 148);
            this.txbIdentityNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbIdentityNumber.Name = "txbIdentityNumber";
            this.txbIdentityNumber.Size = new System.Drawing.Size(432, 34);
            this.txbIdentityNumber.TabIndex = 2;
            // 
            // lbMemberType
            // 
            this.lbMemberType.AutoSize = true;
            this.lbMemberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberType.Location = new System.Drawing.Point(4, 420);
            this.lbMemberType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberType.Name = "lbMemberType";
            this.lbMemberType.Size = new System.Drawing.Size(109, 25);
            this.lbMemberType.TabIndex = 14;
            this.lbMemberType.Text = "User Type:";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberName.Location = new System.Drawing.Point(3, 87);
            this.lbMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(75, 25);
            this.lbMemberName.TabIndex = 1;
            this.lbMemberName.Text = " Name:";
            // 
            // txbMemberName
            // 
            this.txbMemberName.Location = new System.Drawing.Point(144, 87);
            this.txbMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.txbMemberName.Name = "txbMemberName";
            this.txbMemberName.Size = new System.Drawing.Size(432, 34);
            this.txbMemberName.TabIndex = 1;
            this.txbMemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMemberName_KeyPress);
            // 
            // lbIdentityNumber
            // 
            this.lbIdentityNumber.AutoSize = true;
            this.lbIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentityNumber.Location = new System.Drawing.Point(4, 156);
            this.lbIdentityNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdentityNumber.Name = "lbIdentityNumber";
            this.lbIdentityNumber.Size = new System.Drawing.Size(128, 20);
            this.lbIdentityNumber.TabIndex = 3;
            this.lbIdentityNumber.Text = "Identity number:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(4, 226);
            this.lbDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(122, 25);
            this.lbDateOfBirth.TabIndex = 5;
            this.lbDateOfBirth.Text = "Date of birth:";
            // 
            // lbMemberEmail
            // 
            this.lbMemberEmail.AutoSize = true;
            this.lbMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberEmail.Location = new System.Drawing.Point(4, 288);
            this.lbMemberEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberEmail.Name = "lbMemberEmail";
            this.lbMemberEmail.Size = new System.Drawing.Size(66, 25);
            this.lbMemberEmail.TabIndex = 7;
            this.lbMemberEmail.Text = "Email:";
            // 
            // lbMemberAddress
            // 
            this.lbMemberAddress.AutoSize = true;
            this.lbMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberAddress.Location = new System.Drawing.Point(4, 356);
            this.lbMemberAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberAddress.Name = "lbMemberAddress";
            this.lbMemberAddress.Size = new System.Drawing.Size(91, 25);
            this.lbMemberAddress.TabIndex = 9;
            this.lbMemberAddress.Text = "Address:";
            // 
            // tpBook
            // 
            this.tpBook.Controls.Add(this.panel12);
            this.tpBook.Controls.Add(this.panel2);
            this.tpBook.Controls.Add(this.flowLayoutPanel2);
            this.tpBook.Controls.Add(this.flowLayoutPanel5);
            this.tpBook.Location = new System.Drawing.Point(4, 54);
            this.tpBook.Margin = new System.Windows.Forms.Padding(4);
            this.tpBook.Name = "tpBook";
            this.tpBook.Padding = new System.Windows.Forms.Padding(4);
            this.tpBook.Size = new System.Drawing.Size(1285, 618);
            this.tpBook.TabIndex = 1;
            this.tpBook.Text = "    Book   ";
            this.tpBook.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dgvBookInfo);
            this.panel12.Location = new System.Drawing.Point(4, 4);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(636, 597);
            this.panel12.TabIndex = 8;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToAddRows = false;
            this.dgvBookInfo.AllowUserToDeleteRows = false;
            this.dgvBookInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvBookInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.ReadOnly = true;
            this.dgvBookInfo.RowHeadersWidth = 51;
            this.dgvBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookInfo.Size = new System.Drawing.Size(636, 597);
            this.dgvBookInfo.TabIndex = 1;
            this.dgvBookInfo.TabStop = false;
            this.dgvBookInfo.SelectionChanged += new System.EventHandler(this.dgvBookInfo_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txbSearchWithBookName);
            this.panel2.Controls.Add(this.cbSearchWithGenre);
            this.panel2.Controls.Add(this.lbSearchWithAuthor);
            this.panel2.Controls.Add(this.txbSearchWithAuthor);
            this.panel2.Controls.Add(this.lbSearchWithGenre);
            this.panel2.Controls.Add(this.lbSearchWithBookName);
            this.panel2.Controls.Add(this.lbSearchWithBookID);
            this.panel2.Controls.Add(this.btnBookSearch);
            this.panel2.Controls.Add(this.txbSearchWithBookID);
            this.panel2.Location = new System.Drawing.Point(648, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 186);
            this.panel2.TabIndex = 0;
            // 
            // txbSearchWithBookName
            // 
            this.txbSearchWithBookName.Location = new System.Drawing.Point(128, 57);
            this.txbSearchWithBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchWithBookName.Name = "txbSearchWithBookName";
            this.txbSearchWithBookName.Size = new System.Drawing.Size(332, 34);
            this.txbSearchWithBookName.TabIndex = 1;
            // 
            // cbSearchWithGenre
            // 
            this.cbSearchWithGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearchWithGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchWithGenre.FormattingEnabled = true;
            this.cbSearchWithGenre.Location = new System.Drawing.Point(128, 98);
            this.cbSearchWithGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cbSearchWithGenre.Name = "cbSearchWithGenre";
            this.cbSearchWithGenre.Size = new System.Drawing.Size(332, 37);
            this.cbSearchWithGenre.TabIndex = 2;
            // 
            // lbSearchWithAuthor
            // 
            this.lbSearchWithAuthor.AutoSize = true;
            this.lbSearchWithAuthor.Location = new System.Drawing.Point(5, 145);
            this.lbSearchWithAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchWithAuthor.Name = "lbSearchWithAuthor";
            this.lbSearchWithAuthor.Size = new System.Drawing.Size(88, 29);
            this.lbSearchWithAuthor.TabIndex = 8;
            this.lbSearchWithAuthor.Text = "Author:";
            // 
            // txbSearchWithAuthor
            // 
            this.txbSearchWithAuthor.Location = new System.Drawing.Point(128, 143);
            this.txbSearchWithAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchWithAuthor.Name = "txbSearchWithAuthor";
            this.txbSearchWithAuthor.Size = new System.Drawing.Size(332, 34);
            this.txbSearchWithAuthor.TabIndex = 3;
            // 
            // lbSearchWithGenre
            // 
            this.lbSearchWithGenre.AutoSize = true;
            this.lbSearchWithGenre.Location = new System.Drawing.Point(5, 102);
            this.lbSearchWithGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchWithGenre.Name = "lbSearchWithGenre";
            this.lbSearchWithGenre.Size = new System.Drawing.Size(86, 29);
            this.lbSearchWithGenre.TabIndex = 6;
            this.lbSearchWithGenre.Text = "Genre:";
            // 
            // lbSearchWithBookName
            // 
            this.lbSearchWithBookName.AutoSize = true;
            this.lbSearchWithBookName.Location = new System.Drawing.Point(5, 59);
            this.lbSearchWithBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchWithBookName.Name = "lbSearchWithBookName";
            this.lbSearchWithBookName.Size = new System.Drawing.Size(84, 29);
            this.lbSearchWithBookName.TabIndex = 4;
            this.lbSearchWithBookName.Text = "Name:";
            // 
            // lbSearchWithBookID
            // 
            this.lbSearchWithBookID.AutoSize = true;
            this.lbSearchWithBookID.Location = new System.Drawing.Point(5, 16);
            this.lbSearchWithBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchWithBookID.Name = "lbSearchWithBookID";
            this.lbSearchWithBookID.Size = new System.Drawing.Size(104, 29);
            this.lbSearchWithBookID.TabIndex = 3;
            this.lbSearchWithBookID.Text = "Book ID:";
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(469, 14);
            this.btnBookSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(152, 161);
            this.btnBookSearch.TabIndex = 4;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // txbSearchWithBookID
            // 
            this.txbSearchWithBookID.Location = new System.Drawing.Point(128, 14);
            this.txbSearchWithBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchWithBookID.Name = "txbSearchWithBookID";
            this.txbSearchWithBookID.Size = new System.Drawing.Size(332, 34);
            this.txbSearchWithBookID.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.btnAddNewBook);
            this.flowLayoutPanel2.Controls.Add(this.btnChangeBookInfo);
            this.flowLayoutPanel2.Controls.Add(this.btnDeleteBook);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(648, 482);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(629, 118);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(4, 4);
            this.btnAddNewBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(201, 111);
            this.btnAddNewBook.TabIndex = 5;
            this.btnAddNewBook.Text = "Add new book";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnChangeBookInfo
            // 
            this.btnChangeBookInfo.Location = new System.Drawing.Point(213, 4);
            this.btnChangeBookInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeBookInfo.Name = "btnChangeBookInfo";
            this.btnChangeBookInfo.Size = new System.Drawing.Size(201, 111);
            this.btnChangeBookInfo.TabIndex = 100;
            this.btnChangeBookInfo.Text = "Change";
            this.btnChangeBookInfo.UseVisualStyleBackColor = true;
            this.btnChangeBookInfo.Click += new System.EventHandler(this.btnChangeBookInfo_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(422, 4);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(201, 111);
            this.btnDeleteBook.TabIndex = 17;
            this.btnDeleteBook.Text = "Delete ";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoScroll = true;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel5.Controls.Add(this.panel4);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(648, 198);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(628, 276);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbNamxbEX);
            this.panel4.Controls.Add(this.lbMasSachEX);
            this.panel4.Controls.Add(this.lbGiaTriEX);
            this.panel4.Controls.Add(this.cbBookState);
            this.panel4.Controls.Add(this.lbBookState);
            this.panel4.Controls.Add(this.btnBookInfoDetail);
            this.panel4.Controls.Add(this.txbBookPrice);
            this.panel4.Controls.Add(this.lbBookPrice);
            this.panel4.Controls.Add(this.txbPublishYear);
            this.panel4.Controls.Add(this.txbPublisher);
            this.panel4.Controls.Add(this.txbAuthor);
            this.panel4.Controls.Add(this.cbGenre);
            this.panel4.Controls.Add(this.txbBookID);
            this.panel4.Controls.Add(this.lbPublishYear);
            this.panel4.Controls.Add(this.lbBookName);
            this.panel4.Controls.Add(this.txbBookName);
            this.panel4.Controls.Add(this.lbBookID);
            this.panel4.Controls.Add(this.lbGenre);
            this.panel4.Controls.Add(this.lbAuthor);
            this.panel4.Controls.Add(this.lbPublisher);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(593, 588);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbNamxbEX
            // 
            this.lbNamxbEX.AutoSize = true;
            this.lbNamxbEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamxbEX.ForeColor = System.Drawing.Color.Red;
            this.lbNamxbEX.Location = new System.Drawing.Point(143, 486);
            this.lbNamxbEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNamxbEX.Name = "lbNamxbEX";
            this.lbNamxbEX.Size = new System.Drawing.Size(0, 18);
            this.lbNamxbEX.TabIndex = 42;
            // 
            // lbMasSachEX
            // 
            this.lbMasSachEX.AutoSize = true;
            this.lbMasSachEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMasSachEX.ForeColor = System.Drawing.Color.Red;
            this.lbMasSachEX.Location = new System.Drawing.Point(143, 174);
            this.lbMasSachEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMasSachEX.Name = "lbMasSachEX";
            this.lbMasSachEX.Size = new System.Drawing.Size(0, 18);
            this.lbMasSachEX.TabIndex = 41;
            // 
            // lbGiaTriEX
            // 
            this.lbGiaTriEX.AutoSize = true;
            this.lbGiaTriEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTriEX.ForeColor = System.Drawing.Color.Red;
            this.lbGiaTriEX.Location = new System.Drawing.Point(143, 564);
            this.lbGiaTriEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaTriEX.Name = "lbGiaTriEX";
            this.lbGiaTriEX.Size = new System.Drawing.Size(0, 18);
            this.lbGiaTriEX.TabIndex = 40;
            // 
            // cbBookState
            // 
            this.cbBookState.Enabled = false;
            this.cbBookState.FormattingEnabled = true;
            this.cbBookState.Location = new System.Drawing.Point(144, 599);
            this.cbBookState.Margin = new System.Windows.Forms.Padding(4);
            this.cbBookState.Name = "cbBookState";
            this.cbBookState.Size = new System.Drawing.Size(265, 37);
            this.cbBookState.TabIndex = 14;
            this.cbBookState.Visible = false;
            // 
            // lbBookState
            // 
            this.lbBookState.AutoSize = true;
            this.lbBookState.Enabled = false;
            this.lbBookState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookState.Location = new System.Drawing.Point(4, 601);
            this.lbBookState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookState.Name = "lbBookState";
            this.lbBookState.Size = new System.Drawing.Size(64, 25);
            this.lbBookState.TabIndex = 39;
            this.lbBookState.Text = "State:";
            this.lbBookState.Visible = false;
            // 
            // btnBookInfoDetail
            // 
            this.btnBookInfoDetail.Location = new System.Drawing.Point(4, 4);
            this.btnBookInfoDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookInfoDetail.Name = "btnBookInfoDetail";
            this.btnBookInfoDetail.Size = new System.Drawing.Size(585, 62);
            this.btnBookInfoDetail.TabIndex = 5;
            this.btnBookInfoDetail.Text = "Detail";
            this.btnBookInfoDetail.UseVisualStyleBackColor = true;
            this.btnBookInfoDetail.Click += new System.EventHandler(this.btnBookInfoDetail_Click);
            // 
            // txbBookPrice
            // 
            this.txbBookPrice.Location = new System.Drawing.Point(144, 524);
            this.txbBookPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookPrice.Name = "txbBookPrice";
            this.txbBookPrice.Size = new System.Drawing.Size(435, 34);
            this.txbBookPrice.TabIndex = 13;
            this.txbBookPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyInput);
            // 
            // lbBookPrice
            // 
            this.lbBookPrice.AutoSize = true;
            this.lbBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookPrice.Location = new System.Drawing.Point(5, 524);
            this.lbBookPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookPrice.Name = "lbBookPrice";
            this.lbBookPrice.Size = new System.Drawing.Size(62, 25);
            this.lbBookPrice.TabIndex = 19;
            this.lbBookPrice.Text = "Price:";
            // 
            // txbPublishYear
            // 
            this.txbPublishYear.Location = new System.Drawing.Point(144, 448);
            this.txbPublishYear.Margin = new System.Windows.Forms.Padding(4);
            this.txbPublishYear.Name = "txbPublishYear";
            this.txbPublishYear.Size = new System.Drawing.Size(435, 34);
            this.txbPublishYear.TabIndex = 12;
            this.txbPublishYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyInput);
            // 
            // txbPublisher
            // 
            this.txbPublisher.Location = new System.Drawing.Point(144, 359);
            this.txbPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Size = new System.Drawing.Size(435, 34);
            this.txbPublisher.TabIndex = 10;
            this.txbPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBookName_KeyPress);
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(144, 283);
            this.txbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(435, 34);
            this.txbAuthor.TabIndex = 9;
            this.txbAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBookName_KeyPress);
            // 
            // cbGenre
            // 
            this.cbGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(144, 206);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(265, 37);
            this.cbGenre.TabIndex = 8;
            // 
            // txbBookID
            // 
            this.txbBookID.Enabled = false;
            this.txbBookID.Location = new System.Drawing.Point(144, 134);
            this.txbBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(435, 34);
            this.txbBookID.TabIndex = 7;
            // 
            // lbPublishYear
            // 
            this.lbPublishYear.AutoSize = true;
            this.lbPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublishYear.Location = new System.Drawing.Point(1, 454);
            this.lbPublishYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublishYear.Name = "lbPublishYear";
            this.lbPublishYear.Size = new System.Drawing.Size(128, 25);
            this.lbPublishYear.TabIndex = 14;
            this.lbPublishYear.Text = "Publish Year:";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(1, 85);
            this.lbBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(120, 25);
            this.lbBookName.TabIndex = 1;
            this.lbBookName.Text = "Book Name:";
            // 
            // txbBookName
            // 
            this.txbBookName.Location = new System.Drawing.Point(144, 76);
            this.txbBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(435, 34);
            this.txbBookName.TabIndex = 6;
            this.txbBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBookName_KeyPress);
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookID.Location = new System.Drawing.Point(5, 143);
            this.lbBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(87, 25);
            this.lbBookID.TabIndex = 3;
            this.lbBookID.Text = "Book ID:";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(5, 212);
            this.lbGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(72, 25);
            this.lbGenre.TabIndex = 5;
            this.lbGenre.Text = "Genre:";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(4, 289);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(76, 25);
            this.lbAuthor.TabIndex = 7;
            this.lbAuthor.Text = "Author:";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.Location = new System.Drawing.Point(5, 366);
            this.lbPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(99, 25);
            this.lbPublisher.TabIndex = 9;
            this.lbPublisher.Text = "Publisher:";
            // 
            // tpStatistics
            // 
            this.tpStatistics.Controls.Add(this.btnShowList);
            this.tpStatistics.Controls.Add(this.lbTimeOfStatistic);
            this.tpStatistics.Controls.Add(this.dtmThongKe);
            this.tpStatistics.Controls.Add(this.pnlTypeOfStatistic);
            this.tpStatistics.Controls.Add(this.dgvStatistics);
            this.tpStatistics.Location = new System.Drawing.Point(4, 54);
            this.tpStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.tpStatistics.Name = "tpStatistics";
            this.tpStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.tpStatistics.Size = new System.Drawing.Size(1285, 618);
            this.tpStatistics.TabIndex = 5;
            this.tpStatistics.Text = "  Statistics  ";
            this.tpStatistics.UseVisualStyleBackColor = true;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(721, 265);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(251, 70);
            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "Show list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // lbTimeOfStatistic
            // 
            this.lbTimeOfStatistic.AutoSize = true;
            this.lbTimeOfStatistic.Location = new System.Drawing.Point(716, 186);
            this.lbTimeOfStatistic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeOfStatistic.Name = "lbTimeOfStatistic";
            this.lbTimeOfStatistic.Size = new System.Drawing.Size(186, 29);
            this.lbTimeOfStatistic.TabIndex = 3;
            this.lbTimeOfStatistic.Text = "Time of statistic:";
            // 
            // dtmThongKe
            // 
            this.dtmThongKe.CustomFormat = "MM/yyyy";
            this.dtmThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmThongKe.Location = new System.Drawing.Point(960, 181);
            this.dtmThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dtmThongKe.Name = "dtmThongKe";
            this.dtmThongKe.Size = new System.Drawing.Size(311, 34);
            this.dtmThongKe.TabIndex = 2;
            // 
            // pnlTypeOfStatistic
            // 
            this.pnlTypeOfStatistic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTypeOfStatistic.Controls.Add(this.rdoTheLoai);
            this.pnlTypeOfStatistic.Controls.Add(this.rdoTacGiaYeuThich);
            this.pnlTypeOfStatistic.Controls.Add(this.label1);
            this.pnlTypeOfStatistic.Location = new System.Drawing.Point(692, 7);
            this.pnlTypeOfStatistic.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTypeOfStatistic.Name = "pnlTypeOfStatistic";
            this.pnlTypeOfStatistic.Size = new System.Drawing.Size(579, 150);
            this.pnlTypeOfStatistic.TabIndex = 1;
            // 
            // rdoTheLoai
            // 
            this.rdoTheLoai.AutoSize = true;
            this.rdoTheLoai.Location = new System.Drawing.Point(83, 91);
            this.rdoTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTheLoai.Name = "rdoTheLoai";
            this.rdoTheLoai.Size = new System.Drawing.Size(292, 33);
            this.rdoTheLoai.TabIndex = 2;
            this.rdoTheLoai.Text = "The most popular genre";
            this.rdoTheLoai.UseVisualStyleBackColor = true;
            // 
            // rdoTacGiaYeuThich
            // 
            this.rdoTacGiaYeuThich.AutoSize = true;
            this.rdoTacGiaYeuThich.Checked = true;
            this.rdoTacGiaYeuThich.Location = new System.Drawing.Point(83, 49);
            this.rdoTacGiaYeuThich.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTacGiaYeuThich.Name = "rdoTacGiaYeuThich";
            this.rdoTacGiaYeuThich.Size = new System.Drawing.Size(296, 33);
            this.rdoTacGiaYeuThich.TabIndex = 1;
            this.rdoTacGiaYeuThich.TabStop = true;
            this.rdoTacGiaYeuThich.Text = "The most popular author";
            this.rdoTacGiaYeuThich.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show statistic by:";
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Location = new System.Drawing.Point(8, 7);
            this.dgvStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.RowHeadersWidth = 51;
            this.dgvStatistics.Size = new System.Drawing.Size(676, 587);
            this.dgvStatistics.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(1333, 1231);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "button1";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // lbOwedMoney
            // 
            this.lbOwedMoney.AutoSize = true;
            this.lbOwedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOwedMoney.Location = new System.Drawing.Point(4, 557);
            this.lbOwedMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOwedMoney.Name = "lbOwedMoney";
            this.lbOwedMoney.Size = new System.Drawing.Size(135, 25);
            this.lbOwedMoney.TabIndex = 14;
            this.lbOwedMoney.Text = "Owed Money:";
            // 
            // txbOwedMoney
            // 
            this.txbOwedMoney.Location = new System.Drawing.Point(144, 551);
            this.txbOwedMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txbOwedMoney.Name = "txbOwedMoney";
            this.txbOwedMoney.Size = new System.Drawing.Size(432, 34);
            this.txbOwedMoney.TabIndex = 5;
            this.txbOwedMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMemberAddress_KeyPress);
            // 
            // receivePenaltyToolStripMenuItem
            // 
            this.receivePenaltyToolStripMenuItem.Name = "receivePenaltyToolStripMenuItem";
            this.receivePenaltyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.receivePenaltyToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.receivePenaltyToolStripMenuItem.Text = "Receive Penalty";
            this.receivePenaltyToolStripMenuItem.Click += new System.EventHandler(this.receivePenaltyToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(1293, 736);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.sttError.ResumeLayout(false);
            this.sttError.PerformLayout();
            this.tcMainMenu.ResumeLayout(false);
            this.tpMember.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpBook.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tpStatistics.ResumeLayout(false);
            this.tpStatistics.PerformLayout();
            this.pnlTypeOfStatistic.ResumeLayout(false);
            this.pnlTypeOfStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterNewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmBạnĐọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageborrowReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBorrowTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReturnTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSáchTrảTrễToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTìnhHìnhMượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tcMainMenu;
        private System.Windows.Forms.TabPage tpMember;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvMemberInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSearchWithMemberName;
        private System.Windows.Forms.Label lbSearchWithCardnumber;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txbSearchWithMemberName;
        private System.Windows.Forms.TextBox txbSearchWithCardnumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnRegisterNewMember;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpRegistrationerDate;
        private System.Windows.Forms.Label lbRegistrationDate;
        private System.Windows.Forms.Button btnUserInfoDetail;
        private System.Windows.Forms.TextBox txbMemberAddress;
        private System.Windows.Forms.DateTimePicker dtpDayOfBirth;
        private System.Windows.Forms.TextBox txbMemberEmail;
        private System.Windows.Forms.ComboBox cbMemberType;
        private System.Windows.Forms.TextBox txbIdentityNumber;
        private System.Windows.Forms.Label lbMemberType;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txbMemberName;
        private System.Windows.Forms.Label lbIdentityNumber;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbMemberEmail;
        private System.Windows.Forms.Label lbMemberAddress;
        private System.Windows.Forms.TabPage tpBook;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSearchWithAuthor;
        private System.Windows.Forms.TextBox txbSearchWithAuthor;
        private System.Windows.Forms.Label lbSearchWithGenre;
        private System.Windows.Forms.Label lbSearchWithBookName;
        private System.Windows.Forms.Label lbSearchWithBookID;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.TextBox txbSearchWithBookName;
        private System.Windows.Forms.TextBox txbSearchWithBookID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnChangeBookInfo;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBookInfoDetail;
        private System.Windows.Forms.TextBox txbBookPrice;
        private System.Windows.Forms.Label lbBookPrice;
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
        private System.Windows.Forms.TabPage tpStatistics;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Label lbTimeOfStatistic;
        private System.Windows.Forms.DateTimePicker dtmThongKe;
        private System.Windows.Forms.Panel pnlTypeOfStatistic;
        private System.Windows.Forms.RadioButton rdoTheLoai;
        private System.Windows.Forms.RadioButton rdoTacGiaYeuThich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbCmndEX;
        private System.Windows.Forms.Label lbEmailEX;
        private System.Windows.Forms.Label lbTenbandocEX;
        private System.Windows.Forms.Label lbGiaTriEX;
        private System.Windows.Forms.Label lbMasSachEX;
        private System.Windows.Forms.Label lbNamxbEX;
        private System.Windows.Forms.ComboBox cbSearchWithGenre;
        private System.Windows.Forms.StatusStrip sttError;
        private System.Windows.Forms.ToolStripStatusLabel sttErrorLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem borrowedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowedBooksDetailToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbBookState;
        private System.Windows.Forms.Label lbBookState;
        private System.Windows.Forms.TextBox txbOwedMoney;
        private System.Windows.Forms.Label lbOwedMoney;
        private System.Windows.Forms.ToolStripMenuItem receivePenaltyToolStripMenuItem;
    }
}