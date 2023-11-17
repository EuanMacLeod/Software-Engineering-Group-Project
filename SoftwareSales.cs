using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Software_Engineering_Project_New
{
    public partial class SoftwareSales : Form
    {
        int count;
        User user;


        public SoftwareSales(User puser)
        {
            InitializeComponent();
            user = puser;

        }



        private void SoftwareSales_Load(object sender, EventArgs e)
        {
            getData();
            panel2.Height = 23;

        }

        private void getData()
        {

            userLoggedInLabel.Text = user.Name;

            // TODO: This line of code loads data into the 'citisoftDataSet.Softwares' table. You can move, or remove it, as needed.
            this.softwaresTableAdapter.Fill(this.citisoftDataSet.Softwares);


            if (this.citisoftDataSet.Softwares.Rows.Count > 0)
            {


                var Nextrow = this.citisoftDataSet.Softwares.Rows[count];

                softwareNameTextBox.Text = Nextrow["Name"].ToString();
                softwareDescriptionTextBox.Text = Nextrow["Description"].ToString();

                count = count + 1;
                Nextrow = this.citisoftDataSet.Softwares.Rows[count];

                softwareNameTextBox2.Text = Nextrow["Name"].ToString();
                softwareDescriptionTextBox2.Text = Nextrow["Description"].ToString();

                count = count + 1;
                Nextrow = this.citisoftDataSet.Softwares.Rows[count];


                softwareNameTextBox3.Text = Nextrow["Name"].ToString();
                softwareDescriptionTextBox3.Text = Nextrow["Description"].ToString();

                count = count + 1;
                Nextrow = this.citisoftDataSet.Softwares.Rows[count];


                softwareNameTextBox4.Text = Nextrow["Name"].ToString();
                softwareDescriptionTextBox4.Text = Nextrow["Description"].ToString();


            }
        }

        private void DisplayRowInDataGridView(DataGridView dataGridView, DataTable softwareTable, int rowIndex)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void nextPagebutton_Click(object sender, EventArgs e)
        {
            count = count + 4;
            getData();
            
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (count > 4)
            {
                count = 0;
                getData();
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 187)
            {
                panel2.Height = 23;

            }

            else
            {
                panel2.Height = 187;
            }
        }

        

        private void FilterButton_Click_1(object sender, EventArgs e)
        {
            if (panel2.Height == 187)
            {
                panel2.Height = 23;

            }

            else
            {
                panel2.Height = 187;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.softwaresTableAdapter.Fill(this.citisoftDataSet.Softwares);
            string sqlQuery = "SELECT Name, Description FROM software WHERE cloud_native = true";

            DBConnections.getInstanceOfDBConnection().getDataSet(sqlQuery);
            


        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bool cloudNative = true;
            }

            if (RatingButton1.Checked)
            {
                bool starRating1 = true;
            }

            if (RatingButton2.Checked)
            {
                bool starRating2 = true;
            }

            if (RatingButton3.Checked)
            {
                bool starRating3 = true;
            }

            if (RatingButton4.Checked)
            {
                bool starRating4 = true;
            }

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
    }
}
