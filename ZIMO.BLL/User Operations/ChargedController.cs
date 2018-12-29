using System.Collections.Generic;
using System.Linq;
using ZIMO.BLL.General_Operations;
using ZIMO.BLL.Utils;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.User_Operations
{
    public class ChargedController : UserController, IChargedController
    {
        /// <summary>
        /// Create report by List of users
        /// </summary>
        /// <param name="users">List of users that will reported</param>
        public void CreateReport(IList<User> users)
        {
            foreach (var user in users)
            {
                user.Borrows = ItemController.GetItems(true)
                    .SelectMany(x => x.Borrows.Where(y => y.User_Id.Equals(user.Id))).ToList();
                foreach (var borrow in user.Borrows)
                {
                    borrow.Stock = StockController.GetAllStocks().First(y => y.Id.Equals(borrow.Stock_Id));
                }
            }

            ReportUtil.CreateReport(users);
        }

        /// <summary>
        /// Create report by user
        /// </summary>
        /// <param name="user">User that will reported/param>
        public void CreateReport(User user)
        {
            user.Borrows = ItemController.GetItems(true)
                .SelectMany(x => x.Borrows.Where(y => y.User_Id.Equals(user.Id))).ToList();
            foreach (var borrow in user.Borrows)
            {
                borrow.Stock = StockController.GetAllStocks().First(y => y.Id.Equals(borrow.Stock_Id));
            }

            ReportUtil.CreateReport(user);
        }
    }
}
