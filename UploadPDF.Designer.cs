namespace Software_Engineering_Project_New
{
    partial class UploadPDF
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
            this.button_exit = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label_pdfname = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_url = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(257, 287);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(231, 96);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(311, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(231, 122);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(311, 20);
            this.txt_author.TabIndex = 2;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(231, 148);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(311, 20);
            this.txt_url.TabIndex = 3;
            // 
            // label_pdfname
            // 
            this.label_pdfname.AutoSize = true;
            this.label_pdfname.Location = new System.Drawing.Point(96, 102);
            this.label_pdfname.Name = "label_pdfname";
            this.label_pdfname.Size = new System.Drawing.Size(59, 13);
            this.label_pdfname.TabIndex = 4;
            this.label_pdfname.Text = "PDF Name";
            this.label_pdfname.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(96, 129);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(49, 13);
            this.label_author.TabIndex = 5;
            this.label_author.Text = "Author(s)";
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(96, 155);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(29, 13);
            this.label_url.TabIndex = 6;
            this.label_url.Text = "URL";
            // 
            // button_upload
            // 
            this.button_upload.Location = new System.Drawing.Point(387, 287);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(75, 23);
            this.button_upload.TabIndex = 7;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // UploadPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_pdfname);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.button_exit);
            this.Name = "UploadPDF";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label_pdfname;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Button button_upload;
    }
}