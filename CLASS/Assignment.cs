using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS
{
    class Assignment
    {
        static public string[] assignmentsTypes = new string[] {"test","assignment","homework"};

        private int assignmentID;
        private string type;
        private DateTime deadline;
        private int lessonID;

        public int AssignmentID { set => assignmentID = value; get => assignmentID; }
        public string Type
        {
            set
            {
                if (assignmentsTypes.Contains(value))
                    this.type = value;
                else
                    throw new Exception("סוג לא חוקי");
            }
            get
            {
                return this.type;
            }
        }
        public DateTime Deadline { set => deadline = value; get => deadline; }
        public int LessonID { set => lessonID = value; get => lessonID; }

    }
}
