using System;
using System.Text;
using System.Threading;
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

        private static 
            ThreadLocal<ApplicationManager> app
        = new 
            ThreadLocal<ApplicationManager>();

                                                            
        private ApplicationManager()
        {
            driver = new ChromeDriver();
            baseUrl = "http://localhost";

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseUrl);
            groupHelper = new GroupHelper(this);
        }

        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();

                app.Value = newInstance;
                newInstance.Navigator.GoToHomePage();       
            }

            return app.Value;
        }

        ~ApplicationManager()
        {
            Driver.Quit();
        }

        public IWebDriver Driver { get { return driver; } }
        public LoginHelper Auth { get { return loginHelper; } }
        public NavigationHelper Navigator { get { return navigationHelper; } }
        public GroupHelper Groups { get { return groupHelper; } }
    }
}
