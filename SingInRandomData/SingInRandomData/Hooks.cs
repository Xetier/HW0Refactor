using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInRandomData
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
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("logs\\myapp.txt", rollingInterval: RollingInterval.Day).CreateLogger();
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
