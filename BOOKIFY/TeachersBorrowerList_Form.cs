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
    public partial class TeachersBorrowerList_Form : Form
    {
        public TeachersBorrowerList_Form()
        {
            InitializeComponent();
            teacherList teacher = new teacherList();
            ArrayList bookList = teacher.GetTeacher();
            convertArrayListtoDataTable dt = new convertArrayListtoDataTable(bookList);

            dataGridViewStudentBorrowerList.DataSource = dt.GetDataTable(bookList);
        }

        private void TeachersMembers_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButtonTeachers_Click(object sender, EventArgs e)
        {
            // Create an instance of the TeacherForm
            TeachersBorrowerList_Form teacherForm = new TeachersBorrowerList_Form();

            // Set the TopLevel property to false to allow embedding in the MainPanel
            teacherForm.TopLevel = false;
            teacherForm.Dock = DockStyle.Fill;

            // Clear existing controls in the MainPanel
            SharedClass.MainFormInstance.mainPanel.Controls.Clear();

            // Add the TeacherForm to the MainPanel
            SharedClass.MainFormInstance.mainPanel.Controls.Add(teacherForm);

            // Show the TeacherForm
            teacherForm.Show();
        }

        private void bunifuButtonStudents_Click(object sender, EventArgs e)
        {
            // Create an instance of the TeacherForm
            StudentBorrowerList_Form studentForm = new StudentBorrowerList_Form();

            // Set the TopLevel property to false to allow embedding in the MainPanel
            studentForm.TopLevel = false;
            studentForm.Dock = DockStyle.Fill;

            // Clear existing controls in the MainPanel
            SharedClass.MainFormInstance.mainPanel.Controls.Clear();

            // Add the TeacherForm to the MainPanel
            SharedClass.MainFormInstance.mainPanel.Controls.Add(studentForm);

            // Show the TeacherForm
            studentForm.Show();
        }

        private void customComboBoxSort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = customComboBoxSort.SelectedItem.ToString();

            if (keyword != "All")
            {
                for (int i = 0; i < this.dataGridViewStudentBorrowerList.Rows.Count; i++)
                {
                    if (dataGridViewStudentBorrowerList.Rows[i].Cells[3].Value.ToString() == keyword)
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
