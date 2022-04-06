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
        private string ID;
        private string firstName;
        private string lastName;
        private string address;
        //private string adress;
        private string city;
        private string birthDate;
        private string phoneNumber;

        public Person(string ID, string firstName, string lastName, string address, string city, string birthDate, string phoneNumber)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
        }

        public string PersonID
        {
            set
            {
                if (ValidationsUtilities.IsLegalId(value))
                    this.ID = value;
                else
                    throw new Exception("תעודת זהות לא חוקית");
            }
            get
            {
                return this.ID;
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

        public string BirthDate
        {
            set
            {
                //if (value.Year >= 1900 && value.Year <= DateTime.Now.Year)
                //{
                //    this.birthDate = value;
                //}
                //else
                //    throw new Exception("תאריך לא חוקי");
            }
            get
            {
                return this.birthDate;
            }
        }

        public string PhoneNumber { set => phoneNumber = value; get => phoneNumber; }
    }
}
