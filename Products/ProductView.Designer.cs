namespace Software_Engineering_Project_New.PDF
{
    partial class ProductView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.citisoftDataSet = new Software_Engineering_Project_New.CitisoftDataSet();
            this.softwaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwaresTableAdapter = new Software_Engineering_Project_New.CitisoftDataSetTableAdapters.SoftwaresTableAdapter();
            this.softwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfDemoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliableProfessionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.documentLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareIDDataGridViewTextBoxColumn,
            this.vendorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.additionalInformationDataGridViewTextBoxColumn,
            this.dateOfDemoDataGridViewTextBoxColumn,
            this.avaliableProfessionalDataGridViewCheckBoxColumn,
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn,
            this.documentLinkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.softwaresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // citisoftDataSet
            // 
            this.citisoftDataSet.DataSetName = "CitisoftDataSet";
            this.citisoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwaresBindingSource
            // 
            this.softwaresBindingSource.DataMember = "Softwares";
            this.softwaresBindingSource.DataSource = this.citisoftDataSet;
            // 
            // softwaresTableAdapter
            // 
            this.softwaresTableAdapter.ClearBeforeFill = true;
            // 
            // softwareIDDataGridViewTextBoxColumn
            // 
            this.softwareIDDataGridViewTextBoxColumn.DataPropertyName = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.HeaderText = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.softwareIDDataGridViewTextBoxColumn.Name = "softwareIDDataGridViewTextBoxColumn";
            this.softwareIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.softwareIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            this.vendorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // additionalInformationDataGridViewTextBoxColumn
            // 
            this.additionalInformationDataGridViewTextBoxColumn.DataPropertyName = "Additional Information";
            this.additionalInformationDataGridViewTextBoxColumn.HeaderText = "Additional Information";
            this.additionalInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInformationDataGridViewTextBoxColumn.Name = "additionalInformationDataGridViewTextBoxColumn";
            this.additionalInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfDemoDataGridViewTextBoxColumn
            // 
            this.dateOfDemoDataGridViewTextBoxColumn.DataPropertyName = "Date of Demo";
            this.dateOfDemoDataGridViewTextBoxColumn.HeaderText = "Date of Demo";
            this.dateOfDemoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfDemoDataGridViewTextBoxColumn.Name = "dateOfDemoDataGridViewTextBoxColumn";
            this.dateOfDemoDataGridViewTextBoxColumn.Width = 125;
            // 
            // avaliableProfessionalDataGridViewCheckBoxColumn
            // 
            this.avaliableProfessionalDataGridViewCheckBoxColumn.DataPropertyName = "Avaliable Professional";
            this.avaliableProfessionalDataGridViewCheckBoxColumn.HeaderText = "Avaliable Professional";
            this.avaliableProfessionalDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.avaliableProfessionalDataGridViewCheckBoxColumn.Name = "avaliableProfessionalDataGridViewCheckBoxColumn";
            this.avaliableProfessionalDataGridViewCheckBoxColumn.Width = 125;
            // 
            // cloudServicesAvaliableDataGridViewCheckBoxColumn
            // 
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.DataPropertyName = "Cloud Services Avaliable";
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.HeaderText = "Cloud Services Avaliable";
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.Name = "cloudServicesAvaliableDataGridViewCheckBoxColumn";
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // documentLinkDataGridViewTextBoxColumn
            // 
            this.documentLinkDataGridViewTextBoxColumn.DataPropertyName = "Document Link";
            this.documentLinkDataGridViewTextBoxColumn.HeaderText = "Document Link";
            this.documentLinkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentLinkDataGridViewTextBoxColumn.Name = "documentLinkDataGridViewTextBoxColumn";
            this.documentLinkDataGridViewTextBoxColumn.Width = 125;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(114, 375);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // PDFDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PDFDB";
            this.Text = "PDFDB";
            this.Load += new System.EventHandler(this.PDFDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CitisoftDataSet citisoftDataSet;
        private System.Windows.Forms.BindingSource softwaresBindingSource;
        private CitisoftDataSetTableAdapters.SoftwaresTableAdapter softwaresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfDemoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn avaliableProfessionalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cloudServicesAvaliableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_exit;
    }
}