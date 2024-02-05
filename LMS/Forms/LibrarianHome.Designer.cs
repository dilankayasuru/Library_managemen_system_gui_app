namespace LMS.Forms
{
    partial class LibrarianHome
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
            this.headerText = new System.Windows.Forms.Label();
            this.totalBookPanel = new System.Windows.Forms.Panel();
            this.totalBookCount = new System.Windows.Forms.Label();
            this.totalBooksLbl = new System.Windows.Forms.Label();
            this.availableBookPanel = new System.Windows.Forms.Panel();
            this.availableCount = new System.Windows.Forms.Label();
            this.availbleBooks = new System.Windows.Forms.Label();
            this.issuedBooksPanel = new System.Windows.Forms.Panel();
            this.issuedBookCount = new System.Windows.Forms.Label();
            this.issuedBooks = new System.Windows.Forms.Label();
            this.totalMembersPanel = new System.Windows.Forms.Panel();
            this.totalMemberCount = new System.Windows.Forms.Label();
            this.totalMembers = new System.Windows.Forms.Label();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.totalBookPanel.SuspendLayout();
            this.availableBookPanel.SuspendLayout();
            this.issuedBooksPanel.SuspendLayout();
            this.totalMembersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(13, 10);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(276, 30);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Library Management System";
            // 
            // totalBookPanel
            // 
            this.totalBookPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.totalBookPanel.Controls.Add(this.totalBookCount);
            this.totalBookPanel.Controls.Add(this.totalBooksLbl);
            this.totalBookPanel.Location = new System.Drawing.Point(44, 89);
            this.totalBookPanel.Name = "totalBookPanel";
            this.totalBookPanel.Padding = new System.Windows.Forms.Padding(5);
            this.totalBookPanel.Size = new System.Drawing.Size(200, 100);
            this.totalBookPanel.TabIndex = 1;
            // 
            // totalBookCount
            // 
            this.totalBookCount.AutoSize = true;
            this.totalBookCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBookCount.Location = new System.Drawing.Point(62, 18);
            this.totalBookCount.Name = "totalBookCount";
            this.totalBookCount.Size = new System.Drawing.Size(77, 47);
            this.totalBookCount.TabIndex = 2;
            this.totalBookCount.Text = "150";
            // 
            // totalBooksLbl
            // 
            this.totalBooksLbl.AutoSize = true;
            this.totalBooksLbl.Location = new System.Drawing.Point(8, 75);
            this.totalBooksLbl.Name = "totalBooksLbl";
            this.totalBooksLbl.Size = new System.Drawing.Size(86, 20);
            this.totalBooksLbl.TabIndex = 0;
            this.totalBooksLbl.Text = "Total Books";
            // 
            // availableBookPanel
            // 
            this.availableBookPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.availableBookPanel.Controls.Add(this.availableCount);
            this.availableBookPanel.Controls.Add(this.availbleBooks);
            this.availableBookPanel.Location = new System.Drawing.Point(298, 89);
            this.availableBookPanel.Name = "availableBookPanel";
            this.availableBookPanel.Padding = new System.Windows.Forms.Padding(5);
            this.availableBookPanel.Size = new System.Drawing.Size(200, 100);
            this.availableBookPanel.TabIndex = 3;
            // 
            // availableCount
            // 
            this.availableCount.AutoSize = true;
            this.availableCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCount.Location = new System.Drawing.Point(62, 18);
            this.availableCount.Name = "availableCount";
            this.availableCount.Size = new System.Drawing.Size(77, 47);
            this.availableCount.TabIndex = 2;
            this.availableCount.Text = "150";
            // 
            // availbleBooks
            // 
            this.availbleBooks.AutoSize = true;
            this.availbleBooks.Location = new System.Drawing.Point(8, 75);
            this.availbleBooks.Name = "availbleBooks";
            this.availbleBooks.Size = new System.Drawing.Size(115, 20);
            this.availbleBooks.TabIndex = 0;
            this.availbleBooks.Text = "Available Books";
            // 
            // issuedBooksPanel
            // 
            this.issuedBooksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(191)))), ((int)(((byte)(179)))));
            this.issuedBooksPanel.Controls.Add(this.issuedBookCount);
            this.issuedBooksPanel.Controls.Add(this.issuedBooks);
            this.issuedBooksPanel.Location = new System.Drawing.Point(552, 89);
            this.issuedBooksPanel.Name = "issuedBooksPanel";
            this.issuedBooksPanel.Padding = new System.Windows.Forms.Padding(5);
            this.issuedBooksPanel.Size = new System.Drawing.Size(200, 100);
            this.issuedBooksPanel.TabIndex = 4;
            // 
            // issuedBookCount
            // 
            this.issuedBookCount.AutoSize = true;
            this.issuedBookCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBookCount.Location = new System.Drawing.Point(62, 18);
            this.issuedBookCount.Name = "issuedBookCount";
            this.issuedBookCount.Size = new System.Drawing.Size(77, 47);
            this.issuedBookCount.TabIndex = 2;
            this.issuedBookCount.Text = "150";
            // 
            // issuedBooks
            // 
            this.issuedBooks.AutoSize = true;
            this.issuedBooks.Location = new System.Drawing.Point(8, 75);
            this.issuedBooks.Name = "issuedBooks";
            this.issuedBooks.Size = new System.Drawing.Size(94, 20);
            this.issuedBooks.TabIndex = 0;
            this.issuedBooks.Text = "Issued Books";
            // 
            // totalMembersPanel
            // 
            this.totalMembersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.totalMembersPanel.Controls.Add(this.totalMemberCount);
            this.totalMembersPanel.Controls.Add(this.totalMembers);
            this.totalMembersPanel.Location = new System.Drawing.Point(806, 89);
            this.totalMembersPanel.Name = "totalMembersPanel";
            this.totalMembersPanel.Padding = new System.Windows.Forms.Padding(5);
            this.totalMembersPanel.Size = new System.Drawing.Size(200, 100);
            this.totalMembersPanel.TabIndex = 5;
            // 
            // totalMemberCount
            // 
            this.totalMemberCount.AutoSize = true;
            this.totalMemberCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMemberCount.Location = new System.Drawing.Point(62, 18);
            this.totalMemberCount.Name = "totalMemberCount";
            this.totalMemberCount.Size = new System.Drawing.Size(77, 47);
            this.totalMemberCount.TabIndex = 2;
            this.totalMemberCount.Text = "150";
            // 
            // totalMembers
            // 
            this.totalMembers.AutoSize = true;
            this.totalMembers.Location = new System.Drawing.Point(8, 75);
            this.totalMembers.Name = "totalMembers";
            this.totalMembers.Size = new System.Drawing.Size(108, 20);
            this.totalMembers.TabIndex = 0;
            this.totalMembers.Text = "Total Members";
            // 
            // chartPanel
            // 
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartPanel.Location = new System.Drawing.Point(10, 249);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(1030, 470);
            this.chartPanel.TabIndex = 6;
            // 
            // LibrarianHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.totalMembersPanel);
            this.Controls.Add(this.issuedBooksPanel);
            this.Controls.Add(this.availableBookPanel);
            this.Controls.Add(this.totalBookPanel);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibrarianHome";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1050, 729);
            this.Load += new System.EventHandler(this.LibrarianHome_Load);
            this.totalBookPanel.ResumeLayout(false);
            this.totalBookPanel.PerformLayout();
            this.availableBookPanel.ResumeLayout(false);
            this.availableBookPanel.PerformLayout();
            this.issuedBooksPanel.ResumeLayout(false);
            this.issuedBooksPanel.PerformLayout();
            this.totalMembersPanel.ResumeLayout(false);
            this.totalMembersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Panel totalBookPanel;
        private System.Windows.Forms.Label totalBooksLbl;
        private System.Windows.Forms.Label totalBookCount;
        private System.Windows.Forms.Panel availableBookPanel;
        private System.Windows.Forms.Label availableCount;
        private System.Windows.Forms.Label availbleBooks;
        private System.Windows.Forms.Panel issuedBooksPanel;
        private System.Windows.Forms.Label issuedBookCount;
        private System.Windows.Forms.Label issuedBooks;
        private System.Windows.Forms.Panel totalMembersPanel;
        private System.Windows.Forms.Label totalMemberCount;
        private System.Windows.Forms.Label totalMembers;
        private System.Windows.Forms.Panel chartPanel;
    }
}
