namespace ZIMO.App.Forms.Sales_Controls
{
    partial class ItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemControl));
            this.pnlManageItems = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tbcManageItems = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpBorrowItem = new System.Windows.Forms.TabPage();
            this.tbcBorrow = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpSearchBorrowItem = new System.Windows.Forms.TabPage();
            this.btnSearchBorrowItem = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchBorrowItem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dropSearchBorrowItemBy = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblSearchBorrowItemSearchBy = new System.Windows.Forms.Label();
            this.mlvSearchBorrowItem = new MaterialSkin.Controls.MaterialListView();
            this.clmSearchBorrowItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSearchBorrowItemDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSearchBorrowItemStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSearchBorrowItemBorroweds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpSelectBorrowStock = new System.Windows.Forms.TabPage();
            this.btnSearchBorrowStock = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchBorrowStock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblSearchBorrowStockSearchByTitle = new System.Windows.Forms.Label();
            this.mlvSearchBorrowStock = new MaterialSkin.Controls.MaterialListView();
            this.clmSelectBorrowStockCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowStockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowStockCreatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowStockUpdatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpSelectBorrowerUser = new System.Windows.Forms.TabPage();
            this.mlvSelectBorrowerUsers = new MaterialSkin.Controls.MaterialListView();
            this.clmSelectBorrowerCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowerUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowerFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowerLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowerDepartmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowerRoleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectBorrowerBorrows = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchBorrower = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchBorrower = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dropSelectBorrowerUserDepartment = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblSelectBorrowerDepartment = new System.Windows.Forms.Label();
            this.tbpAcceptBorrowing = new System.Windows.Forms.TabPage();
            this.pnlAcceptBorrowingFailAlert = new System.Windows.Forms.Panel();
            this.lblAcceptBorrowingFailAlert2 = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingFailAlert1 = new System.Windows.Forms.Label();
            this.pboxAcceptBorrowingFailAlert = new System.Windows.Forms.PictureBox();
            this.btnAcceptBorrowingCharge = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblAcceptBorrowingAlreadyBorrowed = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingDepartmentName = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingFullName = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingUsername = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingBorrowed = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingInStock = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingItemName = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingItemId = new System.Windows.Forms.Label();
            this.dropBorrowItemCount = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblAcceptBorrowingBorrowedQuantityTitle = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingBorrowerDetailsBorrowed = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingBorrowerDetailsDepartment = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingBorrowerDetailsFirstName = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingBorrowerDetailsUsername = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingBorrowerDetailsTitle = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingItemDetailsBorrowed = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingItemDetailsInStock = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingItemDetailsItemName = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingItemDetailsItemId = new System.Windows.Forms.Label();
            this.lblAcceptBorrowingItemDetailsTitle = new System.Windows.Forms.Label();
            this.tbsManageBorrow = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbpRefund = new System.Windows.Forms.TabPage();
            this.tbcManageRefund = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpSelectRefunder = new System.Windows.Forms.TabPage();
            this.dropSelectRefunderDepartment = new Bunifu.Framework.UI.BunifuDropdown();
            this.mlvSelectRefunderUser = new MaterialSkin.Controls.MaterialListView();
            this.clmBorrowerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBorrowerUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBorrowerFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBorrowerDepartmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNumberOfBorrows = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNumberOfDifferentBorrows = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelectRefunder = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSelectRefunder = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dropSelectRefunderSearchBy = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblSelectBorrowerSearchByTitle = new System.Windows.Forms.Label();
            this.tbpSelectRefundedItem = new System.Windows.Forms.TabPage();
            this.btnSearchRefundItem = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchRefundItem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dropSelectRefundItemSearchBy = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblSearchRefundItemSearchByTitle = new System.Windows.Forms.Label();
            this.mlvSelectRefundItemStock = new MaterialSkin.Controls.MaterialListView();
            this.clmSelectRefundItemCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectRefundItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectRefundItemCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectRefundItemBorrowings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSelectRefundItemBorrowedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpAcceptRefund = new System.Windows.Forms.TabPage();
            this.lblAcceptRefundOperationSuccessfulAlert = new System.Windows.Forms.Label();
            this.lblAcceptRefundItemAddedAlert = new System.Windows.Forms.Label();
            this.lblAcceptRefundItemRemovedAlert = new System.Windows.Forms.Label();
            this.lblAcceptRefundSelectedItemCount = new System.Windows.Forms.Label();
            this.btnAcceptSendItemToGarbage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblAcceptRefundSelectItemsTitle = new System.Windows.Forms.Label();
            this.btnAcceptRefund = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mlvSelectRefundItem = new MaterialSkin.Controls.MaterialListView();
            this.clmAcceptRefundCounter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAcceptRefundItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAcceptRefundItemCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbsManageRefund = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbsManageItems = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnlManageItems.SuspendLayout();
            this.tbcManageItems.SuspendLayout();
            this.tbpBorrowItem.SuspendLayout();
            this.tbcBorrow.SuspendLayout();
            this.tbpSearchBorrowItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchBorrowItem)).BeginInit();
            this.tbpSelectBorrowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchBorrowStock)).BeginInit();
            this.tbpSelectBorrowerUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchBorrower)).BeginInit();
            this.tbpAcceptBorrowing.SuspendLayout();
            this.pnlAcceptBorrowingFailAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAcceptBorrowingFailAlert)).BeginInit();
            this.tbpRefund.SuspendLayout();
            this.tbcManageRefund.SuspendLayout();
            this.tbpSelectRefunder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectRefunder)).BeginInit();
            this.tbpSelectRefundedItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchRefundItem)).BeginInit();
            this.tbpAcceptRefund.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManageItems
            // 
            this.pnlManageItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManageItems.BackgroundImage")));
            this.pnlManageItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlManageItems.Controls.Add(this.tbcManageItems);
            this.pnlManageItems.Controls.Add(this.tbsManageItems);
            this.pnlManageItems.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlManageItems.GradientBottomRight = System.Drawing.Color.White;
            this.pnlManageItems.GradientTopLeft = System.Drawing.Color.White;
            this.pnlManageItems.GradientTopRight = System.Drawing.Color.White;
            this.pnlManageItems.Location = new System.Drawing.Point(0, 0);
            this.pnlManageItems.Name = "pnlManageItems";
            this.pnlManageItems.Quality = 10;
            this.pnlManageItems.Size = new System.Drawing.Size(774, 645);
            this.pnlManageItems.TabIndex = 36;
            // 
            // tbcManageItems
            // 
            this.tbcManageItems.Controls.Add(this.tbpBorrowItem);
            this.tbcManageItems.Controls.Add(this.tbpRefund);
            this.tbcManageItems.Depth = 0;
            this.tbcManageItems.Location = new System.Drawing.Point(0, 41);
            this.tbcManageItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbcManageItems.Name = "tbcManageItems";
            this.tbcManageItems.SelectedIndex = 0;
            this.tbcManageItems.Size = new System.Drawing.Size(774, 602);
            this.tbcManageItems.TabIndex = 3;
            // 
            // tbpBorrowItem
            // 
            this.tbpBorrowItem.Controls.Add(this.tbcBorrow);
            this.tbpBorrowItem.Controls.Add(this.tbsManageBorrow);
            this.tbpBorrowItem.Location = new System.Drawing.Point(4, 22);
            this.tbpBorrowItem.Name = "tbpBorrowItem";
            this.tbpBorrowItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBorrowItem.Size = new System.Drawing.Size(766, 576);
            this.tbpBorrowItem.TabIndex = 0;
            this.tbpBorrowItem.Text = "Borrow";
            this.tbpBorrowItem.UseVisualStyleBackColor = true;
            // 
            // tbcBorrow
            // 
            this.tbcBorrow.Controls.Add(this.tbpSearchBorrowItem);
            this.tbcBorrow.Controls.Add(this.tbpSelectBorrowStock);
            this.tbcBorrow.Controls.Add(this.tbpSelectBorrowerUser);
            this.tbcBorrow.Controls.Add(this.tbpAcceptBorrowing);
            this.tbcBorrow.Depth = 0;
            this.tbcBorrow.Location = new System.Drawing.Point(-1, 41);
            this.tbcBorrow.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbcBorrow.Name = "tbcBorrow";
            this.tbcBorrow.SelectedIndex = 0;
            this.tbcBorrow.Size = new System.Drawing.Size(770, 538);
            this.tbcBorrow.TabIndex = 3;
            // 
            // tbpSearchBorrowItem
            // 
            this.tbpSearchBorrowItem.Controls.Add(this.btnSearchBorrowItem);
            this.tbpSearchBorrowItem.Controls.Add(this.txtSearchBorrowItem);
            this.tbpSearchBorrowItem.Controls.Add(this.dropSearchBorrowItemBy);
            this.tbpSearchBorrowItem.Controls.Add(this.lblSearchBorrowItemSearchBy);
            this.tbpSearchBorrowItem.Controls.Add(this.mlvSearchBorrowItem);
            this.tbpSearchBorrowItem.Location = new System.Drawing.Point(4, 22);
            this.tbpSearchBorrowItem.Name = "tbpSearchBorrowItem";
            this.tbpSearchBorrowItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearchBorrowItem.Size = new System.Drawing.Size(762, 512);
            this.tbpSearchBorrowItem.TabIndex = 0;
            this.tbpSearchBorrowItem.Text = "Search Item";
            this.tbpSearchBorrowItem.UseVisualStyleBackColor = true;
            // 
            // btnSearchBorrowItem
            // 
            this.btnSearchBorrowItem.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBorrowItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBorrowItem.Image")));
            this.btnSearchBorrowItem.ImageActive = null;
            this.btnSearchBorrowItem.Location = new System.Drawing.Point(720, 4);
            this.btnSearchBorrowItem.Name = "btnSearchBorrowItem";
            this.btnSearchBorrowItem.Size = new System.Drawing.Size(40, 33);
            this.btnSearchBorrowItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchBorrowItem.TabIndex = 17;
            this.btnSearchBorrowItem.TabStop = false;
            this.btnSearchBorrowItem.Zoom = 4;
            this.btnSearchBorrowItem.Click += new System.EventHandler(this.txtSearchBorrowItem_OnValueChanged);
            // 
            // txtSearchBorrowItem
            // 
            this.txtSearchBorrowItem.BackColor = System.Drawing.Color.White;
            this.txtSearchBorrowItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBorrowItem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchBorrowItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchBorrowItem.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSearchBorrowItem.HintText = "Search...";
            this.txtSearchBorrowItem.isPassword = false;
            this.txtSearchBorrowItem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrowItem.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrowItem.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrowItem.LineThickness = 3;
            this.txtSearchBorrowItem.Location = new System.Drawing.Point(278, 4);
            this.txtSearchBorrowItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBorrowItem.Name = "txtSearchBorrowItem";
            this.txtSearchBorrowItem.Size = new System.Drawing.Size(442, 33);
            this.txtSearchBorrowItem.TabIndex = 16;
            this.txtSearchBorrowItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchBorrowItem.OnValueChanged += new System.EventHandler(this.txtSearchBorrowItem_OnValueChanged);
            // 
            // dropSearchBorrowItemBy
            // 
            this.dropSearchBorrowItemBy.BackColor = System.Drawing.Color.Transparent;
            this.dropSearchBorrowItemBy.BorderRadius = 3;
            this.dropSearchBorrowItemBy.DisabledColor = System.Drawing.Color.Gray;
            this.dropSearchBorrowItemBy.ForeColor = System.Drawing.Color.White;
            this.dropSearchBorrowItemBy.Items = new string[] {
        "Name",
        "Description"};
            this.dropSearchBorrowItemBy.Location = new System.Drawing.Point(120, 3);
            this.dropSearchBorrowItemBy.Name = "dropSearchBorrowItemBy";
            this.dropSearchBorrowItemBy.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSearchBorrowItemBy.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSearchBorrowItemBy.selectedIndex = 0;
            this.dropSearchBorrowItemBy.Size = new System.Drawing.Size(151, 35);
            this.dropSearchBorrowItemBy.TabIndex = 15;
            this.dropSearchBorrowItemBy.onItemSelected += new System.EventHandler(this.dropSearchBorrowItemBy_onItemSelected);
            // 
            // lblSearchBorrowItemSearchBy
            // 
            this.lblSearchBorrowItemSearchBy.AutoSize = true;
            this.lblSearchBorrowItemSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchBorrowItemSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchBorrowItemSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblSearchBorrowItemSearchBy.Location = new System.Drawing.Point(3, 8);
            this.lblSearchBorrowItemSearchBy.Name = "lblSearchBorrowItemSearchBy";
            this.lblSearchBorrowItemSearchBy.Size = new System.Drawing.Size(111, 24);
            this.lblSearchBorrowItemSearchBy.TabIndex = 14;
            this.lblSearchBorrowItemSearchBy.Text = "Search By:";
            // 
            // mlvSearchBorrowItem
            // 
            this.mlvSearchBorrowItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvSearchBorrowItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSearchBorrowItemName,
            this.clmSearchBorrowItemDescription,
            this.clmSearchBorrowItemStock,
            this.clmSearchBorrowItemBorroweds});
            this.mlvSearchBorrowItem.Depth = 0;
            this.mlvSearchBorrowItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvSearchBorrowItem.FullRowSelect = true;
            this.mlvSearchBorrowItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvSearchBorrowItem.Location = new System.Drawing.Point(0, 43);
            this.mlvSearchBorrowItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvSearchBorrowItem.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvSearchBorrowItem.Name = "mlvSearchBorrowItem";
            this.mlvSearchBorrowItem.OwnerDraw = true;
            this.mlvSearchBorrowItem.Size = new System.Drawing.Size(764, 467);
            this.mlvSearchBorrowItem.TabIndex = 1;
            this.mlvSearchBorrowItem.UseCompatibleStateImageBehavior = false;
            this.mlvSearchBorrowItem.View = System.Windows.Forms.View.Details;
            this.mlvSearchBorrowItem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvSearchBorrowItem_ItemSelectionChanged);
            // 
            // clmSearchBorrowItemName
            // 
            this.clmSearchBorrowItemName.Text = "Name";
            this.clmSearchBorrowItemName.Width = 200;
            // 
            // clmSearchBorrowItemDescription
            // 
            this.clmSearchBorrowItemDescription.Text = "Description";
            this.clmSearchBorrowItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSearchBorrowItemDescription.Width = 250;
            // 
            // clmSearchBorrowItemStock
            // 
            this.clmSearchBorrowItemStock.Text = "In Stock";
            this.clmSearchBorrowItemStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSearchBorrowItemStock.Width = 150;
            // 
            // clmSearchBorrowItemBorroweds
            // 
            this.clmSearchBorrowItemBorroweds.Text = "Borroweds";
            this.clmSearchBorrowItemBorroweds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSearchBorrowItemBorroweds.Width = 150;
            // 
            // tbpSelectBorrowStock
            // 
            this.tbpSelectBorrowStock.Controls.Add(this.btnSearchBorrowStock);
            this.tbpSelectBorrowStock.Controls.Add(this.txtSearchBorrowStock);
            this.tbpSelectBorrowStock.Controls.Add(this.lblSearchBorrowStockSearchByTitle);
            this.tbpSelectBorrowStock.Controls.Add(this.mlvSearchBorrowStock);
            this.tbpSelectBorrowStock.Location = new System.Drawing.Point(4, 22);
            this.tbpSelectBorrowStock.Name = "tbpSelectBorrowStock";
            this.tbpSelectBorrowStock.Size = new System.Drawing.Size(762, 512);
            this.tbpSelectBorrowStock.TabIndex = 3;
            this.tbpSelectBorrowStock.Text = "Select Borrow Stock";
            this.tbpSelectBorrowStock.UseVisualStyleBackColor = true;
            // 
            // btnSearchBorrowStock
            // 
            this.btnSearchBorrowStock.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBorrowStock.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBorrowStock.Image")));
            this.btnSearchBorrowStock.ImageActive = null;
            this.btnSearchBorrowStock.Location = new System.Drawing.Point(719, 4);
            this.btnSearchBorrowStock.Name = "btnSearchBorrowStock";
            this.btnSearchBorrowStock.Size = new System.Drawing.Size(40, 33);
            this.btnSearchBorrowStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchBorrowStock.TabIndex = 22;
            this.btnSearchBorrowStock.TabStop = false;
            this.btnSearchBorrowStock.Zoom = 4;
            this.btnSearchBorrowStock.Click += new System.EventHandler(this.txtSearchBorrowStock_OnValueChanged);
            // 
            // txtSearchBorrowStock
            // 
            this.txtSearchBorrowStock.BackColor = System.Drawing.Color.White;
            this.txtSearchBorrowStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBorrowStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchBorrowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchBorrowStock.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSearchBorrowStock.HintText = "Search...";
            this.txtSearchBorrowStock.isPassword = false;
            this.txtSearchBorrowStock.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrowStock.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrowStock.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrowStock.LineThickness = 3;
            this.txtSearchBorrowStock.Location = new System.Drawing.Point(275, 4);
            this.txtSearchBorrowStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBorrowStock.Name = "txtSearchBorrowStock";
            this.txtSearchBorrowStock.Size = new System.Drawing.Size(444, 33);
            this.txtSearchBorrowStock.TabIndex = 21;
            this.txtSearchBorrowStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchBorrowStock.OnValueChanged += new System.EventHandler(this.txtSearchBorrowStock_OnValueChanged);
            // 
            // lblSearchBorrowStockSearchByTitle
            // 
            this.lblSearchBorrowStockSearchByTitle.AutoSize = true;
            this.lblSearchBorrowStockSearchByTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchBorrowStockSearchByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchBorrowStockSearchByTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblSearchBorrowStockSearchByTitle.Location = new System.Drawing.Point(2, 8);
            this.lblSearchBorrowStockSearchByTitle.Name = "lblSearchBorrowStockSearchByTitle";
            this.lblSearchBorrowStockSearchByTitle.Size = new System.Drawing.Size(266, 24);
            this.lblSearchBorrowStockSearchByTitle.TabIndex = 19;
            this.lblSearchBorrowStockSearchByTitle.Text = "Search By Company Name:";
            // 
            // mlvSearchBorrowStock
            // 
            this.mlvSearchBorrowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvSearchBorrowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSelectBorrowStockCompanyName,
            this.clmSelectBorrowStockQuantity,
            this.clmSelectBorrowStockCreatedAt,
            this.clmSelectBorrowStockUpdatedAt});
            this.mlvSearchBorrowStock.Depth = 0;
            this.mlvSearchBorrowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvSearchBorrowStock.FullRowSelect = true;
            this.mlvSearchBorrowStock.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvSearchBorrowStock.Location = new System.Drawing.Point(-1, 43);
            this.mlvSearchBorrowStock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvSearchBorrowStock.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvSearchBorrowStock.Name = "mlvSearchBorrowStock";
            this.mlvSearchBorrowStock.OwnerDraw = true;
            this.mlvSearchBorrowStock.Size = new System.Drawing.Size(764, 467);
            this.mlvSearchBorrowStock.TabIndex = 18;
            this.mlvSearchBorrowStock.UseCompatibleStateImageBehavior = false;
            this.mlvSearchBorrowStock.View = System.Windows.Forms.View.Details;
            this.mlvSearchBorrowStock.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvSearchBorrowStock_ItemSelectionChanged);
            // 
            // clmSelectBorrowStockCompanyName
            // 
            this.clmSelectBorrowStockCompanyName.Text = "Company Name";
            this.clmSelectBorrowStockCompanyName.Width = 200;
            // 
            // clmSelectBorrowStockQuantity
            // 
            this.clmSelectBorrowStockQuantity.Text = "Quantity";
            this.clmSelectBorrowStockQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSelectBorrowStockQuantity.Width = 250;
            // 
            // clmSelectBorrowStockCreatedAt
            // 
            this.clmSelectBorrowStockCreatedAt.Text = "Created At";
            this.clmSelectBorrowStockCreatedAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSelectBorrowStockCreatedAt.Width = 150;
            // 
            // clmSelectBorrowStockUpdatedAt
            // 
            this.clmSelectBorrowStockUpdatedAt.Text = "Updated At";
            this.clmSelectBorrowStockUpdatedAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSelectBorrowStockUpdatedAt.Width = 150;
            // 
            // tbpSelectBorrowerUser
            // 
            this.tbpSelectBorrowerUser.Controls.Add(this.mlvSelectBorrowerUsers);
            this.tbpSelectBorrowerUser.Controls.Add(this.btnSearchBorrower);
            this.tbpSelectBorrowerUser.Controls.Add(this.txtSearchBorrower);
            this.tbpSelectBorrowerUser.Controls.Add(this.dropSelectBorrowerUserDepartment);
            this.tbpSelectBorrowerUser.Controls.Add(this.lblSelectBorrowerDepartment);
            this.tbpSelectBorrowerUser.Location = new System.Drawing.Point(4, 22);
            this.tbpSelectBorrowerUser.Name = "tbpSelectBorrowerUser";
            this.tbpSelectBorrowerUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSelectBorrowerUser.Size = new System.Drawing.Size(762, 512);
            this.tbpSelectBorrowerUser.TabIndex = 1;
            this.tbpSelectBorrowerUser.Text = "Select User";
            this.tbpSelectBorrowerUser.UseVisualStyleBackColor = true;
            // 
            // mlvSelectBorrowerUsers
            // 
            this.mlvSelectBorrowerUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvSelectBorrowerUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSelectBorrowerCount,
            this.clmSelectBorrowerUsername,
            this.clmSelectBorrowerFirstName,
            this.clmSelectBorrowerLastName,
            this.clmSelectBorrowerDepartmentName,
            this.clmSelectBorrowerRoleName,
            this.clmSelectBorrowerBorrows});
            this.mlvSelectBorrowerUsers.Depth = 0;
            this.mlvSelectBorrowerUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvSelectBorrowerUsers.FullRowSelect = true;
            this.mlvSelectBorrowerUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvSelectBorrowerUsers.Location = new System.Drawing.Point(-1, 42);
            this.mlvSelectBorrowerUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvSelectBorrowerUsers.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvSelectBorrowerUsers.Name = "mlvSelectBorrowerUsers";
            this.mlvSelectBorrowerUsers.OwnerDraw = true;
            this.mlvSelectBorrowerUsers.Size = new System.Drawing.Size(764, 476);
            this.mlvSelectBorrowerUsers.TabIndex = 22;
            this.mlvSelectBorrowerUsers.UseCompatibleStateImageBehavior = false;
            this.mlvSelectBorrowerUsers.View = System.Windows.Forms.View.Details;
            this.mlvSelectBorrowerUsers.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvSelectBorrowerUsers_ItemSelectionChanged);
            // 
            // clmSelectBorrowerCount
            // 
            this.clmSelectBorrowerCount.Text = "#";
            this.clmSelectBorrowerCount.Width = 50;
            // 
            // clmSelectBorrowerUsername
            // 
            this.clmSelectBorrowerUsername.Text = "UserName";
            this.clmSelectBorrowerUsername.Width = 120;
            // 
            // clmSelectBorrowerFirstName
            // 
            this.clmSelectBorrowerFirstName.Text = "First Name";
            this.clmSelectBorrowerFirstName.Width = 100;
            // 
            // clmSelectBorrowerLastName
            // 
            this.clmSelectBorrowerLastName.Text = "Last Name";
            this.clmSelectBorrowerLastName.Width = 100;
            // 
            // clmSelectBorrowerDepartmentName
            // 
            this.clmSelectBorrowerDepartmentName.Text = "Department";
            this.clmSelectBorrowerDepartmentName.Width = 140;
            // 
            // clmSelectBorrowerRoleName
            // 
            this.clmSelectBorrowerRoleName.Text = "Role";
            this.clmSelectBorrowerRoleName.Width = 100;
            // 
            // clmSelectBorrowerBorrows
            // 
            this.clmSelectBorrowerBorrows.Text = "Borrows";
            this.clmSelectBorrowerBorrows.Width = 150;
            // 
            // btnSearchBorrower
            // 
            this.btnSearchBorrower.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBorrower.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBorrower.Image")));
            this.btnSearchBorrower.ImageActive = null;
            this.btnSearchBorrower.Location = new System.Drawing.Point(720, 2);
            this.btnSearchBorrower.Name = "btnSearchBorrower";
            this.btnSearchBorrower.Size = new System.Drawing.Size(40, 33);
            this.btnSearchBorrower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchBorrower.TabIndex = 21;
            this.btnSearchBorrower.TabStop = false;
            this.btnSearchBorrower.Zoom = 4;
            this.btnSearchBorrower.Click += new System.EventHandler(this.txtSearchBorrower_OnValueChanged);
            // 
            // txtSearchBorrower
            // 
            this.txtSearchBorrower.BackColor = System.Drawing.Color.White;
            this.txtSearchBorrower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBorrower.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchBorrower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchBorrower.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSearchBorrower.HintText = "Search...";
            this.txtSearchBorrower.isPassword = false;
            this.txtSearchBorrower.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrower.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrower.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchBorrower.LineThickness = 3;
            this.txtSearchBorrower.Location = new System.Drawing.Point(303, 2);
            this.txtSearchBorrower.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBorrower.Name = "txtSearchBorrower";
            this.txtSearchBorrower.Size = new System.Drawing.Size(417, 33);
            this.txtSearchBorrower.TabIndex = 20;
            this.txtSearchBorrower.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchBorrower.OnValueChanged += new System.EventHandler(this.txtSearchBorrower_OnValueChanged);
            // 
            // dropSelectBorrowerUserDepartment
            // 
            this.dropSelectBorrowerUserDepartment.BackColor = System.Drawing.Color.Transparent;
            this.dropSelectBorrowerUserDepartment.BorderRadius = 3;
            this.dropSelectBorrowerUserDepartment.DisabledColor = System.Drawing.Color.Gray;
            this.dropSelectBorrowerUserDepartment.ForeColor = System.Drawing.Color.White;
            this.dropSelectBorrowerUserDepartment.Items = new string[0];
            this.dropSelectBorrowerUserDepartment.Location = new System.Drawing.Point(132, 0);
            this.dropSelectBorrowerUserDepartment.Name = "dropSelectBorrowerUserDepartment";
            this.dropSelectBorrowerUserDepartment.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSelectBorrowerUserDepartment.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSelectBorrowerUserDepartment.selectedIndex = -1;
            this.dropSelectBorrowerUserDepartment.Size = new System.Drawing.Size(164, 35);
            this.dropSelectBorrowerUserDepartment.TabIndex = 19;
            this.dropSelectBorrowerUserDepartment.onItemSelected += new System.EventHandler(this.dropSelectBorrowerUserDepartment_onItemSelected);
            // 
            // lblSelectBorrowerDepartment
            // 
            this.lblSelectBorrowerDepartment.AutoSize = true;
            this.lblSelectBorrowerDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectBorrowerDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectBorrowerDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblSelectBorrowerDepartment.Location = new System.Drawing.Point(3, 6);
            this.lblSelectBorrowerDepartment.Name = "lblSelectBorrowerDepartment";
            this.lblSelectBorrowerDepartment.Size = new System.Drawing.Size(123, 24);
            this.lblSelectBorrowerDepartment.TabIndex = 18;
            this.lblSelectBorrowerDepartment.Text = "Department:";
            // 
            // tbpAcceptBorrowing
            // 
            this.tbpAcceptBorrowing.Controls.Add(this.pnlAcceptBorrowingFailAlert);
            this.tbpAcceptBorrowing.Controls.Add(this.btnAcceptBorrowingCharge);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingAlreadyBorrowed);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingDepartmentName);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingFullName);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingUsername);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingBorrowed);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingInStock);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingItemName);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingItemId);
            this.tbpAcceptBorrowing.Controls.Add(this.dropBorrowItemCount);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingBorrowedQuantityTitle);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingBorrowerDetailsBorrowed);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingBorrowerDetailsDepartment);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingBorrowerDetailsFirstName);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingBorrowerDetailsUsername);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingBorrowerDetailsTitle);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingItemDetailsBorrowed);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingItemDetailsInStock);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingItemDetailsItemName);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingItemDetailsItemId);
            this.tbpAcceptBorrowing.Controls.Add(this.lblAcceptBorrowingItemDetailsTitle);
            this.tbpAcceptBorrowing.Location = new System.Drawing.Point(4, 22);
            this.tbpAcceptBorrowing.Name = "tbpAcceptBorrowing";
            this.tbpAcceptBorrowing.Size = new System.Drawing.Size(762, 512);
            this.tbpAcceptBorrowing.TabIndex = 2;
            this.tbpAcceptBorrowing.Text = "Accept Borrowing";
            this.tbpAcceptBorrowing.UseVisualStyleBackColor = true;
            // 
            // pnlAcceptBorrowingFailAlert
            // 
            this.pnlAcceptBorrowingFailAlert.Controls.Add(this.lblAcceptBorrowingFailAlert2);
            this.pnlAcceptBorrowingFailAlert.Controls.Add(this.lblAcceptBorrowingFailAlert1);
            this.pnlAcceptBorrowingFailAlert.Controls.Add(this.pboxAcceptBorrowingFailAlert);
            this.pnlAcceptBorrowingFailAlert.Location = new System.Drawing.Point(450, 290);
            this.pnlAcceptBorrowingFailAlert.Name = "pnlAcceptBorrowingFailAlert";
            this.pnlAcceptBorrowingFailAlert.Size = new System.Drawing.Size(184, 210);
            this.pnlAcceptBorrowingFailAlert.TabIndex = 47;
            this.pnlAcceptBorrowingFailAlert.Visible = false;
            // 
            // lblAcceptBorrowingFailAlert2
            // 
            this.lblAcceptBorrowingFailAlert2.AutoSize = true;
            this.lblAcceptBorrowingFailAlert2.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingFailAlert2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingFailAlert2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.lblAcceptBorrowingFailAlert2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcceptBorrowingFailAlert2.Location = new System.Drawing.Point(8, 149);
            this.lblAcceptBorrowingFailAlert2.Name = "lblAcceptBorrowingFailAlert2";
            this.lblAcceptBorrowingFailAlert2.Size = new System.Drawing.Size(171, 17);
            this.lblAcceptBorrowingFailAlert2.TabIndex = 18;
            this.lblAcceptBorrowingFailAlert2.Text = "Check your selections!";
            // 
            // lblAcceptBorrowingFailAlert1
            // 
            this.lblAcceptBorrowingFailAlert1.AutoSize = true;
            this.lblAcceptBorrowingFailAlert1.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingFailAlert1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingFailAlert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.lblAcceptBorrowingFailAlert1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcceptBorrowingFailAlert1.Location = new System.Drawing.Point(28, 128);
            this.lblAcceptBorrowingFailAlert1.Name = "lblAcceptBorrowingFailAlert1";
            this.lblAcceptBorrowingFailAlert1.Size = new System.Drawing.Size(129, 17);
            this.lblAcceptBorrowingFailAlert1.TabIndex = 17;
            this.lblAcceptBorrowingFailAlert1.Text = "Operation failed!";
            // 
            // pboxAcceptBorrowingFailAlert
            // 
            this.pboxAcceptBorrowingFailAlert.Image = ((System.Drawing.Image)(resources.GetObject("pboxAcceptBorrowingFailAlert.Image")));
            this.pboxAcceptBorrowingFailAlert.Location = new System.Drawing.Point(66, 82);
            this.pboxAcceptBorrowingFailAlert.Name = "pboxAcceptBorrowingFailAlert";
            this.pboxAcceptBorrowingFailAlert.Size = new System.Drawing.Size(50, 45);
            this.pboxAcceptBorrowingFailAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAcceptBorrowingFailAlert.TabIndex = 1;
            this.pboxAcceptBorrowingFailAlert.TabStop = false;
            // 
            // btnAcceptBorrowingCharge
            // 
            this.btnAcceptBorrowingCharge.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnAcceptBorrowingCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnAcceptBorrowingCharge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcceptBorrowingCharge.BorderRadius = 0;
            this.btnAcceptBorrowingCharge.ButtonText = "CHARGE";
            this.btnAcceptBorrowingCharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptBorrowingCharge.DisabledColor = System.Drawing.Color.Gray;
            this.btnAcceptBorrowingCharge.Enabled = false;
            this.btnAcceptBorrowingCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAcceptBorrowingCharge.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAcceptBorrowingCharge.Iconimage = null;
            this.btnAcceptBorrowingCharge.Iconimage_right = null;
            this.btnAcceptBorrowingCharge.Iconimage_right_Selected = null;
            this.btnAcceptBorrowingCharge.Iconimage_Selected = null;
            this.btnAcceptBorrowingCharge.IconMarginLeft = 0;
            this.btnAcceptBorrowingCharge.IconMarginRight = 0;
            this.btnAcceptBorrowingCharge.IconRightVisible = false;
            this.btnAcceptBorrowingCharge.IconRightZoom = 0D;
            this.btnAcceptBorrowingCharge.IconVisible = false;
            this.btnAcceptBorrowingCharge.IconZoom = 90D;
            this.btnAcceptBorrowingCharge.IsTab = false;
            this.btnAcceptBorrowingCharge.Location = new System.Drawing.Point(202, 410);
            this.btnAcceptBorrowingCharge.Name = "btnAcceptBorrowingCharge";
            this.btnAcceptBorrowingCharge.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnAcceptBorrowingCharge.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnAcceptBorrowingCharge.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAcceptBorrowingCharge.selected = false;
            this.btnAcceptBorrowingCharge.Size = new System.Drawing.Size(242, 48);
            this.btnAcceptBorrowingCharge.TabIndex = 46;
            this.btnAcceptBorrowingCharge.Text = "CHARGE";
            this.btnAcceptBorrowingCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAcceptBorrowingCharge.Textcolor = System.Drawing.Color.White;
            this.btnAcceptBorrowingCharge.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptBorrowingCharge.Click += new System.EventHandler(this.btnAcceptBorrowingBorrow_Click);
            // 
            // lblAcceptBorrowingAlreadyBorrowed
            // 
            this.lblAcceptBorrowingAlreadyBorrowed.AutoSize = true;
            this.lblAcceptBorrowingAlreadyBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingAlreadyBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingAlreadyBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptBorrowingAlreadyBorrowed.Location = new System.Drawing.Point(391, 319);
            this.lblAcceptBorrowingAlreadyBorrowed.Name = "lblAcceptBorrowingAlreadyBorrowed";
            this.lblAcceptBorrowingAlreadyBorrowed.Size = new System.Drawing.Size(0, 17);
            this.lblAcceptBorrowingAlreadyBorrowed.TabIndex = 45;
            // 
            // lblAcceptBorrowingDepartmentName
            // 
            this.lblAcceptBorrowingDepartmentName.AutoSize = true;
            this.lblAcceptBorrowingDepartmentName.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingDepartmentName.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptBorrowingDepartmentName.Location = new System.Drawing.Point(172, 284);
            this.lblAcceptBorrowingDepartmentName.Name = "lblAcceptBorrowingDepartmentName";
            this.lblAcceptBorrowingDepartmentName.Size = new System.Drawing.Size(0, 17);
            this.lblAcceptBorrowingDepartmentName.TabIndex = 44;
            // 
            // lblAcceptBorrowingFullName
            // 
            this.lblAcceptBorrowingFullName.AutoSize = true;
            this.lblAcceptBorrowingFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingFullName.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptBorrowingFullName.Location = new System.Drawing.Point(166, 253);
            this.lblAcceptBorrowingFullName.Name = "lblAcceptBorrowingFullName";
            this.lblAcceptBorrowingFullName.Size = new System.Drawing.Size(0, 17);
            this.lblAcceptBorrowingFullName.TabIndex = 42;
            // 
            // lblAcceptBorrowingUsername
            // 
            this.lblAcceptBorrowingUsername.AutoSize = true;
            this.lblAcceptBorrowingUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingUsername.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptBorrowingUsername.Location = new System.Drawing.Point(161, 219);
            this.lblAcceptBorrowingUsername.Name = "lblAcceptBorrowingUsername";
            this.lblAcceptBorrowingUsername.Size = new System.Drawing.Size(0, 17);
            this.lblAcceptBorrowingUsername.TabIndex = 41;
            // 
            // lblAcceptBorrowingBorrowed
            // 
            this.lblAcceptBorrowingBorrowed.AutoSize = true;
            this.lblAcceptBorrowingBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptBorrowingBorrowed.Location = new System.Drawing.Point(156, 137);
            this.lblAcceptBorrowingBorrowed.Name = "lblAcceptBorrowingBorrowed";
            this.lblAcceptBorrowingBorrowed.Size = new System.Drawing.Size(0, 17);
            this.lblAcceptBorrowingBorrowed.TabIndex = 40;
            // 
            // lblAcceptBorrowingInStock
            // 
            this.lblAcceptBorrowingInStock.AutoSize = true;
            this.lblAcceptBorrowingInStock.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingInStock.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptBorrowingInStock.Location = new System.Drawing.Point(146, 106);
            this.lblAcceptBorrowingInStock.Name = "lblAcceptBorrowingInStock";
            this.lblAcceptBorrowingInStock.Size = new System.Drawing.Size(0, 17);
            this.lblAcceptBorrowingInStock.TabIndex = 39;
            // 
            // lblAcceptBorrowingItemName
            // 
            this.lblAcceptBorrowingItemName.AutoSize = true;
            this.lblAcceptBorrowingItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingItemName.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptBorrowingItemName.Location = new System.Drawing.Point(164, 73);
            this.lblAcceptBorrowingItemName.Name = "lblAcceptBorrowingItemName";
            this.lblAcceptBorrowingItemName.Size = new System.Drawing.Size(0, 17);
            this.lblAcceptBorrowingItemName.TabIndex = 38;
            // 
            // lblAcceptBorrowingItemId
            // 
            this.lblAcceptBorrowingItemId.AutoSize = true;
            this.lblAcceptBorrowingItemId.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingItemId.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptBorrowingItemId.Location = new System.Drawing.Point(136, 39);
            this.lblAcceptBorrowingItemId.Name = "lblAcceptBorrowingItemId";
            this.lblAcceptBorrowingItemId.Size = new System.Drawing.Size(0, 17);
            this.lblAcceptBorrowingItemId.TabIndex = 37;
            // 
            // dropBorrowItemCount
            // 
            this.dropBorrowItemCount.AutoScroll = true;
            this.dropBorrowItemCount.BackColor = System.Drawing.Color.Transparent;
            this.dropBorrowItemCount.BorderRadius = 3;
            this.dropBorrowItemCount.DisabledColor = System.Drawing.Color.Gray;
            this.dropBorrowItemCount.ForeColor = System.Drawing.Color.White;
            this.dropBorrowItemCount.Items = new string[0];
            this.dropBorrowItemCount.Location = new System.Drawing.Point(202, 369);
            this.dropBorrowItemCount.Name = "dropBorrowItemCount";
            this.dropBorrowItemCount.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropBorrowItemCount.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropBorrowItemCount.selectedIndex = -1;
            this.dropBorrowItemCount.Size = new System.Drawing.Size(242, 35);
            this.dropBorrowItemCount.TabIndex = 36;
            this.dropBorrowItemCount.onItemSelected += new System.EventHandler(this.dropBorrowItemCount_onItemSelected);
            // 
            // lblAcceptBorrowingBorrowedQuantityTitle
            // 
            this.lblAcceptBorrowingBorrowedQuantityTitle.AutoSize = true;
            this.lblAcceptBorrowingBorrowedQuantityTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingBorrowedQuantityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcceptBorrowingBorrowedQuantityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingBorrowedQuantityTitle.Location = new System.Drawing.Point(3, 374);
            this.lblAcceptBorrowingBorrowedQuantityTitle.Name = "lblAcceptBorrowingBorrowedQuantityTitle";
            this.lblAcceptBorrowingBorrowedQuantityTitle.Size = new System.Drawing.Size(193, 24);
            this.lblAcceptBorrowingBorrowedQuantityTitle.TabIndex = 35;
            this.lblAcceptBorrowingBorrowedQuantityTitle.Text = "Borrowing Quantity:";
            // 
            // lblAcceptBorrowingBorrowerDetailsBorrowed
            // 
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.AutoSize = true;
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.Location = new System.Drawing.Point(69, 319);
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.Name = "lblAcceptBorrowingBorrowerDetailsBorrowed";
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.Size = new System.Drawing.Size(316, 17);
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.TabIndex = 34;
            this.lblAcceptBorrowingBorrowerDetailsBorrowed.Text = "Does Already Borrowed This Item Before?:";
            // 
            // lblAcceptBorrowingBorrowerDetailsDepartment
            // 
            this.lblAcceptBorrowingBorrowerDetailsDepartment.AutoSize = true;
            this.lblAcceptBorrowingBorrowerDetailsDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingBorrowerDetailsDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingBorrowerDetailsDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingBorrowerDetailsDepartment.Location = new System.Drawing.Point(69, 284);
            this.lblAcceptBorrowingBorrowerDetailsDepartment.Name = "lblAcceptBorrowingBorrowerDetailsDepartment";
            this.lblAcceptBorrowingBorrowerDetailsDepartment.Size = new System.Drawing.Size(97, 17);
            this.lblAcceptBorrowingBorrowerDetailsDepartment.TabIndex = 33;
            this.lblAcceptBorrowingBorrowerDetailsDepartment.Text = "Department:";
            // 
            // lblAcceptBorrowingBorrowerDetailsFirstName
            // 
            this.lblAcceptBorrowingBorrowerDetailsFirstName.AutoSize = true;
            this.lblAcceptBorrowingBorrowerDetailsFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingBorrowerDetailsFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingBorrowerDetailsFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingBorrowerDetailsFirstName.Location = new System.Drawing.Point(69, 253);
            this.lblAcceptBorrowingBorrowerDetailsFirstName.Name = "lblAcceptBorrowingBorrowerDetailsFirstName";
            this.lblAcceptBorrowingBorrowerDetailsFirstName.Size = new System.Drawing.Size(85, 17);
            this.lblAcceptBorrowingBorrowerDetailsFirstName.TabIndex = 31;
            this.lblAcceptBorrowingBorrowerDetailsFirstName.Text = "Full Name:";
            // 
            // lblAcceptBorrowingBorrowerDetailsUsername
            // 
            this.lblAcceptBorrowingBorrowerDetailsUsername.AutoSize = true;
            this.lblAcceptBorrowingBorrowerDetailsUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingBorrowerDetailsUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingBorrowerDetailsUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingBorrowerDetailsUsername.Location = new System.Drawing.Point(69, 219);
            this.lblAcceptBorrowingBorrowerDetailsUsername.Name = "lblAcceptBorrowingBorrowerDetailsUsername";
            this.lblAcceptBorrowingBorrowerDetailsUsername.Size = new System.Drawing.Size(86, 17);
            this.lblAcceptBorrowingBorrowerDetailsUsername.TabIndex = 30;
            this.lblAcceptBorrowingBorrowerDetailsUsername.Text = "Username:";
            // 
            // lblAcceptBorrowingBorrowerDetailsTitle
            // 
            this.lblAcceptBorrowingBorrowerDetailsTitle.AutoSize = true;
            this.lblAcceptBorrowingBorrowerDetailsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingBorrowerDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcceptBorrowingBorrowerDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingBorrowerDetailsTitle.Location = new System.Drawing.Point(3, 179);
            this.lblAcceptBorrowingBorrowerDetailsTitle.Name = "lblAcceptBorrowingBorrowerDetailsTitle";
            this.lblAcceptBorrowingBorrowerDetailsTitle.Size = new System.Drawing.Size(169, 24);
            this.lblAcceptBorrowingBorrowerDetailsTitle.TabIndex = 29;
            this.lblAcceptBorrowingBorrowerDetailsTitle.Text = "Borrower Details:";
            // 
            // lblAcceptBorrowingItemDetailsBorrowed
            // 
            this.lblAcceptBorrowingItemDetailsBorrowed.AutoSize = true;
            this.lblAcceptBorrowingItemDetailsBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingItemDetailsBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingItemDetailsBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingItemDetailsBorrowed.Location = new System.Drawing.Point(69, 137);
            this.lblAcceptBorrowingItemDetailsBorrowed.Name = "lblAcceptBorrowingItemDetailsBorrowed";
            this.lblAcceptBorrowingItemDetailsBorrowed.Size = new System.Drawing.Size(81, 17);
            this.lblAcceptBorrowingItemDetailsBorrowed.TabIndex = 28;
            this.lblAcceptBorrowingItemDetailsBorrowed.Text = "Borrowed:";
            // 
            // lblAcceptBorrowingItemDetailsInStock
            // 
            this.lblAcceptBorrowingItemDetailsInStock.AutoSize = true;
            this.lblAcceptBorrowingItemDetailsInStock.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingItemDetailsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingItemDetailsInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingItemDetailsInStock.Location = new System.Drawing.Point(69, 106);
            this.lblAcceptBorrowingItemDetailsInStock.Name = "lblAcceptBorrowingItemDetailsInStock";
            this.lblAcceptBorrowingItemDetailsInStock.Size = new System.Drawing.Size(71, 17);
            this.lblAcceptBorrowingItemDetailsInStock.TabIndex = 27;
            this.lblAcceptBorrowingItemDetailsInStock.Text = "In Stock:";
            // 
            // lblAcceptBorrowingItemDetailsItemName
            // 
            this.lblAcceptBorrowingItemDetailsItemName.AutoSize = true;
            this.lblAcceptBorrowingItemDetailsItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingItemDetailsItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingItemDetailsItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingItemDetailsItemName.Location = new System.Drawing.Point(69, 73);
            this.lblAcceptBorrowingItemDetailsItemName.Name = "lblAcceptBorrowingItemDetailsItemName";
            this.lblAcceptBorrowingItemDetailsItemName.Size = new System.Drawing.Size(89, 17);
            this.lblAcceptBorrowingItemDetailsItemName.TabIndex = 26;
            this.lblAcceptBorrowingItemDetailsItemName.Text = "Item Name:";
            // 
            // lblAcceptBorrowingItemDetailsItemId
            // 
            this.lblAcceptBorrowingItemDetailsItemId.AutoSize = true;
            this.lblAcceptBorrowingItemDetailsItemId.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingItemDetailsItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptBorrowingItemDetailsItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingItemDetailsItemId.Location = new System.Drawing.Point(69, 39);
            this.lblAcceptBorrowingItemDetailsItemId.Name = "lblAcceptBorrowingItemDetailsItemId";
            this.lblAcceptBorrowingItemDetailsItemId.Size = new System.Drawing.Size(61, 17);
            this.lblAcceptBorrowingItemDetailsItemId.TabIndex = 25;
            this.lblAcceptBorrowingItemDetailsItemId.Text = "Item Id:";
            // 
            // lblAcceptBorrowingItemDetailsTitle
            // 
            this.lblAcceptBorrowingItemDetailsTitle.AutoSize = true;
            this.lblAcceptBorrowingItemDetailsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptBorrowingItemDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcceptBorrowingItemDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptBorrowingItemDetailsTitle.Location = new System.Drawing.Point(3, 1);
            this.lblAcceptBorrowingItemDetailsTitle.Name = "lblAcceptBorrowingItemDetailsTitle";
            this.lblAcceptBorrowingItemDetailsTitle.Size = new System.Drawing.Size(123, 24);
            this.lblAcceptBorrowingItemDetailsTitle.TabIndex = 19;
            this.lblAcceptBorrowingItemDetailsTitle.Text = "Item Details:";
            // 
            // tbsManageBorrow
            // 
            this.tbsManageBorrow.BaseTabControl = this.tbcBorrow;
            this.tbsManageBorrow.Depth = 0;
            this.tbsManageBorrow.Location = new System.Drawing.Point(0, 0);
            this.tbsManageBorrow.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbsManageBorrow.Name = "tbsManageBorrow";
            this.tbsManageBorrow.Size = new System.Drawing.Size(783, 40);
            this.tbsManageBorrow.TabIndex = 2;
            this.tbsManageBorrow.Text = "materialTabSelector1";
            // 
            // tbpRefund
            // 
            this.tbpRefund.Controls.Add(this.tbcManageRefund);
            this.tbpRefund.Controls.Add(this.tbsManageRefund);
            this.tbpRefund.Location = new System.Drawing.Point(4, 22);
            this.tbpRefund.Name = "tbpRefund";
            this.tbpRefund.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRefund.Size = new System.Drawing.Size(766, 576);
            this.tbpRefund.TabIndex = 1;
            this.tbpRefund.Text = "Refund";
            this.tbpRefund.UseVisualStyleBackColor = true;
            // 
            // tbcManageRefund
            // 
            this.tbcManageRefund.Controls.Add(this.tbpSelectRefunder);
            this.tbcManageRefund.Controls.Add(this.tbpSelectRefundedItem);
            this.tbcManageRefund.Controls.Add(this.tbpAcceptRefund);
            this.tbcManageRefund.Depth = 0;
            this.tbcManageRefund.Location = new System.Drawing.Point(0, 43);
            this.tbcManageRefund.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbcManageRefund.Name = "tbcManageRefund";
            this.tbcManageRefund.SelectedIndex = 0;
            this.tbcManageRefund.Size = new System.Drawing.Size(769, 530);
            this.tbcManageRefund.TabIndex = 4;
            // 
            // tbpSelectRefunder
            // 
            this.tbpSelectRefunder.Controls.Add(this.dropSelectRefunderDepartment);
            this.tbpSelectRefunder.Controls.Add(this.mlvSelectRefunderUser);
            this.tbpSelectRefunder.Controls.Add(this.btnSelectRefunder);
            this.tbpSelectRefunder.Controls.Add(this.txtSelectRefunder);
            this.tbpSelectRefunder.Controls.Add(this.dropSelectRefunderSearchBy);
            this.tbpSelectRefunder.Controls.Add(this.lblSelectBorrowerSearchByTitle);
            this.tbpSelectRefunder.Location = new System.Drawing.Point(4, 22);
            this.tbpSelectRefunder.Name = "tbpSelectRefunder";
            this.tbpSelectRefunder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSelectRefunder.Size = new System.Drawing.Size(761, 504);
            this.tbpSelectRefunder.TabIndex = 0;
            this.tbpSelectRefunder.Text = "SELECT BORROWER";
            this.tbpSelectRefunder.UseVisualStyleBackColor = true;
            // 
            // dropSelectRefunderDepartment
            // 
            this.dropSelectRefunderDepartment.BackColor = System.Drawing.Color.Transparent;
            this.dropSelectRefunderDepartment.BorderRadius = 3;
            this.dropSelectRefunderDepartment.DisabledColor = System.Drawing.Color.Gray;
            this.dropSelectRefunderDepartment.ForeColor = System.Drawing.Color.White;
            this.dropSelectRefunderDepartment.Items = new string[0];
            this.dropSelectRefunderDepartment.Location = new System.Drawing.Point(276, 0);
            this.dropSelectRefunderDepartment.Name = "dropSelectRefunderDepartment";
            this.dropSelectRefunderDepartment.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSelectRefunderDepartment.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSelectRefunderDepartment.selectedIndex = -1;
            this.dropSelectRefunderDepartment.Size = new System.Drawing.Size(151, 35);
            this.dropSelectRefunderDepartment.TabIndex = 23;
            this.dropSelectRefunderDepartment.onItemSelected += new System.EventHandler(this.dropSelectRefunderDepartment_onItemSelected);
            // 
            // mlvSelectRefunderUser
            // 
            this.mlvSelectRefunderUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvSelectRefunderUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmBorrowerNumber,
            this.clmBorrowerUsername,
            this.clmBorrowerFullName,
            this.clmBorrowerDepartmentName,
            this.clmNumberOfBorrows,
            this.clmNumberOfDifferentBorrows});
            this.mlvSelectRefunderUser.Depth = 0;
            this.mlvSelectRefunderUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvSelectRefunderUser.FullRowSelect = true;
            this.mlvSelectRefunderUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvSelectRefunderUser.Location = new System.Drawing.Point(-2, 41);
            this.mlvSelectRefunderUser.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvSelectRefunderUser.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvSelectRefunderUser.Name = "mlvSelectRefunderUser";
            this.mlvSelectRefunderUser.OwnerDraw = true;
            this.mlvSelectRefunderUser.Size = new System.Drawing.Size(764, 467);
            this.mlvSelectRefunderUser.TabIndex = 22;
            this.mlvSelectRefunderUser.UseCompatibleStateImageBehavior = false;
            this.mlvSelectRefunderUser.View = System.Windows.Forms.View.Details;
            this.mlvSelectRefunderUser.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvSelectRefunderUser_ItemSelectionChanged);
            // 
            // clmBorrowerNumber
            // 
            this.clmBorrowerNumber.Text = "#";
            this.clmBorrowerNumber.Width = 50;
            // 
            // clmBorrowerUsername
            // 
            this.clmBorrowerUsername.Text = "Username";
            this.clmBorrowerUsername.Width = 175;
            // 
            // clmBorrowerFullName
            // 
            this.clmBorrowerFullName.Text = "Name";
            this.clmBorrowerFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmBorrowerFullName.Width = 175;
            // 
            // clmBorrowerDepartmentName
            // 
            this.clmBorrowerDepartmentName.Text = "Department Name";
            this.clmBorrowerDepartmentName.Width = 150;
            // 
            // clmNumberOfBorrows
            // 
            this.clmNumberOfBorrows.Text = "Number Of Borrows";
            this.clmNumberOfBorrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmNumberOfBorrows.Width = 100;
            // 
            // clmNumberOfDifferentBorrows
            // 
            this.clmNumberOfDifferentBorrows.Text = "Number Of Different Items";
            this.clmNumberOfDifferentBorrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmNumberOfDifferentBorrows.Width = 100;
            // 
            // btnSelectRefunder
            // 
            this.btnSelectRefunder.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectRefunder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectRefunder.Image")));
            this.btnSelectRefunder.ImageActive = null;
            this.btnSelectRefunder.Location = new System.Drawing.Point(718, 3);
            this.btnSelectRefunder.Name = "btnSelectRefunder";
            this.btnSelectRefunder.Size = new System.Drawing.Size(40, 33);
            this.btnSelectRefunder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelectRefunder.TabIndex = 21;
            this.btnSelectRefunder.TabStop = false;
            this.btnSelectRefunder.Zoom = 4;
            this.btnSelectRefunder.Click += new System.EventHandler(this.txtSelectRefunder_OnValueChanged);
            // 
            // txtSelectRefunder
            // 
            this.txtSelectRefunder.BackColor = System.Drawing.Color.White;
            this.txtSelectRefunder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelectRefunder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSelectRefunder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSelectRefunder.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSelectRefunder.HintText = "Search...";
            this.txtSelectRefunder.isPassword = false;
            this.txtSelectRefunder.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSelectRefunder.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSelectRefunder.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSelectRefunder.LineThickness = 3;
            this.txtSelectRefunder.Location = new System.Drawing.Point(434, 2);
            this.txtSelectRefunder.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelectRefunder.Name = "txtSelectRefunder";
            this.txtSelectRefunder.Size = new System.Drawing.Size(285, 33);
            this.txtSelectRefunder.TabIndex = 20;
            this.txtSelectRefunder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSelectRefunder.OnValueChanged += new System.EventHandler(this.txtSelectRefunder_OnValueChanged);
            // 
            // dropSelectRefunderSearchBy
            // 
            this.dropSelectRefunderSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.dropSelectRefunderSearchBy.BorderRadius = 3;
            this.dropSelectRefunderSearchBy.DisabledColor = System.Drawing.Color.Gray;
            this.dropSelectRefunderSearchBy.ForeColor = System.Drawing.Color.White;
            this.dropSelectRefunderSearchBy.Items = new string[] {
        "Username",
        "Name"};
            this.dropSelectRefunderSearchBy.Location = new System.Drawing.Point(119, 0);
            this.dropSelectRefunderSearchBy.Name = "dropSelectRefunderSearchBy";
            this.dropSelectRefunderSearchBy.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSelectRefunderSearchBy.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSelectRefunderSearchBy.selectedIndex = 0;
            this.dropSelectRefunderSearchBy.Size = new System.Drawing.Size(151, 35);
            this.dropSelectRefunderSearchBy.TabIndex = 19;
            this.dropSelectRefunderSearchBy.onItemSelected += new System.EventHandler(this.dropSelectRefunderSearchBy_onItemSelected);
            // 
            // lblSelectBorrowerSearchByTitle
            // 
            this.lblSelectBorrowerSearchByTitle.AutoSize = true;
            this.lblSelectBorrowerSearchByTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectBorrowerSearchByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectBorrowerSearchByTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblSelectBorrowerSearchByTitle.Location = new System.Drawing.Point(2, 6);
            this.lblSelectBorrowerSearchByTitle.Name = "lblSelectBorrowerSearchByTitle";
            this.lblSelectBorrowerSearchByTitle.Size = new System.Drawing.Size(111, 24);
            this.lblSelectBorrowerSearchByTitle.TabIndex = 18;
            this.lblSelectBorrowerSearchByTitle.Text = "Search By:";
            // 
            // tbpSelectRefundedItem
            // 
            this.tbpSelectRefundedItem.Controls.Add(this.btnSearchRefundItem);
            this.tbpSelectRefundedItem.Controls.Add(this.txtSearchRefundItem);
            this.tbpSelectRefundedItem.Controls.Add(this.dropSelectRefundItemSearchBy);
            this.tbpSelectRefundedItem.Controls.Add(this.lblSearchRefundItemSearchByTitle);
            this.tbpSelectRefundedItem.Controls.Add(this.mlvSelectRefundItemStock);
            this.tbpSelectRefundedItem.Location = new System.Drawing.Point(4, 22);
            this.tbpSelectRefundedItem.Name = "tbpSelectRefundedItem";
            this.tbpSelectRefundedItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSelectRefundedItem.Size = new System.Drawing.Size(761, 504);
            this.tbpSelectRefundedItem.TabIndex = 1;
            this.tbpSelectRefundedItem.Text = "Select Item";
            this.tbpSelectRefundedItem.UseVisualStyleBackColor = true;
            // 
            // btnSearchRefundItem
            // 
            this.btnSearchRefundItem.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchRefundItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRefundItem.Image")));
            this.btnSearchRefundItem.ImageActive = null;
            this.btnSearchRefundItem.Location = new System.Drawing.Point(718, 3);
            this.btnSearchRefundItem.Name = "btnSearchRefundItem";
            this.btnSearchRefundItem.Size = new System.Drawing.Size(40, 33);
            this.btnSearchRefundItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchRefundItem.TabIndex = 22;
            this.btnSearchRefundItem.TabStop = false;
            this.btnSearchRefundItem.Zoom = 4;
            this.btnSearchRefundItem.Click += new System.EventHandler(this.txtSearchRefundItem_OnValueChanged);
            // 
            // txtSearchRefundItem
            // 
            this.txtSearchRefundItem.BackColor = System.Drawing.Color.White;
            this.txtSearchRefundItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchRefundItem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchRefundItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchRefundItem.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSearchRefundItem.HintText = "Search...";
            this.txtSearchRefundItem.isPassword = false;
            this.txtSearchRefundItem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchRefundItem.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchRefundItem.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.txtSearchRefundItem.LineThickness = 3;
            this.txtSearchRefundItem.Location = new System.Drawing.Point(276, 0);
            this.txtSearchRefundItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchRefundItem.Name = "txtSearchRefundItem";
            this.txtSearchRefundItem.Size = new System.Drawing.Size(442, 33);
            this.txtSearchRefundItem.TabIndex = 21;
            this.txtSearchRefundItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchRefundItem.OnValueChanged += new System.EventHandler(this.txtSearchRefundItem_OnValueChanged);
            // 
            // dropSelectRefundItemSearchBy
            // 
            this.dropSelectRefundItemSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.dropSelectRefundItemSearchBy.BorderRadius = 3;
            this.dropSelectRefundItemSearchBy.DisabledColor = System.Drawing.Color.Gray;
            this.dropSelectRefundItemSearchBy.ForeColor = System.Drawing.Color.White;
            this.dropSelectRefundItemSearchBy.Items = new string[] {
        "Name",
        "CompanyName"};
            this.dropSelectRefundItemSearchBy.Location = new System.Drawing.Point(119, 0);
            this.dropSelectRefundItemSearchBy.Name = "dropSelectRefundItemSearchBy";
            this.dropSelectRefundItemSearchBy.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSelectRefundItemSearchBy.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.dropSelectRefundItemSearchBy.selectedIndex = 0;
            this.dropSelectRefundItemSearchBy.Size = new System.Drawing.Size(151, 35);
            this.dropSelectRefundItemSearchBy.TabIndex = 20;
            this.dropSelectRefundItemSearchBy.onItemSelected += new System.EventHandler(this.dropSelectRefundItemSearchBy_onItemSelected);
            // 
            // lblSearchRefundItemSearchByTitle
            // 
            this.lblSearchRefundItemSearchByTitle.AutoSize = true;
            this.lblSearchRefundItemSearchByTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchRefundItemSearchByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchRefundItemSearchByTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblSearchRefundItemSearchByTitle.Location = new System.Drawing.Point(2, 6);
            this.lblSearchRefundItemSearchByTitle.Name = "lblSearchRefundItemSearchByTitle";
            this.lblSearchRefundItemSearchByTitle.Size = new System.Drawing.Size(111, 24);
            this.lblSearchRefundItemSearchByTitle.TabIndex = 19;
            this.lblSearchRefundItemSearchByTitle.Text = "Search By:";
            // 
            // mlvSelectRefundItemStock
            // 
            this.mlvSelectRefundItemStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvSelectRefundItemStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSelectRefundItemCount,
            this.clmSelectRefundItemName,
            this.clmSelectRefundItemCompanyName,
            this.clmSelectRefundItemBorrowings,
            this.clmSelectRefundItemBorrowedDate});
            this.mlvSelectRefundItemStock.Depth = 0;
            this.mlvSelectRefundItemStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvSelectRefundItemStock.FullRowSelect = true;
            this.mlvSelectRefundItemStock.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvSelectRefundItemStock.Location = new System.Drawing.Point(0, 40);
            this.mlvSelectRefundItemStock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvSelectRefundItemStock.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvSelectRefundItemStock.Name = "mlvSelectRefundItemStock";
            this.mlvSelectRefundItemStock.OwnerDraw = true;
            this.mlvSelectRefundItemStock.Size = new System.Drawing.Size(764, 467);
            this.mlvSelectRefundItemStock.TabIndex = 18;
            this.mlvSelectRefundItemStock.UseCompatibleStateImageBehavior = false;
            this.mlvSelectRefundItemStock.View = System.Windows.Forms.View.Details;
            this.mlvSelectRefundItemStock.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvSelectRefundItemStock_ItemSelectionChanged);
            // 
            // clmSelectRefundItemCount
            // 
            this.clmSelectRefundItemCount.Text = "#";
            this.clmSelectRefundItemCount.Width = 50;
            // 
            // clmSelectRefundItemName
            // 
            this.clmSelectRefundItemName.Text = "Name";
            this.clmSelectRefundItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSelectRefundItemName.Width = 200;
            // 
            // clmSelectRefundItemCompanyName
            // 
            this.clmSelectRefundItemCompanyName.Text = "Company Name";
            this.clmSelectRefundItemCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSelectRefundItemCompanyName.Width = 200;
            // 
            // clmSelectRefundItemBorrowings
            // 
            this.clmSelectRefundItemBorrowings.Text = "Number Of Borrowings";
            this.clmSelectRefundItemBorrowings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSelectRefundItemBorrowings.Width = 100;
            // 
            // clmSelectRefundItemBorrowedDate
            // 
            this.clmSelectRefundItemBorrowedDate.Text = "Latest Borrow Date";
            this.clmSelectRefundItemBorrowedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSelectRefundItemBorrowedDate.Width = 200;
            // 
            // tbpAcceptRefund
            // 
            this.tbpAcceptRefund.Controls.Add(this.lblAcceptRefundOperationSuccessfulAlert);
            this.tbpAcceptRefund.Controls.Add(this.lblAcceptRefundItemAddedAlert);
            this.tbpAcceptRefund.Controls.Add(this.lblAcceptRefundItemRemovedAlert);
            this.tbpAcceptRefund.Controls.Add(this.lblAcceptRefundSelectedItemCount);
            this.tbpAcceptRefund.Controls.Add(this.btnAcceptSendItemToGarbage);
            this.tbpAcceptRefund.Controls.Add(this.lblAcceptRefundSelectItemsTitle);
            this.tbpAcceptRefund.Controls.Add(this.btnAcceptRefund);
            this.tbpAcceptRefund.Controls.Add(this.mlvSelectRefundItem);
            this.tbpAcceptRefund.Location = new System.Drawing.Point(4, 22);
            this.tbpAcceptRefund.Name = "tbpAcceptRefund";
            this.tbpAcceptRefund.Size = new System.Drawing.Size(761, 504);
            this.tbpAcceptRefund.TabIndex = 2;
            this.tbpAcceptRefund.Text = "Accept Refund";
            this.tbpAcceptRefund.UseVisualStyleBackColor = true;
            // 
            // lblAcceptRefundOperationSuccessfulAlert
            // 
            this.lblAcceptRefundOperationSuccessfulAlert.AutoSize = true;
            this.lblAcceptRefundOperationSuccessfulAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptRefundOperationSuccessfulAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptRefundOperationSuccessfulAlert.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAcceptRefundOperationSuccessfulAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcceptRefundOperationSuccessfulAlert.Location = new System.Drawing.Point(479, 13);
            this.lblAcceptRefundOperationSuccessfulAlert.Name = "lblAcceptRefundOperationSuccessfulAlert";
            this.lblAcceptRefundOperationSuccessfulAlert.Size = new System.Drawing.Size(90, 17);
            this.lblAcceptRefundOperationSuccessfulAlert.TabIndex = 54;
            this.lblAcceptRefundOperationSuccessfulAlert.Text = "Successful!";
            this.lblAcceptRefundOperationSuccessfulAlert.Visible = false;
            // 
            // lblAcceptRefundItemAddedAlert
            // 
            this.lblAcceptRefundItemAddedAlert.AutoSize = true;
            this.lblAcceptRefundItemAddedAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptRefundItemAddedAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptRefundItemAddedAlert.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAcceptRefundItemAddedAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcceptRefundItemAddedAlert.Location = new System.Drawing.Point(511, 11);
            this.lblAcceptRefundItemAddedAlert.Name = "lblAcceptRefundItemAddedAlert";
            this.lblAcceptRefundItemAddedAlert.Size = new System.Drawing.Size(58, 17);
            this.lblAcceptRefundItemAddedAlert.TabIndex = 53;
            this.lblAcceptRefundItemAddedAlert.Text = "Added!";
            this.lblAcceptRefundItemAddedAlert.Visible = false;
            // 
            // lblAcceptRefundItemRemovedAlert
            // 
            this.lblAcceptRefundItemRemovedAlert.AutoSize = true;
            this.lblAcceptRefundItemRemovedAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptRefundItemRemovedAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptRefundItemRemovedAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.lblAcceptRefundItemRemovedAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcceptRefundItemRemovedAlert.Location = new System.Drawing.Point(490, 11);
            this.lblAcceptRefundItemRemovedAlert.Name = "lblAcceptRefundItemRemovedAlert";
            this.lblAcceptRefundItemRemovedAlert.Size = new System.Drawing.Size(79, 17);
            this.lblAcceptRefundItemRemovedAlert.TabIndex = 52;
            this.lblAcceptRefundItemRemovedAlert.Text = "Removed!";
            this.lblAcceptRefundItemRemovedAlert.Visible = false;
            // 
            // lblAcceptRefundSelectedItemCount
            // 
            this.lblAcceptRefundSelectedItemCount.AutoSize = true;
            this.lblAcceptRefundSelectedItemCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptRefundSelectedItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcceptRefundSelectedItemCount.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptRefundSelectedItemCount.Location = new System.Drawing.Point(345, 11);
            this.lblAcceptRefundSelectedItemCount.Name = "lblAcceptRefundSelectedItemCount";
            this.lblAcceptRefundSelectedItemCount.Size = new System.Drawing.Size(120, 17);
            this.lblAcceptRefundSelectedItemCount.TabIndex = 51;
            this.lblAcceptRefundSelectedItemCount.Text = "0 Item Selected";
            // 
            // btnAcceptSendItemToGarbage
            // 
            this.btnAcceptSendItemToGarbage.Activecolor = System.Drawing.Color.Firebrick;
            this.btnAcceptSendItemToGarbage.BackColor = System.Drawing.Color.Firebrick;
            this.btnAcceptSendItemToGarbage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcceptSendItemToGarbage.BorderRadius = 0;
            this.btnAcceptSendItemToGarbage.ButtonText = "GARBAGE";
            this.btnAcceptSendItemToGarbage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptSendItemToGarbage.DisabledColor = System.Drawing.Color.Gray;
            this.btnAcceptSendItemToGarbage.Enabled = false;
            this.btnAcceptSendItemToGarbage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAcceptSendItemToGarbage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAcceptSendItemToGarbage.Iconimage")));
            this.btnAcceptSendItemToGarbage.Iconimage_right = null;
            this.btnAcceptSendItemToGarbage.Iconimage_right_Selected = null;
            this.btnAcceptSendItemToGarbage.Iconimage_Selected = null;
            this.btnAcceptSendItemToGarbage.IconMarginLeft = 0;
            this.btnAcceptSendItemToGarbage.IconMarginRight = 0;
            this.btnAcceptSendItemToGarbage.IconRightVisible = false;
            this.btnAcceptSendItemToGarbage.IconRightZoom = 0D;
            this.btnAcceptSendItemToGarbage.IconVisible = false;
            this.btnAcceptSendItemToGarbage.IconZoom = 60D;
            this.btnAcceptSendItemToGarbage.IsTab = false;
            this.btnAcceptSendItemToGarbage.Location = new System.Drawing.Point(675, 0);
            this.btnAcceptSendItemToGarbage.Name = "btnAcceptSendItemToGarbage";
            this.btnAcceptSendItemToGarbage.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnAcceptSendItemToGarbage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAcceptSendItemToGarbage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAcceptSendItemToGarbage.selected = false;
            this.btnAcceptSendItemToGarbage.Size = new System.Drawing.Size(84, 47);
            this.btnAcceptSendItemToGarbage.TabIndex = 50;
            this.btnAcceptSendItemToGarbage.Text = "GARBAGE";
            this.btnAcceptSendItemToGarbage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAcceptSendItemToGarbage.Textcolor = System.Drawing.Color.White;
            this.btnAcceptSendItemToGarbage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAcceptSendItemToGarbage.Click += new System.EventHandler(this.btnAcceptSendItemToGarbage_Click);
            // 
            // lblAcceptRefundSelectItemsTitle
            // 
            this.lblAcceptRefundSelectItemsTitle.AutoSize = true;
            this.lblAcceptRefundSelectItemsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptRefundSelectItemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcceptRefundSelectItemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(254)))));
            this.lblAcceptRefundSelectItemsTitle.Location = new System.Drawing.Point(2, 6);
            this.lblAcceptRefundSelectItemsTitle.Name = "lblAcceptRefundSelectItemsTitle";
            this.lblAcceptRefundSelectItemsTitle.Size = new System.Drawing.Size(337, 24);
            this.lblAcceptRefundSelectItemsTitle.TabIndex = 49;
            this.lblAcceptRefundSelectItemsTitle.Text = "Select Items You Want To Manage:";
            // 
            // btnAcceptRefund
            // 
            this.btnAcceptRefund.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnAcceptRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnAcceptRefund.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcceptRefund.BorderRadius = 0;
            this.btnAcceptRefund.ButtonText = "REFUND";
            this.btnAcceptRefund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptRefund.DisabledColor = System.Drawing.Color.Gray;
            this.btnAcceptRefund.Enabled = false;
            this.btnAcceptRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAcceptRefund.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAcceptRefund.Iconimage = null;
            this.btnAcceptRefund.Iconimage_right = null;
            this.btnAcceptRefund.Iconimage_right_Selected = null;
            this.btnAcceptRefund.Iconimage_Selected = null;
            this.btnAcceptRefund.IconMarginLeft = 0;
            this.btnAcceptRefund.IconMarginRight = 0;
            this.btnAcceptRefund.IconRightVisible = false;
            this.btnAcceptRefund.IconRightZoom = 0D;
            this.btnAcceptRefund.IconVisible = false;
            this.btnAcceptRefund.IconZoom = 90D;
            this.btnAcceptRefund.IsTab = false;
            this.btnAcceptRefund.Location = new System.Drawing.Point(573, -1);
            this.btnAcceptRefund.Name = "btnAcceptRefund";
            this.btnAcceptRefund.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnAcceptRefund.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.btnAcceptRefund.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAcceptRefund.selected = false;
            this.btnAcceptRefund.Size = new System.Drawing.Size(96, 48);
            this.btnAcceptRefund.TabIndex = 47;
            this.btnAcceptRefund.Text = "REFUND";
            this.btnAcceptRefund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAcceptRefund.Textcolor = System.Drawing.Color.White;
            this.btnAcceptRefund.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptRefund.Click += new System.EventHandler(this.btnAcceptRefund_Click);
            // 
            // mlvSelectRefundItem
            // 
            this.mlvSelectRefundItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvSelectRefundItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAcceptRefundCounter,
            this.clmAcceptRefundItemName,
            this.clmAcceptRefundItemCompanyName});
            this.mlvSelectRefundItem.Depth = 0;
            this.mlvSelectRefundItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvSelectRefundItem.FullRowSelect = true;
            this.mlvSelectRefundItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvSelectRefundItem.Location = new System.Drawing.Point(0, 53);
            this.mlvSelectRefundItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvSelectRefundItem.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvSelectRefundItem.Name = "mlvSelectRefundItem";
            this.mlvSelectRefundItem.OwnerDraw = true;
            this.mlvSelectRefundItem.ShowItemToolTips = true;
            this.mlvSelectRefundItem.Size = new System.Drawing.Size(764, 454);
            this.mlvSelectRefundItem.TabIndex = 19;
            this.mlvSelectRefundItem.UseCompatibleStateImageBehavior = false;
            this.mlvSelectRefundItem.View = System.Windows.Forms.View.Details;
            this.mlvSelectRefundItem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvSelectRefundItem_ItemSelectionChanged);
            // 
            // clmAcceptRefundCounter
            // 
            this.clmAcceptRefundCounter.Text = "#";
            this.clmAcceptRefundCounter.Width = 70;
            // 
            // clmAcceptRefundItemName
            // 
            this.clmAcceptRefundItemName.Text = "Name";
            this.clmAcceptRefundItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmAcceptRefundItemName.Width = 320;
            // 
            // clmAcceptRefundItemCompanyName
            // 
            this.clmAcceptRefundItemCompanyName.Text = "Company Name";
            this.clmAcceptRefundItemCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmAcceptRefundItemCompanyName.Width = 350;
            // 
            // tbsManageRefund
            // 
            this.tbsManageRefund.BaseTabControl = this.tbcManageRefund;
            this.tbsManageRefund.Depth = 0;
            this.tbsManageRefund.Location = new System.Drawing.Point(0, 0);
            this.tbsManageRefund.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbsManageRefund.Name = "tbsManageRefund";
            this.tbsManageRefund.Size = new System.Drawing.Size(783, 40);
            this.tbsManageRefund.TabIndex = 3;
            this.tbsManageRefund.Text = "materialTabSelector1";
            // 
            // tbsManageItems
            // 
            this.tbsManageItems.BaseTabControl = this.tbcManageItems;
            this.tbsManageItems.Depth = 0;
            this.tbsManageItems.Location = new System.Drawing.Point(0, 0);
            this.tbsManageItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbsManageItems.Name = "tbsManageItems";
            this.tbsManageItems.Size = new System.Drawing.Size(774, 40);
            this.tbsManageItems.TabIndex = 1;
            this.tbsManageItems.Text = "materialTabSelector1";
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlManageItems);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(774, 645);
            this.pnlManageItems.ResumeLayout(false);
            this.tbcManageItems.ResumeLayout(false);
            this.tbpBorrowItem.ResumeLayout(false);
            this.tbcBorrow.ResumeLayout(false);
            this.tbpSearchBorrowItem.ResumeLayout(false);
            this.tbpSearchBorrowItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchBorrowItem)).EndInit();
            this.tbpSelectBorrowStock.ResumeLayout(false);
            this.tbpSelectBorrowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchBorrowStock)).EndInit();
            this.tbpSelectBorrowerUser.ResumeLayout(false);
            this.tbpSelectBorrowerUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchBorrower)).EndInit();
            this.tbpAcceptBorrowing.ResumeLayout(false);
            this.tbpAcceptBorrowing.PerformLayout();
            this.pnlAcceptBorrowingFailAlert.ResumeLayout(false);
            this.pnlAcceptBorrowingFailAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAcceptBorrowingFailAlert)).EndInit();
            this.tbpRefund.ResumeLayout(false);
            this.tbcManageRefund.ResumeLayout(false);
            this.tbpSelectRefunder.ResumeLayout(false);
            this.tbpSelectRefunder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectRefunder)).EndInit();
            this.tbpSelectRefundedItem.ResumeLayout(false);
            this.tbpSelectRefundedItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchRefundItem)).EndInit();
            this.tbpAcceptRefund.ResumeLayout(false);
            this.tbpAcceptRefund.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlManageItems;
        private MaterialSkin.Controls.MaterialTabControl tbcManageItems;
        private System.Windows.Forms.TabPage tbpBorrowItem;
        private MaterialSkin.Controls.MaterialTabControl tbcBorrow;
        private System.Windows.Forms.TabPage tbpSearchBorrowItem;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchBorrowItem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchBorrowItem;
        private Bunifu.Framework.UI.BunifuDropdown dropSearchBorrowItemBy;
        private System.Windows.Forms.Label lblSearchBorrowItemSearchBy;
        private MaterialSkin.Controls.MaterialListView mlvSearchBorrowItem;
        private System.Windows.Forms.ColumnHeader clmSearchBorrowItemName;
        private System.Windows.Forms.ColumnHeader clmSearchBorrowItemDescription;
        private System.Windows.Forms.ColumnHeader clmSearchBorrowItemStock;
        private System.Windows.Forms.ColumnHeader clmSearchBorrowItemBorroweds;
        private System.Windows.Forms.TabPage tbpSelectBorrowStock;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchBorrowStock;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchBorrowStock;
        private System.Windows.Forms.Label lblSearchBorrowStockSearchByTitle;
        private MaterialSkin.Controls.MaterialListView mlvSearchBorrowStock;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowStockCompanyName;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowStockQuantity;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowStockCreatedAt;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowStockUpdatedAt;
        private System.Windows.Forms.TabPage tbpSelectBorrowerUser;
        private MaterialSkin.Controls.MaterialListView mlvSelectBorrowerUsers;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowerCount;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowerUsername;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowerFirstName;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowerLastName;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowerDepartmentName;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowerRoleName;
        private System.Windows.Forms.ColumnHeader clmSelectBorrowerBorrows;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchBorrower;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchBorrower;
        private Bunifu.Framework.UI.BunifuDropdown dropSelectBorrowerUserDepartment;
        private System.Windows.Forms.Label lblSelectBorrowerDepartment;
        private System.Windows.Forms.TabPage tbpAcceptBorrowing;
        private System.Windows.Forms.Panel pnlAcceptBorrowingFailAlert;
        private System.Windows.Forms.Label lblAcceptBorrowingFailAlert2;
        private System.Windows.Forms.Label lblAcceptBorrowingFailAlert1;
        private System.Windows.Forms.PictureBox pboxAcceptBorrowingFailAlert;
        private Bunifu.Framework.UI.BunifuFlatButton btnAcceptBorrowingCharge;
        private System.Windows.Forms.Label lblAcceptBorrowingAlreadyBorrowed;
        private System.Windows.Forms.Label lblAcceptBorrowingDepartmentName;
        private System.Windows.Forms.Label lblAcceptBorrowingFullName;
        private System.Windows.Forms.Label lblAcceptBorrowingUsername;
        private System.Windows.Forms.Label lblAcceptBorrowingBorrowed;
        private System.Windows.Forms.Label lblAcceptBorrowingInStock;
        private System.Windows.Forms.Label lblAcceptBorrowingItemName;
        private System.Windows.Forms.Label lblAcceptBorrowingItemId;
        private Bunifu.Framework.UI.BunifuDropdown dropBorrowItemCount;
        private System.Windows.Forms.Label lblAcceptBorrowingBorrowedQuantityTitle;
        private System.Windows.Forms.Label lblAcceptBorrowingBorrowerDetailsBorrowed;
        private System.Windows.Forms.Label lblAcceptBorrowingBorrowerDetailsDepartment;
        private System.Windows.Forms.Label lblAcceptBorrowingBorrowerDetailsFirstName;
        private System.Windows.Forms.Label lblAcceptBorrowingBorrowerDetailsUsername;
        private System.Windows.Forms.Label lblAcceptBorrowingBorrowerDetailsTitle;
        private System.Windows.Forms.Label lblAcceptBorrowingItemDetailsBorrowed;
        private System.Windows.Forms.Label lblAcceptBorrowingItemDetailsInStock;
        private System.Windows.Forms.Label lblAcceptBorrowingItemDetailsItemName;
        private System.Windows.Forms.Label lblAcceptBorrowingItemDetailsItemId;
        private System.Windows.Forms.Label lblAcceptBorrowingItemDetailsTitle;
        private MaterialSkin.Controls.MaterialTabSelector tbsManageBorrow;
        private System.Windows.Forms.TabPage tbpRefund;
        private MaterialSkin.Controls.MaterialTabControl tbcManageRefund;
        private System.Windows.Forms.TabPage tbpSelectRefunder;
        private Bunifu.Framework.UI.BunifuDropdown dropSelectRefunderDepartment;
        private MaterialSkin.Controls.MaterialListView mlvSelectRefunderUser;
        private System.Windows.Forms.ColumnHeader clmBorrowerNumber;
        private System.Windows.Forms.ColumnHeader clmBorrowerUsername;
        private System.Windows.Forms.ColumnHeader clmBorrowerFullName;
        private System.Windows.Forms.ColumnHeader clmBorrowerDepartmentName;
        private System.Windows.Forms.ColumnHeader clmNumberOfBorrows;
        private System.Windows.Forms.ColumnHeader clmNumberOfDifferentBorrows;
        private Bunifu.Framework.UI.BunifuImageButton btnSelectRefunder;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSelectRefunder;
        private Bunifu.Framework.UI.BunifuDropdown dropSelectRefunderSearchBy;
        private System.Windows.Forms.Label lblSelectBorrowerSearchByTitle;
        private System.Windows.Forms.TabPage tbpSelectRefundedItem;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchRefundItem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchRefundItem;
        private Bunifu.Framework.UI.BunifuDropdown dropSelectRefundItemSearchBy;
        private System.Windows.Forms.Label lblSearchRefundItemSearchByTitle;
        private MaterialSkin.Controls.MaterialListView mlvSelectRefundItemStock;
        private System.Windows.Forms.ColumnHeader clmSelectRefundItemCount;
        private System.Windows.Forms.ColumnHeader clmSelectRefundItemName;
        private System.Windows.Forms.ColumnHeader clmSelectRefundItemCompanyName;
        private System.Windows.Forms.ColumnHeader clmSelectRefundItemBorrowings;
        private System.Windows.Forms.ColumnHeader clmSelectRefundItemBorrowedDate;
        private System.Windows.Forms.TabPage tbpAcceptRefund;
        private System.Windows.Forms.Label lblAcceptRefundOperationSuccessfulAlert;
        private System.Windows.Forms.Label lblAcceptRefundItemAddedAlert;
        private System.Windows.Forms.Label lblAcceptRefundItemRemovedAlert;
        private System.Windows.Forms.Label lblAcceptRefundSelectedItemCount;
        private Bunifu.Framework.UI.BunifuFlatButton btnAcceptSendItemToGarbage;
        private System.Windows.Forms.Label lblAcceptRefundSelectItemsTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnAcceptRefund;
        private MaterialSkin.Controls.MaterialListView mlvSelectRefundItem;
        private System.Windows.Forms.ColumnHeader clmAcceptRefundCounter;
        private System.Windows.Forms.ColumnHeader clmAcceptRefundItemName;
        private System.Windows.Forms.ColumnHeader clmAcceptRefundItemCompanyName;
        private MaterialSkin.Controls.MaterialTabSelector tbsManageRefund;
        private MaterialSkin.Controls.MaterialTabSelector tbsManageItems;
    }
}
