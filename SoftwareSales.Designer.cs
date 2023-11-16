namespace Software_Engineering_Project_New
{
    partial class SoftwareSales
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
            this.citisoftDataSet = new Software_Engineering_Project_New.CitisoftDataSet();
            this.softwaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwaresTableAdapter = new Software_Engineering_Project_New.CitisoftDataSetTableAdapters.SoftwaresTableAdapter();
            this.softwaresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.softwareNameTextBox = new System.Windows.Forms.TextBox();
            this.softwareDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.softwareDescriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.softwareNameTextBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.softwareDescriptionTextBox3 = new System.Windows.Forms.TextBox();
            this.softwareNameTextBox3 = new System.Windows.Forms.TextBox();
            this.softwareDescriptionTextBox4 = new System.Windows.Forms.TextBox();
            this.softwareNameTextBox4 = new System.Windows.Forms.TextBox();
            this.nextPagebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // citisoftDataSet
            // 
            this.citisoftDataSet.DataSetName = "CitisoftDataSet";
            this.citisoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwaresBindingSource
            // 
            this.softwaresBindingSource.DataMember = "Softwares";
            this.softwaresBindingSource.DataSource = this.citisoftDataSet;
            // 
            // softwaresTableAdapter
            // 
            this.softwaresTableAdapter.ClearBeforeFill = true;
            // 
            // softwaresBindingSource1
            // 
            this.softwaresBindingSource1.DataMember = "Softwares";
            this.softwaresBindingSource1.DataSource = this.citisoftDataSet;
            // 
            // softwareNameTextBox
            // 
            this.softwareNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.softwareNameTextBox.Location = new System.Drawing.Point(97, 68);
            this.softwareNameTextBox.Name = "softwareNameTextBox";
            this.softwareNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.softwareNameTextBox.TabIndex = 5;
            // 
            // softwareDescriptionTextBox
            // 
            this.softwareDescriptionTextBox.Location = new System.Drawing.Point(97, 94);
            this.softwareDescriptionTextBox.Multiline = true;
            this.softwareDescriptionTextBox.Name = "softwareDescriptionTextBox";
            this.softwareDescriptionTextBox.Size = new System.Drawing.Size(531, 64);
            this.softwareDescriptionTextBox.TabIndex = 6;
            // 
            // softwareDescriptionTextBox2
            // 
            this.softwareDescriptionTextBox2.Location = new System.Drawing.Point(97, 190);
            this.softwareDescriptionTextBox2.Multiline = true;
            this.softwareDescriptionTextBox2.Name = "softwareDescriptionTextBox2";
            this.softwareDescriptionTextBox2.Size = new System.Drawing.Size(531, 65);
            this.softwareDescriptionTextBox2.TabIndex = 8;
            // 
            // softwareNameTextBox2
            // 
            this.softwareNameTextBox2.Location = new System.Drawing.Point(97, 164);
            this.softwareNameTextBox2.Name = "softwareNameTextBox2";
            this.softwareNameTextBox2.Size = new System.Drawing.Size(168, 20);
            this.softwareNameTextBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 9;
            // 
            // softwareDescriptionTextBox3
            // 
            this.softwareDescriptionTextBox3.Location = new System.Drawing.Point(97, 287);
            this.softwareDescriptionTextBox3.Multiline = true;
            this.softwareDescriptionTextBox3.Name = "softwareDescriptionTextBox3";
            this.softwareDescriptionTextBox3.Size = new System.Drawing.Size(531, 66);
            this.softwareDescriptionTextBox3.TabIndex = 11;
            // 
            // softwareNameTextBox3
            // 
            this.softwareNameTextBox3.Location = new System.Drawing.Point(97, 261);
            this.softwareNameTextBox3.Name = "softwareNameTextBox3";
            this.softwareNameTextBox3.Size = new System.Drawing.Size(168, 20);
            this.softwareNameTextBox3.TabIndex = 10;
            // 
            // softwareDescriptionTextBox4
            // 
            this.softwareDescriptionTextBox4.Location = new System.Drawing.Point(97, 385);
            this.softwareDescriptionTextBox4.Multiline = true;
            this.softwareDescriptionTextBox4.Name = "softwareDescriptionTextBox4";
            this.softwareDescriptionTextBox4.Size = new System.Drawing.Size(531, 63);
            this.softwareDescriptionTextBox4.TabIndex = 13;
            // 
            // softwareNameTextBox4
            // 
            this.softwareNameTextBox4.Location = new System.Drawing.Point(97, 359);
            this.softwareNameTextBox4.Name = "softwareNameTextBox4";
            this.softwareNameTextBox4.Size = new System.Drawing.Size(168, 20);
            this.softwareNameTextBox4.TabIndex = 12;
            // 
            // nextPagebutton
            // 
            this.nextPagebutton.Location = new System.Drawing.Point(655, 425);
            this.nextPagebutton.Name = "nextPagebutton";
            this.nextPagebutton.Size = new System.Drawing.Size(75, 23);
            this.nextPagebutton.TabIndex = 14;
            this.nextPagebutton.Text = "Next Page";
            this.nextPagebutton.UseVisualStyleBackColor = true;
            this.nextPagebutton.Click += new System.EventHandler(this.nextPagebutton_Click);
            // 
            // SoftwareSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.nextPagebutton);
            this.Controls.Add(this.softwareDescriptionTextBox4);
            this.Controls.Add(this.softwareNameTextBox4);
            this.Controls.Add(this.softwareDescriptionTextBox3);
            this.Controls.Add(this.softwareNameTextBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.softwareDescriptionTextBox2);
            this.Controls.Add(this.softwareNameTextBox2);
            this.Controls.Add(this.softwareDescriptionTextBox);
            this.Controls.Add(this.softwareNameTextBox);
            this.Name = "SoftwareSales";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SoftwareSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citisoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private CitisoftDataSet citisoftDataSet;
        private System.Windows.Forms.BindingSource softwaresBindingSource;
        private CitisoftDataSetTableAdapters.SoftwaresTableAdapter softwaresTableAdapter;
        private System.Windows.Forms.BindingSource softwaresBindingSource1;
        private System.Windows.Forms.TextBox softwareNameTextBox;
        private System.Windows.Forms.TextBox softwareDescriptionTextBox;
        private System.Windows.Forms.TextBox softwareDescriptionTextBox2;
        private System.Windows.Forms.TextBox softwareNameTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox softwareDescriptionTextBox3;
        private System.Windows.Forms.TextBox softwareNameTextBox3;
        private System.Windows.Forms.TextBox softwareDescriptionTextBox4;
        private System.Windows.Forms.TextBox softwareNameTextBox4;
        private System.Windows.Forms.Button nextPagebutton;
    }
}