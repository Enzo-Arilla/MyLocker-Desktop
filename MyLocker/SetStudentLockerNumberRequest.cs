using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class SetStudentLockerNumberRequest
    {

        public SetStudentLockerNumberRequest(string ra, int lockerNumber)
        {
            this.Ra = ra;
            this.LockerNumber = lockerNumber;
        }

        public SetStudentLockerNumberRequest()
        {

        }

        [JsonProperty("ra")]
        public string Ra { get; set; }

        [JsonProperty("lockerNumber")]
        public int LockerNumber { get; set; }
    }
}
