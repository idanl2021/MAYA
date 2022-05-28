using IdanLalezari326643269.DATA;
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
    public partial class AssignmentStudentForm : Form
    {
        string assignmentID, studentID, grade;

        public AssignmentStudentForm()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            grade = grade_label.Text = trackBar1.Value.ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (assignmentID.Length > 0 && studentID.Length == 9 && int.Parse(grade) >= 0 && int.Parse(grade) <= 100)
                {
                    string updateSql = $"UPDATE [Assignment-Student] SET Grade = '{grade}' WHERE StudentID='{studentID}' AND AssignmentID = '{assignmentID}'";
                    MessageBox.Show(GeneralUtilities.UpDateRecd(DAL.OpenTable("[Assignment-Student]"), updateSql));
                    //MessageBox.Show("הנתונים נשמרו" + $"\n{assignmentID}, {studentID}, {grade}");
                }
            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog(ex.Message, ENUM.Enums.LogType.Error);
            }
        }

        private void AssignmentStudentForm_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;

            DataTable dt = DAL.GetSqlTable("SELECT Students.* " +
                                           "FROM Students INNER JOIN [Assignment-Student] " +
                                           "ON Students.StudentID =  [Assignment-Student].StudentID " +
                                           $"WHERE [Assignment-Student].AssignmentID = '{CLASS.SharedHashTable.dict["AssignmentID"]}' ");
            UTILITIES.DisplayUtilities.FillDataGrid(students_dgv, dt);

            assignmentID = CLASS.SharedHashTable.dict["AssignmentID"].ToString();
        }

        private void students_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentID = students_dgv.SelectedRows[0].Cells["StudentID"].Value.ToString();
        }
    }
}
