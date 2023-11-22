using System;
using System.Windows.Forms;
using Software_Engineering_Project_New.Properties;
using System.Net.Mail;

namespace Software_Engineering_Project_New
{
    public partial class Register : Form
    {
        //String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luca\Documents\GitHub\Software-Engineering-Group-Project\SQL Databases\Citisoft.mdf"";Integrated Security=True;Connect Timeout=30";

        public Register()
        {
            InitializeComponent();
        }
        private bool IsNumeric(string value)
        {
            return long.TryParse(value, out _);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        private int verifyAdmin(String email)
        {
            
            try
            {
                string adminEmail = "admin@citisoft.com";

                if (adminEmail.Equals(email))
                {
                    return 1; // Admin email matches the provided email
                }
                else
                {
                    return 0; // Admin email does not match the provided email
                }
            }
            catch (FormatException)
            {
                // Handle the format exception if needed
                return 0; // For simplicity, return false in case of a format exception
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int RoleID;
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

            else if (!IsNumeric(txt_ContactNumber.Text.Trim()) || txt_ContactNumber.Text.Trim().Length < 11)                {
                    MessageBox.Show("Contact Number should be numeric and at least 11 digits");
                }
            else if (!IsValidEmail(txt_email.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address");
            }
            
            else
            {
                
                RoleID = radioButton1.Checked ? 3 : 4;

                if(verifyAdmin(txt_email.Text.Trim()) == 1)
                {
                    RoleID = 1;
                }

                string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(txt_password.Text.Trim(), 13);
                //MessageBox.Show(passwordHash);

                DBConnections.getInstanceOfDBConnection().addEmployeeToDB(
                    txt_firstname.Text.Trim(),
                    txt_ContactNumber.Text.Trim(),
                    txt_username.Text.Trim(),
                    passwordHash,
                    txt_email.Text.Trim(),
                    RoleID

                );
                /*
                if (isAdmin == 1)
                {
                    DBConnections.getInstanceOfDBConnection().createGod(isAdmin);
                }
                */
                MessageBox.Show("Registration Successful");

                new HomePage().Show();
                Hide();


                
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

        private void box_admin_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}