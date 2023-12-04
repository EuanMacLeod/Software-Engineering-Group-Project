namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    partial class roleIdChange
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
            this.txt_userame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_adjust = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_userLoggedin = new System.Windows.Forms.Label();
            this.bttn_sales = new System.Windows.Forms.RadioButton();
            this.bttn_DBEng = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_userame
            // 
            this.txt_userame.Location = new System.Drawing.Point(185, 64);
            this.txt_userame.Name = "txt_userame";
            this.txt_userame.Size = new System.Drawing.Size(264, 22);
            this.txt_userame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(185, 109);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(264, 22);
            this.txt_email.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttn_adjust
            // 
            this.bttn_adjust.Location = new System.Drawing.Point(496, 51);
            this.bttn_adjust.Name = "bttn_adjust";
            this.bttn_adjust.Size = new System.Drawing.Size(123, 99);
            this.bttn_adjust.TabIndex = 2;
            this.bttn_adjust.Text = "Adjust role";
            this.bttn_adjust.UseVisualStyleBackColor = true;
            this.bttn_adjust.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current user:";
            // 
            // label_userLoggedin
            // 
            this.label_userLoggedin.AutoSize = true;
            this.label_userLoggedin.Location = new System.Drawing.Point(182, 13);
            this.label_userLoggedin.Name = "label_userLoggedin";
            this.label_userLoggedin.Size = new System.Drawing.Size(106, 16);
            this.label_userLoggedin.TabIndex = 3;
            this.label_userLoggedin.Text = "<user logged in>";
            this.label_userLoggedin.Click += new System.EventHandler(this.label4_Click);
            // 
            // bttn_sales
            // 
            this.bttn_sales.AutoSize = true;
            this.bttn_sales.Location = new System.Drawing.Point(662, 59);
            this.bttn_sales.Name = "bttn_sales";
            this.bttn_sales.Size = new System.Drawing.Size(89, 20);
            this.bttn_sales.TabIndex = 4;
            this.bttn_sales.TabStop = true;
            this.bttn_sales.Text = "Salesman";
            this.bttn_sales.UseVisualStyleBackColor = true;
            // 
            // bttn_DBEng
            // 
            this.bttn_DBEng.AutoSize = true;
            this.bttn_DBEng.Location = new System.Drawing.Point(662, 110);
            this.bttn_DBEng.Name = "bttn_DBEng";
            this.bttn_DBEng.Size = new System.Drawing.Size(145, 20);
            this.bttn_DBEng.TabIndex = 4;
            this.bttn_DBEng.TabStop = true;
            this.bttn_DBEng.Text = "Database Engineer";
            this.bttn_DBEng.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 247);
            this.dataGridView1.TabIndex = 5;
            // 
            // roleIdChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttn_DBEng);
            this.Controls.Add(this.bttn_sales);
            this.Controls.Add(this.label_userLoggedin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttn_adjust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_userame);
            this.Name = "roleIdChange";
            this.Text = "roleIdChange";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_userame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_userLoggedin;
        private System.Windows.Forms.Button bttn_adjust;
        private System.Windows.Forms.RadioButton bttn_DBEng;
        private System.Windows.Forms.RadioButton bttn_sales;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}