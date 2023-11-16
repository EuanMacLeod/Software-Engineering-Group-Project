using Software_Engineering_Project_New.Controllers.DatabaseEngineer.AdminTools;
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
    public partial class adminTools : Form
    {
        private readonly User user;
        public adminTools(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new roleIdChange(user).Show();
        }

        private void bttn_recovery_click(Object sender, EventArgs e)
        {
            new accountRecovery(user).Show();
        }
    }
}
