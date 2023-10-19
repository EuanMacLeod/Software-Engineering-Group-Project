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
            ExitButton = new Button();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            loginButton = new Button();
            termsAndConditionsBox = new CheckBox();
            dgvEmployees = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            ManagerID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(33, 213);
            ExitButton.Margin = new Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(86, 28);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(30, 50);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(77, 18);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            usernameLabel.Click += UsernameLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(30, 96);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(75, 18);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            passwordLabel.Click += PasswordLabel_Click;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(170, 48);
            usernameTextbox.Margin = new Padding(4, 3, 4, 3);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(116, 23);
            usernameTextbox.TabIndex = 3;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(170, 98);
            passwordTextbox.Margin = new Padding(4, 3, 4, 3);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(116, 23);
            passwordTextbox.TabIndex = 4;
            passwordTextbox.UseSystemPasswordChar = true;
            passwordTextbox.TextChanged += PasswordTextbox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Enabled = false;
            loginButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(170, 213);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(88, 27);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // termsAndConditionsBox
            // 
            termsAndConditionsBox.AutoSize = true;
            termsAndConditionsBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            termsAndConditionsBox.Location = new Point(33, 160);
            termsAndConditionsBox.Margin = new Padding(4, 3, 4, 3);
            termsAndConditionsBox.Name = "termsAndConditionsBox";
            termsAndConditionsBox.Size = new Size(125, 22);
            termsAndConditionsBox.TabIndex = 6;
            termsAndConditionsBox.Text = "I Accept T's&C's";
            termsAndConditionsBox.UseVisualStyleBackColor = true;
            termsAndConditionsBox.CheckedChanged += TermsAndConditionsBox_CheckedChanged;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, EmployeeName, Email, ContactNumber, Username, Password, ManagerID });
            dgvEmployees.Location = new Point(30, 261);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.Size = new Size(745, 246);
            dgvEmployees.TabIndex = 7;
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.Name = "EmployeeID";
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "EmployeeName";
            EmployeeName.Name = "EmployeeName";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // ContactNumber
            // 
            ContactNumber.HeaderText = "ContactNumber";
            ContactNumber.Name = "ContactNumber";
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            // 
            // ManagerID
            // 
            ManagerID.HeaderText = "ManagerID";
            ManagerID.Name = "ManagerID";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dgvEmployees);
            Controls.Add(termsAndConditionsBox);
            Controls.Add(loginButton);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(ExitButton);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button loginButton;
        private CheckBox termsAndConditionsBox;
        private DataGridView dgvEmployees;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn ManagerID;
    }
}

