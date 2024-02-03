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
            this.headerText = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new Krypton.Toolkit.KryptonButton();
            this.searchTxt = new Krypton.Toolkit.KryptonTextBox();
            this.availableBooksCheckBox = new System.Windows.Forms.CheckBox();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
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
            this.filterComboBox.Location = new System.Drawing.Point(224, 58);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(68, 29);
            this.filterComboBox.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.CornerRoundingRadius = 20F;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Location = new System.Drawing.Point(743, 54);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchBtn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchBtn.OverrideDefault.Border.Rounding = 20F;
            this.searchBtn.OverrideDefault.Border.Width = 1;
            this.searchBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.searchBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.searchBtn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.searchBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.searchBtn.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchBtn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.searchBtn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.searchBtn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchBtn.OverrideFocus.Border.Rounding = 20F;
            this.searchBtn.OverrideFocus.Border.Width = 1;
            this.searchBtn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.searchBtn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.searchBtn.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.searchBtn.Size = new System.Drawing.Size(83, 36);
            this.searchBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchBtn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.searchBtn.StateCommon.Border.Rounding = 20F;
            this.searchBtn.StateCommon.Border.Width = 1;
            this.searchBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.searchBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.searchBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Values.Text = "Search";
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
            this.searchTxt.Location = new System.Drawing.Point(300, 54);
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
            // 
            // availableBooksCheckBox
            // 
            this.availableBooksCheckBox.AutoSize = true;
            this.availableBooksCheckBox.Location = new System.Drawing.Point(435, 100);
            this.availableBooksCheckBox.Name = "availableBooksCheckBox";
            this.availableBooksCheckBox.Size = new System.Drawing.Size(181, 25);
            this.availableBooksCheckBox.TabIndex = 4;
            this.availableBooksCheckBox.Text = "Show Available Books";
            this.availableBooksCheckBox.UseVisualStyleBackColor = true;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.booksDataGridView.Location = new System.Drawing.Point(15, 159);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(1020, 554);
            this.booksDataGridView.TabIndex = 0;
            // 
            // BrowseBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.availableBooksCheckBox);
            this.Controls.Add(this.searchBtn);
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
        private Krypton.Toolkit.KryptonButton searchBtn;
        private Krypton.Toolkit.KryptonTextBox searchTxt;
        private System.Windows.Forms.CheckBox availableBooksCheckBox;
        private System.Windows.Forms.DataGridView booksDataGridView;
    }
}
