using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_CS_Cucumber.pageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public IWebElement userNameInput => driver.FindElement(By.Name("userName"));

        public IWebElement passwordInput => driver.FindElement(By.Name("password"));

        public IWebElement loginBtn => driver.FindElement(By.Name("login"));

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
