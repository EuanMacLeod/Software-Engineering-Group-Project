﻿namespace Software_Engineering_Project_New
{
    partial class Register
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
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_conpassword = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_ContactNumber = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_conpassword = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Location = new System.Drawing.Point(126, 129);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(80, 20);
            this.label_firstname.TabIndex = 0;
            this.label_firstname.Text = "Full Name";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(126, 177);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(125, 20);
            this.label_lastname.TabIndex = 1;
            this.label_lastname.Text = "Contact Number";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(129, 283);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(83, 20);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(129, 329);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(78, 20);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            // 
            // label_conpassword
            // 
            this.label_conpassword.AutoSize = true;
            this.label_conpassword.Location = new System.Drawing.Point(126, 375);
            this.label_conpassword.Name = "label_conpassword";
            this.label_conpassword.Size = new System.Drawing.Size(137, 20);
            this.label_conpassword.TabIndex = 4;
            this.label_conpassword.Text = "Confirm Password";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(374, 448);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(174, 80);
            this.button_submit.TabIndex = 5;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(270, 125);
            this.txt_firstname.MaxLength = 30;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(440, 26);
            this.txt_firstname.TabIndex = 6;
            // 
            // txt_ContactNumber
            // 
            this.txt_ContactNumber.Location = new System.Drawing.Point(270, 177);
            this.txt_ContactNumber.MaxLength = 20;
            this.txt_ContactNumber.Name = "txt_ContactNumber";
            this.txt_ContactNumber.Size = new System.Drawing.Size(440, 26);
            this.txt_ContactNumber.TabIndex = 7;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(270, 277);
            this.txt_username.MaxLength = 30;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(440, 26);
            this.txt_username.TabIndex = 8;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(270, 329);
            this.txt_password.MaxLength = 30;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(440, 26);
            this.txt_password.TabIndex = 9;
            // 
            // txt_conpassword
            // 
            this.txt_conpassword.Location = new System.Drawing.Point(270, 375);
            this.txt_conpassword.MaxLength = 30;
            this.txt_conpassword.Name = "txt_conpassword";
            this.txt_conpassword.PasswordChar = '*';
            this.txt_conpassword.Size = new System.Drawing.Size(440, 26);
            this.txt_conpassword.TabIndex = 10;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(270, 228);
            this.txt_email.MaxLength = 30;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(440, 26);
            this.txt_email.TabIndex = 11;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(129, 228);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(48, 20);
            this.label_email.TabIndex = 12;
            this.label_email.Text = "Email";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(132, 398);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 65);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Clicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_conpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_ContactNumber);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_conpassword);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_firstname);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_conpassword;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_ContactNumber;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_conpassword;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button backButton;
    }
}