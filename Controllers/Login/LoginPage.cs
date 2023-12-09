using System;
using System.Windows.Forms;
using Software_Engineering_Project_New.Controllers.DatabaseEngineer;
using Software_Engineering_Project_New.Helper_Classes;
using Software_Engineering_Project_New.Properties;

namespace Software_Engineering_Project_New
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //get information entered by user onto the form and pass to backend
            User user = DBConnections.getInstanceOfDBConnection().getUserFromDB(
                txt_username.Text.Trim(),
                txt_password.Text.Trim());


            if (user == null)
                MessageBox.Show("Error Logging In:\nUsername Or Password Is Incorrect");
            else
                switch (user.RoleId) //Load different forms depending on the user's role
                {
                    case null:
                        MessageBox.Show("User Account Has Not Yet Been Verfied, Please Contact Your Manager.");
                        break;

                    case (int)Roles.Admin:
                        new DatabaseEngineerHomePage(user).Show();
                        Hide();
                        break;

                    case (int)Roles.Manager:
                        break;

                    case (int)Roles.DatabaseEngineer:
                        DatabaseEngineerHomePage databaseEngineerHomePage = new DatabaseEngineerHomePage(user);
                        databaseEngineerHomePage.Show();
                        Hide();
                        break;

                    case (int)Roles.SoftwareSalesman:
                        SoftwareSales SoftwareSales = new SoftwareSales(user);
                        SoftwareSales.Show();
                        this.Hide();
                        break;
                }
        }

        private void button_switchboard_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            Close();
        }

        private void button_register_Click(object sender, EventArgs e)

        {
            Register register = new Register();
            register.Show();
            Close();
        }
    }
}
