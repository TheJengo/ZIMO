using System.Collections.Generic;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.User_Operations
{
    public interface ISalesController : IChargedController
    {
        // Sales Permissions

        /// <summary>
        /// Borrowing an item to a user from stock.
        /// </summary>
        /// <param name="item">Item Info - Which object?</param>
        /// <param name="stock">Stock Info - Borrow from?</param>
        /// <param name="user">User Info - Who is borrowing?</param>
        /// <param name="quantity">How many objects will borrowing?</param>
        void ChargeItem(Item item, Stock stock, User user, int quantity);

        /// <summary>
        /// Refunding a borrowed item from user to stock
        /// </summary>
        /// <param name="item">Item Info - Which object?</param>
        /// <param name="stock">Stock Info - Where to refund?</param>
        /// <param name="user">User Info - Who is refunding?</param>
        /// <param name="quantity">How many objects will refund?</param>
        void RefundItem(Item item, Stock stock, User user, int quantity);

        /// <summary>
        /// Adds Stocked Items to Garbage .
        /// </summary>
        /// <param name="stock">Stock Object that has the information of garbages</param>
        /// <param name="quantity">How many objects will send to the garbage</param>
        void AddGarbage(Stock stock, int quantity);

        /// <summary>
        /// Adds Borrowed Items to Garbage. 
        /// </summary>
        /// <param name="borrow">Borrow Object that has the information of garbages</param>
        /// <param name="quantity">How many objects will send to the garbage</param>
        void AddGarbage(Borrow borrow, int quantity);

        /// <summary>
        /// Update Stock info with the state you declared.
        /// </summary>
        /// <param name="stock">Updated Stock Object</param>
        /// <param name="entityState">Stocks new status</param>
        void ManageItem(Item item, EntityState entityState);

        /// <summary>
        /// Update Item info with the state you declared.
        /// </summary>
        /// <param name="item">Updated Item Object</param>
        /// <param name="entityState">Items new status</param>
        void ManageStock(Stock stock, EntityState entityState);
    }
}
