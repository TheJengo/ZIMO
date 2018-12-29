using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Utils
{
    public static class ListUtil
    {
        /// <summary>
        /// Initializes DropdownList with the deparment name values
        /// </summary>
        /// <param name="dropdown">DropdownList Object</param>
        /// <param name="departments">Department List</param>
        public static void InitializeDropdownList(Bunifu.Framework.UI.BunifuDropdown dropdown,
            IList<Department> departments)
        {
            dropdown.Clear();
            if (departments != null)
            {
                foreach (var department in departments)
                {
                    dropdown.AddItem(department.Name);
                }

                dropdown.selectedIndex = 0;
            }
        }

        /// <summary>
        /// Initializes DropdownList with the role name values
        /// </summary>
        /// <param name="dropdown">DropdownList Object</param>
        /// <param name="roles">Role List</param>
        public static void InitializeDropdownList(Bunifu.Framework.UI.BunifuDropdown dropdown, IList<Role> roles)
        {
            dropdown.Clear();
            if (roles != null)
            {
                foreach (var role in roles)
                {
                    dropdown.AddItem(role.Name);
                }

                dropdown.selectedIndex = 0;
            }
        }

        /// <summary>
        /// Initializes DropdownList with the item quantities in stock
        /// </summary>
        /// <param name="dropdown">DropdownList Object</param>
        /// <param name="item">Item List</param>
        public static void InitializeDropdownList(Bunifu.Framework.UI.BunifuDropdown dropdown, Stock stock)
        {
            dropdown.Clear();
            if (stock != null)
            {
                for (int i = 0; i <= stock.Quantity; i++)
                {
                    dropdown.AddItem(i.ToString());
                }
            }
        }

        /// <summary>
        /// Initializes ListView details with user properties by user list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="users">User List</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<User> users)
        {
            mlv.Items.Clear();
            int counter = 1;
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(counter++.ToString());
                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.Employee.FirstName);
                item.SubItems.Add(user.Employee.LastName);
                item.SubItems.Add(user.Department.Name);
                item.SubItems.Add(user.Role.Name);
                item.SubItems.Add(user.Borrows.Where(x=>!x.IsReturn).ToList().Count.ToString());
                mlv.Items.Add(item);
            }
        }

        /// <summary>
        /// Initializes ListView details with department properties by departments list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="departments">Department List</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv,
            IList<Department> departments)
        {
            mlv.Items.Clear();
            foreach (var department in departments)
            {
                ListViewItem item = new ListViewItem(department.Id.ToString());
                item.SubItems.Add(department.Name);
                item.SubItems.Add(department.Users.Count.ToString());
                mlv.Items.Add(item);
            }
        }

        /// <summary>
        /// Initializes ListView details with item properties by items list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="items">Item list</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<Item> items)
        {
            mlv.Items.Clear();
            foreach (var item in items)
            {
                ListViewItem listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add(item.Description);
                listItem.SubItems.Add(item.InStock.ToString());
                listItem.SubItems.Add(item.Borroweds.ToString());
                mlv.Items.Add(listItem);
            }
        }

        /// <summary>
        /// Initializes ListView details with stock properties by stocks list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="stocks">Stock List</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<Stock> stocks)
        {
            mlv.Items.Clear();
            foreach (var stock in stocks)
            {
                ListViewItem item = new ListViewItem(stock.CompanyName);
                item.SubItems.Add(stock.Quantity.ToString());
                item.SubItems.Add(stock.CreatedAt.ToString());
                item.SubItems.Add(stock.UpdatedAt.ToString());
                mlv.Items.Add(item);
            }

        }

        /// <summary>
        /// Initializes ListView details with borrow properties by user's borrow list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="borrows">Borrow List</param>
        /// <param name="users">User List</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<Borrow> borrows,
            IList<User> users)
        {
            mlv.Items.Clear();
            int counter = 1;
            foreach (var user in users.Where(x=>x.Borrows.Any(y=>!y.IsReturn)))
            {
                //User user = users.First(x => x.Id.Equals(borrow.User_Id));
                ListViewItem item = new ListViewItem(counter++.ToString());
                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.Employee.FirstName + " " + user.Employee.LastName);
                item.SubItems.Add(user.Department.Name);
                item.SubItems.Add(user.Borrows.Sum(x => x.Quantity).ToString());
                item.SubItems.Add(user.Borrows.Count.ToString());
                mlv.Items.Add(item);
            }
        }

        /// <summary>
        /// Initializes ListView details with stock properties by item's stock list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="stocks">Stock List</param>
        /// <param name="items">Item List</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<Stock> stocks,
            IList<Item> items)
        {
            mlv.Items.Clear();
            foreach (var stock in stocks)
            {
                Item stockItem = items.First(x => x.Id.Equals(stock.Item_Id));
                ListViewItem item = new ListViewItem(stock.Item.Name);
                item.SubItems.Add(stock.Item.Description);
                item.SubItems.Add(stock.CompanyName);
                item.SubItems.Add(stock.UnitPrice.ToString());
                item.SubItems.Add(stock.TotalPrice.ToString());
                item.SubItems.Add(stock.Quantity.ToString());
                item.SubItems.Add(stockItem.Borrows.Sum(x => x.Quantity).ToString());
                item.SubItems.Add(stockItem.Garbages.Sum(x => x.Quantity).ToString());
                mlv.Items.Add(item);
            }
        }

        /// <summary>
        /// Initializes ListView details with borrow properties by item's borrows list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="borrows"></param>
        /// <param name="items"></param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<Borrow> borrows,
            IList<Item> items)
        {
            mlv.Items.Clear();
            int counter = 1;
            foreach (var borrow in borrows)
            {
                Stock stock = items.First(x => x.Id.Equals(borrow.Item_Id)).Stocks
                    .First(x => x.Id.Equals(borrow.Stock_Id));
                ListViewItem item = new ListViewItem(counter++.ToString());
                item.SubItems.Add(stock.Item.Name);
                item.SubItems.Add(stock.CompanyName);
                item.SubItems.Add(borrow.Quantity.ToString());
                item.SubItems.Add(borrow.BorrowTime.ToLongDateString());
                mlv.Items.Add(item);
            }
        }

        /// <summary>
        /// Initializes ListView details with borrow properties by item's borrows list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="borrows">Borrow List</param>
        /// <param name="items">Item List</param>
        /// <param name="quantity">Quantity Of Items</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<Borrow> borrows,
            IList<Item> items, int quantity)
        {
            mlv.Items.Clear();
            int counter = 1;
            foreach (var borrow in borrows)
            {
                Stock stock = items.First(x => x.Id.Equals(borrow.Item_Id)).Stocks
                    .First(x => x.Id.Equals(borrow.Stock_Id));
                for (int i = 0; i < borrow.Quantity; i++)
                {
                    ListViewItem item = new ListViewItem(counter++.ToString());
                    item.SubItems.Add(stock.Item.Name);
                    item.SubItems.Add(stock.CompanyName);
                    mlv.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Initializes ListView details with garbage properties by item's garbages list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="garbages">Garbage List</param>
        /// <param name="items">Item List</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<Garbage> garbages,
            IList<Item> items)
        {
            mlv.Items.Clear();
            int counter = 1;
            Item item;
            Stock stock;
            foreach (var garbage in garbages)
            {
                item = items.First(x => x.Id.Equals(garbage.Item_Id));
                stock = items.SelectMany(x => x.Stocks).First(x => x.Id.Equals(garbage.Stock_Id));
                ListViewItem listViewItem = new ListViewItem(counter++.ToString());
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(stock.CompanyName);
                listViewItem.SubItems.Add(garbage.Quantity.ToString());
                listViewItem.SubItems.Add(garbage.CreatedAt.ToShortDateString());
                mlv.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// Initializes ListView details with file properties by file info list
        /// </summary>
        /// <param name="mlv">ListView Object</param>
        /// <param name="files">File List</param>
        public static void InitializeListView(MaterialSkin.Controls.MaterialListView mlv, IList<FileInfo> files)
        {
            mlv.Items.Clear();
            int counter = 1;
            foreach (var file in files)
            {
                ListViewItem item = new ListViewItem(counter++.ToString());
                item.SubItems.Add(file.Name);
                item.SubItems.Add(file.CreationTime.ToShortDateString()+" "+file.CreationTime.ToShortTimeString());
                item.SubItems.Add(file.LastAccessTime.ToShortDateString() + " " + file.LastAccessTime.ToShortTimeString());
                mlv.Items.Add(item);
            }
        }
    }
}
