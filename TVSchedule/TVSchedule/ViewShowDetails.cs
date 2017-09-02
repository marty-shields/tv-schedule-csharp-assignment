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
    public partial class ViewShowDetails : Form
    {
        public ViewShowDetails()
        {
            InitializeComponent();

            //filling first 4 text boxes
            txtTitle.Text = ShowDetails.Title;
            txtDescription.Text = ShowDetails.Description;
            txtAgeRating.Text = ShowDetails.AgeRating.ToString();
            txtRunTime.Text = ShowDetails.RunTime.ToString();

            //filling rest of text boxes

            //drama
            if (ShowDetails is Drama)
            {
                //period drama
                if (ShowDetails is PeriodDrama)
                {
                    PeriodDrama pDrama = (PeriodDrama)ShowDetails;
                    txtOption1.Text = pDrama.MainActor;
                    lblOption1.Text = "Main Actor: ";
                    txtOption2.Text = pDrama.SupportingActor;
                    lblOption2.Text = "Supporting Actor: ";
                    txtOption3.Text = pDrama.PeriodDate.ToString();
                    lblOption3.Text = "Period Date: ";

                    //hide rest of boxes and labels
                    lblOption4.Visible = false;
                    txtOption4.Visible = false;
                }
                else
                {
                    Drama drama = (Drama)ShowDetails;
                    txtOption1.Text = drama.MainActor;
                    lblOption1.Text = "Main Actor: ";
                    txtOption2.Text = drama.SupportingActor;
                    lblOption2.Text = "Supporting Actor: ";

                    //hide rest of boxes and labels
                    txtOption3.Visible = false;
                    lblOption3.Visible = false;
                    lblOption4.Visible = false;
                    txtOption4.Visible = false;
                }
            }

            //comedy
            if (ShowDetails is Comedy)
            {
                Comedy comedy = (Comedy)ShowDetails;
                txtOption1.Text = comedy.MainActor;
                lblOption1.Text = "Main Actor: ";
                txtOption2.Text = comedy.ComdeyType;
                lblOption2.Text = "Comey Genre: ";

                //hide rest of boxes and labels
                txtOption3.Visible = false;
                lblOption3.Visible = false;
                lblOption4.Visible = false;
                txtOption4.Visible = false;
            }

            //documentary
            if (ShowDetails is Documentary)
            {
                Documentary doc = (Documentary)ShowDetails;
                txtOption1.Text = doc.Narrator;
                lblOption1.Text = "Narrator: ";
                txtOption2.Text = doc.DocumentaryType;
                lblOption2.Text = "Documentary Type: ";

                //hide rest of boxes and labels
                txtOption3.Visible = false;
                lblOption3.Visible = false;
                lblOption4.Visible = false;
                txtOption4.Visible = false;
            }
            //if its a movie fill 2 main text boxes
            if (ShowDetails is Movie)
            {
                Movie movie = (Movie)ShowDetails;
                txtOption1.Text = movie.ReleaseYear.ToString();
                lblOption1.Text = "Release Year: ";
                txtOption2.Text = movie.MainActor;
                lblOption2.Text = "Main Actor: ";

                //horror
                if (ShowDetails is Horror)
                {
                    Horror horror = (Horror)ShowDetails;
                    txtOption3.Text = horror.HorrorGenre;
                    lblOption3.Text = "Type Of Horror: ";

                    //hide rest of boxes and labels
                    lblOption4.Visible = false;
                    txtOption4.Visible = false;
                }
                //fantasy
                else
                {
                    Fantasy fant = (Fantasy)ShowDetails;
                    txtOption3.Text = fant.SupportingActor;
                    lblOption3.Text = "Supporting Actor: ";
                    txtOption4.Text = fant.FantasyType;
                    lblOption4.Text = "Fantasy Genre: ";
                }
            }
        }

        public static iRecordableItem ShowDetails
        {
            get;
            set;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
