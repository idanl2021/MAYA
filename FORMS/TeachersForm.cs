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

        public string CheckInput()
        {
            throw new NotImplementedException();
        }

        public void LeaveKeyTextBox(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
