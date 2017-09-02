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
    public partial class AddShow : Form
    {
        public AddShow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //when adding the show to the database
        private void btnAddShow_Click(object sender, EventArgs e)
        {
            //exception ready
            FieldEmptyException emptyField = new FieldEmptyException();
            try
            {
                string returnMessage = "A new movie has been added.\nDetails: \n";

                //make sure none of the text boxes are empty first
                if (txtID.Text == "" || txtTitle.Text == "" || txtAgeRating.Text == "" || txtDescription.Text == "" || txtRunTime.Text == "")
                {
                    throw (emptyField);
                }

                //check for each of the genres for episode
                if (rdoEpisode.Checked)
                {
                    if (txtOption1.Text == "" || txtOption2.Text == "")
                    {
                        throw (emptyField);
                    }
                    if (rdoOption4.Checked)
                    {
                        if (txtOption3.Text == "")
                        {
                            throw (emptyField);
                        }
                    }
                }

                //check for each genre of movie
                if (rdoMovie.Checked)
                {
                    if (txtOption1.Text == "" || txtOption2.Text == "" || txtOption3.Text == "")
                    {
                        throw (emptyField);
                    }
                    if (rdoOption2.Checked)
                    {
                        if (txtOption4.Text == "")
                        {
                            throw (emptyField);
                        }
                    }
                }

                //make sure the format of each text box is correct
                string id = txtID.Text;
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                int runTime = Convert.ToInt32(txtRunTime.Text);
                int ageRating = Convert.ToInt32(txtAgeRating.Text);

                //if the show is an episode check boxes
                if (rdoEpisode.Checked)
                {
                    string option1 = txtOption1.Text;
                    string option2 = txtOption2.Text;

                    if (rdoOption1.Checked)//creating drama show
                    {
                        Drama newShow = new Drama(id, title, description, runTime, ageRating, option1, option2);
                        returnMessage += newShow.AddProgram();
                    }

                    if (rdoOption2.Checked)//creating comedy show
                    {
                        Comedy newShow = new Comedy(id, title, description, runTime, ageRating, option1, option2);
                        returnMessage += newShow.AddProgram();
                    }

                    if (rdoOption3.Checked) //creating documentary
                    {
                        Documentary newShow = new Documentary(id, title, description, runTime, ageRating, option1, option2);
                        returnMessage += newShow.AddProgram();
                    }

                    if (rdoOption4.Checked) //if period drama selected
                    {
                        int iOption1 = Convert.ToInt32(txtOption3.Text);

                        PeriodDrama newShow = new PeriodDrama(id, title, description, runTime, ageRating, option1, option2, iOption1);
                        returnMessage += newShow.AddProgram();
                    }
                }

                //if movie is selected check boxes
                if(rdoMovie.Checked)
                {
                    int iOption1 = Convert.ToInt32(txtOption1.Text);
                    string option1 = txtOption2.Text;
                    string option2 = txtOption3.Text;

                    if (rdoOption1.Checked) //creating horror
                    {
                        Horror newShow = new Horror(id, title, description, option1, runTime, ageRating, iOption1, option2);
                        returnMessage += newShow.AddProgram();
                    }

                    if (rdoOption2.Checked)//if fant is selected
                    {
                        string option3 = txtOption4.Text;

                        Fantasy newShow = new Fantasy(id, title, description, option1, runTime, ageRating, iOption1, option2, option3);
                        returnMessage += newShow.AddProgram();
                    }
                }

                //successs box
                MessageBox.Show(returnMessage, "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);

                //resetting the system
                rdoHidden1.Checked = true;
            }
            catch(FormatException fe) //if the format is incorrect
            {
                MessageBox.Show(fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) //if anything else is picked up
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //set instructions for when episode is selected
        private void rdoEpisode_CheckedChanged(object sender, EventArgs e)
        {
            HideInputFields();

            if (rdoEpisode.Checked)
            {
                //show and hide correct radio buttons and select names
                rdoOption1.Text = "Drama";
                rdoOption2.Text = "Comedy";
                rdoOption3.Text = "Documentary";
                rdoOption4.Text = "Period Drama";
                btnAddShow.Text = "Add Episode";

                rdoOption1.Visible = true;
                rdoOption2.Visible = true;
                rdoOption3.Visible = true;
                rdoOption4.Visible = true;

                //select hidden radio button
                rdoHidden2.Checked = true;
            }
        }
        
        //set instructions for when movie is selected
        private void rdoMovie_CheckedChanged(object sender, EventArgs e)
        {
            HideInputFields();

            if (rdoMovie.Checked)
            {
                //show and hide correct radio buttons and select names
                rdoOption1.Text = "Horror";
                rdoOption2.Text = "Fantasy";
                btnAddShow.Text = "Add Movie";

                rdoOption1.Visible = true;
                rdoOption2.Visible = true;
                rdoOption3.Visible = false;
                rdoOption4.Visible = false;

                rdoHidden2.Checked = true;
            }
        }

        //set instructions when hidden is selected
        private void rdoHidden1_CheckedChanged(object sender, EventArgs e)
        {
            HideInputFields();

            if (rdoHidden1.Checked)
            {
                //show and hide correct radio buttons
                rdoOption1.Visible = false;
                rdoOption2.Visible = false;
                rdoOption3.Visible = false;
                rdoOption4.Visible = false;

                rdoHidden2.Checked = true;
            }
        }

        //function for when first genre is selected
        private void rdoOption1_CheckedChanged(object sender, EventArgs e)
        {
            ShowDefaultFields();

            if (rdoOption1.Text == "Drama") //if its drama
            {
                //hide unrelivent label and text boxes
                lblOption1.Visible = true;
                lblOption2.Visible = true;
                lblOption3.Visible = false;
                lblOption4.Visible = false;
                txtOption1.Visible = true;
                txtOption2.Visible = true;
                txtOption3.Visible = false;
                txtOption4.Visible = false;

                //rename boxes
                lblOption1.Text = "Main Actor:";
                lblOption2.Text = "Supporting Actor:";
            }
            else // it is horror
            {
                MovieDefaultFields();

                //hide unrelivent label and text boxes
                lblOption3.Visible = true;
                lblOption4.Visible = false;
                txtOption3.Visible = true;
                txtOption4.Visible = false;

                //rename boxes
                lblOption3.Text = "Type of Horror:";
            }
        }

        //when 2nd genre is selected
        private void rdoOption2_CheckedChanged(object sender, EventArgs e)
        {
            ShowDefaultFields();

            if (rdoOption1.Text == "Comedy") //if its drama
            {
                //hide unrelivent label and text boxes
                lblOption1.Visible = true;
                lblOption2.Visible = true;
                lblOption3.Visible = false;
                lblOption4.Visible = false;
                txtOption1.Visible = true;
                txtOption2.Visible = true;
                txtOption3.Visible = false;
                txtOption4.Visible = false;

                //rename boxes
                lblOption1.Text = "Main Actor:";
                lblOption2.Text = "Type of Comedy:";
            }
            else // it is horror
            {
                MovieDefaultFields();

                //hide unrelivent label and text boxes
                lblOption3.Visible = true;
                lblOption4.Visible = true;
                txtOption3.Visible = true;
                txtOption4.Visible = true;

                //rename boxes
                lblOption3.Text = "Supporting Actor:";
                lblOption4.Text = "Fantasy Type:";
            }
        }

        //when 3rd genre is selected
        private void rdoOption3_CheckedChanged(object sender, EventArgs e)
        {
            ShowDefaultFields();

            //hide unrelivent label and text boxes
            lblOption1.Visible = true;
            lblOption2.Visible = true;
            lblOption3.Visible = false;
            lblOption4.Visible = false;
            txtOption1.Visible = true;
            txtOption2.Visible = true;
            txtOption3.Visible = false;
            txtOption4.Visible = false;

            //rename boxes
            lblOption1.Text = "Narrator:";
            lblOption2.Text = "Documentary Type:";
        }

        //when 4th genre is selected
        private void rdoOption4_CheckedChanged(object sender, EventArgs e)
        {
            ShowDefaultFields();

            //hide unrelivent label and text boxes
            lblOption1.Visible = true;
            lblOption2.Visible = true;
            lblOption3.Visible = true;
            lblOption4.Visible = false;
            txtOption1.Visible = true;
            txtOption2.Visible = true;
            txtOption3.Visible = true;
            txtOption4.Visible = false;

            //rename boxes
            lblOption1.Text = "Main Actor:";
            lblOption2.Text = "Supporting Actor:";
            lblOption3.Text = "Period Date:";
        }

        //when hidden one is checked
        private void rdoHidden2_CheckedChanged(object sender, EventArgs e)
        {
            HideInputFields();
        }

        //hide all the fields that require user input
        public void HideInputFields()
        {
            //hiding labels
            lblID.Visible = false;
            lblTitle.Visible = false;
            lblRunTime.Visible = false;
            lblOption4.Visible = false;
            lblOption3.Visible = false;
            lblOption2.Visible = false;
            lblOption1.Visible = false;
            lblDescription.Visible = false;
            lblAgeRating.Visible = false;

            //hiding text boxes
            txtID.Visible = false;
            txtAgeRating.Visible = false;
            txtDescription.Visible = false;
            txtOption1.Visible = false;
            txtOption2.Visible = false;
            txtOption3.Visible = false;
            txtOption4.Visible = false;
            txtRunTime.Visible = false;
            txtTitle.Visible = false;

            //hide button
            btnAddShow.Visible = false;
        }

        //show the default fields
        public void ShowDefaultFields()
        {
            //show default labels
            lblID.Visible = true;
            lblTitle.Visible = true;
            lblRunTime.Visible = true;
            lblAgeRating.Visible = true;
            lblDescription.Visible = true;

            //show default text boxes
            txtID.Visible = true;
            txtAgeRating.Visible = true;
            txtDescription.Visible = true;
            txtRunTime.Visible = true;
            txtTitle.Visible = true;

            //button visible
            btnAddShow.Visible = true;
        }

        //showing the defaults for movies
        public void MovieDefaultFields()
        {
            lblOption1.Visible = true;
            lblOption2.Visible = true;
            txtOption1.Visible = true;
            txtOption2.Visible = true;

            lblOption1.Text = "Release Year:";
            lblOption2.Text = "Main Actor:";
        }
    }
}
