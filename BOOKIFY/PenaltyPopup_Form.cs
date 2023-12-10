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
    public partial class PenaltyPopup_Form : Form
    {
        public PenaltyPopup_Form()
        {
            InitializeComponent();
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            //Code to trigger when the "Yes"-button is pressed.
            LoginErrorPopup_Form settings = new LoginErrorPopup_Form();
            this.Close();
            settings.Close();
        }
    }
    
}
