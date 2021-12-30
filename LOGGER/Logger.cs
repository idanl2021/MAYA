using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdanLalezari326643269.ENUM;

namespace IdanLalezari326643269.LOGGER
{
    public class Logger
    {
        static public void PrintLog(string msg, Enums.LogType logType = Enums.LogType.Normal)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}
