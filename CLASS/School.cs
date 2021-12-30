using IdanLalezari326643269.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS
{
    class School
    {
        private int schoolID;
        private string address;
        private string city;
        private string schoolName;
        private string pricipalID;
        private string pFirstName;
        private string pLastName;

        public string PrincipalID
        {
            set
            {
                if (ValidationsUtilities.IsLegalId(value))
                    this.pricipalID = value;
                else
                    throw new Exception("תעודת זהות לא חוקית");
            }
            get
            {
                return this.pricipalID;
            }
        }

        public int SchoolID { get => schoolID; set => schoolID = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string SchoolName { get => schoolName; set => schoolName = value; }
        public string PFirstName { get => pFirstName; set => pFirstName = value; }
        public string PLastName { get => pLastName; set => pLastName = value; }
    }
}
