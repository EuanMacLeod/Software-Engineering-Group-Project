using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Software_Engineering_Project_New
{
    public partial class SoftwareSales : Form
    {
        private int count;

        public SoftwareSales()
        {
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
        
        private void UpdateDisplayedSoftwareInfo()
        {
            for (int i = 0; i < 4; i++)
            {
                int rowIndex = count + i;

                if (rowIndex < this.citisoftDataSet.Softwares.Rows.Count)
                {
                    DataRow row = this.citisoftDataSet.Softwares.Rows[rowIndex];
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
            TextBox descriptionTextBox = (TextBox)this.Controls.Find($"softwareDescriptionTextBox{setNumber}", true).FirstOrDefault();

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
                TextBox descriptionTextBox = (TextBox)this.Controls.Find($"softwareDescriptionTextBox{i}", true).FirstOrDefault();

                nameTextBox?.Clear();
                descriptionTextBox?.Clear();
            }
        }


        private void nextPagebutton_Click(object sender, EventArgs e)
        {
            count = count + 4;
            UpdateDisplayedSoftwareInfo();
        }

    }
    
}
//alex code:

/*private void SoftwareSales_Load(object sender, EventArgs e)
{
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


}*/
