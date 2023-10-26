using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void DBTestButton_Click(object sender, EventArgs e)
        {

            
            this.Close();
            new DatabaseTesting().Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }




        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}