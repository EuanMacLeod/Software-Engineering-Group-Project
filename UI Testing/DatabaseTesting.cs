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

        private void viewManagersButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLMANAGERS);
            dgvTest.DataSource = dataSet.Tables[0];

        }

        private void viewVendorBranchesButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLBRANCHES);
            dgvTest.DataSource = dataSet.Tables[0];

        }

        private void viewSoftwareButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLSOFTWARES);
            dgvTest.DataSource = dataSet.Tables[0];
        }

        private void viewPurchasedSoftwareButton_Click(object sender, EventArgs e)
        {
            
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLPURCHASEDSOFTWARES);
            dgvTest.DataSource = dataSet.Tables[0];
        }

        private void viewSoftwareClientTypesButton_Click(object sender, EventArgs e)
        {
            
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLSOFTWARECLIENTTYPES);
            dgvTest.DataSource = dataSet.Tables[0];
        }

        private void viewSoftwareModulesButton_Click(object sender, EventArgs e)
        {
            
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLSOFTWAREMODULES);
            dgvTest.DataSource = dataSet.Tables[0];
        }
        
        private void viewSoftwareTypesButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLTYPESOFSOFTWARES);
            dgvTest.DataSource = dataSet.Tables[0];

        }
        
        private void viewSoftwareBuisnessAreas_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTALLSOFTWAREBUISNESSAREAS);
            dgvTest.DataSource = dataSet.Tables[0];

        }

        private void viewRolesButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DBConnections.getInstanceOfDBConnection().getDataSet(Constants.SELECTEMPLOYEEROLES);
            dgvTest.DataSource = dataSet.Tables[0];
        }
    }
}
