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
    public partial class ReturnedPopup_Form : Form
    {
        public ReturnedPopup_Form()
        {
            InitializeComponent();
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            //Code to trigger when the "Yes"-button is pressed.
            ReturnedPopup_Form settings = new ReturnedPopup_Form();
            this.Close();
            settings.Close();
        }

        private void lblreturnedBTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
