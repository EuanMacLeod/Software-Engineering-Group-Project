namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    partial class DatabaseEngineerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseEngineerHomePage));
            this.logoutButton = new System.Windows.Forms.Button();
            this.gotoPdfTaggingPageButton = new System.Windows.Forms.Button();
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.bttn_adminTools = new System.Windows.Forms.Button();
            this.Citisoft_logo = new System.Windows.Forms.PictureBox();
            this.bttn_sales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Citisoft_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(19, 95);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(167, 80);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // gotoPdfTaggingPageButton
            // 
            this.gotoPdfTaggingPageButton.Location = new System.Drawing.Point(19, 183);
            this.gotoPdfTaggingPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.gotoPdfTaggingPageButton.Name = "gotoPdfTaggingPageButton";
            this.gotoPdfTaggingPageButton.Size = new System.Drawing.Size(167, 80);
            this.gotoPdfTaggingPageButton.TabIndex = 1;
            this.gotoPdfTaggingPageButton.Text = "Pdf Tagging Page";
            this.gotoPdfTaggingPageButton.UseVisualStyleBackColor = true;
            this.gotoPdfTaggingPageButton.Click += new System.EventHandler(this.button_pdfTagging_Click);
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.AutoSize = true;
            this.welcomeUserLabel.Location = new System.Drawing.Point(16, 11);
            this.welcomeUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(65, 16);
            this.welcomeUserLabel.TabIndex = 2;
            this.welcomeUserLabel.Text = "Welcome";
            // 
            // bttn_adminTools
            // 
            this.bttn_adminTools.Location = new System.Drawing.Point(193, 95);
            this.bttn_adminTools.Name = "bttn_adminTools";
            this.bttn_adminTools.Size = new System.Drawing.Size(166, 80);
            this.bttn_adminTools.TabIndex = 3;
            this.bttn_adminTools.Text = "Admin Tools";
            this.bttn_adminTools.UseVisualStyleBackColor = true;
            this.bttn_adminTools.Visible = false;
            this.bttn_adminTools.Click += new System.EventHandler(this.bttn_adminTools_Click);
            // 
            // Citisoft_logo
            // 
            this.Citisoft_logo.Image = ((System.Drawing.Image)(resources.GetObject("Citisoft_logo.Image")));
            this.Citisoft_logo.Location = new System.Drawing.Point(375, 71);
            this.Citisoft_logo.Name = "Citisoft_logo";
            this.Citisoft_logo.Size = new System.Drawing.Size(189, 192);
            this.Citisoft_logo.TabIndex = 5;
            this.Citisoft_logo.TabStop = false;
            // 
            // bttn_sales
            // 
            this.bttn_sales.Location = new System.Drawing.Point(193, 183);
            this.bttn_sales.Name = "bttn_sales";
            this.bttn_sales.Size = new System.Drawing.Size(166, 80);
            this.bttn_sales.TabIndex = 6;
            this.bttn_sales.Text = "Sales ";
            this.bttn_sales.UseVisualStyleBackColor = true;
            this.bttn_sales.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatabaseEngineerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 288);
            this.Controls.Add(this.bttn_sales);
            this.Controls.Add(this.Citisoft_logo);
            this.Controls.Add(this.bttn_adminTools);
            this.Controls.Add(this.welcomeUserLabel);
            this.Controls.Add(this.gotoPdfTaggingPageButton);
            this.Controls.Add(this.logoutButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatabaseEngineerHomePage";
            this.Text = "AdminHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.Citisoft_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button gotoPdfTaggingPageButton;
        private System.Windows.Forms.Label welcomeUserLabel;
        private System.Windows.Forms.Button bttn_adminTools;
        private System.Windows.Forms.PictureBox Citisoft_logo;
        private System.Windows.Forms.Button bttn_sales;
    }
}