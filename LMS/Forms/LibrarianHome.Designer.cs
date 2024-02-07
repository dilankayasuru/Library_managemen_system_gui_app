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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianHome));
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
            this.label1 = new System.Windows.Forms.Label();
            this.transactionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterLbl = new System.Windows.Forms.Label();
            this.refreshbtn = new System.Windows.Forms.Button();
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
            this.totalBookPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.totalBookPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.availableBookPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(237)))), ((int)(((byte)(185)))));
            this.availableBookPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.issuedBooksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(139)))));
            this.issuedBooksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.totalMembersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.totalMembersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.totalMemberCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalMemberCount.Location = new System.Drawing.Point(62, 18);
            this.totalMemberCount.Name = "totalMemberCount";
            this.totalMemberCount.Size = new System.Drawing.Size(77, 47);
            this.totalMemberCount.TabIndex = 2;
            this.totalMemberCount.Text = "150";
            // 
            // totalMembers
            // 
            this.totalMembers.AutoSize = true;
            this.totalMembers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalMembers.Location = new System.Drawing.Point(8, 75);
            this.totalMembers.Name = "totalMembers";
            this.totalMembers.Size = new System.Drawing.Size(108, 20);
            this.totalMembers.TabIndex = 0;
            this.totalMembers.Text = "Total Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Transaction History";
            // 
            // transactionPanel
            // 
            this.transactionPanel.AutoScroll = true;
            this.transactionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.transactionPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.transactionPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionPanel.Location = new System.Drawing.Point(10, 249);
            this.transactionPanel.Name = "transactionPanel";
            this.transactionPanel.Size = new System.Drawing.Size(1030, 470);
            this.transactionPanel.TabIndex = 8;
            this.transactionPanel.WrapContents = false;
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Date | new to old",
            "Date | old to new"});
            this.filterComboBox.Location = new System.Drawing.Point(843, 217);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(163, 28);
            this.filterComboBox.TabIndex = 9;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Location = new System.Drawing.Point(788, 221);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(49, 20);
            this.filterLbl.TabIndex = 10;
            this.filterLbl.Text = "Filter: ";
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshbtn.Image")));
            this.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshbtn.Location = new System.Drawing.Point(902, 13);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(104, 36);
            this.refreshbtn.TabIndex = 11;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // LibrarianHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.transactionPanel);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel transactionPanel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Button refreshbtn;
    }
}
