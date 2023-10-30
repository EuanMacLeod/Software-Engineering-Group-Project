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
            populateDgv(generateDataSet(Constants.SELECTALLVENDORS));
        }
        
        private void viewEmployeesButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLEMPLOYEES));
        }

        private void viewManagersButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLMANAGERS));
        }

        private void viewVendorBranchesButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLBRANCHES));
        }

        private void viewSoftwareButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLSOFTWARES));
        }

        private void viewPurchasedSoftwareButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLPURCHASEDSOFTWARES));
        }

        private void viewSoftwareClientTypesButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLSOFTWARECLIENTTYPES));
        }

        private void viewSoftwareModulesButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLSOFTWAREMODULES));
        }
        
        private void viewSoftwareTypesButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLTYPESOFSOFTWARES));
        }
        
        private void viewSoftwareBuisnessAreas_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTALLSOFTWAREBUISNESSAREAS));

        }

        private void viewRolesButton_Click(object sender, EventArgs e)
        {
            populateDgv(generateDataSet(Constants.SELECTEMPLOYEEROLES));
        }


        private DataSet generateDataSet(string sqlQuery)
        {
            return(DBConnections.getInstanceOfDBConnection().getDataSet(sqlQuery));
        }

        private void populateDgv(DataSet ds)
        {
            dgvTest.DataSource = ds.Tables[0];
        }




    }
}
