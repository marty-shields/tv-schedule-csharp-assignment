using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    /// <summary>
    /// adds a period drama as an object which will allow user to add a drama episode to the program
    /// also can display drama episode on form
    /// </summary>
    [Serializable]
    public class PeriodDrama : Drama
    {
        /// <summary>
        /// Constructor to add new drama as an object
        /// Will take in episode's and drama's parameters as well as own
        /// </summary>
        /// <param name="title">title of drama</param>
        /// <param name="desc">drama description</param>
        /// <param name="runTime">how long the drama is on for</param>
        /// <param name="ageRating">age rating for drama</param>
        /// <param name="periodDate">period date of drama</param>
        public PeriodDrama(string id, string title, string desc, int runTime, int ageRating, string mainActor, string supportingActor, int periodDate)
            : base(id, title, desc, runTime, ageRating, mainActor, supportingActor)
        {
           this.periodDate = periodDate;
        }

        /// <summary>
        /// propety for the date the drama was in if it is a period drama
        /// </summary>
        private int periodDate;

        /// <summary>
        /// getter and setter for period date propety
        /// </summary>
        public int PeriodDate
        {
            get
            {
                return periodDate;
            }

            set
            {
                periodDate = value;
            }
        }

        public override string AddProgram()
        {
            base.AddProgram();

            return "Period Drama: " + this.Title;
        }

    }
}
