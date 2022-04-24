using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public struct Result
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsOk { get; set; }
        public object Data { get; set; }    
    }
}
