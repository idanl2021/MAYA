using IdanLalezari326643269.DATA;
using IdanLalezari326643269.UTILITIES;
using System;
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
    public partial class LessonForm : DataForm, IDataForm
    {
        HashSet<string> classesSet = new HashSet<string>();


        public LessonForm()
        {
            this.tableName = "Lessons";
            this.tableKeyName = "LessonID";
            InitializeComponent();
            base.CreateInputControlArray();
            base.CreateControlTypeDict();
            base.ChangeInputControlEnabled(false);
            FillClassComboBox();
        }

        string IDataForm.CheckInput()
        {
            return "";
        }

        void IDataForm.LeaveKeyTextBox(object sender, EventArgs e)
        {
            keyValue = LessonID_Input_string_1.Text;
        }

        private void LessonFrom_Load(object sender, EventArgs e)
        {
            Table = NETWORK.DatabaseServer.OpenTable_SelectAllFrom("Lessons");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, Table);
            count = 0;
            key = LessonID_Input_string_1;
            DisplayRecords(0);
        }

        public override void Search()
        {
            DataTable t = null;
            if (textBox1.Text == "")
            {
                t = Table;
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                t = DAL.OpenTable("Lessons Where LessonName LIKE '%" + this.textBox1.Text + "%'");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                t = DAL.OpenTable("Lessons Where TeacherID = '" + this.textBox1.Text + "'");
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
            //return;
        }

        protected void DisplayRecords(int currentRow)
        {
            base.DisplayRecords(currentRow);
            DataTable dt1 = DATA.DAL.GetSqlTable("SELECT TeacherID ,FirstName, LastName, [FirstName] & '\u200E ' & [LastName] FROM Teachers");
            UTILITIES.DisplayUtilities.FillDataGrid(teachers_dataGridView, dt1);

            ////// !!! Table ----> dt1 !!! ////////
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchTeacher();
        }

        void searchTeacher()
        {
            ////// !!! Table ----> dt1 !!! ////////
            DataTable dt1 = DATA.DAL.GetSqlTable("SELECT TeacherID ,FirstName, LastName FROM Teachers Where TeacherID LIKE '% " + textBox2.Text + " %' OR [FirstName] & '\u200E ' & [LastName] LIKE '%" + textBox2.Text + "%'");
            UTILITIES.DisplayUtilities.FillDataGrid(teachers_dataGridView, dt1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            searchTeacher();
        }

        private void AddRecord_BTN_Click_1(object sender, EventArgs e)
        {

        }

        public override void EditMode()
        {
            base.EditMode();
            teachers_dataGridView.Enabled = true;
        }

        public override void ExitEditMode()
        {
            base.ExitEditMode();
            teachers_dataGridView.Enabled = false;
        }

        private void teachers_dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID_INDEX = 0;
            string id = teachers_dataGridView.SelectedRows[0].Cells[ID_INDEX].Value.ToString();
            TeacherID_Input_string_3.Text = id;
            //DataTable t = DAL.GetSqlTable("SELECT * FROM Teachers Where TeacherID = '" + id + "'");
        }

        private void FillClassComboBox()
        {
            DataTable dt = DAL.GetSqlTable("SELECT ClassName From Classes");////////////
            List<DataRow> list = dt.AsEnumerable().ToList();

            // Order ClassName by alphabetical order
            IEnumerable<DataRow> query = list.OrderBy(dr => dr["ClassName"].ToString() /*Regex.Match(dr["ClassName"].ToString(), @"\d+").Value  */);

            foreach (DataRow item in query)
            {
                classes.Items.Add(item["ClassName"].ToString());
            }
            //ClassName_Input_string_4.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classesSet.Add(classes.Text);
        }

        protected override void Save_BTN_Click(object sender, EventArgs e)
        {
            DataTable dt = DAL.OpenTable("Lessons");
            //string StringId = dt.Compute("max([LessonID])", string.Empty).ToString();
            string StringId = "0";
            try
            {
                StringId = dt.Columns["LessonID"].Table.AsEnumerable().Max(row => int.Parse(Regex.Match(row.Field<string>("LessonID"), @"\d+").Value)).ToString();
            }
            catch (Exception)
            {
                
            }
            //int maxId = Convert.ToInt32(StringId.Remove(StringId.Length - 1));
            int maxId = int.Parse(Regex.Match(StringId, @"\d+").Value);
            this.LessonID_Input_string_1.Text = "" + (maxId + 1);
            base.Save_BTN_Click(sender, e);
            foreach (string classStr in classesSet)
            {
                Connect(maxId + 1, classStr);
            }
            classesSet.Clear();
        }


        protected void Connect(int lessonId, string className)
        {
            DataTable dt = DAL.GetSqlTable($"SELECT * From Students where ClassName = '{className}'");
            List<DataRow> list = dt.AsEnumerable().ToList();
            List<string> ids = new List<string>();
            list.ForEach(dr => { ids.Add(dr["StudentID"].ToString()); });
            DataTable lessonStudent;
            foreach (var id in ids)
            {
                lessonStudent = DAL.GetSqlTable("SELECT * From [Lesson-Student]");
                string strSQL = $"INSERT INTO [Lesson-Student] VALUES ('{lessonId}', '{id}')";
                LOGGER.Logger.PrintLog(strSQL);
                GeneralUtilities.AddRecd(lessonStudent, strSQL);
            }
        }
    }
}
