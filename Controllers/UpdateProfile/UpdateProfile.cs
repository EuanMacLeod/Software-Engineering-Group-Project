using System;
using System.Windows.Forms;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer.UpdateProfile
{
    public partial class UpdateProfile : Form
    {
        User user;
        private SoftwareSales softwareSales;
        public UpdateProfile(SoftwareSales softwareSales)
        {
            InitializeComponent();
            this.softwareSales = softwareSales;
        }
        
        public void SetUserData(User user)
        {
            this.user = user;
            textName.Text = user.Name;
            textEmail.Text = user.Email;
            textNumber.Text = user.ContactNumber;
            textUserName.Text = user.Username;
            
            textNumber.ReadOnly = false;
            textEmail.ReadOnly = false;
            textName.ReadOnly = false;
            textUserName.ReadOnly = false;

        }
        private bool ValidateInputs()
        {
            // Validate name
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Validation Error");
                return false;
            }

            // Validate email
            if (!IsValidEmail(textEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error");
                return false;
            }

            // Validate contact number 
            if (string.IsNullOrWhiteSpace(textNumber.Text))
            {
                MessageBox.Show("Please enter a valid contact number.", "Validation Error");
                return false;
            }

            // Validate username
            if (string.IsNullOrWhiteSpace(textUserName.Text))
            {
                MessageBox.Show("Please enter a valid username.", "Validation Error");
                return false;
            }

            // Validate password (if it's not null)
            if (textPassword != null && string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MessageBox.Show("Please enter a valid password.", "Validation Error");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            // textName.Text = user.Name;
            // textName.ReadOnly = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            // textEmail.Text = user.Email;
            // textEmail.ReadOnly = false;
        }

        private void textNumber_TextChanged(object sender, EventArgs e)
        {
            // textNumber.Text = user.ContactNumber;
            // textNumber.ReadOnly = false;
        }

        public void UpdateUserData(SoftwareSales softwareSales)
        {
            if (textPassword == null)
            {
                User user = DBConnections.getInstanceOfDBConnection().getUserFromDB(textUserName.Text, textCurrentPassword.Text.Trim());
                
                softwareSales.RefreshUserData(user);
            }

            if (textPassword != null)
            {
                User user = DBConnections.getInstanceOfDBConnection().getUserFromDB(textUserName.Text, textPassword.Text.Trim());
               
                softwareSales.RefreshUserData(user);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DBConnections.getInstanceOfDBConnection().VerifyCurrentPassword(user.Username, textCurrentPassword.Text))
            {
                if (ValidateInputs())
                {
                    string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(textPassword.Text.Trim(), 13);
                    // The current password is correct, proceed with the desired operation
                    DBConnections.getInstanceOfDBConnection().UpdateEmployeeInDB(user.Id, textName.Text,
                        textNumber.Text, textUserName.Text, passwordHash, textEmail.Text);
                    // updates user details
                    UpdateUserData(this.softwareSales);
                    MessageBox.Show("User is updated successfully ");
                }
            }
            else
            {
                // The current password is incorrect
                MessageBox.Show("Incorrect current password. Please try again.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}