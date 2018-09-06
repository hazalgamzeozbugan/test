using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace PomTest1.Pages
{
    class SearchPage
    {
        IWebDriver webDriver;

        public SearchPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region objects

        private IWebElement SearchTextBox
        {
            get
            {

                return webDriver.FindElement(By.Id("searchData"));
            }
        }


        private IWebElement SearchBtn
        {
            get
            {
                return webDriver.FindElement(By.ClassName("searchBtn"));
            }
        }


        #endregion

        #region methods

        public string LoginIntoAccount(string username, string password)
        {
            SearchTextBox.SendKeys("samsung");
            string SearchPageTitle = webDriver.Title;
            SearchBtn.Click();
            return SearchPageTitle;
           

        }

        #endregion

    }
}

