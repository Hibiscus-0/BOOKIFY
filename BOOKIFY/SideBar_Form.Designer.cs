namespace BOOKIFY
{
    partial class SideBar_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBar_Form));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gradientPanelSideBar = new BOOKIFY.GradientPanel();
            this.iconButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.iconButtonReturnBook = new FontAwesome.Sharp.IconButton();
            this.iconButtonIssueBook = new FontAwesome.Sharp.IconButton();
            this.iconButtonMembers = new FontAwesome.Sharp.IconButton();
            this.iconButtonBooks = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogoHam = new System.Windows.Forms.Panel();
            this.iconButtonSideBarIcon = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.gradientPanelSideBar.SuspendLayout();
            this.panelLogoHam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(275, 0);
            this.mainPanel.MinimumSize = new System.Drawing.Size(187, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(733, 861);
            this.mainPanel.TabIndex = 6;
            // 
            // gradientPanelSideBar
            // 
            this.gradientPanelSideBar.Angle = 90F;
            this.gradientPanelSideBar.Controls.Add(this.iconButtonLogOut);
            this.gradientPanelSideBar.Controls.Add(this.iconButtonReturnBook);
            this.gradientPanelSideBar.Controls.Add(this.iconButtonIssueBook);
            this.gradientPanelSideBar.Controls.Add(this.iconButtonMembers);
            this.gradientPanelSideBar.Controls.Add(this.iconButtonBooks);
            this.gradientPanelSideBar.Controls.Add(this.iconButtonDashboard);
            this.gradientPanelSideBar.Controls.Add(this.panelLogoHam);
            this.gradientPanelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanelSideBar.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(53)))), ((int)(((byte)(110)))));
            this.gradientPanelSideBar.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelSideBar.Name = "gradientPanelSideBar";
            this.gradientPanelSideBar.Size = new System.Drawing.Size(275, 861);
            this.gradientPanelSideBar.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(231)))), ((int)(((byte)(199)))));
            this.gradientPanelSideBar.TabIndex = 5;
            // 
            // iconButtonLogOut
            // 
            this.iconButtonLogOut.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonLogOut.FlatAppearance.BorderSize = 0;
            this.iconButtonLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.iconButtonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(178)))), ((int)(((byte)(176)))));
            this.iconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogOut.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogOut.ForeColor = System.Drawing.Color.White;
            this.iconButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iconButtonLogOut.IconColor = System.Drawing.Color.White;
            this.iconButtonLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogOut.IconSize = 50;
            this.iconButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogOut.Location = new System.Drawing.Point(0, 785);
            this.iconButtonLogOut.Name = "iconButtonLogOut";
            this.iconButtonLogOut.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.iconButtonLogOut.Size = new System.Drawing.Size(275, 76);
            this.iconButtonLogOut.TabIndex = 7;
            this.iconButtonLogOut.Tag = "Log Out";
            this.iconButtonLogOut.Text = "Log Out";
            this.iconButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogOut.UseVisualStyleBackColor = false;
            this.iconButtonLogOut.Click += new System.EventHandler(this.iconButtonLogOut_Click);
            // 
            // iconButtonReturnBook
            // 
            this.iconButtonReturnBook.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonReturnBook.FlatAppearance.BorderSize = 0;
            this.iconButtonReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.iconButtonReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(178)))), ((int)(((byte)(176)))));
            this.iconButtonReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReturnBook.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReturnBook.ForeColor = System.Drawing.Color.White;
            this.iconButtonReturnBook.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.iconButtonReturnBook.IconColor = System.Drawing.Color.White;
            this.iconButtonReturnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReturnBook.IconSize = 50;
            this.iconButtonReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReturnBook.Location = new System.Drawing.Point(0, 452);
            this.iconButtonReturnBook.Name = "iconButtonReturnBook";
            this.iconButtonReturnBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonReturnBook.Size = new System.Drawing.Size(275, 76);
            this.iconButtonReturnBook.TabIndex = 6;
            this.iconButtonReturnBook.Tag = "Return Book";
            this.iconButtonReturnBook.Text = "Return Book";
            this.iconButtonReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReturnBook.UseVisualStyleBackColor = false;
            this.iconButtonReturnBook.Click += new System.EventHandler(this.iconButtonReturnBook_Click);
            // 
            // iconButtonIssueBook
            // 
            this.iconButtonIssueBook.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonIssueBook.FlatAppearance.BorderSize = 0;
            this.iconButtonIssueBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.iconButtonIssueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(178)))), ((int)(((byte)(176)))));
            this.iconButtonIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonIssueBook.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonIssueBook.ForeColor = System.Drawing.Color.White;
            this.iconButtonIssueBook.IconChar = FontAwesome.Sharp.IconChar.MailForward;
            this.iconButtonIssueBook.IconColor = System.Drawing.Color.White;
            this.iconButtonIssueBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonIssueBook.IconSize = 50;
            this.iconButtonIssueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonIssueBook.Location = new System.Drawing.Point(0, 376);
            this.iconButtonIssueBook.Name = "iconButtonIssueBook";
            this.iconButtonIssueBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonIssueBook.Size = new System.Drawing.Size(275, 76);
            this.iconButtonIssueBook.TabIndex = 5;
            this.iconButtonIssueBook.Tag = "Issue Book";
            this.iconButtonIssueBook.Text = "Issue Book";
            this.iconButtonIssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonIssueBook.UseVisualStyleBackColor = false;
            this.iconButtonIssueBook.Click += new System.EventHandler(this.iconButtonIssueBook_Click);
            // 
            // iconButtonMembers
            // 
            this.iconButtonMembers.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMembers.FlatAppearance.BorderSize = 0;
            this.iconButtonMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.iconButtonMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(178)))), ((int)(((byte)(176)))));
            this.iconButtonMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMembers.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMembers.ForeColor = System.Drawing.Color.White;
            this.iconButtonMembers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonMembers.IconColor = System.Drawing.Color.White;
            this.iconButtonMembers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMembers.IconSize = 50;
            this.iconButtonMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMembers.Location = new System.Drawing.Point(0, 300);
            this.iconButtonMembers.Name = "iconButtonMembers";
            this.iconButtonMembers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonMembers.Size = new System.Drawing.Size(275, 76);
            this.iconButtonMembers.TabIndex = 4;
            this.iconButtonMembers.Tag = "Borrowers";
            this.iconButtonMembers.Text = "Borrowers";
            this.iconButtonMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMembers.UseVisualStyleBackColor = false;
            this.iconButtonMembers.Click += new System.EventHandler(this.iconButtonMembers_Click);
            // 
            // iconButtonBooks
            // 
            this.iconButtonBooks.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonBooks.FlatAppearance.BorderSize = 0;
            this.iconButtonBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.iconButtonBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(178)))), ((int)(((byte)(176)))));
            this.iconButtonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBooks.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBooks.ForeColor = System.Drawing.Color.White;
            this.iconButtonBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButtonBooks.IconColor = System.Drawing.Color.White;
            this.iconButtonBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBooks.IconSize = 50;
            this.iconButtonBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBooks.Location = new System.Drawing.Point(0, 224);
            this.iconButtonBooks.Name = "iconButtonBooks";
            this.iconButtonBooks.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonBooks.Size = new System.Drawing.Size(275, 76);
            this.iconButtonBooks.TabIndex = 3;
            this.iconButtonBooks.Tag = "Books";
            this.iconButtonBooks.Text = "Books";
            this.iconButtonBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBooks.UseVisualStyleBackColor = false;
            this.iconButtonBooks.Click += new System.EventHandler(this.iconButtonBooks_Click);
            // 
            // iconButtonDashboard
            // 
            this.iconButtonDashboard.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboard.FlatAppearance.BorderSize = 0;
            this.iconButtonDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.iconButtonDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(178)))), ((int)(((byte)(176)))));
            this.iconButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashboard.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDashboard.ForeColor = System.Drawing.Color.White;
            this.iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.iconButtonDashboard.IconColor = System.Drawing.Color.White;
            this.iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDashboard.IconSize = 50;
            this.iconButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 148);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButtonDashboard.Size = new System.Drawing.Size(275, 76);
            this.iconButtonDashboard.TabIndex = 2;
            this.iconButtonDashboard.Tag = "Dashboard";
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashboard.UseVisualStyleBackColor = false;
            this.iconButtonDashboard.Click += new System.EventHandler(this.iconButtonDashboard_Click);
            // 
            // panelLogoHam
            // 
            this.panelLogoHam.BackColor = System.Drawing.Color.Transparent;
            this.panelLogoHam.Controls.Add(this.iconButtonSideBarIcon);
            this.panelLogoHam.Controls.Add(this.pictureBoxLogo);
            this.panelLogoHam.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoHam.ForeColor = System.Drawing.Color.Transparent;
            this.panelLogoHam.Location = new System.Drawing.Point(0, 0);
            this.panelLogoHam.Name = "panelLogoHam";
            this.panelLogoHam.Size = new System.Drawing.Size(275, 148);
            this.panelLogoHam.TabIndex = 0;
            // 
            // iconButtonSideBarIcon
            // 
            this.iconButtonSideBarIcon.FlatAppearance.BorderSize = 0;
            this.iconButtonSideBarIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            this.iconButtonSideBarIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(178)))), ((int)(((byte)(176)))));
            this.iconButtonSideBarIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSideBarIcon.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconButtonSideBarIcon.IconColor = System.Drawing.Color.White;
            this.iconButtonSideBarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSideBarIcon.IconSize = 40;
            this.iconButtonSideBarIcon.Location = new System.Drawing.Point(215, 1);
            this.iconButtonSideBarIcon.Name = "iconButtonSideBarIcon";
            this.iconButtonSideBarIcon.Size = new System.Drawing.Size(60, 147);
            this.iconButtonSideBarIcon.TabIndex = 4;
            this.iconButtonSideBarIcon.UseVisualStyleBackColor = false;
            this.iconButtonSideBarIcon.Click += new System.EventHandler(this.iconButtonSideBarIcon_Click_1);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BOOKIFY.Properties.Resources.Artboard_11__1_4;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(197, 75);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // SideBar_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 861);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.gradientPanelSideBar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1024, 900);
            this.Name = "SideBar_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Bookify";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sideBarPanel_Load);
            this.gradientPanelSideBar.ResumeLayout(false);
            this.panelLogoHam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton iconButtonReturnBook;
        private FontAwesome.Sharp.IconButton iconButtonIssueBook;
        private FontAwesome.Sharp.IconButton iconButtonMembers;
        private FontAwesome.Sharp.IconButton iconButtonBooks;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private System.Windows.Forms.Panel panelLogoHam;
        private GradientPanel gradientPanelSideBar;
        private FontAwesome.Sharp.IconButton iconButtonLogOut;
        private FontAwesome.Sharp.IconButton iconButtonSideBarIcon;
        public System.Windows.Forms.Panel mainPanel;
    }
}