using IdanLalezari326643269.CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdanLalezari326643269.FORMS
{
    public partial class ManagerMainForm : Form
    {
        User user;
        public ManagerMainForm()
        {
            InitializeComponent();
        }

        public ManagerMainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ManagerMainForm_Load(object sender, EventArgs e)
        {
            ToStudents_NavButton.Text = "תלמידים";
            

        }

        private void ToStudents_NavButton_Load(object sender, EventArgs e)
        {
            //this.Text = "תלמידים";
        }

        private void ToStudents_NavButton_Click(object sender, EventArgs e)
        {
            UTILITIES.FormUtilities.AddFormToPanel<StudentsForm>(mainPanel);
        }

        private void ToTeachers_NavButton_Load(object sender, EventArgs e)
        {
            ToTeachers_NavButton.Text = "מורים";
        }

        private void ToTeachers_NavButton_Click(object sender, EventArgs e)
        {
            
            UTILITIES.FormUtilities.AddFormToPanel<TeachersForm>(mainPanel);
        }

        private void ToClasses_NavButton_Load(object sender, EventArgs e)
        {
            ToClasses_NavButton.Text = "כיתות";
        }

        private void ToClasses_NavButton_Click(object sender, EventArgs e)
        {
            UTILITIES.FormUtilities.AddFormToPanel<ClassesForm>(mainPanel);
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
