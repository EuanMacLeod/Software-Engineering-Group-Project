using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.Helper_Classes
{
    public partial class Sales : Form
    {
        private readonly User user;

        
        public Sales(User user)
        {
            InitializeComponent();
            this.user = user;
            new Constants();

            DataGridView1_SelectionChanged(dataGridView1, lbl_name.Text);
         
        }

        
        private void DataGridView1_SelectionChanged(object sender, String output)
        {
            // Check if there's at least one selected cell
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the value from the selected cell and update the label's text
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int selectedColumnIndex = dataGridView1.SelectedCells[0].ColumnIndex;
                object cellValue = dataGridView1[selectedColumnIndex, selectedRowIndex].Value;

                // Assuming you have a Label named label1
                output = "Selected Value: " + cellValue.ToString();
            }
        }
        private void loadDGV()
        {
            populateDgv(generateDataSet(Constants.SELECTALLSOFTWARES));
        }
        private DataSet generateDataSet(string sqlQuery)
        {
            return DBConnections.getInstanceOfDBConnection().getDataSet(sqlQuery);
        }
        private void populateDgv(DataSet ds)
        {
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetSelectedCellValue(String name, String output)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Assuming "Name" is the column name
                DataGridViewCell cell = dataGridView1.Rows[selectedRowIndex].Cells[name];

                if (cell.Value != null)
                {
                    output = cell.Value.ToString();
                }
                
                    
                
            }
            

        }


        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citisoft_Softwares.Softwares' table. You can move, or remove it, as needed.
            this.softwaresTableAdapter.Fill(this.citisoft_Softwares.Softwares);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
