using IdanLalezari326643269.DATA;
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
    public partial class MainFormOfStudents : Form
    {
        public MainFormOfStudents()
        {
            InitializeComponent();
        }

        private void MainFormOfStudents_Load(object sender, EventArgs e)
        {
            if (CLASS.SharedHashTable.dict.ContainsKey("StudentID"))
            {
                DataTable dt = DAL.GetSqlTable($"SELECT Grade FROM [Assignment-Student] WHERE StudentID = '{CLASS.SharedHashTable.dict["StudentID"]}'");
                //double avg = (double)dt.Compute("AVG([Grade])", "");
                var list = dt.AsEnumerable();
                double avg = 0, numofgrades = 0;
                foreach (var row in list)
                {
                    if (row["Grade"].ToString().Length > 0) {
                        avg += double.Parse(row["Grade"].ToString());
                        numofgrades++;
                    }
                }
                numofgrades = numofgrades == 0 ? 1 : numofgrades;
                avg = avg / numofgrades;
                grade.Text = avg.ToString();

                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                try
                {
                    progressBar1.Value = (int)avg;
                }
                catch (Exception)
                {
                    progressBar1.Value = 100;
                }


                if (CLASS.SharedHashTable.dict.ContainsKey("StudentID"))
                {
                    UTILITIES.DisplayUtilities.FillDataGrid(dataGridView1, DAL.GetSqlTable("SELECT LessonName ,Assignments.AssignmentID AS AssignmentID, Type, Deadline, Grade FROM ([Assignment-student] INNER JOIN Assignments ON [Assignment-student].AssignmentID = Assignments.AssignmentID)" +
                        " INNER JOIN Lessons ON Lessons.LessonID = Assignments.LessonID " +
                                $"WHERE StudentID = '{CLASS.SharedHashTable.dict["StudentID"]}'")); 
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CLASS.SharedHashTable.dict["AssignmentIDForSend"] = dataGridView1.SelectedRows[0].Cells["AssignmentID"].Value.ToString();
            var frm = new sendAssignmentForm();
            frm.Show();
        }
    }
}
