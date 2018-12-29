namespace ZIMO.App.Forms.Admin_Controls
{
    partial class DepartmentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentControl));
            this.pnlManageDepartments = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblManageDepartmentsAddFailAlert = new System.Windows.Forms.Label();
            this.lblManageDepartmentsAddSuccessfulAlert = new System.Windows.Forms.Label();
            this.lblManageDepartmentUpdateFailAlert = new System.Windows.Forms.Label();
            this.lblManageDepartmentUpdateSuccessAlert = new System.Windows.Forms.Label();
            this.btnManageDepartmentsAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManageDepartmentsUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManageDepartmentsDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblManageDepartmentAdd = new System.Windows.Forms.Label();
            this.txtManageDepartmentsAdd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblManageDepartmentAddDepartmentTitle = new System.Windows.Forms.Label();
            this.lblManageDepartmentUpdateTitle = new System.Windows.Forms.Label();
            this.lblManageDepartmentUpdatename = new System.Windows.Forms.Label();
            this.txtManageDepartmentUpdate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSearchDepartment = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtManageDepartmentsSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblManageDepartmentsTitle = new System.Windows.Forms.Label();
            this.mlvDepartments = new MaterialSkin.Controls.MaterialListView();
            this.clmDepartmentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmManageDepartmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmManageUserCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlManageDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManageDepartments
            // 
            this.pnlManageDepartments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManageDepartments.BackgroundImage")));
            this.pnlManageDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentsAddFailAlert);
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentsAddSuccessfulAlert);
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentUpdateFailAlert);
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentUpdateSuccessAlert);
            this.pnlManageDepartments.Controls.Add(this.btnManageDepartmentsAdd);
            this.pnlManageDepartments.Controls.Add(this.btnManageDepartmentsUpdate);
            this.pnlManageDepartments.Controls.Add(this.btnManageDepartmentsDelete);
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentAdd);
            this.pnlManageDepartments.Controls.Add(this.txtManageDepartmentsAdd);
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentAddDepartmentTitle);
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentUpdateTitle);
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentUpdatename);
            this.pnlManageDepartments.Controls.Add(this.txtManageDepartmentUpdate);
            this.pnlManageDepartments.Controls.Add(this.btnSearchDepartment);
            this.pnlManageDepartments.Controls.Add(this.txtManageDepartmentsSearch);
            this.pnlManageDepartments.Controls.Add(this.lblManageDepartmentsTitle);
            this.pnlManageDepartments.Controls.Add(this.mlvDepartments);
            this.pnlManageDepartments.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlManageDepartments.GradientBottomRight = System.Drawing.Color.White;
            this.pnlManageDepartments.GradientTopLeft = System.Drawing.Color.White;
            this.pnlManageDepartments.GradientTopRight = System.Drawing.Color.White;
            this.pnlManageDepartments.Location = new System.Drawing.Point(-1, 0);
            this.pnlManageDepartments.Name = "pnlManageDepartments";
            this.pnlManageDepartments.Quality = 10;
            this.pnlManageDepartments.Size = new System.Drawing.Size(774, 645);
            this.pnlManageDepartments.TabIndex = 8;
            // 
            // lblManageDepartmentsAddFailAlert
            // 
            this.lblManageDepartmentsAddFailAlert.AutoSize = true;
            this.lblManageDepartmentsAddFailAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentsAddFailAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageDepartmentsAddFailAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.lblManageDepartmentsAddFailAlert.Image = ((System.Drawing.Image)(resources.GetObject("lblManageDepartmentsAddFailAlert.Image")));
            this.lblManageDepartmentsAddFailAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageDepartmentsAddFailAlert.Location = new System.Drawing.Point(490, 598);
            this.lblManageDepartmentsAddFailAlert.Name = "lblManageDepartmentsAddFailAlert";
            this.lblManageDepartmentsAddFailAlert.Size = new System.Drawing.Size(86, 17);
            this.lblManageDepartmentsAddFailAlert.TabIndex = 32;
            this.lblManageDepartmentsAddFailAlert.Text = "      Failed!";
            this.lblManageDepartmentsAddFailAlert.Visible = false;
            // 
            // lblManageDepartmentsAddSuccessfulAlert
            // 
            this.lblManageDepartmentsAddSuccessfulAlert.AutoSize = true;
            this.lblManageDepartmentsAddSuccessfulAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentsAddSuccessfulAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageDepartmentsAddSuccessfulAlert.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblManageDepartmentsAddSuccessfulAlert.Image = ((System.Drawing.Image)(resources.GetObject("lblManageDepartmentsAddSuccessfulAlert.Image")));
            this.lblManageDepartmentsAddSuccessfulAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageDepartmentsAddSuccessfulAlert.Location = new System.Drawing.Point(478, 598);
            this.lblManageDepartmentsAddSuccessfulAlert.Name = "lblManageDepartmentsAddSuccessfulAlert";
            this.lblManageDepartmentsAddSuccessfulAlert.Size = new System.Drawing.Size(98, 17);
            this.lblManageDepartmentsAddSuccessfulAlert.TabIndex = 31;
            this.lblManageDepartmentsAddSuccessfulAlert.Text = "     Updated!";
            this.lblManageDepartmentsAddSuccessfulAlert.Visible = false;
            // 
            // lblManageDepartmentUpdateFailAlert
            // 
            this.lblManageDepartmentUpdateFailAlert.AutoSize = true;
            this.lblManageDepartmentUpdateFailAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentUpdateFailAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageDepartmentUpdateFailAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.lblManageDepartmentUpdateFailAlert.Image = ((System.Drawing.Image)(resources.GetObject("lblManageDepartmentUpdateFailAlert.Image")));
            this.lblManageDepartmentUpdateFailAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageDepartmentUpdateFailAlert.Location = new System.Drawing.Point(50, 598);
            this.lblManageDepartmentUpdateFailAlert.Name = "lblManageDepartmentUpdateFailAlert";
            this.lblManageDepartmentUpdateFailAlert.Size = new System.Drawing.Size(86, 17);
            this.lblManageDepartmentUpdateFailAlert.TabIndex = 30;
            this.lblManageDepartmentUpdateFailAlert.Text = "      Failed!";
            this.lblManageDepartmentUpdateFailAlert.Visible = false;
            // 
            // lblManageDepartmentUpdateSuccessAlert
            // 
            this.lblManageDepartmentUpdateSuccessAlert.AutoSize = true;
            this.lblManageDepartmentUpdateSuccessAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentUpdateSuccessAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageDepartmentUpdateSuccessAlert.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblManageDepartmentUpdateSuccessAlert.Image = ((System.Drawing.Image)(resources.GetObject("lblManageDepartmentUpdateSuccessAlert.Image")));
            this.lblManageDepartmentUpdateSuccessAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageDepartmentUpdateSuccessAlert.Location = new System.Drawing.Point(38, 598);
            this.lblManageDepartmentUpdateSuccessAlert.Name = "lblManageDepartmentUpdateSuccessAlert";
            this.lblManageDepartmentUpdateSuccessAlert.Size = new System.Drawing.Size(98, 17);
            this.lblManageDepartmentUpdateSuccessAlert.TabIndex = 29;
            this.lblManageDepartmentUpdateSuccessAlert.Text = "     Updated!";
            this.lblManageDepartmentUpdateSuccessAlert.Visible = false;
            // 
            // btnManageDepartmentsAdd
            // 
            this.btnManageDepartmentsAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageDepartmentsAdd.BorderRadius = 0;
            this.btnManageDepartmentsAdd.ButtonText = "ADD";
            this.btnManageDepartmentsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageDepartmentsAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageDepartmentsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageDepartmentsAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageDepartmentsAdd.Iconimage = null;
            this.btnManageDepartmentsAdd.Iconimage_right = null;
            this.btnManageDepartmentsAdd.Iconimage_right_Selected = null;
            this.btnManageDepartmentsAdd.Iconimage_Selected = null;
            this.btnManageDepartmentsAdd.IconMarginLeft = 0;
            this.btnManageDepartmentsAdd.IconMarginRight = 0;
            this.btnManageDepartmentsAdd.IconRightVisible = false;
            this.btnManageDepartmentsAdd.IconRightZoom = 0D;
            this.btnManageDepartmentsAdd.IconVisible = false;
            this.btnManageDepartmentsAdd.IconZoom = 90D;
            this.btnManageDepartmentsAdd.IsTab = false;
            this.btnManageDepartmentsAdd.Location = new System.Drawing.Point(601, 578);
            this.btnManageDepartmentsAdd.Name = "btnManageDepartmentsAdd";
            this.btnManageDepartmentsAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageDepartmentsAdd.selected = false;
            this.btnManageDepartmentsAdd.Size = new System.Drawing.Size(142, 48);
            this.btnManageDepartmentsAdd.TabIndex = 28;
            this.btnManageDepartmentsAdd.Text = "ADD";
            this.btnManageDepartmentsAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageDepartmentsAdd.Textcolor = System.Drawing.Color.White;
            this.btnManageDepartmentsAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDepartmentsAdd.Click += new System.EventHandler(this.btnManageDepartmentsAdd_Click);
            // 
            // btnManageDepartmentsUpdate
            // 
            this.btnManageDepartmentsUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageDepartmentsUpdate.BorderRadius = 0;
            this.btnManageDepartmentsUpdate.ButtonText = "UPDATE";
            this.btnManageDepartmentsUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageDepartmentsUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageDepartmentsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageDepartmentsUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageDepartmentsUpdate.Iconimage = null;
            this.btnManageDepartmentsUpdate.Iconimage_right = null;
            this.btnManageDepartmentsUpdate.Iconimage_right_Selected = null;
            this.btnManageDepartmentsUpdate.Iconimage_Selected = null;
            this.btnManageDepartmentsUpdate.IconMarginLeft = 0;
            this.btnManageDepartmentsUpdate.IconMarginRight = 0;
            this.btnManageDepartmentsUpdate.IconRightVisible = false;
            this.btnManageDepartmentsUpdate.IconRightZoom = 0D;
            this.btnManageDepartmentsUpdate.IconVisible = false;
            this.btnManageDepartmentsUpdate.IconZoom = 90D;
            this.btnManageDepartmentsUpdate.IsTab = false;
            this.btnManageDepartmentsUpdate.Location = new System.Drawing.Point(161, 578);
            this.btnManageDepartmentsUpdate.Name = "btnManageDepartmentsUpdate";
            this.btnManageDepartmentsUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageDepartmentsUpdate.selected = false;
            this.btnManageDepartmentsUpdate.Size = new System.Drawing.Size(97, 48);
            this.btnManageDepartmentsUpdate.TabIndex = 27;
            this.btnManageDepartmentsUpdate.Text = "UPDATE";
            this.btnManageDepartmentsUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageDepartmentsUpdate.Textcolor = System.Drawing.Color.White;
            this.btnManageDepartmentsUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDepartmentsUpdate.Click += new System.EventHandler(this.btnManageDepartmentsUpdate_Click);
            // 
            // btnManageDepartmentsDelete
            // 
            this.btnManageDepartmentsDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnManageDepartmentsDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnManageDepartmentsDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageDepartmentsDelete.BorderRadius = 0;
            this.btnManageDepartmentsDelete.ButtonText = "DELETE";
            this.btnManageDepartmentsDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageDepartmentsDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageDepartmentsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageDepartmentsDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageDepartmentsDelete.Iconimage = null;
            this.btnManageDepartmentsDelete.Iconimage_right = null;
            this.btnManageDepartmentsDelete.Iconimage_right_Selected = null;
            this.btnManageDepartmentsDelete.Iconimage_Selected = null;
            this.btnManageDepartmentsDelete.IconMarginLeft = 0;
            this.btnManageDepartmentsDelete.IconMarginRight = 0;
            this.btnManageDepartmentsDelete.IconRightVisible = false;
            this.btnManageDepartmentsDelete.IconRightZoom = 0D;
            this.btnManageDepartmentsDelete.IconVisible = false;
            this.btnManageDepartmentsDelete.IconZoom = 90D;
            this.btnManageDepartmentsDelete.IsTab = false;
            this.btnManageDepartmentsDelete.Location = new System.Drawing.Point(264, 578);
            this.btnManageDepartmentsDelete.Name = "btnManageDepartmentsDelete";
            this.btnManageDepartmentsDelete.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnManageDepartmentsDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnManageDepartmentsDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageDepartmentsDelete.selected = false;
            this.btnManageDepartmentsDelete.Size = new System.Drawing.Size(75, 48);
            this.btnManageDepartmentsDelete.TabIndex = 26;
            this.btnManageDepartmentsDelete.Text = "DELETE";
            this.btnManageDepartmentsDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageDepartmentsDelete.Textcolor = System.Drawing.Color.White;
            this.btnManageDepartmentsDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDepartmentsDelete.Click += new System.EventHandler(this.btnManageDepartmentsDelete_Click);
            // 
            // lblManageDepartmentAdd
            // 
            this.lblManageDepartmentAdd.AutoSize = true;
            this.lblManageDepartmentAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageDepartmentAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageDepartmentAdd.Location = new System.Drawing.Point(416, 554);
            this.lblManageDepartmentAdd.Name = "lblManageDepartmentAdd";
            this.lblManageDepartmentAdd.Size = new System.Drawing.Size(178, 17);
            this.lblManageDepartmentAdd.TabIndex = 25;
            this.lblManageDepartmentAdd.Text = "New Department Name:";
            // 
            // txtManageDepartmentsAdd
            // 
            this.txtManageDepartmentsAdd.BackColor = System.Drawing.Color.White;
            this.txtManageDepartmentsAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageDepartmentsAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageDepartmentsAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageDepartmentsAdd.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageDepartmentsAdd.HintText = "Department Name";
            this.txtManageDepartmentsAdd.isPassword = false;
            this.txtManageDepartmentsAdd.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentsAdd.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentsAdd.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentsAdd.LineThickness = 3;
            this.txtManageDepartmentsAdd.Location = new System.Drawing.Point(601, 538);
            this.txtManageDepartmentsAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageDepartmentsAdd.Name = "txtManageDepartmentsAdd";
            this.txtManageDepartmentsAdd.Size = new System.Drawing.Size(142, 33);
            this.txtManageDepartmentsAdd.TabIndex = 24;
            this.txtManageDepartmentsAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageDepartmentsAdd.OnValueChanged += new System.EventHandler(this.txtManageDepartmentsAdd_OnValueChanged);
            // 
            // lblManageDepartmentAddDepartmentTitle
            // 
            this.lblManageDepartmentAddDepartmentTitle.AutoSize = true;
            this.lblManageDepartmentAddDepartmentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentAddDepartmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManageDepartmentAddDepartmentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageDepartmentAddDepartmentTitle.Location = new System.Drawing.Point(415, 503);
            this.lblManageDepartmentAddDepartmentTitle.Name = "lblManageDepartmentAddDepartmentTitle";
            this.lblManageDepartmentAddDepartmentTitle.Size = new System.Drawing.Size(161, 24);
            this.lblManageDepartmentAddDepartmentTitle.TabIndex = 23;
            this.lblManageDepartmentAddDepartmentTitle.Text = "Add Department";
            // 
            // lblManageDepartmentUpdateTitle
            // 
            this.lblManageDepartmentUpdateTitle.AutoSize = true;
            this.lblManageDepartmentUpdateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentUpdateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManageDepartmentUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageDepartmentUpdateTitle.Location = new System.Drawing.Point(17, 503);
            this.lblManageDepartmentUpdateTitle.Name = "lblManageDepartmentUpdateTitle";
            this.lblManageDepartmentUpdateTitle.Size = new System.Drawing.Size(255, 24);
            this.lblManageDepartmentUpdateTitle.TabIndex = 22;
            this.lblManageDepartmentUpdateTitle.Text = "Update/Delete Department";
            // 
            // lblManageDepartmentUpdatename
            // 
            this.lblManageDepartmentUpdatename.AutoSize = true;
            this.lblManageDepartmentUpdatename.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentUpdatename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageDepartmentUpdatename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageDepartmentUpdatename.Location = new System.Drawing.Point(11, 554);
            this.lblManageDepartmentUpdatename.Name = "lblManageDepartmentUpdatename";
            this.lblManageDepartmentUpdatename.Size = new System.Drawing.Size(143, 17);
            this.lblManageDepartmentUpdatename.TabIndex = 21;
            this.lblManageDepartmentUpdatename.Text = "Department Name:";
            // 
            // txtManageDepartmentUpdate
            // 
            this.txtManageDepartmentUpdate.BackColor = System.Drawing.Color.White;
            this.txtManageDepartmentUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageDepartmentUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageDepartmentUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageDepartmentUpdate.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageDepartmentUpdate.HintText = "Department Name";
            this.txtManageDepartmentUpdate.isPassword = false;
            this.txtManageDepartmentUpdate.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentUpdate.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentUpdate.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentUpdate.LineThickness = 3;
            this.txtManageDepartmentUpdate.Location = new System.Drawing.Point(161, 538);
            this.txtManageDepartmentUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageDepartmentUpdate.Name = "txtManageDepartmentUpdate";
            this.txtManageDepartmentUpdate.Size = new System.Drawing.Size(178, 33);
            this.txtManageDepartmentUpdate.TabIndex = 17;
            this.txtManageDepartmentUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageDepartmentUpdate.OnValueChanged += new System.EventHandler(this.txtManageDepartmentUpdate_OnValueChanged);
            // 
            // btnSearchDepartment
            // 
            this.btnSearchDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDepartment.Image")));
            this.btnSearchDepartment.ImageActive = null;
            this.btnSearchDepartment.Location = new System.Drawing.Point(727, 5);
            this.btnSearchDepartment.Name = "btnSearchDepartment";
            this.btnSearchDepartment.Size = new System.Drawing.Size(40, 33);
            this.btnSearchDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchDepartment.TabIndex = 16;
            this.btnSearchDepartment.TabStop = false;
            this.btnSearchDepartment.Zoom = 4;
            this.btnSearchDepartment.Click += new System.EventHandler(this.txtManageDepartmentsSearch_OnValueChanged);
            // 
            // txtManageDepartmentsSearch
            // 
            this.txtManageDepartmentsSearch.BackColor = System.Drawing.Color.White;
            this.txtManageDepartmentsSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageDepartmentsSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageDepartmentsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageDepartmentsSearch.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageDepartmentsSearch.HintText = "Search...";
            this.txtManageDepartmentsSearch.isPassword = false;
            this.txtManageDepartmentsSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentsSearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentsSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageDepartmentsSearch.LineThickness = 3;
            this.txtManageDepartmentsSearch.Location = new System.Drawing.Point(143, 5);
            this.txtManageDepartmentsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageDepartmentsSearch.Name = "txtManageDepartmentsSearch";
            this.txtManageDepartmentsSearch.Size = new System.Drawing.Size(584, 33);
            this.txtManageDepartmentsSearch.TabIndex = 15;
            this.txtManageDepartmentsSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageDepartmentsSearch.OnValueChanged += new System.EventHandler(this.txtManageDepartmentsSearch_OnValueChanged);
            // 
            // lblManageDepartmentsTitle
            // 
            this.lblManageDepartmentsTitle.AutoSize = true;
            this.lblManageDepartmentsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDepartmentsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManageDepartmentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageDepartmentsTitle.Location = new System.Drawing.Point(3, 14);
            this.lblManageDepartmentsTitle.Name = "lblManageDepartmentsTitle";
            this.lblManageDepartmentsTitle.Size = new System.Drawing.Size(133, 24);
            this.lblManageDepartmentsTitle.TabIndex = 14;
            this.lblManageDepartmentsTitle.Text = "Departments:";
            // 
            // mlvDepartments
            // 
            this.mlvDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvDepartments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDepartmentId,
            this.clmManageDepartmentName,
            this.clmManageUserCount});
            this.mlvDepartments.Depth = 0;
            this.mlvDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvDepartments.FullRowSelect = true;
            this.mlvDepartments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvDepartments.Location = new System.Drawing.Point(0, 45);
            this.mlvDepartments.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvDepartments.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvDepartments.Name = "mlvDepartments";
            this.mlvDepartments.OwnerDraw = true;
            this.mlvDepartments.Size = new System.Drawing.Size(771, 434);
            this.mlvDepartments.TabIndex = 0;
            this.mlvDepartments.UseCompatibleStateImageBehavior = false;
            this.mlvDepartments.View = System.Windows.Forms.View.Details;
            this.mlvDepartments.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvDepartments_ItemSelectionChanged);
            // 
            // clmDepartmentId
            // 
            this.clmDepartmentId.Text = "Department Id";
            this.clmDepartmentId.Width = 250;
            // 
            // clmManageDepartmentName
            // 
            this.clmManageDepartmentName.Text = "Department Name";
            this.clmManageDepartmentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmManageDepartmentName.Width = 250;
            // 
            // clmManageUserCount
            // 
            this.clmManageUserCount.Text = "Number Of Users";
            this.clmManageUserCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmManageUserCount.Width = 250;
            // 
            // DepartmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlManageDepartments);
            this.Name = "DepartmentControl";
            this.Size = new System.Drawing.Size(774, 645);
            this.pnlManageDepartments.ResumeLayout(false);
            this.pnlManageDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlManageDepartments;
        private System.Windows.Forms.Label lblManageDepartmentsAddFailAlert;
        private System.Windows.Forms.Label lblManageDepartmentsAddSuccessfulAlert;
        private System.Windows.Forms.Label lblManageDepartmentUpdateFailAlert;
        private System.Windows.Forms.Label lblManageDepartmentUpdateSuccessAlert;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageDepartmentsAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageDepartmentsUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageDepartmentsDelete;
        private System.Windows.Forms.Label lblManageDepartmentAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageDepartmentsAdd;
        private System.Windows.Forms.Label lblManageDepartmentAddDepartmentTitle;
        private System.Windows.Forms.Label lblManageDepartmentUpdateTitle;
        private System.Windows.Forms.Label lblManageDepartmentUpdatename;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageDepartmentUpdate;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchDepartment;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageDepartmentsSearch;
        private System.Windows.Forms.Label lblManageDepartmentsTitle;
        private MaterialSkin.Controls.MaterialListView mlvDepartments;
        private System.Windows.Forms.ColumnHeader clmDepartmentId;
        private System.Windows.Forms.ColumnHeader clmManageDepartmentName;
        private System.Windows.Forms.ColumnHeader clmManageUserCount;
    }
}
