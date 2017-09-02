using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    public class FieldEmptyException : Exception
    {
        //customized string if all fields have no got data in it
        private static string msg = "Please fill in all fields";

        //throws exception here
        public FieldEmptyException()
            : base(msg)
        { }
    }
}
