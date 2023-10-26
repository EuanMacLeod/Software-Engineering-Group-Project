using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project_New
{
    public partial class PDFDB : Form
    {
        String connectionString = @"Data Source=DESKTOP-37PB8E2\SQLEXPRESS;Initial Catalog=PDF;Integrated Security=True";

        public object FormPDF { get; private set; }

        private void changeLabel(Label tartgetlabel, String newText)
        {
            tartgetlabel.Text = newText;

        }

        
        private void setVisable(Label tartgetlabel)
        {
            tartgetlabel.Visible = true;

        }


        public PDFDB()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PDFDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDFDataSet.tblPDF' table. You can move, or remove it, as needed.
            this.tblPDFTableAdapter.Fill(this.pDFDataSet.tblPDF);


        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            UploadPDF UPDF = new UploadPDF();
            UPDF.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void outputToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblPDFTableAdapter.Output(this.pDFDataSet.tblPDF);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

  
        private void button_view_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedCells)
            {
                String value = row.Cells["ColumnName"].Value.ToString();

                MessageBox.Show(value);
            }
        }



        private void button_test_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    for (int i = 0;
                        i < selectedCellCount; i++)
                    {
                        sb.Append("Http://");
                        sb.Append(dataGridView1.SelectedCells[i].Value.ToString());

                    }

                    MessageBox.Show(sb.ToString(), " Opening in new browser");
                    PDF pdf = new PDF();

                    try
                    {
                        Uri uri = new Uri(sb.ToString());
                        
                        pdf.webBrowser1.Url = uri;

                    }
                    catch (UriFormatException ex)
                    {
                        MessageBox.Show("Inavild URL: " + ex.Message);
                    }
                    
                    foreach(Form openForm in Application.OpenForms)
                    {
                        if (openForm is PDF)
                        {
                            openForm.Close();
                            break;
                        }
                    }
                    MessageBox.Show("Opening new PDF window. Download will start");
                    this.Hide();
                    pdf.Show();
                    

                }
                
                
            }


        }
    }
}
