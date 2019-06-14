using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_CS_Cucumber.pageObjects
{
    public class LoginPage
    {
        IWebDriver driver;

        [FindsBy(How = How.Name, Using = "userName")]
        public IWebElement userNameInput { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement passwordInput { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement loginBtn { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void login(string userName, string password)
        {
            userNameInput.SendKeys(userName);
            passwordInput.SendKeys(password);
            loginBtn.Click();
        }
    }
}
