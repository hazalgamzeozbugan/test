using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

using PomTest1.Pages;


namespace PomTest1
{
    public class Test
    {
        public static void Main(string[] args)
        {
            public IWebDriver webDriver;

        public Test(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        [SetUp]
        public void InitializeBrowser()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Program Files (x86)\Google\Chrome\Application", "chromedriver.exe");
            webDriver = new ChromeDriver(service);
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Cookies.DeleteAllCookies();
            string link = @"https://www.n11.com/";
            webDriver.Navigate().GoToUrl(link);
        }

        LoginPage ObjLoginPage;
        HomePage ObjHomePage;

        [Test]
        public void TestLogin()
        {
            HomePage ObjHome = new HomePage(webDriver);
            LoginPage ObjLogin = new LoginPage(webDriver);
            SearchPage ObjSearch = new SearchPage(webDriver);
            string loginPageTitle = ObjLogin.LoginIntoAccount("gahazal@hotmail.com", "gaha2018*");
            Assert.AreEqual("n11", loginPageTitle);
            string homePageTitle = ObjHomePage.getHomePageTitle();
            Assert.AreEqual("Box", homePageTitle);


        }

        [TearDown]
        public void Close()
        {
            webDriver.Quit();
        }
    }
   
}


