using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Software_Engineering_Project_New.Controllers.DatabaseEngineer.SubmitReview;
using System.Windows.Forms;
using Software_Engineering_Project_New.Controllers.DatabaseEngineer.UpdateProfile;
using Software_Engineering_Project_New.Controllers.SoftwareSalesman;

namespace Software_Engineering_Project_New
{
    public partial class SoftwareSales : Form
    {
        private int count;
        private User user;

        private LinkLabel websiteLinkLabel;


        public SoftwareSales(User pUser)
        {
            user = pUser;
            InitializeComponent();
            InitializeData();
        }

        public void RefreshUserData(User updatedUser)
        {
            user = updatedUser;
        }


        private void InitializeData()
        {
            softwaresTableAdapter.Fill(citisoftDataSet.Softwares);
            UpdateDisplayedSoftwareInfo();
        }

        public void SoftwareSales_Load(object sender, EventArgs e)
        {
            resultsLabel.Visible = false;
            //userLoggedInLabel.Text = user.Name;
            ClearSoftwareInfoTextBoxes();
            UpdateDisplayedSoftwareInfo();

            panel2.Height = 23;
            panel2.Width = 159;
        }
        private void OpenReviewForm(int softwareId, int userId)
        {
            SubmitReview reviewForm = new SubmitReview(softwareId, userId);
            reviewForm.ShowDialog();
        }

        private DataRow FetchVendorInfo(int vendorId)
        {
            string query = $"SELECT * FROM Vendors WHERE VendorId = {vendorId}";
            DataTable vendorTable = DBConnections.getInstanceOfDBConnection().getDataTable(query);

            if (vendorTable.Rows.Count > 0) return vendorTable.Rows[0];

            return null;
        }

        private void UpdateDisplayedSoftwareInfo(DataTable data = null)
        {
            // Clear existing displayed information
            ClearSoftwareInfoTextBoxes();

            DataTable sourceData = data ?? citisoftDataSet.Softwares;

            for (int i = 0; i < 4; i++)
            {
                int rowIndex = count + i;

                if (rowIndex < sourceData.Rows.Count)
                {
                    DataRow row = sourceData.Rows[rowIndex];
                    SetSoftwareInfoTextBoxes(i + 1, row);
                }
                else
                {
                    // Clear any remaining text boxes if there are no more rows
                    ClearSoftwareInfoTextBoxes(i + 1);
                    break;
                }
            }
        }
        
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Open the URL in the default web browser
                Process.Start(new ProcessStartInfo(e.Link.LinkData as string)
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening URL: {ex.Message}");
            }
        }



        private void SetSoftwareInfoTextBoxes(int setNumber, DataRow row)
        {
            // Find and update Name TextBox and Description TextBox
            TextBox nameTextBox = (TextBox)Controls.Find($"softwareNameTextBox{setNumber}", true).FirstOrDefault();
            TextBox descriptionTextBox =
                (TextBox)Controls.Find($"softwareDescriptionTextBox{setNumber}", true).FirstOrDefault();

            if (nameTextBox != null && descriptionTextBox != null)
            {
                nameTextBox.Text = row["Name"].ToString();
                descriptionTextBox.Text = row["Description"].ToString();
            }

            bool anyTextBoxNotEmpty = false;

            for (int i = 1; i <= 4; i++)
            {
                // Check and set visibility for Name TextBox
                TextBox textBox = (TextBox)Controls.Find($"softwareNameTextBox{i}", true).FirstOrDefault();

                if (textBox != null)
                {
                    textBox.Visible = !string.IsNullOrEmpty(textBox.Text);

                    // Check and set visibility for corresponding PictureBox
                    PictureBox pictureBox = (PictureBox)Controls.Find($"pictureBox{i}", true).FirstOrDefault();

                    if (pictureBox != null) pictureBox.Visible = textBox.Visible;

                    if (!anyTextBoxNotEmpty && textBox.Visible) anyTextBoxNotEmpty = true;
                }
            }

            // Check and set visibility for Description TextBoxes
            for (int i = 1; i <= 4; i++)
            {
                TextBox textBox = (TextBox)Controls.Find($"softwareDescriptionTextBox{i}", true).FirstOrDefault();

                if (textBox != null)
                {
                    textBox.Visible = !string.IsNullOrEmpty(textBox.Text);

                    if (!anyTextBoxNotEmpty && textBox.Visible) anyTextBoxNotEmpty = true;
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                // Check and set visibility for Name TextBox
                TextBox textBox = (TextBox)Controls.Find($"softwareNameTextBox{i}", true).FirstOrDefault();

                if (textBox != null)
                {
                    textBox.Visible = !string.IsNullOrEmpty(textBox.Text);

                    // Check and set visibility for corresponding weblink
                    LinkLabel LinkLabel = (LinkLabel)Controls.Find($"linkLabel{i}", true).FirstOrDefault();

                    if (LinkLabel != null) LinkLabel.Visible = textBox.Visible;

                    if (!anyTextBoxNotEmpty && textBox.Visible) anyTextBoxNotEmpty = true;
                }
            }

            // Set visibility for Name and Description TextBoxes
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameTextBox.Visible = false;
                descriptionTextBox.Visible = false;
            }
            else
            {
                nameTextBox.Visible = true;
                descriptionTextBox.Visible = true;
            }

            // Set visibility for the resultsLabel
            resultsLabel.Visible = !anyTextBoxNotEmpty;

            int vendorId = Convert.ToInt32(row["VendorId"]);

            // Fetch the vendor information from the Vendors table
            DataRow vendorRow = FetchVendorInfo(vendorId);

            if (vendorRow != null)
            {
                string websiteUrl = vendorRow["Website"].ToString();

                // Get the corresponding link label based on set number
                LinkLabel linkLabel = (LinkLabel)Controls.Find($"linkLabel{setNumber}", true).FirstOrDefault();
                
                // Detachs the event handler before subscribing again
                linkLabel.LinkClicked -= LinkLabel_LinkClicked;

                linkLabel.Links.Clear();
                linkLabel.Links.Add(0, linkLabel.Text.Length, websiteUrl);

                // Handle link click
                linkLabel.LinkClicked += LinkLabel_LinkClicked;
            }
            // adding review button
            Button reviewButton = (Button)this.Controls.Find($"btnReview{setNumber}", true).FirstOrDefault();

            // the event handler for the review button
            reviewButton.Click += (sender, e) =>
            {
                // Handle the review button click
                // Pass the software ID to the review form
                int softwareId = Convert.ToInt32(row["SoftwareId"]);
                OpenReviewForm(softwareId, this.user.Id);
            };

        }


        private void ClearSoftwareInfoTextBoxes(int startFrom = 1)
        {
            for (int i = startFrom; i <= 4; i++)
            {
                TextBox nameTextBox = (TextBox)Controls.Find($"softwareNameTextBox{i}", true).FirstOrDefault();
                TextBox descriptionTextBox =
                    (TextBox)Controls.Find($"softwareDescriptionTextBox{i}", true).FirstOrDefault();

                nameTextBox?.Clear();
                descriptionTextBox?.Clear();
            }
        }


        private void nextPagebutton_Click(object sender, EventArgs e)
        {
            if (count < citisoftDataSet.Softwares.Rows.Count - 4)
            {
                count = count + 4;
                UpdateDisplayedSoftwareInfo();
            }
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count = count - 4;
                UpdateDisplayedSoftwareInfo();
            }
        }


        private void FilterButton_Click_1(object sender, EventArgs e)
        {
            //opens filter menu
            if (panel2.Height == 187)
                panel2.Height = 23;

            else
                panel2.Height = 187;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string searchString = SearchBar.Text;


            DataTable searchResults = DBConnections.getInstanceOfDBConnection().Search(searchString, true);

            UpdateDisplayedSoftwareInfo(searchResults);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bool cloudNative = true;

                while (cloudNative)
                {
                    string sqlQuery = "SELECT Name, Description FROM Softwares WHERE cloud_native = true";
                    DBConnections.getInstanceOfDBConnection().getDataSet(sqlQuery);
                }
            }

            if (checkBox2.Checked)
            {
                bool isProfesional = true;

                while (isProfesional)
                {
                    string sqlQuery = "SELECT Name, Description FROM Softwares WHERE isProfesional = true";
                    DBConnections.getInstanceOfDBConnection().getDataSet(sqlQuery);
                }
            }

        }

        private void SearchBar_Clicked(object sender, EventArgs e)
        {
            SearchBar.Clear();
        }

        public void FindAverage(object sender, EventArgs e)
        {
            

        }

        private void RatingButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RatingButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RatingButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RatingButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = SearchBar.Text;


            DataTable searchResults = DBConnections.getInstanceOfDBConnection().Search(searchString);

            UpdateDisplayedSoftwareInfo(searchResults);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            UpdateDisplayedSoftwareInfo();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile updateProfile = new UpdateProfile(this);

            updateProfile.SetUserData(user);
            Refresh();

            updateProfile.ShowDialog();
        }


        private void whenClicked()
        {
            string name = softwareNameTextBox1.Text;
            string description = softwareDescriptionTextBox1.Text;


            //this.Close();

            using (SoftwareViewer softwareViewerForm = new SoftwareViewer())
            {
                softwareViewerForm.FillTextBox(name, description);

                softwareViewerForm.ShowDialog();
            }
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            whenClicked();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            whenClicked();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            whenClicked();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            whenClicked();
        }

        private void softwareNameTextBox1_Click(object sender, EventArgs e)
        {
            whenClicked();
        }
        private void softwareNameTextBox2_Click(object sender, EventArgs e)
        {
            whenClicked();
        }

        private void softwareNameTextBox3_Click(object sender, EventArgs e)
        {
            whenClicked();
        }

        private void softwareNameTextBox4_Click(object sender, EventArgs e)
        {
            whenClicked();
        }

        private void softwareDescriptionTextBox1_Click(object sender, EventArgs e)
        {
            whenClicked();
        }
        private void softwareDescriptionTextBox2_Click(object sender, EventArgs e)
        {
            whenClicked();
        }
        private void softwareDescriptionTextBox3_Click(object sender, EventArgs e)
        {
            whenClicked();
        }
        private void softwareDescriptionTextBox4_Click(object sender, EventArgs e)
        {
            whenClicked();
        }


    }
}