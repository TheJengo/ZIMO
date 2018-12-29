using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIMO.DAL.Abstractions;
using ZIMO.DAL.Concretes;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.General_Operations
{
    internal class GarbageController
    {
        public static IList<Garbage> GetAllGarbages()
        {
            IGarbageRepository garbageRepository = new GarbageRepository();
            return garbageRepository.GetAll();
        }

        public static void AddGarbageFromBorrow(Borrow borrow, int quantity)
        {
            Garbage garbage = GetAllGarbages().FirstOrDefault(x => x.Item_Id.Equals(borrow.Item_Id) && x.Stock_Id.Equals(borrow.Stock_Id));
            if (garbage != null)
            {
                garbage.Quantity += quantity;
                garbage.EntityState = EntityState.Modified;
            }
            else
            {
                garbage = new Garbage()
                {
                    Item_Id = borrow.Item_Id,
                    Stock_Id =  borrow.Stock_Id,
                    Quantity = quantity,
                    CreatedAt = DateTime.Now,
                    EntityState = EntityState.Added
                };
            }

            borrow.Quantity -= quantity;
            BorrowController.ManageBorrow(borrow,EntityState.Modified);
            ManageGarbage(garbage, garbage.EntityState);
        }

        public static void AddGarbageFromStock(Stock stock, int quantity)
        {
            Garbage garbage = GetAllGarbages().FirstOrDefault(x => x.Item_Id.Equals(stock.Item_Id) && x.Stock_Id.Equals(stock.Id));
            if (garbage != null)
            {
                garbage.Quantity += quantity;
                garbage.EntityState = EntityState.Modified;
            }
            else
            {
                garbage = new Garbage()
                {
                    Item_Id = (int)stock.Item_Id,
                    Stock_Id = stock.Id,
                    Quantity = quantity,
                    CreatedAt = DateTime.Now,
                    EntityState = EntityState.Added
                };
            }

            stock.Quantity -= quantity;
            StockController.ManageStock(stock, EntityState.Modified);
            ManageGarbage(garbage, garbage.EntityState);
        }

        public static void ManageGarbage(Garbage garbage, EntityState entityState)
        {
            IGarbageRepository garbageRepository = new GarbageRepository();
            garbage.EntityState = entityState;
            garbageRepository.Update(garbage);
        }
    }
}
