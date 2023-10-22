namespace Software_Engineering_Project_New
{
    partial class DatabaseTesting
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
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.DBTestingBackButton = new System.Windows.Forms.Button();
            this.viewVendorsButton = new System.Windows.Forms.Button();
            this.viewEmployeesButton = new System.Windows.Forms.Button();
            this.viewManagersButton = new System.Windows.Forms.Button();
            this.viewVendorBranchesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTest
            // 
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(12, 12);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.Size = new System.Drawing.Size(729, 360);
            this.dgvTest.TabIndex = 0;
            this.dgvTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellContentClick);
            // 
            // DBTestingBackButton
            // 
            this.DBTestingBackButton.Location = new System.Drawing.Point(666, 378);
            this.DBTestingBackButton.Name = "DBTestingBackButton";
            this.DBTestingBackButton.Size = new System.Drawing.Size(75, 23);
            this.DBTestingBackButton.TabIndex = 1;
            this.DBTestingBackButton.Text = "Back";
            this.DBTestingBackButton.UseVisualStyleBackColor = true;
            this.DBTestingBackButton.Click += new System.EventHandler(this.DBTestingBackButton_Click);
            // 
            // viewVendorsButton
            // 
            this.viewVendorsButton.Location = new System.Drawing.Point(504, 378);
            this.viewVendorsButton.Name = "viewVendorsButton";
            this.viewVendorsButton.Size = new System.Drawing.Size(89, 23);
            this.viewVendorsButton.TabIndex = 2;
            this.viewVendorsButton.Text = "View Vendors";
            this.viewVendorsButton.UseVisualStyleBackColor = true;
            this.viewVendorsButton.Click += new System.EventHandler(this.viewVendorsButton_Click);
            // 
            // viewEmployeesButton
            // 
            this.viewEmployeesButton.Location = new System.Drawing.Point(404, 378);
            this.viewEmployeesButton.Name = "viewEmployeesButton";
            this.viewEmployeesButton.Size = new System.Drawing.Size(94, 23);
            this.viewEmployeesButton.TabIndex = 3;
            this.viewEmployeesButton.Text = "View Employees";
            this.viewEmployeesButton.UseVisualStyleBackColor = true;
            this.viewEmployeesButton.Click += new System.EventHandler(this.viewEmployeesButton_Click);
            // 
            // viewManagersButton
            // 
            this.viewManagersButton.Location = new System.Drawing.Point(305, 378);
            this.viewManagersButton.Name = "viewManagersButton";
            this.viewManagersButton.Size = new System.Drawing.Size(93, 23);
            this.viewManagersButton.TabIndex = 4;
            this.viewManagersButton.Text = "View Managers";
            this.viewManagersButton.UseVisualStyleBackColor = true;
            this.viewManagersButton.Click += new System.EventHandler(this.viewManagersButton_Click);
            // 
            // viewVendorBranchesButton
            // 
            this.viewVendorBranchesButton.Location = new System.Drawing.Point(155, 378);
            this.viewVendorBranchesButton.Name = "viewVendorBranchesButton";
            this.viewVendorBranchesButton.Size = new System.Drawing.Size(144, 23);
            this.viewVendorBranchesButton.TabIndex = 5;
            this.viewVendorBranchesButton.Text = "View Vendor Branches";
            this.viewVendorBranchesButton.UseVisualStyleBackColor = true;
            this.viewVendorBranchesButton.Click += new System.EventHandler(this.viewVendorBranchesButton_Click);
            // 
            // DatabaseTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 536);
            this.Controls.Add(this.viewVendorBranchesButton);
            this.Controls.Add(this.viewManagersButton);
            this.Controls.Add(this.viewEmployeesButton);
            this.Controls.Add(this.viewVendorsButton);
            this.Controls.Add(this.DBTestingBackButton);
            this.Controls.Add(this.dgvTest);
            this.Name = "DatabaseTesting";
            this.Text = "DatabaseTesting";
            this.Load += new System.EventHandler(this.DatabaseTesting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Button DBTestingBackButton;
        private System.Windows.Forms.Button viewVendorsButton;
        private System.Windows.Forms.Button viewEmployeesButton;
        private System.Windows.Forms.Button viewManagersButton;
        private System.Windows.Forms.Button viewVendorBranchesButton;
    }
}