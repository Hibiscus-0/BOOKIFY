namespace login_bookify
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUserIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.txtboxPassword = new login_bookify.Custom.customTextbox();
            this.txtboxUsername = new login_bookify.Custom.customTextbox();
            this.roundedBtnLogIn = new login_bookify.roundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(74, -26);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(392, 213);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(154, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bookify: Where Books Find Order.";
            // 
            // pictureBoxUserIcon
            // 
            this.pictureBoxUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserIcon.Image")));
            this.pictureBoxUserIcon.Location = new System.Drawing.Point(94, 153);
            this.pictureBoxUserIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUserIcon.Name = "pictureBoxUserIcon";
            this.pictureBoxUserIcon.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserIcon.TabIndex = 2;
            this.pictureBoxUserIcon.TabStop = false;
            this.pictureBoxUserIcon.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(94, 191);
            this.pictureBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 3;
            this.pictureBoxPassword.TabStop = false;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtboxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.txtboxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtboxPassword.BorderRadius = 5;
            this.txtboxPassword.BorderSize = 2;
            this.txtboxPassword.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(135, 191);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxPassword.Multiline = true;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtboxPassword.PasswordChar = false;
            this.txtboxPassword.Size = new System.Drawing.Size(277, 28);
            this.txtboxPassword.TabIndex = 5;
            this.txtboxPassword.Texts = "";
            this.txtboxPassword.UnderlinedStyle = false;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtboxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtboxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.txtboxUsername.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txtboxUsername.BorderRadius = 5;
            this.txtboxUsername.BorderSize = 2;
            this.txtboxUsername.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.Location = new System.Drawing.Point(135, 153);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxUsername.Multiline = true;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtboxUsername.PasswordChar = false;
            this.txtboxUsername.Size = new System.Drawing.Size(277, 28);
            this.txtboxUsername.TabIndex = 4;
            this.txtboxUsername.Texts = "";
            this.txtboxUsername.UnderlinedStyle = false;
            // 
            // roundedBtnLogIn
            // 
            this.roundedBtnLogIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.roundedBtnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.roundedBtnLogIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.roundedBtnLogIn.BorderRadius = 20;
            this.roundedBtnLogIn.BorderThickness = 1F;
            this.roundedBtnLogIn.FlatAppearance.BorderSize = 0;
            this.roundedBtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedBtnLogIn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedBtnLogIn.ForeColor = System.Drawing.Color.White;
            this.roundedBtnLogIn.Location = new System.Drawing.Point(189, 236);
            this.roundedBtnLogIn.Name = "roundedBtnLogIn";
            this.roundedBtnLogIn.Padding = new System.Windows.Forms.Padding(10);
            this.roundedBtnLogIn.Size = new System.Drawing.Size(161, 45);
            this.roundedBtnLogIn.TabIndex = 7;
            this.roundedBtnLogIn.Text = "Log in";
            this.roundedBtnLogIn.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 320);
            this.Controls.Add(this.roundedBtnLogIn);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.pictureBoxUserIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookify";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxUserIcon;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private Custom.customTextbox txtboxUsername;
        private Custom.customTextbox txtboxPassword;
        private roundedButton roundedBtnLogIn;
    }
}

