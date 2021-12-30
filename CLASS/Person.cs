using IdanLalezari326643269.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS
{
    class Person
    {
        private string studentID;
        private string firstName;
        private string lastName;
        private string address;
        //private string adress;
        private string city;
        private DateTime birthDate;
        private string phoneNumber;

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
        public string FirstName
        {
            set
            {
                if (ValidationsUtilities.IsLegalName(value))
                    this.firstName = value;
                else
                    throw new Exception("שם פרטי לא חוקי");
            }
            get
            {
                return this.firstName;
            }
        }
        public string LastName
        {
            set
            {
                if (ValidationsUtilities.IsLegalName(value))
                    this.lastName = value;
                else
                    throw new Exception("שם משפחה לא חוקי");
            }
            get
            {
                return this.lastName;
            }
        }


        public string Address { set => address = value; get => address; } // auto property
        public string City { set => city = value; get => city; }

        public DateTime BirthDate
        {
            set
            {
                if (value.Year >= 1900 && value.Year <= DateTime.Now.Year)
                {
                    this.birthDate = value;
                }
                else
                    throw new Exception("תאריך לא חוקי");
            }
            get
            {
                return this.birthDate;
            }
        }

        public string PhoneNumber { set => phoneNumber = value; get => phoneNumber; }
    }
}
