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

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    public partial class DatabaseEngineerSoftwareManagementPage : Form
    {
        private User user;
        public DatabaseEngineerSoftwareManagementPage(User pUser)
        {
            this.user = pUser;
            InitializeComponent();
        }

        private void SoftwaresManagementPage_Load(object sender, EventArgs e)
        {
            populateSoftwaresDgv(DBConnections.getInstanceOfDBConnection().getDataTable(Constants.SELECTALLSOFTWARES));
        }


        private void populateSoftwaresDgv(DataTable dt)
        {
            SoftwaresDgv.DataSource = dt;
        }

        private void populateSoftwareTypeDgv(DataTable dt)
        {
            SoftwareTypeDgv.DataSource = dt;
        }

        private void populateSoftwareModuleDgv(DataTable dt)
        {
            SoftwareModuleDgv.DataSource = dt;
        }

        private void populateClientTypeDgv(DataTable dt)
        {
            ClientTypeDgv.DataSource = dt;
        }

        private void populateBuisnessAreasDgv(DataTable dt)
        {
            BuisnessAreasDgv.DataSource = dt;
        }

        private void dgvSoftwares_SelectionChanged(object sender, EventArgs e)
        {
            //ensures that only one row of the Softwares dgv can be selected at a time
            if (SoftwaresDgv.SelectedRows.Count > 1)
            {
                SoftwaresDgv.SelectedRows[0].Selected = false;
            }



            try
            {
                MessageBox.Show(
                    Constants.SELECTTYPESOFSOFTWARE + SoftwaresDgv.SelectedRows[0].Cells[0].Value.ToString());


                populateSoftwareTypeDgv(DBConnections.getInstanceOfDBConnection()
                    .getDataTable(Constants.SELECTTYPESOFSOFTWARE +
                                  SoftwaresDgv.SelectedRows[0].Cells[0].Value.ToString()));
                populateBuisnessAreasDgv(DBConnections.getInstanceOfDBConnection()
                    .getDataTable(Constants.SELECTSOFTWAREBUISNESSAREAS +
                                  SoftwaresDgv.SelectedRows[0].Cells[0].Value.ToString()));
                populateSoftwareModuleDgv(DBConnections.getInstanceOfDBConnection()
                    .getDataTable(Constants.SELECTSOFTWAREMODULES +
                                  SoftwaresDgv.SelectedRows[0].Cells[0].Value.ToString()));
                populateClientTypeDgv(DBConnections.getInstanceOfDBConnection()
                    .getDataTable(Constants.SELECTSOFTWARECLIENTTYPES +
                                  SoftwaresDgv.SelectedRows[0].Cells[0].Value.ToString()));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
