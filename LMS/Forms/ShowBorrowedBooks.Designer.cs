namespace LMS.Forms
{
    partial class ShowBorrowedBooks
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
            this.borrowedBooksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(13, 10);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(162, 30);
            this.headerText.TabIndex = 1;
            this.headerText.Text = "Borrowed Books";
            // 
            // borrowedBooksPanel
            // 
            this.borrowedBooksPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.borrowedBooksPanel.Location = new System.Drawing.Point(45, 80);
            this.borrowedBooksPanel.Name = "borrowedBooksPanel";
            this.borrowedBooksPanel.Size = new System.Drawing.Size(960, 610);
            this.borrowedBooksPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(907, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borrowedBooksPanel);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowBorrowedBooks";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1050, 729);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.FlowLayoutPanel borrowedBooksPanel;
        private System.Windows.Forms.Button button1;
    }
}
