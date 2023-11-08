namespace Software_Engineering_Project_New
{
    partial class LoginPage
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
            this.button_login = new System.Windows.Forms.Button();
            this.button_switchboard = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(241, 380);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(98, 44);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_switchboard
            // 
            this.button_switchboard.Location = new System.Drawing.Point(448, 456);
            this.button_switchboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_switchboard.Name = "button_switchboard";
            this.button_switchboard.Size = new System.Drawing.Size(141, 70);
            this.button_switchboard.TabIndex = 1;
            this.button_switchboard.Text = "Switchboard";
            this.button_switchboard.UseVisualStyleBackColor = true;
            this.button_switchboard.Click += new System.EventHandler(this.button_switchboard_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(116, 106);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(83, 20);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(115, 189);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(78, 20);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(241, 106);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(291, 26);
            this.txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(241, 189);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(291, 26);
            this.txt_password.TabIndex = 5;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(424, 380);
            this.button_register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(108, 44);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_switchboard);
            this.Controls.Add(this.button_login);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_switchboard;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button button_register;
    }
}