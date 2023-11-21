using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
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

            populateSoftwaresDgv(generatePDFDataTable());
            populateSoftwaresDgv(DBConnections.getInstanceOfDBConnection().getDataTable(Constants.SELECTALLSOFTWARES));
            lbl_name.Visible = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        private void updateSelectedPDFLabel()
        {
            //updates the label to show the selected PDF
            if (dataGridView1.SelectedRows.Count == 1)
                dataGridView1.Text =
                    "Selected PDF:\n" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            else
                dataGridView1.Text = "Selected PDF: ";
        }
        private DataTable generatePDFDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("File Name");
            dt.Columns.Add("File Size");
            dt.Columns.Add("File Type");
            dt.Columns.Add("File Created");
            dt.Columns.Add("File Modified");
            dt.Columns.Add("File Accessed");
            dt.Columns.Add("File Owner");
            dt.Columns.Add("File Path");

            string[] files = Directory.GetFiles(Constants.TAGGED_PDF_FOLDER_PATH);

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                FileSystemInfo fsi = new FileInfo(file);

                if (fsi.Extension != ".pdf") continue;

                DataRow dr = dt.NewRow();

                dr["File Name"] = fsi.Name;
                dr["File Size"] = info.Length;
                dr["File Type"] = fsi.Extension;
                dr["File Created"] = info.CreationTime;
                dr["File Modified"] = info.LastWriteTime;
                dr["File Accessed"] = info.LastAccessTime;
                dr["File Owner"] = info.GetAccessControl().GetOwner(typeof(NTAccount));
                dr["File Path"] = info.FullName;
                dt.Rows.Add(dr);
            }

            return dt;
        }
        private void populateSoftwaresDgv(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }
       
        
        private DataSet generateDataSet(string sqlQuery)
        {
            return DBConnections.getInstanceOfDBConnection().getDataSet(sqlQuery);
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

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

        private void bttn_web_Click(object sender, EventArgs e)
        {
            try
            {
                webpageOpener.openWepage(dataGridView1.SelectedRows[7].ToString());
            }
            catch (Exception)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginPage().Show();
        }

        private void bttn_down_Click(object sender, EventArgs e)
        {
            int currentIndex = dataGridView1.CurrentCell.RowIndex;
            if (currentIndex < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[currentIndex + 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
            }
            updateLabelName();
            updateLabelDesc();

        }

        private void bttn_up_Click(object sender, EventArgs e)
        {
            int currentIndex = dataGridView1.CurrentCell.RowIndex;
            if (currentIndex > 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[currentIndex - 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
            }
            updateLabelName();
            updateLabelDesc();

        }

        private void bttn_refresh_Click(object sender, EventArgs e)
        {
            updateLabelName();
            updateLabelDesc();
        }
        private void updateLabelName ()
        {
            //updates the label to show the selected PDF
            if (dataGridView1.SelectedRows.Count == 1)
                lbl_name.Text =
                    "Selected PDF:\n" + dataGridView1.SelectedRows[0].Cells[0].Value;
            else
                lbl_name.Text = "Selected PDF: ";
        }
        private void updateLabelDesc()
        {
            //updates the label to show the selected PDF
            if (dataGridView1.SelectedRows.Count == 1)
                lbl_desc.Text =
                    "Selected PDF:\n" + dataGridView1.SelectedRows[0].Cells[1].Value;
            else
                lbl_desc.Text = "Selected PDF: ";
        }
    }
    
}