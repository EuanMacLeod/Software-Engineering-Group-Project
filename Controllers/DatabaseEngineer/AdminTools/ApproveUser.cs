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
            usersAwatingApproval.DataSource = dt;
        }

        private DataTable generateDataTable()
        {
            DataTable dt = DBConnections.getInstanceOfDBConnection().getDataTable("SELECT * FROM Employees WHERE RoleID IS NULL");

            return dt;
        }
    }
}
