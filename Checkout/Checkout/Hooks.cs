using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Hooks
    {
        const int timeout = 60;
        public static IWebDriver _driver;

        [BeforeSuite]
        public void Initialize()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }

        [AfterSuite]
        public void AfterSuite()
        {
            _driver?.Quit();
        }
        public static IWebDriver WebDriver
        {
            get { return _driver; }
        }
    }
}
