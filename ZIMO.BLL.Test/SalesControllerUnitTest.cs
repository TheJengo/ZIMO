using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZIMO.BLL.Login_Operations;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.Test
{
    [TestClass]
    public class SalesControllerUnitTest
    {
        [TestMethod]
        public void AddStock()
        {
            ISalesController userController = new SalesController();
            Stock stock = new Stock()
            {
                Item_Id = 1,
                UnitPrice = 10,
                TotalPrice = 20,
                Quantity = 2,
                CreatedAt = DateTime.Now,
                CompanyName = "Lojitech",
                EntityState = EntityState.Added
            };
            userController.ManageStock(stock,stock.EntityState);
            Assert.AreNotEqual(null, userController.GetItems(true).FirstOrDefault(x=>x.Id.Equals(stock.Item_Id)).Stocks.FirstOrDefault(x=>x.Id.Equals(stock.Id)));
            userController.ManageStock(stock,EntityState.Deleted);
        }

        [TestMethod]
        public void AddItem()
        {
            ISalesController userController = new SalesController();
            Item item = new Item()
            {
                Name = "Monitör",
                Description = "Bilgisayar içerisindeki 0-1'leri anlamlı görüntülere çevirip gösteren aygıt.",
                IsActive = true,
                EntityState = EntityState.Added
            };
            userController.ManageItem(item, item.EntityState);
            Assert.AreNotEqual(null, userController.GetItems(true).FirstOrDefault(x => x.Id.Equals(item.Id)));
            userController.ManageItem(item,EntityState.Deleted);
        }

        [TestMethod]
        public void RefundItem()
        {
            ISalesController userController = new SalesController();
            User user = userController.GetAllUsers(true).FirstOrDefault(x => x.Id.Equals(1));
            Stock stock;
            IList<Borrow> Borrows = user.Borrows.ToList();
            int quantity;
            if (Borrows != null && Borrows.Count > 0)
            {
                Borrow borrow = Borrows.ElementAt(0);
                Item item = userController.GetItems(true).FirstOrDefault(x => x.Id.Equals(borrow.Item_Id));
                stock = item.Stocks.FirstOrDefault(x => x.Id.Equals(borrow.Stock_Id));
                quantity = Convert.ToInt32(stock.Quantity);
                userController.RefundItem(item,stock,user,1);
                Assert.AreEqual(quantity+1,stock.Quantity);
            }
            else
            {
                Assert.Fail("Null exception");
            }
        }

        [TestMethod]
        public void BorrowItem()
        {
            ISalesController userController = new SalesController();
            User user = userController.GetAllUsers(true).FirstOrDefault(x => x.Id.Equals(1));
            Stock stock;
            IList<Borrow> Borrows = user.Borrows.ToList();
            int quantity;
            if (Borrows != null && Borrows.Count > 0)
            {
                Borrow borrow = Borrows.ElementAt(0);
                Item item = userController.GetItems(true).FirstOrDefault(x => x.Id.Equals(borrow.Item_Id));
                stock = item.Stocks.FirstOrDefault(x => x.Id.Equals(borrow.Stock_Id));
                quantity = Convert.ToInt32(stock.Quantity);
                userController.ChargeItem(item, stock, user, 1);
                Assert.AreEqual(quantity - 1, stock.Quantity);
            }
            else
            {
                Assert.Fail("Null exception");
            }
        }

        [TestMethod]
        public void SendToGarbageFromBorrow()
        {
            ISalesController userController = new SalesController();
            User user = userController.GetAllUsers(true).FirstOrDefault(x => x.Id.Equals(1));
            IList<Borrow> Borrows = user.Borrows.ToList();
            int quantity;
            if (Borrows != null && Borrows.Count > 0)
            {
                Borrow borrow = Borrows.ElementAt(0);
                quantity = Convert.ToInt32(borrow.Quantity);
                userController.AddGarbage(borrow, 1);
                Assert.AreEqual(quantity - 1, borrow.Quantity);
            }
            else
            {
                Assert.Fail("Null exception");
            }
        }

        [TestMethod]
        public void SendToGarbageFromStock()
        {
            ISalesController userController = new SalesController();
            IList<Stock> Stocks = userController.GetItems(true).FirstOrDefault(x => x.Id.Equals(1)).Stocks.ToList();
            int quantity;
            if (Stocks != null && Stocks.Count > 0)
            {
                Stock stock = Stocks.ElementAt(0);
                quantity = Convert.ToInt32(stock.Quantity);
                userController.AddGarbage(stock, 1);
                Assert.AreEqual(quantity - 1, stock.Quantity);
            }
            else
            {
                Assert.Fail("Null exception");
            }
        }
    }
}
