using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdanLalezari326643269.UTILITIES;

namespace IdanLalezari326643269.CLASS
{
    class Assignment_Student
    {
        private int assignmentID;
        private string studentID;
        private int grade;

        public int AssignmentID { set => assignmentID = value; get => assignmentID; }
        public string StudentID
        {
            set
            {
                if (ValidationsUtilities.IsLegalId(value))
                    this.studentID = value;
                else
                    throw new Exception("תעודת זהות לא חוקית");
            }
            get
            {
                return this.studentID;
            }
        }
        public int Grade { set => grade = value; get => grade; }
    }
}
