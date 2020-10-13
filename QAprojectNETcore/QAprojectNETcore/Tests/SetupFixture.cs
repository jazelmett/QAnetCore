using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    [SetUpFixture]
    class SetupFixture 
    {
        public static ApplicationManager app;

        [SetUp]
        public void SetupDriver()
        {
            app = ApplicationManager.GetInstance();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [OneTimeTearDown]
        public void Stop()
        {
            app.driver.Quit();
        }
    }
}
