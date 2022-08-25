using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class SetLockerIsRentedRequest
    {

        public SetLockerIsRentedRequest(int lockerNumber, int isRented)
        {
            this.LockerNumber = lockerNumber;
            this.IsRented = isRented;
        }

        public SetLockerIsRentedRequest()
        {

        }

        [JsonProperty("isRented")]
        public int IsRented { get; set; }

        [JsonProperty("lockerNumber")]
        public int LockerNumber { get; set; }

    }
}
