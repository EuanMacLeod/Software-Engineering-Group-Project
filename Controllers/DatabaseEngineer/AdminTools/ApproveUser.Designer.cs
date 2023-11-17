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
            this.usersAwatingApproval = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usersAwatingApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // usersAwatingApproval
            // 
            this.usersAwatingApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersAwatingApproval.Location = new System.Drawing.Point(0, 0);
            this.usersAwatingApproval.Name = "usersAwatingApproval";
            this.usersAwatingApproval.RowHeadersWidth = 62;
            this.usersAwatingApproval.Size = new System.Drawing.Size(1322, 566);
            this.usersAwatingApproval.TabIndex = 0;
            // 
            // ApproveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 800);
            this.Controls.Add(this.usersAwatingApproval);
            this.Name = "ApproveUser";
            this.Text = "ApproveUser";
            ((System.ComponentModel.ISupportInitialize)(this.usersAwatingApproval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersAwatingApproval;
    }
}