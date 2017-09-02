using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    public class AlreadyScheduledException : Exception
    {
        //customized string if all fields have no got data in it
        private static string msg = "Selected program is already scheduled. Please choose another program";

        //throws exception here
        public AlreadyScheduledException()
            : base(msg)
        { }
    }
}
