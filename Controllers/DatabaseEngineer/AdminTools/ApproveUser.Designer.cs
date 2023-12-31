﻿namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer.AdminTools
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
            this.ManagerRadioButton = new System.Windows.Forms.RadioButton();
            this.SalesmanRadioButton = new System.Windows.Forms.RadioButton();
            this.DatabaseEngineerRadioButton = new System.Windows.Forms.RadioButton();
            this.AdminRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RejectRadioButton = new System.Windows.Forms.RadioButton();
            this.ApproveRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.UsersAwaitingApprovalDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.UsersAwaitingApprovalDgv.Size = new System.Drawing.Size(1653, 566);
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
            // ManagerRadioButton
            // 
            this.ManagerRadioButton.AutoSize = true;
            this.ManagerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerRadioButton.Location = new System.Drawing.Point(6, 189);
            this.ManagerRadioButton.Name = "ManagerRadioButton";
            this.ManagerRadioButton.Size = new System.Drawing.Size(133, 33);
            this.ManagerRadioButton.TabIndex = 3;
            this.ManagerRadioButton.TabStop = true;
            this.ManagerRadioButton.Text = "Manager";
            this.ManagerRadioButton.UseVisualStyleBackColor = true;
            this.ManagerRadioButton.Click += new System.EventHandler(this.ManagerRadioButton_Clicked);
            // 
            // SalesmanRadioButton
            // 
            this.SalesmanRadioButton.AutoSize = true;
            this.SalesmanRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesmanRadioButton.Location = new System.Drawing.Point(6, 228);
            this.SalesmanRadioButton.Name = "SalesmanRadioButton";
            this.SalesmanRadioButton.Size = new System.Drawing.Size(145, 33);
            this.SalesmanRadioButton.TabIndex = 4;
            this.SalesmanRadioButton.TabStop = true;
            this.SalesmanRadioButton.Text = "Salesman";
            this.SalesmanRadioButton.UseVisualStyleBackColor = true;
            this.SalesmanRadioButton.Click += new System.EventHandler(this.SalesmanRadioButton_Clicked);
            // 
            // DatabaseEngineerRadioButton
            // 
            this.DatabaseEngineerRadioButton.AutoSize = true;
            this.DatabaseEngineerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseEngineerRadioButton.Location = new System.Drawing.Point(6, 267);
            this.DatabaseEngineerRadioButton.Name = "DatabaseEngineerRadioButton";
            this.DatabaseEngineerRadioButton.Size = new System.Drawing.Size(244, 33);
            this.DatabaseEngineerRadioButton.TabIndex = 5;
            this.DatabaseEngineerRadioButton.TabStop = true;
            this.DatabaseEngineerRadioButton.Text = "Database Engineer";
            this.DatabaseEngineerRadioButton.UseVisualStyleBackColor = true;
            this.DatabaseEngineerRadioButton.Click += new System.EventHandler(this.DatabaseEngineerRadioButton_Clicked);
            // 
            // AdminRadioButton
            // 
            this.AdminRadioButton.AutoSize = true;
            this.AdminRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRadioButton.Location = new System.Drawing.Point(6, 150);
            this.AdminRadioButton.Name = "AdminRadioButton";
            this.AdminRadioButton.Size = new System.Drawing.Size(106, 33);
            this.AdminRadioButton.TabIndex = 2;
            this.AdminRadioButton.TabStop = true;
            this.AdminRadioButton.Text = "Admin";
            this.AdminRadioButton.UseVisualStyleBackColor = true;
            this.AdminRadioButton.Click += new System.EventHandler(this.AdminRadioButton_Clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatabaseEngineerRadioButton);
            this.groupBox1.Controls.Add(this.AdminRadioButton);
            this.groupBox1.Controls.Add(this.ManagerRadioButton);
            this.groupBox1.Controls.Add(this.SalesmanRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(614, 569);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 352);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(1308, 590);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(285, 122);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Clicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RejectRadioButton);
            this.panel1.Controls.Add(this.ApproveRadioButton);
            this.panel1.Location = new System.Drawing.Point(937, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 218);
            this.panel1.TabIndex = 6;
            // 
            // RejectRadioButton
            // 
            this.RejectRadioButton.AutoSize = true;
            this.RejectRadioButton.Checked = true;
            this.RejectRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectRadioButton.Location = new System.Drawing.Point(3, 64);
            this.RejectRadioButton.Name = "RejectRadioButton";
            this.RejectRadioButton.Size = new System.Drawing.Size(107, 33);
            this.RejectRadioButton.TabIndex = 1;
            this.RejectRadioButton.TabStop = true;
            this.RejectRadioButton.Text = "Reject";
            this.RejectRadioButton.UseVisualStyleBackColor = true;
            // 
            // ApproveRadioButton
            // 
            this.ApproveRadioButton.AutoSize = true;
            this.ApproveRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveRadioButton.Location = new System.Drawing.Point(3, 16);
            this.ApproveRadioButton.Name = "ApproveRadioButton";
            this.ApproveRadioButton.Size = new System.Drawing.Size(128, 33);
            this.ApproveRadioButton.TabIndex = 0;
            this.ApproveRadioButton.Text = "Approve";
            this.ApproveRadioButton.UseVisualStyleBackColor = true;
            // 
            // ApproveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 1026);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectedEmployeeLabel);
            this.Controls.Add(this.UsersAwaitingApprovalDgv);
            this.Name = "ApproveUser";
            this.Text = "ApproveUser";
            ((System.ComponentModel.ISupportInitialize)(this.UsersAwaitingApprovalDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersAwaitingApprovalDgv;
        private System.Windows.Forms.Label SelectedEmployeeLabel;
        private System.Windows.Forms.RadioButton ManagerRadioButton;
        private System.Windows.Forms.RadioButton SalesmanRadioButton;
        private System.Windows.Forms.RadioButton DatabaseEngineerRadioButton;
        private System.Windows.Forms.RadioButton AdminRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ApproveRadioButton;
        private System.Windows.Forms.RadioButton RejectRadioButton;
    }
}