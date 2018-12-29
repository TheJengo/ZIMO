using System.Collections.Generic;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.User_Operations
{
    public interface IUserController
    {
        /// <summary>
        /// Gets All Users depended on passive or not.
        /// </summary>
        /// <param name="withPassives"></param>
        /// <returns>IList User</returns>
        IList<User> GetAllUsers(bool withPassives);

        /// <summary>
        /// Allows to GetUser info from other projects.
        /// </summary>
        /// <returns>Active User</returns>
        User GetUser();

        /// <summary>
        /// Updates user infos itself.
        /// </summary>
        /// <param name="user"></param>
        void UpdateUser(User user);

        IList<Item> GetItems(bool withGarbage);

        IList<Department> GetDepartments();

        IList<Role> GetRoles();
    }
}
