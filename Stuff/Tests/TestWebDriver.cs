using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stuff.RavenNoSql;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Stuff.Tests
{
    [TestClass]
    public class TestWebDriver
    {
        IWebDriver webDriver;

        [TestInitialize]
        public void SetUp()
        {
            //webDriver = new FirefoxDriver();
            webDriver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application\");
        }

        [TestMethod]
        public void RunUITest()
        {
            webDriver.Navigate().GoToUrl("http://www.ranorex.com");
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until((d) => { return d.Title.Contains("Ranorex"); });
        }

        [TestCleanup]
        public void Teardown()
        {
            webDriver.Quit();
        }
    }
}
