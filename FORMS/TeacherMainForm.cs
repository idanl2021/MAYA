using IdanLalezari326643269.UTILITIES;
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
    public partial class TeacherMainForm : Form
    {
        public TeacherMainForm()
        {
            InitializeComponent();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_HourLBL_Tick(object sender, EventArgs e)
        {
            hour_LBL.Text = GeneralUtilities.GetHourString();
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            greetingLabel.Text = GeneralUtilities.GetGreetingText();
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

        private void toAssignments_BTN_Click(object sender, EventArgs e)
        {
            UTILITIES.FormUtilities.AddFormToPanel<AssignmentsForm>(this.mainPanel);
        }
    }
}
