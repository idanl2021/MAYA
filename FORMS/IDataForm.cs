using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdanLalezari326643269.ENUM;

namespace IdanLalezari326643269.FORMS
{
    interface IDataForm
    {
        //Control[] GetInputControls();
        //Dictionary<Control, Enums.ControlType> GetTypeDict();
        //string Insert_sqlString();

        void LeaveKeyTextBox(object sender, EventArgs e);
        void Search();
        string CheckInput();

    }
}
