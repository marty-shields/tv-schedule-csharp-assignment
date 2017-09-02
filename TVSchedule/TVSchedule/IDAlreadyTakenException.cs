using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    public class IDAlreadyTakenException : Exception
    {
        //customized string if all fields have no got data in it
        private static string msg = "Selected ID is already taken. Please choose another ID";

        //throws exception here
        public IDAlreadyTakenException()
            : base(msg)
        { }
    }
}
