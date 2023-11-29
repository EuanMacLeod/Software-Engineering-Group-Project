namespace Software_Engineering_Project_New.Controllers.SoftwareSalesman
{
    partial class SoftwareViewer
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ViewerDescriptionBox = new System.Windows.Forms.TextBox();
            this.ViewerNameBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ViewerBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_Engineering_Project_New.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // ViewerDescriptionBox
            // 
            this.ViewerDescriptionBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ViewerDescriptionBox.Location = new System.Drawing.Point(156, 38);
            this.ViewerDescriptionBox.Multiline = true;
            this.ViewerDescriptionBox.Name = "ViewerDescriptionBox";
            this.ViewerDescriptionBox.Size = new System.Drawing.Size(531, 100);
            this.ViewerDescriptionBox.TabIndex = 20;
            // 
            // ViewerNameBox
            // 
            this.ViewerNameBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ViewerNameBox.Location = new System.Drawing.Point(156, 12);
            this.ViewerNameBox.Name = "ViewerNameBox";
            this.ViewerNameBox.Size = new System.Drawing.Size(168, 20);
            this.ViewerNameBox.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(12, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Location = new System.Drawing.Point(12, 172);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Location = new System.Drawing.Point(12, 200);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.Location = new System.Drawing.Point(12, 228);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 22);
            this.textBox4.TabIndex = 25;
            // 
            // ViewerBackButton
            // 
            this.ViewerBackButton.Location = new System.Drawing.Point(700, 415);
            this.ViewerBackButton.Name = "ViewerBackButton";
            this.ViewerBackButton.Size = new System.Drawing.Size(75, 23);
            this.ViewerBackButton.TabIndex = 26;
            this.ViewerBackButton.Text = "Back";
            this.ViewerBackButton.UseVisualStyleBackColor = true;
            this.ViewerBackButton.Click += new System.EventHandler(this.ViewerBackButton_Click);
            // 
            // SoftwareViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewerBackButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ViewerDescriptionBox);
            this.Controls.Add(this.ViewerNameBox);
            this.Name = "SoftwareViewer";
            this.Text = "SoftwareViewer";
            this.Load += new System.EventHandler(this.SoftwareViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ViewerDescriptionBox;
        private System.Windows.Forms.TextBox ViewerNameBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ViewerBackButton;
    }
}