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

namespace Software_Engineering_Project_New
{
    public partial class SoftwareSales : Form
    {
        int count;

        public SoftwareSales()
        {
            InitializeComponent();

        }

       

        private void SoftwareSales_Load(object sender, EventArgs e)
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
        }
    }
}
