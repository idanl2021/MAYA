using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS
{
    class SharedObject
    {
        static public object obj;
        static public string typeOfObj;

        public SharedObject(object o = null, string type = "")
        {
            obj = o;
            typeOfObj = type;
        }

        public static void ChangeObj(object o = null, string type = "")
        {
            obj = o;
            typeOfObj = type;
        }
    }
}
