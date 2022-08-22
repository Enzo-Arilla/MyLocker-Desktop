using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public class SetStudentLockerNumberRequest
    {

        public string ra;
        public int lockerNumber;

        public SetStudentLockerNumberRequest(string ra, int lockerNumber)
        {
            this.ra = ra;
            this.lockerNumber = lockerNumber;
        }

        public SetStudentLockerNumberRequest()
        {

        }
    }
}
