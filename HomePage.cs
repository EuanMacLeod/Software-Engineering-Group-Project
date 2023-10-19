using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LoadEmployeesDGV();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void TermsAndConditionsBox_CheckedChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = termsAndConditionsBox.Checked;
        }

        private void LoadEmployeesDGV()
        {

            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLEMPLOYEES);
            DataTable dataTable = dataSet.Tables[0];
            dgvEmployees.DataSource = dataTable;


        }


    }
}