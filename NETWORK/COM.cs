using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdanLalezari326643269.NETWORK
{
    class COM
    {
        static public string SERVER_IP = "127.0.0.1";
        static public int SERVER_PORT = 7777;

        static public void SetValues(string ip, int port)
        {
            SERVER_IP = ip;
            SERVER_PORT = port;
        }

        public static string SendJSON(string json)
        {
            return Server.ReciveJSON(json);
        }

        public static string Send(string str)
        {

            return "ERROR!";
        }
    }
}
