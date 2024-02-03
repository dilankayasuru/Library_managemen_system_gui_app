namespace LMS.Forms
{
    partial class LibrarianWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianWindow));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.adminName = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.issueBtn = new System.Windows.Forms.Button();
            this.manageBooksBtn = new System.Windows.Forms.Button();
            this.manageMembersBtn = new System.Windows.Forms.Button();
            this.browseBooksBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.adminImg = new System.Windows.Forms.PictureBox();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.navigationPanel.Controls.Add(this.logoutBtn);
            this.navigationPanel.Controls.Add(this.returnBtn);
            this.navigationPanel.Controls.Add(this.issueBtn);
            this.navigationPanel.Controls.Add(this.manageBooksBtn);
            this.navigationPanel.Controls.Add(this.manageMembersBtn);
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
            this.navigationPanel.TabIndex = 0;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.welcome.Location = new System.Drawing.Point(147, 102);
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
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(300, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1050, 729);
            this.mainPanel.TabIndex = 1;
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
            // issueBtn
            // 
            this.issueBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.issueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBtn.FlatAppearance.BorderSize = 0;
            this.issueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.issueBtn.Image = global::LMS.Properties.Resources.borrowBookIcon;
            this.issueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBtn.Location = new System.Drawing.Point(0, 409);
            this.issueBtn.Margin = new System.Windows.Forms.Padding(0);
            this.issueBtn.Name = "issueBtn";
            this.issueBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.issueBtn.Size = new System.Drawing.Size(300, 45);
            this.issueBtn.TabIndex = 5;
            this.issueBtn.Text = "     Issue Books";
            this.issueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.issueBtn.UseVisualStyleBackColor = true;
            this.issueBtn.Click += new System.EventHandler(this.issueBtn_Click);
            // 
            // manageBooksBtn
            // 
            this.manageBooksBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manageBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageBooksBtn.FlatAppearance.BorderSize = 0;
            this.manageBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBooksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.manageBooksBtn.Image = global::LMS.Properties.Resources.manageBooksIcon;
            this.manageBooksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBooksBtn.Location = new System.Drawing.Point(0, 364);
            this.manageBooksBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageBooksBtn.Name = "manageBooksBtn";
            this.manageBooksBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.manageBooksBtn.Size = new System.Drawing.Size(300, 45);
            this.manageBooksBtn.TabIndex = 4;
            this.manageBooksBtn.Text = "     Manage Books";
            this.manageBooksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageBooksBtn.UseVisualStyleBackColor = true;
            this.manageBooksBtn.Click += new System.EventHandler(this.manageBooksBtn_Click);
            // 
            // manageMembersBtn
            // 
            this.manageMembersBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manageMembersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageMembersBtn.FlatAppearance.BorderSize = 0;
            this.manageMembersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageMembersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.manageMembersBtn.Image = global::LMS.Properties.Resources.manageUsersIcon;
            this.manageMembersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageMembersBtn.Location = new System.Drawing.Point(0, 319);
            this.manageMembersBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageMembersBtn.Name = "manageMembersBtn";
            this.manageMembersBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.manageMembersBtn.Size = new System.Drawing.Size(300, 45);
            this.manageMembersBtn.TabIndex = 3;
            this.manageMembersBtn.Text = "     Manage Members";
            this.manageMembersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageMembersBtn.UseVisualStyleBackColor = true;
            this.manageMembersBtn.Click += new System.EventHandler(this.manageMembersBtn_Click);
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
            this.browseBooksBtn.Location = new System.Drawing.Point(0, 274);
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
            this.homeBtn.Location = new System.Drawing.Point(0, 229);
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
            // adminImg
            // 
            this.adminImg.Image = global::LMS.Properties.Resources.librarianProfileImg;
            this.adminImg.Location = new System.Drawing.Point(40, 40);
            this.adminImg.Name = "adminImg";
            this.adminImg.Size = new System.Drawing.Size(100, 100);
            this.adminImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminImg.TabIndex = 0;
            this.adminImg.TabStop = false;
            // 
            // LibrarianWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navigationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibrarianWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox adminImg;
        private System.Windows.Forms.Label adminName;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button issueBtn;
        private System.Windows.Forms.Button manageBooksBtn;
        private System.Windows.Forms.Button manageMembersBtn;
        private System.Windows.Forms.Button browseBooksBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}