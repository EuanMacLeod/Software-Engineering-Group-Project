using System;
using System.Windows.Forms;
using Software_Engineering_Project_New.Properties;

namespace Software_Engineering_Project_New
{
    public partial class Register : Form
    {
        //String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luca\Documents\GitHub\Software-Engineering-Group-Project\SQL Databases\Citisoft.mdf"";Integrated Security=True;Connect Timeout=30";
        private string connectionString = Settings.Default.CitisoftDBConnection;

        public Register()
        {
            InitializeComponent();
        }


        private void button_submit_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("All Fields Are Mandatory");
            }
            else if (txt_password.Text != txt_conpassword.Text)
            {
                MessageBox.Show("Passwords Don't Match");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please Choose A Role");
            }
            else if(DBConnections.getInstanceOfDBConnection().doesUserExist(txt_username.Text.Trim(), txt_email.Text.Trim()))
            {
                MessageBox.Show("User Already Exists");
            }
            else
            {
                int RoleID = radioButton1.Checked ? 3 : 4;

                string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(txt_password.Text.Trim(), 13);
                MessageBox.Show(passwordHash);


                DBConnections.getInstanceOfDBConnection().addEmployeeToDB(
                    txt_firstname.Text.Trim(),
                    txt_ContactNumber.Text.Trim(),
                    txt_username.Text.Trim(),
                    passwordHash,
                    txt_email.Text.Trim(),
                    RoleID
                );

                MessageBox.Show("Registration Successful");

                HomePage homePage = new HomePage();
                homePage.Show();
                Hide();


                // bellow code moved to DBConnections ~Euan
                /*
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("EmployeesAdd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@Name", txt_firstname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@ContactNumber", txt_ContactNumber.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Username", txt_username.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                    if (radioButton1.Checked)
                    {
                        sqlcmd.Parameters.AddWithValue("@RoleID", 3);
                    }
                    else
                    {
                        sqlcmd.Parameters.AddWithValue("@RoleID", 4);
                    }

                    //  sqlcmd.Parameters.AddWithValue("@RoleID", txt_roleid);
                    sqlcmd.ExecuteNonQuery();
                }
                */


                /*
                  char c = txt_email.Text.ToCharArray()[0];
                  String admin = "@Citisoft.com";
                  char[] adminChar = admin.ToCharArray();
                  char[] emailChar = txt_email.Text.ToCharArray();

                  for (int i = 0; i < adminChar.Length; i++)
                  {
                      int j = 0;
                      if (adminChar[i] == emailChar[i])
                      {
                          ++j;
                          if (j == adminChar.Length)
                          {
                              sqlcmd.Parameters.AddWithValue("@admin", box_admin);
                          }
                      }
                  }
                 */
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int roleid;
            if (radioButton1.Checked) roleid = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int roleid;
            if (radioButton2.Checked) roleid = 4;
        }
    }
}