using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            
        }

        private void ViewerBackButton_Click(object sender, EventArgs e)
        {
            //SoftwareSales SoftwareSales = new SoftwareSales(user);
            //SoftwareSales.Show();
            this.Hide();
        }
    }
}
