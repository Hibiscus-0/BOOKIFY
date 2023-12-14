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
    public partial class IssueBook_Form : Form
    {
        public IssueBook_Form()
        {
            InitializeComponent();
            bookList books = new bookList();
            ArrayList bookList = books.getBooks();
            convertArrayListtoDataTable dt = new convertArrayListtoDataTable(bookList);
            string[] columntodisplay = { "Title", "ISBN", "Status" };
            DataTable data = dt.GetDataTable(bookList);
            DataView dv = new DataView(data);
            dv = new DataView(data.DefaultView.ToTable(false, columntodisplay));

            dataGridViewSearchBook.DataSource = dv;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDateBorrowed_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelReturnDateLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanelIssuedBooks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButtonReserve_Click(object sender, EventArgs e)
        {
            var popup = new ReservedPopup_Form();
            popup.ShowDialog();
        }

        private void rjButtonBorrow_Click(object sender, EventArgs e)
        {
            var popup = new BorrowedPopup_Form();
            popup.ShowDialog();
        }
    }
}
