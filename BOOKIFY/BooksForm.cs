﻿using System;
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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void rjButtonBorrow_Click(object sender, EventArgs e)
        {
            var popup = new AddBookPopup_Form();
            popup.ShowDialog();
        }
    }
}
