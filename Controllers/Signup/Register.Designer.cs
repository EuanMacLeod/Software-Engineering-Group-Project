namespace Software_Engineering_Project_New
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
            this.box_admin = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Location = new System.Drawing.Point(112, 89);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(68, 16);
            this.label_firstname.TabIndex = 0;
            this.label_firstname.Text = "Full Name";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(112, 119);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(103, 16);
            this.label_lastname.TabIndex = 1;
            this.label_lastname.Text = "Contact Number";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(112, 182);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(70, 16);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(112, 224);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 16);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            // 
            // label_conpassword
            // 
            this.label_conpassword.AutoSize = true;
            this.label_conpassword.Location = new System.Drawing.Point(112, 263);
            this.label_conpassword.Name = "label_conpassword";
            this.label_conpassword.Size = new System.Drawing.Size(115, 16);
            this.label_conpassword.TabIndex = 4;
            this.label_conpassword.Text = "Confirm Password";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(331, 318);
            this.button_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(116, 52);
            this.button_submit.TabIndex = 5;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(240, 89);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_firstname.MaxLength = 30;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(295, 22);
            this.txt_firstname.TabIndex = 6;
            // 
            // txt_ContactNumber
            // 
            this.txt_ContactNumber.Location = new System.Drawing.Point(240, 116);
            this.txt_ContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ContactNumber.MaxLength = 20;
            this.txt_ContactNumber.Name = "txt_ContactNumber";
            this.txt_ContactNumber.Size = new System.Drawing.Size(295, 22);
            this.txt_ContactNumber.TabIndex = 7;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(240, 182);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.MaxLength = 30;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(295, 22);
            this.txt_username.TabIndex = 8;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(240, 224);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.MaxLength = 30;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(295, 22);
            this.txt_password.TabIndex = 9;
            // 
            // txt_conpassword
            // 
            this.txt_conpassword.Location = new System.Drawing.Point(240, 263);
            this.txt_conpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_conpassword.MaxLength = 30;
            this.txt_conpassword.Name = "txt_conpassword";
            this.txt_conpassword.Size = new System.Drawing.Size(295, 22);
            this.txt_conpassword.TabIndex = 10;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(240, 144);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.MaxLength = 30;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(295, 22);
            this.txt_email.TabIndex = 11;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(112, 146);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 16);
            this.label_email.TabIndex = 12;
            this.label_email.Text = "Email";
            // 
            // box_admin
            // 
            this.box_admin.AutoSize = true;
            this.box_admin.Location = new System.Drawing.Point(587, 129);
            this.box_admin.Margin = new System.Windows.Forms.Padding(4);
            this.box_admin.Name = "box_admin";
            this.box_admin.Size = new System.Drawing.Size(122, 20);
            this.box_admin.TabIndex = 13;
            this.box_admin.Text = "Apply for admin";
            this.box_admin.UseVisualStyleBackColor = true;
            this.box_admin.CheckedChanged += new System.EventHandler(this.box_admin_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(587, 222);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 20);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SoftwareSalesmen";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(587, 258);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 20);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DatabaseEngineer";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.box_admin);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckBox box_admin;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}