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
    internal class BorrowController
    {
        public static IList<Borrow> GetBorrows(bool isReturned)
        {
            IBorrowRepository borrowRepository = new BorrowRepository();
            return borrowRepository.GetAll(x=>x.IsReturn.Equals(isReturned)).Select(x=>x = borrowRepository.GetSingle(y=>y.Id.Equals(x.Id))).ToList();
        }

        public static Borrow DoesAlreadyEnrolledBySameUser(int userId, int stockId)
        {
            IBorrowRepository borrowRepository = new BorrowRepository();
            Borrow borrow = borrowRepository.GetSingle(x => x.User_Id.Equals(userId) && x.Stock_Id.Equals(stockId),
                x => x.Item,
                x => x.Stock, x => x.User);
            return borrow != null ? borrow : null;
        }

        public static void ManageBorrow(Borrow borrow, EntityState entityState)
        {
            IBorrowRepository borrowRepository = new BorrowRepository();
            borrow.EntityState = entityState;
            if (borrow.Quantity == 0 && entityState == EntityState.Modified)
            {
                borrow.IsReturn = true;
                borrow.ReturnTime = DateTime.Now;
            }
            borrowRepository.Update(borrow);
        }
    }
}
