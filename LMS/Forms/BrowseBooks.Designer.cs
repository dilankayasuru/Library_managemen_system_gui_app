namespace LMS.Forms
{
    partial class BrowseBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseBooks));
            this.headerText = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchTxt = new Krypton.Toolkit.KryptonTextBox();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.filterLbl = new System.Windows.Forms.Label();
            this.availbilityFilterComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(18, 16);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(140, 30);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Browse Books";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Title",
            "ISBN"});
            this.filterComboBox.Location = new System.Drawing.Point(269, 58);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(68, 29);
            this.filterComboBox.TabIndex = 3;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.CornerRoundingRadius = 20F;
            this.searchTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.searchTxt.CueHint.CueHintText = "Enter keyword to search";
            this.searchTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchTxt.Location = new System.Drawing.Point(345, 54);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(437, 36);
            this.searchTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.searchTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchTxt.StateCommon.Border.Rounding = 20F;
            this.searchTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchTxt.TabIndex = 1;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.booksDataGridView.Location = new System.Drawing.Point(15, 159);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.RowHeadersWidth = 51;
            this.booksDataGridView.Size = new System.Drawing.Size(1020, 554);
            this.booksDataGridView.TabIndex = 0;
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshbtn.Image")));
            this.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshbtn.Location = new System.Drawing.Point(928, 117);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(104, 36);
            this.refreshbtn.TabIndex = 5;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Location = new System.Drawing.Point(19, 124);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(73, 21);
            this.filterLbl.TabIndex = 6;
            this.filterLbl.Text = "Filter By: ";
            // 
            // availbilityFilterComboBox
            // 
            this.availbilityFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availbilityFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availbilityFilterComboBox.FormattingEnabled = true;
            this.availbilityFilterComboBox.Items.AddRange(new object[] {
            "Show All Books",
            "Show Available Books",
            "Show Unavailable Books"});
            this.availbilityFilterComboBox.Location = new System.Drawing.Point(98, 120);
            this.availbilityFilterComboBox.Name = "availbilityFilterComboBox";
            this.availbilityFilterComboBox.Size = new System.Drawing.Size(186, 28);
            this.availbilityFilterComboBox.TabIndex = 7;
            this.availbilityFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.availbilityFilterComboBox_SelectedIndexChanged);
            // 
            // BrowseBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.availbilityFilterComboBox);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BrowseBooks";
            this.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Size = new System.Drawing.Size(1050, 729);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ComboBox filterComboBox;
        private Krypton.Toolkit.KryptonTextBox searchTxt;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.ComboBox availbilityFilterComboBox;
    }
}
