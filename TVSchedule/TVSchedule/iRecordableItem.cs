using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    public interface iRecordableItem
    {
        string Id
        {
            get;
        }
        string Title
        {
            get;
        }
        int RunTime
        {
            get;
        }
        int AgeRating
        {
            get;
        }
        string Description
        {
            get;
        }

        string AddProgram();
    }
}
