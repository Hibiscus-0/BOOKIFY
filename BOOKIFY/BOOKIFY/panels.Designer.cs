namespace BOOKIFY
{
    partial class formPanels
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPanels));
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sideBar_FlowLayoutPanel = new BOOKIFY.GradientFlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.sideBarBtn = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.booksBtn = new System.Windows.Forms.Button();
            this.membersPanel = new System.Windows.Forms.Panel();
            this.membersBtn = new System.Windows.Forms.Button();
            this.issueBookPanel = new System.Windows.Forms.Panel();
            this.issueBookBtn = new System.Windows.Forms.Button();
            this.returnBookPanel = new System.Windows.Forms.Panel();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.extraPanel = new System.Windows.Forms.Panel();
            this.logOutPanel = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.sideBar_FlowLayoutPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideBarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            this.booksPanel.SuspendLayout();
            this.membersPanel.SuspendLayout();
            this.issueBookPanel.SuspendLayout();
            this.returnBookPanel.SuspendLayout();
            this.logOutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBar_Tick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // sideBar_FlowLayoutPanel
            // 
            this.sideBar_FlowLayoutPanel.Angle = 90F;
            this.sideBar_FlowLayoutPanel.Controls.Add(this.panelLogo);
            this.sideBar_FlowLayoutPanel.Controls.Add(this.dashboardPanel);
            this.sideBar_FlowLayoutPanel.Controls.Add(this.booksPanel);
            this.sideBar_FlowLayoutPanel.Controls.Add(this.membersPanel);
            this.sideBar_FlowLayoutPanel.Controls.Add(this.issueBookPanel);
            this.sideBar_FlowLayoutPanel.Controls.Add(this.returnBookPanel);
            this.sideBar_FlowLayoutPanel.Controls.Add(this.extraPanel);
            this.sideBar_FlowLayoutPanel.Controls.Add(this.logOutPanel);
            this.sideBar_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar_FlowLayoutPanel.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(53)))), ((int)(((byte)(110)))));
            this.sideBar_FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBar_FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBar_FlowLayoutPanel.MaximumSize = new System.Drawing.Size(274, 1041);
            this.sideBar_FlowLayoutPanel.MinimumSize = new System.Drawing.Size(93, 1041);
            this.sideBar_FlowLayoutPanel.Name = "sideBar_FlowLayoutPanel";
            this.sideBar_FlowLayoutPanel.Size = new System.Drawing.Size(274, 1041);
            this.sideBar_FlowLayoutPanel.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(231)))), ((int)(((byte)(199)))));
            this.sideBar_FlowLayoutPanel.TabIndex = 0;
            this.sideBar_FlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar_FlowLayoutPanel_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.sideBarBtn);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(289, 130);
            this.panelLogo.TabIndex = 1;
            // 
            // sideBarBtn
            // 
            this.sideBarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideBarBtn.Image = global::BOOKIFY.Properties.Resources.bars_solid;
            this.sideBarBtn.Location = new System.Drawing.Point(234, 42);
            this.sideBarBtn.Name = "sideBarBtn";
            this.sideBarBtn.Size = new System.Drawing.Size(37, 31);
            this.sideBarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sideBarBtn.TabIndex = 1;
            this.sideBarBtn.TabStop = false;
            this.sideBarBtn.Click += new System.EventHandler(this.sideBarBtn_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::BOOKIFY.Properties.Resources.Artboard_11__1_3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-77, -25);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(366, 159);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.Controls.Add(this.dashboardBtn);
            this.dashboardPanel.Location = new System.Drawing.Point(3, 139);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(271, 120);
            this.dashboardPanel.TabIndex = 2;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Image = global::BOOKIFY.Properties.Resources.dashboard_icon__1___3_2;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(-9, -14);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(312, 145);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "               Dashboard ";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.Color.Transparent;
            this.booksPanel.Controls.Add(this.booksBtn);
            this.booksPanel.Location = new System.Drawing.Point(3, 265);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(271, 120);
            this.booksPanel.TabIndex = 3;
            // 
            // booksBtn
            // 
            this.booksBtn.BackColor = System.Drawing.Color.Transparent;
            this.booksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksBtn.ForeColor = System.Drawing.Color.White;
            this.booksBtn.Image = global::BOOKIFY.Properties.Resources.book_solid__2_;
            this.booksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksBtn.Location = new System.Drawing.Point(-9, -5);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.booksBtn.Size = new System.Drawing.Size(298, 136);
            this.booksBtn.TabIndex = 2;
            this.booksBtn.Text = "               Books ";
            this.booksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksBtn.UseVisualStyleBackColor = false;
            // 
            // membersPanel
            // 
            this.membersPanel.BackColor = System.Drawing.Color.Transparent;
            this.membersPanel.Controls.Add(this.membersBtn);
            this.membersPanel.Location = new System.Drawing.Point(3, 391);
            this.membersPanel.Name = "membersPanel";
            this.membersPanel.Size = new System.Drawing.Size(271, 120);
            this.membersPanel.TabIndex = 4;
            // 
            // membersBtn
            // 
            this.membersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.membersBtn.BackColor = System.Drawing.Color.Transparent;
            this.membersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membersBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersBtn.ForeColor = System.Drawing.Color.White;
            this.membersBtn.Image = global::BOOKIFY.Properties.Resources.users_solid__2_1;
            this.membersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.membersBtn.Location = new System.Drawing.Point(-9, -8);
            this.membersBtn.Name = "membersBtn";
            this.membersBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.membersBtn.Size = new System.Drawing.Size(298, 135);
            this.membersBtn.TabIndex = 3;
            this.membersBtn.Text = "               Members";
            this.membersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.membersBtn.UseVisualStyleBackColor = false;
            // 
            // issueBookPanel
            // 
            this.issueBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.issueBookPanel.Controls.Add(this.issueBookBtn);
            this.issueBookPanel.Location = new System.Drawing.Point(3, 517);
            this.issueBookPanel.Name = "issueBookPanel";
            this.issueBookPanel.Size = new System.Drawing.Size(271, 120);
            this.issueBookPanel.TabIndex = 4;
            // 
            // issueBookBtn
            // 
            this.issueBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.issueBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.issueBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBookBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBookBtn.ForeColor = System.Drawing.Color.White;
            this.issueBookBtn.Image = global::BOOKIFY.Properties.Resources.share_solid__1_;
            this.issueBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBookBtn.Location = new System.Drawing.Point(-9, -10);
            this.issueBookBtn.Name = "issueBookBtn";
            this.issueBookBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.issueBookBtn.Size = new System.Drawing.Size(295, 139);
            this.issueBookBtn.TabIndex = 5;
            this.issueBookBtn.Text = "              Issue Book ";
            this.issueBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBookBtn.UseVisualStyleBackColor = false;
            // 
            // returnBookPanel
            // 
            this.returnBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.returnBookPanel.Controls.Add(this.returnBookBtn);
            this.returnBookPanel.Location = new System.Drawing.Point(3, 643);
            this.returnBookPanel.Name = "returnBookPanel";
            this.returnBookPanel.Size = new System.Drawing.Size(272, 120);
            this.returnBookPanel.TabIndex = 4;
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.returnBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookBtn.ForeColor = System.Drawing.Color.White;
            this.returnBookBtn.Image = global::BOOKIFY.Properties.Resources.exchange_alt_solid__1_;
            this.returnBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBookBtn.Location = new System.Drawing.Point(-9, -8);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.returnBookBtn.Size = new System.Drawing.Size(295, 143);
            this.returnBookBtn.TabIndex = 6;
            this.returnBookBtn.Text = "              Return Book";
            this.returnBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBookBtn.UseVisualStyleBackColor = false;
            // 
            // extraPanel
            // 
            this.extraPanel.BackColor = System.Drawing.Color.Transparent;
            this.extraPanel.Location = new System.Drawing.Point(3, 769);
            this.extraPanel.Name = "extraPanel";
            this.extraPanel.Size = new System.Drawing.Size(281, 128);
            this.extraPanel.TabIndex = 5;
            // 
            // logOutPanel
            // 
            this.logOutPanel.BackColor = System.Drawing.Color.Transparent;
            this.logOutPanel.Controls.Add(this.logOutBtn);
            this.logOutPanel.Location = new System.Drawing.Point(3, 903);
            this.logOutPanel.Name = "logOutPanel";
            this.logOutPanel.Size = new System.Drawing.Size(289, 101);
            this.logOutPanel.TabIndex = 5;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Image = global::BOOKIFY.Properties.Resources.sign_out_alt_solid__1_;
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.Location = new System.Drawing.Point(-6, -19);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.logOutBtn.Size = new System.Drawing.Size(309, 131);
            this.logOutBtn.TabIndex = 7;
            this.logOutBtn.Text = "              Log Out";
            this.logOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.UseVisualStyleBackColor = false;
            // 
            // formPanels
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.sideBar_FlowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "formPanels";
            this.Text = "Bookify";
            this.Load += new System.EventHandler(this.formPanels_Load);
            this.sideBar_FlowLayoutPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sideBarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            this.booksPanel.ResumeLayout(false);
            this.membersPanel.ResumeLayout(false);
            this.issueBookPanel.ResumeLayout(false);
            this.returnBookPanel.ResumeLayout(false);
            this.logOutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientFlowLayoutPanel sideBar_FlowLayoutPanel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Panel booksPanel;
        private System.Windows.Forms.Panel membersPanel;
        private System.Windows.Forms.Panel issueBookPanel;
        private System.Windows.Forms.Panel returnBookPanel;
        private System.Windows.Forms.Panel extraPanel;
        private System.Windows.Forms.Button membersBtn;
        private System.Windows.Forms.Button issueBookBtn;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.PictureBox sideBarBtn;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel logOutPanel;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}