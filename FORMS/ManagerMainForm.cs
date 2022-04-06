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

using IdanLalezari326643269.UTILITIES;

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
            FormUtilities.AddFormToPanel<MainFrom_ManagerForm>(mainPanel);
            greetingLabel.Text = GeneralUtilities.GetGreetingText();
            hour_LBL.Text = GeneralUtilities.GetHourString();
            toClasses_BTN.FlatAppearance.BorderSize = 0;
        }



        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void greetingLabel_Click(object sender, EventArgs e)
        {

        }

        private void toClasses_BTN_Click(object sender, EventArgs e)
        {
            UTILITIES.FormUtilities.AddFormToPanel<ClassesForm>(mainPanel);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toStudents_BTN_Click(object sender, EventArgs e)
        {
            UTILITIES.FormUtilities.AddFormToPanel<StudentsForm>(mainPanel);
        }

        private void toTeachers_BTN_Click(object sender, EventArgs e)
        {
            UTILITIES.FormUtilities.AddFormToPanel<TeachersForm>(mainPanel);
        }

        private void timer_HourLBL_Tick(object sender, EventArgs e)
        {
            hour_LBL.Text = GeneralUtilities.GetHourString();
        }

        private void CloseBTN_MouseEnter(object sender, EventArgs e)
        {
            CloseBTN.ForeColor = Color.Black;
            CloseBTN.BackColor = Color.White;
        }

        private void CloseBTN_MouseLeave(object sender, EventArgs e)
        {
            CloseBTN.ForeColor = Color.White;
            CloseBTN.BackColor = Color.IndianRed;
        }

        private void toLessons_Click(object sender, EventArgs e)
        {
            UTILITIES.FormUtilities.AddFormToPanel<LessonForm>(mainPanel);
        }
    }
}
