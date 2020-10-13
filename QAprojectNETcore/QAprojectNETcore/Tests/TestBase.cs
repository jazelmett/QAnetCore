using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Runtime.InteropServices.ComTypes;

namespace WebAddressbookTests
{
  
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupApplicationManager()
        {
            app = new SetupFixture.app;
        }

    }

    

}
