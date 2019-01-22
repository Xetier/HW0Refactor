using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        [Step("Click to button SingIn ")]
        public void ClickToButtonSingIn()
        {
            _driver.FindElement(By.ClassName("login")).Click();
        }

        [Step("I wait <seconds> seconds")]
        public void WaitFor(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        [Step("Fill email with <email>")]
        public void FillEmail(string email)
        {
            _driver.FindElement(By.Id("email")).Clear();
            _driver.FindElement(By.Id("email")).SendKeys(email);
        }

        [Step("Fill password with <pswrd>")]
        public void FillPassword(string pswrd)
        {
            _driver.FindElement(By.Id("passwd")).Clear();
            _driver.FindElement(By.Id("passwd")).SendKeys(pswrd);
        }

        [Step("Click Sign in button")]
        public void ClickSignIn()
        {
            _driver.FindElement(By.Id("SubmitLogin")).Click();
        }

        [Step("Check proper username is shown in the header with <expectedT>")]
        public void CheckProperUsername(string expectedT)
        {
            _driver.FindElement(By.ClassName("account")).Text.Should().Be(expectedT);
        }

        [Step("Check my account page contains <urlSubString>")]
        public void CheckMyAccountPage(string urlSubString)
        {
            _driver.Url.Should().Contain(urlSubString);
        }
        [Step("Check Log out action is available showing <expectedT>")]
        public void CheckLogOut(string expectedT)
        {
            _driver.FindElement(By.ClassName("logout")).Text.Should().Be(expectedT);
            TakeScreenshot();
        }

        public void TakeScreenshot()
        {
            Console.WriteLine("TAKE SCREENSHOT");
        }
    }
}
