namespace LMS.Forms
{
    partial class borrowedBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookImg = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.isbnLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.publishedYear = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.publishedYearTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).BeginInit();
            this.SuspendLayout();
            // 
            // bookImg
            // 
            this.bookImg.Image = global::LMS.Properties.Resources.book;
            this.bookImg.Location = new System.Drawing.Point(64, 10);
            this.bookImg.Name = "bookImg";
            this.bookImg.Size = new System.Drawing.Size(137, 162);
            this.bookImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookImg.TabIndex = 0;
            this.bookImg.TabStop = false;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(286, 18);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(108, 28);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Book Title: ";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.Location = new System.Drawing.Point(286, 60);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(63, 28);
            this.isbnLbl.TabIndex = 2;
            this.isbnLbl.Text = "ISBN: ";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(286, 102);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(82, 28);
            this.authorLbl.TabIndex = 3;
            this.authorLbl.Text = "Author: ";
            // 
            // publishedYear
            // 
            this.publishedYear.AutoSize = true;
            this.publishedYear.Location = new System.Drawing.Point(286, 145);
            this.publishedYear.Name = "publishedYear";
            this.publishedYear.Size = new System.Drawing.Size(147, 28);
            this.publishedYear.TabIndex = 4;
            this.publishedYear.Text = "Published Year: ";
            // 
            // titleTxt
            // 
            this.titleTxt.Enabled = false;
            this.titleTxt.Location = new System.Drawing.Point(411, 14);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.ReadOnly = true;
            this.titleTxt.Size = new System.Drawing.Size(278, 34);
            this.titleTxt.TabIndex = 7;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Enabled = false;
            this.isbnTxt.Location = new System.Drawing.Point(411, 56);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.ReadOnly = true;
            this.isbnTxt.Size = new System.Drawing.Size(278, 34);
            this.isbnTxt.TabIndex = 8;
            // 
            // authorTxt
            // 
            this.authorTxt.Enabled = false;
            this.authorTxt.Location = new System.Drawing.Point(411, 98);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.ReadOnly = true;
            this.authorTxt.Size = new System.Drawing.Size(278, 34);
            this.authorTxt.TabIndex = 9;
            // 
            // publishedYearTxt
            // 
            this.publishedYearTxt.Enabled = false;
            this.publishedYearTxt.Location = new System.Drawing.Point(411, 140);
            this.publishedYearTxt.Name = "publishedYearTxt";
            this.publishedYearTxt.ReadOnly = true;
            this.publishedYearTxt.Size = new System.Drawing.Size(278, 34);
            this.publishedYearTxt.TabIndex = 10;
            // 
            // borrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.publishedYearTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.isbnTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.publishedYear);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.isbnLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.bookImg);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.Name = "borrowedBook";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(960, 182);
            this.Load += new System.EventHandler(this.borrowedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bookImg;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label isbnLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label publishedYear;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox publishedYearTxt;
    }
}
