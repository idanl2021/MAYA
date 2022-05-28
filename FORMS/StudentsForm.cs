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
using System.Text.RegularExpressions;

namespace IdanLalezari326643269.FORMS
{
    public partial class StudentsForm : DataForm, IDataForm
    {
        
        public StudentsForm() : base()
        {
            this.tableName = "Students";
            this.tableKeyName = "StudentID";
            InitializeComponent();
            base.CreateInputControlArray();
            base.CreateControlTypeDict();
            base.ChangeInputControlEnabled(false);
            FillClassComboBox();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            //Table = NETWORK.DatabaseServer.OpenTable_SelectAllFrom("Students");
            
            Table = NETWORK.DatabaseServer.OpenTable_SelectAllFrom("Students");
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, Table);
            count = 0;
            key = StudentID_Input_string_1;
            DisplayRecords(0);
        }

        private void FillClassComboBox()
        {
            DataTable dt = DAL.GetSqlTable("SELECT ClassName From Classes");////////////
            List<DataRow> list = dt.AsEnumerable().ToList();

            // Order ClassName by alphabetical order
            IEnumerable<DataRow> query = list.OrderBy(dr => dr["ClassName"].ToString() /*Regex.Match(dr["ClassName"].ToString(), @"\d+").Value  */);

            foreach (DataRow item in query)
            {
                ClassName_Input_string_4.Items.Add(item["ClassName"].ToString());
            }
            //ClassName_Input_string_4.DataSource = dt;
        }

        private void First_BTN_Click_1(object sender, EventArgs e)
        {

        }

        //create a function that add two numbers and return the result -- github copilot
        int Add(int a, int b)
        {
            return a + b;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        //public override Control[] GetInputControls()
        //{
        //    return new Control[] { /*this.Key_TB,*/ this.FirstName_Input_string, this.LastName_Input_string, this.ClassName_Input_string, this.Address_Input_string, this.City_Input_string, this.BirthDate_Input_address, this.PhoneNumber_Input_string };
        //}
        //public override Dictionary<Control, Enums.ControlType> GetTypeDict()
        //{
        //    Dictionary<Control, ENUM.Enums.ControlType> dict = new Dictionary<Control, ENUM.Enums.ControlType>();
        //    //dict.Add(this.Key_TB, Enums.ControlType.@string);
        //    dict.Add(StudentID_Input_string_1, Enums.ControlType.@string);
        //    dict.Add(this.FirstName_Input_string_2, Enums.ControlType.@string);
        //    dict.Add(this.LastName_Input_string_3, Enums.ControlType.@string);
        //    dict.Add(this.ClassName_Input_string_4, Enums.ControlType.@int);
        //    dict.Add(this.Address_Input_string_5, Enums.ControlType.@string);
        //    dict.Add(this.City_Input_string_6, Enums.ControlType.@string);
        //    dict.Add(this.BirthDate_Input_address_7, Enums.ControlType.address);
        //    dict.Add(this.PhoneNumber_Input_string_8, Enums.ControlType.@string);
        //    return dict;
        //}
        //public override string Insert_sqlString()
        //{
        //    return "INSERT INTO Students(StudentID,FirstName,LastName,ClassID,Address,City,BirthDate,PhoneNumber) VALUES (" + this.Insert_sqlString_ControlsArray() + ")";
        //}

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            
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
                t = DAL.OpenTable("Students Where StudentID = '" + this.textBox1.Text + "'");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                t = DAL.OpenTable("Students Where FirstName LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                t = DAL.OpenTable("Students Where LastName LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                t = DAL.OpenTable("Students Where ClassName LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                t = DAL.OpenTable("Students Where City LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                t = DAL.OpenTable("Students Where BirthDate = #" + this.textBox1.Text + "#");
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

        protected void AddRecord_BTN_Click(object sender, EventArgs e) { base.AddRecord_BTN_Click(sender, e); }

        public void LeaveKeyTextBox(object sender, EventArgs e)
        {
            keyValue = StudentID_Input_string_1.Text;
        }



        //private void Key_TB_Leave(object sender, EventArgs e)
        //{

        //    if (!UTILITIES.ValidationsUtilities.LegalId(keyValue))
        //    {
        //        MessageBox.Show("ERROR: Illegal Id!");
        //        this.ActiveControl = this.StudentID_Input_string_1;
        //    }
        //}

        public override string CheckInput()//returns an errors string; "" if OK
        {
            string str = "";
            if (!UTILITIES.ValidationsUtilities.LegalId(StudentID_Input_string_1.Text))
            {
                str += "ERROR: Illegal Id!\n";
            }
            if(this.FirstName_Input_string_2.Text.Length <= 1)
            {
                str += "ERROR: Illegal first name!\n";
            }
            if (this.LastName_Input_string_3.Text.Length <= 1)
            {
                str += "ERROR: Illegal last name!\n";
            }

            return str;
        }

        override protected void Save_BTN_Click(object sender, EventArgs e)
        {
            base.Save_BTN_Click(sender, e);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("ID", StudentID_Input_string_1.Text);
            dict.Add("Password", StudentID_Input_string_1.Text);
            dict.Add("Group", "Students");
            dict.Add("Gender", Gender_Input_string_9.Text);
            DAL.InsertRow("Users", dict);
        }

        private void Update_BTN_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void EditMode()
        {
            base.EditMode();
            genderPanel.Enabled = true;
        }

        public override void ExitEditMode()
        {
            base.ExitEditMode();
            genderPanel.Enabled = false;
        }

        private void Gender_Input_string_9_TextChanged(object sender, EventArgs e)
        {
            //switch (Gender_Input_string_9.Text)
            //{
            //    case "M":
            //        Man_RadioBTN.Checked = true;
            //        break;
            //    case "W":
            //        Woman_RadioBTN.Checked = true;
            //        break;
            //    case "N":
            //        NoneGender_RadioBTN.Checked = true;
            //        break;
            //    default:
            //        break;
            //}

            string gender = Gender_Input_string_9.Text;
            if(gender.Length >= 2)
            {
                gender = gender.Remove(gender.Length - 1);
            }
            if(gender == "M")
            {
                Man_RadioBTN.Checked = true;
            }
            else if (gender == "W")
            {
                Woman_RadioBTN.Checked = true;
            }
            else if (gender == "N")
            {
                NoneGender_RadioBTN.Checked = true;
            }
            else
            {
                LOGGER.Logger.PrintLog($"gender is {gender}");
            }
            if(gender.Equals("L"))
            {
                LOGGER.Logger.PrintLog(gender);
            }
        }

        private void Man_RadioBTN_Click(object sender, EventArgs e)
        {
            Gender_Input_string_9.Text = "M";
        }

        private void Woman_RadioBTN_Click(object sender, EventArgs e)
        {
            Gender_Input_string_9.Text = "W";
        }

        private void NoneGender_RadioBTN_Click(object sender, EventArgs e)
        {
            Gender_Input_string_9.Text = "N";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Woman_RadioBTN.Checked = true;
        }

        public void DisplayFromShared()
        {
            if (SharedObject.typeOfObj == "Student")
            {
                Student student = SharedObject.obj as Student;
                int rowIndex = -1;

                DataGridViewRow row = dataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["StudentID"].Value.ToString().Equals(student.PersonID))
                    .First();

                rowIndex = row.Index;
                if (rowIndex != -1)
                {
                    DisplayRecords(rowIndex);
                }
            }
            else
            {
                DisplayRecords(0);
            }
        }

        private void ClassName_Input_string_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
