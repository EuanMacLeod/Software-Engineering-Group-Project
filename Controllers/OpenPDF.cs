using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    public partial class OpenPDF : Form
    {
        private User user;
        
        public OpenPDF(User pUser)
        {
            InitializeComponent();
            this.user = pUser;
            MessageBox.Show("Please click open and close this window");

            webBrowser1.Navigate(Clipboard.GetText());
          
            
        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text.Trim());

        }
    }
}
