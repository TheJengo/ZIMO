using System.Collections.Generic;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.User_Operations
{
    public interface IChargedController : IUserController
    {
        /* Charged User Permissions */

        /// <summary>
        /// Create report by List of users
        /// </summary>
        /// <param name="users">List of users that will reported</param>
        void CreateReport(IList<User> users);

        /// <summary>
        /// Create report by user
        /// </summary>
        /// <param name="user">User that will reported/param>
        void CreateReport(User user);
    }
}
