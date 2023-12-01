using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Software_Engineering_Project_New.Controllers.SoftwareSalesman
{
    public partial class SoftwareViewer : Form
    {

        public SoftwareViewer()
        {
            InitializeComponent();
        }

        public void FillTextBox(string name, string description)
        {
            SoftwareNameLabel.Text = name;
            SoftwareDescLabel.Text = description;
        }

        private void SoftwareViewer_Load(object sender, EventArgs e)
        {
            LoadAdditionalData();
        }

        private void ViewerBackButton_Click(object sender, EventArgs e)
        {
            //closes menu
            this.Hide();
        }       



        public void LoadAdditionalData()
        {
            string Software = SoftwareNameLabel.Text;
            DataTable AdditionalData = DBConnections.getInstanceOfDBConnection().Search(Software);


            //changes label text
            if (AdditionalData != null && AdditionalData.Rows.Count > 0)
            {
                AddInfoLabel.Text = AdditionalData.Rows[0]["Additional Information"].ToString();

                //shows N/A if empty
                if (string.IsNullOrEmpty(AddInfoLabel.Text))
                {
                    AddInfoLabel.Text = "N/A";
                }
            }

            //changes label text
            if (AdditionalData != null && AdditionalData.Rows.Count > 0)
            {
                DemoDateLabel.Text = AdditionalData.Rows[0]["Date Of Demo"].ToString();

                //shows N/A if empty
                if (string.IsNullOrEmpty(DemoDateLabel.Text))
                {
                    DemoDateLabel.Text = "N/A";
                }
            }

            //changes label text
            if (AdditionalData != null && AdditionalData.Rows.Count > 0)
            {
                documentLinkLabel.Text = AdditionalData.Rows[0]["Document link"].ToString();

                //shows N/A if empty
                if (string.IsNullOrEmpty(documentLinkLabel.Text))
                {
                    documentLinkLabel.Text = "N/A";
                }
            }

            string softwareID = AdditionalData.Rows[0]["SoftwareID"].ToString();
            DataTable ReviewsInfo = DBConnections.getInstanceOfDBConnection().SearchReviews(softwareID);

            if (ReviewsInfo != null && ReviewsInfo.Rows.Count > 0)
            {
                ratingLabel.Text = ReviewsInfo.Rows[0]["Review Score"].ToString();

                //shows N/A if empty
                if (string.IsNullOrEmpty(ratingLabel.Text))
                {
                    ratingLabel.Text = "No rating";
                }
            }
            else
            {
                ratingLabel.Text = "N/A";
            }

            if (ReviewsInfo != null && ReviewsInfo.Rows.Count > 0)
            {
                ratingDateLabel.Text = ReviewsInfo.Rows[0]["Date Of Review"].ToString();

                //shows N/A if empty
                if (string.IsNullOrEmpty(ratingDateLabel.Text))
                {
                    ratingDateLabel.Text = "";
                }
            }
            else
            {
                ratingDateLabel.Text = "N/A";
            }

            if (ReviewsInfo != null && ReviewsInfo.Rows.Count > 0)
            {
                reviewComment.Text = ReviewsInfo.Rows[0]["Review Text"].ToString();

                //shows N/A if empty
                if (string.IsNullOrEmpty(reviewComment.Text))
                {
                    reviewComment.Text = "No Comment";
                }
            }
            else
            {
                reviewComment.Text = "N/A";
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
