using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZIMO.App.Extensions;
using ZIMO.App.Utils;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms.Sales_Controls
{
    public partial class StockControl : UserControl
    {
        private ISalesController userController;
        public StockControl()
        {
            InitializeComponent();
        }

        // Set userController informations and start the controller UI
        public void SetAuthorization(ISalesController userController)
        {
            this.userController = userController;
            InitializeDetails();
        }

        private IList<Item> BorrowItems;
        private IList<Item> Items;
        private IList<Stock> Stocks;
        private Stock selectedStock;
        private Item selectedStockItem;
        private int selectedStockIndex = -1;
        private int selectedStockItemIndex = -1;
        private void InitializeDetails()
        {
            // Search Stock Tab
            Stocks = userController.GetItems(true).SelectMany(x => x.Stocks).ToList();
            ListUtil.InitializeListView(mlvSearchStock, Stocks, userController.GetItems(true));

            // Add Stock Tab
            BorrowItems = userController.GetItems(true).ToList();
            ListUtil.InitializeListView(mlvSearchItemForAddStock, BorrowItems);

            // Add Item Tab
            Items = userController.GetItems(true).ToList();
            ListUtil.InitializeListView(mlvAddItemSearch, Items);
        }
        /* Search STOCK to UPDATE */
        private void mlvSearchStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedStockIndex = mlvSearchStock.FocusedItem.Index;
                selectedStock = Stocks.ElementAt(selectedStockIndex);

                txtUpdateStockItemDescription.Text = selectedStock.Item.Description;
                txtUpdateStockItemName.Text = selectedStock.Item.Name;
                txtUpdateStockCompanyName.Text = selectedStock.CompanyName;
                txtUpdateStockUnitPrice.Text = selectedStock.UnitPrice.ToString();
                txtUpdateStockQuantity.Text = selectedStock.Quantity.ToString();

                btnUpdateStock.Enabled = true;
                btnDeleteStock.Enabled = true;
                AnimationUtil.HideSync(pnlUpdateStockSuccessfulAlert);
                AnimationUtil.HideSync(pnlUpdateStockFailAlert);
                tbcStock.SelectedTab = tbpUpdateStock;
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (!TextUtil.IsNull(txtUpdateStockCompanyName.Text) &&
                !TextUtil.IsNull(txtUpdateStockUnitPrice.Text) &&
                !TextUtil.IsNull(txtUpdateStockQuantity.Text) &&
                TextUtil.IsDigit(txtUpdateStockQuantity.Text) &&
                TextUtil.IsMoney(txtUpdateStockUnitPrice.Text))
            {
                selectedStock.Quantity = Convert.ToInt32(txtUpdateStockQuantity.Text);
                selectedStock.UnitPrice = TextUtil.ParseMoney(txtUpdateStockUnitPrice.Text);
                selectedStock.TotalPrice = selectedStock.Quantity * selectedStock.UnitPrice;
                selectedStock.UpdatedAt = DateTime.Now;
                selectedStock.CompanyName = txtUpdateStockCompanyName.Text;
                userController.ManageStock(selectedStock, EntityState.Modified);

                AnimationUtil.HideSync(pnlUpdateStockFailAlert);
                AnimationUtil.ShowSync(pnlUpdateStockSuccessfulAlert);
                btnUpdateStock.Enabled = false;
            }
            else
            {
                AnimationUtil.HideSync(pnlUpdateStockSuccessfulAlert);
                AnimationUtil.ShowSync(pnlUpdateStockFailAlert);
            }
            Stocks = userController.GetItems(true).SelectMany(x => x.Stocks).ToList();
            ListUtil.InitializeListView(mlvSearchStock, Stocks, userController.GetItems(true));
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (selectedStock != null && selectedStock.Quantity != 0)
            {
                userController.AddGarbage(selectedStock, Convert.ToInt32(selectedStock.Quantity));

                AnimationUtil.HideSync(pnlUpdateStockFailAlert);
                AnimationUtil.ShowSync(pnlUpdateStockSuccessfulAlert);
            }
            else
            {
                AnimationUtil.HideSync(pnlUpdateStockSuccessfulAlert);
                AnimationUtil.ShowSync(pnlUpdateStockFailAlert);
            }
            Stocks = userController.GetItems(true).SelectMany(x => x.Stocks).ToList();
            ListUtil.InitializeListView(mlvSearchStock, Stocks, userController.GetItems(true));
        }

        private void dropSearchItem_onItemSelected(object sender, EventArgs e)
        {
            switch (dropSearchItem.selectedIndex)
            {
                case 1:
                    BorrowItems = userController.GetItems(false)
                        .Where(x => x.Description.ToLower().Contains(txtSearchItemToAddStock.Text.ToLower())).ToList();
                    break;
                default:
                    BorrowItems = userController.GetItems(false)
                        .Where(x => x.Name.ToLower().Contains(txtSearchItemToAddStock.Text.ToLower())).ToList();
                    break;
            }

            ListUtil.InitializeListView(mlvSearchStock, BorrowItems);
        }

        private void dropSearchStockSearchBy_onItemSelected(object sender, EventArgs e)
        {
            IList<Item> searchItems = userController.GetItems(false);
            switch (dropSearchStockSearchBy.selectedIndex)
            {
                case 1:
                    searchItems = searchItems
                        .Where(x => x.Stocks.Any(y => y.CompanyName.ToLower().Contains(txtSearchStock.Text.ToLower()))).ToList();
                    break;
                default:
                    searchItems = searchItems
                        .Where(x => x.Name.ToLower().Contains(txtSearchStock.Text.ToLower())).ToList();
                    break;
            }

            Stocks = searchItems.SelectMany(x => x.Stocks).ToList();
            ListUtil.InitializeListView(mlvSearchStock, Stocks, searchItems);

        }

        private void txtSearchStock_OnValueChanged(object sender, EventArgs e)
        {
            txtSearchStock.Text = txtSearchStock.MaximumLength(200);
            dropSearchStockSearchBy_onItemSelected(this, e);
        }

        /* Search Item To Add NEW Stock In It */
        private void mlvSearchItemForAddStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedStockItemIndex = mlvSearchItemForAddStock.FocusedItem.Index;
                selectedStockItem = BorrowItems.ElementAt(selectedStockItemIndex);

                lblAddStockItemName.Text = selectedStockItem.Name;
                if(selectedStockItem.Description.Length > 150)
                    lblAddStockItemDescription.Text = selectedStockItem.Description.Substring(0,150);
                else
                    lblAddStockItemDescription.Text = selectedStockItem.Description;

                lblAddStockItemStockQuantity.Text = selectedStockItem.Stocks.Count.ToString();


                AnimationUtil.HideSync(pnlAddStockFailAlert);
                AnimationUtil.HideSync(pnlAddStockSuccessAlert);
                tbcAddStock.SelectedTab = tbpAddStock;
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (!TextUtil.IsNull(txtAddStockCompanyName.Text) &&
                !TextUtil.IsNull(txtAddStockUnitPrice.Text) &&
                !TextUtil.IsNull(txtAddStockQuantity.Text) &&
                TextUtil.IsDigit(txtAddStockQuantity.Text) &&
                TextUtil.IsMoney(txtAddStockUnitPrice.Text))
            {
                Stock stock = new Stock()
                {
                    Item_Id = selectedStockItem.Id,
                    CompanyName = txtAddStockCompanyName.Text,
                    Quantity = Convert.ToInt32(txtAddStockQuantity.Text),
                    UnitPrice = TextUtil.ParseMoney(txtAddStockUnitPrice.Text),
                    TotalPrice = Convert.ToInt32(txtAddStockQuantity.Text) * TextUtil.ParseMoney(txtAddStockUnitPrice.Text),
                    CreatedAt = DateTime.Now,
                };
                userController.ManageStock(stock, EntityState.Added);

                int lastStockCount = Convert.ToInt32(lblAddStockItemStockQuantity.Text);
                lblAddStockItemStockQuantity.Text = lastStockCount++.ToString();

                AnimationUtil.HideSync(pnlAddStockFailAlert);
                AnimationUtil.ShowSync(pnlAddStockSuccessAlert);
            }
            else
            {
                AnimationUtil.HideSync(pnlAddStockSuccessAlert);
                AnimationUtil.ShowSync(pnlAddStockFailAlert);
            }
            BorrowItems = userController.GetItems(true).ToList();
            ListUtil.InitializeListView(mlvSearchItemForAddStock, BorrowItems);
        }

        private void btnResetAddStock_Click(object sender, EventArgs e)
        {
            txtUpdateStockCompanyName.Text = "";
            txtUpdateStockUnitPrice.Text = "";
            txtUpdateStockQuantity.Text = "";
        }

        private void dropAddItemSearchBy_onItemSelected(object sender, EventArgs e)
        {
            switch (dropAddItemSearchBy.selectedIndex)
            {
                case 1:
                    Items = userController.GetItems(withPassives)
                        .Where(x => x.Description.ToLower().Contains(txtAddItemSearch.Text.ToLower())).ToList();
                    break;
                default:
                    Items = userController.GetItems(withPassives)
                        .Where(x => x.Name.ToLower().Contains(txtAddItemSearch.Text.ToLower())).ToList();
                    break;
            }

            ListUtil.InitializeListView(mlvAddItemSearch, Items);
        }
        
        private void txtSearchItemToAddStock_OnValueChanged(object sender, EventArgs e)
        {
            txtSearchItemToAddStock.Text = txtSearchItemToAddStock.MaximumLength(200);
            dropSearchItem_onItemSelected(this, e);
        }

        /* Manage Items */
        private Item managedItem;
        private int selectedManageItemIndex = -1;
        private void mlvAddItemSearch_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedManageItemIndex = mlvAddItemSearch.FocusedItem.Index;
                managedItem = Items.ElementAt(selectedManageItemIndex);

                txtUpdateItemName.Text = managedItem.Name;
                txtUpdateItemDescription.Text = managedItem.Description;
                btnUpdateItem.Enabled = true;
                btnDeleteItem.Enabled = true;
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (!TextUtil.IsNull(txtUpdateItemName.Text) && !TextUtil.IsNull(txtUpdateItemDescription.Text))
            {
                managedItem.Name = txtUpdateItemName.Text;
                managedItem.Description = txtUpdateItemDescription.Text;
                userController.ManageItem(managedItem, EntityState.Modified);
                lblUpdateItemFailAlert.Visible = false;
                lblUpdateItemSuccessfulAlert.Visible = true;
            }
            else
            {
                lblUpdateItemSuccessfulAlert.Visible = false;
                lblUpdateItemFailAlert.Visible = true;
            }

            selectedManageItemIndex = -1;
            managedItem = null;
            Items = userController.GetItems(true).ToList();
            ListUtil.InitializeListView(mlvAddItemSearch, Items);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (managedItem != null )
            {
                userController.ManageItem(managedItem, EntityState.Deleted);
                lblUpdateItemFailAlert.Visible = false;
                lblUpdateItemSuccessfulAlert.Visible = true;
            }
            else
            {
                lblUpdateItemSuccessfulAlert.Visible = false;
                lblUpdateItemFailAlert.Visible = true;
            }
            Items = userController.GetItems(true).ToList();
            ListUtil.InitializeListView(mlvAddItemSearch, Items);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!TextUtil.IsNull(txtAddItemName.Text) && !TextUtil.IsNull(txtAddItemDescription.Text))
            {
                Item item = new Item()
                {
                    Name = txtAddItemName.Text,
                    Description = txtAddItemDescription.Text,
                    IsActive = true,
                };
                userController.ManageItem(item, EntityState.Added);
                lblAddItemFailAlert.Visible = false;
                lblAddItemSuccessfulAlert.Visible = true;
            }
            else
            {
                lblAddItemSuccessfulAlert.Visible = false;
                lblAddItemFailAlert.Visible = true;
            }
            Items = userController.GetItems(true).ToList();
            ListUtil.InitializeListView(mlvAddItemSearch, Items);
        }

        private void txtAddItemName_OnValueChanged(object sender, EventArgs e)
        {
            txtAddItemName.Text = txtAddItemName.MaximumLength(50);
            if (!TextUtil.IsNull(txtAddItemName.Text))
            {
                btnAddItem.Enabled = true;
            }
            else
            {
                btnAddItem.Enabled = false;
            }
        }

        private void txtAddItemSearch_OnValueChanged(object sender, EventArgs e)
        {
            txtAddItemSearch.Text = txtAddItemSearch.MaximumLength(200);
            dropAddItemSearchBy_onItemSelected(this, e);
        }

        /* Manage Item > Search Item */
        private bool withPassives = true;
        private void cboxItemSearchIsActive_OnChange(object sender, EventArgs e)
        {
            if (cboxItemSearchIsActive.Checked)
                withPassives = true;
            else
                withPassives = false;

            dropAddItemSearchBy_onItemSelected(this, e);
        }

        private void lblSearchItemContainPassives_Click(object sender, EventArgs e)
        {
            if (cboxItemSearchIsActive.Checked)
                cboxItemSearchIsActive.Checked = false;
            else
                cboxItemSearchIsActive.Checked = true;

            cboxItemSearchIsActive_OnChange(this, e);
        }

        private void btnResetItem_Click(object sender, EventArgs e)
        {
            txtAddItemName.Text = "";
            txtAddItemDescription.Text = "";
        }

        // Checks Length of Textbox
        private void txtUpdateStockItemName_OnValueChanged(object sender, EventArgs e)
        {
            txtUpdateStockItemName.Text = txtUpdateStockItemName.MaximumLength(50);
        }

        // Checks Length of Textbox
        private void txtUpdateStockItemDescription_OnValueChanged(object sender, EventArgs e)
        {
            txtUpdateStockItemDescription.Text = txtUpdateStockItemDescription.MaximumLength(200);
        }

        // Checks Length of Textbox
        private void txtUpdateStockCompanyName_OnValueChanged(object sender, EventArgs e)
        {
            txtUpdateStockCompanyName.Text = txtUpdateStockCompanyName.MaximumLength(50);
        }

        // Checks Length of Textbox
        private void txtUpdateStockUnitPrice_OnValueChanged(object sender, EventArgs e)
        {
            txtUpdateStockUnitPrice.Text = txtUpdateStockUnitPrice.MaximumLength(12);
        }

        // Checks Length of Textbox
        private void txtUpdateStockQuantity_OnValueChanged(object sender, EventArgs e)
        {
            txtUpdateStockQuantity.Text = txtUpdateStockQuantity.MaximumLength(5);
        }

        // Checks Length of Textbox
        private void txtAddStockCompanyName_OnValueChanged(object sender, EventArgs e)
        {
            txtAddStockCompanyName.Text = txtAddStockCompanyName.MaximumLength(50);
        }

        // Checks Length of Textbox
        private void txtAddStockUnitPrice_OnValueChanged(object sender, EventArgs e)
        {
            txtAddStockUnitPrice.Text = txtAddStockUnitPrice.MaximumLength(12);
        }

        // Checks Length of Textbox
        private void txtAddStockQuantity_OnValueChanged(object sender, EventArgs e)
        {
            txtAddStockQuantity.Text = txtAddStockQuantity.MaximumLength(5);
        }

        // Checks Length of Textbox
        private void txtUpdateItemName_OnValueChanged(object sender, EventArgs e)
        {
            txtUpdateItemName.Text = txtUpdateItemName.MaximumLength(50);
        }

        // Checks Length of Textbox
        private void txtUpdateItemDescription_OnValueChanged(object sender, EventArgs e)
        {
            txtUpdateItemDescription.Text = txtUpdateItemDescription.MaximumLength(400);
        }

        // Checks Length of Textbox
        private void txtAddItemDescription_OnValueChanged(object sender, EventArgs e)
        {
            txtAddItemDescription.Text = txtAddItemDescription.MaximumLength(400);
        }
    }
}
