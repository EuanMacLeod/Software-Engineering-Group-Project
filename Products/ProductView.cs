using System;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.PDF
{
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void PDFDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citisoftDataSet.Softwares' table. You can move, or remove it, as needed.
            this.softwaresTableAdapter.Fill(this.citisoftDataSet.Softwares);

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            new HomePage().Show();
        }
    }
}
