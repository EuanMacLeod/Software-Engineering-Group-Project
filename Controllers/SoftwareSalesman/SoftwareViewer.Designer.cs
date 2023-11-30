﻿namespace Software_Engineering_Project_New.Controllers.SoftwareSalesman
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
            this.ViewerBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoftwareNameLabel = new System.Windows.Forms.Label();
            this.SoftwareDescLabel = new System.Windows.Forms.Label();
            this.AddInfoLabel = new System.Windows.Forms.Label();
            this.DemoDateLabel = new System.Windows.Forms.Label();
            this.documentLinkLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_Engineering_Project_New.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(580, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Date Of Demo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Document Link:";
            // 
            // SoftwareNameLabel
            // 
            this.SoftwareNameLabel.AutoSize = true;
            this.SoftwareNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareNameLabel.Location = new System.Drawing.Point(17, 15);
            this.SoftwareNameLabel.Name = "SoftwareNameLabel";
            this.SoftwareNameLabel.Size = new System.Drawing.Size(155, 25);
            this.SoftwareNameLabel.TabIndex = 29;
            this.SoftwareNameLabel.Text = "Software name";
            this.SoftwareNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SoftwareDescLabel
            // 
            this.SoftwareDescLabel.AutoSize = true;
            this.SoftwareDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareDescLabel.Location = new System.Drawing.Point(19, 60);
            this.SoftwareDescLabel.MaximumSize = new System.Drawing.Size(531, 92);
            this.SoftwareDescLabel.Name = "SoftwareDescLabel";
            this.SoftwareDescLabel.Size = new System.Drawing.Size(94, 16);
            this.SoftwareDescLabel.TabIndex = 30;
            this.SoftwareDescLabel.Text = "Software Desc";
            // 
            // AddInfoLabel
            // 
            this.AddInfoLabel.AutoSize = true;
            this.AddInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInfoLabel.Location = new System.Drawing.Point(16, 157);
            this.AddInfoLabel.MaximumSize = new System.Drawing.Size(531, 88);
            this.AddInfoLabel.Name = "AddInfoLabel";
            this.AddInfoLabel.Size = new System.Drawing.Size(135, 16);
            this.AddInfoLabel.TabIndex = 31;
            this.AddInfoLabel.Text = "Additional information";
            // 
            // DemoDateLabel
            // 
            this.DemoDateLabel.AutoSize = true;
            this.DemoDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemoDateLabel.Location = new System.Drawing.Point(113, 256);
            this.DemoDateLabel.Name = "DemoDateLabel";
            this.DemoDateLabel.Size = new System.Drawing.Size(76, 16);
            this.DemoDateLabel.TabIndex = 32;
            this.DemoDateLabel.Text = "Demo Date";
            // 
            // documentLinkLabel
            // 
            this.documentLinkLabel.AutoSize = true;
            this.documentLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentLinkLabel.Location = new System.Drawing.Point(116, 282);
            this.documentLinkLabel.Name = "documentLinkLabel";
            this.documentLinkLabel.Size = new System.Drawing.Size(91, 16);
            this.documentLinkLabel.TabIndex = 33;
            this.documentLinkLabel.Text = "Document link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Additional Info:";
            // 
            // SoftwareViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.documentLinkLabel);
            this.Controls.Add(this.DemoDateLabel);
            this.Controls.Add(this.AddInfoLabel);
            this.Controls.Add(this.SoftwareDescLabel);
            this.Controls.Add(this.SoftwareNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewerBackButton);
            this.Controls.Add(this.pictureBox2);
            this.Name = "SoftwareViewer";
            this.Text = "SoftwareViewer";
            this.Load += new System.EventHandler(this.SoftwareViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ViewerBackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SoftwareNameLabel;
        private System.Windows.Forms.Label SoftwareDescLabel;
        private System.Windows.Forms.Label AddInfoLabel;
        private System.Windows.Forms.Label DemoDateLabel;
        private System.Windows.Forms.Label documentLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}