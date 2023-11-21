namespace Software_Engineering_Project_New.Helper_Classes
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.softwaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citisoft_Softwares = new Software_Engineering_Project_New.Citisoft_Softwares();
            this.softwaresTableAdapter = new Software_Engineering_Project_New.Citisoft_SoftwaresTableAdapters.SoftwaresTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LTS_cross = new System.Windows.Forms.PictureBox();
            this.CN_cross = new System.Windows.Forms.PictureBox();
            this.LTS_tick = new System.Windows.Forms.PictureBox();
            this.CN_tick = new System.Windows.Forms.PictureBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.bttn_down = new System.Windows.Forms.Button();
            this.bttn_web = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bttn_up = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfDemoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliableProfessionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.documentLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoft_Softwares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTS_cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CN_cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTS_tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CN_tick)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Description,
            this.additionalInformationDataGridViewTextBoxColumn,
            this.dateOfDemoDataGridViewTextBoxColumn,
            this.avaliableProfessionalDataGridViewCheckBoxColumn,
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn,
            this.documentLinkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.softwaresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(439, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 440);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // softwaresBindingSource
            // 
            this.softwaresBindingSource.DataMember = "Softwares";
            this.softwaresBindingSource.DataSource = this.citisoft_Softwares;
            // 
            // citisoft_Softwares
            // 
            this.citisoft_Softwares.DataSetName = "Citisoft_Softwares";
            this.citisoft_Softwares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwaresTableAdapter
            // 
            this.softwaresTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Long Term Service";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cloud Native";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LTS_cross
            // 
            this.LTS_cross.Image = ((System.Drawing.Image)(resources.GetObject("LTS_cross.Image")));
            this.LTS_cross.Location = new System.Drawing.Point(194, 274);
            this.LTS_cross.Name = "LTS_cross";
            this.LTS_cross.Size = new System.Drawing.Size(52, 37);
            this.LTS_cross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LTS_cross.TabIndex = 6;
            this.LTS_cross.TabStop = false;
            this.LTS_cross.Visible = false;
            // 
            // CN_cross
            // 
            this.CN_cross.Image = ((System.Drawing.Image)(resources.GetObject("CN_cross.Image")));
            this.CN_cross.Location = new System.Drawing.Point(298, 274);
            this.CN_cross.Name = "CN_cross";
            this.CN_cross.Size = new System.Drawing.Size(52, 37);
            this.CN_cross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CN_cross.TabIndex = 7;
            this.CN_cross.TabStop = false;
            this.CN_cross.Visible = false;
            // 
            // LTS_tick
            // 
            this.LTS_tick.Image = ((System.Drawing.Image)(resources.GetObject("LTS_tick.Image")));
            this.LTS_tick.Location = new System.Drawing.Point(194, 318);
            this.LTS_tick.Name = "LTS_tick";
            this.LTS_tick.Size = new System.Drawing.Size(52, 37);
            this.LTS_tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LTS_tick.TabIndex = 8;
            this.LTS_tick.TabStop = false;
            this.LTS_tick.Visible = false;
            // 
            // CN_tick
            // 
            this.CN_tick.Image = ((System.Drawing.Image)(resources.GetObject("CN_tick.Image")));
            this.CN_tick.Location = new System.Drawing.Point(298, 318);
            this.CN_tick.Name = "CN_tick";
            this.CN_tick.Size = new System.Drawing.Size(52, 37);
            this.CN_tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CN_tick.TabIndex = 9;
            this.CN_tick.TabStop = false;
            this.CN_tick.Visible = false;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(38, 365);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(116, 16);
            this.lbl_desc.TabIndex = 10;
            this.lbl_desc.Text = "(Description Here)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "Long Term Serivice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 66);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cloud native";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "filter";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(38, 328);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(85, 16);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "(Name Here)";
            this.lbl_name.Visible = false;
            // 
            // bttn_down
            // 
            this.bttn_down.Location = new System.Drawing.Point(511, 521);
            this.bttn_down.Name = "bttn_down";
            this.bttn_down.Size = new System.Drawing.Size(75, 23);
            this.bttn_down.TabIndex = 16;
            this.bttn_down.Text = "down";
            this.bttn_down.UseVisualStyleBackColor = true;
            this.bttn_down.Click += new System.EventHandler(this.bttn_down_Click);
            // 
            // bttn_web
            // 
            this.bttn_web.Location = new System.Drawing.Point(618, 491);
            this.bttn_web.Name = "bttn_web";
            this.bttn_web.Size = new System.Drawing.Size(91, 53);
            this.bttn_web.TabIndex = 17;
            this.bttn_web.Text = "Open Document";
            this.bttn_web.UseVisualStyleBackColor = true;
            this.bttn_web.Click += new System.EventHandler(this.bttn_web_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(756, 492);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 66);
            this.button6.TabIndex = 19;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bttn_up
            // 
            this.bttn_up.Location = new System.Drawing.Point(511, 492);
            this.bttn_up.Name = "bttn_up";
            this.bttn_up.Size = new System.Drawing.Size(75, 23);
            this.bttn_up.TabIndex = 20;
            this.bttn_up.Text = "up";
            this.bttn_up.UseVisualStyleBackColor = true;
            this.bttn_up.Click += new System.EventHandler(this.bttn_up_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // additionalInformationDataGridViewTextBoxColumn
            // 
            this.additionalInformationDataGridViewTextBoxColumn.DataPropertyName = "Additional Information";
            this.additionalInformationDataGridViewTextBoxColumn.HeaderText = "Additional Information";
            this.additionalInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInformationDataGridViewTextBoxColumn.Name = "additionalInformationDataGridViewTextBoxColumn";
            this.additionalInformationDataGridViewTextBoxColumn.ReadOnly = true;
            this.additionalInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfDemoDataGridViewTextBoxColumn
            // 
            this.dateOfDemoDataGridViewTextBoxColumn.DataPropertyName = "Date of Demo";
            this.dateOfDemoDataGridViewTextBoxColumn.HeaderText = "Date of Demo";
            this.dateOfDemoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfDemoDataGridViewTextBoxColumn.Name = "dateOfDemoDataGridViewTextBoxColumn";
            this.dateOfDemoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfDemoDataGridViewTextBoxColumn.Width = 125;
            // 
            // avaliableProfessionalDataGridViewCheckBoxColumn
            // 
            this.avaliableProfessionalDataGridViewCheckBoxColumn.DataPropertyName = "Avaliable Professional";
            this.avaliableProfessionalDataGridViewCheckBoxColumn.HeaderText = "Avaliable Professional";
            this.avaliableProfessionalDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.avaliableProfessionalDataGridViewCheckBoxColumn.Name = "avaliableProfessionalDataGridViewCheckBoxColumn";
            this.avaliableProfessionalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.avaliableProfessionalDataGridViewCheckBoxColumn.Width = 125;
            // 
            // cloudServicesAvaliableDataGridViewCheckBoxColumn
            // 
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.DataPropertyName = "Cloud Services Avaliable";
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.HeaderText = "Cloud Services Avaliable";
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.Name = "cloudServicesAvaliableDataGridViewCheckBoxColumn";
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.ReadOnly = true;
            this.cloudServicesAvaliableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // documentLinkDataGridViewTextBoxColumn
            // 
            this.documentLinkDataGridViewTextBoxColumn.DataPropertyName = "Document Link";
            this.documentLinkDataGridViewTextBoxColumn.HeaderText = "Document Link";
            this.documentLinkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentLinkDataGridViewTextBoxColumn.Name = "documentLinkDataGridViewTextBoxColumn";
            this.documentLinkDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentLinkDataGridViewTextBoxColumn.Width = 125;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 609);
            this.Controls.Add(this.bttn_up);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bttn_web);
            this.Controls.Add(this.bttn_down);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.CN_tick);
            this.Controls.Add(this.LTS_tick);
            this.Controls.Add(this.CN_cross);
            this.Controls.Add(this.LTS_cross);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citisoft_Softwares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTS_cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CN_cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTS_tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CN_tick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Citisoft_Softwares citisoft_Softwares;
        private System.Windows.Forms.BindingSource softwaresBindingSource;
        private Citisoft_SoftwaresTableAdapters.SoftwaresTableAdapter softwaresTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox LTS_cross;
        private System.Windows.Forms.PictureBox CN_cross;
        private System.Windows.Forms.PictureBox LTS_tick;
        private System.Windows.Forms.PictureBox CN_tick;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button bttn_down;
        private System.Windows.Forms.Button bttn_web;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bttn_up;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfDemoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn avaliableProfessionalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cloudServicesAvaliableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentLinkDataGridViewTextBoxColumn;
    }
}