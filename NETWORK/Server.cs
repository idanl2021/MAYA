using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace IdanLalezari326643269.NETWORK
{
    class Server
    {
        static public string Receive(string str)
        {
            return str;
        }

        static public string ReciveJSON(string json)
        {
            NetworkMsg nm = JsonConvert.DeserializeObject<NetworkMsg>(json);
            switch (nm.msgCode)
            {
                case ENUM.Enums.MsgCode.Nothing:
                    break;
                case ENUM.Enums.MsgCode.OpenTableSelectAllFrom:
                    var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(nm.msg);
                    return JsonConvert.SerializeObject(
                        DATA.DAL.OpenTable(values["TableName"]) //DataTable object
                        );
                case ENUM.Enums.MsgCode.SendSQLquery:
                    break;
                case ENUM.Enums.MsgCode.IsUser:
                    break;
                case ENUM.Enums.MsgCode.Login:
                    break;
                case ENUM.Enums.MsgCode.InsertRow:
                    // given a json, deserialize it to a dictionary and insert the row to the table in the access database 
                    var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(nm.msg);
                    DATA.DAL.InsertRow(dict["TableName"], dict);
                    break;
                default:
                    break;
            }
            return "{}";

        }
    }
}
