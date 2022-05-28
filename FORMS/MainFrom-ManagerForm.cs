using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdanLalezari326643269;
using System.Data.OleDb;

namespace IdanLalezari326643269.FORMS
{
    public partial class MainFrom_ManagerForm : Form
    {
        DataTable table;
        int male, female;

        public MainFrom_ManagerForm()
        {
            InitializeComponent();
        }

        private void MainFrom_ManagerForm_Load(object sender, EventArgs e)
        {
            string numOfStudents, numOfTeachers, numOfClasses;
            string numOfMaleStudents, numOfFemaleStudents;
            string LTR = UTILITIES.GeneralUtilities.GetLTRMark();

            table = DATA.DAL.GetSqlTable("SELECT COUNT(StudentID) AS NumOfStudents From Students");
            List<DataRow> dataRows = table.AsEnumerable().ToList();
            numOfStudents = dataRows[0]["NumOfStudents"].ToString();

            table = DATA.DAL.GetSqlTable("SELECT COUNT(StudentID) AS NumOfStudents From Students WHERE Gender = 'M'");
            dataRows = table.AsEnumerable().ToList();
            numOfMaleStudents = dataRows[0]["NumOfStudents"].ToString();

            table = DATA.DAL.GetSqlTable("SELECT COUNT(StudentID) AS NumOfStudents From Students WHERE Gender = 'W'");
            dataRows = table.AsEnumerable().ToList();
            numOfFemaleStudents = dataRows[0]["NumOfStudents"].ToString();

            table = DATA.DAL.GetSqlTable("SELECT COUNT(TeacherID) AS NumOfTeachers From Teachers");
            dataRows = table.AsEnumerable().ToList();
            numOfTeachers = dataRows[0]["NumOfTeachers"].ToString();

            table = DATA.DAL.GetSqlTable("SELECT COUNT(ClassName) AS NumOfClasses From Classes");
            dataRows = table.AsEnumerable().ToList();
            numOfClasses = dataRows[0]["NumOfClasses"].ToString();


            numOfStudents_LBL.Text = numOfStudents;
            numOfStudentsByGender_LBL.Text = "תלמידות " + LTR + numOfFemaleStudents + LTR + " ו"
                + LTR + " תלמידים " + LTR + numOfMaleStudents + LTR + " " + LTR + "מתוכם ,";
            numOfTeachers_LBL.Text = numOfTeachers;
            numOfClasses_LBL.Text = numOfClasses;

            DateLabel.Text = DateTime.Now.ToShortDateString();

            male = int.Parse(numOfMaleStudents);
            female = int.Parse(numOfFemaleStudents);

            

        }

        public void DisplayPieChart()
        {
            GenderChart.Series["s_gender"].Points.AddXY("male", male);
            GenderChart.Series["s_gender"].Points.AddXY("female", female);
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            DisplayPieChart();
        }




    }
}
