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
using Software_Engineering_Project_New.Helper_Classes;

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
            populateSoftwaresDgv(DBConnections.getInstanceOfDBConnection().getDataTable(Constants.SELECTALLSOFTWARES));

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
            dt.Columns.Add("URL");

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
                dr["URL"] = info.FullName;
                dt.Rows.Add(dr);
            }

            return dt;

        }


        private void populateSoftwaresDgv(DataTable dt)
        {
            dgvSoftwares.DataSource = dt;
        }


        private void populatePDFDgv(DataTable dt)
        {
            dgvUntaggedPDFViewer.DataSource = dt;
        }


        private void dgvUntaggedPDFViewer_SelectionChanged(object sender, EventArgs e)
        {
            //ensures that only one row of the PDF dgv can be selected at a time
            if (dgvUntaggedPDFViewer.SelectedRows.Count > 1)
            {
                dgvUntaggedPDFViewer.SelectedRows[0].Selected = false;
            }

            updateSelectedPDFLabel();
        }

        private void updateSelectedPDFLabel()
        {
            //updates the label to show the selected PDF
            if (dgvUntaggedPDFViewer.SelectedRows.Count == 1)
            {
                SelectedPDFLabel.Text =
                    "Selected PDF:\n" + dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                SelectedPDFLabel.Text = "Selected PDF: ";
            }
        }


        private void dgvSoftwares_SelectionChanged(object sender, EventArgs e)
        {
            //ensures that only one row of the Softwares dgv can be selected at a time
            if (dgvSoftwares.SelectedRows.Count > 1)
            {
                dgvSoftwares.SelectedRows[0].Selected = false;
            }

            updateSelectedSoftwareLabel();
        }

        private void updateSelectedSoftwareLabel()
        {
            //updates the label to show the selected Software
            if (dgvSoftwares.SelectedRows.Count == 1)
            {
                SelectedSoftwareLabel.Text =
                    "Selected Software:\n" + dgvSoftwares.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                SelectedSoftwareLabel.Text = "Selected Software: ";
            }
        }


        
        private void copyLastCell()
        {
            if (dgvUntaggedPDFViewer.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvUntaggedPDFViewer.SelectedRows[0];

                // Determine the index of the last cell in the selected row
                int lastCellIndex = selectedRow.Cells.Count - 1;

                // Get the value of the last cell in the selected row
                string finalCellValue = selectedRow.Cells[lastCellIndex].Value.ToString();


                // Copy the value to the clipboard
                Clipboard.SetText(finalCellValue);

                MessageBox.Show("URL Copied", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No row is selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            OpenPDF openPDF = new OpenPDF(user);

            openPDF.Show();
        }

        public void movePdf()
        {
            //checks that only one row is selected from each dgv
            if (dgvUntaggedPDFViewer.SelectedRows.Count == 1 && dgvSoftwares.SelectedRows.Count == 1)
            {
                string pdfName = dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value.ToString();
                
                string untaggedPDFPath = System.IO.Path.Combine(Constants.UNTAGGED_PDF_FOLDER_PATH + pdfName);
                string taggedPDFPath = System.IO.Path.Combine(Constants.TAGGED_PDF_FOLDER_PATH + pdfName);

                try
                {
                    //Checks if destination file already exists and deletes it if so
                    if (File.Exists(taggedPDFPath))
                    {
                        File.Delete(taggedPDFPath);
                    }

                    //Moves the file
                    File.Move(untaggedPDFPath, taggedPDFPath);
                }
                catch (Exception e)
                {
                    Console.WriteLine("The process failed: {0}", e.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select one PDF and one Software");
            }

        }




        public void tagButton_clicked(object sender, EventArgs e)
        {

            //Checks if the selected software already has a PDF attached
            if (dgvSoftwares.SelectedRows[0].Cells[8].Value.ToString() != "")
            {
                MessageBox.Show("Software Already Has An Attached PDF");
                return;
            }

            //asks the user to confirm that the document being tagged to the software is correct
            DialogResult dr = MessageBox.Show("You Are Tagging:\n" + dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value.ToString() +"\nTo:\n" + dgvSoftwares.SelectedRows[0].Cells[2].Value.ToString(), "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //todo move selected document from untagged to tagged
                movePdf();
                populatePDFDgv(generatePDFDataTable());

                //todo update software table with new document
            }

        }





        private void openPDFButton_Click(object sender, EventArgs e)
        {
            //send the filepath of the selected PDF to the webpage opener so it can be viewed
            webpageOpener.openWepage(dgvUntaggedPDFViewer.SelectedRows[0].Cells[7].Value.ToString());
        }

        private void dgvSoftwares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
