﻿namespace Software_Engineering_Project_New
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
            this.softwareNameTextBox1 = new System.Windows.Forms.TextBox();
            this.softwareDescriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.nextPagebutton = new System.Windows.Forms.Button();
            this.userLoggedInLabel = new System.Windows.Forms.Label();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.RatingButton4 = new System.Windows.Forms.RadioButton();
            this.RatingButton3 = new System.Windows.Forms.RadioButton();
            this.RatingButton2 = new System.Windows.Forms.RadioButton();
            this.RatingButton1 = new System.Windows.Forms.RadioButton();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.softwareDescriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.softwareNameTextBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.softwareDescriptionTextBox3 = new System.Windows.Forms.TextBox();
            this.softwareNameTextBox3 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.softwareDescriptionTextBox4 = new System.Windows.Forms.TextBox();
            this.softwareNameTextBox4 = new System.Windows.Forms.TextBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnReview1 = new System.Windows.Forms.Button();
            this.btnReview2 = new System.Windows.Forms.Button();
            this.btnReview3 = new System.Windows.Forms.Button();
            this.btnReview4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // citisoftDataSet
            // 
            this.citisoftDataSet.DataSetName = "CitisoftDataSet";
            this.citisoftDataSet.Namespace = "http://tempuri.org/CitisoftDataSet.xsd";
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
            // softwareNameTextBox1
            // 
            this.softwareNameTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.softwareNameTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softwareNameTextBox1.Location = new System.Drawing.Point(224, 13);
            this.softwareNameTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.softwareNameTextBox1.Name = "softwareNameTextBox1";
            this.softwareNameTextBox1.ReadOnly = true;
            this.softwareNameTextBox1.Size = new System.Drawing.Size(332, 31);
            this.softwareNameTextBox1.TabIndex = 5;
            this.softwareNameTextBox1.Click += new System.EventHandler(this.softwareNameTextBox1_Click);
            // 
            // softwareDescriptionTextBox1
            // 
            this.softwareDescriptionTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.softwareDescriptionTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softwareDescriptionTextBox1.Location = new System.Drawing.Point(224, 63);
            this.softwareDescriptionTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.softwareDescriptionTextBox1.Multiline = true;
            this.softwareDescriptionTextBox1.Name = "softwareDescriptionTextBox1";
            this.softwareDescriptionTextBox1.ReadOnly = true;
            this.softwareDescriptionTextBox1.Size = new System.Drawing.Size(1058, 119);
            this.softwareDescriptionTextBox1.TabIndex = 6;
            this.softwareDescriptionTextBox1.Click += new System.EventHandler(this.softwareDescriptionTextBox1_Click);
            // 
            // nextPagebutton
            // 
            this.nextPagebutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nextPagebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPagebutton.Location = new System.Drawing.Point(1306, 881);
            this.nextPagebutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nextPagebutton.Name = "nextPagebutton";
            this.nextPagebutton.Size = new System.Drawing.Size(150, 44);
            this.nextPagebutton.TabIndex = 14;
            this.nextPagebutton.Text = "Next Page";
            this.nextPagebutton.UseVisualStyleBackColor = false;
            this.nextPagebutton.Click += new System.EventHandler(this.nextPagebutton_Click);
            // 
            // userLoggedInLabel
            // 
            this.userLoggedInLabel.AutoSize = true;
            this.userLoggedInLabel.Location = new System.Drawing.Point(24, 35);
            this.userLoggedInLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userLoggedInLabel.Name = "userLoggedInLabel";
            this.userLoggedInLabel.Size = new System.Drawing.Size(0, 25);
            this.userLoggedInLabel.TabIndex = 15;
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PreviousPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPageButton.Location = new System.Drawing.Point(24, 881);
            this.PreviousPageButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(176, 44);
            this.PreviousPageButton.TabIndex = 16;
            this.PreviousPageButton.Text = "Previous Page";
            this.PreviousPageButton.UseVisualStyleBackColor = false;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Engineering_Project_New.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SearchBar.Location = new System.Drawing.Point(450, 23);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(554, 31);
            this.SearchBar.TabIndex = 22;
            this.SearchBar.Text = "Search...";
            this.SearchBar.Click += new System.EventHandler(this.SearchBar_Clicked);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1548, 150);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 681);
            this.vScrollBar1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.FilterButton);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.RatingButton4);
            this.panel2.Controls.Add(this.RatingButton3);
            this.panel2.Controls.Add(this.RatingButton2);
            this.panel2.Controls.Add(this.RatingButton1);
            this.panel2.Controls.Add(this.ApplyButton);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(1202, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.MaximumSize = new System.Drawing.Size(318, 360);
            this.panel2.MinimumSize = new System.Drawing.Size(318, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 360);
            this.panel2.TabIndex = 25;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FilterButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Location = new System.Drawing.Point(0, 0);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(318, 44);
            this.FilterButton.TabIndex = 0;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(190, 306);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 42);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RatingButton4
            // 
            this.RatingButton4.AutoSize = true;
            this.RatingButton4.Location = new System.Drawing.Point(234, 48);
            this.RatingButton4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RatingButton4.Name = "RatingButton4";
            this.RatingButton4.Size = new System.Drawing.Size(55, 29);
            this.RatingButton4.TabIndex = 9;
            this.RatingButton4.TabStop = true;
            this.RatingButton4.Text = "4";
            this.RatingButton4.UseVisualStyleBackColor = true;
            this.RatingButton4.CheckedChanged += new System.EventHandler(this.RatingButton4_CheckedChanged);
            // 
            // RatingButton3
            // 
            this.RatingButton3.AutoSize = true;
            this.RatingButton3.Location = new System.Drawing.Point(160, 48);
            this.RatingButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RatingButton3.Name = "RatingButton3";
            this.RatingButton3.Size = new System.Drawing.Size(55, 29);
            this.RatingButton3.TabIndex = 8;
            this.RatingButton3.TabStop = true;
            this.RatingButton3.Text = "3";
            this.RatingButton3.UseVisualStyleBackColor = true;
            this.RatingButton3.CheckedChanged += new System.EventHandler(this.RatingButton3_CheckedChanged);
            // 
            // RatingButton2
            // 
            this.RatingButton2.AutoSize = true;
            this.RatingButton2.Location = new System.Drawing.Point(86, 48);
            this.RatingButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RatingButton2.Name = "RatingButton2";
            this.RatingButton2.Size = new System.Drawing.Size(55, 29);
            this.RatingButton2.TabIndex = 7;
            this.RatingButton2.TabStop = true;
            this.RatingButton2.Text = "2";
            this.RatingButton2.UseVisualStyleBackColor = true;
            this.RatingButton2.CheckedChanged += new System.EventHandler(this.RatingButton2_CheckedChanged);
            // 
            // RatingButton1
            // 
            this.RatingButton1.AutoSize = true;
            this.RatingButton1.Location = new System.Drawing.Point(12, 48);
            this.RatingButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RatingButton1.Name = "RatingButton1";
            this.RatingButton1.Size = new System.Drawing.Size(55, 29);
            this.RatingButton1.TabIndex = 6;
            this.RatingButton1.TabStop = true;
            this.RatingButton1.Text = "1";
            this.RatingButton1.UseVisualStyleBackColor = true;
            this.RatingButton1.CheckedChanged += new System.EventHandler(this.RatingButton1_CheckedChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Location = new System.Drawing.Point(8, 306);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(150, 44);
            this.ApplyButton.TabIndex = 5;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 165);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(163, 29);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Professional";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 121);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 29);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Cloud Native";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1018, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 42);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnReview1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.softwareDescriptionTextBox1);
            this.panel1.Controls.Add(this.softwareNameTextBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(4, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 200);
            this.panel1.TabIndex = 27;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(572, 19);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 25);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Web Link";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnReview2);
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Controls.Add(this.resultsLabel);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.softwareDescriptionTextBox2);
            this.panel3.Controls.Add(this.softwareNameTextBox2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(4, 263);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1294, 200);
            this.panel3.TabIndex = 28;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(572, 19);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(102, 25);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Web Link";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(654, 162);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(162, 37);
            this.resultsLabel.TabIndex = 18;
            this.resultsLabel.Text = "No results";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_Engineering_Project_New.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // softwareDescriptionTextBox2
            // 
            this.softwareDescriptionTextBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.softwareDescriptionTextBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softwareDescriptionTextBox2.Location = new System.Drawing.Point(224, 63);
            this.softwareDescriptionTextBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.softwareDescriptionTextBox2.Multiline = true;
            this.softwareDescriptionTextBox2.Name = "softwareDescriptionTextBox2";
            this.softwareDescriptionTextBox2.ReadOnly = true;
            this.softwareDescriptionTextBox2.Size = new System.Drawing.Size(1058, 119);
            this.softwareDescriptionTextBox2.TabIndex = 6;
            this.softwareDescriptionTextBox2.Click += new System.EventHandler(this.softwareDescriptionTextBox2_Click);
            // 
            // softwareNameTextBox2
            // 
            this.softwareNameTextBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.softwareNameTextBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softwareNameTextBox2.Location = new System.Drawing.Point(224, 13);
            this.softwareNameTextBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.softwareNameTextBox2.Name = "softwareNameTextBox2";
            this.softwareNameTextBox2.ReadOnly = true;
            this.softwareNameTextBox2.Size = new System.Drawing.Size(332, 31);
            this.softwareNameTextBox2.TabIndex = 5;
            this.softwareNameTextBox2.Click += new System.EventHandler(this.softwareNameTextBox2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnReview3);
            this.panel4.Controls.Add(this.linkLabel3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.softwareDescriptionTextBox3);
            this.panel4.Controls.Add(this.softwareNameTextBox3);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(4, 463);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1294, 200);
            this.panel4.TabIndex = 28;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(572, 19);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(102, 25);
            this.linkLabel3.TabIndex = 20;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Web Link";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Software_Engineering_Project_New.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(20, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 173);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // softwareDescriptionTextBox3
            // 
            this.softwareDescriptionTextBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.softwareDescriptionTextBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softwareDescriptionTextBox3.Location = new System.Drawing.Point(224, 63);
            this.softwareDescriptionTextBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.softwareDescriptionTextBox3.Multiline = true;
            this.softwareDescriptionTextBox3.Name = "softwareDescriptionTextBox3";
            this.softwareDescriptionTextBox3.ReadOnly = true;
            this.softwareDescriptionTextBox3.Size = new System.Drawing.Size(1058, 119);
            this.softwareDescriptionTextBox3.TabIndex = 6;
            this.softwareDescriptionTextBox3.Click += new System.EventHandler(this.softwareDescriptionTextBox3_Click);
            // 
            // softwareNameTextBox3
            // 
            this.softwareNameTextBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.softwareNameTextBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softwareNameTextBox3.Location = new System.Drawing.Point(224, 13);
            this.softwareNameTextBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.softwareNameTextBox3.Name = "softwareNameTextBox3";
            this.softwareNameTextBox3.ReadOnly = true;
            this.softwareNameTextBox3.Size = new System.Drawing.Size(332, 31);
            this.softwareNameTextBox3.TabIndex = 5;
            this.softwareNameTextBox3.Click += new System.EventHandler(this.softwareNameTextBox3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnReview4);
            this.panel5.Controls.Add(this.linkLabel4);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.softwareDescriptionTextBox4);
            this.panel5.Controls.Add(this.softwareNameTextBox4);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(4, 669);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1294, 200);
            this.panel5.TabIndex = 29;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(572, 19);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(102, 25);
            this.linkLabel4.TabIndex = 21;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Web Link";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Software_Engineering_Project_New.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(20, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 173);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // softwareDescriptionTextBox4
            // 
            this.softwareDescriptionTextBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.softwareDescriptionTextBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softwareDescriptionTextBox4.Location = new System.Drawing.Point(224, 63);
            this.softwareDescriptionTextBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.softwareDescriptionTextBox4.Multiline = true;
            this.softwareDescriptionTextBox4.Name = "softwareDescriptionTextBox4";
            this.softwareDescriptionTextBox4.ReadOnly = true;
            this.softwareDescriptionTextBox4.Size = new System.Drawing.Size(1058, 119);
            this.softwareDescriptionTextBox4.TabIndex = 6;
            this.softwareDescriptionTextBox4.Click += new System.EventHandler(this.softwareDescriptionTextBox4_Click);
            // 
            // softwareNameTextBox4
            // 
            this.softwareNameTextBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.softwareNameTextBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.softwareNameTextBox4.Location = new System.Drawing.Point(224, 13);
            this.softwareNameTextBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.softwareNameTextBox4.Name = "softwareNameTextBox4";
            this.softwareNameTextBox4.ReadOnly = true;
            this.softwareNameTextBox4.Size = new System.Drawing.Size(332, 31);
            this.softwareNameTextBox4.TabIndex = 5;
            this.softwareNameTextBox4.Click += new System.EventHandler(this.softwareNameTextBox4_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(30, 15);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(150, 44);
            this.btnProfile.TabIndex = 30;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnReview1
            // 
            this.btnReview1.Location = new System.Drawing.Point(708, 18);
            this.btnReview1.Name = "btnReview1";
            this.btnReview1.Size = new System.Drawing.Size(166, 36);
            this.btnReview1.TabIndex = 19;
            this.btnReview1.Text = "Add Review";
            this.btnReview1.UseVisualStyleBackColor = true;
            // 
            // btnReview2
            // 
            this.btnReview2.Location = new System.Drawing.Point(686, 15);
            this.btnReview2.Name = "btnReview2";
            this.btnReview2.Size = new System.Drawing.Size(188, 41);
            this.btnReview2.TabIndex = 20;
            this.btnReview2.Text = "Add Review";
            this.btnReview2.UseVisualStyleBackColor = true;
            // 
            // btnReview3
            // 
            this.btnReview3.Location = new System.Drawing.Point(688, 18);
            this.btnReview3.Name = "btnReview3";
            this.btnReview3.Size = new System.Drawing.Size(185, 34);
            this.btnReview3.TabIndex = 21;
            this.btnReview3.Text = "Add Review";
            this.btnReview3.UseVisualStyleBackColor = true;
            // 
            // btnReview4
            // 
            this.btnReview4.Location = new System.Drawing.Point(712, 22);
            this.btnReview4.Name = "btnReview4";
            this.btnReview4.Size = new System.Drawing.Size(178, 32);
            this.btnReview4.TabIndex = 22;
            this.btnReview4.Text = "Add review";
            this.btnReview4.UseVisualStyleBackColor = true;
            // 
            // SoftwareSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1600, 933);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.PreviousPageButton);
            this.Controls.Add(this.userLoggedInLabel);
            this.Controls.Add(this.nextPagebutton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SoftwareSales";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SoftwareSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citisoftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwaresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnReview4;

        private System.Windows.Forms.Button btnReview1;
        private System.Windows.Forms.Button btnReview2;
        private System.Windows.Forms.Button btnReview3;

        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Button btnSearch;

        #endregion
        private CitisoftDataSet citisoftDataSet;
        private System.Windows.Forms.BindingSource softwaresBindingSource;
        private CitisoftDataSetTableAdapters.SoftwaresTableAdapter softwaresTableAdapter;
        private System.Windows.Forms.BindingSource softwaresBindingSource1;
        private System.Windows.Forms.TextBox softwareNameTextBox1;
        private System.Windows.Forms.TextBox softwareDescriptionTextBox1;
        private System.Windows.Forms.Button nextPagebutton;
        private System.Windows.Forms.Label userLoggedInLabel;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.RadioButton RatingButton4;
        private System.Windows.Forms.RadioButton RatingButton3;
        private System.Windows.Forms.RadioButton RatingButton2;
        private System.Windows.Forms.RadioButton RatingButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox softwareDescriptionTextBox2;
        private System.Windows.Forms.TextBox softwareNameTextBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox softwareDescriptionTextBox3;
        private System.Windows.Forms.TextBox softwareNameTextBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox softwareDescriptionTextBox4;
        private System.Windows.Forms.TextBox softwareNameTextBox4;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Button btnProfile;
    }
}