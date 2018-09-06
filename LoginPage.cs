using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace PomTest1.Pages
{
    class LoginPage
    {
        IWebDriver webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region objects

        private IWebElement LoginSignBtn
        {
            get
            {

                return webDriver.FindElement(By.ClassName("btnSignIn"));
            }
        }

        private IWebElement EmailTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("email"));
            }
        }

        private IWebElement PasswordTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("password"));
            }
        }

        private IWebElement LoginBtn
        {
            get
            {
                return webDriver.FindElement(By.Id("loginButton"));
            }
        }


        #endregion

        #region methods

        public string LoginIntoAccount(string username, string password)
        {
            LoginSignBtn.Click();
            EmailTextBox.SendKeys(username);
            PasswordTextBox.SendKeys(password);
            string LoginPageTitle = webDriver.Title;
            LoginBtn.Click();
            return LoginPageTitle;

        }

        #endregion

    }
}

