using System;
using System.Windows.Forms;
using Software_Engineering_Project_New.Controllers.DatabaseEngineer;
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
                        //Load into new pages here
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

                        break;
                }


            //code bellow has been moved to DBConnections.cs ~Euan
            /*
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            String querry = "SELECT * FROM Employees WHERE Username = '" + txt_username.Text + "' AND Password = '" + txt_password.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, sqlcon);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                username = txt_username.Text;
                user_password = txt_password.Text;
                txt_password.Clear();
                txt_username.Clear();
                MessageBox.Show("Win");

            }
            else
            {
                MessageBox.Show("Not good news");
            }
            */
        }

        private void button_switchboard_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            Hide();
        }

        private void button_register_Click(object sender, EventArgs e)

        {
            Register register = new Register();
            register.Show();
            Hide();
        }
    }
}