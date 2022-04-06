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
    public partial class LessonForm : DataForm, IDataForm
    {
        
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

        void IDataForm.Search()
        {
            return;
        }

        protected void DisplayRecords(int currentRow)
        {
            base.DisplayRecords(currentRow);
            Table = DATA.DAL.GetSqlTable("SELECT TeacherID ,FirstName, LastName, [FirstName] & '\u200E ' & [LastName] FROM Teachers");
            UTILITIES.DisplayUtilities.FillDataGrid(teachers_dataGridView, Table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchTeacher();
        }

        void searchTeacher()
        {
            Table = DATA.DAL.GetSqlTable("SELECT TeacherID ,FirstName, LastName FROM Teachers Where TeacherID LIKE '% " + textBox2.Text + " %' OR [FirstName] & '\u200E ' & [LastName] LIKE '%" + textBox2.Text + "%'");
            UTILITIES.DisplayUtilities.FillDataGrid(teachers_dataGridView, Table);
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
            DataTable dt = DAL.GetSqlTable("SELECT ClassName From Classes");
            //string strSql = "INSERT INTO Lesson-Student(LessonID, StudentID) VALUES ('"
        }
    }
}
