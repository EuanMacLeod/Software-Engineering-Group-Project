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
    public partial class accountRecovery : Form
    {
        private readonly User user;
        public accountRecovery(User user)
        {
            InitializeComponent();
            this.user = user;

            if (user.RoleId != 1)
            {
                MessageBox.Show("You cannot hack the mainframe");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exists = DBConnections.getInstanceOfDBConnection().doesUserExist(txt_username.Text.Trim(), txt_email.Text.Trim());

            if(!exists)
            {
                MessageBox.Show("Stop lying this account isnt real");
            }
            else
            {
                int employeeId = DBConnections.getInstanceOfDBConnection().getUserID(txt_username.Text.Trim());
                

                string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(txt_newPassword.Text.Trim(), 13);

                DBConnections.getInstanceOfDBConnection().accountRecovery(employeeId, passwordHash);

                

            }
        }
    }
}
