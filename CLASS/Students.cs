using IdanLalezari326643269.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.CLASS {
    class Students : Person {
        private int classID;
        public int ClassID { set => classID = value; get => classID; } // auto property
    }
}
