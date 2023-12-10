using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKIFY
{
    public partial class ReturnBook_Form : Form
    {
        public ReturnBook_Form()
        {
            InitializeComponent();

            //sample data for datagridview
            for(int i = 0; i < 100; i++) {
                dataGridViewReturnBook.Rows.Add(new object[] {});
            }
        }

        // rounded buttons
       private void dataGridViewStudentBorrowerList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
         
        }
    }
}
