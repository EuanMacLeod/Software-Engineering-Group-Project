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
    public partial class DatabaseEngineerSoftwareManagementPage : Form
    {
        private User user;
        public DatabaseEngineerSoftwareManagementPage(User pUser)
        {
            this.user = pUser;
            InitializeComponent();
        }

        private void LoadSoftwaresDgv(object sender, EventArgs e)
        {
            populateSoftwaresDgv();
        }


        private void populateSoftwaresDgv()
        {
            SoftwaresDgv.Show();
        }




    }
}
