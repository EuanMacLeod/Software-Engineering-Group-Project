﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New
{
    public partial class LoginPage : Form
    {
        //String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luca\Documents\GitHub\Software-Engineering-Group-Project\SQL Databases\Citisoft.mdf"";Integrated Security=True;Connect Timeout=30";
        
        string ConnectionString = Properties.Settings.Default.CitisoftDBConnection;
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {

            User user = DBConnections.getInstanceOfDBConnection().veryfyLogin(
                txt_username.Text.Trim(),
                txt_password.Text.Trim());


            if (user == null)
            {
                MessageBox.Show("Error Logging In:\nUsername Or Password Is Incorrect");
            }
            else
            {
                //TO DO
                //LOAD INTO NEW PAGE, PASS USER CLASS INTO NEXT FORM SO USER CAN BE RETAINED

                SoftwareSales SoftwareSales = new SoftwareSales();
                SoftwareSales.Show();
                this.Hide();

                switch (user.RoleID)
                {
                    case null:
                        MessageBox.Show("User Account Has Not Yet Been Verfied, Please Contact Your Manager.");
                        break;
                    case (int)Roles.Admin:
                        //Load into new pages here
                        break;
                    case (int)Roles.Manager:

                        break;
                    case (int)Roles.DatabaseEngineer:

                        break;
                    case (int)Roles.SoftwareSalesman:

                        break;
                    default:
                        break;

                }

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
            this.Hide();

        }

        private void button_register_Click(object sender, EventArgs e)

        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
