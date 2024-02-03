namespace LMS.Forms
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.memberIDtxt = new Krypton.Toolkit.KryptonTextBox();
            this.ISBNTxt = new Krypton.Toolkit.KryptonTextBox();
            this.issueBtn = new Krypton.Toolkit.KryptonButton();
            this.headerText = new System.Windows.Forms.Label();
            this.cancelBtn = new Krypton.Toolkit.KryptonButton();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.publishedYearLbl = new System.Windows.Forms.Label();
            this.publishedYearDetailTxt = new System.Windows.Forms.TextBox();
            this.authorLbl = new System.Windows.Forms.Label();
            this.authorDetailTxt = new System.Windows.Forms.TextBox();
            this.bookDetailsLbl = new System.Windows.Forms.Label();
            this.isbnLbl = new System.Windows.Forms.Label();
            this.isbnDetailTxt = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.titleDetailTxt = new System.Windows.Forms.TextBox();
            this.memberDetailsLbl = new System.Windows.Forms.Label();
            this.memberIDLbl = new System.Windows.Forms.Label();
            this.idDetailTxt = new System.Windows.Forms.TextBox();
            this.nameDetailTxt = new System.Windows.Forms.TextBox();
            this.memberNameLbl = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.memberIDtxt);
            this.mainPanel.Controls.Add(this.ISBNTxt);
            this.mainPanel.Controls.Add(this.issueBtn);
            this.mainPanel.Controls.Add(this.headerText);
            this.mainPanel.Controls.Add(this.cancelBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanel.Size = new System.Drawing.Size(419, 561);
            this.mainPanel.TabIndex = 1;
            // 
            // memberIDtxt
            // 
            this.memberIDtxt.CornerRoundingRadius = 20F;
            this.memberIDtxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.memberIDtxt.CueHint.CueHintText = "Membership ID";
            this.memberIDtxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDtxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.memberIDtxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.memberIDtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.memberIDtxt.Location = new System.Drawing.Point(86, 262);
            this.memberIDtxt.Name = "memberIDtxt";
            this.memberIDtxt.Size = new System.Drawing.Size(246, 36);
            this.memberIDtxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.memberIDtxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.memberIDtxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberIDtxt.StateCommon.Border.Rounding = 20F;
            this.memberIDtxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDtxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.memberIDtxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.memberIDtxt.TabIndex = 2;
            // 
            // ISBNTxt
            // 
            this.ISBNTxt.CornerRoundingRadius = 20F;
            this.ISBNTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.ISBNTxt.CueHint.CueHintText = "ISBN";
            this.ISBNTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ISBNTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.ISBNTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.ISBNTxt.Location = new System.Drawing.Point(86, 186);
            this.ISBNTxt.Name = "ISBNTxt";
            this.ISBNTxt.Size = new System.Drawing.Size(246, 36);
            this.ISBNTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ISBNTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ISBNTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ISBNTxt.StateCommon.Border.Rounding = 20F;
            this.ISBNTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ISBNTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ISBNTxt.TabIndex = 1;
            // 
            // issueBtn
            // 
            this.issueBtn.CornerRoundingRadius = 20F;
            this.issueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBtn.Location = new System.Drawing.Point(86, 338);
            this.issueBtn.Name = "issueBtn";
            this.issueBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.issueBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.issueBtn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.issueBtn.OverrideDefault.Border.Rounding = 20F;
            this.issueBtn.OverrideDefault.Border.Width = 1;
            this.issueBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.issueBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.issueBtn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.issueBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.issueBtn.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.issueBtn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.issueBtn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.issueBtn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.issueBtn.OverrideFocus.Border.Rounding = 20F;
            this.issueBtn.OverrideFocus.Border.Width = 1;
            this.issueBtn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.issueBtn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.issueBtn.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBtn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.issueBtn.Size = new System.Drawing.Size(106, 36);
            this.issueBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.issueBtn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.issueBtn.StateCommon.Border.Rounding = 20F;
            this.issueBtn.StateCommon.Border.Width = 1;
            this.issueBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.issueBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.issueBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.issueBtn.TabIndex = 3;
            this.issueBtn.Values.Text = "Issue";
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(149, 77);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(121, 30);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Issue Books";
            // 
            // cancelBtn
            // 
            this.cancelBtn.CornerRoundingRadius = 20F;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(226, 338);
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
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Values.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackgroundImage = global::LMS.Properties.Resources.issueBookImg;
            this.detailsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.detailsPanel.Controls.Add(this.publishedYearLbl);
            this.detailsPanel.Controls.Add(this.publishedYearDetailTxt);
            this.detailsPanel.Controls.Add(this.authorLbl);
            this.detailsPanel.Controls.Add(this.authorDetailTxt);
            this.detailsPanel.Controls.Add(this.bookDetailsLbl);
            this.detailsPanel.Controls.Add(this.isbnLbl);
            this.detailsPanel.Controls.Add(this.isbnDetailTxt);
            this.detailsPanel.Controls.Add(this.titleLbl);
            this.detailsPanel.Controls.Add(this.titleDetailTxt);
            this.detailsPanel.Controls.Add(this.memberDetailsLbl);
            this.detailsPanel.Controls.Add(this.memberIDLbl);
            this.detailsPanel.Controls.Add(this.idDetailTxt);
            this.detailsPanel.Controls.Add(this.nameDetailTxt);
            this.detailsPanel.Controls.Add(this.memberNameLbl);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(419, 0);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(385, 561);
            this.detailsPanel.TabIndex = 19;
            // 
            // publishedYearLbl
            // 
            this.publishedYearLbl.AutoSize = true;
            this.publishedYearLbl.BackColor = System.Drawing.Color.Transparent;
            this.publishedYearLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishedYearLbl.Location = new System.Drawing.Point(48, 438);
            this.publishedYearLbl.Name = "publishedYearLbl";
            this.publishedYearLbl.Size = new System.Drawing.Size(93, 17);
            this.publishedYearLbl.TabIndex = 0;
            this.publishedYearLbl.Text = "Published Year";
            // 
            // publishedYearDetailTxt
            // 
            this.publishedYearDetailTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishedYearDetailTxt.Location = new System.Drawing.Point(51, 458);
            this.publishedYearDetailTxt.Name = "publishedYearDetailTxt";
            this.publishedYearDetailTxt.ReadOnly = true;
            this.publishedYearDetailTxt.Size = new System.Drawing.Size(286, 25);
            this.publishedYearDetailTxt.TabIndex = 0;
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.BackColor = System.Drawing.Color.Transparent;
            this.authorLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLbl.Location = new System.Drawing.Point(48, 387);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(47, 17);
            this.authorLbl.TabIndex = 0;
            this.authorLbl.Text = "Author";
            // 
            // authorDetailTxt
            // 
            this.authorDetailTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorDetailTxt.Location = new System.Drawing.Point(51, 407);
            this.authorDetailTxt.Name = "authorDetailTxt";
            this.authorDetailTxt.ReadOnly = true;
            this.authorDetailTxt.Size = new System.Drawing.Size(286, 25);
            this.authorDetailTxt.TabIndex = 0;
            // 
            // bookDetailsLbl
            // 
            this.bookDetailsLbl.AutoSize = true;
            this.bookDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.bookDetailsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDetailsLbl.Location = new System.Drawing.Point(132, 256);
            this.bookDetailsLbl.Name = "bookDetailsLbl";
            this.bookDetailsLbl.Size = new System.Drawing.Size(96, 21);
            this.bookDetailsLbl.TabIndex = 0;
            this.bookDetailsLbl.Text = "Book Details";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.BackColor = System.Drawing.Color.Transparent;
            this.isbnLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLbl.Location = new System.Drawing.Point(48, 338);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(35, 17);
            this.isbnLbl.TabIndex = 0;
            this.isbnLbl.Text = "ISBN";
            // 
            // isbnDetailTxt
            // 
            this.isbnDetailTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnDetailTxt.Location = new System.Drawing.Point(51, 356);
            this.isbnDetailTxt.Name = "isbnDetailTxt";
            this.isbnDetailTxt.ReadOnly = true;
            this.isbnDetailTxt.Size = new System.Drawing.Size(286, 25);
            this.isbnDetailTxt.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(48, 285);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(32, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title";
            // 
            // titleDetailTxt
            // 
            this.titleDetailTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDetailTxt.Location = new System.Drawing.Point(51, 305);
            this.titleDetailTxt.Name = "titleDetailTxt";
            this.titleDetailTxt.ReadOnly = true;
            this.titleDetailTxt.Size = new System.Drawing.Size(286, 25);
            this.titleDetailTxt.TabIndex = 0;
            // 
            // memberDetailsLbl
            // 
            this.memberDetailsLbl.AutoSize = true;
            this.memberDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.memberDetailsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDetailsLbl.Location = new System.Drawing.Point(132, 76);
            this.memberDetailsLbl.Name = "memberDetailsLbl";
            this.memberDetailsLbl.Size = new System.Drawing.Size(120, 21);
            this.memberDetailsLbl.TabIndex = 0;
            this.memberDetailsLbl.Text = "Member Details";
            // 
            // memberIDLbl
            // 
            this.memberIDLbl.AutoSize = true;
            this.memberIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.memberIDLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDLbl.Location = new System.Drawing.Point(48, 166);
            this.memberIDLbl.Name = "memberIDLbl";
            this.memberIDLbl.Size = new System.Drawing.Size(74, 17);
            this.memberIDLbl.TabIndex = 0;
            this.memberIDLbl.Text = "Member ID";
            // 
            // idDetailTxt
            // 
            this.idDetailTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDetailTxt.Location = new System.Drawing.Point(51, 186);
            this.idDetailTxt.Name = "idDetailTxt";
            this.idDetailTxt.ReadOnly = true;
            this.idDetailTxt.Size = new System.Drawing.Size(286, 25);
            this.idDetailTxt.TabIndex = 0;
            // 
            // nameDetailTxt
            // 
            this.nameDetailTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDetailTxt.Location = new System.Drawing.Point(51, 134);
            this.nameDetailTxt.Name = "nameDetailTxt";
            this.nameDetailTxt.ReadOnly = true;
            this.nameDetailTxt.Size = new System.Drawing.Size(286, 25);
            this.nameDetailTxt.TabIndex = 0;
            // 
            // memberNameLbl
            // 
            this.memberNameLbl.AutoSize = true;
            this.memberNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.memberNameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLbl.Location = new System.Drawing.Point(48, 114);
            this.memberNameLbl.Name = "memberNameLbl";
            this.memberNameLbl.Size = new System.Drawing.Size(43, 17);
            this.memberNameLbl.TabIndex = 0;
            this.memberNameLbl.Text = "Name";
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 600);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue Books";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label headerText;
        private Krypton.Toolkit.KryptonButton issueBtn;
        private Krypton.Toolkit.KryptonButton cancelBtn;
        private Krypton.Toolkit.KryptonTextBox memberIDtxt;
        private Krypton.Toolkit.KryptonTextBox ISBNTxt;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label publishedYearLbl;
        private System.Windows.Forms.TextBox publishedYearDetailTxt;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox authorDetailTxt;
        private System.Windows.Forms.Label bookDetailsLbl;
        private System.Windows.Forms.Label isbnLbl;
        private System.Windows.Forms.TextBox isbnDetailTxt;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox titleDetailTxt;
        private System.Windows.Forms.Label memberDetailsLbl;
        private System.Windows.Forms.Label memberIDLbl;
        private System.Windows.Forms.TextBox idDetailTxt;
        private System.Windows.Forms.TextBox nameDetailTxt;
        private System.Windows.Forms.Label memberNameLbl;
    }
}