namespace LMS.Forms
{
    partial class MemberHome
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
            this.borrowedBooksPanel = new System.Windows.Forms.Panel();
            this.borrowedBooksCount = new System.Windows.Forms.Label();
            this.borrowedBookLbl = new System.Windows.Forms.Label();
            this.availableBooksPanel = new System.Windows.Forms.Panel();
            this.availableBooksCount = new System.Windows.Forms.Label();
            this.availableBooksLbl = new System.Windows.Forms.Label();
            this.profileDetailsPanel = new System.Windows.Forms.Panel();
            this.quotePanel = new System.Windows.Forms.Panel();
            this.profileLbl = new System.Windows.Forms.Label();
            this.borrowedBooksPanel.SuspendLayout();
            this.availableBooksPanel.SuspendLayout();
            this.profileDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(13, 10);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(276, 30);
            this.headerText.TabIndex = 1;
            this.headerText.Text = "Library Management System";
            // 
            // borrowedBooksPanel
            // 
            this.borrowedBooksPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.borrowedBooksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(191)))), ((int)(((byte)(179)))));
            this.borrowedBooksPanel.Controls.Add(this.borrowedBooksCount);
            this.borrowedBooksPanel.Controls.Add(this.borrowedBookLbl);
            this.borrowedBooksPanel.Location = new System.Drawing.Point(803, 91);
            this.borrowedBooksPanel.Name = "borrowedBooksPanel";
            this.borrowedBooksPanel.Padding = new System.Windows.Forms.Padding(5);
            this.borrowedBooksPanel.Size = new System.Drawing.Size(200, 100);
            this.borrowedBooksPanel.TabIndex = 6;
            // 
            // borrowedBooksCount
            // 
            this.borrowedBooksCount.AutoSize = true;
            this.borrowedBooksCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedBooksCount.Location = new System.Drawing.Point(62, 18);
            this.borrowedBooksCount.Name = "borrowedBooksCount";
            this.borrowedBooksCount.Size = new System.Drawing.Size(77, 47);
            this.borrowedBooksCount.TabIndex = 2;
            this.borrowedBooksCount.Text = "150";
            // 
            // borrowedBookLbl
            // 
            this.borrowedBookLbl.AutoSize = true;
            this.borrowedBookLbl.Location = new System.Drawing.Point(8, 75);
            this.borrowedBookLbl.Name = "borrowedBookLbl";
            this.borrowedBookLbl.Size = new System.Drawing.Size(88, 21);
            this.borrowedBookLbl.TabIndex = 0;
            this.borrowedBookLbl.Text = "Total Books";
            // 
            // availableBooksPanel
            // 
            this.availableBooksPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.availableBooksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.availableBooksPanel.Controls.Add(this.availableBooksCount);
            this.availableBooksPanel.Controls.Add(this.availableBooksLbl);
            this.availableBooksPanel.Location = new System.Drawing.Point(549, 91);
            this.availableBooksPanel.Name = "availableBooksPanel";
            this.availableBooksPanel.Padding = new System.Windows.Forms.Padding(5);
            this.availableBooksPanel.Size = new System.Drawing.Size(200, 100);
            this.availableBooksPanel.TabIndex = 5;
            // 
            // availableBooksCount
            // 
            this.availableBooksCount.AutoSize = true;
            this.availableBooksCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableBooksCount.Location = new System.Drawing.Point(62, 18);
            this.availableBooksCount.Name = "availableBooksCount";
            this.availableBooksCount.Size = new System.Drawing.Size(77, 47);
            this.availableBooksCount.TabIndex = 2;
            this.availableBooksCount.Text = "150";
            // 
            // availableBooksLbl
            // 
            this.availableBooksLbl.AutoSize = true;
            this.availableBooksLbl.Location = new System.Drawing.Point(8, 75);
            this.availableBooksLbl.Name = "availableBooksLbl";
            this.availableBooksLbl.Size = new System.Drawing.Size(88, 21);
            this.availableBooksLbl.TabIndex = 0;
            this.availableBooksLbl.Text = "Total Books";
            // 
            // profileDetailsPanel
            // 
            this.profileDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.profileDetailsPanel.Controls.Add(this.profileLbl);
            this.profileDetailsPanel.Location = new System.Drawing.Point(47, 91);
            this.profileDetailsPanel.Name = "profileDetailsPanel";
            this.profileDetailsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.profileDetailsPanel.Size = new System.Drawing.Size(454, 547);
            this.profileDetailsPanel.TabIndex = 8;
            // 
            // quotePanel
            // 
            this.quotePanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quotePanel.BackgroundImage = global::LMS.Properties.Resources.issueBookImg;
            this.quotePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quotePanel.Location = new System.Drawing.Point(549, 246);
            this.quotePanel.Name = "quotePanel";
            this.quotePanel.Size = new System.Drawing.Size(454, 392);
            this.quotePanel.TabIndex = 7;
            // 
            // profileLbl
            // 
            this.profileLbl.AutoSize = true;
            this.profileLbl.Location = new System.Drawing.Point(13, 10);
            this.profileLbl.Name = "profileLbl";
            this.profileLbl.Size = new System.Drawing.Size(55, 21);
            this.profileLbl.TabIndex = 1;
            this.profileLbl.Text = "Profile";
            // 
            // MemberHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.profileDetailsPanel);
            this.Controls.Add(this.quotePanel);
            this.Controls.Add(this.borrowedBooksPanel);
            this.Controls.Add(this.availableBooksPanel);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberHome";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1050, 729);
            this.borrowedBooksPanel.ResumeLayout(false);
            this.borrowedBooksPanel.PerformLayout();
            this.availableBooksPanel.ResumeLayout(false);
            this.availableBooksPanel.PerformLayout();
            this.profileDetailsPanel.ResumeLayout(false);
            this.profileDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Panel borrowedBooksPanel;
        private System.Windows.Forms.Label borrowedBooksCount;
        private System.Windows.Forms.Label borrowedBookLbl;
        private System.Windows.Forms.Panel availableBooksPanel;
        private System.Windows.Forms.Label availableBooksCount;
        private System.Windows.Forms.Label availableBooksLbl;
        private System.Windows.Forms.Panel quotePanel;
        private System.Windows.Forms.Panel profileDetailsPanel;
        private System.Windows.Forms.Label profileLbl;
    }
}
