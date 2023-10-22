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
    public partial class DatabaseTesting : Form
    {
        public DatabaseTesting()
        {
            InitializeComponent();
        }

        private void DatabaseTesting_Load(object sender, EventArgs e)
        {
            LoadEmployeesDGV();
        }

        private void LoadEmployeesDGV()
        {

            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLEMPLOYEES);
            dgvTest.DataSource = dataSet.Tables[0];


        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DBTestingBackButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
            new HomePage().Show();
        }

        private void viewVendorsButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLVENDORS);
            dgvTest.DataSource = dataSet.Tables[0];

        }


        
        private void viewEmployeesButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLEMPLOYEES);
            dgvTest.DataSource = dataSet.Tables[0];

        }

    }
}
