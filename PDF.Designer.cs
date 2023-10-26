namespace Software_Engineering_Project_New
{
    partial class PDF
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
            this.button_pdfDB = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.button_download = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(400, 418);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_pdfDB
            // 
            this.button_pdfDB.Location = new System.Drawing.Point(71, 418);
            this.button_pdfDB.Margin = new System.Windows.Forms.Padding(4);
            this.button_pdfDB.Name = "button_pdfDB";
            this.button_pdfDB.Size = new System.Drawing.Size(100, 28);
            this.button_pdfDB.TabIndex = 2;
            this.button_pdfDB.Text = "PDF Database";
            this.button_pdfDB.UseVisualStyleBackColor = true;
            this.button_pdfDB.Click += new System.EventHandler(this.button_pdfDB_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(22, 388);
            this.txt_url.Margin = new System.Windows.Forms.Padding(4);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(553, 22);
            this.txt_url.TabIndex = 3;
            this.txt_url.TextChanged += new System.EventHandler(this.txt_url_TextChanged);
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(502, 31);
            this.button_download.Margin = new System.Windows.Forms.Padding(4);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(100, 28);
            this.button_download.TabIndex = 4;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(146, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(264, 394);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(83, 16);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Will i change";
            this.label_name.Visible = false;
            this.label_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 495);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.button_pdfDB);
            this.Controls.Add(this.button_exit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PDF";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PDF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_pdfDB;
        public System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button button_download;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label_name;
    }
}