namespace LMS.Forms
{
    partial class ManageMembers
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
            this.searchTxt = new Krypton.Toolkit.KryptonTextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.headerText = new System.Windows.Forms.Label();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.fnameText = new Krypton.Toolkit.KryptonTextBox();
            this.lnameText = new Krypton.Toolkit.KryptonTextBox();
            this.idText = new Krypton.Toolkit.KryptonTextBox();
            this.saveBtn = new Krypton.Toolkit.KryptonButton();
            this.deleteBtn = new Krypton.Toolkit.KryptonButton();
            this.cancelBtn = new Krypton.Toolkit.KryptonButton();
            this.addNewMemberBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.CornerRoundingRadius = 20F;
            this.searchTxt.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.searchTxt.CueHint.CueHintText = "Find members by...";
            this.searchTxt.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.searchTxt.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchTxt.Location = new System.Drawing.Point(18, 51);
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
            // filterComboBox
            // 
            this.filterComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Member ID"});
            this.filterComboBox.Location = new System.Drawing.Point(471, 55);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(120, 29);
            this.filterComboBox.TabIndex = 2;
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(13, 10);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(182, 30);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Manage Members";
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.membersDataGridView.Location = new System.Drawing.Point(10, 264);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.Size = new System.Drawing.Size(1030, 455);
            this.membersDataGridView.TabIndex = 0;
            // 
            // fnameText
            // 
            this.fnameText.CornerRoundingRadius = 20F;
            this.fnameText.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.fnameText.CueHint.CueHintText = "First Name";
            this.fnameText.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameText.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fnameText.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.fnameText.Cursor = System.Windows.Forms.Cursors.Default;
            this.fnameText.Location = new System.Drawing.Point(101, 136);
            this.fnameText.Name = "fnameText";
            this.fnameText.Size = new System.Drawing.Size(246, 36);
            this.fnameText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.fnameText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fnameText.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.fnameText.StateCommon.Border.Rounding = 20F;
            this.fnameText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameText.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fnameText.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fnameText.TabIndex = 3;
            // 
            // lnameText
            // 
            this.lnameText.CornerRoundingRadius = 20F;
            this.lnameText.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.lnameText.CueHint.CueHintText = "Last Name";
            this.lnameText.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameText.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lnameText.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.lnameText.Cursor = System.Windows.Forms.Cursors.Default;
            this.lnameText.Location = new System.Drawing.Point(402, 136);
            this.lnameText.Name = "lnameText";
            this.lnameText.Size = new System.Drawing.Size(246, 36);
            this.lnameText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lnameText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lnameText.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.lnameText.StateCommon.Border.Rounding = 20F;
            this.lnameText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameText.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lnameText.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lnameText.TabIndex = 4;
            // 
            // idText
            // 
            this.idText.CornerRoundingRadius = 20F;
            this.idText.CueHint.Color1 = System.Drawing.Color.DimGray;
            this.idText.CueHint.CueHintText = "Membership ID";
            this.idText.CueHint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.CueHint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.idText.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.idText.Cursor = System.Windows.Forms.Cursors.Default;
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(703, 136);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(246, 36);
            this.idText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.idText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.idText.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.idText.StateCommon.Border.Rounding = 20F;
            this.idText.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.idText.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.idText.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.CornerRoundingRadius = 20F;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(370, 193);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.saveBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveBtn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.saveBtn.OverrideDefault.Border.Rounding = 20F;
            this.saveBtn.OverrideDefault.Border.Width = 1;
            this.saveBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.saveBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.saveBtn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.saveBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.saveBtn.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.saveBtn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.saveBtn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.saveBtn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveBtn.OverrideFocus.Border.Rounding = 20F;
            this.saveBtn.OverrideFocus.Border.Width = 1;
            this.saveBtn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.saveBtn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.saveBtn.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.saveBtn.Size = new System.Drawing.Size(83, 36);
            this.saveBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveBtn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.saveBtn.StateCommon.Border.Rounding = 20F;
            this.saveBtn.StateCommon.Border.Width = 1;
            this.saveBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.saveBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.saveBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Values.Text = "Save";
            // 
            // deleteBtn
            // 
            this.deleteBtn.CornerRoundingRadius = 20F;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Location = new System.Drawing.Point(484, 193);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteBtn.OverrideDefault.Border.Rounding = 20F;
            this.deleteBtn.OverrideDefault.Border.Width = 1;
            this.deleteBtn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteBtn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.deleteBtn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteBtn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.OverrideFocus.Border.Rounding = 20F;
            this.deleteBtn.OverrideFocus.Border.Width = 1;
            this.deleteBtn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteBtn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.deleteBtn.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.deleteBtn.Size = new System.Drawing.Size(83, 36);
            this.deleteBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteBtn.StateCommon.Border.Rounding = 20F;
            this.deleteBtn.StateCommon.Border.Width = 1;
            this.deleteBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.deleteBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.StateNormal.Border.Rounding = 20F;
            this.deleteBtn.StateNormal.Border.Width = 1;
            this.deleteBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.StatePressed.Border.Rounding = 20F;
            this.deleteBtn.StatePressed.Border.Width = 1;
            this.deleteBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(65)))));
            this.deleteBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteBtn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.deleteBtn.StateTracking.Border.Rounding = 20F;
            this.deleteBtn.StateTracking.Border.Width = 1;
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Values.Text = "Delete";
            // 
            // cancelBtn
            // 
            this.cancelBtn.CornerRoundingRadius = 20F;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(598, 193);
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
            this.cancelBtn.Size = new System.Drawing.Size(83, 36);
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
            // addNewMemberBtn
            // 
            this.addNewMemberBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addNewMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewMemberBtn.FlatAppearance.BorderSize = 0;
            this.addNewMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.addNewMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addNewMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMemberBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addNewMemberBtn.Image = global::LMS.Properties.Resources.addNewMemberIcon;
            this.addNewMemberBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewMemberBtn.Location = new System.Drawing.Point(852, 193);
            this.addNewMemberBtn.Name = "addNewMemberBtn";
            this.addNewMemberBtn.Size = new System.Drawing.Size(185, 36);
            this.addNewMemberBtn.TabIndex = 9;
            this.addNewMemberBtn.Text = "Add New Member";
            this.addNewMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewMemberBtn.UseVisualStyleBackColor = true;
            this.addNewMemberBtn.Click += new System.EventHandler(this.addNewMemberBtn_Click);
            // 
            // ManageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addNewMemberBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.lnameText);
            this.Controls.Add(this.fnameText);
            this.Controls.Add(this.membersDataGridView);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageMembers";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1050, 729);
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox searchTxt;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private Krypton.Toolkit.KryptonTextBox fnameText;
        private Krypton.Toolkit.KryptonTextBox lnameText;
        private Krypton.Toolkit.KryptonTextBox idText;
        private Krypton.Toolkit.KryptonButton saveBtn;
        private Krypton.Toolkit.KryptonButton deleteBtn;
        private Krypton.Toolkit.KryptonButton cancelBtn;
        private System.Windows.Forms.Button addNewMemberBtn;
    }
}
