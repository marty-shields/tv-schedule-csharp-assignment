using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    /// <summary>
    /// allows user to set fantasy object in order to add a fantasy film or display on form
    /// </summary>
    [Serializable]
    public class Fantasy : Movie
    {
        /// <summary>
        /// constructor set in order to set properties for fantasy film
        /// also contrains properties for movie
        /// </summary>
        /// <param name="title">title of film</param>
        /// <param name="description">film description</param>
        /// <param name="mainActor">main actor of film</param>
        /// <param name="runTime">how long film is on for</param>
        /// <param name="ageRating">age rating of film</param>
        /// <param name="releaseYear">what year the film was released</param>
        /// <param name="supportingActor">supporting actior of film</param>
        /// <param name="fantasyType">type of fantasy film it is</param>
        public Fantasy(string id, string title, string description, string mainActor, int runTime, int ageRating, int releaseYear, string supportingActor, string fantasyType)
            : base (id, title, description, mainActor, runTime, ageRating, releaseYear)
        {
            this.supportingActor = supportingActor;
            this.fantasyType = fantasyType;
        }

        /// <summary>
        /// properties set for fantasy movie
        /// </summary>
        string supportingActor, fantasyType;

        /// <summary>
        /// getter and setting for supporting actor in film
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

        /// <summary>
        /// getter and setter for the type of fantasy film it is
        /// </summary>
        public string FantasyType
        {
            get
            {
                return fantasyType;
            }

            set
            {
                fantasyType = value;
            }
        }

        public override string AddProgram()
        {
            base.AddProgram();

            return "Fantasy: " + this.Title;
        }
    }
}
