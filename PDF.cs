using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New
{
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }

        


        private void button_exit_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txt_url.Text);
        }

        private void button_pdfDB_Click(object sender, EventArgs e)
        {
            PDFDB PDFDB = new PDFDB();
            PDFDB.Show();
        }
    }
}
