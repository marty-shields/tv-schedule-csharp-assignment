using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    /// <summary>
    /// abstract so can not call object but can store details in order for inherited classes can use
    /// </summary>
    [Serializable]
    public abstract class Movie : iRecordableItem
    {
        public Movie(string id, string title, string desciption, string mainActor, int runTime, int ageRating, int releaseYear)
        {
            this.id = id;
            this.title = title;
            this.description = desciption;
            this.mainActor = mainActor;
            this.runTime = runTime;
            this.ageRating = ageRating;
            this.releaseYear = releaseYear;
        }

        /// <summary>
        /// setting properties for movie
        /// </summary>
        private string id, title, description, mainActor;
        private int runTime, ageRating, releaseYear;

        /// <summary>
        /// getting and setting propetie - title
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        /// <summary>
        /// getting and setting propetie - description
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        /// <summary>
        /// getting and setting propetie - run time
        /// </summary>
        public int RunTime
        {
            get
            {
                return runTime;
            }

            set
            {
                runTime = value;
            }
        }

        /// <summary>
        /// getting and setting propetie - age rating
        /// </summary>
        public int AgeRating
        {
            get
            {
                return ageRating;
            }

            set
            {
                ageRating = value;
            }
        }

        /// <summary>
        /// getting and setting propetie - year of release
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return releaseYear;
            }

            set
            {
                releaseYear = value;
            }
        }

        /// <summary>
        /// getting and setting for movie main actor
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

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public virtual string AddProgram()
        {
            TVSchedule newShow = new TVSchedule();

            //checking to see if the id chosen is already in the recordable list, if it is then it wont be added
            foreach (iRecordableItem show in newShow.RecordableItems)
            {
                if (this.id == show.Id)
                {
                    IDAlreadyTakenException ex = new IDAlreadyTakenException();//exception thrown when the id is found in the recordable list
                    throw (ex);
                }
            }

            newShow.AddToDirectoryList(this);//this will add the show to the recordable list

            return "s";
        }
    }
}
