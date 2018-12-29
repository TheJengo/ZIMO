namespace ZIMO.App.Forms
{
    partial class ChargedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargedForm));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.pnlMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ctrlReports = new ZIMO.App.Forms.General_Controls.ReportsControl();
            this.ctrlSettings = new ZIMO.App.Forms.General_Controls.SettingsControl();
            this.pnlLeftMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMenuRoleInfo = new System.Windows.Forms.Label();
            this.lblMenuDepartmentInfo = new System.Windows.Forms.Label();
            this.btnMenuReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlLeftMenuBottom = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMenuAvatarName = new System.Windows.Forms.Label();
            this.btnMenuLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sprMenuHorizontal = new Bunifu.Framework.UI.BunifuSeparator();
            this.pboxAvatar = new System.Windows.Forms.PictureBox();
            this.pboxZimoMinimalist = new System.Windows.Forms.PictureBox();
            this.animSlider = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.dragControlForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipseAvatar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragControlMenuBottom = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxZimoMinimalist)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.ctrlReports);
            this.pnlMain.Controls.Add(this.ctrlSettings);
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
            this.pnlMain.TabIndex = 1;
            // 
            // ctrlReports
            // 
            this.animSlider.SetDecoration(this.ctrlReports, BunifuAnimatorNS.DecorationType.None);
            this.ctrlReports.Location = new System.Drawing.Point(250, 0);
            this.ctrlReports.Name = "ctrlReports";
            this.ctrlReports.Size = new System.Drawing.Size(773, 645);
            this.ctrlReports.TabIndex = 11;
            this.ctrlReports.Visible = false;
            // 
            // ctrlSettings
            // 
            this.ctrlSettings.BackColor = System.Drawing.Color.White;
            this.animSlider.SetDecoration(this.ctrlSettings, BunifuAnimatorNS.DecorationType.None);
            this.ctrlSettings.Location = new System.Drawing.Point(250, 0);
            this.ctrlSettings.Name = "ctrlSettings";
            this.ctrlSettings.Size = new System.Drawing.Size(774, 645);
            this.ctrlSettings.TabIndex = 9;
            this.ctrlSettings.Visible = false;
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeftMenu.BackgroundImage")));
            this.pnlLeftMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeftMenu.Controls.Add(this.lblMenuRoleInfo);
            this.pnlLeftMenu.Controls.Add(this.lblMenuDepartmentInfo);
            this.pnlLeftMenu.Controls.Add(this.btnMenuReports);
            this.pnlLeftMenu.Controls.Add(this.pnlLeftMenuBottom);
            this.pnlLeftMenu.Controls.Add(this.lblMenuAvatarName);
            this.pnlLeftMenu.Controls.Add(this.btnMenuLogOut);
            this.pnlLeftMenu.Controls.Add(this.btnMenuSettings);
            this.pnlLeftMenu.Controls.Add(this.sprMenuHorizontal);
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
            this.pnlLeftMenu.TabIndex = 2;
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
            this.lblMenuRoleInfo.TabIndex = 22;
            this.lblMenuRoleInfo.Text = "Sales, System Admin";
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
            this.lblMenuDepartmentInfo.TabIndex = 21;
            this.lblMenuDepartmentInfo.Text = "Sales, System Admin";
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
            this.btnMenuReports.Location = new System.Drawing.Point(0, 175);
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
            // pnlLeftMenuBottom
            // 
            this.pnlLeftMenuBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeftMenuBottom.BackgroundImage")));
            this.pnlLeftMenuBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animSlider.SetDecoration(this.pnlLeftMenuBottom, BunifuAnimatorNS.DecorationType.None);
            this.pnlLeftMenuBottom.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLeftMenuBottom.GradientBottomRight = System.Drawing.Color.Firebrick;
            this.pnlLeftMenuBottom.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLeftMenuBottom.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLeftMenuBottom.Location = new System.Drawing.Point(0, 544);
            this.pnlLeftMenuBottom.Name = "pnlLeftMenuBottom";
            this.pnlLeftMenuBottom.Quality = 10;
            this.pnlLeftMenuBottom.Size = new System.Drawing.Size(250, 100);
            this.pnlLeftMenuBottom.TabIndex = 20;
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
            this.btnMenuLogOut.Location = new System.Drawing.Point(0, 271);
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
            this.btnMenuSettings.Location = new System.Drawing.Point(0, 223);
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
            this.pboxZimoMinimalist.TabIndex = 14;
            this.pboxZimoMinimalist.TabStop = false;
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
            // dragControlForm
            // 
            this.dragControlForm.Fixed = true;
            this.dragControlForm.Horizontal = true;
            this.dragControlForm.TargetControl = this.pnlLeftMenu;
            this.dragControlForm.Vertical = true;
            // 
            // elipseAvatar
            // 
            this.elipseAvatar.ElipseRadius = 300;
            this.elipseAvatar.TargetControl = this.pboxAvatar;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 10;
            this.elipseForm.TargetControl = this;
            // 
            // dragControlMenuBottom
            // 
            this.dragControlMenuBottom.Fixed = true;
            this.dragControlMenuBottom.Horizontal = true;
            this.dragControlMenuBottom.TargetControl = this.pnlLeftMenuBottom;
            this.dragControlMenuBottom.Vertical = true;
            // 
            // ChargedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 645);
            this.Controls.Add(this.pnlMain);
            this.animSlider.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChargedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChargedForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlLeftMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxZimoMinimalist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlMain;
        private System.Windows.Forms.PictureBox pboxZimoMinimalist;
        private General_Controls.SettingsControl ctrlSettings;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlLeftMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlLeftMenuBottom;
        private System.Windows.Forms.Label lblMenuAvatarName;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuSettings;
        private Bunifu.Framework.UI.BunifuSeparator sprMenuHorizontal;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuReports;
        private System.Windows.Forms.PictureBox pboxAvatar;
        private BunifuAnimatorNS.BunifuTransition animSlider;
        private Bunifu.Framework.UI.BunifuDragControl dragControlForm;
        private Bunifu.Framework.UI.BunifuElipse elipseAvatar;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private General_Controls.ReportsControl ctrlReports;
        private Bunifu.Framework.UI.BunifuDragControl dragControlMenuBottom;
        private System.Windows.Forms.Label lblMenuRoleInfo;
        private System.Windows.Forms.Label lblMenuDepartmentInfo;
    }
}