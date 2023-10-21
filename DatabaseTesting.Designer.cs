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
            // DatabaseTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}