using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZIMO.App.Extensions;
using ZIMO.App.Utils;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Concretes;

namespace ZIMO.App.Forms.Sales_Controls
{
    public partial class GarbageControl : UserControl
    {
        private ISalesController userController;
        public GarbageControl()
        {
            InitializeComponent();
        }

        // Set userController informations and start the controller UI
        public void SetAuthorization(ISalesController userController)
        {
            this.userController = userController;
            InitializeDetails();
        }

        private IList<Item> Items;
        private IList<Garbage> Garbages;
        private void InitializeDetails()
        {
            // Fills the listview with lists required
            Items = userController.GetItems(true);
            Garbages = Items.SelectMany(x => x.Garbages).ToList();
            ListUtil.InitializeListView(mlvManageGarbage, Garbages, Items);
        }

        private void dropManageGarbageSearchBy_onItemSelected(object sender, EventArgs e)
        {
            // Set Filter Options Of Items With Selected Parameters
            Items = userController.GetItems(true);
            switch (dropManageGarbageSearchBy.selectedIndex)
            {
                case 1:
                    Garbages = Items.Where(x => x.Stocks.Any(y=>y.CompanyName.ToLower().Contains(txtManageGarbageSearch.Text.ToLower())))
                        .SelectMany(x => x.Garbages).ToList();
                    break;
                default:
                    Garbages = Items.Where(x => x.Name.ToLower().Contains(txtManageGarbageSearch.Text.ToLower()))
                        .SelectMany(x => x.Garbages).ToList();
                    break;
            }

            ListUtil.InitializeListView(mlvManageGarbage, Garbages, Items);
        }

        private void txtManageGarbageSearch_OnValueChanged(object sender, EventArgs e)
        {
            txtManageGarbageSearch.Text = txtManageGarbageSearch.MaximumLength(200);
            dropManageGarbageSearchBy_onItemSelected(this, e);
        }
    }
}
