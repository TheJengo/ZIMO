using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIMO.BLL.Login_Operations
{
    public interface ILoginController
    {
        /* Login Operations */
        /// <summary>
        /// Login User In To The Programme
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        bool LoginUser(string username, string password);

        /// <summary>
        /// Returns login(permission) type information of user
        /// </summary>
        /// <returns>0 - No Permission, 1 - System Admin, 2 - Sales Manager, 3 - Charged Employee</returns>
        int GetLoginType();

        /// <summary>
        /// Logouts Logged user from the controller
        /// </summary>
        void LogoutUser();
    }
}
