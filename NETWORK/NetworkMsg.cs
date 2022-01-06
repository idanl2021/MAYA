using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using IdanLalezari326643269;
using Newtonsoft.Json;
//using System.Text.Json.Serialization;

namespace IdanLalezari326643269.NETWORK
{
    [Serializable]
    class NetworkMsg
    {
        //[JsonProperty("@msgCode")]
        public ENUM.Enums.MsgCode msgCode
        {
            get;
            set;           
        }

        //[JsonProperty("@msg")]
        public string msg { set; get; }

        /// <summary>
        /// Constructor of NetworkMsg
        /// </summary>
        /// <param name="msgCode">the type of the messege using ENUM.Enums.MsgCode</param>
        /// <param name="msg">a string representing the messege content in JSON</param>
        public NetworkMsg(ENUM.Enums.MsgCode msgCode, string msg = "")
        {
            this.msgCode = msgCode;
            this.msg = msg;
        }

        public NetworkMsg(ENUM.Enums.MsgCode msgCode = ENUM.Enums.MsgCode.Nothing, Dictionary<string, string> msgDict = null)
        {
            this.msgCode = msgCode;
            if(msgDict == null) {
                this.msg = "{}";
            }
            else
            {
                this.msg = "{";
                foreach (var item in msgDict)
                {
                    msg += @"""" + item.Key + @"""" + @":""" + item.Value + @""", ";
                }
                msg = msg.Remove(msg.Length - 2);
                this.msg += "}";
                LOGGER.Logger.PrintLog(msg);
            }
        }

        [JsonConstructor]
        public NetworkMsg(int code, string msg)
        {
            this.msgCode = (ENUM.Enums.MsgCode)code;
            this.msg = msg;
        }
    }
}
