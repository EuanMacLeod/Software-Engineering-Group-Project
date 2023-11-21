using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Engineering_Project_New.Helper_Classes;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer.AdminTools
{
    public partial class ApproveUser : Form
    {
        private int selectedRoleId = 0;

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

        private void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            if (UsersAwaitingApprovalDgv.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one user to approve");
                return;
            }

            if (selectedRoleId == 0)
            {
                MessageBox.Show("Please select a role for the user");
                return;
            }


            DialogResult dr = MessageBox.Show(
                "Is all the selected information is correct?.",
                "confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Waow");
                
                try
                {
                    int selectedUserId = (int)UsersAwaitingApprovalDgv.SelectedRows[0].Cells[0].Value;
                    if (ApproveRadioButton.Checked)
                    {
                        DBConnections.getInstanceOfDBConnection().updateRoleID(selectedUserId, selectedRoleId);
                        MessageBox.Show("User Has Been Accepted");
                    }
                    else
                    {
                        DBConnections.getInstanceOfDBConnection().deleteEmployee(selectedUserId);
                        MessageBox.Show("User Has Been Rejected");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error Whilst Confirming Employee", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                
                dr = MessageBox.Show(
                    "Would you like to send an email to inform the user?",
                    "confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string recipient = UsersAwaitingApprovalDgv.SelectedRows[0].Cells[2].Value.ToString();
                    string subject = "Citisoft Employee Account";
                    string body = ApproveRadioButton.Checked ? "Your account has been approved, you may now log in." : "Your account has been rejected.";
                    EmailService.getInstanceOfEmailService().sendEmail(recipient, subject, body);
                }
                

                populateDgv(generateDataTable());
            }
        }
    }
}
