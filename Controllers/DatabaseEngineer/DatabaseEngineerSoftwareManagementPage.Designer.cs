namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    partial class DatabaseEngineerSoftwareManagementPage
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
            this.SoftwaresDgv = new System.Windows.Forms.DataGridView();
            this.citisoftSoftwaresDataSet = new Software_Engineering_Project_New.CitisoftSoftwaresDataSet();
            this.citisoftSoftwaresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SoftwaresDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftSoftwaresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftSoftwaresDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SoftwaresDgv
            // 
            this.SoftwaresDgv.AllowUserToAddRows = false;
            this.SoftwaresDgv.AllowUserToDeleteRows = false;
            this.SoftwaresDgv.AutoGenerateColumns = false;
            this.SoftwaresDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftwaresDgv.DataSource = this.citisoftSoftwaresDataSetBindingSource;
            this.SoftwaresDgv.Location = new System.Drawing.Point(0, 0);
            this.SoftwaresDgv.MultiSelect = false;
            this.SoftwaresDgv.Name = "SoftwaresDgv";
            this.SoftwaresDgv.ReadOnly = true;
            this.SoftwaresDgv.RowHeadersWidth = 62;
            this.SoftwaresDgv.RowTemplate.Height = 28;
            this.SoftwaresDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SoftwaresDgv.Size = new System.Drawing.Size(1015, 512);
            this.SoftwaresDgv.TabIndex = 0;
            // 
            // citisoftSoftwaresDataSet
            // 
            this.citisoftSoftwaresDataSet.DataSetName = "CitisoftSoftwaresDataSet";
            this.citisoftSoftwaresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citisoftSoftwaresDataSetBindingSource
            // 
            this.citisoftSoftwaresDataSetBindingSource.DataSource = this.citisoftSoftwaresDataSet;
            this.citisoftSoftwaresDataSetBindingSource.Position = 0;
            // 
            // DatabaseEngineerSoftwareManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 669);
            this.Controls.Add(this.SoftwaresDgv);
            this.Name = "DatabaseEngineerSoftwareManagementPage";
            this.Text = "DatabaseEngineerSoftwareManagementPage";
            this.Load += new System.EventHandler(this.LoadSoftwaresDgv);
            ((System.ComponentModel.ISupportInitialize)(this.SoftwaresDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftSoftwaresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftSoftwaresDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SoftwaresDgv;
        private System.Windows.Forms.BindingSource citisoftSoftwaresDataSetBindingSource;
        private CitisoftSoftwaresDataSet citisoftSoftwaresDataSet;
    }
}