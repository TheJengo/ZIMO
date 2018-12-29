     using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ZIMO.DAL.Abstractions;
using ZIMO.DAL.Concretes;
using ZIMO.Entities.Concretes;
using ZIMO.Entities.Abstractions;

namespace ZIMO.BLL.General_Operations
{
    internal class ItemController
    {
        public static IList<Item> GetItems(bool withGarbage)
        {
            IItemRepository itemRepository = new ItemRepository();
            return withGarbage
                ? itemRepository.GetAll().Select(x => x = itemRepository.GetSingle(y => y.Id.Equals(x.Id), y => y.Stocks, y =>y.Borrows,y=>y.Garbages))
                    .ToList()
                : itemRepository.GetList(x => x.IsActive == !withGarbage).Select(x => x = itemRepository.GetSingle(y => y.Id.Equals(x.Id), y=>y.Stocks, y => y.Borrows, y => y.Garbages))
                    .ToList();
        }

        public static void ManageItem(Item item, EntityState entityState)
        {
            IItemRepository itemRepository = new ItemRepository();
            if (entityState == EntityState.Added)
            {
                item.EntityState = EntityState.Added;
                itemRepository.Add(item);
            }
            else
            {
                item.EntityState = entityState;
                if (entityState == EntityState.Modified)
                    item.IsActive = true;
                if (entityState == EntityState.Deleted)
                {
                    item.IsActive = false;
                    item.EntityState = EntityState.Modified;
                }
                
                itemRepository.Update(item);
            }
        }

        public static void BorrowItem(Item item, Stock stock, User user, int quantity)
        {
            // item operations
            if (stock != null) stock.UpdatedAt = DateTime.Now;
            stock.EntityState = EntityState.Modified;

            // borrowing operations
            Borrow borrow = BorrowController.DoesAlreadyEnrolledBySameUser(user.Id,stock.Id);
            if (borrow != null)
            {
                borrow = item.Borrows.First(x => x.Id.Equals(borrow.Id));
                stock.Quantity += borrow.Quantity;
                borrow.Quantity += quantity;
                stock.Quantity -= borrow.Quantity;
                borrow.BorrowTime = DateTime.Now;
                borrow.ReturnTime = null;
                borrow.IsReturn = false;
                borrow.EntityState = EntityState.Modified;
            }
            else
            {
                borrow = new Borrow()
                {
                    User = user,
                    User_Id = user.Id,
                    BorrowTime = DateTime.Now,
                    IsReturn = false,
                    Item_Id = item.Id,
                    Stock_Id = stock.Id,
                    Quantity = quantity,
                    EntityState = EntityState.Added
                };
                stock.Quantity -= borrow.Quantity;
                BorrowController.ManageBorrow(borrow, borrow.EntityState);
            }
            StockController.ManageStock(stock, EntityState.Modified);
            ManageItem(item,item.EntityState);
        }

        public static void RefundItem(Item item, Stock stock, User user, int quantity)
        {
            // item operations
            if (stock != null) stock.UpdatedAt = DateTime.Now;
            stock.EntityState = EntityState.Modified;

            // borrowing operations
            Borrow borrow = BorrowController.DoesAlreadyEnrolledBySameUser(user.Id, stock.Id);
            if (borrow != null)
            {
                borrow = item.Borrows.First(x => x.Id.Equals(borrow.Id));
                borrow.Quantity -= quantity;
                stock.Quantity += quantity;
                if (borrow.Quantity == 0)
                {
                    borrow.IsReturn = true;
                    borrow.ReturnTime = DateTime.Now;
                }
                borrow.EntityState = EntityState.Modified;
            }
            StockController.ManageStock(stock, EntityState.Modified);
            ManageItem(item, item.EntityState);
        }
    }
}
