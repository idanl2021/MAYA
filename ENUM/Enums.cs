using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.ENUM
{
    public class Enums
    {
        public enum ControlType
        {
            @int,
            @string,
            address
        }

        public enum ControlNameOrder
        {
            SqlColumnName,
            isInput,
            controlType,
            order
        }

        public enum LogType
        {
            Normal,
            Error
        }

        [Serializable]
        public enum MsgCode
        {
            Nothing,
            OpenTableSelectAllFrom,
            SendSQLquery,
            IsUser,
            Login
        }

        public enum UserGroup
        {
            Principal,
            Teacher, 
            Student
        }

    }
}
