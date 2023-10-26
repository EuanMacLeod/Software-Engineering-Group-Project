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

    

    public partial class UploadPDF : Form
    {
        String connectionString = @"Data Source=DESKTOP-37PB8E2\SQLEXPRESS;Initial Catalog = PDF; Integrated Security = True";


        public UploadPDF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            if (txt_url.Text == "" || txt_name.Text == "")
            {
                MessageBox.Show("All fields are mandatory");
            }

            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("pdfadd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@pdf_name", txt_name.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@pdf_author", txt_author.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@pdf_url", txt_url.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Upload is sucessfull");

                }
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
