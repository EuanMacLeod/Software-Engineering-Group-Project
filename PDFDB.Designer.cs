namespace Software_Engineering_Project_New
{
    partial class PDFDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pDFDataSet = new Software_Engineering_Project_New.PDFDataSet();
            this.tblPDFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPDFTableAdapter = new Software_Engineering_Project_New.PDFDataSetTableAdapters.tblPDFTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPDFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(179, 228);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pdfnameDataGridViewTextBoxColumn,
            this.pdfauthorDataGridViewTextBoxColumn,
            this.pdfURLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPDFBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 148);
            this.dataGridView1.TabIndex = 1;
            // 
            // pDFDataSet
            // 
            this.pDFDataSet.DataSetName = "PDFDataSet";
            this.pDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPDFBindingSource
            // 
            this.tblPDFBindingSource.DataMember = "tblPDF";
            this.tblPDFBindingSource.DataSource = this.pDFDataSet;
            // 
            // tblPDFTableAdapter
            // 
            this.tblPDFTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // pdfnameDataGridViewTextBoxColumn
            // 
            this.pdfnameDataGridViewTextBoxColumn.DataPropertyName = "pdf_name";
            this.pdfnameDataGridViewTextBoxColumn.HeaderText = "pdf_name";
            this.pdfnameDataGridViewTextBoxColumn.Name = "pdfnameDataGridViewTextBoxColumn";
            // 
            // pdfauthorDataGridViewTextBoxColumn
            // 
            this.pdfauthorDataGridViewTextBoxColumn.DataPropertyName = "pdf_author";
            this.pdfauthorDataGridViewTextBoxColumn.HeaderText = "pdf_author";
            this.pdfauthorDataGridViewTextBoxColumn.Name = "pdfauthorDataGridViewTextBoxColumn";
            // 
            // pdfURLDataGridViewTextBoxColumn
            // 
            this.pdfURLDataGridViewTextBoxColumn.DataPropertyName = "pdf_URL";
            this.pdfURLDataGridViewTextBoxColumn.HeaderText = "pdf_URL";
            this.pdfURLDataGridViewTextBoxColumn.Name = "pdfURLDataGridViewTextBoxColumn";
            // 
            // button_upload
            // 
            this.button_upload.Location = new System.Drawing.Point(42, 192);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(75, 23);
            this.button_upload.TabIndex = 2;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // PDFDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 272);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_exit);
            this.Name = "PDFDB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PDFDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPDFBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PDFDataSet pDFDataSet;
        private System.Windows.Forms.BindingSource tblPDFBindingSource;
        private PDFDataSetTableAdapters.tblPDFTableAdapter tblPDFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_upload;
    }
}