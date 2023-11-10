using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    
    public partial class DatabaseEngineerHomePage : Form
    {
        private User user;

        public DatabaseEngineerHomePage(User pUser)
        {
            InitializeComponent();
            this.user = pUser;
        }

        private void DatabaseEngineerHomePage_Load(object sender, EventArgs e)
        {
            populatePDFDgv(generatePDFDataTable());
            populateSoftwaresDgv(generateDataSetFromQuery(Constants.SELECTALLSOFTWARES));


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

            string[] files = System.IO.Directory.GetFiles(Constants.UNTAGGED_PDF_FOLDER_PATH);

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
                dr["File Owner"] = info.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount));
                dt.Rows.Add(dr);
            }

            return dt;

        }

        private DataSet generateDataSetFromQuery(string sqlQuery)
        {
            return DBConnections.getInstanceOfDBConnection().getDataSet(sqlQuery);
        }

        private void populateSoftwaresDgv(DataSet ds)
        {
            dgvSoftwares.DataSource = ds.Tables[0];
        }


        private void populatePDFDgv(DataTable dt)
        {
            dgvUntaggedPDFViewer.DataSource = dt;
        }

        private void dgvUntaggedPDFViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }


        private void dgvUntaggedPDFViewer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUntaggedPDFViewer.SelectedRows.Count > 1)
            {
                dgvUntaggedPDFViewer.SelectedRows[0].Selected = false;
            }
            updateSelectedPDFLabel();
        }

        private void updateSelectedPDFLabel()
        {
            if (dgvUntaggedPDFViewer.SelectedRows.Count == 1)
            {
                SelectedPDFLabel.Text = "Selected PDF:\n" + dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                SelectedPDFLabel.Text = "Selected PDF: ";
            }
        }


        private void dgvSoftwares_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSoftwares.SelectedRows.Count > 1)
            {
                dgvSoftwares.SelectedRows[0].Selected = false;
            }
            updateSelectedSoftwareLabel();
        }

        private void updateSelectedSoftwareLabel()
        {
            if (dgvSoftwares.SelectedRows.Count == 1)
            {
                SelectedSoftwareLabel.Text = "Selected Software:\n" + dgvSoftwares.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                SelectedSoftwareLabel.Text = "Selected Software: ";
            }
        }


        public void tagButton_clicked(object sender, EventArgs e)
        {

            if (dgvSoftwares.SelectedRows[0].Cells[8].Value.ToString() != "")
            {
                MessageBox.Show("Software Already Has An Attached PDF");
            }

            DialogResult dr = MessageBox.Show("You Are Tagging:\n" + dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value.ToString() +"\nTo:\n" + dgvSoftwares.SelectedRows[0].Cells[2].Value.ToString(), "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //todo move selected document from untagged to tagged
                //todo update software table with new document
                
            }

            /*
            if (dgvUntaggedPDFViewer.SelectedRows.Count == 1 && dgvSoftwares.SelectedRows.Count == 1)
            {
                string pdfName = dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value.ToString();
                string softwareName = dgvSoftwares.SelectedRows[0].Cells[2].Value.ToString();

                string pdfPath = Constants.UNTAGGED_PDF_FOLDER_PATH + pdfName;
                string softwarePath = Constants.SOFTWARE_FOLDER_PATH + softwareName;

                string taggedPDFPath = Constants.TAGGED_PDF_FOLDER_PATH + pdfName;

                if (File.Exists(taggedPDFPath))
                {
                    MessageBox.Show("Tagged PDF already exists");
                    return;
                }

                if (!File.Exists(pdfPath))
                {
                    MessageBox.Show("PDF does not exist");
                    return;
                }

                if (!File.Exists(softwarePath))
                {
                    MessageBox.Show("Software does not exist");
                    return;
                }

                File.Copy(pdfPath, taggedPDFPath);
                File.AppendAllText(taggedPDFPath, softwareName);

                MessageBox.Show("Tagged PDF created successfully");
                populatePDFDgv(generatePDFDataTable());
            }
            else
            {
                MessageBox.Show("Please select one PDF and one Software");
            }
            */
        }








    }
}
