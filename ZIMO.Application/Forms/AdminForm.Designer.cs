namespace ZIMO.App.Forms
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.pnlMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ctrlSettings = new ZIMO.App.Forms.General_Controls.SettingsControl();
            this.ctrlReports = new ZIMO.App.Forms.General_Controls.ReportsControl();
            this.ctrlItems = new ZIMO.App.Forms.Sales_Controls.ItemControl();
            this.ctrlGarbages = new ZIMO.App.Forms.Sales_Controls.GarbageControl();
            this.ctrlStocks = new ZIMO.App.Forms.Sales_Controls.StockControl();
            this.ctrlDepartments = new ZIMO.App.Forms.Admin_Controls.DepartmentControl();
            this.ctrlEmployees = new ZIMO.App.Forms.Admin_Controls.EmployeeControl();
            this.pnlLeftMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMenuDepartmentInfo = new System.Windows.Forms.Label();
            this.lblMenuAvatarName = new System.Windows.Forms.Label();
            this.btnMenuLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sprMenuHorizontal = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnMenuReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuManageGarbageItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuStockItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuManageItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuManageDepartments = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuManageEmployees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pboxAvatar = new System.Windows.Forms.PictureBox();
            this.pboxZimoMinimalist = new System.Windows.Forms.PictureBox();
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseAvatar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragControlForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animSlider = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lblMenuRoleInfo = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxZimoMinimalist)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.ctrlSettings);
            this.pnlMain.Controls.Add(this.ctrlReports);
            this.pnlMain.Controls.Add(this.ctrlItems);
            this.pnlMain.Controls.Add(this.ctrlGarbages);
            this.pnlMain.Controls.Add(this.ctrlStocks);
            this.pnlMain.Controls.Add(this.ctrlDepartments);
            this.pnlMain.Controls.Add(this.ctrlEmployees);
            this.pnlMain.Controls.Add(this.pnlLeftMenu);
            this.pnlMain.Controls.Add(this.pboxZimoMinimalist);
            this.animSlider.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlMain.GradientBottomRight = System.Drawing.Color.White;
            this.pnlMain.GradientTopLeft = System.Drawing.Color.White;
            this.pnlMain.GradientTopRight = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Quality = 10;
            this.pnlMain.Size = new System.Drawing.Size(1024, 645);
            this.pnlMain.TabIndex = 0;
            // 
            // ctrlSettings
            // 
            this.ctrlSettings.BackColor = System.Drawing.Color.White;
            this.animSlider.SetDecoration(this.ctrlSettings, BunifuAnimatorNS.DecorationType.None);
            this.ctrlSettings.Location = new System.Drawing.Point(250, 0);
            this.ctrlSettings.Name = "ctrlSettings";
            this.ctrlSettings.Size = new System.Drawing.Size(774, 645);
            this.ctrlSettings.TabIndex = 8;
            this.ctrlSettings.Visible = false;
            // 
            // ctrlReports
            // 
            this.animSlider.SetDecoration(this.ctrlReports, BunifuAnimatorNS.DecorationType.None);
            this.ctrlReports.Location = new System.Drawing.Point(250, 0);
            this.ctrlReports.Name = "ctrlReports";
            this.ctrlReports.Size = new System.Drawing.Size(773, 645);
            this.ctrlReports.TabIndex = 7;
            this.ctrlReports.Visible = false;
            // 
            // ctrlItems
            // 
            this.animSlider.SetDecoration(this.ctrlItems, BunifuAnimatorNS.DecorationType.None);
            this.ctrlItems.Location = new System.Drawing.Point(250, 0);
            this.ctrlItems.Name = "ctrlItems";
            this.ctrlItems.Size = new System.Drawing.Size(774, 645);
            this.ctrlItems.TabIndex = 6;
            this.ctrlItems.Visible = false;
            // 
            // ctrlGarbages
            // 
            this.animSlider.SetDecoration(this.ctrlGarbages, BunifuAnimatorNS.DecorationType.None);
            this.ctrlGarbages.Location = new System.Drawing.Point(250, 0);
            this.ctrlGarbages.Name = "ctrlGarbages";
            this.ctrlGarbages.Size = new System.Drawing.Size(773, 645);
            this.ctrlGarbages.TabIndex = 5;
            this.ctrlGarbages.Visible = false;
            // 
            // ctrlStocks
            // 
            this.animSlider.SetDecoration(this.ctrlStocks, BunifuAnimatorNS.DecorationType.None);
            this.ctrlStocks.Location = new System.Drawing.Point(250, 0);
            this.ctrlStocks.Name = "ctrlStocks";
            this.ctrlStocks.Size = new System.Drawing.Size(774, 645);
            this.ctrlStocks.TabIndex = 4;
            this.ctrlStocks.Visible = false;
            // 
            // ctrlDepartments
            // 
            this.animSlider.SetDecoration(this.ctrlDepartments, BunifuAnimatorNS.DecorationType.None);
            this.ctrlDepartments.Location = new System.Drawing.Point(250, 0);
            this.ctrlDepartments.Name = "ctrlDepartments";
            this.ctrlDepartments.Size = new System.Drawing.Size(774, 645);
            this.ctrlDepartments.TabIndex = 3;
            this.ctrlDepartments.Visible = false;
            // 
            // ctrlEmployees
            // 
            this.animSlider.SetDecoration(this.ctrlEmployees, BunifuAnimatorNS.DecorationType.None);
            this.ctrlEmployees.Location = new System.Drawing.Point(250, 0);
            this.ctrlEmployees.Name = "ctrlEmployees";
            this.ctrlEmployees.Size = new System.Drawing.Size(774, 645);
            this.ctrlEmployees.TabIndex = 2;
            this.ctrlEmployees.Visible = false;
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeftMenu.BackgroundImage")));
            this.pnlLeftMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeftMenu.Controls.Add(this.lblMenuRoleInfo);
            this.pnlLeftMenu.Controls.Add(this.lblMenuDepartmentInfo);
            this.pnlLeftMenu.Controls.Add(this.lblMenuAvatarName);
            this.pnlLeftMenu.Controls.Add(this.btnMenuLogOut);
            this.pnlLeftMenu.Controls.Add(this.btnMenuSettings);
            this.pnlLeftMenu.Controls.Add(this.sprMenuHorizontal);
            this.pnlLeftMenu.Controls.Add(this.btnMenuReports);
            this.pnlLeftMenu.Controls.Add(this.btnMenuManageGarbageItems);
            this.pnlLeftMenu.Controls.Add(this.btnMenuStockItems);
            this.pnlLeftMenu.Controls.Add(this.btnMenuManageItems);
            this.pnlLeftMenu.Controls.Add(this.btnMenuManageDepartments);
            this.pnlLeftMenu.Controls.Add(this.btnMenuManageEmployees);
            this.pnlLeftMenu.Controls.Add(this.pboxAvatar);
            this.animSlider.SetDecoration(this.pnlLeftMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlLeftMenu.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlLeftMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLeftMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLeftMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Quality = 10;
            this.pnlLeftMenu.Size = new System.Drawing.Size(250, 645);
            this.pnlLeftMenu.TabIndex = 1;
            // 
            // lblMenuDepartmentInfo
            // 
            this.lblMenuDepartmentInfo.AutoSize = true;
            this.lblMenuDepartmentInfo.BackColor = System.Drawing.Color.Transparent;
            this.animSlider.SetDecoration(this.lblMenuDepartmentInfo, BunifuAnimatorNS.DecorationType.None);
            this.lblMenuDepartmentInfo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuDepartmentInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblMenuDepartmentInfo.Location = new System.Drawing.Point(48, 127);
            this.lblMenuDepartmentInfo.Name = "lblMenuDepartmentInfo";
            this.lblMenuDepartmentInfo.Size = new System.Drawing.Size(155, 18);
            this.lblMenuDepartmentInfo.TabIndex = 17;
            this.lblMenuDepartmentInfo.Text = "Sales, System Admin";
            // 
            // lblMenuAvatarName
            // 
            this.lblMenuAvatarName.AutoSize = true;
            this.lblMenuAvatarName.BackColor = System.Drawing.Color.Transparent;
            this.animSlider.SetDecoration(this.lblMenuAvatarName, BunifuAnimatorNS.DecorationType.None);
            this.lblMenuAvatarName.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuAvatarName.Location = new System.Drawing.Point(80, 109);
            this.lblMenuAvatarName.Name = "lblMenuAvatarName";
            this.lblMenuAvatarName.Size = new System.Drawing.Size(82, 18);
            this.lblMenuAvatarName.TabIndex = 16;
            this.lblMenuAvatarName.Text = "John Doe";
            // 
            // btnMenuLogOut
            // 
            this.btnMenuLogOut.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuLogOut.BorderRadius = 0;
            this.btnMenuLogOut.ButtonText = "Log Out";
            this.btnMenuLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animSlider.SetDecoration(this.btnMenuLogOut, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuLogOut.Iconimage")));
            this.btnMenuLogOut.Iconimage_right = null;
            this.btnMenuLogOut.Iconimage_right_Selected = null;
            this.btnMenuLogOut.Iconimage_Selected = null;
            this.btnMenuLogOut.IconMarginLeft = 0;
            this.btnMenuLogOut.IconMarginRight = 0;
            this.btnMenuLogOut.IconRightVisible = true;
            this.btnMenuLogOut.IconRightZoom = 0D;
            this.btnMenuLogOut.IconVisible = true;
            this.btnMenuLogOut.IconZoom = 60D;
            this.btnMenuLogOut.IsTab = false;
            this.btnMenuLogOut.Location = new System.Drawing.Point(0, 527);
            this.btnMenuLogOut.Name = "btnMenuLogOut";
            this.btnMenuLogOut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnMenuLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuLogOut.selected = false;
            this.btnMenuLogOut.Size = new System.Drawing.Size(250, 48);
            this.btnMenuLogOut.TabIndex = 15;
            this.btnMenuLogOut.Text = "Log Out";
            this.btnMenuLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuLogOut.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btnMenuLogOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuLogOut.Click += new System.EventHandler(this.btnMenuLogOut_Click);
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuSettings.BorderRadius = 0;
            this.btnMenuSettings.ButtonText = "Settings";
            this.btnMenuSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animSlider.SetDecoration(this.btnMenuSettings, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuSettings.Iconimage")));
            this.btnMenuSettings.Iconimage_right = null;
            this.btnMenuSettings.Iconimage_right_Selected = null;
            this.btnMenuSettings.Iconimage_Selected = null;
            this.btnMenuSettings.IconMarginLeft = 0;
            this.btnMenuSettings.IconMarginRight = 0;
            this.btnMenuSettings.IconRightVisible = true;
            this.btnMenuSettings.IconRightZoom = 0D;
            this.btnMenuSettings.IconVisible = true;
            this.btnMenuSettings.IconZoom = 60D;
            this.btnMenuSettings.IsTab = false;
            this.btnMenuSettings.Location = new System.Drawing.Point(0, 479);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnMenuSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuSettings.selected = false;
            this.btnMenuSettings.Size = new System.Drawing.Size(250, 48);
            this.btnMenuSettings.TabIndex = 14;
            this.btnMenuSettings.Text = "Settings";
            this.btnMenuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSettings.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btnMenuSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSettings.Click += new System.EventHandler(this.btnMenuSettings_Click);
            // 
            // sprMenuHorizontal
            // 
            this.sprMenuHorizontal.BackColor = System.Drawing.Color.Transparent;
            this.animSlider.SetDecoration(this.sprMenuHorizontal, BunifuAnimatorNS.DecorationType.None);
            this.sprMenuHorizontal.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.sprMenuHorizontal.LineThickness = 2;
            this.sprMenuHorizontal.Location = new System.Drawing.Point(0, 154);
            this.sprMenuHorizontal.Name = "sprMenuHorizontal";
            this.sprMenuHorizontal.Size = new System.Drawing.Size(250, 35);
            this.sprMenuHorizontal.TabIndex = 12;
            this.sprMenuHorizontal.Transparency = 255;
            this.sprMenuHorizontal.Vertical = false;
            // 
            // btnMenuReports
            // 
            this.btnMenuReports.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuReports.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuReports.BorderRadius = 0;
            this.btnMenuReports.ButtonText = "Reports";
            this.btnMenuReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animSlider.SetDecoration(this.btnMenuReports, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuReports.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuReports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuReports.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuReports.Iconimage")));
            this.btnMenuReports.Iconimage_right = null;
            this.btnMenuReports.Iconimage_right_Selected = null;
            this.btnMenuReports.Iconimage_Selected = null;
            this.btnMenuReports.IconMarginLeft = 0;
            this.btnMenuReports.IconMarginRight = 0;
            this.btnMenuReports.IconRightVisible = true;
            this.btnMenuReports.IconRightZoom = 0D;
            this.btnMenuReports.IconVisible = true;
            this.btnMenuReports.IconZoom = 60D;
            this.btnMenuReports.IsTab = false;
            this.btnMenuReports.Location = new System.Drawing.Point(0, 431);
            this.btnMenuReports.Name = "btnMenuReports";
            this.btnMenuReports.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuReports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnMenuReports.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuReports.selected = false;
            this.btnMenuReports.Size = new System.Drawing.Size(250, 48);
            this.btnMenuReports.TabIndex = 10;
            this.btnMenuReports.Text = "Reports";
            this.btnMenuReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReports.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btnMenuReports.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReports.Click += new System.EventHandler(this.btnMenuReports_Click);
            // 
            // btnMenuManageGarbageItems
            // 
            this.btnMenuManageGarbageItems.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuManageGarbageItems.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuManageGarbageItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuManageGarbageItems.BorderRadius = 0;
            this.btnMenuManageGarbageItems.ButtonText = "Manage Garbage Items";
            this.btnMenuManageGarbageItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animSlider.SetDecoration(this.btnMenuManageGarbageItems, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuManageGarbageItems.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuManageGarbageItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuManageGarbageItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuManageGarbageItems.Iconimage")));
            this.btnMenuManageGarbageItems.Iconimage_right = null;
            this.btnMenuManageGarbageItems.Iconimage_right_Selected = null;
            this.btnMenuManageGarbageItems.Iconimage_Selected = null;
            this.btnMenuManageGarbageItems.IconMarginLeft = 0;
            this.btnMenuManageGarbageItems.IconMarginRight = 0;
            this.btnMenuManageGarbageItems.IconRightVisible = true;
            this.btnMenuManageGarbageItems.IconRightZoom = 0D;
            this.btnMenuManageGarbageItems.IconVisible = true;
            this.btnMenuManageGarbageItems.IconZoom = 60D;
            this.btnMenuManageGarbageItems.IsTab = false;
            this.btnMenuManageGarbageItems.Location = new System.Drawing.Point(0, 383);
            this.btnMenuManageGarbageItems.Name = "btnMenuManageGarbageItems";
            this.btnMenuManageGarbageItems.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuManageGarbageItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnMenuManageGarbageItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuManageGarbageItems.selected = false;
            this.btnMenuManageGarbageItems.Size = new System.Drawing.Size(250, 48);
            this.btnMenuManageGarbageItems.TabIndex = 9;
            this.btnMenuManageGarbageItems.Text = "Manage Garbage Items";
            this.btnMenuManageGarbageItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuManageGarbageItems.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btnMenuManageGarbageItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManageGarbageItems.Click += new System.EventHandler(this.btnMenuManageGarbageItems_Click);
            // 
            // btnMenuStockItems
            // 
            this.btnMenuStockItems.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuStockItems.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuStockItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuStockItems.BorderRadius = 0;
            this.btnMenuStockItems.ButtonText = "Manage Stock Items";
            this.btnMenuStockItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animSlider.SetDecoration(this.btnMenuStockItems, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuStockItems.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuStockItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuStockItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuStockItems.Iconimage")));
            this.btnMenuStockItems.Iconimage_right = null;
            this.btnMenuStockItems.Iconimage_right_Selected = null;
            this.btnMenuStockItems.Iconimage_Selected = null;
            this.btnMenuStockItems.IconMarginLeft = 0;
            this.btnMenuStockItems.IconMarginRight = 0;
            this.btnMenuStockItems.IconRightVisible = true;
            this.btnMenuStockItems.IconRightZoom = 0D;
            this.btnMenuStockItems.IconVisible = true;
            this.btnMenuStockItems.IconZoom = 60D;
            this.btnMenuStockItems.IsTab = false;
            this.btnMenuStockItems.Location = new System.Drawing.Point(0, 335);
            this.btnMenuStockItems.Name = "btnMenuStockItems";
            this.btnMenuStockItems.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuStockItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnMenuStockItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuStockItems.selected = false;
            this.btnMenuStockItems.Size = new System.Drawing.Size(250, 48);
            this.btnMenuStockItems.TabIndex = 8;
            this.btnMenuStockItems.Text = "Manage Stock Items";
            this.btnMenuStockItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStockItems.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btnMenuStockItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuStockItems.Click += new System.EventHandler(this.btnMenuStockItems_Click);
            // 
            // btnMenuManageItems
            // 
            this.btnMenuManageItems.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuManageItems.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuManageItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuManageItems.BorderRadius = 0;
            this.btnMenuManageItems.ButtonText = "Manage Items";
            this.btnMenuManageItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animSlider.SetDecoration(this.btnMenuManageItems, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuManageItems.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuManageItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuManageItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuManageItems.Iconimage")));
            this.btnMenuManageItems.Iconimage_right = null;
            this.btnMenuManageItems.Iconimage_right_Selected = null;
            this.btnMenuManageItems.Iconimage_Selected = null;
            this.btnMenuManageItems.IconMarginLeft = 0;
            this.btnMenuManageItems.IconMarginRight = 0;
            this.btnMenuManageItems.IconRightVisible = true;
            this.btnMenuManageItems.IconRightZoom = 0D;
            this.btnMenuManageItems.IconVisible = true;
            this.btnMenuManageItems.IconZoom = 60D;
            this.btnMenuManageItems.IsTab = false;
            this.btnMenuManageItems.Location = new System.Drawing.Point(0, 287);
            this.btnMenuManageItems.Name = "btnMenuManageItems";
            this.btnMenuManageItems.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuManageItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnMenuManageItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuManageItems.selected = false;
            this.btnMenuManageItems.Size = new System.Drawing.Size(250, 48);
            this.btnMenuManageItems.TabIndex = 7;
            this.btnMenuManageItems.Text = "Manage Items";
            this.btnMenuManageItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuManageItems.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btnMenuManageItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManageItems.Click += new System.EventHandler(this.btnMenuManageItems_Click);
            // 
            // btnMenuManageDepartments
            // 
            this.btnMenuManageDepartments.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuManageDepartments.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuManageDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuManageDepartments.BorderRadius = 0;
            this.btnMenuManageDepartments.ButtonText = "Manage Departments";
            this.btnMenuManageDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animSlider.SetDecoration(this.btnMenuManageDepartments, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuManageDepartments.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuManageDepartments.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuManageDepartments.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuManageDepartments.Iconimage")));
            this.btnMenuManageDepartments.Iconimage_right = null;
            this.btnMenuManageDepartments.Iconimage_right_Selected = null;
            this.btnMenuManageDepartments.Iconimage_Selected = null;
            this.btnMenuManageDepartments.IconMarginLeft = 0;
            this.btnMenuManageDepartments.IconMarginRight = 0;
            this.btnMenuManageDepartments.IconRightVisible = true;
            this.btnMenuManageDepartments.IconRightZoom = 0D;
            this.btnMenuManageDepartments.IconVisible = true;
            this.btnMenuManageDepartments.IconZoom = 60D;
            this.btnMenuManageDepartments.IsTab = false;
            this.btnMenuManageDepartments.Location = new System.Drawing.Point(0, 239);
            this.btnMenuManageDepartments.Name = "btnMenuManageDepartments";
            this.btnMenuManageDepartments.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuManageDepartments.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnMenuManageDepartments.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuManageDepartments.selected = false;
            this.btnMenuManageDepartments.Size = new System.Drawing.Size(250, 48);
            this.btnMenuManageDepartments.TabIndex = 6;
            this.btnMenuManageDepartments.Text = "Manage Departments";
            this.btnMenuManageDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuManageDepartments.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btnMenuManageDepartments.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManageDepartments.Click += new System.EventHandler(this.btnMenuManageDepartments_Click);
            // 
            // btnMenuManageEmployees
            // 
            this.btnMenuManageEmployees.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuManageEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuManageEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuManageEmployees.BorderRadius = 0;
            this.btnMenuManageEmployees.ButtonText = " Manage Employees";
            this.btnMenuManageEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animSlider.SetDecoration(this.btnMenuManageEmployees, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuManageEmployees.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuManageEmployees.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuManageEmployees.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuManageEmployees.Iconimage")));
            this.btnMenuManageEmployees.Iconimage_right = null;
            this.btnMenuManageEmployees.Iconimage_right_Selected = null;
            this.btnMenuManageEmployees.Iconimage_Selected = null;
            this.btnMenuManageEmployees.IconMarginLeft = 0;
            this.btnMenuManageEmployees.IconMarginRight = 0;
            this.btnMenuManageEmployees.IconRightVisible = true;
            this.btnMenuManageEmployees.IconRightZoom = 0D;
            this.btnMenuManageEmployees.IconVisible = true;
            this.btnMenuManageEmployees.IconZoom = 60D;
            this.btnMenuManageEmployees.IsTab = false;
            this.btnMenuManageEmployees.Location = new System.Drawing.Point(0, 191);
            this.btnMenuManageEmployees.Name = "btnMenuManageEmployees";
            this.btnMenuManageEmployees.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuManageEmployees.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnMenuManageEmployees.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuManageEmployees.selected = false;
            this.btnMenuManageEmployees.Size = new System.Drawing.Size(250, 48);
            this.btnMenuManageEmployees.TabIndex = 4;
            this.btnMenuManageEmployees.Text = " Manage Employees";
            this.btnMenuManageEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuManageEmployees.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btnMenuManageEmployees.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManageEmployees.Click += new System.EventHandler(this.btnMenuManageEmployees_Click);
            // 
            // pboxAvatar
            // 
            this.pboxAvatar.BackColor = System.Drawing.Color.Black;
            this.animSlider.SetDecoration(this.pboxAvatar, BunifuAnimatorNS.DecorationType.None);
            this.pboxAvatar.Location = new System.Drawing.Point(75, 5);
            this.pboxAvatar.Name = "pboxAvatar";
            this.pboxAvatar.Size = new System.Drawing.Size(100, 100);
            this.pboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAvatar.TabIndex = 1;
            this.pboxAvatar.TabStop = false;
            // 
            // pboxZimoMinimalist
            // 
            this.pboxZimoMinimalist.BackColor = System.Drawing.Color.White;
            this.animSlider.SetDecoration(this.pboxZimoMinimalist, BunifuAnimatorNS.DecorationType.None);
            this.pboxZimoMinimalist.Image = ((System.Drawing.Image)(resources.GetObject("pboxZimoMinimalist.Image")));
            this.pboxZimoMinimalist.Location = new System.Drawing.Point(475, 147);
            this.pboxZimoMinimalist.Name = "pboxZimoMinimalist";
            this.pboxZimoMinimalist.Size = new System.Drawing.Size(345, 345);
            this.pboxZimoMinimalist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxZimoMinimalist.TabIndex = 3;
            this.pboxZimoMinimalist.TabStop = false;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 10;
            this.elipseForm.TargetControl = this;
            // 
            // elipseAvatar
            // 
            this.elipseAvatar.ElipseRadius = 300;
            this.elipseAvatar.TargetControl = this.pboxAvatar;
            // 
            // dragControlForm
            // 
            this.dragControlForm.Fixed = true;
            this.dragControlForm.Horizontal = true;
            this.dragControlForm.TargetControl = this.pnlLeftMenu;
            this.dragControlForm.Vertical = true;
            // 
            // animSlider
            // 
            this.animSlider.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.animSlider.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animSlider.DefaultAnimation = animation1;
            // 
            // lblMenuRoleInfo
            // 
            this.lblMenuRoleInfo.AutoSize = true;
            this.lblMenuRoleInfo.BackColor = System.Drawing.Color.Transparent;
            this.animSlider.SetDecoration(this.lblMenuRoleInfo, BunifuAnimatorNS.DecorationType.None);
            this.lblMenuRoleInfo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuRoleInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblMenuRoleInfo.Location = new System.Drawing.Point(48, 147);
            this.lblMenuRoleInfo.Name = "lblMenuRoleInfo";
            this.lblMenuRoleInfo.Size = new System.Drawing.Size(155, 18);
            this.lblMenuRoleInfo.TabIndex = 18;
            this.lblMenuRoleInfo.Text = "Sales, System Admin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 645);
            this.Controls.Add(this.pnlMain);
            this.animSlider.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlLeftMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxZimoMinimalist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlMain;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlLeftMenu;
        private System.Windows.Forms.PictureBox pboxAvatar;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private Bunifu.Framework.UI.BunifuElipse elipseAvatar;
        private Bunifu.Framework.UI.BunifuSeparator sprMenuHorizontal;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuReports;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuManageGarbageItems;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuStockItems;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuManageItems;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuManageDepartments;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuManageEmployees;
        private Bunifu.Framework.UI.BunifuDragControl dragControlForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuSettings;
        private System.Windows.Forms.PictureBox pboxZimoMinimalist;
        private System.Windows.Forms.Label lblMenuDepartmentInfo;
        private System.Windows.Forms.Label lblMenuAvatarName;
        private BunifuAnimatorNS.BunifuTransition animSlider;
        private Admin_Controls.EmployeeControl ctrlEmployees;
        private Admin_Controls.DepartmentControl ctrlDepartments;
        private Sales_Controls.StockControl ctrlStocks;
        private Sales_Controls.GarbageControl ctrlGarbages;
        private Sales_Controls.ItemControl ctrlItems;
        private General_Controls.ReportsControl ctrlReports;
        private General_Controls.SettingsControl ctrlSettings;
        private System.Windows.Forms.Label lblMenuRoleInfo;
    }
}