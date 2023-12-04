using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    public partial class roleIdChange : Form
    {
        private readonly User user;
        public roleIdChange(User puser)
        {
            InitializeComponent();
            this.user = puser;
            label_userLoggedin.Text = user.Name;
            populateDgv(generateDataTable());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void populateDgv(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        private DataTable generateDataTable()
        {
            DataTable dt = DBConnections.getInstanceOfDBConnection().getDataTable("SELECT * FROM Employees WHERE RoleID IS NOT NULL ");

            return dt;
        }
    


    private void button1_Click(object sender, EventArgs e)
        {
            
            int adj = bttn_sales.Checked ? 3 : 4;
            
            bool exists = DBConnections.getInstanceOfDBConnection().doesUserExist(txt_userame.Text.Trim(), txt_email.Text.Trim());
            if (!exists)
            {
                MessageBox.Show("Username and email not found");
            }else
            {
                int employeeId = DBConnections.getInstanceOfDBConnection().getUserID(txt_userame.Text.Trim());
                DBConnections.getInstanceOfDBConnection().updateRoleID(employeeId, adj);
                MessageBox.Show("Success");
            }
            

           // MessageBox.Show("role id for " + user.Username + "has been changed to " + adj);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
