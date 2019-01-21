using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Steps
{
    class LogInSteps
    {
        IWebDriver _driver = Hooks.WebDriver;

        [Step("Go to <url>")]
        public void GoToAutomationpractice(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
        }
    }
}
