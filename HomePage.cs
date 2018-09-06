using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace PomTest1.Pages
{
    class HomePage
    {
        IWebDriver webDriver;

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region objects

        //not available
        #endregion

        #region method

        public string getHomePageTitle()
        {
            string HomePageTitle = webDriver.Title;
            return HomePageTitle;
        }
        #endregion
    }
}
