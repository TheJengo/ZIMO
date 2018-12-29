using System;
using LoremNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZIMO.BLL.Login_Operations;

namespace ZIMO.BLL.Test
{
    [TestClass]
    public class LoginControllerUnitTest
    {
        [TestMethod]
        public void Valid_Login()
        {
            ILoginController loginController = new LoginController();
            Assert.AreEqual(true, loginController.LoginUser("cengiz@zimo.com","1234"));
            loginController.LogoutUser();
        }

        [TestMethod]
        public void InValid_Login()
        {
            ILoginController loginController = new LoginController();
            Assert.AreEqual(false, loginController.LoginUser("cengiz@zimo.com", "12345"));
            Assert.AreEqual(false, loginController.LoginUser("cengiz1@zimo.com", "1234"));
            Assert.AreEqual(false, loginController.LoginUser("cengiz1@zimo.com", "12345"));
            Assert.AreEqual(false, loginController.LoginUser("", ""));
        }

        [TestMethod]
        public void Valid_LoginType()
        {
            ILoginController loginController = new LoginController();
            Assert.AreEqual(true, loginController.LoginUser("cengiz@zimo.com", "1234"));
            Assert.AreEqual(1, loginController.GetLoginType());
            loginController.LogoutUser();

            Assert.AreEqual(true, loginController.LoginUser("utku@zimo.com", "1234"));
            Assert.AreEqual(2, loginController.GetLoginType());
            loginController.LogoutUser();

            Assert.AreEqual(true, loginController.LoginUser("onat@zimo.com", "1234"));
            Assert.AreEqual(3, loginController.GetLoginType());
            loginController.LogoutUser();
            
            Assert.AreEqual(false, loginController.LoginUser("hulusi@zimo.com", "1234"));
            Assert.AreEqual(0, loginController.GetLoginType());
            loginController.LogoutUser();
        }

        [TestMethod]
        public void Valid_LogOut()
        {
            ILoginController loginController = new LoginController();
            Assert.AreEqual(true, loginController.LoginUser("cengiz@zimo.com", "1234"));
            loginController.LogoutUser();
            Assert.AreEqual(0, loginController.GetLoginType());
        }
    }
}
