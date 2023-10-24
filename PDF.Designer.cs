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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_pdfDB = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(517, 415);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 332);
            this.webBrowser1.TabIndex = 1;
            // 
            // button_pdfDB
            // 
            this.button_pdfDB.Location = new System.Drawing.Point(176, 415);
            this.button_pdfDB.Name = "button_pdfDB";
            this.button_pdfDB.Size = new System.Drawing.Size(75, 23);
            this.button_pdfDB.TabIndex = 2;
            this.button_pdfDB.Text = "PDF Database";
            this.button_pdfDB.UseVisualStyleBackColor = true;
            this.button_pdfDB.Click += new System.EventHandler(this.button_pdfDB_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(176, 350);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(416, 20);
            this.txt_url.TabIndex = 3;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(336, 376);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 4;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.button_pdfDB);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button_exit);
            this.Name = "PDF";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_pdfDB;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button button_browse;
    }
}