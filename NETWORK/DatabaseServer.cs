using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Newtonsoft.Json;

using IdanLalezari326643269;

namespace IdanLalezari326643269.NETWORK
{
    class DatabaseServer
    {
        public static DataTable OpenTable_SelectAllFrom(string sqlstr)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("TableName", sqlstr);
            NetworkMsg nm = new NetworkMsg(ENUM.Enums.MsgCode.OpenTableSelectAllFrom, dict);

            //JsonConvert.SerializeObject(nm);

            return JsonConvert.DeserializeObject<DataTable>(
                COM.SendJSON(
                    JsonConvert.SerializeObject(nm)
                    )
                );
        }

        
    }
}
