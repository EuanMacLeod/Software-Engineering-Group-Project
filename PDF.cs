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

        private void changeLabel(Label tartgetlabel, String newText)
        { 
                tartgetlabel.Text = newText;
            
        }


        private void setVisable(Label tartgetlabel)
        {
            tartgetlabel.Visible = true;

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
            changeLabel(label_name, "fdsaf");
            setVisable(label_name);
            


        }

        private void button_pdfDB_Click(object sender, EventArgs e)
        {
            PDFDB PDFDB = new PDFDB();
            PDFDB.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void PDF_Load(object sender, EventArgs e)
        {

        }

        private void txt_url_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
