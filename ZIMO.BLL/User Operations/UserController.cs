using System.Collections.Generic;
using System.Linq;
using ZIMO.BLL.General_Operations;
using ZIMO.BLL.Utils;
using ZIMO.DAL.Abstractions;
using ZIMO.DAL.Concretes;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.User_Operations
{
    public class UserController : IUserController
    {
        /// <summary>
        /// Singleton object of active user.
        /// </summary>
        internal static User activeUser { get; set; }

        /// <summary>
        /// Gets All Users depended on passive or not.
        /// </summary>
        /// <param name="withPassives"></param>
        /// <returns>IList User</returns>
        public IList<User> GetAllUsers(bool withPassives)
        {
            IUserRepository userRepository = new UserRepository();
            return withPassives ?
                userRepository.GetAll().Select(x => x = userRepository.GetSingle(y => y.Id.Equals(x.Id), y => y.Department, y => y.Borrows, y => y.Role, y => y.Employee)).ToList() :
            userRepository.GetList(x => x.IsActive).Select(x => x = userRepository.GetSingle(y => y.Id.Equals(x.Id), y => y.Department, y => y.Borrows, y => y.Role, y => y.Employee)).ToList();
        }

        /// <summary>
        /// Allows to GetUser info from other projects.
        /// </summary>
        /// <returns>Active User</returns>
        public Entities.Concretes.User GetUser()
        {
            return activeUser;
        }

        /// <summary>
        /// Updates user infos itself.
        /// </summary>
        /// <param name="user"></param>
        public void UpdateUser(User user)
        {
            activeUser = user;
            activeUser.EntityState = EntityState.Modified;
            IUserRepository userRepository = new UserRepository();
            if (activeUser.Department == null || activeUser.Role == null)
            {
                activeUser.Department = DepartmentController.GetDepartments().First(x => x.Id.Equals(activeUser.Department_Id));
                activeUser.Role = RoleController.GetRoles().First(x => x.Id.Equals(activeUser.Role_Id));
            }
            activeUser.Password = CryptoUtil.HashPassword(user.Password);

            activeUser.Employee.EntityState = activeUser.EntityState;

            userRepository.Update(activeUser);
        }
        // Gets Items With Info
        public IList<Item> GetItems(bool withGarbage)
        {
            return ItemController.GetItems(withGarbage);
        }

        // Gets All Departments
        public IList<Department> GetDepartments()
        {
            return DepartmentController.GetDepartments();
        }

        // Gets All Roles
        public IList<Role> GetRoles()
        {
            return RoleController.GetRoles();
        }
    }
}
