using System;
using System.Windows.Forms;
using Software_Engineering_Project_New.PDF;

namespace Software_Engineering_Project_New
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void DBTestButton_Click(object sender, EventArgs e)
        {
            Close();
            new DatabaseTesting().Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes) Application.Exit();
        }


        private void welcomeLabel_Click(object sender, EventArgs e)
        {
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }

        private void button_pdf_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView();
            Close();
            productView.Show();
        }
    }
}