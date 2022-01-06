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
using IdanLalezari326643269.ENUM;
using IdanLalezari326643269.UTILITIES;
using IdanLalezari326643269.DATA;
using IdanLalezari326643269.FORMS;

namespace IdanLalezari326643269
{
    public partial class TeachersForm :  DataForm, IDataForm
    {
        public TeachersForm() : base()
        {
            this.tableName = "Teachers";
            this.tableKeyName = "TeacherID";
            InitializeComponent();
            base.CreateInputControlArray();
            base.CreateControlTypeDict();
            base.ChangeInputControlEnabled(false);
        }

        public override string CheckInput()
        {
            string str = "";
            if (!UTILITIES.ValidationsUtilities.LegalId(TeacherID_Input_string_1.Text))
            {
                str += "ERROR: Illegal Id!\n";
            }
            if (this.FirstName_Input_string_2.Text.Length <= 1)
            {
                str += "ERROR: Illegal first name!\n";
            }
            if (this.LastName_Input_string_3.Text.Length <= 1)
            {
                str += "ERROR: Illegal last name!\n";
            }

            return str;
        }

        public void LeaveKeyTextBox(object sender, EventArgs e)
        {
            keyValue = TeacherID_Input_string_1.Text;
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
                t = DAL.OpenTable("Teachers Where TeacherID = '" + this.textBox1.Text + "'");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                t = DAL.OpenTable("Teachers Where FirstName LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                t = DAL.OpenTable("Teachers Where LastName LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                t = DAL.OpenTable("Teachers Where City LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                t = DAL.OpenTable("Teachers Where BirthDate = #" + this.textBox1.Text + "#");
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

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            Table = NETWORK.DatabaseServer.OpenTable_SelectAllFrom("Teachers");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, Table);
            count = 0;
            key = TeacherID_Input_string_1;
            DisplayRecords(0);
        }
    }
}
