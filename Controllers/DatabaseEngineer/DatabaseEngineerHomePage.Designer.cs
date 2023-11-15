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
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(51, 198);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(128, 65);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // gotoPdfTaggingPageButton
            // 
            this.gotoPdfTaggingPageButton.Location = new System.Drawing.Point(185, 198);
            this.gotoPdfTaggingPageButton.Name = "gotoPdfTaggingPageButton";
            this.gotoPdfTaggingPageButton.Size = new System.Drawing.Size(125, 65);
            this.gotoPdfTaggingPageButton.TabIndex = 1;
            this.gotoPdfTaggingPageButton.Text = "Pdf Tagging Page";
            this.gotoPdfTaggingPageButton.UseVisualStyleBackColor = true;
            this.gotoPdfTaggingPageButton.Click += new System.EventHandler(this.button_pdfTagging_Click);
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.AutoSize = true;
            this.welcomeUserLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(52, 13);
            this.welcomeUserLabel.TabIndex = 2;
            this.welcomeUserLabel.Text = "Welcome";
            // 
            // DatabaseEngineerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeUserLabel);
            this.Controls.Add(this.gotoPdfTaggingPageButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "DatabaseEngineerHomePage";
            this.Text = "DatabaseEngineerHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button gotoPdfTaggingPageButton;
        private System.Windows.Forms.Label welcomeUserLabel;
    }
}