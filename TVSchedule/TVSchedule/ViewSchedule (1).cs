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
    public partial class ViewSchedule : Form
    {
        TVSchedule scheduledList = new TVSchedule();
        private DataTable table = new DataTable();

        public ViewSchedule()
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

            foreach (iRecordableItem show in scheduledList.ScheduledItems)
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

            foreach (iRecordableItem show in scheduledList.ScheduledItems)
            {
                if (show is Episode)
                {
                    table.Rows.Add(show.Id, show.Title, show.RunTime.ToString(), show.AgeRating.ToString(), show.GetType().Name);
                }
            }

            //adding data table to data grid
            dgvScheduleList.DataSource = table;
        }

        private void btnRemoveFromSchedule_Click(object sender, EventArgs e)
        {
            //get ID
            if (dgvScheduleList.SelectedCells.Count != 0)
            {
                string selectedTitle = dgvScheduleList.CurrentRow.Cells["ID"].Value.ToString();

                scheduledList.RemoveFromSchedule(selectedTitle);
                MessageBox.Show("Show has been removed from schedule", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewAllShows();
            }
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

            foreach (iRecordableItem show in scheduledList.ScheduledItems)
            {
                table.Rows.Add(show.Id, show.Title, show.RunTime.ToString(), show.AgeRating.ToString(), show.GetType().Name);
            }

            //adding data table to data grid
            dgvScheduleList.DataSource = table;
        }

        //this reloads the data table in order to fill the data grid view up with all shows
        public void refreshList()
        {
            //move data from data file to tv schedule list
            scheduledList.LoadScheduleList();

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
