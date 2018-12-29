using System.Linq;
using ZIMO.BLL.General_Operations;
using ZIMO.BLL.Utils;
using ZIMO.DAL.Abstractions;
using ZIMO.DAL.Concretes;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.User_Operations
{
    public class AdminController : SalesController, IAdminController
    {
        /// <summary>
        /// This method will update user info with the state you declared.
        /// </summary>
        /// <param name="user">Updated User Object</param>
        /// <param name="entityState">Users new status</param>
        public void ManageUser(User user, EntityState entityState)
        {
            IUserRepository userRepository = new UserRepository();
            if (entityState == EntityState.Deleted)
            {
                user.EntityState = EntityState.Modified;
                user.IsActive = false;
                userRepository.Update(user);
            }
            else
            {
                user.EntityState = entityState;
                if(!user.Password.StartsWith("$2a$"))
                    user.Password = CryptoUtil.HashPassword(user.Password);

                if (entityState == EntityState.Modified)
                {
                    if (user.Department.Id != GetDepartments().FirstOrDefault(x => x.Id.Equals(user.Department_Id)).Id)
                    {
                        user.Department = GetDepartments().FirstOrDefault(x => x.Id.Equals(user.Department_Id));
                    }

                    if (user.Role.Id != GetRoles().FirstOrDefault(x => x.Id.Equals(user.Role_Id)).Id)
                    {
                        user.Role = GetRoles().FirstOrDefault(x => x.Id.Equals(user.Role_Id));
                    }
                        user.Employee.EntityState = entityState;
                }

                userRepository.Update(user);

            }
        }

        /// <summary>
        /// This method will update deparment info with the state you declared.
        /// </summary>
        /// <param name="department">Updated Department Object</param>
        /// <param name="entityState">Departments new status</param>
        public void ManageDepartment(Department department, EntityState entityState)
        {
            DepartmentController.ManageDepartment(department, entityState);
        }
        
    }
}
