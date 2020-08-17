using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
       [Test,Order(5)]
        public void LoginWithValidCredentials()
        {
            app.Auth.Logout();
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test,Order(6)]
        public void LoginWithInValidCredentials()
        {
            app.Auth.Logout();
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);
            Assert.IsTrue(!app.Auth.IsLoggedIn(account));
        }
        
    }
}
