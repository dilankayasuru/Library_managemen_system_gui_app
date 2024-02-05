namespace LMS.Forms.SearchUI
{
    partial class nullResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nullResult));
            this.headerLbl = new System.Windows.Forms.Label();
            this.bookPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookPic)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(107, 121);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(187, 30);
            this.headerLbl.TabIndex = 3;
            this.headerLbl.Text = "Book Not Found! :(";
            // 
            // bookPic
            // 
            this.bookPic.Image = ((System.Drawing.Image)(resources.GetObject("bookPic.Image")));
            this.bookPic.Location = new System.Drawing.Point(124, 193);
            this.bookPic.Name = "bookPic";
            this.bookPic.Size = new System.Drawing.Size(152, 156);
            this.bookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPic.TabIndex = 2;
            this.bookPic.TabStop = false;
            // 
            // nullResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.bookPic);
            this.Name = "nullResult";
            this.Size = new System.Drawing.Size(400, 470);
            ((System.ComponentModel.ISupportInitialize)(this.bookPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.PictureBox bookPic;
    }
}
