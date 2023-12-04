using System.ComponentModel;

namespace Software_Engineering_Project_New.Controllers.DatabaseEngineer.SubmitReview
{
    partial class SubmitReview
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
            this.reviewTextbox = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reviewTextbox
            // 
            this.reviewTextbox.Location = new System.Drawing.Point(169, 71);
            this.reviewTextbox.Name = "reviewTextbox";
            this.reviewTextbox.Size = new System.Drawing.Size(496, 152);
            this.reviewTextbox.TabIndex = 0;
            this.reviewTextbox.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(317, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(208, 48);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SubmitReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.reviewTextbox);
            this.Name = "SubmitReview";
            this.Text = "SubmitReview";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox reviewTextbox;
        private System.Windows.Forms.Button btnSubmit;

        #endregion
    }
}