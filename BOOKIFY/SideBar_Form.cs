using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKIFY
{
    public partial class SideBar_Form : Form
    {
        // fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        
        // constructors
        public SideBar_Form() 
        {
            InitializeComponent();
            CollapseMenu();
            LoadDashboardForm();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 76);
            gradientPanelSideBar.Controls.Add(leftBorderBtn);
        }

        // structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(20, 73, 72);
        }

        // methods
        private void GoFullscreen(bool fullscreen) // form will appear on top of the taskbar
        {
            if (fullscreen){
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else{
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        private void iconButtonSideBarIcon_Click_1(object sender, EventArgs e) // side bar button
        {
            CollapseMenu(); // will always show the side bar in a collapsed way
        }

        // methods for side bar 
        private void CollapseMenu() // to implement collapsing sidebar  
        {
            //Collapse menu
            if (this.gradientPanelSideBar.Width > 200)
            {
                gradientPanelSideBar.Width = 100;
                pictureBoxLogo.Visible = false;
                iconButtonSideBarIcon.Dock = DockStyle.Top;
                foreach (Button menuButton in gradientPanelSideBar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            /*Expand menu */
            else
            {
                gradientPanelSideBar.Width = 275;
                pictureBoxLogo.Visible = true;
                iconButtonSideBarIcon.Dock = DockStyle.None;
                foreach (Button menuButton in gradientPanelSideBar.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        // hover effects for side bar buttons
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(94, 198, 196);
                currentBtn.ForeColor = color;
                /*currentBtn.TextAlign = ContentAlignment.MiddleCenter;*/
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                /*currentBtn.ImageAlign = ContentAlignment.MiddleLeft;*/

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
/*                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;*/
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.White;
                /*currentBtn.TextAlign = ContentAlignment.MiddleCenter;*/
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                /*currentBtn.ImageAlign = ContentAlignment.MiddleLeft;*/
            }
        }
       
        public void sideBarPanel_Load(object sender, EventArgs e) // to access the main panel in different forms
        {
            SharedClass.MainFormInstance = this;
        }

        public void LoadForm(Form form) // to load different forms 
        {
            if (mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(form);
                this.mainPanel.Tag = form;
                form.Show();  
        }
        private void LoadDashboardForm() // to always load dashboard form first in the mainPanel 
        {
            LoadForm(new Dashboard_Form());
        }

        private void iconButtonDashboard_Click(object sender, EventArgs e) // dashboard button
        {
            LoadForm(new Dashboard_Form());
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButtonBooks_Click(object sender, EventArgs e) // Book list button
        {
            LoadForm(new BooksForm());
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButtonMembers_Click(object sender, EventArgs e) // Borrowers button
        {
            LoadForm(new TeachersBorrowerList_Form());
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButtonIssueBook_Click(object sender, EventArgs e) // Issue book button
        {
            LoadForm(new IssueBook_Form());
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButtonReturnBook_Click(object sender, EventArgs e) // Return book button
        {
            LoadForm(new ReturnBook_Form());
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButtonLogOut_Click(object sender, EventArgs e) // Log out button
        {
            this.Hide();
            var login = new LogInForm();
            login.Show();
        }
    }
}
