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
    public partial class TeachersBorrowerList_Form : Form
    {
        public TeachersBorrowerList_Form()
        {
            InitializeComponent();
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
    }
}
