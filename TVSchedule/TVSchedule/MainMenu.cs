using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVSchedule
{
    public partial class MainMenu : Form
    {
        TVSchedule scheduledList = new TVSchedule();
        private DataTable table = new DataTable();

        public MainMenu()
        {
            InitializeComponent();
            refreshList();
        }

        //show both movies and tv shows scheduled
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewAllShows();
        }

        //view only movies which are scheduled
        private void btnViewMovies_Click(object sender, EventArgs e)
        {
            //clearing data grid view and data table
            table.Clear();

            foreach (iRecordableItem show in scheduledList.RecordableItems)
            {
                if (show is Movie)
                {
                    table.Rows.Add(show.Id, show.Title, show.RunTime.ToString(), show.AgeRating.ToString(), show.GetType().Name);
                }
            }

            //adding data table to data grid
            dgvScheduleList.DataSource = table;
        }

        //view only TV shows which are scheduled
        private void btnViewTV_Click(object sender, EventArgs e)
        {
            //clearing data grid view and data table
            table.Clear();

            foreach (iRecordableItem show in scheduledList.RecordableItems)
            {
                if (show is Episode)
                {
                    table.Rows.Add(show.Id, show.Title, show.RunTime.ToString(), show.AgeRating.ToString(), show.GetType().Name);
                }
            }

            //adding data table to data grid
            dgvScheduleList.DataSource = table;
        }

        //show the particular details for the program you have selected
        private void btnViewShowDetails_Click(object sender, EventArgs e)
        {
            //get correct show and save in order to show details up
            string id = dgvScheduleList.CurrentRow.Cells["ID"].Value.ToString();

            foreach(iRecordableItem show in scheduledList.RecordableItems)
            {
                if (show.Id == id)
                {
                    ViewShowDetails.ShowDetails = show;
                }
            }

            //set up new form
            ViewShowDetails newForm = new ViewShowDetails();
            newForm.FormClosed += new FormClosedEventHandler(NewFormIsClosed);
            this.Hide();
            newForm.Show();
        }

        //this function will try to save selected show to the schedule list
        private void btnScheduleShow_Click(object sender, EventArgs e)
        {
            try
            {
                //get correct show and save in order to show details up
                string id = dgvScheduleList.CurrentRow.Cells["ID"].Value.ToString();

                //trying to schedule program as long as its not already scheduled
                scheduledList.ScheduleShow(id);

                MessageBox.Show("Program has been added to schedule.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //catch if the selected show is already scheduled
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddShow_Click(object sender, EventArgs e)
        {
            AddShow newForm = new AddShow();
            newForm.FormClosed += new FormClosedEventHandler(NewFormIsClosed);
            this.Hide();
            newForm.Show();
        }

        //loads up a new form to show up the scheduled form
        private void btnViewScheduled_Click(object sender, EventArgs e)
        {
            ViewSchedule newForm = new ViewSchedule();
            newForm.FormClosed += new FormClosedEventHandler(NewFormIsClosed);
            this.Hide();
            newForm.Show();
        }

        //added event handler to reload the original form when coming back to the main menu
        public void NewFormIsClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            ViewAllShows();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //function to view all the shows into the datagrid
        private void ViewAllShows()
        {
            //clearing data grid view and data table
            table.Clear();

            foreach (iRecordableItem show in scheduledList.RecordableItems)
            {
                table.Rows.Add(show.Id, show.Title, show.RunTime.ToString(), show.AgeRating.ToString(), show.GetType().Name);
            }

            //adding data table to data grid
            dgvScheduleList.DataSource = table;
        }

        //refereshes the list and clears the sata grid to show all programs
        public void refreshList()
        {
            //move data from data file to tv schedule list
            scheduledList.LoadDirectoryList();

            //adding columns for data table
            table.Columns.Add("ID");
            table.Columns.Add("Title");
            table.Columns.Add("Run Time");
            table.Columns.Add("Age Rating");
            table.Columns.Add("Genre");

            //picking out each show in the list and adding to the data table
            ViewAllShows();

            //setting column widths
            dgvScheduleList.Columns[0].Width = 77;
            dgvScheduleList.Columns[1].Width = 289;
            dgvScheduleList.Columns[2].Width = 77;
            dgvScheduleList.Columns[3].Width = 83;
            dgvScheduleList.AllowUserToOrderColumns = false;
            dgvScheduleList.AllowUserToResizeColumns = false;
            dgvScheduleList.AllowUserToResizeRows = false;
        }

    }
}
