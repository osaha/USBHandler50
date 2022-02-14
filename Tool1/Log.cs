using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool1
{
    public class Log
    {
        public string Date { get; set; }
        public string Guid { get; set; }
        public string User { get; set; }

        public Log(string date, string guid, string user)
        {
            Date = date;
            Guid = guid;
            User = user;
        }
    }
}
