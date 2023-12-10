namespace BOOKIFY
{
    partial class LoginErrorPopup_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginErrorPopup_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginErrorbtn = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuccessBorrowed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 160);
            this.panel1.TabIndex = 46;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelHeader.Controls.Add(this.iconButton1);
            this.panelHeader.Controls.Add(this.iconButtonClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(285, 35);
            this.panelHeader.TabIndex = 62;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(250, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(23, 23);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 30;
            this.iconButtonClose.Location = new System.Drawing.Point(470, 9);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(23, 23);
            this.iconButtonClose.TabIndex = 0;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginErrorbtn
            // 
            this.loginErrorbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.loginErrorbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.loginErrorbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.loginErrorbtn.BorderRadius = 10;
            this.loginErrorbtn.BorderSize = 0;
            this.loginErrorbtn.FlatAppearance.BorderSize = 0;
            this.loginErrorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginErrorbtn.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.loginErrorbtn.ForeColor = System.Drawing.Color.White;
            this.loginErrorbtn.Location = new System.Drawing.Point(59, 237);
            this.loginErrorbtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginErrorbtn.Name = "loginErrorbtn";
            this.loginErrorbtn.Size = new System.Drawing.Size(151, 40);
            this.loginErrorbtn.TabIndex = 49;
            this.loginErrorbtn.Text = "Try Again";
            this.loginErrorbtn.TextColor = System.Drawing.Color.White;
            this.loginErrorbtn.UseVisualStyleBackColor = false;
            this.loginErrorbtn.Click += new System.EventHandler(this.loginErrorbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Invalid Username or Password";
            // 
            // lblSuccessBorrowed
            // 
            this.lblSuccessBorrowed.AutoSize = true;
            this.lblSuccessBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessBorrowed.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblSuccessBorrowed.Location = new System.Drawing.Point(74, 162);
            this.lblSuccessBorrowed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccessBorrowed.Name = "lblSuccessBorrowed";
            this.lblSuccessBorrowed.Size = new System.Drawing.Size(126, 37);
            this.lblSuccessBorrowed.TabIndex = 47;
            this.lblSuccessBorrowed.Text = "ERROR!";
            // 
            // LoginErrorPopup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginErrorbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSuccessBorrowed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginErrorPopup_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginError_Form";
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJButton loginErrorbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuccessBorrowed;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}