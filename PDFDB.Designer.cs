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
            this.button_upload = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_url = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPDFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDFDataSet = new Software_Engineering_Project_New.PDFDataSet();
            this.outputToolStrip = new System.Windows.Forms.ToolStrip();
            this.tblPDFTableAdapter = new Software_Engineering_Project_New.PDFDataSetTableAdapters.tblPDFTableAdapter();
            this.button_view = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPDFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(457, 331);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_upload
            // 
            this.button_upload.Location = new System.Drawing.Point(56, 236);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(100, 28);
            this.button_upload.TabIndex = 2;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(84, 13);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(20, 16);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "ID";
            this.label_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(184, 13);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 16);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Name";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(295, 13);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(45, 16);
            this.label_author.TabIndex = 5;
            this.label_author.Text = "Author";
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(432, 13);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(34, 16);
            this.label_url.TabIndex = 6;
            this.label_url.Text = "URL";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.Window;
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_refresh.Location = new System.Drawing.Point(217, 291);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(100, 28);
            this.button_refresh.TabIndex = 11;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pdfnameDataGridViewTextBoxColumn,
            this.pdfauthorDataGridViewTextBoxColumn,
            this.pdfURLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPDFBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 199);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pdfnameDataGridViewTextBoxColumn
            // 
            this.pdfnameDataGridViewTextBoxColumn.DataPropertyName = "pdf_name";
            this.pdfnameDataGridViewTextBoxColumn.HeaderText = "pdf_name";
            this.pdfnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pdfnameDataGridViewTextBoxColumn.Name = "pdfnameDataGridViewTextBoxColumn";
            this.pdfnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdfnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pdfauthorDataGridViewTextBoxColumn
            // 
            this.pdfauthorDataGridViewTextBoxColumn.DataPropertyName = "pdf_author";
            this.pdfauthorDataGridViewTextBoxColumn.HeaderText = "pdf_author";
            this.pdfauthorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pdfauthorDataGridViewTextBoxColumn.Name = "pdfauthorDataGridViewTextBoxColumn";
            this.pdfauthorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdfauthorDataGridViewTextBoxColumn.Width = 125;
            // 
            // pdfURLDataGridViewTextBoxColumn
            // 
            this.pdfURLDataGridViewTextBoxColumn.DataPropertyName = "pdf_URL";
            this.pdfURLDataGridViewTextBoxColumn.HeaderText = "pdf_URL";
            this.pdfURLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pdfURLDataGridViewTextBoxColumn.Name = "pdfURLDataGridViewTextBoxColumn";
            this.pdfURLDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdfURLDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPDFBindingSource
            // 
            this.tblPDFBindingSource.DataMember = "tblPDF";
            this.tblPDFBindingSource.DataSource = this.pDFDataSet;
            // 
            // pDFDataSet
            // 
            this.pDFDataSet.DataSetName = "PDFDataSet";
            this.pDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outputToolStrip
            // 
            this.outputToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.outputToolStrip.Location = new System.Drawing.Point(0, 0);
            this.outputToolStrip.Name = "outputToolStrip";
            this.outputToolStrip.Size = new System.Drawing.Size(612, 25);
            this.outputToolStrip.TabIndex = 13;
            this.outputToolStrip.Text = "outputToolStrip";
            // 
            // tblPDFTableAdapter
            // 
            this.tblPDFTableAdapter.ClearBeforeFill = true;
            // 
            // button_view
            // 
            this.button_view.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_view.Location = new System.Drawing.Point(56, 291);
            this.button_view.Margin = new System.Windows.Forms.Padding(4);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(100, 28);
            this.button_view.TabIndex = 14;
            this.button_view.Text = "View";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // button_test
            // 
            this.button_test.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_test.Location = new System.Drawing.Point(417, 245);
            this.button_test.Margin = new System.Windows.Forms.Padding(4);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(155, 28);
            this.button_test.TabIndex = 15;
            this.button_test.Text = "Copy ";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // PDFDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(612, 385);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.outputToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_exit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PDFDB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PDFDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPDFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private PDFDataSet pDFDataSet;
        private System.Windows.Forms.BindingSource tblPDFBindingSource;
        private PDFDataSetTableAdapters.tblPDFTableAdapter tblPDFTableAdapter;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip outputToolStrip;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button button_test;
    }
}