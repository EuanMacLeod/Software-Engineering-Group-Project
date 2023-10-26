using System.Drawing;
using System.Windows.Forms;

namespace Software_Engineering_Project_New
{
    partial class HomePage
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
            this.DBTestButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.button_adminTools = new System.Windows.Forms.Button();
            this.label_userloggedin = new System.Windows.Forms.Label();
            this.label_activeUser = new System.Windows.Forms.Label();
            this.button_PDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DBTestButton
            // 
            this.DBTestButton.Location = new System.Drawing.Point(255, 422);
            this.DBTestButton.Name = "DBTestButton";
            this.DBTestButton.Size = new System.Drawing.Size(109, 23);
            this.DBTestButton.TabIndex = 2;
            this.DBTestButton.Text = "Go To DB Tesing";
            this.DBTestButton.UseVisualStyleBackColor = true;
            this.DBTestButton.Click += new System.EventHandler(this.DBTestButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(354, 75);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(132, 25);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "SwitchBoard";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(484, 422);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(296, 258);
            this.button_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(254, 35);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Login page";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_adminTools
            // 
            this.button_adminTools.Location = new System.Drawing.Point(269, 348);
            this.button_adminTools.Name = "button_adminTools";
            this.button_adminTools.Size = new System.Drawing.Size(75, 23);
            this.button_adminTools.TabIndex = 6;
            this.button_adminTools.Text = "Admin Tools";
            this.button_adminTools.UseVisualStyleBackColor = true;
            this.button_adminTools.Click += new System.EventHandler(this.button_adminTools_Click);
            // 
            // label_userloggedin
            // 
            this.label_userloggedin.AutoSize = true;
            this.label_userloggedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userloggedin.Location = new System.Drawing.Point(206, 149);
            this.label_userloggedin.Name = "label_userloggedin";
            this.label_userloggedin.Size = new System.Drawing.Size(151, 25);
            this.label_userloggedin.TabIndex = 7;
            this.label_userloggedin.Text = "Userlogged in:";
            this.label_userloggedin.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_activeUser
            // 
            this.label_activeUser.AutoSize = true;
            this.label_activeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_activeUser.Location = new System.Drawing.Point(375, 149);
            this.label_activeUser.Name = "label_activeUser";
            this.label_activeUser.Size = new System.Drawing.Size(34, 25);
            this.label_activeUser.TabIndex = 8;
            this.label_activeUser.Text = "ss";
            // 
            // button_PDF
            // 
            this.button_PDF.Location = new System.Drawing.Point(484, 348);
            this.button_PDF.Name = "button_PDF";
            this.button_PDF.Size = new System.Drawing.Size(75, 23);
            this.button_PDF.TabIndex = 9;
            this.button_PDF.Text = "PDF Viewer";
            this.button_PDF.UseVisualStyleBackColor = true;
            this.button_PDF.Click += new System.EventHandler(this.button_PDF_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 554);
            this.Controls.Add(this.button_PDF);
            this.Controls.Add(this.label_activeUser);
            this.Controls.Add(this.label_userloggedin);
            this.Controls.Add(this.button_adminTools);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.DBTestButton);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button DBTestButton;
        private Label welcomeLabel;
        private Button exitButton;
        private Button button_login;
        private Button button_adminTools;
        private Label label_userloggedin;
        private Label label_activeUser;
        private Button button_PDF;
    }
}

