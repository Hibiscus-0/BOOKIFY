using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKIFY
{
    public partial class formPanels : Form
    {
        bool sideBarExpand;

        public formPanels()
        {
            InitializeComponent();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sideBar_FlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void bookifyLabel_Click(object sender, EventArgs e)
        {

        }


    // will appear on top of the taskbar
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }

        //sidebar expand
        /*        private void sideBar_Tick(object sender, EventArgs e)
                {
                    if (sideBarExpand)
                    {
                        sideBar_FlowLayoutPanel.width -= 10;
                        if (sideBar_FlowLayoutPanel.width == sideBar_FlowLayoutPanel.MinimumSize.Width)
                        {
                            sideBarExpand = false;
                            sideBarTimer.Stop();
                        }
                    }
                    else
                    {
                        sideBar_FlowLayoutPanel.width += 10;
                        if (sideBar_FlowLayoutPanel.width == sideBar_FlowLayoutPanel.MaximumSize.Width)
                        {
                            sideBarExpand = true;
                            sideBarTimer.Stop();
                        }
                    }
                }

                private void sideBarBtn_Click(object sender, EventArgs e)
                {
                    sideBarTimer.Start();
                }*/

        private void sideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar_FlowLayoutPanel.Width -= 10;
                if (sideBar_FlowLayoutPanel.Width <= 93)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();

  /*                  dashboardPanel.Width = sideBar_FlowLayoutPanel.Width;
                    booksPanel.Width = sideBar_FlowLayoutPanel.Width;
                    membersPanel.Width = sideBar_FlowLayoutPanel.Width;
                    issueBookPanel.Width = sideBar_FlowLayoutPanel.Width;
                    returnBookPanel.Width = sideBar_FlowLayoutPanel.Width;
                    logOutPanel.Width = sideBar_FlowLayoutPanel.Width;
                    extraPanel.Width = sideBar_FlowLayoutPanel.Width;
*//*                    panelLogo.Width = sideBar_FlowLayoutPanel.Width;*/
                }
            }
            else
            {
                sideBar_FlowLayoutPanel.Width += 10;
                if (sideBar_FlowLayoutPanel.Width >= 274)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();

/*                    dashboardPanel.Width = sideBar_FlowLayoutPanel.Width;
                    booksPanel.Width = sideBar_FlowLayoutPanel.Width;
                    membersPanel.Width = sideBar_FlowLayoutPanel.Width;
                    issueBookPanel.Width = sideBar_FlowLayoutPanel.Width;
                    returnBookPanel.Width = sideBar_FlowLayoutPanel.Width;
                    logOutPanel.Width = sideBar_FlowLayoutPanel.Width;
                    extraPanel.Width = sideBar_FlowLayoutPanel.Width;
*//*                    panelLogo.Width = sideBar_FlowLayoutPanel.Width;*/

                }
            }
        }

        private void sideBarBtn_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formPanels_Load(object sender, EventArgs e)
        {

        }
    }
}

