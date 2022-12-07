using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class ChangeStudentStatusRequest
    {
        public ChangeStudentStatusRequest(string ra)
        {
            this.Ra = ra;
        }

        [JsonProperty("ra")]
        public string Ra { get; set; }

    }
}
