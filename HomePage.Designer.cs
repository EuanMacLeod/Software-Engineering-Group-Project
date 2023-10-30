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
            this.button_productView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DBTestButton
            // 
            this.DBTestButton.Location = new System.Drawing.Point(220, 257);
            this.DBTestButton.Margin = new System.Windows.Forms.Padding(4);
            this.DBTestButton.Name = "DBTestButton";
            this.DBTestButton.Size = new System.Drawing.Size(145, 28);
            this.DBTestButton.TabIndex = 2;
            this.DBTestButton.Text = "Go To DB Tesing";
            this.DBTestButton.UseVisualStyleBackColor = true;
            this.DBTestButton.Click += new System.EventHandler(this.DBTestButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(213, 95);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(643, 31);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome 2 the homepage, where do you wanna go?";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(409, 257);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(229, 341);
            this.button_login.Margin = new System.Windows.Forms.Padding(4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(145, 28);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Go To Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_productView
            // 
            this.button_productView.Location = new System.Drawing.Point(418, 341);
            this.button_productView.Margin = new System.Windows.Forms.Padding(4);
            this.button_productView.Name = "button_productView";
            this.button_productView.Size = new System.Drawing.Size(100, 28);
            this.button_productView.TabIndex = 6;
            this.button_productView.Text = "Product View";
            this.button_productView.UseVisualStyleBackColor = true;
            this.button_productView.Click += new System.EventHandler(this.button_pdf_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 682);
            this.Controls.Add(this.button_productView);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.DBTestButton);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Button button_productView;
    }
}

