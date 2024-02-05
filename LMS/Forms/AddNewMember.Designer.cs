namespace LMS.Forms
{
    partial class AddNewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewMember));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.reenterLbl = new System.Windows.Forms.Label();
            this.reEnterPasswordTxt = new Krypton.Toolkit.KryptonTextBox();
            this.passwordTxt = new Krypton.Toolkit.KryptonTextBox();
            this.userNameTxt = new Krypton.Toolkit.KryptonTextBox();
            this.lnameTxt = new Krypton.Toolkit.KryptonTextBox();
            this.memberIDtxt = new Krypton.Toolkit.KryptonTextBox();
            this.fnameTxt = new Krypton.Toolkit.KryptonTextBox();
            this.registerBtn = new Krypton.Toolkit.KryptonButton();
            this.cancelBtn = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.newMemberImg = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newMemberImg)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.reenterLbl);
            this.mainPanel.Controls.Add(this.reEnterPasswordTxt);
            this.mainPanel.Controls.Add(this.passwordTxt);
            this.mainPanel.Controls.Add(this.userNameTxt);
            this.mainPanel.Controls.Add(this.lnameTxt);
            this.mainPanel.Controls.Add(this.memberIDtxt);
            this.mainPanel.Controls.Add(this.fnameTxt);
            this.mainPanel.Controls.Add(this.registerBtn);
            this.mainPanel.Controls.Add(this.cancelBtn);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(273, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanel.Size = new System.Drawing.Size(531, 561);
            this.mainPanel.TabIndex = 1;
            // 
            // reenterLbl
            // 
            this.reenterLbl.AutoSize = true;
            this.reenterLbl.Location = new System.Drawing.Point(49, 356);
            this.reenterLbl.Name = "reenterLbl";
            this.reenterLbl.Size = new System.Drawing.Size(138, 21);
            this.reenterLbl.TabIndex = 0;
            this.reenterLbl.Text = "Re Enter Password";
            // 
            // reEnterPasswordTxt
            // 
            this.reEnterPasswordTxt.CornerRoundingRadius = 20F;
            this.reEnterPasswordTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.reEnterPasswordTxt.CueHint.CueHintText = "Password";
            this.reEnterPasswordTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnterPasswordTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.reEnterPasswordTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.reEnterPasswordTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.reEnterPasswordTxt.Location = new System.Drawing.Point(40, 380);
            this.reEnterPasswordTxt.Name = "reEnterPasswordTxt";
            this.reEnterPasswordTxt.PasswordChar = '*';
            this.reEnterPasswordTxt.Size = new System.Drawing.Size(454, 36);
            this.reEnterPasswordTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.reEnterPasswordTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.reEnterPasswordTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.reEnterPasswordTxt.StateCommon.Border.Rounding = 20F;
            this.reEnterPasswordTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnterPasswordTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.reEnterPasswordTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.reEnterPasswordTxt.TabIndex = 6;
            this.reEnterPasswordTxt.TextChanged += new System.EventHandler(this.reEnterPasswordTxt_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.CornerRoundingRadius = 20F;
            this.passwordTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.passwordTxt.CueHint.CueHintText = "Password";
            this.passwordTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passwordTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwordTxt.Location = new System.Drawing.Point(270, 308);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(224, 36);
            this.passwordTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.passwordTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordTxt.StateCommon.Border.Rounding = 20F;
            this.passwordTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passwordTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // userNameTxt
            // 
            this.userNameTxt.CornerRoundingRadius = 20F;
            this.userNameTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.userNameTxt.CueHint.CueHintText = "User Name";
            this.userNameTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.userNameTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.userNameTxt.Location = new System.Drawing.Point(40, 308);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(224, 36);
            this.userNameTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.userNameTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.userNameTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.userNameTxt.StateCommon.Border.Rounding = 20F;
            this.userNameTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.userNameTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.userNameTxt.TabIndex = 4;
            // 
            // lnameTxt
            // 
            this.lnameTxt.CornerRoundingRadius = 20F;
            this.lnameTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.lnameTxt.CueHint.CueHintText = "Last Name";
            this.lnameTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lnameTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.lnameTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnameTxt.Location = new System.Drawing.Point(270, 243);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(224, 36);
            this.lnameTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lnameTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lnameTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.lnameTxt.StateCommon.Border.Rounding = 20F;
            this.lnameTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lnameTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lnameTxt.TabIndex = 3;
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
            this.memberIDtxt.Location = new System.Drawing.Point(40, 178);
            this.memberIDtxt.Name = "memberIDtxt";
            this.memberIDtxt.Size = new System.Drawing.Size(454, 36);
            this.memberIDtxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.memberIDtxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.memberIDtxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.memberIDtxt.StateCommon.Border.Rounding = 20F;
            this.memberIDtxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDtxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.memberIDtxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.memberIDtxt.TabIndex = 1;
            // 
            // fnameTxt
            // 
            this.fnameTxt.CornerRoundingRadius = 20F;
            this.fnameTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.fnameTxt.CueHint.CueHintText = "First Name";
            this.fnameTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fnameTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.fnameTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.fnameTxt.Location = new System.Drawing.Point(40, 243);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(224, 36);
            this.fnameTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fnameTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fnameTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.fnameTxt.StateCommon.Border.Rounding = 20F;
            this.fnameTxt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fnameTxt.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fnameTxt.TabIndex = 2;
            // 
            // registerBtn
            // 
            this.registerBtn.CornerRoundingRadius = 20F;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.Location = new System.Drawing.Point(158, 438);
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
            this.registerBtn.Values.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.CornerRoundingRadius = 20F;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(270, 438);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Member";
            // 
            // imagePanel
            // 
            this.imagePanel.BackgroundImage = global::LMS.Properties.Resources.loginBackImg;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePanel.Controls.Add(this.newMemberImg);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Padding = new System.Windows.Forms.Padding(10);
            this.imagePanel.Size = new System.Drawing.Size(273, 561);
            this.imagePanel.TabIndex = 0;
            // 
            // newMemberImg
            // 
            this.newMemberImg.BackColor = System.Drawing.Color.Transparent;
            this.newMemberImg.Image = global::LMS.Properties.Resources.addnewMemberImg;
            this.newMemberImg.Location = new System.Drawing.Point(13, 160);
            this.newMemberImg.Name = "newMemberImg";
            this.newMemberImg.Size = new System.Drawing.Size(247, 240);
            this.newMemberImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newMemberImg.TabIndex = 0;
            this.newMemberImg.TabStop = false;
            // 
            // AddNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.imagePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 600);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "AddNewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Members";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newMemberImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox userNameTxt;
        private Krypton.Toolkit.KryptonTextBox lnameTxt;
        private Krypton.Toolkit.KryptonTextBox memberIDtxt;
        private Krypton.Toolkit.KryptonTextBox fnameTxt;
        private Krypton.Toolkit.KryptonButton registerBtn;
        private Krypton.Toolkit.KryptonButton cancelBtn;
        private System.Windows.Forms.PictureBox newMemberImg;
        private Krypton.Toolkit.KryptonTextBox passwordTxt;
        private System.Windows.Forms.Label reenterLbl;
        private Krypton.Toolkit.KryptonTextBox reEnterPasswordTxt;
    }
}