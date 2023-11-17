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
    }
}
