namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    partial class DatabaseEngineerPdfTaggingPage
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
            this.attachedPDFLabel = new System.Windows.Forms.Label();
            this.openAttachedPDFButton = new System.Windows.Forms.Button();
            this.SoftwareDgvLabel = new System.Windows.Forms.Label();
            this.pdfDgvLabel = new System.Windows.Forms.Label();
            this.UntagButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntaggedPDFViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwares)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUntaggedPDFViewer
            // 
            this.dgvUntaggedPDFViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUntaggedPDFViewer.Location = new System.Drawing.Point(1006, 50);
            this.dgvUntaggedPDFViewer.Name = "dgvUntaggedPDFViewer";
            this.dgvUntaggedPDFViewer.ReadOnly = true;
            this.dgvUntaggedPDFViewer.RowHeadersWidth = 62;
            this.dgvUntaggedPDFViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUntaggedPDFViewer.Size = new System.Drawing.Size(639, 378);
            this.dgvUntaggedPDFViewer.TabIndex = 0;
            this.dgvUntaggedPDFViewer.SelectionChanged += new System.EventHandler(this.dgvUntaggedPDFViewer_SelectionChanged);
            // 
            // dgvSoftwares
            // 
            this.dgvSoftwares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoftwares.Location = new System.Drawing.Point(12, 50);
            this.dgvSoftwares.Name = "dgvSoftwares";
            this.dgvSoftwares.ReadOnly = true;
            this.dgvSoftwares.RowHeadersWidth = 62;
            this.dgvSoftwares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoftwares.Size = new System.Drawing.Size(615, 378);
            this.dgvSoftwares.TabIndex = 1;
            this.dgvSoftwares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftwares_CellContentClick);
            this.dgvSoftwares.SelectionChanged += new System.EventHandler(this.dgvSoftwares_SelectionChanged);
            // 
            // SelectedPDFLabel
            // 
            this.SelectedPDFLabel.AutoSize = true;
            this.SelectedPDFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPDFLabel.Location = new System.Drawing.Point(1000, 445);
            this.SelectedPDFLabel.Name = "SelectedPDFLabel";
            this.SelectedPDFLabel.Size = new System.Drawing.Size(190, 31);
            this.SelectedPDFLabel.TabIndex = 2;
            this.SelectedPDFLabel.Text = "Selected PDF:";
            // 
            // openPDFButton
            // 
            this.openPDFButton.Location = new System.Drawing.Point(1006, 539);
            this.openPDFButton.Name = "openPDFButton";
            this.openPDFButton.Size = new System.Drawing.Size(184, 23);
            this.openPDFButton.TabIndex = 3;
            this.openPDFButton.Text = "Open Selected PDF";
            this.openPDFButton.UseVisualStyleBackColor = true;
            this.openPDFButton.Click += new System.EventHandler(this.openPDFButton_Click);
            // 
            // SelectedSoftwareLabel
            // 
            this.SelectedSoftwareLabel.AutoSize = true;
            this.SelectedSoftwareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedSoftwareLabel.Location = new System.Drawing.Point(12, 445);
            this.SelectedSoftwareLabel.Name = "SelectedSoftwareLabel";
            this.SelectedSoftwareLabel.Size = new System.Drawing.Size(243, 31);
            this.SelectedSoftwareLabel.TabIndex = 4;
            this.SelectedSoftwareLabel.Text = "Selected Software:";
            // 
            // TagButton
            // 
            this.TagButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagButton.Location = new System.Drawing.Point(712, 117);
            this.TagButton.Name = "TagButton";
            this.TagButton.Size = new System.Drawing.Size(216, 96);
            this.TagButton.TabIndex = 5;
            this.TagButton.Text = "<= Tag PDF => To Software";
            this.TagButton.UseVisualStyleBackColor = true;
            this.TagButton.Click += new System.EventHandler(this.tagButton_clicked);
            // 
            // attachedPDFLabel
            // 
            this.attachedPDFLabel.AutoSize = true;
            this.attachedPDFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachedPDFLabel.Location = new System.Drawing.Point(15, 539);
            this.attachedPDFLabel.Name = "attachedPDFLabel";
            this.attachedPDFLabel.Size = new System.Drawing.Size(192, 31);
            this.attachedPDFLabel.TabIndex = 6;
            this.attachedPDFLabel.Text = "Attached PDF:";
            // 
            // openAttachedPDFButton
            // 
            this.openAttachedPDFButton.Location = new System.Drawing.Point(18, 624);
            this.openAttachedPDFButton.Name = "openAttachedPDFButton";
            this.openAttachedPDFButton.Size = new System.Drawing.Size(189, 23);
            this.openAttachedPDFButton.TabIndex = 7;
            this.openAttachedPDFButton.Text = "Open Attached PDF";
            this.openAttachedPDFButton.UseVisualStyleBackColor = true;
            this.openAttachedPDFButton.Click += new System.EventHandler(this.openAttachedPDFButton_Click);
            // 
            // SoftwareDgvLabel
            // 
            this.SoftwareDgvLabel.AutoSize = true;
            this.SoftwareDgvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareDgvLabel.Location = new System.Drawing.Point(12, 17);
            this.SoftwareDgvLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SoftwareDgvLabel.Name = "SoftwareDgvLabel";
            this.SoftwareDgvLabel.Size = new System.Drawing.Size(144, 31);
            this.SoftwareDgvLabel.TabIndex = 8;
            this.SoftwareDgvLabel.Text = "Softwares:";
            // 
            // pdfDgvLabel
            // 
            this.pdfDgvLabel.AutoSize = true;
            this.pdfDgvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfDgvLabel.Location = new System.Drawing.Point(1000, 17);
            this.pdfDgvLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pdfDgvLabel.Name = "pdfDgvLabel";
            this.pdfDgvLabel.Size = new System.Drawing.Size(206, 31);
            this.pdfDgvLabel.TabIndex = 9;
            this.pdfDgvLabel.Text = "Unsorted PDF\'s";
            // 
            // UntagButton
            // 
            this.UntagButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UntagButton.Location = new System.Drawing.Point(712, 332);
            this.UntagButton.Name = "UntagButton";
            this.UntagButton.Size = new System.Drawing.Size(216, 96);
            this.UntagButton.TabIndex = 10;
            this.UntagButton.Text = "<= Untag Selected PDF From Software";
            this.UntagButton.UseVisualStyleBackColor = true;
            this.UntagButton.Click += new System.EventHandler(this.untagButton_clicked);
            // 
            // DatabaseEngineerPdfTaggingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.UntagButton);
            this.Controls.Add(this.pdfDgvLabel);
            this.Controls.Add(this.SoftwareDgvLabel);
            this.Controls.Add(this.openAttachedPDFButton);
            this.Controls.Add(this.attachedPDFLabel);
            this.Controls.Add(this.TagButton);
            this.Controls.Add(this.SelectedSoftwareLabel);
            this.Controls.Add(this.openPDFButton);
            this.Controls.Add(this.SelectedPDFLabel);
            this.Controls.Add(this.dgvSoftwares);
            this.Controls.Add(this.dgvUntaggedPDFViewer);
            this.Name = "DatabaseEngineerPdfTaggingPage";
            this.Text = "DatabaseEngineerPdfTaggingPage";
            this.Load += new System.EventHandler(this.DatabaseEngineerPdfTaggingPage_Load);
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
        private System.Windows.Forms.Label attachedPDFLabel;
        private System.Windows.Forms.Button openAttachedPDFButton;
        private System.Windows.Forms.Label SoftwareDgvLabel;
        private System.Windows.Forms.Label pdfDgvLabel;
        private System.Windows.Forms.Button UntagButton;
    }
}