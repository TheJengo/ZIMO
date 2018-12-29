using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZIMO.App.Extensions;
using ZIMO.App.Utils;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms.Sales_Controls
{
    public partial class ItemControl : UserControl
    {
        private ISalesController userController;

        public ItemControl()
        {
            InitializeComponent();
        }

        // Set userController informations and start the controller UI
        public void SetAuthorization(ISalesController userController)
        {
            this.userController = userController;
            InitializeDetails();
        }

        private IList<User> Users;
        private IList<Item> Items;
        private IList<Stock> Stocks;
        private IList<Borrow> Borrows;
        private IList<Department> Departments;
        private Item selectedBorrowItem;
        private User selectedBorrowerUser;
        private Stock selectedBorrowStock;
        private int selectedBorrowerUserIndex = -1;
        private int selectedBorrowItemIndex = -1;
        private int selectedBorrowStockIndex = -1;
        private void InitializeDetails()
        {
            tbcManageItems.SelectedTab = tbpBorrowItem;
            tbcBorrow.SelectedTab = tbpSearchBorrowItem;
            tbpSelectBorrowerUser.Visible = false;
            
            // Borrow Tab
            Items = userController.GetItems(false);
            selectedBorrowItemIndex = -1;
            ListUtil.InitializeListView(mlvSearchBorrowItem, Items);

            // Refund Tab
            RefundItems = userController.GetItems(true);
            Borrows = RefundItems.SelectMany(x => x.Borrows.Where(y => !y.IsReturn)).ToList();
            ListUtil.InitializeListView(mlvSelectRefunderUser, Borrows, userController.GetAllUsers(true));


            Departments = userController.GetDepartments();
            ListUtil.InitializeDropdownList(dropSelectRefunderDepartment, Departments);

        }

        // Item List Selected Operations
        private void mlvSearchBorrowItem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedBorrowItemIndex = mlvSearchBorrowItem.FocusedItem.Index;
                selectedBorrowItem = Items.ElementAt(selectedBorrowItemIndex);

                Stocks = selectedBorrowItem.Stocks.Count != 0 ? selectedBorrowItem.Stocks.ToList() : new List<Stock>();
                ListUtil.InitializeListView(mlvSearchBorrowStock, Stocks);

                tbcBorrow.SelectedTab = tbpSelectBorrowStock;
            }
        }

        // Search By dropdown operations in Select Item screen
        private void dropSearchBorrowItemBy_onItemSelected(object sender, EventArgs e)
        {
            switch (dropSearchBorrowItemBy.selectedIndex)
            {
                case 1:
                    Items = userController.GetItems(false)
                        .Where(x => x.Description.ToLower().Contains(txtSearchBorrowItem.Text.ToLower())).ToList();
                    break;
                default:
                    Items = userController.GetItems(false)
                        .Where(x => x.Name.ToLower().Contains(txtSearchBorrowItem.Text.ToLower())).ToList();
                    break;
            }
            ListUtil.InitializeListView(mlvSearchBorrowItem, Items);
        }

        // Search Textbox operations in Select Item Screen
        private void txtSearchBorrowItem_OnValueChanged(object sender, EventArgs e)
        {
            txtSearchBorrowItem.Text = txtSearchBorrowItem.MaximumLength(200);
            dropSearchBorrowItemBy_onItemSelected(this, e);
        }

        // Search borrow item operations
        private void mlvSearchBorrowStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedBorrowStockIndex = mlvSearchBorrowStock.FocusedItem.Index;
                selectedBorrowStock = Stocks.ElementAt(selectedBorrowStockIndex);

                Users = userController.GetAllUsers(false);
                Departments = userController.GetDepartments();

                ListUtil.InitializeListView(mlvSelectBorrowerUsers, Users);
                ListUtil.InitializeDropdownList(dropSelectBorrowerUserDepartment, Departments);

                tbcBorrow.SelectedTab = tbpSelectBorrowerUser;
            }
        }

        private void txtSearchBorrowStock_OnValueChanged(object sender, EventArgs e)
        {
            txtSearchBorrowStock.Text = txtSearchBorrowStock.MaximumLength(200);
            if (selectedBorrowItem != null)
            {
                if (TextUtil.IsNull(txtSearchBorrowStock.Text))
                    Stocks = selectedBorrowItem.Stocks.ToList();
                else
                    Stocks = selectedBorrowItem.Stocks.Where(x => x.CompanyName.ToLower().Contains(txtSearchBorrowStock.Text.ToLower())).ToList();

                ListUtil.InitializeListView(mlvSearchBorrowStock, Stocks);
            }
        }

        // Select Borrower User Screen Dropdownbox operations
        private void dropSelectBorrowerUserDepartment_onItemSelected(object sender, EventArgs e)
        {
            switch (dropSelectBorrowerUserDepartment.selectedIndex)
            {
                case -1:
                    Users = userController.GetAllUsers(false)
                        .Where(x => x.Employee.FirstName.ToLower()
                                        .Contains(txtSearchBorrower.Text.ToLower()) ||
                                    x.Employee.FirstName.ToLower()
                                        .Contains(txtSearchBorrower.Text.ToLower()))
                        .ToList();
                    break;
                default:
                    Users = userController.GetAllUsers(false).Where(x =>
                        x.Department.Name.Equals(dropSelectBorrowerUserDepartment.selectedValue))
                        .Where(x => x.Employee.FirstName.ToLower()
                                        .Contains(txtSearchBorrower.Text.ToLower()) ||
                                    x.Employee.FirstName.ToLower()
                                        .Contains(txtSearchBorrower.Text.ToLower()))
                        .ToList();
                    break;
            }
            ListUtil.InitializeListView(mlvSelectBorrowerUsers, Users);
        }

        private void txtSearchBorrower_OnValueChanged(object sender, EventArgs e)
        {
            txtSearchBorrower.Text = txtSearchBorrower.MaximumLength(200);
            dropSelectBorrowerUserDepartment_onItemSelected(this, e);
        }

        // Select Borrower User and set the acceptance page
        private void mlvSelectBorrowerUsers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedBorrowerUserIndex = mlvSelectBorrowerUsers.FocusedItem.Index;
                selectedBorrowerUser = Users.ElementAt(selectedBorrowerUserIndex);

                if (selectedBorrowerUser != null && selectedBorrowItem != null && selectedBorrowStock != null)
                {
                    // Set Item Details
                    lblAcceptBorrowingItemId.Text = selectedBorrowItem.Id.ToString();
                    lblAcceptBorrowingItemName.Text = selectedBorrowItem.Name;

                    lblAcceptBorrowingInStock.Text = selectedBorrowStock.Quantity.ToString();
                    lblAcceptBorrowingBorrowed.Text = selectedBorrowItem.Borroweds.ToString();

                    // Set Borrower User Details
                    lblAcceptBorrowingUsername.Text = selectedBorrowerUser.Username;
                    lblAcceptBorrowingFullName.Text = selectedBorrowerUser.Employee.FirstName + " " +
                                                      selectedBorrowerUser.Employee.LastName;
                    lblAcceptBorrowingDepartmentName.Text = selectedBorrowerUser.Department.Name;
                    lblAcceptBorrowingAlreadyBorrowed.Text =
                        selectedBorrowerUser.Borrows.FirstOrDefault(x => x.Item_Id.Equals(selectedBorrowItem.Id)) != null
                            ? "Yes"
                            : "No";
                    ListUtil.InitializeDropdownList(dropBorrowItemCount, selectedBorrowStock);
                }

                tbcBorrow.SelectedTab = tbpAcceptBorrowing;
            }
        }

        // Start Borrowing Operations
        private void btnAcceptBorrowingBorrow_Click(object sender, EventArgs e)
        {
            Items = userController.GetItems(false);
            if(selectedBorrowItem != null && selectedBorrowStock != null)
                selectedBorrowItem = Items.FirstOrDefault(x => x.Id.Equals(selectedBorrowItem.Id));
            else
            {
                AnimationUtil.ShowSync(pnlAcceptBorrowingFailAlert);
                return;
            }

            int quantity = Convert.ToInt32(dropBorrowItemCount.selectedValue);
            if (selectedBorrowItem != null && selectedBorrowItem.InStock >= quantity)
            {
                userController.ChargeItem(selectedBorrowItem, selectedBorrowStock, selectedBorrowerUser, quantity);

                Items = userController.GetItems(false);
                ListUtil.InitializeListView(mlvSearchBorrowItem, Items);

                //Borrows = Items.SelectMany(x => x.Borrows).Where(x => x.IsReturn == false).ToList();
                tbcBorrow.SelectedTab = tbpSearchBorrowItem;

                ClearManageBorrowItem();
            }
            else
            {
                AnimationUtil.ShowSync(pnlAcceptBorrowingFailAlert);
            }
            InitializeDetails();
        }

        private void dropBorrowItemCount_onItemSelected(object sender, EventArgs e)
        {
            switch (dropBorrowItemCount.selectedValue)
            {
                case "0":
                    btnAcceptBorrowingCharge.Enabled = false;
                    break;
                default:
                    btnAcceptBorrowingCharge.Enabled = true;
                    break;
            }
        }

        private void ClearManageBorrowItem()
        {
            selectedBorrowItem = null;
            selectedBorrowerUser = null;
            selectedBorrowStock = null;
            txtSearchBorrower.Text = "";
            txtSearchBorrowStock.Text = "";
            txtSearchBorrowItem.Text = "";
            lblAcceptBorrowingBorrowed.Text = "";
            lblAcceptBorrowingItemId.Text = "";
            lblAcceptBorrowingAlreadyBorrowed.Text = "";
            lblAcceptBorrowingInStock.Text = "";
            lblAcceptBorrowingItemName.Text = "";
            lblAcceptBorrowingUsername.Text = "";
            lblAcceptBorrowingFullName.Text = "";
            lblAcceptBorrowingItemId.Text = "";
            lblAcceptBorrowingDepartmentName.Text = "";
            pnlAcceptBorrowingFailAlert.Visible = false;
            btnAcceptBorrowingCharge.Enabled = false;
            mlvSelectBorrowerUsers.Items.Clear();
            mlvSearchBorrowStock.Items.Clear();
        }
        /* REFUNDING */
        private IList<Item> RefundItems;
        private void dropSelectRefunderSearchBy_onItemSelected(object sender, EventArgs e)
        {
            dropSelectRefunderDepartment_onItemSelected(this, e);
            switch (dropSelectRefunderSearchBy.selectedIndex)
            {
                case 1:
                    Users = Users.Where(x => x.Employee.FirstName.ToLower().Contains(txtSelectRefunder.Text.ToLower())
                                    || x.Employee.LastName.ToLower().Contains(txtSelectRefunder.Text.ToLower())).ToList();
                    break;
                default:
                    Users = Users.Where(x => x.Username.ToLower().Contains(txtSelectRefunder.Text.ToLower())).ToList();
                    break;
            }

            Borrows = RefundItems.SelectMany(x => x.Borrows.Where(y => !y.IsReturn)).ToList().Where(x => Users.Any(y => y.Id.Equals(x.User_Id))).ToList();
            ListUtil.InitializeListView(mlvSelectRefunderUser, Borrows, Users);
        }

        private void txtSelectRefunder_OnValueChanged(object sender, EventArgs e)
        {
            txtSelectRefunder.Text = txtSelectRefunder.MaximumLength(200);
            dropSelectRefunderSearchBy_onItemSelected(this, e);
        }

        // Select Refunders department dropbox
        private void dropSelectRefunderDepartment_onItemSelected(object sender, EventArgs e)
        {
            Users = userController.GetAllUsers(false)
                    .Where(x => x.Department.Name.Equals(dropSelectRefunderDepartment.selectedValue)).ToList();

            Borrows = RefundItems.SelectMany(x => x.Borrows.Where(y => !y.IsReturn)).ToList().Where(x => Users.Any(y => y.Id.Equals(x.User_Id))).ToList();
            ListUtil.InitializeListView(mlvSelectRefunderUser, Borrows, Users);
        }

        private List<int> SelectedItems;
        private User selectedRefunderUser;
        private Borrow selectedRefundBorrow;
        private int selectedRefunderUserIndex = -1;
        private int selectedRefundedItemStock = -1;

        // Select Refunder User
        private void mlvSelectRefunderUser_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedRefunderUserIndex = mlvSelectRefunderUser.FocusedItem.Index;
                selectedRefunderUser = Users.ElementAt(selectedRefunderUserIndex);

                RefundItems = userController.GetItems(true).Where(x=>x.Borrows.Any(y=>!y.IsReturn)).ToList();
                ListUtil.InitializeListView(mlvSelectRefundItemStock, selectedRefunderUser.Borrows.Where(x=>!x.IsReturn).ToList(), RefundItems);

                selectedRefundedItemStock = -1;
                tbcManageRefund.SelectedTab = tbpSelectRefundedItem;
            }
        }

        private void dropSelectRefundItemSearchBy_onItemSelected(object sender, EventArgs e)
        {
            switch (dropSelectRefundItemSearchBy.selectedIndex)
            {
                case 1:
                    RefundItems = userController.GetItems(true)
                        .Where(x => x.Stocks.Any(y => y.CompanyName.ToLower().Contains(txtSearchRefundItem.Text.ToLower()))).ToList();
                    break;
                default:
                    RefundItems = userController.GetItems(true)
                        .Where(x => x.Name.ToLower().Contains(txtSearchRefundItem.Text.ToLower())).ToList();
                    break;
            }

            if (selectedRefunderUser != null)
            {
                Borrows = selectedRefunderUser.Borrows.Where(x=>!x.IsReturn).ToList().Where(x => RefundItems.Any(y => y.Id.Equals(x.Item_Id))).ToList();
                ListUtil.InitializeListView(mlvSelectRefundItemStock, Borrows, RefundItems);
            }
        }

        private void txtSearchRefundItem_OnValueChanged(object sender, EventArgs e)
        {
            txtSearchRefundItem.Text = txtSearchRefundItem.MaximumLength(200);
            dropSelectRefundItemSearchBy_onItemSelected(this, e);
        }

        private Item selectedItem;
        //Select Item Stock
        private void mlvSelectRefundItemStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedRefundedItemStock = mlvSelectRefundItemStock.FocusedItem.Index;
                selectedRefundBorrow = selectedRefunderUser.Borrows.Where(x=>!x.IsReturn).ElementAt(selectedRefundedItemStock);
                selectedItem = RefundItems.FirstOrDefault(x => x.Id.Equals(selectedRefundBorrow.Item_Id));

                SelectedItems = new List<int>();
                ListUtil.InitializeListView(mlvSelectRefundItem, Borrows.Where(x => x.Id.Equals(selectedRefundBorrow.Id)).ToList(), RefundItems, (int)selectedRefundBorrow.Quantity);
                tbcManageRefund.SelectedTab = tbpAcceptRefund;
            }
        }

        // Select Items
        private int selectedItemIndex = -1;
        private void mlvSelectRefundItem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedItemIndex = mlvSelectRefundItem.FocusedItem.Index;
                if (!SelectedItems.Contains(selectedItemIndex))
                {
                    SelectedItems.Add(selectedItemIndex);
                    lblAcceptRefundOperationSuccessfulAlert.Visible = false;
                    lblAcceptRefundItemRemovedAlert.Visible = false;
                    lblAcceptRefundItemAddedAlert.Visible = true;
                }
                else
                {
                    SelectedItems.Remove(selectedItemIndex);
                    lblAcceptRefundOperationSuccessfulAlert.Visible = false;
                    lblAcceptRefundItemAddedAlert.Visible = false;
                    lblAcceptRefundItemRemovedAlert.Visible = true;
                }

                lblAcceptRefundSelectedItemCount.Text = (SelectedItems.Count == 0 || SelectedItems.Count == 1)
                    ? SelectedItems.Count + " Item Selected"
                    : SelectedItems.Count + " Items Selected";

                if (SelectedItems.Count > 0)
                {
                    btnAcceptRefund.Enabled = true;
                    btnAcceptSendItemToGarbage.Enabled = true;
                }
                else
                {
                    btnAcceptRefund.Enabled = false;
                    btnAcceptSendItemToGarbage.Enabled = false;
                }
            }
        }

        // Start Refunding operations
        private void btnAcceptRefund_Click(object sender, EventArgs e)
        {
            userController.RefundItem(selectedItem, selectedItem.Stocks.First(x => x.Id.Equals(selectedRefundBorrow.Stock_Id)), selectedRefunderUser, SelectedItems.Count);
            if (SelectedItems.Count == selectedRefundBorrow.Quantity)
            {
                tbcManageRefund.SelectedTab = tbpSelectRefunder;
                ClearManageRefundItem();
            }
            else
            {
                UpdateRefundItemList();

                lblAcceptRefundSelectedItemCount.Text = "0 Item Selected";
                lblAcceptRefundItemAddedAlert.Visible = false;
                lblAcceptRefundItemRemovedAlert.Visible = false;
                lblAcceptRefundOperationSuccessfulAlert.Visible = true;
            }

            InitializeDetails();
        }

        private void ClearManageRefundItem()
        {
            selectedRefunderUser = null;
            selectedRefundBorrow = null;
            SelectedItems.Clear();
            txtSearchRefundItem.Text = "";
            txtSelectRefunder.Text = "";
            lblAcceptRefundSelectedItemCount.Text = "";
            btnAcceptRefund.Enabled = false;
            btnAcceptSendItemToGarbage.Enabled = false;
            lblAcceptRefundItemAddedAlert.Visible = false;
            lblAcceptRefundItemRemovedAlert.Visible = false;
            lblAcceptRefundOperationSuccessfulAlert.Visible = false;
            mlvSelectRefunderUser.Items.Clear();
            mlvSelectRefundItem.Items.Clear();
            mlvSelectRefundItemStock.Items.Clear();
        }

        private void UpdateRefundItemList()
        {
            selectedItemIndex = -1;
            RefundItems = userController.GetItems(true);
            Borrows = RefundItems.SelectMany(x => x.Borrows).Where(x => x.IsReturn == false).ToList();

            if (selectedRefundBorrow != null)
            {
                selectedRefundBorrow = Borrows.First(x => x.Item_Id.Equals(selectedItem.Id)
                                                          && x.User_Id.Equals(selectedRefunderUser.Id));
                ListUtil.InitializeListView(mlvSelectRefundItem,
                    Borrows.Where(x => x.Id.Equals(selectedRefundBorrow.Id)).ToList(), RefundItems,
                    (int) selectedRefundBorrow.Quantity);
            }

        }
        
        // Sending Borrowed Items To The Garbage
        private void btnAcceptSendItemToGarbage_Click(object sender, EventArgs e)
        {
            if (selectedRefundBorrow != null)
            {
                userController.AddGarbage(selectedRefundBorrow, SelectedItems.Count);
                if (SelectedItems.Count == selectedRefundBorrow.Quantity)
                {
                    tbcManageRefund.SelectedTab = tbpSelectRefunder;
                    ClearManageRefundItem();
                }
                else
                {
                    UpdateRefundItemList();

                    lblAcceptRefundItemAddedAlert.Visible = false;
                    lblAcceptRefundItemRemovedAlert.Visible = false;
                    lblAcceptRefundOperationSuccessfulAlert.Visible = true;
                }
                InitializeDetails();
            }
        }
    }
}
