using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.Controllers.Database_Engineer
{
    public partial class DatabaseEngineerHomePage : Form
    {
        private User user;
        public DatabaseEngineerHomePage(User pUser)
        {
            this.user = pUser;  
            InitializeComponent();
            label1.Text = "Welcome " + user.Username;

        }
    }
}
