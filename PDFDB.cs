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
    public partial class PDFDB : Form
    {
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
    }
}
