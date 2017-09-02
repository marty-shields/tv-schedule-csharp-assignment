using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSchedule
{
    /// <summary>
    /// Episide class which is a parent abstrat class of other episodes
    /// Will allow user to add classes to the program
    /// </summary>
    /// 
    [Serializable]
    public abstract class Episode : iRecordableItem
    {
        /// <summary>
        /// Constructor in order to create new episode object from the inherited classes
        /// </summary>
        /// <param name="title">title of episode</param>
        /// <param name="description">episode description</param>
        /// <param name="runTime">how long the episode is in minuites</param>
        /// <param name="ageRating">age rating of episode</param>
        public Episode(string id, string title, string description, int runTime, int ageRating)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.runTime = runTime;
            this.ageRating = ageRating;
        }

        /// <summary>
        /// setting properties
        /// </summary>
        private string id, title, description;
        private int runTime, ageRating;

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

        //adding the new show to the recordable items list
        public virtual string AddProgram()
        {
            TVSchedule newShow = new TVSchedule();

            //checking to see if the id chosen is already in the recordable list, if it is then it wont be added
            foreach (iRecordableItem show in newShow.RecordableItems)
            {
                if (show.Id == this.id)
                {
                    IDAlreadyTakenException ex = new IDAlreadyTakenException(); //exception thrown when the id is found in the recordable list
                    throw (ex);
                }
            }

            newShow.AddToDirectoryList(this); //this will add the show to the recordable list

            return "s";
        }

    }
}
