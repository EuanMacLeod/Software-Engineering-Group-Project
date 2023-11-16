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

        private void showPFP()
        {
            if (user.isAdmin != 0)
            {
                adminPfp.Visible = true; adminPfp.Enabled = true;
            }
        }

        public DatabaseEngineerHomePage(User pUser)
        {
            InitializeComponent();
            this.user = pUser;
            welcomeUserLabel.Text = "Welcome " + user.Name;

            showPFP();
           
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

            new adminTools().Show();
        }
    }
}
