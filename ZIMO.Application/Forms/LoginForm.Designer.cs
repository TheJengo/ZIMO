namespace ZIMO.App.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlLoginMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblFailAlert = new System.Windows.Forms.Label();
            this.lblSuccessAlert = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.icoPassword = new System.Windows.Forms.PictureBox();
            this.icoUsername = new System.Windows.Forms.PictureBox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.imgLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.sprLogin = new Bunifu.Framework.UI.BunifuSeparator();
            this.elipseLogin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragLogin = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlLoginMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginMain
            // 
            this.pnlLoginMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLoginMain.BackgroundImage")));
            this.pnlLoginMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginMain.Controls.Add(this.lblFailAlert);
            this.pnlLoginMain.Controls.Add(this.lblSuccessAlert);
            this.pnlLoginMain.Controls.Add(this.lblForgotPassword);
            this.pnlLoginMain.Controls.Add(this.lblPassword);
            this.pnlLoginMain.Controls.Add(this.lblUsername);
            this.pnlLoginMain.Controls.Add(this.btnMinimize);
            this.pnlLoginMain.Controls.Add(this.lblLogIn);
            this.pnlLoginMain.Controls.Add(this.btnLogin);
            this.pnlLoginMain.Controls.Add(this.icoPassword);
            this.pnlLoginMain.Controls.Add(this.icoUsername);
            this.pnlLoginMain.Controls.Add(this.txtPassword);
            this.pnlLoginMain.Controls.Add(this.btnClose);
            this.pnlLoginMain.Controls.Add(this.txtUsername);
            this.pnlLoginMain.Controls.Add(this.imgLogo);
            this.pnlLoginMain.Controls.Add(this.sprLogin);
            this.pnlLoginMain.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLoginMain.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLoginMain.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLoginMain.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.pnlLoginMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginMain.Name = "pnlLoginMain";
            this.pnlLoginMain.Quality = 10;
            this.pnlLoginMain.Size = new System.Drawing.Size(820, 330);
            this.pnlLoginMain.TabIndex = 0;
            // 
            // lblFailAlert
            // 
            this.lblFailAlert.AutoSize = true;
            this.lblFailAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblFailAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFailAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.lblFailAlert.Image = ((System.Drawing.Image)(resources.GetObject("lblFailAlert.Image")));
            this.lblFailAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFailAlert.Location = new System.Drawing.Point(412, 298);
            this.lblFailAlert.Name = "lblFailAlert";
            this.lblFailAlert.Size = new System.Drawing.Size(360, 17);
            this.lblFailAlert.TabIndex = 16;
            this.lblFailAlert.Text = "      Login failed! Please, check your credentials.";
            this.lblFailAlert.Visible = false;
            // 
            // lblSuccessAlert
            // 
            this.lblSuccessAlert.AutoSize = true;
            this.lblSuccessAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSuccessAlert.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSuccessAlert.Image = ((System.Drawing.Image)(resources.GetObject("lblSuccessAlert.Image")));
            this.lblSuccessAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuccessAlert.Location = new System.Drawing.Point(512, 298);
            this.lblSuccessAlert.Name = "lblSuccessAlert";
            this.lblSuccessAlert.Size = new System.Drawing.Size(163, 17);
            this.lblSuccessAlert.TabIndex = 15;
            this.lblSuccessAlert.Text = "      Login successful!";
            this.lblSuccessAlert.Visible = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(640, 216);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(153, 17);
            this.lblForgotPassword.TabIndex = 14;
            this.lblForgotPassword.Text = "Forgot your password?";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblPassword.Location = new System.Drawing.Point(387, 158);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblUsername.Location = new System.Drawing.Point(387, 83);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 17);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(757, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblLogIn.Location = new System.Drawing.Point(385, 33);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(78, 25);
            this.lblLogIn.TabIndex = 9;
            this.lblLogIn.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "LOG IN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = null;
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(390, 242);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(407, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // icoPassword
            // 
            this.icoPassword.BackColor = System.Drawing.Color.Transparent;
            this.icoPassword.Image = ((System.Drawing.Image)(resources.GetObject("icoPassword.Image")));
            this.icoPassword.Location = new System.Drawing.Point(390, 186);
            this.icoPassword.Name = "icoPassword";
            this.icoPassword.Size = new System.Drawing.Size(24, 24);
            this.icoPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icoPassword.TabIndex = 6;
            this.icoPassword.TabStop = false;
            // 
            // icoUsername
            // 
            this.icoUsername.BackColor = System.Drawing.Color.Transparent;
            this.icoUsername.Image = ((System.Drawing.Image)(resources.GetObject("icoUsername.Image")));
            this.icoUsername.Location = new System.Drawing.Point(390, 111);
            this.icoUsername.Name = "icoUsername";
            this.icoUsername.Size = new System.Drawing.Size(24, 24);
            this.icoUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icoUsername.TabIndex = 5;
            this.icoUsername.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(254)))));
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.HintText = "          Password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(418, 179);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(379, 33);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(787, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(229)))), ((int)(((byte)(254)))));
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.HintText = "Username";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(418, 104);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(379, 33);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.OnValueChanged += new System.EventHandler(this.txtUsername_OnValueChanged);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.ImageActive = null;
            this.imgLogo.Location = new System.Drawing.Point(30, 75);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(300, 200);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            this.imgLogo.Zoom = 0;
            // 
            // sprLogin
            // 
            this.sprLogin.BackColor = System.Drawing.Color.Transparent;
            this.sprLogin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.sprLogin.LineThickness = 2;
            this.sprLogin.Location = new System.Drawing.Point(270, 15);
            this.sprLogin.Name = "sprLogin";
            this.sprLogin.Size = new System.Drawing.Size(185, 300);
            this.sprLogin.TabIndex = 1;
            this.sprLogin.Transparency = 255;
            this.sprLogin.Vertical = true;
            // 
            // elipseLogin
            // 
            this.elipseLogin.ElipseRadius = 10;
            this.elipseLogin.TargetControl = this;
            // 
            // dragLogin
            // 
            this.dragLogin.Fixed = true;
            this.dragLogin.Horizontal = true;
            this.dragLogin.TargetControl = this.pnlLoginMain;
            this.dragLogin.Vertical = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 330);
            this.Controls.Add(this.pnlLoginMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLoginMain.ResumeLayout(false);
            this.pnlLoginMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlLoginMain;
        private Bunifu.Framework.UI.BunifuImageButton imgLogo;
        private Bunifu.Framework.UI.BunifuElipse elipseLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuSeparator sprLogin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl dragLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.PictureBox icoPassword;
        private System.Windows.Forms.PictureBox icoUsername;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private System.Windows.Forms.Label lblLogIn;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSuccessAlert;
        private System.Windows.Forms.Label lblFailAlert;
    }
}