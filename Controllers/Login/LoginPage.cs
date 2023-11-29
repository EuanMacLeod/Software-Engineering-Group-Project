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
            User user = DBConnections.getInstanceOfDBConnection().getUserFromDB(
                txt_username.Text.Trim(),
                txt_password.Text.Trim());


            if (user == null)
                MessageBox.Show("Error Logging In:\nUsername Or Password Is Incorrect");
            else
                //TO DO
                //LOAD INTO NEW PAGE, PASS USER CLASS INTO NEXT FORM SO USER CAN BE RETAINED
                switch (user.RoleId)
                {
                    case null:
                        MessageBox.Show("User Account Has Not Yet Been Verfied, Please Contact Your Manager.");
                        break;
                    case (int)Roles.Admin:
                        DialogResult result =
                            MessageBox.Show("Confirm for sales", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            new Sales(user).Show();
                        }
                        else
                        {
                            new DatabaseEngineerHomePage(user).Show();
                        }

                        //Load into new pages here

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
