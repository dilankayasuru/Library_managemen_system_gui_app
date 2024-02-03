namespace LMS.Forms
{
    partial class MemberWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberWindow));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.borrowedBooksBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.browseBooksBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.adminName = new System.Windows.Forms.Label();
            this.adminImg = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.navigationPanel.Controls.Add(this.borrowedBooksBtn);
            this.navigationPanel.Controls.Add(this.logoutBtn);
            this.navigationPanel.Controls.Add(this.returnBtn);
            this.navigationPanel.Controls.Add(this.borrowBtn);
            this.navigationPanel.Controls.Add(this.browseBooksBtn);
            this.navigationPanel.Controls.Add(this.homeBtn);
            this.navigationPanel.Controls.Add(this.welcome);
            this.navigationPanel.Controls.Add(this.adminName);
            this.navigationPanel.Controls.Add(this.adminImg);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPanel.ForeColor = System.Drawing.Color.Black;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(300, 729);
            this.navigationPanel.TabIndex = 1;
            // 
            // borrowedBooksBtn
            // 
            this.borrowedBooksBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.borrowedBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowedBooksBtn.FlatAppearance.BorderSize = 0;
            this.borrowedBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowedBooksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.borrowedBooksBtn.Image = global::LMS.Properties.Resources.borrowedBooksIcon;
            this.borrowedBooksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowedBooksBtn.Location = new System.Drawing.Point(-3, 364);
            this.borrowedBooksBtn.Margin = new System.Windows.Forms.Padding(0);
            this.borrowedBooksBtn.Name = "borrowedBooksBtn";
            this.borrowedBooksBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.borrowedBooksBtn.Size = new System.Drawing.Size(300, 45);
            this.borrowedBooksBtn.TabIndex = 8;
            this.borrowedBooksBtn.Text = "     Show Borrowed Books";
            this.borrowedBooksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.borrowedBooksBtn.UseVisualStyleBackColor = true;
            this.borrowedBooksBtn.Click += new System.EventHandler(this.borrowedBooksBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.logoutBtn.Image = global::LMS.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(100, 630);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 36);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.returnBtn.Image = global::LMS.Properties.Resources.returnBookIcon;
            this.returnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.Location = new System.Drawing.Point(0, 454);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(0);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.returnBtn.Size = new System.Drawing.Size(300, 45);
            this.returnBtn.TabIndex = 6;
            this.returnBtn.Text = "     Return Books";
            this.returnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // borrowBtn
            // 
            this.borrowBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.borrowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowBtn.FlatAppearance.BorderSize = 0;
            this.borrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.borrowBtn.Image = global::LMS.Properties.Resources.borrowBookIcon;
            this.borrowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBtn.Location = new System.Drawing.Point(0, 409);
            this.borrowBtn.Margin = new System.Windows.Forms.Padding(0);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.borrowBtn.Size = new System.Drawing.Size(300, 45);
            this.borrowBtn.TabIndex = 5;
            this.borrowBtn.Text = "     Borrow Books";
            this.borrowBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // browseBooksBtn
            // 
            this.browseBooksBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.browseBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBooksBtn.FlatAppearance.BorderSize = 0;
            this.browseBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBooksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.browseBooksBtn.Image = global::LMS.Properties.Resources.searchIcon;
            this.browseBooksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseBooksBtn.Location = new System.Drawing.Point(0, 319);
            this.browseBooksBtn.Margin = new System.Windows.Forms.Padding(0);
            this.browseBooksBtn.Name = "browseBooksBtn";
            this.browseBooksBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.browseBooksBtn.Size = new System.Drawing.Size(300, 45);
            this.browseBooksBtn.TabIndex = 2;
            this.browseBooksBtn.Text = "     Browse Books";
            this.browseBooksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.browseBooksBtn.UseVisualStyleBackColor = true;
            this.browseBooksBtn.Click += new System.EventHandler(this.browseBooksBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.homeBtn.Image = global::LMS.Properties.Resources.homeIcon;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 274);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(300, 45);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "     Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.welcome.Location = new System.Drawing.Point(146, 102);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(91, 17);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome Back";
            // 
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.adminName.Location = new System.Drawing.Point(146, 119);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(62, 21);
            this.adminName.TabIndex = 0;
            this.adminName.Text = "Dilanka";
            // 
            // adminImg
            // 
            this.adminImg.Image = global::LMS.Properties.Resources.memberProfileImg;
            this.adminImg.Location = new System.Drawing.Point(40, 40);
            this.adminImg.Name = "adminImg";
            this.adminImg.Size = new System.Drawing.Size(100, 100);
            this.adminImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminImg.TabIndex = 0;
            this.adminImg.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(300, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1050, 729);
            this.mainPanel.TabIndex = 2;
            // 
            // MemberWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button browseBooksBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label adminName;
        private System.Windows.Forms.PictureBox adminImg;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button borrowedBooksBtn;
    }
}