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

        //a function that insert a new row to the table in the access database 
        public static DataTable InsertRow(string sqlstr, Dictionary<string, string> dict)
        {
            try
            {
                NetworkMsg nm = new NetworkMsg(ENUM.Enums.MsgCode.InsertRow, dict);
                return JsonConvert.DeserializeObject<DataTable>(
                    COM.SendJSON(
                        JsonConvert.SerializeObject(nm)
                        )
                    );
            }
            catch (Exception ex)
            {
                LOGGER.Logger.PrintLog(ex.Message, ENUM.Enums.LogType.Error);
                return new DataTable();
            }

        }

        //a function that update a row in the table in the access database
        public static DataTable UpdateRow(string sqlstr, Dictionary<string, string> dict)
        {
            NetworkMsg nm = new NetworkMsg(ENUM.Enums.MsgCode.UpdateRow, dict);
            return JsonConvert.DeserializeObject<DataTable>(
                COM.SendJSON(
                    JsonConvert.SerializeObject(nm)
                    )
                );
        }

        
    }
}
