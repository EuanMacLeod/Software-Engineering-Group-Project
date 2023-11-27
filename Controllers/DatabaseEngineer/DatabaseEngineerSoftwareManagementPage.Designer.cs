﻿namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
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
            this.citisoftSoftwaresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citisoftSoftwaresDataSet = new Software_Engineering_Project_New.CitisoftSoftwaresDataSet();
            this.SoftwareTypeDgv = new System.Windows.Forms.DataGridView();
            this.SoftwareModuleDgv = new System.Windows.Forms.DataGridView();
            this.ClientTypeDgv = new System.Windows.Forms.DataGridView();
            this.BuisnessAreasDgv = new System.Windows.Forms.DataGridView();
            this.SoftwaresLabel = new System.Windows.Forms.Label();
            this.SoftwareModuleLabel = new System.Windows.Forms.Label();
            this.ClientTypeLabel = new System.Windows.Forms.Label();
            this.SoftwareTypeLabel = new System.Windows.Forms.Label();
            this.BuisnessAreasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwaresDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftSoftwaresDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftSoftwaresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareTypeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareModuleDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTypeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuisnessAreasDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // SoftwaresDgv
            // 
            this.SoftwaresDgv.AllowUserToAddRows = false;
            this.SoftwaresDgv.AllowUserToDeleteRows = false;
            this.SoftwaresDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftwaresDgv.Location = new System.Drawing.Point(0, 55);
            this.SoftwaresDgv.MultiSelect = false;
            this.SoftwaresDgv.Name = "SoftwaresDgv";
            this.SoftwaresDgv.ReadOnly = true;
            this.SoftwaresDgv.RowHeadersWidth = 62;
            this.SoftwaresDgv.RowTemplate.Height = 28;
            this.SoftwaresDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SoftwaresDgv.Size = new System.Drawing.Size(910, 617);
            this.SoftwaresDgv.TabIndex = 0;
            this.SoftwaresDgv.SelectionChanged += new System.EventHandler(this.dgvSoftwares_SelectionChanged);
            // 
            // citisoftSoftwaresDataSetBindingSource
            // 
            this.citisoftSoftwaresDataSetBindingSource.DataSource = this.citisoftSoftwaresDataSet;
            this.citisoftSoftwaresDataSetBindingSource.Position = 0;
            // 
            // citisoftSoftwaresDataSet
            // 
            this.citisoftSoftwaresDataSet.DataSetName = "CitisoftSoftwaresDataSet";
            this.citisoftSoftwaresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SoftwareTypeDgv
            // 
            this.SoftwareTypeDgv.AllowUserToAddRows = false;
            this.SoftwareTypeDgv.AllowUserToDeleteRows = false;
            this.SoftwareTypeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftwareTypeDgv.Location = new System.Drawing.Point(916, 55);
            this.SoftwareTypeDgv.MultiSelect = false;
            this.SoftwareTypeDgv.Name = "SoftwareTypeDgv";
            this.SoftwareTypeDgv.ReadOnly = true;
            this.SoftwareTypeDgv.RowHeadersWidth = 62;
            this.SoftwareTypeDgv.RowTemplate.Height = 28;
            this.SoftwareTypeDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SoftwareTypeDgv.Size = new System.Drawing.Size(576, 271);
            this.SoftwareTypeDgv.TabIndex = 1;
            // 
            // SoftwareModuleDgv
            // 
            this.SoftwareModuleDgv.AllowUserToAddRows = false;
            this.SoftwareModuleDgv.AllowUserToDeleteRows = false;
            this.SoftwareModuleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoftwareModuleDgv.Location = new System.Drawing.Point(916, 402);
            this.SoftwareModuleDgv.MultiSelect = false;
            this.SoftwareModuleDgv.Name = "SoftwareModuleDgv";
            this.SoftwareModuleDgv.ReadOnly = true;
            this.SoftwareModuleDgv.RowHeadersWidth = 62;
            this.SoftwareModuleDgv.RowTemplate.Height = 28;
            this.SoftwareModuleDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SoftwareModuleDgv.Size = new System.Drawing.Size(576, 271);
            this.SoftwareModuleDgv.TabIndex = 2;
            // 
            // ClientTypeDgv
            // 
            this.ClientTypeDgv.AllowUserToAddRows = false;
            this.ClientTypeDgv.AllowUserToDeleteRows = false;
            this.ClientTypeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientTypeDgv.Location = new System.Drawing.Point(1498, 402);
            this.ClientTypeDgv.MultiSelect = false;
            this.ClientTypeDgv.Name = "ClientTypeDgv";
            this.ClientTypeDgv.ReadOnly = true;
            this.ClientTypeDgv.RowHeadersWidth = 62;
            this.ClientTypeDgv.RowTemplate.Height = 28;
            this.ClientTypeDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientTypeDgv.Size = new System.Drawing.Size(576, 271);
            this.ClientTypeDgv.TabIndex = 3;
            // 
            // BuisnessAreasDgv
            // 
            this.BuisnessAreasDgv.AllowUserToAddRows = false;
            this.BuisnessAreasDgv.AllowUserToDeleteRows = false;
            this.BuisnessAreasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuisnessAreasDgv.Location = new System.Drawing.Point(1498, 55);
            this.BuisnessAreasDgv.MultiSelect = false;
            this.BuisnessAreasDgv.Name = "BuisnessAreasDgv";
            this.BuisnessAreasDgv.ReadOnly = true;
            this.BuisnessAreasDgv.RowHeadersWidth = 62;
            this.BuisnessAreasDgv.RowTemplate.Height = 28;
            this.BuisnessAreasDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BuisnessAreasDgv.Size = new System.Drawing.Size(576, 271);
            this.BuisnessAreasDgv.TabIndex = 4;
            // 
            // SoftwaresLabel
            // 
            this.SoftwaresLabel.AutoSize = true;
            this.SoftwaresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwaresLabel.Location = new System.Drawing.Point(0, 0);
            this.SoftwaresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftwaresLabel.Name = "SoftwaresLabel";
            this.SoftwaresLabel.Size = new System.Drawing.Size(214, 47);
            this.SoftwaresLabel.TabIndex = 5;
            this.SoftwaresLabel.Text = "Softwares:";
            // 
            // SoftwareModuleLabel
            // 
            this.SoftwareModuleLabel.AutoSize = true;
            this.SoftwareModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareModuleLabel.Location = new System.Drawing.Point(918, 351);
            this.SoftwareModuleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftwareModuleLabel.Name = "SoftwareModuleLabel";
            this.SoftwareModuleLabel.Size = new System.Drawing.Size(361, 47);
            this.SoftwareModuleLabel.TabIndex = 6;
            this.SoftwareModuleLabel.Text = "Software Modules:";
            // 
            // ClientTypeLabel
            // 
            this.ClientTypeLabel.AutoSize = true;
            this.ClientTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientTypeLabel.Location = new System.Drawing.Point(1500, 351);
            this.ClientTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientTypeLabel.Name = "ClientTypeLabel";
            this.ClientTypeLabel.Size = new System.Drawing.Size(441, 47);
            this.ClientTypeLabel.TabIndex = 7;
            this.ClientTypeLabel.Text = "Financial Client Types:";
            // 
            // SoftwareTypeLabel
            // 
            this.SoftwareTypeLabel.AutoSize = true;
            this.SoftwareTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareTypeLabel.Location = new System.Drawing.Point(918, 5);
            this.SoftwareTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftwareTypeLabel.Name = "SoftwareTypeLabel";
            this.SoftwareTypeLabel.Size = new System.Drawing.Size(350, 47);
            this.SoftwareTypeLabel.TabIndex = 8;
            this.SoftwareTypeLabel.Text = "Type Of Software:";
            // 
            // BuisnessAreasLabel
            // 
            this.BuisnessAreasLabel.AutoSize = true;
            this.BuisnessAreasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuisnessAreasLabel.Location = new System.Drawing.Point(1500, 5);
            this.BuisnessAreasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuisnessAreasLabel.Name = "BuisnessAreasLabel";
            this.BuisnessAreasLabel.Size = new System.Drawing.Size(492, 47);
            this.BuisnessAreasLabel.TabIndex = 9;
            this.BuisnessAreasLabel.Text = "Software Buisness Areas:";
            // 
            // DatabaseEngineerSoftwareManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2120, 1160);
            this.Controls.Add(this.BuisnessAreasLabel);
            this.Controls.Add(this.SoftwareTypeLabel);
            this.Controls.Add(this.ClientTypeLabel);
            this.Controls.Add(this.SoftwareModuleLabel);
            this.Controls.Add(this.SoftwaresLabel);
            this.Controls.Add(this.BuisnessAreasDgv);
            this.Controls.Add(this.ClientTypeDgv);
            this.Controls.Add(this.SoftwareModuleDgv);
            this.Controls.Add(this.SoftwareTypeDgv);
            this.Controls.Add(this.SoftwaresDgv);
            this.Name = "DatabaseEngineerSoftwareManagementPage";
            this.Text = "DatabaseEngineerSoftwareManagementPage";
            this.Load += new System.EventHandler(this.SoftwaresManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoftwaresDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftSoftwaresDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftSoftwaresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareTypeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareModuleDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTypeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuisnessAreasDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SoftwaresDgv;
        private System.Windows.Forms.BindingSource citisoftSoftwaresDataSetBindingSource;
        private CitisoftSoftwaresDataSet citisoftSoftwaresDataSet;
        private System.Windows.Forms.DataGridView SoftwareTypeDgv;
        private System.Windows.Forms.DataGridView SoftwareModuleDgv;
        private System.Windows.Forms.DataGridView ClientTypeDgv;
        private System.Windows.Forms.DataGridView BuisnessAreasDgv;
        private System.Windows.Forms.Label SoftwaresLabel;
        private System.Windows.Forms.Label SoftwareModuleLabel;
        private System.Windows.Forms.Label ClientTypeLabel;
        private System.Windows.Forms.Label SoftwareTypeLabel;
        private System.Windows.Forms.Label BuisnessAreasLabel;
    }
}