namespace LMS.Forms
{
    partial class transactionCard
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
            this.transactionIdHeaderLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.count = new System.Windows.Forms.Label();
            this.performedByText = new System.Windows.Forms.Label();
            this.performedByLbl = new System.Windows.Forms.Label();
            this.transactionIDText = new System.Windows.Forms.Label();
            this.transactionNameTxt = new System.Windows.Forms.Label();
            this.transactionTypeLbl = new System.Windows.Forms.Label();
            this.memberNameTxt = new System.Windows.Forms.Label();
            this.memberNamelbl = new System.Windows.Forms.Label();
            this.memberIdTxt = new System.Windows.Forms.Label();
            this.memberIdLbl = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.Label();
            this.bookISBNTxt = new System.Windows.Forms.Label();
            this.bookISBNLbl = new System.Windows.Forms.Label();
            this.bookTitleTxt = new System.Windows.Forms.Label();
            this.bookTitleLbl = new System.Windows.Forms.Label();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionIdHeaderLbl
            // 
            this.transactionIdHeaderLbl.Location = new System.Drawing.Point(66, 6);
            this.transactionIdHeaderLbl.Margin = new System.Windows.Forms.Padding(3);
            this.transactionIdHeaderLbl.Name = "transactionIdHeaderLbl";
            this.transactionIdHeaderLbl.Size = new System.Drawing.Size(110, 25);
            this.transactionIdHeaderLbl.TabIndex = 0;
            this.transactionIdHeaderLbl.Text = "Transaction ID:";
            this.transactionIdHeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.performedByText);
            this.panel1.Controls.Add(this.performedByLbl);
            this.panel1.Controls.Add(this.transactionIDText);
            this.panel1.Controls.Add(this.transactionIdHeaderLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 37);
            this.panel1.TabIndex = 1;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(5, 8);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(17, 20);
            this.count.TabIndex = 4;
            this.count.Text = "0";
            // 
            // performedByText
            // 
            this.performedByText.Location = new System.Drawing.Point(636, 6);
            this.performedByText.Margin = new System.Windows.Forms.Padding(3);
            this.performedByText.Name = "performedByText";
            this.performedByText.Size = new System.Drawing.Size(310, 25);
            this.performedByText.TabIndex = 3;
            this.performedByText.Text = "Librarian - 1548";
            this.performedByText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // performedByLbl
            // 
            this.performedByLbl.Location = new System.Drawing.Point(520, 6);
            this.performedByLbl.Margin = new System.Windows.Forms.Padding(3);
            this.performedByLbl.Name = "performedByLbl";
            this.performedByLbl.Size = new System.Drawing.Size(110, 25);
            this.performedByLbl.TabIndex = 2;
            this.performedByLbl.Text = "Performed By:";
            this.performedByLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionIDText
            // 
            this.transactionIDText.Location = new System.Drawing.Point(182, 6);
            this.transactionIDText.Margin = new System.Windows.Forms.Padding(3);
            this.transactionIDText.Name = "transactionIDText";
            this.transactionIDText.Size = new System.Drawing.Size(310, 25);
            this.transactionIDText.TabIndex = 1;
            this.transactionIDText.Text = "784578";
            this.transactionIDText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionNameTxt
            // 
            this.transactionNameTxt.ForeColor = System.Drawing.Color.Black;
            this.transactionNameTxt.Location = new System.Drawing.Point(240, 53);
            this.transactionNameTxt.Margin = new System.Windows.Forms.Padding(3);
            this.transactionNameTxt.Name = "transactionNameTxt";
            this.transactionNameTxt.Size = new System.Drawing.Size(250, 25);
            this.transactionNameTxt.TabIndex = 5;
            this.transactionNameTxt.Text = "Borrowed Book";
            this.transactionNameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionTypeLbl
            // 
            this.transactionTypeLbl.ForeColor = System.Drawing.Color.Black;
            this.transactionTypeLbl.Location = new System.Drawing.Point(145, 53);
            this.transactionTypeLbl.Margin = new System.Windows.Forms.Padding(3);
            this.transactionTypeLbl.Name = "transactionTypeLbl";
            this.transactionTypeLbl.Size = new System.Drawing.Size(89, 25);
            this.transactionTypeLbl.TabIndex = 4;
            this.transactionTypeLbl.Text = "Transaction:";
            this.transactionTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memberNameTxt
            // 
            this.memberNameTxt.ForeColor = System.Drawing.Color.Black;
            this.memberNameTxt.Location = new System.Drawing.Point(240, 84);
            this.memberNameTxt.Margin = new System.Windows.Forms.Padding(3);
            this.memberNameTxt.Name = "memberNameTxt";
            this.memberNameTxt.Size = new System.Drawing.Size(250, 25);
            this.memberNameTxt.TabIndex = 7;
            this.memberNameTxt.Text = "Dilanka Yasuru";
            this.memberNameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memberNamelbl
            // 
            this.memberNamelbl.ForeColor = System.Drawing.Color.Black;
            this.memberNamelbl.Location = new System.Drawing.Point(145, 84);
            this.memberNamelbl.Margin = new System.Windows.Forms.Padding(3);
            this.memberNamelbl.Name = "memberNamelbl";
            this.memberNamelbl.Size = new System.Drawing.Size(89, 25);
            this.memberNamelbl.TabIndex = 6;
            this.memberNamelbl.Text = "Member: ";
            this.memberNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memberIdTxt
            // 
            this.memberIdTxt.ForeColor = System.Drawing.Color.Black;
            this.memberIdTxt.Location = new System.Drawing.Point(240, 115);
            this.memberIdTxt.Margin = new System.Windows.Forms.Padding(3);
            this.memberIdTxt.Name = "memberIdTxt";
            this.memberIdTxt.Size = new System.Drawing.Size(250, 25);
            this.memberIdTxt.TabIndex = 9;
            this.memberIdTxt.Text = "15485926";
            this.memberIdTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memberIdLbl
            // 
            this.memberIdLbl.ForeColor = System.Drawing.Color.Black;
            this.memberIdLbl.Location = new System.Drawing.Point(145, 115);
            this.memberIdLbl.Margin = new System.Windows.Forms.Padding(3);
            this.memberIdLbl.Name = "memberIdLbl";
            this.memberIdLbl.Size = new System.Drawing.Size(89, 25);
            this.memberIdLbl.TabIndex = 8;
            this.memberIdLbl.Text = "Member ID: ";
            this.memberIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTxt
            // 
            this.dateTxt.ForeColor = System.Drawing.Color.Black;
            this.dateTxt.Location = new System.Drawing.Point(519, 115);
            this.dateTxt.Margin = new System.Windows.Forms.Padding(3);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(89, 25);
            this.dateTxt.TabIndex = 14;
            this.dateTxt.Text = "Date: ";
            this.dateTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookISBNTxt
            // 
            this.bookISBNTxt.ForeColor = System.Drawing.Color.Black;
            this.bookISBNTxt.Location = new System.Drawing.Point(614, 84);
            this.bookISBNTxt.Margin = new System.Windows.Forms.Padding(3);
            this.bookISBNTxt.Name = "bookISBNTxt";
            this.bookISBNTxt.Size = new System.Drawing.Size(250, 25);
            this.bookISBNTxt.TabIndex = 13;
            this.bookISBNTxt.Text = "4849-4697-3164-46845-4652";
            this.bookISBNTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookISBNLbl
            // 
            this.bookISBNLbl.ForeColor = System.Drawing.Color.Black;
            this.bookISBNLbl.Location = new System.Drawing.Point(519, 84);
            this.bookISBNLbl.Margin = new System.Windows.Forms.Padding(3);
            this.bookISBNLbl.Name = "bookISBNLbl";
            this.bookISBNLbl.Size = new System.Drawing.Size(89, 25);
            this.bookISBNLbl.TabIndex = 12;
            this.bookISBNLbl.Text = "Book ISBN: ";
            this.bookISBNLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookTitleTxt
            // 
            this.bookTitleTxt.ForeColor = System.Drawing.Color.Black;
            this.bookTitleTxt.Location = new System.Drawing.Point(614, 53);
            this.bookTitleTxt.Margin = new System.Windows.Forms.Padding(3);
            this.bookTitleTxt.Name = "bookTitleTxt";
            this.bookTitleTxt.Size = new System.Drawing.Size(250, 25);
            this.bookTitleTxt.TabIndex = 11;
            this.bookTitleTxt.Text = "Harry Potter";
            this.bookTitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.ForeColor = System.Drawing.Color.Black;
            this.bookTitleLbl.Location = new System.Drawing.Point(519, 53);
            this.bookTitleLbl.Margin = new System.Windows.Forms.Padding(3);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(89, 25);
            this.bookTitleLbl.TabIndex = 10;
            this.bookTitleLbl.Text = "Book: ";
            this.bookTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionDate
            // 
            this.transactionDate.Enabled = false;
            this.transactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transactionDate.Location = new System.Drawing.Point(618, 114);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(131, 27);
            this.transactionDate.TabIndex = 16;
            // 
            // transactionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.transactionDate);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.bookISBNTxt);
            this.Controls.Add(this.bookISBNLbl);
            this.Controls.Add(this.bookTitleTxt);
            this.Controls.Add(this.bookTitleLbl);
            this.Controls.Add(this.memberIdTxt);
            this.Controls.Add(this.memberIdLbl);
            this.Controls.Add(this.memberNameTxt);
            this.Controls.Add(this.memberNamelbl);
            this.Controls.Add(this.transactionNameTxt);
            this.Controls.Add(this.transactionTypeLbl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MaximumSize = new System.Drawing.Size(1008, 157);
            this.MinimumSize = new System.Drawing.Size(1008, 157);
            this.Name = "transactionCard";
            this.Size = new System.Drawing.Size(1006, 155);
            this.Load += new System.EventHandler(this.transactionCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label transactionIdHeaderLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label performedByText;
        private System.Windows.Forms.Label performedByLbl;
        private System.Windows.Forms.Label transactionIDText;
        private System.Windows.Forms.Label transactionNameTxt;
        private System.Windows.Forms.Label transactionTypeLbl;
        private System.Windows.Forms.Label memberNameTxt;
        private System.Windows.Forms.Label memberNamelbl;
        private System.Windows.Forms.Label memberIdTxt;
        private System.Windows.Forms.Label memberIdLbl;
        private System.Windows.Forms.Label dateTxt;
        private System.Windows.Forms.Label bookISBNTxt;
        private System.Windows.Forms.Label bookISBNLbl;
        private System.Windows.Forms.Label bookTitleTxt;
        private System.Windows.Forms.Label bookTitleLbl;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.Label count;
    }
}
