using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SignIn.Steps
{
    class SignInSteps
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

        [Step("Fill email_create with <email>")]
        public void FillEmailCreate(string email)
        {
            _driver.FindElement(By.Id("email_create")).Clear();
            _driver.FindElement(By.Id("email_create")).SendKeys(email);
        }

        [Step("Click on Submit Create")]
        public void ClickOnSubmitCreate()
        {
            _driver.FindElement(By.Id("SubmitCreate")).Click();
        }

        [Step("I wait <seconds> seconds")]
        public void WaitFor(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        [Step("Click on Mr")]
        public void ClickOnMr()
        {
            _driver.FindElements(By.Name("id_gender"))[0].Click();
        }

        [Step("Fill first name in customer_firstname field with <firstName>")]
        public void FillFirstNameField(string firstName)
        {
            _driver.FindElement(By.Id("customer_firstname")).Clear();
            _driver.FindElement(By.Id("customer_firstname")).SendKeys(firstName);
        }

        [Step("Fill last name in customer_lastname field with <lastName>")]
        public void FillLasttNameField(string lastName)
        {
            _driver.FindElement(By.Id("customer_lastname")).Clear();
            _driver.FindElement(By.Id("customer_lastname")).SendKeys(lastName);
        }

        [Step("Fill password in passwd field with <password>")]
        public void FillPasswordField(string password)
        {
            _driver.FindElement(By.Id("passwd")).Clear();
            _driver.FindElement(By.Id("passwd")).SendKeys(password);
        }
        [Step("Pick day <day> in birthday day combobox")]
        public void PickBirthDayDay(string day)
        {
            var cbxBirthDays = _driver.FindElement(By.Id("days"));
            var selectElementBirthDays = new SelectElement(cbxBirthDays);
            selectElementBirthDays.SelectByText(day);
        }

        [Step("Pick month <month> in birthday month combobox")]
        public void PickBirthDayMonth(string month)
        {
            var cbxBirthMonth = _driver.FindElement(By.Id("months"));
            var selectElementBirthMonth = new SelectElement(cbxBirthMonth);
            selectElementBirthMonth.SelectByText(month);
        }

        [Step("Pick year <year> in birthday year combobox")]
        public void PickBirthDayYear(string year)
        {
            var cbxBirthYear = _driver.FindElement(By.Id("years"));
            var selectElementBirthYear = new SelectElement(cbxBirthYear);
            selectElementBirthYear.SelectByText(year);
        }

        [Step("Check Sign up for our newsletter! and Receive special offers from our partners!")]
        public void CheckNewsletterAndSO()
        {
            _driver.FindElement(By.Id("newsletter")).Click();
            _driver.FindElement(By.Id("optin")).Click();
        }

        [Step("Fill Company name in company field with <company>")]
        public void FillCompanyName(string company)
        {
            _driver.FindElement(By.Id("company")).Clear();
            _driver.FindElement(By.Id("company")).SendKeys(company);
        }

        [Step("Fill first address in Address1 field with <address1>")]
        public void FillFirstAddress(string address1)
        {
            _driver.FindElement(By.Id("address1")).Clear();
            _driver.FindElement(By.Id("address1")).SendKeys(address1);
        }

        [Step("Fill second address in Address2 field with <address2>")]
        public void FillSecondtAddress(string address2)
        {
            _driver.FindElement(By.Id("address2")).Clear();
            _driver.FindElement(By.Id("address2")).SendKeys(address2);
        }

        [Step("Fill city in City field with <city>")]
        public void FillCity(string city)
        {
            _driver.FindElement(By.Id("city")).Clear();
            _driver.FindElement(By.Id("city")).SendKeys(city);
        }

        [Step("Pick state <state> in state combobox")]
        public void PickState(string state)
        {
            var cbxState = _driver.FindElement(By.Id("id_state"));
            var selectElementState = new SelectElement(cbxState);
            selectElementState.SelectByText(state);
        }

        [Step("Fill post code in postcode field with <postcode>")]
        public void FillPostCode(string postcode)
        {
            _driver.FindElement(By.Id("postcode")).Clear();
            _driver.FindElement(By.Id("postcode")).SendKeys(postcode);
        }

        [Step("Pick country <country> in country combobox")]
        public void PickCountry(string country)
        {
            var cbxCountry = _driver.FindElement(By.Id("id_country"));
            var selectElementCountry = new SelectElement(cbxCountry);
            selectElementCountry.SelectByText(country);
        }

        [Step("Fill additional information in other field with <additional>")]
        public void FillAdditionalInformation(string additional)
        {
            _driver.FindElement(By.Id("other")).Clear();
            _driver.FindElement(By.Id("other")).SendKeys(additional);
        }

        [Step("Fill phone in phone field with <phone>")]
        public void FillPhone(string phone)
        {
            _driver.FindElement(By.Id("phone")).Clear();
            _driver.FindElement(By.Id("phone")).SendKeys(phone);
        }

        [Step("Fill mobile phone in mobile phone field with <mphone>")]
        public void FillMobilePhone(string mphone)
        {
            _driver.FindElement(By.Id("phone_mobile")).Clear();
            _driver.FindElement(By.Id("phone_mobile")).SendKeys(mphone);
        }

        [Step("Fill Address in alias field with <address>")]
        public void FillAddress(string address)
        {
            _driver.FindElement(By.Id("alias")).Clear();
            _driver.FindElement(By.Id("alias")).SendKeys(address);
        }

        [Step("Click on button Register")]
        public void ClickOnButtonRegister()
        {
            _driver.FindElement(By.Id("submitAccount")).Click();
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
