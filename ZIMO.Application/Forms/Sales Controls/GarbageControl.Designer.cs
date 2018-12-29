namespace ZIMO.App.Forms.Sales_Controls
{
    partial class GarbageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarbageControl));
            this.pnlManageGarbage = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnManageGarbageSearchBy = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtManageGarbageSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dropManageGarbageSearchBy = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblManageGarbageSearchByTitle = new System.Windows.Forms.Label();
            this.mlvManageGarbage = new MaterialSkin.Controls.MaterialListView();
            this.clmManageGarbageCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmManageGarbageItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmManageGarbageCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmManageGarbageQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmManageGarbageCreatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlManageGarbage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageGarbageSearchBy)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManageGarbage
            // 
            this.pnlManageGarbage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManageGarbage.BackgroundImage")));
            this.pnlManageGarbage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlManageGarbage.Controls.Add(this.btnManageGarbageSearchBy);
            this.pnlManageGarbage.Controls.Add(this.txtManageGarbageSearch);
            this.pnlManageGarbage.Controls.Add(this.dropManageGarbageSearchBy);
            this.pnlManageGarbage.Controls.Add(this.lblManageGarbageSearchByTitle);
            this.pnlManageGarbage.Controls.Add(this.mlvManageGarbage);
            this.pnlManageGarbage.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlManageGarbage.GradientBottomRight = System.Drawing.Color.White;
            this.pnlManageGarbage.GradientTopLeft = System.Drawing.Color.White;
            this.pnlManageGarbage.GradientTopRight = System.Drawing.Color.White;
            this.pnlManageGarbage.Location = new System.Drawing.Point(0, 0);
            this.pnlManageGarbage.Name = "pnlManageGarbage";
            this.pnlManageGarbage.Quality = 10;
            this.pnlManageGarbage.Size = new System.Drawing.Size(774, 645);
            this.pnlManageGarbage.TabIndex = 39;
            // 
            // btnManageGarbageSearchBy
            // 
            this.btnManageGarbageSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.btnManageGarbageSearchBy.Image = ((System.Drawing.Image)(resources.GetObject("btnManageGarbageSearchBy.Image")));
            this.btnManageGarbageSearchBy.ImageActive = null;
            this.btnManageGarbageSearchBy.Location = new System.Drawing.Point(726, 4);
            this.btnManageGarbageSearchBy.Name = "btnManageGarbageSearchBy";
            this.btnManageGarbageSearchBy.Size = new System.Drawing.Size(40, 33);
            this.btnManageGarbageSearchBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnManageGarbageSearchBy.TabIndex = 29;
            this.btnManageGarbageSearchBy.TabStop = false;
            this.btnManageGarbageSearchBy.Zoom = 4;
            this.btnManageGarbageSearchBy.Click += new System.EventHandler(this.txtManageGarbageSearch_OnValueChanged);
            // 
            // txtManageGarbageSearch
            // 
            this.txtManageGarbageSearch.BackColor = System.Drawing.Color.White;
            this.txtManageGarbageSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManageGarbageSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtManageGarbageSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManageGarbageSearch.HintForeColor = System.Drawing.Color.DimGray;
            this.txtManageGarbageSearch.HintText = "Search...";
            this.txtManageGarbageSearch.isPassword = false;
            this.txtManageGarbageSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageGarbageSearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageGarbageSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtManageGarbageSearch.LineThickness = 3;
            this.txtManageGarbageSearch.Location = new System.Drawing.Point(275, 2);
            this.txtManageGarbageSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtManageGarbageSearch.Name = "txtManageGarbageSearch";
            this.txtManageGarbageSearch.Size = new System.Drawing.Size(450, 33);
            this.txtManageGarbageSearch.TabIndex = 28;
            this.txtManageGarbageSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManageGarbageSearch.OnValueChanged += new System.EventHandler(this.txtManageGarbageSearch_OnValueChanged);
            // 
            // dropManageGarbageSearchBy
            // 
            this.dropManageGarbageSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.dropManageGarbageSearchBy.BorderRadius = 3;
            this.dropManageGarbageSearchBy.DisabledColor = System.Drawing.Color.Gray;
            this.dropManageGarbageSearchBy.ForeColor = System.Drawing.Color.White;
            this.dropManageGarbageSearchBy.Items = new string[] {
        "Name",
        "CompanyName"};
            this.dropManageGarbageSearchBy.Location = new System.Drawing.Point(118, 2);
            this.dropManageGarbageSearchBy.Name = "dropManageGarbageSearchBy";
            this.dropManageGarbageSearchBy.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropManageGarbageSearchBy.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropManageGarbageSearchBy.selectedIndex = 0;
            this.dropManageGarbageSearchBy.Size = new System.Drawing.Size(151, 35);
            this.dropManageGarbageSearchBy.TabIndex = 27;
            this.dropManageGarbageSearchBy.onItemSelected += new System.EventHandler(this.dropManageGarbageSearchBy_onItemSelected);
            // 
            // lblManageGarbageSearchByTitle
            // 
            this.lblManageGarbageSearchByTitle.AutoSize = true;
            this.lblManageGarbageSearchByTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblManageGarbageSearchByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManageGarbageSearchByTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblManageGarbageSearchByTitle.Location = new System.Drawing.Point(2, 6);
            this.lblManageGarbageSearchByTitle.Name = "lblManageGarbageSearchByTitle";
            this.lblManageGarbageSearchByTitle.Size = new System.Drawing.Size(96, 24);
            this.lblManageGarbageSearchByTitle.TabIndex = 26;
            this.lblManageGarbageSearchByTitle.Text = "Garbage:";
            // 
            // mlvManageGarbage
            // 
            this.mlvManageGarbage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvManageGarbage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmManageGarbageCount,
            this.clmManageGarbageItemName,
            this.clmManageGarbageCompanyName,
            this.clmManageGarbageQuantity,
            this.clmManageGarbageCreatedAt});
            this.mlvManageGarbage.Depth = 0;
            this.mlvManageGarbage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvManageGarbage.FullRowSelect = true;
            this.mlvManageGarbage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvManageGarbage.Location = new System.Drawing.Point(0, 41);
            this.mlvManageGarbage.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvManageGarbage.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvManageGarbage.MultiSelect = false;
            this.mlvManageGarbage.Name = "mlvManageGarbage";
            this.mlvManageGarbage.OwnerDraw = true;
            this.mlvManageGarbage.Size = new System.Drawing.Size(769, 604);
            this.mlvManageGarbage.TabIndex = 20;
            this.mlvManageGarbage.UseCompatibleStateImageBehavior = false;
            this.mlvManageGarbage.View = System.Windows.Forms.View.Details;
            // 
            // clmManageGarbageCount
            // 
            this.clmManageGarbageCount.Text = "#";
            this.clmManageGarbageCount.Width = 50;
            // 
            // clmManageGarbageItemName
            // 
            this.clmManageGarbageItemName.Text = "Name";
            this.clmManageGarbageItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmManageGarbageItemName.Width = 200;
            // 
            // clmManageGarbageCompanyName
            // 
            this.clmManageGarbageCompanyName.Text = "Company Name";
            this.clmManageGarbageCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmManageGarbageCompanyName.Width = 200;
            // 
            // clmManageGarbageQuantity
            // 
            this.clmManageGarbageQuantity.Text = "Quantity";
            this.clmManageGarbageQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmManageGarbageQuantity.Width = 100;
            // 
            // clmManageGarbageCreatedAt
            // 
            this.clmManageGarbageCreatedAt.Text = "Created At";
            this.clmManageGarbageCreatedAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmManageGarbageCreatedAt.Width = 200;
            // 
            // GarbageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlManageGarbage);
            this.Name = "GarbageControl";
            this.Size = new System.Drawing.Size(774, 645);
            this.pnlManageGarbage.ResumeLayout(false);
            this.pnlManageGarbage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageGarbageSearchBy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlManageGarbage;
        private Bunifu.Framework.UI.BunifuImageButton btnManageGarbageSearchBy;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtManageGarbageSearch;
        private Bunifu.Framework.UI.BunifuDropdown dropManageGarbageSearchBy;
        private System.Windows.Forms.Label lblManageGarbageSearchByTitle;
        private MaterialSkin.Controls.MaterialListView mlvManageGarbage;
        private System.Windows.Forms.ColumnHeader clmManageGarbageCount;
        private System.Windows.Forms.ColumnHeader clmManageGarbageItemName;
        private System.Windows.Forms.ColumnHeader clmManageGarbageCompanyName;
        private System.Windows.Forms.ColumnHeader clmManageGarbageQuantity;
        private System.Windows.Forms.ColumnHeader clmManageGarbageCreatedAt;
    }
}
