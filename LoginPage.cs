using System;
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

        String connectionString = @"Data Source=DESKTOP-37PB8E2\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            SqlConnection sqlcon = new SqlConnection(connectionString);
            String querry = "SELECT * FROM tblUser WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, sqlcon);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                username = txt_username.Text;
                user_password = txt_password.Text;
                txt_password.Clear();
                txt_username.Clear();
                ; MessageBox.Show("Win");

            }
            else
            {
                MessageBox.Show("Not good news");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
