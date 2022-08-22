using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class SetLockerIsRentedRequest
    {

        public int lockerNumber { get; set; }
        public int isRented { get; set; }

        public SetLockerIsRentedRequest(int lockerNumber, int isRented)
        {
            this.lockerNumber = lockerNumber;
            this.isRented = isRented;
        }

        public SetLockerIsRentedRequest()
        {

        }

    }
}
