using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    /// <summary>
    /// allows to add a new documentary object in order to add a documentary episode to the list
    /// can also show the documentary object as well
    /// </summary>
    [Serializable]
    public class Documentary : Episode
    {
        /// <summary>
        /// contructor for a new documentary object
        /// takes in episodes properties as well
        /// </summary>
        /// <param name="title">title of documentary</param>
        /// <param name="desc">description of documentary</param>
        /// <param name="runTime">how long the documentary episode is</param>
        /// <param name="ageRating">age rating of documentary</param>
        /// <param name="docType">what genre of documentary it is</param>
        /// <param name="narr">the narrator of the documentary</param>
        public Documentary(string id, string title, string desc, int runTime, int ageRating, string documentaryType, string narrator)
            : base(id, title, desc, runTime, ageRating)
        {
            this.documentaryType = documentaryType;
            this.narrator = narrator;
        }

        /// <summary>
        /// properties for type of documentary and the narrator
        /// </summary>
        private string documentaryType, narrator;

        /// <summary>
        /// getter and setter for type of documentary
        /// </summary>
        public string DocumentaryType
        {
            get
            {
                return documentaryType;
            }

            set
            {
                documentaryType = value;
            }
        }

        /// <summary>
        /// getter and setter for the narrator
        /// </summary>
        public string Narrator
        {
            get
            {
                return narrator;
            }

            set
            {
                narrator = value;
            }
        }

        public override string AddProgram()
        {
            base.AddProgram();

            return "Documentary: " + this.Title;
        }

    }
}
