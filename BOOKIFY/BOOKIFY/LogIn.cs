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

        private void bunifuTextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLogInBtn_Click(object sender, EventArgs e)
        {
            String username = bunifuTextBoxUsername.Text;
            String password = bunifuTextBoxPassword.Text;
            if(username == "admin" && password == "admin")
            {
                var home = new sideBarPanel();
                home.Show();
                this.Hide();
            }
        }

        private void bunifuTextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
