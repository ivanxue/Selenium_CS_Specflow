using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_CS_Cucumber.pageObjects
{
    public class ConfirmationPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*/tbody/tr[7]/td/table/tbody/tr/td[2]/a")]
        public IWebElement backToHomeBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*/tbody/tr[7]/td/table/tbody/tr/td[3]/a")]
        public IWebElement logoutBtn { get; set; }

        public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ReviewFlight()
        {
            backToHomeBtn.Click();

        }
    }
}
