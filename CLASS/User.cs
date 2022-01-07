using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS
{
    public class User
    {
        public User(string group = "",string id = "", string gender = "N")
        {
            ID = id;
            //Password = password;
            Group = group;
            Gender = gender;
        }

        public string ID { get; set; }
        //public string Password { get; set; }
        public string Group { get; set; }
        public string Gender { get; set; }


    }
}
