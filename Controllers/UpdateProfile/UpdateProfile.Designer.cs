using System.ComponentModel;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer.UpdateProfile
{
    partial class UpdateProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textCurrentPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(174, 45);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(232, 31);
            this.textName.TabIndex = 1;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(174, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(174, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(174, 112);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(223, 31);
            this.textEmail.TabIndex = 4;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(174, 191);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(221, 31);
            this.textNumber.TabIndex = 5;
            this.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(558, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 68);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(173, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "CurrentPassword";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textCurrentPassword
            // 
            this.textCurrentPassword.Location = new System.Drawing.Point(174, 329);
            this.textCurrentPassword.Name = "textCurrentPassword";
            this.textCurrentPassword.Size = new System.Drawing.Size(222, 31);
            this.textCurrentPassword.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(173, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(172, 392);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(224, 31);
            this.textPassword.TabIndex = 10;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(174, 225);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(169, 24);
            this.UserName.TabIndex = 11;
            this.UserName.Text = "UserName";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(173, 264);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(222, 31);
            this.textUserName.TabIndex = 12;
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCurrentPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProfile";
            this.Text = "UpdateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textUserName;

        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label UserName;

        private System.Windows.Forms.TextBox textCurrentPassword;

        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.TextBox textNumber;

        private System.Windows.Forms.TextBox textEmail;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}