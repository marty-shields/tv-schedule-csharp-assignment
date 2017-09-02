using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    /// <summary>
    /// allows to create object of horror to add a program or display horror
    /// will take properties from movie as well
    /// </summary>
    [Serializable]
    public class Horror : Movie
    {
        /// <summary>
        /// Created object of horror to be used
        /// takes properties for movie class as well
        /// </summary>
        /// <param name="title">title of horror film</param>
        /// <param name="description">description of horror film</param>
        /// <param name="mainActor">the main actor in the horror film</param>
        /// <param name="runTime">how long the horror film is on for</param>
        /// <param name="ageRating">age rating of horror film</param>
        /// <param name="releaseYear">when the film was released</param>
        /// <param name="horrorGenre">the type of horror the film is</param>
        public Horror(string id, string title, string description, string mainActor, int runTime, int ageRating, int releaseYear, string horrorGenre)
            : base (id, title, description, mainActor, runTime, ageRating, releaseYear)
        {
            this.horrorGenre = horrorGenre;
        }

        /// <summary>
        /// properties for horror
        /// </summary>
        private string horrorGenre;

        /// <summary>
        /// getting and setting genre
        /// </summary>
        public string HorrorGenre
        {
            get
            {
                return horrorGenre;
            }

            set
            {
                horrorGenre = value;
            }
        }


        public override string AddProgram()
        {
            base.AddProgram();

            return "Horror: " + this.Title;
        }

    }
}
