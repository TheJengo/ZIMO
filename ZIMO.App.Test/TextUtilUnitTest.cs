using LoremNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZIMO.App.Utils;

namespace ZIMO.App.Test
{
    [TestClass]
    public class TextUtilUnitTest
    {
        [TestMethod]
        public void Valid_IsNullTest()
        {
            Assert.AreEqual(false, TextUtil.IsNull(Lorem.Words(3, true, true)));
            Assert.AreEqual(false, TextUtil.IsNull(Lorem.Number(1,10000).ToString()));
            Assert.AreEqual(false, TextUtil.IsNull(Lorem.Words(5, true, true)));
        }

        [TestMethod]
        public void InValid_IsNullTest()
        {
            Assert.AreEqual(true, TextUtil.IsNull(null));
            Assert.AreEqual(true, TextUtil.IsNull(Lorem.Words(0, true, true)));
        }

        [TestMethod]
        public void Valid_IsDigitTest()
        {
            Assert.AreEqual(true, TextUtil.IsDigit(Lorem.Number(1, 10000).ToString()));
        }

        [TestMethod]
        public void InValid_IsDigitTest()
        {
            Assert.AreEqual(false, TextUtil.IsDigit(null));
            Assert.AreEqual(false, TextUtil.IsDigit(""));
            Assert.AreEqual(false, TextUtil.IsDigit("testVal"));
            Assert.AreEqual(false, TextUtil.IsDigit("a12345"));
        }

        [TestMethod]
        public void Valid_IsEmailTest()
        {
            Assert.AreEqual(true, TextUtil.IsEmail(Lorem.Email()));
        }

        [TestMethod]
        public void InValid_IsEmailTest()
        {
            Assert.AreEqual(false, TextUtil.IsEmail(Lorem.Words(1,true,true)+" "+Lorem.Email()));
        }

        [TestMethod]
        public void Valid_IsMoneyTest()
        {
            Assert.AreEqual(true, TextUtil.IsMoney(Lorem.Number(1,2000).ToString()));
        }

        [TestMethod]
        public void InValid_IsMoneyTest()
        {
            Assert.AreEqual(false, TextUtil.IsMoney(Lorem.Words(0, true, true)));
            Assert.AreEqual(false, TextUtil.IsMoney(Lorem.Words(3, true, true)));
            Assert.AreEqual(false, TextUtil.IsMoney(Lorem.Words(3,true,true)+Lorem.Number(1, 2000)));
        }

        [TestMethod]
        public void Valid_ParseMoneyTest()
        {
            long number = Lorem.Number(1, 2000);
            Assert.AreEqual((decimal)number, TextUtil.ParseMoney(number.ToString()));
        }

        [TestMethod]
        public void InValid_ParseMoneyTest()
        {
            Assert.AreEqual(0, TextUtil.ParseMoney(Lorem.Words(0, true, true)));
            Assert.AreEqual(0, TextUtil.ParseMoney(Lorem.Words(3, true, true)));
        }

        [TestMethod]
        public void Valid_PasswordManagerTest()
        {
            string val = Lorem.Words(1, false, false);
            Assert.AreEqual(val, TextUtil.PasswordFieldManager(val));
            Assert.AreEqual("password", TextUtil.PasswordFieldManager(Lorem.Words(0,true,true)));
        }

    }
}
