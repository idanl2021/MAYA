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
    }
}
