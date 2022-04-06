using IdanLalezari326643269.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS {
    class Student : Person {
        private string className;

        public Student(string ID, string firstName, string lastName, string address, string city, string birthDate, string phoneNumber, string className) 
            : base(ID,firstName,lastName,address,city,birthDate, phoneNumber)
        {
            
            this.className = className;
        }

        public string ClassID { set => className = value; get => className; } // auto property
    }
}
