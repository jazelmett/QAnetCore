using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        public IWebDriver driver;
        public string baseUrl;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;

        public ApplicationManager()
        {
            driver = new ChromeDriver();
            baseUrl = "http://localhost";

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseUrl);
            groupHelper = new GroupHelper(this);
        }

        public IWebDriver Driver { get { return driver; } }

        public void Stop()
        {
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
            }
        }

        public LoginHelper Auth { get { return loginHelper; } }
        public NavigationHelper Navigator { get { return navigationHelper; } }
        public GroupHelper Groups { get { return groupHelper; } }
    }
}
