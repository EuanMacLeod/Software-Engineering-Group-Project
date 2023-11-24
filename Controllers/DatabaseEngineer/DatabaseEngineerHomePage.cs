using Software_Engineering_Project_New.Helper_Classes;
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
    public partial class DatabaseEngineerHomePage : Form
    {
        private User user;

        private void showAdmin()
        {
            if (user.RoleId != (int)Roles.DatabaseEngineer)
            {
                Citisoft_logo.Visible = true; Citisoft_logo.Enabled = true;
                bttn_adminTools.Visible = true;
                
            }
        }

        public DatabaseEngineerHomePage(User pUser)
        {
            InitializeComponent();
            this.user = pUser;
            welcomeUserLabel.Text = "Welcome " + user.Name;
            

            showAdmin();
           
        }


        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }

        private void button_pdfTagging_Click(object sender, EventArgs e)
        {
            DatabaseEngineerPdfTaggingPage databaseEngineerPdfTaggingPage = new DatabaseEngineerPdfTaggingPage(user);
            databaseEngineerPdfTaggingPage.Show();
            Hide();
        }

        private void bttn_adminTools_Click(object sender, EventArgs e)
        {
            // initialise and show admin tools window

            new adminTools(user).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SoftwareSales(user).Show();
        }
    }
}
