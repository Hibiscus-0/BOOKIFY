namespace BOOKIFY
{
    partial class dashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDashboardHeader = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panelDashboardNumberBoxes = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDashboardNumberBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuPanelIssuedBooks = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBoxIssuedBooks = new System.Windows.Forms.PictureBox();
            this.labelIssuedBooksNumber = new System.Windows.Forms.Label();
            this.labelIssuedBooks = new System.Windows.Forms.Label();
            this.bunifuPanelAvailableBooks = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBoxAvailableBooks = new System.Windows.Forms.PictureBox();
            this.labelAvailableBooksNumber = new System.Windows.Forms.Label();
            this.labelAvailableBooks = new System.Windows.Forms.Label();
            this.bunifuPanelMembers = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBoxMembers = new System.Windows.Forms.PictureBox();
            this.labelMembers = new System.Windows.Forms.Label();
            this.labelMembersNumbers = new System.Windows.Forms.Label();
            this.bunifuPanelAllBooks = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBoxAllBooks = new System.Windows.Forms.PictureBox();
            this.labelAllBooksNumber = new System.Windows.Forms.Label();
            this.labelAllBooks = new System.Windows.Forms.Label();
            this.tableLayoutPanelLine = new System.Windows.Forms.TableLayoutPanel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.panelOverdueTransactionLabel = new System.Windows.Forms.Panel();
            this.panelOverdueTransaction = new System.Windows.Forms.Panel();
            this.pictureBoxOverdueTransactionIcon = new System.Windows.Forms.PictureBox();
            this.labelOverdueTransaction = new System.Windows.Forms.Label();
            this.panelOverdueTransactionContents = new System.Windows.Forms.Panel();
            this.panelOverdueTransactionDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewOverdueTransactions = new System.Windows.Forms.DataGridView();
            this.panelScrollBar = new System.Windows.Forms.Panel();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysOverdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDashboardHeader.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelDashboardNumberBoxes.SuspendLayout();
            this.tableLayoutPanelDashboardNumberBoxes.SuspendLayout();
            this.bunifuPanelIssuedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIssuedBooks)).BeginInit();
            this.bunifuPanelAvailableBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvailableBooks)).BeginInit();
            this.bunifuPanelMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMembers)).BeginInit();
            this.bunifuPanelAllBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAllBooks)).BeginInit();
            this.tableLayoutPanelLine.SuspendLayout();
            this.panelOverdueTransactionLabel.SuspendLayout();
            this.panelOverdueTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverdueTransactionIcon)).BeginInit();
            this.panelOverdueTransactionContents.SuspendLayout();
            this.panelOverdueTransactionDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverdueTransactions)).BeginInit();
            this.panelScrollBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashboardHeader
            // 
            this.panelDashboardHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelDashboardHeader.Controls.Add(this.panelDashboard);
            this.panelDashboardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboardHeader.ForeColor = System.Drawing.Color.Transparent;
            this.panelDashboardHeader.Location = new System.Drawing.Point(0, 0);
            this.panelDashboardHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.panelDashboardHeader.Name = "panelDashboardHeader";
            this.panelDashboardHeader.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panelDashboardHeader.Size = new System.Drawing.Size(1935, 185);
            this.panelDashboardHeader.TabIndex = 0;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.labelDashboard);
            this.panelDashboard.Location = new System.Drawing.Point(6, 5);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(501, 168);
            this.panelDashboard.TabIndex = 0;
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.labelDashboard.Location = new System.Drawing.Point(-2, 32);
            this.labelDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(467, 99);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "Dashboard";
            // 
            // panelDashboardNumberBoxes
            // 
            this.panelDashboardNumberBoxes.Controls.Add(this.tableLayoutPanelDashboardNumberBoxes);
            this.panelDashboardNumberBoxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboardNumberBoxes.ForeColor = System.Drawing.Color.Black;
            this.panelDashboardNumberBoxes.Location = new System.Drawing.Point(0, 185);
            this.panelDashboardNumberBoxes.Margin = new System.Windows.Forms.Padding(4, 15, 4, 5);
            this.panelDashboardNumberBoxes.Name = "panelDashboardNumberBoxes";
            this.panelDashboardNumberBoxes.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelDashboardNumberBoxes.Size = new System.Drawing.Size(1935, 275);
            this.panelDashboardNumberBoxes.TabIndex = 1;
            // 
            // tableLayoutPanelDashboardNumberBoxes
            // 
            this.tableLayoutPanelDashboardNumberBoxes.ColumnCount = 4;
            this.tableLayoutPanelDashboardNumberBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDashboardNumberBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDashboardNumberBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDashboardNumberBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDashboardNumberBoxes.Controls.Add(this.bunifuPanelIssuedBooks, 3, 0);
            this.tableLayoutPanelDashboardNumberBoxes.Controls.Add(this.bunifuPanelAvailableBooks, 2, 0);
            this.tableLayoutPanelDashboardNumberBoxes.Controls.Add(this.bunifuPanelMembers, 1, 0);
            this.tableLayoutPanelDashboardNumberBoxes.Controls.Add(this.bunifuPanelAllBooks, 0, 0);
            this.tableLayoutPanelDashboardNumberBoxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelDashboardNumberBoxes.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelDashboardNumberBoxes.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanelDashboardNumberBoxes.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDashboardNumberBoxes.Name = "tableLayoutPanelDashboardNumberBoxes";
            this.tableLayoutPanelDashboardNumberBoxes.RowCount = 1;
            this.tableLayoutPanelDashboardNumberBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDashboardNumberBoxes.Size = new System.Drawing.Size(1905, 262);
            this.tableLayoutPanelDashboardNumberBoxes.TabIndex = 0;
            // 
            // bunifuPanelIssuedBooks
            // 
            this.bunifuPanelIssuedBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuPanelIssuedBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelIssuedBooks.BackgroundImage")));
            this.bunifuPanelIssuedBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelIssuedBooks.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanelIssuedBooks.BorderRadius = 20;
            this.bunifuPanelIssuedBooks.BorderThickness = 1;
            this.bunifuPanelIssuedBooks.Controls.Add(this.pictureBoxIssuedBooks);
            this.bunifuPanelIssuedBooks.Controls.Add(this.labelIssuedBooksNumber);
            this.bunifuPanelIssuedBooks.Controls.Add(this.labelIssuedBooks);
            this.bunifuPanelIssuedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanelIssuedBooks.Location = new System.Drawing.Point(1428, 0);
            this.bunifuPanelIssuedBooks.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.bunifuPanelIssuedBooks.Name = "bunifuPanelIssuedBooks";
            this.bunifuPanelIssuedBooks.ShowBorders = true;
            this.bunifuPanelIssuedBooks.Size = new System.Drawing.Size(477, 247);
            this.bunifuPanelIssuedBooks.TabIndex = 3;
            // 
            // pictureBoxIssuedBooks
            // 
            this.pictureBoxIssuedBooks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxIssuedBooks.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIssuedBooks.Image = global::BOOKIFY.Properties.Resources.share_solid__1_;
            this.pictureBoxIssuedBooks.Location = new System.Drawing.Point(34, 117);
            this.pictureBoxIssuedBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxIssuedBooks.Name = "pictureBoxIssuedBooks";
            this.pictureBoxIssuedBooks.Size = new System.Drawing.Size(75, 77);
            this.pictureBoxIssuedBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIssuedBooks.TabIndex = 11;
            this.pictureBoxIssuedBooks.TabStop = false;
            // 
            // labelIssuedBooksNumber
            // 
            this.labelIssuedBooksNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIssuedBooksNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelIssuedBooksNumber.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuedBooksNumber.ForeColor = System.Drawing.Color.White;
            this.labelIssuedBooksNumber.Location = new System.Drawing.Point(207, 91);
            this.labelIssuedBooksNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIssuedBooksNumber.Name = "labelIssuedBooksNumber";
            this.labelIssuedBooksNumber.Size = new System.Drawing.Size(260, 123);
            this.labelIssuedBooksNumber.TabIndex = 10;
            this.labelIssuedBooksNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIssuedBooks
            // 
            this.labelIssuedBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIssuedBooks.BackColor = System.Drawing.Color.Transparent;
            this.labelIssuedBooks.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuedBooks.ForeColor = System.Drawing.Color.White;
            this.labelIssuedBooks.Location = new System.Drawing.Point(109, 20);
            this.labelIssuedBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIssuedBooks.MaximumSize = new System.Drawing.Size(274, 51);
            this.labelIssuedBooks.Name = "labelIssuedBooks";
            this.labelIssuedBooks.Size = new System.Drawing.Size(260, 51);
            this.labelIssuedBooks.TabIndex = 8;
            this.labelIssuedBooks.Text = "Issued Books";
            this.labelIssuedBooks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuPanelAvailableBooks
            // 
            this.bunifuPanelAvailableBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuPanelAvailableBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelAvailableBooks.BackgroundImage")));
            this.bunifuPanelAvailableBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelAvailableBooks.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanelAvailableBooks.BorderRadius = 20;
            this.bunifuPanelAvailableBooks.BorderThickness = 1;
            this.bunifuPanelAvailableBooks.Controls.Add(this.pictureBoxAvailableBooks);
            this.bunifuPanelAvailableBooks.Controls.Add(this.labelAvailableBooksNumber);
            this.bunifuPanelAvailableBooks.Controls.Add(this.labelAvailableBooks);
            this.bunifuPanelAvailableBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanelAvailableBooks.Location = new System.Drawing.Point(952, 0);
            this.bunifuPanelAvailableBooks.Margin = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.bunifuPanelAvailableBooks.Name = "bunifuPanelAvailableBooks";
            this.bunifuPanelAvailableBooks.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.bunifuPanelAvailableBooks.ShowBorders = true;
            this.bunifuPanelAvailableBooks.Size = new System.Drawing.Size(461, 247);
            this.bunifuPanelAvailableBooks.TabIndex = 2;
            // 
            // pictureBoxAvailableBooks
            // 
            this.pictureBoxAvailableBooks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxAvailableBooks.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAvailableBooks.Image = global::BOOKIFY.Properties.Resources.check_circle_solid;
            this.pictureBoxAvailableBooks.Location = new System.Drawing.Point(34, 118);
            this.pictureBoxAvailableBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAvailableBooks.Name = "pictureBoxAvailableBooks";
            this.pictureBoxAvailableBooks.Size = new System.Drawing.Size(75, 77);
            this.pictureBoxAvailableBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvailableBooks.TabIndex = 8;
            this.pictureBoxAvailableBooks.TabStop = false;
            // 
            // labelAvailableBooksNumber
            // 
            this.labelAvailableBooksNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAvailableBooksNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelAvailableBooksNumber.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableBooksNumber.ForeColor = System.Drawing.Color.White;
            this.labelAvailableBooksNumber.Location = new System.Drawing.Point(208, 92);
            this.labelAvailableBooksNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailableBooksNumber.Name = "labelAvailableBooksNumber";
            this.labelAvailableBooksNumber.Size = new System.Drawing.Size(248, 123);
            this.labelAvailableBooksNumber.TabIndex = 7;
            this.labelAvailableBooksNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAvailableBooks
            // 
            this.labelAvailableBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAvailableBooks.BackColor = System.Drawing.Color.Transparent;
            this.labelAvailableBooks.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableBooks.ForeColor = System.Drawing.Color.White;
            this.labelAvailableBooks.Location = new System.Drawing.Point(109, 21);
            this.labelAvailableBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailableBooks.MaximumSize = new System.Drawing.Size(280, 45);
            this.labelAvailableBooks.MinimumSize = new System.Drawing.Size(182, 0);
            this.labelAvailableBooks.Name = "labelAvailableBooks";
            this.labelAvailableBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAvailableBooks.Size = new System.Drawing.Size(248, 45);
            this.labelAvailableBooks.TabIndex = 5;
            this.labelAvailableBooks.Text = "Available Books";
            this.labelAvailableBooks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuPanelMembers
            // 
            this.bunifuPanelMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuPanelMembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelMembers.BackgroundImage")));
            this.bunifuPanelMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelMembers.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanelMembers.BorderRadius = 20;
            this.bunifuPanelMembers.BorderThickness = 1;
            this.bunifuPanelMembers.Controls.Add(this.pictureBoxMembers);
            this.bunifuPanelMembers.Controls.Add(this.labelMembers);
            this.bunifuPanelMembers.Controls.Add(this.labelMembersNumbers);
            this.bunifuPanelMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanelMembers.Location = new System.Drawing.Point(476, 0);
            this.bunifuPanelMembers.Margin = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.bunifuPanelMembers.Name = "bunifuPanelMembers";
            this.bunifuPanelMembers.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.bunifuPanelMembers.ShowBorders = true;
            this.bunifuPanelMembers.Size = new System.Drawing.Size(461, 247);
            this.bunifuPanelMembers.TabIndex = 1;
            // 
            // pictureBoxMembers
            // 
            this.pictureBoxMembers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxMembers.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMembers.Image = global::BOOKIFY.Properties.Resources.users_solid__2_1;
            this.pictureBoxMembers.Location = new System.Drawing.Point(34, 118);
            this.pictureBoxMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxMembers.Name = "pictureBoxMembers";
            this.pictureBoxMembers.Size = new System.Drawing.Size(75, 77);
            this.pictureBoxMembers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMembers.TabIndex = 7;
            this.pictureBoxMembers.TabStop = false;
            // 
            // labelMembers
            // 
            this.labelMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMembers.BackColor = System.Drawing.Color.Transparent;
            this.labelMembers.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembers.ForeColor = System.Drawing.Color.White;
            this.labelMembers.Location = new System.Drawing.Point(131, 15);
            this.labelMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMembers.Name = "labelMembers";
            this.labelMembers.Size = new System.Drawing.Size(200, 51);
            this.labelMembers.TabIndex = 5;
            this.labelMembers.Text = "Members";
            this.labelMembers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMembersNumbers
            // 
            this.labelMembersNumbers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMembersNumbers.BackColor = System.Drawing.Color.Transparent;
            this.labelMembersNumbers.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembersNumbers.ForeColor = System.Drawing.Color.White;
            this.labelMembersNumbers.Location = new System.Drawing.Point(208, 92);
            this.labelMembersNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMembersNumbers.Name = "labelMembersNumbers";
            this.labelMembersNumbers.Size = new System.Drawing.Size(248, 123);
            this.labelMembersNumbers.TabIndex = 5;
            this.labelMembersNumbers.Text = "90";
            this.labelMembersNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuPanelAllBooks
            // 
            this.bunifuPanelAllBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuPanelAllBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelAllBooks.BackgroundImage")));
            this.bunifuPanelAllBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelAllBooks.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanelAllBooks.BorderRadius = 20;
            this.bunifuPanelAllBooks.BorderThickness = 1;
            this.bunifuPanelAllBooks.Controls.Add(this.pictureBoxAllBooks);
            this.bunifuPanelAllBooks.Controls.Add(this.labelAllBooksNumber);
            this.bunifuPanelAllBooks.Controls.Add(this.labelAllBooks);
            this.bunifuPanelAllBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanelAllBooks.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanelAllBooks.Margin = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.bunifuPanelAllBooks.Name = "bunifuPanelAllBooks";
            this.bunifuPanelAllBooks.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.bunifuPanelAllBooks.ShowBorders = true;
            this.bunifuPanelAllBooks.Size = new System.Drawing.Size(461, 247);
            this.bunifuPanelAllBooks.TabIndex = 0;
            // 
            // pictureBoxAllBooks
            // 
            this.pictureBoxAllBooks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxAllBooks.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAllBooks.Image = global::BOOKIFY.Properties.Resources.book_solid__2_;
            this.pictureBoxAllBooks.Location = new System.Drawing.Point(28, 118);
            this.pictureBoxAllBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAllBooks.Name = "pictureBoxAllBooks";
            this.pictureBoxAllBooks.Size = new System.Drawing.Size(75, 77);
            this.pictureBoxAllBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAllBooks.TabIndex = 4;
            this.pictureBoxAllBooks.TabStop = false;
            // 
            // labelAllBooksNumber
            // 
            this.labelAllBooksNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAllBooksNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelAllBooksNumber.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllBooksNumber.ForeColor = System.Drawing.Color.White;
            this.labelAllBooksNumber.Location = new System.Drawing.Point(179, 92);
            this.labelAllBooksNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllBooksNumber.Name = "labelAllBooksNumber";
            this.labelAllBooksNumber.Size = new System.Drawing.Size(280, 123);
            this.labelAllBooksNumber.TabIndex = 3;
            this.labelAllBooksNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAllBooks
            // 
            this.labelAllBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAllBooks.BackColor = System.Drawing.Color.Transparent;
            this.labelAllBooks.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllBooks.ForeColor = System.Drawing.Color.White;
            this.labelAllBooks.Location = new System.Drawing.Point(131, 15);
            this.labelAllBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllBooks.Name = "labelAllBooks";
            this.labelAllBooks.Size = new System.Drawing.Size(200, 51);
            this.labelAllBooks.TabIndex = 1;
            this.labelAllBooks.Text = "All Books";
            this.labelAllBooks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanelLine
            // 
            this.tableLayoutPanelLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanelLine.ColumnCount = 1;
            this.tableLayoutPanelLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLine.Controls.Add(this.panelLine, 0, 0);
            this.tableLayoutPanelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelLine.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLine.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLine.Name = "tableLayoutPanelLine";
            this.tableLayoutPanelLine.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tableLayoutPanelLine.RowCount = 1;
            this.tableLayoutPanelLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLine.Size = new System.Drawing.Size(1935, 49);
            this.tableLayoutPanelLine.TabIndex = 0;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLine.Location = new System.Drawing.Point(19, 20);
            this.panelLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(1897, 9);
            this.panelLine.TabIndex = 0;
            // 
            // panelOverdueTransactionLabel
            // 
            this.panelOverdueTransactionLabel.BackColor = System.Drawing.Color.Transparent;
            this.panelOverdueTransactionLabel.Controls.Add(this.panelOverdueTransaction);
            this.panelOverdueTransactionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOverdueTransactionLabel.Location = new System.Drawing.Point(0, 49);
            this.panelOverdueTransactionLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOverdueTransactionLabel.Name = "panelOverdueTransactionLabel";
            this.panelOverdueTransactionLabel.Size = new System.Drawing.Size(1935, 72);
            this.panelOverdueTransactionLabel.TabIndex = 1;
            // 
            // panelOverdueTransaction
            // 
            this.panelOverdueTransaction.Controls.Add(this.pictureBoxOverdueTransactionIcon);
            this.panelOverdueTransaction.Controls.Add(this.labelOverdueTransaction);
            this.panelOverdueTransaction.Location = new System.Drawing.Point(2, 5);
            this.panelOverdueTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOverdueTransaction.Name = "panelOverdueTransaction";
            this.panelOverdueTransaction.Size = new System.Drawing.Size(1044, 68);
            this.panelOverdueTransaction.TabIndex = 0;
            // 
            // pictureBoxOverdueTransactionIcon
            // 
            this.pictureBoxOverdueTransactionIcon.Image = global::BOOKIFY.Properties.Resources.user_clock_solid;
            this.pictureBoxOverdueTransactionIcon.Location = new System.Drawing.Point(495, 14);
            this.pictureBoxOverdueTransactionIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxOverdueTransactionIcon.Name = "pictureBoxOverdueTransactionIcon";
            this.pictureBoxOverdueTransactionIcon.Size = new System.Drawing.Size(48, 40);
            this.pictureBoxOverdueTransactionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOverdueTransactionIcon.TabIndex = 1;
            this.pictureBoxOverdueTransactionIcon.TabStop = false;
            // 
            // labelOverdueTransaction
            // 
            this.labelOverdueTransaction.AutoSize = true;
            this.labelOverdueTransaction.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverdueTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.labelOverdueTransaction.Location = new System.Drawing.Point(3, 0);
            this.labelOverdueTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOverdueTransaction.Name = "labelOverdueTransaction";
            this.labelOverdueTransaction.Size = new System.Drawing.Size(491, 56);
            this.labelOverdueTransaction.TabIndex = 0;
            this.labelOverdueTransaction.Text = "Overdue Transactions";
            // 
            // panelOverdueTransactionContents
            // 
            this.panelOverdueTransactionContents.Controls.Add(this.panelOverdueTransactionDataGridView);
            this.panelOverdueTransactionContents.Controls.Add(this.panelOverdueTransactionLabel);
            this.panelOverdueTransactionContents.Controls.Add(this.tableLayoutPanelLine);
            this.panelOverdueTransactionContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOverdueTransactionContents.Location = new System.Drawing.Point(0, 460);
            this.panelOverdueTransactionContents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOverdueTransactionContents.Name = "panelOverdueTransactionContents";
            this.panelOverdueTransactionContents.Size = new System.Drawing.Size(1935, 646);
            this.panelOverdueTransactionContents.TabIndex = 2;
            // 
            // panelOverdueTransactionDataGridView
            // 
            this.panelOverdueTransactionDataGridView.BackColor = System.Drawing.Color.Transparent;
            this.panelOverdueTransactionDataGridView.Controls.Add(this.dataGridViewOverdueTransactions);
            this.panelOverdueTransactionDataGridView.Controls.Add(this.panelScrollBar);
            this.panelOverdueTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOverdueTransactionDataGridView.Location = new System.Drawing.Point(0, 121);
            this.panelOverdueTransactionDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.panelOverdueTransactionDataGridView.Name = "panelOverdueTransactionDataGridView";
            this.panelOverdueTransactionDataGridView.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelOverdueTransactionDataGridView.Size = new System.Drawing.Size(1935, 525);
            this.panelOverdueTransactionDataGridView.TabIndex = 2;
            // 
            // dataGridViewOverdueTransactions
            // 
            this.dataGridViewOverdueTransactions.AllowUserToDeleteRows = false;
            this.dataGridViewOverdueTransactions.AllowUserToOrderColumns = true;
            this.dataGridViewOverdueTransactions.AllowUserToResizeColumns = false;
            this.dataGridViewOverdueTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(111)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(159)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOverdueTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOverdueTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOverdueTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.dataGridViewOverdueTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOverdueTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOverdueTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOverdueTransactions.ColumnHeadersHeight = 60;
            this.dataGridViewOverdueTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOverdueTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.IssuedBookTitle,
            this.Member,
            this.DaysOverdue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOverdueTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOverdueTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOverdueTransactions.EnableHeadersVisualStyles = false;
            this.dataGridViewOverdueTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.dataGridViewOverdueTransactions.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewOverdueTransactions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOverdueTransactions.Name = "dataGridViewOverdueTransactions";
            this.dataGridViewOverdueTransactions.ReadOnly = true;
            this.dataGridViewOverdueTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(159)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOverdueTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOverdueTransactions.RowHeadersVisible = false;
            this.dataGridViewOverdueTransactions.RowHeadersWidth = 60;
            this.dataGridViewOverdueTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(159)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.dataGridViewOverdueTransactions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOverdueTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOverdueTransactions.Size = new System.Drawing.Size(1835, 495);
            this.dataGridViewOverdueTransactions.TabIndex = 2;
            // 
            // panelScrollBar
            // 
            this.panelScrollBar.Controls.Add(this.bunifuVScrollBar1);
            this.panelScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelScrollBar.Location = new System.Drawing.Point(1850, 15);
            this.panelScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelScrollBar.Name = "panelScrollBar";
            this.panelScrollBar.Padding = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.panelScrollBar.Size = new System.Drawing.Size(70, 495);
            this.panelScrollBar.TabIndex = 0;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = null;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuVScrollBar1.BorderRadius = 0;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(15, 15);
            this.bunifuVScrollBar1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(17, 399);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 1;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.bunifuVScrollBar1.ThumbLength = 39;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "Transaction ID";
            this.TransactionID.MinimumWidth = 8;
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            // 
            // IssuedBookTitle
            // 
            this.IssuedBookTitle.HeaderText = "Issued Book Title";
            this.IssuedBookTitle.MinimumWidth = 8;
            this.IssuedBookTitle.Name = "IssuedBookTitle";
            this.IssuedBookTitle.ReadOnly = true;
            // 
            // Member
            // 
            this.Member.HeaderText = "Member";
            this.Member.MinimumWidth = 8;
            this.Member.Name = "Member";
            this.Member.ReadOnly = true;
            // 
            // DaysOverdue
            // 
            this.DaysOverdue.HeaderText = "Days Overdue";
            this.DaysOverdue.MinimumWidth = 8;
            this.DaysOverdue.Name = "DaysOverdue";
            this.DaysOverdue.ReadOnly = true;
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1935, 1106);
            this.ControlBox = false;
            this.Controls.Add(this.panelOverdueTransactionContents);
            this.Controls.Add(this.panelDashboardNumberBoxes);
            this.Controls.Add(this.panelDashboardHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(280, 0);
            this.Name = "dashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardForm";
            this.panelDashboardHeader.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelDashboardNumberBoxes.ResumeLayout(false);
            this.tableLayoutPanelDashboardNumberBoxes.ResumeLayout(false);
            this.bunifuPanelIssuedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIssuedBooks)).EndInit();
            this.bunifuPanelAvailableBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvailableBooks)).EndInit();
            this.bunifuPanelMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMembers)).EndInit();
            this.bunifuPanelAllBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAllBooks)).EndInit();
            this.tableLayoutPanelLine.ResumeLayout(false);
            this.panelOverdueTransactionLabel.ResumeLayout(false);
            this.panelOverdueTransaction.ResumeLayout(false);
            this.panelOverdueTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverdueTransactionIcon)).EndInit();
            this.panelOverdueTransactionContents.ResumeLayout(false);
            this.panelOverdueTransactionDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverdueTransactions)).EndInit();
            this.panelScrollBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboardHeader;
        private System.Windows.Forms.Panel panelDashboardNumberBoxes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDashboardNumberBoxes;
        private System.Windows.Forms.Label labelMembersNumbers;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelIssuedBooks;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelAvailableBooks;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelMembers;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelAllBooks;
        private System.Windows.Forms.PictureBox pictureBoxIssuedBooks;
        private System.Windows.Forms.Label labelIssuedBooksNumber;
        private System.Windows.Forms.Label labelIssuedBooks;
        private System.Windows.Forms.PictureBox pictureBoxAvailableBooks;
        private System.Windows.Forms.Label labelAvailableBooksNumber;
        private System.Windows.Forms.Label labelAvailableBooks;
        private System.Windows.Forms.PictureBox pictureBoxMembers;
        private System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.PictureBox pictureBoxAllBooks;
        private System.Windows.Forms.Label labelAllBooks;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label labelAllBooksNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLine;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panelOverdueTransactionLabel;
        private System.Windows.Forms.Panel panelOverdueTransaction;
        private System.Windows.Forms.Label labelOverdueTransaction;
        private System.Windows.Forms.Panel panelOverdueTransactionContents;
        private System.Windows.Forms.PictureBox pictureBoxOverdueTransactionIcon;
        private System.Windows.Forms.Panel panelOverdueTransactionDataGridView;
        private System.Windows.Forms.Panel panelScrollBar;
        private System.Windows.Forms.DataGridView dataGridViewOverdueTransactions;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysOverdue;
    }
}