using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    /// <summary>
    /// allows the user to add a comedy to the system
    /// and also display the episodes which are comdy
    /// </summary>
    [Serializable]
    public class Comedy : Episode
    {
        /// <summary>
        /// contructor to create a new type of comedy
        /// Will take in parameters of episode plus it's own
        /// </summary>
        /// <param name="title">title of comedy</param>
        /// <param name="desc">comedy description</param>
        /// <param name="runTime">how long the episode is on for</param>
        /// <param name="ageRating">age rating of comedy</param>
        /// <param name="actor">main actor that is in the comedy</param>
        /// <param name="comType">the type of comedy it is</param>
        public Comedy(string id, string title, string desc, int runTime, int ageRating, string mainActor, string comedyType)
            : base (id, title, desc, runTime, ageRating)
        {
            //to add values to the main actor and type of comedy
            this.mainActor = mainActor;
            this.comdeyType = comedyType;
        }

        /// <summary>
        /// propeties for the main actor in the comedy and the type of comedy it is
        /// </summary>
        private string mainActor, comdeyType;

        public string MainActor
        {
            get
            {
                return mainActor;
            }

            set
            {
                mainActor = value;
            }
        }

        public string ComdeyType
        {
            get
            {
                return comdeyType;
            }

            set
            {
                comdeyType = value;
            }
        }

        public override string AddProgram()
        {
            base.AddProgram();

            return "Comedy: " + this.Title;
        }

    }
}
