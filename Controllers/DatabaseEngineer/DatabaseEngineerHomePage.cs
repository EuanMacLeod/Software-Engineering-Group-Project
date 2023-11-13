using System;
using System.Data;
using System.IO;
using System.Security.Principal;
using System.Transactions;
using System.Windows.Forms;
using Software_Engineering_Project_New.Helper_Classes;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    public partial class DatabaseEngineerHomePage : Form
    {
        private readonly User user;

        public DatabaseEngineerHomePage(User pUser)
        {
            InitializeComponent();
            user = pUser;
            WindowState = FormWindowState.Maximized;
            MinimumSize = Size;
            MaximumSize = Size;
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
            dt.Columns.Add("File Path");

            string[] files = Directory.GetFiles(Constants.UNTAGGED_PDF_FOLDER_PATH);

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
            dgvSoftwares.DataSource = dt;
        }


        private void populatePDFDgv(DataTable dt)
        {
            dgvUntaggedPDFViewer.DataSource = dt;
        }


        private void dgvUntaggedPDFViewer_SelectionChanged(object sender, EventArgs e)
        {
            //ensures that only one row of the PDF dgv can be selected at a time
            if (dgvUntaggedPDFViewer.SelectedRows.Count > 1) dgvUntaggedPDFViewer.SelectedRows[0].Selected = false;

            updateSelectedPDFLabel();
        }

        private void updateSelectedPDFLabel()
        {
            //updates the label to show the selected PDF
            if (dgvUntaggedPDFViewer.SelectedRows.Count == 1)
                SelectedPDFLabel.Text =
                    "Selected PDF:\n" + dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value;
            else
                SelectedPDFLabel.Text = "Selected PDF: ";
        }


        private void dgvSoftwares_SelectionChanged(object sender, EventArgs e)
        {
            //ensures that only one row of the Softwares dgv can be selected at a time
            if (dgvSoftwares.SelectedRows.Count > 1) dgvSoftwares.SelectedRows[0].Selected = false;

            updateSelectedSoftwareLabel();
            updateAttachedPDFLabel();
        }

        private void updateSelectedSoftwareLabel()
        {
            //updates the label to show the selected Software
            if (dgvSoftwares.SelectedRows.Count == 1)
                SelectedSoftwareLabel.Text =
                    "Selected Software:\n" + dgvSoftwares.SelectedRows[0].Cells[2].Value;
            else
                SelectedSoftwareLabel.Text = "Selected Software: ";
        }

        private void updateAttachedPDFLabel()
        {
            //updates the label to show the selected Software
            if (dgvSoftwares.SelectedRows.Count == 1)
                attachedPDFLabel.Text =
                    "Attached PDF:\n" + dgvSoftwares.SelectedRows[0].Cells[8].Value.ToString()
                        .Replace(Constants.TAGGED_PDF_FOLDER_PATH, "");
            else
                attachedPDFLabel.Text = "Attached PDF: ";
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

        public void movePdf(string source, string destination)
        {
            //Checks if destination file already exists and deletes it if so
            if (File.Exists(destination)) File.Delete(destination);

            //Moves the file
            File.Move(source, destination);
        }


        public void tagButton_clicked(object sender, EventArgs e)
        {
            //checks that only one row is selected from each dgv
            if (dgvUntaggedPDFViewer.SelectedRows.Count != 1 || dgvSoftwares.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select 1 software and 1 pdf");
                return;
            }

            //Checks if the selected software already has a PDF attached
            if (dgvSoftwares.SelectedRows[0].Cells[8].Value.ToString() != "")
            {
                MessageBox.Show("Software Already Has An Attached PDF");
                return;
            }

            //asks the user to confirm that the document being tagged to the software is correct
            DialogResult dr = MessageBox.Show(
                "You Are Tagging:\n" + dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value + "\nTo:\n" +
                dgvSoftwares.SelectedRows[0].Cells[2].Value, "confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //todo move selected document from untagged to tagged
                string pdfName = dgvUntaggedPDFViewer.SelectedRows[0].Cells[0].Value.ToString();

                string untaggedPDFPath = Path.Combine(Constants.UNTAGGED_PDF_FOLDER_PATH + pdfName);
                string taggedPDFPath = Path.Combine(Constants.TAGGED_PDF_FOLDER_PATH + pdfName);


                try
                {
                    //this using block ensure that both the file is moved and that the database is updated, if either fail then the changes are rolled back
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        movePdf(untaggedPDFPath, taggedPDFPath);

                        DBConnections.getInstanceOfDBConnection().updateSoftware(
                            Convert.ToInt32(dgvSoftwares.SelectedRows[0].Cells[0].Value.ToString()), taggedPDFPath);

                        transaction.Complete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                populatePDFDgv(generatePDFDataTable());
                populateSoftwaresDgv(DBConnections.getInstanceOfDBConnection()
                    .getDataTable(Constants.SELECTALLSOFTWARES));
            }
        }


        private void openPDFButton_Click(object sender, EventArgs e)
        {
            //send the filepath of the selected PDF to the webpage opener so it can be viewed
            webpageOpener.openWepage(dgvUntaggedPDFViewer.SelectedRows[0].Cells[7].Value.ToString());
        }

        private void openAttachedPDFButton_Click(object sender, EventArgs e)
        {
            //send the filepath of the selected PDF to the webpage opener so it can be viewed
            webpageOpener.openWepage(dgvSoftwares.SelectedRows[0].Cells[8].Value.ToString());
        }

        private void dgvSoftwares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}