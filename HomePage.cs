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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void DBTestButton_Click(object sender, EventArgs e)
        {

            
            this.Close();
            new DatabaseTesting().Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }




        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            LoginPage.Show();
            this.Hide();
        }

        private void button_adminTools_Click(object sender, EventArgs e)
        {

        }

        private void Updatebutton_adminTools()
        {

            
            button_adminTools.Visible = false; // no need for if/else
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_PDF_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            pdf.Show();
            this.Hide();
        }
    }
}