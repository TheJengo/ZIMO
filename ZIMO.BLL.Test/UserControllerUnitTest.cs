using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZIMO.BLL.Login_Operations;
using ZIMO.BLL.User_Operations;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.Test
{
    [TestClass]
    public class UserControllerUnitTest
    {
        [TestMethod]
        public void GetAllUsers()
        {
            IUserController userController = new UserController();
            Assert.AreNotEqual(null, userController.GetAllUsers(true).ToList());
            Assert.AreNotEqual(null, userController.GetAllUsers(false).ToList());
        }

        [TestMethod]
        public void GetUser()
        {
            IUserController userController = new UserController();
            ILoginController loginController = new LoginController();
            Assert.AreEqual(null, userController.GetUser());
        }
        
        [TestMethod]
        public void GetUser_Coverage()
        {
            IUserController userController = new UserController();
            ILoginController loginController = new LoginController();
            Assert.AreEqual(null, userController.GetUser());
            Assert.AreEqual(true, loginController.LoginUser("cengiz@zimo.com","1234"));
            Assert.AreNotEqual(null, userController.GetUser());
            loginController.LogoutUser();
            Assert.AreEqual(null, userController.GetUser());
        }

        [TestMethod]
        public void GetItems()
        {
            IUserController userController = new UserController();
            Assert.AreNotEqual(null, userController.GetItems(false).ToList());
        }

        [TestMethod]
        public void GetDepartments()
        {
            IUserController userController = new UserController();
            Assert.AreNotEqual(null, userController.GetDepartments().ToList());
        }

        [TestMethod]
        public void GetRoles()
        {
            IUserController userController = new UserController();
            Assert.AreNotEqual(null, userController.GetRoles().ToList());
        }
    }
}
