using System;
using System.Collections;
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
    public partial class AddBookPopup_Form : Form
    {
        public AddBookPopup_Form()
        {
            InitializeComponent();
            bookCategories bookCategories = new bookCategories();

            ArrayList categories = bookCategories.getBookCategories();

            customComboBoxCategory.DataSource = categories;
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            //Code to trigger when the "Yes"-button is pressed.
            AddBookPopup_Form settings = new AddBookPopup_Form();
            this.Hide();
            settings.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {

        }

        private void customComboBoxCategory_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
