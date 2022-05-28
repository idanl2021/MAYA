using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdanLalezari326643269.ENUM;
using IdanLalezari326643269.DATA;
using IdanLalezari326643269.UTILITIES;
using IdanLalezari326643269.CLASS;

namespace IdanLalezari326643269.FORMS
{
    public partial class ClassesForm : DataForm, IDataForm
    {
        public ClassesForm() : base()
        {
            this.tableName = "Classes";
            this.tableKeyName = "ClassName";
            InitializeComponent();
            base.CreateInputControlArray();
            base.CreateControlTypeDict();
            base.ChangeInputControlEnabled(false);
        }

        public override string CheckInput()
        {
            return "";
        }

        public void LeaveKeyTextBox(object sender, EventArgs e)
        {
            keyValue = ClassName_Input_string_1.Text;
        }

        public override void Search()
        {
            DataTable t = null;
            if (textBox1.Text == "")
            {
                t = Table;
            }
            t = DAL.OpenTable("Classes WHERE ClassName LIKE '%" + textBox1.Text + "%'");
            if (UTILITIES.GeneralUtilities.IsEmpty(t)) return;
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, t);
            count = 0;
            DisplayRecords(0);
        }

        private void ClassesForm_Load(object sender, EventArgs e)
        {
            Table = DATA.DAL.OpenTable("Classes");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, Table);
            count = 0;
            DisplayRecords(0);
        }

        protected override void DisplayRecords(int currentRow)
        {
            base.DisplayRecords(currentRow);
            Table = DATA.DAL.GetSqlTable("SELECT StudentID ,FirstName, LastName FROM Students WHERE ClassName = '" + ClassName_Input_string_1.Text + "'");
            UTILITIES.DisplayUtilities.FillDataGrid(ClassStudents_dataGridView, Table);
        }

        private void ClassName_Input_string_1_TextChanged(object sender, EventArgs e)
        {
            Table = DATA.DAL.GetSqlTable("SELECT FirstName, LastName FROM Students WHERE ClassName = '" + ClassName_Input_string_1.Text + "'");
            UTILITIES.DisplayUtilities.FillDataGrid(ClassStudents_dataGridView, Table);
        }


        public static object GetCellValueFromColumnHeader( DataGridViewCellCollection CellCollection, string HeaderText)
        {
            return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.HeaderText == HeaderText).Value;
        }


        private void ClassStudents_dataGridView_RowHeaderMouseDoubleClick(object sender = null, DataGridViewCellMouseEventArgs e = null)
        {
            try
            {
                int ID_INDEX = 0;
                //string id = ClassStudents_dataGridView.SelectedRows[0].Cells[ID_INDEX].Value.ToString();
                //string id = ClassStudents_dataGridView.SelectedRows[0].Cells;
                string id = GetCellValueFromColumnHeader(ClassStudents_dataGridView.SelectedRows[0].Cells, "StudentID").ToString();
                DataTable t = DAL.GetSqlTable("SELECT * FROM Students Where StudentID = '" + id + "'");
                DataRow dr = t.AsEnumerable().ToList()[0];
                Student student = new Student(dr["StudentID"].ToString(), dr["FirstName"].ToString(), dr["LastName"].ToString(), dr["Address"].ToString(), dr["City"].ToString(), dr["BirthDate"].ToString(), dr["PhoneNumber"].ToString(), dr["ClassName"].ToString());

                SharedObject.ChangeObj(student, "Student");
                if (this.panel != null)
                {
                    StudentsForm frm = UTILITIES.FormUtilities.AddFormToPanel<StudentsForm>(this.panel);
                    frm.DisplayFromShared();
                }
            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog(ex.Message, Enums.LogType.Error);
            }
        }

        private void toStudentsWithShared_BTN_Click(object sender, EventArgs e)
        {
            ClassStudents_dataGridView_RowHeaderMouseDoubleClick(sender);      
        }

        private void ClassStudents_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
    
}
