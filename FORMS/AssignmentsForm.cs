using IdanLalezari326643269.DATA;
using IdanLalezari326643269.UTILITIES;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdanLalezari326643269.FORMS
{
    public partial class AssignmentsForm : DataForm, IDataForm
    {
        public AssignmentsForm(): base()
        {
            this.tableName = "Assignments";
            this.tableKeyName = "AssignmentID";
            InitializeComponent();
            base.CreateInputControlArray();
            base.CreateControlTypeDict();
            base.ChangeInputControlEnabled(false);
        }

        private void AssignmentsForm_Load(object sender, EventArgs e)
        {
            if (CLASS.SharedHashTable.dict.ContainsKey("TeacherID"))
            {
                Table = DAL.GetSqlTable("SELECT Assignments.* " +
                                            "From Assignments INNER JOIN Lessons " +
                                            "ON Assignments.LessonID = Lessons.LessonID" +
                                            $" WHERE Lessons.TeacherID = '{CLASS.SharedHashTable.dict["TeacherID"]}'  "); 
            }
            else
            {
                Table = NETWORK.DatabaseServer.OpenTable_SelectAllFrom("Assignments");
            }
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, Table);
            count = 0;
            key = AssignmentID_Input_string_1;
            DisplayRecords(0);
            
        }

        string IDataForm.CheckInput()
        {
            string str = "";
            
            return str;
        }

        void IDataForm.LeaveKeyTextBox(object sender, EventArgs e)
        {
            keyValue = AssignmentID_Input_string_1.Text;
        }

        public override void Search()
        {
            try
            {
                DataTable t = null;
                if (textBox1.Text == "")
                {
                    t = Table;
                }
                else if (comboBox1.SelectedIndex == 0)
                {
                    t = DAL.GetSqlTable("SELECT Assignments.* FROM Assignments INNER JOIN Lessons " +
                                            "ON Assignments.LessonID = Lessons.LessonID" +
                                            $" WHERE Lessons.TeacherID = '{CLASS.SharedHashTable.dict["TeacherID"]}'" +
                                            $" AND Type = '{textBox1.Text}'  ");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    t = DAL.GetSqlTable("SELECT Assignments.* FROM Assignments INNER JOIN Lessons " +
                                            "ON Assignments.LessonID = Lessons.LessonID" +
                                            $" WHERE Lessons.TeacherID = '{CLASS.SharedHashTable.dict["TeacherID"]}'" +
                                            $" AND Lessons.LessonID = '{textBox1.Text}'  ");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    t = DAL.GetSqlTable("SELECT Assignments.* FROM Assignments INNER JOIN Lessons " +
                                            "ON Assignments.LessonID = Lessons.LessonID" +
                                            $" WHERE Lessons.TeacherID = '{CLASS.SharedHashTable.dict["TeacherID"]}'" +
                                            $" AND Deadline = #{textBox1.Text}#  ");
                }
                else if (t == null)
                {
                    MessageBox.Show("ERROR!");
                    return;
                }
                if (UTILITIES.GeneralUtilities.IsEmpty(t)) return;
                UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, t);
                count = 0;
                DisplayRecords(0);
            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog(ex.Message, ENUM.Enums.LogType.Error);
            }
        }


        public override void EditMode()
        {
            base.EditMode();
            lessons_dgv.Enabled = true;
        }

        public override void ExitEditMode()
        {
            base.ExitEditMode();
            lessons_dgv.Enabled = false;
        }

        protected void DisplayRecords(int currentRow)
        {
            try
            {
                base.DisplayRecords(currentRow);
                DataTable dt1 = DATA.DAL.GetSqlTable("SELECT LessonID, LessonName FROM Lessons " +
                                                     $"WHERE TeacherID = '{CLASS.SharedHashTable.dict["TeacherID"]}'");
                UTILITIES.DisplayUtilities.FillDataGrid(lessons_dgv, dt1);
            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog(ex.Message, ENUM.Enums.LogType.Error);
            }

            ////// !!! Table ----> dt1 !!! ////////
        }

        protected override void Save_BTN_Click(object sender, EventArgs e)
        {
            DataTable dt = DAL.OpenTable("Assignments");
            //string StringId = dt.Compute("max([AssignmentID])", string.Empty).ToString();
            string StringId = "0";
            try
            {
                StringId = dt.Columns["AssignmentID"].Table.AsEnumerable().Max(row => int.Parse(Regex.Match(row.Field<string>("AssignmentID"), @"\d+").Value)).ToString();
            }
            catch (Exception)
            {

            }
            //int maxId = Convert.ToInt32(StringId[0]);
            int maxId = int.Parse(Regex.Match(StringId, @"\d+").Value);

            maxId++;
            AssignmentID_Input_string_1.Text = maxId.ToString();

            base.Save_BTN_Click(sender, e);
            Table = DAL.GetSqlTable("SELECT Assignments.* " +
                                            "From Assignments INNER JOIN Lessons " +
                                            "ON Assignments.LessonID = Lessons.LessonID" +
                                            $" WHERE Lessons.TeacherID = '{CLASS.SharedHashTable.dict["TeacherID"]}'  ");
            Connect(maxId);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, Table);
        }

        void Connect(int assignmentId)
        {
            DataTable dt = DAL.GetSqlTable($"SELECT DISTINCT StudentID " +
                                           $"FROM (Assignments INNER JOIN Lessons ON Assignments.LessonID = Lessons.LessonID) " +
                                           $"INNER JOIN [Lesson-Student] ON Lessons.LessonID = [Lesson-Student].LessonID " +
                                           $" ");
            List<DataRow> list = dt.AsEnumerable().ToList();
            List<string> ids = new List<string>();
            list.ForEach(dr => { ids.Add(dr["StudentID"].ToString()); });

            DataTable assignmentStudent;
            foreach (var id in ids)
            {
                assignmentStudent = DAL.GetSqlTable("SELECT * From [Assignment-Student]");
                string strSQL = $"INSERT INTO [Assignment-Student] VALUES ('{assignmentId}', '{id}', '')";
                LOGGER.Logger.PrintLog(strSQL);
                //MessageBox.Show(GeneralUtilities.AddRecd(assignmentStudent, strSQL));
                GeneralUtilities.AddRecd(assignmentStudent, strSQL);
            }
        }

        private void lessons_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID_INDEX = 0;
            if (LessonID_Input_string_4.Visible != true) return;
            string id = lessons_dgv.SelectedRows[0].Cells[ID_INDEX].Value.ToString();
            LessonID_Input_string_4.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLASS.SharedHashTable.dict["AssignmentID"] = this.AssignmentID_Input_string_1.Text;
            Form frm = new AssignmentStudentForm();
            frm.Show();
        }
    }
}
