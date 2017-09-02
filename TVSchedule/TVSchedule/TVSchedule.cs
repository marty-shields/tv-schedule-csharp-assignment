using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace TVSchedule
{
    public class TVSchedule
    {
        //saving and loading file data variables
        FileStream loadFile, saveFile;
        private string recordableFile = "showList.dat";
        private string scheduledFile = "scheduleList.dat";

        //lists for recordable programs and also programs which are scheduled
        private static List<iRecordableItem> recordableItems = new List<iRecordableItem>();

        private static List<iRecordableItem> scheduledItems = new List<iRecordableItem>();

        public List<iRecordableItem> RecordableItems
        {
            get
            {
                return recordableItems;
            }
        }

        public List<iRecordableItem> ScheduledItems
        {
            get
            {
                return scheduledItems;
            }
        }

        //takes the program data file and loads it into the recordableItems list
        public void LoadDirectoryList()
        {
            recordableItems.Clear();
            BinaryFormatter bFormat = new BinaryFormatter();
            loadFile = new FileStream(recordableFile, FileMode.Open, FileAccess.Read);
            recordableItems = (List<iRecordableItem>)bFormat.Deserialize(loadFile);
            loadFile.Close();
        }

        //takes the scheduled data file and loads it into the scheduledItems list
        public void LoadScheduleList()
        {
            scheduledItems.Clear();
            BinaryFormatter bFormat = new BinaryFormatter();
            loadFile = new FileStream(scheduledFile, FileMode.Open, FileAccess.Read);
            scheduledItems = (List<iRecordableItem>)bFormat.Deserialize(loadFile);
            loadFile.Close();
        }

        //takes the scheduled items and writes that to the data file
        public void WriteScheduleListToFile()
        {
            saveFile = new FileStream(scheduledFile, FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormat = new BinaryFormatter();
            bFormat.Serialize(saveFile, scheduledItems);
            saveFile.Close();
        }

        //takes the recordable items and writes that to the data file
        public void WriteDirectoryListToFile()
        {
            saveFile = new FileStream(recordableFile, FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormat = new BinaryFormatter();
            bFormat.Serialize(saveFile, recordableItems);
            saveFile.Close();
        }

        //function in order to take the selected program and remove it from the scheduled items list
        public void RemoveFromSchedule(string id)
        {
            foreach(iRecordableItem show in scheduledItems)
            {
                if (show.Id == id)
                {
                    scheduledItems.Remove(show);
                    WriteScheduleListToFile();
                    return;
                }
            }
        }

        //this will add teh show needing to be scheduled to the schedule list as long as it is not already scheduled
        public void ScheduleShow(string id)
        {
            //exception inplace if it is scheduled
            AlreadyScheduledException aException = new AlreadyScheduledException();

            foreach (iRecordableItem show in recordableItems)
            {
                if (show.Id == id)
                {
                    foreach (iRecordableItem scheduleShow in scheduledItems)
                    {
                        if (scheduleShow.Id == id)
                        {
                            throw (aException);
                        }
                    }
                    scheduledItems.Add(show);
                    WriteScheduleListToFile();
                    return;
                }
            }
        }

        //adding the new show to the recordable items list
        public void AddToDirectoryList(iRecordableItem show)
        {
            recordableItems.Add(show); //add show to show list

            WriteDirectoryListToFile();
        }
    }
}
