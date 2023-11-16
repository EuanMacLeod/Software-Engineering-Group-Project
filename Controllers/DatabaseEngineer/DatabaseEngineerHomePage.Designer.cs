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
            this.logoutButton = new System.Windows.Forms.Button();
            this.gotoPdfTaggingPageButton = new System.Windows.Forms.Button();
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.bttn_adminTools = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPfp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminPfp)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(68, 244);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(171, 80);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // gotoPdfTaggingPageButton
            // 
            this.gotoPdfTaggingPageButton.Location = new System.Drawing.Point(68, 332);
            this.gotoPdfTaggingPageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.bttn_adminTools.Location = new System.Drawing.Point(664, 294);
            this.bttn_adminTools.Name = "bttn_adminTools";
            this.bttn_adminTools.Size = new System.Drawing.Size(231, 176);
            this.bttn_adminTools.TabIndex = 3;
            this.bttn_adminTools.Text = "Admin Tools";
            this.bttn_adminTools.UseVisualStyleBackColor = true;
            this.bttn_adminTools.Visible = false;
            this.bttn_adminTools.Click += new System.EventHandler(this.bttn_adminTools_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin";
            this.label1.Visible = false;
            // 
            // adminPfp
            // 
            this.adminPfp.Image = global::Software_Engineering_Project_New.Properties.Resources.AdminProfliePicture;
            this.adminPfp.Location = new System.Drawing.Point(293, 132);
            this.adminPfp.Name = "adminPfp";
            this.adminPfp.Size = new System.Drawing.Size(318, 357);
            this.adminPfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminPfp.TabIndex = 5;
            this.adminPfp.TabStop = false;
            this.adminPfp.Visible = false;
            // 
            // DatabaseEngineerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.adminPfp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_adminTools);
            this.Controls.Add(this.welcomeUserLabel);
            this.Controls.Add(this.gotoPdfTaggingPageButton);
            this.Controls.Add(this.logoutButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DatabaseEngineerHomePage";
            this.Text = "DatabaseEngineerHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.adminPfp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button gotoPdfTaggingPageButton;
        private System.Windows.Forms.Label welcomeUserLabel;
        private System.Windows.Forms.Button bttn_adminTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox adminPfp;
    }
}