using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class EmptyLockerRequest
    {

        public EmptyLockerRequest(string ra)
        {
            this.Ra = ra;
        }

        public EmptyLockerRequest()
        {

        }

        [JsonProperty("ra")]
        public string Ra { get; set; }
    }
}
