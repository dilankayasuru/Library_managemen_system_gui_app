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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberHome));
            this.headerText = new System.Windows.Forms.Label();
            this.borrowedBooksPanel = new System.Windows.Forms.Panel();
            this.borrowedBooksCount = new System.Windows.Forms.Label();
            this.borrowedBookLbl = new System.Windows.Forms.Label();
            this.availableBooksPanel = new System.Windows.Forms.Panel();
            this.availableBooksCount = new System.Windows.Forms.Label();
            this.availableBooksLbl = new System.Windows.Forms.Label();
            this.profileDetailsPanel = new System.Windows.Forms.Panel();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.memberIDtxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.memberIdLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profileLbl = new System.Windows.Forms.Label();
            this.quotePanel = new System.Windows.Forms.Panel();
            this.quoteTxt = new System.Windows.Forms.Label();
            this.quoteLbl = new System.Windows.Forms.Label();
            this.borrowedBooksPanel.SuspendLayout();
            this.availableBooksPanel.SuspendLayout();
            this.profileDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.quotePanel.SuspendLayout();
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
            this.borrowedBooksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.borrowedBooksPanel.Controls.Add(this.borrowedBooksCount);
            this.borrowedBooksPanel.Controls.Add(this.borrowedBookLbl);
            this.borrowedBooksPanel.Location = new System.Drawing.Point(803, 91);
            this.borrowedBooksPanel.Name = "borrowedBooksPanel";
            this.borrowedBooksPanel.Padding = new System.Windows.Forms.Padding(5);
            this.borrowedBooksPanel.Size = new System.Drawing.Size(200, 124);
            this.borrowedBooksPanel.TabIndex = 6;
            // 
            // borrowedBooksCount
            // 
            this.borrowedBooksCount.AutoSize = true;
            this.borrowedBooksCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedBooksCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.borrowedBooksCount.Location = new System.Drawing.Point(62, 18);
            this.borrowedBooksCount.Name = "borrowedBooksCount";
            this.borrowedBooksCount.Size = new System.Drawing.Size(77, 47);
            this.borrowedBooksCount.TabIndex = 2;
            this.borrowedBooksCount.Text = "150";
            // 
            // borrowedBookLbl
            // 
            this.borrowedBookLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borrowedBookLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.borrowedBookLbl.Location = new System.Drawing.Point(5, 76);
            this.borrowedBookLbl.Name = "borrowedBookLbl";
            this.borrowedBookLbl.Size = new System.Drawing.Size(190, 43);
            this.borrowedBookLbl.TabIndex = 0;
            this.borrowedBookLbl.Text = "Borrowed Books";
            this.borrowedBookLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availableBooksPanel
            // 
            this.availableBooksPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.availableBooksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.availableBooksPanel.Controls.Add(this.availableBooksCount);
            this.availableBooksPanel.Controls.Add(this.availableBooksLbl);
            this.availableBooksPanel.Location = new System.Drawing.Point(549, 91);
            this.availableBooksPanel.Name = "availableBooksPanel";
            this.availableBooksPanel.Padding = new System.Windows.Forms.Padding(5);
            this.availableBooksPanel.Size = new System.Drawing.Size(200, 124);
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
            this.availableBooksLbl.Location = new System.Drawing.Point(7, 75);
            this.availableBooksLbl.Name = "availableBooksLbl";
            this.availableBooksLbl.Size = new System.Drawing.Size(186, 44);
            this.availableBooksLbl.TabIndex = 0;
            this.availableBooksLbl.Text = "Available Book copies in Library to Borrow\r\n";
            this.availableBooksLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // profileDetailsPanel
            // 
            this.profileDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.profileDetailsPanel.Controls.Add(this.userNameTxt);
            this.profileDetailsPanel.Controls.Add(this.lastNameTxt);
            this.profileDetailsPanel.Controls.Add(this.memberIDtxt);
            this.profileDetailsPanel.Controls.Add(this.firstNameTxt);
            this.profileDetailsPanel.Controls.Add(this.userNameLbl);
            this.profileDetailsPanel.Controls.Add(this.lastNameLbl);
            this.profileDetailsPanel.Controls.Add(this.memberIdLbl);
            this.profileDetailsPanel.Controls.Add(this.firstNameLbl);
            this.profileDetailsPanel.Controls.Add(this.pictureBox1);
            this.profileDetailsPanel.Controls.Add(this.profileLbl);
            this.profileDetailsPanel.Location = new System.Drawing.Point(47, 91);
            this.profileDetailsPanel.Name = "profileDetailsPanel";
            this.profileDetailsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.profileDetailsPanel.Size = new System.Drawing.Size(454, 547);
            this.profileDetailsPanel.TabIndex = 8;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Enabled = false;
            this.userNameTxt.Location = new System.Drawing.Point(165, 474);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(246, 29);
            this.userNameTxt.TabIndex = 11;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Enabled = false;
            this.lastNameTxt.Location = new System.Drawing.Point(165, 420);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(246, 29);
            this.lastNameTxt.TabIndex = 10;
            // 
            // memberIDtxt
            // 
            this.memberIDtxt.Enabled = false;
            this.memberIDtxt.Location = new System.Drawing.Point(165, 312);
            this.memberIDtxt.Name = "memberIDtxt";
            this.memberIDtxt.Size = new System.Drawing.Size(246, 29);
            this.memberIDtxt.TabIndex = 9;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Enabled = false;
            this.firstNameTxt.Location = new System.Drawing.Point(165, 366);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(246, 29);
            this.firstNameTxt.TabIndex = 8;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(43, 478);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(95, 21);
            this.userNameLbl.TabIndex = 6;
            this.userNameLbl.Text = "User Name: ";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(43, 424);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(91, 21);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Last Name: ";
            // 
            // memberIdLbl
            // 
            this.memberIdLbl.AutoSize = true;
            this.memberIdLbl.Location = new System.Drawing.Point(43, 316);
            this.memberIdLbl.Name = "memberIdLbl";
            this.memberIdLbl.Size = new System.Drawing.Size(95, 21);
            this.memberIdLbl.TabIndex = 4;
            this.memberIdLbl.Text = "Member ID: ";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(43, 370);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(93, 21);
            this.firstNameLbl.TabIndex = 3;
            this.firstNameLbl.Text = "First Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.memberProfileImg;
            this.pictureBox1.Location = new System.Drawing.Point(152, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // profileLbl
            // 
            this.profileLbl.AutoSize = true;
            this.profileLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLbl.Location = new System.Drawing.Point(191, 18);
            this.profileLbl.Name = "profileLbl";
            this.profileLbl.Size = new System.Drawing.Size(72, 30);
            this.profileLbl.TabIndex = 1;
            this.profileLbl.Text = "Profile";
            // 
            // quotePanel
            // 
            this.quotePanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quotePanel.BackgroundImage = global::LMS.Properties.Resources.issueBookImg;
            this.quotePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quotePanel.Controls.Add(this.quoteTxt);
            this.quotePanel.Controls.Add(this.quoteLbl);
            this.quotePanel.Location = new System.Drawing.Point(549, 246);
            this.quotePanel.Margin = new System.Windows.Forms.Padding(0);
            this.quotePanel.Name = "quotePanel";
            this.quotePanel.Size = new System.Drawing.Size(454, 392);
            this.quotePanel.TabIndex = 7;
            // 
            // quoteTxt
            // 
            this.quoteTxt.AutoSize = true;
            this.quoteTxt.BackColor = System.Drawing.Color.Transparent;
            this.quoteTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quoteTxt.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTxt.Location = new System.Drawing.Point(0, 57);
            this.quoteTxt.MaximumSize = new System.Drawing.Size(454, 0);
            this.quoteTxt.MinimumSize = new System.Drawing.Size(454, 0);
            this.quoteTxt.Name = "quoteTxt";
            this.quoteTxt.Padding = new System.Windows.Forms.Padding(15);
            this.quoteTxt.Size = new System.Drawing.Size(454, 155);
            this.quoteTxt.TabIndex = 5;
            this.quoteTxt.Text = resources.GetString("quoteTxt.Text");
            this.quoteTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quoteLbl
            // 
            this.quoteLbl.BackColor = System.Drawing.Color.Transparent;
            this.quoteLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.quoteLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteLbl.Location = new System.Drawing.Point(0, 0);
            this.quoteLbl.Name = "quoteLbl";
            this.quoteLbl.Size = new System.Drawing.Size(454, 57);
            this.quoteLbl.TabIndex = 1;
            this.quoteLbl.Text = "Daily Quotes";
            this.quoteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Load += new System.EventHandler(this.MemberHome_Load);
            this.borrowedBooksPanel.ResumeLayout(false);
            this.borrowedBooksPanel.PerformLayout();
            this.availableBooksPanel.ResumeLayout(false);
            this.availableBooksPanel.PerformLayout();
            this.profileDetailsPanel.ResumeLayout(false);
            this.profileDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.quotePanel.ResumeLayout(false);
            this.quotePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Panel borrowedBooksPanel;
        private System.Windows.Forms.Label borrowedBooksCount;
        private System.Windows.Forms.Label borrowedBookLbl;
        private System.Windows.Forms.Panel availableBooksPanel;
        private System.Windows.Forms.Label availableBooksLbl;
        private System.Windows.Forms.Panel quotePanel;
        private System.Windows.Forms.Panel profileDetailsPanel;
        private System.Windows.Forms.Label profileLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label memberIdLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox memberIDtxt;
        private System.Windows.Forms.Label quoteLbl;
        private System.Windows.Forms.Label quoteTxt;
        public System.Windows.Forms.Label availableBooksCount;
    }
}
