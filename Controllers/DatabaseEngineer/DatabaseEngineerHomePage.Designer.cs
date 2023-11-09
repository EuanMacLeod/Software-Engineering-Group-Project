namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    partial class DatabaseEngineerHomePage
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
            this.dgvUntaggedPDFViewer = new System.Windows.Forms.DataGridView();
            this.dgvSoftwares = new System.Windows.Forms.DataGridView();
            this.SelectedPDFLabel = new System.Windows.Forms.Label();
            this.openPDFButton = new System.Windows.Forms.Button();
            this.SelectedSoftwareLabel = new System.Windows.Forms.Label();
            this.TagButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntaggedPDFViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwares)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUntaggedPDFViewer
            // 
            this.dgvUntaggedPDFViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUntaggedPDFViewer.Location = new System.Drawing.Point(1324, 62);
            this.dgvUntaggedPDFViewer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUntaggedPDFViewer.Name = "dgvUntaggedPDFViewer";
            this.dgvUntaggedPDFViewer.ReadOnly = true;
            this.dgvUntaggedPDFViewer.RowHeadersWidth = 51;
            this.dgvUntaggedPDFViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUntaggedPDFViewer.Size = new System.Drawing.Size(852, 465);
            this.dgvUntaggedPDFViewer.TabIndex = 0;
            this.dgvUntaggedPDFViewer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUntaggedPDFViewer_CellContentClick);
            this.dgvUntaggedPDFViewer.SelectionChanged += new System.EventHandler(this.dgvUntaggedPDFViewer_SelectionChanged);
            // 
            // dgvSoftwares
            // 
            this.dgvSoftwares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoftwares.Location = new System.Drawing.Point(16, 62);
            this.dgvSoftwares.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoftwares.Name = "dgvSoftwares";
            this.dgvSoftwares.ReadOnly = true;
            this.dgvSoftwares.RowHeadersWidth = 51;
            this.dgvSoftwares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoftwares.Size = new System.Drawing.Size(820, 465);
            this.dgvSoftwares.TabIndex = 1;
            this.dgvSoftwares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftwares_CellContentClick);
            this.dgvSoftwares.SelectionChanged += new System.EventHandler(this.dgvSoftwares_SelectionChanged);
            // 
            // SelectedPDFLabel
            // 
            this.SelectedPDFLabel.AutoSize = true;
            this.SelectedPDFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPDFLabel.Location = new System.Drawing.Point(1333, 548);
            this.SelectedPDFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedPDFLabel.Name = "SelectedPDFLabel";
            this.SelectedPDFLabel.Size = new System.Drawing.Size(237, 39);
            this.SelectedPDFLabel.TabIndex = 2;
            this.SelectedPDFLabel.Text = "Selected PDF:";
            // 
            // openPDFButton
            // 
            this.openPDFButton.Location = new System.Drawing.Point(1341, 663);
            this.openPDFButton.Margin = new System.Windows.Forms.Padding(4);
            this.openPDFButton.Name = "openPDFButton";
            this.openPDFButton.Size = new System.Drawing.Size(156, 28);
            this.openPDFButton.TabIndex = 3;
            this.openPDFButton.Text = "Open Selected PDF";
            this.openPDFButton.UseVisualStyleBackColor = true;
            this.openPDFButton.Click += new System.EventHandler(this.openPDFButton_Click);
            // 
            // SelectedSoftwareLabel
            // 
            this.SelectedSoftwareLabel.AutoSize = true;
            this.SelectedSoftwareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedSoftwareLabel.Location = new System.Drawing.Point(16, 548);
            this.SelectedSoftwareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedSoftwareLabel.Name = "SelectedSoftwareLabel";
            this.SelectedSoftwareLabel.Size = new System.Drawing.Size(302, 39);
            this.SelectedSoftwareLabel.TabIndex = 4;
            this.SelectedSoftwareLabel.Text = "Selected Software:";
            // 
            // TagButton
            // 
            this.TagButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagButton.Location = new System.Drawing.Point(949, 409);
            this.TagButton.Margin = new System.Windows.Forms.Padding(4);
            this.TagButton.Name = "TagButton";
            this.TagButton.Size = new System.Drawing.Size(288, 118);
            this.TagButton.TabIndex = 5;
            this.TagButton.Text = "<= Tag PDF => To Software";
            this.TagButton.UseVisualStyleBackColor = true;
            // 
            // DatabaseEngineerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2356, 1021);
            this.Controls.Add(this.TagButton);
            this.Controls.Add(this.SelectedSoftwareLabel);
            this.Controls.Add(this.openPDFButton);
            this.Controls.Add(this.SelectedPDFLabel);
            this.Controls.Add(this.dgvSoftwares);
            this.Controls.Add(this.dgvUntaggedPDFViewer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatabaseEngineerHomePage";
            this.Text = "DatabaseEngineerHomePage";
            this.Load += new System.EventHandler(this.DatabaseEngineerHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntaggedPDFViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUntaggedPDFViewer;
        private System.Windows.Forms.DataGridView dgvSoftwares;
        private System.Windows.Forms.Label SelectedPDFLabel;
        private System.Windows.Forms.Button openPDFButton;
        private System.Windows.Forms.Label SelectedSoftwareLabel;
        private System.Windows.Forms.Button TagButton;
    }
}