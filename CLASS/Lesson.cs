using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS
{
    class Lesson
    {
        private int lessonID;
        private string lessonName;
        private string teacherID;
        public int LessonID { get => lessonID; set => lessonID = value; }
        public string LessonName { get => lessonName; set => lessonName = value; }
        public string TeacherID { get => teacherID; set => teacherID = value; }
    }
}
