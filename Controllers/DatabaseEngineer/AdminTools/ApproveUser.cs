using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer.AdminTools
{
    public partial class ApproveUser : Form
    {
        private int? selectedRoleId;

        public ApproveUser()
        {
            InitializeComponent();
            populateDgv(generateDataTable());
        }


        private void populateDgv(DataTable dt)
        {
            UsersAwaitingApprovalDgv.DataSource = dt;
        }

        private DataTable generateDataTable()
        {
            DataTable dt = DBConnections.getInstanceOfDBConnection().getDataTable("SELECT * FROM Employees WHERE RoleID IS NULL");

            return dt;
        }



        private void updateSelectedEmployeeLabel()
        {
            //updates the label to show the selected PDF
            if (UsersAwaitingApprovalDgv.SelectedRows.Count == 1)
            {
                SelectedEmployeeLabel.Text =
                    "Selected Employee:\n" + UsersAwaitingApprovalDgv.SelectedRows[0].Cells[1].Value;
            }
            else
            {
                SelectedEmployeeLabel.Text = "Selected Employee: ";
            }
        }


        private void UsersAwaitingApprovalDgv_SelectionChanged(object sender, EventArgs e)
        {
            //ensures that only one row of the Softwares dgv can be selected at a time
            if (UsersAwaitingApprovalDgv.SelectedRows.Count > 1) UsersAwaitingApprovalDgv.SelectedRows[0].Selected = false;

            updateSelectedEmployeeLabel();
        }

        private void AdminRadioButton_Clicked(object sender, EventArgs e)
        {
            selectedRoleId = (int)Roles.Admin;
        }

        private void ManagerRadioButton_Clicked(object sender, EventArgs e)
        {
            selectedRoleId = (int)Roles.Manager;
        }
        private void SalesmanRadioButton_Clicked(object sender, EventArgs e)
        {
            selectedRoleId = (int)Roles.SoftwareSalesman;
        }
        private void DatabaseEngineerRadioButton_Clicked(object sender, EventArgs e)
        {
            selectedRoleId = (int)Roles.DatabaseEngineer;
        }

        private void ApproveUserButton_Clicked(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "You Are Approving:\n" + UsersAwaitingApprovalDgv.SelectedRows[0].Cells[1].Value + "\nWith The Role Of:\n" +
                selectedRoleId, "confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Waow");
            }

        }

        private void RejectUserButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
