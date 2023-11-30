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
            ViewerNameBox.Text = name;
            ViewerDescriptionBox.Text = description;
        }

        private void SoftwareViewer_Load(object sender, EventArgs e)
        {
            LoadAdditionalData();
        }

        private void ViewerBackButton_Click(object sender, EventArgs e)
        {
            //SoftwareSales SoftwareSales = new SoftwareSales(user);
            //SoftwareSales.Show();
            this.Hide();
        }



        public void LoadAdditionalData()
        {
            string Software = ViewerNameBox.Text;
            DataTable AdditionalData = DBConnections.getInstanceOfDBConnection().Search(Software);

            if (AdditionalData != null && AdditionalData.Rows.Count > 0)
            {
                textBox1.Text = AdditionalData.Rows[0]["Additional Information"].ToString();
            }
            else
            {
                textBox1.Text = "N/A";
            }

            if (AdditionalData != null && AdditionalData.Rows.Count > 0)
            {
                textBox2.Text = AdditionalData.Rows[0]["Date Of Demo"].ToString();
            }
            else
            {
                textBox2.Text = "N/A";
            }

            if (AdditionalData != null && AdditionalData.Rows.Count > 0)
            {
                textBox3.Text = AdditionalData.Rows[0]["Document link"].ToString();
            }
            else
            {
                textBox3.Text = "N/A";
            }

        }

    }
    
}
