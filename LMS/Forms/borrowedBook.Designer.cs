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
            this.issuedDateLbl = new System.Windows.Forms.Label();
            this.returnDateLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.publishedYearTxt = new System.Windows.Forms.TextBox();
            this.borrowedDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
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
            this.titleLbl.Size = new System.Drawing.Size(85, 21);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Book Title: ";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.Location = new System.Drawing.Point(286, 60);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(51, 21);
            this.isbnLbl.TabIndex = 2;
            this.isbnLbl.Text = "ISBN: ";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(286, 102);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(65, 21);
            this.authorLbl.TabIndex = 3;
            this.authorLbl.Text = "Author: ";
            // 
            // publishedYear
            // 
            this.publishedYear.AutoSize = true;
            this.publishedYear.Location = new System.Drawing.Point(286, 145);
            this.publishedYear.Name = "publishedYear";
            this.publishedYear.Size = new System.Drawing.Size(119, 21);
            this.publishedYear.TabIndex = 4;
            this.publishedYear.Text = "Published Year: ";
            // 
            // issuedDateLbl
            // 
            this.issuedDateLbl.AutoSize = true;
            this.issuedDateLbl.Location = new System.Drawing.Point(776, 18);
            this.issuedDateLbl.Name = "issuedDateLbl";
            this.issuedDateLbl.Size = new System.Drawing.Size(121, 21);
            this.issuedDateLbl.TabIndex = 5;
            this.issuedDateLbl.Text = "Borrowed Date: ";
            // 
            // returnDateLbl
            // 
            this.returnDateLbl.AutoSize = true;
            this.returnDateLbl.Location = new System.Drawing.Point(776, 102);
            this.returnDateLbl.Name = "returnDateLbl";
            this.returnDateLbl.Size = new System.Drawing.Size(100, 21);
            this.returnDateLbl.TabIndex = 6;
            this.returnDateLbl.Text = "Return Date: ";
            // 
            // titleTxt
            // 
            this.titleTxt.Enabled = false;
            this.titleTxt.Location = new System.Drawing.Point(411, 14);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.ReadOnly = true;
            this.titleTxt.Size = new System.Drawing.Size(278, 29);
            this.titleTxt.TabIndex = 7;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Enabled = false;
            this.isbnTxt.Location = new System.Drawing.Point(411, 56);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.ReadOnly = true;
            this.isbnTxt.Size = new System.Drawing.Size(278, 29);
            this.isbnTxt.TabIndex = 8;
            // 
            // authorTxt
            // 
            this.authorTxt.Enabled = false;
            this.authorTxt.Location = new System.Drawing.Point(411, 98);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.ReadOnly = true;
            this.authorTxt.Size = new System.Drawing.Size(278, 29);
            this.authorTxt.TabIndex = 9;
            // 
            // publishedYearTxt
            // 
            this.publishedYearTxt.Enabled = false;
            this.publishedYearTxt.Location = new System.Drawing.Point(411, 140);
            this.publishedYearTxt.Name = "publishedYearTxt";
            this.publishedYearTxt.ReadOnly = true;
            this.publishedYearTxt.Size = new System.Drawing.Size(278, 29);
            this.publishedYearTxt.TabIndex = 10;
            // 
            // borrowedDate
            // 
            this.borrowedDate.Enabled = false;
            this.borrowedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.borrowedDate.Location = new System.Drawing.Point(780, 42);
            this.borrowedDate.Name = "borrowedDate";
            this.borrowedDate.Size = new System.Drawing.Size(117, 29);
            this.borrowedDate.TabIndex = 11;
            // 
            // returnDate
            // 
            this.returnDate.Enabled = false;
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returnDate.Location = new System.Drawing.Point(780, 126);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(117, 29);
            this.returnDate.TabIndex = 12;
            // 
            // borrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.borrowedDate);
            this.Controls.Add(this.publishedYearTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.isbnTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.returnDateLbl);
            this.Controls.Add(this.issuedDateLbl);
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
        private System.Windows.Forms.Label issuedDateLbl;
        private System.Windows.Forms.Label returnDateLbl;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox publishedYearTxt;
        private System.Windows.Forms.DateTimePicker borrowedDate;
        private System.Windows.Forms.DateTimePicker returnDate;
    }
}
