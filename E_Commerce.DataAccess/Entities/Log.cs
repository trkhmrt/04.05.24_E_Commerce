using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class Log
    {
        public int logId { get; set; }

        public string logDescription { get; set; }

        public string requestPath { get; set; }
        public DateTime createDate { get; set; }
        public int logType { get; set; }

    }
}
