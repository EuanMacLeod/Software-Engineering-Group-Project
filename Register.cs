using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New
{
    public partial class Register : Form
    {
        String connectionString = @"Data Source=DESKTOP-37PB8E2\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";
        public Register()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("All fields are mandatory");
            }
            else if (txt_password.Text != txt_conpassword.Text)
            {
                MessageBox.Show("Passwords dont match");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@FirstName", txt_firstname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@LastName", txt_lastname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Username", txt_username.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
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
                   
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("registraition is sucessfull");
                    
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();



                }
            }
        }
    }
}
