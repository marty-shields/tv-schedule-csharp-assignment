using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    /// <summary>
    /// allows the user to add a drama to the system
    /// and also display the episodes which are dramas
    /// </summary>
    [Serializable]
    public class Drama : Episode
    {
        /// <summary>
        /// constructor to add a drama object onto program if adding a drama episode
        /// will also take in episode properties
        /// </summary>
        /// <param name="title">title of drama</param>
        /// <param name="desc">description of drama</param>
        /// <param name="runTime">how long the drama is on</param>
        /// <param name="ageRating">age rating of drama</param>
        /// <param name="mActor">main actor in the drama</param>
        /// <param name="sActor">supporting actor of drama</param>
        public Drama(string id, string title, string desc, int runTime, int ageRating, string mainActor, string supportingActor)
            : base(id, title, desc, runTime, ageRating)
        {
            this.mainActor = mainActor;
            this.supportingActor = supportingActor;
        }

        /// <summary>
        /// properties for drama consisting of a main and supporting actor
        /// </summary>
        private string mainActor, supportingActor;

        /// <summary>
        /// getter and setter for main actor
        /// </summary>
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

        /// <summary>
        /// getter and setter for supporting actor
        /// </summary>
        public string SupportingActor
        {
            get
            {
                return supportingActor;
            }

            set
            {
                supportingActor = value;
            }
        }

        public override string AddProgram()
        {
            base.AddProgram();

            return "Drama: " + this.Title;
        }

    }
}
