namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer
{
    partial class adminTools
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bttn_recovery = new System.Windows.Forms.Button();
            this.approveUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 224);
            this.button1.TabIndex = 0;
            this.button1.Text = "role id change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 224);
            this.button2.TabIndex = 0;
            this.button2.Text = "funn clicky button";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_recovery
            // 
            this.bttn_recovery.Location = new System.Drawing.Point(652, 102);
            this.bttn_recovery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttn_recovery.Name = "bttn_recovery";
            this.bttn_recovery.Size = new System.Drawing.Size(250, 224);
            this.bttn_recovery.TabIndex = 0;
            this.bttn_recovery.Text = "Account Recovery";
            this.bttn_recovery.UseVisualStyleBackColor = true;
            this.bttn_recovery.Click += new System.EventHandler(this.bttn_recovery_click);
            // 
            // approveUsersButton
            // 
            this.approveUsersButton.Location = new System.Drawing.Point(350, 383);
            this.approveUsersButton.Name = "approveUsersButton";
            this.approveUsersButton.Size = new System.Drawing.Size(250, 138);
            this.approveUsersButton.TabIndex = 1;
            this.approveUsersButton.Text = "Approve Users";
            this.approveUsersButton.UseVisualStyleBackColor = true;
            this.approveUsersButton.Click += new System.EventHandler(this.approveUsersButton_Clicked);
            // 
            // adminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.approveUsersButton);
            this.Controls.Add(this.bttn_recovery);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "adminTools";
            this.Text = "Ù";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttn_recovery;
        private System.Windows.Forms.Button approveUsersButton;
    }
}