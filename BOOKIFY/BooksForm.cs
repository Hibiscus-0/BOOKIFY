using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BOOKIFY
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            bookList books = new bookList();
            ArrayList bookList = books.getBooks();
            convertArrayListtoDataTable dt = new convertArrayListtoDataTable(bookList);

            dataGridViewStudentBorrowerList.DataSource = dt.GetDataTable(bookList);


        }

        private void rjButtonBorrow_Click(object sender, EventArgs e)
        {
            var popup = new AddBookPopup_Form();
            popup.ShowDialog();
        }

        private void customComboBoxSortCategory_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = customComboBoxSortCategory.SelectedItem.ToString();
            if(keyword == "Fiction")
            {
                keyword = "Fictional";
            }
            else if(keyword == "Non-Fiction")
            {
                keyword = "Non - Fictional";
            }
            
            if(keyword != "All")
            {
                for (int i = 0; i < this.dataGridViewStudentBorrowerList.Rows.Count; i++)
                {
                    if (dataGridViewStudentBorrowerList.Rows[i].Cells[2].Value.ToString() == keyword)
                    {
                        dataGridViewStudentBorrowerList.Rows[i].Visible = true;
                    }
                    else
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridViewStudentBorrowerList.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridViewStudentBorrowerList.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();

                    }
                }
            }
            else
            {
                for (int i = 0; i < this.dataGridViewStudentBorrowerList.Rows.Count; i++)
                {
                    dataGridViewStudentBorrowerList.Rows[i].Visible = true;
                }
            }

        }

        private void customComboBoxFilterStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = customComboBoxFilterStatus.SelectedItem.ToString();

            if (keyword != "All")
            {
                for (int i = 0; i < this.dataGridViewStudentBorrowerList.Rows.Count; i++)
                {
                    if (dataGridViewStudentBorrowerList.Rows[i].Cells[7].Value.ToString() == keyword)
                    {
                        dataGridViewStudentBorrowerList.Rows[i].Visible = true;
                    }
                    else
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridViewStudentBorrowerList.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridViewStudentBorrowerList.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();

                    }
                }
            }

            else
            {
                for (int i = 0; i < this.dataGridViewStudentBorrowerList.Rows.Count; i++)
                {
                    dataGridViewStudentBorrowerList.Rows[i].Visible = true;
                }
            }
        }
    }
}
