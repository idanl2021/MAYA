using System;
using System.Collections.Generic;
using System.Collections;
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
using IdanLalezari326643269.CLASS;

namespace IdanLalezari326643269.FORMS
{
    public /*abstract*/ partial class DataForm : Form/*, IDataForm*/
    {
        protected DataTable Table;
        //public DialogResult dr; // UNUSED
        public int count;
        private int indexOfDataGridView;
        public int IndexOfDataGridView
        {
            get => indexOfDataGridView;
            set
            {
                if (value > dataGridView.RowCount - 2)
                    indexOfDataGridView = 0;
                else if (value < 0)
                    indexOfDataGridView = dataGridView.RowCount - 2;
                else indexOfDataGridView = value;
            }

        }
        protected string tableName;
        protected string tableKeyName;
        protected ArrayList inputControls;
        protected string keyValue;
        protected Control key;
        protected Dictionary<Control, Enums.ControlType> controlTypeDict;
        bool toUpdate = false;
        public 
            bool toAddUser = false;

        public Panel panel = null;

        //public Type type = DataForm;

        public DataForm()
        {
            InitializeComponent();
            //CreateInputControlArray();
        }

        protected void ClearInputControls()
        {
            var controls = GetInputControls();
            foreach (Control c in controls)
            {
                c.Text = "";
            }
        }

        protected void First_BTN_Click(object sender, EventArgs e)
        {
            DisplayRecords(0);
        }

        public virtual ArrayList GetInputControls()
        {
            return inputControls;
        }

        public class ControlComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                try
                {
                    return -/*1 => -1*/((new CaseInsensitiveComparer()).Compare((y as Control).Name.Split('_')[(int)ENUM.Enums.ControlNameOrder.order], (x as Control).Name.Split('_')[(int)ENUM.Enums.ControlNameOrder.order]));
                }
                catch (Exception ex)
                {
                    LOGGER.Logger.PrintLog("ControlComparer ERROR: " + ex.Message, Enums.LogType.Error);
                    //System.Diagnostics.Debug.WriteLine("ControlComparer ERROR: " + ex.Message);
                    return 0;
                }
            }
        }

        public virtual void CreateInputControlArray()
        {
            this.inputControls = new ArrayList();
            foreach (Control control in this.Controls)
            {
                try
                {
                    if (control.Name.Split('_')[1] == "Input")
                    {
                        this.inputControls.Add(control);
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            inputControls.Sort(new ControlComparer());
        }

        public void CreateControlTypeDict()
        {
            controlTypeDict = new Dictionary<Control, Enums.ControlType>();
            var inputs = GetInputControls();
            Enums.ControlType type;
            foreach (Control input in inputs)
            {
                Enum.TryParse(input.Name.Split('_')[(int)Enums.ControlNameOrder.controlType], out type);
                controlTypeDict.Add(input, type);
            }
        }

        public virtual Dictionary<System.Windows.Forms.Control, ENUM.Enums.ControlType> GetTypeDict()
        {
            //Dictionary<Control, ENUM.Enums.ControlType> dict = new Dictionary<Control, ENUM.Enums.ControlType>();
            //dict.Add(this.Key_TB, Enums.ControlType.@string);
            return controlTypeDict;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            First_BTN.BackgroundImage = null;
        }

        protected virtual void DisplayRecords(int currentRow)
        {
            try
            {
                dataGridView.Rows[IndexOfDataGridView].Selected = false;
                IndexOfDataGridView = currentRow;
                var Controls = GetInputControls();
                for (int i = 0; i < Controls.Count; i++)
                {
                    (Controls[i] as Control).Text = dataGridView.Rows[IndexOfDataGridView].Cells[i].Value.ToString();
                }
                dataGridView.Rows[IndexOfDataGridView].Selected = true; ///////////!!!!
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine("DisplayRecords ERROR: " + ex.Message);
                LOGGER.Logger.PrintLog("DisplayRecords ERROR: " + ex.Message, Enums.LogType.Error);
            }
        }

        public virtual string Insert_sqlString()
        {
            string str = @"INSERT INTO " + tableName + "(" + GetSqlTableColumnsNames() + ") VALUES (" + this.Insert_sqlString_ControlsArray() + ")";
            LOGGER.Logger.PrintLog(str);
            return str;
        }

        protected virtual string Insert_sqlString_ControlsArray()
        {
            string LTRMark = "\u200E";
            var controlsArray = GetInputControls();
            string str = "";
            var dict = GetTypeDict(); // Hashtable of controls types
            foreach (Control c in controlsArray)
            {
                if (dict[c] == (Enums.ControlType.address))
                {
                    str += "#" + (c as DateTimePicker).Value.ToString("dd/MM/yyyy") + "#,";
                }
                else if (dict[c] == (Enums.ControlType.@int))
                {
                    str += c.Text + ",";
                }
                else if (dict[c] == (Enums.ControlType.@string))
                {
                    str += "'" + c.Text.Replace("'", "''") + LTRMark + "',"; // replace ' with '' to prevent access sql problems
                }
                else
                    throw new Exception("control is not int/string/address");

            }
            str = str.Remove(str.Length - 3);
            str += "'";
            return str;
        }



        public string GetSqlTableColumnsNames()
        {
            var inputs = GetInputControls();
            string ret = "";
            foreach (var inputControl in inputs)
            {
                /*
                 inputControl: StudentID_Input_string ===> StudentID
                 */
                try
                {
                    ret += (inputControl as Control).Name.Split('_')[0] + ",";
                }
                catch (Exception)
                {

                    continue;
                }
            }
            ret = ret.Remove(ret.Length - 1); // Remove the last comma ,
            return ret;
        }

        public string[] GetSqlTableColumnsNamesAsArray()
        {
            var inputs = GetInputControls();
            ArrayList array = new ArrayList();
            foreach (var inputControl in inputs)
            {
                /*
                 inputControl: StudentID_Input_string ===> StudentID
                 */
                try
                {
                    array.Add((inputControl as Control).Name.Split('_')[0]);
                }
                catch (Exception)
                {

                    continue;
                }
            }
            return Array.ConvertAll(array.ToArray(), x => x.ToString());
        }

        protected void AddRecord(string tableName, string tableKeyName/*, object sender, EventArgs e*/)
        {
            string strSql;
            if (!(DisplayUtilities.ContIsfull(this)))
                MessageBox.Show(("חסרים נתונים"));
            else
            {
                strSql = "Select * " +
                        "from " + tableName + " " +
                         "where " + tableKeyName + "='" + key.Text + "'";
                DAL.GetDataSet(strSql);

                if (DAL.ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("רשומה כבר קיימת");
                }
                else
                {
                    //var controlscol = this.Controls;
                    strSql = Insert_sqlString();
                    MessageBox.Show(GeneralUtilities.AddRecd(Table, strSql));
                    //StudentsForm();

                }
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            DisplayRecords(indexOfDataGridView - 1);
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayRecords(e.RowIndex);
        }

        private void Next_BTN_Click(object sender, EventArgs e)
        {
            DisplayRecords(indexOfDataGridView + 1);
        }

        private void Last_BTN_Click(object sender, EventArgs e)
        {
            DisplayRecords(dataGridView.RowCount - 2);
        }

        protected void AddRecord_BTN_Click(object sender, EventArgs e)
        {
            this.ClearInputControls();
            EditMode();
        }

        private void Search_BTN_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        public virtual void Search()
        {

        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            ExitEditMode();
        }

        protected virtual void Save_BTN_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save() ///////////////////////////////////////////////////////////
        {
            string errorString = CheckInput();
            if (errorString == "")
            {
                if (toUpdate)
                {
                    //////?????
                    ///
                    UpdateRecord();
                    toUpdate = !toUpdate;
                }
                else
                {
                    AddRecord(tableName, tableKeyName);
                    if (toAddUser) {
                        GeneralUtilities.addUser(key.Text, tableName);
                        toAddUser = false;
                    }
                }
                ExitEditMode();
                //Console.WriteLine("hi");
            }
            else
            {
                MessageBox.Show(errorString);
            }
            //GeneralUtilities.RefrechTable(Table, tableName);
            UTILITIES.DisplayUtilities.FillDataGrid(dataGridView, DAL.OpenTable(tableName));
        }


        public virtual string CheckInput()/*returns an errors string; "" if OK*/ { return ""; }

        public void ChangeInputControlEnabled(bool toEnable)
        {
            var inputs = GetInputControls();
            foreach (Control input in inputs)
            {
                input.Enabled = toEnable;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void Clear_BTN_Click(object sender, EventArgs e)
        {
            ClearInputControls();
        }

        private void Update_BTN_Click(object sender, EventArgs e)
        {
            EditMode();
            toUpdate = true;
            //UpdateRecord();

        }

        public void UpdateRecord()
        {
            string strSql;
            if (!(DisplayUtilities.ContIsfull(this)))
                MessageBox.Show(("חסרים נתונים"));
            else
            {
                strSql = "Select * " +
                        "from " + tableName + " " +
                         "where " + tableKeyName + "='" + keyValue + "'";
                DAL.GetDataSet(strSql);

                if (DAL.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("רשומה כבר קיימת");
                else
                {
                    var controlscol = this.Controls;
                    strSql = GetUpdateSQLstring();
                    MessageBox.Show(GeneralUtilities.UpDateRecd(Table, strSql));
                    ////StudentsForm();

                }
            }
        }

        public string GetUpdateSQLstring()
        {
            string str = "UPDATE " + tableName + " SET ";
            string[] stringArr = GetSqlTableColumnsNamesAsArray();
            var dict = GetTypeDict();
            string LTRMark = "\u200E";
            for (int i = 1; i < stringArr.Length; i++)
            {
                Control c = inputControls[i] as Control;
                if (dict[c] == (Enums.ControlType.address))
                {
                    str += stringArr[i] + "=" + "#" + (c as DateTimePicker).Value.ToString("dd/MM/yyyy") + "#,";
                }
                else if (dict[c] == (Enums.ControlType.@int))
                {
                    str += stringArr[i] + "=" + c.Text + ",";
                }
                else if (dict[c] == (Enums.ControlType.@string))
                {
                    str += stringArr[i] + "=" + "'" + c.Text.Replace("'", "''") + LTRMark + "',"; // replace ' with '' to prevent access sql problems
                }
                else
                    throw new Exception("control is not int/string/address");
                /////str += stringArr[i] + "=" + (inputControls[i] as Control).Text + ",";
            }
            str = str.Remove(str.Length - 1);
            str += " WHERE " + tableKeyName + "=";
            if (dict[key] == (Enums.ControlType.address))
            {
                str += "#" + (key as DateTimePicker).Value.ToString("dd/MM/yyyy") + "#";
            }
            else if (dict[key] == (Enums.ControlType.@int))
            {
                str += key.Text;
            }
            else if (dict[key] == (Enums.ControlType.@string))
            {
                str += "'" + key.Text.Replace("'", "''") + LTRMark + "'"; // replace ' with '' to prevent access sql problems
            }
            else
                throw new Exception("control is not int/string/address");

            LOGGER.Logger.PrintLog(str);
            return str;
        }

        private void DataForm_KeyDown(object sender, KeyEventArgs e)
        {
            // error!
            try
            {
                if (e.KeyCode == Keys.Right)
                {
                    Next_BTN_Click(sender, (EventArgs)e);
                }
                if (e.KeyCode == Keys.Left)
                {
                    Back_BTN_Click(sender, (EventArgs)e);
                }
            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog("error in DataForm_KeyDown() func: " + ex.Message, Enums.LogType.Error);
            }
        }

        public virtual void EditMode()
        {
            this.First_BTN.Enabled = false;
            this.Last_BTN.Enabled = false;
            this.Next_BTN.Enabled = false;
            this.Back_BTN.Enabled = false;
            this.AddRecord_BTN.Enabled = false;
            this.Update_BTN.Enabled = false;
            this.Clear_BTN.Enabled = false;
            this.Save_BTN.Enabled = true;
            this.Cancel_BTN.Enabled = true;
            ChangeInputControlEnabled(true);
        }

        public virtual void ExitEditMode()
        {
            this.First_BTN.Enabled = true;
            this.Last_BTN.Enabled = true;
            this.Next_BTN.Enabled = true;
            this.Back_BTN.Enabled = true;
            this.AddRecord_BTN.Enabled = true;
            this.Update_BTN.Enabled = true;
            this.Clear_BTN.Enabled = true;
            this.Save_BTN.Enabled = false;
            this.Cancel_BTN.Enabled = false;
            DisplayRecords(IndexOfDataGridView);
            ChangeInputControlEnabled(false);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //protected void Display<ClassType>(object obj)
        //{
        //    if (obj == null)
        //    {
        //        LOGGER.Logger.PrintLog("error in display func (DataForm) : form is null");
        //        //throw new Exception("form is null in Display(DataForm)");
        //        return;
        //    }
        //    if(obj is ClassType)
        //    {
        //        ClassType ent = (ClassType)obj;
        //        int rowIndex = -1;

        //        DataGridViewRow row = dataGridView.Rows
        //            .Cast<DataGridViewRow>()
        //            .Where(r => r.Cells["StudentID"].Value.ToString().Equals(ent.PersonID))
        //            .First();

        //        rowIndex = row.Index;
        //        if (rowIndex != -1)
        //        {
        //            DisplayRecords(rowIndex);
        //        }
        //    }
        //}


    }
}
