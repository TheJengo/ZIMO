using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIMO.BLL.User_Operations;
using ZIMO.BLL.Utils;
using ZIMO.Entities.Abstractions;
using ZIMO.DAL.Abstractions;
using ZIMO.DAL.Concretes;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.Login_Operations
{
    public class LoginController : ILoginController
    {
        /// <summary>
        /// Login operations happens here with username and password parameters.
        /// If it successful it returns true else false.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True/False</returns>
        public bool LoginUser(string username, string password)
        {
            IUserRepository userRepository = new UserRepository();
            User loginUser = userRepository.GetSingle(x =>
                x.Username.ToLower().Equals(username.ToLower()) && x.IsActive && x.Role.Id != 4,x=>x.Department,x=>x.Borrows, x=>x.Role, x=>x.Employee);
            if (loginUser != null && CryptoUtil.ValidatePassword(password, loginUser.Password))
            {
                UserController.activeUser = loginUser;
                return true;
            }
            // When you want to change ur pass without hashing
            //if (loginUser != null && loginUser.Password.Equals(password))
            //{
            //    UserController.activeUser = loginUser;
            //    return true;
            //}
            return false;
        }

        /// <summary>
        /// Determines what type of user has logged in the system.
        /// Also these type of users who they have permission to use the system.
        /// </summary>
        /// <returns>0,1,2,3</returns>
        public int GetLoginType()
        {
            if(UserController.activeUser != null)
            {
                switch (UserController.activeUser.Role_Id)
                {
                    case 1:
                        return 1; // System Admin
                    case 2:
                        return 2; // Sales Employee
                    case 3:
                        return 3; // Charged Employee
                    default:
                        return 0; // Neither Employee nor System Admin
                }
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Logouts user from the system.
        /// </summary>
        public void LogoutUser()
        {
            UserController.activeUser = null;
        }
    }
}
