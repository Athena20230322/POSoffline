using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPLib.POCO
{
    public class PosResponse
    {
        public string  StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string EncData { get; set; }
    }
}
