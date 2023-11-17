namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer.AdminTools
{
    partial class ApproveUser
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
            this.UsersAwaitingApprovalDgv = new System.Windows.Forms.DataGridView();
            this.SelectedEmployeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersAwaitingApprovalDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersAwaitingApprovalDgv
            // 
            this.UsersAwaitingApprovalDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersAwaitingApprovalDgv.Location = new System.Drawing.Point(0, 0);
            this.UsersAwaitingApprovalDgv.Name = "UsersAwaitingApprovalDgv";
            this.UsersAwaitingApprovalDgv.ReadOnly = true;
            this.UsersAwaitingApprovalDgv.RowHeadersWidth = 62;
            this.UsersAwaitingApprovalDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersAwaitingApprovalDgv.Size = new System.Drawing.Size(1322, 566);
            this.UsersAwaitingApprovalDgv.TabIndex = 0;
            this.UsersAwaitingApprovalDgv.SelectionChanged += new System.EventHandler(this.UsersAwaitingApprovalDgv_SelectionChanged);
            // 
            // SelectedEmployeeLabel
            // 
            this.SelectedEmployeeLabel.AutoSize = true;
            this.SelectedEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedEmployeeLabel.Location = new System.Drawing.Point(12, 569);
            this.SelectedEmployeeLabel.Name = "SelectedEmployeeLabel";
            this.SelectedEmployeeLabel.Size = new System.Drawing.Size(376, 46);
            this.SelectedEmployeeLabel.TabIndex = 1;
            this.SelectedEmployeeLabel.Text = "Selected Employee:";
            // 
            // ApproveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 800);
            this.Controls.Add(this.SelectedEmployeeLabel);
            this.Controls.Add(this.UsersAwaitingApprovalDgv);
            this.Name = "ApproveUser";
            this.Text = "ApproveUser";
            ((System.ComponentModel.ISupportInitialize)(this.UsersAwaitingApprovalDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersAwaitingApprovalDgv;
        private System.Windows.Forms.Label SelectedEmployeeLabel;
    }
}