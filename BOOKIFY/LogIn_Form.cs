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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        //Logic for authentication of login form
        private void rjButtonLogIn_Click(object sender, EventArgs e)
        {
            string username = bunifuTextBoxUsername.Text;
            string password = bunifuTextBoxPassword.Text;

            if(username == "admin" && password == "admin")
            {
                var sidePanel = new SideBar_Form();
                sidePanel.Show();
                this.Hide();
            }
            else
            {
                var error = new LoginErrorPopup_Form();
                error.ShowDialog();
            }
        }
    }
}
