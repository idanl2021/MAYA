using IdanLalezari326643269.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS{
    class Teacher : Person {
        private int schoolID;
        public Teacher(string ID, string firstName, string lastName, string address, string city, string birthDate, string phoneNumber, int schoolID)
            : base(ID, firstName, lastName, address, city, birthDate, phoneNumber)
        {

            this.schoolID = schoolID;
        }
        public int SchoolID { set => schoolID = value; get => schoolID; } // auto property
    }
}
