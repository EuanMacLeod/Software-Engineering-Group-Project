using System;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer.SubmitReview
{
    public partial class SubmitReview : Form
    {
        private int softwareId;
        private int userId;
        public SubmitReview(int softwareId, int userId)
        {
            this.softwareId = softwareId;
            this.userId = userId;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string reviewText = reviewTextbox.Text;
            
            DBConnections.getInstanceOfDBConnection().InsertReviewIntoDatabase(softwareId, reviewText, this.userId);
            this.Close();
        }
    }
}