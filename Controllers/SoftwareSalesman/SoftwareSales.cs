﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Linq;

namespace Software_Engineering_Project_New
{
    public partial class SoftwareSales : Form
    {
        int count;
        User user;


        public SoftwareSales(User pUser)
        {
            this.user = pUser;
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            this.softwaresTableAdapter.Fill(this.citisoftDataSet.Softwares);
            UpdateDisplayedSoftwareInfo();
        }

        public void SoftwareSales_Load(object sender, EventArgs e)
        {
            ClearSoftwareInfoTextBoxes();
            UpdateDisplayedSoftwareInfo();
        }
        
       

        private void UpdateDisplayedSoftwareInfo(DataTable data = null)
        {
            // Clear existing displayed information
            ClearSoftwareInfoTextBoxes();

            DataTable sourceData = data ?? this.citisoftDataSet.Softwares;

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



        private void SetSoftwareInfoTextBoxes(int setNumber, DataRow row)
        {
            TextBox nameTextBox = (TextBox)this.Controls.Find($"softwareNameTextBox{setNumber}", true).FirstOrDefault();
            TextBox descriptionTextBox =
                (TextBox)this.Controls.Find($"softwareDescriptionTextBox{setNumber}", true).FirstOrDefault();

            if (nameTextBox != null && descriptionTextBox != null)
            {
                nameTextBox.Text = row["Name"].ToString();
                descriptionTextBox.Text = row["Description"].ToString();
            }
        }

        private void ClearSoftwareInfoTextBoxes(int startFrom = 1)
        {
            for (int i = startFrom; i <= 4; i++)
            {
                TextBox nameTextBox = (TextBox)this.Controls.Find($"softwareNameTextBox{i}", true).FirstOrDefault();
                TextBox descriptionTextBox =
                    (TextBox)this.Controls.Find($"softwareDescriptionTextBox{i}", true).FirstOrDefault();

                nameTextBox?.Clear();
                descriptionTextBox?.Clear();
            }
        }


        private void nextPagebutton_Click(object sender, EventArgs e)
        {
            count = count + 4;
            UpdateDisplayedSoftwareInfo();
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (count > 4)
            {
                count = 0;
                UpdateDisplayedSoftwareInfo();
            }
        }


        private void DisplayRowInDataGridView(DataGridView dataGridView, DataTable softwareTable, int rowIndex)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
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
        */

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
            string sqlQuery = "SELECT Name, Description FROM Softwares WHERE cloud_native = true";

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
    }
}







        
    
// old code was not in use so removed that