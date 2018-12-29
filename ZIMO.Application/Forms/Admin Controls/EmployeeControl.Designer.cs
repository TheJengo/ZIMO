namespace ZIMO.App.Forms.Admin_Controls
{
    partial class EmployeeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeControl));
            this.pnlManageEmployees = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tbsEmployee = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbcEmployee = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpSearchEmployee = new System.Windows.Forms.TabPage();
            this.lblSearchEmployeeContainPassives = new System.Windows.Forms.Label();
            this.cboxEmployeeSearchIsActive = new Bunifu.Framework.UI.BunifuCheckbox();
            this.mlvUsers = new MaterialSkin.Controls.MaterialListView();
            this.clmNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDepartmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRoleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBorrowings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEmployeeSearchBy = new System.Windows.Forms.Label();
            this.dropEmployeeSearchKey = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnSearchEmployee = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchEmployee = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbpManageEmployee = new System.Windows.Forms.TabPage();
            this.btnManageEmployeeUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dropManageEmployeeActivity = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblManageEmployeeActivity = new System.Windows.Forms.Label();
            this.pnlManageFailAlert = new System.Windows.Forms.Panel();
            this.lblManageFailAlert2 = new System.Windows.Forms.Label();
            this.lblManageFailAlert1 = new System.Windows.Forms.Label();
            this.pboxManageFailAlert = new System.Windows.Forms.PictureBox();
            this.pnlManageSuccessfulAlert = new System.Windows.Forms.Panel();
            this.lblManageSuccessAlert = new System.Windows.Forms.Label();
            this.pboxManageSuccessfulAlert = new System.Windows.Forms.PictureBox();
            this.btnManageEmployeeDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtManageEmployeeConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblManageEmployeeConfirmPassword = new System.Windows.Forms.Label();
            this.btnManageOpenFileDialog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManageEmployeeSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dropManageEmployeeDepartment = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblManageEmployeeRoleName = new System.Windows.Forms.Label();
            this.lblManageEmployeeDepartmentName = new System.Windows.Forms.Label();
            this.dropManageEmployeeRole = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblManageEmployeeAvatarPath = new System.Windows.Forms.Label();
            this.lblManageEmployeeLastName = new System.Windows.Forms.Label();
            this.lblManageEmployeeFirstName = new System.Windows.Forms.Label();
            this.lblManageEmployeePassword = new System.Windows.Forms.Label();
            this.lblManageEmployeeUsername = new System.Windows.Forms.Label();
            this.txtManageEmployeeAvatarPath = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtManageEmployeeLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtManageEmployeeFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtManageEmployeePassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblManageInformationTitle = new System.Windows.Forms.Label();
            this.txtManageEmployeeUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlManageEmployees.SuspendLayout();
            this.tbcEmployee.SuspendLayout();
            this.tbpSearchEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEmployee)).BeginInit();
            this.tbpManageEmployee.SuspendLayout();
            this.pnlManageFailAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxManageFailAlert)).BeginInit();
            this.pnlManageSuccessfulAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxManageSuccessfulAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManageEmployees
            // 
            this.pnlManageEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManageEmployees.BackgroundImage")));
            this.pnlManageEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlManageEmployees.Controls.Add(this.tbsEmployee);
            this.pnlManageEmployees.Controls.Add(this.tbcEmployee);
            this.pnlManageEmployees.GradientBottomLeft = System.Drawing.Color.Gainsboro;
            this.pnlManageEmployees.GradientBottomRight = System.Drawing.Color.GhostWhite;
            this.pnlManageEmployees.GradientTopLeft = System.Drawing.Color.Gainsboro;
            this.pnlManageEmployees.GradientTopRight = System.Drawing.Color.Gainsboro;
            this.pnlManageEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlManageEmployees.Name = "pnlManageEmployees";
            this.pnlManageEmployees.Quality = 10;
            this.pnlManageEmployees.Size = new System.Drawing.Size(774, 645);
            this.pnlManageEmployees.TabIndex = 6;
            // 
            // tbsEmployee
            // 
            this.tbsEmployee.BaseTabControl = this.tbcEmployee;
            this.tbsEmployee.Depth = 0;
            this.tbsEmployee.Location = new System.Drawing.Point(0, 0);
            this.tbsEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbsEmployee.Name = "tbsEmployee";
            this.tbsEmployee.Size = new System.Drawing.Size(774, 40);
            this.tbsEmployee.TabIndex = 1;
            this.tbsEmployee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbsEmployee_MouseClick);
            // 
            // tbcEmployee
            // 
            this.tbcEmployee.Controls.Add(this.tbpSearchEmployee);
            this.tbcEmployee.Controls.Add(this.tbpManageEmployee);
            this.tbcEmployee.Depth = 0;
            this.tbcEmployee.Location = new System.Drawing.Point(0, 42);
            this.tbcEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbcEmployee.Name = "tbcEmployee";
            this.tbcEmployee.SelectedIndex = 0;
            this.tbcEmployee.Size = new System.Drawing.Size(774, 600);
            this.tbcEmployee.TabIndex = 0;
            // 
            // tbpSearchEmployee
            // 
            this.tbpSearchEmployee.Controls.Add(this.lblSearchEmployeeContainPassives);
            this.tbpSearchEmployee.Controls.Add(this.cboxEmployeeSearchIsActive);
            this.tbpSearchEmployee.Controls.Add(this.mlvUsers);
            this.tbpSearchEmployee.Controls.Add(this.lblEmployeeSearchBy);
            this.tbpSearchEmployee.Controls.Add(this.dropEmployeeSearchKey);
            this.tbpSearchEmployee.Controls.Add(this.btnSearchEmployee);
            this.tbpSearchEmployee.Controls.Add(this.txtSearchEmployee);
            this.tbpSearchEmployee.Location = new System.Drawing.Point(4, 22);
            this.tbpSearchEmployee.Name = "tbpSearchEmployee";
            this.tbpSearchEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearchEmployee.Size = new System.Drawing.Size(766, 574);
            this.tbpSearchEmployee.TabIndex = 0;
            this.tbpSearchEmployee.Text = "Search";
            this.tbpSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // lblSearchEmployeeContainPassives
            // 
            this.lblSearchEmployeeContainPassives.AutoSize = true;
            this.lblSearchEmployeeContainPassives.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchEmployeeContainPassives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearchEmployeeContainPassives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblSearchEmployeeContainPassives.Location = new System.Drawing.Point(318, 15);
            this.lblSearchEmployeeContainPassives.Name = "lblSearchEmployeeContainPassives";
            this.lblSearchEmployeeContainPassives.Size = new System.Drawing.Size(132, 17);
            this.lblSearchEmployeeContainPassives.TabIndex = 2;
            this.lblSearchEmployeeContainPassives.Text = "Contain Passives";
            this.lblSearchEmployeeContainPassives.Click += new System.EventHandler(this.lblSearchEmployeeContainPassives_Click);
            // 
            // cboxEmployeeSearchIsActive
            // 
            this.cboxEmployeeSearchIsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.cboxEmployeeSearchIsActive.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cboxEmployeeSearchIsActive.Checked = true;
            this.cboxEmployeeSearchIsActive.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.cboxEmployeeSearchIsActive.ForeColor = System.Drawing.Color.White;
            this.cboxEmployeeSearchIsActive.Location = new System.Drawing.Point(296, 14);
            this.cboxEmployeeSearchIsActive.Name = "cboxEmployeeSearchIsActive";
            this.cboxEmployeeSearchIsActive.Size = new System.Drawing.Size(20, 20);
            this.cboxEmployeeSearchIsActive.TabIndex = 15;
            this.cboxEmployeeSearchIsActive.Tag = "";
            this.cboxEmployeeSearchIsActive.OnChange += new System.EventHandler(this.cboxIsActive_OnChange);
            // 
            // mlvUsers
            // 
            this.mlvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNumber,
            this.clmUserName,
            this.clmFirstName,
            this.clmLastName,
            this.clmDepartmentName,
            this.clmRoleName,
            this.clmBorrowings});
            this.mlvUsers.Depth = 0;
            this.mlvUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvUsers.FullRowSelect = true;
            this.mlvUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvUsers.Location = new System.Drawing.Point(2, 46);
            this.mlvUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvUsers.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvUsers.Name = "mlvUsers";
            this.mlvUsers.OwnerDraw = true;
            this.mlvUsers.Size = new System.Drawing.Size(764, 523);
            this.mlvUsers.TabIndex = 14;
            this.mlvUsers.UseCompatibleStateImageBehavior = false;
            this.mlvUsers.View = System.Windows.Forms.View.Details;
            this.mlvUsers.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvUsers_ItemSelectionChanged);
            // 
            // clmNumber
            // 
            this.clmNumber.Text = "#";
            this.clmNumber.Width = 50;
            // 
            // clmUserName
            // 
            this.clmUserName.Text = "UserName";
            this.clmUserName.Width = 120;
            // 
            // clmFirstName
            // 
            this.clmFirstName.Text = "First Name";
            this.clmFirstName.Width = 100;
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "Last Name";
            this.clmLastName.Width = 100;
            // 
            // clmDepartmentName
            // 
            this.clmDepartmentName.Text = "Department";
            this.clmDepartmentName.Width = 140;
            // 
            // clmRoleName
            // 
            this.clmRoleName.Text = "Role";
            this.clmRoleName.Width = 100;
            // 
            // clmBorrowings
            // 
            this.clmBorrowings.Text = "Borrows";
            this.clmBorrowings.Width = 150;
            // 
            // lblEmployeeSearchBy
            // 
            this.lblEmployeeSearchBy.AutoSize = true;
            this.lblEmployeeSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmployeeSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblEmployeeSearchBy.Location = new System.Drawing.Point(-1, 14);
            this.lblEmployeeSearchBy.Name = "lblEmployeeSearchBy";
            this.lblEmployeeSearchBy.Size = new System.Drawing.Size(111, 24);
            this.lblEmployeeSearchBy.TabIndex = 13;
            this.lblEmployeeSearchBy.Text = "Search By:";
            // 
            // dropEmployeeSearchKey
            // 
            this.dropEmployeeSearchKey.BackColor = System.Drawing.Color.Transparent;
            this.dropEmployeeSearchKey.BorderRadius = 3;
            this.dropEmployeeSearchKey.DisabledColor = System.Drawing.Color.Gray;
            this.dropEmployeeSearchKey.ForeColor = System.Drawing.Color.White;
            this.dropEmployeeSearchKey.Items = new string[] {
        "Username",
        "First Name",
        "Last Name",
        "Department Name",
        "Role Name"};
            this.dropEmployeeSearchKey.Location = new System.Drawing.Point(115, 7);
            this.dropEmployeeSearchKey.Name = "dropEmployeeSearchKey";
            this.dropEmployeeSearchKey.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropEmployeeSearchKey.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropEmployeeSearchKey.selectedIndex = 0;
            this.dropEmployeeSearchKey.Size = new System.Drawing.Size(176, 35);
            this.dropEmployeeSearchKey.TabIndex = 1;
            this.dropEmployeeSearchKey.onItemSelected += new System.EventHandler(this.dropEmployeeSearchKey_onItemSelected);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchEmployee.Image")));
            this.btnSearchEmployee.ImageActive = null;
            this.btnSearchEmployee.Location = new System.Drawing.Point(723, 7);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(40, 33);
            this.btnSearchEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchEmployee.TabIndex = 5;
            this.btnSearchEmployee.TabStop = false;
            this.btnSearchEmployee.Zoom = 4;
            this.btnSearchEmployee.Click += new System.EventHandler(this.txtSearchEmployee_OnValueChanged);
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.BackColor = System.Drawing.Color.White;
            this.txtSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEmployee.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchEmployee.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSearchEmployee.HintText = "Search...";
            this.txtSearchEmployee.isPassword = false;
            this.txtSearchEmployee.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchEmployee.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchEmployee.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchEmployee.LineThickness = 3;
            this.txtSearchEmployee.Location = new System.Drawing.Point(457, 7);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(266, 33);
            this.txtSearchEmployee.TabIndex = 3;
            this.txtSearchEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchEmployee.OnValueChanged += new System.EventHandler(this.txtSearchEmployee_OnValueChanged);
            // 
            // tbpManageEmployee
            // 
            this.tbpManageEmployee.Controls.Add(this.btnManageEmployeeUpdate);
            this.tbpManageEmployee.Controls.Add(this.dropManageEmployeeActivity);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeeActivity);
            this.tbpManageEmployee.Controls.Add(this.pnlManageFailAlert);
            this.tbpManageEmployee.Controls.Add(this.pnlManageSuccessfulAlert);
            this.tbpManageEmployee.Controls.Add(this.btnManageEmployeeDelete);
            this.tbpManageEmployee.Controls.Add(this.txtManageEmployeeConfirmPassword);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeeConfirmPassword);
            this.tbpManageEmployee.Controls.Add(this.btnManageOpenFileDialog);
            this.tbpManageEmployee.Controls.Add(this.btnManageEmployeeSubmit);
            this.tbpManageEmployee.Controls.Add(this.dropManageEmployeeDepartment);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeeRoleName);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeeDepartmentName);
            this.tbpManageEmployee.Controls.Add(this.dropManageEmployeeRole);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeeAvatarPath);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeeLastName);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeeFirstName);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeePassword);
            this.tbpManageEmployee.Controls.Add(this.lblManageEmployeeUsername);
            this.tbpManageEmployee.Controls.Add(this.txtManageEmployeeAvatarPath);
            this.tbpManageEmployee.Controls.Add(this.txtManageEmployeeLastName);
            this.tbpManageEmployee.Controls.Add(this.txtManageEmployeeFirstName);
            this.tbpManageEmployee.Controls.Add(this.txtManageEmployeePassword);
            this.tbpManageEmployee.Controls.Add(this.lblManageInformationTitle);
            this.tbpManageEmployee.Controls.Add(this.txtManageEmployeeUsername);
            this.tbpManageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tbpManageEmployee.Name = "tbpManageEmployee";
            this.tbpManageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbpManageEmployee.Size = new System.Drawing.Size(766, 574);
            this.tbpManageEmployee.TabIndex = 1;
            this.tbpManageEmployee.Text = "Manage";
            this.tbpManageEmployee.UseVisualStyleBackColor = true;
            // 
            // btnManageEmployeeUpdate
            // 
            this.btnManageEmployeeUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageEmployeeUpdate.BorderRadius = 0;
            this.btnManageEmployeeUpdate.ButtonText = "Update";
            this.btnManageEmployeeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmployeeUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageEmployeeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageEmployeeUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageEmployeeUpdate.Iconimage = null;
            this.btnManageEmployeeUpdate.Iconimage_right = null;
            this.btnManageEmployeeUpdate.Iconimage_right_Selected = null;
            this.btnManageEmployeeUpdate.Iconimage_Selected = null;
            this.btnManageEmployeeUpdate.IconMarginLeft = 0;
            this.btnManageEmployeeUpdate.IconMarginRight = 0;
            this.btnManageEmployeeUpdate.IconRightVisible = false;
            this.btnManageEmployeeUpdate.IconRightZoom = 0D;
            this.btnManageEmployeeUpdate.IconVisible = false;
            this.btnManageEmployeeUpdate.IconZoom = 90D;
            this.btnManageEmployeeUpdate.IsTab = false;
            this.btnManageEmployeeUpdate.Location = new System.Drawing.Point(193, 434);
            this.btnManageEmployeeUpdate.Name = "btnManageEmployeeUpdate";
            this.btnManageEmployeeUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageEmployeeUpdate.selected = false;
            this.btnManageEmployeeUpdate.Size = new System.Drawing.Size(275, 48);
            this.btnManageEmployeeUpdate.TabIndex = 38;
            this.btnManageEmployeeUpdate.Text = "Update";
            this.btnManageEmployeeUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageEmployeeUpdate.Textcolor = System.Drawing.Color.White;
            this.btnManageEmployeeUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployeeUpdate.Click += new System.EventHandler(this.btnManageEmployeeUpdate_Click);
            // 
            // dropManageEmployeeActivity
            // 
            this.dropManageEmployeeActivity.BackColor = System.Drawing.Color.Transparent;
            this.dropManageEmployeeActivity.BorderRadius = 3;
            this.dropManageEmployeeActivity.DisabledColor = System.Drawing.Color.Gray;
            this.dropManageEmployeeActivity.ForeColor = System.Drawing.Color.White;
            this.dropManageEmployeeActivity.Items = new string[] {
        "True",
        "False"};
            this.dropManageEmployeeActivity.Location = new System.Drawing.Point(193, 393);
            this.dropManageEmployeeActivity.Name = "dropManageEmployeeActivity";
            this.dropManageEmployeeActivity.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropManageEmployeeActivity.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropManageEmployeeActivity.selectedIndex = 0;
            this.dropManageEmployeeActivity.Size = new System.Drawing.Size(379, 35);
            this.dropManageEmployeeActivity.TabIndex = 37;
            // 
            // lblManageEmployeeActivity
            // 
            this.lblManageEmployeeActivity.AutoSize = true;
            this.lblManageEmployeeActivity.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeeActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeeActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeeActivity.Location = new System.Drawing.Point(86, 410);
            this.lblManageEmployeeActivity.Name = "lblManageEmployeeActivity";
            this.lblManageEmployeeActivity.Size = new System.Drawing.Size(57, 17);
            this.lblManageEmployeeActivity.TabIndex = 36;
            this.lblManageEmployeeActivity.Text = "Active:";
            // 
            // pnlManageFailAlert
            // 
            this.pnlManageFailAlert.Controls.Add(this.lblManageFailAlert2);
            this.pnlManageFailAlert.Controls.Add(this.lblManageFailAlert1);
            this.pnlManageFailAlert.Controls.Add(this.pboxManageFailAlert);
            this.pnlManageFailAlert.Location = new System.Drawing.Point(580, 145);
            this.pnlManageFailAlert.Name = "pnlManageFailAlert";
            this.pnlManageFailAlert.Size = new System.Drawing.Size(184, 210);
            this.pnlManageFailAlert.TabIndex = 35;
            this.pnlManageFailAlert.Visible = false;
            // 
            // lblManageFailAlert2
            // 
            this.lblManageFailAlert2.AutoSize = true;
            this.lblManageFailAlert2.BackColor = System.Drawing.Color.Transparent;
            this.lblManageFailAlert2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageFailAlert2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.lblManageFailAlert2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageFailAlert2.Location = new System.Drawing.Point(8, 149);
            this.lblManageFailAlert2.Name = "lblManageFailAlert2";
            this.lblManageFailAlert2.Size = new System.Drawing.Size(169, 17);
            this.lblManageFailAlert2.TabIndex = 18;
            this.lblManageFailAlert2.Text = "Check the credentials!";
            // 
            // lblManageFailAlert1
            // 
            this.lblManageFailAlert1.AutoSize = true;
            this.lblManageFailAlert1.BackColor = System.Drawing.Color.Transparent;
            this.lblManageFailAlert1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageFailAlert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.lblManageFailAlert1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageFailAlert1.Location = new System.Drawing.Point(28, 128);
            this.lblManageFailAlert1.Name = "lblManageFailAlert1";
            this.lblManageFailAlert1.Size = new System.Drawing.Size(129, 17);
            this.lblManageFailAlert1.TabIndex = 17;
            this.lblManageFailAlert1.Text = "Operation failed!";
            // 
            // pboxManageFailAlert
            // 
            this.pboxManageFailAlert.Image = ((System.Drawing.Image)(resources.GetObject("pboxManageFailAlert.Image")));
            this.pboxManageFailAlert.Location = new System.Drawing.Point(17, 16);
            this.pboxManageFailAlert.Name = "pboxManageFailAlert";
            this.pboxManageFailAlert.Size = new System.Drawing.Size(150, 110);
            this.pboxManageFailAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxManageFailAlert.TabIndex = 1;
            this.pboxManageFailAlert.TabStop = false;
            // 
            // pnlManageSuccessfulAlert
            // 
            this.pnlManageSuccessfulAlert.Controls.Add(this.lblManageSuccessAlert);
            this.pnlManageSuccessfulAlert.Controls.Add(this.pboxManageSuccessfulAlert);
            this.pnlManageSuccessfulAlert.Location = new System.Drawing.Point(579, 144);
            this.pnlManageSuccessfulAlert.Name = "pnlManageSuccessfulAlert";
            this.pnlManageSuccessfulAlert.Size = new System.Drawing.Size(184, 210);
            this.pnlManageSuccessfulAlert.TabIndex = 34;
            this.pnlManageSuccessfulAlert.Visible = false;
            // 
            // lblManageSuccessAlert
            // 
            this.lblManageSuccessAlert.AutoSize = true;
            this.lblManageSuccessAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblManageSuccessAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageSuccessAlert.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblManageSuccessAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageSuccessAlert.Location = new System.Drawing.Point(10, 130);
            this.lblManageSuccessAlert.Name = "lblManageSuccessAlert";
            this.lblManageSuccessAlert.Size = new System.Drawing.Size(165, 17);
            this.lblManageSuccessAlert.TabIndex = 17;
            this.lblManageSuccessAlert.Text = "Operation successful!";
            // 
            // pboxManageSuccessfulAlert
            // 
            this.pboxManageSuccessfulAlert.Image = ((System.Drawing.Image)(resources.GetObject("pboxManageSuccessfulAlert.Image")));
            this.pboxManageSuccessfulAlert.Location = new System.Drawing.Point(17, 16);
            this.pboxManageSuccessfulAlert.Name = "pboxManageSuccessfulAlert";
            this.pboxManageSuccessfulAlert.Size = new System.Drawing.Size(150, 110);
            this.pboxManageSuccessfulAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxManageSuccessfulAlert.TabIndex = 1;
            this.pboxManageSuccessfulAlert.TabStop = false;
            // 
            // btnManageEmployeeDelete
            // 
            this.btnManageEmployeeDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnManageEmployeeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageEmployeeDelete.BorderRadius = 0;
            this.btnManageEmployeeDelete.ButtonText = "DELETE";
            this.btnManageEmployeeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmployeeDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageEmployeeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageEmployeeDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageEmployeeDelete.Iconimage = null;
            this.btnManageEmployeeDelete.Iconimage_right = null;
            this.btnManageEmployeeDelete.Iconimage_right_Selected = null;
            this.btnManageEmployeeDelete.Iconimage_Selected = null;
            this.btnManageEmployeeDelete.IconMarginLeft = 0;
            this.btnManageEmployeeDelete.IconMarginRight = 0;
            this.btnManageEmployeeDelete.IconRightVisible = false;
            this.btnManageEmployeeDelete.IconRightZoom = 0D;
            this.btnManageEmployeeDelete.IconVisible = false;
            this.btnManageEmployeeDelete.IconZoom = 90D;
            this.btnManageEmployeeDelete.IsTab = false;
            this.btnManageEmployeeDelete.Location = new System.Drawing.Point(474, 434);
            this.btnManageEmployeeDelete.Name = "btnManageEmployeeDelete";
            this.btnManageEmployeeDelete.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnManageEmployeeDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnManageEmployeeDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageEmployeeDelete.selected = false;
            this.btnManageEmployeeDelete.Size = new System.Drawing.Size(98, 48);
            this.btnManageEmployeeDelete.TabIndex = 15;
            this.btnManageEmployeeDelete.Text = "DELETE";
            this.btnManageEmployeeDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageEmployeeDelete.Textcolor = System.Drawing.Color.White;
            this.btnManageEmployeeDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtManageEmployeeConfirmPassword
            // 
            this.txtManageEmployeeConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtManageEmployeeConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageEmployeeConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageEmployeeConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageEmployeeConfirmPassword.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageEmployeeConfirmPassword.HintText = "";
            this.txtManageEmployeeConfirmPassword.isPassword = true;
            this.txtManageEmployeeConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeConfirmPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeConfirmPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeConfirmPassword.LineThickness = 3;
            this.txtManageEmployeeConfirmPassword.Location = new System.Drawing.Point(193, 144);
            this.txtManageEmployeeConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageEmployeeConfirmPassword.Name = "txtManageEmployeeConfirmPassword";
            this.txtManageEmployeeConfirmPassword.Size = new System.Drawing.Size(379, 33);
            this.txtManageEmployeeConfirmPassword.TabIndex = 7;
            this.txtManageEmployeeConfirmPassword.Text = "password";
            this.txtManageEmployeeConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageEmployeeConfirmPassword.OnValueChanged += new System.EventHandler(this.txtManageEmployeePassword_OnValueChanged);
            // 
            // lblManageEmployeeConfirmPassword
            // 
            this.lblManageEmployeeConfirmPassword.AutoSize = true;
            this.lblManageEmployeeConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeeConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeeConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeeConfirmPassword.Location = new System.Drawing.Point(86, 160);
            this.lblManageEmployeeConfirmPassword.Name = "lblManageEmployeeConfirmPassword";
            this.lblManageEmployeeConfirmPassword.Size = new System.Drawing.Size(108, 17);
            this.lblManageEmployeeConfirmPassword.TabIndex = 32;
            this.lblManageEmployeeConfirmPassword.Text = "Confirm Pass:";
            // 
            // btnManageOpenFileDialog
            // 
            this.btnManageOpenFileDialog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageOpenFileDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageOpenFileDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageOpenFileDialog.BorderRadius = 0;
            this.btnManageOpenFileDialog.ButtonText = "Open";
            this.btnManageOpenFileDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageOpenFileDialog.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageOpenFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageOpenFileDialog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageOpenFileDialog.Iconimage = null;
            this.btnManageOpenFileDialog.Iconimage_right = null;
            this.btnManageOpenFileDialog.Iconimage_right_Selected = null;
            this.btnManageOpenFileDialog.Iconimage_Selected = null;
            this.btnManageOpenFileDialog.IconMarginLeft = 0;
            this.btnManageOpenFileDialog.IconMarginRight = 0;
            this.btnManageOpenFileDialog.IconRightVisible = false;
            this.btnManageOpenFileDialog.IconRightZoom = 0D;
            this.btnManageOpenFileDialog.IconVisible = false;
            this.btnManageOpenFileDialog.IconZoom = 90D;
            this.btnManageOpenFileDialog.IsTab = false;
            this.btnManageOpenFileDialog.Location = new System.Drawing.Point(487, 266);
            this.btnManageOpenFileDialog.Name = "btnManageOpenFileDialog";
            this.btnManageOpenFileDialog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageOpenFileDialog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageOpenFileDialog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageOpenFileDialog.selected = false;
            this.btnManageOpenFileDialog.Size = new System.Drawing.Size(85, 39);
            this.btnManageOpenFileDialog.TabIndex = 11;
            this.btnManageOpenFileDialog.Text = "Open";
            this.btnManageOpenFileDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageOpenFileDialog.Textcolor = System.Drawing.Color.White;
            this.btnManageOpenFileDialog.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOpenFileDialog.Click += new System.EventHandler(this.btnManageOpenFileDialog_Click);
            // 
            // btnManageEmployeeSubmit
            // 
            this.btnManageEmployeeSubmit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageEmployeeSubmit.BorderRadius = 0;
            this.btnManageEmployeeSubmit.ButtonText = "ADD";
            this.btnManageEmployeeSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmployeeSubmit.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageEmployeeSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageEmployeeSubmit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageEmployeeSubmit.Iconimage = null;
            this.btnManageEmployeeSubmit.Iconimage_right = null;
            this.btnManageEmployeeSubmit.Iconimage_right_Selected = null;
            this.btnManageEmployeeSubmit.Iconimage_Selected = null;
            this.btnManageEmployeeSubmit.IconMarginLeft = 0;
            this.btnManageEmployeeSubmit.IconMarginRight = 0;
            this.btnManageEmployeeSubmit.IconRightVisible = false;
            this.btnManageEmployeeSubmit.IconRightZoom = 0D;
            this.btnManageEmployeeSubmit.IconVisible = false;
            this.btnManageEmployeeSubmit.IconZoom = 90D;
            this.btnManageEmployeeSubmit.IsTab = false;
            this.btnManageEmployeeSubmit.Location = new System.Drawing.Point(193, 434);
            this.btnManageEmployeeSubmit.Name = "btnManageEmployeeSubmit";
            this.btnManageEmployeeSubmit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeSubmit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageEmployeeSubmit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageEmployeeSubmit.selected = false;
            this.btnManageEmployeeSubmit.Size = new System.Drawing.Size(275, 48);
            this.btnManageEmployeeSubmit.TabIndex = 14;
            this.btnManageEmployeeSubmit.Text = "ADD";
            this.btnManageEmployeeSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageEmployeeSubmit.Textcolor = System.Drawing.Color.White;
            this.btnManageEmployeeSubmit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployeeSubmit.Click += new System.EventHandler(this.btnManageEmployeeSubmit_Click);
            // 
            // dropManageEmployeeDepartment
            // 
            this.dropManageEmployeeDepartment.BackColor = System.Drawing.Color.Transparent;
            this.dropManageEmployeeDepartment.BorderRadius = 3;
            this.dropManageEmployeeDepartment.DisabledColor = System.Drawing.Color.Gray;
            this.dropManageEmployeeDepartment.ForeColor = System.Drawing.Color.White;
            this.dropManageEmployeeDepartment.Items = new string[0];
            this.dropManageEmployeeDepartment.Location = new System.Drawing.Point(193, 311);
            this.dropManageEmployeeDepartment.Name = "dropManageEmployeeDepartment";
            this.dropManageEmployeeDepartment.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropManageEmployeeDepartment.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropManageEmployeeDepartment.selectedIndex = -1;
            this.dropManageEmployeeDepartment.Size = new System.Drawing.Size(379, 35);
            this.dropManageEmployeeDepartment.TabIndex = 12;
            // 
            // lblManageEmployeeRoleName
            // 
            this.lblManageEmployeeRoleName.AutoSize = true;
            this.lblManageEmployeeRoleName.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeeRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeeRoleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeeRoleName.Location = new System.Drawing.Point(86, 370);
            this.lblManageEmployeeRoleName.Name = "lblManageEmployeeRoleName";
            this.lblManageEmployeeRoleName.Size = new System.Drawing.Size(46, 17);
            this.lblManageEmployeeRoleName.TabIndex = 28;
            this.lblManageEmployeeRoleName.Text = "Role:";
            // 
            // lblManageEmployeeDepartmentName
            // 
            this.lblManageEmployeeDepartmentName.AutoSize = true;
            this.lblManageEmployeeDepartmentName.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeeDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeeDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeeDepartmentName.Location = new System.Drawing.Point(86, 329);
            this.lblManageEmployeeDepartmentName.Name = "lblManageEmployeeDepartmentName";
            this.lblManageEmployeeDepartmentName.Size = new System.Drawing.Size(97, 17);
            this.lblManageEmployeeDepartmentName.TabIndex = 27;
            this.lblManageEmployeeDepartmentName.Text = "Department:";
            // 
            // dropManageEmployeeRole
            // 
            this.dropManageEmployeeRole.BackColor = System.Drawing.Color.Transparent;
            this.dropManageEmployeeRole.BorderRadius = 3;
            this.dropManageEmployeeRole.DisabledColor = System.Drawing.Color.Gray;
            this.dropManageEmployeeRole.ForeColor = System.Drawing.Color.White;
            this.dropManageEmployeeRole.Items = new string[0];
            this.dropManageEmployeeRole.Location = new System.Drawing.Point(193, 352);
            this.dropManageEmployeeRole.Name = "dropManageEmployeeRole";
            this.dropManageEmployeeRole.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropManageEmployeeRole.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropManageEmployeeRole.selectedIndex = -1;
            this.dropManageEmployeeRole.Size = new System.Drawing.Size(379, 35);
            this.dropManageEmployeeRole.TabIndex = 13;
            // 
            // lblManageEmployeeAvatarPath
            // 
            this.lblManageEmployeeAvatarPath.AutoSize = true;
            this.lblManageEmployeeAvatarPath.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeeAvatarPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeeAvatarPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeeAvatarPath.Location = new System.Drawing.Point(86, 287);
            this.lblManageEmployeeAvatarPath.Name = "lblManageEmployeeAvatarPath";
            this.lblManageEmployeeAvatarPath.Size = new System.Drawing.Size(60, 17);
            this.lblManageEmployeeAvatarPath.TabIndex = 24;
            this.lblManageEmployeeAvatarPath.Text = "Avatar:";
            // 
            // lblManageEmployeeLastName
            // 
            this.lblManageEmployeeLastName.AutoSize = true;
            this.lblManageEmployeeLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeeLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeeLastName.Location = new System.Drawing.Point(86, 242);
            this.lblManageEmployeeLastName.Name = "lblManageEmployeeLastName";
            this.lblManageEmployeeLastName.Size = new System.Drawing.Size(90, 17);
            this.lblManageEmployeeLastName.TabIndex = 23;
            this.lblManageEmployeeLastName.Text = "Last Name:";
            // 
            // lblManageEmployeeFirstName
            // 
            this.lblManageEmployeeFirstName.AutoSize = true;
            this.lblManageEmployeeFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeeFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeeFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeeFirstName.Location = new System.Drawing.Point(86, 201);
            this.lblManageEmployeeFirstName.Name = "lblManageEmployeeFirstName";
            this.lblManageEmployeeFirstName.Size = new System.Drawing.Size(91, 17);
            this.lblManageEmployeeFirstName.TabIndex = 22;
            this.lblManageEmployeeFirstName.Text = "First Name:";
            // 
            // lblManageEmployeePassword
            // 
            this.lblManageEmployeePassword.AutoSize = true;
            this.lblManageEmployeePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeePassword.Location = new System.Drawing.Point(86, 119);
            this.lblManageEmployeePassword.Name = "lblManageEmployeePassword";
            this.lblManageEmployeePassword.Size = new System.Drawing.Size(82, 17);
            this.lblManageEmployeePassword.TabIndex = 21;
            this.lblManageEmployeePassword.Text = "Password:";
            // 
            // lblManageEmployeeUsername
            // 
            this.lblManageEmployeeUsername.AutoSize = true;
            this.lblManageEmployeeUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblManageEmployeeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageEmployeeUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageEmployeeUsername.Location = new System.Drawing.Point(86, 78);
            this.lblManageEmployeeUsername.Name = "lblManageEmployeeUsername";
            this.lblManageEmployeeUsername.Size = new System.Drawing.Size(86, 17);
            this.lblManageEmployeeUsername.TabIndex = 20;
            this.lblManageEmployeeUsername.Text = "Username:";
            // 
            // txtManageEmployeeAvatarPath
            // 
            this.txtManageEmployeeAvatarPath.BackColor = System.Drawing.Color.White;
            this.txtManageEmployeeAvatarPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageEmployeeAvatarPath.Enabled = false;
            this.txtManageEmployeeAvatarPath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageEmployeeAvatarPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageEmployeeAvatarPath.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageEmployeeAvatarPath.HintText = "JohnDoe.png";
            this.txtManageEmployeeAvatarPath.isPassword = false;
            this.txtManageEmployeeAvatarPath.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeAvatarPath.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeAvatarPath.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeAvatarPath.LineThickness = 3;
            this.txtManageEmployeeAvatarPath.Location = new System.Drawing.Point(193, 271);
            this.txtManageEmployeeAvatarPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageEmployeeAvatarPath.Name = "txtManageEmployeeAvatarPath";
            this.txtManageEmployeeAvatarPath.Size = new System.Drawing.Size(287, 33);
            this.txtManageEmployeeAvatarPath.TabIndex = 10;
            this.txtManageEmployeeAvatarPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageEmployeeAvatarPath.OnValueChanged += new System.EventHandler(this.txtManageEmployeeAvatarPath_OnValueChanged);
            // 
            // txtManageEmployeeLastName
            // 
            this.txtManageEmployeeLastName.BackColor = System.Drawing.Color.White;
            this.txtManageEmployeeLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageEmployeeLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageEmployeeLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageEmployeeLastName.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageEmployeeLastName.HintText = "Doe";
            this.txtManageEmployeeLastName.isPassword = false;
            this.txtManageEmployeeLastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeLastName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeLastName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeLastName.LineThickness = 3;
            this.txtManageEmployeeLastName.Location = new System.Drawing.Point(193, 226);
            this.txtManageEmployeeLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageEmployeeLastName.Name = "txtManageEmployeeLastName";
            this.txtManageEmployeeLastName.Size = new System.Drawing.Size(379, 33);
            this.txtManageEmployeeLastName.TabIndex = 9;
            this.txtManageEmployeeLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageEmployeeLastName.OnValueChanged += new System.EventHandler(this.txtManageEmployeeLastName_OnValueChanged);
            // 
            // txtManageEmployeeFirstName
            // 
            this.txtManageEmployeeFirstName.BackColor = System.Drawing.Color.White;
            this.txtManageEmployeeFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageEmployeeFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageEmployeeFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageEmployeeFirstName.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageEmployeeFirstName.HintText = "John";
            this.txtManageEmployeeFirstName.isPassword = false;
            this.txtManageEmployeeFirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeFirstName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeFirstName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeFirstName.LineThickness = 3;
            this.txtManageEmployeeFirstName.Location = new System.Drawing.Point(193, 185);
            this.txtManageEmployeeFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageEmployeeFirstName.Name = "txtManageEmployeeFirstName";
            this.txtManageEmployeeFirstName.Size = new System.Drawing.Size(379, 33);
            this.txtManageEmployeeFirstName.TabIndex = 8;
            this.txtManageEmployeeFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageEmployeeFirstName.OnValueChanged += new System.EventHandler(this.txtManageEmployeeFirstName_OnValueChanged);
            // 
            // txtManageEmployeePassword
            // 
            this.txtManageEmployeePassword.BackColor = System.Drawing.Color.White;
            this.txtManageEmployeePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageEmployeePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageEmployeePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageEmployeePassword.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageEmployeePassword.HintText = "";
            this.txtManageEmployeePassword.isPassword = true;
            this.txtManageEmployeePassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeePassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeePassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeePassword.LineThickness = 3;
            this.txtManageEmployeePassword.Location = new System.Drawing.Point(193, 103);
            this.txtManageEmployeePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageEmployeePassword.Name = "txtManageEmployeePassword";
            this.txtManageEmployeePassword.Size = new System.Drawing.Size(379, 33);
            this.txtManageEmployeePassword.TabIndex = 6;
            this.txtManageEmployeePassword.Text = "password";
            this.txtManageEmployeePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageEmployeePassword.OnValueChanged += new System.EventHandler(this.txtManageEmployeePassword_OnValueChanged);
            // 
            // lblManageInformationTitle
            // 
            this.lblManageInformationTitle.AutoSize = true;
            this.lblManageInformationTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblManageInformationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManageInformationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageInformationTitle.Location = new System.Drawing.Point(6, 27);
            this.lblManageInformationTitle.Name = "lblManageInformationTitle";
            this.lblManageInformationTitle.Size = new System.Drawing.Size(178, 24);
            this.lblManageInformationTitle.TabIndex = 14;
            this.lblManageInformationTitle.Text = "User Informations:";
            // 
            // txtManageEmployeeUsername
            // 
            this.txtManageEmployeeUsername.BackColor = System.Drawing.Color.White;
            this.txtManageEmployeeUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageEmployeeUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageEmployeeUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageEmployeeUsername.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageEmployeeUsername.HintText = "example@zimo.com";
            this.txtManageEmployeeUsername.isPassword = false;
            this.txtManageEmployeeUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageEmployeeUsername.LineThickness = 3;
            this.txtManageEmployeeUsername.Location = new System.Drawing.Point(193, 62);
            this.txtManageEmployeeUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageEmployeeUsername.Name = "txtManageEmployeeUsername";
            this.txtManageEmployeeUsername.Size = new System.Drawing.Size(379, 33);
            this.txtManageEmployeeUsername.TabIndex = 5;
            this.txtManageEmployeeUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageEmployeeUsername.OnValueChanged += new System.EventHandler(this.txtManageEmployeeUsername_OnValueChanged);
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlManageEmployees);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(774, 645);
            this.pnlManageEmployees.ResumeLayout(false);
            this.tbcEmployee.ResumeLayout(false);
            this.tbpSearchEmployee.ResumeLayout(false);
            this.tbpSearchEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEmployee)).EndInit();
            this.tbpManageEmployee.ResumeLayout(false);
            this.tbpManageEmployee.PerformLayout();
            this.pnlManageFailAlert.ResumeLayout(false);
            this.pnlManageFailAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxManageFailAlert)).EndInit();
            this.pnlManageSuccessfulAlert.ResumeLayout(false);
            this.pnlManageSuccessfulAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxManageSuccessfulAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlManageEmployees;
        private MaterialSkin.Controls.MaterialTabSelector tbsEmployee;
        private MaterialSkin.Controls.MaterialTabControl tbcEmployee;
        private System.Windows.Forms.TabPage tbpSearchEmployee;
        private System.Windows.Forms.Label lblSearchEmployeeContainPassives;
        private Bunifu.Framework.UI.BunifuCheckbox cboxEmployeeSearchIsActive;
        private MaterialSkin.Controls.MaterialListView mlvUsers;
        private System.Windows.Forms.ColumnHeader clmNumber;
        private System.Windows.Forms.ColumnHeader clmUserName;
        private System.Windows.Forms.ColumnHeader clmFirstName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.ColumnHeader clmDepartmentName;
        private System.Windows.Forms.ColumnHeader clmRoleName;
        private System.Windows.Forms.ColumnHeader clmBorrowings;
        private System.Windows.Forms.Label lblEmployeeSearchBy;
        private Bunifu.Framework.UI.BunifuDropdown dropEmployeeSearchKey;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchEmployee;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchEmployee;
        private System.Windows.Forms.TabPage tbpManageEmployee;
        private Bunifu.Framework.UI.BunifuDropdown dropManageEmployeeActivity;
        private System.Windows.Forms.Label lblManageEmployeeActivity;
        private System.Windows.Forms.Panel pnlManageFailAlert;
        private System.Windows.Forms.Label lblManageFailAlert2;
        private System.Windows.Forms.Label lblManageFailAlert1;
        private System.Windows.Forms.PictureBox pboxManageFailAlert;
        private System.Windows.Forms.Panel pnlManageSuccessfulAlert;
        private System.Windows.Forms.Label lblManageSuccessAlert;
        private System.Windows.Forms.PictureBox pboxManageSuccessfulAlert;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageEmployeeDelete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageEmployeeConfirmPassword;
        private System.Windows.Forms.Label lblManageEmployeeConfirmPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageOpenFileDialog;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageEmployeeSubmit;
        private Bunifu.Framework.UI.BunifuDropdown dropManageEmployeeDepartment;
        private System.Windows.Forms.Label lblManageEmployeeRoleName;
        private System.Windows.Forms.Label lblManageEmployeeDepartmentName;
        private Bunifu.Framework.UI.BunifuDropdown dropManageEmployeeRole;
        private System.Windows.Forms.Label lblManageEmployeeAvatarPath;
        private System.Windows.Forms.Label lblManageEmployeeLastName;
        private System.Windows.Forms.Label lblManageEmployeeFirstName;
        private System.Windows.Forms.Label lblManageEmployeePassword;
        private System.Windows.Forms.Label lblManageEmployeeUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageEmployeeAvatarPath;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageEmployeeLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageEmployeeFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageEmployeePassword;
        private System.Windows.Forms.Label lblManageInformationTitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageEmployeeUsername;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageEmployeeUpdate;
    }
}
