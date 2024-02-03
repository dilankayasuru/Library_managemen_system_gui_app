namespace LMS.Forms
{
    partial class AddNewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewBook));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bookIdTxt = new Krypton.Toolkit.KryptonTextBox();
            this.copiesTxt = new Krypton.Toolkit.KryptonTextBox();
            this.publishedYearTxt = new Krypton.Toolkit.KryptonTextBox();
            this.authorTxt = new Krypton.Toolkit.KryptonTextBox();
            this.isbnTxt = new Krypton.Toolkit.KryptonTextBox();
            this.titleTxt = new Krypton.Toolkit.KryptonTextBox();
            this.registerBtn = new Krypton.Toolkit.KryptonButton();
            this.cancelBtn = new Krypton.Toolkit.KryptonButton();
            this.addNewBookLbl = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.newBookImg = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newBookImg)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.bookIdTxt);
            this.mainPanel.Controls.Add(this.copiesTxt);
            this.mainPanel.Controls.Add(this.publishedYearTxt);
            this.mainPanel.Controls.Add(this.authorTxt);
            this.mainPanel.Controls.Add(this.isbnTxt);
            this.mainPanel.Controls.Add(this.titleTxt);
            this.mainPanel.Controls.Add(this.registerBtn);
            this.mainPanel.Controls.Add(this.cancelBtn);
            this.mainPanel.Controls.Add(this.addNewBookLbl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(273, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanel.Size = new System.Drawing.Size(531, 561);
            this.mainPanel.TabIndex = 4;
            // 
            // bookIdTxt
            // 
            this.bookIdTxt.CornerRoundingRadius = 20F;
            this.bookIdTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.bookIdTxt.CueHint.CueHintText = "Book ID";
            this.bookIdTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bookIdTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.bookIdTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.bookIdTxt.Location = new System.Drawing.Point(38, 178);
            this.bookIdTxt.Name = "bookIdTxt";
            this.bookIdTxt.Size = new System.Drawing.Size(224, 36);
            this.bookIdTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.bookIdTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookIdTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bookIdTxt.StateCommon.Border.Rounding = 20F;
            this.bookIdTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bookIdTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bookIdTxt.TabIndex = 1;
            // 
            // copiesTxt
            // 
            this.copiesTxt.CornerRoundingRadius = 20F;
            this.copiesTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.copiesTxt.CueHint.CueHintText = "Number of Copies";
            this.copiesTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiesTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.copiesTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.copiesTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.copiesTxt.Location = new System.Drawing.Point(268, 373);
            this.copiesTxt.Name = "copiesTxt";
            this.copiesTxt.Size = new System.Drawing.Size(224, 36);
            this.copiesTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.copiesTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.copiesTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.copiesTxt.StateCommon.Border.Rounding = 20F;
            this.copiesTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiesTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.copiesTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.copiesTxt.TabIndex = 6;
            // 
            // publishedYearTxt
            // 
            this.publishedYearTxt.CornerRoundingRadius = 20F;
            this.publishedYearTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.publishedYearTxt.CueHint.CueHintText = "Published Year";
            this.publishedYearTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishedYearTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.publishedYearTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.publishedYearTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.publishedYearTxt.Location = new System.Drawing.Point(38, 373);
            this.publishedYearTxt.Name = "publishedYearTxt";
            this.publishedYearTxt.Size = new System.Drawing.Size(224, 36);
            this.publishedYearTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.publishedYearTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.publishedYearTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.publishedYearTxt.StateCommon.Border.Rounding = 20F;
            this.publishedYearTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishedYearTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.publishedYearTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.publishedYearTxt.TabIndex = 5;
            // 
            // authorTxt
            // 
            this.authorTxt.CornerRoundingRadius = 20F;
            this.authorTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.authorTxt.CueHint.CueHintText = "Author";
            this.authorTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.authorTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.authorTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.authorTxt.Location = new System.Drawing.Point(268, 178);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(224, 36);
            this.authorTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.authorTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.authorTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.authorTxt.StateCommon.Border.Rounding = 20F;
            this.authorTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.authorTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.authorTxt.TabIndex = 2;
            // 
            // isbnTxt
            // 
            this.isbnTxt.CornerRoundingRadius = 20F;
            this.isbnTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.isbnTxt.CueHint.CueHintText = "ISBN";
            this.isbnTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.isbnTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.isbnTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.isbnTxt.Location = new System.Drawing.Point(38, 308);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(454, 36);
            this.isbnTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.isbnTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.isbnTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.isbnTxt.StateCommon.Border.Rounding = 20F;
            this.isbnTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.isbnTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.isbnTxt.TabIndex = 4;
            // 
            // titleTxt
            // 
            this.titleTxt.CornerRoundingRadius = 20F;
            this.titleTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.titleTxt.CueHint.CueHintText = "Book Title";
            this.titleTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.titleTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleTxt.Location = new System.Drawing.Point(38, 243);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(454, 36);
            this.titleTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.titleTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.titleTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.titleTxt.StateCommon.Border.Rounding = 20F;
            this.titleTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleTxt.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.CornerRoundingRadius = 20F;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.Location = new System.Drawing.Point(156, 438);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.registerBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.registerBtn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.registerBtn.OverrideDefault.Border.Rounding = 20F;
            this.registerBtn.OverrideDefault.Border.Width = 1;
            this.registerBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.registerBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.registerBtn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.registerBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.registerBtn.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.registerBtn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.registerBtn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.registerBtn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.registerBtn.OverrideFocus.Border.Rounding = 20F;
            this.registerBtn.OverrideFocus.Border.Width = 1;
            this.registerBtn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.registerBtn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.registerBtn.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.registerBtn.Size = new System.Drawing.Size(106, 36);
            this.registerBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.registerBtn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.registerBtn.StateCommon.Border.Rounding = 20F;
            this.registerBtn.StateCommon.Border.Width = 1;
            this.registerBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.registerBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.registerBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Values.Text = "Add Book";
            // 
            // cancelBtn
            // 
            this.cancelBtn.CornerRoundingRadius = 20F;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(268, 438);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cancelBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cancelBtn.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBtn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBtn.OverrideDefault.Border.Rounding = 20F;
            this.cancelBtn.OverrideDefault.Border.Width = 1;
            this.cancelBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cancelBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cancelBtn.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBtn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.cancelBtn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.cancelBtn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBtn.OverrideFocus.Border.Rounding = 20F;
            this.cancelBtn.OverrideFocus.Border.Width = 1;
            this.cancelBtn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cancelBtn.Size = new System.Drawing.Size(106, 36);
            this.cancelBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cancelBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.cancelBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBtn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBtn.StateCommon.Border.Rounding = 20F;
            this.cancelBtn.StateCommon.Border.Width = 1;
            this.cancelBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cancelBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cancelBtn.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.cancelBtn.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBtn.StateNormal.Border.Rounding = 20F;
            this.cancelBtn.StateNormal.Border.Width = 1;
            this.cancelBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cancelBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cancelBtn.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Values.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addNewBookLbl
            // 
            this.addNewBookLbl.AutoSize = true;
            this.addNewBookLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBookLbl.Location = new System.Drawing.Point(174, 86);
            this.addNewBookLbl.Name = "addNewBookLbl";
            this.addNewBookLbl.Size = new System.Drawing.Size(151, 30);
            this.addNewBookLbl.TabIndex = 0;
            this.addNewBookLbl.Text = "Add New Book";
            // 
            // imagePanel
            // 
            this.imagePanel.BackgroundImage = global::LMS.Properties.Resources.loginBackImg;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePanel.Controls.Add(this.newBookImg);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Padding = new System.Windows.Forms.Padding(10);
            this.imagePanel.Size = new System.Drawing.Size(273, 561);
            this.imagePanel.TabIndex = 3;
            // 
            // newBookImg
            // 
            this.newBookImg.BackColor = System.Drawing.Color.Transparent;
            this.newBookImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newBookImg.Image = global::LMS.Properties.Resources.addnewBookImg;
            this.newBookImg.Location = new System.Drawing.Point(10, 10);
            this.newBookImg.Name = "newBookImg";
            this.newBookImg.Size = new System.Drawing.Size(253, 541);
            this.newBookImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newBookImg.TabIndex = 0;
            this.newBookImg.TabStop = false;
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.imagePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 600);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "AddNewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Books";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newBookImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox newBookImg;
        private System.Windows.Forms.Panel mainPanel;
        private Krypton.Toolkit.KryptonTextBox bookIdTxt;
        private Krypton.Toolkit.KryptonTextBox copiesTxt;
        private Krypton.Toolkit.KryptonTextBox publishedYearTxt;
        private Krypton.Toolkit.KryptonTextBox authorTxt;
        private Krypton.Toolkit.KryptonTextBox isbnTxt;
        private Krypton.Toolkit.KryptonTextBox titleTxt;
        private Krypton.Toolkit.KryptonButton registerBtn;
        private Krypton.Toolkit.KryptonButton cancelBtn;
        private System.Windows.Forms.Label addNewBookLbl;
    }
}