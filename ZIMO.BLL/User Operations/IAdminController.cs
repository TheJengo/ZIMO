using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.User_Operations
{
    public interface IAdminController : ISalesController
    {
        // Admin Permissions
        /// <summary>
        /// This method will update user info with the state you declared.
        /// </summary>
        /// <param name="user">Updated User Object</param>
        /// <param name="entityState">Users new status</param>
        void ManageUser(User user, EntityState entityState);

        /// <summary>
        /// This method will update deparment info with the state you declared.
        /// </summary>
        /// <param name="department">Updated Department Object</param>
        /// <param name="entityState">Departments new status</param>
        void ManageDepartment(Department department, EntityState entityState);
    }
}
